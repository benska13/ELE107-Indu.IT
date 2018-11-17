namespace Simulator_GUI
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
            this.btnStartSensor = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.txtInndata = new System.Windows.Forms.TextBox();
            this.txtUtdata = new System.Windows.Forms.TextBox();
            this.txtSensorverdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bwSensor = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnStartSensor
            // 
            this.btnStartSensor.Location = new System.Drawing.Point(12, 224);
            this.btnStartSensor.Name = "btnStartSensor";
            this.btnStartSensor.Size = new System.Drawing.Size(135, 48);
            this.btnStartSensor.TabIndex = 0;
            this.btnStartSensor.Text = "Start";
            this.btnStartSensor.UseVisualStyleBackColor = true;
            this.btnStartSensor.Click += new System.EventHandler(this.btnStartSensor_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(458, 224);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(135, 48);
            this.btnAvslutt.TabIndex = 1;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // txtInndata
            // 
            this.txtInndata.Location = new System.Drawing.Point(12, 25);
            this.txtInndata.Name = "txtInndata";
            this.txtInndata.Size = new System.Drawing.Size(502, 26);
            this.txtInndata.TabIndex = 2;
            this.txtInndata.TextChanged += new System.EventHandler(this.txtInndata_TextChanged);
            // 
            // txtUtdata
            // 
            this.txtUtdata.Location = new System.Drawing.Point(12, 74);
            this.txtUtdata.Name = "txtUtdata";
            this.txtUtdata.ReadOnly = true;
            this.txtUtdata.Size = new System.Drawing.Size(502, 26);
            this.txtUtdata.TabIndex = 3;
            // 
            // txtSensorverdi
            // 
            this.txtSensorverdi.Location = new System.Drawing.Point(12, 180);
            this.txtSensorverdi.Name = "txtSensorverdi";
            this.txtSensorverdi.ReadOnly = true;
            this.txtSensorverdi.Size = new System.Drawing.Size(278, 26);
            this.txtSensorverdi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inndata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Utdata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sensorverdi";
            // 
            // bwSensor
            // 
            this.bwSensor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSensor_DoWork);
            this.bwSensor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSensor_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensorverdi);
            this.Controls.Add(this.txtUtdata);
            this.Controls.Add(this.txtInndata);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnStartSensor);
            this.Name = "Form1";
            this.Text = "Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSensor;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.TextBox txtInndata;
        private System.Windows.Forms.TextBox txtUtdata;
        private System.Windows.Forms.TextBox txtSensorverdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bwSensor;
    }
}

