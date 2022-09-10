using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[StandardModule]
internal sealed class _________________________________________________________________
{
	public static string _ = _003CModule_003E.__________(34588, 37139, (int)((nint)Type.EmptyTypes.LongLength + 143));

	private static FileStream m___;

	public static void _()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 57:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				_________________________________________________________________.m___ = new FileStream(_____________________________________________________________________________.__, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 57;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 49:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				_________________________________________________________________.m___.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 49;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	public unsafe static void _____(string string_0)
	{
		nint num;
		int num2 = default(int);
		if (Operators.CompareString(string_0, _003CModule_003E.______<string>(2383457398u), false) == 0)
		{
			num = (nint)Type.EmptyTypes.LongLength + 2;
		}
		else if (Operators.CompareString(string_0, _003CModule_003E.___<string>(3762934230u), false) == 0)
		{
			num = (nint)Type.EmptyTypes.LongLength + 3;
		}
		else if (Operators.CompareString(string_0, _003CModule_003E.______<string>(3050598636u), false) == 0)
		{
			num = (((0x1A40 ^ (num2 << 16)) - 576863472 != (int)((uint)num2 % 29037696u >> 25)) ? (sizeof(byte) + 4) : (sizeof(ushort) + -1573355758));
		}
		else if (Operators.CompareString(string_0, _003CModule_003E.____<string>(1829879047u), false) == 0)
		{
			num = 7;
		}
		else
		{
			if (Operators.CompareString(string_0, _003CModule_003E.___<string>(3057207948u), false) != 0)
			{
				goto IL_00de;
			}
			num = sizeof(short) + 2;
		}
		goto IL_0221;
		IL_00de:
		num2 = 24831;
		int num4 = default(int);
		if (Operators.CompareString(string_0, _003CModule_003E.______<string>(4286198082u), false) != 0)
		{
			if (Operators.CompareString(string_0, _003CModule_003E.____<string>(1989248892u), false) == 0)
			{
				int num3 = default(int);
				if (num2 * -516800 - (num2 * 139395072 - -3271) == -6068)
				{
					if (1048576 * num3 + -457572352 != -(num3 << 22))
					{
						goto IL_0287;
					}
					num = (nint)Type.EmptyTypes.LongLength + -1527892062;
				}
				else
				{
					num3 = _003CModule_003E._______________;
					if (((num3 * (int)((uint)num3 / 6182u << 7)) ^ 0x241) != 7460)
					{
						if ((0x1800 & ((uint)num3 / 131072u / 5364125u)) == (uint)((num3 << 9 << 4) & 0x1800))
						{
							if (178749440 * num4 != 1813)
							{
								goto IL_0278;
							}
							num = sizeof(float) + 1937654322;
						}
						else
						{
							num = sizeof(byte) + 1505672208;
						}
					}
					else
					{
						num = (nint)Type.EmptyTypes.LongLength + -1951609268;
					}
				}
			}
			else
			{
				if (Operators.CompareString(string_0, _003CModule_003E.____<string>(2148618737u), false) != 0)
				{
					if (Operators.CompareString(string_0, _003CModule_003E.___<string>(93573293u), false) == 0)
					{
						______(Conversions.ToString(_____________________________________________________________________._________()));
					}
					else if (Operators.CompareString(string_0, _003CModule_003E._____<string>(2032625360u), false) == 0)
					{
						______(_003CModule_003E._____<string>(1451226774u) + (double)(Environment.TickCount - _________________________._.__) / 60000.0 + _003CModule_003E.______<string>(2618344987u));
					}
					return;
				}
				int num5 = ______________________._______;
				num = ((((512 * (0xDEC & num5)) ^ 0x1A47) == 0) ? (sizeof(byte) + 353601436) : ((nint)Type.EmptyTypes.LongLength + 6));
			}
			goto IL_0221;
		}
		if (num2 != 24831 || num4 + -1517131872 - 238752 == ~num4)
		{
			goto IL_02d7;
		}
		______(____________________());
		return;
		IL_02d7:
		______(_________________());
		return;
		IL_0221:
		switch (num)
		{
		case 1:
			break;
		case 0:
			goto IL_0278;
		default:
			goto IL_0287;
		case 3:
			______(________________());
			return;
		case 4:
			______(__________________() + _003CModule_003E._______<string>(1302917883u) + ___________________());
			return;
		case 5:
			goto IL_02d7;
		case 6:
			______(_____________________________________________________________________________.__);
			return;
		case 7:
			______(_______________());
			return;
		}
		goto IL_00de;
		IL_0278:
		______(______________());
		return;
		IL_0287:
		______(_003CModule_003E._______<string>(1354352154u) + _________());
	}

	public static void ______(string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 104:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 4:
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					if (Operators.CompareString(string_0, string.Empty, false) != 0)
					{
						break;
					}
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 5;
				______________________________________________________________.___________(_003CModule_003E._____<string>(3420599726u) + string_0 + _003CModule_003E.____<string>(3008796200u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				result = obj is Exception && num3 != 0 && num2 == 0;
				_003CModule_003E._____________ = 1326660401;
				return result;
			}).Invoke())
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 104;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string _______()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(_____________________________________________________________________________.__);
			return fileInfo.CreationTime.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.____<string>(2307988582u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ________()
	{
		try
		{
			Ping ping = new Ping();
			return ping.Send(______________________________________________________________._____________).RoundtripTime.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.______<string>(3591423010u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string _________()
	{
		try
		{
			int num;
			while (Operators.CompareString(__________________________________________________________________.____(_003CModule_003E._______<string>(2855919502u)), string.Empty, false) != 0)
			{
				num = -12431;
				if ((nint)Type.EmptyTypes.LongLength + 18791 != 16887)
				{
					return __________________________________________________________________.____(_003CModule_003E.____<string>(3233773404u));
				}
			}
			WebClient webClient = new WebClient();
			num = 19319;
			if ((nint)Type.EmptyTypes.LongLength + -12431 != 9834)
			{
			}
			DateTime now = DateAndTime.get_Now();
			webClient.DownloadData(_003CModule_003E.___<string>(2009413008u));
			if (num == 31148)
			{
				int num2 = _003CModule_003E._____________;
				if ((num2 << 25) - 6133 != 6947)
				{
				}
			}
			TimeSpan timeSpan = DateAndTime.get_Now().Subtract(now);
			webClient.Dispose();
			string string_ = _003CModule_003E.______<string>(616921273u);
			double num3 = Math.Round(5120.0 / (double)timeSpan.Seconds);
			global::___________._ = 1480675399;
			__________________________________________________________________._____(string_, num3 + _003CModule_003E.___<string>(214792501u));
			return __________________________________________________________________.____(_003CModule_003E._______<string>(2855919502u));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.___<string>(2654529686u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string __________()
	{
		try
		{
			string text = Dns.Resolve(Dns.GetHostName()).AddressList[0].ToString();
			if (Operators.CompareString(text, _003CModule_003E.__________(sizeof(double) + 755, (int)((nint)Type.EmptyTypes.LongLength + 1239), (int)((nint)Type.EmptyTypes.LongLength + 14)), false) == 0)
			{
				return text;
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.____<string>(1316596401u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ___________()
	{
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			return allNetworkInterfaces[0].GetPhysicalAddress().ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.___<string>(2354836464u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ____________()
	{
		try
		{
			return Screen.get_AllScreens().Length.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E._______<string>(1320268655u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string _____________()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PowerStatus powerStatus = SystemInformation.get_PowerStatus();
			string text = ((Enum)powerStatus.get_BatteryChargeStatus()).ToString();
			if (Operators.CompareString(text, _003CModule_003E._______<string>(2910692050u), false) == 0)
			{
				return _003CModule_003E._____<string>(1375549379u);
			}
			return ((Enum)powerStatus.get_BatteryChargeStatus()).ToString() + _003CModule_003E._____<string>(1488137976u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.___<string>(74062974u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ______________()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process processById = Process.GetProcessById(int_);
			string mainWindowTitle = processById.MainWindowTitle;
			string processName = processById.ProcessName;
			return _003CModule_003E.___<string>(1431141875u) + processName + _003CModule_003E._____<string>(1835178722u) + mainWindowTitle;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string empty = string.Empty;
			ProjectData.ClearProjectError();
			return empty;
		}
	}

	public static string _______________()
	{
		try
		{
			return Strings.Format((object)((double)((ServerComputer)global::_____________._).get_Info().get_TotalPhysicalMemory() / 1024.0 / 1024.0 / 1024.0), _003CModule_003E.____<string>(1109115442u));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.___<string>(2354836464u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ________________()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			ManagementObject val = new ManagementObject(_003CModule_003E.____<string>(3408360373u));
			val.Get();
			return ((ManagementBaseObject)val).get_Item(_003CModule_003E.___<string>(673120577u)).ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.______<string>(555695132u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string _________________()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ObjectQuery val = new ObjectQuery(_003CModule_003E._______<string>(3513190078u));
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val3).get_Item(_003CModule_003E._____<string>(967671166u))), (object)_003CModule_003E._______<string>(1557410348u)));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.___<string>(2354836464u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string __________________()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.______<string>(2535443485u) + Environment.MachineName + _003CModule_003E.______<string>(881407307u), _003CModule_003E._____<string>(2894567943u));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item(_003CModule_003E.___<string>(3401355253u)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = _003CModule_003E.____<string>(1316596401u);
			}
			return _003CModule_003E._____<string>(1262960782u) + text.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.____<string>(1746594822u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ___________________()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.____<string>(2657162520u) + Environment.MachineName + _003CModule_003E.______<string>(881407307u), _003CModule_003E.___<string>(225988232u));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item(_003CModule_003E._______<string>(1831273088u)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = _003CModule_003E._______<string>(2705614353u);
			}
			return _003CModule_003E._____<string>(183166660u) + text.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.____<string>(1228392692u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ____________________()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			TimeSpan timeSpan;
			Exception ex2 = default(Exception);
			try
			{
				PerformanceCounter val = new PerformanceCounter(_003CModule_003E._____<string>(4009323967u), _003CModule_003E.____<string>(3687007468u));
				val.NextValue();
				timeSpan = TimeSpan.FromSeconds(val.NextValue());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				ex2 = ex;
				throw ex2;
			}
			string[] array = new string[6]
			{
				Conversions.ToString(timeSpan.Days),
				null,
				null,
				null,
				null,
				null
			};
			int num = default(int);
			int num2 = default(int);
			if ((num | (612160 * num2 + -1436693347)) != -5234)
			{
				switch ((~((num & (num * 73555968 - num)) * 1024) != num * 288 + num * 736) ? ((nint)Type.EmptyTypes.LongLength + 0) : ((nint)Type.EmptyTypes.LongLength + -948606189))
				{
				}
			}
			array[1] = _003CModule_003E.___<string>(2282557474u);
			_003CModule_003E.___ = ex2;
			array[2] = Conversions.ToString(timeSpan.Hours);
			array[3] = _003CModule_003E.___<string>(487936967u);
			array[4] = Conversions.ToString(timeSpan.Minutes);
			array[5] = _003CModule_003E._______<string>(3245344505u);
			return string.Concat(array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.____<string>(1316596401u);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
