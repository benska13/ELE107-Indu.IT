namespace Klient_GUI_HT
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
            this.btnKobleTil = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.btnKobleFra = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataTilServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataFraServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKobleTil
            // 
            this.btnKobleTil.Location = new System.Drawing.Point(600, 12);
            this.btnKobleTil.Name = "btnKobleTil";
            this.btnKobleTil.Size = new System.Drawing.Size(118, 39);
            this.btnKobleTil.TabIndex = 0;
            this.btnKobleTil.Text = "Koble til";
            this.btnKobleTil.UseVisualStyleBackColor = true;
            this.btnKobleTil.Click += new System.EventHandler(this.btnKobleTil_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(600, 73);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 39);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(600, 200);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(118, 39);
            this.btnAvslutt.TabIndex = 2;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // btnKobleFra
            // 
            this.btnKobleFra.Enabled = false;
            this.btnKobleFra.Location = new System.Drawing.Point(600, 136);
            this.btnKobleFra.Name = "btnKobleFra";
            this.btnKobleFra.Size = new System.Drawing.Size(118, 39);
            this.btnKobleFra.TabIndex = 3;
            this.btnKobleFra.Text = "Koble Fra";
            this.btnKobleFra.UseVisualStyleBackColor = true;
            this.btnKobleFra.Click += new System.EventHandler(this.btnKobleFra_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(12, 18);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(226, 26);
            this.txtServerIP.TabIndex = 4;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(375, 18);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 26);
            this.txtServerPort.TabIndex = 5;
            this.txtServerPort.Text = "9050";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server Port#";
            // 
            // txtDataTilServer
            // 
            this.txtDataTilServer.Location = new System.Drawing.Point(12, 79);
            this.txtDataTilServer.Name = "txtDataTilServer";
            this.txtDataTilServer.Size = new System.Drawing.Size(463, 26);
            this.txtDataTilServer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data til server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data fra server";
            // 
            // txtDataFraServer
            // 
            this.txtDataFraServer.Location = new System.Drawing.Point(12, 142);
            this.txtDataFraServer.Name = "txtDataFraServer";
            this.txtDataFraServer.ReadOnly = true;
            this.txtDataFraServer.Size = new System.Drawing.Size(463, 26);
            this.txtDataFraServer.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataFraServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataTilServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnKobleFra);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnKobleTil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKobleTil;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.Button btnKobleFra;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataTilServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataFraServer;
    }
}

