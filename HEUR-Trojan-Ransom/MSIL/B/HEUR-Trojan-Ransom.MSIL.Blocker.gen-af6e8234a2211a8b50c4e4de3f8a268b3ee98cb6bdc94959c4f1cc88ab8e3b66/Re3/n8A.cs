using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ak9;
using Ar7;
using Ek3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qf0;
using Yb6;
using Zc7;
using e6AW;
using j7JG;
using o5T;
using p0J;

namespace Re3;

[DesignerGenerated]
public class n8A : Form
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
			EventHandler eventHandler = Dw5;
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
			EventHandler eventHandler = e1Z;
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
			EventHandler eventHandler = t0S;
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

	public n8A()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Nx9));
		((Form)this).add_Load((EventHandler)Bw8);
		((Form)this).add_Shown((EventHandler)z4L);
		btnApagadoPulsado = false;
		countDown = 85;
		SumaBarra = 0.0;
		Rojo = 255.0;
		Verde = 30.0;
		SumaResta = (Rojo - Verde) / (double)checked(countDown - 30);
		j4E();
	}

	[DebuggerNonUserCode]
	protected override void Dr6(bool Wx8)
	{
		try
		{
			if (Wx8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wx8);
		}
	}

	[DebuggerStepThrough]
	private void j4E()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(n8A));
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

	private void e1Z(object sender, EventArgs e)
	{
		CerrarServidor = false;
		((Form)this).Close();
		((Component)this).Dispose();
	}

	private void Dw5(object sender, EventArgs e)
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

	private void Nx9(object sender, FormClosingEventArgs e)
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

	private void t0S(object sender, EventArgs e)
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

	private void Bw8(object sender, EventArgs e)
	{
		((Control)lblProgressBarr).set_Width(0);
	}

	private void z4L(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(FrmMain, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(frmConsola, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	[STAThread]
	public static void n2E()
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
					a3Y.c3R(list);
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

	static void Wn5()
	{
		UIntPtr uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j6Q j6Q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ab4 ab);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)j6Q.Default;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					ab = null;
					ab = ab;
					goto end_IL_0022;
				}
				end_IL_0022:;
			}
			catch
			{
			}
		}
		else
		{
			j6Q = j6Q.Default;
			j6Q = j6Q;
		}
		_ = (d3D6)(object)j6Q.Default;
		d3D6 d3D = d3D;
		d3D = d3D;
		d3D = null;
		q4H9 obj2 = (q4H9)(object)j6Q.Default;
		q4H9 q4H = null;
		q4H = obj2;
		_ = (q4H9)(object)j6Q.Default;
		object obj3 = null;
		while (obj3 != null)
		{
		}
		try
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)j6Q.Default;
					Xy3 xy = xy;
				}
				finally
				{
					_ = (Ry0)(object)j6Q.Default;
					goto end_IL_00ae;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (c0W)(object)j6Q.Default;
			}
			else
			{
				_ = (Ab4)(object)j6Q.Default;
			}
			end_IL_00ae:;
		}
		catch
		{
			try
			{
				ab = null;
			}
			catch
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Dd8)(object)j6Q.Default;
				}
			}
		}
		_ = (Xy3)(object)j6Q.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n8A n8A2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ry0 ry);
		try
		{
			try
			{
				_ = (Ab4)(object)j6Q.Default;
				n8A2 = (n8A)(object)j6Q.Default;
				n8A2 = n8A2;
				j6Q = j6Q;
				ry = (Ry0)(object)j6Q.Default;
				ry = null;
			}
			finally
			{
				_ = (t3T)(object)j6Q.Default;
				goto end_IL_0138;
			}
			end_IL_0138:;
		}
		finally
		{
			_ = (Ry0)(object)j6Q.Default;
			goto IL_0193;
		}
		IL_01e5:
		try
		{
			while ((object)j6Q.Default != null)
			{
				while (obj3 != null)
				{
					d3D = null;
				}
			}
		}
		catch
		{
			do
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					_ = (q4H9)(object)j6Q.Default;
				}
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dd8 dd);
		while (obj3 != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					dd = dd;
				}
				else
				{
					ry = (Ry0)(object)j6Q.Default;
					_ = j6Q.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					_ = (n8A)(object)j6Q.Default;
				}
				catch
				{
					dd = dd;
				}
				continue;
			}
		}
		_ = (Xy3)(object)j6Q.Default;
		try
		{
			if (uIntPtr == 0)
			{
				dd = dd;
				_ = (Ab4)(object)j6Q.Default;
				n8A2 = (n8A)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
			}
		}
		catch
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (checked(unchecked((nuint)default(UIntPtr)) - uIntPtr) / uIntPtr != 0)
				{
					ry = null;
					d3D = (d3D6)(object)j6Q.Default;
				}
				else
				{
					_ = (Ab4)(object)j6Q.Default;
				}
			}
			while ((object)j6Q.Default != null);
		}
		try
		{
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					q4H = q4H;
					t3T t3T = (t3T)(object)j6Q.Default;
					t3T = t3T;
				}
				else
				{
					_ = (n8A)(object)j6Q.Default;
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					ry = ry;
				}
				else
				{
					dd = (Dd8)(object)j6Q.Default;
				}
				goto IL_037c;
			}
		}
		IL_037c:
		ab = ab;
		ry = ry;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = j6Q.Default;
				}
			}
			while ((object)j6Q.Default != null);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Xy3)(object)j6Q.Default;
		}
		n8A2 = n8A2;
		_ = (a3Y)(object)j6Q.Default;
		_ = (Ry0)(object)j6Q.Default;
		_ = (t3T)(object)j6Q.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Dd8)(object)j6Q.Default;
				ry = (Ry0)(object)j6Q.Default;
				dd = null;
				c0W c0W = (c0W)(object)j6Q.Default;
				return;
			}
			catch
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					_ = (q4H9)(object)j6Q.Default;
					_ = (Ab4)(object)j6Q.Default;
					_ = (Dd8)(object)j6Q.Default;
				}
				else
				{
					_ = (Ry0)(object)j6Q.Default;
				}
				return;
			}
		}
		do
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = j6Q.Default;
			}
		}
		while (obj3 != null);
		return;
		IL_0193:
		_ = (t3T)(object)j6Q.Default;
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				while (obj3 != null)
				{
					n8A2 = null;
				}
			}
		}
		finally
		{
			try
			{
				c0W c0W = c0W;
				c0W = c0W;
			}
			catch
			{
				_ = (Xy3)(object)j6Q.Default;
			}
			goto IL_01e5;
		}
	}

	static void Wg2()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dd8 dd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xy3 xy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a3Y a3Y);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					dd = null;
					dd = dd;
				}
				finally
				{
					dd = null;
					a3Y = a3Y;
					a3Y = a3Y;
					Xy3 obj = (Xy3)(object)j6Q.Default;
					xy = (Xy3)(object)j6Q.Default;
					xy = obj;
					goto end_IL_000e;
				}
				end_IL_000e:;
			}
			finally
			{
				xy = xy;
				_ = (t3T)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
				goto IL_0073;
			}
		}
		goto IL_0073;
		IL_01c7:
		_ = (Xy3)(object)j6Q.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j6Q j6Q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ab4 ab);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3D6 d3D);
		try
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					j6Q = j6Q;
					_ = (Ry0)(object)j6Q.Default;
					dd = dd;
					xy = xy;
				}
			}
			else
			{
				xy = null;
			}
		}
		catch
		{
			try
			{
				try
				{
					ab = null;
				}
				catch
				{
					d3D = null;
				}
			}
			catch
			{
				_ = j6Q.Default;
			}
		}
		d3D = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (q4H9)(object)j6Q.Default;
			}
			obj5 = obj5;
		}
		while (obj5 != null);
		q4H9 q4H = q4H;
		q4H = q4H;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					n8A obj6 = (n8A)(object)j6Q.Default;
					n8A n8A2 = n8A2;
					n8A2 = obj6;
					_ = (Dd8)(object)j6Q.Default;
				}
				else
				{
					a3Y = a3Y;
					_ = j6Q.Default;
					_ = (n8A)(object)j6Q.Default;
				}
			}
			finally
			{
				_ = j6Q.Default;
				goto IL_031b;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			a3Y = a3Y;
			goto IL_031b;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ry0 ry);
		try
		{
			ry = ry;
		}
		finally
		{
			_ = (q4H9)(object)j6Q.Default;
			goto IL_031b;
		}
		IL_0073:
		if (uIntPtr == 0)
		{
			while ((object)j6Q.Default != null)
			{
				try
				{
					_ = j6Q.Default;
				}
				catch
				{
					_ = (Xy3)(object)j6Q.Default;
				}
			}
		}
		_ = (c0W)(object)j6Q.Default;
		_ = j6Q.Default;
		checked
		{
			if (uIntPtr - unchecked(uIntPtr / uIntPtr) == 0)
			{
				d3D = null;
				d3D = d3D;
			}
		}
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (a3Y)(object)j6Q.Default;
				}
				finally
				{
					dd = dd;
					continue;
				}
			}
			while ((object)j6Q.Default != null);
		}
		else
		{
			_ = (Dd8)(object)j6Q.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t3T t3T);
		try
		{
			t3T = t3T;
			t3T = null;
		}
		catch
		{
			ry = ry;
			ry = ry;
		}
		try
		{
		}
		catch
		{
			_ = (q4H9)(object)j6Q.Default;
		}
		finally
		{
			_ = (a3Y)(object)j6Q.Default;
			goto IL_0157;
		}
		IL_04d5:
		do
		{
			try
			{
				try
				{
					_ = (q4H9)(object)j6Q.Default;
					t3T = t3T;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (Xy3)(object)j6Q.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					ab = ab;
				}
			}
		}
		while (obj5 != null);
		while (obj5 != null)
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Ab4)(object)j6Q.Default;
				}
				while ((object)j6Q.Default != null);
				continue;
			}
			try
			{
				ry = ry;
			}
			catch
			{
				t3T = null;
			}
		}
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				while (obj5 != null)
				{
					_ = (n8A)(object)j6Q.Default;
				}
			}
			else
			{
				while (obj5 != null)
				{
					_003CModule_003E = null;
				}
			}
		}
		_ = (Ab4)(object)j6Q.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ab4)(object)j6Q.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		return;
		IL_0394:
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (d3D6)(object)j6Q.Default;
				}
				finally
				{
					_ = (Ab4)(object)j6Q.Default;
					_ = (t3T)(object)j6Q.Default;
					goto end_IL_03ba;
				}
				end_IL_03ba:;
			}
			catch
			{
				t3T = (t3T)(object)j6Q.Default;
			}
		}
		try
		{
			while ((object)j6Q.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					_ = (t3T)(object)j6Q.Default;
				}
			}
		}
		finally
		{
			_ = (d3D6)(object)j6Q.Default;
			goto IL_0432;
		}
		IL_031b:
		do
		{
			try
			{
				try
				{
					_003CModule_003E = null;
				}
				finally
				{
					_ = (t3T)(object)j6Q.Default;
					ab = ab;
					_ = (q4H9)(object)j6Q.Default;
					goto end_IL_031b;
				}
				end_IL_031b:;
			}
			finally
			{
				while ((object)j6Q.Default != null)
				{
					_ = (a3Y)(object)j6Q.Default;
				}
				continue;
			}
		}
		while ((object)j6Q.Default != null);
		try
		{
			_ = (Ry0)(object)j6Q.Default;
		}
		finally
		{
			j6Q = j6Q;
			d3D = null;
			q4H = q4H;
			goto IL_0394;
		}
		IL_0432:
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)j6Q.Default) == 0)
			{
				while (true)
				{
					if ((object)j6Q.Default != null)
					{
						_ = (Ab4)(object)j6Q.Default;
					}
					else if (obj5 == null)
					{
						break;
					}
				}
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					j6Q = j6Q;
				}
			}
			else
			{
				_ = (Ab4)(object)j6Q.Default;
			}
		}
		finally
		{
			try
			{
				t3T = (t3T)(object)j6Q.Default;
			}
			catch
			{
				try
				{
					_ = (n8A)(object)j6Q.Default;
				}
				catch
				{
					ab = ab;
					t3T = null;
					ab = null;
				}
			}
			goto IL_04d5;
		}
		IL_0157:
		try
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (n8A)(object)j6Q.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_0158;
				}
			}
			end_IL_0158:;
		}
		finally
		{
			try
			{
				try
				{
					ab = ab;
					ab = ab;
				}
				finally
				{
					j6Q = j6Q;
					j6Q = j6Q;
					_ = (t3T)(object)j6Q.Default;
					d3D = d3D;
					goto end_IL_017e;
				}
				end_IL_017e:;
			}
			finally
			{
				_ = (t3T)(object)j6Q.Default;
				goto IL_01c7;
			}
		}
	}

	static void Jz8()
	{
		_ = (Dd8)(object)j6Q.Default;
		Xy3 xy = xy;
		xy = xy;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			_ = (Ab4)(object)j6Q.Default;
		}
		catch
		{
			do
			{
				Ry0 ry = (Ry0)(object)j6Q.Default;
				ry = ry;
				obj = obj;
			}
			while (obj != null);
		}
		do
		{
			_ = (_003CModule_003E)(object)j6Q.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3D6 d3D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j6Q j6Q);
		nuint uIntPtr;
		try
		{
			try
			{
				try
				{
					d3D = null;
					d3D = d3D;
					_ = (t3T)(object)j6Q.Default;
				}
				catch
				{
					j6Q = null;
					j6Q = null;
				}
			}
			catch
			{
				try
				{
					_ = (a3Y)(object)j6Q.Default;
				}
				catch
				{
					j6Q = null;
				}
			}
		}
		catch
		{
			uIntPtr = (UIntPtr)j6Q.Default;
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Dd8 obj6 = (Dd8)(object)j6Q.Default;
				Dd8 dd = dd;
				dd = obj6;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4H9 q4H);
		if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)j6Q.Default)) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / checked(uIntPtr + uIntPtr) == 0)
			{
				q4H = null;
				q4H = null;
				_ = (Dd8)(object)j6Q.Default;
			}
		}
		try
		{
			q4H = q4H;
		}
		finally
		{
			_ = (t3T)(object)j6Q.Default;
			_ = (n8A)(object)j6Q.Default;
			_ = (_003CModule_003E)(object)j6Q.Default;
			d3D = d3D;
			goto IL_016c;
		}
		IL_0250:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n8A n8A2);
		do
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				_ = (c0W)(object)j6Q.Default;
				_ = (t3T)(object)j6Q.Default;
				_003CModule_003E = null;
			}
			catch
			{
				n8A2 = n8A2;
				n8A2 = null;
			}
		}
		while (obj != null || obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			Ab4 ab = ab;
			ab = null;
		}
		_ = (d3D6)(object)j6Q.Default;
		checked
		{
			try
			{
				do
				{
					_ = (q4H9)(object)j6Q.Default;
				}
				while ((object)j6Q.Default != null);
			}
			catch
			{
				xy = xy;
				Ab4 ab = (Ab4)(object)j6Q.Default;
			}
			finally
			{
				do
				{
					nuint num = uIntPtr * uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num * uIntPtr == 0)
					{
						_ = (d3D6)(object)j6Q.Default;
					}
				}
				while (obj != null);
				goto IL_0330;
			}
		}
		IL_0330:
		q4H = (q4H9)(object)j6Q.Default;
		try
		{
			while ((object)j6Q.Default != null)
			{
				if (uIntPtr == 0)
				{
					_ = (d3D6)(object)j6Q.Default;
				}
			}
		}
		catch
		{
			try
			{
				n8A2 = (n8A)(object)j6Q.Default;
			}
			finally
			{
				goto end_IL_0360;
			}
			end_IL_0360:;
		}
		while (true)
		{
			if ((object)j6Q.Default != null)
			{
				_ = (c0W)(object)j6Q.Default;
			}
			else if (obj == null)
			{
				break;
			}
		}
		_ = (t3T)(object)j6Q.Default;
		if (uIntPtr == 0)
		{
			do
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
			while (obj != null || obj != null);
		}
		else
		{
			do
			{
				_ = j6Q.Default;
				j6Q = j6Q.Default;
			}
			while ((object)j6Q.Default != null);
		}
		try
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = (c0W)(object)j6Q.Default;
				Dd8 dd = (Dd8)(object)j6Q.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Dd8)(object)j6Q.Default;
			}
			catch
			{
				xy = xy;
			}
		}
		finally
		{
			_ = (Xy3)(object)j6Q.Default;
			goto IL_043a;
		}
		IL_016c:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					xy = xy;
				}
				else
				{
					_ = (q4H9)(object)j6Q.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (q4H9)(object)j6Q.Default;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (q4H9)(object)j6Q.Default;
			}
			else if (uIntPtr == 0)
			{
				_ = (t3T)(object)j6Q.Default;
				_ = (t3T)(object)j6Q.Default;
			}
			else
			{
				_ = (t3T)(object)j6Q.Default;
			}
		}
		if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
		{
			j6Q = j6Q;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				_ = (Xy3)(object)j6Q.Default;
				goto IL_0250;
			}
		}
		goto IL_0250;
		IL_043a:
		nuint num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked(num2 / uIntPtr) + unchecked(uIntPtr / (nuint)(UIntPtr)j6Q.Default) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * (unchecked((nuint)(UIntPtr)j6Q.Default) * unchecked((nuint)(UIntPtr)j6Q.Default)) == 0)
				{
					_ = (_003CModule_003E)(object)j6Q.Default;
				}
			}
			_ = (Ab4)(object)j6Q.Default;
			try
			{
				try
				{
					_ = (d3D6)(object)j6Q.Default;
				}
				finally
				{
					try
					{
						xy = xy;
						return;
					}
					catch
					{
						_ = (n8A)(object)j6Q.Default;
						return;
					}
				}
			}
			catch
			{
				do
				{
					nuint num3 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num3 + uIntPtr != 0)
					{
						_ = (q4H9)(object)j6Q.Default;
						continue;
					}
					a3Y a3Y = null;
					a3Y = a3Y;
				}
				while (obj != null);
			}
		}
	}

	static void Mj6()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t3T t3T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dd8 dd);
		try
		{
			try
			{
				Dd8 obj = (Dd8)(object)j6Q.Default;
				dd = (Dd8)(object)j6Q.Default;
				dd = obj;
			}
			catch
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c0W)(object)j6Q.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (t3T)(object)j6Q.Default;
					_ = (Ry0)(object)j6Q.Default;
					_ = (q4H9)(object)j6Q.Default;
				}
				finally
				{
					_ = (t3T)(object)j6Q.Default;
					goto end_IL_003c;
				}
			}
			t3T = null;
			t3T = t3T;
			end_IL_003c:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		checked
		{
			num = unchecked((nuint)(UIntPtr)j6Q.Default) * num;
			num = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4H9 q4H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j6Q j6Q);
		if (num != (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					j6Q obj4 = j6Q.Default;
					j6Q = j6Q;
					j6Q = obj4;
					q4H = null;
					q4H = q4H;
					_ = j6Q.Default;
					_ = (Ry0)(object)j6Q.Default;
				}
				finally
				{
					t3T = t3T;
					goto IL_00f1;
				}
				IL_00f1:
				obj5 = obj5;
			}
			while (obj5 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n8A n8A2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0W c0W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a3Y a3Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3D6 d3D);
		if (num == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					n8A obj6 = (n8A)(object)j6Q.Default;
					n8A2 = n8A2;
					n8A2 = obj6;
					_ = (Ab4)(object)j6Q.Default;
					a3Y = a3Y;
					a3Y = null;
					d3D = (d3D6)(object)j6Q.Default;
					d3D = d3D;
				}
				finally
				{
					q4H = q4H;
					goto IL_0196;
				}
			}
			try
			{
				_ = (c0W)(object)j6Q.Default;
				_ = (q4H9)(object)j6Q.Default;
			}
			catch
			{
				c0W = (c0W)(object)j6Q.Default;
				c0W = c0W;
			}
		}
		goto IL_0196;
		IL_0262:
		_ = (q4H9)(object)j6Q.Default;
		try
		{
			try
			{
				_ = (Ry0)(object)j6Q.Default;
			}
			catch
			{
				_ = (a3Y)(object)j6Q.Default;
			}
		}
		catch
		{
			while (obj5 != null)
			{
				do
				{
					_ = (q4H9)(object)j6Q.Default;
				}
				while (obj5 != null);
			}
		}
		try
		{
		}
		catch
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				while (obj5 != null)
				{
					j6Q = j6Q;
				}
			}
		}
		try
		{
			try
			{
				c0W = null;
			}
			catch
			{
				_ = (d3D6)(object)j6Q.Default;
				_ = (Dd8)(object)j6Q.Default;
				j6Q = j6Q.Default;
			}
		}
		catch
		{
			_ = j6Q.Default;
			_ = (Dd8)(object)j6Q.Default;
			_ = (c0W)(object)j6Q.Default;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			do
			{
				try
				{
					_ = (q4H9)(object)j6Q.Default;
				}
				catch
				{
					t3T = (t3T)(object)j6Q.Default;
				}
			}
			while ((object)j6Q.Default != null);
		}
		_ = (a3Y)(object)j6Q.Default;
		_ = (n8A)(object)j6Q.Default;
		checked
		{
			while (obj5 != null)
			{
				if (num - unchecked((nuint)(UIntPtr)j6Q.Default) == 0)
				{
					try
					{
						dd = dd;
					}
					catch
					{
						_ = (_003CModule_003E)(object)j6Q.Default;
						_ = (a3Y)(object)j6Q.Default;
						_ = (n8A)(object)j6Q.Default;
						_ = (Ab4)(object)j6Q.Default;
					}
					continue;
				}
				try
				{
					_ = j6Q.Default;
				}
				finally
				{
					d3D = d3D;
					continue;
				}
			}
			while (obj5 != null)
			{
				_ = (Ry0)(object)j6Q.Default;
			}
			dd = (Dd8)(object)j6Q.Default;
			_ = (q4H9)(object)j6Q.Default;
			_ = (t3T)(object)j6Q.Default;
			if (unchecked((UIntPtr)j6Q.Default != (UIntPtr)(nuint)0u))
			{
				try
				{
					do
					{
						_ = (_003CModule_003E)(object)j6Q.Default;
					}
					while (obj5 != null);
				}
				catch
				{
					try
					{
						q4H = q4H;
					}
					catch
					{
						t3T = t3T;
					}
				}
			}
			do
			{
				q4H = q4H;
			}
			while ((object)j6Q.Default != null);
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					if (unchecked((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Xy3)(object)j6Q.Default;
					}
				}
				catch
				{
					_ = (d3D6)(object)j6Q.Default;
				}
			}
			else if (num - unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		try
		{
		}
		catch
		{
			num = default(UIntPtr);
			if (num != (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		dd = dd;
		_ = (t3T)(object)j6Q.Default;
		a3Y = null;
		Xy3 xy = (Xy3)(object)j6Q.Default;
		try
		{
			t3T = (t3T)(object)j6Q.Default;
		}
		finally
		{
			dd = dd;
			goto IL_051c;
		}
		IL_0196:
		if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = j6Q.Default;
				}
			}
			finally
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					j6Q = j6Q.Default;
				}
				else
				{
					d3D = null;
				}
				goto IL_0262;
			}
		}
		try
		{
			d3D = (d3D6)(object)j6Q.Default;
		}
		catch
		{
			Xy3 obj19 = (Xy3)(object)j6Q.Default;
			xy = xy;
			xy = obj19;
			_ = (d3D6)(object)j6Q.Default;
			_ = (a3Y)(object)j6Q.Default;
			t3T = null;
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				_ = (a3Y)(object)j6Q.Default;
			}
			goto IL_0262;
		}
		IL_051c:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u && num != (UIntPtr)(nuint)0u)
		{
			_ = j6Q.Default;
			_ = (n8A)(object)j6Q.Default;
			j6Q = null;
			_ = (a3Y)(object)j6Q.Default;
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Ry0)(object)j6Q.Default;
					d3D = (d3D6)(object)j6Q.Default;
					_ = (Ab4)(object)j6Q.Default;
					dd = (Dd8)(object)j6Q.Default;
				}
				while (obj5 != null);
			}
		}
		catch
		{
			do
			{
				if (num != (UIntPtr)(nuint)0u)
				{
					c0W = c0W;
					n8A2 = n8A2;
					t3T = t3T;
				}
				else
				{
					_ = (q4H9)(object)j6Q.Default;
				}
			}
			while ((object)j6Q.Default != null);
		}
		_ = (Ry0)(object)j6Q.Default;
	}
}
