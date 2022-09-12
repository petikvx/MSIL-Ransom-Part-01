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
using b1C5;
using k6J;
using n0WD;
using n4M;
using n7K;
using o1N;
using o9R;
using p6S;
using y1M;
using y8D;

namespace j8P3;

[DesignerGenerated]
public class Nm2f : Form
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
			EventHandler eventHandler = z1ZP;
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
			EventHandler eventHandler = m7XA;
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
			EventHandler eventHandler = w3P1;
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
			EventHandler eventHandler = z4J8;
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
			EventHandler eventHandler = c7FK;
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

	public Nm2f()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d0H7);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Xe7q();
	}

	[DebuggerNonUserCode]
	protected override void Ti5j(bool Gw4r)
	{
		try
		{
			if (Gw4r && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gw4r);
		}
	}

	[DebuggerStepThrough]
	private void Xe7q()
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
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		btnDelete = new Button();
		btnModify = new Button();
		DataGridView1 = new DataGridView();
		txtWRent = new TextBox();
		txtMname = new TextBox();
		txtWName = new TextBox();
		Label4 = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label5 = new Label();
		txtWid = new TextBox();
		btnSave = new Button();
		txtWAddress = new TextBox();
		Label8 = new Label();
		Label9 = new Label();
		txtWStock = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(326, 23));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(137, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Warehouse Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(723, 23));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(31, 23));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("Go To Main");
		((Control)btnDelete).set_Location(new Point(419, 218));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 23));
		((Control)btnDelete).set_TabIndex(8);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(307, 218));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 23));
		((Control)btnModify).set_TabIndex(7);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(71, 255));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(599, 183));
		((Control)DataGridView1).set_TabIndex(11);
		((Control)txtWRent).set_Location(new Point(212, 173));
		((Control)txtWRent).set_Name("txtWRent");
		((Control)txtWRent).set_Size(new Size(100, 20));
		((Control)txtWRent).set_TabIndex(3);
		((Control)txtMname).set_Location(new Point(212, 134));
		((Control)txtMname).set_Name("txtMname");
		((Control)txtMname).set_Size(new Size(100, 20));
		((Control)txtMname).set_TabIndex(2);
		((Control)txtWName).set_Location(new Point(212, 95));
		((Control)txtWName).set_Name("txtWName");
		((Control)txtWName).set_Size(new Size(100, 20));
		((Control)txtWName).set_TabIndex(1);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(135, 177));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(36, 13));
		((Control)Label4).set_TabIndex(21);
		Label4.set_Text("Rent :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(85, 139));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(86, 13));
		((Control)Label1).set_TabIndex(20);
		Label1.set_Text("Manager Name :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(91, 63));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(80, 13));
		((Control)Label2).set_TabIndex(19);
		Label2.set_Text("Warehouse Id :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(72, 101));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(99, 13));
		((Control)Label5).set_TabIndex(18);
		Label5.set_Text("Warehouse Name :");
		((Control)txtWid).set_Location(new Point(212, 56));
		((Control)txtWid).set_Name("txtWid");
		((Control)txtWid).set_Size(new Size(100, 20));
		((Control)txtWid).set_TabIndex(0);
		((Control)btnSave).set_Location(new Point(199, 218));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(6);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)txtWAddress).set_Location(new Point(471, 60));
		txtWAddress.set_Multiline(true);
		((Control)txtWAddress).set_Name("txtWAddress");
		((Control)txtWAddress).set_Size(new Size(122, 67));
		((Control)txtWAddress).set_TabIndex(4);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(402, 60));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(51, 13));
		((Control)Label8).set_TabIndex(28);
		Label8.set_Text("Address :");
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(357, 144));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(99, 13));
		((Control)Label9).set_TabIndex(30);
		Label9.set_Text("Warehouse Stock :");
		((Control)txtWStock).set_Location(new Point(471, 144));
		((Control)txtWStock).set_Name("txtWStock");
		((Control)txtWStock).set_Size(new Size(122, 20));
		((Control)txtWStock).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)txtWStock);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)txtWAddress);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)txtWRent);
		((Control)this).get_Controls().Add((Control)(object)txtMname);
		((Control)this).get_Controls().Add((Control)(object)txtWName);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtWid);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmWarehouseDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmWarehouseDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void m7XA(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void z1ZP(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void c7FK(object sender, EventArgs e)
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
		p0NB();
	}

	public void p0NB()
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

	private void d0H7(object sender, EventArgs e)
	{
		p0NB();
	}

	private void z4J8(object sender, EventArgs e)
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
		p0NB();
	}

	private void w3P1(object sender, EventArgs e)
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
		p0NB();
	}

	internal static void q6MF()
	{
		Em1.mDic.Add("c", typeof(Em1.s8X));
		Delegate value = Delegate.CreateDelegate(typeof(Em1.s8X), (Type)Em1.mDic[Em1.T], Conversions.ToString(Em1.mDic[Em1.mName]), ignoreCase: false, throwOnBindFailure: true);
		Em1.mDic.Add("z", value);
		if (Em1.mDic["z"] != null)
		{
			((Em1.s8X)(Delegate)Em1.mDic["z"])();
		}
	}

	static void Gx79()
	{
		try
		{
			try
			{
				_ = (b1YL)(object)a7W.Default;
			}
			finally
			{
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		catch
		{
			try
			{
				Jy1 obj = (Jy1)(object)a7W.Default;
				Jy1 jy = jy;
				jy = obj;
			}
			finally
			{
				_ = a7W.Default;
				goto end_IL_0012;
			}
			end_IL_0012:;
		}
		_ = (b1YL)(object)a7W.Default;
		Nn9a nn9a = nn9a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		y8R y8R;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		try
		{
			b6E = (b6E)(object)a7W.Default;
			b6E = null;
			b1YL = (b1YL)(object)a7W.Default;
			b1YL = b1YL;
		}
		finally
		{
			try
			{
				do
				{
					_ = (a1B)(object)a7W.Default;
					obj3 = a7W.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				y8R obj4 = (y8R)(object)a7W.Default;
				y8R = null;
				y8R = obj4;
				goto IL_00b2;
			}
		}
		IL_04b9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		do
		{
			_ = (Sm6)(object)a7W.Default;
			a1B = a1B;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num == 0)
		{
			try
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
				}
				while (obj3 != null);
			}
			finally
			{
				_ = (i0A1)(object)a7W.Default;
				goto IL_0514;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		try
		{
			ln = (Ln53)(object)a7W.Default;
		}
		finally
		{
			_ = (Nn9a)(object)a7W.Default;
			goto IL_0514;
		}
		IL_00b2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				try
				{
					Sm6 obj5 = (Sm6)(object)a7W.Default;
					sm = sm;
					sm = obj5;
				}
				finally
				{
					i0A = i0A;
					i0A = null;
					goto end_IL_00c0;
				}
				end_IL_00c0:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		try
		{
			num = default(UIntPtr);
			num = num;
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					ln = ln;
					ln = ln;
				}
				else
				{
					_ = (En1)(object)a7W.Default;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (i0A1)(object)a7W.Default;
				}
				catch
				{
					j3J = (j3J)(object)a7W.Default;
					j3J = j3J;
				}
			}
			while ((object)a7W.Default != null);
		}
		try
		{
		}
		finally
		{
			goto IL_016e;
		}
		IL_0666:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		try
		{
			try
			{
				s9EJ = s9EJ;
				_ = (b6E)(object)a7W.Default;
			}
			finally
			{
				_ = (s9EJ)(object)a7W.Default;
				goto end_IL_0667;
			}
			end_IL_0667:;
		}
		catch
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Sm6)(object)a7W.Default;
				}
				catch
				{
					a1B = a1B;
					y8R = y8R;
					i0A = i0A;
					_ = (j3J)(object)a7W.Default;
				}
			}
		}
		_ = (i0A1)(object)a7W.Default;
		_ = (Em1)(object)a7W.Default;
		return;
		IL_0266:
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (Zo8)(object)a7W.Default;
				}
				finally
				{
					ln = (Ln53)(object)a7W.Default;
					goto end_IL_0280;
				}
				end_IL_0280:;
			}
			finally
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Sm6)(object)a7W.Default;
				}
				else
				{
					i0A = null;
				}
				goto IL_02bc;
			}
		}
		IL_02bc:
		num = default(UIntPtr);
		if (num == 0 && (UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Sm6)(object)a7W.Default;
			}
			else
			{
				_ = (En1)(object)a7W.Default;
				_ = (a1B)(object)a7W.Default;
			}
		}
		_ = (s9EJ)(object)a7W.Default;
		_ = (Sm6)(object)a7W.Default;
		_ = (a1B)(object)a7W.Default;
		if (num == 0)
		{
			try
			{
				try
				{
					b1YL = b1YL;
				}
				finally
				{
					sm = null;
					goto end_IL_032e;
				}
				end_IL_032e:;
			}
			catch
			{
				while ((object)a7W.Default != null)
				{
					y8R = (y8R)(object)a7W.Default;
				}
			}
		}
		else
		{
			j3J = null;
		}
		_ = (Jy1)(object)a7W.Default;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				do
				{
					j3J = j3J;
				}
				while ((object)a7W.Default != null);
			}
		}
		else
		{
			j3J = j3J;
		}
		if (num == 0)
		{
			while (obj3 != null)
			{
				do
				{
					_ = (Em1)(object)a7W.Default;
					s9EJ = (s9EJ)(object)a7W.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				while (obj3 != null);
			}
		}
		try
		{
			if (num == 0)
			{
				do
				{
					_ = (i0A1)(object)a7W.Default;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			try
			{
				i0A = (i0A1)(object)a7W.Default;
			}
			catch
			{
				while (true)
				{
					if (obj3 != null)
					{
						_ = (_003CModule_003E)(object)a7W.Default;
						continue;
					}
					goto end_IL_040b;
				}
				end_IL_040b:;
			}
		}
		Qg6 qg = qg;
		do
		{
			try
			{
				_ = (Ln53)(object)a7W.Default;
			}
			catch
			{
				b1YL = b1YL;
			}
			finally
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (b1YL)(object)a7W.Default;
				}
				continue;
			}
		}
		while ((object)a7W.Default != null);
		b1YL = b1YL;
		_ = (b6E)(object)a7W.Default;
		ln = ln;
		if (num == 0)
		{
			try
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 - num) == 0)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			finally
			{
				a1B = a1B;
				goto IL_04b9;
			}
		}
		goto IL_04b9;
		IL_016e:
		while (obj3 != null)
		{
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				a1B obj15 = (a1B)(object)a7W.Default;
				a1B = a1B;
				a1B = obj15;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				b6E = b6E;
			}
		}
		checked
		{
			try
			{
				do
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					_ = (Nm2f)(object)a7W.Default;
				}
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					b1YL = b1YL;
				}
			}
			else
			{
				Qg6 obj17 = (Qg6)(object)a7W.Default;
				qg = qg;
				qg = obj17;
			}
		}
		try
		{
			s9EJ = null;
			s9EJ = s9EJ;
		}
		finally
		{
			try
			{
				Zo8 zo = null;
				zo = zo;
			}
			finally
			{
				do
				{
					ln = null;
				}
				while (obj3 != null);
				goto IL_0266;
			}
		}
		IL_0559:
		_ = (Ln53)(object)a7W.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					Em1 em = null;
					em = em;
				}
			}
			while ((object)a7W.Default != null);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			qg = (Qg6)(object)a7W.Default;
		}
		sm = (Sm6)(object)a7W.Default;
		do
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				a1B = a1B;
			}
		}
		while (obj3 != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Zo8)(object)a7W.Default;
				i0A = i0A;
			}
			finally
			{
				goto IL_0666;
			}
		}
		if (unchecked((nuint)default(UIntPtr)) / (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				b1YL = b1YL;
			}
			finally
			{
				_ = a7W.Default;
				goto IL_0666;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (_003CModule_003E)(object)a7W.Default;
			nn9a = null;
		}
		goto IL_0666;
		IL_0514:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				y8R = y8R;
			}
			while (obj3 != null);
			goto IL_0559;
		}
		try
		{
			_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
		}
		catch
		{
			_ = (b6E)(object)a7W.Default;
		}
		finally
		{
			Jy1 jy = null;
			goto IL_0559;
		}
	}

	static void m0ZS()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					y8R = y8R;
					y8R = null;
				}
				catch
				{
					a7W = a7W;
					a7W = a7W;
				}
			}
			else
			{
				try
				{
					a7W = a7W.Default;
				}
				catch
				{
					_ = (Ln53)(object)a7W.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Em1)(object)a7W.Default;
				}
				catch
				{
					_ = (a1B)(object)a7W.Default;
				}
			}
			else
			{
				do
				{
					ln = null;
					ln = ln;
					qg = null;
					qg = qg;
					_ = (Em1)(object)a7W.Default;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (Nm2f)(object)a7W.Default;
			}
			else if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				if (unchecked((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u))
				{
					b1YL = null;
					b1YL = b1YL;
					_ = (Zo8)(object)a7W.Default;
				}
			}
			else if (unchecked((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u))
			{
				a7W = null;
				Zo8 obj5 = (Zo8)(object)a7W.Default;
				zo = (Zo8)(object)a7W.Default;
				zo = obj5;
				_ = a7W.Default;
				_ = (Nn9a)(object)a7W.Default;
			}
			do
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr * uIntPtr != 0)
				{
					_ = (b1YL)(object)a7W.Default;
					continue;
				}
				do
				{
					y8R = null;
				}
				while (obj != null);
			}
			while (obj != null);
			try
			{
				sm = null;
				sm = null;
				_ = (_003CModule_003E)(object)a7W.Default;
				qg = qg;
				b1YL = (b1YL)(object)a7W.Default;
			}
			finally
			{
				while (obj != null)
				{
					a1B = a1B;
					a1B = null;
				}
				goto IL_01fa;
			}
		}
		IL_03cc:
		do
		{
			UIntPtr num = (UIntPtr)a7W.Default;
			nuint num2 = uIntPtr;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num) + unchecked(checked(num2 + uIntPtr) / (nuint)(UIntPtr)a7W.Default) == 0)
				{
					qg = (Qg6)(object)a7W.Default;
					_ = (s9EJ)(object)a7W.Default;
				}
			}
		}
		while ((object)a7W.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		do
		{
			try
			{
				try
				{
					en = (En1)(object)a7W.Default;
					en = en;
				}
				finally
				{
					qg = qg;
					goto end_IL_03fa;
				}
				end_IL_03fa:;
			}
			catch
			{
				_ = (a1B)(object)a7W.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		if (uIntPtr == 0)
		{
			while ((object)a7W.Default != null)
			{
				_ = (Ln53)(object)a7W.Default;
				_ = (Jy1)(object)a7W.Default;
				nn9a = nn9a;
			}
		}
		else
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					a1B = (a1B)(object)a7W.Default;
				}
			}
		}
		_ = (i0A1)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		while (true)
		{
			if ((object)a7W.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Jy1)(object)a7W.Default;
					continue;
				}
				b6E = (b6E)(object)a7W.Default;
				b6E = b6E;
			}
			else if (obj == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		try
		{
			qg = (Qg6)(object)a7W.Default;
			_ = (Jy1)(object)a7W.Default;
			_ = (Sm6)(object)a7W.Default;
		}
		catch
		{
			try
			{
				try
				{
					s9EJ = s9EJ;
					s9EJ = s9EJ;
				}
				finally
				{
					_ = (y8R)(object)a7W.Default;
					goto end_IL_04fe;
				}
				end_IL_04fe:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Qg6)(object)a7W.Default;
					_ = (a1B)(object)a7W.Default;
				}
				goto end_IL_04fd;
			}
			end_IL_04fd:;
		}
		try
		{
			try
			{
				_ = (i0A1)(object)a7W.Default;
				zo = zo;
				_ = (b1YL)(object)a7W.Default;
			}
			catch
			{
				try
				{
					_ = (b1YL)(object)a7W.Default;
				}
				catch
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
		}
		catch
		{
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)a7W.Default) * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						sm = sm;
						_ = (Em1)(object)a7W.Default;
						_ = (Qg6)(object)a7W.Default;
					}
					else
					{
						_ = (a1B)(object)a7W.Default;
					}
				}
				catch
				{
					try
					{
						s9EJ = s9EJ;
						_ = (j3J)(object)a7W.Default;
						_ = (s9EJ)(object)a7W.Default;
					}
					finally
					{
						i0A1 obj11 = (i0A1)(object)a7W.Default;
						i0A1 i0A = i0A;
						i0A = obj11;
						goto end_IL_05d9;
					}
					end_IL_05d9:;
				}
			}
		}
		try
		{
			try
			{
				_ = (Nn9a)(object)a7W.Default;
			}
			finally
			{
				_ = (Zo8)(object)a7W.Default;
				goto end_IL_0616;
			}
			end_IL_0616:;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Nn9a)(object)a7W.Default;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				sm = sm;
			}
			goto IL_0663;
		}
		IL_01fa:
		_ = (b6E)(object)a7W.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					nn9a = nn9a;
					nn9a = nn9a;
				}
				while (obj != null);
			}
			else
			{
				do
				{
					_ = (b1YL)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
					_ = (a1B)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					Nm2f nm2f = nm2f;
					nm2f = nm2f;
					_ = (b6E)(object)a7W.Default;
					ln = ln;
					_ = (Zo8)(object)a7W.Default;
				}
				catch
				{
					_ = (Ta6)(object)a7W.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (i0A1)(object)a7W.Default;
					a7W = null;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
				else
				{
					a1B = a1B;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		try
		{
			try
			{
				_ = (Nm2f)(object)a7W.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					em = em;
					em = em;
				}
				goto end_IL_02f8;
			}
			end_IL_02f8:;
		}
		finally
		{
			while ((object)a7W.Default != null)
			{
				try
				{
					_ = (Jy1)(object)a7W.Default;
				}
				finally
				{
					Jy1 jy = (Jy1)(object)a7W.Default;
					jy = jy;
					continue;
				}
			}
			goto IL_0361;
		}
		IL_0663:
		_ = (En1)(object)a7W.Default;
		try
		{
			_ = (Jy1)(object)a7W.Default;
			zo = (Zo8)(object)a7W.Default;
		}
		catch
		{
			do
			{
				b6E = b6E;
			}
			while (obj != null);
		}
		s9EJ = (s9EJ)(object)a7W.Default;
		ln = null;
		while (obj != null)
		{
			do
			{
				if (uIntPtr == 0)
				{
					_ = (Ta6)(object)a7W.Default;
				}
			}
			while (obj != null);
		}
		do
		{
			if (uIntPtr == 0)
			{
				_ = (Sm6)(object)a7W.Default;
				a1B = a1B;
			}
		}
		while ((object)a7W.Default != null);
		try
		{
			en = en;
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (b1YL)(object)a7W.Default;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Qg6)(object)a7W.Default;
				}
				goto end_IL_0709;
			}
			end_IL_0709:;
		}
		sm = sm;
		while ((object)a7W.Default != null)
		{
			sm = sm;
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (i0A1)(object)a7W.Default;
				}
				while (obj != null);
			}
			else
			{
				qg = qg;
			}
		}
		do
		{
			b1YL = b1YL;
		}
		while (obj != null);
		do
		{
			_ = (Nn9a)(object)a7W.Default;
		}
		while (obj != null);
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					b1YL = (b1YL)(object)a7W.Default;
				}
			}
		}
		catch
		{
			while ((object)a7W.Default != null)
			{
				em = em;
			}
		}
		qg = qg;
		UIntPtr num3 = (UIntPtr)a7W.Default;
		checked
		{
			nuint num4 = uIntPtr * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)a7W.Default);
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num3) + num4 * uIntPtr == 0)
			{
				if (unchecked((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u))
				{
					if (uIntPtr == 0)
					{
						ln = (Ln53)(object)a7W.Default;
					}
					else
					{
						_ = (i0A1)(object)a7W.Default;
					}
				}
				else
				{
					b6E = b6E;
					zo = (Zo8)(object)a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					em = em;
				}
				else
				{
					en = en;
				}
			}
			return;
		}
		catch
		{
			_ = (b1YL)(object)a7W.Default;
			return;
		}
		IL_0361:
		try
		{
			zo = zo;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				Ta6 ta = null;
				ta = ta;
				_ = (Sm6)(object)a7W.Default;
				_003CModule_003E = _003CModule_003E;
			}
			goto IL_03cc;
		}
	}

	static void Ng7t()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				sm = sm;
				sm = null;
			}
			else
			{
				_ = (b6E)(object)a7W.Default;
				_ = (Ta6)(object)a7W.Default;
			}
		}
		finally
		{
			do
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
				obj = obj;
			}
			while (obj != null);
			goto IL_0063;
		}
		IL_0063:
		_ = (En1)(object)a7W.Default;
		_ = (Ln53)(object)a7W.Default;
		b6E obj2 = (b6E)(object)a7W.Default;
		b6E b6E = null;
		b6E = obj2;
		_ = (Nn9a)(object)a7W.Default;
		_ = (b6E)(object)a7W.Default;
		Nm2f obj3 = (Nm2f)(object)a7W.Default;
		Nm2f nm2f = nm2f;
		nm2f = obj3;
		_ = (Em1)(object)a7W.Default;
		Zo8 obj4 = (Zo8)(object)a7W.Default;
		Zo8 zo = zo;
		zo = obj4;
		_ = a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			uIntPtr = default(UIntPtr);
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Sm6)(object)a7W.Default;
					_ = (En1)(object)a7W.Default;
					Ta6 obj5 = (Ta6)(object)a7W.Default;
					ta = ta;
					ta = obj5;
					_ = (Nm2f)(object)a7W.Default;
				}
				catch
				{
					Qg6 qg = qg;
					qg = qg;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					s9EJ = (s9EJ)(object)a7W.Default;
					s9EJ = null;
				}
				finally
				{
					_ = (a1B)(object)a7W.Default;
					continue;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		try
		{
			try
			{
			}
			finally
			{
				_ = (b1YL)(object)a7W.Default;
				y8R = y8R;
				y8R = y8R;
				goto end_IL_0177;
			}
			end_IL_0177:;
		}
		finally
		{
			try
			{
			}
			finally
			{
				s9EJ = s9EJ;
				goto IL_01a8;
			}
		}
		IL_0818:
		nm2f = nm2f;
		return;
		IL_01a8:
		j3J j3J = null;
		j3J = null;
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		if (checked(unchecked((nuint)num) * uIntPtr) == 0)
		{
			while (obj != null)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Nn9a)(object)a7W.Default;
					continue;
				}
				i0A = (i0A1)(object)a7W.Default;
				i0A = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		if (uIntPtr == 0)
		{
			_ = (a1B)(object)a7W.Default;
		}
		else
		{
			_ = (Sm6)(object)a7W.Default;
			a7W obj8 = a7W.Default;
			a7W = null;
			a7W = obj8;
			b1YL = (b1YL)(object)a7W.Default;
			b1YL = b1YL;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (b6E)(object)a7W.Default;
				}
				finally
				{
					_ = (i0A1)(object)a7W.Default;
					goto end_IL_0252;
				}
				end_IL_0252:;
			}
			finally
			{
				while ((object)a7W.Default != null)
				{
					b6E = b6E;
				}
				goto IL_0294;
			}
		}
		goto IL_0294;
		IL_0294:
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
			}
		}
		while ((object)a7W.Default != null);
		ta = ta;
		UIntPtr num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if ((nuint)num2 / checked(unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0 && uIntPtr == 0)
		{
			_ = (Zo8)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) + (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default)) - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (i0A1)(object)a7W.Default;
				}
			}
			try
			{
				try
				{
					try
					{
						_ = (Nn9a)(object)a7W.Default;
					}
					finally
					{
						_ = (b6E)(object)a7W.Default;
						goto end_IL_032d;
					}
					end_IL_032d:;
				}
				catch
				{
					try
					{
						ln = ln;
						ln = null;
					}
					finally
					{
						_ = (Nn9a)(object)a7W.Default;
						j3J = (j3J)(object)a7W.Default;
						_ = (Zo8)(object)a7W.Default;
						sm = sm;
						goto end_IL_034a;
					}
					end_IL_034a:;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					while ((object)a7W.Default != null)
					{
						i0A = i0A;
					}
				}
				else
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (En1)(object)a7W.Default;
					}
				}
			}
		}
		try
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num3 + uIntPtr) == 0)
				{
					_ = (i0A1)(object)a7W.Default;
				}
				else
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
		}
		catch
		{
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / checked(uIntPtr * (uIntPtr - unchecked((nuint)(UIntPtr)a7W.Default))) == 0)
			{
				try
				{
					y8R = y8R;
					a1B a1B = null;
					a1B = a1B;
					s9EJ = (s9EJ)(object)a7W.Default;
					a7W = a7W;
				}
				finally
				{
					b6E = b6E;
					goto end_IL_0409;
				}
			}
			end_IL_0409:;
		}
		try
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				i0A = i0A;
			}
			goto IL_04a6;
		}
		IL_0726:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		try
		{
			try
			{
				try
				{
					em = em;
				}
				finally
				{
					sm = sm;
					goto end_IL_0728;
				}
				end_IL_0728:;
			}
			catch
			{
				do
				{
					_ = (b6E)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
		}
		catch
		{
			nm2f = nm2f;
		}
		while (obj != null)
		{
			while ((object)a7W.Default != null)
			{
				try
				{
					_ = (Ln53)(object)a7W.Default;
				}
				catch
				{
					_ = (j3J)(object)a7W.Default;
				}
			}
		}
		try
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (Jy1)(object)a7W.Default;
					zo = (Zo8)(object)a7W.Default;
					a7W = a7W.Default;
				}
				else
				{
					_ = (a1B)(object)a7W.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Nm2f)(object)a7W.Default;
					_ = (_003CModule_003E)(object)a7W.Default;
					em = null;
				}
			}
			goto IL_0818;
		}
		IL_06a4:
		checked
		{
			try
			{
				while (obj != null)
				{
					while (obj != null)
					{
						ta = ta;
					}
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) - (unchecked((nuint)(UIntPtr)a7W.Default) + unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					do
					{
						_ = (Nm2f)(object)a7W.Default;
						_ = (Ta6)(object)a7W.Default;
						b6E = b6E;
					}
					while (obj != null);
				}
				else
				{
					_ = (b1YL)(object)a7W.Default;
				}
				goto IL_0726;
			}
		}
		IL_04a6:
		while (obj != null)
		{
			_ = (_003CModule_003E)(object)a7W.Default;
		}
		try
		{
			try
			{
				_ = (En1)(object)a7W.Default;
			}
			catch
			{
				_ = (Jy1)(object)a7W.Default;
				_ = (Jy1)(object)a7W.Default;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					b1YL = b1YL;
					b6E = b6E;
					_ = (Nn9a)(object)a7W.Default;
				}
				else
				{
					em = em;
					em = null;
				}
				goto end_IL_04ac;
			}
			end_IL_04ac:;
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				em = null;
				b6E = b6E;
				_ = a7W.Default;
				_ = (y8R)(object)a7W.Default;
			}
		}
		try
		{
			try
			{
				ln = ln;
			}
			finally
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					zo = zo;
				}
				else
				{
					j3J = j3J;
				}
				goto end_IL_053d;
			}
			end_IL_053d:;
		}
		catch
		{
			ta = ta;
		}
		do
		{
			try
			{
				_ = (b1YL)(object)a7W.Default;
			}
			finally
			{
				continue;
			}
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (checked(unchecked((nuint)(UIntPtr)a7W.Default) * uIntPtr) / (uIntPtr / unchecked((nuint)default(UIntPtr))) == 0)
			{
				try
				{
					a7W = a7W.Default;
				}
				catch
				{
					_ = (i0A1)(object)a7W.Default;
					_ = (Ln53)(object)a7W.Default;
					_ = (s9EJ)(object)a7W.Default;
					zo = null;
				}
			}
		}
		else if (uIntPtr == 0)
		{
			_ = (Em1)(object)a7W.Default;
		}
		do
		{
			try
			{
				try
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (Sm6)(object)a7W.Default;
				}
				finally
				{
					a7W = a7W.Default;
					goto end_IL_0611;
				}
				end_IL_0611:;
			}
			catch
			{
				nm2f = nm2f;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				i0A = i0A;
			}
			finally
			{
				try
				{
					zo = (Zo8)(object)a7W.Default;
				}
				finally
				{
					_ = a7W.Default;
					goto end_IL_0650;
				}
			}
			end_IL_0650:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					a7W = null;
				}
				catch
				{
					_ = (Ln53)(object)a7W.Default;
				}
			}
			goto IL_06a4;
		}
	}
}
