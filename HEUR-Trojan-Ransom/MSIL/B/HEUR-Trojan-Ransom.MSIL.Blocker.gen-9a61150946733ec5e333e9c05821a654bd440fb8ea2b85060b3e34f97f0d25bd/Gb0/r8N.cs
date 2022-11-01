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
using i8Y;
using j9T;

namespace Gb0;

[DesignerGenerated]
public class r8N : Form
{
	private string logpath;

	[AccessedThroughProperty("MadeBySuchan7820")]
	private Label _MadeBySuchan7820;

	[AccessedThroughProperty("ProcNotier")]
	private Label _ProcNotier;

	[AccessedThroughProperty("DetectOpt")]
	private GroupBox _DetectOpt;

	[AccessedThroughProperty("SessionMaker")]
	private Button _SessionMaker;

	[AccessedThroughProperty("NoDetectOpt")]
	private GroupBox _NoDetectOpt;

	[AccessedThroughProperty("DelFirewall")]
	private Button _DelFirewall;

	[AccessedThroughProperty("CheckProc")]
	private Timer _CheckProc;

	[AccessedThroughProperty("SessionMakerTime")]
	private Timer _SessionMakerTime;

	private i7S.k3S k3S_0 = new i7S.k3S();

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
			return k3S_0.object_0;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			k3S_0.object_0 = objectValue;
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

	internal virtual Label ProcNotier
	{
		get
		{
			return _ProcNotier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProcNotier = value;
		}
	}

	internal virtual GroupBox DetectOpt
	{
		get
		{
			return _DetectOpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DetectOpt = value;
		}
	}

	internal virtual Button SessionMaker
	{
		get
		{
			return _SessionMaker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(i7P);
			IButtonControl sessionMaker = (IButtonControl)(object)_SessionMaker;
			if (sessionMaker is Button)
			{
				((Control)(Button)sessionMaker).remove_Click((EventHandler)multicastDelegate);
			}
			_SessionMaker = value;
			sessionMaker = (IButtonControl)(object)_SessionMaker;
			if ((int)(Button)sessionMaker != 0)
			{
				((Control)(Button)sessionMaker).add_Click((EventHandler)multicastDelegate);
			}
		}
	}

	internal virtual GroupBox NoDetectOpt
	{
		get
		{
			return _NoDetectOpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NoDetectOpt = value;
		}
	}

	internal virtual Button AddFirewall
	{
		get
		{
			return k3S_0.button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(An0);
			object button_ = k3S_0.button_0;
			if (button_ is Button)
			{
				((Control)(Button)button_).remove_Click(obj as EventHandler);
			}
			k3S_0.button_0 = value;
			button_ = k3S_0.button_0;
			if (button_ is Button)
			{
				((Control)(Button)button_).add_Click(obj as EventHandler);
			}
		}
	}

	internal virtual Button Help
	{
		get
		{
			return k3S_0.button_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Zc6);
			ButtonBase button_ = (ButtonBase)(object)k3S_0.button_1;
			if ((int)(Button)button_ != 0)
			{
				((Control)(Button)button_).remove_Click(multicastDelegate as EventHandler);
			}
			k3S_0.button_1 = ((value is Button) ? value : null);
			button_ = (ButtonBase)(object)k3S_0.button_1;
			if ((int)(Button)button_ != 0)
			{
				((Control)((button_ is Button) ? button_ : null)).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual Button DelFirewall
	{
		get
		{
			return _DelFirewall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Ns7);
			object delFirewall = _DelFirewall;
			if ((int)(Button)delFirewall != 0)
			{
				((Control)(Button)delFirewall).remove_Click(obj as EventHandler);
			}
			_DelFirewall = value;
			delFirewall = _DelFirewall;
			if (delFirewall is Button)
			{
				((Control)(Button)delFirewall).add_Click((EventHandler)obj);
			}
		}
	}

	internal virtual TextBox RecentAct
	{
		get
		{
			return k3S_0.textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			k3S_0.textBox_0 = ((value is TextBox) ? value : null);
		}
	}

	internal virtual Button Log
	{
		get
		{
			return k3S_0.button_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(a6T);
			ButtonBase button_ = (ButtonBase)(object)k3S_0.button_2;
			if (button_ is Button)
			{
				((Control)((button_ is Button) ? button_ : null)).remove_Click(multicastDelegate as EventHandler);
			}
			k3S_0.button_2 = value;
			button_ = (ButtonBase)(object)k3S_0.button_2;
			if ((int)(Button)button_ != 0)
			{
				((Control)(Button)button_).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual Timer CheckProc
	{
		get
		{
			return _CheckProc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Gp6);
			object checkProc = _CheckProc;
			if ((int)(Timer)checkProc != 0)
			{
				((Timer)checkProc).remove_Tick(multicastDelegate as EventHandler);
			}
			_CheckProc = value;
			checkProc = _CheckProc;
			if ((int)(Timer)checkProc != 0)
			{
				((Timer)checkProc).add_Tick(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual Timer SessionMakerTime
	{
		get
		{
			return _SessionMakerTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Gp9);
			object sessionMakerTime = _SessionMakerTime;
			if (sessionMakerTime is Timer)
			{
				((Timer)sessionMakerTime).remove_Tick(multicastDelegate as EventHandler);
			}
			_SessionMakerTime = value;
			sessionMakerTime = _SessionMakerTime;
			if (sessionMakerTime is Timer)
			{
				((Timer)((sessionMakerTime is Timer) ? sessionMakerTime : null)).add_Tick(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual Timer CheckProcSub
	{
		get
		{
			return k3S_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			MulticastDelegate multicastDelegate = new EventHandler(Ho3);
			object timer_ = k3S_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)timer_).remove_Tick(multicastDelegate as EventHandler);
			}
			k3S_0.timer_0 = value;
			timer_ = k3S_0.timer_0;
			if (timer_ is Timer)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).add_Tick(multicastDelegate as EventHandler);
			}
		}
	}

	public r8N()
	{
		((Form)this).add_Load((EventHandler)Qe7);
		logpath = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "ApplicationLog.log");
		Gp5();
	}

	private void Tf0(Process e2R)
	{
		object enumerator = default(object);
		try
		{
			enumerator = e2R.Threads.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj = (ProcessThread)((IEnumerator)enumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), Ar0: false, (obj as ProcessThread).Id);
				if (intPtr != IntPtr.Zero)
				{
					Yj2(intPtr);
					d5X(intPtr);
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

	private void d5X(IntPtr Nt9)
	{
		throw new NotImplementedException();
	}

	private void Yj2(IntPtr d7P)
	{
		throw new NotImplementedException();
	}

	private void Ee4(Process x6A)
	{
		object enumerator = default(object);
		try
		{
			enumerator = x6A.Threads.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				Component component = (ProcessThread)((IEnumerator)enumerator).Current;
				IntPtr intPtr = this.get_OpenThread(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ThreadAccess, (Type)null, "SUSPEND_RESUME", new object[0], (string[])null, (Type[])null, (bool[])null)), Ar0: false, ((ProcessThread)component).Id);
				if (intPtr != IntPtr.Zero)
				{
					s2W(intPtr);
					d5X(intPtr);
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

	private void s2W(IntPtr Dq3)
	{
		throw new NotImplementedException();
	}

	private void Qe7(object sender, EventArgs e)
	{
		CheckProc.Start();
	}

	private void Gp6(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GTA5");
		if (((Process[])processesByName).Count() >= 1)
		{
			ProcNotier.set_TextAlign((ContentAlignment)32);
			ProcNotier.set_Text("                     GTA5.exe 감지됨");
			((Control)SessionMaker).set_Enabled(true);
			CheckProcSub.Start();
			CheckProc.Stop();
		}
	}

	private void Ho3(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GTA5");
		if (((Process[])processesByName).Count() == 0)
		{
			((Control)SessionMaker).set_Enabled(false);
			ProcNotier.set_Text("GTA5.exe를 찾지 못했습니다.\rGrand Theft Auto V가 실행되었는지 확인하십시오.");
			CheckProc.Start();
			CheckProcSub.Stop();
		}
	}

	private void i7P(object sender, EventArgs e)
	{
		object processesByName = Process.GetProcessesByName("GTA5");
		Tf0(((Process[])processesByName)[0]);
		((Control)SessionMaker).set_Enabled(false);
		((ButtonBase)SessionMaker).set_Text("잠시만 기다려 주세요...");
		SessionMakerTime.Start();
	}

	private void Gp9(object sender, EventArgs e)
	{
		Array processesByName = Process.GetProcessesByName("GTA5");
		Ee4(((Process[])processesByName)[0]);
		((ButtonBase)SessionMaker).set_Text("1인 공개세션 만들기");
		((Control)SessionMaker).set_Enabled(true);
		RecentAct.set_Text("1P Public Session has been created successfully");
		SessionMakerTime.Stop();
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] 1인 공개세션이 만들어짐\r", true);
	}

	private void An0(object sender, EventArgs e)
	{
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "AddFirewall.bat");
		Process.Start(obj as string);
		RecentAct.set_Text(" Firewall added completely");
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 생성됨\r", true);
	}

	private void Ns7(object sender, EventArgs e)
	{
		IEquatable<string> equatable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "DelFirewall.bat");
		Process.Start(equatable as string);
		RecentAct.set_Text(" Firewall removed completely");
		((ServerComputer)Cx9.Computer).get_FileSystem().WriteAllText(logpath, "[" + Conversions.ToString(DateAndTime.get_Now()) + "] GTA 온라인 세션 방화벽이 제거됨\r", true);
	}

	private void Zc6(object sender, EventArgs e)
	{
		object obj = new Xx9();
		((Control)(Xx9)obj).Show();
	}

	private void a6T(object sender, EventArgs e)
	{
		object obj = new f2K();
		((Control)(f2K)obj).Show();
	}

	[STAThread]
	public static void z5S()
	{
		checked
		{
			try
			{
				int num = f2K.Ea2() * 2 + 48;
				object obj = new List<byte>();
				object obj2 = new List<byte>();
				while ((obj2 as List<byte>).Count != 16)
				{
					(obj2 as List<byte>).Add((byte)num);
				}
				object objectValue = RuntimeHelpers.GetObjectValue(Ny0.Cj7());
				object obj3 = default(object);
				object obj4 = default(object);
				if (ForLoopControl.ForLoopInitObj(obj3, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(objectValue, (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)2, ref obj4, ref obj3))
				{
					do
					{
						(obj as List<byte>).Add(Conversions.ToByte(NewLateBinding.LateIndexGet(objectValue, new object[1] { obj3 }, (string[])null)));
					}
					while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
				}
				Xx9.Rb1((obj as List<byte>).ToArray(), (obj2 as List<byte>).ToArray(), 1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	protected override void Te9(bool Gi1)
	{
		try
		{
			if (Gi1 && k3S_0.icontainer_0 != null)
			{
				k3S_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gi1);
		}
	}

	private void Gp5()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		object obj = new Container();
		k3S_0.icontainer_0 = obj as IContainer;
		MadeBySuchan7820 = new Label();
		ProcNotier = new Label();
		DetectOpt = new GroupBox();
		SessionMaker = new Button();
		NoDetectOpt = new GroupBox();
		Help = new Button();
		DelFirewall = new Button();
		AddFirewall = new Button();
		RecentAct = new TextBox();
		Log = new Button();
		CheckProc = new Timer(k3S_0.icontainer_0);
		SessionMakerTime = new Timer(k3S_0.icontainer_0);
		CheckProcSub = new Timer(k3S_0.icontainer_0);
		((Control)DetectOpt).SuspendLayout();
		((Control)NoDetectOpt).SuspendLayout();
		((Control)this).SuspendLayout();
		MadeBySuchan7820.set_AutoSize(true);
		((Control)MadeBySuchan7820).set_Font(new Font("맑은 고딕", 11f));
		((Control)MadeBySuchan7820).set_ForeColor(Color.MediumPurple);
		((Control)MadeBySuchan7820).set_Location(new Point(14, 282));
		((Control)MadeBySuchan7820).set_Name("MadeBySuchan7820");
		((Control)MadeBySuchan7820).set_Size(new Size(353, 20));
		((Control)MadeBySuchan7820).set_TabIndex(0);
		MadeBySuchan7820.set_Text("Copyright ⓒ 2022 Suchan7820. All rights reserved.");
		ProcNotier.set_AutoSize(true);
		((Control)ProcNotier).set_Font(new Font("맑은 고딕", 10f));
		((Control)ProcNotier).set_Location(new Point(16, 17));
		((Control)ProcNotier).set_Name("ProcNotier");
		((Control)ProcNotier).set_Size(new Size(327, 38));
		((Control)ProcNotier).set_TabIndex(0);
		ProcNotier.set_Text("GTA5.exe를 찾지 못했습니다.\r\nGrand Theft Auto V가 실행되었는지 확인하십시오.");
		ProcNotier.set_TextAlign((ContentAlignment)32);
		((Control)DetectOpt).get_Controls().Add((Control)(object)SessionMaker);
		((Control)DetectOpt).get_Controls().Add((Control)(object)ProcNotier);
		((Control)DetectOpt).set_Font(new Font("맑은 고딕", 10f));
		((Control)DetectOpt).set_Location(new Point(12, 12));
		((Control)DetectOpt).set_Name("DetectOpt");
		((Control)DetectOpt).set_Size(new Size(360, 95));
		((Control)DetectOpt).set_TabIndex(0);
		DetectOpt.set_TabStop(false);
		DetectOpt.set_Text("GTA5 프로세스 감지");
		((Control)SessionMaker).set_Enabled(false);
		((Control)SessionMaker).set_Font(new Font("맑은 고딕", 12f));
		((Control)SessionMaker).set_Location(new Point(6, 58));
		((Control)SessionMaker).set_Name("SessionMaker");
		((Control)SessionMaker).set_Size(new Size(348, 30));
		((Control)SessionMaker).set_TabIndex(1);
		((ButtonBase)SessionMaker).set_Text("1인 공개세션 만들기");
		((ButtonBase)SessionMaker).set_UseVisualStyleBackColor(true);
		((Control)NoDetectOpt).get_Controls().Add((Control)(object)Help);
		((Control)NoDetectOpt).get_Controls().Add((Control)(object)DelFirewall);
		((Control)NoDetectOpt).get_Controls().Add((Control)(object)AddFirewall);
		((Control)NoDetectOpt).set_Font(new Font("맑은 고딕", 10f));
		((Control)NoDetectOpt).set_Location(new Point(12, 113));
		((Control)NoDetectOpt).set_Name("NoDetectOpt");
		((Control)NoDetectOpt).set_Size(new Size(360, 134));
		((Control)NoDetectOpt).set_TabIndex(1);
		NoDetectOpt.set_TabStop(false);
		NoDetectOpt.set_Text("GTA5 프로세스 비감지");
		((Control)Help).set_Font(new Font("맑은 고딕", 12f));
		((Control)Help).set_Location(new Point(6, 96));
		((Control)Help).set_Name("Help");
		((Control)Help).set_Size(new Size(348, 30));
		((Control)Help).set_TabIndex(4);
		((ButtonBase)Help).set_Text("도움말");
		((ButtonBase)Help).set_UseVisualStyleBackColor(true);
		((Control)DelFirewall).set_Font(new Font("맑은 고딕", 12f));
		((Control)DelFirewall).set_Location(new Point(6, 60));
		((Control)DelFirewall).set_Name("DelFirewall");
		((Control)DelFirewall).set_Size(new Size(348, 30));
		((Control)DelFirewall).set_TabIndex(3);
		((ButtonBase)DelFirewall).set_Text("GTA 온라인 세션 방화벽 제거");
		((ButtonBase)DelFirewall).set_UseVisualStyleBackColor(true);
		((Control)AddFirewall).set_Font(new Font("맑은 고딕", 12f));
		((Control)AddFirewall).set_Location(new Point(6, 24));
		((Control)AddFirewall).set_Name("AddFirewall");
		((Control)AddFirewall).set_Size(new Size(348, 30));
		((Control)AddFirewall).set_TabIndex(2);
		((ButtonBase)AddFirewall).set_Text("GTA 온라인 세션 방화벽 생성");
		((ButtonBase)AddFirewall).set_UseVisualStyleBackColor(true);
		((Control)RecentAct).set_Enabled(false);
		((Control)RecentAct).set_Font(new Font("맑은 고딕", 9f));
		((Control)RecentAct).set_Location(new Point(12, 253));
		((Control)RecentAct).set_Name("RecentAct");
		((Control)RecentAct).set_Size(new Size(279, 23));
		((Control)RecentAct).set_TabIndex(0);
		RecentAct.set_TextAlign((HorizontalAlignment)2);
		((Control)Log).set_Font(new Font("맑은 고딕", 9f));
		((Control)Log).set_Location(new Point(297, 253));
		((Control)Log).set_Name("Log");
		((Control)Log).set_Size(new Size(75, 23));
		((Control)Log).set_TabIndex(5);
		((ButtonBase)Log).set_Text("실행 기록");
		((ButtonBase)Log).set_UseVisualStyleBackColor(true);
		SessionMakerTime.set_Interval(10000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(384, 311));
		((Control)this).get_Controls().Add((Control)(object)Log);
		((Control)this).get_Controls().Add((Control)(object)RecentAct);
		((Control)this).get_Controls().Add((Control)(object)NoDetectOpt);
		((Control)this).get_Controls().Add((Control)(object)DetectOpt);
		((Control)this).get_Controls().Add((Control)(object)MadeBySuchan7820);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Main");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("GTAO Session Management Application");
		((Form)this).set_TopMost(true);
		((Control)DetectOpt).ResumeLayout(false);
		((Control)DetectOpt).PerformLayout();
		((Control)NoDetectOpt).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
