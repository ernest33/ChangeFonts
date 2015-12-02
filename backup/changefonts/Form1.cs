using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontsChange;


namespace ChangeFonts
{
	public partial class w_main : Form
	{
		// VARIABLES
		private Win32.LOGFONT fnt_Caption;
		private Win32.LOGFONT fnt_SmCaption;
		private Win32.LOGFONT fnt_Menu;
		private Win32.LOGFONT fnt_Status;
		private Win32.LOGFONT fnt_Msg;
		private Win32.LOGFONT fnt_Icon;
		private Win32.NONCLIENTMETRICS metrics = new Win32.NONCLIENTMETRICS();
		private Win32.ICONMETRICS icnmetrics = new Win32.ICONMETRICS();	

		public w_main()
		{
			InitializeComponent();
			
	
			metrics.cbSize = Marshal.SizeOf(metrics);
			Win32.SystemParametersInfo(Win32.SPI_GETNONCLIENTMETRICS, 0, ref metrics, 0);
			icnmetrics.cbSize = Marshal.SizeOf(icnmetrics);
			Win32.SystemParametersInfo(Win32.SPI_GETICONMETRICS, 0, ref icnmetrics, 0);
			fnt_Caption = metrics.lfCaptionFont;
			fnt_SmCaption = metrics.lfSMCaptionFont;
			fnt_Menu = metrics.lfMenuFont;
			fnt_Status = metrics.lfStatusFont;
			fnt_Msg = metrics.lfMessageFont;
			fnt_Icon = icnmetrics.lfFont;

			// Mise à jour des champs de polices...
			font_caption.font_name = fnt_Caption.lfFaceName.ToString();
			font_smcaption.font_name = fnt_SmCaption.lfFaceName.ToString();
			font_menu.font_name = fnt_Menu.lfFaceName.ToString();
			font_status.font_name = fnt_Status.lfFaceName.ToString();
			font_msg.font_name = fnt_Msg.lfFaceName.ToString();
			font_icon.font_name = fnt_Icon.lfFaceName.ToString();

			//font_caption.font_size = Math.Abs(fnt_Caption.lfHeight); //ConvertToPoint(fnt_Caption.lfHeight);
			//font_smcaption.font_size = Math.Abs(fnt_SmCaption.lfHeight); //ConvertToPoint(fnt_SmCaption.lfHeight);
			//font_menu.font_size = Math.Abs(fnt_Menu.lfHeight); //ConvertToPoint(fnt_Menu.lfHeight);
			//font_status.font_size = Math.Abs(fnt_Status.lfHeight); //ConvertToPoint(fnt_Status.lfHeight);
			//font_msg.font_size = Math.Abs(fnt_Msg.lfHeight); //ConvertToPoint(fnt_Msg.lfHeight);
			//font_icon.font_size = Math.Abs(fnt_Icon.lfHeight); //ConvertToPoint(fnt_Icon.lfHeight);

			font_caption.font_size = ConvertToPoint(fnt_Caption.lfHeight);
			font_smcaption.font_size = ConvertToPoint(fnt_SmCaption.lfHeight);
			font_menu.font_size = ConvertToPoint(fnt_Menu.lfHeight);
			font_status.font_size = ConvertToPoint(fnt_Status.lfHeight);
			font_msg.font_size = ConvertToPoint(fnt_Msg.lfHeight);
			font_icon.font_size = ConvertToPoint(fnt_Icon.lfHeight);

			
			//MessageBox.Show(metrics.lfMenuFont.lfFaceName.ToString());
		}
		public int ConvertToPoint(int emsize)
		{
			int fntsiz;
			Graphics g = this.CreateGraphics();
			fntsiz = (int)Math.Ceiling(Math.Abs((((double)emsize * 72 / g.DpiY))));
			g.Dispose();

			return fntsiz;
		}
		public int ConvertToPixel(int fntsiz)
		{
			int emsize;
			Graphics g = this.CreateGraphics();
			emsize = (fntsiz * (int)g.DpiY / 72);
			g.Dispose();
			return emsize;
		}

		private void w_main_Load(object sender, EventArgs e)
		{
			InstalledFontCollection fonts = new InstalledFontCollection();
			foreach (FontFamily family in fonts.Families)
			{
				try
				{
					listBox1.Items.Add(family.Name);
				}
				catch
				{
					// On ne s'occupe des fonts/style invalide
				}
			}
		}

		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			//e.Graphics.Clear(listBox1.BackColor);
			e.DrawBackground();
			e.DrawFocusRectangle();
			e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
			e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),  FontsUtils.MakeAFont(listBox1.Items[e.Index].ToString()), new SolidBrush(Color.Black), e.Bounds);
		}

		private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 22;
		}

		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
		}

		private void listBox1_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void bt_valid_Click(object sender, EventArgs e)
		{
			bt_valid.Enabled = false;
			bt_valid.Text = "Modification en cours";
			this.Update();
			// Applique les modifications
			// Mise à jour des champs de polices...
			//font_caption.font_name = fnt_Caption.lfFaceName.ToString();
			fnt_Caption.lfFaceName = font_caption.font_name;
			fnt_Caption.lfHeight = -(int)ConvertToPixel(font_caption.font_size);
			
			//font_smcaption.font_name = fnt_SmCaption.lfFaceName.ToString();
			fnt_SmCaption.lfFaceName = font_smcaption.font_name;
			fnt_SmCaption.lfHeight = -(int)ConvertToPixel(font_smcaption.font_size);

			//font_menu.font_name = fnt_Menu.lfFaceName.ToString();
			fnt_Menu.lfFaceName = font_menu.font_name;
			fnt_Menu.lfHeight = -(int)ConvertToPixel(font_menu.font_size);

			//font_status.font_name = fnt_Status.lfFaceName.ToString();
			fnt_Status.lfFaceName = font_status.font_name;
			fnt_Status.lfHeight = -(int)ConvertToPixel(font_status.font_size);

			//font_msg.font_name = fnt_Msg.lfFaceName.ToString();
			fnt_Msg.lfFaceName = font_msg.font_name;
			fnt_Msg.lfHeight = -(int)ConvertToPixel(font_msg.font_size);

			fnt_Icon.lfFaceName = font_icon.font_name;
			fnt_Icon.lfHeight = -(int)ConvertToPixel(font_icon.font_size);

			metrics.lfCaptionFont = fnt_Caption;
			metrics.lfSMCaptionFont = fnt_SmCaption;
			metrics.lfMenuFont = fnt_Menu;
			metrics.lfStatusFont = fnt_Status;
			metrics.lfMessageFont = fnt_Msg;

			icnmetrics.lfFont = fnt_Icon;

			Win32.SystemParametersInfo(Win32.SPI_SETNONCLIENTMETRICS, 0, ref metrics, Win32.SPIF_UPDATEINIFILE | Win32.SPIF_SENDWININICHANGE);
			Win32.SystemParametersInfo(Win32.SPI_SETICONMETRICS, 0, ref icnmetrics, Win32.SPIF_UPDATEINIFILE | Win32.SPIF_SENDWININICHANGE);
			//Beep(1000, 300);
			bt_valid.Enabled = true;
			bt_valid.Text = "Valider";
			//MessageBox.Show("DONE !");
		}

		private void bt_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listBox1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
		{
			//e.Effect = DragDropEffects.Copy;
			e.UseDefaultCursors = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ChangeFonts by ernest33", "About...");
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

	}
}
