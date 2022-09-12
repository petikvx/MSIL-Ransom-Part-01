using System;
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
using r4Z;
using w7Y6;
using w8E;

namespace s6Y;

[DesignerGenerated]
public class Pg6 : Form
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
			EventHandler eventHandler = s6Y;
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
			EventHandler eventHandler = p1J;
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
			EventHandler eventHandler = Jm0;
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
			EventHandler eventHandler = y3K;
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
			EventHandler eventHandler = Mw4;
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

	public Pg6()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Hi4);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Lq3();
	}

	[DebuggerNonUserCode]
	protected override void Zp9(bool Ea5)
	{
		try
		{
			if (Ea5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ea5);
		}
	}

	[DebuggerStepThrough]
	private void Lq3()
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
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		txtWeight = new TextBox();
		Label10 = new Label();
		DataGridView1 = new DataGridView();
		DateTimePicker1 = new DateTimePicker();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label1 = new Label();
		txtRcode = new TextBox();
		btnDelete = new Button();
		btnModify = new Button();
		txtCategory = new TextBox();
		txtRName = new TextBox();
		txtAmount = new TextBox();
		Label2 = new Label();
		btnSave = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(320, 21));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(123, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Purchase Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(734, 21));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(42, 21));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("Go To Main");
		((Control)txtWeight).set_Location(new Point(537, 136));
		((Control)txtWeight).set_Name("txtWeight");
		((Control)txtWeight).set_Size(new Size(100, 20));
		((Control)txtWeight).set_TabIndex(5);
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(478, 139));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(47, 13));
		((Control)Label10).set_TabIndex(99);
		Label10.set_Text("Weight :");
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(45, 239));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(724, 199));
		((Control)DataGridView1).set_TabIndex(11);
		((Control)DateTimePicker1).set_Location(new Point(537, 64));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(126, 20));
		((Control)DateTimePicker1).set_TabIndex(3);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(166, 130));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(55, 13));
		((Control)Label8).set_TabIndex(94);
		Label8.set_Text("Category :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(156, 101));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(66, 13));
		((Control)Label5).set_TabIndex(93);
		Label5.set_Text("Raw Name :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(466, 106));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(49, 13));
		((Control)Label4).set_TabIndex(92);
		Label4.set_Text("Amount :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(431, 67));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(84, 13));
		((Control)Label1).set_TabIndex(91);
		Label1.set_Text("Purchase Date :");
		((Control)txtRcode).set_Location(new Point(245, 64));
		((Control)txtRcode).set_Name("txtRcode");
		((Control)txtRcode).set_Size(new Size(100, 20));
		((Control)txtRcode).set_TabIndex(0);
		((Control)btnDelete).set_Location(new Point(496, 202));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(8);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(378, 202));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(7);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		((Control)txtCategory).set_Location(new Point(243, 124));
		((Control)txtCategory).set_Name("txtCategory");
		((Control)txtCategory).set_Size(new Size(100, 20));
		((Control)txtCategory).set_TabIndex(2);
		((Control)txtRName).set_Location(new Point(243, 94));
		((Control)txtRName).set_Name("txtRName");
		((Control)txtRName).set_Size(new Size(100, 20));
		((Control)txtRName).set_TabIndex(1);
		((Control)txtAmount).set_Location(new Point(537, 99));
		((Control)txtAmount).set_Name("txtAmount");
		((Control)txtAmount).set_Size(new Size(100, 20));
		((Control)txtAmount).set_TabIndex(4);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(167, 67));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(63, 13));
		((Control)Label2).set_TabIndex(90);
		Label2.set_Text("Row Code :");
		((Control)btnSave).set_Location(new Point(249, 202));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(6);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)txtWeight);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtRcode);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)txtCategory);
		((Control)this).get_Controls().Add((Control)(object)txtRName);
		((Control)this).get_Controls().Add((Control)(object)txtAmount);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmPurchaseDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmPurchaseDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void p1J(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void s6Y(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Hi4(object sender, EventArgs e)
	{
		Cw4();
	}

	private void Mw4(object sender, EventArgs e)
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
		Cw4();
	}

	public void Cw4()
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

	internal static byte[] o4G(int Ro0)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return Qy5m.g0N8(c7B.Ci4(), Ro0);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void y3K(object sender, EventArgs e)
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
		Cw4();
	}

	private void Jm0(object sender, EventArgs e)
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
		Cw4();
	}

	static void Wr7()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			checked
			{
				num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
			}
			if (num / checked(unchecked((nuint)(UIntPtr)s6J.Default) - unchecked((nuint)(UIntPtr)s6J.Default)) / (nuint)(UIntPtr)s6J.Default == 0)
			{
				_ = (o7A)(object)s6J.Default;
			}
			else
			{
				_ = (Tb9)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		if (num == 0)
		{
			c7R obj2 = (c7R)(object)s6J.Default;
			c7R = (c7R)(object)s6J.Default;
			c7R = obj2;
		}
		else
		{
			UIntPtr num2 = (UIntPtr)s6J.Default;
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num2) - num) / num == 0)
			{
				if (checked(num - num) == 0)
				{
					_ = (m9B)(object)s6J.Default;
				}
				else
				{
					_ = (m1S6)(object)s6J.Default;
				}
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Wm5)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		m9B m9B;
		try
		{
			while (obj != null)
			{
				try
				{
					o7A = (o7A)(object)s6J.Default;
					o7A = o7A;
				}
				finally
				{
					m1S = m1S;
					m1S = m1S;
					continue;
				}
			}
		}
		finally
		{
			_ = (Dw54)(object)s6J.Default;
			m9B obj3 = (m9B)(object)s6J.Default;
			m9B = (m9B)(object)s6J.Default;
			m9B = obj3;
			goto IL_015b;
		}
		IL_0320:
		Pg6 pg = pg;
		pg = null;
		Dw54 dw = null;
		Rg0 rg = rg;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2M8 g2M);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
			while (obj != null)
			{
				try
				{
					if (num == 0)
					{
						_ = (d9N2)(object)s6J.Default;
					}
				}
				finally
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + num == 0)
					{
						ap = (Ap93)(object)s6J.Default;
						ap = ap;
					}
					continue;
				}
			}
			if (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)))) != 0)
			{
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				UIntPtr num3 = unchecked((UIntPtr)s6J.Default);
				num = default(UIntPtr);
				if (unchecked((nuint)num3) - num == 0)
				{
					if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Dw54)(object)s6J.Default;
					}
					else
					{
						ap = ap;
					}
				}
				else
				{
					do
					{
						g2M = g2M;
						g2M = g2M;
					}
					while ((object)s6J.Default != null);
				}
			}
			else
			{
				c7R = c7R;
			}
			try
			{
				_ = (Wm5)(object)s6J.Default;
			}
			catch
			{
				while (obj != null)
				{
					try
					{
						x2K = (x2K9)(object)s6J.Default;
						x2K = x2K;
					}
					catch
					{
						_ = (Tb9)(object)s6J.Default;
						_ = (Tb9)(object)s6J.Default;
					}
				}
			}
			while (obj != null)
			{
				while (obj != null)
				{
					if (num == 0)
					{
						_ = (Tb9)(object)s6J.Default;
						_ = (m1S6)(object)s6J.Default;
						rg = rg;
					}
				}
			}
			_ = (c7B)(object)s6J.Default;
			c7R = (c7R)(object)s6J.Default;
			_003CModule_003E _003CModule_003E = null;
			_ = (m2R)(object)s6J.Default;
			num = default(UIntPtr);
			if (num == unchecked((UIntPtr)(nuint)0u))
			{
				while ((object)s6J.Default != null)
				{
					try
					{
						_ = (m9B)(object)s6J.Default;
					}
					catch
					{
						_ = (Ap93)(object)s6J.Default;
					}
				}
				goto IL_060f;
			}
			try
			{
				_ = (Pg6)(object)s6J.Default;
				_ = (d9N2)(object)s6J.Default;
				m1S = m1S;
				Wm5 wm = wm;
				wm = wm;
			}
			catch
			{
				o7A = null;
				pg = (Pg6)(object)s6J.Default;
			}
			finally
			{
				UIntPtr num4 = num;
				num = default(UIntPtr);
				UIntPtr num5 = num;
				UIntPtr num6 = num;
				num = default(UIntPtr);
				if (unchecked((nuint)num4) - unchecked((nuint)num5 / checked(unchecked((nuint)num6) + num + num)) * unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					pg = (Pg6)(object)s6J.Default;
				}
				else
				{
					c7R = (c7R)(object)s6J.Default;
					_ = (g2M8)(object)s6J.Default;
					_ = (_003CModule_003E)(object)s6J.Default;
					rg = null;
				}
				goto IL_060f;
			}
		}
		IL_09f0:
		while (obj != null)
		{
			_ = (c7R)(object)s6J.Default;
		}
		while ((object)s6J.Default != null)
		{
			do
			{
				if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Tb9)(object)s6J.Default;
				}
				else
				{
					x2K = x2K;
				}
			}
			while (obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				UIntPtr num7 = (UIntPtr)s6J.Default;
				num = default(UIntPtr);
				if ((nuint)num7 / checked(num * num) == 0)
				{
					_ = (Tb9)(object)s6J.Default;
				}
			}
		}
		_ = (c7R)(object)s6J.Default;
		return;
		IL_015b:
		if (num == 0)
		{
			do
			{
				_ = (m2R)(object)s6J.Default;
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				do
				{
					try
					{
						_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)s6J.Default;
						_003CModule_003E = _003CModule_003E;
					}
					finally
					{
						o7A = null;
						continue;
					}
				}
				while (obj != null);
			}
			else if (unchecked(checked(unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)(UIntPtr)s6J.Default)) / (nuint)(UIntPtr)s6J.Default) - num == 0)
			{
				while (obj != null)
				{
					dw = (Dw54)(object)s6J.Default;
					dw = dw;
				}
			}
			else
			{
				do
				{
					_ = (a0E)(object)s6J.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Ap93)(object)s6J.Default;
				}
				else
				{
					_ = (m9B)(object)s6J.Default;
				}
			}
		}
		catch
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (Dw54)(object)s6J.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		do
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Rg0)(object)s6J.Default;
				}
			}
			finally
			{
				try
				{
					rg = rg;
					rg = null;
				}
				finally
				{
					_ = (m2R)(object)s6J.Default;
					_ = (m9B)(object)s6J.Default;
					continue;
				}
			}
		}
		while ((object)s6J.Default != null);
		m9B = m9B;
		m1S = m1S;
		_ = (m9B)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		while (true)
		{
			if ((object)s6J.Default != null)
			{
				do
				{
					a0E = a0E;
					a0E = a0E;
				}
				while (obj != null);
			}
			else if ((object)s6J.Default == null)
			{
				break;
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (m2R)(object)s6J.Default;
				}
				finally
				{
					_ = (m9B)(object)s6J.Default;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			goto IL_0320;
		}
		IL_060f:
		do
		{
			_ = (Rg0)(object)s6J.Default;
			o7A = o7A;
			_ = (d9N2)(object)s6J.Default;
			Qy5m qy5m = (Qy5m)(object)s6J.Default;
			qy5m = qy5m;
		}
		while (obj != null || obj != null);
		num = default(UIntPtr);
		if (num / (nuint)(UIntPtr)s6J.Default == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (c7B)(object)s6J.Default;
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			o7A = o7A;
		}
		else
		{
			_ = (d9N2)(object)s6J.Default;
		}
		if ((nuint)(UIntPtr)s6J.Default / checked(unchecked((nuint)(UIntPtr)s6J.Default) + num) == 0)
		{
			try
			{
				while ((object)s6J.Default != null)
				{
					_ = (Tb9)(object)s6J.Default;
				}
			}
			catch
			{
				_ = (d9N2)(object)s6J.Default;
			}
		}
		else
		{
			num = default(UIntPtr);
			checked
			{
				if (unchecked(num / num) + num != 0)
				{
				}
			}
		}
		do
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			finally
			{
				a0E = null;
				continue;
			}
		}
		while (obj != null);
		g2M = null;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (m2R)(object)s6J.Default;
			}
		}
		num = default(UIntPtr);
		nuint num8 = num;
		checked
		{
			nuint num9 = unchecked((nuint)(UIntPtr)s6J.Default) * num;
			num = default(UIntPtr);
			if (num8 - (num9 - num - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
			{
				_003CModule_003E _003CModule_003E = null;
			}
			try
			{
				try
				{
					if (num * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (a0E)(object)s6J.Default;
						_ = (a0E)(object)s6J.Default;
					}
					else
					{
						o7A = o7A;
						Wm5 wm = (Wm5)(object)s6J.Default;
						_ = (Rg0)(object)s6J.Default;
					}
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) * (unchecked(num / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)(UIntPtr)s6J.Default) - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
					{
						_ = (Qy5m)(object)s6J.Default;
					}
					goto end_IL_07a2;
				}
				end_IL_07a2:;
			}
			catch
			{
				_ = (Dw54)(object)s6J.Default;
			}
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				g2M = null;
			}
		}
		while (obj != null);
		do
		{
			try
			{
				o7A = o7A;
			}
			catch
			{
				_ = (Tb9)(object)s6J.Default;
				m1S = (m1S6)(object)s6J.Default;
				Wm5 wm = (Wm5)(object)s6J.Default;
				_ = s6J.Default;
			}
		}
		while (obj != null || obj != null);
		try
		{
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / checked(num * num * unchecked((nuint)(UIntPtr)s6J.Default) + num) == 0)
			{
				do
				{
					_ = (d9N2)(object)s6J.Default;
					_ = (m9B)(object)s6J.Default;
				}
				while (obj != null);
			}
			else
			{
				try
				{
					pg = null;
				}
				catch
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					dw = dw;
				}
				catch
				{
					dw = null;
					_ = (_003CModule_003E)(object)s6J.Default;
					_ = s6J.Default;
					_ = (m1S6)(object)s6J.Default;
				}
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				o7A = o7A;
			}
		}
		if (num == 0)
		{
			try
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = s6J.Default;
				}
				else
				{
					_ = (Pg6)(object)s6J.Default;
				}
			}
			finally
			{
				try
				{
					Ap93 ap = null;
					_ = (Ap93)(object)s6J.Default;
					pg = pg;
					dw = (Dw54)(object)s6J.Default;
				}
				catch
				{
					m9B = m9B;
				}
				goto IL_09f0;
			}
		}
		goto IL_09f0;
	}

	static void n0T5()
	{
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rg0 rg);
		Tb9 tb;
		if (checked(unchecked((nuint)default(UIntPtr)) * (uIntPtr + uIntPtr) + (unchecked(uIntPtr / (uIntPtr / uIntPtr)) - uIntPtr)) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					tb = null;
					tb = tb;
					_ = (a0E)(object)s6J.Default;
					Qy5m qy5m = null;
					qy5m = qy5m;
				}
				else
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					m1S6 m1S = m1S;
					m1S = m1S;
					s6J s6J = s6J;
					s6J = s6J;
					d9N2 d9N = null;
					d9N = d9N;
				}
			}
		}
		else
		{
			do
			{
				try
				{
					rg = rg;
					rg = rg;
				}
				finally
				{
					_ = (m9B)(object)s6J.Default;
					goto IL_00f6;
				}
				IL_00f6:
				obj = obj;
			}
			while (obj != null);
		}
		tb = null;
		_ = (x2K9)(object)s6J.Default;
		c7R c7R = c7R;
		c7R = null;
		while ((object)s6J.Default != null)
		{
			try
			{
				do
				{
					_ = (g2M8)(object)s6J.Default;
				}
				while (obj != null);
			}
			catch
			{
				if (uIntPtr == 0)
				{
				}
			}
		}
		x2K9 x2K;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		try
		{
		}
		catch
		{
			while (obj != null)
			{
				_ = (c7B)(object)s6J.Default;
			}
		}
		finally
		{
			try
			{
				o7A = o7A;
				o7A = null;
			}
			catch
			{
				_ = (m2R)(object)s6J.Default;
			}
			finally
			{
				do
				{
					x2K9 obj5 = (x2K9)(object)s6J.Default;
					x2K = null;
					x2K = obj5;
				}
				while (obj != null);
				goto IL_01be;
			}
		}
		IL_0251:
		try
		{
		}
		catch
		{
			try
			{
				do
				{
					_ = (c7R)(object)s6J.Default;
				}
				while (obj != null);
			}
			finally
			{
				do
				{
					_ = (o7A)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
				goto end_IL_0254;
			}
			end_IL_0254:;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (m1S6)(object)s6J.Default;
			}
			while (obj != null);
		}
		_ = (Ap93)(object)s6J.Default;
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr * uIntPtr) == 0)
		{
			try
			{
				try
				{
					_ = (c7B)(object)s6J.Default;
				}
				catch
				{
					_ = (m1S6)(object)s6J.Default;
				}
			}
			catch
			{
				_ = (d9N2)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		try
		{
			do
			{
				_ = (Rg0)(object)s6J.Default;
			}
			while ((object)s6J.Default != null);
		}
		catch
		{
			wm = wm;
		}
		_ = (Ap93)(object)s6J.Default;
		try
		{
			while ((object)s6J.Default != null)
			{
				while (obj != null)
				{
					_ = s6J.Default;
				}
			}
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					_ = (Pg6)(object)s6J.Default;
				}
			}
			catch
			{
				_ = (Pg6)(object)s6J.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out g2M8 g2M);
			while ((object)s6J.Default != null)
			{
				g2M = g2M;
				g2M = g2M;
			}
		}
		else
		{
			_ = (d9N2)(object)s6J.Default;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				c7R = c7R;
				_ = (d9N2)(object)s6J.Default;
			}
			while (obj != null);
		}
		else
		{
			_ = (Dw54)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		try
		{
			while ((object)s6J.Default != null)
			{
				if (uIntPtr == 0)
				{
					pg = pg;
					pg = pg;
				}
				else
				{
					_ = (c7R)(object)s6J.Default;
				}
			}
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (o7A)(object)s6J.Default;
				}
			}
			catch
			{
				c7B obj12 = (c7B)(object)s6J.Default;
				c7B = c7B;
				c7B = obj12;
			}
		}
		_ = (Rg0)(object)s6J.Default;
		pg = pg;
		Dw54 dw = dw;
		dw = null;
		_ = (Qy5m)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				_ = (o7A)(object)s6J.Default;
				_ = (Wm5)(object)s6J.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					o7A = (o7A)(object)s6J.Default;
				}
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = s6J.Default;
				}
				else
				{
					c7B = c7B;
				}
			}
			goto IL_0533;
		}
		IL_0533:
		while (obj != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (x2K9)(object)s6J.Default;
				}
				else
				{
					_ = s6J.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					rg = rg;
				}
				continue;
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
				{
					try
					{
						x2K = x2K;
					}
					catch
					{
						_ = (Qy5m)(object)s6J.Default;
						_ = (d9N2)(object)s6J.Default;
						o7A = o7A;
					}
				}
				else
				{
					do
					{
						_ = (g2M8)(object)s6J.Default;
					}
					while (obj != null);
				}
			}
			try
			{
				while (obj != null)
				{
					Qy5m qy5m = (Qy5m)(object)s6J.Default;
				}
			}
			finally
			{
				do
				{
					try
					{
						rg = null;
					}
					finally
					{
						Qy5m qy5m = (Qy5m)(object)s6J.Default;
						_ = (o7A)(object)s6J.Default;
						continue;
					}
				}
				while (obj != null);
				goto IL_05e0;
			}
		}
		IL_05e0:
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				wm = wm;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			_ = (Pg6)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)s6J.Default != null)
				{
					_ = (m2R)(object)s6J.Default;
				}
			}
			else
			{
				while ((object)s6J.Default != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			try
			{
				while ((object)s6J.Default != null)
				{
					ap = ap;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Pg6)(object)s6J.Default;
				}
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
			}
		}
		_ = s6J.Default;
		_ = (m9B)(object)s6J.Default;
		return;
		IL_01be:
		while (obj != null)
		{
			while ((object)s6J.Default != null)
			{
				do
				{
					ap = null;
				}
				while (obj != null);
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				do
				{
					if (uIntPtr == 0)
					{
						_ = (_003CModule_003E)(object)s6J.Default;
					}
				}
				while (obj != null);
			}
			tb = tb;
			if (unchecked((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u))
			{
				try
				{
					while (obj != null)
					{
						_ = (m1S6)(object)s6J.Default;
					}
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) * uIntPtr * uIntPtr == 0)
					{
					}
					goto IL_0241;
				}
			}
			goto IL_0241;
		}
		IL_0241:
		try
		{
		}
		finally
		{
			_ = (Pg6)(object)s6J.Default;
			goto IL_0251;
		}
	}

	static void n5A6()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		do
		{
			if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
			{
				a0E obj = (a0E)(object)s6J.Default;
				a0E = a0E;
				a0E = obj;
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				Rg0 rg = null;
				rg = rg;
			}
			obj2 = obj2;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			try
			{
				while (obj2 != null)
				{
					d9N2 obj3 = (d9N2)(object)s6J.Default;
					d9N = null;
					d9N = obj3;
				}
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				goto end_IL_004d;
			}
			end_IL_004d:;
		}
		catch
		{
			do
			{
				_ = (Wm5)(object)s6J.Default;
			}
			while ((object)s6J.Default != null);
		}
		UIntPtr uIntPtr;
		Dw54 dw;
		checked
		{
			try
			{
				dw = (Dw54)(object)s6J.Default;
				dw = dw;
			}
			finally
			{
				do
				{
					uIntPtr = default(UIntPtr);
					uIntPtr = default(UIntPtr);
					if (uIntPtr - uIntPtr * unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)s6J.Default) != 0)
					{
						_ = (m1S6)(object)s6J.Default;
					}
					else
					{
						_ = (c7B)(object)s6J.Default;
					}
				}
				while (obj2 != null);
				goto IL_011b;
			}
		}
		IL_0323:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		try
		{
			if (uIntPtr == 0)
			{
				while ((object)s6J.Default != null)
				{
					_ = (Wm5)(object)s6J.Default;
				}
			}
		}
		finally
		{
			m1S = m1S;
			goto IL_035c;
		}
		IL_055c:
		_ = (c7B)(object)s6J.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					d9N = d9N;
					c7R c7R = c7R;
					c7R = null;
				}
				catch
				{
					a0E = a0E;
				}
			}
			catch
			{
				while (obj2 != null)
				{
					x2K9 x2K = null;
				}
			}
		}
		_ = (m2R)(object)s6J.Default;
		_ = s6J.Default;
		_ = (_003CModule_003E)(object)s6J.Default;
		_003CModule_003E = _003CModule_003E;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (g2M8)(object)s6J.Default;
				}
			}
			else
			{
				_ = (d9N2)(object)s6J.Default;
			}
		}
		else
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					m1S = (m1S6)(object)s6J.Default;
				}
			}
			catch
			{
				try
				{
					a0E = null;
					_ = (Rg0)(object)s6J.Default;
					_ = (m2R)(object)s6J.Default;
				}
				catch
				{
					_ = (Rg0)(object)s6J.Default;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (g2M8)(object)s6J.Default;
			}
		}
		else
		{
			_ = (Ap93)(object)s6J.Default;
		}
		try
		{
			while (obj2 != null)
			{
				_ = (c7R)(object)s6J.Default;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (m2R)(object)s6J.Default;
				}
				catch
				{
					_ = (Ap93)(object)s6J.Default;
				}
			}
			goto IL_06ce;
		}
		IL_0479:
		_ = (a0E)(object)s6J.Default;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && checked(uIntPtr + (unchecked((nuint)(UIntPtr)s6J.Default) - unchecked((nuint)default(UIntPtr)))) == 0)
		{
			do
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			while (obj2 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		while (obj2 != null)
		{
			a0E = a0E;
			_ = (g2M8)(object)s6J.Default;
			m2R = m2R;
		}
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					tb = null;
				}
				finally
				{
					_ = (Tb9)(object)s6J.Default;
					goto end_IL_0504;
				}
				end_IL_0504:;
			}
			catch
			{
				do
				{
					_ = (m9B)(object)s6J.Default;
				}
				while (obj2 != null);
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)s6J.Default;
		}
		finally
		{
			do
			{
				try
				{
					_ = (o7A)(object)s6J.Default;
				}
				finally
				{
					continue;
				}
			}
			while ((object)s6J.Default != null);
			goto IL_055c;
		}
		IL_06ce:
		while ((object)s6J.Default != null)
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					tb = null;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		try
		{
			return;
		}
		finally
		{
			while ((object)s6J.Default != null)
			{
				while (obj2 != null)
				{
					o7A = o7A;
				}
			}
			return;
		}
		IL_0307:
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			_ = (Qy5m)(object)s6J.Default;
			goto IL_0323;
		}
		IL_0232:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
			while (obj2 != null)
			{
				try
				{
					_ = (Ap93)(object)s6J.Default;
				}
				catch
				{
					x2K = x2K;
					x2K = x2K;
				}
			}
		}
		_ = (o7A)(object)s6J.Default;
		_ = (c7B)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		try
		{
			try
			{
				try
				{
					Rg0 rg = null;
				}
				finally
				{
					g2M8 obj13 = (g2M8)(object)s6J.Default;
					g2M8 g2M = g2M;
					g2M = obj13;
					goto end_IL_0282;
				}
				end_IL_0282:;
			}
			finally
			{
				try
				{
					_ = (d9N2)(object)s6J.Default;
				}
				catch
				{
					_ = (Tb9)(object)s6J.Default;
				}
				goto end_IL_0281;
			}
			end_IL_0281:;
		}
		finally
		{
			try
			{
				try
				{
					c7B obj15 = (c7B)(object)s6J.Default;
					c7B c7B = c7B;
					c7B = obj15;
				}
				catch
				{
					_ = s6J.Default;
				}
			}
			catch
			{
				try
				{
					dw = dw;
				}
				finally
				{
					wm = wm;
					goto end_IL_02ee;
				}
				end_IL_02ee:;
			}
			goto IL_0307;
		}
		IL_011b:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			else
			{
				while ((object)s6J.Default != null)
				{
					_ = (c7B)(object)s6J.Default;
				}
			}
		}
		dw = (Dw54)(object)s6J.Default;
		wm = wm;
		wm = wm;
		_ = (Dw54)(object)s6J.Default;
		_ = (Qy5m)(object)s6J.Default;
		dw = dw;
		if (checked(unchecked((nuint)(UIntPtr)s6J.Default) - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Dw54)(object)s6J.Default;
				}
				finally
				{
					_ = (a0E)(object)s6J.Default;
					goto IL_0232;
				}
			}
			m1S6 obj18 = (m1S6)(object)s6J.Default;
			m1S = m1S;
			m1S = obj18;
			goto IL_0232;
		}
		try
		{
			m2R = (m2R)(object)s6J.Default;
			m2R = m2R;
		}
		catch
		{
			_ = (m9B)(object)s6J.Default;
		}
		finally
		{
			try
			{
				_ = (Dw54)(object)s6J.Default;
			}
			catch
			{
				_ = (Wm5)(object)s6J.Default;
			}
			goto IL_0232;
		}
		IL_035c:
		while ((object)s6J.Default != null)
		{
			tb = tb;
			tb = null;
		}
		o7A obj21 = (o7A)(object)s6J.Default;
		o7A = o7A;
		o7A = obj21;
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				c7B c7B = (c7B)(object)s6J.Default;
			}
		}
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (c7B)(object)s6J.Default;
				}
				else
				{
					_ = (g2M8)(object)s6J.Default;
				}
			}
			catch
			{
				o7A = o7A;
			}
		}
		while (obj2 != null);
		o7A = (o7A)(object)s6J.Default;
		m1S = (m1S6)(object)s6J.Default;
		_003CModule_003E = _003CModule_003E;
		try
		{
			while ((object)s6J.Default != null)
			{
				wm = null;
			}
		}
		catch
		{
			try
			{
				_ = (Wm5)(object)s6J.Default;
			}
			finally
			{
				while (obj2 != null)
				{
					_ = (Qy5m)(object)s6J.Default;
				}
				goto end_IL_0410;
			}
			end_IL_0410:;
		}
		_ = (Qy5m)(object)s6J.Default;
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = s6J.Default;
				}
				catch
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
			else
			{
				a0E = null;
			}
		}
		finally
		{
			wm = wm;
			goto IL_0479;
		}
	}
}
