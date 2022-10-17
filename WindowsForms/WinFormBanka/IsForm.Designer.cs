namespace WinFormBanka
{
    partial class IsForm
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
            this.KurumsalLabel = new System.Windows.Forms.Label();
            this.BireyselLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KurumsalLabel
            // 
            this.KurumsalLabel.AutoSize = true;
            this.KurumsalLabel.BackColor = System.Drawing.Color.Transparent;
            this.KurumsalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KurumsalLabel.ForeColor = System.Drawing.Color.White;
            this.KurumsalLabel.Location = new System.Drawing.Point(108, 232);
            this.KurumsalLabel.Name = "KurumsalLabel";
            this.KurumsalLabel.Size = new System.Drawing.Size(141, 25);
            this.KurumsalLabel.TabIndex = 0;
            this.KurumsalLabel.Text = "KurumsalKredi";
            this.KurumsalLabel.Click += new System.EventHandler(this.KurumsalLabel_Click);
            // 
            // BireyselLabel
            // 
            this.BireyselLabel.AutoSize = true;
            this.BireyselLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BireyselLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BireyselLabel.Location = new System.Drawing.Point(108, 154);
            this.BireyselLabel.Name = "BireyselLabel";
            this.BireyselLabel.Size = new System.Drawing.Size(132, 25);
            this.BireyselLabel.TabIndex = 1;
            this.BireyselLabel.Text = "Bireysel Kredi";
            this.BireyselLabel.Click += new System.EventHandler(this.BireyselLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çekmek İstediğiniz Kredi Tutarını Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(180, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taksit sayısını giriniz";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(406, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.MaximumSize = new System.Drawing.Size(800, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(406, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Borcu Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(406, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Onayla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BireyselLabel);
            this.Controls.Add(this.KurumsalLabel);
            this.Name = "IsForm";
            this.Text = "IsForm";
            this.Load += new System.EventHandler(this.IsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KurumsalLabel;
        private System.Windows.Forms.Label BireyselLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}