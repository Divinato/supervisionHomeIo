namespace ApplicationDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFT1 = new System.Windows.Forms.Label();
            this.labelFT2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRoller = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBP1 = new System.Windows.Forms.Label();
            this.labelBP1precedent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFront = new System.Windows.Forms.Label();
            this.labelUP = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelFT3 = new System.Windows.Forms.Label();
            this.labelFT4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lancer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1 =";
            // 
            // labelX1
            // 
            this.labelX1.AccessibleName = "";
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(373, 52);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(35, 13);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "X2 =";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(373, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(35, 13);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FT1 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "FT2 =";
            // 
            // labelFT1
            // 
            this.labelFT1.AutoSize = true;
            this.labelFT1.Location = new System.Drawing.Point(373, 96);
            this.labelFT1.Name = "labelFT1";
            this.labelFT1.Size = new System.Drawing.Size(35, 13);
            this.labelFT1.TabIndex = 7;
            this.labelFT1.Text = "label7";
            // 
            // labelFT2
            // 
            this.labelFT2.AutoSize = true;
            this.labelFT2.Location = new System.Drawing.Point(373, 119);
            this.labelFT2.Name = "labelFT2";
            this.labelFT2.Size = new System.Drawing.Size(35, 13);
            this.labelFT2.TabIndex = 8;
            this.labelFT2.Text = "label8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Roller Shades =";
            // 
            // labelRoller
            // 
            this.labelRoller.AutoSize = true;
            this.labelRoller.Location = new System.Drawing.Point(373, 145);
            this.labelRoller.Name = "labelRoller";
            this.labelRoller.Size = new System.Drawing.Size(35, 13);
            this.labelRoller.TabIndex = 10;
            this.labelRoller.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "BP1 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "BP1 precedent =";
            // 
            // labelBP1
            // 
            this.labelBP1.AutoSize = true;
            this.labelBP1.Location = new System.Drawing.Point(373, 191);
            this.labelBP1.Name = "labelBP1";
            this.labelBP1.Size = new System.Drawing.Size(35, 13);
            this.labelBP1.TabIndex = 13;
            this.labelBP1.Text = "label8";
            // 
            // labelBP1precedent
            // 
            this.labelBP1precedent.AutoSize = true;
            this.labelBP1precedent.Location = new System.Drawing.Point(373, 215);
            this.labelBP1precedent.Name = "labelBP1precedent";
            this.labelBP1precedent.Size = new System.Drawing.Size(35, 13);
            this.labelBP1precedent.TabIndex = 14;
            this.labelBP1precedent.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "front =";
            // 
            // labelFront
            // 
            this.labelFront.AutoSize = true;
            this.labelFront.Location = new System.Drawing.Point(373, 239);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(53, 13);
            this.labelFront.TabIndex = 16;
            this.labelFront.Text = "labelFront";
            // 
            // labelUP
            // 
            this.labelUP.AutoSize = true;
            this.labelUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUP.Location = new System.Drawing.Point(94, 180);
            this.labelUP.Name = "labelUP";
            this.labelUP.Size = new System.Drawing.Size(19, 13);
            this.labelUP.TabIndex = 17;
            this.labelUP.Text = "/\\";
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDown.Location = new System.Drawing.Point(130, 180);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(19, 13);
            this.labelDown.TabIndex = 18;
            this.labelDown.Text = "\\/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Store enrouleur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Grafcet initial (ouverture)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 29);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(152, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Grafcet bonus (fermeture)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "X3 =";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(556, 74);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(41, 13);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(515, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "FT3 =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(515, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "FT4 =";
            // 
            // labelFT3
            // 
            this.labelFT3.AutoSize = true;
            this.labelFT3.Location = new System.Drawing.Point(556, 52);
            this.labelFT3.Name = "labelFT3";
            this.labelFT3.Size = new System.Drawing.Size(41, 13);
            this.labelFT3.TabIndex = 26;
            this.labelFT3.Text = "label16";
            // 
            // labelFT4
            // 
            this.labelFT4.AutoSize = true;
            this.labelFT4.Location = new System.Drawing.Point(556, 96);
            this.labelFT4.Name = "labelFT4";
            this.labelFT4.Size = new System.Drawing.Size(41, 13);
            this.labelFT4.TabIndex = 27;
            this.labelFT4.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 26);
            this.label18.TabIndex = 28;
            this.label18.Text = "Ouverture du store enrouleur 2 de la pièce A\r\navec le bouton 1 de la télécomande";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 282);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelFT4);
            this.Controls.Add(this.labelFT3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.labelUP);
            this.Controls.Add(this.labelFront);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelBP1precedent);
            this.Controls.Add(this.labelBP1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRoller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFT2);
            this.Controls.Add(this.labelFT1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Scénario 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFT1;
        private System.Windows.Forms.Label labelFT2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRoller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBP1;
        private System.Windows.Forms.Label labelBP1precedent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFront;
        private System.Windows.Forms.Label labelUP;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelFT3;
        private System.Windows.Forms.Label labelFT4;
        private System.Windows.Forms.Label label18;
    }
}

