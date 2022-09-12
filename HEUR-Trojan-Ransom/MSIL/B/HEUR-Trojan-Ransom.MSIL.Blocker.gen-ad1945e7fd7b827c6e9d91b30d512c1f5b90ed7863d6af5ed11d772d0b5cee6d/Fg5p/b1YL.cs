using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cd2;
using Dn57;
using Jr8;
using Microsoft.VisualBasic.CompilerServices;
using Ps92;
using Wy4;
using Xr2;
using b1C5;
using j8P3;
using k6J;
using n0WD;
using n4M;
using n7K;
using o1N;
using o9R;
using p6S;
using y1M;
using y8D;

namespace Fg5p;

[DesignerGenerated]
public class b1YL : Form
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
			EventHandler eventHandler = Ge7k;
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

	public b1YL()
	{
		Cp9x();
	}

	[DebuggerNonUserCode]
	protected override void Fg52(bool Jr0i)
	{
		try
		{
			if (Jr0i && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jr0i);
		}
	}

	[DebuggerStepThrough]
	private void Cp9x()
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

	private void Ge7k(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0))
		{
			MessageBox.Show("Login Successfully...!");
			Jy1 jy = new Jy1();
			((Control)jy).Show();
			((Control)this).Hide();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password...!");
		}
	}

	static void z4DW()
	{
		b1YL b1YL2 = b1YL2;
		b1YL2 = null;
		Em1 em = null;
		em = null;
		_ = a7W.Default;
		UIntPtr uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		if (uIntPtr == 0)
		{
			do
			{
				_ = (Ln53)(object)a7W.Default;
				obj = a7W.Default;
			}
			while (obj != null);
		}
		else
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Em1)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
					_ = (En1)(object)a7W.Default;
				}
				else
				{
					em = (Em1)(object)a7W.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					a1B = (a1B)(object)a7W.Default;
					a1B = a1B;
				}
				else
				{
					zo = (Zo8)(object)a7W.Default;
					zo = zo;
					_ = a7W.Default;
					_ = (Sm6)(object)a7W.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		Ln53 ln;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		try
		{
			_ = (_003CModule_003E)(object)a7W.Default;
			_ = (b1YL)(object)a7W.Default;
			Ln53 obj3 = (Ln53)(object)a7W.Default;
			ln = (Ln53)(object)a7W.Default;
			ln = obj3;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					s9EJ = s9EJ;
					s9EJ = s9EJ;
				}
				catch
				{
					_ = (Sm6)(object)a7W.Default;
					Jy1 obj4 = (Jy1)(object)a7W.Default;
					Jy1 jy = jy;
					jy = obj4;
				}
			}
			else
			{
				try
				{
					_ = (Zo8)(object)a7W.Default;
					nn9a = nn9a;
					nn9a = nn9a;
					_ = (Ta6)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
				}
				catch
				{
					b6E = null;
					b6E = b6E;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			do
			{
				try
				{
					a7W = a7W;
					a7W = a7W;
				}
				finally
				{
					_ = (_003CModule_003E)(object)a7W.Default;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			_ = (a1B)(object)a7W.Default;
			sm = sm;
			sm = sm;
			goto IL_01e7;
		}
		IL_03b9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		try
		{
			do
			{
				if ((UIntPtr)a7W.Default != (UIntPtr)(nuint)0u)
				{
					s9EJ = (s9EJ)(object)a7W.Default;
					y8R obj8 = (y8R)(object)a7W.Default;
					y8R = y8R;
					y8R = obj8;
				}
				else
				{
					i0A = i0A;
				}
			}
			while (obj != null);
		}
		catch
		{
			if (checked(uIntPtr - uIntPtr + uIntPtr) == 0)
			{
				try
				{
					a7W = a7W;
					_ = (j3J)(object)a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
					_ = (Ln53)(object)a7W.Default;
				}
				finally
				{
					_ = (s9EJ)(object)a7W.Default;
					goto end_IL_0403;
				}
			}
			end_IL_0403:;
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (j3J)(object)a7W.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Ln53)(object)a7W.Default;
					_ = (i0A1)(object)a7W.Default;
					_ = a7W.Default;
				}
				while ((object)a7W.Default != null);
				goto IL_04b0;
			}
		}
		if (checked(uIntPtr - uIntPtr) == 0)
		{
			s9EJ = s9EJ;
		}
		goto IL_04b0;
		IL_074c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		checked
		{
			try
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Qg6)(object)a7W.Default;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr + uIntPtr == 0)
					{
						b1YL2 = b1YL2;
					}
				}
			}
			catch
			{
				try
				{
					if (uIntPtr == 0)
					{
						y8R = y8R;
					}
					else
					{
						_ = (j3J)(object)a7W.Default;
					}
				}
				finally
				{
					while (obj != null)
					{
						_ = (Nn9a)(object)a7W.Default;
					}
					goto end_IL_078d;
				}
				end_IL_078d:;
			}
			if (uIntPtr + uIntPtr == 0)
			{
				try
				{
					do
					{
						_ = (Nn9a)(object)a7W.Default;
						j3J = (j3J)(object)a7W.Default;
						s9EJ = s9EJ;
						ta = null;
					}
					while ((object)a7W.Default != null);
				}
				catch
				{
					while (obj != null)
					{
						_ = (Ta6)(object)a7W.Default;
					}
				}
			}
			else if (uIntPtr == 0)
			{
				_ = (b1YL)(object)a7W.Default;
			}
			_ = (s9EJ)(object)a7W.Default;
			do
			{
				try
				{
					_ = (Qg6)(object)a7W.Default;
				}
				finally
				{
					if (uIntPtr == 0)
					{
						a7W = a7W.Default;
					}
					else
					{
						_ = (En1)(object)a7W.Default;
					}
					continue;
				}
			}
			while (obj != null);
			while ((object)a7W.Default != null)
			{
				while ((object)a7W.Default != null)
				{
					do
					{
						_ = (b1YL)(object)a7W.Default;
						_ = (En1)(object)a7W.Default;
						_ = (b6E)(object)a7W.Default;
						a1B = (a1B)(object)a7W.Default;
					}
					while (obj != null);
				}
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				sm = sm;
				_ = (Zo8)(object)a7W.Default;
				a7W = null;
			}
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				j3J = j3J;
			}
		}
		finally
		{
			b6E = null;
			goto IL_08fc;
		}
		IL_0273:
		_ = (Qg6)(object)a7W.Default;
		em = em;
		_ = (b1YL)(object)a7W.Default;
		_ = (Ta6)(object)a7W.Default;
		_ = (Em1)(object)a7W.Default;
		_ = (En1)(object)a7W.Default;
		checked
		{
			while (obj != null)
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) - uIntPtr == 0)
				{
					try
					{
						i0A = i0A;
						i0A = i0A;
					}
					finally
					{
						_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)a7W.Default;
						_003CModule_003E = _003CModule_003E;
						nn9a = nn9a;
						a1B = a1B;
						_ = (Nn9a)(object)a7W.Default;
						continue;
					}
				}
			}
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					j3J = (j3J)(object)a7W.Default;
					j3J = null;
				}
				finally
				{
					_ = (Jy1)(object)a7W.Default;
					b6E = b6E;
					nn9a = nn9a;
					_ = (Ta6)(object)a7W.Default;
					goto IL_03b9;
				}
			}
			try
			{
				a7W = null;
			}
			finally
			{
				_ = (Ln53)(object)a7W.Default;
				goto IL_03b9;
			}
		}
		try
		{
			while ((object)a7W.Default != null)
			{
				_ = (y8R)(object)a7W.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
			}
			catch
			{
				_ = a7W.Default;
			}
		}
		goto IL_03b9;
		IL_0698:
		try
		{
			_ = (Qg6)(object)a7W.Default;
			ln = ln;
			_ = (Zo8)(object)a7W.Default;
		}
		finally
		{
			try
			{
				while ((object)a7W.Default != null)
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
			catch
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					b6E = (b6E)(object)a7W.Default;
				}
			}
			goto IL_06f5;
		}
		IL_01e7:
		if (uIntPtr == 0)
		{
			do
			{
				b6E = b6E;
			}
			while ((object)a7W.Default != null);
		}
		do
		{
			try
			{
			}
			finally
			{
				continue;
			}
		}
		while ((object)a7W.Default != null);
		zo = zo;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
			{
				b6E = b6E;
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (s9EJ)(object)a7W.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
			}
			else
			{
				En1 obj18 = (En1)(object)a7W.Default;
				en = en;
				en = obj18;
			}
			goto IL_0273;
		}
		IL_04b0:
		do
		{
			ln = null;
			em = em;
			_ = (y8R)(object)a7W.Default;
			em = (Em1)(object)a7W.Default;
		}
		while ((object)a7W.Default != null);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					en = en;
				}
				else
				{
					_ = (En1)(object)a7W.Default;
				}
			}
			else
			{
				do
				{
					ta = ta;
					ta = null;
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (b1YL)(object)a7W.Default;
			}
		}
		finally
		{
			_ = (a1B)(object)a7W.Default;
			goto IL_054e;
		}
		IL_08fc:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
		}
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					a1B = (a1B)(object)a7W.Default;
				}
				else
				{
					ln = null;
				}
			}
		}
		while ((object)a7W.Default != null);
		b1YL2 = (b1YL)(object)a7W.Default;
		return;
		IL_06f5:
		a1B = a1B;
		sm = sm;
		try
		{
			if (uIntPtr == 0)
			{
				b6E = null;
			}
			else
			{
				while ((object)a7W.Default != null)
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				while ((object)a7W.Default != null)
				{
					_ = (Jy1)(object)a7W.Default;
				}
			}
			goto IL_074c;
		}
		IL_054e:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			y8R = null;
			_ = (En1)(object)a7W.Default;
			ln = ln;
			a1B = a1B;
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				do
				{
					b6E = b6E;
				}
				while (obj != null);
			}
		}
		else
		{
			_ = (Qg6)(object)a7W.Default;
			sm = null;
			_ = (b1YL)(object)a7W.Default;
			b1YL2 = b1YL2;
		}
		ta = ta;
		if (uIntPtr / uIntPtr == 0)
		{
			_ = (a1B)(object)a7W.Default;
		}
		else
		{
			do
			{
				if (uIntPtr != 0)
				{
					em = (Em1)(object)a7W.Default;
				}
				else
				{
					b1YL2 = (b1YL)(object)a7W.Default;
				}
			}
			while (obj != null);
		}
		while (obj != null)
		{
			do
			{
				_ = (Zo8)(object)a7W.Default;
			}
			while (obj != null);
		}
		try
		{
			if ((UIntPtr)a7W.Default != (UIntPtr)(nuint)0u)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
				try
				{
					j3J = null;
					_ = (Jy1)(object)a7W.Default;
					Qg6 obj19 = (Qg6)(object)a7W.Default;
					qg = qg;
					qg = obj19;
				}
				finally
				{
					qg = qg;
					goto end_IL_0627;
				}
			}
			_ = a7W.Default;
			a7W = a7W;
			_ = (y8R)(object)a7W.Default;
			end_IL_0627:;
		}
		finally
		{
			a1B = (a1B)(object)a7W.Default;
			goto IL_0698;
		}
	}
}
