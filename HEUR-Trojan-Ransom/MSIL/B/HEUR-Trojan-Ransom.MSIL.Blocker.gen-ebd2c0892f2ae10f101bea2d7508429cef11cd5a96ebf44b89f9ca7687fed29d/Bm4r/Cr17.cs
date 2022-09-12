using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
using i1QX;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace Bm4r;

[DesignerGenerated]
public class Cr17 : Form
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
			EventHandler eventHandler = Nd4y;
			Label label = _Label6;
			Label obj = label;
			s5C.int_0[92] = (s5C.int_0[92] - s5C.int_0[34]) & 0xE0;
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
			EventHandler eventHandler = j1RJ;
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
			EventHandler eventHandler = Hz58;
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
			EventHandler eventHandler = Go57;
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
			EventHandler eventHandler = Eb62;
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

	public Cr17()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Cq26);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		e7Y6();
	}

	[DebuggerNonUserCode]
	protected override void e2CH(bool i6TQ)
	{
		try
		{
			if (i6TQ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i6TQ);
		}
	}

	[DebuggerStepThrough]
	private void e7Y6()
	{
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected O, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected O, but got Unknown
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected O, but got Unknown
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected O, but got Unknown
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Expected O, but got Unknown
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Expected O, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected O, but got Unknown
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected O, but got Unknown
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Expected O, but got Unknown
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected O, but got Unknown
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected O, but got Unknown
		int[] int_ = s5C.int_0;
		char[] char_ = o1W.char_0;
		int num = 43;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 57;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 60;
				while (true)
				{
					txtWRent = new TextBox();
					txtMname = new TextBox();
					txtWName = new TextBox();
					num = 31;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 56;
						while (true)
						{
							Label5 = new Label();
							txtWid = new TextBox();
							btnSave = new Button();
							num = 16;
							while (true)
							{
								txtWAddress = new TextBox();
								Label8 = new Label();
								Label9 = new Label();
								num = 81;
								while (true)
								{
									txtWStock = new TextBox();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 83;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 24;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(326, 23));
											num = 33;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(137, 17));
												num = 35;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Warehouse Detail");
													num = 36;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 79;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 61;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(723, 23));
																num = 1;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 42;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(10);
																		Label6.set_Text("X");
																		num = 66;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = 50;
																			while (true)
																			{
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 20;
																				while (true)
																				{
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(31, 23));
																					num = int_[449] - 16068;
																					while (true)
																					{
																						switch (num)
																						{
																						case 11:
																						case 82:
																							((Control)btnModify).set_Location(new Point(307, 218));
																							((Control)btnModify).set_Name("btnModify");
																							num = 47;
																							goto case 47;
																						case 47:
																							((Control)btnModify).set_Size(new Size(75, 23));
																							((Control)btnModify).set_TabIndex(7);
																							num = 25;
																							goto case 25;
																						case 25:
																							((ButtonBase)btnModify).set_Text("MODIFY");
																							((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																							num = 71;
																							goto case 71;
																						case 71:
																							DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																							((Control)DataGridView1).set_Location(new Point(71, 255));
																							num = 3;
																							goto case 3;
																						case 3:
																							((Control)DataGridView1).set_Name("DataGridView1");
																							((Control)DataGridView1).set_Size(new Size(599, 183));
																							num = 44;
																							goto case 44;
																						case 44:
																							((Control)DataGridView1).set_TabIndex(11);
																							((Control)txtWRent).set_Location(new Point(212, 173));
																							num = 78;
																							goto case 78;
																						case 78:
																							((Control)txtWRent).set_Name("txtWRent");
																							((Control)txtWRent).set_Size(new Size(100, 20));
																							num = 38;
																							goto case 38;
																						case 38:
																							((Control)txtWRent).set_TabIndex(3);
																							((Control)txtMname).set_Location(new Point(212, 134));
																							num = 40;
																							goto case 40;
																						case 40:
																							((Control)txtMname).set_Name("txtMname");
																							((Control)txtMname).set_Size(new Size(100, 20));
																							num = 18;
																							goto case 18;
																						case 18:
																							((Control)txtMname).set_TabIndex(2);
																							((Control)txtWName).set_Location(new Point(212, 95));
																							num = 48;
																							goto case 48;
																						case 48:
																							((Control)txtWName).set_Name("txtWName");
																							((Control)txtWName).set_Size(new Size(100, 20));
																							num = 32;
																							goto case 32;
																						case 32:
																							((Control)txtWName).set_TabIndex(1);
																							Label4.set_AutoSize(true);
																							num = 51;
																							goto case 51;
																						case 51:
																							((Control)Label4).set_ForeColor(Color.White);
																							((Control)Label4).set_Location(new Point(135, 177));
																							num = 19;
																							goto case 19;
																						case 19:
																							((Control)Label4).set_Name("Label4");
																							((Control)Label4).set_Size(new Size(36, 13));
																							num = 63;
																							goto case 63;
																						case 63:
																							((Control)Label4).set_TabIndex(21);
																							Label4.set_Text("Rent :");
																							num = 46;
																							goto case 46;
																						case 46:
																							Label1.set_AutoSize(true);
																							goto case 6;
																						case 6:
																							((Control)Label1).set_ForeColor(Color.White);
																							num = 80;
																							goto case 80;
																						case 80:
																							((Control)Label1).set_Location(new Point(85, 139));
																							((Control)Label1).set_Name("Label1");
																							num = 49;
																							goto case 49;
																						case 49:
																							((Control)Label1).set_Size(new Size(86, 13));
																							((Control)Label1).set_TabIndex(20);
																							num = 2;
																							goto case 2;
																						case 2:
																							Label1.set_Text("Manager Name :");
																							Label2.set_AutoSize(true);
																							num = 7;
																							goto case 7;
																						case 7:
																							((Control)Label2).set_ForeColor(Color.White);
																							((Control)Label2).set_Location(new Point(91, 63));
																							num = 77;
																							goto case 77;
																						case 77:
																							((Control)Label2).set_Name("Label2");
																							((Control)Label2).set_Size(new Size(80, 13));
																							num = 62;
																							goto case 62;
																						case 62:
																							((Control)Label2).set_TabIndex(19);
																							Label2.set_Text("Warehouse Id :");
																							num = 72;
																							goto case 72;
																						case 72:
																							Label5.set_AutoSize(true);
																							((Control)Label5).set_ForeColor(Color.White);
																							num = 73;
																							goto case 73;
																						case 73:
																							((Control)Label5).set_Location(new Point(72, 101));
																							((Control)Label5).set_Name("Label5");
																							num = 4;
																							goto case 4;
																						case 4:
																							((Control)Label5).set_Size(new Size(99, 13));
																							((Control)Label5).set_TabIndex(18);
																							num = 65;
																							goto case 65;
																						case 65:
																							Label5.set_Text("Warehouse Name :");
																							((Control)txtWid).set_Location(new Point(212, 56));
																							num = 75;
																							goto case 75;
																						case 75:
																							((Control)txtWid).set_Name("txtWid");
																							((Control)txtWid).set_Size(new Size(100, 20));
																							num = 39;
																							goto case 39;
																						case 39:
																							((Control)txtWid).set_TabIndex(0);
																							((Control)btnSave).set_Location(new Point(199, 218));
																							num = 30;
																							goto case 30;
																						case 30:
																							((Control)btnSave).set_Name("btnSave");
																							((Control)btnSave).set_Size(new Size(75, 23));
																							num = 8;
																							goto case 8;
																						case 8:
																							((Control)btnSave).set_TabIndex(6);
																							((ButtonBase)btnSave).set_Text("SAVE");
																							num = 27;
																							goto case 27;
																						case 27:
																							((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																							((Control)txtWAddress).set_Location(new Point(471, 60));
																							num = 76;
																							goto case 76;
																						case 76:
																							txtWAddress.set_Multiline(true);
																							((Control)txtWAddress).set_Name("txtWAddress");
																							num = 28;
																							goto case 28;
																						case 28:
																							((Control)txtWAddress).set_Size(new Size(122, 67));
																							((Control)txtWAddress).set_TabIndex(4);
																							num = 74;
																							goto case 74;
																						case 74:
																							Label8.set_AutoSize(true);
																							((Control)Label8).set_ForeColor(Color.White);
																							num = 5;
																							goto case 5;
																						case 5:
																							((Control)Label8).set_Location(new Point(402, 60));
																							((Control)Label8).set_Name("Label8");
																							num = 26;
																							goto case 26;
																						case 26:
																							((Control)Label8).set_Size(new Size(51, 13));
																							((Control)Label8).set_TabIndex(28);
																							num = 9;
																							goto case 9;
																						case 9:
																							Label8.set_Text("Address :");
																							Label9.set_AutoSize(true);
																							num = 22;
																							goto case 22;
																						case 22:
																							((Control)Label9).set_ForeColor(Color.White);
																							((Control)Label9).set_Location(new Point(357, 144));
																							num = 69;
																							goto case 69;
																						case 69:
																							((Control)Label9).set_Name("Label9");
																							((Control)Label9).set_Size(new Size(99, 13));
																							num = 41;
																							goto case 41;
																						case 41:
																							((Control)Label9).set_TabIndex(30);
																							Label9.set_Text("Warehouse Stock :");
																							num = 68;
																							goto case 68;
																						case 68:
																							((Control)txtWStock).set_Location(new Point(471, 144));
																							((Control)txtWStock).set_Name("txtWStock");
																							num = 52;
																							goto case 52;
																						case 52:
																							((Control)txtWStock).set_Size(new Size(122, 20));
																							((Control)txtWStock).set_TabIndex(5);
																							num = 53;
																							goto case 53;
																						case 53:
																							((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																							((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																							num = 17;
																							goto case 17;
																						case 17:
																							((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																							((Form)this).set_ClientSize(new Size(800, 450));
																							num = 13;
																							goto case 13;
																						case 13:
																							((Control)this).get_Controls().Add((Control)(object)txtWStock);
																							((Control)this).get_Controls().Add((Control)(object)Label9);
																							num = 14;
																							goto case 14;
																						case 14:
																							((Control)this).get_Controls().Add((Control)(object)txtWAddress);
																							((Control)this).get_Controls().Add((Control)(object)Label8);
																							num = 55;
																							goto case 55;
																						case 55:
																							((Control)this).get_Controls().Add((Control)(object)btnDelete);
																							((Control)this).get_Controls().Add((Control)(object)btnModify);
																							num = 37;
																							goto case 37;
																						case 37:
																							((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																							((Control)this).get_Controls().Add((Control)(object)txtWRent);
																							num = 58;
																							goto case 58;
																						case 58:
																							((Control)this).get_Controls().Add((Control)(object)txtMname);
																							((Control)this).get_Controls().Add((Control)(object)txtWName);
																							num = 10;
																							goto case 10;
																						case 10:
																							((Control)this).get_Controls().Add((Control)(object)Label4);
																							((Control)this).get_Controls().Add((Control)(object)Label1);
																							num = 12;
																							goto case 12;
																						case 12:
																							((Control)this).get_Controls().Add((Control)(object)Label2);
																							((Control)this).get_Controls().Add((Control)(object)Label5);
																							num = char_[369] - 55921;
																							continue;
																						case 70:
																							((Control)btnDelete).set_Location(new Point(419, 218));
																							((Control)btnDelete).set_Name("btnDelete");
																							num = 21;
																							goto case 21;
																						case 21:
																							((Control)btnDelete).set_Size(new Size(75, 23));
																							((Control)btnDelete).set_TabIndex(8);
																							num = 23;
																							goto case 23;
																						case 23:
																							((ButtonBase)btnDelete).set_Text("DELETE");
																							((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																							num = 11;
																							goto case 11;
																						case 59:
																							((Control)Label7).set_TabIndex(9);
																							Label7.set_Text("Go To Main");
																							num = 70;
																							goto case 70;
																						case 54:
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 59;
																							goto case 59;
																						case 20:
																							break;
																						case 50:
																							goto end_IL_099f;
																						case 66:
																							goto end_IL_09d6;
																						case 42:
																							goto end_IL_09f8;
																						case 1:
																							goto end_IL_0a19;
																						case 61:
																							goto end_IL_0a3b;
																						case 79:
																							goto end_IL_0a64;
																						case 36:
																							goto end_IL_0a8f;
																						case 35:
																							goto end_IL_0ab1;
																						case 33:
																							goto end_IL_0ad2;
																						case 24:
																							goto end_IL_0af4;
																						case 83:
																							goto end_IL_0b20;
																						case 81:
																							goto end_IL_0b4c;
																						case 16:
																							goto end_IL_0b7a;
																						case 56:
																							goto end_IL_0b9b;
																						case 31:
																							goto end_IL_0bc1;
																						case 60:
																							goto end_IL_0be7;
																						case 57:
																							goto end_IL_0c0d;
																						default:
																							goto end_IL_0c33;
																						case 0:
																							((Control)this).get_Controls().Add((Control)(object)txtWid);
																							((Control)this).get_Controls().Add((Control)(object)btnSave);
																							goto case 29;
																						case 29:
																							num = 64;
																							goto case 64;
																						case 64:
																							((Control)this).get_Controls().Add((Control)(object)Label6);
																							((Control)this).get_Controls().Add((Control)(object)Label7);
																							num = 34;
																							goto case 34;
																						case 34:
																							((Control)this).get_Controls().Add((Control)(object)Label3);
																							((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																							num = 15;
																							goto case 15;
																						case 15:
																							((Control)this).set_Name("frmWarehouseDetail");
																							((Form)this).set_StartPosition((FormStartPosition)1);
																							((Form)this).set_Text("frmWarehouseDetail");
																							num = 45;
																							goto case 45;
																						case 45:
																							((ISupportInitialize)DataGridView1).EndInit();
																							((Control)this).ResumeLayout(false);
																							((Control)this).PerformLayout();
																							num = 67;
																							return;
																						case 67:
																							return;
																						}
																						break;
																					}
																					continue;
																					end_IL_099f:
																					break;
																				}
																				continue;
																				end_IL_09d6:
																				break;
																			}
																			continue;
																			end_IL_09f8:
																			break;
																		}
																		continue;
																		end_IL_0a19:
																		break;
																	}
																	continue;
																	end_IL_0a3b:
																	break;
																}
																continue;
																end_IL_0a64:
																break;
															}
															continue;
															end_IL_0a8f:
															break;
														}
														continue;
														end_IL_0ab1:
														break;
													}
													continue;
													end_IL_0ad2:
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
										end_IL_0b4c:
										break;
									}
									continue;
									end_IL_0b7a:
									break;
								}
								continue;
								end_IL_0b9b:
								break;
							}
							continue;
							end_IL_0bc1:
							break;
						}
						continue;
						end_IL_0be7:
						break;
					}
					continue;
					end_IL_0c0d:
					break;
				}
				continue;
				end_IL_0c33:
				break;
			}
		}
	}

	private void j1RJ(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void Nd4y(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Eb62(object sender, EventArgs e)
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
		z3R5();
	}

	public void z3R5()
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
	}

	private void Cq26(object sender, EventArgs e)
	{
		z3R5();
	}

	private void Go57(object sender, EventArgs e)
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
		z3R5();
		o1W.char_0[358] = (char)((o1W.char_0[358] ^ o1W.char_0[475]) & '·');
	}

	private void Hz58(object sender, EventArgs e)
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
		z3R5();
	}

	internal static void p5TN()
	{
		k2GS.mDic.Add("c", typeof(k2GS.Zm3));
		Delegate value = Delegate.CreateDelegate(typeof(k2GS.Zm3), (Type)k2GS.mDic[k2GS.T], Conversions.ToString(k2GS.mDic[k2GS.mName]), ignoreCase: false, throwOnBindFailure: true);
		k2GS.mDic.Add("z", value);
		if (k2GS.mDic["z"] != null)
		{
			((k2GS.Zm3)(Delegate)k2GS.mDic["z"])();
		}
	}

	static void y8DC()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4PG q4PG);
		q1J3 q1J;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		try
		{
			num = default(UIntPtr);
			num = num;
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				else
				{
					_ = (o1W)(object)Ns87.Default;
					_ = Ns87.Default;
				}
			}
			else
			{
				_ = (Xq90)(object)Ns87.Default;
			}
		}
		finally
		{
			try
			{
				_ = (Ty3)(object)Ns87.Default;
			}
			finally
			{
				try
				{
					g6EQ = null;
					g6EQ = null;
					q4PG = q4PG;
					q4PG = q4PG;
					_ = (Ty3)(object)Ns87.Default;
					_ = (Xq90)(object)Ns87.Default;
				}
				finally
				{
					q1J = null;
					q1J = null;
					goto IL_00ab;
				}
			}
		}
		IL_00ab:
		object obj2;
		checked
		{
			try
			{
				try
				{
					q4PG = q4PG;
				}
				finally
				{
					_ = (g6EQ)(object)Ns87.Default;
					goto end_IL_00ad;
				}
				end_IL_00ad:;
			}
			catch
			{
			}
			finally
			{
				if (num + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
				{
					_ = (Cy1)(object)Ns87.Default;
				}
				else
				{
					_ = (c7G)(object)Ns87.Default;
					_ = (Es6d)(object)Ns87.Default;
					_ = (Xj06)Ns87.Default;
					f1D8 f1D = f1D;
					f1D = f1D;
				}
				obj2 = null;
				goto IL_0122;
			}
		}
		IL_0122:
		_ = (a1HS)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
		try
		{
			es6d = es6d;
			es6d = es6d;
			sd = sd;
			sd = sd;
		}
		catch
		{
			do
			{
				_ = (o1W)(object)Ns87.Default;
			}
			while (obj2 != null);
		}
		if (num == 0)
		{
			while (true)
			{
				if (obj2 != null)
				{
					_ = (Sd5)(object)Ns87.Default;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		_ = (Cr17)(object)Ns87.Default;
		Cr17 cr = cr;
		cr = cr;
		_ = (Sd5)(object)Ns87.Default;
		_ = (Sa53)Ns87.Default;
		a1HS a1HS = null;
		a1HS = a1HS;
		nuint num2 = num;
		UIntPtr num3 = (UIntPtr)Ns87.Default;
		num = default(UIntPtr);
		checked
		{
			if (num2 - (unchecked((nuint)num3) + num) == 0)
			{
				do
				{
					try
					{
						_ = (g6EQ)(object)Ns87.Default;
					}
					catch
					{
						_ = Ns87.Default;
					}
				}
				while ((object)Ns87.Default != null);
				goto IL_024c;
			}
			try
			{
				do
				{
					_ = Ns87.Default;
					_ = (_003CModule_003E)(object)Ns87.Default;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					es6d = (Es6d)(object)Ns87.Default;
				}
				catch
				{
					g6EQ = g6EQ;
				}
				goto IL_024c;
			}
		}
		IL_024c:
		s5C s5C;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out o1W o1W);
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (k2GS)(object)Ns87.Default;
					f1D8 f1D = null;
					_ = (k2GS)(object)Ns87.Default;
					o1W = o1W;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			s5C = null;
			s5C = s5C;
			goto IL_02a0;
		}
		IL_02a0:
		_ = Ns87.Default;
		while (true)
		{
			if (obj2 != null)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		_ = Ns87.Default;
		_ = (c7G)(object)Ns87.Default;
		c7G c7G = (c7G)(object)Ns87.Default;
		c7G = c7G;
		_ = (f1D8)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		do
		{
			try
			{
				_ = (Xj06)Ns87.Default;
				sa = sa;
				sa = sa;
			}
			finally
			{
				k2GS = k2GS;
				k2GS = k2GS;
				continue;
			}
		}
		while (obj2 != null || obj2 != null);
		try
		{
			sd = null;
		}
		catch
		{
		}
		es6d = es6d;
		_ = (a1HS)(object)Ns87.Default;
		cr = cr;
		if (num == 0)
		{
			cr = cr;
			goto IL_03a0;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Xq90)(object)Ns87.Default;
			}
		}
		finally
		{
			goto IL_03a0;
		}
		IL_04aa:
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)Ns87.Default != null)
				{
					_ = (g6EQ)(object)Ns87.Default;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (g6EQ)(object)Ns87.Default;
					Xj06 xj = xj;
					xj = default(Xj06);
					q4PG = q4PG;
				}
				else
				{
					_ = (s5C)(object)Ns87.Default;
				}
			}
			finally
			{
				q1J = q1J;
				goto end_IL_04d2;
			}
			end_IL_04d2:;
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (c7G)(object)Ns87.Default;
				}
				else
				{
					s5C = s5C;
				}
			}
		}
		Ns87 ns = Ns87.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Sa53)Ns87.Default;
				}
				finally
				{
					o1W o1W = null;
					goto end_IL_0590;
				}
				end_IL_0590:;
			}
			catch
			{
				num = default(UIntPtr);
				if (num / checked(num - num + (num - unchecked((nuint)default(UIntPtr)))) == 0)
				{
					_ = (Sa53)Ns87.Default;
				}
			}
		}
		else
		{
			checked
			{
				try
				{
					if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						_ = (Es6d)(object)Ns87.Default;
					}
				}
				catch
				{
					while (obj2 != null)
					{
					}
				}
			}
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u && default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Sd5)(object)Ns87.Default;
			}
			while (obj2 != null);
		}
		do
		{
			IL_0683:
			if ((object)Ns87.Default != null)
			{
				try
				{
					_ = (Ea3q)(object)Ns87.Default;
					_ = (Cy1)(object)Ns87.Default;
					_ = (o1W)(object)Ns87.Default;
					_ = (f1D8)(object)Ns87.Default;
				}
				finally
				{
					g6EQ = null;
					goto IL_0683;
				}
			}
		}
		while (obj2 != null);
		_ = (q4PG)(object)Ns87.Default;
		sa = (Sa53)Ns87.Default;
		_ = (Cy1)(object)Ns87.Default;
		_ = (q1C3)(object)Ns87.Default;
		_ = (Ea3q)(object)Ns87.Default;
		ns = Ns87.Default;
		_ = (_003CModule_003E)(object)Ns87.Default;
		return;
		IL_043f:
		c7G = (c7G)(object)Ns87.Default;
		Ns87 obj10 = Ns87.Default;
		ns = ns;
		ns = obj10;
		while ((object)Ns87.Default != null)
		{
			while (obj2 != null)
			{
				_ = (f1D8)(object)Ns87.Default;
			}
		}
		try
		{
			do
			{
				sd = sd;
			}
			while (obj2 != null);
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (q1J3)(object)Ns87.Default;
			}
			goto IL_04aa;
		}
		IL_03a0:
		q1J = null;
		while ((object)Ns87.Default != null)
		{
			_ = (Cr17)(object)Ns87.Default;
		}
		if (num == 0)
		{
			try
			{
				_ = (Cy1)(object)Ns87.Default;
			}
			catch
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			goto IL_043f;
		}
		try
		{
			if (num == 0)
			{
				cr = cr;
				_ = (Ea3q)(object)Ns87.Default;
				_ = (a1HS)(object)Ns87.Default;
				_ = (Xq90)(object)Ns87.Default;
			}
			else
			{
				s5C = s5C;
			}
		}
		finally
		{
			_ = (a1HS)(object)Ns87.Default;
			_ = (k2GS)(object)Ns87.Default;
			_ = (q1J3)(object)Ns87.Default;
			goto IL_043f;
		}
	}
}
