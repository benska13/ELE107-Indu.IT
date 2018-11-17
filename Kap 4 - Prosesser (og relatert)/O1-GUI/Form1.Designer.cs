namespace O1_GUI
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
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnNettleser = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.txtNettleserArgument = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(12, 12);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(123, 23);
            this.btnNotepad.TabIndex = 0;
            this.btnNotepad.Text = "Start Notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnNettleser
            // 
            this.btnNettleser.Location = new System.Drawing.Point(12, 41);
            this.btnNettleser.Name = "btnNettleser";
            this.btnNettleser.Size = new System.Drawing.Size(123, 23);
            this.btnNettleser.TabIndex = 1;
            this.btnNettleser.Text = "Start nettleser";
            this.btnNettleser.UseVisualStyleBackColor = true;
            this.btnNettleser.Click += new System.EventHandler(this.btnNettleser_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(12, 70);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(123, 23);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Start Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(12, 99);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(123, 23);
            this.btnAvslutt.TabIndex = 3;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // txtNettleserArgument
            // 
            this.txtNettleserArgument.Location = new System.Drawing.Point(142, 41);
            this.txtNettleserArgument.Name = "txtNettleserArgument";
            this.txtNettleserArgument.Size = new System.Drawing.Size(326, 20);
            this.txtNettleserArgument.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 136);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNettleserArgument);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnNettleser);
            this.Controls.Add(this.btnNotepad);
            this.Name = "Form1";
            this.Text = "Program-starter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnNettleser;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.TextBox txtNettleserArgument;
        private System.Windows.Forms.TextBox textBox2;
    }
}

