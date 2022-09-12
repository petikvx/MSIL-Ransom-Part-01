using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using La50;
using Lg1;
using Microsoft.VisualBasic.CompilerServices;
using Yi2x;
using Yw2;
using b8ED;
using e2N;
using f0B;
using f2H;
using f2K3;
using f4A;
using m4K5;
using m7A;
using r4B;
using r4Z;
using s6Y;
using w7Y6;
using w8E;

namespace Qo03;

[DesignerGenerated]
public class g2M8 : Form
{
	private IContainer components;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e0R7;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUsername")]
	internal virtual TextBox txtUsername
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPassword")]
	internal virtual TextBox txtPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public g2M8()
	{
		Qy5f();
	}

	[DebuggerNonUserCode]
	protected override void Hz2o(bool Rc4i)
	{
		try
		{
			if (Rc4i && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rc4i);
		}
	}

	[DebuggerStepThrough]
	private void Qy5f()
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
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		Button1 = new Button();
		Button2 = new Button();
		txtUsername = new TextBox();
		txtPassword = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.FromArgb(128, 128, 255));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.White);
		((Control)Button1).set_Location(new Point(48, 137));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(84, 29));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Login");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(Color.FromArgb(128, 128, 255));
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.White);
		((Control)Button2).set_Location(new Point(149, 137));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(84, 29));
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Cancel");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Control)txtUsername).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtUsername).set_ForeColor(Color.Purple);
		((Control)txtUsername).set_Location(new Point(139, 57));
		((Control)txtUsername).set_Name("txtUsername");
		((Control)txtUsername).set_Size(new Size(104, 23));
		((Control)txtUsername).set_TabIndex(2);
		txtUsername.set_TextAlign((HorizontalAlignment)2);
		((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtPassword).set_ForeColor(Color.Purple);
		((Control)txtPassword).set_Location(new Point(139, 96));
		((Control)txtPassword).set_Name("txtPassword");
		txtPassword.set_PasswordChar('#');
		((Control)txtPassword).set_Size(new Size(104, 23));
		((Control)txtPassword).set_TabIndex(3);
		txtPassword.set_TextAlign((HorizontalAlignment)2);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(46, 56));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(91, 17));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Username :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(46, 102));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(87, 17));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Password :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(108, 22));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(48, 17));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Login");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(283, 189));
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtPassword);
		((Control)this).get_Controls().Add((Control)(object)txtUsername);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Login");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Login");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void e0R7(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0))
		{
			MessageBox.Show("Login Successfully...!");
			o7A o7A = new o7A();
			((Control)o7A).Show();
			((Control)this).Hide();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password...!");
		}
	}

	static void g5EP()
	{
		UIntPtr num = (UIntPtr)s6J.Default;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2M8 g2M9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		if (checked(unchecked((nuint)num) - uIntPtr) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ap93)(object)s6J.Default;
				}
				else
				{
					_ = (c7R)(object)s6J.Default;
				}
			}
			else
			{
				try
				{
					_ = (c7B)(object)s6J.Default;
					g2M9 = null;
					g2M9 = g2M9;
					m1S = m1S;
					m1S = m1S;
					_ = s6J.Default;
				}
				catch
				{
					c7B = c7B;
					c7B = c7B;
				}
			}
		}
		else
		{
			try
			{
				o7A = o7A;
				o7A = null;
				o7A = o7A;
			}
			catch
			{
				tb = tb;
				tb = null;
			}
			obj3 = null;
		}
		_ = (Wm5)(object)s6J.Default;
		if (uIntPtr / uIntPtr == 0)
		{
			_ = (Qy5m)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		try
		{
			c7B = c7B;
		}
		finally
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
				}
				catch
				{
					pg = pg;
					pg = pg;
				}
			}
			goto IL_0137;
		}
		IL_0604:
		Wm5 wm = wm;
		while (obj3 != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				c7B = null;
				continue;
			}
			while (obj3 != null)
			{
				_ = (Rg0)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		try
		{
			_ = (o7A)(object)s6J.Default;
			a0E = null;
			_ = (Qy5m)(object)s6J.Default;
		}
		finally
		{
			wm = null;
			goto IL_0661;
		}
		IL_046a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		try
		{
		}
		finally
		{
			if (uIntPtr == 0 && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				m2R = null;
			}
			goto IL_0486;
		}
		IL_055d:
		x2K9 x2K = x2K;
		_ = (_003CModule_003E)(object)s6J.Default;
		m1S = (m1S6)(object)s6J.Default;
		c7B = c7B;
		_ = (a0E)(object)s6J.Default;
		do
		{
			try
			{
				_ = (d9N2)(object)s6J.Default;
			}
			catch
			{
				_ = (m9B)(object)s6J.Default;
			}
		}
		while ((object)s6J.Default != null || obj3 != null);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				pg = pg;
				_ = (m9B)(object)s6J.Default;
				_ = (Ap93)(object)s6J.Default;
			}
			goto IL_0604;
		}
		try
		{
			m1S = m1S;
		}
		finally
		{
			g2M9 = g2M9;
			goto IL_0604;
		}
		IL_019a:
		try
		{
			while (obj3 != null)
			{
				if (uIntPtr == 0)
				{
					a0E = null;
					a0E = a0E;
				}
			}
		}
		finally
		{
			while (obj3 != null)
			{
				if (uIntPtr == 0)
				{
					o7A = o7A;
				}
			}
			goto IL_01d2;
		}
		IL_0661:
		while (obj3 != null)
		{
		}
		_ = (c7R)(object)s6J.Default;
		while (obj3 != null)
		{
			_ = (Tb9)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					dw = dw;
				}
				finally
				{
					x2K = (x2K9)(object)s6J.Default;
					goto end_IL_0685;
				}
			}
			end_IL_0685:;
		}
		catch
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					_ = (Qy5m)(object)s6J.Default;
					_ = (m9B)(object)s6J.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		checked
		{
			if (unchecked((nuint)(UIntPtr)s6J.Default) - uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					s6J = s6J;
				}
				else
				{
					pg = (Pg6)(object)s6J.Default;
				}
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)s6J.Default;
					return;
				}
				catch
				{
					m1S = m1S;
					return;
				}
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (m9B)(object)s6J.Default;
				}
				return;
			}
		}
		catch
		{
			try
			{
				m1S = m1S;
				return;
			}
			catch
			{
				try
				{
					o7A = (o7A)(object)s6J.Default;
					return;
				}
				catch
				{
					a0E = a0E;
					return;
				}
			}
		}
		IL_0137:
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					tb = null;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				try
				{
					x2K = (x2K9)(object)s6J.Default;
					x2K = null;
				}
				finally
				{
					Qy5m qy5m = qy5m;
					qy5m = qy5m;
					goto IL_019a;
				}
			}
		}
		goto IL_019a;
		IL_01d2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		try
		{
			if (checked(uIntPtr - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c7B)(object)s6J.Default;
				}
				else
				{
					ap = (Ap93)(object)s6J.Default;
					ap = null;
				}
			}
			else
			{
				while (obj3 != null)
				{
					m2R obj13 = (m2R)(object)s6J.Default;
					m2R = m2R;
					m2R = obj13;
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					g2M9 = g2M9;
				}
			}
		}
		do
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				dw = null;
				dw = null;
			}
		}
		while ((object)s6J.Default != null || obj3 != null);
		try
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (m2R)(object)s6J.Default;
				}
			}
			else
			{
				x2K = (x2K9)(object)s6J.Default;
			}
		}
		catch
		{
			ap = null;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
		{
			while (obj3 != null)
			{
				_ = (c7R)(object)s6J.Default;
			}
		}
		_ = (Rg0)(object)s6J.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			c7B = c7B;
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj3 != null)
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					continue;
				}
			}
		}
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					g2M9 = (g2M8)(object)s6J.Default;
				}
				else
				{
					tb = tb;
				}
			}
			catch
			{
				try
				{
					_ = (Wm5)(object)s6J.Default;
				}
				finally
				{
					_ = (g2M8)(object)s6J.Default;
					goto end_IL_0363;
				}
				end_IL_0363:;
			}
		}
		while ((object)s6J.Default != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)s6J.Default) + uIntPtr == 0)
			{
				do
				{
					try
					{
						ap = ap;
						_ = (Rg0)(object)s6J.Default;
					}
					finally
					{
						_ = (m9B)(object)s6J.Default;
						_ = (m9B)(object)s6J.Default;
						m2R = m2R;
						a0E = (a0E)(object)s6J.Default;
						Rg0 rg = null;
						rg = rg;
						continue;
					}
				}
				while (obj3 != null);
			}
		}
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				wm = wm;
				wm = wm;
			}
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = s6J.Default;
				}
				else
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
			catch
			{
				_ = (Pg6)(object)s6J.Default;
				_ = (Qy5m)(object)s6J.Default;
				m1S = (m1S6)(object)s6J.Default;
			}
			goto IL_046a;
		}
		IL_0486:
		_ = (Rg0)(object)s6J.Default;
		while ((object)s6J.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					c7B = (c7B)(object)s6J.Default;
				}
				catch
				{
					x2K = x2K;
				}
			}
			else
			{
				_ = (m9B)(object)s6J.Default;
				_ = (Dw54)(object)s6J.Default;
				_ = (m1S6)(object)s6J.Default;
			}
		}
		c7B = c7B;
		x2K = (x2K9)(object)s6J.Default;
		_ = (Pg6)(object)s6J.Default;
		try
		{
			try
			{
				try
				{
					_ = (Qy5m)(object)s6J.Default;
				}
				finally
				{
					c7B = c7B;
					goto end_IL_050d;
				}
				end_IL_050d:;
			}
			finally
			{
				s6J = s6J.Default;
				s6J = null;
				goto end_IL_050c;
			}
			end_IL_050c:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					m2R = null;
				}
			}
			goto IL_055d;
		}
	}

	static void j5GD()
	{
		UIntPtr uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					o7A = (o7A)(object)s6J.Default;
					o7A = null;
					obj = obj;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = (x2K9)(object)s6J.Default;
				}
				finally
				{
					_ = (a0E)(object)s6J.Default;
					_ = (m1S6)(object)s6J.Default;
					_ = (Wm5)(object)s6J.Default;
					goto end_IL_003c;
				}
				end_IL_003c:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		try
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
			}
			catch
			{
				UIntPtr num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if ((nuint)num / checked(uIntPtr + uIntPtr) == 0)
				{
					ap = ap;
					ap = ap;
				}
			}
		}
		catch
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
				do
				{
					m1S = m1S;
					m1S = m1S;
				}
				while (obj != null);
			}
			finally
			{
				while ((object)s6J.Default != null)
				{
					m1S6 m1S = null;
					_ = (a0E)(object)s6J.Default;
					_ = s6J.Default;
					Wm5 obj4 = (Wm5)(object)s6J.Default;
					wm = null;
					wm = obj4;
				}
				goto end_IL_00ad;
			}
			end_IL_00ad:;
		}
		ap = (Ap93)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		m9B m9B;
		try
		{
			try
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					x2K9 x2K = (x2K9)(object)s6J.Default;
					x2K = x2K;
					Tb9 tb = null;
					tb = tb;
					c7R = null;
					c7R = c7R;
				}
				else
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Dw54)(object)s6J.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)s6J.Default;
					m9B = null;
					m9B = null;
					_ = (d9N2)(object)s6J.Default;
					g2M8 g2M9 = g2M9;
					g2M9 = g2M9;
				}
				goto end_IL_0116;
			}
			end_IL_0116:;
		}
		finally
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
			}
			goto IL_01cf;
		}
		IL_069b:
		_ = (Pg6)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		checked
		{
			try
			{
				try
				{
					if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
					{
						s6J s6J = s6J.Default;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						s6J s6J = null;
						c7B = null;
					}
					else
					{
						_ = (Rg0)(object)s6J.Default;
					}
				}
			}
			catch
			{
				pg = pg;
			}
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * uIntPtr == 0)
				{
					m2R = m2R;
				}
			}
			else if (uIntPtr == 0)
			{
				m9B = m9B;
			}
			m9B = m9B;
			while (obj != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)s6J.Default;
					_ = (Wm5)(object)s6J.Default;
					g2M8 g2M9 = null;
				}
				catch
				{
					if (uIntPtr == 0)
					{
						_ = (_003CModule_003E)(object)s6J.Default;
					}
					else
					{
						_ = (x2K9)(object)s6J.Default;
					}
				}
			}
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					try
					{
						d9N = (d9N2)(object)s6J.Default;
					}
					finally
					{
						_ = (Tb9)(object)s6J.Default;
						continue;
					}
				}
			}
			else
			{
				try
				{
					_ = (c7B)(object)s6J.Default;
				}
				catch
				{
					if (uIntPtr == 0)
					{
						c7R = (c7R)(object)s6J.Default;
					}
					else
					{
						_ = (c7R)(object)s6J.Default;
					}
				}
			}
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (d9N2)(object)s6J.Default;
			}
		}
		finally
		{
			try
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					m1S6 m1S = null;
				}
				else
				{
					_ = (Wm5)(object)s6J.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					c7R = c7R;
				}
				goto IL_0858;
			}
		}
		IL_0258:
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Qy5m)(object)s6J.Default;
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null || obj != null);
		}
		while ((object)s6J.Default != null)
		{
			_ = s6J.Default;
			_ = (Dw54)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		while (obj != null)
		{
			do
			{
				try
				{
					qy5m = null;
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
				}
			}
			while (obj != null);
		}
		_ = (m1S6)(object)s6J.Default;
		try
		{
			_ = (c7R)(object)s6J.Default;
			c7B = c7B;
			c7B = null;
			o7A = o7A;
		}
		catch
		{
			try
			{
				do
				{
					x2K9 x2K = null;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					ap = ap;
					goto end_IL_030c;
				}
				catch
				{
					o7A = (o7A)(object)s6J.Default;
					wm = null;
					goto end_IL_030c;
				}
				end_IL_030c:;
			}
		}
		while (obj != null)
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
				_ = (Tb9)(object)s6J.Default;
				g2M8 g2M9 = null;
				c7B = c7B;
			}
			catch
			{
				o7A = o7A;
			}
			finally
			{
				try
				{
					_ = (Pg6)(object)s6J.Default;
				}
				finally
				{
					Tb9 tb = null;
					continue;
				}
			}
		}
		ap = null;
		_ = (Ap93)(object)s6J.Default;
		_ = (Dw54)(object)s6J.Default;
		_ = (_003CModule_003E)(object)s6J.Default;
		ap = ap;
		d9N2 obj16 = (d9N2)(object)s6J.Default;
		d9N = d9N;
		d9N = obj16;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			a0E = null;
			a0E = a0E;
			_ = (o7A)(object)s6J.Default;
			_ = (m9B)(object)s6J.Default;
		}
		else
		{
			do
			{
				pg = pg;
				pg = pg;
			}
			while (obj != null);
		}
		_ = (Wm5)(object)s6J.Default;
		try
		{
			_ = (m1S6)(object)s6J.Default;
		}
		finally
		{
			try
			{
				_ = (Rg0)(object)s6J.Default;
				_ = (c7B)(object)s6J.Default;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					m2R obj17 = (m2R)(object)s6J.Default;
					m2R = null;
					m2R = obj17;
				}
			}
			goto IL_04b7;
		}
		IL_055f:
		try
		{
			try
			{
				_ = (c7R)(object)s6J.Default;
			}
			finally
			{
				goto end_IL_0560;
			}
			end_IL_0560:;
		}
		catch
		{
			_ = (x2K9)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		do
		{
			try
			{
				try
				{
					_ = (Qy5m)(object)s6J.Default;
				}
				finally
				{
					Dw54 obj20 = (Dw54)(object)s6J.Default;
					dw = dw;
					dw = obj20;
					goto end_IL_0580;
				}
				end_IL_0580:;
			}
			finally
			{
				try
				{
					dw = dw;
				}
				finally
				{
					_ = (m2R)(object)s6J.Default;
					continue;
				}
			}
		}
		while ((object)s6J.Default != null);
		do
		{
			_ = (Ap93)(object)s6J.Default;
		}
		while (obj != null);
		try
		{
			while (true)
			{
				if ((object)s6J.Default != null)
				{
					c7B = (c7B)(object)s6J.Default;
				}
				else if ((object)s6J.Default == null)
				{
					break;
				}
			}
		}
		catch
		{
			do
			{
				wm = null;
			}
			while ((object)s6J.Default != null);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				a0E = a0E;
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (Ap93)(object)s6J.Default;
				}
				finally
				{
					_ = (Dw54)(object)s6J.Default;
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			_ = (m1S6)(object)s6J.Default;
		}
		finally
		{
			do
			{
				m9B = m9B;
			}
			while ((object)s6J.Default != null || obj != null);
			goto IL_069b;
		}
		IL_01cf:
		try
		{
			_ = (m9B)(object)s6J.Default;
		}
		catch
		{
			m1S6 m1S = null;
		}
		finally
		{
			x2K9 x2K = (x2K9)(object)s6J.Default;
			goto IL_01f8;
		}
		IL_01f8:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Tb9 tb = (Tb9)(object)s6J.Default;
			Rg0 rg = rg;
			rg = rg;
			goto IL_0258;
		}
		try
		{
			do
			{
				c7R = (c7R)(object)s6J.Default;
			}
			while (obj != null);
		}
		finally
		{
			qy5m = (Qy5m)(object)s6J.Default;
			qy5m = qy5m;
			goto IL_0258;
		}
		IL_0858:
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)s6J.Default) * (uIntPtr * unchecked((nuint)(UIntPtr)s6J.Default) - uIntPtr) == 0)
				{
					try
					{
						qy5m = qy5m;
						return;
					}
					catch
					{
						o7A = (o7A)(object)s6J.Default;
						return;
					}
				}
				while (obj != null)
				{
					_ = (x2K9)(object)s6J.Default;
				}
				return;
			}
			catch
			{
				c7R = c7R;
				a0E = (a0E)(object)s6J.Default;
				_ = (o7A)(object)s6J.Default;
				return;
			}
		}
		IL_04b7:
		while (obj != null)
		{
			try
			{
				do
				{
					_ = (Wm5)(object)s6J.Default;
					_ = (g2M8)(object)s6J.Default;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					d9N = d9N;
					_ = (g2M8)(object)s6J.Default;
					_ = (Dw54)(object)s6J.Default;
				}
				catch
				{
					m9B = (m9B)(object)s6J.Default;
				}
				continue;
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
		}
		do
		{
			try
			{
				while (obj != null)
				{
					g2M8 g2M9 = (g2M8)(object)s6J.Default;
				}
			}
			finally
			{
				m9B = null;
				m1S6 m1S = null;
				continue;
			}
		}
		while ((object)s6J.Default != null);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
			while ((object)s6J.Default != null)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					wm = wm;
					continue;
				}
				s6J = s6J;
				s6J = null;
			}
		}
		finally
		{
			try
			{
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Pg6)(object)s6J.Default;
				}
			}
			goto IL_055f;
		}
	}
}
