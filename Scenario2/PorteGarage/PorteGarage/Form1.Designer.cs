namespace PorteGarage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPorteGarageOuverte = new System.Windows.Forms.Label();
            this.labelPorteGarageFermée = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPorteGarageInfrarouge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBP1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelOuverture = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFermeture = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelX0 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX4 = new System.Windows.Forms.Label();
            this.labelX5 = new System.Windows.Forms.Label();
            this.labelFT1 = new System.Windows.Forms.Label();
            this.labelFT2 = new System.Windows.Forms.Label();
            this.labelFT3 = new System.Windows.Forms.Label();
            this.labelFT4 = new System.Windows.Forms.Label();
            this.labelFT5 = new System.Windows.Forms.Label();
            this.labelFT6 = new System.Windows.Forms.Label();
            this.labelFT7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelFTBP1 = new System.Windows.Forms.Label();
            this.labelFTInfrarouge = new System.Windows.Forms.Label();
            this.labelFinTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lancer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porte de garage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ouverte :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fermée :";
            // 
            // labelPorteGarageOuverte
            // 
            this.labelPorteGarageOuverte.AutoSize = true;
            this.labelPorteGarageOuverte.Location = new System.Drawing.Point(142, 147);
            this.labelPorteGarageOuverte.Name = "labelPorteGarageOuverte";
            this.labelPorteGarageOuverte.Size = new System.Drawing.Size(35, 13);
            this.labelPorteGarageOuverte.TabIndex = 4;
            this.labelPorteGarageOuverte.Text = "label4";
            // 
            // labelPorteGarageFermée
            // 
            this.labelPorteGarageFermée.AutoSize = true;
            this.labelPorteGarageFermée.Location = new System.Drawing.Point(142, 170);
            this.labelPorteGarageFermée.Name = "labelPorteGarageFermée";
            this.labelPorteGarageFermée.Size = new System.Drawing.Size(35, 13);
            this.labelPorteGarageFermée.TabIndex = 5;
            this.labelPorteGarageFermée.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Infrarouge :";
            // 
            // labelPorteGarageInfrarouge
            // 
            this.labelPorteGarageInfrarouge.AutoSize = true;
            this.labelPorteGarageInfrarouge.Location = new System.Drawing.Point(142, 192);
            this.labelPorteGarageInfrarouge.Name = "labelPorteGarageInfrarouge";
            this.labelPorteGarageInfrarouge.Size = new System.Drawing.Size(35, 13);
            this.labelPorteGarageInfrarouge.TabIndex = 7;
            this.labelPorteGarageInfrarouge.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "BP1 :";
            // 
            // labelBP1
            // 
            this.labelBP1.AutoSize = true;
            this.labelBP1.Location = new System.Drawing.Point(142, 282);
            this.labelBP1.Name = "labelBP1";
            this.labelBP1.Size = new System.Drawing.Size(35, 13);
            this.labelBP1.TabIndex = 9;
            this.labelBP1.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ouverture :";
            // 
            // labelOuverture
            // 
            this.labelOuverture.AutoSize = true;
            this.labelOuverture.Location = new System.Drawing.Point(142, 216);
            this.labelOuverture.Name = "labelOuverture";
            this.labelOuverture.Size = new System.Drawing.Size(35, 13);
            this.labelOuverture.TabIndex = 11;
            this.labelOuverture.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fermeture :";
            // 
            // labelFermeture
            // 
            this.labelFermeture.AutoSize = true;
            this.labelFermeture.Location = new System.Drawing.Point(142, 238);
            this.labelFermeture.Name = "labelFermeture";
            this.labelFermeture.Size = new System.Drawing.Size(35, 13);
            this.labelFermeture.TabIndex = 13;
            this.labelFermeture.Text = "label7";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grafcet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "X0 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "X1 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "X2 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "X3 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "X4 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "X5 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(569, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "FT6 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(569, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "FT5 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(569, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "FT4 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(569, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "FT3 :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(569, 170);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "FT2 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(569, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "FT1 :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(569, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "FT7 :";
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(434, 146);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(41, 13);
            this.labelX0.TabIndex = 28;
            this.labelX0.Text = "label22";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(434, 170);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(41, 13);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "label23";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(433, 192);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(41, 13);
            this.labelX2.TabIndex = 30;
            this.labelX2.Text = "label24";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(433, 216);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(41, 13);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "label25";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(433, 238);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(41, 13);
            this.labelX4.TabIndex = 32;
            this.labelX4.Text = "label26";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(433, 260);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(41, 13);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "label27";
            // 
            // labelFT1
            // 
            this.labelFT1.AutoSize = true;
            this.labelFT1.Location = new System.Drawing.Point(608, 147);
            this.labelFT1.Name = "labelFT1";
            this.labelFT1.Size = new System.Drawing.Size(41, 13);
            this.labelFT1.TabIndex = 34;
            this.labelFT1.Text = "label28";
            // 
            // labelFT2
            // 
            this.labelFT2.AutoSize = true;
            this.labelFT2.Location = new System.Drawing.Point(607, 170);
            this.labelFT2.Name = "labelFT2";
            this.labelFT2.Size = new System.Drawing.Size(41, 13);
            this.labelFT2.TabIndex = 35;
            this.labelFT2.Text = "label29";
            // 
            // labelFT3
            // 
            this.labelFT3.AutoSize = true;
            this.labelFT3.Location = new System.Drawing.Point(607, 192);
            this.labelFT3.Name = "labelFT3";
            this.labelFT3.Size = new System.Drawing.Size(41, 13);
            this.labelFT3.TabIndex = 36;
            this.labelFT3.Text = "label30";
            // 
            // labelFT4
            // 
            this.labelFT4.AutoSize = true;
            this.labelFT4.Location = new System.Drawing.Point(607, 216);
            this.labelFT4.Name = "labelFT4";
            this.labelFT4.Size = new System.Drawing.Size(41, 13);
            this.labelFT4.TabIndex = 37;
            this.labelFT4.Text = "label31";
            // 
            // labelFT5
            // 
            this.labelFT5.AutoSize = true;
            this.labelFT5.Location = new System.Drawing.Point(607, 238);
            this.labelFT5.Name = "labelFT5";
            this.labelFT5.Size = new System.Drawing.Size(41, 13);
            this.labelFT5.TabIndex = 38;
            this.labelFT5.Text = "label32";
            // 
            // labelFT6
            // 
            this.labelFT6.AutoSize = true;
            this.labelFT6.Location = new System.Drawing.Point(607, 260);
            this.labelFT6.Name = "labelFT6";
            this.labelFT6.Size = new System.Drawing.Size(41, 13);
            this.labelFT6.TabIndex = 39;
            this.labelFT6.Text = "label33";
            // 
            // labelFT7
            // 
            this.labelFT7.AutoSize = true;
            this.labelFT7.Location = new System.Drawing.Point(607, 282);
            this.labelFT7.Name = "labelFT7";
            this.labelFT7.Size = new System.Drawing.Size(41, 13);
            this.labelFT7.TabIndex = 40;
            this.labelFT7.Text = "label34";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 331);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Timer tempo :";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(142, 331);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(41, 13);
            this.labelTimer.TabIndex = 42;
            this.labelTimer.Text = "label23";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(560, 312);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "FTBP1 :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(532, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "FTInfrarouge :";
            // 
            // labelFTBP1
            // 
            this.labelFTBP1.AutoSize = true;
            this.labelFTBP1.Location = new System.Drawing.Point(607, 312);
            this.labelFTBP1.Name = "labelFTBP1";
            this.labelFTBP1.Size = new System.Drawing.Size(41, 13);
            this.labelFTBP1.TabIndex = 45;
            this.labelFTBP1.Text = "label25";
            // 
            // labelFTInfrarouge
            // 
            this.labelFTInfrarouge.AutoSize = true;
            this.labelFTInfrarouge.Location = new System.Drawing.Point(607, 331);
            this.labelFTInfrarouge.Name = "labelFTInfrarouge";
            this.labelFTInfrarouge.Size = new System.Drawing.Size(41, 13);
            this.labelFTInfrarouge.TabIndex = 46;
            this.labelFTInfrarouge.Text = "label26";
            // 
            // labelFinTempo
            // 
            this.labelFinTempo.AutoSize = true;
            this.labelFinTempo.Location = new System.Drawing.Point(142, 355);
            this.labelFinTempo.Name = "labelFinTempo";
            this.labelFinTempo.Size = new System.Drawing.Size(41, 13);
            this.labelFinTempo.TabIndex = 47;
            this.labelFinTempo.Text = "label25";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.labelFinTempo);
            this.Controls.Add(this.labelFTInfrarouge);
            this.Controls.Add(this.labelFTBP1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labelFT7);
            this.Controls.Add(this.labelFT6);
            this.Controls.Add(this.labelFT5);
            this.Controls.Add(this.labelFT4);
            this.Controls.Add(this.labelFT3);
            this.Controls.Add(this.labelFT2);
            this.Controls.Add(this.labelFT1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelFermeture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelOuverture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelBP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPorteGarageInfrarouge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPorteGarageFermée);
            this.Controls.Add(this.labelPorteGarageOuverte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Scenario 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPorteGarageOuverte;
        private System.Windows.Forms.Label labelPorteGarageFermée;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPorteGarageInfrarouge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBP1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelOuverture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFermeture;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX4;
        private System.Windows.Forms.Label labelX5;
        private System.Windows.Forms.Label labelFT1;
        private System.Windows.Forms.Label labelFT2;
        private System.Windows.Forms.Label labelFT3;
        private System.Windows.Forms.Label labelFT4;
        private System.Windows.Forms.Label labelFT5;
        private System.Windows.Forms.Label labelFT6;
        private System.Windows.Forms.Label labelFT7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelFTBP1;
        private System.Windows.Forms.Label labelFTInfrarouge;
        private System.Windows.Forms.Label labelFinTempo;
    }
}

