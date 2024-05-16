namespace inventura_hrastnik
{
    partial class Izbriši
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.izbris_btn = new System.Windows.Forms.Button();
            this.nazaj_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "monitor",
            "computer",
            "programska oprema",
            "strojna oprema"});
            this.comboBox1.Location = new System.Drawing.Point(37, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(37, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 500);
            this.listBox1.TabIndex = 1;
            // 
            // izbris_btn
            // 
            this.izbris_btn.Location = new System.Drawing.Point(459, 517);
            this.izbris_btn.Name = "izbris_btn";
            this.izbris_btn.Size = new System.Drawing.Size(160, 68);
            this.izbris_btn.TabIndex = 2;
            this.izbris_btn.Text = "Izbiši";
            this.izbris_btn.UseVisualStyleBackColor = true;
            this.izbris_btn.Click += new System.EventHandler(this.izbris_btn_Click);
            // 
            // nazaj_btn
            // 
            this.nazaj_btn.Location = new System.Drawing.Point(659, 517);
            this.nazaj_btn.Name = "nazaj_btn";
            this.nazaj_btn.Size = new System.Drawing.Size(160, 68);
            this.nazaj_btn.TabIndex = 3;
            this.nazaj_btn.Text = "Nazaj";
            this.nazaj_btn.UseVisualStyleBackColor = true;
            this.nazaj_btn.Click += new System.EventHandler(this.nazaj_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Izbriši
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(903, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazaj_btn);
            this.Controls.Add(this.izbris_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Izbriši";
            this.Text = "Izbriši";
            this.Load += new System.EventHandler(this.Izbriši_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button izbris_btn;
        private System.Windows.Forms.Button nazaj_btn;
        private System.Windows.Forms.Label label1;
    }
}