using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using Yz5;
using a3S0;
using a7A;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using j6N2;
using k7R;
using q4PZ;
using s6N8;
using w0WN;
using x5PX;

namespace c9P;

[DesignerGenerated]
public class p9B : Form
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
			EventHandler eventHandler = Ds1;
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

	public p9B()
	{
		a0S();
	}

	[DebuggerNonUserCode]
	protected override void r5M(bool r6Q)
	{
		try
		{
			if (r6Q && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r6Q);
		}
	}

	[DebuggerStepThrough]
	private void a0S()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		byte[] byte_ = Tf67.byte_0;
		int num = 13;
		while (true)
		{
			Button1 = new Button();
			Button2 = new Button();
			txtUsername = new TextBox();
			num = 41;
			while (true)
			{
				txtPassword = new TextBox();
				Label1 = new Label();
				Label2 = new Label();
				num = 10;
				while (true)
				{
					Label3 = new Label();
					((Control)this).SuspendLayout();
					((ButtonBase)Button1).set_BackColor(Color.FromArgb(128, 128, 255));
					num = 2;
					while (true)
					{
						((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
						((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 6;
						while (true)
						{
							((Control)Button1).set_ForeColor(Color.White);
							((Control)Button1).set_Location(new Point(48, 137));
							num = 3;
							while (true)
							{
								((Control)Button1).set_Name("Button1");
								((Control)Button1).set_Size(new Size(84, 29));
								num = 25;
								while (true)
								{
									((Control)Button1).set_TabIndex(0);
									((ButtonBase)Button1).set_Text("Login");
									num = 16;
									while (true)
									{
										((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
										((ButtonBase)Button2).set_BackColor(Color.FromArgb(128, 128, 255));
										num = 11;
										while (true)
										{
											((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
											((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 1;
											while (true)
											{
												((Control)Button2).set_ForeColor(Color.White);
												((Control)Button2).set_Location(new Point(149, 137));
												switch (byte_[110])
												{
												case 113:
													break;
												case 123:
													goto end_IL_000e;
												case 128:
													goto end_IL_00fb;
												case 137:
													goto end_IL_012b;
												case 115:
													goto end_IL_015b;
												case 118:
													goto end_IL_017c;
												case 114:
													goto end_IL_01a5;
												case 122:
													goto end_IL_01d0;
												case 153:
													goto end_IL_01fd;
												default:
													goto end_IL_0231;
												case 139:
													((Control)Button2).set_Name("Button2");
													((Control)Button2).set_Size(new Size(84, 29));
													num = 29;
													goto case 141;
												case 141:
													((Control)Button2).set_TabIndex(1);
													((ButtonBase)Button2).set_Text("Cancel");
													num = 43;
													goto case 155;
												case 155:
													((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
													((Control)txtUsername).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 33;
													goto case 145;
												case 145:
													((TextBoxBase)txtUsername).set_ForeColor(Color.Purple);
													((Control)txtUsername).set_Location(new Point(139, 57));
													num = 39;
													goto case 151;
												case 151:
													((Control)txtUsername).set_Name("txtUsername");
													((Control)txtUsername).set_Size(new Size(104, 23));
													num = 30;
													goto case 142;
												case 142:
													((Control)txtUsername).set_TabIndex(2);
													txtUsername.set_TextAlign((HorizontalAlignment)2);
													num = 4;
													goto case 116;
												case 116:
													((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 22;
													goto case 134;
												case 134:
													((TextBoxBase)txtPassword).set_ForeColor(Color.Purple);
													((Control)txtPassword).set_Location(new Point(139, 96));
													num = 15;
													goto case 127;
												case 127:
													((Control)txtPassword).set_Name("txtPassword");
													txtPassword.set_PasswordChar('#');
													num = 7;
													goto case 119;
												case 119:
													((Control)txtPassword).set_Size(new Size(104, 23));
													((Control)txtPassword).set_TabIndex(3);
													num = 18;
													goto case 130;
												case 130:
													txtPassword.set_TextAlign((HorizontalAlignment)2);
													Label1.set_AutoSize(true);
													num = 36;
													goto case 148;
												case 148:
													((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 31;
													goto case 135;
												case 135:
												case 143:
													((Control)Label1).set_ForeColor(Color.White);
													((Control)Label1).set_Location(new Point(46, 56));
													num = 40;
													goto case 152;
												case 152:
													((Control)Label1).set_Name("Label1");
													((Control)Label1).set_Size(new Size(91, 17));
													num = 17;
													goto case 129;
												case 129:
													((Control)Label1).set_TabIndex(4);
													Label1.set_Text("Username :");
													num = 12;
													goto case 124;
												case 124:
													Label2.set_AutoSize(true);
													((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 37;
													goto case 149;
												case 149:
													((Control)Label2).set_ForeColor(Color.White);
													((Control)Label2).set_Location(new Point(46, 102));
													num = 42;
													goto case 154;
												case 154:
													((Control)Label2).set_Name("Label2");
													((Control)Label2).set_Size(new Size(87, 17));
													num = 9;
													goto case 121;
												case 121:
													((Control)Label2).set_TabIndex(5);
													Label2.set_Text("Password :");
													goto case 112;
												case 112:
													num = 32;
													goto case 144;
												case 144:
													Label3.set_AutoSize(true);
													((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 28;
													goto case 140;
												case 140:
													((Control)Label3).set_ForeColor(Color.White);
													((Control)Label3).set_Location(new Point(108, 22));
													num = 19;
													goto case 131;
												case 131:
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(48, 17));
													num = 8;
													goto case 120;
												case 120:
													((Control)Label3).set_TabIndex(6);
													Label3.set_Text("Login");
													num = 24;
													goto case 136;
												case 136:
													((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
													((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
													num = 26;
													goto case 138;
												case 138:
													((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
													((Form)this).set_ClientSize(new Size(283, 189));
													num = 20;
													goto case 132;
												case 132:
													((Control)this).get_Controls().Add((Control)(object)Label3);
													((Control)this).get_Controls().Add((Control)(object)Label2);
													num = 14;
													goto case 126;
												case 126:
													((Control)this).get_Controls().Add((Control)(object)Label1);
													((Control)this).get_Controls().Add((Control)(object)txtPassword);
													num = 21;
													goto case 133;
												case 133:
													((Control)this).get_Controls().Add((Control)(object)txtUsername);
													((Control)this).get_Controls().Add((Control)(object)Button2);
													num = 5;
													goto case 117;
												case 117:
													((Control)this).get_Controls().Add((Control)(object)Button1);
													((Form)this).set_FormBorderStyle((FormBorderStyle)0);
													num = 34;
													goto case 146;
												case 146:
													((Control)this).set_Name("Login");
													((Form)this).set_StartPosition((FormStartPosition)1);
													((Form)this).set_Text("Login");
													num = 35;
													goto case 147;
												case 147:
													((Control)this).ResumeLayout(false);
													((Control)this).PerformLayout();
													Tf67.byte_0[53] = (byte)(Tf67.byte_0[53] & Tf67.byte_0[113] & 0xEF);
													return;
												case 150:
													return;
												}
												continue;
												end_IL_000e:
												break;
											}
											continue;
											end_IL_00fb:
											break;
										}
										continue;
										end_IL_012b:
										break;
									}
									continue;
									end_IL_015b:
									break;
								}
								continue;
								end_IL_017c:
								break;
							}
							continue;
							end_IL_01a5:
							break;
						}
						continue;
						end_IL_01d0:
						break;
					}
					continue;
					end_IL_01fd:
					break;
				}
				continue;
				end_IL_0231:
				break;
			}
		}
	}

	private void Ds1(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		byte[] byte_ = Tf67.byte_0;
		int num = 4;
		while (true)
		{
			bool flag = (Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0);
			while (true)
			{
				num = 3;
				while (true)
				{
					if (flag)
					{
						num = 2;
						while (true)
						{
							MessageBox.Show("Login Successfully...!");
							Hi84 hi = new Hi84();
							((Control)hi).Show();
							((Control)this).Hide();
							switch (byte_[121])
							{
							case 41:
								break;
							case 42:
								goto end_IL_000d;
							case 45:
								goto end_IL_005f;
							default:
								goto end_IL_0064;
							case 46:
								num = 0;
								return;
							case 40:
								goto IL_00a4;
							case 39:
								return;
							}
							continue;
							end_IL_000d:
							break;
						}
						continue;
					}
					num = 1;
					goto IL_00a4;
					IL_00a4:
					MessageBox.Show("Invalid Username or Password...!");
					num = 0;
					return;
					continue;
					end_IL_005f:
					break;
				}
				continue;
				end_IL_0064:
				break;
			}
		}
	}

	static void Fq4()
	{
		p9B p9B2 = p9B2;
		p9B2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		while (true)
		{
			obj = obj;
			if (obj != null)
			{
				_ = (k0WR)(object)o0E3.Default;
				continue;
			}
			break;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj != null)
		{
			try
			{
				_003CModule_003E obj2 = (_003CModule_003E)(object)o0E3.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj2;
			}
			catch
			{
				_003CModule_003E = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		catch
		{
			try
			{
				hi = hi;
				hi = hi;
			}
			catch
			{
				x4N = x4N;
				x4N = x4N;
			}
			finally
			{
				try
				{
					_ = o0E3.Default;
				}
				finally
				{
					hi = null;
					goto end_IL_005e;
				}
			}
			end_IL_005e:;
		}
		k0WR k0WR;
		do
		{
			k0WR = null;
			k0WR = k0WR;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		checked
		{
			num = num * (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)o0E3.Default);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				et = et;
				et = et;
				i5NX = (i5NX)(object)o0E3.Default;
				i5NX = i5NX;
				p9B2 = p9B2;
				hi = hi;
			}
		}
		else
		{
			do
			{
				p9B2 = null;
			}
			while ((object)o0E3.Default != null || (object)o0E3.Default != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (_003CModule_003E)(object)o0E3.Default;
			goto IL_01ce;
		}
		try
		{
			do
			{
				_ = o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		finally
		{
			while (obj != null)
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			goto IL_01ce;
		}
		IL_01ce:
		et = et;
		_003CModule_003E = _003CModule_003E;
		_ = (Et0)o0E3.Default;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
				{
					i5NX = i5NX;
				}
				else
				{
					x4N = null;
				}
			}
			while (obj != null);
		}
		a9X a9X = (a9X)(object)o0E3.Default;
		a9X = a9X;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		try
		{
			w8W = w8W;
			w8W = default(w8W);
			w8W = w8W;
		}
		catch
		{
			try
			{
				Pg2c pg2c = pg2c;
				pg2c = null;
			}
			catch
			{
				_ = (Hi84)(object)o0E3.Default;
			}
		}
		f5R4 f5R = f5R;
		f5R = f5R;
		_ = (a9X)(object)o0E3.Default;
		et = et;
		Tf67 tf = tf;
		tf = null;
		num = default(UIntPtr);
		checked
		{
			nuint num2 = unchecked(checked(unchecked((nuint)default(UIntPtr)) + num) / (nuint)(UIntPtr)o0E3.Default) + unchecked(num / checked(num + num));
			num = default(UIntPtr);
			if (num2 * (unchecked((nuint)default(UIntPtr)) * num) == 0)
			{
				_ = (p9B)(object)o0E3.Default;
				_ = (Dg19)(object)o0E3.Default;
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					k0WR = k0WR;
				}
				else
				{
					w8W = default(w8W);
					_ = (p9B)(object)o0E3.Default;
					_ = (_003CModule_003E)(object)o0E3.Default;
					et = et;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
				{
					w8W = w8W;
				}
			}
			finally
			{
				try
				{
					o0E3 obj9 = o0E3.Default;
					o0E3 o0E = o0E;
					o0E = obj9;
				}
				catch
				{
					_ = o0E3.Default;
				}
				goto IL_039c;
			}
		}
		goto IL_039c;
		IL_039c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		checked
		{
			if (unchecked((nuint)(UIntPtr)o0E3.Default) + num == 0)
			{
				x4N = x4N;
			}
			try
			{
				if (num == 0)
				{
					if (num == 0)
					{
						i5NX = i5NX;
					}
					else
					{
						_ = (Hi84)(object)o0E3.Default;
					}
				}
			}
			catch
			{
				Pg2c pg2c = (Pg2c)(object)o0E3.Default;
			}
			do
			{
				g9Z = g9Z;
				g9Z = g9Z;
			}
			while (obj != null);
		}
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
			do
			{
				try
				{
					_ = (a9X)(object)o0E3.Default;
				}
				finally
				{
					a9X = a9X;
					_ = (Sf06)(object)o0E3.Default;
					sf = sf;
					sf = sf;
					i5NX = (i5NX)(object)o0E3.Default;
					continue;
				}
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (w8W)o0E3.Default;
				}
				else
				{
					i5NX = i5NX;
				}
			}
		}
		if (num != (UIntPtr)(nuint)0u || (UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
		{
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					Pg2c pg2c = (Pg2c)(object)o0E3.Default;
				}
				finally
				{
					_ = (i5NX)(object)o0E3.Default;
					continue;
				}
			}
		}
		while (obj != null)
		{
			_ = (i5NX)(object)o0E3.Default;
		}
		_ = (Pg2c)(object)o0E3.Default;
		x4N = (x4N6)(object)o0E3.Default;
		_ = (Zn1b)(object)o0E3.Default;
		a9X = (a9X)(object)o0E3.Default;
		try
		{
			if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				finally
				{
					_ = o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
					_ = (k4C9)(object)o0E3.Default;
					_ = o0E3.Default;
					goto end_IL_052f;
				}
			}
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				k0WR = k0WR;
			}
			end_IL_052f:;
		}
		catch
		{
			do
			{
				p9B2 = (p9B)(object)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		do
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				i5NX = i5NX;
			}
		}
		while (obj != null);
		_ = (p9B)(object)o0E3.Default;
		if (num == (UIntPtr)(nuint)0u)
		{
			g9Z = g9Z;
			_ = (Zn1b)(object)o0E3.Default;
			_ = (Hi84)(object)o0E3.Default;
		}
	}

	static void Sr1()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		checked
		{
			nuint num = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)o0E3.Default);
			nuint num2 = unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default);
			uIntPtr = default(UIntPtr);
			nuint num3 = unchecked(checked(num * (num2 + uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default))) / uIntPtr) + uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((num3 - uIntPtr) * uIntPtr == 0)
			{
				while ((object)o0E3.Default != null)
				{
					while (true)
					{
						obj = obj;
						if (obj == null)
						{
							break;
						}
						_ = (a9X)(object)o0E3.Default;
					}
				}
			}
			x4N6 x4N = x4N;
			x4N = null;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
				}
				finally
				{
					_ = (Dg19)(object)o0E3.Default;
					goto IL_00c4;
				}
			}
			goto IL_00c4;
		}
		IL_00c4:
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
		_003CModule_003E = _003CModule_003E;
		_ = (w1H)(object)o0E3.Default;
		_ = (p9B)(object)o0E3.Default;
		_ = (_003CModule_003E)(object)o0E3.Default;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = o0E3.Default;
			}
			while (obj != null || obj != null);
		}
		f5R4 f5R = f5R;
		f5R = null;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
			}
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
					{
						_ = (Et0)o0E3.Default;
					}
					else
					{
						g9Z g9Z = g9Z;
						g9Z = g9Z;
					}
				}
			}
			else
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					_ = (x4N6)(object)o0E3.Default;
				}
			}
		}
		else
		{
			_ = (g9Z)(object)o0E3.Default;
		}
		if (uIntPtr == 0 && (UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Hi84)(object)o0E3.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		do
		{
			try
			{
				try
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				finally
				{
					_ = (w0A)(object)o0E3.Default;
					goto end_IL_01e2;
				}
				end_IL_01e2:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					et = (Et0)o0E3.Default;
					et = et;
				}
			}
		}
		while ((object)o0E3.Default != null);
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				_ = (Dg19)(object)o0E3.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		checked
		{
			if (unchecked((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u))
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if ((uIntPtr - uIntPtr) * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
					{
					}
				}
				catch
				{
					try
					{
						_ = (k0WR)(object)o0E3.Default;
					}
					finally
					{
						tf = null;
						goto end_IL_027c;
					}
					end_IL_027c:;
				}
			}
			else
			{
				o0E3 obj5 = o0E3.Default;
				o0E = o0E3.Default;
				o0E = obj5;
			}
			_ = (w1H)(object)o0E3.Default;
			_ = (Gn76)(object)o0E3.Default;
			try
			{
				if (uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr - uIntPtr == 0)
					{
						et = et;
					}
					else
					{
						_ = (Tf67)(object)o0E3.Default;
					}
				}
			}
			finally
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					try
					{
						_ = (Sf06)(object)o0E3.Default;
					}
					catch
					{
						i5NX = i5NX;
					}
				}
				goto IL_0330;
			}
		}
		IL_0330:
		do
		{
			try
			{
				do
				{
					g9Z g9Z = null;
				}
				while (obj != null);
			}
			catch
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					tf = tf;
				}
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		try
		{
			checked
			{
				try
				{
					while ((object)o0E3.Default != null)
					{
						et = (Et0)o0E3.Default;
					}
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * (unchecked((nuint)(UIntPtr)o0E3.Default) * uIntPtr) - uIntPtr == 0)
					{
						_ = (w0A)(object)o0E3.Default;
					}
					goto end_IL_035e;
				}
			}
			end_IL_035e:;
		}
		catch
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					k4C9 obj8 = (k4C9)(object)o0E3.Default;
					k4C9 k4C = k4C;
					k4C = obj8;
				}
			}
			finally
			{
				UIntPtr num4 = (UIntPtr)o0E3.Default;
				uIntPtr = default(UIntPtr);
				if ((nuint)num4 / uIntPtr == 0)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				else
				{
					k0WR = null;
				}
				goto end_IL_03b2;
			}
			end_IL_03b2:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		try
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gn = null;
					gn = gn;
				}
			}
		}
		catch
		{
			gn = gn;
			_ = (w1H)(object)o0E3.Default;
			_ = (w1H)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (a9X)(object)o0E3.Default;
					_ = (w0A)(object)o0E3.Default;
					_ = (k0WR)(object)o0E3.Default;
				}
				finally
				{
					f5R = (f5R4)(object)o0E3.Default;
					goto IL_04b8;
				}
			}
			if (uIntPtr == 0)
			{
				_ = (k4C9)(object)o0E3.Default;
			}
			else
			{
				_ = (w1H)(object)o0E3.Default;
			}
		}
		goto IL_04b8;
		IL_060e:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == 0)
				{
				}
			}
			catch
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (i5NX)(object)o0E3.Default;
				}
				catch
				{
					gn = null;
					_003CModule_003E = _003CModule_003E;
					_ = (Et0)o0E3.Default;
					g9Z g9Z = null;
				}
			}
			while ((object)o0E3.Default != null);
		}
		do
		{
			try
			{
				while (obj != null)
				{
					_ = (Gn76)(object)o0E3.Default;
				}
			}
			catch
			{
				try
				{
					_ = (w0A)(object)o0E3.Default;
				}
				catch
				{
					p9B p9B2 = null;
					p9B2 = p9B2;
				}
			}
		}
		while (obj != null);
		if (uIntPtr == 0)
		{
			Zn1b zn1b = (Zn1b)(object)o0E3.Default;
		}
		else
		{
			Zn1b zn1b = null;
		}
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (a9X)(object)o0E3.Default;
				}
				finally
				{
					k0WR = k0WR;
					goto end_IL_06cc;
				}
				end_IL_06cc:;
			}
			catch
			{
				if ((nuint)(UIntPtr)o0E3.Default / uIntPtr == 0)
				{
					_ = (w8W)o0E3.Default;
					_ = (f5R4)(object)o0E3.Default;
					p9B p9B2 = (p9B)(object)o0E3.Default;
				}
			}
		}
		_ = o0E3.Default;
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					_ = (g9Z)(object)o0E3.Default;
					i5NX = (i5NX)(object)o0E3.Default;
				}
			}
		}
		try
		{
			_ = (Pg2c)(object)o0E3.Default;
		}
		catch
		{
			_ = (k0WR)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Dg19)(object)o0E3.Default;
		}
		_ = (Hi84)(object)o0E3.Default;
		return;
		IL_04b8:
		try
		{
			try
			{
				do
				{
					et = (Et0)o0E3.Default;
					o0E = null;
					Zn1b zn1b = (Zn1b)(object)o0E3.Default;
					zn1b = zn1b;
					_ = o0E3.Default;
				}
				while (obj != null);
			}
			catch
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Tf67)(object)o0E3.Default;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					i5NX = i5NX;
				}
				else
				{
					_ = o0E3.Default;
				}
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			else
			{
				w8W w8W = w8W;
				w8W = w8W;
			}
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Et0)o0E3.Default;
				}
			}
			else
			{
				k4C9 k4C = null;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					o0E = o0E;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (k0WR)(object)o0E3.Default;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
			if (unchecked((nuint)default(UIntPtr)) / uIntPtr != 0)
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				finally
				{
					hi = hi;
					goto IL_060e;
				}
			}
			hi = null;
			hi = hi;
		}
		goto IL_060e;
	}

	static void w9Y()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		try
		{
			_ = (p9B)(object)o0E3.Default;
			_ = (f5R4)(object)o0E3.Default;
			_ = (Gn76)(object)o0E3.Default;
			dg = dg;
			dg = dg;
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			_ = o0E3.Default;
		}
		catch
		{
			x4N = x4N;
			x4N = x4N;
			_003CModule_003E _003CModule_003E = null;
			_003CModule_003E = _003CModule_003E;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		try
		{
			while (true)
			{
				_ = (Zn1b)(object)o0E3.Default;
				o0E = o0E3.Default;
				pg2c = null;
				pg2c = pg2c;
				if ((object)o0E3.Default == null)
				{
					obj3 = obj3;
					if (obj3 == null)
					{
						break;
					}
				}
			}
		}
		finally
		{
			num = (UIntPtr)o0E3.Default;
			if (num == 0)
			{
				_ = (Sf06)(object)o0E3.Default;
			}
			goto IL_00cd;
		}
		IL_090f:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			_ = (p9B)(object)o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		do
		{
			a9X = a9X;
		}
		while (obj3 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			dg = dg;
		}
		Hi84 hi = hi;
		_ = (k4C9)(object)o0E3.Default;
		a9X = a9X;
		if (checked(unchecked((nuint)(UIntPtr)o0E3.Default) - (unchecked((nuint)(UIntPtr)o0E3.Default) - num) - num) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (g9Z)(object)o0E3.Default;
				}
			}
			else
			{
				_ = o0E3.Default;
			}
			goto IL_09e9;
		}
		try
		{
			_ = (Tf67)(object)o0E3.Default;
		}
		finally
		{
			while (obj3 != null)
			{
				p9B p9B2 = (p9B)(object)o0E3.Default;
				p9B2 = p9B2;
			}
			goto IL_09e9;
		}
		IL_0792:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		try
		{
			try
			{
				pg2c = pg2c;
			}
			catch
			{
				sf = null;
			}
			finally
			{
				while (obj3 != null)
				{
					sf = sf;
				}
				goto end_IL_0793;
			}
			end_IL_0793:;
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					hi = null;
				}
			}
			finally
			{
				try
				{
					Tf67 tf = null;
				}
				catch
				{
					_ = (Hi84)(object)o0E3.Default;
					_ = (w1H)(object)o0E3.Default;
					k4C = (k4C9)(object)o0E3.Default;
					w1H = (w1H)(object)o0E3.Default;
				}
				goto IL_080d;
			}
		}
		IL_00cd:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		if (num == 0)
		{
			if (checked(unchecked((nuint)(UIntPtr)o0E3.Default) * num) == 0)
			{
				if (num == 0)
				{
					k0WR = k0WR;
					k0WR = null;
				}
				else
				{
					_ = (Sf06)(object)o0E3.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (w0A)(object)o0E3.Default;
			}
		}
		else
		{
			while (obj3 != null)
			{
				do
				{
					hi = (Hi84)(object)o0E3.Default;
					hi = hi;
				}
				while (obj3 != null);
			}
		}
		sf = sf;
		sf = sf;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
			{
				_003CModule_003E _003CModule_003E = null;
				_ = (Sf06)(object)o0E3.Default;
			}
		}
		else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
			while (obj3 != null)
			{
				tf = tf;
				tf = tf;
			}
		}
		try
		{
			_ = (Dg19)(object)o0E3.Default;
		}
		catch
		{
			while ((object)o0E3.Default != null)
			{
				do
				{
					w1H = w1H;
					w1H = null;
				}
				while (obj3 != null);
			}
		}
		num = default(UIntPtr);
		nuint num2 = checked(num + unchecked(checked(num + unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default)) / num) + (unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default))) / (nuint)(UIntPtr)o0E3.Default;
		nuint num3;
		nuint num4;
		checked
		{
			num3 = num + unchecked((nuint)(UIntPtr)o0E3.Default);
			num4 = num;
		}
		UIntPtr num5 = (UIntPtr)o0E3.Default;
		UIntPtr num6 = (UIntPtr)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		checked
		{
			nuint num7 = unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default);
			num = default(UIntPtr);
			if (num2 * (num3 - (num4 * (unchecked((nuint)num5) * (unchecked((nuint)num6) + unchecked(checked(num7 + num * num) / num))) - unchecked(num / num) + unchecked((nuint)(UIntPtr)o0E3.Default) - num) * unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
			{
				if (unchecked((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u))
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				else
				{
					Zn1b obj7 = (Zn1b)(object)o0E3.Default;
					zn1b = (Zn1b)(object)o0E3.Default;
					zn1b = obj7;
					_ = (_003CModule_003E)(object)o0E3.Default;
					_ = (Dg19)(object)o0E3.Default;
					_ = (w1H)(object)o0E3.Default;
				}
			}
			else
			{
				do
				{
					a9X = (a9X)(object)o0E3.Default;
					a9X = a9X;
				}
				while (obj3 != null);
			}
			do
			{
				try
				{
					_ = (Hi84)(object)o0E3.Default;
				}
				finally
				{
					if (num == 0)
					{
						_ = (Gn76)(object)o0E3.Default;
					}
					continue;
				}
			}
			while ((object)o0E3.Default != null);
			_ = (f5R4)(object)o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				Et0 obj8 = (Et0)o0E3.Default;
				et = (Et0)o0E3.Default;
				et = obj8;
			}
			else
			{
				pg2c = null;
			}
		}
		catch
		{
			f5R = (f5R4)(object)o0E3.Default;
			f5R = f5R;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		try
		{
			try
			{
				_ = (Sf06)(object)o0E3.Default;
				w0A = w0A;
				w0A = w0A;
				g9Z = null;
				g9Z = null;
			}
			finally
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
				goto end_IL_03c6;
			}
			end_IL_03c6:;
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gn = (Gn76)(object)o0E3.Default;
					gn = null;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gn = gn;
				}
			}
			goto IL_0440;
		}
		IL_04fe:
		do
		{
			try
			{
				do
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				try
				{
					_ = (Gn76)(object)o0E3.Default;
				}
				catch
				{
					pg2c = pg2c;
					w0A = (w0A)(object)o0E3.Default;
					k0WR = k0WR;
				}
				continue;
			}
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		while ((object)o0E3.Default != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				o0E = o0E3.Default;
				continue;
			}
			et = et;
			zn1b = zn1b;
			w8W = w8W;
			w8W = default(w8W);
			_ = (a9X)(object)o0E3.Default;
		}
		do
		{
			if (num / num != 0)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (a9X)(object)o0E3.Default;
				}
				else
				{
					w0A = w0A;
				}
			}
			else
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		while (obj3 != null);
		try
		{
			try
			{
				o0E = o0E3.Default;
			}
			catch
			{
				do
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				gn = gn;
				_ = (p9B)(object)o0E3.Default;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
				et = et;
			}
			else
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
					pg2c = null;
				}
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Gn76)(object)o0E3.Default;
			}
			else
			{
				g9Z = (g9Z)(object)o0E3.Default;
			}
		}
		finally
		{
			do
			{
				sf = null;
				_ = (Tf67)(object)o0E3.Default;
				_ = (Gn76)(object)o0E3.Default;
			}
			while (obj3 != null);
			goto IL_06e9;
		}
		IL_0440:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w1H)(object)o0E3.Default;
				}
				catch
				{
					_ = (g9Z)(object)o0E3.Default;
				}
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				w0A = w0A;
			}
		}
		else
		{
			_ = (x4N6)(object)o0E3.Default;
		}
		if (num == 0)
		{
			nuint num8 = num;
			num = default(UIntPtr);
			if (checked(num8 + (num + num)) == 0)
			{
				try
				{
					o0E = null;
				}
				catch
				{
					a9X = a9X;
				}
			}
		}
		try
		{
			w0A = w0A;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				finally
				{
					_ = (x4N6)(object)o0E3.Default;
					_ = (_003CModule_003E)(object)o0E3.Default;
					goto end_IL_04d2;
				}
				end_IL_04d2:;
			}
			finally
			{
				goto IL_04fe;
			}
		}
		IL_06e9:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = o0E3.Default;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Gn76)(object)o0E3.Default;
					_ = (Sf06)(object)o0E3.Default;
				}
			}
		}
		try
		{
			try
			{
				x4N = (x4N6)(object)o0E3.Default;
			}
			finally
			{
				w1H = (w1H)(object)o0E3.Default;
				goto end_IL_072c;
			}
			end_IL_072c:;
		}
		finally
		{
			if (num / num == 0)
			{
				k4C9 obj17 = (k4C9)(object)o0E3.Default;
				k4C = k4C;
				k4C = obj17;
				goto IL_0792;
			}
			try
			{
				pg2c = (Pg2c)(object)o0E3.Default;
			}
			finally
			{
				_ = o0E3.Default;
				goto IL_0792;
			}
		}
		IL_09e9:
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (w8W)o0E3.Default;
		}
		else
		{
			_ = (k4C9)(object)o0E3.Default;
		}
		checked
		{
			if (num == 0)
			{
				pg2c = pg2c;
			}
			else
			{
				nuint num9 = num;
				nuint num10 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)o0E3.Default);
				UIntPtr num11 = unchecked((UIntPtr)o0E3.Default);
				num = default(UIntPtr);
				if (num9 - (num10 + unchecked((nuint)num11 / num)) == 0)
				{
					do
					{
						a9X = null;
					}
					while ((object)o0E3.Default != null);
				}
			}
			_ = (_003CModule_003E)(object)o0E3.Default;
		}
		try
		{
			try
			{
				if ((nuint)(UIntPtr)o0E3.Default / num == 0)
				{
					_003CModule_003E _003CModule_003E = null;
				}
				return;
			}
			finally
			{
				try
				{
					_ = (a9X)(object)o0E3.Default;
					return;
				}
				finally
				{
					_ = (Et0)o0E3.Default;
					f5R = f5R;
					w0A = w0A;
					_ = (Pg2c)(object)o0E3.Default;
					return;
				}
			}
		}
		finally
		{
			_ = (g9Z)(object)o0E3.Default;
			w1H = null;
			return;
		}
		IL_080d:
		k4C = k4C;
		checked
		{
			if ((num - unchecked((nuint)(UIntPtr)o0E3.Default)) * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					w1H = w1H;
				}
				else
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						hi = hi;
					}
					else
					{
						_ = (_003CModule_003E)(object)o0E3.Default;
					}
				}
			}
			else
			{
				try
				{
					o0E = o0E;
				}
				catch
				{
					try
					{
						g9Z = g9Z;
					}
					catch
					{
						_ = (Hi84)(object)o0E3.Default;
					}
				}
			}
		}
		try
		{
			while (obj3 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				else
				{
					x4N = x4N;
				}
			}
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					k4C = null;
					_ = (Gn76)(object)o0E3.Default;
				}
				catch
				{
					w1H = w1H;
				}
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			else
			{
				k4C = k4C;
			}
			goto IL_090f;
		}
	}

	static void Tj2()
	{
		o0E3 o0E = o0E;
		o0E = o0E;
		_ = (Sf06)(object)o0E3.Default;
		Gn76 obj = (Gn76)(object)o0E3.Default;
		Gn76 gn = gn;
		gn = obj;
		UIntPtr num = (UIntPtr)o0E3.Default;
		nuint num2 = default(UIntPtr);
		checked
		{
			num2 = unchecked((nuint)num) + num2 + num2;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			o0E = null;
		}
		f5R4 f5R = (f5R4)(object)o0E3.Default;
		f5R = f5R;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		while ((object)o0E3.Default != null)
		{
			try
			{
				k0WR = null;
				k0WR = null;
			}
			catch
			{
				et = default(Et0);
				et = et;
				et = et;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					w8W obj3 = (w8W)o0E3.Default;
					w8W = (w8W)o0E3.Default;
					w8W = obj3;
				}
				continue;
			}
		}
		object obj4 = null;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
			try
			{
				while (obj4 != null)
				{
					w0A = (w0A)(object)o0E3.Default;
					w0A = w0A;
				}
			}
			finally
			{
				w0A = w0A;
				goto end_IL_00e8;
			}
			end_IL_00e8:;
		}
		catch
		{
			_ = (Et0)o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		while (obj4 != null)
		{
			do
			{
				if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
				{
					o0E = o0E3.Default;
					_ = (w1H)(object)o0E3.Default;
					w1H obj6 = (w1H)(object)o0E3.Default;
					w1H = w1H;
					w1H = obj6;
				}
				else
				{
					et = et;
				}
			}
			while (obj4 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		else
		{
			while ((object)o0E3.Default != null)
			{
				num2 = default(UIntPtr);
				if (num2 / (nuint)(UIntPtr)o0E3.Default / num2 == 0)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
		}
		Dg19 dg = dg;
		dg = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				finally
				{
					w1H = null;
					goto IL_022f;
				}
			}
			try
			{
				i5NX = (i5NX)(object)o0E3.Default;
				i5NX = null;
			}
			catch
			{
				et = et;
			}
		}
		goto IL_022f;
		IL_0671:
		if (num2 == 0)
		{
			while ((object)o0E3.Default != null)
			{
				dg = (((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u) ? dg : null);
			}
		}
		else
		{
			_ = (Hi84)(object)o0E3.Default;
		}
		try
		{
			_ = (g9Z)(object)o0E3.Default;
		}
		finally
		{
			a9X a9X = (a9X)(object)o0E3.Default;
			goto IL_06cb;
		}
		IL_04df:
		while ((object)o0E3.Default != null)
		{
			_ = (Pg2c)(object)o0E3.Default;
		}
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while ((object)o0E3.Default != null)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)o0E3.Default) - num2 == 0)
					{
						_003CModule_003E obj8 = (_003CModule_003E)(object)o0E3.Default;
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = obj8;
					}
					else
					{
						gn = gn;
					}
				}
				catch
				{
					try
					{
						_ = (f5R4)(object)o0E3.Default;
						Tf67 tf = (Tf67)(object)o0E3.Default;
						tf = tf;
						_ = (x4N6)(object)o0E3.Default;
						_ = (i5NX)(object)o0E3.Default;
					}
					catch
					{
						_ = (w0A)(object)o0E3.Default;
					}
				}
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					Sf06 sf = sf;
					sf = sf;
				}
				else
				{
					_ = (Tf67)(object)o0E3.Default;
				}
			}
			else
			{
				g9Z g9Z = null;
			}
		}
		else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			while (obj4 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B2);
		do
		{
			p9B2 = p9B2;
			p9B2 = p9B2;
		}
		while (obj4 != null);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		try
		{
			if (checked(num2 * num2) == 0)
			{
				while (obj4 != null)
				{
					Tf67 tf = (Tf67)(object)o0E3.Default;
				}
			}
			else
			{
				w8W = w8W;
			}
		}
		finally
		{
			while (obj4 != null)
			{
				try
				{
					_ = (x4N6)(object)o0E3.Default;
				}
				finally
				{
					w1H = w1H;
					k4C = k4C;
					gn = gn;
					continue;
				}
			}
			goto IL_0671;
		}
		IL_022f:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			_ = o0E3.Default;
		}
		while (true)
		{
			if ((object)o0E3.Default != null)
			{
				try
				{
					k4C = (k4C9)(object)o0E3.Default;
					k4C = k4C;
				}
				catch
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		if (num2 == 0)
		{
			try
			{
				Hi84 hi = hi;
				hi = hi;
			}
			catch
			{
				try
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				finally
				{
					_ = (k4C9)(object)o0E3.Default;
					goto end_IL_029f;
				}
				end_IL_029f:;
			}
		}
		else
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
				do
				{
					g9Z = g9Z;
					g9Z = g9Z;
				}
				while (obj4 != null);
			}
			else
			{
				gn = null;
			}
		}
		while ((object)o0E3.Default != null)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					et = et;
				}
				catch
				{
					f5R = null;
					_ = (a9X)(object)o0E3.Default;
				}
			}
		}
		if (checked(num2 * (unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked(checked((unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)o0E3.Default)) * unchecked((nuint)(UIntPtr)o0E3.Default)) / unchecked((nuint)default(UIntPtr))))) == 0)
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Et0)o0E3.Default;
				}
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
				while (obj4 != null)
				{
					a9X = a9X;
					a9X = a9X;
					_ = (Dg19)(object)o0E3.Default;
					_ = (Et0)o0E3.Default;
				}
				goto IL_03be;
			}
		}
		_ = (_003CModule_003E)(object)o0E3.Default;
		goto IL_03be;
		IL_06cb:
		try
		{
			p9B2 = p9B2;
		}
		catch
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (w0A)(object)o0E3.Default;
				}
				else
				{
					k4C = k4C;
				}
			}
			while (obj4 != null);
		}
		try
		{
			try
			{
				do
				{
					w1H = null;
					_ = (Sf06)(object)o0E3.Default;
					_ = (Sf06)(object)o0E3.Default;
					_ = (Dg19)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			finally
			{
				try
				{
					_ = (w1H)(object)o0E3.Default;
				}
				catch
				{
					i5NX = i5NX;
				}
				goto end_IL_0707;
			}
			end_IL_0707:;
		}
		finally
		{
			do
			{
				try
				{
					k0WR = k0WR;
				}
				catch
				{
					dg = (Dg19)(object)o0E3.Default;
					i5NX = (i5NX)(object)o0E3.Default;
					_ = (Tf67)(object)o0E3.Default;
				}
			}
			while (obj4 != null);
			goto IL_0798;
		}
		IL_03be:
		_ = (Gn76)(object)o0E3.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				f5R = null;
			}
			catch
			{
				_ = (Hi84)(object)o0E3.Default;
			}
		}
		else
		{
			_ = (g9Z)(object)o0E3.Default;
		}
		while ((object)o0E3.Default != null)
		{
			k0WR = k0WR;
		}
		_ = (k4C9)(object)o0E3.Default;
		do
		{
			g9Z g9Z = (g9Z)(object)o0E3.Default;
		}
		while (obj4 != null);
		w8W = w8W;
		_ = (f5R4)(object)o0E3.Default;
		num2 = default(UIntPtr);
		if (checked(num2 + (num2 + (num2 + num2))) == 0)
		{
			while (obj4 != null)
			{
				o0E = o0E3.Default;
			}
			goto IL_04df;
		}
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				Pg2c pg2c = null;
				pg2c = pg2c;
				_ = (Dg19)(object)o0E3.Default;
				_ = (p9B)(object)o0E3.Default;
			}
			else
			{
				w8W = default(w8W);
				w8W = w8W;
			}
		}
		finally
		{
			while (obj4 != null)
			{
				_ = (w8W)o0E3.Default;
			}
			goto IL_04df;
		}
		IL_0798:
		_ = (Gn76)(object)o0E3.Default;
		_ = (Tf67)(object)o0E3.Default;
		_ = (p9B)(object)o0E3.Default;
		f5R = (f5R4)(object)o0E3.Default;
	}
}
