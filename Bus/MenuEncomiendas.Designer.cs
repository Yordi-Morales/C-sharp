﻿namespace ProyectoII_Tiquete_bus
{
    partial class MenuEncomiendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label1.Location = new System.Drawing.Point(327, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ecomiendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label2.Location = new System.Drawing.Point(53, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = ". Envios y Recepcion de Encomidas ---->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label3.Location = new System.Drawing.Point(72, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ". Cierre de cajas de Encomidas ---->";
            // 
            // btnCierre
            // 
            this.btnCierre.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.cierre1_png;
            this.btnCierre.Location = new System.Drawing.Point(447, 277);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(136, 88);
            this.btnCierre.TabIndex = 2;
            this.btnCierre.UseVisualStyleBackColor = true;
            // 
            // btnEnvio
            // 
            this.btnEnvio.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.envioecomiendas1;
            this.btnEnvio.Location = new System.Drawing.Point(447, 168);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(136, 88);
            this.btnEnvio.TabIndex = 1;
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.encomiendas2;
            this.pictureBox1.Location = new System.Drawing.Point(142, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuEncomiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.ClientSize = new System.Drawing.Size(873, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnEnvio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuEncomiendas";
            this.Text = "MenuEncomiendas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}