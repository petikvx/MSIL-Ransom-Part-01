using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wi0;
using Xs3;
using c7R0;

namespace Hf5i;

[DesignerGenerated]
public class Fw02 : Form
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
			EventHandler eventHandler = a3D;
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

	public Fw02()
	{
		j9Q5();
	}

	[DebuggerNonUserCode]
	protected override void f2F3(bool n7C1)
	{
		try
		{
			if (n7C1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n7C1);
		}
	}

	[DebuggerStepThrough]
	private void j9Q5()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		byte[] byte_ = Pr5.byte_0;
		int num = 32;
		while (true)
		{
			Button1 = new Button();
			Button2 = new Button();
			txtUsername = new TextBox();
			num = 11;
			while (true)
			{
				txtPassword = new TextBox();
				Label1 = new Label();
				Label2 = new Label();
				num = 5;
				while (true)
				{
					Label3 = new Label();
					((Control)this).SuspendLayout();
					((ButtonBase)Button1).set_BackColor(Color.FromArgb(128, 128, 255));
					num = 9;
					while (true)
					{
						((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
						((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 4;
						while (true)
						{
							((Control)Button1).set_ForeColor(Color.White);
							((Control)Button1).set_Location(new Point(48, 137));
							switch (byte_[321])
							{
							case 178:
								break;
							case 183:
								goto end_IL_000e;
							case 179:
								goto end_IL_00fe;
							case 185:
								goto end_IL_012e;
							default:
								goto end_IL_0163;
							case 181:
								((Control)Button1).set_Name("Button1");
								((Control)Button1).set_Size(new Size(84, 29));
								num = 36;
								goto case 210;
							case 210:
								((Control)Button1).set_TabIndex(0);
								((ButtonBase)Button1).set_Text("Login");
								num = 35;
								goto case 209;
							case 209:
								((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
								((ButtonBase)Button2).set_BackColor(Color.FromArgb(128, 128, 255));
								num = 29;
								goto case 203;
							case 203:
								((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
								((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 19;
								goto case 193;
							case 193:
								((Control)Button2).set_ForeColor(Color.White);
								((Control)Button2).set_Location(new Point(149, 137));
								num = 25;
								goto case 184;
							case 184:
							case 199:
								((Control)Button2).set_Name("Button2");
								((Control)Button2).set_Size(new Size(84, 29));
								num = 13;
								goto case 187;
							case 187:
								((Control)Button2).set_TabIndex(1);
								((ButtonBase)Button2).set_Text("Cancel");
								num = 30;
								goto case 204;
							case 204:
								((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
								((Control)txtUsername).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 20;
								goto case 194;
							case 194:
								((TextBoxBase)txtUsername).set_ForeColor(Color.Purple);
								((Control)txtUsername).set_Location(new Point(139, 57));
								num = 14;
								goto case 188;
							case 188:
								((Control)txtUsername).set_Name("txtUsername");
								((Control)txtUsername).set_Size(new Size(104, 23));
								num = 21;
								goto case 195;
							case 195:
								((Control)txtUsername).set_TabIndex(2);
								txtUsername.set_TextAlign((HorizontalAlignment)2);
								num = 38;
								goto case 212;
							case 212:
								((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 18;
								goto case 192;
							case 192:
								((TextBoxBase)txtPassword).set_ForeColor(Color.Purple);
								((Control)txtPassword).set_Location(new Point(139, 96));
								num = 2;
								goto case 176;
							case 176:
								((Control)txtPassword).set_Name("txtPassword");
								txtPassword.set_PasswordChar('#');
								num = 33;
								goto case 207;
							case 207:
								((Control)txtPassword).set_Size(new Size(104, 23));
								((Control)txtPassword).set_TabIndex(3);
								num = 41;
								goto case 215;
							case 215:
								txtPassword.set_TextAlign((HorizontalAlignment)2);
								Label1.set_AutoSize(true);
								num = 12;
								goto case 186;
							case 186:
								((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 26;
								goto case 200;
							case 200:
								((Control)Label1).set_ForeColor(Color.White);
								((Control)Label1).set_Location(new Point(46, 56));
								goto case 213;
							case 213:
								num = 28;
								goto case 202;
							case 202:
								((Control)Label1).set_Name("Label1");
								((Control)Label1).set_Size(new Size(91, 17));
								num = 23;
								goto case 197;
							case 197:
								((Control)Label1).set_TabIndex(4);
								Label1.set_Text("Username :");
								num = 31;
								goto case 205;
							case 205:
								Label2.set_AutoSize(true);
								((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 40;
								goto case 214;
							case 214:
								((Control)Label2).set_ForeColor(Color.White);
								((Control)Label2).set_Location(new Point(46, 102));
								num = 37;
								goto case 211;
							case 211:
								((Control)Label2).set_Name("Label2");
								((Control)Label2).set_Size(new Size(87, 17));
								num = 17;
								goto case 191;
							case 191:
								((Control)Label2).set_TabIndex(5);
								Label2.set_Text("Password :");
								num = 24;
								goto case 198;
							case 198:
								Label3.set_AutoSize(true);
								((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 6;
								goto case 180;
							case 180:
								((Control)Label3).set_ForeColor(Color.White);
								((Control)Label3).set_Location(new Point(108, 22));
								num = 1;
								goto case 175;
							case 175:
								((Control)Label3).set_Name("Label3");
								((Control)Label3).set_Size(new Size(48, 17));
								num = 22;
								goto case 196;
							case 196:
								((Control)Label3).set_TabIndex(6);
								Label3.set_Text("Login");
								num = 43;
								goto case 217;
							case 217:
								((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
								((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
								num = 27;
								goto case 201;
							case 201:
								((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
								((Form)this).set_ClientSize(new Size(283, 189));
								num = 16;
								goto case 190;
							case 190:
								((Control)this).get_Controls().Add((Control)(object)Label3);
								((Control)this).get_Controls().Add((Control)(object)Label2);
								num = 42;
								goto case 216;
							case 216:
								((Control)this).get_Controls().Add((Control)(object)Label1);
								((Control)this).get_Controls().Add((Control)(object)txtPassword);
								num = 0;
								goto case 174;
							case 174:
							case 208:
								((Control)this).get_Controls().Add((Control)(object)txtUsername);
								((Control)this).get_Controls().Add((Control)(object)Button2);
								num = 15;
								goto case 189;
							case 189:
								((Control)this).get_Controls().Add((Control)(object)Button1);
								((Form)this).set_FormBorderStyle((FormBorderStyle)0);
								num = 8;
								goto case 182;
							case 182:
								((Control)this).set_Name("Login");
								((Form)this).set_StartPosition((FormStartPosition)1);
								((Form)this).set_Text("Login");
								num = 3;
								goto case 177;
							case 177:
								((Control)this).ResumeLayout(false);
								((Control)this).PerformLayout();
								return;
							}
							continue;
							end_IL_000e:
							break;
						}
						continue;
						end_IL_00fe:
						break;
					}
					continue;
					end_IL_012e:
					break;
				}
				continue;
				end_IL_0163:
				break;
			}
		}
	}

	private void a3D(object sender, EventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = b4C0.char_0;
		int num = 7;
		while (true)
		{
			bool flag = (Operators.CompareString(txtUsername.get_Text(), "admin", false) == 0) & (Operators.CompareString(txtPassword.get_Text(), "123", false) == 0);
			while (true)
			{
				num = 1;
				while (true)
				{
					if (flag)
					{
						num = 5;
						while (true)
						{
							MessageBox.Show("Login Successfully...!");
							i3F i3F = new i3F();
							((Control)i3F).Show();
							((Control)this).Hide();
							num = 3;
							while (true)
							{
								switch (char_[65])
								{
								case '\ue280':
									break;
								case '\ue282':
									goto end_IL_000f;
								case '\ue27e':
									goto end_IL_0047;
								case '\ue27d':
									goto end_IL_0068;
								default:
									goto end_IL_006d;
								case '\ue285':
									goto IL_00a9;
								case '\ue27f':
								case '\ue283':
									goto IL_00b4;
								case '\ue281':
									return;
								}
								continue;
								end_IL_000f:
								break;
							}
							continue;
							end_IL_0047:
							break;
						}
						continue;
					}
					num = 8;
					goto IL_00a9;
					IL_00a9:
					MessageBox.Show("Invalid Username or Password...!");
					goto IL_00b4;
					IL_00b4:
					num = 4;
					return;
					continue;
					end_IL_0068:
					break;
				}
				continue;
				end_IL_006d:
				break;
			}
		}
	}
}
