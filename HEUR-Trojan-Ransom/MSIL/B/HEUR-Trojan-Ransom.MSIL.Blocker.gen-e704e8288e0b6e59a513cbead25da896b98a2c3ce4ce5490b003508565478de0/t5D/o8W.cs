using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ba50;
using Cd1t;
using Ci75;
using Es0;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Ri5n;
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xo8;
using Xs5;
using a9D;
using c4ZK;
using e6H;
using j3B;
using q8B;
using s1Y;
using x9E1;

namespace t5D;

[DesignerGenerated]
public class o8W : Form
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
			EventHandler eventHandler = g3X;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
				Ta8.char_0[87] = (char)((Ta8.char_0[87] ^ Ta8.char_0[308]) & '\u008f');
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
			EventHandler eventHandler = f3W;
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

	public o8W()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)m8X);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		z1P();
	}

	[DebuggerNonUserCode]
	protected override void Gg1(bool Wm4)
	{
		try
		{
			if (Wm4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wm4);
		}
	}

	[DebuggerStepThrough]
	private void z1P()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		char[] char_ = Ta8.char_0;
		int num = 13;
		while (true)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(o8W));
			Label3 = new Label();
			Label6 = new Label();
			num = 18;
			while (true)
			{
				Label7 = new Label();
				PictureBox1 = new PictureBox();
				Label1 = new Label();
				num = 16;
				while (true)
				{
					((ISupportInitialize)PictureBox1).BeginInit();
					((Control)this).SuspendLayout();
					Label3.set_AutoSize(true);
					num = 14;
					while (true)
					{
						((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 3;
						while (true)
						{
							((Control)Label3).set_ForeColor(Color.White);
							((Control)Label3).set_Location(new Point(364, 27));
							num = 30;
							while (true)
							{
								((Control)Label3).set_Name("Label3");
								((Control)Label3).set_Size(new Size(107, 17));
								num = 22;
								while (true)
								{
									((Control)Label3).set_TabIndex(8);
									Label3.set_Text("About System");
									num = 15;
									while (true)
									{
										Label6.set_AutoSize(true);
										((Control)Label6).set_BackColor(Color.Blue);
										num = 2;
										while (true)
										{
											((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 10;
											while (true)
											{
												((Control)Label6).set_ForeColor(Color.White);
												((Control)Label6).set_Location(new Point(727, 27));
												num = 35;
												while (true)
												{
													((Control)Label6).set_Name("Label6");
													((Control)Label6).set_Size(new Size(18, 17));
													num = 21;
													while (true)
													{
														((Control)Label6).set_TabIndex(14);
														while (true)
														{
															Label6.set_Text("X");
															num = 12;
															while (true)
															{
																Label7.set_AutoSize(true);
																((Control)Label7).set_BackColor(Color.Blue);
																num = 9;
																while (true)
																{
																	((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																	switch (char_[311])
																	{
																	case '\u1c8a':
																	case '\u1c8f':
																		break;
																	case 'Გ':
																		goto end_IL_000f;
																	case '\u1c8c':
																		goto end_IL_00d5;
																	case 'Მ':
																		goto end_IL_00f9;
																	case 'Ჩ':
																		goto end_IL_010e;
																	case 'Ა':
																		goto end_IL_011d;
																	case 'ᲈ':
																		goto end_IL_0146;
																	case 'Ვ':
																		goto end_IL_0172;
																	case 'Ნ':
																		goto end_IL_0194;
																	case 'Ფ':
																		goto end_IL_01b4;
																	case '\u1c89':
																		goto end_IL_01d5;
																	case 'Ე':
																		goto end_IL_01fe;
																	case 'Ზ':
																		goto end_IL_022a;
																	case 'Ი':
																		goto end_IL_024b;
																	default:
																		goto end_IL_026d;
																	case 'Ლ':
																		((Control)Label7).set_ForeColor(Color.White);
																		((Control)Label7).set_Location(new Point(35, 27));
																		num = 17;
																		goto case 'Თ';
																	case 'Თ':
																		((Control)Label7).set_Name("Label7");
																		((Control)Label7).set_Size(new Size(92, 17));
																		num = 11;
																		goto case 'Ბ';
																	case 'Ბ':
																		((Control)Label7).set_TabIndex(13);
																		Label7.set_Text("Go To Main");
																		num = 27;
																		goto case 'Ს';
																	case 'Ს':
																		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
																		((Control)PictureBox1).set_Location(new Point(189, 104));
																		num = 25;
																		goto case 'Ჟ';
																	case 'Ჟ':
																		((Control)PictureBox1).set_Name("PictureBox1");
																		((Control)PictureBox1).set_Size(new Size(469, 346));
																		num = 32;
																		goto case 'Ღ';
																	case 'Ღ':
																		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
																		PictureBox1.set_TabIndex(15);
																		num = 19;
																		goto case 'Კ';
																	case 'Კ':
																		PictureBox1.set_TabStop(false);
																		Label1.set_AutoSize(true);
																		num = 26;
																		goto case 'Რ';
																	case 'Რ':
																		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
																		num = 1;
																		goto case 'ᲇ';
																	case 'ᲇ':
																		((Control)Label1).set_ForeColor(Color.White);
																		((Control)Label1).set_Location(new Point(170, 65));
																		num = 34;
																		goto case 'Შ';
																	case 'Შ':
																		((Control)Label1).set_Name("Label1");
																		goto case 'ᲆ';
																	case 'ᲆ':
																		((Control)Label1).set_Size(new Size(446, 17));
																		num = 8;
																		goto case '\u1c8e';
																	case '\u1c8e':
																		((Control)Label1).set_TabIndex(16);
																		Label1.set_Text("One fully-integrated software solution to manage your entire business");
																		num = 31;
																		goto case 'Ქ';
																	case 'Ქ':
																		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																		num = 33;
																		goto case 'Ყ';
																	case 'Ყ':
																		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																		((Form)this).set_ClientSize(new Size(800, 450));
																		num = 23;
																		goto case 'Ო';
																	case 'Ო':
																		((Control)this).get_Controls().Add((Control)(object)Label1);
																		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
																		num = 5;
																		goto case '\u1c8b';
																	case '\u1c8b':
																		((Control)this).get_Controls().Add((Control)(object)Label6);
																		((Control)this).get_Controls().Add((Control)(object)Label7);
																		num = 24;
																		goto case 'Პ';
																	case 'Პ':
																		((Control)this).get_Controls().Add((Control)(object)Label3);
																		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																		num = 28;
																		goto case 'Ტ';
																	case 'Ტ':
																		((Control)this).set_Name("frmBillingDetail");
																		((Form)this).set_StartPosition((FormStartPosition)1);
																		((Form)this).set_Text("frmBillingDetail");
																		num = 7;
																		goto case '\u1c8d';
																	case '\u1c8d':
																		((ISupportInitialize)PictureBox1).EndInit();
																		((Control)this).ResumeLayout(false);
																		((Control)this).PerformLayout();
																		num = 29;
																		return;
																	case 'Უ':
																		return;
																	}
																	continue;
																	end_IL_000f:
																	break;
																}
																continue;
																end_IL_00d5:
																break;
															}
															continue;
															end_IL_00f9:
															break;
														}
														continue;
														end_IL_010e:
														break;
													}
													continue;
													end_IL_011d:
													break;
												}
												continue;
												end_IL_0146:
												break;
											}
											continue;
											end_IL_0172:
											break;
										}
										continue;
										end_IL_0194:
										break;
									}
									continue;
									end_IL_01b4:
									break;
								}
								continue;
								end_IL_01d5:
								break;
							}
							continue;
							end_IL_01fe:
							break;
						}
						continue;
						end_IL_022a:
						break;
					}
					continue;
					end_IL_024b:
					break;
				}
				continue;
				end_IL_026d:
				break;
			}
		}
	}

	private void f3W(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void g3X(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void m8X(object sender, EventArgs e)
	{
	}

	internal static string Bf7(string[] Ze8, int Gw5, int Qt1)
	{
		string text = "";
		for (int i = Gw5; i <= Qt1; i = checked(i + 1))
		{
			text += Ze8[i];
		}
		string result = text.ToString();
		c0B.int_0[378] = (c0B.int_0[378] + Gw5) & 0xBA;
		return result;
	}

	internal static bool j2G(string Wa8)
	{
		bool flag;
		try
		{
			WebRequest webRequest = WebRequest.Create(Wa8);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			flag = false;
			ProjectData.ClearProjectError();
			goto IL_0023;
		}
		flag = true;
		goto IL_0023;
		IL_0023:
		bool result = flag;
		Ta8.char_0[341] = (char)((Ta8.char_0[341] | c0B.int_0[368]) & 'R');
		return result;
	}

	static void Zb2()
	{
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		if (num / num == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			j5Y = j5Y;
			j5Y = j5Y;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ws0)(object)j5Y1.Default;
			}
			finally
			{
				_ = (k8NS)j5Y1.Default;
				goto IL_0063;
			}
		}
		goto IL_0063;
		IL_05db:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		checked
		{
			try
			{
				try
				{
					try
					{
						c0B c0B = (c0B)(object)j5Y1.Default;
						cd0n = cd0n;
						j5Y = null;
					}
					finally
					{
						_ = (Gw13)(object)j5Y1.Default;
						goto end_IL_05dd;
					}
					end_IL_05dd:;
				}
				finally
				{
					_ = (Ws0)(object)j5Y1.Default;
					goto end_IL_05dc;
				}
				end_IL_05dc:;
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)j5Y1.Default) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (b2H1)j5Y1.Default;
				}
			}
			_ = (Cd0n)(object)j5Y1.Default;
			try
			{
				_ = (t1P)(object)j5Y1.Default;
				b2H1 b2H = b2H;
				b2H = b2H;
			}
			finally
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				catch
				{
					try
					{
						_ = (Ja24)(object)j5Y1.Default;
						Ja24 ja = (Ja24)(object)j5Y1.Default;
					}
					finally
					{
						_ = (c0B)(object)j5Y1.Default;
						goto end_IL_0678;
					}
					end_IL_0678:;
				}
				goto IL_06a5;
			}
		}
		IL_0835:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		checked
		{
			while ((object)j5Y1.Default != null)
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)default(UIntPtr)) != 0)
					{
						ma = ma;
					}
					else
					{
						_ = (z1J)(object)j5Y1.Default;
					}
				}
				while (obj3 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		try
		{
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Cd0n)(object)j5Y1.Default;
				ws = ws;
				Ja24 ja = null;
			}
			goto IL_086d;
		}
		IL_06a5:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tg0e tg0e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		checked
		{
			if (num + unchecked(checked(num * num) / checked(unchecked((nuint)(UIntPtr)j5Y1.Default / checked((unchecked((nuint)(UIntPtr)j5Y1.Default) - unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr)))) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
				try
				{
					ng = ng;
				}
				catch
				{
					while ((object)j5Y1.Default != null)
					{
						_ = j5Y1.Default;
					}
				}
			}
			num = default(UIntPtr);
			if (num == 0 && num == 0)
			{
				try
				{
					k8NS = default(k8NS);
					k8NS = k8NS;
				}
				catch
				{
					_ = (Tg0e)(object)j5Y1.Default;
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			if (num - unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				try
				{
					while (obj3 != null)
					{
						tg0e = (Tg0e)(object)j5Y1.Default;
					}
				}
				finally
				{
					if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
					{
						k8NS = k8NS;
					}
					else
					{
						_ = (t1P)(object)j5Y1.Default;
					}
					goto IL_0835;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				tg0e = tg0e;
			}
			else
			{
				_ = (o8W)(object)j5Y1.Default;
			}
		}
		finally
		{
			_ = (Br2)(object)j5Y1.Default;
			goto IL_0835;
		}
		IL_086d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					y9T y9T = (y9T)(object)j5Y1.Default;
				}
				catch
				{
					_ = (w5D)(object)j5Y1.Default;
					z1J = null;
					_ = (Ws0)(object)j5Y1.Default;
				}
			}
			catch
			{
				do
				{
					ws = ws;
					Ja24 ja = null;
					_ = (Br2)(object)j5Y1.Default;
				}
				while (obj3 != null);
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (w5D)(object)j5Y1.Default;
				}
				else
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
			}
			catch
			{
				_ = (Ma6)(object)j5Y1.Default;
			}
		}
		catch
		{
			w5D w5D = (w5D)(object)j5Y1.Default;
			w5D = w5D;
			ng = (Ng67)(object)j5Y1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		while (obj3 != null)
		{
			try
			{
				o8W o8W2 = (o8W)(object)j5Y1.Default;
			}
			finally
			{
				br = br;
				continue;
			}
		}
		return;
		IL_0063:
		try
		{
			ws = ws;
			ws = null;
			_ = (Ng67)(object)j5Y1.Default;
			_ = (n4NE)(object)j5Y1.Default;
		}
		finally
		{
			try
			{
				cd0n = cd0n;
				cd0n = cd0n;
			}
			catch
			{
				_ = (Ng67)(object)j5Y1.Default;
				obj3 = null;
			}
			goto IL_00b1;
		}
		IL_00b1:
		num = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(num - unchecked(checked(unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)(UIntPtr)j5Y1.Default)) / (nuint)(UIntPtr)j5Y1.Default)) == 0)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					_ = (z1J)(object)j5Y1.Default;
				}
			}
			else
			{
				_ = (c0B)(object)j5Y1.Default;
			}
		}
		tg0e = tg0e;
		tg0e = tg0e;
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Ma6 obj11 = (Ma6)(object)j5Y1.Default;
				ma = (Ma6)(object)j5Y1.Default;
				ma = obj11;
			}
			else
			{
				try
				{
					Br2 obj12 = (Br2)(object)j5Y1.Default;
					br = (Br2)(object)j5Y1.Default;
					br = obj12;
				}
				catch
				{
					ng = ng;
					ng = null;
					tg0e = tg0e;
					Ja24 ja = ja;
					ja = ja;
					br = (Br2)(object)j5Y1.Default;
				}
			}
		}
		else
		{
			try
			{
				do
				{
					c0B c0B = (c0B)(object)j5Y1.Default;
					c0B = c0B;
					n4NE n4NE = null;
					n4NE = n4NE;
					_ = (z1J)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W2);
				while (obj3 != null)
				{
					o8W2 = o8W2;
					o8W2 = o8W2;
				}
			}
		}
		do
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
			_003CModule_003E = _003CModule_003E;
			k8NS = k8NS;
			k8NS = default(k8NS);
			_ = (o8W)(object)j5Y1.Default;
		}
		while (obj3 != null);
		_ = (k8NS)j5Y1.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			z1J obj15 = (z1J)(object)j5Y1.Default;
			z1J = z1J;
			z1J = obj15;
		}
		try
		{
			while ((object)j5Y1.Default != null)
			{
				y9T y9T = (y9T)(object)j5Y1.Default;
				y9T = y9T;
			}
		}
		catch
		{
			try
			{
				do
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			finally
			{
				tg0e = (Tg0e)(object)j5Y1.Default;
				goto end_IL_02b0;
			}
			end_IL_02b0:;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Cd0n)(object)j5Y1.Default;
		}
		Ta8 ta = ta;
		ta = ta;
		_ = (Cd0n)(object)j5Y1.Default;
		_ = j5Y1.Default;
		do
		{
			try
			{
				_ = (Ja24)(object)j5Y1.Default;
			}
			catch
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
			finally
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
				_ = (o8W)(object)j5Y1.Default;
				_ = (b2H1)j5Y1.Default;
				continue;
			}
		}
		while (obj3 != null);
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (b2H1)j5Y1.Default;
			}
		}
		while (obj3 != null);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		if (num == 0)
		{
			if ((nuint)(UIntPtr)j5Y1.Default / num == 0)
			{
				try
				{
					j5Y = j5Y;
				}
				catch
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
			}
			else if (checked(num - (num + unchecked(checked(unchecked((nuint)(UIntPtr)j5Y1.Default) + num) / (nuint)(UIntPtr)j5Y1.Default))) == 0)
			{
				gw = (Gw13)(object)j5Y1.Default;
				gw = gw;
			}
		}
		else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (w5D)(object)j5Y1.Default;
			}
			catch
			{
				tg0e = tg0e;
			}
		}
		_ = (Br2)(object)j5Y1.Default;
		z1J = z1J;
		br = br;
		_ = (y9T)(object)j5Y1.Default;
		cd0n = null;
		do
		{
			try
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (Br2)(object)j5Y1.Default;
				}
			}
			finally
			{
				_ = (Ja24)(object)j5Y1.Default;
				_ = (Be5)(object)j5Y1.Default;
				j5Y = j5Y1.Default;
				continue;
			}
		}
		while (obj3 != null);
		while ((object)j5Y1.Default != null)
		{
			_ = (Br2)(object)j5Y1.Default;
		}
		_ = (_003CModule_003E)(object)j5Y1.Default;
		_ = (Tg0e)(object)j5Y1.Default;
		_ = (k8NS)j5Y1.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Ja24 ja = null;
			_ = (y9T)(object)j5Y1.Default;
			ja = (Ja24)(object)j5Y1.Default;
			_ = (t1P)(object)j5Y1.Default;
		}
		num = default(UIntPtr);
		checked
		{
			if (num == 0 && num * unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				do
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
				while (obj3 != null);
			}
			if (num == 0)
			{
				_ = (Ma6)(object)j5Y1.Default;
				j5Y = j5Y;
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Tg0e)(object)j5Y1.Default;
			_ = (_003CModule_003E)(object)j5Y1.Default;
			goto IL_05db;
		}
		try
		{
			_ = (k8NS)j5Y1.Default;
			_ = (t1P)(object)j5Y1.Default;
			br = null;
			z1J = z1J;
		}
		catch
		{
			gw = gw;
		}
		finally
		{
			try
			{
				c0B c0B = (c0B)(object)j5Y1.Default;
			}
			catch
			{
				br = (Br2)(object)j5Y1.Default;
			}
			goto IL_05db;
		}
	}

	static void w4H()
	{
		_ = (Tg0e)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		try
		{
			num = default(UIntPtr);
			num = num;
			num = default(UIntPtr);
			nuint num2 = num;
			UIntPtr num3 = (UIntPtr)j5Y1.Default;
			num = default(UIntPtr);
			if (num2 / checked(unchecked((nuint)num3) + num) == 0)
			{
				UIntPtr num4 = (UIntPtr)j5Y1.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num4) + num == 0)
					{
						c0B = (c0B)(object)j5Y1.Default;
						c0B = c0B;
						_ = (Tg0e)(object)j5Y1.Default;
					}
					else
					{
						_ = (n4NE)(object)j5Y1.Default;
					}
				}
			}
		}
		catch
		{
			try
			{
				_ = (o8W)(object)j5Y1.Default;
			}
			finally
			{
				t1P t1P = t1P;
				t1P = t1P;
				goto end_IL_0092;
			}
			end_IL_0092:;
		}
		_ = (Ta8)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W2);
		try
		{
			UIntPtr num5 = (UIntPtr)j5Y1.Default;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num5) - num != 0)
				{
					try
					{
						j5Y1 obj2 = j5Y1.Default;
						j5Y = j5Y;
						j5Y = obj2;
					}
					finally
					{
						_ = (t1P)(object)j5Y1.Default;
						c0B = (c0B)(object)j5Y1.Default;
						goto end_IL_00bf;
					}
				}
				_ = j5Y1.Default;
				obj3 = null;
			}
			end_IL_00bf:;
		}
		finally
		{
			try
			{
				try
				{
					j5Y = j5Y;
				}
				catch
				{
					_ = (k8NS)j5Y1.Default;
				}
			}
			catch
			{
				o8W obj5 = (o8W)(object)j5Y1.Default;
				o8W2 = o8W2;
				o8W2 = obj5;
			}
			goto IL_0159;
		}
		IL_05c3:
		try
		{
			o8W2 = o8W2;
		}
		finally
		{
			_ = (b2H1)j5Y1.Default;
			goto IL_05db;
		}
		IL_0159:
		_ = (z1J)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		try
		{
			if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					y9T y9T = y9T;
					y9T = y9T;
				}
				finally
				{
					_ = (b2H1)j5Y1.Default;
					goto end_IL_0164;
				}
			}
			while (obj3 != null)
			{
				b2H = b2H;
				b2H = default(b2H1);
				b2H = b2H;
			}
			end_IL_0164:;
		}
		finally
		{
			goto IL_01b8;
		}
		IL_01b8:
		Tg0e obj7 = (Tg0e)(object)j5Y1.Default;
		Tg0e tg0e = tg0e;
		tg0e = obj7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		if (num == 0)
		{
			do
			{
				br = br;
			}
			while (obj3 != null);
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				Ta8 ta = ta;
				ta = ta;
			}
			else
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				UIntPtr num6;
				UIntPtr num7;
				unchecked
				{
					num6 = (UIntPtr)j5Y1.Default;
					num7 = (UIntPtr)j5Y1.Default;
					num = default(UIntPtr);
				}
				if (unchecked((nuint)num6) * unchecked((nuint)num7 / num) * num == 0)
				{
					try
					{
						be = be;
						be = null;
					}
					catch
					{
						_ = (y9T)(object)j5Y1.Default;
					}
				}
			}
			else
			{
				k8NS = default(k8NS);
			}
			_ = (Gw13)(object)j5Y1.Default;
			_ = (_003CModule_003E)(object)j5Y1.Default;
			Ng67 ng = null;
			ng = ng;
			_ = (Ja24)(object)j5Y1.Default;
			if (num == 0)
			{
				try
				{
					do
					{
						Cd0n cd0n = (Cd0n)(object)j5Y1.Default;
						cd0n = cd0n;
					}
					while ((object)j5Y1.Default != null);
				}
				catch
				{
					try
					{
						_ = (Ta8)(object)j5Y1.Default;
						b2H = (b2H1)j5Y1.Default;
						o8W2 = null;
					}
					catch
					{
						b2H = default(b2H1);
						Gw13 gw = gw;
						n4NE = n4NE;
						n4NE = n4NE;
					}
				}
			}
			else
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
			o8W2 = (o8W)(object)j5Y1.Default;
		}
		try
		{
			if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w5D)(object)j5Y1.Default;
					_ = (n4NE)(object)j5Y1.Default;
					_ = (Cd0n)(object)j5Y1.Default;
				}
				finally
				{
					y9T y9T = (y9T)(object)j5Y1.Default;
					goto end_IL_0346;
				}
			}
			do
			{
				n4NE = n4NE;
			}
			while (obj3 != null);
			end_IL_0346:;
		}
		finally
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				Gw13 gw = null;
			}
			else
			{
				c0B = c0B;
			}
			goto IL_03c0;
		}
		IL_03c0:
		while (obj3 != null)
		{
			_ = (Ng67)(object)j5Y1.Default;
		}
		try
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
					_ = (w5D)(object)j5Y1.Default;
					b2H = b2H;
					_ = (b2H1)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			finally
			{
				if (num == 0)
				{
					_ = (Tg0e)(object)j5Y1.Default;
				}
				goto end_IL_03c6;
			}
			end_IL_03c6:;
		}
		finally
		{
			while ((object)j5Y1.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
			}
			goto IL_0440;
		}
		IL_05db:
		b2H = b2H;
		_ = (o8W)(object)j5Y1.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (w5D)(object)j5Y1.Default;
			}
			catch
			{
				_ = (k8NS)j5Y1.Default;
			}
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
			while (obj3 != null)
			{
				w5D = w5D;
				w5D = w5D;
			}
		}
		catch
		{
			c0B = (c0B)(object)j5Y1.Default;
		}
		finally
		{
			try
			{
				_ = (Br2)(object)j5Y1.Default;
			}
			catch
			{
				_ = (o8W)(object)j5Y1.Default;
			}
			goto IL_0667;
		}
		IL_074e:
		nuint num8 = checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr));
		num = default(UIntPtr);
		checked
		{
			if (num8 + num == 0)
			{
				_ = (Tg0e)(object)j5Y1.Default;
			}
			else
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (k8NS)j5Y1.Default;
				}
			}
			while ((object)j5Y1.Default != null)
			{
				if (num == 0)
				{
					while (obj3 != null)
					{
						_ = (n4NE)(object)j5Y1.Default;
					}
					continue;
				}
				nuint num9 = unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				if (num9 + num == 0)
				{
					b2H = (b2H1)j5Y1.Default;
				}
			}
			while ((object)j5Y1.Default != null)
			{
				while (obj3 != null)
				{
					if (num == 0)
					{
						tg0e = null;
					}
				}
			}
			be = be;
			return;
		}
		IL_0667:
		_ = (Ta8)(object)j5Y1.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (z1J)(object)j5Y1.Default;
				}
			}
			catch
			{
				while ((object)j5Y1.Default != null)
				{
					b2H = (b2H1)j5Y1.Default;
				}
			}
		}
		else
		{
			try
			{
				Ta8 ta = null;
			}
			catch
			{
				do
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
				while (obj3 != null);
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					Gw13 gw = (Gw13)(object)j5Y1.Default;
					_ = (Cd0n)(object)j5Y1.Default;
					_ = (Ja24)(object)j5Y1.Default;
					_ = (Gw13)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
				while (obj3 != null);
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					o8W2 = o8W2;
					k8NS = k8NS;
				}
			}
			goto IL_074e;
		}
		IL_0440:
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (k8NS)j5Y1.Default;
			}
		}
		else if (num == 0)
		{
			_ = (Ws0)(object)j5Y1.Default;
		}
		_ = (Cd0n)(object)j5Y1.Default;
		_ = (w5D)(object)j5Y1.Default;
		_ = (_003CModule_003E)(object)j5Y1.Default;
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				finally
				{
					_ = (z1J)(object)j5Y1.Default;
					goto IL_0501;
				}
			}
			do
			{
				_ = (z1J)(object)j5Y1.Default;
			}
			while (obj3 != null);
		}
		else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Tg0e)(object)j5Y1.Default;
			}
			catch
			{
				_ = (k8NS)j5Y1.Default;
			}
		}
		goto IL_0501;
		IL_0501:
		try
		{
			if (num == 0)
			{
				_ = j5Y1.Default;
			}
			else
			{
				Ng67 ng = null;
				_ = (Cd0n)(object)j5Y1.Default;
				_ = (c0B)(object)j5Y1.Default;
			}
		}
		catch
		{
			_ = (w5D)(object)j5Y1.Default;
			o8W2 = o8W2;
		}
		try
		{
			try
			{
				try
				{
					Ta8 ta = (Ta8)(object)j5Y1.Default;
				}
				finally
				{
					br = null;
					goto end_IL_054a;
				}
				end_IL_054a:;
			}
			finally
			{
				br = br;
				goto end_IL_0549;
			}
			end_IL_0549:;
		}
		finally
		{
			try
			{
				if (num / num == 0)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
					_ = (z1J)(object)j5Y1.Default;
					Cd0n cd0n = null;
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
				finally
				{
					_ = (Gw13)(object)j5Y1.Default;
					goto IL_05c3;
				}
			}
		}
	}
}
