using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Di68;
using Gn3;
using Hx0;
using Jz9;
using Kd1q;
using Kr2c;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using a2A;
using b9YC;
using e2D3;
using i4B6;
using j3S2;
using n2X;
using o5FP;
using q0GA;
using q4G1;
using w1R;
using x0S1;
using x9B;

namespace Bz7;

[DesignerGenerated]
public class q1M : Form
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
			EventHandler eventHandler = x5B;
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

	public q1M()
	{
		t5F();
	}

	[DebuggerNonUserCode]
	protected override void b9B(bool Lg8)
	{
		try
		{
			if (Lg8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lg8);
		}
		n0J5.char_0[211] = (char)(n0J5.char_0[211] & n0J5.char_0[255] & 'C');
	}

	[DebuggerStepThrough]
	private void t5F()
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

	private void x5B(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		bool num = Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0;
		bool num2 = Operators.CompareString(txtPassword.get_Text(), "123", false) == 0;
		Qp49.char_0[174] = (char)(Qp49.char_0[174] & Qp49.char_0[171] & 'é');
		if (num && num2)
		{
			MessageBox.Show("Login Successfully...!");
			g2J4 g2J = new g2J4();
			((Control)g2J).Show();
			((Control)this).Hide();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password...!");
		}
	}

	static void c5M()
	{
		b7KC b7KC = (b7KC)(object)e7WK.Default;
		b7KC = b7KC;
		z0R3 z0R = null;
		z0R = z0R;
		UIntPtr uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			_ = (q1M)(object)e7WK.Default;
			_ = (q1M)(object)e7WK.Default;
			Qt2 obj = (Qt2)(object)e7WK.Default;
			qt = qt;
			qt = obj;
			Yo50 yo = yo;
			yo = yo;
			g2J = (g2J4)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		try
		{
			cx = null;
			cx = cx;
		}
		finally
		{
			try
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			finally
			{
				try
				{
					_ = (g2J4)(object)e7WK.Default;
				}
				catch
				{
					y2HN = (y2HN)(object)e7WK.Default;
				}
				goto IL_00c6;
			}
		}
		IL_0387:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		do
		{
			Qe07 qe = null;
		}
		while (obj3 != null);
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (b6G)e7WK.Default;
				}
				else
				{
					y2HN = (y2HN)(object)e7WK.Default;
				}
			}
			finally
			{
				_ = (Cx7)(object)e7WK.Default;
				goto end_IL_0392;
			}
			end_IL_0392:;
		}
		catch
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
		}
		UIntPtr num = (UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num) + uIntPtr == 0)
			{
				_ = (Dx5s)(object)e7WK.Default;
			}
			else if (uIntPtr == 0)
			{
				while ((object)e7WK.Default != null)
				{
					y2HN = null;
				}
			}
			_ = (z8Y)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (uIntPtr != 0)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			else
			{
				try
				{
					z8Y = z8Y;
				}
				catch
				{
					_003CModule_003E obj5 = (_003CModule_003E)(object)e7WK.Default;
					_003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
					_003CModule_003E = obj5;
				}
			}
		}
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
				catch
				{
					c8CP c8CP = (c8CP)(object)e7WK.Default;
				}
			}
			catch
			{
				while ((object)e7WK.Default != null)
				{
					_ = (So3)(object)e7WK.Default;
				}
			}
		}
		n0J5 n0J = (n0J5)(object)e7WK.Default;
		_ = (c8CP)(object)e7WK.Default;
		_ = (Qe07)(object)e7WK.Default;
		e7WK e7WK = null;
		e7WK = null;
		while (obj3 != null)
		{
			if (uIntPtr == 0)
			{
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				g2J = g2J;
				_ = (o2T)(object)e7WK.Default;
			}
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					Qp49 qp = qp;
					qp = qp;
				}
			}
			finally
			{
				try
				{
					_ = (n0J5)(object)e7WK.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
				goto end_IL_0525;
			}
			end_IL_0525:;
		}
		while (obj3 != null)
		{
			_ = (Cx7)(object)e7WK.Default;
			_ = (Qp49)(object)e7WK.Default;
			n0J = null;
			_003CModule_003E = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		if (uIntPtr == 0)
		{
			Pw9k pw9k = pw9k;
			_003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
			b6G = default(b6G);
			_ = (o2T)(object)e7WK.Default;
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				cx = (Cx7)(object)e7WK.Default;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				y2HN = y2HN;
				_ = (Qp49)(object)e7WK.Default;
				e7WK = e7WK;
				z0R = z0R;
			}
		}
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				_ = (q1M)(object)e7WK.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
		}
		while ((object)e7WK.Default != null || obj3 != null);
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					e7WK = e7WK;
				}
			}
			finally
			{
				try
				{
					n0J = n0J;
				}
				catch
				{
					_ = (Dx5s)(object)e7WK.Default;
					n0J = n0J;
				}
				goto end_IL_0649;
			}
			end_IL_0649:;
		}
		catch
		{
			o2T o2T = (o2T)(object)e7WK.Default;
		}
		g2J = g2J;
		_ = (Qp49)(object)e7WK.Default;
		while (obj3 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (g2J4)(object)e7WK.Default;
					_ = (Qp49)(object)e7WK.Default;
				}
				finally
				{
					qt = null;
					continue;
				}
			}
		}
		while ((object)e7WK.Default != null)
		{
			_ = (Dx5s)(object)e7WK.Default;
		}
		b6G = b6G;
		return;
		IL_0243:
		checked
		{
			try
			{
				try
				{
					do
					{
						_ = (b7KC)(object)e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					nuint num2 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 * uIntPtr == 0)
					{
						z8Y obj13 = (z8Y)(object)e7WK.Default;
						z8Y = null;
						z8Y = obj13;
					}
					else
					{
						_ = (Qe07)(object)e7WK.Default;
					}
				}
			}
			catch
			{
				_ = (o2T)(object)e7WK.Default;
			}
			while (obj3 != null)
			{
				try
				{
					if (uIntPtr - uIntPtr == 0)
					{
						_ = (c8CP)(object)e7WK.Default;
					}
					else
					{
						Fz0 fz = (Fz0)e7WK.Default;
						fz = fz;
					}
				}
				finally
				{
					try
					{
						_ = (o2T)(object)e7WK.Default;
						_ = (So3)(object)e7WK.Default;
						_ = (Pw9k)(object)e7WK.Default;
						y2HN = y2HN;
					}
					catch
					{
						Qe07 qe = (Qe07)(object)e7WK.Default;
						qe = qe;
					}
					continue;
				}
			}
			while (obj3 != null)
			{
				_ = (b7KC)(object)e7WK.Default;
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
				else
				{
					_ = (Fz0)e7WK.Default;
				}
			}
			finally
			{
				while (obj3 != null)
				{
					_ = (o2T)(object)e7WK.Default;
				}
				goto IL_0387;
			}
		}
		goto IL_0387;
		IL_00c6:
		try
		{
			_ = (o2T)(object)e7WK.Default;
			c8CP c8CP = (c8CP)(object)e7WK.Default;
			c8CP = c8CP;
			_ = (g2J4)(object)e7WK.Default;
		}
		catch
		{
			qt = qt;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (c8CP)(object)e7WK.Default;
			}
			goto IL_0120;
		}
		IL_0120:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (checked(unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					cx = null;
				}
				else
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
		}
		else
		{
			_ = (Qe07)(object)e7WK.Default;
			_ = (y2HN)(object)e7WK.Default;
			_ = (z0R3)(object)e7WK.Default;
			_ = (q1M)(object)e7WK.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Yo50 yo = (Yo50)(object)e7WK.Default;
		}
		_ = (So3)(object)e7WK.Default;
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					cx = (Cx7)(object)e7WK.Default;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					o2T o2T = null;
					o2T = o2T;
				}
				else
				{
					_ = (b6G)e7WK.Default;
					n0J = null;
					n0J = n0J;
				}
				goto end_IL_01ba;
			}
			end_IL_01ba:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					c8CP c8CP = (c8CP)(object)e7WK.Default;
				}
				finally
				{
					_ = (Yo50)(object)e7WK.Default;
					goto IL_0243;
				}
			}
			cx = cx;
			goto IL_0243;
		}
	}
}
