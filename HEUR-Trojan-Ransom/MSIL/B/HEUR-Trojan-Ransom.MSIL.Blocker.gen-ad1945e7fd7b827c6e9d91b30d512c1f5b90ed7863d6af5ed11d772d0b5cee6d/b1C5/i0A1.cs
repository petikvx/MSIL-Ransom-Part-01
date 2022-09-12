using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cd2;
using Dn57;
using Fg5p;
using Jr8;
using Microsoft.VisualBasic.CompilerServices;
using Ps92;
using Wy4;
using Xr2;
using j8P3;
using k6J;
using n0WD;
using n4M;
using n7K;
using o1N;
using o9R;
using p6S;
using y1M;
using y8D;

namespace b1C5;

[DesignerGenerated]
public class i0A1 : Form
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
			EventHandler eventHandler = Fj9g;
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
			EventHandler eventHandler = Wc19;
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
			EventHandler eventHandler = i3QZ;
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
			EventHandler eventHandler = m4KR;
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
			EventHandler eventHandler = o5N7;
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

	public i0A1()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Kf5t);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Qi7k();
	}

	[DebuggerNonUserCode]
	protected override void Hw1o(bool Zn69)
	{
		try
		{
			if (Zn69 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zn69);
		}
	}

	[DebuggerStepThrough]
	private void Qi7k()
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

	private void Wc19(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void Fj9g(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Kf5t(object sender, EventArgs e)
	{
		z3K0();
	}

	private void o5N7(object sender, EventArgs e)
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
		z3K0();
	}

	public void z3K0()
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

	internal static byte[] a1T2(int r1FN)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return Ln53.Tj6z(Qg6.Gg84(), r1FN);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void m4KR(object sender, EventArgs e)
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
		z3K0();
	}

	private void i3QZ(object sender, EventArgs e)
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
		z3K0();
	}

	static void Go9b()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		Zo8 zo;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				finally
				{
					_ = (a1B)(object)a7W.Default;
					goto end_IL_0018;
				}
				end_IL_0018:;
			}
			catch
			{
				try
				{
					_ = (En1)(object)a7W.Default;
				}
				finally
				{
					zo = (Zo8)(object)a7W.Default;
					zo = zo;
					goto end_IL_0035;
				}
				end_IL_0035:;
			}
		}
		else
		{
			sm = (Sm6)(object)a7W.Default;
			sm = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		try
		{
			_ = (i0A1)(object)a7W.Default;
			nn9a = nn9a;
			nn9a = nn9a;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					i0A2 = null;
					i0A2 = null;
					obj2 = obj2;
				}
				while (obj2 != null);
			}
			else if (uIntPtr == 0)
			{
				ln = ln;
				ln = ln;
			}
			else
			{
				qg = (Qg6)(object)a7W.Default;
				qg = null;
				_ = (Zo8)(object)a7W.Default;
				_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
				_003CModule_003E = null;
			}
			goto IL_0199;
		}
		IL_047c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		try
		{
			_ = (Ta6)(object)a7W.Default;
			_ = (b6E)(object)a7W.Default;
			_ = (y8R)(object)a7W.Default;
		}
		catch
		{
			while (obj2 != null)
			{
				while ((object)a7W.Default != null)
				{
					y8R = null;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)a7W.Default / (nuint)(UIntPtr)a7W.Default) == 0)
			{
				a7W = null;
			}
			while ((object)a7W.Default != null)
			{
				i0A2 = (i0A1)(object)a7W.Default;
				_ = (b1YL)(object)a7W.Default;
			}
			a1B = a1B;
			try
			{
				do
				{
					if (uIntPtr != 0)
					{
						sm = null;
					}
					else
					{
						nm2f = nm2f;
					}
				}
				while (obj2 != null);
			}
			catch
			{
				do
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
					{
						_ = (a1B)(object)a7W.Default;
					}
				}
				while (obj2 != null);
			}
			while ((object)a7W.Default != null)
			{
				do
				{
					try
					{
						j3J = (j3J)(object)a7W.Default;
					}
					catch
					{
						_ = (Nn9a)(object)a7W.Default;
					}
				}
				while ((object)a7W.Default != null);
			}
			if (uIntPtr == 0)
			{
				_ = (j3J)(object)a7W.Default;
			}
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (b1YL)(object)a7W.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (j3J)(object)a7W.Default;
					_ = (Jy1)(object)a7W.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				try
				{
					_ = (Ta6)(object)a7W.Default;
					goto end_IL_05fa;
				}
				finally
				{
					_ = (Zo8)(object)a7W.Default;
					goto end_IL_05fa;
				}
				end_IL_05fa:;
			}
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				qg = (Qg6)(object)a7W.Default;
			}
			else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (En1)(object)a7W.Default;
				_ = (Sm6)(object)a7W.Default;
				y8R = (y8R)(object)a7W.Default;
				_ = (a1B)(object)a7W.Default;
			}
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					a7W = null;
				}
				finally
				{
					s9EJ s9EJ = s9EJ;
					goto end_IL_0673;
				}
			}
			try
			{
				_ = (i0A1)(object)a7W.Default;
			}
			finally
			{
				_ = (En1)(object)a7W.Default;
				goto end_IL_0673;
			}
			end_IL_0673:;
		}
		nuint num = uIntPtr / checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)a7W.Default));
		uIntPtr = default(UIntPtr);
		if (checked(num + uIntPtr) == 0)
		{
			_ = (Jy1)(object)a7W.Default;
		}
		while (obj2 != null)
		{
			_ = (b6E)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		try
		{
			y8R = null;
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Em1)(object)a7W.Default;
					_ = (En1)(object)a7W.Default;
					_ = (Ta6)(object)a7W.Default;
				}
				finally
				{
					j3J = (j3J)(object)a7W.Default;
					goto end_IL_0702;
				}
			}
			try
			{
				_ = (i0A1)(object)a7W.Default;
			}
			finally
			{
				b1YL = (b1YL)(object)a7W.Default;
				goto end_IL_0702;
			}
			end_IL_0702:;
		}
		Em1 em;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Nn9a)(object)a7W.Default;
			}
			catch
			{
				em = (Em1)(object)a7W.Default;
				_ = (b6E)(object)a7W.Default;
			}
		}
		nn9a = (Nn9a)(object)a7W.Default;
		_ = (Sm6)(object)a7W.Default;
		_ = (Zo8)(object)a7W.Default;
		_ = (a1B)(object)a7W.Default;
		if (checked(uIntPtr + unchecked((nuint)(UIntPtr)a7W.Default)) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Jy1)(object)a7W.Default;
				}
			}
			finally
			{
				try
				{
					y8R = y8R;
				}
				finally
				{
					_ = (y8R)(object)a7W.Default;
					goto IL_0870;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				qg = (Qg6)(object)a7W.Default;
			}
			else
			{
				nn9a = nn9a;
				nm2f = null;
				nm2f = nm2f;
				_ = (En1)(object)a7W.Default;
			}
		}
		else
		{
			do
			{
				nn9a = (Nn9a)(object)a7W.Default;
			}
			while (obj2 != null);
		}
		goto IL_0870;
		IL_0323:
		UIntPtr num2 = (UIntPtr)a7W.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) * uIntPtr == 0 && uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					nn9a = nn9a;
					_ = (y8R)(object)a7W.Default;
					a1B obj12 = (a1B)(object)a7W.Default;
					a1B = null;
					a1B = obj12;
					_ = (Ta6)(object)a7W.Default;
				}
				finally
				{
					a7W = a7W;
					goto IL_0390;
				}
			}
			goto IL_0390;
		}
		IL_0a90:
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr - uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
				{
					b1YL = b1YL;
					_ = (Sm6)(object)a7W.Default;
					nn9a = (Nn9a)(object)a7W.Default;
				}
			}
			while (obj2 != null);
			while (obj2 != null)
			{
				try
				{
					b6E b6E = null;
				}
				catch
				{
					s9EJ s9EJ = (s9EJ)(object)a7W.Default;
				}
			}
			return;
		}
		IL_0199:
		checked
		{
			while (obj2 != null)
			{
				nuint num3 = uIntPtr;
				nuint num4 = uIntPtr;
				nuint num5 = uIntPtr;
				nuint num6 = uIntPtr * uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num3 - (num4 - (num5 - (num6 + uIntPtr))) * unchecked(uIntPtr / checked(unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default))) == 0)
				{
					if (unchecked((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Nn9a)(object)a7W.Default;
						continue;
					}
					y8R = y8R;
					y8R = y8R;
				}
				else
				{
					nm2f = (Nm2f)(object)a7W.Default;
					nm2f = nm2f;
					_ = (Em1)(object)a7W.Default;
				}
			}
			try
			{
				if (uIntPtr == 0)
				{
					while (obj2 != null)
					{
						_ = (b6E)(object)a7W.Default;
					}
				}
				else
				{
					i0A2 = i0A2;
					_ = a7W.Default;
					nm2f = nm2f;
					y8R = y8R;
				}
			}
			finally
			{
				while ((object)a7W.Default != null)
				{
					while (obj2 != null)
					{
						y8R = y8R;
						qg = qg;
						_ = (j3J)(object)a7W.Default;
					}
				}
				goto IL_0214;
			}
		}
		IL_0870:
		zo = (Zo8)(object)a7W.Default;
		En1 en = en;
		en = en;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (y8R)(object)a7W.Default;
		}
		else
		{
			try
			{
				try
				{
					_ = (i0A1)(object)a7W.Default;
				}
				catch
				{
					ln = ln;
				}
			}
			catch
			{
				try
				{
					b6E b6E = null;
				}
				catch
				{
					_ = (Jy1)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
					a7W = a7W;
				}
			}
		}
		_ = (Qg6)(object)a7W.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Zo8)(object)a7W.Default;
					_ = (i0A1)(object)a7W.Default;
					a7W = a7W;
				}
			}
			catch
			{
				_ = (Zo8)(object)a7W.Default;
			}
		}
		Ta6 ta = ta;
		ta = ta;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) * unchecked(uIntPtr / (nuint)(UIntPtr)a7W.Default) == 0)
				{
					if (unchecked((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Zo8)(object)a7W.Default;
					}
				}
				else
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						_ = a7W.Default;
						nm2f = nm2f;
					}
				}
			}
			else
			{
				try
				{
					try
					{
						nm2f = nm2f;
					}
					finally
					{
						_ = (Ln53)(object)a7W.Default;
						goto end_IL_09ca;
					}
					end_IL_09ca:;
				}
				catch
				{
					try
					{
						a7W = null;
						_ = (_003CModule_003E)(object)a7W.Default;
						sm = sm;
					}
					catch
					{
						en = null;
					}
				}
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr != 0 && uIntPtr == 0)
			{
				zo = (Zo8)(object)a7W.Default;
				_ = (b6E)(object)a7W.Default;
			}
			goto IL_0a90;
		}
		try
		{
			j3J = j3J;
		}
		finally
		{
			if ((nuint)(UIntPtr)a7W.Default / uIntPtr == 0)
			{
				_ = (i0A1)(object)a7W.Default;
			}
			goto IL_0a90;
		}
		IL_0214:
		nn9a = nn9a;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Jy1)(object)a7W.Default;
				_ = (Jy1)(object)a7W.Default;
			}
			while (obj2 != null || obj2 != null);
		}
		else
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						b6E b6E = b6E;
						b6E = b6E;
					}
				}
				else if (uIntPtr * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					_ = (_003CModule_003E)(object)a7W.Default;
					y8R = (y8R)(object)a7W.Default;
				}
			}
		}
		_ = (Sm6)(object)a7W.Default;
		em = null;
		em = null;
		ln = ln;
		_ = (Zo8)(object)a7W.Default;
		try
		{
			j3J obj20 = (j3J)(object)a7W.Default;
			j3J = j3J;
			j3J = obj20;
			_003CModule_003E = _003CModule_003E;
			_ = (Ta6)(object)a7W.Default;
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					i0A2 = i0A2;
				}
			}
			catch
			{
				try
				{
					_ = a7W.Default;
				}
				finally
				{
					y8R = y8R;
					goto end_IL_0307;
				}
				end_IL_0307:;
			}
			goto IL_0323;
		}
		IL_0390:
		UIntPtr num7 = (UIntPtr)a7W.Default;
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)num7) - (uIntPtr - uIntPtr)) == 0)
		{
			while (obj2 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / uIntPtr == 0)
				{
					b1YL = b1YL;
					b1YL = b1YL;
				}
				else
				{
					_ = (Sm6)(object)a7W.Default;
				}
			}
		}
		else
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					a1B = (a1B)(object)a7W.Default;
				}
			}
			catch
			{
				nn9a = nn9a;
				_ = (a1B)(object)a7W.Default;
				_ = (Ta6)(object)a7W.Default;
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
			}
			finally
			{
				_ = (b1YL)(object)a7W.Default;
				goto IL_047c;
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
				em = em;
				qg = null;
			}
			catch
			{
				sm = null;
			}
		}
		else
		{
			_ = (Qg6)(object)a7W.Default;
		}
		goto IL_047c;
	}

	static void Ed0m()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = (Jy1)(object)a7W.Default;
			obj = obj;
		}
		while (obj != null);
		do
		{
			try
			{
				while (obj != null)
				{
					_ = (Ln53)(object)a7W.Default;
				}
			}
			catch
			{
				_ = (s9EJ)(object)a7W.Default;
			}
		}
		while ((object)a7W.Default != null);
		s9EJ s9EJ = s9EJ;
		s9EJ = s9EJ;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		try
		{
			try
			{
				b6E obj3 = (b6E)(object)a7W.Default;
				b6E = b6E;
				b6E = obj3;
			}
			finally
			{
				do
				{
					_ = (b1YL)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
				goto end_IL_005a;
			}
			end_IL_005a:;
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					b1YL obj4 = (b1YL)(object)a7W.Default;
					b1YL = b1YL;
					b1YL = obj4;
				}
			}
			finally
			{
				while (obj != null)
				{
					a7W = a7W;
					a7W = a7W;
				}
				goto IL_00ce;
			}
		}
		IL_04ab:
		_ = (Ta6)(object)a7W.Default;
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		checked
		{
			if (unchecked(num / (nuint)(UIntPtr)a7W.Default) * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				do
				{
					_ = a7W.Default;
					zo = (Zo8)(object)a7W.Default;
				}
				while (obj != null);
			}
			try
			{
				while (obj != null)
				{
					try
					{
						_ = (s9EJ)(object)a7W.Default;
					}
					catch
					{
						_ = (Sm6)(object)a7W.Default;
					}
				}
			}
			finally
			{
				_ = (Jy1)(object)a7W.Default;
				b6E = b6E;
				goto IL_053e;
			}
		}
		IL_053e:
		do
		{
			_ = (a1B)(object)a7W.Default;
		}
		while (obj != null || obj != null);
		_ = (_003CModule_003E)(object)a7W.Default;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					a7W = a7W;
				}
				finally
				{
					_ = (j3J)(object)a7W.Default;
					goto IL_0638;
				}
			}
			try
			{
				_ = (b6E)(object)a7W.Default;
			}
			finally
			{
				_ = (Jy1)(object)a7W.Default;
				_ = (Ta6)(object)a7W.Default;
				goto IL_0638;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		try
		{
			num = default(UIntPtr);
			nuint num2 = num;
			num = default(UIntPtr);
			checked
			{
				if (num2 * num + (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default)) == 0)
				{
					em = em;
					_ = (_003CModule_003E)(object)a7W.Default;
					Nn9a nn9a = nn9a;
				}
			}
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (j3J)(object)a7W.Default;
			}
			else
			{
				_ = (y8R)(object)a7W.Default;
			}
		}
		goto IL_0638;
		IL_0638:
		if (num == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
			catch
			{
				j3J j3J = (j3J)(object)a7W.Default;
				j3J = j3J;
				_ = (Em1)(object)a7W.Default;
				_ = (Nm2f)(object)a7W.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		try
		{
			if ((nuint)(UIntPtr)a7W.Default / num != 0)
			{
				try
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				finally
				{
					y8R = y8R;
					goto end_IL_0684;
				}
			}
			try
			{
				_ = (i0A1)(object)a7W.Default;
				_ = a7W.Default;
				s9EJ = null;
			}
			catch
			{
				b6E = (b6E)(object)a7W.Default;
				i0A2 = i0A2;
			}
			end_IL_0684:;
		}
		catch
		{
			i0A2 = i0A2;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
		if (num == 0)
		{
			do
			{
				Nm2f nm2f = (Nm2f)(object)a7W.Default;
				_ = a7W.Default;
				jy = jy;
			}
			while (obj != null);
		}
		if (num == 0)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					zo = zo;
					_ = (Zo8)(object)a7W.Default;
				}
			}
			else
			{
				try
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				catch
				{
					a7W = a7W.Default;
				}
			}
		}
		else
		{
			nuint num3 = num;
			nuint num4 = num;
			nuint num5;
			checked
			{
				num5 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
			}
			nuint num6 = num4 / checked(num5 - num);
			UIntPtr num7 = (UIntPtr)a7W.Default;
			nuint num8 = num;
			nuint num9 = num;
			num = default(UIntPtr);
			if (num3 / checked(num6 + unchecked(checked(unchecked((nuint)num7) * (num8 * (num9 * num))) / (nuint)(UIntPtr)a7W.Default)) == 0 && num == 0)
			{
				_ = a7W.Default;
				_ = (a1B)(object)a7W.Default;
				j3J j3J = (j3J)(object)a7W.Default;
				_ = (s9EJ)(object)a7W.Default;
			}
		}
		_ = (b6E)(object)a7W.Default;
		y8R = (y8R)(object)a7W.Default;
		_ = (En1)(object)a7W.Default;
		_ = (Em1)(object)a7W.Default;
		En1 en;
		try
		{
			try
			{
				j3J j3J = null;
			}
			catch
			{
				_ = (j3J)(object)a7W.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Zo8)(object)a7W.Default;
				en = en;
			}
			catch
			{
				_ = (Jy1)(object)a7W.Default;
			}
		}
		b1YL = null;
		if (num == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = (En1)(object)a7W.Default;
				}
			}
			catch
			{
				try
				{
					_ = (b1YL)(object)a7W.Default;
				}
				finally
				{
					_ = (s9EJ)(object)a7W.Default;
					goto end_IL_08a8;
				}
				end_IL_08a8:;
			}
		}
		_ = (Jy1)(object)a7W.Default;
		_ = (Em1)(object)a7W.Default;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				while (obj != null)
				{
					Nn9a nn9a = (Nn9a)(object)a7W.Default;
				}
			}
			else
			{
				_ = (j3J)(object)a7W.Default;
			}
			_ = (Qg6)(object)a7W.Default;
			return;
		}
		IL_00ce:
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
			while (obj != null)
			{
				_ = (_003CModule_003E)(object)a7W.Default;
				qg = qg;
				qg = null;
				_ = (b6E)(object)a7W.Default;
			}
		}
		catch
		{
			num = num;
			if (num == 0)
			{
				em = (Em1)(object)a7W.Default;
				em = em;
			}
			else
			{
				_ = (_003CModule_003E)(object)a7W.Default;
				_ = (_003CModule_003E)(object)a7W.Default;
			}
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				nuint num10 = num;
				num = default(UIntPtr);
				if (num10 / num == 0)
				{
					_ = (Ta6)(object)a7W.Default;
					_ = (Ta6)(object)a7W.Default;
				}
				else
				{
					_ = (Qg6)(object)a7W.Default;
				}
			}
			finally
			{
				s9EJ = null;
				goto IL_018d;
			}
		}
		IL_018d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					y8R = null;
					y8R = null;
				}
				finally
				{
					ln = ln;
					ln = null;
					continue;
				}
			}
			while ((object)a7W.Default != null);
		}
		ln = (Ln53)(object)a7W.Default;
		em = em;
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					Nm2f nm2f = (Nm2f)(object)a7W.Default;
					nm2f = nm2f;
				}
				else
				{
					_ = a7W.Default;
				}
			}
			catch
			{
				try
				{
					_ = (b1YL)(object)a7W.Default;
				}
				finally
				{
					b6E = b6E;
					goto end_IL_020b;
				}
				end_IL_020b:;
			}
		}
		do
		{
			try
			{
				_ = a7W.Default;
			}
			finally
			{
				_ = (Ln53)(object)a7W.Default;
				_ = (b1YL)(object)a7W.Default;
				_ = (Nm2f)(object)a7W.Default;
				continue;
			}
		}
		while (obj != null || (object)a7W.Default != null);
		num = default(UIntPtr);
		checked
		{
			nuint num11 = num - num;
			num = default(UIntPtr);
			if (num11 - num == 0)
			{
				try
				{
					try
					{
						_ = (i0A1)(object)a7W.Default;
					}
					catch
					{
						_ = (i0A1)(object)a7W.Default;
					}
				}
				catch
				{
					b1YL = null;
					_ = (j3J)(object)a7W.Default;
				}
			}
			while (obj != null)
			{
				try
				{
					while (obj != null)
					{
						b6E = null;
					}
				}
				finally
				{
					_ = (Nn9a)(object)a7W.Default;
					continue;
				}
			}
			en = (En1)(object)a7W.Default;
			en = null;
			_ = (Zo8)(object)a7W.Default;
		}
		if (num == 0)
		{
			if (num == 0)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (b6E)(object)a7W.Default;
					b6E = null;
					b6E = b6E;
					s9EJ = null;
				}
				else
				{
					_ = (Zo8)(object)a7W.Default;
				}
			}
		}
		else
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					s9EJ = s9EJ;
				}
			}
			while ((object)a7W.Default != null);
		}
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Nn9a)(object)a7W.Default;
			}
			else
			{
				_ = a7W.Default;
			}
		}
		else if (num == 0)
		{
			zo = zo;
			zo = null;
		}
		else
		{
			_ = (s9EJ)(object)a7W.Default;
		}
		try
		{
			nuint num12 = num;
			UIntPtr num13 = (UIntPtr)a7W.Default;
			num = default(UIntPtr);
			checked
			{
				if (num12 * (unchecked((nuint)num13 / checked(num + num)) * (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked(num / (num / num)))) == 0)
				{
					try
					{
						_ = (Ln53)(object)a7W.Default;
					}
					catch
					{
						jy = null;
						jy = jy;
						a1B a1B = (a1B)(object)a7W.Default;
						a1B = a1B;
						_ = a7W.Default;
						_ = (s9EJ)(object)a7W.Default;
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			while (obj != null)
			{
				i0A2 = (i0A1)(object)a7W.Default;
			}
		}
		catch
		{
			if (num == 0)
			{
				Nm2f nm2f = null;
			}
		}
		try
		{
			while ((object)a7W.Default != null)
			{
				_ = (s9EJ)(object)a7W.Default;
			}
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (En1)(object)a7W.Default;
			}
			goto IL_04ab;
		}
	}

	static void p2G7()
	{
		Nn9a nn9a = nn9a;
		nn9a = null;
		_ = (Nn9a)(object)a7W.Default;
		_ = (b6E)(object)a7W.Default;
		_ = (i0A1)(object)a7W.Default;
		y8R y8R = y8R;
		y8R = y8R;
		UIntPtr uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		try
		{
			while ((object)a7W.Default != null)
			{
				uIntPtr = (UIntPtr)a7W.Default;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)a7W.Default;
					continue;
				}
				zo = zo;
				zo = zo;
			}
		}
		catch
		{
			_ = a7W.Default;
			_ = (Jy1)(object)a7W.Default;
		}
		_ = (Zo8)(object)a7W.Default;
		do
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		while ((object)a7W.Default != null);
		_ = (a1B)(object)a7W.Default;
		nn9a = nn9a;
		_ = (Nn9a)(object)a7W.Default;
		_ = (Zo8)(object)a7W.Default;
		object obj2;
		try
		{
			_ = (Jy1)(object)a7W.Default;
		}
		finally
		{
			do
			{
				_ = (j3J)(object)a7W.Default;
				obj2 = a7W.Default;
			}
			while (obj2 != null);
			goto IL_0113;
		}
		IL_0505:
		nn9a = nn9a;
		i0A1 i0A2 = (i0A1)(object)a7W.Default;
		_ = (Zo8)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		if (checked(uIntPtr - unchecked((nuint)(UIntPtr)a7W.Default)) == 0)
		{
			try
			{
				if ((nuint)(UIntPtr)a7W.Default / unchecked((nuint)default(UIntPtr)) == 0)
				{
					b6E b6E = b6E;
					b6E = null;
				}
				else
				{
					s9EJ = null;
				}
			}
			finally
			{
				try
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				finally
				{
					nn9a = (Nn9a)(object)a7W.Default;
					goto IL_060e;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		try
		{
			try
			{
				Em1 em = (Em1)(object)a7W.Default;
				em = em;
			}
			catch
			{
				_ = (En1)(object)a7W.Default;
			}
		}
		catch
		{
			try
			{
				b1YL = b1YL;
				_ = (_003CModule_003E)(object)a7W.Default;
				j3J = (j3J)(object)a7W.Default;
				j3J = j3J;
			}
			catch
			{
				_ = (Ta6)(object)a7W.Default;
			}
		}
		goto IL_060e;
		IL_03e1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
			do
			{
				if ((UIntPtr)a7W.Default != (UIntPtr)(nuint)0u)
				{
					_ = (i0A1)(object)a7W.Default;
					en = en;
					en = en;
					a1B a1B = (a1B)(object)a7W.Default;
					_ = (Qg6)(object)a7W.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
			}
			while ((object)a7W.Default != null);
		}
		catch
		{
			while (obj2 != null)
			{
				if (checked(unchecked((nuint)(UIntPtr)a7W.Default) + uIntPtr) / (nuint)(UIntPtr)a7W.Default == 0)
				{
					j3J = (j3J)(object)a7W.Default;
					ta = null;
					continue;
				}
				En1 en = (En1)(object)a7W.Default;
				_ = (_003CModule_003E)(object)a7W.Default;
				b1YL = b1YL;
				b1YL = null;
				_ = (b1YL)(object)a7W.Default;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				y8R = null;
				_ = (Qg6)(object)a7W.Default;
				Qg6 qg = (Qg6)(object)a7W.Default;
				qg = qg;
				ta = (Ta6)(object)a7W.Default;
			}
			else
			{
				_ = (b6E)(object)a7W.Default;
			}
		}
		finally
		{
			zo = zo;
			goto IL_0505;
		}
		IL_0721:
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					b1YL = b1YL;
				}
				finally
				{
					Em1 em = null;
					continue;
				}
			}
		}
		while (obj2 != null);
		try
		{
			_ = (s9EJ)(object)a7W.Default;
		}
		catch
		{
			s9EJ = s9EJ;
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				while (obj2 != null);
			}
			return;
		}
		finally
		{
			_ = (Ln53)(object)a7W.Default;
			return;
		}
		IL_0113:
		_ = (a1B)(object)a7W.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Ln53 ln = (Ln53)(object)a7W.Default;
			ln = ln;
			goto IL_017c;
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (a1B)(object)a7W.Default;
			}
		}
		finally
		{
			try
			{
				s9EJ = s9EJ;
				s9EJ = s9EJ;
			}
			finally
			{
				_ = (b1YL)(object)a7W.Default;
				goto IL_017c;
			}
		}
		IL_060e:
		while ((object)a7W.Default != null)
		{
			while (obj2 != null)
			{
				do
				{
					b6E b6E = (b6E)(object)a7W.Default;
				}
				while (obj2 != null);
			}
		}
		while ((object)a7W.Default != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		try
		{
			try
			{
				i0A2 = (i0A1)(object)a7W.Default;
				_ = (i0A1)(object)a7W.Default;
			}
			finally
			{
				try
				{
					a1B a1B = null;
				}
				finally
				{
					nn9a = null;
					j3J = j3J;
					i0A2 = (i0A1)(object)a7W.Default;
					goto end_IL_0626;
				}
			}
			end_IL_0626:;
		}
		catch
		{
			sm = sm;
		}
		do
		{
			if ((UIntPtr)a7W.Default != (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					j3J = (j3J)(object)a7W.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					zo = (Zo8)(object)a7W.Default;
				}
			}
		}
		while (obj2 != null);
		_003CModule_003E _003CModule_003E;
		try
		{
			b1YL = b1YL;
			_ = (Zo8)(object)a7W.Default;
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			}
			else
			{
				_ = (En1)(object)a7W.Default;
			}
			goto IL_0721;
		}
		IL_021c:
		try
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
				}
				finally
				{
					i0A2 = i0A2;
					i0A2 = i0A2;
					goto end_IL_021d;
				}
			}
			_ = (s9EJ)(object)a7W.Default;
			end_IL_021d:;
		}
		catch
		{
			_ = (En1)(object)a7W.Default;
		}
		try
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					ta = null;
				}
			}
			else if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)a7W.Default)) == 0)
			{
				y8R = (y8R)(object)a7W.Default;
			}
			else
			{
				_ = (Zo8)(object)a7W.Default;
				sm = sm;
				sm = sm;
				sm = (Sm6)(object)a7W.Default;
			}
		}
		ta = ta;
		_ = (Nn9a)(object)a7W.Default;
		_ = (b1YL)(object)a7W.Default;
		_ = (Jy1)(object)a7W.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (b6E)(object)a7W.Default;
			goto IL_0373;
		}
		try
		{
			try
			{
				_ = (b1YL)(object)a7W.Default;
			}
			finally
			{
				_ = (Qg6)(object)a7W.Default;
				goto end_IL_0324;
			}
			end_IL_0324:;
		}
		finally
		{
			while ((object)a7W.Default != null)
			{
				_ = (Zo8)(object)a7W.Default;
				y8R = null;
				y8R = null;
				_ = (b6E)(object)a7W.Default;
			}
			goto IL_0373;
		}
		IL_017c:
		_003CModule_003E = null;
		_003CModule_003E = _003CModule_003E;
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				try
				{
					j3J = j3J;
					j3J = j3J;
				}
				finally
				{
					try
					{
						_ = a7W.Default;
					}
					finally
					{
						_ = (Sm6)(object)a7W.Default;
						goto IL_021c;
					}
				}
			}
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				zo = null;
				_ = (s9EJ)(object)a7W.Default;
				ta = ta;
				ta = null;
			}
		}
		else
		{
			_ = a7W.Default;
			_ = (b6E)(object)a7W.Default;
		}
		goto IL_021c;
		IL_0373:
		while (obj2 != null)
		{
		}
		_ = (Sm6)(object)a7W.Default;
		try
		{
			if ((nuint)(UIntPtr)a7W.Default / uIntPtr / (nuint)(UIntPtr)a7W.Default == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
				while (obj2 != null)
				{
					a1B obj11 = (a1B)(object)a7W.Default;
					a1B = a1B;
					a1B = obj11;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				while ((object)a7W.Default != null)
				{
					_ = (i0A1)(object)a7W.Default;
				}
			}
			goto IL_03e1;
		}
	}
}
