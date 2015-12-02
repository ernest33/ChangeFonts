using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace FontsChange
{
	class Win32
	{
		// ---------
		// API WIN32
		// ---------
		[DllImport("gdi32.dll")]
		public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		// We can overload this definition, since that's in effect what the unmanaged
		// API does anyway.
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int SystemParametersInfo(int uAction,
		int uParam, ref NONCLIENTMETRICS lpvParam, int fuWinIni);

		/// <summary>
		/// Get system infos (font, size, color depth, ...)
		/// </summary>
		/// <param name="uAction"></param>
		/// <param name="uParam"></param>
		/// <param name="lpvParam"></param>
		/// <param name="fuWinIni"></param>
		/// <returns>Return an 'int'</returns>
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int SystemParametersInfo(int uAction,
		int uParam, ref ICONMETRICS lpvParam, int fuWinIni);

		//Declare Function GetDesktopWindow Lib "user32" Alias "GetDesktopWindow" () As Long
		/// <summary>
		/// Get the HDC of the desktop window
		/// </summary>
		/// <returns></returns>
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern long GetDesktopWindow();

		/// <summary>
		/// Make a beep using internal system sound
		/// </summary>
		/// <param name="frequency">0 to 6000</param>
		/// <param name="duration">0 to 3000(ms)</param>
		/// <returns></returns>
		[DllImport("Kernel32.dll")]
		public static extern bool Beep(UInt32 frequency, UInt32 duration);

		// CONSTANTS
		public const Int32 PHYSICALOFFSETX = 112;
		public const Int32 PHYSICALOFFSETY = 113;
		public const Int32 PHYSICALWIDTH = 110;
		public const Int32 PHYSICALHEIGHT = 111;
		public const int LF_FACESIZE = 32;
		public const int SPI_GETNONCLIENTMETRICS = 41;
		public const int SPI_SETNONCLIENTMETRICS = 42;
		public const int SPIF_UPDATEINIFILE = 1;
		public const int SPIF_SENDWININICHANGE = 2;
		public const int SPI_GETICONMETRICS = 45;
		public const int SPI_SETICONMETRICS = 46;
		public const int SPI_GETICONTITLELOGFONT = 31;
		public const int SPI_SETICONTITLELOGFONT = 34;

		// STRUCTURES
		/// <summary>
		/// A "logical font" used by old-school windows
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct LOGFONT
		{
			public int lfHeight;
			public int lfWidth;
			public int lfEscapement;
			public int lfOrientation;
			public int lfWeight;
			public byte lfItalic;
			public byte lfUnderline;
			public byte lfStrikeOut;
			public byte lfCharSet;
			public byte lfOutPrecision;
			public byte lfClipPrecision;
			public byte lfQuality;
			public byte lfPitchAndFamily;

			/// <summary>
			/// <see cref="UnmanagedType.ByValTStr"/> means that the string
			/// should be marshalled as an array of TCHAR embedded in the
			/// structure.  This implies that the font names can be no larger
			/// than <see cref="LF_FACESIZE"/> including the terminating '\0'.
			/// That works out to 31 characters.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LF_FACESIZE)]
			public string lfFaceName;

			// to shut it up about the warnings
			public LOGFONT(string lfFaceName)
			{
				this.lfFaceName = lfFaceName;
				lfHeight = lfWidth = lfEscapement = lfOrientation = lfWeight = 0;
				lfItalic = lfUnderline = lfStrikeOut = lfCharSet = lfOutPrecision
				= lfClipPrecision = lfQuality = lfPitchAndFamily = 0;
			}
		}
		public struct NONCLIENTMETRICS
		{
			public int cbSize;
			public int iBorderWidth;
			public int iScrollWidth;
			public int iScrollHeight;
			public int iCaptionWidth;
			public int iCaptionHeight;
			/// <summary>
			/// Since <see cref="LOGFONT"/> is a struct instead of a class,
			/// we don't have to do any special marshalling here.  Much
			/// simpler this way.
			/// </summary>
			public LOGFONT lfCaptionFont;
			public int iSMCaptionWidth;
			public int iSMCaptionHeight;
			public LOGFONT lfSMCaptionFont;
			public int iMenuWidth;
			public int iMenuHeight;
			public LOGFONT lfMenuFont;
			public LOGFONT lfStatusFont;
			public LOGFONT lfMessageFont;
		}
		public struct ICONMETRICS
		{
			public int cbSize;
			public int iHorzSpacing;
			public int iVertSpacing;
			public int iTitleWrap;
			public LOGFONT lfFont;
		}
		
		// ENUMERATIOSN
		/// <summary>
		/// Enumeration of DeviceCap capacity
		/// </summary>
		public enum DeviceCap
		{
			/// <summary>
			/// Device driver version
			/// </summary>
			DRIVERVERSION = 0,
			/// <summary>
			/// Device classification
			/// </summary>
			TECHNOLOGY = 2,
			/// <summary>
			/// Horizontal size in millimeters
			/// </summary>
			HORZSIZE = 4,
			/// <summary>
			/// Vertical size in millimeters
			/// </summary>
			VERTSIZE = 6,
			/// <summary>
			/// Horizontal width in pixels
			/// </summary>
			HORZRES = 8,
			/// <summary>
			/// Vertical height in pixels
			/// </summary>
			VERTRES = 10,
			/// <summary>
			/// Number of bits per pixel
			/// </summary>
			BITSPIXEL = 12,
			/// <summary>
			/// Number of planes
			/// </summary>
			PLANES = 14,
			/// <summary>
			/// Number of brushes the device has
			/// </summary>
			NUMBRUSHES = 16,
			/// <summary>
			/// Number of pens the device has
			/// </summary>
			NUMPENS = 18,
			/// <summary>
			/// Number of markers the device has
			/// </summary>
			NUMMARKERS = 20,
			/// <summary>
			/// Number of fonts the device has
			/// </summary>
			NUMFONTS = 22,
			/// <summary>
			/// Number of colors the device supports
			/// </summary>
			NUMCOLORS = 24,
			/// <summary>
			/// Size required for device descriptor
			/// </summary>
			PDEVICESIZE = 26,
			/// <summary>
			/// Curve capabilities
			/// </summary>
			CURVECAPS = 28,
			/// <summary>
			/// Line capabilities
			/// </summary>
			LINECAPS = 30,
			/// <summary>
			/// Polygonal capabilities
			/// </summary>
			POLYGONALCAPS = 32,
			/// <summary>
			/// Text capabilities
			/// </summary>
			TEXTCAPS = 34,
			/// <summary>
			/// Clipping capabilities
			/// </summary>
			CLIPCAPS = 36,
			/// <summary>
			/// Bitblt capabilities
			/// </summary>
			RASTERCAPS = 38,
			/// <summary>
			/// Length of the X leg
			/// </summary>
			ASPECTX = 40,
			/// <summary>
			/// Length of the Y leg
			/// </summary>
			ASPECTY = 42,
			/// <summary>
			/// Length of the hypotenuse
			/// </summary>
			ASPECTXY = 44,
			/// <summary>
			/// Shading and Blending caps
			/// </summary>
			SHADEBLENDCAPS = 45,

			/// <summary>
			/// Logical pixels inch in X
			/// </summary>
			LOGPIXELSX = 88,
			/// <summary>
			/// Logical pixels inch in Y
			/// </summary>
			LOGPIXELSY = 90,

			/// <summary>
			/// Number of entries in physical palette
			/// </summary>
			SIZEPALETTE = 104,
			/// <summary>
			/// Number of reserved entries in palette
			/// </summary>
			NUMRESERVED = 106,
			/// <summary>
			/// Actual color resolution
			/// </summary>
			COLORRES = 108,

			// Printing related DeviceCaps. These replace the appropriate Escapes
			/// <summary>
			/// Physical Width in device units
			/// </summary>
			PHYSICALWIDTH = 110,
			/// <summary>
			/// Physical Height in device units
			/// </summary>
			PHYSICALHEIGHT = 111,
			/// <summary>
			/// Physical Printable Area x margin
			/// </summary>
			PHYSICALOFFSETX = 112,
			/// <summary>
			/// Physical Printable Area y margin
			/// </summary>
			PHYSICALOFFSETY = 113,
			/// <summary>
			/// Scaling factor x
			/// </summary>
			SCALINGFACTORX = 114,
			/// <summary>
			/// Scaling factor y
			/// </summary>
			SCALINGFACTORY = 115,

			/// <summary>
			/// Current vertical refresh rate of the display device (for displays only) in Hz
			/// </summary>
			VREFRESH = 116,
			/// <summary>
			/// Horizontal width of entire desktop in pixels
			/// </summary>
			DESKTOPVERTRES = 117,
			/// <summary>
			/// Vertical height of entire desktop in pixels
			/// </summary>
			DESKTOPHORZRES = 118,
			/// <summary>
			/// Preferred blt alignment
			/// </summary>
			BLTALIGNMENT = 119
		}

	
	}
}
