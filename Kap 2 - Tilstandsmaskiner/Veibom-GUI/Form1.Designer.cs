namespace Veibom_GUI
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
            this.btnKr1 = new System.Windows.Forms.Button();
            this.btnKr5 = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.txtRetur = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPassering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKr1
            // 
            this.btnKr1.Location = new System.Drawing.Point(46, 402);
            this.btnKr1.Name = "btnKr1";
            this.btnKr1.Size = new System.Drawing.Size(86, 47);
            this.btnKr1.TabIndex = 0;
            this.btnKr1.Text = "Kr 1";
            this.btnKr1.UseVisualStyleBackColor = true;
            this.btnKr1.Click += new System.EventHandler(this.btnKr1_Click);
            // 
            // btnKr5
            // 
            this.btnKr5.Location = new System.Drawing.Point(171, 402);
            this.btnKr5.Name = "btnKr5";
            this.btnKr5.Size = new System.Drawing.Size(86, 47);
            this.btnKr5.TabIndex = 1;
            this.btnKr5.Text = "Kr 5";
            this.btnKr5.UseVisualStyleBackColor = true;
            this.btnKr5.Click += new System.EventHandler(this.btnKr5_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(412, 402);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(137, 47);
            this.btnAvslutt.TabIndex = 2;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // txtRetur
            // 
            this.txtRetur.Location = new System.Drawing.Point(46, 341);
            this.txtRetur.Name = "txtRetur";
            this.txtRetur.Size = new System.Drawing.Size(503, 26);
            this.txtRetur.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(46, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 264);
            this.panel1.TabIndex = 4;
            // 
            // btnPassering
            // 
            this.btnPassering.Location = new System.Drawing.Point(292, 402);
            this.btnPassering.Name = "btnPassering";
            this.btnPassering.Size = new System.Drawing.Size(98, 47);
            this.btnPassering.TabIndex = 5;
            this.btnPassering.Text = "Passering";
            this.btnPassering.UseVisualStyleBackColor = true;
            this.btnPassering.Click += new System.EventHandler(this.btnPassering_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 496);
            this.Controls.Add(this.btnPassering);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRetur);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnKr5);
            this.Controls.Add(this.btnKr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKr1;
        private System.Windows.Forms.Button btnKr5;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.TextBox txtRetur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPassering;
    }
}

