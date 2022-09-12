using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Xs5;
using e6H;
using q8B;

namespace Wz7;

[DesignerGenerated]
public class Be5 : Form
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
			char[] char_ = Ta8.char_0;
			int num = 7;
			while (true)
			{
				IL_0061:
				EventHandler eventHandler = n9X4;
				Button button = _Button1;
				Button obj = button;
				c0B.int_0[443] = (c0B.int_0[443] * c0B.int_0[446]) & 4;
				if (obj == null)
				{
					num = 5;
					goto IL_004a;
				}
				num = 0;
				goto IL_0043;
				IL_004a:
				while (true)
				{
					_Button1 = value;
					button = _Button1;
					if (button != null)
					{
						switch (char_[74])
						{
						case '惣':
							break;
						case '惨':
							continue;
						default:
							goto IL_0061;
						case '惦':
						case '惧':
							((Control)button).add_Click(eventHandler);
							return;
						case '惤':
						case '惥':
							return;
						}
						break;
					}
					num = 1;
					return;
				}
				goto IL_0043;
				IL_0043:
				((Control)button).remove_Click(eventHandler);
				goto IL_004a;
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

	public Be5()
	{
		Fa8();
	}

	[DebuggerNonUserCode]
	protected override void Jx4(bool q7F)
	{
		try
		{
			if (q7F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q7F);
		}
	}

	[DebuggerStepThrough]
	private void Fa8()
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		char[] char_ = Ta8.char_0;
		int num = 0;
		while (true)
		{
			Button1 = new Button();
			Button2 = new Button();
			txtUsername = new TextBox();
			num = 3;
			while (true)
			{
				txtPassword = new TextBox();
				Label1 = new Label();
				Label2 = new Label();
				num = 26;
				while (true)
				{
					Label3 = new Label();
					((Control)this).SuspendLayout();
					((ButtonBase)Button1).set_BackColor(Color.FromArgb(128, 128, 255));
					num = 37;
					while (true)
					{
						((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
						((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 12;
						while (true)
						{
							((Control)Button1).set_ForeColor(Color.White);
							((Control)Button1).set_Location(new Point(48, 137));
							num = 9;
							while (true)
							{
								((Control)Button1).set_Name("Button1");
								while (true)
								{
									((Control)Button1).set_Size(new Size(84, 29));
									switch (char_[16])
									{
									case 'შ':
										break;
									case 'ჯ':
										goto end_IL_000d;
									case 'ჲ':
										goto end_IL_00e7;
									case 'ჺ':
									case 'ᄋ':
										goto end_IL_00fc;
									case 'ᄀ':
										goto end_IL_0128;
									case 'ჩ':
										goto end_IL_0156;
									default:
										goto end_IL_018b;
									case 'ᄌ':
										((Control)Button1).set_TabIndex(0);
										((ButtonBase)Button1).set_Text("Login");
										num = 41;
										goto case 'ᄏ';
									case 'ᄏ':
										((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
										((ButtonBase)Button2).set_BackColor(Color.FromArgb(128, 128, 255));
										num = 5;
										goto case 'ძ';
									case 'ძ':
										((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
										goto case 'ᄐ';
									case 'ᄐ':
										((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 21;
										goto case '჻';
									case '჻':
										((Control)Button2).set_ForeColor(Color.White);
										((Control)Button2).set_Location(new Point(149, 137));
										num = 1;
										goto case 'ყ';
									case 'ყ':
										((Control)Button2).set_Name("Button2");
										((Control)Button2).set_Size(new Size(84, 29));
										num = 35;
										goto case 'ᄉ';
									case 'ᄉ':
										((Control)Button2).set_TabIndex(1);
										((ButtonBase)Button2).set_Text("Cancel");
										num = 13;
										goto case 'ჳ';
									case 'ჳ':
										((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
										((Control)txtUsername).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 17;
										goto case 'ჷ';
									case 'ჷ':
										((TextBoxBase)txtUsername).set_ForeColor(Color.Purple);
										((Control)txtUsername).set_Location(new Point(139, 57));
										num = 8;
										goto case 'ხ';
									case 'ხ':
										((Control)txtUsername).set_Name("txtUsername");
										((Control)txtUsername).set_Size(new Size(104, 23));
										num = 29;
										goto case 'ᄃ';
									case 'ᄃ':
										((Control)txtUsername).set_TabIndex(2);
										txtUsername.set_TextAlign((HorizontalAlignment)2);
										num = 33;
										goto case 'ᄇ';
									case 'ᄇ':
										((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 16;
										goto case 'ჶ';
									case 'ჶ':
										((TextBoxBase)txtPassword).set_ForeColor(Color.Purple);
										((Control)txtPassword).set_Location(new Point(139, 96));
										num = 28;
										goto case 'ᄂ';
									case 'ᄂ':
										((Control)txtPassword).set_Name("txtPassword");
										txtPassword.set_PasswordChar('#');
										num = 6;
										goto case 'წ';
									case 'წ':
										((Control)txtPassword).set_Size(new Size(104, 23));
										((Control)txtPassword).set_TabIndex(3);
										num = 15;
										goto case 'ჵ';
									case 'ჵ':
										txtPassword.set_TextAlign((HorizontalAlignment)2);
										Label1.set_AutoSize(true);
										num = 32;
										goto case 'ᄆ';
									case 'ᄆ':
										((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 7;
										goto case 'ჭ';
									case 'ჭ':
										((Control)Label1).set_ForeColor(Color.White);
										((Control)Label1).set_Location(new Point(46, 56));
										num = 19;
										goto case 'ჹ';
									case 'ჹ':
										((Control)Label1).set_Name("Label1");
										((Control)Label1).set_Size(new Size(91, 17));
										num = 14;
										goto case 'ჴ';
									case 'ჴ':
										((Control)Label1).set_TabIndex(4);
										Label1.set_Text("Username :");
										num = 18;
										goto case 'ჸ';
									case 'ჸ':
										Label2.set_AutoSize(true);
										((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 25;
										goto case 'ჿ';
									case 'ჿ':
										((Control)Label2).set_ForeColor(Color.White);
										((Control)Label2).set_Location(new Point(46, 102));
										num = 11;
										goto case 'ჱ';
									case 'ჱ':
										((Control)Label2).set_Name("Label2");
										((Control)Label2).set_Size(new Size(87, 17));
										num = 39;
										goto case 'ᄍ';
									case 'ᄍ':
										((Control)Label2).set_TabIndex(5);
										Label2.set_Text("Password :");
										num = 27;
										goto case 'ᄁ';
									case 'ᄁ':
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 22;
										goto case 'ჼ';
									case 'ჼ':
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(108, 22));
										num = 10;
										goto case 'ჰ';
									case 'ჰ':
										((Control)Label3).set_Name("Label3");
										((Control)Label3).set_Size(new Size(48, 17));
										num = 40;
										goto case 'ᄎ';
									case 'ᄎ':
										((Control)Label3).set_TabIndex(6);
										Label3.set_Text("Login");
										num = 43;
										goto case 'ᄑ';
									case 'ᄑ':
										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
										num = 36;
										goto case 'ᄊ';
									case 'ᄊ':
										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
										((Form)this).set_ClientSize(new Size(283, 189));
										num = 24;
										goto case 'ჾ';
									case 'ჾ':
										((Control)this).get_Controls().Add((Control)(object)Label3);
										((Control)this).get_Controls().Add((Control)(object)Label2);
										num = 23;
										goto case 'ჽ';
									case 'ჽ':
										((Control)this).get_Controls().Add((Control)(object)Label1);
										((Control)this).get_Controls().Add((Control)(object)txtPassword);
										num = 34;
										goto case 'ᄈ';
									case 'ᄈ':
										((Control)this).get_Controls().Add((Control)(object)txtUsername);
										((Control)this).get_Controls().Add((Control)(object)Button2);
										num = 30;
										goto case 'ᄄ';
									case 'ᄄ':
										((Control)this).get_Controls().Add((Control)(object)Button1);
										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
										num = 31;
										goto case 'ᄅ';
									case 'ᄅ':
										((Control)this).set_Name("Login");
										((Form)this).set_StartPosition((FormStartPosition)1);
										((Form)this).set_Text("Login");
										num = 4;
										goto case 'ც';
									case 'ც':
										((Control)this).ResumeLayout(false);
										((Control)this).PerformLayout();
										Ta8.char_0[88] = (char)((Ta8.char_0[88] | Ta8.char_0[259]) & '\u00b8');
										return;
									}
									continue;
									end_IL_000d:
									break;
								}
								continue;
								end_IL_00e7:
								break;
							}
							continue;
							end_IL_00fc:
							break;
						}
						continue;
						end_IL_0128:
						break;
					}
					continue;
					end_IL_0156:
					break;
				}
				continue;
				end_IL_018b:
				break;
			}
		}
	}

	private void n9X4(object sender, EventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		bool num = (Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0);
		c0B.int_0[432] = (c0B.int_0[432] ^ c0B.int_0[598]) & 0x26;
		if (num)
		{
			MessageBox.Show("Login Successfully...!");
			t1P t1P = new t1P();
			((Control)t1P).Show();
			((Control)this).Hide();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password...!");
		}
	}
}
