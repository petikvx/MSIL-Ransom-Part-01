using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bm4r;
using Cr4;
using Ds3;
using Jo7k;
using Kc9;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Sd9;
using Ti18;
using Wf0t;
using Yf06;
using Yn19;
using Yn6o;
using b3YP;
using c9S;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace i1QX;

[DesignerGenerated]
public class f1D8 : Form
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
			EventHandler eventHandler = Dd2r;
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

	public f1D8()
	{
		Qd67();
	}

	[DebuggerNonUserCode]
	protected override void Qi41(bool Hs34)
	{
		try
		{
			if (Hs34 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Hs34);
		}
	}

	[DebuggerStepThrough]
	private void Qd67()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		char[] char_ = o1W.char_0;
		int num = 12;
		while (true)
		{
			Button1 = new Button();
			Button2 = new Button();
			txtUsername = new TextBox();
			num = 40;
			while (true)
			{
				txtPassword = new TextBox();
				Label1 = new Label();
				Label2 = new Label();
				num = 20;
				while (true)
				{
					Label3 = new Label();
					((Control)this).SuspendLayout();
					((ButtonBase)Button1).set_BackColor(Color.FromArgb(128, 128, 255));
					num = 31;
					while (true)
					{
						((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
						((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 7;
						while (true)
						{
							((Control)Button1).set_ForeColor(Color.White);
							((Control)Button1).set_Location(new Point(48, 137));
							num = 28;
							while (true)
							{
								((Control)Button1).set_Name("Button1");
								((Control)Button1).set_Size(new Size(84, 29));
								num = 8;
								while (true)
								{
									((Control)Button1).set_TabIndex(0);
									((ButtonBase)Button1).set_Text("Login");
									num = 25;
									while (true)
									{
										((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
										((ButtonBase)Button2).set_BackColor(Color.FromArgb(128, 128, 255));
										num = 17;
										while (true)
										{
											((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
											((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 42;
											while (true)
											{
												((Control)Button2).set_ForeColor(Color.White);
												((Control)Button2).set_Location(new Point(149, 137));
												num = 23;
												while (true)
												{
													((Control)Button2).set_Name("Button2");
													((Control)Button2).set_Size(new Size(84, 29));
													num = 26;
													while (true)
													{
														((Control)Button2).set_TabIndex(1);
														((ButtonBase)Button2).set_Text("Cancel");
														num = 19;
														while (true)
														{
															((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
															((Control)txtUsername).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 39;
															while (true)
															{
																((TextBoxBase)txtUsername).set_ForeColor(Color.Purple);
																((Control)txtUsername).set_Location(new Point(139, 57));
																num = 2;
																while (true)
																{
																	((Control)txtUsername).set_Name("txtUsername");
																	((Control)txtUsername).set_Size(new Size(104, 23));
																	num = 14;
																	while (true)
																	{
																		((Control)txtUsername).set_TabIndex(2);
																		txtUsername.set_TextAlign((HorizontalAlignment)2);
																		num = 0;
																		while (true)
																		{
																			((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 34;
																			while (true)
																			{
																				((TextBoxBase)txtPassword).set_ForeColor(Color.Purple);
																				((Control)txtPassword).set_Location(new Point(139, 96));
																				num = 37;
																				while (true)
																				{
																					((Control)txtPassword).set_Name("txtPassword");
																					while (true)
																					{
																						txtPassword.set_PasswordChar('#');
																						num = 11;
																						while (true)
																						{
																							((Control)txtPassword).set_Size(new Size(104, 23));
																							((Control)txtPassword).set_TabIndex(3);
																							num = 29;
																							while (true)
																							{
																								txtPassword.set_TextAlign((HorizontalAlignment)2);
																								Label1.set_AutoSize(true);
																								num = 16;
																								while (true)
																								{
																									((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																									num = 24;
																									while (true)
																									{
																										((Control)Label1).set_ForeColor(Color.White);
																										((Control)Label1).set_Location(new Point(46, 56));
																										num = 10;
																										while (true)
																										{
																											((Control)Label1).set_Name("Label1");
																											((Control)Label1).set_Size(new Size(91, 17));
																											num = 6;
																											while (true)
																											{
																												((Control)Label1).set_TabIndex(4);
																												Label1.set_Text("Username :");
																												num = 1;
																												while (true)
																												{
																													Label2.set_AutoSize(true);
																													((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																													num = 33;
																													while (true)
																													{
																														((Control)Label2).set_ForeColor(Color.White);
																														((Control)Label2).set_Location(new Point(46, 102));
																														num = 27;
																														while (true)
																														{
																															((Control)Label2).set_Name("Label2");
																															((Control)Label2).set_Size(new Size(87, 17));
																															num = 30;
																															while (true)
																															{
																																((Control)Label2).set_TabIndex(5);
																																Label2.set_Text("Password :");
																																num = 4;
																																while (true)
																																{
																																	Label3.set_AutoSize(true);
																																	((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																	num = 5;
																																	while (true)
																																	{
																																		((Control)Label3).set_ForeColor(Color.White);
																																		((Control)Label3).set_Location(new Point(108, 22));
																																		num = 32;
																																		while (true)
																																		{
																																			((Control)Label3).set_Name("Label3");
																																			((Control)Label3).set_Size(new Size(48, 17));
																																			num = 35;
																																			while (true)
																																			{
																																				((Control)Label3).set_TabIndex(6);
																																				Label3.set_Text("Login");
																																				num = 22;
																																				while (true)
																																				{
																																					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																					num = 41;
																																					while (true)
																																					{
																																						((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																						((Form)this).set_ClientSize(new Size(283, 189));
																																						switch (char_[525])
																																						{
																																						case '෦':
																																							break;
																																						case '\u0dd3':
																																							goto end_IL_000e;
																																						case '\u0de0':
																																							goto end_IL_00fb;
																																						case '\u0ddd':
																																							goto end_IL_011f;
																																						case 'ෂ':
																																							goto end_IL_0140;
																																						case 'ව':
																																						case 'ශ':
																																							goto end_IL_0169;
																																						case '\u0ddb':
																																							goto end_IL_0192;
																																						case '\u0dd8':
																																							goto end_IL_01bf;
																																						case '\u0dde':
																																							goto end_IL_01df;
																																						case '\u0dbe':
																																							goto end_IL_0208;
																																						case 'ස':
																																							goto end_IL_0231;
																																						case '\u0dc7':
																																							goto end_IL_025f;
																																						case '\u0dd5':
																																							goto end_IL_027f;
																																						case '\u0dcd':
																																							goto end_IL_02a7;
																																						case '\u0dda':
																																							goto end_IL_02d0;
																																						case '\u0dc8':
																																							goto end_IL_02f2;
																																						case '෨':
																																							goto end_IL_030f;
																																						case '\u0de2':
																																							goto end_IL_0334;
																																						case '\u0ddf':
																																							goto end_IL_0346;
																																						case 'ල':
																																							goto end_IL_0358;
																																						case '\u0dcb':
																																							goto end_IL_0384;
																																						case '\u0dbf':
																																							goto end_IL_03a6;
																																						case '\u0de4':
																																							goto end_IL_03c2;
																																						case '\u0dd0':
																																							goto end_IL_03eb;
																																						case '\u0dd7':
																																							goto end_IL_0416;
																																						case '\u0dd4':
																																							goto end_IL_0444;
																																						case '෧':
																																							goto end_IL_0465;
																																						case '\u0dce':
																																							goto end_IL_048e;
																																						case '\u0dd6':
																																							goto end_IL_04bd;
																																						case 'ළ':
																																							goto end_IL_04eb;
																																						case '\u0dd9':
																																							goto end_IL_051b;
																																						case 'හ':
																																							goto end_IL_053c;
																																						case '\u0ddc':
																																							goto end_IL_0564;
																																						case '\u0dd1':
																																							goto end_IL_0590;
																																						case '\u0de5':
																																							goto end_IL_05bd;
																																						default:
																																							goto end_IL_05f2;
																																						case '\u0dd2':
																																							((Control)this).get_Controls().Add((Control)(object)Label3);
																																							((Control)this).get_Controls().Add((Control)(object)Label2);
																																							num = 13;
																																							goto case '\u0dca';
																																						case '\u0dca':
																																							((Control)this).get_Controls().Add((Control)(object)Label1);
																																							((Control)this).get_Controls().Add((Control)(object)txtPassword);
																																							num = 36;
																																							goto case '\u0de1';
																																						case '\u0de1':
																																							((Control)this).get_Controls().Add((Control)(object)txtUsername);
																																							((Control)this).get_Controls().Add((Control)(object)Button2);
																																							num = 38;
																																							goto case '\u0de3';
																																						case '\u0de3':
																																							((Control)this).get_Controls().Add((Control)(object)Button1);
																																							((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																							num = 15;
																																							goto case '\u0dcc';
																																						case '\u0dcc':
																																							((Control)this).set_Name("Login");
																																							goto case '\u0dcf';
																																						case '\u0dcf':
																																							((Form)this).set_StartPosition((FormStartPosition)1);
																																							((Form)this).set_Text("Login");
																																							num = 9;
																																							goto case 'ෆ';
																																						case 'ෆ':
																																							((Control)this).ResumeLayout(false);
																																							((Control)this).PerformLayout();
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
																																				end_IL_011f:
																																				break;
																																			}
																																			continue;
																																			end_IL_0140:
																																			break;
																																		}
																																		continue;
																																		end_IL_0169:
																																		break;
																																	}
																																	continue;
																																	end_IL_0192:
																																	break;
																																}
																																continue;
																																end_IL_01bf:
																																break;
																															}
																															continue;
																															end_IL_01df:
																															break;
																														}
																														continue;
																														end_IL_0208:
																														break;
																													}
																													continue;
																													end_IL_0231:
																													break;
																												}
																												continue;
																												end_IL_025f:
																												break;
																											}
																											continue;
																											end_IL_027f:
																											break;
																										}
																										continue;
																										end_IL_02a7:
																										break;
																									}
																									continue;
																									end_IL_02d0:
																									break;
																								}
																								continue;
																								end_IL_02f2:
																								break;
																							}
																							continue;
																							end_IL_030f:
																							break;
																						}
																						continue;
																						end_IL_0334:
																						break;
																					}
																					continue;
																					end_IL_0346:
																					break;
																				}
																				continue;
																				end_IL_0358:
																				break;
																			}
																			continue;
																			end_IL_0384:
																			break;
																		}
																		continue;
																		end_IL_03a6:
																		break;
																	}
																	continue;
																	end_IL_03c2:
																	break;
																}
																continue;
																end_IL_03eb:
																break;
															}
															continue;
															end_IL_0416:
															break;
														}
														continue;
														end_IL_0444:
														break;
													}
													continue;
													end_IL_0465:
													break;
												}
												continue;
												end_IL_048e:
												break;
											}
											continue;
											end_IL_04bd:
											break;
										}
										continue;
										end_IL_04eb:
										break;
									}
									continue;
									end_IL_051b:
									break;
								}
								continue;
								end_IL_053c:
								break;
							}
							continue;
							end_IL_0564:
							break;
						}
						continue;
						end_IL_0590:
						break;
					}
					continue;
					end_IL_05bd:
					break;
				}
				continue;
				end_IL_05f2:
				break;
			}
		}
	}

	private void Dd2r(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0))
		{
			MessageBox.Show("Login Successfully...!");
			c7G c7G = new c7G();
			((Control)c7G).Show();
			((Control)this).Hide();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password...!");
		}
	}

	static void Sj3a()
	{
		a1HS obj = (a1HS)(object)Ns87.Default;
		a1HS a1HS = null;
		a1HS = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq90 xq);
		while (true)
		{
			obj2 = obj2;
			if (obj2 == null)
			{
				break;
			}
			xq = xq;
			xq = xq;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (c7G)(object)Ns87.Default;
			}
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					sa = sa;
					sa = sa;
				}
				finally
				{
					_ = (q4PG)(object)Ns87.Default;
					continue;
				}
			}
		}
		UIntPtr num = (UIntPtr)Ns87.Default;
		nuint num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ea3q ea3q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ns87 ns);
		q4PG q4PG;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (unchecked((nuint)num) - num2 != 0 || num2 != 0)
			{
			}
			try
			{
				try
				{
					try
					{
						ty = ty;
						ty = ty;
					}
					finally
					{
						a1HS = null;
						goto end_IL_00a9;
					}
					end_IL_00a9:;
				}
				finally
				{
					while (obj2 != null)
					{
						_ = (Cr17)(object)Ns87.Default;
					}
					goto end_IL_00a8;
				}
				end_IL_00a8:;
			}
			catch
			{
				while ((object)Ns87.Default != null)
				{
					try
					{
						_ = (_003CModule_003E)(object)Ns87.Default;
					}
					catch
					{
						ea3q = null;
						ea3q = ea3q;
					}
				}
			}
			while (obj2 != null)
			{
				try
				{
					_ = (c7G)(object)Ns87.Default;
					_003CModule_003E obj5 = (_003CModule_003E)(object)Ns87.Default;
					_003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
					_003CModule_003E = obj5;
				}
				catch
				{
					ns = ns;
					ns = ns;
				}
				finally
				{
					if (num2 * num2 == 0)
					{
						q1J = q1J;
						q1J = q1J;
					}
					else
					{
						_ = (o1W)(object)Ns87.Default;
						_ = (q1J3)(object)Ns87.Default;
					}
					continue;
				}
			}
			while ((object)Ns87.Default != null)
			{
				try
				{
					q4PG = (q4PG)(object)Ns87.Default;
					q4PG = q4PG;
				}
				finally
				{
					while (obj2 != null)
					{
						_ = (c7G)(object)Ns87.Default;
					}
					continue;
				}
			}
			_ = (c7G)(object)Ns87.Default;
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (f1D8)(object)Ns87.Default;
		}
		else if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u && (UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			sa = sa;
		}
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr17 cr);
		s5C s5C;
		if (num2 == 0)
		{
			_ = (q4PG)(object)Ns87.Default;
			_ = (c7G)(object)Ns87.Default;
			s5C = null;
			s5C = s5C;
			ty = ty;
		}
		else
		{
			do
			{
				a1HS = (a1HS)(object)Ns87.Default;
				cr = (Cr17)(object)Ns87.Default;
				cr = cr;
				_ = (Cr17)(object)Ns87.Default;
			}
			while (obj2 != null);
		}
		q4PG = null;
		while ((object)Ns87.Default != null)
		{
			try
			{
				sa = sa;
			}
			catch
			{
				a1HS = a1HS;
			}
		}
		try
		{
			try
			{
				f1D8 f1D9 = null;
				f1D9 = f1D9;
			}
			catch
			{
				_ = (_003CModule_003E)(object)Ns87.Default;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				ns = ns;
			}
		}
		if (num2 == 0)
		{
			try
			{
				q1J = null;
			}
			finally
			{
				_ = (Cy1)(object)Ns87.Default;
				goto IL_02f3;
			}
		}
		goto IL_02f3;
		IL_0525:
		Sd5 sd;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (q1C3)(object)Ns87.Default;
					sd = sd;
				}
				catch
				{
					g6EQ = g6EQ;
				}
			}
			catch
			{
				try
				{
					_ = Ns87.Default;
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
				}
			}
		}
		_ = (Cy1)(object)Ns87.Default;
		ns = null;
		try
		{
			try
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					a1HS = a1HS;
					_ = (Cy1)(object)Ns87.Default;
					q1C3 q1C = null;
				}
			}
			catch
			{
				_ = (c7G)(object)Ns87.Default;
			}
		}
		catch
		{
			do
			{
				try
				{
					cr = cr;
				}
				catch
				{
					q1J = q1J;
				}
			}
			while (obj2 != null);
		}
		sa = sa;
		sd = sd;
		Cy1 cy = (Cy1)(object)Ns87.Default;
		cy = cy;
		cr = cr;
		ty = (Ty3)(object)Ns87.Default;
		_ = (Cy1)(object)Ns87.Default;
		ea3q = ea3q;
		try
		{
			_ = (k2GS)(object)Ns87.Default;
			return;
		}
		finally
		{
			_ = (q1J3)(object)Ns87.Default;
			return;
		}
		IL_02f3:
		sd = null;
		sd = null;
		if (num2 == 0)
		{
			Es6d es6d = es6d;
			es6d = null;
			goto IL_0361;
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			q1C3 q1C = q1C;
			q1C = q1C;
		}
		finally
		{
			try
			{
				_ = (Xq90)(object)Ns87.Default;
			}
			catch
			{
				ns = null;
				_ = (q1J3)(object)Ns87.Default;
				_ = (q1J3)(object)Ns87.Default;
			}
			goto IL_0361;
		}
		IL_0361:
		sd = sd;
		if (num2 == 0)
		{
			cr = cr;
			_ = (Cy1)(object)Ns87.Default;
			g6EQ = g6EQ;
			g6EQ = g6EQ;
			_ = (o1W)(object)Ns87.Default;
		}
		else
		{
			_ = Ns87.Default;
			_ = (Xq90)(object)Ns87.Default;
			_ = (Cy1)(object)Ns87.Default;
			_ = Ns87.Default;
		}
		s5C = (s5C)(object)Ns87.Default;
		while (obj2 != null)
		{
			Xj06 xj = default(Xj06);
		}
		while (obj2 != null)
		{
			_ = (Ea3q)(object)Ns87.Default;
			Es6d es6d = null;
			q4PG = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS);
		do
		{
			try
			{
				k2GS = (k2GS)(object)Ns87.Default;
				k2GS = k2GS;
			}
			catch
			{
				do
				{
					_ = (k2GS)(object)Ns87.Default;
					k2GS = k2GS;
					_ = (s5C)(object)Ns87.Default;
				}
				while (obj2 != null);
			}
		}
		while ((object)Ns87.Default != null);
		while (obj2 != null)
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					g6EQ = (g6EQ)(object)Ns87.Default;
				}
				finally
				{
					ty = (Ty3)(object)Ns87.Default;
					continue;
				}
			}
			do
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
			while (obj2 != null);
		}
		checked
		{
			try
			{
				try
				{
					num2 = default(UIntPtr);
					nuint num3 = num2 * unchecked((nuint)(UIntPtr)Ns87.Default);
					num2 = default(UIntPtr);
					if ((num3 - num2) * num2 == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
				finally
				{
					if (num2 == 0)
					{
						_ = (c7G)(object)Ns87.Default;
						s5C = s5C;
						_ = (Cr17)(object)Ns87.Default;
					}
					else
					{
						_ = (c7G)(object)Ns87.Default;
					}
					goto end_IL_04a9;
				}
				end_IL_04a9:;
			}
			finally
			{
				_ = (Xq90)(object)Ns87.Default;
				goto IL_0525;
			}
		}
	}
}
