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
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xs5;
using a9D;
using c4ZK;
using e6H;
using j3B;
using q8B;
using s1Y;
using t5D;
using x9E1;

namespace Xo8;

[DesignerGenerated]
public class Br2 : Form
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
			EventHandler eventHandler = y1D;
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
			EventHandler eventHandler = s9B;
			Label label = _Label7;
			Label obj = label;
			Ta8.char_0[35] = (char)((Ta8.char_0[35] | Ta8.char_0[251]) & '\u008d');
			if (obj != null)
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
			EventHandler eventHandler = s3Q;
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
			EventHandler eventHandler = k8D;
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
			EventHandler eventHandler = Lp2;
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

	public Br2()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)e2E);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		f0Q();
	}

	[DebuggerNonUserCode]
	protected override void Ek1(bool f0X)
	{
		try
		{
			bool num = f0X && components != null;
			c0B.int_0[234] = (c0B.int_0[234] ^ c0B.int_0[194]) & 0xD0;
			if (num)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f0X);
		}
	}

	[DebuggerStepThrough]
	private void f0Q()
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

	private void s9B(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void y1D(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Lp2(object sender, EventArgs e)
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
		m0K();
	}

	public void m0K()
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

	private void e2E(object sender, EventArgs e)
	{
		m0K();
	}

	private void k8D(object sender, EventArgs e)
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
		m0K();
	}

	private void s3Q(object sender, EventArgs e)
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
		m0K();
	}

	internal static void Dw0()
	{
		Ng67.mDic.Add("c", typeof(Ng67.Kc9));
		Delegate value = Delegate.CreateDelegate(typeof(Ng67.Kc9), (Type)Ng67.mDic[Ng67.T], Conversions.ToString(Ng67.mDic[Ng67.mName]), ignoreCase: false, throwOnBindFailure: true);
		Ng67.mDic.Add("z", value);
		if (Ng67.mDic["z"] != null)
		{
			((Ng67.Kc9)(Delegate)Ng67.mDic["z"])();
		}
		c0B.int_0[209] = (c0B.int_0[209] - c0B.int_0[490]) & 0xB4;
	}

	static void y5G()
	{
		UIntPtr uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		if (uIntPtr == 0)
		{
			_ = (Be5)(object)j5Y1.Default;
		}
		else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				t1P = t1P;
				t1P = null;
			}
			catch
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
		}
		else
		{
			_ = (c0B)(object)j5Y1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta8 ta);
		try
		{
			_ = (Ma6)(object)j5Y1.Default;
		}
		finally
		{
			try
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
			catch
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
			finally
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 != null)
					{
						_ = (z1J)(object)j5Y1.Default;
						Ta8 obj4 = (Ta8)(object)j5Y1.Default;
						ta = ta;
						ta = obj4;
						gw = null;
						gw = null;
						continue;
					}
					break;
				}
				goto IL_00c6;
			}
		}
		IL_0169:
		uIntPtr = default(UIntPtr);
		checked
		{
			nuint num = uIntPtr + uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num - uIntPtr == 0)
			{
				_ = (c0B)(object)j5Y1.Default;
			}
			else
			{
				while (obj3 != null)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Ws0)(object)j5Y1.Default;
						_ = (Tg0e)(object)j5Y1.Default;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		do
		{
			if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (z1J)(object)j5Y1.Default;
					w5D = w5D;
					w5D = w5D;
				}
				while (obj3 != null);
				continue;
			}
			do
			{
				ma = null;
				ma = ma;
				_ = (n4NE)(object)j5Y1.Default;
				ws = ws;
				ws = ws;
				ja = ja;
				ja = ja;
			}
			while ((object)j5Y1.Default != null);
		}
		while ((object)j5Y1.Default != null);
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				do
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (k8NS)j5Y1.Default;
		}
		while (obj3 != null)
		{
			uIntPtr = default(UIntPtr);
			nuint num2 = checked(uIntPtr - uIntPtr);
			uIntPtr = default(UIntPtr);
			if (num2 / uIntPtr == 0)
			{
				while (obj3 != null)
				{
					_ = (n4NE)(object)j5Y1.Default;
					_ = (Ng67)(object)j5Y1.Default;
					_ = (Tg0e)(object)j5Y1.Default;
					gw = gw;
				}
			}
		}
		do
		{
			_ = (n4NE)(object)j5Y1.Default;
			_ = (y9T)(object)j5Y1.Default;
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			try
			{
				_ = (y9T)(object)j5Y1.Default;
			}
			finally
			{
				_ = (Br2)(object)j5Y1.Default;
				continue;
			}
		}
		_ = (Ta8)(object)j5Y1.Default;
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					nuint num3 = uIntPtr;
					uIntPtr = default(UIntPtr);
					nuint num4 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num3 - unchecked(num4 / uIntPtr) * uIntPtr == 0)
					{
						_ = (c0B)(object)j5Y1.Default;
					}
				}
				finally
				{
					try
					{
						_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
						_003CModule_003E = _003CModule_003E;
					}
					catch
					{
						_ = (y9T)(object)j5Y1.Default;
					}
					goto IL_03b2;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (t1P)(object)j5Y1.Default;
			}
			goto IL_03b2;
		}
		IL_0705:
		Be5 be;
		try
		{
			do
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (b2H1)j5Y1.Default;
					be = be;
				}
			}
			while (obj3 != null);
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			catch
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			goto IL_0765;
		}
		IL_04fa:
		_ = (Ta8)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B);
		while ((object)j5Y1.Default != null)
		{
			try
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
			catch
			{
				do
				{
					c0B = c0B;
				}
				while ((object)j5Y1.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		do
		{
			if (checked(uIntPtr - unchecked((nuint)default(UIntPtr))) != 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (nuint)(UIntPtr)j5Y1.Default == 0)
				{
					z1J = z1J;
					continue;
				}
				_ = (y9T)(object)j5Y1.Default;
				Be5 obj8 = (Be5)(object)j5Y1.Default;
				be = (Be5)(object)j5Y1.Default;
				be = obj8;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					t1P = null;
					continue;
				}
				ng = (Ng67)(object)j5Y1.Default;
				ng = ng;
			}
		}
		while ((object)j5Y1.Default != null);
		try
		{
			try
			{
				try
				{
					Cd0n cd0n = (Cd0n)(object)j5Y1.Default;
					cd0n = cd0n;
				}
				finally
				{
					_ = (Be5)(object)j5Y1.Default;
					goto end_IL_05e1;
				}
				end_IL_05e1:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_003CModule_003E _003CModule_003E = null;
				}
				else
				{
					z1J = z1J;
				}
				goto end_IL_05e0;
			}
			end_IL_05e0:;
		}
		catch
		{
			while (obj3 != null)
			{
				gw = gw;
				_ = (Ta8)(object)j5Y1.Default;
			}
		}
		be = (Be5)(object)j5Y1.Default;
		_ = (t1P)(object)j5Y1.Default;
		try
		{
			try
			{
				while ((object)j5Y1.Default != null)
				{
					z1J = z1J;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
				else
				{
					ng = ng;
				}
				goto end_IL_0659;
			}
			end_IL_0659:;
		}
		finally
		{
			while (obj3 != null)
			{
				be = be;
				_ = (t1P)(object)j5Y1.Default;
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			goto IL_06c5;
		}
		IL_04ca:
		y9T y9T;
		try
		{
			z1J = null;
		}
		finally
		{
			w5D = w5D;
			y9T = y9T;
			b2H1 obj10 = (b2H1)j5Y1.Default;
			b2H1 b2H = b2H;
			b2H = obj10;
			goto IL_04fa;
		}
		IL_042d:
		while (obj3 != null)
		{
		}
		y9T = (y9T)(object)j5Y1.Default;
		try
		{
			UIntPtr num5 = (UIntPtr)j5Y1.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num5) * uIntPtr == 0)
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				else
				{
					try
					{
						_ = (Tg0e)(object)j5Y1.Default;
					}
					catch
					{
						z1J = z1J;
						z1J = z1J;
					}
				}
			}
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
			while (obj3 != null)
			{
				try
				{
					t1P = t1P;
				}
				finally
				{
					gw = (Gw13)(object)j5Y1.Default;
					j5Y = j5Y;
					_ = j5Y1.Default;
					c0B = null;
					continue;
				}
			}
			goto IL_04ca;
		}
		IL_00c6:
		try
		{
		}
		catch
		{
			_ = (Ta8)(object)j5Y1.Default;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)j5Y1.Default / uIntPtr) != 0 || unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) != 0)
			{
			}
			if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
			{
				try
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
					{
						_ = (Ma6)(object)j5Y1.Default;
					}
					else
					{
						_ = (b2H1)j5Y1.Default;
					}
				}
				finally
				{
					while (obj3 != null)
					{
						_ = j5Y1.Default;
					}
					goto IL_0169;
				}
			}
			_ = (y9T)(object)j5Y1.Default;
			goto IL_0169;
		}
		IL_06c5:
		if (uIntPtr == 0)
		{
			while (obj3 != null)
			{
				Tg0e tg0e = null;
				tg0e = tg0e;
			}
		}
		try
		{
			ma = null;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Be5)(object)j5Y1.Default;
			}
			goto IL_0705;
		}
		IL_07b4:
		checked
		{
			try
			{
				do
				{
					z1J = (z1J)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
				return;
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)j5Y1.Default) + unchecked((nuint)(UIntPtr)j5Y1.Default) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)j5Y1.Default)) == 0)
				{
					try
					{
						_ = (Br2)(object)j5Y1.Default;
						return;
					}
					finally
					{
						_ = (y9T)(object)j5Y1.Default;
						return;
					}
				}
				while (obj3 != null)
				{
					_ = (Br2)(object)j5Y1.Default;
				}
				return;
			}
		}
		IL_0765:
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (b2H1)j5Y1.Default;
				}
				catch
				{
					ma = null;
				}
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
			else
			{
				gw = (Gw13)(object)j5Y1.Default;
			}
		}
		finally
		{
			ma = ma;
			goto IL_07b4;
		}
		IL_03b2:
		try
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					ta = ta;
				}
				else
				{
					_ = (y9T)(object)j5Y1.Default;
				}
			}
			finally
			{
				try
				{
					_ = (o8W)(object)j5Y1.Default;
				}
				catch
				{
					Br2 br = br;
					_ = (o8W)(object)j5Y1.Default;
					ja = null;
				}
				goto end_IL_03b3;
			}
			end_IL_03b3:;
		}
		finally
		{
			while ((object)j5Y1.Default != null)
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
			goto IL_042d;
		}
	}
}
