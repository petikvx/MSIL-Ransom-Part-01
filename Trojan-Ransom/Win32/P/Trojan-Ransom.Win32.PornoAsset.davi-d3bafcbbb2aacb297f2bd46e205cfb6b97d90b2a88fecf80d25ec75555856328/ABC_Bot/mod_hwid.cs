using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

[StandardModule]
internal sealed class mod_hwid
{
	internal static string GetProcessorId()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		ManagementObject val = default(ManagementObject);
		SelectQuery val2 = default(SelectQuery);
		ManagementObjectSearcher val3 = default(ManagementObjectSearcher);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 185:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_002b;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_005f;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005f:
					num = 7;
					goto IL_0062;
					IL_004a:
					num = 6;
					text = ((ManagementBaseObject)val).get_Item("processorId").ToString();
					goto IL_005f;
					IL_0009:
					num = 2;
					text = string.Empty;
					goto IL_0013;
					IL_0013:
					num = 3;
					val2 = new SelectQuery("Win32_processor");
					goto IL_0021;
					IL_0021:
					num = 4;
					val3 = new ManagementObjectSearcher((ObjectQuery)(object)val2);
					goto IL_002b;
					IL_002b:
					num = 5;
					enumerator = val3.Get().GetEnumerator();
					goto IL_0062;
					IL_0062:
					if (enumerator.MoveNext())
					{
						val = (ManagementObject)enumerator.get_Current();
						goto IL_004a;
					}
					((IDisposable)enumerator)?.Dispose();
					break;
					end_IL_0000_2:
					break;
				}
				num = 8;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 185;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	internal static string GetMACAddress()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		ManagementObject val = default(ManagementObject);
		ManagementClass val2 = default(ManagementClass);
		ManagementObjectCollection instances = default(ManagementObjectCollection);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 282:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0017;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_002a;
						case 6:
							goto IL_004c;
						case 7:
							goto IL_005c;
						case 8:
							goto IL_0072;
						case 11:
						case 12:
							goto IL_0089;
						case 13:
							goto IL_009e;
						case 9:
						case 10:
							goto IL_00a4;
						case 14:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0089:
					num = 12;
					text = text.Replace(":", string.Empty);
					goto IL_009e;
					IL_00a4:
					num = 10;
					val.Dispose();
					goto IL_0089;
					IL_0009:
					num = 2;
					val2 = new ManagementClass("Win32_NetworkAdapterConfiguration");
					goto IL_0017;
					IL_0017:
					num = 3;
					instances = val2.GetInstances();
					goto IL_0021;
					IL_0021:
					num = 4;
					text = string.Empty;
					goto IL_002a;
					IL_002a:
					num = 5;
					enumerator = instances.GetEnumerator();
					goto IL_0035;
					IL_0035:
					if (enumerator.MoveNext())
					{
						val = (ManagementObject)enumerator.get_Current();
						goto IL_004c;
					}
					((IDisposable)enumerator)?.Dispose();
					break;
					IL_009e:
					num = 13;
					goto IL_0035;
					IL_004c:
					num = 6;
					if (text.Equals(string.Empty))
					{
						goto IL_005c;
					}
					goto IL_0089;
					IL_005c:
					num = 7;
					if (Conversions.ToBoolean(((ManagementBaseObject)val).get_Item("IPEnabled")))
					{
						goto IL_0072;
					}
					goto IL_00a4;
					IL_0072:
					num = 8;
					text = ((ManagementBaseObject)val).get_Item("MacAddress").ToString();
					goto IL_00a4;
					end_IL_0000_2:
					break;
				}
				num = 14;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 282;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	internal static string GetVolumeSerial(string strDriveLetter = "C")
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ManagementObject val = default(ManagementObject);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 97:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001c;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001c:
					num = 3;
					val.Get();
					break;
					IL_0008:
					num = 2;
					val = new ManagementObject($"win32_logicaldisk.deviceid=\"{strDriveLetter}:\"");
					goto IL_001c;
					end_IL_0000_2:
					break;
				}
				num = 4;
				text = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 97;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	internal static string GetMotherBoardID()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		ManagementObject val = default(ManagementObject);
		SelectQuery val2 = default(SelectQuery);
		ManagementObjectSearcher val3 = default(ManagementObjectSearcher);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 185:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_002b;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_005f;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005f:
					num = 7;
					goto IL_0062;
					IL_004a:
					num = 6;
					text = ((ManagementBaseObject)val).get_Item("SerialNumber").ToString();
					goto IL_005f;
					IL_0009:
					num = 2;
					text = string.Empty;
					goto IL_0013;
					IL_0013:
					num = 3;
					val2 = new SelectQuery("Win32_BaseBoard");
					goto IL_0021;
					IL_0021:
					num = 4;
					val3 = new ManagementObjectSearcher((ObjectQuery)(object)val2);
					goto IL_002b;
					IL_002b:
					num = 5;
					enumerator = val3.Get().GetEnumerator();
					goto IL_0062;
					IL_0062:
					if (enumerator.MoveNext())
					{
						val = (ManagementObject)enumerator.get_Current();
						goto IL_004a;
					}
					((IDisposable)enumerator)?.Dispose();
					break;
					end_IL_0000_2:
					break;
				}
				num = 8;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 185;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object hwid()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string s = default(string);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		string text2 = default(string);
		byte[] bytes = default(byte[]);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num6 = default(int);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 341:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_002c;
						case 4:
							goto IL_0035;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_0048;
						case 7:
							goto IL_0058;
						case 8:
							goto IL_0064;
						case 9:
							goto IL_0078;
						case 10:
							goto IL_0088;
						case 11:
							goto IL_0096;
						case 14:
							goto IL_00aa;
						case 12:
						case 13:
							goto IL_00b6;
						case 15:
							goto IL_00c5;
						case 16:
							goto IL_00d0;
						case 17:
						case 18:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 19:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00d0:
					num = 16;
					Interaction.MsgBox((object)("HardwareID: " + text), (MsgBoxStyle)0, (object)null);
					break;
					IL_00c5:
					num = 15;
					if (!main.debug)
					{
						break;
					}
					goto IL_00d0;
					IL_0009:
					num = 2;
					s = GetProcessorId() + GetMACAddress() + GetMotherBoardID() + GetVolumeSerial();
					goto IL_002c;
					IL_002c:
					num = 3;
					mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					goto IL_0035;
					IL_0035:
					num = 4;
					text = "";
					goto IL_003e;
					IL_003e:
					num = 5;
					text2 = "";
					goto IL_0048;
					IL_0048:
					num = 6;
					bytes = Encoding.ASCII.GetBytes(s);
					goto IL_0058;
					IL_0058:
					num = 7;
					array = mD5CryptoServiceProvider.ComputeHash(bytes);
					goto IL_0064;
					IL_0064:
					num = 8;
					num5 = checked(array.Length - 1);
					num6 = 0;
					goto IL_0072;
					IL_0072:
					if (num6 <= num5)
					{
						goto IL_0078;
					}
					goto IL_00c5;
					IL_0078:
					num = 9;
					text2 = Conversion.Hex(array[num6]);
					goto IL_0088;
					IL_0088:
					num = 10;
					if (Strings.Len(text2) == 1)
					{
						goto IL_0096;
					}
					goto IL_00b6;
					IL_0096:
					num = 11;
					text2 = "0" + text2;
					goto IL_00b6;
					IL_00b6:
					num = 13;
					text += text2;
					goto IL_00aa;
					IL_00aa:
					num = 14;
					num6 = checked(num6 + 1);
					goto IL_0072;
					end_IL_0000_2:
					break;
				}
				num = 18;
				obj = text;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 341;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
