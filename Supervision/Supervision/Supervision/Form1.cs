using EngineIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervision
{
    public partial class Form1 : Form
    {

        private bool switchVolets = false;
        private bool switchVoletsMemory;
        private bool switchVoletsMemoryLast;
        private bool open = true;
        private bool close = true;
        private bool stop = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            runCycleApi();
        }
        private void runCycleApi()
        {

            switchVoletsMemoryLast = switchVoletsMemory;
            switchVoletsMemory = (MemoryMap.Instance.GetFloat(4, MemoryType.Input).Value == 10 || MemoryMap.Instance.GetFloat(4, MemoryType.Input).Value == 0);

            if (switchVolets && (switchVoletsMemory && !switchVoletsMemoryLast))
            {
                stopVolets();
                switchVolets = false;
                stop = false;
            }


            // Mise à jour de l'interface graphique

            this.labelDateTime.Text = MemoryMap.Instance.GetDateTime(0, MemoryType.Input).Value.ToString();
            this.labelTemperature.Text = Math.Round((MemoryMap.Instance.GetFloat(150, MemoryType.Memory).Value - 273.15),1)+" °C";

            this.labelDetecteurMouvement.Text = MemoryMap.Instance.GetBit(15, MemoryType.Input).Value ? "Oui" : "Non";
            this.labelCapteurLuminosité.Text = MemoryMap.Instance.GetBit(16, MemoryType.Input).Value +" - "+MemoryMap.Instance.GetFloat(0, MemoryType.Input).Value;
            this.labelDétecteurFumée.Text = MemoryMap.Instance.GetBit(17, MemoryType.Input).Value ? "Oui" : "Non";

            this.button2.Enabled = open;
            this.button3.Enabled = stop;
            this.button4.Enabled = close;

            this.button1.Text = "Lumières " +(MemoryMap.Instance.GetBit(0, MemoryType.Output).Value ? "ON" : "OFF");

            this.labelDétecteurPorte1.Text = "La porte 1 est "+(MemoryMap.Instance.GetBit(13, MemoryType.Input).Value ? "fermée" : "ouverte") ;
            this.labelDétecteurPorte2.Text = "La porte 2 est "+(MemoryMap.Instance.GetBit(14, MemoryType.Input).Value ? "fermée" : "ouverte") ;

            //mise à jour HomeIO

            MemoryMap.Instance.Update();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryMap.Instance.GetBit(0, MemoryType.Output).Value = !MemoryMap.Instance.GetBit(0, MemoryType.Output).Value;
        }     

        private void button2_Click(object sender, EventArgs e)
        {
            close = true;
            open = false;
            stop = true;
            switchVolets = true;
            runVolets(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            close = false;
            open = true;
            stop = true;
            switchVolets = true;
            runVolets(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            close = true;
            open = true;
            stop = false;
            stopVolets();
        }

        private void runVolets(int start)
        {
            stopVolets();
            for (int i = start; i <= 8; i += 2)
            {
                MemoryMap.Instance.GetBit(i, MemoryType.Output).Value = true;
            }
        }

        private void stopVolets()
        {
            for (int i = 1; i <= 8; i++)
            {
                MemoryMap.Instance.GetBit(i, MemoryType.Output).Value = false;
            }
        }
    }
}
