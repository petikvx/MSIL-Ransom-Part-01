using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hn20;
using Lg2q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nw4c;
using Rm76;
using Wj80;
using d8Y9;
using f7W1;
using m7A6;
using o7R3;
using t3B2;
using t4PD;

namespace Bp2s;

[DesignerGenerated]
public class Ym89 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("LogoPictureBox")]
	internal virtual PictureBox LogoPictureBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label UsernameLabel
	{
		[CompilerGenerated]
		get
		{
			return _UsernameLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Li48;
			Label usernameLabel = _UsernameLabel;
			if (usernameLabel != null)
			{
				((Control)usernameLabel).remove_Click(eventHandler);
			}
			_UsernameLabel = value;
			usernameLabel = _UsernameLabel;
			if (usernameLabel != null)
			{
				((Control)usernameLabel).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PasswordLabel")]
	internal virtual Label PasswordLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameTextBox")]
	internal virtual TextBox UsernameTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordTextBox")]
	internal virtual TextBox PasswordTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wr83;
			Button oK = _OK;
			if (oK != null)
			{
				((Control)oK).remove_Click(eventHandler);
			}
			_OK = value;
			oK = _OK;
			if (oK != null)
			{
				((Control)oK).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Cancel
	{
		[CompilerGenerated]
		get
		{
			return _Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Rj45;
			Button cancel = _Cancel;
			if (cancel != null)
			{
				((Control)cancel).remove_Click(eventHandler);
			}
			_Cancel = value;
			cancel = _Cancel;
			if (cancel != null)
			{
				((Control)cancel).add_Click(eventHandler);
			}
		}
	}

	public Ym89()
	{
		((Form)this).add_Load((EventHandler)Na6c);
		q9N1();
	}

	[DebuggerNonUserCode]
	protected override void p6RA(bool k8H0)
	{
		try
		{
			if (k8H0 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k8H0);
		}
	}

	[DebuggerStepThrough]
	private void q9N1()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ym89));
		LogoPictureBox = new PictureBox();
		UsernameLabel = new Label();
		PasswordLabel = new Label();
		UsernameTextBox = new TextBox();
		PasswordTextBox = new TextBox();
		OK = new Button();
		Cancel = new Button();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		((Control)LogoPictureBox).set_Location(new Point(0, 0));
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		((Control)LogoPictureBox).set_Size(new Size(165, 193));
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)UsernameLabel).set_Location(new Point(172, 24));
		((Control)UsernameLabel).set_Name("UsernameLabel");
		((Control)UsernameLabel).set_Size(new Size(220, 23));
		((Control)UsernameLabel).set_TabIndex(0);
		UsernameLabel.set_Text("&User name");
		UsernameLabel.set_TextAlign((ContentAlignment)16);
		((Control)PasswordLabel).set_Location(new Point(172, 81));
		((Control)PasswordLabel).set_Name("PasswordLabel");
		((Control)PasswordLabel).set_Size(new Size(220, 23));
		((Control)PasswordLabel).set_TabIndex(2);
		PasswordLabel.set_Text("&Password");
		PasswordLabel.set_TextAlign((ContentAlignment)16);
		((Control)UsernameTextBox).set_Location(new Point(174, 44));
		((Control)UsernameTextBox).set_Name("UsernameTextBox");
		((Control)UsernameTextBox).set_Size(new Size(220, 20));
		((Control)UsernameTextBox).set_TabIndex(1);
		((Control)PasswordTextBox).set_Location(new Point(174, 101));
		((Control)PasswordTextBox).set_Name("PasswordTextBox");
		PasswordTextBox.set_PasswordChar('*');
		((Control)PasswordTextBox).set_Size(new Size(220, 20));
		((Control)PasswordTextBox).set_TabIndex(3);
		((Control)OK).set_Location(new Point(197, 161));
		((Control)OK).set_Name("OK");
		((Control)OK).set_Size(new Size(94, 23));
		((Control)OK).set_TabIndex(4);
		((ButtonBase)OK).set_Text("&OK");
		Cancel.set_DialogResult((DialogResult)2);
		((Control)Cancel).set_Location(new Point(300, 161));
		((Control)Cancel).set_Name("Cancel");
		((Control)Cancel).set_Size(new Size(94, 23));
		((Control)Cancel).set_TabIndex(5);
		((ButtonBase)Cancel).set_Text("&Cancel");
		((Form)this).set_AcceptButton((IButtonControl)(object)OK);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)Cancel);
		((Form)this).set_ClientSize(new Size(401, 192));
		((Control)this).get_Controls().Add((Control)(object)Cancel);
		((Control)this).get_Controls().Add((Control)(object)OK);
		((Control)this).get_Controls().Add((Control)(object)PasswordTextBox);
		((Control)this).get_Controls().Add((Control)(object)UsernameTextBox);
		((Control)this).get_Controls().Add((Control)(object)PasswordLabel);
		((Control)this).get_Controls().Add((Control)(object)UsernameLabel);
		((Control)this).get_Controls().Add((Control)(object)LogoPictureBox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Login");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("LOGIN - RAFLI RAMADHAN");
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void d4D3()
	{
		((TextBoxBase)UsernameTextBox).Clear();
		((TextBoxBase)PasswordTextBox).Clear();
		((Control)UsernameTextBox).Focus();
	}

	public void p3J9()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		y4B7.j1DM();
		y4B7.cmd = new SqlCommand("select * from tbl_user where username='" + UsernameTextBox.get_Text() + "' AND password='" + PasswordTextBox.get_Text() + "'", y4B7.conn);
		y4B7.dr = y4B7.cmd.ExecuteReader();
		y4B7.dr.Read();
	}

	private void Wr83(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Xq18 xq = new Xq18();
		p3J9();
		if (y4B7.dr.get_HasRows())
		{
			((ToolStripItem)xq.kodeuser).set_Text(Conversions.ToString(y4B7.dr.get_Item(0)));
			((Control)this).set_Visible(false);
			((Control)xq).Show();
		}
		else
		{
			Interaction.MsgBox((object)"Username atau password salah", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Rj45(object sender, EventArgs e)
	{
		d4D3();
	}

	private void Li48(object sender, EventArgs e)
	{
	}

	private void Na6c(object sender, EventArgs e)
	{
		((Form)this).CenterToScreen();
	}

	[STAThread]
	public static void n8TS()
	{
		checked
		{
			try
			{
				int num = 4;
				while (!Ld7n.d6D1())
				{
					num *= 2;
					if (num > 100000)
					{
						num = (int)Math.Round((double)num / 50000.0);
					}
				}
				List<object> list = new List<object>();
				int num2 = list.Count;
				while (num2 <= 0)
				{
					num2++;
					list.Add(num2);
				}
				list.Add(Assembly.LoadFrom(Application.get_ExecutablePath()));
				list.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(list[1], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)));
				if (list[2] != null && list.Count > 2)
				{
					Ld7n.t0JT(list);
					num2 = list.Count;
					if (num2 > 0)
					{
						num2 = num2 * 25 * 25;
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

	static void Br21()
	{
		nuint uIntPtr = (UIntPtr)n2H1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq18 xq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Pd01 obj = (Pd01)(object)n2H1.Default;
					pd = null;
					pd = obj;
				}
				finally
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					goto end_IL_0014;
				}
				end_IL_0014:;
			}
			catch
			{
				Xq18 obj2 = (Xq18)(object)n2H1.Default;
				xq = null;
				xq = obj2;
				obj3 = null;
			}
		}
		else
		{
			while (obj3 != null)
			{
				t8X = t8X;
				t8X = t8X;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					ym = ym;
					ym = null;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (y4B7)(object)n2H1.Default;
				}
				finally
				{
					_ = (Pd01)(object)n2H1.Default;
					goto end_IL_0089;
				}
				end_IL_0089:;
			}
			catch
			{
				while (true)
				{
					_ = (Pd01)(object)n2H1.Default;
					if ((object)n2H1.Default != null)
					{
						continue;
					}
					goto end_IL_00a6;
				}
				end_IL_00a6:;
			}
		}
		ym = (Ym89)(object)n2H1.Default;
		_ = (w4M5)(object)n2H1.Default;
		_ = (Pd01)(object)n2H1.Default;
		y4B7 y4B = y4B;
		y4B = y4B;
		_003CModule_003E _003CModule_003E;
		try
		{
			_ = (d3CT)(object)n2H1.Default;
		}
		finally
		{
			_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
			_003CModule_003E = _003CModule_003E;
			_ = (d3CT)(object)n2H1.Default;
			goto IL_0126;
		}
		IL_057e:
		Ps93 ps;
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					n2H1 n2H = n2H1.Default;
				}
			}
		}
		else
		{
			try
			{
				UIntPtr num = (UIntPtr)n2H1.Default;
				uIntPtr = default(UIntPtr);
				nuint num2 = checked(unchecked((nuint)num) + uIntPtr) / (nuint)(UIntPtr)n2H1.Default;
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num2 + (num3 + uIntPtr)) == 0)
				{
					xq = (Xq18)(object)n2H1.Default;
				}
			}
			catch
			{
				if (uIntPtr / uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					t8X = t8X;
					n2H1 n2H = n2H1.Default;
					ps = null;
				}
				else
				{
					_ = (Pd01)(object)n2H1.Default;
					_ = (Ym89)(object)n2H1.Default;
				}
			}
		}
		_ = (Pd01)(object)n2H1.Default;
		d3CT d3CT = d3CT;
		do
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		while (obj3 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				w4M = w4M;
				continue;
			}
			while (obj3 != null)
			{
				t8X = (t8X9)(object)n2H1.Default;
			}
		}
		xq = xq;
		_ = (w4M5)(object)n2H1.Default;
		t8X = (t8X9)(object)n2H1.Default;
		while (obj3 != null)
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					pd = (Pd01)(object)n2H1.Default;
				}
				else
				{
					_ = (d3CT)(object)n2H1.Default;
				}
			}
			finally
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y4B7)(object)n2H1.Default;
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
				}
				continue;
			}
		}
		try
		{
		}
		finally
		{
			goto IL_0715;
		}
		IL_0744:
		_ = (Ge4b)(object)n2H1.Default;
		return;
		IL_0333:
		uIntPtr = default(UIntPtr);
		if (uIntPtr / uIntPtr == 0)
		{
			do
			{
				t8X = null;
			}
			while (obj3 != null);
		}
		else
		{
			checked
			{
				try
				{
					while (obj3 != null)
					{
						_ = (t8X9)(object)n2H1.Default;
					}
				}
				catch
				{
					if (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)n2H1.Default)) == 0)
					{
						_ = (w4M5)(object)n2H1.Default;
					}
					else
					{
						xq = (Xq18)(object)n2H1.Default;
						_ = (Xq18)(object)n2H1.Default;
						ym = ym;
						_ = (Ld7n)(object)n2H1.Default;
					}
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
				finally
				{
					_ = (w4M5)(object)n2H1.Default;
					goto end_IL_03e2;
				}
				end_IL_03e2:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
				}
				goto IL_0412;
			}
		}
		goto IL_0412;
		IL_0715:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		try
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					ge4b = ge4b;
				}
			}
			catch
			{
				xq = xq;
			}
			goto IL_0744;
		}
		IL_0126:
		try
		{
			Ps93 obj10 = (Ps93)(object)n2H1.Default;
			ps = (Ps93)(object)n2H1.Default;
			ps = obj10;
		}
		catch
		{
			try
			{
				try
				{
				}
				finally
				{
					t8X = (t8X9)(object)n2H1.Default;
					goto end_IL_0146;
				}
				end_IL_0146:;
			}
			finally
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				goto end_IL_0145;
			}
			end_IL_0145:;
		}
		try
		{
			do
			{
				try
				{
					_ = (y4B7)(object)n2H1.Default;
					n2H1 n2H = null;
					n2H = n2H;
					_ = (Ps93)(object)n2H1.Default;
				}
				finally
				{
					_ = n2H1.Default;
					continue;
				}
			}
			while ((object)n2H1.Default != null);
		}
		finally
		{
			ps = null;
			goto IL_01c0;
		}
		IL_04e8:
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
				{
					try
					{
						pd = pd;
					}
					catch
					{
						_ = (_003CModule_003E)(object)n2H1.Default;
						_ = (Ps93)(object)n2H1.Default;
						_ = (Pd01)(object)n2H1.Default;
					}
				}
			}
		}
		try
		{
			while (obj3 != null)
			{
				_ = (Ge4b)(object)n2H1.Default;
			}
		}
		catch
		{
		}
		finally
		{
			y4B = y4B;
			_ = (Ge4b)(object)n2H1.Default;
			_ = (_003CModule_003E)(object)n2H1.Default;
			goto IL_057e;
		}
		IL_01c0:
		try
		{
			while (obj3 != null)
			{
				_ = (d3CT)(object)n2H1.Default;
				_ = n2H1.Default;
			}
		}
		finally
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
			goto IL_01ef;
		}
		IL_01ef:
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
			do
			{
				q0D = q0D;
				q0D = q0D;
			}
			while (obj3 != null);
		}
		catch
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		_ = (Ym89)(object)n2H1.Default;
		try
		{
			do
			{
				d3CT obj15 = (d3CT)(object)n2H1.Default;
				d3CT = (d3CT)(object)n2H1.Default;
				d3CT = obj15;
				t8X = t8X;
				Ge4b obj16 = (Ge4b)(object)n2H1.Default;
				ge4b = null;
				ge4b = obj16;
				_ = (Ym89)(object)n2H1.Default;
			}
			while (obj3 != null);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				UIntPtr num4 = (UIntPtr)n2H1.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num4) - uIntPtr == 0)
					{
						w4M = (w4M5)(object)n2H1.Default;
						w4M = w4M;
					}
					else
					{
						_ = (q0D6)(object)n2H1.Default;
					}
				}
			}
			goto IL_02bd;
		}
		IL_0412:
		_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
		ps = ps;
		while (obj3 != null)
		{
		}
		do
		{
			try
			{
				do
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				while (obj3 != null)
				{
					ym = ym;
				}
				continue;
			}
		}
		while ((object)n2H1.Default != null);
		do
		{
			try
			{
				try
				{
					ge4b = ge4b;
				}
				catch
				{
					ym = ym;
				}
			}
			catch
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					q0D6 q0D = null;
					goto end_IL_047b;
				}
				end_IL_047b:;
			}
		}
		while ((object)n2H1.Default != null);
		try
		{
			_ = (d3CT)(object)n2H1.Default;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (w4M5)(object)n2H1.Default;
			}
			else
			{
				_ = (Ld7n)(object)n2H1.Default;
			}
		}
		finally
		{
			try
			{
			}
			finally
			{
				_ = (w4M5)(object)n2H1.Default;
				goto IL_04e8;
			}
		}
		IL_02bd:
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)n2H1.Default / uIntPtr) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = n2H1.Default;
				}
			}
			else
			{
				_ = (d3CT)(object)n2H1.Default;
			}
		}
		finally
		{
			while (obj3 != null)
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				finally
				{
					_ = (q0D6)(object)n2H1.Default;
					ym = null;
					continue;
				}
			}
			goto IL_0333;
		}
	}

	static void i1JL()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		checked
		{
			num *= unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)));
			if (num == 0)
			{
				try
				{
					try
					{
						_ = (Pd01)(object)n2H1.Default;
						w4M = w4M;
						w4M = w4M;
						q0D6 q0D = q0D;
						q0D = null;
					}
					catch
					{
						w4M = null;
					}
				}
				catch
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (q0D6)(object)n2H1.Default;
					}
					else
					{
						_ = (Ps93)(object)n2H1.Default;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				y4B = y4B;
				y4B = null;
			}
			finally
			{
				_ = (y4B7)(object)n2H1.Default;
				goto IL_00c3;
			}
		}
		goto IL_00c3;
		IL_01f6:
		Xq18 xq;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		if (num == 0)
		{
			try
			{
				ld7n = null;
			}
			finally
			{
				xq = xq;
				goto IL_020d;
			}
		}
		goto IL_020d;
		IL_00c3:
		object obj3 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		while ((object)n2H1.Default != null)
		{
			t8X9 obj4 = (t8X9)(object)n2H1.Default;
			t8X = t8X;
			t8X = obj4;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)n2H1.Default != null)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				ps = ps;
				ps = ps;
			}
		}
		xq = (Xq18)(object)n2H1.Default;
		xq = xq;
		xq = null;
		Pd01 pd = pd;
		pd = null;
		w4M = (w4M5)(object)n2H1.Default;
		_ = (Ps93)(object)n2H1.Default;
		UIntPtr num2 = num;
		UIntPtr num3 = (UIntPtr)n2H1.Default;
		num = default(UIntPtr);
		nuint num4 = num / checked(num + unchecked((nuint)default(UIntPtr)));
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3CT d3CT);
		checked
		{
			if (unchecked((nuint)num2) + unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)num3) * (num4 - num)) == 0)
			{
				try
				{
					_ = (Ps93)(object)n2H1.Default;
				}
				finally
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						d3CT = d3CT;
					}
					goto IL_01f6;
				}
			}
			goto IL_01f6;
		}
		IL_020d:
		try
		{
			ld7n = ld7n;
			_ = (w4M5)(object)n2H1.Default;
			ld7n = ld7n;
		}
		catch
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					y4B = y4B;
				}
			}
			while (obj3 != null);
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					w4M = w4M;
				}
			}
			else
			{
				ps = ps;
			}
		}
		try
		{
		}
		catch
		{
			d3CT = d3CT;
			xq = (Xq18)(object)n2H1.Default;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)n2H1.Default) + unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
			{
				try
				{
					try
					{
						_ = (Ps93)(object)n2H1.Default;
					}
					catch
					{
						d3CT = (d3CT)(object)n2H1.Default;
					}
				}
				catch
				{
					do
					{
						_ = (y4B7)(object)n2H1.Default;
					}
					while (obj3 != null);
				}
			}
			_ = (y4B7)(object)n2H1.Default;
			while ((object)n2H1.Default != null)
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Ym89)(object)n2H1.Default;
				}
			}
		}
		do
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				finally
				{
					ps = ps;
					_ = (q0D6)(object)n2H1.Default;
					_ = (q0D6)(object)n2H1.Default;
					continue;
				}
			}
		}
		while ((object)n2H1.Default != null);
		d3CT = d3CT;
		_ = (Ym89)(object)n2H1.Default;
		xq = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)n2H1.Default) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						Ge4b obj9 = (Ge4b)(object)n2H1.Default;
						Ge4b ge4b = ge4b;
						ge4b = obj9;
					}
					else
					{
						_ = (_003CModule_003E)(object)n2H1.Default;
					}
				}
				catch
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
		}
		while (obj3 != null)
		{
			_ = n2H1.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			pd = null;
		}
		else
		{
			while (obj3 != null)
			{
			}
		}
		_ = (t8X9)(object)n2H1.Default;
		ld7n = null;
	}
}
