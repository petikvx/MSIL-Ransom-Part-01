using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class MainClass
{
	[STAThread]
	public static void main()
	{
		string text = Environment.GetCommandLineArgs()[0];
		byte[] array = new byte[6];
		char[] array2 = new char[6];
		FileStream fileStream;
		try
		{
			fileStream = File.OpenRead(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Errors.FileNoAccess(ex2.Message);
			ProjectData.ClearProjectError();
			return;
		}
		checked
		{
			fileStream.Position = fileStream.Length - 6L;
			fileStream.Read(array, 0, array.Length);
			array2 = Encoding.UTF8.GetChars(array);
			string text2 = string.Concat(new string(array2));
			if (Versioned.IsNumeric((object)text2))
			{
				fileStream.Position = Conversions.ToLong(text2);
				byte[] array3 = new byte[(int)(fileStream.Length - fileStream.Position - 6L - 1L) + 1];
				fileStream.Read(array3, 0, array3.Length);
				char[] chars = Encoding.UTF8.GetChars(array3);
				string text3 = string.Concat(new string(chars));
				fileStream.Close();
				string lang_name = text3.Substring(0, text3.IndexOf("~~~"));
				text3 = text3.Substring(text3.IndexOf("~~~") + 3);
				peremens.lang_name = lang_name;
				peremens.lang_interface = peremens.lang_name;
				peremens.lang_name_old = peremens.lang_name;
				string txt = text3.Substring(0, text3.IndexOf("~~~"));
				text3 = text3.Substring(text3.IndexOf("~~~") + 3);
				peremens.lang = peremens.Get2ListFromString(txt, "~~");
				peremens.langLw = peremens.Get2ListFromString(txt, "~~", null, withLCase: true);
				peremens.langINFC = peremens.lang;
				peremens.langLwINFC = peremens.langLw;
				peremens.langOld = peremens.lang;
				peremens.langLwOld = peremens.langLw;
				string txt2 = text3.Substring(0, text3.IndexOf("~~~"));
				text3 = text3.Substring(text3.IndexOf("~~~") + 3);
				peremens.langENG = peremens.Get2ListFromString(txt2, "~~");
				peremens.langLwENG = peremens.Get2ListFromString(txt2, "~~", null, withLCase: true);
			}
			else
			{
				peremens.lang_name = "Russian";
				peremens.LanguagePath = Path.GetDirectoryName(text) + "\\Languages\\";
				peremens.setLangs(withOld: true, withFolder: false);
			}
			peremens.RunProj = new RunProject("");
			Pers(text);
			Props.CreateArrays();
			Props.CreateConstants();
			Props.CreateHelpWords();
			Application.EnableVisualStyles();
			CodeAlg.Initial();
			Application.Run();
		}
	}

	private static void Pers(string file)
	{
		peremens.isDevelop = false;
		peremens.isCompilBest = true;
		peremens.RunProj.isRUN = true;
		peremens2.proj = peremens.RunProj;
		if (peremens.RunProj.GetType().ToString().IndexOf(".") == -1)
		{
			peremens.ClassAplication = "";
		}
		else
		{
			peremens.ClassAplication = peremens.RunProj.GetType().ToString().Split(new char[1] { '.' })[0] + ".";
		}
		peremens.RunProj.pPath = Path.GetDirectoryName(file) + "\\";
		peremens.RunProj.pFileName = Path.GetFileName(file);
		peremens.RunProj.iPath = peremens.RunProj.pPath + "Pictures";
	}
}
