using System;
using System.ComponentModel;
using System.Data.SqlClient;
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
using c9P;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using k7R;
using q4PZ;
using s6N8;
using w0WN;
using x5PX;

namespace j6N2;

[DesignerGenerated]
public class Gn76 : Form
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
			EventHandler eventHandler = n5Q;
			Label label = _Label6;
			Label obj = label;
			Hi84.char_0[401] = (char)((Hi84.char_0[401] + Hi84.char_0[234]) & '%');
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
			EventHandler eventHandler = Hr1;
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

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("txtRcode")]
	internal virtual TextBox txtRcode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Md1;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnModify
	{
		[CompilerGenerated]
		get
		{
			return _btnModify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gr6;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			Button obj = val;
			Tf67.byte_0[83] = (byte)((Tf67.byte_0[83] - Tf67.byte_0[70]) & 0x83);
			if (obj != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtCategory")]
	internal virtual TextBox txtCategory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRName")]
	internal virtual TextBox txtRName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
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

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g1R;
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				Hi84.char_0[348] = (char)((Hi84.char_0[348] * Hi84.char_0[168]) & 'Ð');
			}
		}
	}

	public Gn76()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Lr4);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Xb1r();
	}

	[DebuggerNonUserCode]
	protected override void p9R7(bool q1AH)
	{
		byte[] byte_ = Tf67.byte_0;
		try
		{
			int num = 5;
			while (true)
			{
				if (!q1AH)
				{
					switch (byte_[1])
					{
					case 19:
						goto IL_003c;
					case 20:
					case 23:
						goto IL_004c;
					case 25:
						goto IL_0059;
					case 26:
						goto IL_005d;
					case 22:
						goto end_IL_0037;
					}
					continue;
				}
				num = 0;
				goto IL_003c;
				IL_004c:
				components.Dispose();
				goto IL_005d;
				IL_005d:
				num = 3;
				break;
				IL_003c:
				if (components != null)
				{
					num = 4;
					goto IL_004c;
				}
				goto IL_0059;
				IL_0059:
				num = 3;
				break;
				continue;
				end_IL_0037:
				break;
			}
		}
		finally
		{
			((Form)this).Dispose(q1AH);
		}
		Hi84.char_0[122] = (char)((Hi84.char_0[122] ^ Hi84.char_0[395]) & '\u0091');
	}

	[DebuggerStepThrough]
	private void Xb1r()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected O, but got Unknown
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected O, but got Unknown
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected O, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected O, but got Unknown
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Expected O, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected O, but got Unknown
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected O, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected O, but got Unknown
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Expected O, but got Unknown
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected O, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected O, but got Unknown
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected O, but got Unknown
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected O, but got Unknown
		char[] char_ = Hi84.char_0;
		byte[] byte_ = Tf67.byte_0;
		int num = 46;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 81;
			while (true)
			{
				txtWeight = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 3;
				while (true)
				{
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					Label5 = new Label();
					num = 47;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						txtRcode = new TextBox();
						num = 76;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							txtCategory = new TextBox();
							num = 37;
							while (true)
							{
								txtRName = new TextBox();
								txtAmount = new TextBox();
								Label2 = new Label();
								num = 79;
								while (true)
								{
									btnSave = new Button();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 8;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 16;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(320, 21));
											num = char_[144] - 2577;
											while (true)
											{
												switch (num)
												{
												case 80:
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 28;
													goto case 28;
												case 28:
													((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 26;
													goto case 26;
												case 26:
													((Control)Label6).set_ForeColor(Color.White);
													((Control)Label6).set_Location(new Point(734, 21));
													num = 39;
													goto case 39;
												case 39:
													((Control)Label6).set_Name("Label6");
													((Control)Label6).set_Size(new Size(18, 17));
													num = byte_[0] - 36;
													continue;
												case 78:
													((Control)btnDelete).set_Location(new Point(496, 202));
													((Control)btnDelete).set_Name("btnDelete");
													num = 38;
													goto case 38;
												case 38:
													((Control)btnDelete).set_Size(new Size(75, 31));
													((Control)btnDelete).set_TabIndex(8);
													num = 30;
													goto case 30;
												case 30:
													((ButtonBase)btnDelete).set_Text("DELETE");
													((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
													num = 52;
													goto case 52;
												case 52:
													((Control)btnModify).set_Location(new Point(378, 202));
													((Control)btnModify).set_Name("btnModify");
													num = 4;
													goto case 4;
												case 4:
													((Control)btnModify).set_Size(new Size(75, 31));
													((Control)btnModify).set_TabIndex(7);
													num = 61;
													goto case 61;
												case 61:
													((ButtonBase)btnModify).set_Text("MODIFY");
													((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
													num = 20;
													goto case 20;
												case 20:
													((Control)txtCategory).set_Location(new Point(243, 124));
													((Control)txtCategory).set_Name("txtCategory");
													num = 40;
													goto case 40;
												case 40:
													((Control)txtCategory).set_Size(new Size(100, 20));
													((Control)txtCategory).set_TabIndex(2);
													num = byte_[120] - byte_[94];
													continue;
												case 77:
													((Control)txtAmount).set_Location(new Point(537, 99));
													((Control)txtAmount).set_Name("txtAmount");
													num = 44;
													goto case 44;
												case 44:
													((Control)txtAmount).set_Size(new Size(100, 20));
													((Control)txtAmount).set_TabIndex(4);
													num = 27;
													goto case 27;
												case 27:
													Label2.set_AutoSize(true);
													((Control)Label2).set_ForeColor(Color.White);
													goto case 1;
												case 1:
													num = 0;
													goto case 0;
												case 0:
													((Control)Label2).set_Location(new Point(167, 67));
													((Control)Label2).set_Name("Label2");
													num = 29;
													goto case 29;
												case 29:
													((Control)Label2).set_Size(new Size(63, 13));
													((Control)Label2).set_TabIndex(90);
													num = 70;
													goto case 70;
												case 70:
													Label2.set_Text("Row Code :");
													((Control)btnSave).set_Location(new Point(249, 202));
													num = 72;
													goto case 72;
												case 72:
													((Control)btnSave).set_Name("btnSave");
													goto case 57;
												case 57:
													((Control)btnSave).set_Size(new Size(75, 31));
													num = 10;
													goto case 10;
												case 10:
													((Control)btnSave).set_TabIndex(6);
													((ButtonBase)btnSave).set_Text("SAVE");
													num = 56;
													goto case 56;
												case 56:
													((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
													((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
													num = 74;
													goto case 74;
												case 74:
													((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
													((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
													num = 41;
													goto case 41;
												case 41:
													((Form)this).set_ClientSize(new Size(800, 450));
													((Control)this).get_Controls().Add((Control)(object)txtWeight);
													num = 65;
													goto case 65;
												case 65:
													((Control)this).get_Controls().Add((Control)(object)Label10);
													((Control)this).get_Controls().Add((Control)(object)DataGridView1);
													num = 58;
													goto case 58;
												case 58:
													((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
													((Control)this).get_Controls().Add((Control)(object)Label8);
													num = byte_[1] - 20;
													continue;
												case 75:
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Purchase Detail");
													goto case 35;
												case 35:
													num = 80;
													goto case 80;
												case 73:
													((Control)Label5).set_TabIndex(93);
													Label5.set_Text("Raw Name :");
													num = 9;
													goto case 9;
												case 9:
													Label4.set_AutoSize(true);
													((Control)Label4).set_ForeColor(Color.White);
													num = 21;
													goto case 21;
												case 21:
													((Control)Label4).set_Location(new Point(466, 106));
													((Control)Label4).set_Name("Label4");
													num = 55;
													goto case 55;
												case 55:
													((Control)Label4).set_Size(new Size(49, 13));
													((Control)Label4).set_TabIndex(92);
													num = 60;
													goto case 60;
												case 60:
													Label4.set_Text("Amount :");
													Label1.set_AutoSize(true);
													num = 42;
													goto case 42;
												case 42:
													((Control)Label1).set_ForeColor(Color.White);
													((Control)Label1).set_Location(new Point(431, 67));
													num = 64;
													goto case 64;
												case 64:
													((Control)Label1).set_Name("Label1");
													((Control)Label1).set_Size(new Size(84, 13));
													num = 18;
													goto case 18;
												case 18:
													((Control)Label1).set_TabIndex(91);
													Label1.set_Text("Purchase Date :");
													num = 45;
													goto case 45;
												case 45:
													((Control)txtRcode).set_Location(new Point(245, 64));
													((Control)txtRcode).set_Name("txtRcode");
													num = 59;
													goto case 59;
												case 59:
													((Control)txtRcode).set_Size(new Size(100, 20));
													((Control)txtRcode).set_TabIndex(0);
													num = 78;
													goto case 78;
												case 71:
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(123, 17));
													num = 75;
													goto case 75;
												case 69:
													Label10.set_AutoSize(true);
													((Control)Label10).set_ForeColor(Color.White);
													num = 19;
													goto case 19;
												case 19:
													((Control)Label10).set_Location(new Point(478, 139));
													((Control)Label10).set_Name("Label10");
													num = 66;
													goto case 66;
												case 66:
													((Control)Label10).set_Size(new Size(47, 13));
													((Control)Label10).set_TabIndex(99);
													num = 32;
													goto case 32;
												case 32:
													Label10.set_Text("Weight :");
													DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
													num = 15;
													goto case 15;
												case 15:
													((Control)DataGridView1).set_Location(new Point(45, 239));
													((Control)DataGridView1).set_Name("DataGridView1");
													num = 17;
													goto case 17;
												case 17:
													((Control)DataGridView1).set_Size(new Size(724, 199));
													((Control)DataGridView1).set_TabIndex(11);
													num = 50;
													goto case 50;
												case 50:
													((Control)DateTimePicker1).set_Location(new Point(537, 64));
													((Control)DateTimePicker1).set_Name("DateTimePicker1");
													num = 54;
													goto case 54;
												case 54:
													((Control)DateTimePicker1).set_Size(new Size(126, 20));
													((Control)DateTimePicker1).set_TabIndex(3);
													num = 13;
													goto case 13;
												case 13:
													Label8.set_AutoSize(true);
													((Control)Label8).set_ForeColor(Color.White);
													num = 11;
													goto case 11;
												case 11:
													((Control)Label8).set_Location(new Point(166, 130));
													((Control)Label8).set_Name("Label8");
													num = 33;
													goto case 33;
												case 33:
													((Control)Label8).set_Size(new Size(55, 13));
													((Control)Label8).set_TabIndex(94);
													num = 14;
													goto case 14;
												case 14:
													Label8.set_Text("Category :");
													Label5.set_AutoSize(true);
													num = 25;
													goto case 25;
												case 25:
													((Control)Label5).set_ForeColor(Color.White);
													((Control)Label5).set_Location(new Point(156, 101));
													num = 51;
													goto case 51;
												case 51:
													((Control)Label5).set_Name("Label5");
													((Control)Label5).set_Size(new Size(66, 13));
													num = 73;
													goto case 73;
												case 68:
													((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 48;
													goto case 48;
												case 48:
													((Control)Label7).set_ForeColor(Color.White);
													((Control)Label7).set_Location(new Point(42, 21));
													num = 31;
													goto case 31;
												case 31:
													((Control)Label7).set_Name("Label7");
													((Control)Label7).set_Size(new Size(92, 17));
													num = 24;
													goto case 24;
												case 24:
													((Control)Label7).set_TabIndex(9);
													Label7.set_Text("Go To Main");
													num = 67;
													goto case 67;
												case 67:
													((Control)txtWeight).set_Location(new Point(537, 136));
													((Control)txtWeight).set_Name("txtWeight");
													num = 34;
													goto case 34;
												case 34:
													((Control)txtWeight).set_Size(new Size(100, 20));
													((Control)txtWeight).set_TabIndex(5);
													num = 69;
													goto case 69;
												case 36:
													((Control)txtRName).set_Location(new Point(243, 94));
													((Control)txtRName).set_Name("txtRName");
													num = char_[395] - 24695;
													continue;
												case 22:
													((Control)txtRName).set_Size(new Size(100, 20));
													((Control)txtRName).set_TabIndex(1);
													num = 77;
													goto case 77;
												case 12:
													Label7.set_AutoSize(true);
													((Control)Label7).set_BackColor(Color.Blue);
													num = 68;
													goto case 68;
												case 7:
													((Control)Label6).set_TabIndex(10);
													Label6.set_Text("X");
													num = 12;
													goto case 12;
												case 16:
													break;
												case 8:
													goto end_IL_0a7c;
												case 79:
													goto end_IL_0ab6;
												case 37:
													goto end_IL_0ae4;
												case 76:
													goto end_IL_0b04;
												case 47:
													goto end_IL_0b2a;
												case 3:
													goto end_IL_0b50;
												case 81:
													goto end_IL_0b76;
												default:
													goto end_IL_0b9c;
												case 5:
													((Control)this).get_Controls().Add((Control)(object)Label5);
													((Control)this).get_Controls().Add((Control)(object)Label4);
													num = 23;
													goto case 23;
												case 23:
													((Control)this).get_Controls().Add((Control)(object)Label1);
													((Control)this).get_Controls().Add((Control)(object)txtRcode);
													num = 63;
													goto case 63;
												case 63:
													((Control)this).get_Controls().Add((Control)(object)btnDelete);
													((Control)this).get_Controls().Add((Control)(object)btnModify);
													num = 2;
													goto case 2;
												case 2:
													((Control)this).get_Controls().Add((Control)(object)txtCategory);
													((Control)this).get_Controls().Add((Control)(object)txtRName);
													num = 6;
													goto case 6;
												case 6:
													((Control)this).get_Controls().Add((Control)(object)txtAmount);
													((Control)this).get_Controls().Add((Control)(object)Label2);
													num = 49;
													goto case 49;
												case 49:
													((Control)this).get_Controls().Add((Control)(object)btnSave);
													((Control)this).get_Controls().Add((Control)(object)Label6);
													num = 53;
													goto case 53;
												case 53:
													((Control)this).get_Controls().Add((Control)(object)Label7);
													((Control)this).get_Controls().Add((Control)(object)Label3);
													num = 82;
													goto case 82;
												case 82:
													((Form)this).set_FormBorderStyle((FormBorderStyle)0);
													((Control)this).set_Name("frmPurchaseDetail");
													((Form)this).set_StartPosition((FormStartPosition)1);
													num = 62;
													goto case 62;
												case 62:
													((Form)this).set_Text("frmPurchaseDetail");
													((ISupportInitialize)DataGridView1).EndInit();
													((Control)this).ResumeLayout(false);
													num = 43;
													goto case 43;
												case 43:
													((Control)this).PerformLayout();
													return;
												}
												break;
											}
											continue;
											end_IL_0a7c:
											break;
										}
										continue;
										end_IL_0ab6:
										break;
									}
									continue;
									end_IL_0ae4:
									break;
								}
								continue;
								end_IL_0b04:
								break;
							}
							continue;
							end_IL_0b2a:
							break;
						}
						continue;
						end_IL_0b50:
						break;
					}
					continue;
					end_IL_0b76:
					break;
				}
				continue;
				end_IL_0b9c:
				break;
			}
		}
	}

	private void Hr1(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void n5Q(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Lr4(object sender, EventArgs e)
	{
		i2A();
	}

	private void g1R(object sender, EventArgs e)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = Hi84.char_0;
		try
		{
			int num = 3;
			while (true)
			{
				cn.Open();
				while (true)
				{
					cmd.set_Connection(cn);
					while (true)
					{
						num = 2;
						while (true)
						{
							cmd.set_CommandText("insert into tbl_purchase_detail values(" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())) + ",'" + txtRName.get_Text() + "','" + txtCategory.get_Text() + "','" + DateTimePicker1.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", " + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " )");
							switch (char_[183])
							{
							case '₋':
							case '₍':
								break;
							case 'ₑ':
								goto end_IL_000d;
							case '\u208f':
								goto end_IL_0104;
							default:
								goto end_IL_010b;
							case '₌':
								cmd.ExecuteReader();
								MessageBox.Show("Record Saved");
								goto end_IL_011e;
							}
							continue;
							end_IL_000d:
							break;
						}
						continue;
						end_IL_0104:
						break;
					}
					continue;
					end_IL_010b:
					break;
				}
				continue;
				end_IL_011e:
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		i2A();
	}

	public void i2A()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_purchase_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Raw Code");
			DataGridView1.get_Columns().Add("c2", "Raw Name");
			DataGridView1.get_Columns().Add("c3", "Category");
			DataGridView1.get_Columns().Add("c4", "Purchase Date");
			DataGridView1.get_Columns().Add("c5", "Amount");
			DataGridView1.get_Columns().Add("c6", "Weight");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("rowcode").ToString(),
					rd.get_Item("rowname"),
					rd.get_Item("category"),
					rd.get_Item("purdate"),
					rd.get_Item("amount"),
					rd.get_Item("weight")
				});
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
	}

	internal static byte[] q3Q(int m8T)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return a9X.a4E(k4C9.q8E5(), m8T);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void Gr6(object sender, EventArgs e)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_purchase_detail set rowname ='" + txtRName.get_Text() + "',category='" + txtCategory.get_Text() + "',purdate='" + DateTimePicker1.get_Text() + "',amount=" + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", weight=" + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Modified");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		i2A();
	}

	private void Md1(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_purchase_detail where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Deleted");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		i2A();
	}

	static void p8Z()
	{
		w0A w0A = null;
		w0A = w0A;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		try
		{
			_ = (Tf67)(object)o0E3.Default;
		}
		catch
		{
			try
			{
				Gn76 obj = (Gn76)(object)o0E3.Default;
				gn = (Gn76)(object)o0E3.Default;
				gn = obj;
			}
			catch
			{
				_ = (p9B)(object)o0E3.Default;
			}
			finally
			{
				_ = (x4N6)(object)o0E3.Default;
				_ = (x4N6)(object)o0E3.Default;
				Zn1b obj3 = (Zn1b)(object)o0E3.Default;
				zn1b = zn1b;
				zn1b = obj3;
				goto end_IL_001d;
			}
			end_IL_001d:;
		}
		object obj5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		while (true)
		{
			obj5 = o0E3.Default;
			if (obj5 == null)
			{
				break;
			}
			uIntPtr = (UIntPtr)o0E3.Default;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					zn1b = (Zn1b)(object)o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
					_003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
					_003CModule_003E = null;
					_ = (w8W)o0E3.Default;
				}
				finally
				{
					zn1b = null;
					continue;
				}
			}
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = o0E3.Default;
			}
		}
		_ = (Tf67)(object)o0E3.Default;
		g9Z g9Z = g9Z;
		g9Z = g9Z;
		_ = (x4N6)(object)o0E3.Default;
		_ = (Hi84)(object)o0E3.Default;
		_ = (Pg2c)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (p9B)(object)o0E3.Default;
		}
		else
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
					p9B obj6 = (p9B)(object)o0E3.Default;
					p9B = (p9B)(object)o0E3.Default;
					p9B = obj6;
				}
				finally
				{
					tf = null;
					tf = tf;
					_ = (g9Z)(object)o0E3.Default;
					_ = (Pg2c)(object)o0E3.Default;
					goto IL_01b3;
				}
			}
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				Sf06 obj7 = (Sf06)(object)o0E3.Default;
				sf = sf;
				sf = obj7;
			}
		}
		goto IL_01b3;
		IL_087d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Et0)o0E3.Default;
			}
		}
		catch
		{
			gn = (Gn76)(object)o0E3.Default;
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					dg = dg;
				}
			}
			else
			{
				try
				{
					i5NX = (i5NX)(object)o0E3.Default;
				}
				catch
				{
					k4C = (k4C9)(object)o0E3.Default;
					tf = null;
				}
			}
			goto IL_08f4;
		}
		IL_08f4:
		try
		{
			try
			{
				w0A = (w0A)(object)o0E3.Default;
				_ = (x4N6)(object)o0E3.Default;
			}
			finally
			{
				i5NX = null;
				goto end_IL_08f6;
			}
			end_IL_08f6:;
		}
		catch
		{
			i5NX = (i5NX)(object)o0E3.Default;
		}
		finally
		{
			do
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					sf = sf;
				}
			}
			while ((object)o0E3.Default != null);
			goto IL_0972;
		}
		IL_0739:
		_ = (a9X)(object)o0E3.Default;
		_ = (f5R4)(object)o0E3.Default;
		zn1b = zn1b;
		gn = gn;
		while (true)
		{
			if (obj5 != null)
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			else if (obj5 == null)
			{
				break;
			}
		}
		do
		{
			if ((nuint)(UIntPtr)o0E3.Default / (nuint)(UIntPtr)o0E3.Default == 0)
			{
				_ = (f5R4)(object)o0E3.Default;
				_ = (k4C9)(object)o0E3.Default;
				p9B = p9B;
			}
		}
		while ((object)o0E3.Default != null);
		while (obj5 != null)
		{
			try
			{
				_ = (Hi84)(object)o0E3.Default;
				_ = o0E3.Default;
				a9X a9X = null;
				_ = (i5NX)(object)o0E3.Default;
			}
			catch
			{
				a9X a9X = (a9X)(object)o0E3.Default;
			}
		}
		try
		{
			try
			{
				do
				{
					k0WR k0WR = null;
				}
				while (obj5 != null);
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Dg19)(object)o0E3.Default;
					_ = (w8W)o0E3.Default;
					tf = (Tf67)(object)o0E3.Default;
				}
				else
				{
					w0A = w0A;
					_ = (Zn1b)(object)o0E3.Default;
					k4C = k4C;
					_003CModule_003E = _003CModule_003E;
				}
				goto end_IL_0803;
			}
			end_IL_0803:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
			}
			goto IL_087d;
		}
		IL_04d8:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		checked
		{
			try
			{
				do
				{
					try
					{
						f5R = f5R;
					}
					finally
					{
						_ = (Zn1b)(object)o0E3.Default;
						p9B = p9B;
						continue;
					}
				}
				while ((object)o0E3.Default != null);
			}
			finally
			{
				nuint num = unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (num - uIntPtr == 0)
				{
					if (unchecked((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u))
					{
						_ = (p9B)(object)o0E3.Default;
					}
					else
					{
						_ = (a9X)(object)o0E3.Default;
					}
				}
				goto IL_0596;
			}
		}
		IL_044f:
		_ = (Hi84)(object)o0E3.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
			{
				try
				{
					try
					{
						a9X a9X = a9X;
						o0E3 o0E = o0E;
						o0E = o0E;
					}
					finally
					{
						f5R4 obj12 = (f5R4)(object)o0E3.Default;
						f5R = f5R;
						f5R = obj12;
						_ = (Et0)o0E3.Default;
						k0WR k0WR = (k0WR)(object)o0E3.Default;
						_ = (Tf67)(object)o0E3.Default;
						goto end_IL_0471;
					}
					end_IL_0471:;
				}
				finally
				{
					do
					{
						_003CModule_003E = null;
					}
					while (obj5 != null);
					goto IL_04d8;
				}
			}
			goto IL_04d8;
		}
		IL_0596:
		while (obj5 != null)
		{
			try
			{
				try
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
				finally
				{
					_ = (w1H)(object)o0E3.Default;
					goto end_IL_055c;
				}
				end_IL_055c:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					k0WR k0WR = null;
					_ = (f5R4)(object)o0E3.Default;
					g9Z = null;
				}
				continue;
			}
		}
		nuint num2 = uIntPtr;
		UIntPtr num3 = (UIntPtr)o0E3.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		if (num2 / checked(unchecked((nuint)num3) * (uIntPtr * unchecked((nuint)(UIntPtr)o0E3.Default))) == 0)
		{
			checked
			{
				try
				{
					do
					{
						_ = (Pg2c)(object)o0E3.Default;
						dg = (Dg19)(object)o0E3.Default;
						dg = null;
						_003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
						i5NX = i5NX;
					}
					while (obj5 != null);
				}
				catch
				{
					nuint num4 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (num4 - (unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0)
					{
						w8W = (w8W)o0E3.Default;
					}
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr == 0)
				{
					if (uIntPtr * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
					{
						tf = tf;
					}
				}
				else
				{
					gn = (Gn76)(object)o0E3.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		try
		{
			et = et;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				catch
				{
					_ = (f5R4)(object)o0E3.Default;
					w0A = (w0A)(object)o0E3.Default;
				}
			}
			goto IL_06cd;
		}
		IL_0382:
		UIntPtr num5 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num5) + uIntPtr == 0)
			{
				try
				{
					_ = (Hi84)(object)o0E3.Default;
				}
				finally
				{
					try
					{
						_ = (x4N6)(object)o0E3.Default;
					}
					finally
					{
						_ = (x4N6)(object)o0E3.Default;
						_ = (w8W)o0E3.Default;
						x4N6 x4N = x4N;
						x4N = x4N;
						goto IL_044f;
					}
				}
			}
			try
			{
				if ((uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default)) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					w0A = (w0A)(object)o0E3.Default;
				}
				else
				{
					w8W = w8W;
					_ = (Pg2c)(object)o0E3.Default;
					_ = (w0A)(object)o0E3.Default;
					_ = (w1H)(object)o0E3.Default;
				}
			}
			finally
			{
				try
				{
					x4N6 x4N = null;
				}
				finally
				{
					zn1b = zn1b;
					goto IL_044f;
				}
			}
		}
		IL_01b3:
		try
		{
			i5NX = i5NX;
			i5NX = i5NX;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Gn76)(object)o0E3.Default;
				}
				finally
				{
					w8W = (w8W)o0E3.Default;
					w8W = w8W;
					goto end_IL_01ca;
				}
				end_IL_01ca:;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				else
				{
					w0A = w0A;
				}
				goto IL_0285;
			}
		}
		IL_0285:
		do
		{
			if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					p9B = p9B;
					continue;
				}
				_ = (Dg19)(object)o0E3.Default;
				_ = (k4C9)(object)o0E3.Default;
				_ = (Hi84)(object)o0E3.Default;
				continue;
			}
			try
			{
				et = et;
				et = et;
			}
			finally
			{
				k4C = k4C;
				k4C = k4C;
				_ = (Tf67)(object)o0E3.Default;
				continue;
			}
		}
		while (obj5 != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr != (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (w1H)(object)o0E3.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					tf = (Tf67)(object)o0E3.Default;
				}
				catch
				{
					_ = (k4C9)(object)o0E3.Default;
				}
			}
			while (obj5 != null);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (f5R4)(object)o0E3.Default;
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (i5NX)(object)o0E3.Default;
		}
		while ((object)o0E3.Default != null)
		{
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (a9X)(object)o0E3.Default;
				}
				finally
				{
					g9Z = g9Z;
					w1H = (w1H)(object)o0E3.Default;
					w1H = w1H;
					goto end_IL_032c;
				}
				end_IL_032c:;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					k0WR k0WR = k0WR;
					k0WR = k0WR;
				}
				goto IL_0382;
			}
		}
		p9B = p9B;
		goto IL_0382;
		IL_0972:
		while (true)
		{
			if ((object)o0E3.Default != null)
			{
				while (obj5 != null)
				{
					zn1b = null;
				}
			}
			else if ((object)o0E3.Default == null)
			{
				break;
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		else
		{
			x4N6 x4N = (x4N6)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (p9B)(object)o0E3.Default;
				}
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (w8W)o0E3.Default;
				}
			}
		}
		try
		{
			_ = (i5NX)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				sf = (Sf06)(object)o0E3.Default;
				g9Z = g9Z;
				_ = (k0WR)(object)o0E3.Default;
			}
			catch
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				catch
				{
					_ = (p9B)(object)o0E3.Default;
				}
			}
			goto IL_0a33;
		}
		IL_0a33:
		if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
		{
			do
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					w1H = w1H;
				}
			}
			while (obj5 != null);
		}
		try
		{
			while (obj5 != null)
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			return;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w1H)(object)o0E3.Default;
					return;
				}
				catch
				{
					tf = null;
					return;
				}
			}
			_ = (i5NX)(object)o0E3.Default;
			i5NX = null;
			return;
		}
		IL_06cd:
		try
		{
			if ((nuint)(UIntPtr)o0E3.Default / (uIntPtr / checked(unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)(UIntPtr)o0E3.Default))) == 0)
			{
				try
				{
					f5R = null;
				}
				catch
				{
					_ = o0E3.Default;
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr * unchecked(uIntPtr / uIntPtr) == 0)
				{
					try
					{
						tf = tf;
					}
					finally
					{
						x4N6 x4N = null;
						goto IL_0739;
					}
				}
				goto IL_0739;
			}
		}
	}

	static void t7G()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		try
		{
			UIntPtr num = (UIntPtr)o0E3.Default;
			num2 = default(UIntPtr);
			checked
			{
				num2 = unchecked((nuint)num) * (num2 + unchecked((nuint)(UIntPtr)o0E3.Default));
			}
			if (num2 == 0)
			{
				sf = null;
				sf = null;
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				w8W = w8W;
				w8W = default(w8W);
				w8W = w8W;
			}
		}
		finally
		{
			w1H = w1H;
			w1H = null;
			goto IL_0071;
		}
		IL_0071:
		_ = (w1H)(object)o0E3.Default;
		w0A w0A = w0A;
		w0A = w0A;
		_ = (w8W)o0E3.Default;
		object obj = null;
		do
		{
			w0A = w0A;
		}
		while ((object)o0E3.Default != null);
		x4N6 x4N;
		try
		{
			k0WR k0WR = (k0WR)(object)o0E3.Default;
			k0WR = k0WR;
		}
		finally
		{
			x4N = null;
			x4N = x4N;
			goto IL_00fb;
		}
		IL_0692:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		try
		{
			_ = (Sf06)(object)o0E3.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = o0E3.Default;
				x4N = x4N;
				dg = null;
				goto IL_06ff;
			}
			try
			{
				hi = hi;
			}
			finally
			{
				_ = (g9Z)(object)o0E3.Default;
				Tf67 tf = tf;
				tf = tf;
				_ = (w1H)(object)o0E3.Default;
				goto IL_06ff;
			}
		}
		IL_06ff:
		if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)o0E3.Default) * (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)))) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (k0WR)(object)o0E3.Default;
					k0WR k0WR = null;
					_ = (Zn1b)(object)o0E3.Default;
				}
				else
				{
					sf = null;
				}
			}
			else
			{
				do
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			w8W = w8W;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Pg2c pg2c = (Pg2c)(object)o0E3.Default;
				}
				finally
				{
					_ = (Gn76)(object)o0E3.Default;
					goto end_IL_0797;
				}
			}
			do
			{
				x4N = x4N;
			}
			while (obj != null);
			end_IL_0797:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					g9Z = g9Z;
					_ = (k0WR)(object)o0E3.Default;
				}
			}
		}
		while ((object)o0E3.Default != null);
		return;
		IL_00fb:
		while (obj != null)
		{
			try
			{
				_ = (i5NX)(object)o0E3.Default;
			}
			catch
			{
				while (obj != null)
				{
					_ = o0E3.Default;
				}
			}
		}
		_ = (Sf06)(object)o0E3.Default;
		while ((object)o0E3.Default != null)
		{
			_ = (Dg19)(object)o0E3.Default;
			_ = (p9B)(object)o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		try
		{
			try
			{
				_ = (a9X)(object)o0E3.Default;
				Zn1b obj5 = (Zn1b)(object)o0E3.Default;
				zn1b = (Zn1b)(object)o0E3.Default;
				zn1b = obj5;
				_ = (p9B)(object)o0E3.Default;
			}
			finally
			{
				_ = (a9X)(object)o0E3.Default;
				_ = (w1H)(object)o0E3.Default;
				_ = (k4C9)(object)o0E3.Default;
				g9Z = g9Z;
				g9Z = g9Z;
				goto end_IL_0132;
			}
			end_IL_0132:;
		}
		catch
		{
			try
			{
				_ = o0E3.Default;
			}
			catch
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			while ((object)o0E3.Default != null)
			{
			}
			goto IL_01d0;
		}
		IL_0595:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		checked
		{
			if (unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
			{
				try
				{
					try
					{
						_ = (k4C9)(object)o0E3.Default;
					}
					catch
					{
						w0A = (w0A)(object)o0E3.Default;
					}
				}
				catch
				{
					try
					{
						_ = (Sf06)(object)o0E3.Default;
					}
					finally
					{
						w1H = w1H;
						_ = o0E3.Default;
						_ = (w1H)(object)o0E3.Default;
						_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
						goto end_IL_05cd;
					}
					end_IL_05cd:;
				}
			}
			else
			{
				_ = (Sf06)(object)o0E3.Default;
			}
			try
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			catch
			{
				o0E3 o0E = o0E3.Default;
				o0E = o0E;
				f5R = null;
				_ = (g9Z)(object)o0E3.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		try
		{
			nuint num3 = num2;
			num2 = default(UIntPtr);
			if (checked(num3 * num2) / num2 == 0)
			{
				do
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				while (obj != null);
			}
			else
			{
				_ = (g9Z)(object)o0E3.Default;
			}
		}
		finally
		{
			k4C = k4C;
			goto IL_0692;
		}
		IL_0493:
		if (num2 == 0)
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				catch
				{
					_ = (w8W)o0E3.Default;
				}
			}
		}
		else
		{
			sf = (Sf06)(object)o0E3.Default;
		}
		dg = dg;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		try
		{
			if (num2 == 0)
			{
				hi = hi;
			}
			else
			{
				try
				{
					_ = (i5NX)(object)o0E3.Default;
					_ = (i5NX)(object)o0E3.Default;
				}
				catch
				{
					_ = (a9X)(object)o0E3.Default;
				}
			}
		}
		finally
		{
			if (checked(num2 + num2) == 0)
			{
				et = default(Et0);
			}
			goto IL_0533;
		}
		IL_0533:
		try
		{
			do
			{
				try
				{
					_ = (Gn76)(object)o0E3.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				finally
				{
					w0A = w0A;
					k4C = null;
					k4C = k4C;
					goto IL_0595;
				}
			}
			_ = (Sf06)(object)o0E3.Default;
			goto IL_0595;
		}
		IL_01d0:
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				nuint num4 = num2;
				num2 = default(UIntPtr);
				checked
				{
					if (num4 + unchecked(num2 / num2) == 0)
					{
						_ = (x4N6)(object)o0E3.Default;
					}
					else
					{
						_ = (w0A)(object)o0E3.Default;
					}
				}
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					x4N = (x4N6)(object)o0E3.Default;
				}
				finally
				{
					_ = (w8W)o0E3.Default;
					_ = (Sf06)(object)o0E3.Default;
					goto IL_0251;
				}
			}
			goto IL_0251;
		}
		IL_0251:
		do
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		while (obj != null);
		do
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					f5R = f5R;
					f5R = null;
					continue;
				}
				sf = sf;
				hi = hi;
				hi = hi;
				w1H = (w1H)(object)o0E3.Default;
				sf = null;
			}
			catch
			{
				while (obj != null)
				{
					g9Z = g9Z;
				}
			}
		}
		while (obj != null);
		_ = (a9X)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		while (obj != null)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					gn = (Gn76)(object)o0E3.Default;
					gn = gn;
				}
				else
				{
					gn = gn;
					_ = (g9Z)(object)o0E3.Default;
				}
				continue;
			}
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				dg = (Dg19)(object)o0E3.Default;
				dg = dg;
				_ = (i5NX)(object)o0E3.Default;
				sf = sf;
				zn1b = zn1b;
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (w8W)o0E3.Default;
				}
			}
		}
		if (checked(unchecked((nuint)(UIntPtr)o0E3.Default) + num2) == 0)
		{
			_ = (k4C9)(object)o0E3.Default;
		}
		else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				x4N = (x4N6)(object)o0E3.Default;
				et = et;
				et = et;
			}
		}
		else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		_ = (p9B)(object)o0E3.Default;
		_ = o0E3.Default;
		_ = (x4N6)(object)o0E3.Default;
		try
		{
			try
			{
				_ = (p9B)(object)o0E3.Default;
			}
			finally
			{
				et = et;
				_ = (w8W)o0E3.Default;
				k0WR k0WR = (k0WR)(object)o0E3.Default;
				goto end_IL_041c;
			}
			end_IL_041c:;
		}
		catch
		{
			_ = (g9Z)(object)o0E3.Default;
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					Pg2c obj15 = (Pg2c)(object)o0E3.Default;
					Pg2c pg2c = pg2c;
					pg2c = obj15;
				}
			}
			goto IL_0493;
		}
	}

	static void Da1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Gn76)(object)o0E3.Default;
			}
		}
		catch
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						g9Z obj2 = (g9Z)(object)o0E3.Default;
						g9Z = g9Z;
						g9Z = obj2;
						continue;
					}
					break;
				}
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				p9B obj3 = (p9B)(object)o0E3.Default;
				p9B = (p9B)(object)o0E3.Default;
				p9B = obj3;
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Sf06)(object)o0E3.Default;
				_ = (a9X)(object)o0E3.Default;
			}
			finally
			{
				goto IL_0097;
			}
		}
		goto IL_0097;
		IL_0713:
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
			while (obj != null)
			{
				a9X = a9X;
			}
		}
		finally
		{
			_ = (Zn1b)(object)o0E3.Default;
			goto IL_0734;
		}
		IL_0356:
		do
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = o0E3.Default;
				}
				else
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
			}
			catch
			{
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		while (obj != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					k0WR obj6 = (k0WR)(object)o0E3.Default;
					k0WR = null;
					k0WR = obj6;
				}
				else
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
			}
			catch
			{
				_ = o0E3.Default;
			}
		}
		Gn76 obj8 = (Gn76)(object)o0E3.Default;
		Gn76 gn = gn;
		gn = obj8;
		try
		{
			while ((object)o0E3.Default != null)
			{
			}
		}
		catch
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				g9Z g9Z = null;
			}
		}
		_ = (_003CModule_003E)(object)o0E3.Default;
		gn = null;
		if (uIntPtr == 0)
		{
			do
			{
				try
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				catch
				{
					_ = (k4C9)(object)o0E3.Default;
				}
			}
			while (obj != null);
			goto IL_0468;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		try
		{
			do
			{
				_ = (k0WR)(object)o0E3.Default;
				et = (Et0)o0E3.Default;
			}
			while (obj != null);
		}
		finally
		{
			_ = (a9X)(object)o0E3.Default;
			goto IL_0468;
		}
		IL_0097:
		w0A obj11 = (w0A)(object)o0E3.Default;
		w0A w0A = w0A;
		w0A = obj11;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					Pg2c obj12 = (Pg2c)(object)o0E3.Default;
					pg2c = pg2c;
					pg2c = obj12;
				}
				finally
				{
					_ = o0E3.Default;
					goto end_IL_00bd;
				}
				end_IL_00bd:;
			}
			finally
			{
				do
				{
					_ = (Sf06)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
				goto IL_010c;
			}
		}
		goto IL_010c;
		IL_0787:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					pg2c = pg2c;
				}
				else
				{
					pg2c = pg2c;
				}
				goto IL_07ca;
			}
		}
		goto IL_07ca;
		IL_010c:
		while ((object)o0E3.Default != null)
		{
			while ((object)o0E3.Default != null)
			{
			}
		}
		checked
		{
			if ((uIntPtr * unchecked((nuint)(UIntPtr)o0E3.Default) + uIntPtr) * uIntPtr * uIntPtr == 0)
			{
				try
				{
					_ = (p9B)(object)o0E3.Default;
				}
				finally
				{
					_ = (a9X)(object)o0E3.Default;
					goto IL_018a;
				}
			}
			_ = (i5NX)(object)o0E3.Default;
			goto IL_018a;
		}
		IL_0468:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num = checked((uIntPtr * uIntPtr + uIntPtr + uIntPtr) * uIntPtr);
				uIntPtr = default(UIntPtr);
				if (num / uIntPtr == 0)
				{
					_ = (Tf67)(object)o0E3.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					et = default(Et0);
				}
			}
		}
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			else
			{
				_ = (i5NX)(object)o0E3.Default;
			}
		}
		try
		{
			do
			{
				UIntPtr num2 = (UIntPtr)o0E3.Default;
				uIntPtr = default(UIntPtr);
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num4 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num5 = num3 / checked(num4 * uIntPtr);
				UIntPtr num6 = (UIntPtr)o0E3.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num2) * (num5 * unchecked((nuint)num6 / uIntPtr)) == 0)
					{
						_ = (Et0)o0E3.Default;
					}
				}
			}
			while ((object)o0E3.Default != null);
		}
		finally
		{
			_ = (Hi84)(object)o0E3.Default;
			gn = (Gn76)(object)o0E3.Default;
			goto IL_05a7;
		}
		IL_0734:
		_ = (Tf67)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		try
		{
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (Zn1b)(object)o0E3.Default;
					_ = (w8W)o0E3.Default;
					_ = (Gn76)(object)o0E3.Default;
				}
			}
			catch
			{
				try
				{
					k0WR = k0WR;
				}
				finally
				{
					zn1b = zn1b;
					goto end_IL_076e;
				}
				end_IL_076e:;
			}
			goto IL_0787;
		}
		IL_0674:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = o0E3.Default;
				}
				catch
				{
					w1H = w1H;
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
				}
			}
			else
			{
				do
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		_ = (Gn76)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			zn1b = zn1b;
		}
		finally
		{
			do
			{
				try
				{
					p9B = p9B;
					w1H = null;
					x4N = null;
				}
				finally
				{
					_ = (k4C9)(object)o0E3.Default;
					continue;
				}
			}
			while ((object)o0E3.Default != null);
			goto IL_0713;
		}
		IL_018a:
		while (obj != null)
		{
			try
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			catch
			{
				try
				{
					_ = (Zn1b)(object)o0E3.Default;
				}
				finally
				{
					_ = (f5R4)(object)o0E3.Default;
					goto end_IL_016d;
				}
				end_IL_016d:;
			}
		}
		_ = (Tf67)(object)o0E3.Default;
		Zn1b obj18 = (Zn1b)(object)o0E3.Default;
		zn1b = zn1b;
		zn1b = obj18;
		_ = (_003CModule_003E)(object)o0E3.Default;
		_ = (i5NX)(object)o0E3.Default;
		x4N = x4N;
		x4N = x4N;
		k4C9 k4C = k4C;
		k4C = k4C;
		k4C = (k4C9)(object)o0E3.Default;
		et = et;
		et = default(Et0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		try
		{
			p9B = p9B;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			nuint num7 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num7 / checked(uIntPtr + unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
			{
				w8W = w8W;
				w8W = w8W;
				pg2c = pg2c;
				zn1b = (Zn1b)(object)o0E3.Default;
			}
			else
			{
				f5R4 obj19 = (f5R4)(object)o0E3.Default;
				f5R = (f5R4)(object)o0E3.Default;
				f5R = obj19;
				_ = (Pg2c)(object)o0E3.Default;
				_ = (a9X)(object)o0E3.Default;
			}
		}
		finally
		{
			goto IL_02b3;
		}
		IL_05a7:
		try
		{
			uIntPtr = default(UIntPtr);
			nuint num8 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num9 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num8 - (num9 + uIntPtr)) == 0)
			{
				try
				{
					w8W = w8W;
				}
				finally
				{
					_ = (f5R4)(object)o0E3.Default;
					goto end_IL_05a8;
				}
			}
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Pg2c)(object)o0E3.Default;
				pg2c = (Pg2c)(object)o0E3.Default;
			}
			else
			{
				et = default(Et0);
			}
			end_IL_05a8:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					p9B = p9B;
				}
				finally
				{
					_ = (g9Z)(object)o0E3.Default;
					goto IL_0674;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				gn = null;
			}
			else
			{
				w1H obj21 = (w1H)(object)o0E3.Default;
				w1H = w1H;
				w1H = obj21;
			}
			goto IL_0674;
		}
		IL_02b3:
		_ = o0E3.Default;
		zn1b = zn1b;
		_ = (g9Z)(object)o0E3.Default;
		_ = (w0A)(object)o0E3.Default;
		do
		{
			f5R = f5R;
		}
		while (obj != null);
		_ = (Sf06)(object)o0E3.Default;
		try
		{
			do
			{
				try
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				catch
				{
					_ = (k0WR)(object)o0E3.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				try
				{
					w0A = w0A;
				}
				catch
				{
					_ = (f5R4)(object)o0E3.Default;
				}
			}
			catch
			{
				try
				{
					_ = (f5R4)(object)o0E3.Default;
				}
				catch
				{
					_ = (f5R4)(object)o0E3.Default;
				}
			}
			goto IL_0356;
		}
		IL_07ca:
		do
		{
			_ = (w8W)o0E3.Default;
		}
		while (obj != null || (object)o0E3.Default != null);
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (x4N6)(object)o0E3.Default;
					return;
				}
				k4C = (k4C9)(object)o0E3.Default;
				_ = (w1H)(object)o0E3.Default;
				_ = (a9X)(object)o0E3.Default;
				p9B = null;
				return;
			}
		}
		finally
		{
			_ = (Et0)o0E3.Default;
			return;
		}
	}
}
