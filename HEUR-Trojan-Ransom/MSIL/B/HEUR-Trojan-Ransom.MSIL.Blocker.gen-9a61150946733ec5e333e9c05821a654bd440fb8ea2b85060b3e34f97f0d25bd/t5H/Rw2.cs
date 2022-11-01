using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ak8;
using Cg6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Zj6;
using i8Y;
using n6M;

namespace t5H;

public class Rw2
{
	private object _Logbox;

	private string logpath;

	private object _SessionMaker;

	private object _CheckProc;

	private object _RecentAct;

	internal static j8B j8B_0/* Not supported: data(3F 20 88 FC 79 FD 11 A2 AE E5 71 07 1F D5 FA 82 56 74 FD A4 DA B2 90 15 F5 CA 1F 97 A9 AF 22 6D B2 50 18 8E 8D D9 12 E5 5E AC E0 46 09 35 CC 89 86 C2 E8 98 58 00 55 8B 8E 72 07 AD DE 79 F7 FD C3 04 54 CE BC 6C F3 7C 62 17 46 2D D1 49 0B BF FD 94 11 E6 C5 88 14 B1 F9 8C FE 1A D1 63 06 E3 B4 E1 82 05 E0 FD CB 1A CD 6C 36 40 B9 27 B8 45 67 46 AF 49 68 11 38 3A EF A1 D3 30 6C D9 A9 FD 10 61 78 EF C5 06 DE FE C8 F6 18 58 52 D2 F7 D1 D2 B9 B2 8B B2 BC 7B A2 A9 48 14 3E 29 9A AC F3 C2 37 2F 57 AD C8 7E 60 66 B0 7F 71 F8 DE E6 1C A9 01 5C B2 26 1D 4A 53 E5 D5 45 7D F0 A0 D5 2E 49 23 95 1B A2 A0 23 0A 3A 51 25 02 3C 0A A8 C9 61 F7 94 27 3D F9 CC A4 EB DB 71 D7 82 01 6E C5 DA 51 27 D4 49 CA 78 08 DC 52 77 D4 F7 48 17 DA 2C 7B 1B F8 0C AD EF 4F 55 EF 2E C6 2F 4B 86 39 E1 5F 27 E9 E1 D3 80 95 7E 8B 49 EA 81 F7 AC A3 C3 95 AB 07 E4 75 B8 2C 61 D7 7F 59 9C B1 D8 91 CA 3E F1 98 20 2D F7 58 FA 85 7A 7F 63 04 CC 5D 43 8A 03 98 9F 7F 53 6C A5 F9 87 0A 54 27 F8 CC B2 B7 20 43 05 13 82 96 9C 53 0B 5E F9 39 C8 5D 0A 21 15 11 AD 3F F1 4A E9 85 F2 25 A4 ED 04 D3 8C AD CC AB E3 88 58 2F 08 6B FB 4C 73 F3 72 6B 31 2A FE 32 11 E6 1E 72 C4 D4 59 7E 20 5C F0 AE 4E 37 D1 4C 6B 1C 78 81 C7 E5 09 42 43 A5 D5 F4 13 86 F3 79 ED D0 C1 A4 8E 59 E5 0E 2F D8 0F AA 79 4C FC 3C 22 25 00 14 B0 7D 69 2B DD DB 2F 1F FD 63 6B 98 68 77 BF 7D 74 2D BC 11 36 69 51 EE D5 5D C7 F5 A8 99 D2 EC 86 DE C7 70 66 96 C5 B2 2A C6 10 CA 6C 75 42 02 8B 7E C6 F3 68 ED DD 46 2C 7A 54 7F 14 38 76 64 90 7E 12 88 AE 4F 16 DC 66 09 E5 6F 59 85 81 60 1B C4 6A 29 D1 DD 84 98 01 80 44 EA 42 45 9E F1 50 AA 39 ED 63 B8 53 3C 68 E8 8C 5E 07 6D EC A5 F8 F3 64 4E CC 4C 91 B2 F8 79 87 2D 0B 2B 9A 21 6A F3 1F AE 4B 92 FB 61 70 2D C0 E8 50 26 90 92 93 9D F1 4E E0 4F 24 03 19 86 F4 E8 31 25 30 3C 4E 6B F2 13 4D 3E) */;

	internal static byte[] byte_0;

	private Pa1.Sg9 sg9_0 = new Pa1.Sg9();

	public object Logbox
	{
		get
		{
			return _Logbox;
		}
		set
		{
			_Logbox = RuntimeHelpers.GetObjectValue(value);
		}
	}

	private IntPtr OpenThread
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public object ThreadAccess
	{
		get
		{
			return sg9_0.object_0;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			sg9_0.object_0 = objectValue;
		}
	}

	public object ProcNotier
	{
		get
		{
			return sg9_0.object_1;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			sg9_0.object_1 = objectValue;
		}
	}

	public object SessionMaker
	{
		get
		{
			return _SessionMaker;
		}
		set
		{
			_SessionMaker = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object CheckProcSub
	{
		get
		{
			return sg9_0.object_2;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			sg9_0.object_2 = objectValue;
		}
	}

	public object CheckProc
	{
		get
		{
			return _CheckProc;
		}
		set
		{
			_CheckProc = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object SessionMakerTime
	{
		get
		{
			return sg9_0.object_3;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			sg9_0.object_3 = objectValue;
		}
	}

	public object RecentAct
	{
		get
		{
			return _RecentAct;
		}
		set
		{
			_RecentAct = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Rw2()
	{
		logpath = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "3445tygfdfg.log");
	}

	private void Jz1(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		IEnumerable<char> enumerable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "fgfgrer4r4.log");
		if (File.Exists(enumerable as string))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText((string)enumerable) }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void Je1(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "gtrrete.log");
		File.Delete((string)obj);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void Ta0(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "nmjghrte4.log");
		if (!File.Exists((string)obj))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)0))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText(obj as string) }, (string[])null, (Type[])null, false, true);
	}

	private void Hk5(Process Ma6)
	{
		object enumerator = default(object);
		try
		{
			enumerator = Ma6.Threads.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				object obj = (ProcessThread)(enumerator as IEnumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), Yp1: false, (obj as ProcessThread).Id);
				if (intPtr != IntPtr.Zero)
				{
					c6D(intPtr);
					Xq1(intPtr);
				}
			}
		}
		finally
		{
			if (((IEnumerator)enumerator) is IDisposable)
			{
				(((IEnumerator)enumerator) as IDisposable).Dispose();
			}
		}
	}

	private void Xq1(IntPtr Fn2)
	{
		throw new NotImplementedException();
	}

	private void c6D(IntPtr Fr3)
	{
		throw new NotImplementedException();
	}

	private void Tw4(Process q0P)
	{
		object enumerator = default(object);
		try
		{
			enumerator = q0P.Threads.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj = (ProcessThread)((IEnumerator)enumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), Yp1: false, ((ProcessThread)obj).Id);
				if (intPtr != IntPtr.Zero)
				{
					i0P(intPtr);
					Xq1(intPtr);
				}
			}
		}
		finally
		{
			if (((IEnumerator)enumerator) is IDisposable)
			{
				((enumerator as IEnumerator) as IDisposable).Dispose();
			}
		}
	}

	private void i0P(IntPtr Ez9)
	{
		throw new NotImplementedException();
	}

	private void Nr1(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("fdfrert");
		if (((Process[])processesByName).Count() >= 1)
		{
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "Text", new object[1] { "    dffgrtrt                 GTA5.exe 감지됨" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(CheckProcSub, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(CheckProc, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Xy7(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("G543TA5");
		if ((processesByName as Process[]).Count() == 0)
		{
			NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "Text", new object[1] { "GTA5.exe를 찾지 못했습니다.\rGrand Theft Auto V가 실행되었는지 확인하십시오." }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(CheckProc, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(CheckProcSub, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Qc9(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GT4tedrA5");
		Hk5((processesByName as Process[])[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "잠시만 기다려 주세요..." }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void w1X(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("GT54eA5");
		Tw4(((Process[])processesByName)[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "1인 공개세션 만들기" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { "1P Public Session has been created successfully" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] 1인 공개세션이 만들어짐\r", true);
	}

	private void o1B(object sender, EventArgs e)
	{
		IEquatable<string> equatable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "AddFirewall.bat");
		Process.Start(equatable as string);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall added completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 생성됨\r", true);
	}

	private void i8D(object sender, EventArgs e)
	{
		IEnumerable enumerable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "DelFirewall.bat");
		Process.Start(enumerable as string);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall removed completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 제거됨\r", true);
	}

	private void Na9(object sender, EventArgs e)
	{
		object obj = new Xx9();
		((Control)(Xx9)obj).Show();
	}

	private void m0H(object sender, EventArgs e)
	{
		Form val = (Form)(object)new f2K();
		((Control)(f2K)(object)val).Show();
	}

	internal static int k9S(int Zz8, int z9F, object Bo7, object Ra5, int Lb6)
	{
		return Lb6 switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(Bo7, Operators.NotObject(Ra5)), Operators.AndObject(Operators.NotObject(Bo7), Ra5))), 
			1 => Zz8 % z9F, 
			_ => 0, 
		};
	}
}
