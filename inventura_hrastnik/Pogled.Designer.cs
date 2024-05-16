namespace inventura_hrastnik
{
    partial class Pogled
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nazaj_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 500);
            this.listBox1.TabIndex = 0;
            // 
            // nazaj_btn
            // 
            this.nazaj_btn.Location = new System.Drawing.Point(623, 516);
            this.nazaj_btn.Name = "nazaj_btn";
            this.nazaj_btn.Size = new System.Drawing.Size(179, 82);
            this.nazaj_btn.TabIndex = 1;
            this.nazaj_btn.Text = "Nazaj";
            this.nazaj_btn.UseVisualStyleBackColor = true;
            this.nazaj_btn.Click += new System.EventHandler(this.nazaj_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "monitor",
            "računlanik",
            "programska oprema",
            "strojna oprema"});
            this.comboBox1.Location = new System.Drawing.Point(477, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pogled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 626);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nazaj_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Pogled";
            this.Text = "Pogled";
            this.Load += new System.EventHandler(this.Pogled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button nazaj_btn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}