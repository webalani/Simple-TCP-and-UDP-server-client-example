﻿namespace TCP_Client_GUI
{
    partial class Form1
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnPovezi = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adresa Servera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj Porta Servera:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(147, 13);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(323, 22);
            this.txtAdresa.TabIndex = 2;
            this.txtAdresa.Text = "127.0.0.1";
            this.txtAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(147, 47);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(323, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "3000";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPovezi
            // 
            this.btnPovezi.Location = new System.Drawing.Point(147, 85);
            this.btnPovezi.Name = "btnPovezi";
            this.btnPovezi.Size = new System.Drawing.Size(200, 46);
            this.btnPovezi.TabIndex = 4;
            this.btnPovezi.Text = "Povezi";
            this.btnPovezi.UseVisualStyleBackColor = true;
            this.btnPovezi.Click += new System.EventHandler(this.button1_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(16, 163);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(454, 314);
            this.consoleBox.TabIndex = 5;
            this.consoleBox.Text = "";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(395, 507);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 30);
            this.btnPosalji.TabIndex = 6;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(76, 511);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(313, 22);
            this.txtPoruka.TabIndex = 7;
            this.txtPoruka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPoruka_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Poruka:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.btnPovezi);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnPovezi;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.Label label3;
    }
}

