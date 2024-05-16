namespace inventura_hrastnik
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
            this.pregled_btn = new System.Windows.Forms.Button();
            this.Dodaj_btn = new System.Windows.Forms.Button();
            this.Izris_btn = new System.Windows.Forms.Button();
            this.Uredi_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pregled_btn
            // 
            this.pregled_btn.Location = new System.Drawing.Point(25, 207);
            this.pregled_btn.Name = "pregled_btn";
            this.pregled_btn.Size = new System.Drawing.Size(169, 49);
            this.pregled_btn.TabIndex = 0;
            this.pregled_btn.Text = "Pregled item";
            this.pregled_btn.UseVisualStyleBackColor = true;
            this.pregled_btn.Click += new System.EventHandler(this.pregled_btn_Click);
            // 
            // Dodaj_btn
            // 
            this.Dodaj_btn.Location = new System.Drawing.Point(216, 207);
            this.Dodaj_btn.Name = "Dodaj_btn";
            this.Dodaj_btn.Size = new System.Drawing.Size(169, 49);
            this.Dodaj_btn.TabIndex = 1;
            this.Dodaj_btn.Text = "Dodaj item";
            this.Dodaj_btn.UseVisualStyleBackColor = true;
            this.Dodaj_btn.Click += new System.EventHandler(this.Dodaj_btn_Click);
            // 
            // Izris_btn
            // 
            this.Izris_btn.Location = new System.Drawing.Point(410, 207);
            this.Izris_btn.Name = "Izris_btn";
            this.Izris_btn.Size = new System.Drawing.Size(169, 49);
            this.Izris_btn.TabIndex = 2;
            this.Izris_btn.Text = "Izbris item";
            this.Izris_btn.UseVisualStyleBackColor = true;
            this.Izris_btn.Click += new System.EventHandler(this.Izris_btn_Click);
            // 
            // Uredi_btn
            // 
            this.Uredi_btn.Location = new System.Drawing.Point(607, 207);
            this.Uredi_btn.Name = "Uredi_btn";
            this.Uredi_btn.Size = new System.Drawing.Size(169, 49);
            this.Uredi_btn.TabIndex = 3;
            this.Uredi_btn.Text = "Uredi item";
            this.Uredi_btn.UseVisualStyleBackColor = true;
            this.Uredi_btn.Click += new System.EventHandler(this.Uredi_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "IZBERI DEJAVNOST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uredi_btn);
            this.Controls.Add(this.Izris_btn);
            this.Controls.Add(this.Dodaj_btn);
            this.Controls.Add(this.pregled_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pregled_btn;
        private System.Windows.Forms.Button Dodaj_btn;
        private System.Windows.Forms.Button Izris_btn;
        private System.Windows.Forms.Button Uredi_btn;
        private System.Windows.Forms.Label label1;
    }
}

