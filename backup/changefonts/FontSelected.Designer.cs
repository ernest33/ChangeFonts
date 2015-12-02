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
			this.lab_size = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bt_down = new System.Windows.Forms.Button();
			this.bt_up = new System.Windows.Forms.Button();
			this.lab_sample = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lab_fontname);
			this.panel1.Controls.Add(this.lab_what);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(5, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(319, 19);
			this.panel1.TabIndex = 3;
			// 
			// lab_fontname
			// 
			this.lab_fontname.BackColor = System.Drawing.Color.Black;
			this.lab_fontname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lab_fontname.ForeColor = System.Drawing.Color.White;
			this.lab_fontname.Location = new System.Drawing.Point(98, 0);
			this.lab_fontname.Name = "lab_fontname";
			this.lab_fontname.Size = new System.Drawing.Size(221, 19);
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
			this.panel2.Controls.Add(this.lab_size);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(258, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(66, 40);
			this.panel2.TabIndex = 7;
			// 
			// lab_size
			// 
			this.lab_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.lab_size.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lab_size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lab_size.Font = new System.Drawing.Font("Droid Sans Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_size.Location = new System.Drawing.Point(0, 0);
			this.lab_size.Name = "lab_size";
			this.lab_size.Size = new System.Drawing.Size(41, 40);
			this.lab_size.TabIndex = 2;
			this.lab_size.Text = "22";
			this.lab_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gray;
			this.panel3.Controls.Add(this.bt_down);
			this.panel3.Controls.Add(this.bt_up);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(41, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(25, 40);
			this.panel3.TabIndex = 1;
			// 
			// bt_down
			// 
			this.bt_down.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bt_down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bt_down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
			this.bt_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_down.Font = new System.Drawing.Font("Nina", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_down.Location = new System.Drawing.Point(0, 20);
			this.bt_down.Margin = new System.Windows.Forms.Padding(0);
			this.bt_down.Name = "bt_down";
			this.bt_down.Size = new System.Drawing.Size(25, 20);
			this.bt_down.TabIndex = 1;
			this.bt_down.Text = "\\/";
			this.bt_down.UseVisualStyleBackColor = true;
			this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
			// 
			// bt_up
			// 
			this.bt_up.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bt_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
			this.bt_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_up.Font = new System.Drawing.Font("Nina", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_up.Location = new System.Drawing.Point(0, 0);
			this.bt_up.Margin = new System.Windows.Forms.Padding(0);
			this.bt_up.Name = "bt_up";
			this.bt_up.Size = new System.Drawing.Size(25, 20);
			this.bt_up.TabIndex = 0;
			this.bt_up.Text = "/\\";
			this.bt_up.UseVisualStyleBackColor = true;
			this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
			// 
			// lab_sample
			// 
			this.lab_sample.AutoEllipsis = true;
			this.lab_sample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lab_sample.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lab_sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_sample.Location = new System.Drawing.Point(5, 24);
			this.lab_sample.Name = "lab_sample";
			this.lab_sample.Size = new System.Drawing.Size(253, 40);
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
			this.Size = new System.Drawing.Size(329, 69);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FontSelected_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FontSelected_DragEnter);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lab_fontname;
		private System.Windows.Forms.Label lab_what;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lab_size;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button bt_up;
		private System.Windows.Forms.Button bt_down;
		private System.Windows.Forms.Label lab_sample;


	}
}
