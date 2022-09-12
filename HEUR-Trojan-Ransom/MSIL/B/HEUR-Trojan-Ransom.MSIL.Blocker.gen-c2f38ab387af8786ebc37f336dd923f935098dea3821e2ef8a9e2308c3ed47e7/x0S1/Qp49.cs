using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz7;
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
using x9B;

namespace x0S1;

[DesignerGenerated]
public class Qp49 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static Fz0 fz0_0/* Not supported: data(06 7E 45 96 50 0C FD 0D 1B EF 4B 84 95 06 12 3D 9A 92 28 C5 27 34 0F 4E FD D9 B0 05 9D 06 32 D0 79 68 D2 EB FE 7B CB F0 23 C9 B1 CB BE AC 66 EE 7A 62 90 0A A7 6D 18 BE 10 48 75 8E C3 4A 27 B7 DC D2 25 F7 7B 8A E4 D5 E3 9D 0C F9 56 AB 1D 72 CC CC 9C D1 0B 29 C6 20 15 90 15 A2 6C 32 7B 96 F9 51 AF 15 A2 75 F6 16 9C 5B 34 50 99 EF 53 B2 85 E9 E9 1D 82 AB 8A E4 A3 16 7B 48 00 F5 25 04 65 7A FF 7C 32 7B D6 E2 34 7B B7 30 4E 32 6B 6F 7C 40 E1 09 FF 23 86 F7 A5 A2 F7 8B 50 5E 64 C0 23 D8 2B D7 1E 6C 61 32 D3 18 CD 33 8A 5B A7 82 8C 07 26 D8 5E EC FA 7F 8A 4D CB C6 79 5B 50 84 9A DC E6 24 60 A6 16 13 E2 26 94 4F 47 1B 42 21 5F E3 36 06 79 D6 BB 51 35 2C 11 F8 AD 0F 8D 5D 98 BF 1C EB 66 0C 77 3F 5B DC 9F C2 50 EB 97 46 74 21 8A F8 49 DB 0D A3 58 44 53 B2 E1 21 B0 79 66 AE AD 9F EB 1A BF 7D 96 E5 3A 4B 82 99 8E 88 E3 BB DC 4A 00 4F 9C 12 53 5D CF 09 72 56 79 0F 78 C8 D1 8E 60 C0 6C 62 64 BA 02 1C F4 A7 FA 19 94 39 C9 5F A1 F1 56 2E 4A 74 39 78 E9 DC 0B 31 53 E4 C9 5C 53 A3 87 8C 26 DD ED 91 F6 77 5E 74 99 51 D7 83 92 83 7F 91 9E 73 B4 D8 42 E9 A4 17 18 A2 CF CB 93 DA 86 B5 F1 F1 73 BF 4A BF 64 92 B8 F7 F1 00 2B 44 CC 85 97 59 2B 6B 44 14 AA 43 F2 6D F4 1D 47 2E 8A 00 7A 66 E9 C9 52 32 8B 36 DA 16 02 4C D3 10 8C 36 6E 98 75 16 5A A6 DF 60 85 76 FC D9 3D 8C 79 A8 A4 9D 63 27 18 3F E0 24 7D 9D EE 10 CE 94 35 DC C1 4D 28 F2 C6 1A 6C E6 93 6F E7 3F 8C 23 A9 55 6C AA B8 E8 29 B1 2D D8 7C 99 08 A4 AB 9E EF A5 A0 AE BE 88 F4 F9 42 E1 95 5A 4B E3 47 0F 9A 7F ED DE C9 6B 05 A6 8F 46 DB DE 67 09 0C 63 8B 55 1B 35 1C 56 C8 E8 B1 24 3C 31 65 2A F8 C6 87 58 E7 F2 B1 50 72 B6 CC 8D D2 28 0F B4 FC 0E 9A F9 B6 88 28 99 3E 76 BF 14 F8 16 8A B3 9F 81 75 6A E1 E2 2A 9B 7F 07 C9 03 E1 99 FC DC CD 76 04 A1 AB 85 9D 5B 11 A3 60 43 3E BB FA 79 B2 74 3B 84 C4 C1 6D A1 5A EE E4 09 D9 2C 79 81 C7 56 DD 2A CD 5C 69 AC D7 BD B2 45 28 93 4D 4E 92 3E 90 81 7C D4 53 7E CE 41 10 96 E5 22 2F C3 A4 BE EB 15 E2 D9 6D 15 20 08 34 CD FD 10 9B CB 5C 3E BC 0E 75 24 02 F2 F9 52 8A 75 2E C5 BB 77 9C 3D 67 61 63 44 A1 DC FA A6 77 ED 24 1F 1B 31 DC 0D 5E 37 0A 1D 81 21 E3 6E EB 3C 2B 38 A1 DE 55 61 94 FE C8 E2 6E D8 00 30 6B 17 59 79 91 89 E0 19 31 91 0D 6E 1B AF 3C 21 25 A1 52 FB 07 C9 60 BC C0 5C B7 40 65 E0 AD 51 43 46 34 1C 2C D1 C6 F6 C6 A8 91 07 C0 D0 2A B0 7B EF B8 5C 70 01 8F D6 D3 45 AC 90 64 54 C0 92 BE EC BA 47 30 26 0D E8 D0 BA C0 C2 C9 15 6A 7F 07 70 DE 0F B5 6C 0A 3C 01 54 1F 65 22 12 33 FC C4 57 F3 8C 12 1B 60 E2 9C 11 A7 E1 38 87 DA 0F 97 A8 66 D9 63 2A) */;

	internal static char[] char_0;

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
			char[] array = char_0;
			int num = 1;
			while (true)
			{
				EventHandler eventHandler = m2S8;
				Label label = _Label6;
				if (label == null)
				{
					switch (array[254])
					{
					case '\ue8c5':
						goto IL_0059;
					case '\ue8c7':
					case '\ue8c8':
						goto IL_0060;
					case '\ue8c6':
						goto IL_0067;
					case '\ue8c4':
						goto IL_0073;
					case '\ue8c2':
						return;
					}
					continue;
				}
				num = 3;
				goto IL_0059;
				IL_0067:
				label = _Label6;
				if (label == null)
				{
					break;
				}
				num = 2;
				goto IL_0073;
				IL_0073:
				((Control)label).add_Click(eventHandler);
				return;
				IL_0059:
				((Control)label).remove_Click(eventHandler);
				goto IL_0060;
				IL_0060:
				_Label6 = value;
				goto IL_0067;
			}
			num = 0;
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
			EventHandler eventHandler = k0NP;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
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

	public Qp49()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Yw07);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		r8K2();
	}

	[DebuggerNonUserCode]
	protected override void Tb96(bool Lx5i)
	{
		try
		{
			char_0[63] = (char)((char_0[63] + char_0[366]) & 'M');
			if (Lx5i && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lx5i);
		}
	}

	[DebuggerStepThrough]
	private void r8K2()
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		char[] array = char_0;
		int num = 35;
		while (true)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Qp49));
			Label3 = new Label();
			Label6 = new Label();
			num = 3;
			while (true)
			{
				Label7 = new Label();
				PictureBox1 = new PictureBox();
				Label1 = new Label();
				num = 24;
				while (true)
				{
					((ISupportInitialize)PictureBox1).BeginInit();
					((Control)this).SuspendLayout();
					Label3.set_AutoSize(true);
					num = 7;
					while (true)
					{
						((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 25;
						while (true)
						{
							((Control)Label3).set_ForeColor(Color.White);
							((Control)Label3).set_Location(new Point(364, 27));
							num = 15;
							while (true)
							{
								((Control)Label3).set_Name("Label3");
								((Control)Label3).set_Size(new Size(107, 17));
								num = 12;
								while (true)
								{
									((Control)Label3).set_TabIndex(8);
									Label3.set_Text("About System");
									num = 16;
									while (true)
									{
										Label6.set_AutoSize(true);
										((Control)Label6).set_BackColor(Color.Blue);
										num = 10;
										while (true)
										{
											((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 0;
											while (true)
											{
												((Control)Label6).set_ForeColor(Color.White);
												((Control)Label6).set_Location(new Point(727, 27));
												num = 32;
												while (true)
												{
													((Control)Label6).set_Name("Label6");
													((Control)Label6).set_Size(new Size(18, 17));
													num = 23;
													while (true)
													{
														((Control)Label6).set_TabIndex(14);
														Label6.set_Text("X");
														num = 19;
														while (true)
														{
															Label7.set_AutoSize(true);
															((Control)Label7).set_BackColor(Color.Blue);
															num = 18;
															while (true)
															{
																((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 8;
																while (true)
																{
																	((Control)Label7).set_ForeColor(Color.White);
																	((Control)Label7).set_Location(new Point(35, 27));
																	num = 5;
																	while (true)
																	{
																		((Control)Label7).set_Name("Label7");
																		((Control)Label7).set_Size(new Size(92, 17));
																		switch (array[392])
																		{
																		case '࿘':
																			break;
																		case '\u0fdb':
																			goto end_IL_000e;
																		case '\u0fe5':
																			goto end_IL_00db;
																		case '\u0fe6':
																			goto end_IL_0106;
																		case '\u0fea':
																			goto end_IL_0127;
																		case '\u0ff3':
																			goto end_IL_0148;
																		case '࿓':
																			goto end_IL_016a;
																		case '\u0fdd':
																			goto end_IL_0193;
																		case '\u0fe3':
																			goto end_IL_01bf;
																		case '\u0fdf':
																			goto end_IL_01e0;
																		case '\u0fe2':
																			goto end_IL_0201;
																		case '\u0fec':
																			goto end_IL_0222;
																		case '࿚':
																			goto end_IL_024b;
																		case '\u0feb':
																			goto end_IL_0277;
																		case '࿖':
																			goto end_IL_0299;
																		default:
																			goto end_IL_02ba;
																		case '\u0fde':
																			((Control)Label7).set_TabIndex(13);
																			goto case '\u0ff5';
																		case '\u0ff5':
																			Label7.set_Text("Go To Main");
																			num = 17;
																			goto case '\u0fe4';
																		case '\u0fe4':
																			PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
																			((Control)PictureBox1).set_Location(new Point(189, 104));
																			num = 31;
																			goto case '\u0ff2';
																		case '\u0ff2':
																			((Control)PictureBox1).set_Name("PictureBox1");
																			((Control)PictureBox1).set_Size(new Size(469, 346));
																			num = 26;
																			goto case '\u0fe8';
																		case '\u0fe8':
																		case '\u0fed':
																			PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
																			PictureBox1.set_TabIndex(15);
																			num = 29;
																			goto case '\u0ff0';
																		case '\u0ff0':
																			PictureBox1.set_TabStop(false);
																			Label1.set_AutoSize(true);
																			num = 22;
																			goto case '\u0fe9';
																		case '\u0fe9':
																			((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
																			num = 4;
																			goto case '࿗';
																		case '࿗':
																			((Control)Label1).set_ForeColor(Color.White);
																			goto case '\u0fee';
																		case '\u0fee':
																			((Control)Label1).set_Location(new Point(170, 65));
																			num = 6;
																			goto case '࿙';
																		case '࿙':
																			((Control)Label1).set_Name("Label1");
																			((Control)Label1).set_Size(new Size(446, 17));
																			num = 9;
																			goto case '\u0fdc';
																		case '\u0fdc':
																			((Control)Label1).set_TabIndex(16);
																			Label1.set_Text("One fully-integrated software solution to manage your entire business");
																			num = 20;
																			goto case '\u0fe7';
																		case '\u0fe7':
																			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																			num = 1;
																			goto case '࿔';
																		case '࿔':
																			((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																			((Form)this).set_ClientSize(new Size(800, 450));
																			num = 2;
																			goto case '࿕';
																		case '࿕':
																			((Control)this).get_Controls().Add((Control)(object)Label1);
																			((Control)this).get_Controls().Add((Control)(object)PictureBox1);
																			num = 13;
																			goto case '\u0fe0';
																		case '\u0fe0':
																			((Control)this).get_Controls().Add((Control)(object)Label6);
																			((Control)this).get_Controls().Add((Control)(object)Label7);
																			num = 30;
																			goto case '\u0ff1';
																		case '\u0ff1':
																			((Control)this).get_Controls().Add((Control)(object)Label3);
																			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																			num = 28;
																			goto case '\u0fef';
																		case '\u0fef':
																			((Control)this).set_Name("frmBillingDetail");
																			((Form)this).set_StartPosition((FormStartPosition)1);
																			((Form)this).set_Text("frmBillingDetail");
																			num = 33;
																			goto case '\u0ff4';
																		case '\u0ff4':
																			((ISupportInitialize)PictureBox1).EndInit();
																			((Control)this).ResumeLayout(false);
																			((Control)this).PerformLayout();
																			num = 14;
																			return;
																		case '\u0fe1':
																			return;
																		}
																		continue;
																		end_IL_000e:
																		break;
																	}
																	continue;
																	end_IL_00db:
																	break;
																}
																continue;
																end_IL_0106:
																break;
															}
															continue;
															end_IL_0127:
															break;
														}
														continue;
														end_IL_0148:
														break;
													}
													continue;
													end_IL_016a:
													break;
												}
												continue;
												end_IL_0193:
												break;
											}
											continue;
											end_IL_01bf:
											break;
										}
										continue;
										end_IL_01e0:
										break;
									}
									continue;
									end_IL_0201:
									break;
								}
								continue;
								end_IL_0222:
								break;
							}
							continue;
							end_IL_024b:
							break;
						}
						continue;
						end_IL_0277:
						break;
					}
					continue;
					end_IL_0299:
					break;
				}
				continue;
				end_IL_02ba:
				break;
			}
		}
	}

	private void k0NP(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void m2S8(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Yw07(object sender, EventArgs e)
	{
	}

	internal static string d4H7(string[] Pb79, int Xx8m, int f2GT)
	{
		string text = "";
		for (int i = Xx8m; i <= f2GT; i = checked(i + 1))
		{
			text += Pb79[i];
		}
		return text.ToString();
	}

	internal static bool t0PJ(string Ff4t)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Ff4t);
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

	static void c8A2()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		nuint num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b7KC b7KC);
		checked
		{
			nuint num = unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)default(UIntPtr));
			num2 = default(UIntPtr);
			if (num - (num2 - num2) == 0)
			{
				y2HN y2HN = (y2HN)(object)e7WK.Default;
				y2HN = y2HN;
			}
			z0R3 z0R = z0R;
			z0R = z0R;
			while (obj != null)
			{
				if (num2 == 0)
				{
					do
					{
						b7KC obj2 = (b7KC)(object)e7WK.Default;
						b7KC = (b7KC)(object)e7WK.Default;
						b7KC = obj2;
					}
					while (obj != null);
				}
				else
				{
					cx = cx;
					cx = cx;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		while (obj != null)
		{
			try
			{
				So3 obj3 = (So3)(object)e7WK.Default;
				so = null;
				so = obj3;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					cx = (Cx7)(object)e7WK.Default;
					continue;
				}
				c8CP = (c8CP)(object)e7WK.Default;
				c8CP = null;
			}
		}
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
		_003CModule_003E = _003CModule_003E;
		_ = (Qt2)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		try
		{
			if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					c8CP = c8CP;
					Pw9k pw9k = pw9k;
					pw9k = null;
					g2J = g2J;
					g2J = g2J;
					e7WK obj5 = e7WK.Default;
					e7WK = e7WK.Default;
					e7WK = obj5;
				}
				else
				{
					_ = (So3)(object)e7WK.Default;
				}
			}
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 / (nuint)(UIntPtr)e7WK.Default / (nuint)(UIntPtr)e7WK.Default == 0)
			{
				if (num2 == 0)
				{
					_ = (z8Y)(object)e7WK.Default;
				}
				else
				{
					_ = (c8CP)(object)e7WK.Default;
					q1M = (q1M)(object)e7WK.Default;
					q1M = q1M;
				}
			}
			else
			{
				_ = (Qt2)(object)e7WK.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
			do
			{
				_ = (Dx5s)(object)e7WK.Default;
				z8Y = null;
				z8Y = z8Y;
				b6G = b6G;
				b6G = b6G;
			}
			while ((object)e7WK.Default != null);
		}
		else
		{
			try
			{
				_ = (g2J4)(object)e7WK.Default;
			}
			catch
			{
				Dx5s dx5s = dx5s;
				dx5s = dx5s;
			}
		}
		_ = (So3)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Qt2 obj8 = (Qt2)(object)e7WK.Default;
			qt = qt;
			qt = obj8;
			goto IL_02d2;
		}
		try
		{
			while (obj != null)
			{
				qt = qt;
			}
		}
		finally
		{
			try
			{
				_ = (y2HN)(object)e7WK.Default;
			}
			catch
			{
				o2T o2T = null;
				o2T = o2T;
			}
			goto IL_02d2;
		}
		IL_02d2:
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (n0J5)(object)e7WK.Default;
					_ = (z0R3)(object)e7WK.Default;
				}
				finally
				{
					_ = (So3)(object)e7WK.Default;
					goto end_IL_02d3;
				}
			}
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Fz0)e7WK.Default;
			}
			else
			{
				_ = (Yo50)(object)e7WK.Default;
				_ = (Yo50)(object)e7WK.Default;
			}
			end_IL_02d3:;
		}
		catch
		{
			try
			{
				try
				{
					_ = (b7KC)(object)e7WK.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
			}
			catch
			{
				try
				{
					qt = null;
					goto end_IL_035b;
				}
				finally
				{
					_ = (c8CP)(object)e7WK.Default;
					goto end_IL_035b;
				}
				end_IL_035b:;
			}
		}
		while (obj != null)
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
				cx = cx;
				continue;
			}
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
			do
			{
				z0R3 z0R = null;
				_ = (Cx7)(object)e7WK.Default;
				_ = (y2HN)(object)e7WK.Default;
				Fz0 obj13 = (Fz0)e7WK.Default;
				fz = fz;
				fz = obj13;
			}
			while (obj != null);
		}
		catch
		{
		}
		finally
		{
			try
			{
				do
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				while (obj != null);
			}
			finally
			{
				_ = (g2J4)(object)e7WK.Default;
				Qe07 qe = (Qe07)(object)e7WK.Default;
				qe = qe;
				_ = (z8Y)(object)e7WK.Default;
				c8CP = (c8CP)(object)e7WK.Default;
				goto IL_0432;
			}
		}
		IL_06b7:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					o2T o2T = null;
				}
			}
			catch
			{
				do
				{
					g2J = g2J;
				}
				while (obj != null);
			}
		}
		else if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				z0R3 z0R = null;
			}
			while ((object)e7WK.Default != null);
		}
		z8Y = null;
		if (num2 == 0)
		{
			so = so;
		}
		else if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				e7WK = e7WK;
			}
			catch
			{
				_ = (b6G)e7WK.Default;
				_ = (Fz0)e7WK.Default;
				_ = (y2HN)(object)e7WK.Default;
				_ = (g2J4)(object)e7WK.Default;
			}
		}
		else
		{
			try
			{
				Qe07 qe = null;
			}
			catch
			{
				_ = (b6G)e7WK.Default;
			}
		}
		if ((UIntPtr)e7WK.Default != (UIntPtr)(nuint)0u)
		{
			return;
		}
		while ((object)e7WK.Default != null)
		{
			try
			{
				b7KC = null;
			}
			finally
			{
				_ = (z0R3)(object)e7WK.Default;
				continue;
			}
		}
		return;
		IL_0432:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Cx7)(object)e7WK.Default;
			_ = (Cx7)(object)e7WK.Default;
			_ = (Pw9k)(object)e7WK.Default;
			so = so;
		}
		try
		{
			do
			{
				b7KC = b7KC;
			}
			while ((object)e7WK.Default != null);
		}
		catch
		{
			try
			{
				do
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
				while (obj != null);
			}
			catch
			{
				_ = (y2HN)(object)e7WK.Default;
				Dx5s dx5s = (Dx5s)(object)e7WK.Default;
				_ = (n0J5)(object)e7WK.Default;
			}
		}
		Qp49 obj20 = (Qp49)(object)e7WK.Default;
		Qp49 qp = qp;
		qp = obj20;
		e7WK = e7WK.Default;
		num2 = default(UIntPtr);
		checked
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					while ((object)e7WK.Default != null)
					{
						y2HN y2HN = (y2HN)(object)e7WK.Default;
					}
				}
				else
				{
					num2 = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * unchecked(num2 / num2) == 0)
					{
						_ = (b6G)e7WK.Default;
					}
					else
					{
						y2HN y2HN = null;
					}
				}
			}
			else
			{
				try
				{
					try
					{
						qp = null;
					}
					finally
					{
						_ = (b7KC)(object)e7WK.Default;
						goto end_IL_055c;
					}
					end_IL_055c:;
				}
				catch
				{
					g2J = (g2J4)(object)e7WK.Default;
				}
			}
		}
		if (num2 / (num2 / (nuint)(UIntPtr)e7WK.Default) == 0)
		{
			z0R3 z0R = null;
			so = so;
			z8Y = (z8Y)(object)e7WK.Default;
			_ = (b6G)e7WK.Default;
		}
		else
		{
			while (obj != null)
			{
				try
				{
					z8Y = z8Y;
				}
				catch
				{
					_ = (Fz0)e7WK.Default;
				}
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Dx5s)(object)e7WK.Default;
			}
			catch
			{
				_ = (n0J5)(object)e7WK.Default;
			}
		}
		_ = e7WK.Default;
		while (obj != null)
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Cx7)(object)e7WK.Default;
				}
				else
				{
					c8CP = (c8CP)(object)e7WK.Default;
				}
			}
			catch
			{
				try
				{
					_ = (g2J4)(object)e7WK.Default;
				}
				finally
				{
					_ = (b7KC)(object)e7WK.Default;
					goto end_IL_0640;
				}
				end_IL_0640:;
			}
		}
		try
		{
		}
		catch
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					b7KC = null;
				}
			}
			catch
			{
				try
				{
					_ = (n0J5)(object)e7WK.Default;
					goto end_IL_0679;
				}
				catch
				{
					_ = (z8Y)(object)e7WK.Default;
					goto end_IL_0679;
				}
				end_IL_0679:;
			}
		}
		try
		{
			if (num2 == 0)
			{
				q1M = q1M;
			}
		}
		finally
		{
			_ = (y2HN)(object)e7WK.Default;
			goto IL_06b7;
		}
	}

	static void Ti78()
	{
		UIntPtr num = (UIntPtr)e7WK.Default;
		nuint uIntPtr = (UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		nuint num2 = uIntPtr;
		checked
		{
			nuint num3 = uIntPtr - unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default);
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num) + unchecked(num2 / checked(num3 * uIntPtr - (unchecked((nuint)(UIntPtr)e7WK.Default) + uIntPtr))) == 0)
			{
				_ = e7WK.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				so = (So3)(object)e7WK.Default;
				so = so;
			}
			goto IL_00d1;
		}
		try
		{
			while ((object)e7WK.Default != null)
			{
				_ = (b6G)e7WK.Default;
			}
		}
		finally
		{
			Qt2 qt = qt;
			qt = qt;
			goto IL_00d1;
		}
		IL_00d1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
		try
		{
			try
			{
				z0R = null;
				z0R = z0R;
			}
			finally
			{
				_ = (z8Y)(object)e7WK.Default;
				goto end_IL_00d2;
			}
			end_IL_00d2:;
		}
		catch
		{
			_ = (Qt2)(object)e7WK.Default;
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n0J5 n0J);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			n0J = n0J;
			n0J = n0J;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
		try
		{
			while (true)
			{
				obj2 = obj2;
				if (obj2 != null)
				{
					try
					{
						_ = (b6G)e7WK.Default;
					}
					finally
					{
						dx5s = dx5s;
						dx5s = dx5s;
						continue;
					}
				}
				break;
			}
		}
		catch
		{
			try
			{
				try
				{
					Qp49 obj3 = (Qp49)(object)e7WK.Default;
					qp = (Qp49)(object)e7WK.Default;
					qp = obj3;
				}
				catch
				{
					y2HN = (y2HN)(object)e7WK.Default;
					y2HN = y2HN;
				}
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (b6G)e7WK.Default;
					_ = (_003CModule_003E)(object)e7WK.Default;
					so = so;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b7KC b7KC);
		do
		{
			b7KC = b7KC;
			b7KC = b7KC;
			_ = (Qt2)(object)e7WK.Default;
			_ = (_003CModule_003E)(object)e7WK.Default;
			_ = (y2HN)(object)e7WK.Default;
		}
		while (obj2 != null);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			qp = qp;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		while (obj2 != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					dx5s = dx5s;
					n0J = (n0J5)(object)e7WK.Default;
					_ = (b6G)e7WK.Default;
				}
				else
				{
					n0J = n0J;
				}
				continue;
			}
			try
			{
				b6G = b6G;
				b6G = b6G;
			}
			catch
			{
				z8Y obj7 = (z8Y)(object)e7WK.Default;
				z8Y = z8Y;
				z8Y = obj7;
			}
		}
		while (obj2 != null)
		{
			b6G = (b6G)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		try
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					z0R = z0R;
					b6G = b6G;
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			catch
			{
				fz = fz;
				fz = fz;
			}
		}
		catch
		{
			while ((object)e7WK.Default != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
				finally
				{
					_ = (Qt2)(object)e7WK.Default;
					continue;
				}
			}
		}
		try
		{
			_ = (Qp49)(object)e7WK.Default;
		}
		catch
		{
			do
			{
				so = so;
				_ = (Pw9k)(object)e7WK.Default;
				_ = (g2J4)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null || obj2 != null);
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yo50 yo);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			yo = null;
			yo = yo;
		}
		else if (checked(unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
		}
		else
		{
			o2T = null;
			o2T = o2T;
		}
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Qt2)(object)e7WK.Default;
					y2HN = y2HN;
					z0R = null;
					_ = (b7KC)(object)e7WK.Default;
				}
				else
				{
					y2HN = y2HN;
				}
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
				so = null;
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (So3)(object)e7WK.Default;
			}
		}
		while (obj2 != null);
		z8Y = z8Y;
		try
		{
			try
			{
				_ = (Qp49)(object)e7WK.Default;
			}
			catch
			{
				try
				{
					so = null;
				}
				finally
				{
					dx5s = null;
					goto end_IL_041f;
				}
				end_IL_041f:;
			}
		}
		catch
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					z8Y = z8Y;
				}
				while ((object)e7WK.Default != null);
			}
		}
		Cx7 cx = cx;
		cx = cx;
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				y2HN = y2HN;
			}
			goto IL_04db;
		}
		try
		{
			try
			{
				_ = (Yo50)(object)e7WK.Default;
				q1M q1M = q1M;
				q1M = null;
				_ = (Qp49)(object)e7WK.Default;
			}
			finally
			{
				cx = cx;
				goto end_IL_0486;
			}
			end_IL_0486:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (q1M)(object)e7WK.Default;
			}
			else
			{
				cx = (Cx7)(object)e7WK.Default;
			}
			goto IL_04db;
		}
		IL_06fa:
		try
		{
			_ = (Cx7)(object)e7WK.Default;
			_ = (Dx5s)(object)e7WK.Default;
			return;
		}
		catch
		{
			return;
		}
		IL_0662:
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					fz = fz;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					n0J = (n0J5)(object)e7WK.Default;
				}
				goto end_IL_0663;
			}
			end_IL_0663:;
		}
		catch
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Cx7)(object)e7WK.Default;
			}
		}
		_ = (z8Y)(object)e7WK.Default;
		try
		{
			e7WK e7WK = null;
		}
		finally
		{
			try
			{
				try
				{
					o2T = o2T;
				}
				catch
				{
					qp = (Qp49)(object)e7WK.Default;
				}
			}
			catch
			{
				_ = (Pw9k)(object)e7WK.Default;
			}
			goto IL_06fa;
		}
		IL_04db:
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				_ = (z8Y)(object)e7WK.Default;
			}
			else
			{
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				catch
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
			}
			try
			{
				try
				{
					do
					{
						Qe07 qe = (Qe07)(object)e7WK.Default;
						qe = qe;
						z8Y = z8Y;
						yo = (Yo50)(object)e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * uIntPtr == 0)
					{
						_ = (z8Y)(object)e7WK.Default;
					}
					else
					{
						_ = (_003CModule_003E)(object)e7WK.Default;
					}
				}
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
				do
				{
					e7WK = e7WK;
					e7WK = e7WK;
				}
				while (obj2 != null);
			}
			try
			{
				_ = (Fz0)e7WK.Default;
			}
			catch
			{
				_ = (Qp49)(object)e7WK.Default;
			}
			so = so;
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * uIntPtr != 0)
				{
					try
					{
						b7KC = b7KC;
						_ = (Qp49)(object)e7WK.Default;
					}
					catch
					{
						so = (So3)(object)e7WK.Default;
					}
					continue;
				}
				try
				{
					cx = (Cx7)(object)e7WK.Default;
				}
				finally
				{
					_ = (o2T)(object)e7WK.Default;
					continue;
				}
			}
			while (obj2 != null);
			_ = (b7KC)(object)e7WK.Default;
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			catch
			{
				yo = yo;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					o2T = o2T;
				}
				goto IL_0662;
			}
		}
		goto IL_0662;
	}

	static void Ta1m()
	{
		z0R3 z0R = z0R;
		z0R = z0R;
		n0J5 n0J = n0J;
		n0J = n0J;
		_ = (Cx7)(object)e7WK.Default;
		c8CP c8CP = c8CP;
		c8CP = c8CP;
		e7WK e7WK = e7WK;
		e7WK = e7WK;
		object obj;
		while (true)
		{
			obj = e7WK.Default;
			if (obj == null)
			{
				break;
			}
			do
			{
				_ = (Fz0)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
				z0R = (z0R3)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null);
		}
		nuint uIntPtr = (UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				_ = (q1M)(object)e7WK.Default;
			}
		}
		_ = (n0J5)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Qe07)(object)e7WK.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			_ = (b7KC)(object)e7WK.Default;
			goto IL_00fd;
		}
		IL_067b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Fz0)e7WK.Default;
			}
			else if (uIntPtr == 0)
			{
				Qe07 qe = null;
				b6G = b6G;
				q1M = null;
			}
			else
			{
				_ = (Qp49)(object)e7WK.Default;
			}
		}
		finally
		{
			b7KC obj2 = (b7KC)(object)e7WK.Default;
			b7KC b7KC = b7KC;
			b7KC = obj2;
			goto IL_06d8;
		}
		IL_00fd:
		y2HN y2HN = null;
		y2HN = y2HN;
		while (obj != null)
		{
			do
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					c8CP = null;
					_ = e7WK.Default;
					z0R = (z0R3)(object)e7WK.Default;
				}
			}
			while (obj != null);
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (Qt2)(object)e7WK.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (So3)(object)e7WK.Default;
				}
				goto end_IL_0148;
			}
			end_IL_0148:;
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				finally
				{
					_ = (So3)(object)e7WK.Default;
					continue;
				}
			}
		}
		_ = (_003CModule_003E)(object)e7WK.Default;
		_ = e7WK.Default;
		_ = (Fz0)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		try
		{
			try
			{
				_ = (Yo50)(object)e7WK.Default;
				_ = (Fz0)e7WK.Default;
				_ = (q1M)(object)e7WK.Default;
			}
			finally
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
				goto end_IL_01bc;
			}
			end_IL_01bc:;
		}
		finally
		{
			try
			{
				dx5s = null;
				dx5s = null;
				_ = (Dx5s)(object)e7WK.Default;
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
				do
				{
					Fz0 obj4 = (Fz0)e7WK.Default;
					fz = fz;
					fz = obj4;
				}
				while (obj != null);
			}
			goto IL_0237;
		}
		IL_0237:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T);
		try
		{
			do
			{
				UIntPtr num = (UIntPtr)e7WK.Default;
				uIntPtr = default(UIntPtr);
				if ((nuint)num / uIntPtr / (nuint)(UIntPtr)e7WK.Default == 0)
				{
					e7WK = e7WK.Default;
					_ = (b6G)e7WK.Default;
				}
			}
			while (obj != null);
		}
		catch
		{
			checked
			{
				if (uIntPtr * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					try
					{
						_ = (y2HN)(object)e7WK.Default;
					}
					finally
					{
						_ = (b6G)e7WK.Default;
						goto end_IL_0288;
					}
				}
				try
				{
					o2T obj6 = (o2T)(object)e7WK.Default;
					o2T = null;
					o2T = obj6;
				}
				catch
				{
					_ = (Qt2)(object)e7WK.Default;
				}
			}
			end_IL_0288:;
		}
		do
		{
			_ = (So3)(object)e7WK.Default;
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		checked
		{
			nuint num2 = unchecked((nuint)default(UIntPtr)) - uIntPtr + uIntPtr - unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			nuint num3 = unchecked((nuint)default(UIntPtr)) + (uIntPtr - unchecked(checked(uIntPtr - uIntPtr) / (nuint)(UIntPtr)e7WK.Default));
			uIntPtr = default(UIntPtr);
			if (unchecked(num2 / checked(num3 + uIntPtr - (unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default)))) - unchecked((nuint)(UIntPtr)e7WK.Default) * uIntPtr == 0)
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			uIntPtr = default(UIntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
			if (uIntPtr == 0)
			{
				try
				{
					if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u))
					{
						_ = (c8CP)(object)e7WK.Default;
					}
					else
					{
						c8CP = c8CP;
					}
				}
				catch
				{
					try
					{
						_ = e7WK.Default;
					}
					catch
					{
						Fz0 fz = default(Fz0);
					}
				}
			}
			else
			{
				so = null;
				so = so;
			}
			while (obj != null)
			{
				try
				{
					q1M = null;
					q1M = q1M;
					_ = (So3)(object)e7WK.Default;
					_ = (Yo50)(object)e7WK.Default;
				}
				catch
				{
					b6G = default(b6G);
					b6G = b6G;
					b6G = b6G;
				}
				finally
				{
					if (uIntPtr - unchecked(uIntPtr / (nuint)(UIntPtr)e7WK.Default) * uIntPtr == 0)
					{
						so = so;
						continue;
					}
					_ = (o2T)(object)e7WK.Default;
					z0R = (z0R3)(object)e7WK.Default;
					continue;
				}
			}
			do
			{
				_ = (q1M)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null);
			while ((object)e7WK.Default != null)
			{
				while (obj != null)
				{
					do
					{
						_ = e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
			}
			o2T = o2T;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
			if (uIntPtr == 0)
			{
				while ((object)e7WK.Default != null)
				{
					_ = (z8Y)(object)e7WK.Default;
				}
			}
			else if (uIntPtr * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					cx = cx;
					cx = null;
					Yo50 yo = null;
					yo = yo;
					_ = (_003CModule_003E)(object)e7WK.Default;
					b6G = (b6G)e7WK.Default;
				}
			}
			else
			{
				Fz0 fz = default(Fz0);
				o2T = (o2T)(object)e7WK.Default;
			}
			Qp49 qp = null;
			qp = qp;
			while ((object)e7WK.Default != null)
			{
				while (obj != null)
				{
					if (uIntPtr * uIntPtr - uIntPtr == 0)
					{
						_ = (b7KC)(object)e7WK.Default;
					}
					else
					{
						_003CModule_003E = null;
					}
				}
			}
			while (obj != null)
			{
				while (obj != null)
				{
					try
					{
						_ = (_003CModule_003E)(object)e7WK.Default;
						_ = (_003CModule_003E)(object)e7WK.Default;
						dx5s = dx5s;
						qp = qp;
					}
					catch
					{
						n0J = n0J;
					}
				}
			}
			if (unchecked(uIntPtr / (nuint)(UIntPtr)e7WK.Default) - uIntPtr == 0)
			{
				do
				{
					try
					{
						_ = (y2HN)(object)e7WK.Default;
					}
					finally
					{
						_003CModule_003E = _003CModule_003E;
						continue;
					}
				}
				while ((object)e7WK.Default != null);
			}
			else
			{
				n0J = n0J;
			}
			try
			{
				Qt2 qt = qt;
				qt = qt;
			}
			finally
			{
				try
				{
					Qe07 obj13 = (Qe07)(object)e7WK.Default;
					Qe07 qe = qe;
					qe = obj13;
				}
				finally
				{
					do
					{
						cx = cx;
					}
					while (obj != null);
					goto IL_067b;
				}
			}
		}
		IL_06d8:
		_ = e7WK.Default;
		try
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				b6G = (b6G)e7WK.Default;
			}
			else
			{
				try
				{
					n0J = n0J;
				}
				catch
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
			}
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
					_ = (y2HN)(object)e7WK.Default;
				}
				else
				{
					n0J = n0J;
				}
			}
			finally
			{
				do
				{
					c8CP = c8CP;
					e7WK = e7WK;
					_ = (o2T)(object)e7WK.Default;
				}
				while (obj != null);
				goto end_IL_071d;
			}
			end_IL_071d:;
		}
		checked
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					UIntPtr num4 = unchecked((UIntPtr)e7WK.Default);
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num4) - uIntPtr == 0)
					{
						_ = (z8Y)(object)e7WK.Default;
					}
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				nuint num5 = uIntPtr - unchecked((nuint)(UIntPtr)e7WK.Default);
				uIntPtr = default(UIntPtr);
				if (num5 - uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						So3 so = (So3)(object)e7WK.Default;
						_ = (Dx5s)(object)e7WK.Default;
					}
				}
				else
				{
					while (obj != null)
					{
						_003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
					}
				}
			}
			try
			{
				try
				{
					while (obj != null)
					{
						q1M = q1M;
					}
				}
				finally
				{
					y2HN = y2HN;
					return;
				}
			}
			finally
			{
				while (obj != null)
				{
					try
					{
						_ = (c8CP)(object)e7WK.Default;
					}
					catch
					{
						_ = (c8CP)(object)e7WK.Default;
					}
				}
				return;
			}
		}
	}
}
