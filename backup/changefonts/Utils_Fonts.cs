using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FontsChange
{
	class FontsUtils
	{
		/// <summary>
		/// Create a font with the facename
		/// (check for avaible style)
		/// </summary>
		public static Font MakeAFont(String fnt_name)
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

			Font fnt = new Font(fnt_name, 9, fs);
			return fnt;
		}
	}
}