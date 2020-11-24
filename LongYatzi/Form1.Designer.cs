namespace LongYatzi
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
            this.throw1 = new System.Windows.Forms.Button();
            this.die1 = new System.Windows.Forms.Label();
            this.die2 = new System.Windows.Forms.Label();
            this.die3 = new System.Windows.Forms.Label();
            this.die4 = new System.Windows.Forms.Label();
            this.die5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // throw1
            // 
            this.throw1.Location = new System.Drawing.Point(223, 35);
            this.throw1.Name = "throw1";
            this.throw1.Size = new System.Drawing.Size(75, 23);
            this.throw1.TabIndex = 0;
            this.throw1.Text = "Throw";
            this.throw1.UseVisualStyleBackColor = true;
            this.throw1.Click += new System.EventHandler(this.button1_Click);
            // 
            // die1
            // 
            this.die1.AutoSize = true;
            this.die1.Location = new System.Drawing.Point(21, 40);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(32, 13);
            this.die1.TabIndex = 1;
            this.die1.Text = "Die 1";
            this.die1.Click += new System.EventHandler(this.die1_Click);
            // 
            // die2
            // 
            this.die2.AutoSize = true;
            this.die2.Location = new System.Drawing.Point(59, 40);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(32, 13);
            this.die2.TabIndex = 2;
            this.die2.Text = "Die 2";
            // 
            // die3
            // 
            this.die3.AutoSize = true;
            this.die3.Location = new System.Drawing.Point(97, 40);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(32, 13);
            this.die3.TabIndex = 3;
            this.die3.Text = "Die 3";
            // 
            // die4
            // 
            this.die4.AutoSize = true;
            this.die4.Location = new System.Drawing.Point(135, 40);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(32, 13);
            this.die4.TabIndex = 4;
            this.die4.Text = "Die 4";
            // 
            // die5
            // 
            this.die5.AutoSize = true;
            this.die5.Location = new System.Drawing.Point(173, 40);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(32, 13);
            this.die5.TabIndex = 5;
            this.die5.Text = "Die 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.die5);
            this.Controls.Add(this.die4);
            this.Controls.Add(this.die3);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.throw1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button throw1;
        private System.Windows.Forms.Label die1;
        private System.Windows.Forms.Label die2;
        private System.Windows.Forms.Label die3;
        private System.Windows.Forms.Label die4;
        private System.Windows.Forms.Label die5;
    }
}

