using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace a;

[StandardModule]
internal sealed class CheckProcesses
{
	public static void Check()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (Config.Debug)
		{
			return;
		}
		checked
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				ListBox val = new ListBox();
				for (int i = 0; i != processes.Length - 1; i++)
				{
					val.get_Items().Add((object)processes[i].ProcessName.ToLower());
				}
				int j = 0;
				int k = 0;
				for (; j != Config.ProsNotAllowed.get_Items().get_Count(); j++)
				{
					for (; k != val.get_Items().get_Count(); k++)
					{
						if (val.get_Items().get_Item(k).ToString()!.Contains(Conversions.ToString(Config.ProsNotAllowed.get_Items().get_Item(j))))
						{
							ProjectData.EndApp();
						}
					}
					k = 0;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
