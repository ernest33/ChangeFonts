using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace ChangeFonts
{
	public partial class FontSelected : UserControl
	{
		private string fnt;
		private string sample;
		private string what;
		private int fnt_size;


		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
		public static extern IntPtr GetDesktopWindow();
		
		[DllImport("user32.dll", EntryPoint = "GetDC")]
		public static extern IntPtr GetDC(IntPtr ptr);

		public FontSelected()
		{
			InitializeComponent();
			if (sample == null)
			{
				font_sample = "ABCDEFabcde01234€";
				sample = font_sample;
			}
			if(fnt == null)
			{
				font_name = "Arial";
				fnt = font_name;
			}
			if (what == null)
			{
				what_fnt = "<??>";
				what = what_fnt;
			}
			if (fnt_size == 0)
			{
				fnt_size = 10;
			}
			else
			{
				//IntPtr hdc;
				//Graphics e = Graphics.FromHwnd(IntPtr.Zero);
				//hdc = e.GetHdc();

				//int dvc = GetDeviceCaps(hdc, PHYSICALOFFSETY);
				//fnt_size = Math.Abs(((int)(fnt_size * 72 / 96)));
				//e.ReleaseHdc();

				//// points = -Int(lngHeight * 72 / lngLogPixelsY)
				//// pixels = -Int(lngHeight * lngLogPixelsY / 72)
	
				//Font nFont = new Font(fnt, fnt_size);
				//lab_sample.Font = nFont;
				//lab_size.Text = fnt_size.ToString();
			}
		}

		public int ConvertToPoint(int emsize)
		{
			int fntsiz;
			fntsiz = (int)Math.Ceiling(Math.Abs((((double)emsize * 72 / 96))));
			return fntsiz;
		}
		public int ConvertToPixel(int fntsiz)
		{
			int emsize;
			emsize = (fntsiz * 96 / 72);
			return emsize;
		}

		public string font_name
		{
			get
			{
				return fnt;
			}
			set
			{
				fnt = value;
				lab_fontname.Text = fnt;
				Font nFont = MakeAFont(lab_fontname.Text);
				lab_sample.Font = nFont;
			}
		}

		public string font_sample
		{
			get
			{
				return sample;
			}
			set
			{
				sample = value;
				lab_sample.Text = sample;
			}
		}

		public string what_fnt
		{
			get
			{
				return what;
			}
			set
			{
				what = value;
				lab_what.Text = what;
			}
		}

		public int font_size
		{
			get
			{
				return fnt_size;
			}
			set
			{
				fnt_size = value;
				//fnt_size = Math.Abs(((int)(fnt_size * 96 / 72))); //value;
				//IntPtr hdc;
				//Graphics e = Graphics.FromHwnd(IntPtr.Zero);
				//hdc = e.GetHdc();

				//int dvc = GetDeviceCaps(hdc, PHYSICALOFFSETY);
				//fnt_size = Math.Abs(((int)(fnt_size * 72 / 96)));
				//e.ReleaseHdc();

				//// points = -Int(lngHeight * 72 / lngLogPixelsY)
				//// pixels = -Int(lngHeight * lngLogPixelsY / 72)
								
				//Font nFont = new Font(fnt, Convert.ToInt32(lab_size.Text));
				//lab_sample.Font = nFont;
				//Font nFont = new Font(fnt, Convert.ToInt32(fnt_size));
				Font nFont = MakeAFont(fnt);//new Font(fnt, fnt_size);
				lab_sample.Font = nFont;
                //System.Windows.Forms.MessageBox.Show("Hello", "Hello", MessageBoxButtons.OK);
                //lab_size.Text = Math.Abs(fnt_size).ToString();
				//lab_size.Text = fnt_size.ToString();
                numericUpDown1.Value = fnt_size;
			}
		}

		private void FontSelected_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void FontSelected_DragDrop(object sender, DragEventArgs e)
		{
			font_name = e.Data.GetData(DataFormats.Text).ToString();
		}

		public Font MakeAFont(String fnt_name)
		{
			FontFamily family = new FontFamily(fnt_name);
			FontStyle fs = new FontStyle();
			if (family.IsStyleAvailable(FontStyle.Regular))
			{
				fs = FontStyle.Regular;
			}
			else if (family.IsStyleAvailable(FontStyle.Bold))
			{
				fs = FontStyle.Bold;
			}
			else if (family.IsStyleAvailable(FontStyle.Italic))
			{
				fs = FontStyle.Italic;
				//
			}
			family.Dispose();
			if (fnt_size == 0)
				fnt_size = 9;
			Font fnt = new Font(fnt_name, fnt_size, fs);
			return fnt;
		}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int size = int.Parse(numericUpDown1.Value.ToString());//int.Parse(lab_size.Text);
            if (size > 1)
            {
                //size -= 1;
                //lab_size.Text = size.ToString();
                font_size = size;
            } 
        }
	}
}
