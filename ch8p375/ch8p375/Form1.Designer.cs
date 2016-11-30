namespace ch8p375
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.draw1 = new System.Windows.Forms.Button();
            this.shuffle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 173);
            this.textBox1.TabIndex = 0;
            // 
            // draw1
            // 
            this.draw1.Location = new System.Drawing.Point(12, 192);
            this.draw1.Name = "draw1";
            this.draw1.Size = new System.Drawing.Size(124, 27);
            this.draw1.TabIndex = 1;
            this.draw1.Text = "Draw a card";
            this.draw1.UseVisualStyleBackColor = true;
            this.draw1.Click += new System.EventHandler(this.draw1_Click);
            // 
            // shuffle
            // 
            this.shuffle.Location = new System.Drawing.Point(148, 192);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(124, 27);
            this.shuffle.TabIndex = 2;
            this.shuffle.Text = "Shuffle";
            this.shuffle.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.draw1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button draw1;
        private System.Windows.Forms.Button shuffle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

