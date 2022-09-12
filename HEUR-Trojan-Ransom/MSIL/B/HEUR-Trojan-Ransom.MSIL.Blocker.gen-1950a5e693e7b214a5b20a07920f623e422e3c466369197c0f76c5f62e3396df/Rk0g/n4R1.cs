using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bi7;
using Co02;
using Mb5q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nr2m;
using Nt1m;
using Re2r;
using Rp8;
using e8Z;
using y0D5;
using y5P;

namespace Rk0g;

[DesignerGenerated]
public class n4R1 : Form
{
	private IContainer components;

	private const int WM_CHAR = 258;

	private const int EM_GETLINE = 196;

	private const int EM_GETLINECOUNT = 186;

	private bool btnApagadoPulsado;

	private int countDown;

	private double SumaBarra;

	private double Rojo;

	private double Verde;

	private double SumaResta;

	private object frmConsola;

	private object FrmMain;

	private bool CerrarServidor;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnShutdown
	{
		[CompilerGenerated]
		get
		{
			return _btnShutdown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Nj7c;
			Button val = _btnShutdown;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnShutdown = value;
			val = _btnShutdown;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnCancel
	{
		[CompilerGenerated]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xz0r;
			Button val = _btnCancel;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnCancel = value;
			val = _btnCancel;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timershutdown
	{
		[CompilerGenerated]
		get
		{
			return _Timershutdown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ri76;
			Timer timershutdown = _Timershutdown;
			if (timershutdown != null)
			{
				timershutdown.remove_Tick(eventHandler);
			}
			_Timershutdown = value;
			timershutdown = _Timershutdown;
			if (timershutdown != null)
			{
				timershutdown.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PanelProgresBar")]
	internal virtual Panel PanelProgresBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProgressBarr")]
	internal virtual Label lblProgressBarr
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public n4R1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(p2QP));
		((Form)this).add_Load((EventHandler)Dn38);
		((Form)this).add_Shown((EventHandler)q9K6);
		btnApagadoPulsado = false;
		countDown = 85;
		SumaBarra = 0.0;
		Rojo = 255.0;
		Verde = 30.0;
		SumaResta = (Rojo - Verde) / (double)checked(countDown - 30);
		w0YD();
	}

	[DebuggerNonUserCode]
	protected override void n2A8(bool w9C2)
	{
		try
		{
			if (w9C2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w9C2);
		}
	}

	[DebuggerStepThrough]
	private void w0YD()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(n4R1));
		Label1 = new Label();
		btnShutdown = new Button();
		btnCancel = new Button();
		Timershutdown = new Timer(components);
		PanelProgresBar = new Panel();
		lblProgressBarr = new Label();
		((Control)PanelProgresBar).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("Playbill", 18.15652f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(100, 70, 30));
		((Control)Label1).set_Location(new Point(2, 28));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(454, 35));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Coj2 Dedicated Server is running!!!");
		Label1.set_TextAlign((ContentAlignment)32);
		((ButtonBase)btnShutdown).set_AutoSize(true);
		((ButtonBase)btnShutdown).set_BackColor(Color.Firebrick);
		((Control)btnShutdown).set_Font(new Font("Segoe UI", 8.139131f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnShutdown).set_ForeColor(SystemColors.ControlLight);
		((Control)btnShutdown).set_Location(new Point(65, 132));
		((Control)btnShutdown).set_Margin(new Padding(3, 2, 3, 2));
		((Control)btnShutdown).set_Name("btnShutdown");
		((Control)btnShutdown).set_Size(new Size(139, 35));
		((Control)btnShutdown).set_TabIndex(29);
		((ButtonBase)btnShutdown).set_Text("Shutdown (10s)");
		((ButtonBase)btnShutdown).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnCancel).set_AutoSize(true);
		((ButtonBase)btnCancel).set_BackColor(Color.OliveDrab);
		((Control)btnCancel).set_Font(new Font("Segoe UI", 8.139131f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnCancel).set_ForeColor(SystemColors.ControlLight);
		((Control)btnCancel).set_Location(new Point(253, 132));
		((Control)btnCancel).set_Margin(new Padding(3, 2, 3, 2));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(139, 35));
		((Control)btnCancel).set_TabIndex(30);
		((ButtonBase)btnCancel).set_Text("Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(false);
		((Control)PanelProgresBar).set_BackColor(SystemColors.ControlLight);
		PanelProgresBar.set_BorderStyle((BorderStyle)1);
		((Control)PanelProgresBar).get_Controls().Add((Control)(object)lblProgressBarr);
		((Control)PanelProgresBar).set_Location(new Point(67, 88));
		((Control)PanelProgresBar).set_Name("PanelProgresBar");
		((Control)PanelProgresBar).set_Size(new Size(324, 19));
		((Control)PanelProgresBar).set_TabIndex(32);
		((Control)lblProgressBarr).set_BackColor(Color.FromArgb(255, 30, 30));
		((Control)lblProgressBarr).set_Location(new Point(0, 0));
		((Control)lblProgressBarr).set_Name("lblProgressBarr");
		((Control)lblProgressBarr).set_Size(new Size(51, 17));
		((Control)lblProgressBarr).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(459, 213));
		((Control)this).get_Controls().Add((Control)(object)PanelProgresBar);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnShutdown);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Font(new Font("Segoe UI", 8.139131f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(475, 252));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MinimumSize(new Size(475, 252));
		((Control)this).set_Name("frmClosingServer");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Closing Server...");
		((Control)PanelProgresBar).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int PostMessageA(int hwnd, int wMsg, int wParam, int lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_1(int hWnd, int wMsg, int wParam, int lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowExA(int hWnd1, int hWnd2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz2);

	private void Xz0r(object sender, EventArgs e)
	{
		CerrarServidor = false;
		((Form)this).Close();
		((Component)this).Dispose();
	}

	private void Nj7c(object sender, EventArgs e)
	{
		((Control)btnShutdown).set_Enabled(false);
		((Control)btnCancel).set_Enabled(false);
		checked
		{
			SumaBarra = (double)(((Control)PanelProgresBar).get_Width() - 2) / 80.0;
			btnApagadoPulsado = true;
			Timershutdown.set_Enabled(true);
			Label1.set_Text("Coj2 Dedicated Server is shutting down");
			Timershutdown.set_Enabled(true);
			string text = "/servershutdown";
			string lpClassName = "ConsoleWindowClass";
			string lpWindowName = null;
			int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
			int num = Strings.Len(text);
			for (int i = 1; i <= num; i++)
			{
				int wParam = Strings.Asc(Strings.Mid(text, i, 1));
				lpWindowName = Conversions.ToString(0L);
				SendMessageA(hwnd, 258, wParam, ref lpWindowName);
			}
			lpWindowName = Conversions.ToString(0L);
			SendMessageA(hwnd, 258, 13, ref lpWindowName);
			lpWindowName = Conversions.ToString(0L);
			SendMessageA(hwnd, 258, 10, ref lpWindowName);
			CerrarServidor = true;
		}
	}

	private void p2QP(object sender, FormClosingEventArgs e)
	{
		if (!btnApagadoPulsado)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else
		{
			((Component)this).Dispose();
		}
	}

	private void Ri76(object sender, EventArgs e)
	{
		if (countDown < 55)
		{
			Rojo -= SumaResta;
			Verde += SumaResta;
		}
		if (countDown == -1)
		{
			Timershutdown.set_Enabled(false);
			((Form)this).Close();
			((Component)this).Dispose();
			NewLateBinding.LateCall(FrmMain, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		NewLateBinding.LateCall(FrmMain, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		checked
		{
			if (Verde < 256.0)
			{
				((Control)lblProgressBarr).set_BackColor(Color.FromArgb((int)Conversion.Int(Rojo), (int)Conversion.Int(Verde), 30));
			}
			((Control)lblProgressBarr).set_Width((int)Math.Round((double)((Control)lblProgressBarr).get_Width() + Conversion.Int(SumaBarra)));
			if (Operators.CompareString(Strings.Mid(countDown.ToString().Trim(), 2, 1), "0", false) == 0)
			{
				Label1.set_Text(Label1.get_Text() + ".");
				((ButtonBase)btnShutdown).set_Text("Shutdown (" + ((double)countDown / 10.0).ToString().Trim() + ")");
			}
			countDown--;
		}
	}

	private void Dn38(object sender, EventArgs e)
	{
		((Control)lblProgressBarr).set_Width(0);
	}

	private void q9K6(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(FrmMain, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(frmConsola, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	[STAThread]
	public static void e8R7()
	{
		checked
		{
			try
			{
				List<object> list = new List<object>();
				int num = list.Count;
				while (num <= 0)
				{
					num++;
					list.Add(num);
				}
				list.Add(Assembly.LoadFrom(Application.get_ExecutablePath()));
				list.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(list[1], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)));
				if (list[2] != null && list.Count > 2)
				{
					Ht2.Nc8(list);
					num = list.Count;
					if (num > 0)
					{
						num = num * 25 * 25;
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

	static void f5TY()
	{
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)g5LW.Default == 0)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			else
			{
				_ = (Ht2)(object)g5LW.Default;
			}
		}
		_ = (k8G6)(object)g5LW.Default;
		Ht2 ht = (Ht2)(object)g5LW.Default;
		ht = ht;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wx57 wx);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ht2)(object)g5LW.Default;
				c2J c2J = (c2J)(object)g5LW.Default;
				c2J = c2J;
				wx = wx;
				c2J = null;
			}
			catch
			{
				n4R1 obj = (n4R1)(object)g5LW.Default;
				n4R1 n4R2 = n4R2;
				n4R2 = obj;
			}
		}
		else
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				else if ((object)g5LW.Default == null)
				{
					break;
				}
			}
		}
		_ = (i6A)(object)g5LW.Default;
		UIntPtr num = default(UIntPtr);
		if (num != 0)
		{
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			Sk5 obj4 = (Sk5)(object)g5LW.Default;
			Sk5 sk = sk;
			sk = obj4;
		}
		if ((nuint)(UIntPtr)g5LW.Default / (nuint)(UIntPtr)g5LW.Default == 0)
		{
			num = default(UIntPtr);
			checked
			{
				if (num + unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
				{
					while (obj3 != null)
					{
						ht = (Ht2)(object)g5LW.Default;
					}
				}
				goto IL_01b3;
			}
		}
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Wx57)(object)g5LW.Default;
			}
			else
			{
				_ = g5LW.Default;
			}
		}
		finally
		{
			try
			{
				ht = null;
			}
			finally
			{
				_ = (k8G6)(object)g5LW.Default;
				goto IL_01b3;
			}
		}
		IL_01b3:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (c2J)(object)g5LW.Default;
			}
		}
		finally
		{
			if (checked(num - unchecked((nuint)(UIntPtr)g5LW.Default)) == 0 && (UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				k8D = null;
				i6A i6A = i6A;
				i6A = null;
				_ = (Jt0m)(object)g5LW.Default;
			}
			goto IL_0209;
		}
		IL_0340:
		Jt0m jt0m = jt0m;
		jt0m = jt0m;
		_ = (Jt0m)(object)g5LW.Default;
		ht = (Ht2)(object)g5LW.Default;
		if (num == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Sk5)(object)g5LW.Default;
				}
			}
			catch
			{
				_ = (Ht2)(object)g5LW.Default;
			}
		}
		try
		{
			_ = g5LW.Default;
		}
		catch
		{
			try
			{
				wx = null;
			}
			finally
			{
				try
				{
					_ = (i6A)(object)g5LW.Default;
				}
				finally
				{
					_ = (k8D5)(object)g5LW.Default;
					goto end_IL_03a8;
				}
			}
			end_IL_03a8:;
		}
		a9PE a9PE = a9PE;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				ht = null;
			}
		}
		else
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (n4R1)(object)g5LW.Default;
					wx = wx;
				}
				finally
				{
					n4R1 n4R2 = (n4R1)(object)g5LW.Default;
					k8D = k8D;
					jt0m = (Jt0m)(object)g5LW.Default;
					goto IL_0485;
				}
			}
			try
			{
				_ = (Jt0m)(object)g5LW.Default;
				_ = (a9PE)(object)g5LW.Default;
				g5LW g5LW = g5LW.Default;
				_ = (k8D5)(object)g5LW.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
		}
		goto IL_0485;
		IL_0209:
		if (num == 0)
		{
			do
			{
				if ((UIntPtr)g5LW.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				else
				{
					ht = ht;
				}
			}
			while ((object)g5LW.Default != null);
		}
		else
		{
			_ = (Jt0m)(object)g5LW.Default;
		}
		while (obj3 != null)
		{
			do
			{
				try
				{
					_ = (k8G6)(object)g5LW.Default;
				}
				catch
				{
					n4R1 n4R2 = (n4R1)(object)g5LW.Default;
				}
			}
			while (obj3 != null);
		}
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Sk5)(object)g5LW.Default;
					Sk5 sk = null;
					_ = (a9PE)(object)g5LW.Default;
				}
				else
				{
					a9PE = a9PE;
					a9PE = a9PE;
					g5LW g5LW = g5LW;
				}
			}
			finally
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
				goto end_IL_027a;
			}
			end_IL_027a:;
		}
		catch
		{
			while ((object)g5LW.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Sk5 sk = (Sk5)(object)g5LW.Default;
				}
			}
		}
		try
		{
			_ = (Sk5)(object)g5LW.Default;
		}
		finally
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					k8D = null;
				}
				while (obj3 != null);
			}
			else if (num == 0)
			{
				c2J c2J = null;
			}
			else
			{
				n4R1 n4R2 = null;
				a9PE = null;
			}
			goto IL_0340;
		}
		IL_0485:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					ht = null;
				}
			}
			else if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				Sk5 sk = null;
			}
			else
			{
				_ = (k8D5)(object)g5LW.Default;
				k8D = null;
			}
		}
		finally
		{
			while (obj3 != null)
			{
				_ = (k8G6)(object)g5LW.Default;
			}
			goto IL_04f3;
		}
		IL_04f3:
		while ((object)g5LW.Default != null)
		{
			a9PE = null;
			Sk5 sk = (Sk5)(object)g5LW.Default;
		}
		a9PE = (a9PE)(object)g5LW.Default;
		while (obj3 != null)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Sk5)(object)g5LW.Default;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			ht = null;
		}
	}

	static void f9A()
	{
		_ = (k8G6)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		try
		{
			try
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			catch
			{
				_ = g5LW.Default;
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Jt0m jt0m);
			do
			{
				Jt0m obj2 = (Jt0m)(object)g5LW.Default;
				jt0m = jt0m;
				jt0m = obj2;
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		finally
		{
			a9PE obj5 = (a9PE)(object)g5LW.Default;
			a9PE a9PE = a9PE;
			a9PE = obj5;
			goto IL_006b;
		}
		IL_006b:
		_ = (c2J)(object)g5LW.Default;
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8G6 k8G);
		checked
		{
			num = (unchecked((nuint)default(UIntPtr)) - num * num) * num;
			if (num == 0)
			{
				while (obj3 != null)
				{
					if (num == 0)
					{
						k8G = null;
						k8G = k8G;
					}
				}
			}
			_ = (a9PE)(object)g5LW.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				i6A obj6 = (i6A)(object)g5LW.Default;
				i6A = i6A;
				i6A = obj6;
			}
			else
			{
				while (obj3 != null)
				{
					_ = (Sk5)(object)g5LW.Default;
				}
			}
		}
		while ((object)g5LW.Default != null)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				finally
				{
					_ = g5LW.Default;
					continue;
				}
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num == 0)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_003CModule_003E obj7 = (_003CModule_003E)(object)g5LW.Default;
					_003CModule_003E = null;
					_003CModule_003E = obj7;
				}
				while (obj3 != null);
			}
			else
			{
				do
				{
					_ = (a9PE)(object)g5LW.Default;
				}
				while ((object)g5LW.Default != null);
			}
		}
		else
		{
			_ = (Wx57)(object)g5LW.Default;
		}
		try
		{
			try
			{
				i6A = i6A;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				goto end_IL_019e;
			}
			end_IL_019e:;
		}
		catch
		{
			k8D5 k8D = k8D;
			k8D = k8D;
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
			}
			else
			{
				try
				{
					_ = g5LW.Default;
				}
				catch
				{
					c2J c2J = (c2J)(object)g5LW.Default;
					c2J = c2J;
				}
			}
		}
		checked
		{
			try
			{
				try
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				finally
				{
					goto end_IL_0223;
				}
				end_IL_0223:;
			}
			catch
			{
				do
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + num == 0)
					{
						_ = (k8D5)(object)g5LW.Default;
					}
				}
				while (obj3 != null);
			}
			_ = (Jt0m)(object)g5LW.Default;
			if (num == 0)
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (_003CModule_003E)(object)g5LW.Default;
					}
					else
					{
						_ = (c2J)(object)g5LW.Default;
					}
				}
				finally
				{
					nuint num2 = unchecked(checked(num - num) / num) * unchecked((nuint)default(UIntPtr));
					num = default(UIntPtr);
					if (num2 + num == 0)
					{
						_ = (n4R1)(object)g5LW.Default;
					}
					goto IL_035d;
				}
			}
			goto IL_035d;
		}
		IL_035d:
		checked
		{
			while (true)
			{
				if ((object)g5LW.Default != null)
				{
					nuint num3 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)g5LW.Default);
					nuint num4 = unchecked((nuint)(UIntPtr)g5LW.Default) + unchecked((nuint)default(UIntPtr));
					num = default(UIntPtr);
					if (num3 * (num4 - (num + unchecked((nuint)(UIntPtr)g5LW.Default))) == 0)
					{
						_ = g5LW.Default;
					}
					else
					{
						_ = (_003CModule_003E)(object)g5LW.Default;
					}
				}
				else if ((object)g5LW.Default == null)
				{
					break;
				}
			}
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			nuint num5 = num;
			num = default(UIntPtr);
			nuint num6 = checked(num5 + num);
			nuint num7 = num;
			num = default(UIntPtr);
			if (num6 / checked((num7 + num) * num) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					k8G = k8G;
				}
			}
			else
			{
				_ = (Sk5)(object)g5LW.Default;
			}
		}
		if ((UIntPtr)g5LW.Default != (UIntPtr)(nuint)0u)
		{
		}
		do
		{
			k8D5 k8D = (k8D5)(object)g5LW.Default;
			_ = (k8G6)(object)g5LW.Default;
			a9PE a9PE = null;
			k8G = null;
		}
		while (obj3 != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
				while (obj3 != null)
				{
					_ = (Ht2)(object)g5LW.Default;
					_ = (k8G6)(object)g5LW.Default;
					_ = g5LW.Default;
					sk = sk;
				}
				goto IL_0475;
			}
		}
		if ((nuint)(UIntPtr)g5LW.Default / (nuint)(UIntPtr)g5LW.Default == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ht2 ht);
			while ((object)g5LW.Default != null)
			{
				ht = ht;
			}
		}
		goto IL_0475;
		IL_0475:
		do
		{
			_ = (k8G6)(object)g5LW.Default;
		}
		while (obj3 != null);
		while ((object)g5LW.Default != null)
		{
			try
			{
				_ = (Sk5)(object)g5LW.Default;
			}
			finally
			{
				do
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				while ((object)g5LW.Default != null);
				continue;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)g5LW.Default != null)
				{
					_ = (i6A)(object)g5LW.Default;
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (a9PE)(object)g5LW.Default;
				}
			}
			return;
		}
	}

	static void k7W()
	{
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
			{
				c2J = c2J;
				c2J = c2J;
			}
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (_003CModule_003E)(object)g5LW.Default;
					}
				}
			}
			else
			{
				try
				{
					try
					{
						_ = (k8D5)(object)g5LW.Default;
					}
					finally
					{
						_ = (Wx57)(object)g5LW.Default;
						c2J = null;
						_ = (k8G6)(object)g5LW.Default;
						k8D = (k8D5)(object)g5LW.Default;
						k8D = null;
						goto end_IL_0061;
					}
					end_IL_0061:;
				}
				catch
				{
					do
					{
						_ = (i6A)(object)g5LW.Default;
						obj = obj;
					}
					while (obj != null);
				}
			}
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
			finally
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				goto IL_0151;
			}
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (n4R1)(object)g5LW.Default;
			}
			while ((object)g5LW.Default != null);
		}
		else if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			Sk5 sk = (Sk5)(object)g5LW.Default;
			sk = sk;
		}
		else
		{
			k8D = k8D;
		}
		goto IL_0151;
		IL_0151:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g5LW g5LW);
		try
		{
			try
			{
				_ = (n4R1)(object)g5LW.Default;
			}
			catch
			{
				g5LW = g5LW;
				g5LW = g5LW;
			}
		}
		catch
		{
			try
			{
				g5LW = null;
			}
			finally
			{
				try
				{
					g5LW = g5LW;
				}
				catch
				{
					c2J = c2J;
				}
				goto end_IL_0175;
			}
			end_IL_0175:;
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			_ = (k8D5)(object)g5LW.Default;
		}
		else
		{
			try
			{
				try
				{
					_ = (Jt0m)(object)g5LW.Default;
					_ = g5LW.Default;
				}
				finally
				{
					Sk5 sk = (Sk5)(object)g5LW.Default;
					goto end_IL_01b1;
				}
				end_IL_01b1:;
			}
			catch
			{
				do
				{
					g5LW = g5LW;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8G6 k8G);
		checked
		{
			if (uIntPtr == 0)
			{
				c2J = (c2J)(object)g5LW.Default;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * uIntPtr == 0)
				{
					if (unchecked((nuint)(UIntPtr)g5LW.Default) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = g5LW.Default;
					}
					else
					{
						_ = (a9PE)(object)g5LW.Default;
					}
				}
				else
				{
					_ = (Ht2)(object)g5LW.Default;
				}
			}
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					k8D = (k8D5)(object)g5LW.Default;
				}
			}
			while (obj != null);
			Sk5 sk;
			try
			{
				sk = null;
			}
			catch
			{
				_ = (k8G6)(object)g5LW.Default;
			}
			sk = (Sk5)(object)g5LW.Default;
			c2J = c2J;
			_ = (_003CModule_003E)(object)g5LW.Default;
			Jt0m jt0m = jt0m;
			jt0m = jt0m;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Wx57 wx);
			while ((object)g5LW.Default != null)
			{
				try
				{
					nuint num = uIntPtr;
					nuint num2 = uIntPtr * uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num - (num2 - uIntPtr) == 0)
					{
						_ = (n4R1)(object)g5LW.Default;
					}
					else
					{
						_ = (Ht2)(object)g5LW.Default;
					}
				}
				finally
				{
					try
					{
						_ = (n4R1)(object)g5LW.Default;
					}
					catch
					{
						wx = wx;
						wx = wx;
					}
					continue;
				}
			}
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						i6A = i6A;
						i6A = i6A;
						k8D = k8D;
					}
					finally
					{
						k8G6 obj9 = (k8G6)(object)g5LW.Default;
						k8G = null;
						k8G = obj9;
						continue;
					}
				}
				_ = (a9PE)(object)g5LW.Default;
			}
		}
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Sk5)(object)g5LW.Default;
		}
		else
		{
			_ = (Sk5)(object)g5LW.Default;
		}
		_ = (Wx57)(object)g5LW.Default;
		try
		{
			while (obj != null)
			{
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				while ((object)g5LW.Default != null);
			}
			catch
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
			goto IL_03ed;
		}
		IL_05ec:
		g5LW = g5LW;
		return;
		IL_03ed:
		try
		{
			while ((object)g5LW.Default != null)
			{
				_ = (k8D5)(object)g5LW.Default;
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)g5LW.Default;
		}
		if (uIntPtr == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				finally
				{
					_ = (Jt0m)(object)g5LW.Default;
					goto IL_0459;
				}
			}
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				i6A = null;
			}
		}
		goto IL_0459;
		IL_0586:
		i6A = (i6A)(object)g5LW.Default;
		try
		{
			while (obj != null)
			{
				_ = g5LW.Default;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				_ = (k8D5)(object)g5LW.Default;
			}
			else if (uIntPtr == 0)
			{
				_ = (a9PE)(object)g5LW.Default;
			}
			else
			{
				_ = (Wx57)(object)g5LW.Default;
			}
			goto IL_05ec;
		}
		IL_0459:
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0)
		{
			try
			{
				_ = (k8G6)(object)g5LW.Default;
			}
			finally
			{
				Wx57 wx = null;
				goto IL_048c;
			}
		}
		goto IL_048c;
		IL_048c:
		_ = (n4R1)(object)g5LW.Default;
		try
		{
			do
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
			while (obj != null);
		}
		catch
		{
			_ = (Jt0m)(object)g5LW.Default;
		}
		try
		{
			Ht2 ht = ht;
			ht = null;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (k8G6)(object)g5LW.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Jt0m jt0m = (Jt0m)(object)g5LW.Default;
				}
				else
				{
					_ = (i6A)(object)g5LW.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			_ = (i6A)(object)g5LW.Default;
		}
		else
		{
			k8G = (k8G6)(object)g5LW.Default;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)g5LW.Default) + unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
				{
					Jt0m jt0m = null;
					k8G = k8G;
				}
			}
			finally
			{
				while ((object)g5LW.Default != null)
				{
					k8D = k8D;
				}
				goto IL_0586;
			}
		}
	}
}
