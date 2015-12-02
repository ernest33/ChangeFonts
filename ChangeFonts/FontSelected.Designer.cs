namespace ChangeFonts
{
	partial class FontSelected
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_fontname = new System.Windows.Forms.Label();
            this.lab_what = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lab_sample = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_fontname);
            this.panel1.Controls.Add(this.lab_what);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 19);
            this.panel1.TabIndex = 3;
            // 
            // lab_fontname
            // 
            this.lab_fontname.BackColor = System.Drawing.Color.Black;
            this.lab_fontname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_fontname.ForeColor = System.Drawing.Color.White;
            this.lab_fontname.Location = new System.Drawing.Point(98, 0);
            this.lab_fontname.Name = "lab_fontname";
            this.lab_fontname.Size = new System.Drawing.Size(267, 19);
            this.lab_fontname.TabIndex = 4;
            this.lab_fontname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_what
            // 
            this.lab_what.AutoEllipsis = true;
            this.lab_what.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_what.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_what.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_what.ForeColor = System.Drawing.Color.White;
            this.lab_what.Location = new System.Drawing.Point(0, 0);
            this.lab_what.Name = "lab_what";
            this.lab_what.Size = new System.Drawing.Size(98, 19);
            this.lab_what.TabIndex = 3;
            this.lab_what.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(311, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 31);
            this.panel2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 31);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lab_sample
            // 
            this.lab_sample.AutoEllipsis = true;
            this.lab_sample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_sample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sample.Location = new System.Drawing.Point(5, 24);
            this.lab_sample.Name = "lab_sample";
            this.lab_sample.Size = new System.Drawing.Size(306, 31);
            this.lab_sample.TabIndex = 8;
            this.lab_sample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontSelected
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lab_sample);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FontSelected";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(375, 60);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FontSelected_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FontSelected_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lab_fontname;
		private System.Windows.Forms.Label lab_what;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_sample;
        private System.Windows.Forms.NumericUpDown numericUpDown1;


	}
}
