using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns1;

public sealed class FermiColors
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[24];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	public static Color AltControl => Color.FromArgb(79, 79, 79);

	public static Color AltControlAccent => Color.FromArgb(99, 191, 105);

	public static Color AltControlDark => Color.FromArgb(63, 63, 63);

	public static Color AltControlLight => Color.FromArgb(94, 105, 114);

	public static Color AltControlText => Color.FromArgb(193, 193, 193);

	public static Color AltControlTextDark => Color.FromArgb(130, 130, 130);

	public static Color AltControlTextLight => Color.FromArgb(242, 242, 242);

	public static Color Control => Color.FromArgb(27, 27, 27);

	public static Color ControlAccent => Color.FromArgb(0, 180, 120);

	public static Color ControlAccentDark => Color.FromArgb(0, 160, 100);

	public static Color ControlAccentLight => Color.FromArgb(0, 200, 140);

	public static Color ControlDark => Color.FromArgb(68, 68, 68);

	public static Color ControlDarkDark => Color.FromArgb(45, 45, 45);

	public static Color ControlLight => Color.FromArgb(80, 80, 80);

	public static Color ControlLightLight => Color.FromArgb(255, 255, 255);

	public static Color ControlText => Color.FromArgb(254, 254, 254);

	public static Color ControlTextLight => Color.FromArgb(130, 130, 130);

	public static Color Highlight => Color.FromArgb(230, 230, 230);

	public static Color HighlightText => Color.FromArgb(51, 51, 51);

	public static Color Window => Color.FromArgb(21, 21, 21);

	public static Color WindowCaption => Color.FromArgb(34, 34, 34);

	public static Color WindowClose => Color.FromArgb(232, 17, 35);

	public static Color WindowCloseLight => Color.FromArgb(165, 13, 28);

	public static Color WindowFrame => Color.FromArgb(20, 20, 20);

	public static Color WindowText => Color.FromArgb(250, 250, 250);

	static FermiColors()
	{
		char[] array = new char[8];
		array[6] = 'ẋ';
		array[3] = '↊';
		array[1] = 'ຨ';
		array[2] = 'ⴑ';
		array[0] = 'ⱄ';
		array[7] = 'Ḯ';
		array[5] = '㴺';
		array[4] = 'ᝦ';
		array_2 = new string[3];
		array_0 = array;
	}
}
