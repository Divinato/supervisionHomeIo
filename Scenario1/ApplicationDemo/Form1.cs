using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineIO;

namespace ApplicationDemo
{
    public partial class Form1 : Form
    {
        private bool ft1 = false;
        private bool ft2 = false;
        private bool X1 = true;
        private bool X2 = false;
        private bool front = false;
        private bool bpPrec = false;
        private bool bp;

        private bool ft3 = false;
        private bool ft4 = false;
        private bool X3 = false;

        private bool RollerShadesOpen;
        private bool RollerShadesClose;

        private MemoryBit rollerShadesOpen;
        private MemoryBit rollerShadesClose;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conditions initiales
            this.X1 = true;
            this.X2 = false;
            this.X3 = false;
            this.bpPrec = false;
            this.rollerShadesOpen = MemoryMap.Instance.GetBit(3, MemoryType.Output);
            this.rollerShadesClose = MemoryMap.Instance.GetBit(4, MemoryType.Output);
            timer1.Start();
        }

        private void runCycleApi()
        {
            this.bpPrec = this.bp;
            //lecture des entrées
            this.bp = MemoryMap.Instance.GetBit(274, MemoryType.Input).Value;
            this.RollerShadesOpen = MemoryMap.Instance.GetFloat(4, MemoryType.Input).Value == 10;
            this.RollerShadesClose = MemoryMap.Instance.GetFloat(4, MemoryType.Input).Value == 0;

            //calculs des FTs
            this.front = !this.bpPrec && this.bp;

            this.ft1 = this.X1 && this.front && !this.RollerShadesOpen;
            this.ft2 = this.X2 && (( this.front && !this.RollerShadesOpen) || this.RollerShadesOpen);
            this.ft3 = this.X1 && this.front && this.RollerShadesOpen;
            this.ft4 = this.X3 && this.RollerShadesClose;

            //calculs des étapes
            this.X1 = this.ft2 || this.X1 && !this.ft1;
            this.X2 = this.ft1 || this.X2 && !this.ft2;
            this.X3 = this.ft3 || this.X3 && !this.ft4;

            //écriture des sorties
            this.rollerShadesOpen.Value = X2;
            this.rollerShadesClose.Value = X3;

            // Mise à jour de l'interface graphique
            this.labelX1.Text = X1.ToString();
            this.labelX2.Text = X2.ToString();
            this.labelFT1.Text = ft1.ToString();
            this.labelFT2.Text = ft2.ToString();
            this.labelRoller.Text = MemoryMap.Instance.GetFloat(4, MemoryType.Input).Value+" ( Open : " + this.RollerShadesOpen + " | Close : "+ this.RollerShadesClose + " )";
            this.labelBP1.Text = bp.ToString();
            this.labelBP1precedent.Text = bpPrec.ToString();
            this.labelFront.Text = front.ToString();
            this.labelX3.Text = X3.ToString();
            this.labelFT3.Text = ft3.ToString();
            this.labelFT4.Text = ft4.ToString();

            if (this.rollerShadesOpen.Value)
            {
                this.labelUP.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.labelUP.ForeColor = System.Drawing.Color.Red;
            }

            if (this.rollerShadesClose.Value)
            {
                this.labelDown.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.labelDown.ForeColor = System.Drawing.Color.Red;
            }

            //mise à jour HomeIO
            MemoryMap.Instance.Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            runCycleApi();
        }

    }
}
