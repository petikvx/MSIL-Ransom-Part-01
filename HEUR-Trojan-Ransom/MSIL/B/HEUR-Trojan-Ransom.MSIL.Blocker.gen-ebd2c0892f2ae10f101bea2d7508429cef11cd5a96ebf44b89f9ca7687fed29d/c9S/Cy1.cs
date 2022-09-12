using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
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
using i1QX;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace c9S;

[DesignerGenerated]
public class Cy1 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d8M;
			Label label = _Label6;
			Label obj = label;
			s5C.int_0[120] = (s5C.int_0[120] ^ s5C.int_0[276]) & 0xDB;
			if (obj != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			char[] char_ = o1W.char_0;
			int num = 0;
			EventHandler eventHandler;
			Label label;
			while (true)
			{
				eventHandler = n8L;
				label = _Label7;
				if (label == null)
				{
					switch (char_[132])
					{
					case 'ꈈ':
						goto IL_0059;
					case 'ꈄ':
						goto IL_0060;
					case 'ꈆ':
						goto IL_0067;
					case 'ꈇ':
					case 'ꈊ':
						goto end_IL_0040;
					case 'ꈉ':
						return;
					}
					continue;
				}
				num = 5;
				goto IL_0059;
				IL_0060:
				_Label7 = value;
				goto IL_0067;
				IL_0067:
				label = _Label7;
				if (label != null)
				{
					num = 4;
					break;
				}
				num = 6;
				return;
				IL_0059:
				((Control)label).remove_Click(eventHandler);
				goto IL_0060;
				continue;
				end_IL_0040:
				break;
			}
			((Control)label).add_Click(eventHandler);
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	public Cy1()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)So8);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		g3L();
	}

	[DebuggerNonUserCode]
	protected override void t3A(bool q0H)
	{
		char[] char_ = o1W.char_0;
		try
		{
			int num = 6;
			while (true)
			{
				IL_0059:
				if (!q0H)
				{
					num = 2;
					goto IL_0052;
				}
				num = 3;
				goto IL_0046;
				IL_004f:
				int num2;
				bool flag = (byte)num2 != 0;
				while (true)
				{
					if (flag)
					{
						switch (char_[22])
						{
						case '籌':
							break;
						case '籏':
							goto end_IL_0041;
						case '籎':
							goto IL_0052;
						default:
							goto IL_0059;
						case '籐':
							components.Dispose();
							num = 5;
							return;
						case '籍':
						case '籑':
						case '籓':
							return;
						}
						continue;
					}
					num = 5;
					return;
					continue;
					end_IL_0041:
					break;
				}
				goto IL_0046;
				IL_0046:
				num2 = ((components != null) ? 1 : 0);
				goto IL_004f;
				IL_0052:
				num2 = 0;
				goto IL_004f;
			}
		}
		finally
		{
			((Form)this).Dispose(q0H);
		}
	}

	[DebuggerStepThrough]
	private void g3L()
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		int[] int_ = s5C.int_0;
		int num = 23;
		while (true)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cy1));
			Label3 = new Label();
			Label6 = new Label();
			num = 33;
			while (true)
			{
				Label7 = new Label();
				while (true)
				{
					PictureBox1 = new PictureBox();
					Label1 = new Label();
					num = 30;
					while (true)
					{
						((ISupportInitialize)PictureBox1).BeginInit();
						((Control)this).SuspendLayout();
						Label3.set_AutoSize(true);
						num = 5;
						while (true)
						{
							((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
							num = 13;
							while (true)
							{
								((Control)Label3).set_ForeColor(Color.White);
								((Control)Label3).set_Location(new Point(364, 27));
								num = 26;
								while (true)
								{
									((Control)Label3).set_Name("Label3");
									((Control)Label3).set_Size(new Size(107, 17));
									num = 11;
									while (true)
									{
										((Control)Label3).set_TabIndex(8);
										Label3.set_Text("About System");
										num = 22;
										while (true)
										{
											Label6.set_AutoSize(true);
											((Control)Label6).set_BackColor(Color.Blue);
											num = 0;
											while (true)
											{
												((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
												num = 34;
												while (true)
												{
													((Control)Label6).set_ForeColor(Color.White);
													((Control)Label6).set_Location(new Point(727, 27));
													num = 18;
													while (true)
													{
														((Control)Label6).set_Name("Label6");
														((Control)Label6).set_Size(new Size(18, 17));
														num = 7;
														while (true)
														{
															((Control)Label6).set_TabIndex(14);
															Label6.set_Text("X");
															num = 19;
															while (true)
															{
																Label7.set_AutoSize(true);
																((Control)Label7).set_BackColor(Color.Blue);
																num = 6;
																while (true)
																{
																	((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																	num = 35;
																	while (true)
																	{
																		((Control)Label7).set_ForeColor(Color.White);
																		((Control)Label7).set_Location(new Point(35, 27));
																		num = 31;
																		while (true)
																		{
																			((Control)Label7).set_Name("Label7");
																			((Control)Label7).set_Size(new Size(92, 17));
																			num = 8;
																			while (true)
																			{
																				((Control)Label7).set_TabIndex(13);
																				Label7.set_Text("Go To Main");
																				int num2 = int_[255];
																				s5C.int_0[71] = (s5C.int_0[71] | s5C.int_0[228]) & 0x3C;
																				switch (num2 - 42084)
																				{
																				case 8:
																					break;
																				case 31:
																					goto end_IL_000e;
																				case 35:
																					goto end_IL_00f3;
																				case 6:
																					goto end_IL_011e;
																				case 19:
																					goto end_IL_0147;
																				case 7:
																					goto end_IL_0169;
																				case 18:
																					goto end_IL_0189;
																				case 34:
																					goto end_IL_01ab;
																				case 0:
																					goto end_IL_01d3;
																				case 22:
																					goto end_IL_01ff;
																				case 11:
																					goto end_IL_0221;
																				case 26:
																					goto end_IL_0241;
																				case 13:
																					goto end_IL_0262;
																				case 5:
																					goto end_IL_028b;
																				case 30:
																					goto end_IL_02b7;
																				case 27:
																					goto end_IL_02d9;
																				case 33:
																					goto end_IL_02fa;
																				default:
																					goto end_IL_0315;
																				case 14:
																					PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
																					((Control)PictureBox1).set_Location(new Point(189, 104));
																					num = 9;
																					goto case 9;
																				case 9:
																					((Control)PictureBox1).set_Name("PictureBox1");
																					((Control)PictureBox1).set_Size(new Size(469, 346));
																					num = 25;
																					goto case 25;
																				case 25:
																					PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
																					PictureBox1.set_TabIndex(15);
																					num = 28;
																					goto case 28;
																				case 28:
																					PictureBox1.set_TabStop(false);
																					Label1.set_AutoSize(true);
																					num = 21;
																					goto case 21;
																				case 21:
																					((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
																					num = 10;
																					goto case 10;
																				case 10:
																					((Control)Label1).set_ForeColor(Color.White);
																					((Control)Label1).set_Location(new Point(170, 65));
																					num = 17;
																					goto case 17;
																				case 17:
																					((Control)Label1).set_Name("Label1");
																					((Control)Label1).set_Size(new Size(446, 17));
																					num = 32;
																					goto case 32;
																				case 32:
																					((Control)Label1).set_TabIndex(16);
																					Label1.set_Text("One fully-integrated software solution to manage your entire business");
																					num = 16;
																					goto case 16;
																				case 16:
																					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																					goto case 4;
																				case 4:
																					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																					goto case 12;
																				case 12:
																					num = 29;
																					goto case 29;
																				case 29:
																					((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																					((Form)this).set_ClientSize(new Size(800, 450));
																					num = 20;
																					goto case 20;
																				case 20:
																					((Control)this).get_Controls().Add((Control)(object)Label1);
																					((Control)this).get_Controls().Add((Control)(object)PictureBox1);
																					num = 3;
																					goto case 3;
																				case 3:
																					((Control)this).get_Controls().Add((Control)(object)Label6);
																					((Control)this).get_Controls().Add((Control)(object)Label7);
																					num = 2;
																					goto case 2;
																				case 2:
																					((Control)this).get_Controls().Add((Control)(object)Label3);
																					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																					num = 15;
																					goto case 15;
																				case 15:
																					((Control)this).set_Name("frmBillingDetail");
																					((Form)this).set_StartPosition((FormStartPosition)1);
																					((Form)this).set_Text("frmBillingDetail");
																					num = 1;
																					goto case 1;
																				case 1:
																					((ISupportInitialize)PictureBox1).EndInit();
																					((Control)this).ResumeLayout(false);
																					((Control)this).PerformLayout();
																					num = 24;
																					return;
																				case 24:
																					return;
																				}
																				continue;
																				end_IL_000e:
																				break;
																			}
																			continue;
																			end_IL_00f3:
																			break;
																		}
																		continue;
																		end_IL_011e:
																		break;
																	}
																	continue;
																	end_IL_0147:
																	break;
																}
																continue;
																end_IL_0169:
																break;
															}
															continue;
															end_IL_0189:
															break;
														}
														continue;
														end_IL_01ab:
														break;
													}
													continue;
													end_IL_01d3:
													break;
												}
												continue;
												end_IL_01ff:
												break;
											}
											continue;
											end_IL_0221:
											break;
										}
										continue;
										end_IL_0241:
										break;
									}
									continue;
									end_IL_0262:
									break;
								}
								continue;
								end_IL_028b:
								break;
							}
							continue;
							end_IL_02b7:
							break;
						}
						continue;
						end_IL_02d9:
						break;
					}
					continue;
					end_IL_02fa:
					break;
				}
				continue;
				end_IL_0315:
				break;
			}
		}
	}

	private void n8L(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void d8M(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void So8(object sender, EventArgs e)
	{
	}

	internal static string Xr2(string[] f6T, int x0L, int Md7)
	{
		string text = "";
		int num = x0L;
		while (true)
		{
			int num2 = num;
			s5C.int_0[363] = s5C.int_0[363] & x0L & 0x73;
			if (num2 > Md7)
			{
				break;
			}
			text += f6T[num];
			num = checked(num + 1);
		}
		return text.ToString();
	}

	internal static bool t9R(string m4Q)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(m4Q);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	static void Tn4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				while ((object)Ns87.Default != null)
				{
					num = (num - unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Ns87.Default)) * unchecked((nuint)(UIntPtr)Ns87.Default);
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + num == 0)
					{
						Es6d es6d = null;
						es6d = es6d;
					}
				}
			}
			finally
			{
				_ = (q4PG)(object)Ns87.Default;
				goto IL_0077;
			}
		}
		IL_0077:
		_ = (f1D8)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7G c7G);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				cy = cy;
				cy = null;
			}
		}
		catch
		{
			while ((object)Ns87.Default != null)
			{
				c7G = c7G;
				c7G = c7G;
				sd = null;
				sd = sd;
				a1HS = a1HS;
				a1HS = a1HS;
				q1J = (q1J3)(object)Ns87.Default;
				q1J = q1J;
			}
		}
		finally
		{
			try
			{
				obj2 = null;
			}
			finally
			{
				while (obj2 != null)
				{
					_ = (Ea3q)(object)Ns87.Default;
				}
				goto IL_0118;
			}
		}
		IL_0118:
		_ = (Xj06)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			q1C3 obj3 = (q1C3)(object)Ns87.Default;
			q1C = q1C;
			q1C = obj3;
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					c7G = null;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					goto end_IL_0169;
				}
			}
			while ((object)Ns87.Default != null)
			{
				Sa53 sa = default(Sa53);
				sa = default(Sa53);
			}
			end_IL_0169:;
		}
		catch
		{
			try
			{
				Ty3 ty = ty;
				ty = ty;
			}
			finally
			{
				try
				{
					_ = (Es6d)(object)Ns87.Default;
					_ = (Cy1)(object)Ns87.Default;
					_ = (Ea3q)(object)Ns87.Default;
					sd = null;
				}
				catch
				{
					_ = (f1D8)(object)Ns87.Default;
				}
				goto end_IL_01c6;
			}
			end_IL_01c6:;
		}
		q1C = (q1C3)(object)Ns87.Default;
		_ = (g6EQ)(object)Ns87.Default;
		while (true)
		{
			if (obj2 != null)
			{
				try
				{
					_ = (q1C3)(object)Ns87.Default;
				}
				catch
				{
					q1J = (q1J3)(object)Ns87.Default;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		_ = (Sd5)(object)Ns87.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				UIntPtr num2 = (UIntPtr)Ns87.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num2) * unchecked(checked(unchecked((nuint)default(UIntPtr)) * num * num) / num) == 0)
					{
						_003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
						_ = (s5C)(object)Ns87.Default;
						_ = (Es6d)(object)Ns87.Default;
					}
					else
					{
						c7G = c7G;
					}
				}
			}
		}
		else
		{
			_ = (s5C)(object)Ns87.Default;
		}
		_ = (k2GS)(object)Ns87.Default;
		Xq90 obj7 = (Xq90)(object)Ns87.Default;
		Xq90 xq = null;
		xq = obj7;
		try
		{
			do
			{
				try
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				catch
				{
					a1HS = a1HS;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			_ = (q1C3)(object)Ns87.Default;
			_ = (Xj06)Ns87.Default;
			_ = (g6EQ)(object)Ns87.Default;
			_ = (Ea3q)(object)Ns87.Default;
			goto IL_035a;
		}
		IL_035a:
		_ = (c7G)(object)Ns87.Default;
		_ = (Ea3q)(object)Ns87.Default;
		_ = (Ea3q)(object)Ns87.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					q1J = q1J;
				}
				while (obj2 != null);
			}
			else
			{
				try
				{
					_ = (q4PG)(object)Ns87.Default;
				}
				catch
				{
					_ = (s5C)(object)Ns87.Default;
				}
			}
		}
		else
		{
			while ((object)Ns87.Default != null)
			{
				_ = (q1J3)(object)Ns87.Default;
			}
		}
		_003CModule_003E = null;
		try
		{
			if ((nuint)(UIntPtr)Ns87.Default / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (Cy1)(object)Ns87.Default;
				a1HS = null;
				Xj06 xj = xj;
				xj = xj;
				_ = (q1J3)(object)Ns87.Default;
			}
			else
			{
				_ = (Xq90)(object)Ns87.Default;
			}
		}
		catch
		{
			_ = (s5C)(object)Ns87.Default;
			_ = (Ty3)(object)Ns87.Default;
		}
		num = default(UIntPtr);
		checked
		{
			if ((unchecked((nuint)default(UIntPtr)) - num * num) * unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			else
			{
				while (obj2 != null)
				{
					_ = (q1C3)(object)Ns87.Default;
				}
			}
			try
			{
				q1J = q1J;
			}
			catch
			{
				if (unchecked((UIntPtr)Ns87.Default != (UIntPtr)(nuint)0u))
				{
					try
					{
						a1HS = null;
					}
					finally
					{
						a1HS = (a1HS)(object)Ns87.Default;
						goto end_IL_04a9;
					}
				}
				try
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				catch
				{
					g6EQ g6EQ = (g6EQ)(object)Ns87.Default;
					g6EQ = g6EQ;
				}
				end_IL_04a9:;
			}
			try
			{
				do
				{
					_ = (q4PG)(object)Ns87.Default;
				}
				while ((object)Ns87.Default != null || obj2 != null);
			}
			catch
			{
				nuint num3 = unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				nuint num4 = num - unchecked((nuint)(UIntPtr)Ns87.Default);
				nuint num5 = num;
				num = default(UIntPtr);
				unchecked
				{
					if (num3 / checked(num4 * (num5 * num) + unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
					{
						do
						{
							a1HS = a1HS;
						}
						while ((object)Ns87.Default != null);
					}
					else
					{
						q1J = q1J;
						k2GS k2GS = null;
						k2GS = k2GS;
						_ = Ns87.Default;
						_ = (Ty3)(object)Ns87.Default;
					}
				}
			}
			_ = (c7G)(object)Ns87.Default;
			if (num != 0)
			{
				while ((object)Ns87.Default != null)
				{
					do
					{
						_ = (f1D8)(object)Ns87.Default;
						_ = (Sd5)(object)Ns87.Default;
						_ = (q4PG)(object)Ns87.Default;
					}
					while ((object)Ns87.Default != null);
				}
			}
			while (true)
			{
				if ((object)Ns87.Default != null)
				{
					Ns87 ns = null;
					ns = ns;
					_ = (Cr17)(object)Ns87.Default;
					_ = (c7G)(object)Ns87.Default;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) + num == 0)
			{
				if (num == 0)
				{
					try
					{
						_ = (q1J3)(object)Ns87.Default;
					}
					catch
					{
						_ = (Sa53)Ns87.Default;
						_ = (Ea3q)(object)Ns87.Default;
					}
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr17 cr);
					while (obj2 != null)
					{
						Cr17 obj15 = (Cr17)(object)Ns87.Default;
						cr = cr;
						cr = obj15;
						_ = (Ea3q)(object)Ns87.Default;
					}
				}
			}
			else
			{
				num = default(UIntPtr);
				UIntPtr num6 = num;
				UIntPtr num7 = num;
				UIntPtr num8 = unchecked((UIntPtr)Ns87.Default);
				num = default(UIntPtr);
				if (unchecked((nuint)num6) - unchecked((nuint)num7 / checked(unchecked((nuint)num8) * (num + num))) == 0)
				{
					Ty3 ty = (Ty3)(object)Ns87.Default;
				}
				else if (num == 0)
				{
					sd = sd;
				}
			}
			if (num == 0)
			{
				try
				{
					if (unchecked((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u))
					{
						_ = (q1J3)(object)Ns87.Default;
					}
					else
					{
						cy = cy;
						a1HS = a1HS;
						_ = (g6EQ)(object)Ns87.Default;
						cy = (Cy1)(object)Ns87.Default;
					}
				}
				catch
				{
					while ((object)Ns87.Default != null)
					{
						Sa53 sa = (Sa53)Ns87.Default;
						_ = (Cy1)(object)Ns87.Default;
					}
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out q4PG q4PG);
				while (obj2 != null)
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						xq = xq;
						q4PG = (q4PG)(object)Ns87.Default;
						q4PG = null;
						_ = (s5C)(object)Ns87.Default;
						_ = (Ea3q)(object)Ns87.Default;
					}
					else
					{
						q4PG = q4PG;
					}
				}
			}
			num = default(UIntPtr);
			if (num - num == 0)
			{
			}
		}
	}
}
