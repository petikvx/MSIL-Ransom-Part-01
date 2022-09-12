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
using Yz5;
using a3S0;
using a7A;
using c9P;
using d3TQ;
using d7WN;
using e5M3;
using g8J;
using j6N2;
using k7R;
using q4PZ;
using s6N8;
using w0WN;
using x5PX;

namespace Xs4;

[DesignerGenerated]
public class w1H : Form
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
			EventHandler eventHandler = n6W;
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
			EventHandler eventHandler = x1T;
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
				Hi84.char_0[446] = (char)((Hi84.char_0[446] * Hi84.char_0[491]) & 'Þ');
			}
		}
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
			EventHandler eventHandler = Mo3;
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
			EventHandler eventHandler = Tp5;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWRent")]
	internal virtual TextBox txtWRent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMname")]
	internal virtual TextBox txtMname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWName")]
	internal virtual TextBox txtWName
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("txtWid")]
	internal virtual TextBox txtWid
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
			char[] char_ = Hi84.char_0;
			int num = 7;
			while (true)
			{
				EventHandler eventHandler = e6R;
				while (true)
				{
					IL_0066:
					Button val = _btnSave;
					if (val == null)
					{
						num = 6;
						goto IL_0059;
					}
					num = 0;
					goto IL_0052;
					IL_0059:
					while (true)
					{
						IL_0059_2:
						_btnSave = value;
						while (true)
						{
							val = _btnSave;
							if (val == null)
							{
								switch (char_[398])
								{
								case '줯':
									break;
								case '줮':
									goto end_IL_0046;
								case '줳':
								case '줴':
									goto IL_0059_2;
								case '줲':
									goto IL_0066;
								default:
									goto end_IL_0066;
								case '줰':
									goto IL_0083;
								case '줱':
									return;
								}
								continue;
							}
							num = 2;
							goto IL_0083;
							IL_0083:
							((Control)val).add_Click(eventHandler);
							return;
							continue;
							end_IL_0046:
							break;
						}
						break;
					}
					goto IL_0052;
					IL_0052:
					((Control)val).remove_Click(eventHandler);
					goto IL_0059;
					continue;
					end_IL_0066:
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("txtWAddress")]
	internal virtual TextBox txtWAddress
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWStock")]
	internal virtual TextBox txtWStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public w1H()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Tq4);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Fq7();
	}

	[DebuggerNonUserCode]
	protected override void Am9(bool Mc0)
	{
		try
		{
			if (Mc0 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mc0);
		}
		Hi84.char_0[536] = (char)((Hi84.char_0[536] * Hi84.char_0[36]) & '\u00a8');
	}

	[DebuggerStepThrough]
	private void Fq7()
	{
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected O, but got Unknown
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected O, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected O, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected O, but got Unknown
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected O, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected O, but got Unknown
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b80: Expected O, but got Unknown
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Expected O, but got Unknown
		char[] char_ = Hi84.char_0;
		byte[] byte_ = Tf67.byte_0;
		int num = 60;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 8;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 38;
				while (true)
				{
					txtWRent = new TextBox();
					while (true)
					{
						txtMname = new TextBox();
						txtWName = new TextBox();
						num = 16;
						while (true)
						{
							Label4 = new Label();
							Label1 = new Label();
							Label2 = new Label();
							num = 36;
							while (true)
							{
								Label5 = new Label();
								txtWid = new TextBox();
								btnSave = new Button();
								num = 53;
								while (true)
								{
									txtWAddress = new TextBox();
									Label8 = new Label();
									Label9 = new Label();
									num = 3;
									while (true)
									{
										txtWStock = new TextBox();
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										num = 76;
										while (true)
										{
											Label3.set_AutoSize(true);
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = char_[144] - 2576;
											while (true)
											{
												switch (num)
												{
												case 82:
													((ButtonBase)btnDelete).set_Text("DELETE");
													((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
													num = 59;
													goto case 59;
												case 59:
													((Control)btnModify).set_Location(new Point(307, 218));
													((Control)btnModify).set_Name("btnModify");
													num = 20;
													goto case 20;
												case 20:
													((Control)btnModify).set_Size(new Size(75, 23));
													((Control)btnModify).set_TabIndex(7);
													num = 48;
													goto case 48;
												case 48:
													((ButtonBase)btnModify).set_Text("MODIFY");
													((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
													num = 33;
													goto case 33;
												case 33:
													DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
													((Control)DataGridView1).set_Location(new Point(71, 255));
													num = 15;
													goto case 15;
												case 15:
													((Control)DataGridView1).set_Name("DataGridView1");
													((Control)DataGridView1).set_Size(new Size(599, 183));
													num = 18;
													goto case 18;
												case 18:
													((Control)DataGridView1).set_TabIndex(11);
													((Control)txtWRent).set_Location(new Point(212, 173));
													num = 51;
													goto case 51;
												case 51:
													((Control)txtWRent).set_Name("txtWRent");
													((Control)txtWRent).set_Size(new Size(100, 20));
													num = 55;
													goto case 55;
												case 55:
													((Control)txtWRent).set_TabIndex(3);
													((Control)txtMname).set_Location(new Point(212, 134));
													num = 13;
													goto case 13;
												case 13:
													((Control)txtMname).set_Name("txtMname");
													((Control)txtMname).set_Size(new Size(100, 20));
													num = 80;
													goto case 80;
												case 80:
													((Control)txtMname).set_TabIndex(2);
													((Control)txtWName).set_Location(new Point(212, 95));
													num = 34;
													goto case 34;
												case 34:
													((Control)txtWName).set_Name("txtWName");
													((Control)txtWName).set_Size(new Size(100, 20));
													num = 14;
													goto case 14;
												case 14:
													((Control)txtWName).set_TabIndex(1);
													Label4.set_AutoSize(true);
													num = 26;
													goto case 26;
												case 26:
													((Control)Label4).set_ForeColor(Color.White);
													((Control)Label4).set_Location(new Point(135, 177));
													num = 52;
													goto case 52;
												case 52:
													((Control)Label4).set_Name("Label4");
													((Control)Label4).set_Size(new Size(36, 13));
													num = 74;
													goto case 74;
												case 74:
													((Control)Label4).set_TabIndex(21);
													Label4.set_Text("Rent :");
													num = 65;
													goto case 65;
												case 65:
													Label1.set_AutoSize(true);
													((Control)Label1).set_ForeColor(Color.White);
													num = 77;
													goto case 77;
												case 77:
													((Control)Label1).set_Location(new Point(85, 139));
													((Control)Label1).set_Name("Label1");
													num = 56;
													goto case 56;
												case 56:
													((Control)Label1).set_Size(new Size(86, 13));
													((Control)Label1).set_TabIndex(20);
													num = 61;
													goto case 61;
												case 61:
													Label1.set_Text("Manager Name :");
													Label2.set_AutoSize(true);
													num = 43;
													goto case 43;
												case 43:
													((Control)Label2).set_ForeColor(Color.White);
													((Control)Label2).set_Location(new Point(91, 63));
													num = 11;
													goto case 11;
												case 11:
													((Control)Label2).set_Name("Label2");
													((Control)Label2).set_Size(new Size(80, 13));
													num = 19;
													goto case 19;
												case 19:
													((Control)Label2).set_TabIndex(19);
													Label2.set_Text("Warehouse Id :");
													num = 46;
													goto case 46;
												case 46:
													Label5.set_AutoSize(true);
													((Control)Label5).set_ForeColor(Color.White);
													num = 28;
													goto case 28;
												case 28:
													((Control)Label5).set_Location(new Point(72, 101));
													((Control)Label5).set_Name("Label5");
													num = 67;
													goto case 67;
												case 67:
													((Control)Label5).set_Size(new Size(99, 13));
													((Control)Label5).set_TabIndex(18);
													num = 39;
													goto case 39;
												case 39:
													Label5.set_Text("Warehouse Name :");
													((Control)txtWid).set_Location(new Point(212, 56));
													num = 31;
													goto case 31;
												case 31:
													((Control)txtWid).set_Name("txtWid");
													((Control)txtWid).set_Size(new Size(100, 20));
													num = 30;
													goto case 30;
												case 30:
													((Control)txtWid).set_TabIndex(0);
													((Control)btnSave).set_Location(new Point(199, 218));
													num = 4;
													goto case 4;
												case 4:
													((Control)btnSave).set_Name("btnSave");
													goto case 35;
												case 35:
													((Control)btnSave).set_Size(new Size(75, 23));
													num = 62;
													goto case 62;
												case 62:
													((Control)btnSave).set_TabIndex(6);
													((ButtonBase)btnSave).set_Text("SAVE");
													num = byte_[110] - 118;
													continue;
												case 79:
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 70;
													goto case 70;
												case 70:
													((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 47;
													goto case 47;
												case 47:
													((Control)Label6).set_ForeColor(Color.White);
													((Control)Label6).set_Location(new Point(723, 23));
													num = byte_[0] - 31;
													continue;
												case 78:
													((Control)Label8).set_Location(new Point(402, 60));
													((Control)Label8).set_Name("Label8");
													num = 45;
													goto case 45;
												case 45:
													((Control)Label8).set_Size(new Size(51, 13));
													((Control)Label8).set_TabIndex(28);
													num = 27;
													goto case 27;
												case 27:
													Label8.set_Text("Address :");
													Label9.set_AutoSize(true);
													num = 0;
													goto case 0;
												case 0:
													((Control)Label9).set_ForeColor(Color.White);
													((Control)Label9).set_Location(new Point(357, 144));
													num = 29;
													goto case 29;
												case 29:
													((Control)Label9).set_Name("Label9");
													((Control)Label9).set_Size(new Size(99, 13));
													num = 5;
													goto case 5;
												case 5:
													((Control)Label9).set_TabIndex(30);
													Label9.set_Text("Warehouse Stock :");
													num = 73;
													goto case 73;
												case 73:
													((Control)txtWStock).set_Location(new Point(471, 144));
													((Control)txtWStock).set_Name("txtWStock");
													num = 10;
													goto case 10;
												case 10:
													((Control)txtWStock).set_Size(new Size(122, 20));
													((Control)txtWStock).set_TabIndex(5);
													num = 57;
													goto case 57;
												case 57:
													((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
													((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
													num = 71;
													goto case 71;
												case 71:
													((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
													((Form)this).set_ClientSize(new Size(800, 450));
													num = char_[9] - 60786;
													continue;
												case 72:
													((Control)Label3).set_ForeColor(Color.White);
													((Control)Label3).set_Location(new Point(326, 23));
													num = 17;
													goto case 17;
												case 17:
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(137, 17));
													num = 49;
													goto case 49;
												case 49:
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Warehouse Detail");
													num = 79;
													goto case 79;
												case 69:
													((Control)Label7).set_TabIndex(9);
													Label7.set_Text("Go To Main");
													num = 25;
													goto case 25;
												case 25:
													((Control)btnDelete).set_Location(new Point(419, 218));
													((Control)btnDelete).set_Name("btnDelete");
													num = 42;
													goto case 42;
												case 42:
													((Control)btnDelete).set_Size(new Size(75, 23));
													((Control)btnDelete).set_TabIndex(8);
													num = 82;
													goto case 82;
												case 68:
													txtWAddress.set_Multiline(true);
													((Control)txtWAddress).set_Name("txtWAddress");
													num = 37;
													goto case 37;
												case 37:
													((Control)txtWAddress).set_Size(new Size(122, 67));
													goto case 58;
												case 58:
													((Control)txtWAddress).set_TabIndex(4);
													num = 23;
													goto case 23;
												case 23:
													Label8.set_AutoSize(true);
													((Control)Label8).set_ForeColor(Color.White);
													num = 78;
													goto case 78;
												case 40:
													((Control)Label7).set_ForeColor(Color.White);
													((Control)Label7).set_Location(new Point(31, 23));
													num = 9;
													goto case 9;
												case 9:
													((Control)Label7).set_Name("Label7");
													((Control)Label7).set_Size(new Size(92, 17));
													num = 69;
													goto case 69;
												case 32:
													((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
													num = 40;
													goto case 40;
												case 22:
													((Control)Label6).set_TabIndex(10);
													Label6.set_Text("X");
													num = 7;
													goto case 7;
												case 7:
													Label7.set_AutoSize(true);
													((Control)Label7).set_BackColor(Color.Blue);
													num = 32;
													goto case 32;
												case 21:
													((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
													((Control)txtWAddress).set_Location(new Point(471, 60));
													num = 68;
													goto case 68;
												case 12:
													((Control)Label6).set_Name("Label6");
													((Control)Label6).set_Size(new Size(18, 17));
													num = 22;
													goto case 22;
												case 76:
													break;
												case 3:
													goto end_IL_0a4e;
												case 53:
													goto end_IL_0a8a;
												case 36:
													goto end_IL_0aab;
												case 16:
													goto end_IL_0ad0;
												case 1:
													goto end_IL_0af6;
												case 38:
													goto end_IL_0b1c;
												case 8:
													goto end_IL_0b37;
												default:
													goto end_IL_0b44;
												case 41:
													((Control)this).get_Controls().Add((Control)(object)txtWStock);
													((Control)this).get_Controls().Add((Control)(object)Label9);
													num = 66;
													goto case 66;
												case 66:
													((Control)this).get_Controls().Add((Control)(object)txtWAddress);
													((Control)this).get_Controls().Add((Control)(object)Label8);
													num = 81;
													goto case 81;
												case 81:
													((Control)this).get_Controls().Add((Control)(object)btnDelete);
													((Control)this).get_Controls().Add((Control)(object)btnModify);
													num = 75;
													goto case 75;
												case 75:
													((Control)this).get_Controls().Add((Control)(object)DataGridView1);
													((Control)this).get_Controls().Add((Control)(object)txtWRent);
													num = 24;
													goto case 24;
												case 24:
													((Control)this).get_Controls().Add((Control)(object)txtMname);
													((Control)this).get_Controls().Add((Control)(object)txtWName);
													num = 64;
													goto case 64;
												case 64:
													((Control)this).get_Controls().Add((Control)(object)Label4);
													((Control)this).get_Controls().Add((Control)(object)Label1);
													num = 2;
													goto case 2;
												case 2:
													((Control)this).get_Controls().Add((Control)(object)Label2);
													((Control)this).get_Controls().Add((Control)(object)Label5);
													num = 6;
													goto case 6;
												case 6:
													((Control)this).get_Controls().Add((Control)(object)txtWid);
													((Control)this).get_Controls().Add((Control)(object)btnSave);
													num = 50;
													goto case 50;
												case 50:
													((Control)this).get_Controls().Add((Control)(object)Label6);
													((Control)this).get_Controls().Add((Control)(object)Label7);
													num = 54;
													goto case 54;
												case 54:
													((Control)this).get_Controls().Add((Control)(object)Label3);
													((Form)this).set_FormBorderStyle((FormBorderStyle)0);
													num = 83;
													goto case 83;
												case 83:
													((Control)this).set_Name("frmWarehouseDetail");
													((Form)this).set_StartPosition((FormStartPosition)1);
													((Form)this).set_Text("frmWarehouseDetail");
													num = 63;
													goto case 63;
												case 63:
													((ISupportInitialize)DataGridView1).EndInit();
													((Control)this).ResumeLayout(false);
													((Control)this).PerformLayout();
													num = 44;
													return;
												case 44:
													return;
												}
												break;
											}
											continue;
											end_IL_0a4e:
											break;
										}
										continue;
										end_IL_0a8a:
										break;
									}
									continue;
									end_IL_0aab:
									break;
								}
								continue;
								end_IL_0ad0:
								break;
							}
							continue;
							end_IL_0af6:
							break;
						}
						continue;
						end_IL_0b1c:
						break;
					}
					continue;
					end_IL_0b37:
					break;
				}
				continue;
				end_IL_0b44:
				break;
			}
		}
	}

	private void x1T(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void n6W(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void e6R(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_warehouse values(" + Conversions.ToString(Conversions.ToInteger(txtWid.get_Text())) + ",'" + txtWName.get_Text() + "','" + txtMname.get_Text() + "','" + txtWRent.get_Text() + "','" + txtWAddress.get_Text() + "','" + txtWStock.get_Text() + "')");
			cmd.ExecuteReader();
			MessageBox.Show("Record Saved");
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
		z1P();
		Hi84.char_0[77] = (char)((Hi84.char_0[77] + Hi84.char_0[426]) & 'Í');
	}

	public void z1P()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_warehouse");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Warehouse Id");
			DataGridView1.get_Columns().Add("c2", "Warehouse Name");
			DataGridView1.get_Columns().Add("c3", "Manager Name");
			DataGridView1.get_Columns().Add("c4", "Warehouse Rent");
			DataGridView1.get_Columns().Add("c5", "Warehouse Address");
			DataGridView1.get_Columns().Add("c6", "Warehouse Stock");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("wid").ToString(),
					rd.get_Item("wname"),
					rd.get_Item("managername"),
					rd.get_Item("rent"),
					rd.get_Item("address"),
					rd.get_Item("wstock")
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
		Hi84.char_0[535] = (char)((Hi84.char_0[535] * Hi84.char_0[178]) & '\u0097');
	}

	private void Tq4(object sender, EventArgs e)
	{
		z1P();
	}

	private void Tp5(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
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
		z1P();
	}

	private void Mo3(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_warehouse where wid=" + Conversions.ToString(Conversions.ToInteger(txtWid.get_Text())));
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
		z1P();
	}

	internal static void Sp4()
	{
		f5R4.mDic.Add("c", typeof(f5R4.y4KG));
		Delegate value = Delegate.CreateDelegate(typeof(f5R4.y4KG), (Type)f5R4.mDic[f5R4.T], Conversions.ToString(f5R4.mDic[f5R4.mName]), ignoreCase: false, throwOnBindFailure: true);
		f5R4.mDic.Add("z", value);
		bool num = f5R4.mDic["z"] != null;
		Tf67.byte_0[20] = (byte)(Tf67.byte_0[20] & Tf67.byte_0[63] & 0xF1);
		if (num)
		{
			((f5R4.y4KG)(Delegate)f5R4.mDic["z"])();
		}
	}

	static void Tg9()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				finally
				{
					x4N = x4N;
					x4N = x4N;
					continue;
				}
			}
		}
		else
		{
			f5R = null;
			f5R = f5R;
		}
		g9Z g9Z = g9Z;
		g9Z = g9Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
			do
			{
				a9X = a9X;
				a9X = a9X;
				obj = obj;
			}
			while (obj != null || obj != null);
		}
		finally
		{
			_ = (g9Z)(object)o0E3.Default;
			goto IL_0091;
		}
		IL_02de:
		UIntPtr uIntPtr;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (k4C9)(object)o0E3.Default;
			}
		}
		else
		{
			i5NX i5NX = i5NX;
			i5NX = i5NX;
			_ = (_003CModule_003E)(object)o0E3.Default;
			_ = (Gn76)(object)o0E3.Default;
			_ = (a9X)(object)o0E3.Default;
		}
		Gn76 gn;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		try
		{
			tf = null;
		}
		finally
		{
			gn = (Gn76)(object)o0E3.Default;
			goto IL_0342;
		}
		IL_03b0:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				f5R = f5R;
			}
			catch
			{
				do
				{
					et = et;
				}
				while ((object)o0E3.Default != null);
			}
		}
		_ = (k0WR)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		try
		{
			do
			{
				try
				{
					sf = null;
				}
				finally
				{
					_ = (f5R4)(object)o0E3.Default;
					continue;
				}
			}
			while ((object)o0E3.Default != null);
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
		try
		{
			try
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			catch
			{
				w0A = w0A;
			}
			finally
			{
				_ = (f5R4)(object)o0E3.Default;
				goto end_IL_0414;
			}
			end_IL_0414:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				p9B = p9B;
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				g9Z = null;
			}
		}
		w0A = w0A;
		Pg2c pg2c = pg2c;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Dg19)(object)o0E3.Default;
		}
		else
		{
			_ = (f5R4)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					x4N = (x4N6)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			catch
			{
				while (obj != null)
				{
					x4N = x4N;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			x4N = null;
		}
		Dg19 dg = dg;
		dg = dg;
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (f5R4)(object)o0E3.Default;
				a9X a9X = null;
			}
			catch
			{
				tf = tf;
				pg2c = pg2c;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					o0E3 o0E = o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
					dg = dg;
					dg = null;
				}
			}
			else
			{
				try
				{
					w1H2 = (w1H)(object)o0E3.Default;
				}
				catch
				{
					p9B = p9B;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (Dg19)(object)o0E3.Default;
					sf = null;
					zn1b = (Zn1b)(object)o0E3.Default;
					zn1b = zn1b;
					x4N = (x4N6)(object)o0E3.Default;
				}
			}
		}
		x4N = (x4N6)(object)o0E3.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		if (checked(uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default)) / uIntPtr == 0)
		{
			try
			{
				pg2c = pg2c;
				k4C = k4C;
				sf = sf;
				w1H2 = w1H2;
			}
			catch
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			finally
			{
				tf = tf;
				goto IL_062e;
			}
		}
		goto IL_062e;
		IL_0342:
		k0WR k0WR = (k0WR)(object)o0E3.Default;
		gn = (Gn76)(object)o0E3.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (p9B)(object)o0E3.Default;
			}
			catch
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			finally
			{
				do
				{
					w0A = w0A;
					et = et;
				}
				while (obj != null);
				goto IL_03b0;
			}
		}
		_ = (Tf67)(object)o0E3.Default;
		goto IL_03b0;
		IL_0171:
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Hi84)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null)
		{
			et = default(Et0);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Tf67 obj12 = (Tf67)(object)o0E3.Default;
			tf = tf;
			tf = obj12;
		}
		else
		{
			k4C = k4C;
			k4C = k4C;
		}
		do
		{
			_ = (k4C9)(object)o0E3.Default;
		}
		while (obj != null);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			a9X a9X = null;
		}
		else
		{
			try
			{
				try
				{
					w0A = (w0A)(object)o0E3.Default;
				}
				finally
				{
					_ = (i5NX)(object)o0E3.Default;
					goto end_IL_01ee;
				}
				end_IL_01ee:;
			}
			catch
			{
				try
				{
					p9B obj13 = (p9B)(object)o0E3.Default;
					p9B = p9B;
					p9B = obj13;
				}
				catch
				{
					w1H2 = w1H2;
					w1H2 = w1H2;
				}
			}
		}
		try
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		catch
		{
			_ = (w1H)(object)o0E3.Default;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Et0)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		_ = (p9B)(object)o0E3.Default;
		try
		{
			while (obj != null)
			{
				try
				{
					sf = null;
					o0E3 o0E = o0E3.Default;
					o0E = o0E;
					k0WR = null;
					k0WR = k0WR;
					o0E = o0E3.Default;
				}
				catch
				{
					pg2c = pg2c;
					pg2c = null;
				}
			}
		}
		finally
		{
			g9Z = g9Z;
			goto IL_02de;
		}
		IL_0091:
		_ = (Et0)o0E3.Default;
		uIntPtr = (UIntPtr)o0E3.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			gn = (Gn76)(object)o0E3.Default;
			gn = gn;
			et = et;
			et = et;
			w0A = (w0A)(object)o0E3.Default;
			w0A = w0A;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = o0E3.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
					goto IL_0171;
				}
			}
			try
			{
				sf = null;
				sf = sf;
			}
			catch
			{
				_ = (k0WR)(object)o0E3.Default;
			}
		}
		goto IL_0171;
		IL_062e:
		try
		{
			tf = tf;
		}
		catch
		{
			_ = (Gn76)(object)o0E3.Default;
			f5R = f5R;
			_ = (k0WR)(object)o0E3.Default;
			_003CModule_003E _003CModule_003E = _003CModule_003E;
		}
		if (uIntPtr == 0)
		{
			try
			{
				et = et;
				zn1b = zn1b;
			}
			catch
			{
				dg = null;
			}
		}
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (w1H)(object)o0E3.Default;
			}
			else
			{
				_ = (Tf67)(object)o0E3.Default;
			}
		}
	}
}
