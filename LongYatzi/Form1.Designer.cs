using System;

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
            this.hold1 = new System.Windows.Forms.CheckBox();
            this.hold2 = new System.Windows.Forms.CheckBox();
            this.hold3 = new System.Windows.Forms.CheckBox();
            this.hold4 = new System.Windows.Forms.CheckBox();
            this.hold5 = new System.Windows.Forms.CheckBox();
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
            // hold1
            // 
            this.hold1.AutoSize = true;
            this.hold1.Location = new System.Drawing.Point(24, 72);
            this.hold1.Name = "hold1";
            this.hold1.Size = new System.Drawing.Size(15, 14);
            this.hold1.TabIndex = 6;
            this.hold1.UseVisualStyleBackColor = true;
            this.hold1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // hold2
            // 
            this.hold2.AutoSize = true;
            this.hold2.Location = new System.Drawing.Point(62, 72);
            this.hold2.Name = "hold2";
            this.hold2.Size = new System.Drawing.Size(15, 14);
            this.hold2.TabIndex = 7;
            this.hold2.UseVisualStyleBackColor = true;
            // 
            // hold3
            // 
            this.hold3.AutoSize = true;
            this.hold3.Location = new System.Drawing.Point(100, 72);
            this.hold3.Name = "hold3";
            this.hold3.Size = new System.Drawing.Size(15, 14);
            this.hold3.TabIndex = 8;
            this.hold3.UseVisualStyleBackColor = true;
            // 
            // hold4
            // 
            this.hold4.AutoSize = true;
            this.hold4.Location = new System.Drawing.Point(138, 72);
            this.hold4.Name = "hold4";
            this.hold4.Size = new System.Drawing.Size(15, 14);
            this.hold4.TabIndex = 9;
            this.hold4.UseVisualStyleBackColor = true;
            // 
            // hold5
            // 
            this.hold5.AutoSize = true;
            this.hold5.Location = new System.Drawing.Point(176, 72);
            this.hold5.Name = "hold5";
            this.hold5.Size = new System.Drawing.Size(15, 14);
            this.hold5.TabIndex = 10;
            this.hold5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hold5);
            this.Controls.Add(this.hold4);
            this.Controls.Add(this.hold3);
            this.Controls.Add(this.hold2);
            this.Controls.Add(this.hold1);
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

        private void die1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button throw1;
        private System.Windows.Forms.Label die1;
        private System.Windows.Forms.Label die2;
        private System.Windows.Forms.Label die3;
        private System.Windows.Forms.Label die4;
        private System.Windows.Forms.Label die5;
        private System.Windows.Forms.CheckBox hold1;
        private System.Windows.Forms.CheckBox hold2;
        private System.Windows.Forms.CheckBox hold3;
        private System.Windows.Forms.CheckBox hold4;
        private System.Windows.Forms.CheckBox hold5;
    }
}

