using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ha03;
using Kw6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wo0y;
using Wo29;
using Xi7s;
using b1T3;
using d2G3;
using i1H7;
using y6N2;
using z2FR;

namespace Pp74;

[DesignerGenerated]
public class m0PK : Form
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
			EventHandler eventHandler = s4G3;
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
			EventHandler eventHandler = Ti21;
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
			EventHandler eventHandler = e3TL;
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

	public m0PK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(b4EJ));
		((Form)this).add_Load((EventHandler)Lg7n);
		((Form)this).add_Shown((EventHandler)Wq21);
		btnApagadoPulsado = false;
		countDown = 85;
		SumaBarra = 0.0;
		Rojo = 255.0;
		Verde = 30.0;
		SumaResta = (Rojo - Verde) / (double)checked(countDown - 30);
		Jn28();
	}

	[DebuggerNonUserCode]
	protected override void t1XL(bool c3N0)
	{
		try
		{
			if (c3N0 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c3N0);
		}
	}

	[DebuggerStepThrough]
	private void Jn28()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(m0PK));
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

	private void Ti21(object sender, EventArgs e)
	{
		CerrarServidor = false;
		((Form)this).Close();
		((Component)this).Dispose();
	}

	private void s4G3(object sender, EventArgs e)
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

	private void b4EJ(object sender, FormClosingEventArgs e)
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

	private void e3TL(object sender, EventArgs e)
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

	private void Lg7n(object sender, EventArgs e)
	{
		((Control)lblProgressBarr).set_Width(0);
	}

	private void Wq21(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(FrmMain, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(frmConsola, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	[STAThread]
	public static void r3TG()
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
					Ao56.k1LA(list);
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

	static void Xm43()
	{
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				finally
				{
					_ = (Ao56)(object)t8TR.Default;
					goto end_IL_0022;
				}
				end_IL_0022:;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
				}
				else
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
				goto IL_00b7;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		while (true)
		{
			p9CA obj = (p9CA)(object)t8TR.Default;
			p9CA = (p9CA)(object)t8TR.Default;
			p9CA = obj;
			_ = (Nb4n)(object)t8TR.Default;
			_ = (Nb4n)(object)t8TR.Default;
			if ((object)t8TR.Default == null)
			{
				obj2 = obj2;
				if (obj2 == null)
				{
					break;
				}
			}
		}
		goto IL_00b7;
		IL_01cc:
		try
		{
			_ = (Cc9k)(object)t8TR.Default;
		}
		finally
		{
			try
			{
				_ = (m0PK)(object)t8TR.Default;
			}
			finally
			{
				_ = (o3HG)(object)t8TR.Default;
				goto IL_020e;
			}
		}
		IL_020e:
		while ((object)t8TR.Default != null)
		{
			while ((object)t8TR.Default != null)
			{
				_ = (m0PK)(object)t8TR.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s0T s0T);
		try
		{
			while (obj2 != null)
			{
				if ((UIntPtr)t8TR.Default != (UIntPtr)(nuint)0u)
				{
					_ = t8TR.Default;
				}
			}
		}
		catch
		{
			s0T = s0T;
			s0T = s0T;
			_ = (Cc9k)(object)t8TR.Default;
			y9CZ obj3 = (y9CZ)(object)t8TR.Default;
			y9CZ y9CZ = y9CZ;
			y9CZ = obj3;
			p9CA = p9CA;
		}
		t8TR t8TR = null;
		if (checked(unchecked((nuint)(UIntPtr)t8TR.Default) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			_ = (Nb4n)(object)t8TR.Default;
		}
		else if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (o3HG)(object)t8TR.Default;
			}
			while (obj2 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while ((object)t8TR.Default != null)
			{
				_ = (Ao56)(object)t8TR.Default;
			}
		}
		Nb4n nb4n;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hj2y hj2y);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					hj2y = null;
				}
				else
				{
					s0T = null;
					nb4n = nb4n;
					_ = t8TR.Default;
					p9CA = p9CA;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ao56 ao);
		if (uIntPtr == 0)
		{
			Ao56 obj5 = (Ao56)(object)t8TR.Default;
			ao = null;
			ao = obj5;
		}
		else
		{
			try
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					s0T = s0T;
				}
				else
				{
					m0PK m0PK2 = m0PK2;
					m0PK2 = m0PK2;
				}
			}
			catch
			{
				try
				{
					m0PK m0PK2 = null;
				}
				finally
				{
					_ = (o3HG)(object)t8TR.Default;
					goto end_IL_039f;
				}
				end_IL_039f:;
			}
		}
		checked
		{
			if (uIntPtr + unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					try
					{
						_ = t8TR.Default;
					}
					finally
					{
						_ = (p9CA)(object)t8TR.Default;
						_ = (p9CA)(object)t8TR.Default;
						goto end_IL_03cb;
					}
					end_IL_03cb:;
				}
				finally
				{
					ao = ao;
					goto IL_0451;
				}
			}
			try
			{
				_ = t8TR.Default;
			}
			finally
			{
				try
				{
					t8TR = null;
					hj2y = (Hj2y)(object)t8TR.Default;
					hj2y = hj2y;
					s0T = s0T;
				}
				catch
				{
					p9CA = null;
					nb4n = (Nb4n)(object)t8TR.Default;
					hj2y = hj2y;
				}
				goto IL_0451;
			}
		}
		IL_0451:
		p9CA = p9CA;
		_ = (_003CModule_003E)(object)t8TR.Default;
		_ = (_003CModule_003E)(object)t8TR.Default;
		s2ZW s2ZW = s2ZW;
		_ = (Cc9k)(object)t8TR.Default;
		return;
		IL_00b7:
		checked
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr * (unchecked((nuint)(UIntPtr)t8TR.Default) + unchecked(uIntPtr / unchecked((nuint)default(UIntPtr)))) == 0)
				{
					_ = t8TR.Default;
				}
				else
				{
					s2ZW = s2ZW;
					s2ZW = s2ZW;
				}
			}
			t8TR = null;
			t8TR = t8TR;
			_ = (p9CA)(object)t8TR.Default;
			_ = (Hj2y)(object)t8TR.Default;
			nb4n = null;
			nb4n = null;
			while ((object)t8TR.Default != null)
			{
				do
				{
					_ = t8TR.Default;
					_ = (_003CModule_003E)(object)t8TR.Default;
					_ = (o3HG)(object)t8TR.Default;
				}
				while (obj2 != null);
			}
		}
		try
		{
			do
			{
				nb4n = (Nb4n)(object)t8TR.Default;
			}
			while (obj2 != null);
		}
		catch
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					p9CA = null;
				}
				catch
				{
					_ = t8TR.Default;
				}
			}
		}
		try
		{
			while (obj2 != null)
			{
				while ((object)t8TR.Default != null)
				{
				}
			}
		}
		finally
		{
			Hj2y obj10 = (Hj2y)(object)t8TR.Default;
			hj2y = hj2y;
			hj2y = obj10;
			goto IL_01cc;
		}
	}

	static void s6QA()
	{
		object obj;
		nuint num;
		while (true)
		{
			obj = t8TR.Default;
			if (obj == null)
			{
				break;
			}
			num = default(UIntPtr);
			num = checked(unchecked((nuint)default(UIntPtr)) - num) / num;
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (s0T)(object)t8TR.Default;
				}
				else
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
			}
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = null;
		s2ZW s2ZW = null;
		s2ZW = s2ZW;
		_ = (_003CModule_003E)(object)t8TR.Default;
		_ = (o3HG)(object)t8TR.Default;
		while (obj != null)
		{
			_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
		}
		while ((object)t8TR.Default != null)
		{
			_ = (p9CA)(object)t8TR.Default;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o3HG o3HG);
		if (num == 0)
		{
			if (num == 0)
			{
				_ = t8TR.Default;
			}
		}
		else
		{
			do
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 + num + num) != 0)
				{
					o3HG = (o3HG)(object)t8TR.Default;
					o3HG = null;
				}
				else
				{
					_ = (p9CA)(object)t8TR.Default;
				}
			}
			while ((object)t8TR.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hj2y hj2y);
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
			}
			catch
			{
				o3HG = o3HG;
			}
		}
		catch
		{
			if (checked(num + num * num) == 0)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					hj2y = hj2y;
					hj2y = hj2y;
				}
				else
				{
					p9CA obj3 = (p9CA)(object)t8TR.Default;
					p9CA = (p9CA)(object)t8TR.Default;
					p9CA = obj3;
				}
			}
		}
		while (obj != null)
		{
			do
			{
				try
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
				catch
				{
					_ = (m0PK)(object)t8TR.Default;
				}
			}
			while ((object)t8TR.Default != null);
		}
		try
		{
			while ((object)t8TR.Default != null)
			{
				_ = (m0PK)(object)t8TR.Default;
			}
		}
		finally
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				_ = (s0T)(object)t8TR.Default;
			}
			else if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o3HG)(object)t8TR.Default;
				_ = (Hj2y)(object)t8TR.Default;
			}
			goto IL_023d;
		}
		IL_023d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9CZ y9CZ);
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					y9CZ = null;
					y9CZ = y9CZ;
				}
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ao56 ao);
			do
			{
				try
				{
					hj2y = hj2y;
				}
				finally
				{
					ao = ao;
					ao = null;
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			if (num / (nuint)(UIntPtr)t8TR.Default == 0 && (UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				_ = (m0PK)(object)t8TR.Default;
			}
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
			}
			finally
			{
				y9CZ = y9CZ;
				goto IL_02ca;
			}
		}
		IL_02ca:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cc9k cc9k);
		try
		{
			cc9k = cc9k;
			cc9k = cc9k;
		}
		catch
		{
			while ((object)t8TR.Default != null)
			{
				_ = (s2ZW)(object)t8TR.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s0T s0T);
		while (obj != null)
		{
			try
			{
				_ = (m0PK)(object)t8TR.Default;
			}
			finally
			{
				try
				{
					s0T = s0T;
					s0T = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
					continue;
				}
			}
		}
		_ = (s2ZW)(object)t8TR.Default;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = t8TR.Default;
			}
		}
		else
		{
			do
			{
				_ = (s2ZW)(object)t8TR.Default;
			}
			while ((object)t8TR.Default != null);
		}
		try
		{
			UIntPtr num3 = (UIntPtr)t8TR.Default;
			checked
			{
				nuint num4 = unchecked((nuint)(UIntPtr)t8TR.Default) + unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				if (unchecked((nuint)num3) * (num4 - num) * num == 0)
				{
					do
					{
						_ = t8TR.Default;
					}
					while (obj != null);
				}
			}
		}
		finally
		{
			try
			{
				hj2y = null;
				Ao56 ao = null;
			}
			catch
			{
				_ = (Hj2y)(object)t8TR.Default;
			}
			goto IL_03e2;
		}
		IL_0628:
		do
		{
			try
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					p9CA = (p9CA)(object)t8TR.Default;
					t8TR t8TR = t8TR.Default;
				}
			}
			finally
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
				}
				else
				{
					Ao56 ao = null;
				}
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		try
		{
			hj2y = null;
		}
		catch
		{
			if (num == 0)
			{
				s2ZW = null;
			}
			else
			{
				while ((object)t8TR.Default != null)
				{
					nb4n = nb4n;
				}
			}
		}
		while (obj != null)
		{
			nuint num5 = num;
			num = default(UIntPtr);
			if (checked(num5 - (num + unchecked(num / (nuint)(UIntPtr)t8TR.Default))) == 0)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					s0T = s0T;
				}
				else
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
			}
			else if (num == 0)
			{
				_ = (s2ZW)(object)t8TR.Default;
			}
		}
		try
		{
			m0PK m0PK2 = null;
			return;
		}
		finally
		{
			while (obj != null)
			{
				while (obj != null)
				{
					p9CA = p9CA;
				}
			}
			return;
		}
		IL_048b:
		UIntPtr num6 = (UIntPtr)t8TR.Default;
		num = default(UIntPtr);
		if ((nuint)num6 / checked(num - (unchecked((nuint)(UIntPtr)t8TR.Default) + unchecked((nuint)(UIntPtr)t8TR.Default) + num)) == 0)
		{
			nb4n = (Nb4n)(object)t8TR.Default;
		}
		else
		{
			t8TR t8TR = null;
			t8TR = t8TR;
			cc9k = cc9k;
			m0PK m0PK2 = (m0PK)(object)t8TR.Default;
			m0PK2 = m0PK2;
		}
		try
		{
			if ((nuint)(UIntPtr)t8TR.Default / num == 0)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (s0T)(object)t8TR.Default;
				}
				else
				{
					_ = (Ao56)(object)t8TR.Default;
				}
			}
			else
			{
				do
				{
					s2ZW = s2ZW;
				}
				while (obj != null);
			}
		}
		finally
		{
			try
			{
				m0PK m0PK2 = null;
			}
			finally
			{
				_ = (s2ZW)(object)t8TR.Default;
				goto IL_055b;
			}
		}
		IL_055b:
		try
		{
			try
			{
				do
				{
					hj2y = hj2y;
				}
				while (obj != null);
			}
			finally
			{
				do
				{
					_ = (s2ZW)(object)t8TR.Default;
					nb4n = (Nb4n)(object)t8TR.Default;
				}
				while (obj != null);
				goto end_IL_055c;
			}
			end_IL_055c:;
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					s2ZW = s2ZW;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
					continue;
				}
			}
		}
		if (num == 0)
		{
			_ = (_003CModule_003E)(object)t8TR.Default;
		}
		else
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				_ = (Cc9k)(object)t8TR.Default;
				s0T = null;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (Hj2y)(object)t8TR.Default;
			}
			finally
			{
				if (num == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
				goto IL_0628;
			}
		}
		goto IL_0628;
		IL_03e2:
		_ = (Cc9k)(object)t8TR.Default;
		while (true)
		{
			if (obj != null)
			{
				_ = t8TR.Default;
			}
			else if (obj == null)
			{
				break;
			}
		}
		do
		{
			_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
			_ = (Cc9k)(object)t8TR.Default;
		}
		while ((object)t8TR.Default != null || obj != null || (object)t8TR.Default != null);
		try
		{
			try
			{
				try
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
				finally
				{
					o3HG = null;
					goto end_IL_0444;
				}
				end_IL_0444:;
			}
			finally
			{
				try
				{
					Nb4n obj11 = (Nb4n)(object)t8TR.Default;
					nb4n = nb4n;
					nb4n = obj11;
				}
				finally
				{
					s2ZW = null;
					goto end_IL_0443;
				}
			}
			end_IL_0443:;
		}
		finally
		{
			while (obj != null)
			{
			}
			goto IL_048b;
		}
	}

	static void b1XH()
	{
		_ = (s2ZW)(object)t8TR.Default;
		m0PK m0PK2 = (m0PK)(object)t8TR.Default;
		m0PK2 = null;
		UIntPtr num = (UIntPtr)t8TR.Default;
		UIntPtr num2 = (UIntPtr)t8TR.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s0T s0T);
		checked
		{
			if (unchecked((nuint)num) + num2 == 0)
			{
				do
				{
					_ = (Ao56)(object)t8TR.Default;
					obj = obj;
				}
				while (obj != null);
			}
			else
			{
				s0T = s0T;
				s0T = s0T;
				m0PK2 = m0PK2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ao56 ao);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					ao = ao;
					ao = null;
				}
				catch
				{
					p9CA = null;
					p9CA = p9CA;
				}
			}
			while (obj != null);
		}
		else
		{
			s0T = s0T;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (s0T)(object)t8TR.Default;
		}
		else
		{
			_ = (Nb4n)(object)t8TR.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hj2y hj2y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o3HG o3HG);
		try
		{
			try
			{
				hj2y = (Hj2y)(object)t8TR.Default;
				hj2y = hj2y;
				o3HG = null;
				o3HG = o3HG;
				m0PK2 = null;
			}
			catch
			{
				_ = (Ao56)(object)t8TR.Default;
				_ = (s2ZW)(object)t8TR.Default;
			}
		}
		catch
		{
			nb4n = nb4n;
			nb4n = nb4n;
		}
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s2ZW s2ZW);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num2 == 0)
		{
			hj2y = hj2y;
		}
		else
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
				}
				catch
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					s2ZW = s2ZW;
					s2ZW = s2ZW;
					_ = (o3HG)(object)t8TR.Default;
					_ = (_003CModule_003E)(object)t8TR.Default;
				}
			}
			catch
			{
				_ = (Ao56)(object)t8TR.Default;
				_ = (s0T)(object)t8TR.Default;
				p9CA = p9CA;
			}
		}
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				try
				{
					_ = (Nb4n)(object)t8TR.Default;
					_ = (Hj2y)(object)t8TR.Default;
					_ = (o3HG)(object)t8TR.Default;
					_ = (Hj2y)(object)t8TR.Default;
				}
				finally
				{
					_ = (Cc9k)(object)t8TR.Default;
					goto IL_0208;
				}
			}
			_ = (y9CZ)(object)t8TR.Default;
		}
		goto IL_0208;
		IL_053a:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (Cc9k)(object)t8TR.Default;
			}
			else
			{
				do
				{
					s2ZW = (s2ZW)(object)t8TR.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			if (num2 == 0)
			{
				try
				{
					s0T = s0T;
				}
				finally
				{
					_ = (m0PK)(object)t8TR.Default;
					goto end_IL_056e;
				}
			}
			end_IL_056e:;
		}
		if (num2 == 0)
		{
			try
			{
				s2ZW = (s2ZW)(object)t8TR.Default;
			}
			finally
			{
				try
				{
					hj2y = null;
				}
				catch
				{
					s0T = s0T;
				}
				goto IL_05b9;
			}
		}
		goto IL_05b9;
		IL_0286:
		_ = (s0T)(object)t8TR.Default;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					s0T = s0T;
					s0T = null;
					s0T = s0T;
				}
				else
				{
					_ = t8TR.Default;
				}
			}
			else
			{
				t8TR t8TR = t8TR;
				t8TR = t8TR;
				_ = (m0PK)(object)t8TR.Default;
				s2ZW = null;
			}
		}
		else
		{
			if (num2 == 0)
			{
				try
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				finally
				{
					_ = (o3HG)(object)t8TR.Default;
					m0PK2 = m0PK2;
					_ = (Cc9k)(object)t8TR.Default;
					_ = (_003CModule_003E)(object)t8TR.Default;
					goto IL_034e;
				}
			}
			do
			{
				_ = (Cc9k)(object)t8TR.Default;
			}
			while (obj != null);
		}
		goto IL_034e;
		IL_034e:
		try
		{
			if (num2 / checked(unchecked((nuint)(UIntPtr)t8TR.Default) + unchecked((nuint)(UIntPtr)t8TR.Default)) == 0)
			{
				_ = (m0PK)(object)t8TR.Default;
			}
			else if (num2 == 0)
			{
				_ = (s0T)(object)t8TR.Default;
			}
			else
			{
				ao = null;
				_ = (s2ZW)(object)t8TR.Default;
				s2ZW = s2ZW;
				nb4n = (Nb4n)(object)t8TR.Default;
			}
		}
		catch
		{
			try
			{
				ao = ao;
				_ = (s0T)(object)t8TR.Default;
				_ = (Cc9k)(object)t8TR.Default;
			}
			finally
			{
				try
				{
					hj2y = hj2y;
				}
				catch
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
				goto end_IL_03b3;
			}
			end_IL_03b3:;
		}
		try
		{
			hj2y = hj2y;
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
				catch
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
			}
			else
			{
				do
				{
					_003CModule_003E = null;
					_ = (m0PK)(object)t8TR.Default;
					nb4n = nb4n;
				}
				while (obj != null);
			}
			goto IL_0447;
		}
		IL_0447:
		s0T = s0T;
		try
		{
			num2 = default(UIntPtr);
			if (num2 != (UIntPtr)(nuint)0u)
			{
				try
				{
					ao = null;
				}
				finally
				{
					_ = (Nb4n)(object)t8TR.Default;
					goto end_IL_044f;
				}
			}
			if (num2 == (UIntPtr)(nuint)0u)
			{
				s0T = s0T;
			}
			end_IL_044f:;
		}
		catch
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
			}
			catch
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		_ = t8TR.Default;
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / num2 == 0)
			{
				p9CA = p9CA;
			}
			else
			{
				o3HG = o3HG;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cc9k cc9k);
		try
		{
			Cc9k obj14 = (Cc9k)(object)t8TR.Default;
			cc9k = cc9k;
			cc9k = obj14;
		}
		finally
		{
			if (num2 == 0)
			{
				_ = (Nb4n)(object)t8TR.Default;
				s2ZW = null;
				_003CModule_003E = null;
				p9CA = null;
			}
			goto IL_053a;
		}
		IL_05b9:
		try
		{
			cc9k = cc9k;
			return;
		}
		finally
		{
			_ = (Ao56)(object)t8TR.Default;
			return;
		}
		IL_0208:
		checked
		{
			if (num2 - unchecked((nuint)(UIntPtr)t8TR.Default) == 0)
			{
				hj2y = (Hj2y)(object)t8TR.Default;
				s2ZW = null;
				nb4n = nb4n;
			}
			num2 = default(UIntPtr);
			UIntPtr num3 = num2;
			UIntPtr num4 = num2;
			num2 = default(UIntPtr);
			if (unchecked((nuint)num3) - unchecked((nuint)num4) * num2 * unchecked((nuint)(UIntPtr)t8TR.Default) == 0)
			{
				s0T = s0T;
			}
			try
			{
			}
			finally
			{
				_ = t8TR.Default;
				_ = (Nb4n)(object)t8TR.Default;
				goto IL_0286;
			}
		}
	}

	static void Mt95()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s0T s0T);
		try
		{
			try
			{
				_ = (Cc9k)(object)t8TR.Default;
				_ = (s0T)(object)t8TR.Default;
				_ = (s2ZW)(object)t8TR.Default;
				_ = (s2ZW)(object)t8TR.Default;
			}
			finally
			{
				try
				{
					s0T = s0T;
					s0T = s0T;
				}
				catch
				{
					m0PK m0PK2 = m0PK2;
					m0PK2 = m0PK2;
				}
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			_ = (Nb4n)(object)t8TR.Default;
			goto IL_0066;
		}
		IL_0066:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s2ZW s2ZW);
		try
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				_ = (y9CZ)(object)t8TR.Default;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				s2ZW obj3 = (s2ZW)(object)t8TR.Default;
				s2ZW = s2ZW;
				s2ZW = obj3;
				obj2 = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o3HG o3HG);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		try
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = (UIntPtr)t8TR.Default;
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Cc9k)(object)t8TR.Default;
					_ = (y9CZ)(object)t8TR.Default;
					_ = (s2ZW)(object)t8TR.Default;
					_ = (Nb4n)(object)t8TR.Default;
				}
				else
				{
					p9CA = (p9CA)(object)t8TR.Default;
					p9CA = p9CA;
				}
			}
			else if (checked(unchecked((nuint)(UIntPtr)t8TR.Default) * (uIntPtr * unchecked((nuint)default(UIntPtr)))) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (o3HG)(object)t8TR.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					s2ZW = s2ZW;
				}
				finally
				{
					_ = (Cc9k)(object)t8TR.Default;
					goto end_IL_0154;
				}
				end_IL_0154:;
			}
			finally
			{
				Hj2y hj2y = (Hj2y)(object)t8TR.Default;
				hj2y = hj2y;
				o3HG obj5 = (o3HG)(object)t8TR.Default;
				o3HG = null;
				o3HG = obj5;
				o3HG = (o3HG)(object)t8TR.Default;
				nb4n = nb4n;
				nb4n = nb4n;
				goto end_IL_0153;
			}
			end_IL_0153:;
		}
		s0T = s0T;
		try
		{
			o3HG = (o3HG)(object)t8TR.Default;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
				finally
				{
					o3HG = o3HG;
					goto IL_01fa;
				}
			}
			goto IL_01fa;
		}
		IL_0427:
		s0T = null;
		_ = (Nb4n)(object)t8TR.Default;
		p9CA = p9CA;
		if (uIntPtr == 0)
		{
			while ((object)t8TR.Default != null)
			{
				nuint num = (nuint)(UIntPtr)t8TR.Default / unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (num / uIntPtr == 0)
				{
					o3HG = o3HG;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8TR t8TR);
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			t8TR = t8TR;
		}
		_ = (Hj2y)(object)t8TR.Default;
		do
		{
			try
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
				}
			}
			catch
			{
				_ = (Cc9k)(object)t8TR.Default;
			}
		}
		while (obj2 != null);
		_ = (Cc9k)(object)t8TR.Default;
		y9CZ y9CZ = null;
		_ = (s2ZW)(object)t8TR.Default;
		_ = (Hj2y)(object)t8TR.Default;
		if (uIntPtr == 0)
		{
		}
		return;
		IL_0384:
		try
		{
		}
		catch
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					nb4n = nb4n;
				}
				else
				{
					nb4n = (Nb4n)(object)t8TR.Default;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked((uIntPtr + uIntPtr) * uIntPtr) == 0)
		{
			_ = t8TR.Default;
			goto IL_0427;
		}
		try
		{
			Ao56 ao = ao;
			ao = ao;
			ao = null;
		}
		finally
		{
			try
			{
				y9CZ = y9CZ;
				y9CZ = y9CZ;
			}
			catch
			{
				_003CModule_003E obj9 = (_003CModule_003E)(object)t8TR.Default;
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj9;
			}
			goto IL_0427;
		}
		IL_01fa:
		try
		{
			try
			{
				try
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
					_ = (Ao56)(object)t8TR.Default;
					goto end_IL_01fc;
				}
				end_IL_01fc:;
			}
			catch
			{
				while (obj2 != null)
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
			}
		}
		catch
		{
			Cc9k cc9k = cc9k;
			cc9k = cc9k;
		}
		while (obj2 != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
				else
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
			}
			else
			{
				_ = (Ao56)(object)t8TR.Default;
				Cc9k cc9k = (Cc9k)(object)t8TR.Default;
				_ = (Nb4n)(object)t8TR.Default;
				_ = (s0T)(object)t8TR.Default;
			}
		}
		_ = (y9CZ)(object)t8TR.Default;
		try
		{
			try
			{
				nb4n = (Nb4n)(object)t8TR.Default;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				goto end_IL_02bb;
			}
			end_IL_02bb:;
		}
		catch
		{
			m0PK m0PK2 = null;
		}
		while (obj2 != null)
		{
			try
			{
				try
				{
					_ = t8TR.Default;
				}
				finally
				{
					_ = (o3HG)(object)t8TR.Default;
					goto end_IL_02f4;
				}
				end_IL_02f4:;
			}
			finally
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					t8TR obj14 = t8TR.Default;
					t8TR = t8TR.Default;
					t8TR = obj14;
				}
				continue;
			}
		}
		while (obj2 != null)
		{
			try
			{
			}
			catch
			{
				_ = (m0PK)(object)t8TR.Default;
			}
		}
		try
		{
			nb4n = null;
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
			}
			finally
			{
				_ = (m0PK)(object)t8TR.Default;
				goto IL_0384;
			}
		}
	}

	static void Mr49()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s2ZW s2ZW);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hj2y hj2y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				num = unchecked((nuint)(UIntPtr)t8TR.Default) + num;
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					while (true)
					{
						obj = obj;
						if (obj != null)
						{
							Nb4n obj2 = (Nb4n)(object)t8TR.Default;
							nb4n = nb4n;
							nb4n = obj2;
							continue;
						}
						break;
					}
				}
				else
				{
					hj2y = hj2y;
					hj2y = null;
				}
			}
			finally
			{
				s2ZW = s2ZW;
				s2ZW = s2ZW;
				goto IL_007b;
			}
		}
		IL_007b:
		_ = (o3HG)(object)t8TR.Default;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)t8TR.Default != (UIntPtr)(nuint)0u)
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
				}
			}
			while ((object)t8TR.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		try
		{
			_ = (p9CA)(object)t8TR.Default;
		}
		catch
		{
			try
			{
				s2ZW = s2ZW;
			}
			finally
			{
				p9CA = null;
				p9CA = null;
				goto end_IL_00d6;
			}
			end_IL_00d6:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cc9k cc9k);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (s0T)(object)t8TR.Default;
				}
				finally
				{
					cc9k = (Cc9k)(object)t8TR.Default;
					cc9k = null;
					goto end_IL_00f0;
				}
			}
			end_IL_00f0:;
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (o3HG)(object)t8TR.Default;
				}
			}
			catch
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
				else
				{
					o3HG o3HG = null;
					o3HG = o3HG;
					o3HG = null;
				}
			}
			goto IL_016b;
		}
		IL_016b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s0T s0T);
		try
		{
			try
			{
				cc9k = (Cc9k)(object)t8TR.Default;
			}
			finally
			{
				try
				{
					_ = (Cc9k)(object)t8TR.Default;
					_ = (o3HG)(object)t8TR.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
					m0PK m0PK2 = m0PK2;
					m0PK2 = m0PK2;
				}
				goto end_IL_016c;
			}
			end_IL_016c:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (s0T)(object)t8TR.Default;
				}
				catch
				{
					_ = (m0PK)(object)t8TR.Default;
				}
			}
			else
			{
				do
				{
					cc9k = null;
					s0T = s0T;
					s0T = s0T;
				}
				while ((object)t8TR.Default != null);
			}
		}
		try
		{
			Ao56 ao = ao;
			ao = ao;
		}
		finally
		{
			do
			{
				_ = (s2ZW)(object)t8TR.Default;
			}
			while (obj != null);
			goto IL_022e;
		}
		IL_03e1:
		_ = (Nb4n)(object)t8TR.Default;
		_ = (p9CA)(object)t8TR.Default;
		try
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				p9CA = p9CA;
			}
			else
			{
				nb4n = nb4n;
			}
		}
		catch
		{
			if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = t8TR.Default;
			}
			else
			{
				_003CModule_003E _003CModule_003E = null;
			}
		}
		finally
		{
			while ((object)t8TR.Default != null)
			{
				while ((object)t8TR.Default != null)
				{
					s0T = null;
				}
			}
			goto IL_0470;
		}
		IL_0470:
		do
		{
			try
			{
				try
				{
					s2ZW = s2ZW;
				}
				finally
				{
					_ = (y9CZ)(object)t8TR.Default;
					goto end_IL_0470;
				}
				end_IL_0470:;
			}
			catch
			{
				try
				{
					_ = (p9CA)(object)t8TR.Default;
				}
				catch
				{
					s2ZW = s2ZW;
				}
			}
		}
		while (obj != null);
		s2ZW = s2ZW;
		_ = (y9CZ)(object)t8TR.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			t8TR obj11 = t8TR.Default;
			t8TR t8TR = t8TR;
			t8TR = obj11;
		}
		else
		{
			_ = (Ao56)(object)t8TR.Default;
			nb4n = null;
			s0T = null;
		}
		while (obj != null)
		{
			try
			{
				_ = (_003CModule_003E)(object)t8TR.Default;
			}
			catch
			{
				_ = (Hj2y)(object)t8TR.Default;
			}
			finally
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
				continue;
			}
		}
		while ((object)t8TR.Default != null)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					nb4n = nb4n;
					_ = t8TR.Default;
					s2ZW = null;
				}
			}
			finally
			{
				_ = (o3HG)(object)t8TR.Default;
				continue;
			}
		}
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					s2ZW = s2ZW;
				}
				finally
				{
					_ = (Cc9k)(object)t8TR.Default;
					continue;
				}
			}
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
			}
		}
		catch
		{
			_ = (Nb4n)(object)t8TR.Default;
		}
		_ = (s2ZW)(object)t8TR.Default;
		return;
		IL_022e:
		try
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (p9CA)(object)t8TR.Default;
					_ = (s2ZW)(object)t8TR.Default;
				}
				catch
				{
					hj2y = null;
				}
			}
			else
			{
				while (obj != null)
				{
					m0PK m0PK2 = (m0PK)(object)t8TR.Default;
				}
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)t8TR.Default;
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (o3HG)(object)t8TR.Default;
				}
			}
			else if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				hj2y = hj2y;
				o3HG o3HG = (o3HG)(object)t8TR.Default;
				_ = (Cc9k)(object)t8TR.Default;
				_ = (m0PK)(object)t8TR.Default;
			}
			else
			{
				_ = t8TR.Default;
			}
		}
		while (obj != null)
		{
			try
			{
				try
				{
					cc9k = null;
				}
				finally
				{
					s2ZW = (s2ZW)(object)t8TR.Default;
					goto end_IL_0320;
				}
				end_IL_0320:;
			}
			finally
			{
				try
				{
					cc9k = cc9k;
				}
				catch
				{
					_ = (Cc9k)(object)t8TR.Default;
				}
				continue;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				o3HG o3HG = (o3HG)(object)t8TR.Default;
			}
			catch
			{
				s0T = s0T;
			}
			finally
			{
				try
				{
					o3HG o3HG = (o3HG)(object)t8TR.Default;
				}
				catch
				{
					Ao56 ao = null;
				}
				goto IL_03e1;
			}
		}
		checked
		{
			if (num + unchecked((nuint)(UIntPtr)t8TR.Default) == 0)
			{
				while ((object)t8TR.Default != null)
				{
					cc9k = cc9k;
					_ = (o3HG)(object)t8TR.Default;
					_ = (p9CA)(object)t8TR.Default;
				}
			}
			goto IL_03e1;
		}
	}

	static void q5BA()
	{
		nuint uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s2ZW s2ZW);
		try
		{
			_ = (p9CA)(object)t8TR.Default;
			s2ZW = null;
			s2ZW = null;
		}
		finally
		{
			uIntPtr = (UIntPtr)t8TR.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr - unchecked((nuint)(UIntPtr)t8TR.Default) == 0)
				{
					try
					{
						s0T s0T = null;
						s0T = s0T;
					}
					finally
					{
						_ = (s0T)(object)t8TR.Default;
						goto IL_005e;
					}
				}
				goto IL_005e;
			}
		}
		IL_005e:
		nuint num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		Hj2y hj2y;
		if (checked(num + uIntPtr) == 0)
		{
			try
			{
				while (true)
				{
					obj = t8TR.Default;
					if (obj != null)
					{
						s0T s0T = null;
						continue;
					}
					break;
				}
			}
			catch
			{
				hj2y = (Hj2y)(object)t8TR.Default;
				hj2y = hj2y;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cc9k cc9k);
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
		{
			while (obj != null)
			{
				cc9k = cc9k;
				cc9k = cc9k;
			}
		}
		try
		{
			while (obj != null)
			{
			}
		}
		catch
		{
			_ = (s0T)(object)t8TR.Default;
		}
		do
		{
			_ = (s0T)(object)t8TR.Default;
		}
		while (obj != null || obj != null);
		while ((object)t8TR.Default != null)
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = t8TR.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o3HG o3HG);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0PK m0PK2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8TR t8TR);
		y9CZ y9CZ;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ao56 ao);
		checked
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * unchecked((nuint)(UIntPtr)t8TR.Default / checked(unchecked((nuint)(UIntPtr)t8TR.Default) * uIntPtr)) == 0)
				{
					nuint num2 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 - uIntPtr == 0)
					{
						_ = t8TR.Default;
						_ = (Nb4n)(object)t8TR.Default;
						t8TR = t8TR;
						t8TR = null;
						_ = (_003CModule_003E)(object)t8TR.Default;
					}
				}
				else
				{
					try
					{
						o3HG = o3HG;
						o3HG = null;
					}
					catch
					{
						cc9k = cc9k;
					}
				}
			}
			finally
			{
				try
				{
					try
					{
						ao = ao;
						m0PK obj5 = (m0PK)(object)t8TR.Default;
						m0PK2 = (m0PK)(object)t8TR.Default;
						m0PK2 = obj5;
					}
					finally
					{
						_ = (p9CA)(object)t8TR.Default;
						goto end_IL_01b6;
					}
					end_IL_01b6:;
				}
				finally
				{
					ao = null;
					y9CZ = null;
					y9CZ = y9CZ;
					goto IL_0202;
				}
			}
		}
		IL_0202:
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		y9CZ = null;
		hj2y = (Hj2y)(object)t8TR.Default;
		p9CA p9CA = p9CA;
		p9CA = null;
		t8TR = null;
		_ = (s0T)(object)t8TR.Default;
		_ = (Nb4n)(object)t8TR.Default;
		_ = (s2ZW)(object)t8TR.Default;
		_ = (y9CZ)(object)t8TR.Default;
		try
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = t8TR.Default;
				}
			}
			else
			{
				do
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			nuint num3 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num3 - uIntPtr) == 0)
			{
				cc9k = cc9k;
			}
			else if (uIntPtr / uIntPtr == 0)
			{
				_ = (m0PK)(object)t8TR.Default;
			}
		}
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					do
					{
						p9CA = (p9CA)(object)t8TR.Default;
					}
					while (obj != null);
				}
				catch
				{
					nuint num4 = unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)(UIntPtr)t8TR.Default);
					uIntPtr = default(UIntPtr);
					if (num4 * uIntPtr == 0)
					{
						_ = (y9CZ)(object)t8TR.Default;
					}
					else
					{
						p9CA = null;
					}
				}
			}
		}
		else if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Nb4n)(object)t8TR.Default;
		}
		while (obj != null)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
			while (obj != null);
		}
		do
		{
			ao = ao;
			_ = (_003CModule_003E)(object)t8TR.Default;
			_ = (y9CZ)(object)t8TR.Default;
			_ = (y9CZ)(object)t8TR.Default;
		}
		while (obj != null);
		_ = (Hj2y)(object)t8TR.Default;
		t8TR = t8TR.Default;
		_ = t8TR.Default;
		_ = (Hj2y)(object)t8TR.Default;
		while (true)
		{
			if ((object)t8TR.Default != null)
			{
				try
				{
					_ = (Hj2y)(object)t8TR.Default;
					m0PK2 = (m0PK)(object)t8TR.Default;
					s0T s0T = (s0T)(object)t8TR.Default;
				}
				catch
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		while ((object)t8TR.Default != null)
		{
			do
			{
				_ = (Hj2y)(object)t8TR.Default;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			t8TR = t8TR;
		}
		_ = (Hj2y)(object)t8TR.Default;
		try
		{
			o3HG = o3HG;
		}
		catch
		{
			_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
			s2ZW = (s2ZW)(object)t8TR.Default;
		}
		finally
		{
			try
			{
				_ = (s2ZW)(object)t8TR.Default;
			}
			catch
			{
				_ = (m0PK)(object)t8TR.Default;
			}
			goto IL_04f3;
		}
		IL_04f3:
		while ((object)t8TR.Default != null)
		{
			try
			{
				while (obj != null)
				{
					_ = (m0PK)(object)t8TR.Default;
					y9CZ = null;
				}
			}
			finally
			{
				_ = (Hj2y)(object)t8TR.Default;
				_ = (Ao56)(object)t8TR.Default;
				o3HG = o3HG;
				continue;
			}
		}
		hj2y = hj2y;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			nuint num5 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			checked
			{
				nuint num6 = num5 - (unchecked((nuint)default(UIntPtr)) - uIntPtr);
				nuint num7 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * (num6 - unchecked(num7 / uIntPtr)) == 0)
				{
					if (unchecked(uIntPtr / uIntPtr) == 0)
					{
						s0T s0T = (s0T)(object)t8TR.Default;
					}
					else
					{
						_ = (_003CModule_003E)(object)t8TR.Default;
						_ = (Cc9k)(object)t8TR.Default;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		try
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					p9CA = (p9CA)(object)t8TR.Default;
					_ = (s0T)(object)t8TR.Default;
					m0PK2 = m0PK2;
				}
			}
			else
			{
				hj2y = (Hj2y)(object)t8TR.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					nb4n = nb4n;
					s2ZW = s2ZW;
					m0PK2 = m0PK2;
				}
				finally
				{
					ao = (Ao56)(object)t8TR.Default;
					_ = (Ao56)(object)t8TR.Default;
					hj2y = hj2y;
					cc9k = cc9k;
					goto end_IL_05ed;
				}
				end_IL_05ed:;
			}
			finally
			{
				s0T s0T = null;
				goto end_IL_05ec;
			}
			end_IL_05ec:;
		}
		while (obj != null)
		{
			do
			{
				_ = (s2ZW)(object)t8TR.Default;
				_ = (Nb4n)(object)t8TR.Default;
				_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
				_ = (_003CModule_003E)(object)t8TR.Default;
			}
			while (obj != null);
		}
		try
		{
			try
			{
				p9CA = null;
			}
			catch
			{
				y9CZ = null;
				cc9k = null;
				_ = (y9CZ)(object)t8TR.Default;
			}
			finally
			{
				try
				{
					_ = (s2ZW)(object)t8TR.Default;
					_ = (o3HG)(object)t8TR.Default;
					nb4n = nb4n;
				}
				finally
				{
					_ = (Nb4n)(object)t8TR.Default;
					t8TR = t8TR;
					goto end_IL_0679;
				}
			}
			end_IL_0679:;
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					s2ZW = (s2ZW)(object)t8TR.Default;
				}
			}
			finally
			{
				try
				{
					_ = (s0T)(object)t8TR.Default;
					_ = (s0T)(object)t8TR.Default;
				}
				finally
				{
					ao = null;
					goto end_IL_06d6;
				}
			}
			end_IL_06d6:;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)t8TR.Default) * uIntPtr == 0)
			{
				hj2y = hj2y;
			}
		}
	}
}
