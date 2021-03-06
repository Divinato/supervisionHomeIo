﻿using EngineIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorteGarage
{
    public partial class Form1 : Form
    {

        private bool porteGarageOuverte;
        private bool porteGarageFermée;
        private bool porteGarageInfrarouge;
        private bool porteGarageInfrarougePrecedent;
        private bool BP1;
        private bool BP1precedent;

        private MemoryBit porteGarageOuverture;
        private MemoryBit porteGarageFermeture;

        private bool X0;
        private bool X1;
        private bool X2;
        private bool X3;
        private bool X4;
        private bool X5;
        private bool X6;

        private bool FT1;
        private bool FT2;
        private bool FT3;
        private bool FT4;
        private bool FT5;
        private bool FT6;
        private bool FT7;

        //////////////////

        private bool portailOuvert;
        private bool portailFermé;

        private MemoryBit portailOuverture;
        private MemoryBit portailFermeture;

        private bool X11;
        private bool X12;
        private bool X13;
        private bool X14;
        private bool X15;
        private bool X16;

        private bool FT11;
        private bool FT12;
        private bool FT13;
        private bool FT14;
        private bool FT15;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            runCycleApi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.porteGarageOuverture = MemoryMap.Instance.GetBit(72, MemoryType.Output);
            this.porteGarageFermeture = MemoryMap.Instance.GetBit(73, MemoryType.Output);
            this.portailOuverture = MemoryMap.Instance.GetBit(193, MemoryType.Output);
            this.portailFermeture = MemoryMap.Instance.GetBit(194, MemoryType.Output);
            this.X0 = true;
            this.X1 = false;
            this.X2 = false;
            this.X3 = false;
            this.X4 = false;
            this.X5 = false;          
            this.X11 = false;
            this.X12 = false;
            this.X13 = false;
            this.X14 = false;
            this.X15 = false;
            this.X16 = false;
            timer1.Start();         
        }

        private void runCycleApi()
        {

            //////////////////////
            // NON FONCTIONNEL  //
            //////////////////////

            this.BP1precedent = this.BP1;
            this.porteGarageInfrarougePrecedent = this.porteGarageInfrarouge;      

            //lecture des entrées
            this.porteGarageOuverte = MemoryMap.Instance.GetBit(100, MemoryType.Input).Value;
            this.porteGarageFermée = MemoryMap.Instance.GetBit(101, MemoryType.Input).Value;
            this.porteGarageInfrarouge = MemoryMap.Instance.GetBit(102, MemoryType.Input).Value;
            this.BP1 = MemoryMap.Instance.GetBit(274, MemoryType.Input).Value;

            this.portailOuvert = MemoryMap.Instance.GetBit(260, MemoryType.Input).Value;
            this.portailFermé = MemoryMap.Instance.GetBit(261, MemoryType.Input).Value;

            //calculs des FTs
            bool FTBP1 = !this.BP1precedent && this.BP1;
            bool FTInfrarouge = !this.porteGarageInfrarougePrecedent && this.porteGarageInfrarouge;

            this.FT1 = this.X0 && FTBP1; // bouton 1
            this.FT2 = this.X1 && this.porteGarageOuverte; // porte ouvert
            this.FT3 = this.X2; // 1 
            this.FT4 = this.X3 && finTempo; // X3 / 5s
            this.FT5 = this.X4 && this.porteGarageFermée; // porte fermée
            this.FT6 = this.X5; // 1
            this.FT7 = this.X6 && this.X16; // etape d'attente

            this.FT11 = this.X0 && FTBP1; // portail ouvert
            this.FT12 = this.X12 && this.portailOuvert; // 1
            this.FT13 = this.X13 && this.finTempoPortail; // X13 / 1s
            this.FT14 = this.X14 && this.portailFermé; // portail fermé
            this.FT15 = this.X15 && this.X6; // etape d'attente

            //calculs des étapes
            this.X0 = this.FT6 || this.X0 && !this.FT1;

            this.X1 = this.FT1 || this.X1 && !this.FT2;
            this.X2 = this.FT2 || this.X2 && !this.FT3;
            this.X3 = (this.FT3 || this.X3 && !this.FT4) && !this.X1;
            this.X4 = this.FT4 || this.X4 && (!this.FT5 && !this.FT7);
            this.X5 = (this.FT5 && !this.FT7) || this.X5 && !this.FT6;
    
            this.X11 = this.FT1 || this.X11 && !this.FT11;
            this.X12 = this.FT11 || this.X12 && !this.FT12;
            this.X13 = this.FT12 || this.X13 && !this.FT13;
            this.X14 = this.FT13 || this.X14 && !this.FT13;
            this.X15 = this.FT14 || this.X15 && !this.FT15;
            this.X16 = this.FT15;

            if (this.X3)
            {
                if(!this.timer2.Enabled)
                {
                    this.temp = 0;
                    this.finTempo = false;
                    this.timer2.Start();
                }
            }

            if (this.X13)
            {
                if (!this.timer3.Enabled)
                {
                    this.temp2 = 0;
                    this.finTempoPortail = false;
                    this.timer3.Start();
                }
            }

            if (this.X4)
            {
                this.temp = 0;
                this.finTempo = false;
            }

            if (this.X14)
            {
                this.temp2 = 0;
                this.finTempoPortail = false;
            }

            //écriture des sorties
            this.porteGarageOuverture.Value = this.X1;
            this.porteGarageFermeture.Value = this.X4;

            this.portailOuverture.Value = this.X11;
            this.portailFermeture.Value = this.X14;

            // Mise à jour de l'interface graphique
            this.labelPorteGarageFermée.Text = this.porteGarageFermée.ToString();                   if (this.porteGarageFermée) this.labelPorteGarageFermée.ForeColor = Color.Green; else this.labelPorteGarageFermée.ForeColor = Color.Red;
            this.labelPorteGarageOuverte.Text = this.porteGarageOuverte.ToString();                 if (this.porteGarageOuverte) this.labelPorteGarageOuverte.ForeColor = Color.Green; else this.labelPorteGarageOuverte.ForeColor = Color.Red;
            this.labelPorteGarageInfrarouge.Text = this.porteGarageInfrarouge.ToString();           if (this.porteGarageInfrarouge) this.labelPorteGarageInfrarouge.ForeColor = Color.Green; else this.labelPorteGarageInfrarouge.ForeColor = Color.Red;
            this.labelOuverture.Text = this.porteGarageOuverture.Value.ToString();                  if (this.porteGarageOuverture.Value) this.labelOuverture.ForeColor = Color.Green; else this.labelOuverture.ForeColor = Color.Red;
            this.labelFermeture.Text = this.porteGarageFermeture.Value.ToString();                  if (this.porteGarageFermeture.Value) this.labelFermeture.ForeColor = Color.Green; else this.labelFermeture.ForeColor = Color.Red;
            this.labelBP1.Text = this.BP1.ToString();

            this.labelX0.Text = this.X0.ToString(); if (this.X0) this.labelX0.ForeColor = Color.Green; else this.labelX0.ForeColor = Color.Red;
            this.labelX1.Text = this.X1.ToString(); if (this.X1) this.labelX1.ForeColor = Color.Green; else this.labelX1.ForeColor = Color.Red;
            this.labelX2.Text = this.X2.ToString(); if (this.X2) this.labelX2.ForeColor = Color.Green; else this.labelX2.ForeColor = Color.Red;
            this.labelX3.Text = this.X3.ToString(); if (this.X3) this.labelX3.ForeColor = Color.Green; else this.labelX3.ForeColor = Color.Red;
            this.labelX4.Text = this.X4.ToString(); if (this.X4) this.labelX4.ForeColor = Color.Green; else this.labelX4.ForeColor = Color.Red;
            this.labelX5.Text = this.X5.ToString(); if (this.X5) this.labelX5.ForeColor = Color.Green; else this.labelX5.ForeColor = Color.Red;

            this.labelFT1.Text = this.FT1.ToString();
            this.labelFT2.Text = this.FT2.ToString();
            this.labelFT3.Text = this.FT3.ToString();
            this.labelFT4.Text = this.FT4.ToString();
            this.labelFT5.Text = this.FT5.ToString();
            this.labelFT6.Text = this.FT6.ToString();
            this.labelFT7.Text = this.FT7.ToString();

            this.labelFTBP1.Text = FTBP1.ToString();
            this.labelFTInfrarouge.Text = FTInfrarouge.ToString();

            this.labelTimer.Text = this.temp.ToString();
            this.labelFinTempo.Text = this.finTempo.ToString();
            if (this.timer2.Enabled) this.labelTimer.ForeColor = Color.Red; else this.labelTimer.ForeColor = Color.Black;

            //mise à jour HomeIO
            MemoryMap.Instance.Update();
        }

        private int temp = 0;
        private bool finTempo = false;
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (temp > 5)
            {
                this.timer2.Stop();
                this.finTempo = true;
            }
        }

        private int temp2 = 0;
        private bool finTempoPortail = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if(temp2 > 0)
            {
                this.timer3.Stop();
                this.finTempoPortail = true;
            }
            this.temp++;
        }
    }
}
