using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ba50;
using Cd1t;
using Ci75;
using Es0;
using Microsoft.VisualBasic.CompilerServices;
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
using t5D;
using x9E1;

namespace Mn1k;

[DesignerGenerated]
public class Ng67 : Form
{
	internal delegate void Kc9();

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
			int[] int_ = c0B.int_0;
			int num = 3;
			while (true)
			{
				IL_0066:
				EventHandler eventHandler = c7X;
				Label label = _Label6;
				if (label == null)
				{
					num = 6;
					goto IL_0059;
				}
				num = 7;
				goto IL_0052;
				IL_0059:
				while (true)
				{
					IL_0059_2:
					_Label6 = value;
					while (true)
					{
						label = _Label6;
						if (label == null)
						{
							switch (int_[398])
							{
							case 31897:
								break;
							case 31901:
							case 31903:
								goto end_IL_0046;
							case 31896:
							case 31902:
								goto IL_0059_2;
							default:
								goto IL_0066;
							case 31900:
								goto IL_0081;
							case 31898:
								return;
							}
							continue;
						}
						num = 4;
						goto IL_0081;
						IL_0081:
						((Control)label).add_Click(eventHandler);
						return;
						continue;
						end_IL_0046:
						break;
					}
					break;
				}
				goto IL_0052;
				IL_0052:
				((Control)label).remove_Click(eventHandler);
				goto IL_0059;
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
			EventHandler eventHandler = n3S;
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
			EventHandler eventHandler = z6Q;
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
			int[] int_ = c0B.int_0;
			int num = 3;
			while (true)
			{
				EventHandler eventHandler = c0L;
				while (true)
				{
					Button val = _btnModify;
					if (val == null)
					{
						switch (int_[344])
						{
						case 48679:
							break;
						default:
							goto end_IL_0042;
						case 48686:
							goto IL_005f;
						case 48681:
							goto IL_0066;
						case 48680:
						case 48684:
							goto IL_0079;
						case 48683:
							return;
						}
						continue;
					}
					num = 7;
					goto IL_005f;
					IL_0066:
					_btnModify = value;
					val = _btnModify;
					if (val != null)
					{
						num = 5;
						goto IL_0079;
					}
					num = 4;
					return;
					IL_0079:
					((Control)val).add_Click(eventHandler);
					return;
					IL_005f:
					((Control)val).remove_Click(eventHandler);
					goto IL_0066;
					continue;
					end_IL_0042:
					break;
				}
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
			EventHandler eventHandler = Zw7;
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

	public Ng67()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Qe0);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Zi4();
	}

	[DebuggerNonUserCode]
	protected override void o5D8(bool t3D8)
	{
		try
		{
			c0B.int_0[504] = (c0B.int_0[504] | c0B.int_0[578]) & 0xAB;
			if (t3D8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t3D8);
		}
	}

	[DebuggerStepThrough]
	private void Zi4()
	{
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected O, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected O, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected O, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected O, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected O, but got Unknown
		char[] char_ = Ta8.char_0;
		int num = 2;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 40;
			while (true)
			{
				DateTimePicker1 = new DateTimePicker();
				Label9 = new Label();
				txtTransport = new TextBox();
				num = 17;
				while (true)
				{
					Label8 = new Label();
					Label5 = new Label();
					Label4 = new Label();
					num = 78;
					while (true)
					{
						Label1 = new Label();
						txtBNo = new TextBox();
						btnDelete = new Button();
						num = 20;
						while (true)
						{
							btnModify = new Button();
							txtDiscount = new TextBox();
							txtRDetail = new TextBox();
							num = 11;
							while (true)
							{
								txtCname = new TextBox();
								Label2 = new Label();
								btnSave = new Button();
								num = 83;
								while (true)
								{
									DataGridView1 = new DataGridView();
									Label10 = new Label();
									txtTotal = new TextBox();
									num = char_[210] - 30586;
									while (true)
									{
										switch (num)
										{
										case 88:
											((Control)Label8).set_ForeColor(Color.White);
											((Control)Label8).set_Location(new Point(166, 130));
											num = 30;
											goto case 30;
										case 30:
											((Control)Label8).set_Name("Label8");
											((Control)Label8).set_Size(new Size(55, 13));
											num = 66;
											goto case 66;
										case 66:
											((Control)Label8).set_TabIndex(76);
											Label8.set_Text("Discount :");
											num = 34;
											goto case 34;
										case 34:
										case 44:
											Label5.set_AutoSize(true);
											((Control)Label5).set_ForeColor(Color.White);
											num = 29;
											goto case 29;
										case 29:
											((Control)Label5).set_Location(new Point(156, 101));
											((Control)Label5).set_Name("Label5");
											num = 71;
											goto case 71;
										case 71:
											((Control)Label5).set_Size(new Size(65, 13));
											((Control)Label5).set_TabIndex(75);
											num = 86;
											goto case 86;
										case 86:
											Label5.set_Text("Raw Detail :");
											Label4.set_AutoSize(true);
											num = 67;
											goto case 67;
										case 67:
											((Control)Label4).set_ForeColor(Color.White);
											((Control)Label4).set_Location(new Point(427, 106));
											num = 59;
											goto case 59;
										case 59:
											((Control)Label4).set_Name("Label4");
											((Control)Label4).set_Size(new Size(88, 13));
											num = 23;
											goto case 23;
										case 23:
											((Control)Label4).set_TabIndex(74);
											Label4.set_Text("Customer Name :");
											num = 45;
											goto case 45;
										case 45:
											Label1.set_AutoSize(true);
											((Control)Label1).set_ForeColor(Color.White);
											num = 85;
											goto case 85;
										case 85:
											((Control)Label1).set_Location(new Point(450, 64));
											((Control)Label1).set_Name("Label1");
											num = 70;
											goto case 70;
										case 70:
											((Control)Label1).set_Size(new Size(66, 13));
											((Control)Label1).set_TabIndex(73);
											num = 8;
											goto case 8;
										case 8:
											Label1.set_Text("Billing Date :");
											((Control)txtBNo).set_Location(new Point(245, 64));
											num = 82;
											goto case 82;
										case 82:
											((Control)txtBNo).set_Name("txtBNo");
											((Control)txtBNo).set_Size(new Size(100, 20));
											num = 57;
											goto case 57;
										case 57:
											((Control)txtBNo).set_TabIndex(0);
											((Control)btnDelete).set_Location(new Point(496, 202));
											num = 27;
											goto case 27;
										case 27:
											((Control)btnDelete).set_Name("btnDelete");
											((Control)btnDelete).set_Size(new Size(75, 31));
											num = 19;
											goto case 19;
										case 19:
											((Control)btnDelete).set_TabIndex(9);
											((ButtonBase)btnDelete).set_Text("DELETE");
											num = 3;
											goto case 3;
										case 3:
											((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
											((Control)btnModify).set_Location(new Point(378, 202));
											num = 77;
											goto case 77;
										case 77:
											((Control)btnModify).set_Name("btnModify");
											((Control)btnModify).set_Size(new Size(75, 31));
											num = 9;
											goto case 9;
										case 9:
											((Control)btnModify).set_TabIndex(8);
											((ButtonBase)btnModify).set_Text("MODIFY");
											num = 33;
											goto case 33;
										case 33:
											((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
											((Control)txtDiscount).set_Location(new Point(243, 124));
											num = 35;
											goto case 35;
										case 35:
											((Control)txtDiscount).set_Name("txtDiscount");
											((Control)txtDiscount).set_Size(new Size(100, 20));
											num = 15;
											goto case 15;
										case 15:
											((Control)txtDiscount).set_TabIndex(2);
											((Control)txtRDetail).set_Location(new Point(243, 94));
											num = 13;
											goto case 13;
										case 13:
											((Control)txtRDetail).set_Name("txtRDetail");
											((Control)txtRDetail).set_Size(new Size(100, 20));
											num = 73;
											goto case 73;
										case 73:
											((Control)txtRDetail).set_TabIndex(1);
											((Control)txtCname).set_Location(new Point(537, 99));
											num = char_[84] - 38242;
											continue;
										case 80:
											((Control)Label9).set_Size(new Size(88, 13));
											((Control)Label9).set_TabIndex(78);
											num = 52;
											goto case 52;
										case 52:
											Label9.set_Text("Transport Detail :");
											((Control)txtTransport).set_Location(new Point(243, 159));
											num = 16;
											goto case 16;
										case 16:
											((Control)txtTransport).set_Name("txtTransport");
											((Control)txtTransport).set_Size(new Size(100, 20));
											num = 53;
											goto case 53;
										case 53:
											((Control)txtTransport).set_TabIndex(3);
											Label8.set_AutoSize(true);
											num = 88;
											goto case 88;
										case 79:
											Label6.set_AutoSize(true);
											((Control)Label6).set_BackColor(Color.Blue);
											num = 22;
											goto case 22;
										case 22:
											((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 24;
											goto case 24;
										case 24:
											((Control)Label6).set_ForeColor(Color.White);
											((Control)Label6).set_Location(new Point(734, 29));
											num = 48;
											goto case 48;
										case 48:
											((Control)Label6).set_Name("Label6");
											((Control)Label6).set_Size(new Size(18, 17));
											num = 41;
											goto case 41;
										case 41:
											((Control)Label6).set_TabIndex(11);
											Label6.set_Text("X");
											num = 26;
											goto case 26;
										case 26:
											Label7.set_AutoSize(true);
											((Control)Label7).set_BackColor(Color.Blue);
											num = 65;
											goto case 65;
										case 65:
											((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 1;
											goto case 1;
										case 1:
											((Control)Label7).set_ForeColor(Color.White);
											((Control)Label7).set_Location(new Point(42, 29));
											num = 69;
											goto case 69;
										case 69:
											((Control)Label7).set_Name("Label7");
											((Control)Label7).set_Size(new Size(92, 17));
											num = 76;
											goto case 76;
										case 76:
											((Control)Label7).set_TabIndex(10);
											Label7.set_Text("Go To Main");
											num = 32;
											goto case 32;
										case 32:
											((Control)DateTimePicker1).set_Location(new Point(537, 64));
											((Control)DateTimePicker1).set_Name("DateTimePicker1");
											num = 36;
											goto case 36;
										case 36:
											((Control)DateTimePicker1).set_Size(new Size(126, 20));
											((Control)DateTimePicker1).set_TabIndex(4);
											num = 0;
											goto case 0;
										case 0:
											Label9.set_AutoSize(true);
											((Control)Label9).set_ForeColor(Color.White);
											num = 58;
											goto case 58;
										case 58:
											((Control)Label9).set_Location(new Point(132, 162));
											((Control)Label9).set_Name("Label9");
											num = 80;
											goto case 80;
										case 47:
											((Control)Label3).set_TabIndex(7);
											Label3.set_Text("Billing");
											num = 79;
											goto case 79;
										case 37:
											((ISupportInitialize)DataGridView1).BeginInit();
											((Control)this).SuspendLayout();
											Label3.set_AutoSize(true);
											num = 4;
											goto case 4;
										case 4:
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 5;
											goto case 5;
										case 5:
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(363, 29));
											num = 18;
											goto case 18;
										case 18:
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(52, 17));
											num = 47;
											goto case 47;
										case 83:
											break;
										case 11:
											goto end_IL_08a6;
										case 20:
											goto end_IL_08da;
										case 78:
											goto end_IL_0900;
										case 17:
											goto end_IL_0926;
										case 40:
											goto end_IL_094c;
										default:
											goto end_IL_0972;
										case 74:
											((Control)txtCname).set_Name("txtCname");
											((Control)txtCname).set_Size(new Size(100, 20));
											num = 51;
											goto case 51;
										case 51:
											((Control)txtCname).set_TabIndex(5);
											Label2.set_AutoSize(true);
											num = 72;
											goto case 72;
										case 72:
											((Control)Label2).set_ForeColor(Color.White);
											((Control)Label2).set_Location(new Point(167, 67));
											num = 6;
											goto case 6;
										case 6:
											((Control)Label2).set_Name("Label2");
											((Control)Label2).set_Size(new Size(57, 13));
											num = 54;
											goto case 54;
										case 54:
											((Control)Label2).set_TabIndex(72);
											Label2.set_Text("Billing No :");
											num = 75;
											goto case 75;
										case 75:
											((Control)btnSave).set_Location(new Point(249, 202));
											((Control)btnSave).set_Name("btnSave");
											num = 87;
											goto case 87;
										case 87:
											((Control)btnSave).set_Size(new Size(75, 31));
											((Control)btnSave).set_TabIndex(7);
											goto case 63;
										case 63:
											num = 89;
											goto case 89;
										case 89:
											((ButtonBase)btnSave).set_Text("SAVE");
											((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
											num = 49;
											goto case 49;
										case 49:
											DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
											((Control)DataGridView1).set_Location(new Point(45, 239));
											num = 50;
											goto case 50;
										case 50:
											((Control)DataGridView1).set_Name("DataGridView1");
											((Control)DataGridView1).set_Size(new Size(724, 199));
											num = 56;
											goto case 56;
										case 56:
											((Control)DataGridView1).set_TabIndex(12);
											Label10.set_AutoSize(true);
											num = 43;
											goto case 43;
										case 43:
											((Control)Label10).set_ForeColor(Color.White);
											((Control)Label10).set_Location(new Point(478, 139));
											num = 21;
											goto case 21;
										case 21:
											((Control)Label10).set_Name("Label10");
											((Control)Label10).set_Size(new Size(37, 13));
											num = 7;
											goto case 7;
										case 7:
											((Control)Label10).set_TabIndex(81);
											Label10.set_Text("Total :");
											num = 81;
											goto case 81;
										case 81:
											((Control)txtTotal).set_Location(new Point(537, 136));
											((Control)txtTotal).set_Name("txtTotal");
											num = 68;
											goto case 68;
										case 68:
											((Control)txtTotal).set_Size(new Size(100, 20));
											((Control)txtTotal).set_TabIndex(6);
											num = 28;
											goto case 28;
										case 28:
											((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
											((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
											num = 10;
											goto case 10;
										case 10:
											((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
											((Form)this).set_ClientSize(new Size(800, 450));
											num = 25;
											goto case 25;
										case 25:
											((Control)this).get_Controls().Add((Control)(object)txtTotal);
											((Control)this).get_Controls().Add((Control)(object)Label10);
											num = 46;
											goto case 46;
										case 46:
											((Control)this).get_Controls().Add((Control)(object)DataGridView1);
											((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
											num = 90;
											goto case 90;
										case 90:
											((Control)this).get_Controls().Add((Control)(object)Label9);
											((Control)this).get_Controls().Add((Control)(object)txtTransport);
											num = 12;
											goto case 12;
										case 12:
											((Control)this).get_Controls().Add((Control)(object)Label8);
											((Control)this).get_Controls().Add((Control)(object)Label5);
											num = 84;
											goto case 84;
										case 84:
											((Control)this).get_Controls().Add((Control)(object)Label4);
											((Control)this).get_Controls().Add((Control)(object)Label1);
											num = 39;
											goto case 39;
										case 39:
											((Control)this).get_Controls().Add((Control)(object)txtBNo);
											((Control)this).get_Controls().Add((Control)(object)btnDelete);
											num = 60;
											goto case 60;
										case 60:
											((Control)this).get_Controls().Add((Control)(object)btnModify);
											((Control)this).get_Controls().Add((Control)(object)txtDiscount);
											num = 31;
											goto case 31;
										case 31:
											((Control)this).get_Controls().Add((Control)(object)txtRDetail);
											goto case 14;
										case 14:
											((Control)this).get_Controls().Add((Control)(object)txtCname);
											num = 42;
											goto case 42;
										case 42:
											((Control)this).get_Controls().Add((Control)(object)Label2);
											((Control)this).get_Controls().Add((Control)(object)btnSave);
											num = 38;
											goto case 38;
										case 38:
											((Control)this).get_Controls().Add((Control)(object)Label6);
											((Control)this).get_Controls().Add((Control)(object)Label7);
											num = 62;
											goto case 62;
										case 62:
											((Control)this).get_Controls().Add((Control)(object)Label3);
											((Form)this).set_FormBorderStyle((FormBorderStyle)0);
											num = 64;
											goto case 64;
										case 64:
											((Control)this).set_Name("frmBilling");
											((Form)this).set_StartPosition((FormStartPosition)1);
											((Form)this).set_Text("frmBilling");
											num = 61;
											goto case 61;
										case 61:
											((ISupportInitialize)DataGridView1).EndInit();
											((Control)this).ResumeLayout(false);
											((Control)this).PerformLayout();
											num = 55;
											return;
										case 55:
											return;
										}
										break;
									}
									continue;
									end_IL_08a6:
									break;
								}
								continue;
								end_IL_08da:
								break;
							}
							continue;
							end_IL_0900:
							break;
						}
						continue;
						end_IL_0926:
						break;
					}
					continue;
					end_IL_094c:
					break;
				}
				continue;
				end_IL_0972:
				break;
			}
		}
	}

	private void n3S(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void c7X(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Qe0(object sender, EventArgs e)
	{
		Am8();
	}

	private void Zw7(object sender, EventArgs e)
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
		Am8();
		c0B.int_0[154] = (c0B.int_0[154] ^ c0B.int_0[34]) & 0x20;
	}

	public void Am8()
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

	private void c0L(object sender, EventArgs e)
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
		Am8();
	}

	private void z6Q(object sender, EventArgs e)
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
		Am8();
	}

	[STAThread]
	public static void Ri9()
	{
		try
		{
			int hc;
			do
			{
				hc = 2;
			}
			while (!t1P.Pp0() || !Ws0.w1J(hc));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = o8W.Bf7(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = o8W.Bf7(Listt, 1, 1);
			mName = o8W.Bf7(Listt, 2, 2);
			mArray = o8W.Bf7(Listt, 3, 3);
			sArray = o8W.Bf7(Listt, 4, 4);
			T = o8W.Bf7(Listt, 5, 5);
			sNum = o8W.Bf7(Listt, 6, 6);
			c0B.int_0[567] = (c0B.int_0[567] - c0B.int_0[29]) & 0xFD;
			mDic.Add(sNum, 98);
			byte[] value = Ws0.Yp5(98, 15);
			mDic.Add(sArray, value);
			Ma6.Hx2();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void Jo1()
	{
		UIntPtr num;
		checked
		{
			num = unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)default(UIntPtr));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		Tg0e tg0e;
		if (num == 0)
		{
			while (true)
			{
				obj = obj;
				if (obj != null)
				{
					if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
					{
						tg0e = (Tg0e)(object)j5Y1.Default;
						tg0e = null;
						_ = (Cd0n)(object)j5Y1.Default;
					}
					continue;
				}
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta8 ta);
		n4NE n4NE;
		while ((object)j5Y1.Default != null)
		{
			if (num == 0)
			{
				Ws0 obj2 = (Ws0)(object)j5Y1.Default;
				ws = (Ws0)(object)j5Y1.Default;
				ws = obj2;
				ta = ta;
				ta = null;
				_ = (Cd0n)(object)j5Y1.Default;
				n4NE = null;
				n4NE = n4NE;
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				nuint num2 = num / (nuint)(UIntPtr)j5Y1.Default;
				nuint num3 = num;
				num = default(UIntPtr);
				checked
				{
					if (num2 + unchecked(num3 / num) == 0)
					{
						_ = (Ng67)(object)j5Y1.Default;
						_ = (k8NS)j5Y1.Default;
						ws = ws;
					}
				}
			}
			while ((object)j5Y1.Default != null);
		}
		else if (num == 0)
		{
			while (obj != null)
			{
				_ = j5Y1.Default;
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				catch
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
		}
		catch
		{
			do
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
			while (obj != null || (object)j5Y1.Default != null);
		}
		try
		{
			while (obj != null)
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
		}
		catch
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (w5D)(object)j5Y1.Default;
			}
		}
		tg0e = (Tg0e)(object)j5Y1.Default;
		num = default(UIntPtr);
		if (num / (nuint)(UIntPtr)j5Y1.Default == 0)
		{
			try
			{
			}
			finally
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				goto IL_01ee;
			}
		}
		goto IL_01ee;
		IL_05f8:
		j5Y1 j5Y = j5Y;
		j5Y = j5Y;
		return;
		IL_0476:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		do
		{
			try
			{
				try
				{
					ng = ng;
				}
				finally
				{
					k8NS = (k8NS)j5Y1.Default;
					goto end_IL_0476;
				}
				end_IL_0476:;
			}
			catch
			{
				n4NE = null;
				ma = ma;
				ma = null;
				_ = j5Y1.Default;
			}
		}
		while (obj != null);
		_ = (Be5)(object)j5Y1.Default;
		b2H1 b2H = (b2H1)j5Y1.Default;
		_ = (y9T)(object)j5Y1.Default;
		Gw13 gw = null;
		_ = (z1J)(object)j5Y1.Default;
		while (obj != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				b2H = default(b2H1);
				continue;
			}
			b2H = b2H;
			_ = (_003CModule_003E)(object)j5Y1.Default;
			_ = (Be5)(object)j5Y1.Default;
			_ = (c0B)(object)j5Y1.Default;
		}
		_ = (Br2)(object)j5Y1.Default;
		try
		{
			_ = (t1P)(object)j5Y1.Default;
			_ = (b2H1)j5Y1.Default;
		}
		finally
		{
			goto IL_0560;
		}
		IL_0306:
		try
		{
			try
			{
				ng = (Ng67)(object)j5Y1.Default;
			}
			finally
			{
				try
				{
				}
				finally
				{
					_ = (z1J)(object)j5Y1.Default;
					goto end_IL_0307;
				}
			}
			end_IL_0307:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				while (obj != null);
			}
		}
		k8NS = k8NS;
		k8NS = k8NS;
		b2H = b2H;
		b2H = b2H;
		tg0e = tg0e;
		try
		{
			_ = (Ta8)(object)j5Y1.Default;
			_ = (z1J)(object)j5Y1.Default;
			_ = (Be5)(object)j5Y1.Default;
			_ = j5Y1.Default;
		}
		finally
		{
			while ((object)j5Y1.Default != null)
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
			goto IL_03d9;
		}
		IL_02ad:
		checked
		{
			do
			{
				if (unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					while ((object)j5Y1.Default != null)
					{
						_ = (_003CModule_003E)(object)j5Y1.Default;
					}
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				Cd0n cd0n = cd0n;
				cd0n = cd0n;
			}
			finally
			{
				try
				{
					_ = (z1J)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
				goto IL_0306;
			}
		}
		goto IL_0306;
		IL_0560:
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				finally
				{
					w5D w5D = null;
					goto end_IL_0561;
				}
			}
			end_IL_0561:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					ma = ma;
				}
				else
				{
					b2H = (b2H1)j5Y1.Default;
				}
			}
			goto IL_05bd;
		}
		IL_01ee:
		do
		{
			_ = (Gw13)(object)j5Y1.Default;
		}
		while (obj != null);
		try
		{
			try
			{
				y9T y9T = null;
				y9T = y9T;
			}
			catch
			{
				if (num == 0)
				{
					gw = gw;
					gw = gw;
				}
			}
		}
		catch
		{
			ta = (Ta8)(object)j5Y1.Default;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			ng = ng;
			ng = null;
			goto IL_02ad;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
			while (obj != null)
			{
				w5D = w5D;
				w5D = w5D;
			}
		}
		finally
		{
			do
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
			while ((object)j5Y1.Default != null);
			goto IL_02ad;
		}
		IL_05bd:
		n4NE = null;
		try
		{
			_ = (Be5)(object)j5Y1.Default;
		}
		finally
		{
			while ((object)j5Y1.Default != null)
			{
				try
				{
					ws = ws;
				}
				finally
				{
					_ = (Ma6)(object)j5Y1.Default;
					continue;
				}
			}
			goto IL_05f8;
		}
		IL_03d9:
		while (obj != null)
		{
			_ = (k8NS)j5Y1.Default;
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (Br2)(object)j5Y1.Default;
				}
			}
			catch
			{
				_ = (Ma6)(object)j5Y1.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Be5)(object)j5Y1.Default;
			}
			finally
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
				goto end_IL_0406;
			}
			end_IL_0406:;
		}
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
				while (obj != null)
				{
					o8W = o8W;
					o8W = null;
				}
			}
			finally
			{
				_ = (y9T)(object)j5Y1.Default;
				goto end_IL_0424;
			}
			end_IL_0424:;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				w5D w5D = null;
			}
			else
			{
				do
				{
					_ = (w5D)(object)j5Y1.Default;
				}
				while (obj != null);
			}
			goto IL_0476;
		}
	}

	static void r4Y()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = (k8NS)j5Y1.Default;
			obj = obj;
		}
		while (obj != null);
		_ = (Ng67)(object)j5Y1.Default;
		nuint uIntPtr = default(UIntPtr);
		UIntPtr num = (UIntPtr)j5Y1.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta8 ta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * unchecked(checked(unchecked((nuint)num) + uIntPtr) / (nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				try
				{
					do
					{
						b2H1 obj2 = (b2H1)j5Y1.Default;
						b2H = b2H;
						b2H = obj2;
						ta = (Ta8)(object)j5Y1.Default;
						ta = null;
					}
					while ((object)j5Y1.Default != null);
				}
				catch
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
			}
			else
			{
				_ = (z1J)(object)j5Y1.Default;
			}
		}
		if (uIntPtr != 0 || uIntPtr != 0 || (UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE);
		try
		{
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				n4NE = null;
				n4NE = null;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
			}
			while (obj != null);
		}
		do
		{
			_ = (w5D)(object)j5Y1.Default;
		}
		while (obj != null);
		z1J z1J = z1J;
		z1J = z1J;
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj != null)
			{
				_003CModule_003E obj5 = (_003CModule_003E)(object)j5Y1.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj5;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while ((object)j5Y1.Default != null)
			{
				_ = (Ws0)(object)j5Y1.Default;
			}
		}
		else
		{
			_ = (t1P)(object)j5Y1.Default;
		}
		if ((nuint)(UIntPtr)j5Y1.Default / unchecked((nuint)default(UIntPtr)) == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (n4NE)(object)j5Y1.Default;
			Ma6 ma = null;
			ma = ma;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while ((object)j5Y1.Default != null)
			{
				try
				{
					b2H = (b2H1)j5Y1.Default;
				}
				finally
				{
					ta = ta;
					continue;
				}
			}
		}
		t1P t1P;
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)j5Y1.Default) * uIntPtr == 0)
				{
					while (obj != null)
					{
						_ = (o8W)(object)j5Y1.Default;
					}
				}
			}
			finally
			{
				t1P = null;
				t1P = null;
				goto IL_026b;
			}
		}
		IL_0465:
		k8NS k8NS = (k8NS)j5Y1.Default;
		k8NS = default(k8NS);
		do
		{
			_ = (o8W)(object)j5Y1.Default;
		}
		while ((object)j5Y1.Default != null);
		c0B c0B;
		Gw13 gw;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			c0B = c0B;
		}
		else
		{
			if (checked(uIntPtr * uIntPtr) != 0)
			{
				try
				{
					ng = ng;
				}
				finally
				{
					gw = gw;
					n4NE = n4NE;
					goto IL_04ef;
				}
			}
			while (obj != null)
			{
				_ = (Ws0)(object)j5Y1.Default;
			}
		}
		goto IL_04ef;
		IL_026b:
		if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
		{
		}
		c0B = null;
		c0B = null;
		Be5 be = be;
		be = be;
		Ng67 obj6 = (Ng67)(object)j5Y1.Default;
		ng = ng;
		ng = obj6;
		gw = null;
		gw = gw;
		_ = j5Y1.Default;
		t1P = t1P;
		_ = (Be5)(object)j5Y1.Default;
		gw = null;
		_ = (n4NE)(object)j5Y1.Default;
		ta = ta;
		ng = (Ng67)(object)j5Y1.Default;
		try
		{
			_ = (Cd0n)(object)j5Y1.Default;
			_ = (z1J)(object)j5Y1.Default;
			_ = (Cd0n)(object)j5Y1.Default;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				y9T y9T = y9T;
				y9T = y9T;
			}
			else
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
		}
		do
		{
			if (uIntPtr == 0)
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
		}
		while (obj != null);
		_ = (_003CModule_003E)(object)j5Y1.Default;
		try
		{
			try
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
			catch
			{
				b2H = (b2H1)j5Y1.Default;
			}
			finally
			{
				try
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				finally
				{
					z1J = null;
					goto end_IL_0369;
				}
			}
			end_IL_0369:;
		}
		catch
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					n4NE = n4NE;
				}
				else
				{
					_ = j5Y1.Default;
				}
			}
		}
		ng = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (_003CModule_003E)(object)j5Y1.Default;
			_ = j5Y1.Default;
			be = (Be5)(object)j5Y1.Default;
			_ = (c0B)(object)j5Y1.Default;
			goto IL_0465;
		}
		try
		{
			do
			{
				_ = (Ws0)(object)j5Y1.Default;
			}
			while ((object)j5Y1.Default != null);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
			do
			{
				_ = (Ja24)(object)j5Y1.Default;
				j5Y = j5Y;
				j5Y = null;
				_ = (Ma6)(object)j5Y1.Default;
			}
			while (obj != null);
			goto IL_0465;
		}
		IL_04ef:
		_ = (w5D)(object)j5Y1.Default;
		_ = (t1P)(object)j5Y1.Default;
		b2H = b2H;
		t1P = (t1P)(object)j5Y1.Default;
		_ = (Cd0n)(object)j5Y1.Default;
	}
}
