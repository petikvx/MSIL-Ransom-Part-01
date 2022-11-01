using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cg6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Zj6;
using b9A;
using j3Z;
using n1X;
using t5H;

namespace i8Y;

[DesignerGenerated]
public class Xx9 : Form
{
	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("MadeBySuchan7820")]
	private Label _MadeBySuchan7820;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	private object _SessionMaker;

	internal static Wb2 wb2_0/* Not supported: data(A0 E6 7D 95 60 E2 48 82 E9 AB BA 00 5C 1D D1 D5 96 3C E3 D2 E0 18 E5 AD 1A 64 B6 51 D2 AB DE 71 46 3E 34 BC E0 15 06 62 DC F8 C3 55 5A 9F 55 50 65 8D B5 13 E0 85 5D 88 01 CE 7B FB 2B F6 AE 3E CB 48 B9 1D E7 14 F3 80 35 80 F4 E6 54 8F 52 79 0E 66 EA 45 F4 CA 90 BF DF AB BB 12 99 0A 36 E5 49 85 88 11 E5 37 67 50 98 34 DC 5F 90 75 33 70 7B 02 EC C4 0B 69 48 00 B7 F8 3C 3B 58 E1 E6 2B 49 0F 9D CE 06 40 92 D6 FD 9A AB C0 ED 30 2F 69 77 4A 95 97 1C 71 D9 DE 3C 87 59 EB F9 2C F6 B6 4D B1 15 80 D7 64 6A 3A 6E 16 C6 70 BD 87 12 86 C9 D2 C2 0E 4B 4F 0F D7 35 BD 91 7D E6 A6 DC D1 A2 F4 72 3B 1B AE 91 12 DF 5B 28 06 AA 68 21 B4 75 D1 22 27 68 E8 6A FD A2 3D 4A 19 D2 EB 52 C6 38 F3 CC C8 14 D5 6B 1B 40 AF 2E EF 26 08 2D CB 9C DB 08 15 84 B4 68 B9 89 74 98 DC 63 77 3F F2 08 61 CC B5 9B 58 9F 9E 65 07 E5 B7 B9 7A D6 99 0F 7E 7C F6 E2 3D 42 82 8A 13 3E 9F 3C 8D B6 C8) */;

	internal static byte[] byte_0;

	private Ny0.Na5 na5_0;

	internal virtual GroupBox SessionMakerInst
	{
		get
		{
			return na5_0.groupBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			na5_0.groupBox_0 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return na5_0.groupBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			na5_0.groupBox_1 = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual Label MadeBySuchan7820
	{
		get
		{
			return _MadeBySuchan7820;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MadeBySuchan7820 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return na5_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			na5_0.label_0 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	public object Logbox
	{
		get
		{
			return na5_0.object_0;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_0 = objectValue;
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
			return na5_0.object_1;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_1 = objectValue;
		}
	}

	public object ProcNotier
	{
		get
		{
			return na5_0.object_2;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_2 = objectValue;
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
			return na5_0.object_3;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_3 = objectValue;
		}
	}

	public object CheckProc
	{
		get
		{
			return na5_0.object_4;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_4 = objectValue;
		}
	}

	public object SessionMakerTime
	{
		get
		{
			return na5_0.object_5;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_5 = objectValue;
		}
	}

	public object RecentAct
	{
		get
		{
			return na5_0.object_6;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			na5_0.object_6 = objectValue;
		}
	}

	public Xx9()
	{
		((Form)this).add_Load((EventHandler)Mi1);
		IConvertible convertible = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "3445tygfdfg.log");
		na5_0.string_0 = (string)convertible;
		o8B();
	}

	protected override void Eo9(bool Li7)
	{
		try
		{
			if (Li7 && na5_0.icontainer_0 != null)
			{
				na5_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Li7);
		}
	}

	private void o8B()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		SessionMakerInst = new GroupBox();
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		Label2 = new Label();
		GroupBox2 = new GroupBox();
		Label3 = new Label();
		MadeBySuchan7820 = new Label();
		((Control)SessionMakerInst).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)SessionMakerInst).get_Controls().Add((Control)(object)Label1);
		((Control)SessionMakerInst).set_Font(new Font("맑은 고딕", 10f));
		((Control)SessionMakerInst).set_Location(new Point(12, 12));
		((Control)SessionMakerInst).set_Name("SessionMakerInst");
		((Control)SessionMakerInst).set_Size(new Size(360, 87));
		((Control)SessionMakerInst).set_TabIndex(0);
		SessionMakerInst.set_TabStop(false);
		SessionMakerInst.set_Text("1인 공개세션 만들기");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(6, 21));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(336, 57));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("10초 동안 GTA 온라인 세션과의 연결을 해제합니다.\r\n일정 플레이어가 모여야 시작되는 작업들의 경우\r\n이 기능을 사용하면 임무가 취소됩니다.");
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("맑은 고딕", 10f));
		((Control)GroupBox1).set_Location(new Point(12, 105));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(360, 87));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GTA 온라인 세션 방화벽 생성(호스트)");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(6, 21));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(341, 57));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("GTA 온라인이 사용하는 세션 포트를 차단합니다.\r\nGTA 온라인의 세션 정보를 차단하기 때문에\r\n자신 빼고는 아무도 현재 세션에 참가할 수 없습니다.");
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).set_Font(new Font("맑은 고딕", 10f));
		((Control)GroupBox2).set_Location(new Point(12, 198));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(360, 87));
		((Control)GroupBox2).set_TabIndex(0);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("GTA 온라인 세션 방화벽 제거(호스트)");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(6, 21));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(341, 57));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("GTA온라인이 사용하는 세션 포트를 개방합니다.\r\n플레이어가 현재 세션의 정보를 받을 수 있게 됩니다.\r\n이후 플레이어가 현재 세션에 참가할 수 있습니다.");
		MadeBySuchan7820.set_AutoSize(true);
		((Control)MadeBySuchan7820).set_Font(new Font("맑은 고딕", 11f));
		((Control)MadeBySuchan7820).set_ForeColor(Color.MediumPurple);
		((Control)MadeBySuchan7820).set_Location(new Point(15, 288));
		((Control)MadeBySuchan7820).set_Name("MadeBySuchan7820");
		((Control)MadeBySuchan7820).set_Size(new Size(353, 20));
		((Control)MadeBySuchan7820).set_TabIndex(0);
		MadeBySuchan7820.set_Text("Copyright ⓒ 2022 Suchan7820. All rights reserved.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(384, 311));
		((Control)this).get_Controls().Add((Control)(object)MadeBySuchan7820);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)SessionMakerInst);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("HelpForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("도움말");
		((Form)this).set_TopMost(true);
		((Control)SessionMakerInst).ResumeLayout(false);
		((Control)SessionMakerInst).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Mi1(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		IComparable<string> comparable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "fgfgrer4r4.log");
		if (File.Exists((string)comparable))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText(comparable as string) }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void Ad0(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "gtrrete.log");
		File.Delete(obj as string);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.OrObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)2))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
	}

	private void Qj4(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		IEnumerable<char> enumerable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "nmjghrte4.log");
		if (!File.Exists((string)enumerable))
		{
			NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { "\r\r\r\r\r\r\r\r\r" }, (string[])null, (Type[])null, false, true);
			return;
		}
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Font", new object[1] { (object)new Font(Conversions.ToString(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToSingle(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Logbox, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(FontStyle)0))) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Logbox, (Type)null, "Text", new object[1] { File.ReadAllText((string)enumerable) }, (string[])null, (Type[])null, false, true);
	}

	private void Dr6(Process Fk8)
	{
		object enumerator = default(object);
		try
		{
			enumerator = Fk8.Threads.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				Component component = (ProcessThread)(enumerator as IEnumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), p7D: false, (component as ProcessThread).Id);
				if (intPtr != IntPtr.Zero)
				{
					b0B(intPtr);
					t0S(intPtr);
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

	private void t0S(IntPtr e4G)
	{
		throw new NotImplementedException();
	}

	private void b0B(IntPtr Mn5)
	{
		throw new NotImplementedException();
	}

	private void d9E(Process y3K)
	{
		object enumerator = default(object);
		try
		{
			enumerator = y3K.Threads.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				Component component = (ProcessThread)((IEnumerator)enumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), p7D: false, ((ProcessThread)component).Id);
				if (intPtr != IntPtr.Zero)
				{
					r8S(intPtr);
					t0S(intPtr);
				}
			}
		}
		finally
		{
			if ((enumerator as IEnumerator) is IDisposable)
			{
				((enumerator as IEnumerator) as IDisposable).Dispose();
			}
		}
	}

	private void r8S(IntPtr Yq8)
	{
		throw new NotImplementedException();
	}

	private void Ai9(object sender, EventArgs e)
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

	private void Dq9(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("G543TA5");
		if ((processesByName as Process[]).Count() == 0)
		{
			NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(ProcNotier, (Type)null, "Text", new object[1] { "GTA5.exe를 찾지 못했습니다.\rGrand Theft Auto V가 실행되었는지 확인하십시오." }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(CheckProc, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(CheckProcSub, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Hf8(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("GT4tedrA5");
		Dr6(((Process[])processesByName)[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "잠시만 기다려 주세요..." }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Xa2(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("GT54eA5");
		d9E((processesByName as Process[])[0]);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Text", new object[1] { "1인 공개세션 만들기" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SessionMaker, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { "1P Public Session has been created successfully" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(SessionMakerTime, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(na5_0.string_0, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] 1인 공개세션이 만들어짐\r", true);
	}

	private void q7X(object sender, EventArgs e)
	{
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "AddFirewall.bat");
		Process.Start((string)obj);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall added completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(na5_0.string_0, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 생성됨\r", true);
	}

	private void j9K(object sender, EventArgs e)
	{
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "DelFirewall.bat");
		Process.Start(obj as string);
		NewLateBinding.LateSetComplex(RecentAct, (Type)null, "Text", new object[1] { " Firewall removed completely" }, (string[])null, (Type[])null, false, true);
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(na5_0.string_0, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 제거됨\r", true);
	}

	private void d8E(object sender, EventArgs e)
	{
		Form val = (Form)(object)new Xx9();
		((Control)(Xx9)(object)val).Show();
	}

	private void d8Y(object sender, EventArgs e)
	{
		Form val = (Form)(object)new f2K();
		((Control)(f2K)(object)val).Show();
	}

	internal static object Rb1(object Ed8, byte[] Rm8, int j5S)
	{
		object obj = new List<string>();
		(obj as List<string>).Add("NMNMH");
		((List<string>)obj).Add("44TRG");
		(obj as List<string>).Add("JY5Y4");
		Array array = (byte[])Ed8;
		checked
		{
			int num = ((byte[])Ed8).Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Rw2.k9S(j5S, Rm8.Length, null, null, 1);
				int num3 = num2 & j5S;
				int num4 = Rm8[Rw2.k9S(i, Rm8.Length, null, null, 1)];
				((byte[])array)[i] = (byte)Rw2.k9S(0, 0, RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Ed8, new object[1] { i }, (string[])null)), Rw2.k9S(0, 0, num4, num3, 2), 2);
			}
			q8S.Db2((byte[])array, 35, 0);
			return null;
		}
	}
}
