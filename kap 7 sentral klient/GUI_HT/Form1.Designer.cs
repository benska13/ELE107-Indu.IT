namespace GUI_HT
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
            this.t = new System.Windows.Forms.Label();
            this.txtDataFraServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataTilServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnKobleTil = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.btnKobleFra = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(412, 151);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(80, 13);
            this.t.TabIndex = 23;
            this.t.Text = "Data fra server ";
            // 
            // txtDataFraServer
            // 
            this.txtDataFraServer.Enabled = false;
            this.txtDataFraServer.Location = new System.Drawing.Point(27, 148);
            this.txtDataFraServer.Name = "txtDataFraServer";
            this.txtDataFraServer.Size = new System.Drawing.Size(379, 20);
            this.txtDataFraServer.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data til server";
            // 
            // txtDataTilServer
            // 
            this.txtDataTilServer.Location = new System.Drawing.Point(27, 122);
            this.txtDataTilServer.Name = "txtDataTilServer";
            this.txtDataTilServer.Size = new System.Drawing.Size(379, 20);
            this.txtDataTilServer.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Server Port#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Server IP";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(289, 53);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(102, 20);
            this.txtServerPort.TabIndex = 17;
            this.txtServerPort.Text = "9050";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(27, 53);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(195, 20);
            this.txtServerIP.TabIndex = 16;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // btnKobleTil
            // 
            this.btnKobleTil.Location = new System.Drawing.Point(503, 53);
            this.btnKobleTil.Name = "btnKobleTil";
            this.btnKobleTil.Size = new System.Drawing.Size(79, 35);
            this.btnKobleTil.TabIndex = 15;
            this.btnKobleTil.Text = "Koble til";
            this.btnKobleTil.UseVisualStyleBackColor = true;
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(503, 230);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(79, 35);
            this.btnAvslutt.TabIndex = 14;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            // 
            // btnKobleFra
            // 
            this.btnKobleFra.Location = new System.Drawing.Point(503, 135);
            this.btnKobleFra.Name = "btnKobleFra";
            this.btnKobleFra.Size = new System.Drawing.Size(79, 35);
            this.btnKobleFra.TabIndex = 13;
            this.btnKobleFra.Text = "Koble fra";
            this.btnKobleFra.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(503, 94);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(79, 35);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t);
            this.Controls.Add(this.txtDataFraServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataTilServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnKobleTil);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnKobleFra);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtDataFraServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataTilServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnKobleTil;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.Button btnKobleFra;
        private System.Windows.Forms.Button btnSend;
    }
}

