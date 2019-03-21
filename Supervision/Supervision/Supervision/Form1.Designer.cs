namespace Supervision
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
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDetecteurMouvement = new System.Windows.Forms.Label();
            this.labelCapteurLuminosité = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDétecteurFumée = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDétecteurPorte1 = new System.Windows.Forms.Label();
            this.labelDétecteurPorte2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(-6, -1);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(334, 42);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "xx/xx/xxxx xx:xx:xx";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(-6, 41);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(137, 42);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "xx,x °C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pièce A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mouvement dans la pièce : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Luminosité :";
            // 
            // labelDetecteurMouvement
            // 
            this.labelDetecteurMouvement.AutoSize = true;
            this.labelDetecteurMouvement.Location = new System.Drawing.Point(187, 161);
            this.labelDetecteurMouvement.Name = "labelDetecteurMouvement";
            this.labelDetecteurMouvement.Size = new System.Drawing.Size(35, 13);
            this.labelDetecteurMouvement.TabIndex = 5;
            this.labelDetecteurMouvement.Text = "label4";
            // 
            // labelCapteurLuminosité
            // 
            this.labelCapteurLuminosité.AutoSize = true;
            this.labelCapteurLuminosité.Location = new System.Drawing.Point(187, 184);
            this.labelCapteurLuminosité.Name = "labelCapteurLuminosité";
            this.labelCapteurLuminosité.Size = new System.Drawing.Size(35, 13);
            this.labelCapteurLuminosité.TabIndex = 6;
            this.labelCapteurLuminosité.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Détection de fumée :";
            // 
            // labelDétecteurFumée
            // 
            this.labelDétecteurFumée.AutoSize = true;
            this.labelDétecteurFumée.Location = new System.Drawing.Point(187, 206);
            this.labelDétecteurFumée.Name = "labelDétecteurFumée";
            this.labelDétecteurFumée.Size = new System.Drawing.Size(35, 13);
            this.labelDétecteurFumée.TabIndex = 8;
            this.labelDétecteurFumée.Text = "label5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lumières";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Etat des portes :";
            // 
            // labelDétecteurPorte1
            // 
            this.labelDétecteurPorte1.AutoSize = true;
            this.labelDétecteurPorte1.Location = new System.Drawing.Point(94, 270);
            this.labelDétecteurPorte1.Name = "labelDétecteurPorte1";
            this.labelDétecteurPorte1.Size = new System.Drawing.Size(41, 13);
            this.labelDétecteurPorte1.TabIndex = 11;
            this.labelDétecteurPorte1.Text = "Porte 1";
            // 
            // labelDétecteurPorte2
            // 
            this.labelDétecteurPorte2.AutoSize = true;
            this.labelDétecteurPorte2.Location = new System.Drawing.Point(94, 283);
            this.labelDétecteurPorte2.Name = "labelDétecteurPorte2";
            this.labelDétecteurPorte2.Size = new System.Drawing.Size(41, 13);
            this.labelDétecteurPorte2.TabIndex = 12;
            this.labelDétecteurPorte2.Text = "Porte 2";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(574, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ouvrir volets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(574, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Stopper volets";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(574, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Fermer volets";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelDétecteurPorte2);
            this.Controls.Add(this.labelDétecteurPorte1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDétecteurFumée);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCapteurLuminosité);
            this.Controls.Add(this.labelDetecteurMouvement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelDateTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDetecteurMouvement;
        private System.Windows.Forms.Label labelCapteurLuminosité;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDétecteurFumée;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDétecteurPorte1;
        private System.Windows.Forms.Label labelDétecteurPorte2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

