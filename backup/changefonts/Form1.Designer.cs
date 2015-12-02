namespace ChangeFonts
{
	partial class w_main
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

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_main));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.bt_revert = new System.Windows.Forms.Button();
			this.bt_cancel = new System.Windows.Forms.Button();
			this.bt_valid = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.font_others = new ChangeFonts.FontSelected();
			this.font_icon = new ChangeFonts.FontSelected();
			this.font_smcaption = new ChangeFonts.FontSelected();
			this.font_msg = new ChangeFonts.FontSelected();
			this.font_status = new ChangeFonts.FontSelected();
			this.font_menu = new ChangeFonts.FontSelected();
			this.font_caption = new ChangeFonts.FontSelected();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dlg_flsselect = new System.Windows.Forms.FolderBrowserDialog();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.bt_revert);
			this.panel1.Controls.Add(this.bt_cancel);
			this.panel1.Controls.Add(this.bt_valid);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 537);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(576, 48);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(310, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(27, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "?";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_revert
			// 
			this.bt_revert.Dock = System.Windows.Forms.DockStyle.Left;
			this.bt_revert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bt_revert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
			this.bt_revert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_revert.Location = new System.Drawing.Point(160, 10);
			this.bt_revert.Name = "bt_revert";
			this.bt_revert.Size = new System.Drawing.Size(150, 28);
			this.bt_revert.TabIndex = 2;
			this.bt_revert.Text = "Restaurer";
			this.bt_revert.UseVisualStyleBackColor = true;
			// 
			// bt_cancel
			// 
			this.bt_cancel.Dock = System.Windows.Forms.DockStyle.Left;
			this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
			this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_cancel.Location = new System.Drawing.Point(10, 10);
			this.bt_cancel.Name = "bt_cancel";
			this.bt_cancel.Size = new System.Drawing.Size(150, 28);
			this.bt_cancel.TabIndex = 1;
			this.bt_cancel.Text = "Annuler";
			this.bt_cancel.UseVisualStyleBackColor = true;
			this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
			// 
			// bt_valid
			// 
			this.bt_valid.Dock = System.Windows.Forms.DockStyle.Right;
			this.bt_valid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bt_valid.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
			this.bt_valid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_valid.Location = new System.Drawing.Point(416, 10);
			this.bt_valid.Name = "bt_valid";
			this.bt_valid.Size = new System.Drawing.Size(150, 28);
			this.bt_valid.TabIndex = 0;
			this.bt_valid.Text = "Valider";
			this.bt_valid.UseVisualStyleBackColor = true;
			this.bt_valid.Click += new System.EventHandler(this.bt_valid_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.AllowDrop = true;
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(576, 537);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(568, 508);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Change System Fonts";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.AllowDrop = true;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
			this.splitContainer1.Panel1.Controls.Add(this.listBox1);
			this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(10);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AutoScroll = true;
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer1.Panel2.Controls.Add(this.font_others);
			this.splitContainer1.Panel2.Controls.Add(this.font_icon);
			this.splitContainer1.Panel2.Controls.Add(this.font_smcaption);
			this.splitContainer1.Panel2.Controls.Add(this.font_msg);
			this.splitContainer1.Panel2.Controls.Add(this.font_status);
			this.splitContainer1.Panel2.Controls.Add(this.font_menu);
			this.splitContainer1.Panel2.Controls.Add(this.font_caption);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
			this.splitContainer1.Size = new System.Drawing.Size(562, 496);
			this.splitContainer1.SplitterDistance = 208;
			this.splitContainer1.TabIndex = 3;
			// 
			// listBox1
			// 
			this.listBox1.AllowDrop = true;
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBox1.Font = new System.Drawing.Font("Verdana Ref", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(5, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(198, 484);
			this.listBox1.TabIndex = 0;
			this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
			this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
			this.listBox1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listBox1_GiveFeedback);
			// 
			// font_others
			// 
			this.font_others.AllowDrop = true;
			this.font_others.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_others.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_others.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_others.font_name = "Arial";
			this.font_others.font_sample = "ABCDEFabcde01234€";
			this.font_others.font_size = 10;
			this.font_others.Location = new System.Drawing.Point(5, 419);
			this.font_others.Name = "font_others";
			this.font_others.Padding = new System.Windows.Forms.Padding(5);
			this.font_others.Size = new System.Drawing.Size(340, 69);
			this.font_others.TabIndex = 6;
			this.font_others.Visible = false;
			this.font_others.what_fnt = "Others";
			// 
			// font_icon
			// 
			this.font_icon.AllowDrop = true;
			this.font_icon.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_icon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_icon.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_icon.font_name = "Arial";
			this.font_icon.font_sample = "ABCDEFabcde01234€";
			this.font_icon.font_size = 10;
			this.font_icon.Location = new System.Drawing.Point(5, 350);
			this.font_icon.Name = "font_icon";
			this.font_icon.Padding = new System.Windows.Forms.Padding(5);
			this.font_icon.Size = new System.Drawing.Size(340, 69);
			this.font_icon.TabIndex = 5;
			this.font_icon.what_fnt = "Icon Title";
			// 
			// font_smcaption
			// 
			this.font_smcaption.AllowDrop = true;
			this.font_smcaption.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_smcaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_smcaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_smcaption.font_name = "Arial";
			this.font_smcaption.font_sample = "ABCDEFabcde01234€";
			this.font_smcaption.font_size = 10;
			this.font_smcaption.Location = new System.Drawing.Point(5, 281);
			this.font_smcaption.Name = "font_smcaption";
			this.font_smcaption.Padding = new System.Windows.Forms.Padding(5);
			this.font_smcaption.Size = new System.Drawing.Size(340, 69);
			this.font_smcaption.TabIndex = 4;
			this.font_smcaption.what_fnt = "Small Caption";
			// 
			// font_msg
			// 
			this.font_msg.AllowDrop = true;
			this.font_msg.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_msg.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_msg.font_name = "Arial";
			this.font_msg.font_sample = "ABCDEFabcde01234€";
			this.font_msg.font_size = 10;
			this.font_msg.Location = new System.Drawing.Point(5, 212);
			this.font_msg.Name = "font_msg";
			this.font_msg.Padding = new System.Windows.Forms.Padding(5);
			this.font_msg.Size = new System.Drawing.Size(340, 69);
			this.font_msg.TabIndex = 3;
			this.font_msg.what_fnt = "Message";
			// 
			// font_status
			// 
			this.font_status.AllowDrop = true;
			this.font_status.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_status.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_status.font_name = "Arial";
			this.font_status.font_sample = "ABCDEFabcde01234€";
			this.font_status.font_size = 10;
			this.font_status.Location = new System.Drawing.Point(5, 143);
			this.font_status.Name = "font_status";
			this.font_status.Padding = new System.Windows.Forms.Padding(5);
			this.font_status.Size = new System.Drawing.Size(340, 69);
			this.font_status.TabIndex = 2;
			this.font_status.what_fnt = "Status";
			// 
			// font_menu
			// 
			this.font_menu.AllowDrop = true;
			this.font_menu.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_menu.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_menu.font_name = "Arial";
			this.font_menu.font_sample = "ABCDEFabcde01234€";
			this.font_menu.font_size = 10;
			this.font_menu.Location = new System.Drawing.Point(5, 74);
			this.font_menu.Name = "font_menu";
			this.font_menu.Padding = new System.Windows.Forms.Padding(5);
			this.font_menu.Size = new System.Drawing.Size(340, 69);
			this.font_menu.TabIndex = 1;
			this.font_menu.what_fnt = "Menu";
			// 
			// font_caption
			// 
			this.font_caption.AllowDrop = true;
			this.font_caption.BackColor = System.Drawing.SystemColors.ControlDark;
			this.font_caption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.font_caption.Dock = System.Windows.Forms.DockStyle.Top;
			this.font_caption.font_name = "Arial";
			this.font_caption.font_sample = "ABCDEFabcde01234€";
			this.font_caption.font_size = 10;
			this.font_caption.Location = new System.Drawing.Point(5, 5);
			this.font_caption.Name = "font_caption";
			this.font_caption.Padding = new System.Windows.Forms.Padding(5);
			this.font_caption.Size = new System.Drawing.Size(340, 69);
			this.font_caption.TabIndex = 0;
			this.font_caption.what_fnt = "Caption";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(568, 508);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Change Wallpaper";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(7, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(554, 292);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// dlg_flsselect
			// 
			this.dlg_flsselect.Description = "Sélectionner un répertoire d\'images (png;jpg;bmp;...)";
			this.dlg_flsselect.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// w_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 585);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "w_main";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Change Fonts";
			this.Load += new System.EventHandler(this.w_main_Load);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button bt_cancel;
		private System.Windows.Forms.Button bt_valid;
		private System.Windows.Forms.Button bt_revert;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBox1;
		private FontSelected font_others;
		private FontSelected font_icon;
		private FontSelected font_smcaption;
		private FontSelected font_msg;
		private FontSelected font_status;
		private FontSelected font_menu;
		private FontSelected font_caption;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FolderBrowserDialog dlg_flsselect;


	}
}

