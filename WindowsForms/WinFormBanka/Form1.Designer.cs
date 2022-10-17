namespace WinFormBanka
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
            this.ziraatLabel = new System.Windows.Forms.Label();
            this.garantiLabel = new System.Windows.Forms.Label();
            this.isLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ziraatLabel
            // 
            this.ziraatLabel.AutoSize = true;
            this.ziraatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ziraatLabel.Location = new System.Drawing.Point(69, 84);
            this.ziraatLabel.Name = "ziraatLabel";
            this.ziraatLabel.Size = new System.Drawing.Size(136, 25);
            this.ziraatLabel.TabIndex = 0;
            this.ziraatLabel.Text = "Ziraat Bankası";
            this.ziraatLabel.Click += new System.EventHandler(this.ziraatLabel_Click);
            // 
            // garantiLabel
            // 
            this.garantiLabel.AutoSize = true;
            this.garantiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.garantiLabel.Location = new System.Drawing.Point(69, 161);
            this.garantiLabel.Name = "garantiLabel";
            this.garantiLabel.Size = new System.Drawing.Size(150, 25);
            this.garantiLabel.TabIndex = 0;
            this.garantiLabel.Text = "Garanti Bankası";
            this.garantiLabel.Click += new System.EventHandler(this.garantiLabel_Click);
            // 
            // isLabel
            // 
            this.isLabel.AutoSize = true;
            this.isLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isLabel.Location = new System.Drawing.Point(69, 233);
            this.isLabel.Name = "isLabel";
            this.isLabel.Size = new System.Drawing.Size(102, 25);
            this.isLabel.TabIndex = 0;
            this.isLabel.Text = "İş Bankası";
            this.isLabel.Click += new System.EventHandler(this.isLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isLabel);
            this.Controls.Add(this.garantiLabel);
            this.Controls.Add(this.ziraatLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ziraatLabel;
        private System.Windows.Forms.Label garantiLabel;
        private System.Windows.Forms.Label isLabel;
    }
}

