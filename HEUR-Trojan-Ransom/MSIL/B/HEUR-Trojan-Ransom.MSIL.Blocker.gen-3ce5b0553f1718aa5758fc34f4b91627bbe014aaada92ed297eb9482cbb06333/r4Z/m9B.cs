using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using La50;
using Lg1;
using Microsoft.VisualBasic.CompilerServices;
using Qo03;
using Yi2x;
using Yw2;
using b8ED;
using e2N;
using f0B;
using f2H;
using f2K3;
using f4A;
using m4K5;
using m7A;
using r4B;
using s6Y;
using w7Y6;
using w8E;

namespace r4Z;

[DesignerGenerated]
public class m9B : Form
{
	internal delegate void Ak4();

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
			EventHandler eventHandler = Hy9;
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
			EventHandler eventHandler = Gm0;
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
			EventHandler eventHandler = Jd1;
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
			EventHandler eventHandler = g6G;
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
			EventHandler eventHandler = w1M;
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

	public m9B()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Sp7);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		z6Z();
	}

	[DebuggerNonUserCode]
	protected override void La2(bool p2F)
	{
		try
		{
			if (p2F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p2F);
		}
	}

	[DebuggerStepThrough]
	private void z6Z()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		DateTimePicker1 = new DateTimePicker();
		Label9 = new Label();
		txtTransport = new TextBox();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label1 = new Label();
		txtBNo = new TextBox();
		btnDelete = new Button();
		btnModify = new Button();
		txtDiscount = new TextBox();
		txtRDetail = new TextBox();
		txtCname = new TextBox();
		Label2 = new Label();
		btnSave = new Button();
		DataGridView1 = new DataGridView();
		Label10 = new Label();
		txtTotal = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(363, 29));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(52, 17));
		((Control)Label3).set_TabIndex(7);
		Label3.set_Text("Billing");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(734, 29));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(42, 29));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(10);
		Label7.set_Text("Go To Main");
		((Control)DateTimePicker1).set_Location(new Point(537, 64));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(126, 20));
		((Control)DateTimePicker1).set_TabIndex(4);
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(132, 162));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(88, 13));
		((Control)Label9).set_TabIndex(78);
		Label9.set_Text("Transport Detail :");
		((Control)txtTransport).set_Location(new Point(243, 159));
		((Control)txtTransport).set_Name("txtTransport");
		((Control)txtTransport).set_Size(new Size(100, 20));
		((Control)txtTransport).set_TabIndex(3);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(166, 130));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(55, 13));
		((Control)Label8).set_TabIndex(76);
		Label8.set_Text("Discount :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(156, 101));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(65, 13));
		((Control)Label5).set_TabIndex(75);
		Label5.set_Text("Raw Detail :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(427, 106));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(88, 13));
		((Control)Label4).set_TabIndex(74);
		Label4.set_Text("Customer Name :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(450, 64));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(66, 13));
		((Control)Label1).set_TabIndex(73);
		Label1.set_Text("Billing Date :");
		((Control)txtBNo).set_Location(new Point(245, 64));
		((Control)txtBNo).set_Name("txtBNo");
		((Control)txtBNo).set_Size(new Size(100, 20));
		((Control)txtBNo).set_TabIndex(0);
		((Control)btnDelete).set_Location(new Point(496, 202));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(9);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(378, 202));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(8);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		((Control)txtDiscount).set_Location(new Point(243, 124));
		((Control)txtDiscount).set_Name("txtDiscount");
		((Control)txtDiscount).set_Size(new Size(100, 20));
		((Control)txtDiscount).set_TabIndex(2);
		((Control)txtRDetail).set_Location(new Point(243, 94));
		((Control)txtRDetail).set_Name("txtRDetail");
		((Control)txtRDetail).set_Size(new Size(100, 20));
		((Control)txtRDetail).set_TabIndex(1);
		((Control)txtCname).set_Location(new Point(537, 99));
		((Control)txtCname).set_Name("txtCname");
		((Control)txtCname).set_Size(new Size(100, 20));
		((Control)txtCname).set_TabIndex(5);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(167, 67));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(57, 13));
		((Control)Label2).set_TabIndex(72);
		Label2.set_Text("Billing No :");
		((Control)btnSave).set_Location(new Point(249, 202));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(7);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(45, 239));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(724, 199));
		((Control)DataGridView1).set_TabIndex(12);
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(478, 139));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(37, 13));
		((Control)Label10).set_TabIndex(81);
		Label10.set_Text("Total :");
		((Control)txtTotal).set_Location(new Point(537, 136));
		((Control)txtTotal).set_Name("txtTotal");
		((Control)txtTotal).set_Size(new Size(100, 20));
		((Control)txtTotal).set_TabIndex(6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)txtTotal);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)txtTransport);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtBNo);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)txtDiscount);
		((Control)this).get_Controls().Add((Control)(object)txtRDetail);
		((Control)this).get_Controls().Add((Control)(object)txtCname);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmBilling");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmBilling");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Gm0(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void Hy9(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Sp7(object sender, EventArgs e)
	{
		p2B();
	}

	private void w1M(object sender, EventArgs e)
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
		p2B();
	}

	public void p2B()
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

	private void g6G(object sender, EventArgs e)
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
		p2B();
	}

	private void Jd1(object sender, EventArgs e)
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
		p2B();
	}

	[STAThread]
	public static void Yi1()
	{
		try
		{
			int j5A;
			do
			{
				j5A = 2;
			}
			while (!o7A.f3N() || !Tb9.Yx5(j5A));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = c7R.Rz4(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = c7R.Rz4(Listt, 1, 1);
			mName = c7R.Rz4(Listt, 2, 2);
			mArray = c7R.Rz4(Listt, 3, 3);
			sArray = c7R.Rz4(Listt, 4, 4);
			T = c7R.Rz4(Listt, 5, 5);
			sNum = c7R.Rz4(Listt, 6, 6);
			mDic.Add(sNum, 98);
			byte[] value = Tb9.Ee6(98, 15);
			mDic.Add(sArray, value);
			m2R.Wc8();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void Zb4()
	{
		object obj;
		try
		{
			o7A o7A = null;
			o7A = o7A;
		}
		finally
		{
			while (true)
			{
				obj = s6J.Default;
				if (obj != null)
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_003d;
		}
		IL_003d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2M8 g2M);
		nuint num;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			checked
			{
				if (num == 0)
				{
					if (num * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (a0E)(object)s6J.Default;
						_ = (a0E)(object)s6J.Default;
					}
					else
					{
						_ = (Qy5m)(object)s6J.Default;
					}
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					g2M8 obj2 = (g2M8)(object)s6J.Default;
					g2M = (g2M8)(object)s6J.Default;
					g2M = obj2;
				}
				catch
				{
					_ = (x2K9)(object)s6J.Default;
				}
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o7A)(object)s6J.Default;
			}
			else
			{
				_ = (c7B)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		checked
		{
			if (num - num == 0)
			{
				if (unchecked((nuint)(UIntPtr)s6J.Default) * num == 0)
				{
					_ = s6J.Default;
					_ = (c7R)(object)s6J.Default;
				}
				goto IL_014c;
			}
			try
			{
				do
				{
					g2M = null;
				}
				while (obj != null);
			}
			finally
			{
				tb = null;
				tb = tb;
				goto IL_014c;
			}
		}
		IL_02e5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		while (obj != null)
		{
			pg = pg;
		}
		_ = (Qy5m)(object)s6J.Default;
		while (obj != null)
		{
			tb = tb;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		try
		{
			x2K = x2K;
			x2K = null;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = s6J.Default;
			}
			goto IL_0332;
		}
		IL_014c:
		_ = (o7A)(object)s6J.Default;
		try
		{
			_ = (m9B)(object)s6J.Default;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (a0E)(object)s6J.Default;
			}
			goto IL_0189;
		}
		IL_0189:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		if (num == 0)
		{
			try
			{
				while ((object)s6J.Default != null)
				{
					_ = (g2M8)(object)s6J.Default;
				}
			}
			finally
			{
				try
				{
					pg = pg;
					pg = null;
					_ = (Tb9)(object)s6J.Default;
					s6J = s6J.Default;
					s6J = s6J;
					Ap93 ap = ap;
					ap = ap;
				}
				finally
				{
					_ = (o7A)(object)s6J.Default;
					goto IL_021f;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		try
		{
			wm = (Wm5)(object)s6J.Default;
			wm = wm;
		}
		catch
		{
			s6J = s6J;
		}
		goto IL_021f;
		IL_0665:
		try
		{
			do
			{
				_ = (o7A)(object)s6J.Default;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				g2M = null;
			}
			finally
			{
				try
				{
					s6J = null;
				}
				catch
				{
					_ = (o7A)(object)s6J.Default;
				}
				goto IL_069c;
			}
		}
		IL_047b:
		_ = (Tb9)(object)s6J.Default;
		Dw54 dw = dw;
		_ = (d9N2)(object)s6J.Default;
		Rg0 rg = null;
		rg = rg;
		try
		{
			try
			{
				do
				{
					wm = wm;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					pg = (Pg6)(object)s6J.Default;
				}
				finally
				{
					_ = (Ap93)(object)s6J.Default;
					goto end_IL_04b8;
				}
				end_IL_04b8:;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Qy5m)(object)s6J.Default;
				dw = dw;
				wm = null;
				_ = (Tb9)(object)s6J.Default;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Wm5)(object)s6J.Default;
			}
			else
			{
				_ = (Pg6)(object)s6J.Default;
			}
		}
		finally
		{
			goto IL_053d;
		}
		IL_053d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					m1S = m1S;
				}
			}
			else if ((nuint)(UIntPtr)s6J.Default / num == 0)
			{
				_ = (Rg0)(object)s6J.Default;
			}
		}
		catch
		{
			try
			{
			}
			finally
			{
				while (obj != null)
				{
					wm = null;
				}
				goto end_IL_057e;
			}
			end_IL_057e:;
		}
		if (num / ((nuint)(UIntPtr)s6J.Default / (nuint)(UIntPtr)s6J.Default) / (nuint)(UIntPtr)s6J.Default == 0)
		{
			_ = (c7B)(object)s6J.Default;
		}
		else
		{
			do
			{
				try
				{
					pg = null;
				}
				finally
				{
					tb = null;
					continue;
				}
			}
			while ((object)s6J.Default != null);
		}
		c7B c7B = (c7B)(object)s6J.Default;
		_ = (m9B)(object)s6J.Default;
		_ = (Ap93)(object)s6J.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_ = (Tb9)(object)s6J.Default;
				m2R = m2R;
				c7B = c7B;
			}
			catch
			{
				_ = (a0E)(object)s6J.Default;
				_ = (o7A)(object)s6J.Default;
			}
			finally
			{
				do
				{
					tb = null;
				}
				while (obj != null);
				goto IL_0665;
			}
		}
		goto IL_0665;
		IL_021f:
		if (num / unchecked((nuint)default(UIntPtr)) == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = s6J.Default;
		}
		try
		{
			while ((object)s6J.Default != null)
			{
				_ = (x2K9)(object)s6J.Default;
			}
		}
		catch
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (Wm5)(object)s6J.Default;
				}
			}
		}
		try
		{
			dw = dw;
			dw = dw;
			dw = (Dw54)(object)s6J.Default;
			s6J = null;
			m1S = null;
			m1S = null;
		}
		finally
		{
			_ = (m2R)(object)s6J.Default;
			goto IL_02e5;
		}
		IL_0332:
		_ = s6J.Default;
		try
		{
			try
			{
				_ = (Wm5)(object)s6J.Default;
			}
			finally
			{
				c7B obj12 = (c7B)(object)s6J.Default;
				c7B = null;
				c7B = obj12;
				goto end_IL_033e;
			}
			end_IL_033e:;
		}
		catch
		{
			if ((nuint)(UIntPtr)s6J.Default / (nuint)(UIntPtr)s6J.Default == 0)
			{
				_ = s6J.Default;
				_ = (Qy5m)(object)s6J.Default;
				_ = (x2K9)(object)s6J.Default;
				_ = (_003CModule_003E)(object)s6J.Default;
			}
		}
		finally
		{
			do
			{
				_ = (Ap93)(object)s6J.Default;
			}
			while (obj != null);
			goto IL_03bf;
		}
		IL_03bf:
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = s6J.Default;
				_ = (Ap93)(object)s6J.Default;
				g2M = g2M;
				_ = (Dw54)(object)s6J.Default;
			}
			while ((object)s6J.Default != null || obj != null);
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Pg6)(object)s6J.Default;
			_ = (Rg0)(object)s6J.Default;
			_ = (o7A)(object)s6J.Default;
			_ = (Dw54)(object)s6J.Default;
			goto IL_047b;
		}
		try
		{
			wm = null;
		}
		catch
		{
			_ = (a0E)(object)s6J.Default;
		}
		finally
		{
			do
			{
				wm = wm;
				s6J = null;
				x2K = x2K;
			}
			while (obj != null);
			goto IL_047b;
		}
		IL_069c:
		do
		{
			_ = (Rg0)(object)s6J.Default;
		}
		while (obj != null);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (m9B)(object)s6J.Default;
			_ = (m1S6)(object)s6J.Default;
			_ = (c7B)(object)s6J.Default;
			wm = wm;
		}
		m2R = (m2R)(object)s6J.Default;
		_ = (Dw54)(object)s6J.Default;
		_ = (m2R)(object)s6J.Default;
		_ = (m2R)(object)s6J.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (x2K9)(object)s6J.Default;
		}
		else if (num == 0)
		{
			while (obj != null)
			{
				wm = wm;
			}
		}
		c7R c7R = c7R;
		c7R = null;
		try
		{
			try
			{
				_ = (Ap93)(object)s6J.Default;
			}
			finally
			{
				_ = (d9N2)(object)s6J.Default;
				goto end_IL_074b;
			}
			end_IL_074b:;
		}
		catch
		{
			_ = (m1S6)(object)s6J.Default;
		}
		_ = (d9N2)(object)s6J.Default;
		s6J = s6J;
		try
		{
			_ = (c7B)(object)s6J.Default;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Pg6)(object)s6J.Default;
			}
			else
			{
				_ = (Rg0)(object)s6J.Default;
			}
		}
		try
		{
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					_ = (x2K9)(object)s6J.Default;
				}
				else
				{
					tb = tb;
				}
			}
			finally
			{
				do
				{
					m2R = m2R;
				}
				while (obj != null);
				goto end_IL_07c4;
			}
			end_IL_07c4:;
		}
		try
		{
			checked
			{
				nuint num2 = num + unchecked((nuint)(UIntPtr)s6J.Default / unchecked((nuint)default(UIntPtr)));
				num = default(UIntPtr);
				if (num2 * num == 0)
				{
					if (num == 0)
					{
						x2K = x2K;
					}
					else
					{
						x2K = x2K;
					}
				}
			}
		}
		catch
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				m2R = m2R;
			}
		}
	}
}
