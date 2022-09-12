using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bx3;
using Dn7;
using Dy1a;
using Gb1;
using Hc8;
using Hf9e;
using Hj8;
using Lj1k;
using Microsoft.VisualBasic.CompilerServices;
using Qw80;
using Ss0;
using Tb3;
using c5E;
using c6R;
using g5S;
using i3L;
using o8Z;
using p0H;
using q8X;
using z2Z;

namespace q3F;

[DesignerGenerated]
public class Co4 : Form
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
			EventHandler eventHandler = Rc1;
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

	public Co4()
	{
		p8F();
	}

	[DebuggerNonUserCode]
	protected override void k3T(bool d8F)
	{
		try
		{
			if (d8F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d8F);
		}
	}

	[DebuggerStepThrough]
	private void p8F()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		byte[] byte_ = Pj8.byte_0;
		char[] char_ = Mb5.char_0;
		int num = 30;
		while (true)
		{
			Button1 = new Button();
			Button2 = new Button();
			txtUsername = new TextBox();
			num = 43;
			while (true)
			{
				txtPassword = new TextBox();
				Label1 = new Label();
				Label2 = new Label();
				num = 17;
				while (true)
				{
					Label3 = new Label();
					((Control)this).SuspendLayout();
					((ButtonBase)Button1).set_BackColor(Color.FromArgb(128, 128, 255));
					num = 8;
					while (true)
					{
						((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
						((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 14;
						while (true)
						{
							((Control)Button1).set_ForeColor(Color.White);
							((Control)Button1).set_Location(new Point(48, 137));
							num = 0;
							while (true)
							{
								((Control)Button1).set_Name("Button1");
								((Control)Button1).set_Size(new Size(84, 29));
								num = byte_[174] - 87;
								while (true)
								{
									switch (num)
									{
									case 40:
										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
										((Form)this).set_ClientSize(new Size(283, 189));
										num = 23;
										goto case 23;
									case 23:
										((Control)this).get_Controls().Add((Control)(object)Label3);
										((Control)this).get_Controls().Add((Control)(object)Label2);
										num = 5;
										goto case 5;
									case 5:
										((Control)this).get_Controls().Add((Control)(object)Label1);
										((Control)this).get_Controls().Add((Control)(object)txtPassword);
										num = char_[107] - 62202;
										continue;
									case 29:
									case 39:
										((Control)txtUsername).set_TabIndex(2);
										txtUsername.set_TextAlign((HorizontalAlignment)2);
										num = 15;
										goto case 15;
									case 15:
										((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 24;
										goto case 24;
									case 24:
										((TextBoxBase)txtPassword).set_ForeColor(Color.Purple);
										((Control)txtPassword).set_Location(new Point(139, 96));
										num = 6;
										goto case 6;
									case 6:
										((Control)txtPassword).set_Name("txtPassword");
										txtPassword.set_PasswordChar('#');
										num = 19;
										goto case 19;
									case 19:
										((Control)txtPassword).set_Size(new Size(104, 23));
										((Control)txtPassword).set_TabIndex(3);
										num = 10;
										goto case 10;
									case 10:
										txtPassword.set_TextAlign((HorizontalAlignment)2);
										Label1.set_AutoSize(true);
										num = 3;
										goto case 3;
									case 3:
										((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 31;
										goto case 31;
									case 31:
										((Control)Label1).set_ForeColor(Color.White);
										((Control)Label1).set_Location(new Point(46, 56));
										num = 25;
										goto case 25;
									case 25:
										((Control)Label1).set_Name("Label1");
										((Control)Label1).set_Size(new Size(91, 17));
										num = 2;
										goto case 2;
									case 2:
										((Control)Label1).set_TabIndex(4);
										Label1.set_Text("Username :");
										num = 1;
										goto case 1;
									case 1:
										Label2.set_AutoSize(true);
										((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 11;
										goto case 11;
									case 11:
										((Control)Label2).set_ForeColor(Color.White);
										((Control)Label2).set_Location(new Point(46, 102));
										num = 33;
										goto case 33;
									case 33:
										((Control)Label2).set_Name("Label2");
										((Control)Label2).set_Size(new Size(87, 17));
										num = 20;
										goto case 20;
									case 20:
										((Control)Label2).set_TabIndex(5);
										Label2.set_Text("Password :");
										num = 12;
										goto case 12;
									case 12:
										Label3.set_AutoSize(true);
										goto case 35;
									case 35:
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 38;
										goto case 38;
									case 38:
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(108, 22));
										num = 34;
										goto case 34;
									case 34:
										((Control)Label3).set_Name("Label3");
										((Control)Label3).set_Size(new Size(48, 17));
										num = 9;
										goto case 9;
									case 9:
										((Control)Label3).set_TabIndex(6);
										Label3.set_Text("Login");
										num = 37;
										goto case 37;
									case 37:
										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
										num = 40;
										goto case 40;
									case 36:
										((Control)txtUsername).set_Name("txtUsername");
										((Control)txtUsername).set_Size(new Size(104, 23));
										num = 39;
										goto case 29;
									case 32:
										((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
										((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 22;
										goto case 22;
									case 22:
										((Control)Button2).set_ForeColor(Color.White);
										((Control)Button2).set_Location(new Point(149, 137));
										num = 13;
										goto case 13;
									case 13:
										((Control)Button2).set_Name("Button2");
										((Control)Button2).set_Size(new Size(84, 29));
										goto case 26;
									case 26:
										num = 27;
										goto case 27;
									case 27:
										((Control)Button2).set_TabIndex(1);
										((ButtonBase)Button2).set_Text("Cancel");
										num = 28;
										goto case 28;
									case 28:
										((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
										((Control)txtUsername).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 7;
										goto case 7;
									case 7:
										((TextBoxBase)txtUsername).set_ForeColor(Color.Purple);
										((Control)txtUsername).set_Location(new Point(139, 57));
										num = 36;
										goto case 36;
									case 18:
										((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
										((ButtonBase)Button2).set_BackColor(Color.FromArgb(128, 128, 255));
										num = 32;
										goto case 32;
									case 4:
										((Control)Button1).set_TabIndex(0);
										((ButtonBase)Button1).set_Text("Login");
										num = 18;
										goto case 18;
									case 0:
										break;
									case 14:
										goto end_IL_0567;
									case 8:
										goto end_IL_059b;
									case 17:
										goto end_IL_05c6;
									case 43:
										goto end_IL_05f4;
									default:
										goto end_IL_0628;
									case 16:
										((Control)this).get_Controls().Add((Control)(object)txtUsername);
										((Control)this).get_Controls().Add((Control)(object)Button2);
										num = 42;
										goto case 42;
									case 42:
										((Control)this).get_Controls().Add((Control)(object)Button1);
										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
										num = 21;
										goto case 21;
									case 21:
										((Control)this).set_Name("Login");
										((Form)this).set_StartPosition((FormStartPosition)1);
										((Form)this).set_Text("Login");
										num = 41;
										goto case 41;
									case 41:
										((Control)this).ResumeLayout(false);
										((Control)this).PerformLayout();
										return;
									}
									break;
								}
								continue;
								end_IL_0567:
								break;
							}
							continue;
							end_IL_059b:
							break;
						}
						continue;
						end_IL_05c6:
						break;
					}
					continue;
					end_IL_05f4:
					break;
				}
				continue;
				end_IL_0628:
				break;
			}
		}
	}

	private void Rc1(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0))
		{
			MessageBox.Show("Login Successfully...!");
			Np8 np = new Np8();
			((Control)np).Show();
			((Control)this).Hide();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password...!");
		}
	}

	static void c1W()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		try
		{
			UIntPtr num = (UIntPtr)Nf2.Default;
			num2 = default(UIntPtr);
			num2 = (nuint)num / num2;
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					f0F obj = (f0F)(object)Nf2.Default;
					f0F f0F = (f0F)(object)Nf2.Default;
					f0F = obj;
					_ = (f0F)(object)Nf2.Default;
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (x8D9)(object)Nf2.Default;
					goto end_IL_0000;
				}
			}
			try
			{
				_ = (Co4)(object)Nf2.Default;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
				_ = (Pm9)(object)Nf2.Default;
				_ = (x8D9)(object)Nf2.Default;
			}
			finally
			{
				f0F f0F = f0F;
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			try
			{
				_ = Nf2.Default;
			}
			catch
			{
			}
			goto IL_00ca;
		}
		IL_00ca:
		Co4 co = (Co4)(object)Nf2.Default;
		co = null;
		try
		{
			if (num2 == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Gj4)Nf2.Default;
				}
			}
			else if (checked(unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
			{
				_ = (w4R)(object)Nf2.Default;
			}
		}
		finally
		{
			goto IL_0157;
		}
		IL_0157:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		while (obj3 != null)
		{
			do
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (m0N)(object)Nf2.Default;
				}
				obj3 = Nf2.Default;
			}
			while (obj3 != null);
		}
		_ = (x8D9)(object)Nf2.Default;
		k6D9 k6D = (k6D9)(object)Nf2.Default;
		k6D = k6D;
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Pj8)(object)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				nf = Nf2.Default;
				nf = nf;
			}
			while ((object)Nf2.Default != null);
		}
		UIntPtr num3 = (UIntPtr)Nf2.Default;
		num2 = default(UIntPtr);
		checked
		{
			nuint num4 = (unchecked((nuint)num3) + num2 - num2 - unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr));
			num2 = default(UIntPtr);
			if (num4 * unchecked(num2 / (nuint)(UIntPtr)Nf2.Default) == 0)
			{
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
					do
					{
						Mb5 obj4 = (Mb5)(object)Nf2.Default;
						mb = mb;
						mb = obj4;
					}
					while ((object)Nf2.Default != null);
				}
				catch
				{
					_ = (m0N)(object)Nf2.Default;
				}
			}
			else
			{
				try
				{
				}
				catch
				{
					if (num2 == 0)
					{
						Eb1 eb = eb;
						eb = eb;
					}
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
			do
			{
				if (num2 != 0)
				{
					if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Eb1)(object)Nf2.Default;
						continue;
					}
					d1X = d1X;
					d1X = d1X;
				}
				else
				{
					_ = (f2L)(object)Nf2.Default;
				}
			}
			while (obj3 != null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
			do
			{
				try
				{
					num2 = default(UIntPtr);
					nuint num5 = num2;
					num2 = default(UIntPtr);
					if (num5 - num2 == 0)
					{
						_ = (Pj8)(object)Nf2.Default;
					}
				}
				finally
				{
					if (num2 == 0)
					{
						pm = pm;
						pm = null;
					}
					continue;
				}
			}
			while (obj3 != null);
			if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
			{
				_ = (f9T6)(object)Nf2.Default;
			}
			else
			{
				while (obj3 != null)
				{
					if (unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)(UIntPtr)Nf2.Default) + num2 == 0)
					{
						_ = (r8M)Nf2.Default;
						x8D9 x8D = (x8D9)(object)Nf2.Default;
						x8D = x8D;
						_ = (Eb1)(object)Nf2.Default;
						_ = (Pm9)(object)Nf2.Default;
					}
					else
					{
						_ = (Mb5)(object)Nf2.Default;
					}
				}
			}
			_ = Nf2.Default;
			_ = (m0N)(object)Nf2.Default;
			_ = (_003CModule_003E)(object)Nf2.Default;
			do
			{
				_ = (d4E)(object)Nf2.Default;
			}
			while (obj3 != null);
			num2 = default(UIntPtr);
			if (num2 + num2 == 0)
			{
				while (obj3 != null)
				{
					_ = (Eb1)(object)Nf2.Default;
				}
			}
			else
			{
				_ = (d4E)(object)Nf2.Default;
			}
			if (num2 == 0)
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
				_ = (f9T6)(object)Nf2.Default;
				_ = (d1X)(object)Nf2.Default;
			}
			try
			{
				_ = (Pm9)(object)Nf2.Default;
			}
			finally
			{
				_ = (r8M)Nf2.Default;
				goto IL_0420;
			}
		}
		IL_078e:
		do
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (w4R)(object)Nf2.Default;
				}
			}
			catch
			{
				_ = (Mb5)(object)Nf2.Default;
			}
		}
		while ((object)Nf2.Default != null);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				while ((object)Nf2.Default != null)
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
		}
		else
		{
			try
			{
				try
				{
					nf = nf;
				}
				finally
				{
					_ = Nf2.Default;
					goto end_IL_07fa;
				}
				end_IL_07fa:;
			}
			catch
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (x8D9)(object)Nf2.Default;
				}
			}
		}
		_ = (Pm9)(object)Nf2.Default;
		while (obj3 != null)
		{
			f0F f0F = (f0F)(object)Nf2.Default;
			_ = (Pm9)(object)Nf2.Default;
			co = co;
			_ = (m0N)(object)Nf2.Default;
		}
		try
		{
			do
			{
				_ = (Np8)(object)Nf2.Default;
			}
			while (obj3 != null);
		}
		finally
		{
			_ = (Eb1)(object)Nf2.Default;
			goto IL_088f;
		}
		IL_0454:
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				m0N = null;
				m0N = null;
			}
			finally
			{
				o5CZ obj9 = (o5CZ)(object)Nf2.Default;
				o5CZ = o5CZ;
				o5CZ = obj9;
				goto IL_04b9;
			}
		}
		Np8 np = np;
		np = np;
		goto IL_04b9;
		IL_088f:
		while (obj3 != null)
		{
		}
		if (num2 != (UIntPtr)(nuint)0u)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		do
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				d8B = d8B;
				d8B = null;
			}
		}
		while (obj3 != null);
		return;
		IL_065b:
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Nf2.Default != null)
			{
				while (obj3 != null)
				{
					_ = (r8M)Nf2.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gj = gj;
			}
			else
			{
				do
				{
					_ = (Mb5)(object)Nf2.Default;
					_ = (f9T6)(object)Nf2.Default;
				}
				while (obj3 != null);
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (r8M)Nf2.Default;
				}
			}
			else
			{
				r8M r8M = r8M;
				r8M = r8M;
			}
			goto IL_06f6;
		}
		IL_06f6:
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				catch
				{
					_ = (Pm9)(object)Nf2.Default;
					f0F f0F = null;
					_ = (Co4)(object)Nf2.Default;
				}
			}
			catch
			{
				_ = (f9T6)(object)Nf2.Default;
			}
		}
		try
		{
			do
			{
				_ = (d8B)(object)Nf2.Default;
			}
			while ((object)Nf2.Default != null);
		}
		catch
		{
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					_ = (m0N)(object)Nf2.Default;
				}
			}
			finally
			{
				while ((object)Nf2.Default != null)
				{
					_ = (d1X)(object)Nf2.Default;
				}
				goto IL_078e;
			}
		}
		IL_0503:
		nuint num6 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Nf2.Default;
		num2 = default(UIntPtr);
		if (checked(num6 + num2) == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Np8)(object)Nf2.Default;
			}
			else
			{
				o5CZ = o5CZ;
			}
		}
		if (checked(num2 - num2) == 0)
		{
			try
			{
				try
				{
					Eb1 eb = (Eb1)(object)Nf2.Default;
					w4R w4R = (w4R)(object)Nf2.Default;
					w4R = w4R;
					co = (Co4)(object)Nf2.Default;
					_ = (k6D9)(object)Nf2.Default;
				}
				finally
				{
					Pm9 pm = (Pm9)(object)Nf2.Default;
					goto end_IL_0565;
				}
				end_IL_0565:;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					m0N = m0N;
				}
				goto IL_065b;
			}
		}
		UIntPtr num7 = (UIntPtr)Nf2.Default;
		num2 = default(UIntPtr);
		checked
		{
			if ((unchecked((nuint)num7) + num2) * num2 == 0)
			{
				unchecked
				{
					if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Nf2.Default)) / unchecked((nuint)default(UIntPtr)) == 0)
					{
						np = null;
					}
					else
					{
						_ = (Np8)(object)Nf2.Default;
					}
				}
			}
			else if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				_ = (f2L)(object)Nf2.Default;
			}
			goto IL_065b;
		}
		IL_04b9:
		while (true)
		{
			if (obj3 != null)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
			else if ((object)Nf2.Default == null)
			{
				break;
			}
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					nf = null;
				}
				else
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
			}
		}
		finally
		{
			_ = (Pm9)(object)Nf2.Default;
			_ = (f2L)(object)Nf2.Default;
			goto IL_0503;
		}
		IL_0420:
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					gj = gj;
					gj = gj;
				}
			}
		}
		finally
		{
			_ = (m0N)(object)Nf2.Default;
			goto IL_0454;
		}
	}

	static void c5H()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		f9T6 f9T;
		checked
		{
			try
			{
				num = default(UIntPtr);
				nuint num2 = num;
				num = default(UIntPtr);
				nuint num3 = num2 - num * unchecked((nuint)(UIntPtr)Nf2.Default);
				num = default(UIntPtr);
				nuint num4 = num3 * num;
				num = default(UIntPtr);
				num = unchecked(num4 / num);
				num = default(UIntPtr);
				if (num == 0)
				{
					Np8 obj = (Np8)(object)Nf2.Default;
					np = null;
					np = obj;
				}
			}
			catch
			{
				try
				{
					try
					{
						_ = (x8D9)(object)Nf2.Default;
					}
					catch
					{
						pj = (Pj8)(object)Nf2.Default;
						pj = null;
					}
				}
				catch
				{
					try
					{
						Pm9 pm = pm;
						pm = null;
						_ = (f0F)(object)Nf2.Default;
						pm = (Pm9)(object)Nf2.Default;
						d8B = null;
						d8B = d8B;
						goto end_IL_0099;
					}
					finally
					{
						_ = (d8B)(object)Nf2.Default;
						w4R w4R = null;
						w4R = w4R;
						co = null;
						co = co;
						Mb5 mb = mb;
						mb = mb;
						goto end_IL_0099;
					}
					end_IL_0099:;
				}
			}
			if (num == 0)
			{
				do
				{
					if (num == 0)
					{
						_ = (r8M)Nf2.Default;
						f0F = f0F;
						f0F = f0F;
					}
					obj5 = obj5;
				}
				while (obj5 != null);
			}
			if (unchecked((nuint)(UIntPtr)Nf2.Default) - num == 0)
			{
				do
				{
					_ = (f2L)(object)Nf2.Default;
				}
				while (obj5 != null);
			}
			else
			{
				do
				{
					try
					{
					}
					catch
					{
						d8B = d8B;
						_ = (m0N)(object)Nf2.Default;
					}
				}
				while ((object)Nf2.Default != null);
			}
			f9T6 obj7 = (f9T6)(object)Nf2.Default;
			f9T = (f9T6)(object)Nf2.Default;
			f9T = obj7;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (f2L)(object)Nf2.Default;
					_ = (Eb1)(object)Nf2.Default;
					m0N obj8 = (m0N)(object)Nf2.Default;
					m0N = (m0N)(object)Nf2.Default;
					m0N = obj8;
				}
				else
				{
					np = null;
				}
			}
			catch
			{
				if (num == 0)
				{
					f0F = f0F;
					_ = (f0F)(object)Nf2.Default;
					_ = (Pm9)(object)Nf2.Default;
				}
				else
				{
					o5CZ o5CZ = null;
					o5CZ = o5CZ;
				}
			}
			finally
			{
				try
				{
					if (num == 0)
					{
						_ = (d1X)(object)Nf2.Default;
					}
				}
				finally
				{
					while (obj5 != null)
					{
						m0N = m0N;
					}
					goto IL_02a3;
				}
			}
		}
		IL_0313:
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				while (obj5 != null)
				{
					_ = (d1X)(object)Nf2.Default;
				}
			}
			goto IL_0373;
		}
		try
		{
			_ = (Eb1)(object)Nf2.Default;
			_ = Nf2.Default;
		}
		finally
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (d8B)(object)Nf2.Default;
			}
			else
			{
				np = np;
			}
			goto IL_0373;
		}
		IL_0373:
		try
		{
			try
			{
				d8B = d8B;
				_ = Nf2.Default;
			}
			catch
			{
				d4E d4E = (d4E)(object)Nf2.Default;
				d4E = d4E;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (m0N)(object)Nf2.Default;
					_ = (o5CZ)(object)Nf2.Default;
					_ = (Pj8)(object)Nf2.Default;
					_ = Nf2.Default;
				}
				else
				{
					_ = (d4E)(object)Nf2.Default;
				}
				goto end_IL_0374;
			}
			end_IL_0374:;
		}
		finally
		{
			f0F = (f0F)(object)Nf2.Default;
			goto IL_0403;
		}
		IL_0683:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		do
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / num == 0)
				{
					np = np;
				}
				else
				{
					d8B = d8B;
				}
			}
		}
		while (obj5 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		checked
		{
			while (obj5 != null)
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked(num / checked(num + unchecked(num / num))) == 0)
				{
					w4R w4R = null;
					continue;
				}
				while ((object)Nf2.Default != null)
				{
					_ = (k6D9)(object)Nf2.Default;
				}
			}
			while (obj5 != null)
			{
				_ = Nf2.Default;
			}
			if (num == 0)
			{
				x8D = x8D;
			}
			if (num == 0)
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		if ((nuint)(UIntPtr)Nf2.Default / (num / unchecked((nuint)default(UIntPtr))) == 0)
		{
			do
			{
				d8B = d8B;
			}
			while (obj5 != null);
		}
		else
		{
			while (obj5 != null)
			{
				np = np;
				_ = (Mb5)(object)Nf2.Default;
				_ = (Np8)(object)Nf2.Default;
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (Np8)(object)Nf2.Default;
				}
				finally
				{
					_ = (x8D9)(object)Nf2.Default;
					continue;
				}
			}
			while (obj5 != null);
		}
		finally
		{
			try
			{
				co = null;
			}
			catch
			{
				_ = (d8B)(object)Nf2.Default;
			}
			finally
			{
				Nf2 nf = null;
				goto IL_07ff;
			}
		}
		IL_0523:
		checked
		{
			while (obj5 != null)
			{
				num = default(UIntPtr);
				if (num - (num - unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
				{
					while (obj5 != null)
					{
						d8B = d8B;
					}
				}
			}
			_ = (f9T6)(object)Nf2.Default;
			do
			{
				_ = (x8D9)(object)Nf2.Default;
				pj = pj;
				_ = (o5CZ)(object)Nf2.Default;
			}
			while (obj5 != null);
			try
			{
				while (obj5 != null)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (f9T6)(object)Nf2.Default;
					}
					else
					{
						f9T = f9T;
					}
				}
			}
			catch
			{
				UIntPtr num5;
				UIntPtr num6;
				unchecked
				{
					num5 = (UIntPtr)Nf2.Default;
					num6 = (UIntPtr)Nf2.Default;
				}
				nuint num7 = num + unchecked((nuint)(UIntPtr)Nf2.Default);
				UIntPtr num8 = unchecked((UIntPtr)Nf2.Default);
				num = default(UIntPtr);
				if (unchecked((nuint)num5) + (unchecked((nuint)num6) + (num7 - (unchecked((nuint)num8) + num) - num)) == 0)
				{
					try
					{
						x8D = (x8D9)(object)Nf2.Default;
						x8D = x8D;
						_ = (k6D9)(object)Nf2.Default;
						f0F = f0F;
						_ = (r8M)Nf2.Default;
					}
					finally
					{
						_ = (Pj8)(object)Nf2.Default;
						goto end_IL_058b;
					}
				}
				end_IL_058b:;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
				while ((object)Nf2.Default != null)
				{
					while (obj5 != null)
					{
						nf = nf;
						nf = nf;
					}
				}
			}
			catch
			{
				do
				{
					_ = (Np8)(object)Nf2.Default;
				}
				while (obj5 != null || obj5 != null);
			}
		}
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
			}
		}
		finally
		{
			co = (Co4)(object)Nf2.Default;
			goto IL_0683;
		}
		IL_02a3:
		Eb1 eb;
		checked
		{
			while (obj5 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					nuint num9 = unchecked((nuint)(UIntPtr)Nf2.Default) + (num - unchecked((nuint)default(UIntPtr)));
					num = default(UIntPtr);
					if (num9 * num == 0)
					{
						_ = (Mb5)(object)Nf2.Default;
					}
				}
			}
			try
			{
				try
				{
					eb = null;
					eb = eb;
				}
				finally
				{
					if (num == 0)
					{
						_ = Nf2.Default;
					}
					goto end_IL_02a9;
				}
				end_IL_02a9:;
			}
			finally
			{
				do
				{
					try
					{
						_ = (Np8)(object)Nf2.Default;
						_ = (r8M)Nf2.Default;
					}
					finally
					{
						d8B = null;
						_ = (x8D9)(object)Nf2.Default;
						_ = (f0F)(object)Nf2.Default;
						continue;
					}
				}
				while ((object)Nf2.Default != null);
				goto IL_0313;
			}
		}
		IL_0403:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		try
		{
			try
			{
				f2L = null;
				f2L = f2L;
			}
			finally
			{
				while ((object)Nf2.Default != null)
				{
					_ = (f2L)(object)Nf2.Default;
				}
				goto end_IL_0404;
			}
			end_IL_0404:;
		}
		finally
		{
			Gj4 gj = gj;
			gj = gj;
			goto IL_0444;
		}
		IL_0444:
		do
		{
			_ = (d1X)(object)Nf2.Default;
		}
		while (obj5 != null);
		do
		{
			_ = (r8M)Nf2.Default;
		}
		while ((object)Nf2.Default != null);
		eb = (Eb1)(object)Nf2.Default;
		f9T = f9T;
		_ = (f0F)(object)Nf2.Default;
		_ = (d8B)(object)Nf2.Default;
		try
		{
		}
		catch
		{
			while ((object)Nf2.Default != null)
			{
				co = co;
			}
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
			while (true)
			{
				if ((object)Nf2.Default != null)
				{
					np = np;
					r8M = r8M;
					r8M = default(r8M);
				}
				else if (obj5 == null)
				{
					break;
				}
			}
			goto IL_0523;
		}
		IL_07ff:
		_ = (Pm9)(object)Nf2.Default;
		while (obj5 != null)
		{
			try
			{
				do
				{
					_ = (Gj4)Nf2.Default;
					_ = (f9T6)(object)Nf2.Default;
					_ = (Gj4)Nf2.Default;
					_ = (Pm9)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
			catch
			{
				do
				{
					_ = (Np8)(object)Nf2.Default;
				}
				while (obj5 != null);
			}
		}
		UIntPtr num10 = (UIntPtr)Nf2.Default;
		num = default(UIntPtr);
		if ((nuint)num10 / num == 0)
		{
			while ((object)Nf2.Default != null)
			{
			}
		}
		else
		{
			do
			{
				if (num == 0)
				{
					pj = pj;
				}
			}
			while (obj5 != null);
		}
		num = default(UIntPtr);
		checked
		{
			if (num + num == 0)
			{
				if (num == 0)
				{
					do
					{
						_ = (Gj4)Nf2.Default;
					}
					while (obj5 != null);
				}
				else
				{
					while ((object)Nf2.Default != null)
					{
						_ = (_003CModule_003E)(object)Nf2.Default;
					}
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					if (unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						f2L = f2L;
					}
				}
				else
				{
					_ = (Pj8)(object)Nf2.Default;
					d8B = null;
					f0F = f0F;
					w4R w4R = (w4R)(object)Nf2.Default;
				}
			}
			while (true)
			{
				if ((object)Nf2.Default != null)
				{
					while (obj5 != null)
					{
						_ = (Pm9)(object)Nf2.Default;
					}
				}
				else if (obj5 == null)
				{
					break;
				}
			}
			try
			{
				try
				{
					_ = Nf2.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
					_ = (Mb5)(object)Nf2.Default;
					eb = null;
					_ = (d8B)(object)Nf2.Default;
					goto end_IL_096f;
				}
				end_IL_096f:;
			}
			catch
			{
				try
				{
					_ = (f0F)(object)Nf2.Default;
				}
				catch
				{
					f9T = null;
				}
				finally
				{
					f0F = null;
					goto end_IL_09a7;
				}
				end_IL_09a7:;
			}
		}
		while ((object)Nf2.Default != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					eb = eb;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					co = co;
					continue;
				}
			}
			while ((object)Nf2.Default != null)
			{
				_ = (f2L)(object)Nf2.Default;
			}
		}
		do
		{
			if (num == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		while (obj5 != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Nf2.Default) + num == 0)
			{
				_ = (o5CZ)(object)Nf2.Default;
			}
			do
			{
				_ = (Pj8)(object)Nf2.Default;
			}
			while (obj5 != null);
		}
	}

	static void n1P()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		while (obj != null)
		{
			do
			{
				_ = (r8M)Nf2.Default;
				obj = obj;
			}
			while (obj != null || (object)Nf2.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
					_ = (d4E)(object)Nf2.Default;
					_ = (k6D9)(object)Nf2.Default;
				}
				catch
				{
					f2L = f2L;
					f2L = f2L;
				}
			}
			catch
			{
				uIntPtr = (UIntPtr)Nf2.Default;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (r8M)Nf2.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4R w4R);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)Nf2.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					w4R obj4 = (w4R)(object)Nf2.Default;
					w4R = null;
					w4R = obj4;
				}
				else
				{
					_ = (Pj8)(object)Nf2.Default;
				}
			}
		}
		else
		{
			_ = (Pm9)(object)Nf2.Default;
			_ = (k6D9)(object)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Gj4)Nf2.Default;
				_ = (Pj8)(object)Nf2.Default;
				m0N = (m0N)(object)Nf2.Default;
				m0N = m0N;
				_ = (Np8)(object)Nf2.Default;
			}
			catch
			{
				_ = (Co4)(object)Nf2.Default;
			}
			finally
			{
				do
				{
					_ = (f0F)(object)Nf2.Default;
				}
				while (obj != null);
				goto IL_015e;
			}
		}
		goto IL_015e;
		IL_0406:
		m0N = null;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr / (uIntPtr / (nuint)(UIntPtr)Nf2.Default) == 0)
			{
				r8M obj6 = (r8M)Nf2.Default;
				r8M r8M = default(r8M);
				r8M = obj6;
				_ = (f2L)(object)Nf2.Default;
			}
		}
		while (obj != null);
		while (obj != null)
		{
			try
			{
				_ = (Gj4)Nf2.Default;
			}
			finally
			{
				Nf2 nf = Nf2.Default;
				nf = nf;
				continue;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			d1X = d1X;
		}
		else
		{
			try
			{
				do
				{
					_ = (Np8)(object)Nf2.Default;
					pm = pm;
					Nf2 nf = Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
			catch
			{
			}
		}
		_ = (m0N)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f9T6 f9T);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					f9T = f9T;
				}
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (f9T6)(object)Nf2.Default;
				}
				finally
				{
					_ = Nf2.Default;
					goto end_IL_0513;
				}
				end_IL_0513:;
			}
			catch
			{
				do
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				while (obj != null);
			}
		}
		_ = (f9T6)(object)Nf2.Default;
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w4R)(object)Nf2.Default;
				}
				finally
				{
					f2L = null;
					goto end_IL_054f;
				}
			}
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				pm = pm;
			}
			end_IL_054f:;
		}
		catch
		{
			_ = (Pj8)(object)Nf2.Default;
			_ = (d8B)(object)Nf2.Default;
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (d4E)(object)Nf2.Default;
					_ = (w4R)(object)Nf2.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pm9)(object)Nf2.Default;
				}
			}
		}
		else
		{
			d4E = d4E;
			d4E = d4E;
		}
		while ((object)Nf2.Default != null)
		{
			try
			{
				pm = pm;
			}
			catch
			{
				do
				{
					k6D9 k6D = (k6D9)(object)Nf2.Default;
					k6D = k6D;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		checked
		{
			try
			{
				try
				{
					f9T = (f9T6)(object)Nf2.Default;
				}
				finally
				{
					_ = (Pj8)(object)Nf2.Default;
					goto end_IL_062e;
				}
				end_IL_062e:;
			}
			catch
			{
				if ((uIntPtr - uIntPtr) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					f2L = null;
				}
				else
				{
					try
					{
						_ = (Pj8)(object)Nf2.Default;
					}
					catch
					{
						_ = (f0F)(object)Nf2.Default;
						_ = (o5CZ)(object)Nf2.Default;
						_ = (d1X)(object)Nf2.Default;
					}
				}
			}
			try
			{
				_ = (Pj8)(object)Nf2.Default;
			}
			finally
			{
				x8D = (x8D9)(object)Nf2.Default;
				goto IL_06c2;
			}
		}
		IL_015e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		Mb5 mb;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		checked
		{
			try
			{
				f2L = f2L;
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
				{
					while (obj != null)
					{
						d1X = (d1X)(object)Nf2.Default;
						d1X = d1X;
						mb = null;
						mb = mb;
					}
				}
				else
				{
					_ = (Np8)(object)Nf2.Default;
				}
			}
			try
			{
				try
				{
					_ = (m0N)(object)Nf2.Default;
				}
				finally
				{
					_ = (o5CZ)(object)Nf2.Default;
					goto end_IL_01bf;
				}
				end_IL_01bf:;
			}
			catch
			{
				w4R = null;
				_ = (Pm9)(object)Nf2.Default;
				_ = (f0F)(object)Nf2.Default;
			}
			finally
			{
				try
				{
					try
					{
						pj = pj;
						pj = pj;
					}
					finally
					{
						_ = (Pj8)(object)Nf2.Default;
						goto end_IL_01fd;
					}
					end_IL_01fd:;
				}
				finally
				{
					try
					{
						d8B obj16 = (d8B)(object)Nf2.Default;
						d8B = null;
						d8B = obj16;
					}
					catch
					{
						_ = (f9T6)(object)Nf2.Default;
					}
					goto IL_0247;
				}
			}
		}
		IL_0795:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			do
			{
				UIntPtr num = unchecked((UIntPtr)Nf2.Default);
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)num) + uIntPtr != 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (r8M)Nf2.Default;
						f9T = f9T;
						d8B = d8B;
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = _003CModule_003E;
					}
				}
				else
				{
					w4R = (w4R)(object)Nf2.Default;
				}
			}
			while (obj != null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Eb1 eb);
			while ((object)Nf2.Default != null)
			{
				try
				{
					try
					{
						_ = (Pm9)(object)Nf2.Default;
					}
					catch
					{
						eb = eb;
						eb = null;
					}
				}
				catch
				{
					mb = (Mb5)(object)Nf2.Default;
				}
			}
			_ = (f2L)(object)Nf2.Default;
			if (uIntPtr == 0)
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) * uIntPtr == 0)
				{
					try
					{
						pj = pj;
					}
					finally
					{
						_ = (f0F)(object)Nf2.Default;
						goto IL_0844;
					}
				}
				try
				{
					d1X = d1X;
				}
				finally
				{
					co = (Co4)(object)Nf2.Default;
					goto IL_0844;
				}
			}
			goto IL_0844;
		}
		IL_02c6:
		checked
		{
			try
			{
				try
				{
					do
					{
						_ = (f0F)(object)Nf2.Default;
					}
					while ((object)Nf2.Default != null);
				}
				finally
				{
					while (obj != null)
					{
						_ = (d8B)(object)Nf2.Default;
					}
					goto end_IL_02c7;
				}
				end_IL_02c7:;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr - unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
				{
					_ = (m0N)(object)Nf2.Default;
				}
				goto IL_0354;
			}
		}
		IL_086a:
		_ = (o5CZ)(object)Nf2.Default;
		try
		{
			try
			{
				co = null;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					Nf2 nf = Nf2.Default;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Np8)(object)Nf2.Default;
				}
				catch
				{
					_ = (Pm9)(object)Nf2.Default;
				}
			}
			else
			{
				_ = (d1X)(object)Nf2.Default;
			}
		}
		while (obj != null)
		{
			mb = mb;
		}
		try
		{
			nuint num2 = uIntPtr;
			UIntPtr num3 = (UIntPtr)Nf2.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (num2 + (unchecked((nuint)num3) - uIntPtr) == 0)
				{
					co = co;
				}
				else
				{
					m0N = m0N;
				}
				return;
			}
		}
		catch
		{
			try
			{
				_ = (w4R)(object)Nf2.Default;
				x8D = x8D;
				return;
			}
			finally
			{
				f9T = (f9T6)(object)Nf2.Default;
				return;
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Np8)(object)Nf2.Default;
				}
				while (obj != null);
			}
			return;
		}
		IL_06c2:
		_ = (k6D9)(object)Nf2.Default;
		try
		{
			k6D9 k6D = (k6D9)(object)Nf2.Default;
		}
		finally
		{
			try
			{
				do
				{
					_ = Nf2.Default;
					_ = (o5CZ)(object)Nf2.Default;
					_ = (d4E)(object)Nf2.Default;
					w4R = w4R;
				}
				while ((object)Nf2.Default != null);
			}
			catch
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
				d4E = (d4E)(object)Nf2.Default;
				_ = (Pj8)(object)Nf2.Default;
			}
			goto IL_0795;
		}
		IL_0844:
		checked
		{
			try
			{
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) - uIntPtr == 0)
				{
					while (obj != null)
					{
						d4E = d4E;
					}
				}
				goto IL_086a;
			}
		}
		IL_0354:
		while (obj != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					pm = (Pm9)(object)Nf2.Default;
					pm = null;
				}
			}
			else
			{
				_ = (m0N)(object)Nf2.Default;
			}
		}
		_ = (Gj4)Nf2.Default;
		x8D9 obj25 = (x8D9)(object)Nf2.Default;
		x8D = x8D;
		x8D = obj25;
		mb = (Mb5)(object)Nf2.Default;
		m0N = m0N;
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Gj4)Nf2.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					f9T = (f9T6)(object)Nf2.Default;
					f9T = f9T;
					_ = (o5CZ)(object)Nf2.Default;
					_ = (o5CZ)(object)Nf2.Default;
					co = (Co4)(object)Nf2.Default;
					co = co;
					m0N = m0N;
				}
				goto IL_0406;
			}
		}
		goto IL_0406;
		IL_0247:
		try
		{
			Gj4 obj26 = (Gj4)Nf2.Default;
			Gj4 gj = default(Gj4);
			gj = obj26;
			_ = (r8M)Nf2.Default;
			_ = (Pj8)(object)Nf2.Default;
		}
		finally
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (d4E)(object)Nf2.Default;
				}
				finally
				{
					_ = (f0F)(object)Nf2.Default;
					goto IL_02c6;
				}
			}
			try
			{
				d1X = (d1X)(object)Nf2.Default;
			}
			finally
			{
				_ = (r8M)Nf2.Default;
				goto IL_02c6;
			}
		}
	}
}
