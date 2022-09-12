using System;
using System.Collections.Generic;
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
using g5S;
using i3L;
using o8Z;
using p0H;
using q3F;
using z2Z;

namespace q8X;

[DesignerGenerated]
public class Eb1 : Form
{
	internal delegate void Kg9();

	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

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
			EventHandler eventHandler = z9A;
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
			EventHandler eventHandler = t3D;
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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("txtTransport")]
	internal virtual TextBox txtTransport
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

	[field: AccessedThroughProperty("txtBNo")]
	internal virtual TextBox txtBNo
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
			byte[] byte_ = Pj8.byte_0;
			int num = 0;
			while (true)
			{
				EventHandler eventHandler = r9G;
				while (true)
				{
					Button val = _btnDelete;
					if (val != null)
					{
						switch (byte_[346])
						{
						case 204:
							break;
						default:
							goto end_IL_0042;
						case 207:
							((Control)val).remove_Click(eventHandler);
							goto IL_0068;
						case 208:
							goto IL_0068;
						case 203:
							goto IL_007b;
						case 205:
						case 206:
						case 209:
							return;
						}
						continue;
					}
					num = 6;
					goto IL_0068;
					IL_0068:
					_btnDelete = value;
					val = _btnDelete;
					if (val != null)
					{
						num = 1;
						goto IL_007b;
					}
					num = 4;
					return;
					IL_007b:
					((Control)val).add_Click(eventHandler);
					return;
					continue;
					end_IL_0042:
					break;
				}
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
			EventHandler eventHandler = e2P;
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

	[field: AccessedThroughProperty("txtDiscount")]
	internal virtual TextBox txtDiscount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRDetail")]
	internal virtual TextBox txtRDetail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCname")]
	internal virtual TextBox txtCname
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
			EventHandler eventHandler = By0;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
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

	[field: AccessedThroughProperty("txtTotal")]
	internal virtual TextBox txtTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Eb1()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)x6L);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Pt8();
	}

	[DebuggerNonUserCode]
	protected override void Gz4(bool Pq1)
	{
		try
		{
			if (Pq1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pq1);
		}
	}

	[DebuggerStepThrough]
	private void Pt8()
	{
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected O, but got Unknown
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected O, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected O, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected O, but got Unknown
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected O, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected O, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected O, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected O, but got Unknown
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Expected O, but got Unknown
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf1: Expected O, but got Unknown
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected O, but got Unknown
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected O, but got Unknown
		byte[] byte_ = Pj8.byte_0;
		int num = 79;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 22;
			while (true)
			{
				DateTimePicker1 = new DateTimePicker();
				Label9 = new Label();
				txtTransport = new TextBox();
				num = 84;
				while (true)
				{
					Label8 = new Label();
					Label5 = new Label();
					Label4 = new Label();
					num = 61;
					while (true)
					{
						Label1 = new Label();
						txtBNo = new TextBox();
						btnDelete = new Button();
						num = 37;
						while (true)
						{
							btnModify = new Button();
							txtDiscount = new TextBox();
							txtRDetail = new TextBox();
							num = 17;
							while (true)
							{
								txtCname = new TextBox();
								Label2 = new Label();
								btnSave = new Button();
								num = 70;
								while (true)
								{
									DataGridView1 = new DataGridView();
									Label10 = new Label();
									txtTotal = new TextBox();
									num = 55;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										num = 57;
										while (true)
										{
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 47;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(363, 29));
												num = 90;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(52, 17));
													num = 9;
													while (true)
													{
														((Control)Label3).set_TabIndex(7);
														Label3.set_Text("Billing");
														num = 32;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 51;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 27;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 29));
																	num = 19;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 83;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(11);
																			Label6.set_Text("X");
																			num = 39;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 36;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 75;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(42, 29));
																						num = 63;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 67;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(10);
																								Label7.set_Text("Go To Main");
																								num = 60;
																								while (true)
																								{
																									((Control)DateTimePicker1).set_Location(new Point(537, 64));
																									((Control)DateTimePicker1).set_Name("DateTimePicker1");
																									num = 85;
																									while (true)
																									{
																										((Control)DateTimePicker1).set_Size(new Size(126, 20));
																										((Control)DateTimePicker1).set_TabIndex(4);
																										num = 59;
																										while (true)
																										{
																											Label9.set_AutoSize(true);
																											((Control)Label9).set_ForeColor(Color.White);
																											num = byte_[50] - 122;
																											while (true)
																											{
																												switch (num)
																												{
																												case 89:
																													((Control)txtBNo).set_TabIndex(0);
																													((Control)btnDelete).set_Location(new Point(496, 202));
																													num = 68;
																													goto case 68;
																												case 68:
																													((Control)btnDelete).set_Name("btnDelete");
																													((Control)btnDelete).set_Size(new Size(75, 31));
																													num = 2;
																													goto case 2;
																												case 2:
																													((Control)btnDelete).set_TabIndex(9);
																													((ButtonBase)btnDelete).set_Text("DELETE");
																													num = 46;
																													goto case 46;
																												case 46:
																													((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																													((Control)btnModify).set_Location(new Point(378, 202));
																													num = 6;
																													goto case 6;
																												case 6:
																													((Control)btnModify).set_Name("btnModify");
																													((Control)btnModify).set_Size(new Size(75, 31));
																													num = 20;
																													goto case 20;
																												case 20:
																													((Control)btnModify).set_TabIndex(8);
																													((ButtonBase)btnModify).set_Text("MODIFY");
																													num = 52;
																													goto case 52;
																												case 52:
																													((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																													((Control)txtDiscount).set_Location(new Point(243, 124));
																													num = 21;
																													goto case 21;
																												case 21:
																													((Control)txtDiscount).set_Name("txtDiscount");
																													((Control)txtDiscount).set_Size(new Size(100, 20));
																													num = 14;
																													goto case 14;
																												case 14:
																													((Control)txtDiscount).set_TabIndex(2);
																													((Control)txtRDetail).set_Location(new Point(243, 94));
																													num = 11;
																													goto case 11;
																												case 11:
																													((Control)txtRDetail).set_Name("txtRDetail");
																													((Control)txtRDetail).set_Size(new Size(100, 20));
																													num = 80;
																													goto case 80;
																												case 80:
																													((Control)txtRDetail).set_TabIndex(1);
																													((Control)txtCname).set_Location(new Point(537, 99));
																													num = 12;
																													goto case 12;
																												case 12:
																													((Control)txtCname).set_Name("txtCname");
																													((Control)txtCname).set_Size(new Size(100, 20));
																													num = 72;
																													goto case 72;
																												case 72:
																													((Control)txtCname).set_TabIndex(5);
																													goto case 78;
																												case 78:
																													Label2.set_AutoSize(true);
																													num = 74;
																													goto case 74;
																												case 74:
																													((Control)Label2).set_ForeColor(Color.White);
																													((Control)Label2).set_Location(new Point(167, 67));
																													num = 64;
																													goto case 64;
																												case 64:
																													((Control)Label2).set_Name("Label2");
																													((Control)Label2).set_Size(new Size(57, 13));
																													num = 15;
																													goto case 15;
																												case 15:
																													((Control)Label2).set_TabIndex(72);
																													Label2.set_Text("Billing No :");
																													num = 58;
																													goto case 58;
																												case 58:
																													((Control)btnSave).set_Location(new Point(249, 202));
																													((Control)btnSave).set_Name("btnSave");
																													num = 50;
																													goto case 50;
																												case 50:
																													((Control)btnSave).set_Size(new Size(75, 31));
																													((Control)btnSave).set_TabIndex(7);
																													num = 44;
																													goto case 44;
																												case 44:
																													((ButtonBase)btnSave).set_Text("SAVE");
																													((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																													num = 33;
																													goto case 33;
																												case 33:
																													DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																													((Control)DataGridView1).set_Location(new Point(45, 239));
																													num = 29;
																													goto case 29;
																												case 29:
																													((Control)DataGridView1).set_Name("DataGridView1");
																													((Control)DataGridView1).set_Size(new Size(724, 199));
																													num = 54;
																													goto case 54;
																												case 54:
																													((Control)DataGridView1).set_TabIndex(12);
																													Label10.set_AutoSize(true);
																													num = 8;
																													goto case 8;
																												case 8:
																													((Control)Label10).set_ForeColor(Color.White);
																													((Control)Label10).set_Location(new Point(478, 139));
																													num = 45;
																													goto case 45;
																												case 45:
																													((Control)Label10).set_Name("Label10");
																													((Control)Label10).set_Size(new Size(37, 13));
																													num = 73;
																													goto case 73;
																												case 73:
																													((Control)Label10).set_TabIndex(81);
																													Label10.set_Text("Total :");
																													num = 10;
																													goto case 10;
																												case 10:
																													((Control)txtTotal).set_Location(new Point(537, 136));
																													((Control)txtTotal).set_Name("txtTotal");
																													num = 7;
																													goto case 7;
																												case 7:
																													((Control)txtTotal).set_Size(new Size(100, 20));
																													((Control)txtTotal).set_TabIndex(6);
																													num = 16;
																													goto case 16;
																												case 16:
																													((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																													((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																													num = 28;
																													goto case 28;
																												case 28:
																													((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																													((Form)this).set_ClientSize(new Size(800, 450));
																													num = 23;
																													goto case 23;
																												case 23:
																													((Control)this).get_Controls().Add((Control)(object)txtTotal);
																													goto case 38;
																												case 38:
																													((Control)this).get_Controls().Add((Control)(object)Label10);
																													num = 76;
																													goto case 76;
																												case 76:
																													((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																													((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																													num = 35;
																													goto case 35;
																												case 35:
																													((Control)this).get_Controls().Add((Control)(object)Label9);
																													((Control)this).get_Controls().Add((Control)(object)txtTransport);
																													num = 69;
																													goto case 69;
																												case 69:
																													((Control)this).get_Controls().Add((Control)(object)Label8);
																													((Control)this).get_Controls().Add((Control)(object)Label5);
																													num = 62;
																													goto case 62;
																												case 62:
																													((Control)this).get_Controls().Add((Control)(object)Label4);
																													((Control)this).get_Controls().Add((Control)(object)Label1);
																													num = byte_[29] - 94;
																													continue;
																												case 88:
																													((Control)txtTransport).set_TabIndex(3);
																													Label8.set_AutoSize(true);
																													num = 41;
																													goto case 41;
																												case 41:
																													((Control)Label8).set_ForeColor(Color.White);
																													((Control)Label8).set_Location(new Point(166, 130));
																													num = 86;
																													goto case 86;
																												case 86:
																													((Control)Label8).set_Name("Label8");
																													((Control)Label8).set_Size(new Size(55, 13));
																													num = 26;
																													goto case 26;
																												case 26:
																													((Control)Label8).set_TabIndex(76);
																													Label8.set_Text("Discount :");
																													num = 25;
																													goto case 25;
																												case 25:
																													Label5.set_AutoSize(true);
																													((Control)Label5).set_ForeColor(Color.White);
																													num = 30;
																													goto case 30;
																												case 30:
																													((Control)Label5).set_Location(new Point(156, 101));
																													((Control)Label5).set_Name("Label5");
																													num = 0;
																													goto case 0;
																												case 0:
																													((Control)Label5).set_Size(new Size(65, 13));
																													((Control)Label5).set_TabIndex(75);
																													num = 42;
																													goto case 42;
																												case 42:
																													Label5.set_Text("Raw Detail :");
																													Label4.set_AutoSize(true);
																													goto case 48;
																												case 48:
																													num = 4;
																													goto case 4;
																												case 4:
																													((Control)Label4).set_ForeColor(Color.White);
																													((Control)Label4).set_Location(new Point(427, 106));
																													num = 65;
																													goto case 65;
																												case 65:
																													((Control)Label4).set_Name("Label4");
																													((Control)Label4).set_Size(new Size(88, 13));
																													num = 87;
																													goto case 87;
																												case 87:
																													((Control)Label4).set_TabIndex(74);
																													Label4.set_Text("Customer Name :");
																													num = 5;
																													goto case 5;
																												case 5:
																													Label1.set_AutoSize(true);
																													((Control)Label1).set_ForeColor(Color.White);
																													num = 43;
																													goto case 43;
																												case 43:
																													((Control)Label1).set_Location(new Point(450, 64));
																													((Control)Label1).set_Name("Label1");
																													num = 18;
																													goto case 18;
																												case 18:
																													((Control)Label1).set_Size(new Size(66, 13));
																													((Control)Label1).set_TabIndex(73);
																													num = 82;
																													goto case 82;
																												case 82:
																													Label1.set_Text("Billing Date :");
																													((Control)txtBNo).set_Location(new Point(245, 64));
																													num = 40;
																													goto case 40;
																												case 40:
																													((Control)txtBNo).set_Name("txtBNo");
																													((Control)txtBNo).set_Size(new Size(100, 20));
																													num = 89;
																													goto case 89;
																												case 77:
																													((Control)txtTransport).set_Name("txtTransport");
																													((Control)txtTransport).set_Size(new Size(100, 20));
																													num = 88;
																													goto case 88;
																												case 56:
																													((Control)Label9).set_Location(new Point(132, 162));
																													((Control)Label9).set_Name("Label9");
																													num = 1;
																													goto case 1;
																												case 1:
																													((Control)Label9).set_Size(new Size(88, 13));
																													((Control)Label9).set_TabIndex(78);
																													num = 49;
																													goto case 49;
																												case 49:
																													Label9.set_Text("Transport Detail :");
																													((Control)txtTransport).set_Location(new Point(243, 159));
																													num = 77;
																													goto case 77;
																												case 59:
																													break;
																												case 85:
																													goto end_IL_0978;
																												case 60:
																													goto end_IL_09a1;
																												case 67:
																													goto end_IL_09c6;
																												case 63:
																													goto end_IL_09f2;
																												case 75:
																													goto end_IL_0a14;
																												case 36:
																													goto end_IL_0a3d;
																												case 39:
																													goto end_IL_0a66;
																												case 83:
																													goto end_IL_0a88;
																												case 19:
																													goto end_IL_0aa9;
																												case 27:
																													goto end_IL_0acb;
																												case 51:
																													goto end_IL_0af4;
																												case 32:
																													goto end_IL_0b20;
																												case 9:
																													goto end_IL_0b42;
																												case 90:
																													goto end_IL_0b63;
																												case 47:
																													goto end_IL_0b84;
																												case 57:
																													goto end_IL_0bad;
																												case 55:
																													goto end_IL_0bd9;
																												case 70:
																													goto end_IL_0bfb;
																												case 17:
																													goto end_IL_0c1d;
																												case 37:
																													goto end_IL_0c43;
																												case 61:
																													goto end_IL_0c69;
																												case 84:
																													goto end_IL_0c8f;
																												case 22:
																													goto end_IL_0cb5;
																												default:
																													goto end_IL_0cdb;
																												case 71:
																													((Control)this).get_Controls().Add((Control)(object)txtBNo);
																													((Control)this).get_Controls().Add((Control)(object)btnDelete);
																													num = 3;
																													goto case 3;
																												case 3:
																													((Control)this).get_Controls().Add((Control)(object)btnModify);
																													((Control)this).get_Controls().Add((Control)(object)txtDiscount);
																													num = 24;
																													goto case 24;
																												case 24:
																													((Control)this).get_Controls().Add((Control)(object)txtRDetail);
																													((Control)this).get_Controls().Add((Control)(object)txtCname);
																													num = 13;
																													goto case 13;
																												case 13:
																													((Control)this).get_Controls().Add((Control)(object)Label2);
																													((Control)this).get_Controls().Add((Control)(object)btnSave);
																													num = 66;
																													goto case 66;
																												case 66:
																													((Control)this).get_Controls().Add((Control)(object)Label6);
																													((Control)this).get_Controls().Add((Control)(object)Label7);
																													num = 31;
																													goto case 31;
																												case 31:
																													((Control)this).get_Controls().Add((Control)(object)Label3);
																													((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																													num = 81;
																													goto case 81;
																												case 81:
																													((Control)this).set_Name("frmBilling");
																													((Form)this).set_StartPosition((FormStartPosition)1);
																													((Form)this).set_Text("frmBilling");
																													num = 34;
																													goto case 34;
																												case 34:
																													((ISupportInitialize)DataGridView1).EndInit();
																													((Control)this).ResumeLayout(false);
																													((Control)this).PerformLayout();
																													num = 53;
																													return;
																												case 53:
																													return;
																												}
																												break;
																											}
																											continue;
																											end_IL_0978:
																											break;
																										}
																										continue;
																										end_IL_09a1:
																										break;
																									}
																									continue;
																									end_IL_09c6:
																									break;
																								}
																								continue;
																								end_IL_09f2:
																								break;
																							}
																							continue;
																							end_IL_0a14:
																							break;
																						}
																						continue;
																						end_IL_0a3d:
																						break;
																					}
																					continue;
																					end_IL_0a66:
																					break;
																				}
																				continue;
																				end_IL_0a88:
																				break;
																			}
																			continue;
																			end_IL_0aa9:
																			break;
																		}
																		continue;
																		end_IL_0acb:
																		break;
																	}
																	continue;
																	end_IL_0af4:
																	break;
																}
																continue;
																end_IL_0b20:
																break;
															}
															continue;
															end_IL_0b42:
															break;
														}
														continue;
														end_IL_0b63:
														break;
													}
													continue;
													end_IL_0b84:
													break;
												}
												continue;
												end_IL_0bad:
												break;
											}
											continue;
											end_IL_0bd9:
											break;
										}
										continue;
										end_IL_0bfb:
										break;
									}
									continue;
									end_IL_0c1d:
									break;
								}
								continue;
								end_IL_0c43:
								break;
							}
							continue;
							end_IL_0c69:
							break;
						}
						continue;
						end_IL_0c8f:
						break;
					}
					continue;
					end_IL_0cb5:
					break;
				}
				continue;
				end_IL_0cdb:
				break;
			}
		}
	}

	private void t3D(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void z9A(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void x6L(object sender, EventArgs e)
	{
		Er5();
	}

	private void By0(object sender, EventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_billing values(" + Conversions.ToString(Conversions.ToInteger(txtBNo.get_Text())) + ",'" + DateTimePicker1.get_Text() + "','" + txtCname.get_Text() + "','" + txtRDetail.get_Text() + "','" + txtDiscount.get_Text() + "','" + txtTransport.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtTotal.get_Text())) + ")");
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
		Er5();
	}

	public void Er5()
	{
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_billing");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Bill No");
			DataGridView1.get_Columns().Add("c2", "Bill Date");
			DataGridView1.get_Columns().Add("c3", "Customer Name");
			DataGridView1.get_Columns().Add("c4", "Raw Detail");
			DataGridView1.get_Columns().Add("c5", "Discount");
			DataGridView1.get_Columns().Add("c6", "Transport Detail");
			DataGridView1.get_Columns().Add("c7", "Total");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[7]
				{
					rd.get_Item("billno").ToString(),
					rd.get_Item("bdate"),
					rd.get_Item("cname"),
					rd.get_Item("rawdetail"),
					rd.get_Item("discount"),
					rd.get_Item("transportdetail"),
					rd.get_Item("total").ToString()
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

	private void e2P(object sender, EventArgs e)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_billing set bdate ='" + DateTimePicker1.get_Text() + "',cname='" + txtCname.get_Text() + "',rawdetail='" + txtRDetail.get_Text() + "',discount=''" + txtDiscount.get_Text() + "', transportdetail='" + txtTransport.get_Text() + "', total='" + txtTotal.get_Text() + "' where billno=" + Conversions.ToString(Conversions.ToInteger(txtBNo.get_Text())));
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
		Er5();
	}

	private void r9G(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_billing where billno=" + Conversions.ToString(Conversions.ToInteger(txtBNo.get_Text())));
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
		Er5();
		Pj8.byte_0[199] = (byte)((Pj8.byte_0[199] | Pj8.byte_0[329]) & 0x56);
	}

	[STAThread]
	public static void Mw3()
	{
		try
		{
			int kz;
			do
			{
				kz = 2;
			}
			while (!Np8.j3D() || !Pj8.c8T(kz));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = m0N.Pi1(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = m0N.Pi1(Listt, 1, 1);
			mName = m0N.Pi1(Listt, 2, 2);
			mArray = m0N.Pi1(Listt, 3, 3);
			sArray = m0N.Pi1(Listt, 4, 4);
			T = m0N.Pi1(Listt, 5, 5);
			sNum = m0N.Pi1(Listt, 6, 6);
			mDic.Add(sNum, 98);
			byte[] value = Pj8.Am9(98, 15);
			mDic.Add(sArray, value);
			Mb5.Qe8();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void f8T()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f9T6 f9T);
		checked
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					f9T6 obj = (f9T6)(object)Nf2.Default;
					f9T = f9T;
					f9T = obj;
				}
			}
			finally
			{
				uIntPtr = uIntPtr;
				nuint num = uIntPtr - uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num * uIntPtr == 0)
				{
					_ = (w4R)(object)Nf2.Default;
					Pj8 obj2 = (Pj8)(object)Nf2.Default;
					pj = null;
					pj = obj2;
				}
				goto IL_0069;
			}
		}
		IL_0069:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		Nf2 nf;
		try
		{
		}
		finally
		{
			try
			{
				_ = (d1X)(object)Nf2.Default;
			}
			finally
			{
				do
				{
					_ = (w4R)(object)Nf2.Default;
					_ = (d1X)(object)Nf2.Default;
					Nf2 obj3 = Nf2.Default;
					nf = null;
					nf = obj3;
					obj4 = obj4;
				}
				while (obj4 != null);
				goto IL_00b6;
			}
		}
		IL_00b6:
		_ = (Co4)(object)Nf2.Default;
		_003CModule_003E obj5 = (_003CModule_003E)(object)Nf2.Default;
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
		_003CModule_003E = obj5;
		m0N m0N = (m0N)(object)Nf2.Default;
		m0N = m0N;
		d1X obj6 = (d1X)(object)Nf2.Default;
		d1X d1X = d1X;
		d1X = obj6;
		try
		{
		}
		finally
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				else
				{
					_ = Nf2.Default;
				}
			}
			else
			{
				while ((object)Nf2.Default != null)
				{
					m0N = m0N;
				}
			}
			goto IL_014d;
		}
		IL_014d:
		try
		{
			_ = (Pm9)(object)Nf2.Default;
		}
		catch
		{
			_ = (o5CZ)(object)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		checked
		{
			if (uIntPtr == 0)
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked(uIntPtr / unchecked((nuint)default(UIntPtr))) == 0)
				{
					co = null;
					co = null;
				}
			}
			else
			{
				_ = (f2L)(object)Nf2.Default;
			}
			f9T = f9T;
			try
			{
				d4E d4E = d4E;
			}
			finally
			{
				try
				{
					try
					{
						_ = (w4R)(object)Nf2.Default;
						Pm9 obj8 = (Pm9)(object)Nf2.Default;
						pm = pm;
						pm = obj8;
					}
					catch
					{
						_ = (d8B)(object)Nf2.Default;
					}
				}
				catch
				{
					while (obj4 != null)
					{
						pj = pj;
					}
				}
				goto IL_0202;
			}
		}
		IL_0202:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					d1X = d1X;
					f2L = null;
					f2L = f2L;
					_ = (w4R)(object)Nf2.Default;
				}
				else
				{
					_ = (x8D9)(object)Nf2.Default;
					Gj4 obj11 = (Gj4)Nf2.Default;
					Gj4 gj = gj;
					gj = obj11;
					d8B obj12 = (d8B)(object)Nf2.Default;
					d8B d8B = d8B;
					d8B = obj12;
				}
			}
			else
			{
				do
				{
					np = np;
					np = np;
				}
				while (obj4 != null);
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					nf = nf;
				}
			}
			else
			{
				while (obj4 != null)
				{
					_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
					f9T = f9T;
					m0N = m0N;
					np = np;
				}
			}
		}
		try
		{
			_ = (Eb1)(object)Nf2.Default;
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
			}
			catch
			{
				_ = (d1X)(object)Nf2.Default;
				_ = (Gj4)Nf2.Default;
			}
			finally
			{
				try
				{
					_ = (Gj4)Nf2.Default;
				}
				catch
				{
					_ = (f0F)(object)Nf2.Default;
				}
				goto IL_033f;
			}
		}
		IL_033f:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked(uIntPtr / uIntPtr) == 0)
			{
				try
				{
					x8D = null;
					x8D = null;
				}
				catch
				{
				}
			}
			try
			{
				_ = (d8B)(object)Nf2.Default;
			}
			catch
			{
				_ = (x8D9)(object)Nf2.Default;
			}
			finally
			{
				try
				{
					_ = (Gj4)Nf2.Default;
				}
				finally
				{
					try
					{
						_ = (Pm9)(object)Nf2.Default;
					}
					finally
					{
						_ = (f2L)(object)Nf2.Default;
						goto IL_03be;
					}
				}
			}
		}
		IL_0448:
		do
		{
			if (uIntPtr != 0)
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			else
			{
				_ = (Gj4)Nf2.Default;
			}
		}
		while (obj4 != null);
		checked
		{
			do
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				catch
				{
					nuint num2 = uIntPtr + unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (num2 - uIntPtr == 0)
					{
						x8D = x8D;
					}
					else
					{
						pm = null;
					}
				}
			}
			while (obj4 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		do
		{
			if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
			{
				do
				{
					Gj4 gj = (Gj4)Nf2.Default;
				}
				while (obj4 != null);
				continue;
			}
			try
			{
				o5CZ = o5CZ;
				o5CZ = o5CZ;
				_ = Nf2.Default;
			}
			finally
			{
				f2L = f2L;
				continue;
			}
		}
		while (obj4 != null);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
				while (obj4 != null)
				{
					_ = (Co4)(object)Nf2.Default;
					co = null;
					_ = (Pj8)(object)Nf2.Default;
					k6D = k6D;
					k6D = null;
				}
			}
			catch
			{
				try
				{
					_ = (m0N)(object)Nf2.Default;
				}
				catch
				{
					f2L = null;
				}
			}
		}
		x8D = null;
		do
		{
			_003CModule_003E = _003CModule_003E;
		}
		while (obj4 != null);
		try
		{
			if (uIntPtr == 0)
			{
				f2L = null;
			}
			else
			{
				nf = Nf2.Default;
				f2L = null;
				_ = Nf2.Default;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
			}
		}
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				do
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
			else
			{
				try
				{
					_ = (r8M)Nf2.Default;
					f2L = f2L;
					_ = (Pj8)(object)Nf2.Default;
					_ = (x8D9)(object)Nf2.Default;
				}
				catch
				{
					co = co;
				}
			}
			try
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			finally
			{
				do
				{
					try
					{
						m0N = null;
					}
					finally
					{
						_ = (k6D9)(object)Nf2.Default;
						continue;
					}
				}
				while (obj4 != null);
				goto IL_0616;
			}
		}
		IL_0616:
		f2L = f2L;
		while (obj4 != null)
		{
			_ = (Mb5)(object)Nf2.Default;
		}
		m0N = m0N;
		while ((object)Nf2.Default != null)
		{
			if ((nuint)(UIntPtr)Nf2.Default / (nuint)(UIntPtr)Nf2.Default == 0)
			{
				pj = pj;
			}
			else
			{
				_ = (Mb5)(object)Nf2.Default;
			}
		}
		while (obj4 != null)
		{
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				f9T = f9T;
			}
			catch
			{
				_ = (f2L)(object)Nf2.Default;
				m0N = (m0N)(object)Nf2.Default;
				_ = (Np8)(object)Nf2.Default;
			}
		}
		try
		{
			try
			{
				_ = (Np8)(object)Nf2.Default;
			}
			finally
			{
				try
				{
					_ = (f0F)(object)Nf2.Default;
				}
				catch
				{
					_ = (d4E)(object)Nf2.Default;
				}
				goto end_IL_06c7;
			}
			end_IL_06c7:;
		}
		catch
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					m0N = (m0N)(object)Nf2.Default;
				}
				else
				{
					_ = (r8M)Nf2.Default;
				}
			}
			catch
			{
				r8M r8M = default(r8M);
			}
		}
		do
		{
			try
			{
				_ = (Gj4)Nf2.Default;
			}
			catch
			{
				d8B d8B = (d8B)(object)Nf2.Default;
			}
			finally
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					nf = null;
				}
				else
				{
					_ = (m0N)(object)Nf2.Default;
				}
				continue;
			}
		}
		while (obj4 != null);
		while ((object)Nf2.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (x8D9)(object)Nf2.Default;
				_ = (x8D9)(object)Nf2.Default;
				continue;
			}
			do
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
				_ = Nf2.Default;
				d8B d8B = null;
				d8B = null;
			}
			while ((object)Nf2.Default != null);
		}
		return;
		IL_03be:
		try
		{
			do
			{
				if (uIntPtr == 0)
				{
					Gj4 gj = (Gj4)Nf2.Default;
				}
			}
			while (obj4 != null);
		}
		finally
		{
			try
			{
				do
				{
					f9T = (f9T6)(object)Nf2.Default;
					f9T = (f9T6)(object)Nf2.Default;
					pm = pm;
				}
				while (obj4 != null);
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
			}
			goto IL_0448;
		}
	}
}
