using System;
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
using Mn1k;
using Ri5n;
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
using t5D;
using x9E1;

namespace s1Y;

[DesignerGenerated]
public class w5D : Form
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
			EventHandler eventHandler = n1W;
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
			EventHandler eventHandler = Xy7;
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
			EventHandler eventHandler = Kb2;
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
			EventHandler eventHandler = b2F;
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
				Ta8.char_0[118] = (char)((Ta8.char_0[118] * c0B.int_0[456]) & ' ');
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
			EventHandler eventHandler = Qn3;
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

	public w5D()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Bn4);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		e3B();
	}

	[DebuggerNonUserCode]
	protected override void d9X(bool d7Q)
	{
		try
		{
			if (d7Q && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d7Q);
		}
	}

	[DebuggerStepThrough]
	private void e3B()
	{
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected O, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected O, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		int[] int_ = c0B.int_0;
		char[] char_ = Ta8.char_0;
		int num = 18;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 78;
			while (true)
			{
				txtWeight = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 73;
				while (true)
				{
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					Label5 = new Label();
					num = int_[215] - 20314;
					while (true)
					{
						switch (num)
						{
						case 82:
							Label10.set_Text("Weight :");
							DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
							num = 9;
							goto case 9;
						case 9:
							((Control)DataGridView1).set_Location(new Point(45, 239));
							((Control)DataGridView1).set_Name("DataGridView1");
							num = 16;
							goto case 16;
						case 16:
							((Control)DataGridView1).set_Size(new Size(724, 199));
							((Control)DataGridView1).set_TabIndex(11);
							num = 56;
							goto case 56;
						case 56:
							((Control)DateTimePicker1).set_Location(new Point(537, 64));
							((Control)DateTimePicker1).set_Name("DateTimePicker1");
							num = 15;
							goto case 15;
						case 15:
							((Control)DateTimePicker1).set_Size(new Size(126, 20));
							((Control)DateTimePicker1).set_TabIndex(3);
							num = 5;
							goto case 5;
						case 5:
							Label8.set_AutoSize(true);
							((Control)Label8).set_ForeColor(Color.White);
							num = 68;
							goto case 68;
						case 68:
							((Control)Label8).set_Location(new Point(166, 130));
							((Control)Label8).set_Name("Label8");
							num = 48;
							goto case 48;
						case 48:
							((Control)Label8).set_Size(new Size(55, 13));
							((Control)Label8).set_TabIndex(94);
							num = 13;
							goto case 13;
						case 13:
							Label8.set_Text("Category :");
							Label5.set_AutoSize(true);
							num = 59;
							goto case 59;
						case 59:
							((Control)Label5).set_ForeColor(Color.White);
							((Control)Label5).set_Location(new Point(156, 101));
							num = 28;
							goto case 28;
						case 28:
							((Control)Label5).set_Name("Label5");
							((Control)Label5).set_Size(new Size(66, 13));
							num = 47;
							goto case 47;
						case 47:
							((Control)Label5).set_TabIndex(93);
							Label5.set_Text("Raw Name :");
							num = 3;
							goto case 3;
						case 3:
							Label4.set_AutoSize(true);
							((Control)Label4).set_ForeColor(Color.White);
							num = 60;
							goto case 60;
						case 60:
							((Control)Label4).set_Location(new Point(466, 106));
							((Control)Label4).set_Name("Label4");
							num = 29;
							goto case 29;
						case 29:
							((Control)Label4).set_Size(new Size(49, 13));
							((Control)Label4).set_TabIndex(92);
							num = 22;
							goto case 22;
						case 22:
							Label4.set_Text("Amount :");
							Label1.set_AutoSize(true);
							num = 70;
							goto case 27;
						case 27:
						case 70:
							((Control)Label1).set_ForeColor(Color.White);
							((Control)Label1).set_Location(new Point(431, 67));
							num = 4;
							goto case 4;
						case 4:
							((Control)Label1).set_Name("Label1");
							((Control)Label1).set_Size(new Size(84, 13));
							goto case 71;
						case 71:
							num = 61;
							goto case 31;
						case 31:
						case 61:
							((Control)Label1).set_TabIndex(91);
							Label1.set_Text("Purchase Date :");
							num = 25;
							goto case 25;
						case 25:
							((Control)txtRcode).set_Location(new Point(245, 64));
							((Control)txtRcode).set_Name("txtRcode");
							num = 46;
							goto case 46;
						case 46:
							((Control)txtRcode).set_Size(new Size(100, 20));
							((Control)txtRcode).set_TabIndex(0);
							num = 14;
							goto case 14;
						case 14:
							((Control)btnDelete).set_Location(new Point(496, 202));
							((Control)btnDelete).set_Name("btnDelete");
							num = 41;
							goto case 41;
						case 41:
							((Control)btnDelete).set_Size(new Size(75, 31));
							((Control)btnDelete).set_TabIndex(8);
							num = 66;
							goto case 66;
						case 66:
							((ButtonBase)btnDelete).set_Text("DELETE");
							((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
							num = 38;
							goto case 38;
						case 38:
							((Control)btnModify).set_Location(new Point(378, 202));
							((Control)btnModify).set_Name("btnModify");
							num = 36;
							goto case 36;
						case 36:
							((Control)btnModify).set_Size(new Size(75, 31));
							((Control)btnModify).set_TabIndex(7);
							num = char_[243] - 1866;
							continue;
						case 80:
							((Control)txtWeight).set_Size(new Size(100, 20));
							((Control)txtWeight).set_TabIndex(5);
							num = 45;
							goto case 45;
						case 45:
							Label10.set_AutoSize(true);
							((Control)Label10).set_ForeColor(Color.White);
							num = 20;
							goto case 20;
						case 20:
							((Control)Label10).set_Location(new Point(478, 139));
							((Control)Label10).set_Name("Label10");
							num = 37;
							goto case 37;
						case 37:
							((Control)Label10).set_Size(new Size(47, 13));
							((Control)Label10).set_TabIndex(99);
							num = 82;
							goto case 82;
						case 64:
							((Control)Label6).set_Name("Label6");
							((Control)Label6).set_Size(new Size(18, 17));
							num = 17;
							goto case 17;
						case 17:
							((Control)Label6).set_TabIndex(10);
							Label6.set_Text("X");
							num = 51;
							goto case 51;
						case 51:
							Label7.set_AutoSize(true);
							((Control)Label7).set_BackColor(Color.Blue);
							num = char_[84] - 38263;
							continue;
						case 62:
							((Control)Label3).set_TabIndex(9);
							Label3.set_Text("Purchase Detail");
							num = 42;
							goto case 42;
						case 42:
							Label6.set_AutoSize(true);
							((Control)Label6).set_BackColor(Color.Blue);
							num = 12;
							goto case 12;
						case 12:
							((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
							num = 11;
							goto case 11;
						case 11:
							((Control)Label6).set_ForeColor(Color.White);
							((Control)Label6).set_Location(new Point(734, 21));
							num = 64;
							goto case 64;
						case 55:
							Label4 = new Label();
							Label1 = new Label();
							txtRcode = new TextBox();
							num = 8;
							goto case 8;
						case 8:
							btnDelete = new Button();
							btnModify = new Button();
							txtCategory = new TextBox();
							num = 32;
							goto case 32;
						case 32:
							txtRName = new TextBox();
							txtAmount = new TextBox();
							Label2 = new Label();
							num = 44;
							goto case 44;
						case 44:
							btnSave = new Button();
							((ISupportInitialize)DataGridView1).BeginInit();
							((Control)this).SuspendLayout();
							num = 54;
							goto case 54;
						case 54:
							Label3.set_AutoSize(true);
							((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
							num = 21;
							goto case 21;
						case 21:
							((Control)Label3).set_ForeColor(Color.White);
							((Control)Label3).set_Location(new Point(320, 21));
							num = 19;
							goto case 19;
						case 19:
							((Control)Label3).set_Name("Label3");
							((Control)Label3).set_Size(new Size(123, 17));
							num = 62;
							goto case 62;
						case 53:
							((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
							num = 24;
							goto case 24;
						case 24:
							((Control)Label7).set_ForeColor(Color.White);
							((Control)Label7).set_Location(new Point(42, 21));
							num = 26;
							goto case 26;
						case 26:
							((Control)Label7).set_Name("Label7");
							((Control)Label7).set_Size(new Size(92, 17));
							num = 34;
							goto case 34;
						case 34:
							((Control)Label7).set_TabIndex(9);
							Label7.set_Text("Go To Main");
							num = 40;
							goto case 40;
						case 40:
							((Control)txtWeight).set_Location(new Point(537, 136));
							((Control)txtWeight).set_Name("txtWeight");
							num = 80;
							goto case 80;
						case 43:
							((Control)txtCategory).set_Location(new Point(243, 124));
							((Control)txtCategory).set_Name("txtCategory");
							num = 0;
							goto case 0;
						case 0:
							((Control)txtCategory).set_Size(new Size(100, 20));
							((Control)txtCategory).set_TabIndex(2);
							num = char_[305] - 9656;
							continue;
						case 10:
							((ButtonBase)btnModify).set_Text("MODIFY");
							((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
							num = 43;
							goto case 43;
						case 73:
							break;
						case 78:
							goto end_IL_091d;
						default:
							goto end_IL_0951;
						case 1:
							((Control)txtRName).set_Location(new Point(243, 94));
							((Control)txtRName).set_Name("txtRName");
							num = 74;
							goto case 74;
						case 74:
							((Control)txtRName).set_Size(new Size(100, 20));
							((Control)txtRName).set_TabIndex(1);
							num = 65;
							goto case 65;
						case 65:
							((Control)txtAmount).set_Location(new Point(537, 99));
							((Control)txtAmount).set_Name("txtAmount");
							num = 79;
							goto case 79;
						case 79:
							((Control)txtAmount).set_Size(new Size(100, 20));
							((Control)txtAmount).set_TabIndex(4);
							num = 49;
							goto case 49;
						case 49:
							Label2.set_AutoSize(true);
							((Control)Label2).set_ForeColor(Color.White);
							num = 58;
							goto case 58;
						case 58:
							((Control)Label2).set_Location(new Point(167, 67));
							((Control)Label2).set_Name("Label2");
							num = 72;
							goto case 72;
						case 72:
							((Control)Label2).set_Size(new Size(63, 13));
							((Control)Label2).set_TabIndex(90);
							num = 35;
							goto case 35;
						case 35:
							Label2.set_Text("Row Code :");
							((Control)btnSave).set_Location(new Point(249, 202));
							num = 30;
							goto case 30;
						case 30:
							((Control)btnSave).set_Name("btnSave");
							((Control)btnSave).set_Size(new Size(75, 31));
							num = 81;
							goto case 81;
						case 81:
							((Control)btnSave).set_TabIndex(6);
							((ButtonBase)btnSave).set_Text("SAVE");
							num = 7;
							goto case 7;
						case 7:
							((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
							((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
							num = 75;
							goto case 75;
						case 75:
							((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
							((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
							num = 63;
							goto case 63;
						case 63:
							((Form)this).set_ClientSize(new Size(800, 450));
							((Control)this).get_Controls().Add((Control)(object)txtWeight);
							num = 6;
							goto case 6;
						case 6:
							((Control)this).get_Controls().Add((Control)(object)Label10);
							((Control)this).get_Controls().Add((Control)(object)DataGridView1);
							num = 33;
							goto case 33;
						case 33:
							((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
							((Control)this).get_Controls().Add((Control)(object)Label8);
							num = 2;
							goto case 2;
						case 2:
							((Control)this).get_Controls().Add((Control)(object)Label5);
							((Control)this).get_Controls().Add((Control)(object)Label4);
							num = 76;
							goto case 76;
						case 76:
							((Control)this).get_Controls().Add((Control)(object)Label1);
							((Control)this).get_Controls().Add((Control)(object)txtRcode);
							num = 69;
							goto case 69;
						case 69:
							((Control)this).get_Controls().Add((Control)(object)btnDelete);
							((Control)this).get_Controls().Add((Control)(object)btnModify);
							num = 67;
							goto case 67;
						case 67:
							((Control)this).get_Controls().Add((Control)(object)txtCategory);
							((Control)this).get_Controls().Add((Control)(object)txtRName);
							num = 23;
							goto case 23;
						case 23:
							((Control)this).get_Controls().Add((Control)(object)txtAmount);
							((Control)this).get_Controls().Add((Control)(object)Label2);
							num = 77;
							goto case 77;
						case 77:
							((Control)this).get_Controls().Add((Control)(object)btnSave);
							((Control)this).get_Controls().Add((Control)(object)Label6);
							num = 52;
							goto case 52;
						case 52:
							((Control)this).get_Controls().Add((Control)(object)Label7);
							((Control)this).get_Controls().Add((Control)(object)Label3);
							num = 50;
							goto case 50;
						case 50:
							((Form)this).set_FormBorderStyle((FormBorderStyle)0);
							((Control)this).set_Name("frmPurchaseDetail");
							((Form)this).set_StartPosition((FormStartPosition)1);
							num = 57;
							goto case 57;
						case 57:
							((Form)this).set_Text("frmPurchaseDetail");
							((ISupportInitialize)DataGridView1).EndInit();
							((Control)this).ResumeLayout(false);
							num = 39;
							goto case 39;
						case 39:
							((Control)this).PerformLayout();
							return;
						}
						break;
					}
					continue;
					end_IL_091d:
					break;
				}
				continue;
				end_IL_0951:
				break;
			}
		}
	}

	private void Xy7(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void n1W(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Bn4(object sender, EventArgs e)
	{
		g4N();
	}

	private void Qn3(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_purchase_detail values(" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())) + ",'" + txtRName.get_Text() + "','" + txtCategory.get_Text() + "','" + DateTimePicker1.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", " + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " )");
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
		g4N();
		Ta8.char_0[104] = (char)(Ta8.char_0[104] & Ta8.char_0[74] & '\u0095');
	}

	public void g4N()
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

	internal static byte[] x4T(int Hp7)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return y9T.Pn2(z1J.k5F(), Hp7);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void b2F(object sender, EventArgs e)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		int[] int_ = c0B.int_0;
		try
		{
			int num = 4;
			while (true)
			{
				cn.Open();
				cmd.set_Connection(cn);
				switch (int_[67])
				{
				default:
					continue;
				case 62337:
				case 62339:
					cmd.set_CommandText("update tbl_purchase_detail set rowname ='" + txtRName.get_Text() + "',category='" + txtCategory.get_Text() + "',purdate='" + DateTimePicker1.get_Text() + "',amount=" + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", weight=" + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
					num = 5;
					goto case 62338;
				case 62338:
				case 62342:
					cmd.ExecuteReader();
					break;
				case 62343:
					break;
				}
				break;
			}
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
		g4N();
	}

	private void Kb2(object sender, EventArgs e)
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
		g4N();
	}

	static void r5B()
	{
		_ = (z1J)(object)j5Y1.Default;
		try
		{
			_ = (o8W)(object)j5Y1.Default;
		}
		catch
		{
			_ = (Be5)(object)j5Y1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				ng = ng;
				ng = null;
			}
			catch
			{
				while (true)
				{
					obj2 = obj2;
					if (obj2 != null)
					{
						_ = (b2H1)j5Y1.Default;
						t1P = t1P;
						Be5 be = (Be5)(object)j5Y1.Default;
						be = be;
						continue;
					}
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tg0e tg0e);
		while (obj2 != null)
		{
			try
			{
				try
				{
					_ = (Be5)(object)j5Y1.Default;
				}
				catch
				{
					_ = j5Y1.Default;
				}
			}
			catch
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					tg0e = (Tg0e)(object)j5Y1.Default;
					tg0e = tg0e;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		nuint uIntPtr;
		try
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					Cd0n obj6 = (Cd0n)(object)j5Y1.Default;
					cd0n = (Cd0n)(object)j5Y1.Default;
					cd0n = obj6;
				}
			}
			finally
			{
				do
				{
					_ = (z1J)(object)j5Y1.Default;
					o8W = null;
					o8W = null;
				}
				while ((object)j5Y1.Default != null);
				goto end_IL_00d1;
			}
			end_IL_00d1:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					Be5 be = null;
				}
				while (obj2 != null);
			}
			else
			{
				try
				{
					j5Y = j5Y;
					j5Y = j5Y;
				}
				catch
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			goto IL_0162;
		}
		IL_0349:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		try
		{
			k8NS k8NS = k8NS;
			k8NS = default(k8NS);
			br = br;
			_ = j5Y1.Default;
		}
		finally
		{
			_ = (Ng67)(object)j5Y1.Default;
			goto IL_0386;
		}
		IL_03da:
		_ = (t1P)(object)j5Y1.Default;
		_ = (Cd0n)(object)j5Y1.Default;
		do
		{
			_ = (k8NS)j5Y1.Default;
		}
		while (obj2 != null || obj2 != null || obj2 != null);
		t1P = t1P;
		_ = (Cd0n)(object)j5Y1.Default;
		if (uIntPtr == 0)
		{
			_ = (z1J)(object)j5Y1.Default;
		}
		else
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					tg0e = tg0e;
				}
				else
				{
					_ = (b2H1)j5Y1.Default;
				}
			}
			catch
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
		}
		if (uIntPtr == 0)
		{
			do
			{
				_ = (Be5)(object)j5Y1.Default;
			}
			while (obj2 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE);
		if ((nuint)(UIntPtr)j5Y1.Default / uIntPtr == 0)
		{
			while ((object)j5Y1.Default != null)
			{
				try
				{
					o8W = o8W;
				}
				finally
				{
					n4NE = n4NE;
					continue;
				}
			}
			goto IL_04cf;
		}
		try
		{
			y9T y9T = y9T;
			y9T = y9T;
		}
		finally
		{
			goto IL_04cf;
		}
		IL_0386:
		if (uIntPtr == 0)
		{
			try
			{
				if (checked(uIntPtr - unchecked((nuint)(UIntPtr)j5Y1.Default)) / uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
				else
				{
					_ = (b2H1)j5Y1.Default;
				}
			}
			finally
			{
				n4NE obj9 = (n4NE)(object)j5Y1.Default;
				n4NE = (n4NE)(object)j5Y1.Default;
				n4NE = obj9;
				goto IL_03da;
			}
		}
		goto IL_03da;
		IL_04cf:
		try
		{
			try
			{
				_ = (Ma6)(object)j5Y1.Default;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					k8NS k8NS = default(k8NS);
				}
				else
				{
					br = null;
				}
				goto end_IL_04d0;
			}
			end_IL_04d0:;
		}
		catch
		{
			_ = (c0B)(object)j5Y1.Default;
		}
		if (uIntPtr == 0)
		{
			_ = (b2H1)j5Y1.Default;
		}
		j5Y = j5Y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		do
		{
			_ = (Ng67)(object)j5Y1.Default;
			_ = (n4NE)(object)j5Y1.Default;
			ja = ja;
			ja = ja;
			_ = (b2H1)j5Y1.Default;
			_ = (b2H1)j5Y1.Default;
		}
		while (obj2 != null);
		t1P = t1P;
		_003CModule_003E obj11 = (_003CModule_003E)(object)j5Y1.Default;
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
		_003CModule_003E = obj11;
		while (obj2 != null)
		{
			try
			{
				_ = (n4NE)(object)j5Y1.Default;
			}
			catch
			{
				_ = (t1P)(object)j5Y1.Default;
			}
		}
		try
		{
			_ = (n4NE)(object)j5Y1.Default;
			_ = (_003CModule_003E)(object)j5Y1.Default;
			_003CModule_003E = _003CModule_003E;
			_ = (Br2)(object)j5Y1.Default;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				k8NS k8NS = (k8NS)j5Y1.Default;
			}
			else
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
				}
				catch
				{
					_ = (c0B)(object)j5Y1.Default;
				}
			}
		}
		while (true)
		{
			if (obj2 != null)
			{
				cd0n = cd0n;
			}
			else if ((object)j5Y1.Default == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (k8NS)j5Y1.Default;
			}
			catch
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					ma = ma;
				}
			}
		}
		try
		{
		}
		catch
		{
			t1P = t1P;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Ta8)(object)j5Y1.Default;
		}
		else
		{
			o8W = o8W;
			_ = (Ta8)(object)j5Y1.Default;
		}
		_ = (w5D)(object)j5Y1.Default;
		_ = (Be5)(object)j5Y1.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (k8NS)j5Y1.Default;
			o8W = o8W;
		}
		while (obj2 != null)
		{
		}
		try
		{
		}
		catch
		{
			do
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					k8NS k8NS = default(k8NS);
					continue;
				}
				cd0n = null;
				_ = (o8W)(object)j5Y1.Default;
				_ = j5Y1.Default;
			}
			while (obj2 != null);
		}
		do
		{
			_ = (o8W)(object)j5Y1.Default;
		}
		while (obj2 != null);
		return;
		IL_0162:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				UIntPtr num = uIntPtr;
				uIntPtr = default(UIntPtr);
				UIntPtr num2 = uIntPtr;
				UIntPtr num3 = (UIntPtr)j5Y1.Default;
				UIntPtr num4 = uIntPtr;
				UIntPtr num5 = (UIntPtr)j5Y1.Default;
				UIntPtr num6 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) + (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)num2) * (unchecked((nuint)num3) + (unchecked((nuint)num4) + (unchecked((nuint)num5) + (unchecked((nuint)num6) - (uIntPtr - uIntPtr))))) + unchecked((nuint)(UIntPtr)j5Y1.Default)) * unchecked((nuint)default(UIntPtr))) == 0)
					{
					}
				}
			}
			finally
			{
				_ = (Ja24)(object)j5Y1.Default;
				goto IL_0236;
			}
		}
		UIntPtr num7 = (UIntPtr)j5Y1.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num7) * uIntPtr * uIntPtr == 0)
			{
				try
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
				finally
				{
					ma = null;
					ma = null;
					goto IL_0236;
				}
			}
			if (uIntPtr == 0)
			{
				_ = (k8NS)j5Y1.Default;
			}
			goto IL_0236;
		}
		IL_0236:
		UIntPtr num8 = (UIntPtr)j5Y1.Default;
		uIntPtr = default(UIntPtr);
		if ((nuint)num8 / checked(uIntPtr + unchecked((nuint)(UIntPtr)j5Y1.Default)) == 0)
		{
			if (uIntPtr / (nuint)(UIntPtr)j5Y1.Default == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (z1J)(object)j5Y1.Default;
				}
			}
			else
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					tg0e = tg0e;
				}
				else
				{
					_ = (o8W)(object)j5Y1.Default;
					ng = ng;
				}
			}
			finally
			{
				try
				{
					_ = (Cd0n)(object)j5Y1.Default;
					_ = (Ng67)(object)j5Y1.Default;
					Be5 be = null;
				}
				catch
				{
					_ = (y9T)(object)j5Y1.Default;
					Gw13 gw = gw;
					gw = gw;
				}
				goto end_IL_028c;
			}
			end_IL_028c:;
		}
		finally
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (o8W)(object)j5Y1.Default;
				}
				finally
				{
					_ = (w5D)(object)j5Y1.Default;
					ma = ma;
					_ = (Ta8)(object)j5Y1.Default;
					Br2 obj19 = (Br2)(object)j5Y1.Default;
					br = br;
					br = obj19;
					goto IL_0349;
				}
			}
			goto IL_0349;
		}
	}
}
