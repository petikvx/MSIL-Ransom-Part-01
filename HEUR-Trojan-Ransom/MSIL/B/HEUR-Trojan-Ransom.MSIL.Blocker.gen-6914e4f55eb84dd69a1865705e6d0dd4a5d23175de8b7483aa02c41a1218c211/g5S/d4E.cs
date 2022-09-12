using System;
using System.ComponentModel;
using System.Data.SqlClient;
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
using i3L;
using o8Z;
using p0H;
using q3F;
using q8X;
using z2Z;

namespace g5S;

[DesignerGenerated]
public class d4E : Form
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
			EventHandler eventHandler = b5D;
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
				Pj8.byte_0[183] = (byte)((Pj8.byte_0[183] + Pj8.byte_0[24]) & 0x45);
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
			EventHandler eventHandler = Cr7;
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
			EventHandler eventHandler = z4K;
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
			char[] char_ = Mb5.char_0;
			int num = 3;
			while (true)
			{
				EventHandler eventHandler = Lf7;
				while (true)
				{
					IL_0061:
					Button val = _btnModify;
					if (val == null)
					{
						num = 5;
						goto IL_004a;
					}
					num = 4;
					goto IL_0043;
					IL_004a:
					while (true)
					{
						_btnModify = value;
						val = _btnModify;
						if (val != null)
						{
							switch (char_[31])
							{
							case '쬌':
								break;
							case '쬍':
								continue;
							case '쬎':
							case '쬏':
								goto IL_0061;
							default:
								goto end_IL_0061;
							case '쬉':
								((Control)val).add_Click(eventHandler);
								return;
							case '쬈':
							case '쬊':
								return;
							}
							break;
						}
						num = 0;
						return;
					}
					goto IL_0043;
					IL_0043:
					((Control)val).remove_Click(eventHandler);
					goto IL_004a;
					continue;
					end_IL_0061:
					break;
				}
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
			EventHandler eventHandler = t5S;
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

	public d4E()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)r0W);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		w9Q();
	}

	[DebuggerNonUserCode]
	protected override void f7A(bool b5P)
	{
		try
		{
			if (b5P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b5P);
		}
	}

	[DebuggerStepThrough]
	private void w9Q()
	{
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected O, but got Unknown
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected O, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected O, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected O, but got Unknown
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected O, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected O, but got Unknown
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected O, but got Unknown
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected O, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected O, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected O, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected O, but got Unknown
		byte[] byte_ = Pj8.byte_0;
		char[] char_ = Mb5.char_0;
		int num = 34;
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
				num = 65;
				while (true)
				{
					txtWRent = new TextBox();
					txtMname = new TextBox();
					txtWName = new TextBox();
					num = 63;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 42;
						while (true)
						{
							Label5 = new Label();
							txtWid = new TextBox();
							btnSave = new Button();
							num = 69;
							while (true)
							{
								txtWAddress = new TextBox();
								Label8 = new Label();
								Label9 = new Label();
								num = 53;
								while (true)
								{
									txtWStock = new TextBox();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 5;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 2;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(326, 23));
											num = 3;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(137, 17));
												num = 13;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Warehouse Detail");
													num = 55;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 68;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 46;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(723, 23));
																num = 37;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 56;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(10);
																		Label6.set_Text("X");
																		num = 21;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = 66;
																			while (true)
																			{
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 75;
																				while (true)
																				{
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(31, 23));
																					num = 18;
																					while (true)
																					{
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 27;
																						while (true)
																						{
																							((Control)Label7).set_TabIndex(9);
																							Label7.set_Text("Go To Main");
																							num = 54;
																							while (true)
																							{
																								((Control)btnDelete).set_Location(new Point(419, 218));
																								((Control)btnDelete).set_Name("btnDelete");
																								num = 45;
																								while (true)
																								{
																									((Control)btnDelete).set_Size(new Size(75, 23));
																									((Control)btnDelete).set_TabIndex(8);
																									num = 33;
																									while (true)
																									{
																										((ButtonBase)btnDelete).set_Text("DELETE");
																										((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																										num = 70;
																										while (true)
																										{
																											((Control)btnModify).set_Location(new Point(307, 218));
																											((Control)btnModify).set_Name("btnModify");
																											num = 16;
																											while (true)
																											{
																												((Control)btnModify).set_Size(new Size(75, 23));
																												((Control)btnModify).set_TabIndex(7);
																												num = 32;
																												while (true)
																												{
																													((ButtonBase)btnModify).set_Text("MODIFY");
																													((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																													num = byte_[78] - 50;
																													while (true)
																													{
																														switch (num)
																														{
																														case 83:
																															((Control)Label5).set_Location(new Point(72, 101));
																															((Control)Label5).set_Name("Label5");
																															num = 44;
																															goto case 44;
																														case 44:
																															((Control)Label5).set_Size(new Size(99, 13));
																															((Control)Label5).set_TabIndex(18);
																															num = 12;
																															goto case 12;
																														case 12:
																															Label5.set_Text("Warehouse Name :");
																															((Control)txtWid).set_Location(new Point(212, 56));
																															num = 10;
																															goto case 10;
																														case 10:
																															((Control)txtWid).set_Name("txtWid");
																															((Control)txtWid).set_Size(new Size(100, 20));
																															num = char_[13] - 5058;
																															continue;
																														case 81:
																															((Control)this).get_Controls().Add((Control)(object)btnDelete);
																															((Control)this).get_Controls().Add((Control)(object)btnModify);
																															num = 59;
																															goto case 59;
																														case 59:
																															((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																															((Control)this).get_Controls().Add((Control)(object)txtWRent);
																															num = 23;
																															goto case 23;
																														case 23:
																															((Control)this).get_Controls().Add((Control)(object)txtMname);
																															((Control)this).get_Controls().Add((Control)(object)txtWName);
																															num = 6;
																															goto case 6;
																														case 6:
																															((Control)this).get_Controls().Add((Control)(object)Label4);
																															((Control)this).get_Controls().Add((Control)(object)Label1);
																															num = 30;
																															goto case 30;
																														case 30:
																															((Control)this).get_Controls().Add((Control)(object)Label2);
																															((Control)this).get_Controls().Add((Control)(object)Label5);
																															num = char_[31] - 51949;
																															continue;
																														case 79:
																															((Control)txtMname).set_TabIndex(2);
																															((Control)txtWName).set_Location(new Point(212, 95));
																															num = 31;
																															goto case 31;
																														case 31:
																															((Control)txtWName).set_Name("txtWName");
																															((Control)txtWName).set_Size(new Size(100, 20));
																															num = 72;
																															goto case 72;
																														case 72:
																															((Control)txtWName).set_TabIndex(1);
																															Label4.set_AutoSize(true);
																															num = 24;
																															goto case 24;
																														case 24:
																															((Control)Label4).set_ForeColor(Color.White);
																															((Control)Label4).set_Location(new Point(135, 177));
																															num = 74;
																															goto case 74;
																														case 74:
																															((Control)Label4).set_Name("Label4");
																															((Control)Label4).set_Size(new Size(36, 13));
																															num = 52;
																															goto case 52;
																														case 52:
																															((Control)Label4).set_TabIndex(21);
																															Label4.set_Text("Rent :");
																															num = 39;
																															goto case 39;
																														case 39:
																															Label1.set_AutoSize(true);
																															((Control)Label1).set_ForeColor(Color.White);
																															num = 9;
																															goto case 9;
																														case 9:
																															((Control)Label1).set_Location(new Point(85, 139));
																															((Control)Label1).set_Name("Label1");
																															num = 62;
																															goto case 62;
																														case 62:
																															((Control)Label1).set_Size(new Size(86, 13));
																															((Control)Label1).set_TabIndex(20);
																															num = 47;
																															goto case 47;
																														case 47:
																															Label1.set_Text("Manager Name :");
																															Label2.set_AutoSize(true);
																															num = 38;
																															goto case 38;
																														case 38:
																															((Control)Label2).set_ForeColor(Color.White);
																															((Control)Label2).set_Location(new Point(91, 63));
																															num = 17;
																															goto case 17;
																														case 17:
																															((Control)Label2).set_Name("Label2");
																															((Control)Label2).set_Size(new Size(80, 13));
																															num = 77;
																															goto case 77;
																														case 77:
																															((Control)Label2).set_TabIndex(19);
																															Label2.set_Text("Warehouse Id :");
																															num = 73;
																															goto case 73;
																														case 73:
																															Label5.set_AutoSize(true);
																															((Control)Label5).set_ForeColor(Color.White);
																															num = 83;
																															goto case 83;
																														case 78:
																															Label8.set_AutoSize(true);
																															((Control)Label8).set_ForeColor(Color.White);
																															num = 14;
																															goto case 14;
																														case 14:
																															((Control)Label8).set_Location(new Point(402, 60));
																															((Control)Label8).set_Name("Label8");
																															num = 57;
																															goto case 57;
																														case 57:
																															((Control)Label8).set_Size(new Size(51, 13));
																															((Control)Label8).set_TabIndex(28);
																															num = 19;
																															goto case 19;
																														case 19:
																															Label8.set_Text("Address :");
																															Label9.set_AutoSize(true);
																															num = 25;
																															goto case 25;
																														case 25:
																															((Control)Label9).set_ForeColor(Color.White);
																															((Control)Label9).set_Location(new Point(357, 144));
																															num = 40;
																															goto case 40;
																														case 40:
																															((Control)Label9).set_Name("Label9");
																															((Control)Label9).set_Size(new Size(99, 13));
																															num = 4;
																															goto case 4;
																														case 4:
																															((Control)Label9).set_TabIndex(30);
																															Label9.set_Text("Warehouse Stock :");
																															num = 11;
																															goto case 11;
																														case 11:
																															((Control)txtWStock).set_Location(new Point(471, 144));
																															((Control)txtWStock).set_Name("txtWStock");
																															num = 0;
																															goto case 0;
																														case 0:
																															((Control)txtWStock).set_Size(new Size(122, 20));
																															((Control)txtWStock).set_TabIndex(5);
																															num = 64;
																															goto case 64;
																														case 64:
																															((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																															((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																															num = 50;
																															goto case 50;
																														case 50:
																															((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																															((Form)this).set_ClientSize(new Size(800, 450));
																															num = 15;
																															goto case 15;
																														case 15:
																															((Control)this).get_Controls().Add((Control)(object)txtWStock);
																															((Control)this).get_Controls().Add((Control)(object)Label9);
																															num = 61;
																															goto case 61;
																														case 61:
																															((Control)this).get_Controls().Add((Control)(object)txtWAddress);
																															((Control)this).get_Controls().Add((Control)(object)Label8);
																															num = 81;
																															goto case 81;
																														case 60:
																														case 71:
																															((Control)DataGridView1).set_Name("DataGridView1");
																															((Control)DataGridView1).set_Size(new Size(599, 183));
																															num = 1;
																															goto case 1;
																														case 1:
																															((Control)DataGridView1).set_TabIndex(11);
																															((Control)txtWRent).set_Location(new Point(212, 173));
																															num = 58;
																															goto case 58;
																														case 58:
																															((Control)txtWRent).set_Name("txtWRent");
																															((Control)txtWRent).set_Size(new Size(100, 20));
																															num = 20;
																															goto case 20;
																														case 20:
																															((Control)txtWRent).set_TabIndex(3);
																															((Control)txtMname).set_Location(new Point(212, 134));
																															num = 48;
																															goto case 48;
																														case 48:
																															((Control)txtMname).set_Name("txtMname");
																															((Control)txtMname).set_Size(new Size(100, 20));
																															num = 79;
																															goto case 79;
																														case 67:
																															((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																															((Control)txtWAddress).set_Location(new Point(471, 60));
																															num = 29;
																															goto case 29;
																														case 29:
																															txtWAddress.set_Multiline(true);
																															((Control)txtWAddress).set_Name("txtWAddress");
																															num = 7;
																															goto case 7;
																														case 7:
																															((Control)txtWAddress).set_Size(new Size(122, 67));
																															((Control)txtWAddress).set_TabIndex(4);
																															num = 78;
																															goto case 78;
																														case 41:
																															DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																															((Control)DataGridView1).set_Location(new Point(71, 255));
																															num = 71;
																															goto case 60;
																														case 36:
																															((Control)txtWid).set_TabIndex(0);
																															((Control)btnSave).set_Location(new Point(199, 218));
																															num = 22;
																															goto case 22;
																														case 22:
																															((Control)btnSave).set_Name("btnSave");
																															((Control)btnSave).set_Size(new Size(75, 23));
																															num = 26;
																															goto case 26;
																														case 26:
																															((Control)btnSave).set_TabIndex(6);
																															((ButtonBase)btnSave).set_Text("SAVE");
																															num = 67;
																															goto case 67;
																														case 32:
																															break;
																														case 16:
																															goto end_IL_0897;
																														case 70:
																															goto end_IL_08c0;
																														case 33:
																															goto end_IL_08e5;
																														case 45:
																															goto end_IL_0914;
																														case 54:
																															goto end_IL_0935;
																														case 27:
																															goto end_IL_095a;
																														case 18:
																															goto end_IL_0989;
																														case 75:
																															goto end_IL_09ab;
																														case 66:
																															goto end_IL_09d4;
																														case 21:
																															goto end_IL_09fd;
																														case 56:
																															goto end_IL_0a1f;
																														case 37:
																														case 80:
																															goto end_IL_0a40;
																														case 46:
																															goto end_IL_0a62;
																														case 68:
																															goto end_IL_0a8b;
																														case 55:
																															goto end_IL_0ab7;
																														case 13:
																															goto end_IL_0ad9;
																														case 3:
																															goto end_IL_0afa;
																														case 2:
																														case 35:
																															goto end_IL_0b1c;
																														case 5:
																															goto end_IL_0b48;
																														case 53:
																															goto end_IL_0b73;
																														case 69:
																															goto end_IL_0ba0;
																														case 42:
																															goto end_IL_0bc0;
																														case 63:
																															goto end_IL_0be6;
																														case 65:
																															goto end_IL_0c0c;
																														case 8:
																															goto end_IL_0c32;
																														default:
																															goto end_IL_0c58;
																														case 28:
																															((Control)this).get_Controls().Add((Control)(object)txtWid);
																															((Control)this).get_Controls().Add((Control)(object)btnSave);
																															num = 76;
																															goto case 76;
																														case 76:
																															((Control)this).get_Controls().Add((Control)(object)Label6);
																															((Control)this).get_Controls().Add((Control)(object)Label7);
																															num = 51;
																															goto case 51;
																														case 51:
																															((Control)this).get_Controls().Add((Control)(object)Label3);
																															((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																															num = 43;
																															goto case 43;
																														case 43:
																															((Control)this).set_Name("frmWarehouseDetail");
																															((Form)this).set_StartPosition((FormStartPosition)1);
																															((Form)this).set_Text("frmWarehouseDetail");
																															num = 82;
																															goto case 82;
																														case 82:
																															((ISupportInitialize)DataGridView1).EndInit();
																															((Control)this).ResumeLayout(false);
																															((Control)this).PerformLayout();
																															num = 49;
																															goto case 49;
																														case 49:
																															Mb5.char_0[92] = (char)(Mb5.char_0[92] & Pj8.byte_0[3] & ';');
																															return;
																														}
																														break;
																													}
																													continue;
																													end_IL_0897:
																													break;
																												}
																												continue;
																												end_IL_08c0:
																												break;
																											}
																											continue;
																											end_IL_08e5:
																											break;
																										}
																										continue;
																										end_IL_0914:
																										break;
																									}
																									continue;
																									end_IL_0935:
																									break;
																								}
																								continue;
																								end_IL_095a:
																								break;
																							}
																							continue;
																							end_IL_0989:
																							break;
																						}
																						continue;
																						end_IL_09ab:
																						break;
																					}
																					continue;
																					end_IL_09d4:
																					break;
																				}
																				continue;
																				end_IL_09fd:
																				break;
																			}
																			continue;
																			end_IL_0a1f:
																			break;
																		}
																		continue;
																		end_IL_0a40:
																		break;
																	}
																	continue;
																	end_IL_0a62:
																	break;
																}
																continue;
																end_IL_0a8b:
																break;
															}
															continue;
															end_IL_0ab7:
															break;
														}
														continue;
														end_IL_0ad9:
														break;
													}
													continue;
													end_IL_0afa:
													break;
												}
												continue;
												end_IL_0b1c:
												break;
											}
											continue;
											end_IL_0b48:
											break;
										}
										continue;
										end_IL_0b73:
										break;
									}
									continue;
									end_IL_0ba0:
									break;
								}
								continue;
								end_IL_0bc0:
								break;
							}
							continue;
							end_IL_0be6:
							break;
						}
						continue;
						end_IL_0c0c:
						break;
					}
					continue;
					end_IL_0c32:
					break;
				}
				continue;
				end_IL_0c58:
				break;
			}
		}
	}

	private void Cr7(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void b5D(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void t5S(object sender, EventArgs e)
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
		b1W();
		Mb5.char_0[202] = (char)((Mb5.char_0[202] | Mb5.char_0[132]) & 'I');
	}

	public void b1W()
	{
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
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
			while (true)
			{
				bool num = rd.Read();
				Mb5.char_0[68] = (char)((Mb5.char_0[68] ^ Pj8.byte_0[434]) & 'x');
				if (num)
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
					continue;
				}
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
	}

	private void r0W(object sender, EventArgs e)
	{
		b1W();
	}

	private void Lf7(object sender, EventArgs e)
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
		b1W();
		Pj8.byte_0[247] = (byte)((Pj8.byte_0[247] ^ Pj8.byte_0[195]) & 0xE0);
	}

	private void z4K(object sender, EventArgs e)
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
		b1W();
	}

	internal static void c4Y()
	{
		Eb1.mDic.Add("c", typeof(Eb1.Kg9));
		Delegate value = Delegate.CreateDelegate(typeof(Eb1.Kg9), (Type)Eb1.mDic[Eb1.T], Conversions.ToString(Eb1.mDic[Eb1.mName]), ignoreCase: false, throwOnBindFailure: true);
		Eb1.mDic.Add("z", value);
		if (Eb1.mDic["z"] != null)
		{
			((Eb1.Kg9)(Delegate)Eb1.mDic["z"])();
		}
		Pj8.byte_0[330] = (byte)((Pj8.byte_0[330] - Pj8.byte_0[258]) & 0x25);
	}

	static void c8S()
	{
		_ = (w4R)(object)Nf2.Default;
		f2L f2L = null;
		f2L = f2L;
		_ = (Np8)(object)Nf2.Default;
		Eb1 eb = eb;
		eb = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		while ((object)Nf2.Default != null)
		{
			do
			{
				num = num;
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (f2L)(object)Nf2.Default;
				}
				obj = obj;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Np8)(object)Nf2.Default;
				}
			}
			finally
			{
				checked
				{
					if (num + unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						_ = (Eb1)(object)Nf2.Default;
					}
					else
					{
						Mb5 obj2 = (Mb5)(object)Nf2.Default;
						mb = (Mb5)(object)Nf2.Default;
						mb = obj2;
					}
					goto IL_00d6;
				}
			}
		}
		goto IL_00d6;
		IL_079b:
		while (obj != null)
		{
			_ = (f9T6)(object)Nf2.Default;
		}
		return;
		IL_0134:
		do
		{
			_ = (Np8)(object)Nf2.Default;
		}
		while (obj != null);
		if (num == 0)
		{
			do
			{
				try
				{
					eb = eb;
				}
				catch
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		while (obj != null)
		{
			nuint num2 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Nf2.Default;
			num = default(UIntPtr);
			if (checked(num2 + num) == 0)
			{
				try
				{
					r8M = default(r8M);
					r8M = r8M;
					r8M = r8M;
				}
				finally
				{
					_ = (x8D9)(object)Nf2.Default;
					continue;
				}
			}
			if (num == 0)
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		Np8 np = (Np8)(object)Nf2.Default;
		np = np;
		_ = (f9T6)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		try
		{
			Pm9 obj4 = (Pm9)(object)Nf2.Default;
			pm = null;
			pm = obj4;
			d1X d1X = d1X;
			d1X = null;
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (d4E)(object)Nf2.Default;
				}
			}
			while ((object)Nf2.Default != null);
		}
		_ = (Pj8)(object)Nf2.Default;
		do
		{
			r8M = r8M;
		}
		while (obj != null);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E2);
			while ((object)Nf2.Default != null)
			{
				try
				{
					do
					{
						d4E2 = d4E2;
						d4E2 = null;
					}
					while (obj != null);
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)Nf2.Default / (nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						_ = (f2L)(object)Nf2.Default;
					}
					else
					{
						_ = (o5CZ)(object)Nf2.Default;
					}
					continue;
				}
			}
			while ((object)Nf2.Default != null)
			{
				_ = (Np8)(object)Nf2.Default;
			}
		}
		do
		{
			if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					np = (Np8)(object)Nf2.Default;
					continue;
				}
				_ = (Np8)(object)Nf2.Default;
				pm = (Pm9)(object)Nf2.Default;
			}
			else
			{
				_ = (m0N)(object)Nf2.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		while (obj != null)
		{
			try
			{
				do
				{
					_ = (x8D9)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
			finally
			{
				try
				{
					gj = gj;
					gj = gj;
				}
				finally
				{
					d8B obj6 = (d8B)(object)Nf2.Default;
					d8B = d8B;
					d8B = obj6;
					continue;
				}
			}
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			if (num / num / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				mb = mb;
				_ = (o5CZ)(object)Nf2.Default;
				eb = null;
			}
			else
			{
				Co4 co = co;
			}
		}
		else if (num == 0)
		{
			while (obj != null)
			{
				_ = (x8D9)(object)Nf2.Default;
			}
		}
		else
		{
			pm = pm;
			eb = eb;
			eb = eb;
			d1X d1X = null;
		}
		_ = (Co4)(object)Nf2.Default;
		try
		{
			try
			{
				try
				{
					w4R obj7 = (w4R)(object)Nf2.Default;
					w4R w4R = w4R;
					w4R = obj7;
				}
				finally
				{
					pm = pm;
					goto end_IL_041c;
				}
				end_IL_041c:;
			}
			finally
			{
				do
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
				goto end_IL_041b;
			}
			end_IL_041b:;
		}
		catch
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u && checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
			{
				_ = (f2L)(object)Nf2.Default;
			}
		}
		gj = default(Gj4);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (f2L)(object)Nf2.Default;
				eb = (Eb1)(object)Nf2.Default;
			}
		}
		else
		{
			while (obj != null)
			{
			}
		}
		_ = (Co4)(object)Nf2.Default;
		_ = (x8D9)(object)Nf2.Default;
		_ = (k6D9)(object)Nf2.Default;
		_ = (d1X)(object)Nf2.Default;
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				gj = gj;
			}
			finally
			{
				gj = gj;
				goto IL_05ca;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		try
		{
			try
			{
				mb = (Mb5)(object)Nf2.Default;
				x8D = (x8D9)(object)Nf2.Default;
				mb = null;
			}
			finally
			{
				_ = (Co4)(object)Nf2.Default;
				goto end_IL_053d;
			}
			end_IL_053d:;
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
			}
			catch
			{
				o5CZ o5CZ = null;
				o5CZ = o5CZ;
			}
			goto IL_05ca;
		}
		IL_05ca:
		while ((object)Nf2.Default != null)
		{
			try
			{
				do
				{
					gj = default(Gj4);
					gj = gj;
				}
				while (obj != null);
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Eb1)(object)Nf2.Default;
				}
				else
				{
					x8D = x8D;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		do
		{
			try
			{
				d1X d1X = (d1X)(object)Nf2.Default;
				_ = (r8M)Nf2.Default;
			}
			catch
			{
				f0F = f0F;
				f0F = f0F;
			}
		}
		while ((object)Nf2.Default != null || obj != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				o5CZ o5CZ = (o5CZ)(object)Nf2.Default;
			}
			catch
			{
				mb = null;
			}
			finally
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					gj = gj;
				}
				else
				{
					mb = mb;
					d1X d1X = null;
					_ = (Eb1)(object)Nf2.Default;
				}
				goto IL_0676;
			}
		}
		goto IL_0676;
		IL_00d6:
		_ = (Pm9)(object)Nf2.Default;
		_ = (_003CModule_003E)(object)Nf2.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)Nf2.Default) - num == 0)
			{
				do
				{
					_ = (d4E)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
				goto IL_0134;
			}
			try
			{
				_ = (f9T6)(object)Nf2.Default;
			}
			finally
			{
				x8D = (x8D9)(object)Nf2.Default;
				goto IL_0134;
			}
		}
		IL_0676:
		_ = (Pj8)(object)Nf2.Default;
		_ = (_003CModule_003E)(object)Nf2.Default;
		_ = (_003CModule_003E)(object)Nf2.Default;
		_ = (o5CZ)(object)Nf2.Default;
		f0F = f0F;
		try
		{
			try
			{
				try
				{
					_ = (Pm9)(object)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
					Co4 co = null;
				}
				finally
				{
					_ = (w4R)(object)Nf2.Default;
					goto end_IL_06ab;
				}
				end_IL_06ab:;
			}
			finally
			{
				nuint num3;
				checked
				{
					num3 = unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)(UIntPtr)Nf2.Default);
					num = default(UIntPtr);
				}
				if (num3 / num == 0)
				{
					gj = gj;
				}
				else
				{
					_ = (f9T6)(object)Nf2.Default;
				}
				goto end_IL_06aa;
			}
			end_IL_06aa:;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)Nf2.Default) * num) / num == 0)
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			else if (checked(unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
			{
			}
		}
		try
		{
			_ = (x8D9)(object)Nf2.Default;
		}
		finally
		{
			try
			{
				_ = (Pj8)(object)Nf2.Default;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
			}
			goto IL_079b;
		}
	}
}
