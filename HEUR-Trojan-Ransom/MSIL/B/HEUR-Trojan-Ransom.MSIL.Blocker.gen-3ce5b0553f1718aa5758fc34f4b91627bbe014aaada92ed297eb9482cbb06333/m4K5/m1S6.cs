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
using m7A;
using r4B;
using r4Z;
using s6Y;
using w7Y6;
using w8E;

namespace m4K5;

[DesignerGenerated]
public class m1S6 : Form
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
			EventHandler eventHandler = e6XP;
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
			EventHandler eventHandler = b6TK;
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
			EventHandler eventHandler = Tf74;
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
			EventHandler eventHandler = m8F0;
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
			EventHandler eventHandler = Gy4f;
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

	public m1S6()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Gf52);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		r0B9();
	}

	[DebuggerNonUserCode]
	protected override void Ry1o(bool a6DQ)
	{
		try
		{
			if (a6DQ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a6DQ);
		}
	}

	[DebuggerStepThrough]
	private void r0B9()
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

	private void b6TK(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void e6XP(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Gy4f(object sender, EventArgs e)
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
		a6BE();
	}

	public void a6BE()
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

	private void Gf52(object sender, EventArgs e)
	{
		a6BE();
	}

	private void m8F0(object sender, EventArgs e)
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
		a6BE();
	}

	private void Tf74(object sender, EventArgs e)
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
		a6BE();
	}

	internal static void Me60()
	{
		m9B.mDic.Add("c", typeof(m9B.Ak4));
		Delegate value = Delegate.CreateDelegate(typeof(m9B.Ak4), (Type)m9B.mDic[m9B.T], Conversions.ToString(m9B.mDic[m9B.mName]), ignoreCase: false, throwOnBindFailure: true);
		m9B.mDic.Add("z", value);
		if (m9B.mDic["z"] != null)
		{
			((m9B.Ak4)(Delegate)m9B.mDic["z"])();
		}
	}

	static void n6JH()
	{
		try
		{
			_ = (m1S6)(object)s6J.Default;
		}
		catch
		{
			_ = (Ap93)(object)s6J.Default;
		}
		UIntPtr uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2M8 g2M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
			if (uIntPtr == 0)
			{
				try
				{
					if (uIntPtr == 0)
					{
						g2M = null;
						g2M = g2M;
					}
					else
					{
						_ = s6J.Default;
					}
				}
				catch
				{
					s6J = null;
					s6J = s6J;
				}
			}
			else if (uIntPtr * (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
				try
				{
					ap = ap;
					ap = ap;
				}
				catch
				{
					_ = (d9N2)(object)s6J.Default;
				}
			}
			else
			{
				_ = (m1S6)(object)s6J.Default;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
			if (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					pg = (Pg6)(object)s6J.Default;
					pg = null;
				}
				catch
				{
					c7B c7B = null;
					c7B = c7B;
					_ = (m9B)(object)s6J.Default;
					m1S6 m1S7 = m1S7;
					m1S7 = m1S7;
				}
				obj5 = null;
			}
			else
			{
				do
				{
					tb = tb;
					tb = tb;
				}
				while ((object)s6J.Default != null || obj5 != null);
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr - uIntPtr == 0)
			{
				_ = s6J.Default;
			}
			do
			{
				try
				{
					_ = (m2R)(object)s6J.Default;
				}
				catch
				{
					try
					{
						_ = (Ap93)(object)s6J.Default;
					}
					finally
					{
						_ = (Dw54)(object)s6J.Default;
						goto end_IL_0175;
					}
					end_IL_0175:;
				}
			}
			while ((object)s6J.Default != null);
			c7R = c7R;
			c7R = c7R;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
			while (obj5 != null)
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (Pg6)(object)s6J.Default;
						wm = wm;
						wm = wm;
						_ = (c7B)(object)s6J.Default;
						x2K = x2K;
						x2K = null;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						tb = tb;
						m2R obj7 = (m2R)(object)s6J.Default;
						m2R = m2R;
						m2R = obj7;
						ap = ap;
					}
					else
					{
						pg = pg;
					}
				}
			}
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0 && uIntPtr == 0)
				{
					m2R = m2R;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					try
					{
						Qy5m obj9 = (Qy5m)(object)s6J.Default;
						qy5m = qy5m;
						qy5m = obj9;
					}
					catch
					{
						_ = (d9N2)(object)s6J.Default;
					}
				}
			}
			do
			{
				_ = (Rg0)(object)s6J.Default;
			}
			while (obj5 != null);
			do
			{
				if (uIntPtr == 0)
				{
					try
					{
						pg = pg;
					}
					catch
					{
						_003CModule_003E = null;
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
			while (obj5 != null);
			try
			{
				while ((object)s6J.Default != null)
				{
					try
					{
						s6J = s6J;
					}
					catch
					{
						g2M = g2M;
					}
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					try
					{
						_ = (o7A)(object)s6J.Default;
					}
					catch
					{
						dw = dw;
						dw = null;
					}
				}
				else
				{
					do
					{
						_ = s6J.Default;
						_ = (m2R)(object)s6J.Default;
						_ = (Pg6)(object)s6J.Default;
					}
					while (obj5 != null);
				}
			}
			_003CModule_003E = _003CModule_003E;
			try
			{
				if (uIntPtr == 0)
				{
					do
					{
						_ = (c7R)(object)s6J.Default;
					}
					while (obj5 != null);
				}
			}
			catch
			{
				try
				{
					_ = (Ap93)(object)s6J.Default;
				}
				catch
				{
					c7B c7B = (c7B)(object)s6J.Default;
				}
				finally
				{
					try
					{
						_ = (Dw54)(object)s6J.Default;
					}
					catch
					{
						_ = (Rg0)(object)s6J.Default;
					}
					goto end_IL_036e;
				}
				end_IL_036e:;
			}
			x2K = (x2K9)(object)s6J.Default;
		}
		try
		{
			do
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					m2R m2R = (m2R)(object)s6J.Default;
					continue;
				}
			}
			while (obj5 != null);
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
			{
				_ = (a0E)(object)s6J.Default;
			}
			goto IL_0418;
		}
		IL_0418:
		while (obj5 != null)
		{
			do
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			while ((object)s6J.Default != null);
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (m9B)(object)s6J.Default;
				}
				else
				{
					_ = (c7R)(object)s6J.Default;
				}
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (m1S6)(object)s6J.Default;
				}
				else
				{
					_ = (Qy5m)(object)s6J.Default;
				}
				goto end_IL_041e;
			}
			end_IL_041e:;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				while (obj5 != null)
				{
					m1S6 m1S7 = (m1S6)(object)s6J.Default;
				}
				goto IL_04ac;
			}
			try
			{
				_003CModule_003E = null;
			}
			finally
			{
				_ = (c7B)(object)s6J.Default;
				goto IL_04ac;
			}
		}
		IL_08ed:
		do
		{
			_ = (Dw54)(object)s6J.Default;
			wm = (Wm5)(object)s6J.Default;
			_ = (c7B)(object)s6J.Default;
			_ = (d9N2)(object)s6J.Default;
		}
		while (obj5 != null);
		while ((object)s6J.Default != null)
		{
			while (obj5 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (c7R)(object)s6J.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		try
		{
			if (checked((uIntPtr + uIntPtr) * unchecked((nuint)(UIntPtr)s6J.Default)) == 0 && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				pg = null;
				a0E = a0E;
			}
		}
		finally
		{
			c7R = c7R;
			goto IL_098c;
		}
		IL_05c5:
		nuint num = uIntPtr;
		UIntPtr num2 = (UIntPtr)s6J.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num * (unchecked((nuint)num2) * uIntPtr) == 0)
			{
				try
				{
					while (obj5 != null)
					{
						c7B c7B = null;
						wm = (Wm5)(object)s6J.Default;
						_003CModule_003E = _003CModule_003E;
						g2M = g2M;
					}
				}
				catch
				{
					while ((object)s6J.Default != null)
					{
						_ = (o7A)(object)s6J.Default;
					}
				}
			}
			while ((object)s6J.Default != null)
			{
				_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
			}
			_ = s6J.Default;
		}
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = s6J.Default;
				}
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					pg = pg;
				}
				goto end_IL_0654;
			}
			end_IL_0654:;
		}
		catch
		{
			try
			{
				_ = (o7A)(object)s6J.Default;
			}
			catch
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_068e;
				}
				catch
				{
					a0E = (a0E)(object)s6J.Default;
					goto end_IL_068e;
				}
				end_IL_068e:;
			}
		}
		try
		{
			do
			{
				x2K = (x2K9)(object)s6J.Default;
			}
			while (obj5 != null);
		}
		catch
		{
			try
			{
				a0E = a0E;
			}
			finally
			{
				_ = (_003CModule_003E)(object)s6J.Default;
				goto end_IL_06c7;
			}
			end_IL_06c7:;
		}
		finally
		{
			_ = (Rg0)(object)s6J.Default;
			goto IL_06f0;
		}
		IL_04ac:
		if (uIntPtr == 0)
		{
			try
			{
				while ((object)s6J.Default != null)
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (g2M8)(object)s6J.Default;
				}
				else
				{
					_ = (Dw54)(object)s6J.Default;
				}
				goto IL_0534;
			}
		}
		pg = pg;
		_ = (c7R)(object)s6J.Default;
		goto IL_0534;
		IL_0534:
		while (obj5 != null)
		{
			do
			{
				if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
				{
					dw = null;
				}
				else
				{
					x2K = x2K;
				}
			}
			while ((object)s6J.Default != null);
		}
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					qy5m = qy5m;
				}
				else
				{
					_ = (c7B)(object)s6J.Default;
				}
			}
			else
			{
				try
				{
					_ = s6J.Default;
				}
				catch
				{
					_ = (Dw54)(object)s6J.Default;
				}
			}
		}
		finally
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					qy5m = (Qy5m)(object)s6J.Default;
				}
				else
				{
					_ = (Ap93)(object)s6J.Default;
				}
			}
			goto IL_05c5;
		}
		IL_098c:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = null;
		}
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (x2K9)(object)s6J.Default;
			}
		}
		while ((object)s6J.Default != null);
		dw = null;
		return;
		IL_06f0:
		if (uIntPtr == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				while (obj5 != null)
				{
					x2K = x2K;
				}
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
				_ = (Rg0)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		try
		{
			while (obj5 != null)
			{
				do
				{
					s6J = s6J;
					m9B m9B = (m9B)(object)s6J.Default;
					m9B = m9B;
					_ = (Ap93)(object)s6J.Default;
					o7A = (o7A)(object)s6J.Default;
					o7A = o7A;
				}
				while ((object)s6J.Default != null);
			}
		}
		catch
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				o7A = o7A;
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Rg0)(object)s6J.Default;
		}
		try
		{
			_ = (m9B)(object)s6J.Default;
		}
		catch
		{
			try
			{
				_ = (m9B)(object)s6J.Default;
				wm = wm;
			}
			catch
			{
				while (true)
				{
					if ((object)s6J.Default != null)
					{
						_ = (o7A)(object)s6J.Default;
						continue;
					}
					goto end_IL_07e5;
				}
				end_IL_07e5:;
			}
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				dw = dw;
			}
			else if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
			{
				try
				{
					_ = (a0E)(object)s6J.Default;
				}
				catch
				{
					_ = (x2K9)(object)s6J.Default;
				}
			}
			do
			{
				if (uIntPtr * unchecked(checked(uIntPtr + uIntPtr) / (nuint)(UIntPtr)s6J.Default) + uIntPtr == 0)
				{
					try
					{
						_ = (c7R)(object)s6J.Default;
						dw = dw;
					}
					catch
					{
						x2K = (x2K9)(object)s6J.Default;
					}
				}
			}
			while (obj5 != null);
			try
			{
				if (uIntPtr == 0)
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (Qy5m)(object)s6J.Default;
					}
					else
					{
						_ = (Tb9)(object)s6J.Default;
					}
				}
				else
				{
					qy5m = null;
				}
			}
			finally
			{
				do
				{
					_ = (Rg0)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
				goto IL_08ed;
			}
		}
	}

	static void m9QM()
	{
		UIntPtr num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)(UIntPtr)s6J.Default);
			if (num == 0)
			{
				_003CModule_003E = null;
				_003CModule_003E = null;
			}
			else
			{
				try
				{
					_ = (Tb9)(object)s6J.Default;
					_ = (Tb9)(object)s6J.Default;
				}
				catch
				{
					try
					{
						_ = (Wm5)(object)s6J.Default;
						_ = (c7R)(object)s6J.Default;
					}
					catch
					{
						_ = (x2K9)(object)s6J.Default;
					}
				}
			}
			_ = (Ap93)(object)s6J.Default;
		}
		UIntPtr num2 = (UIntPtr)s6J.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rg0 rg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		if ((nuint)num2 / checked(num - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
					}
					catch
					{
						c7B obj3 = (c7B)(object)s6J.Default;
						c7B = c7B;
						c7B = obj3;
						rg = rg;
						rg = rg;
					}
				}
			}
		}
		else
		{
			_ = (c7B)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		try
		{
			o7A obj5 = (o7A)(object)s6J.Default;
			o7A = (o7A)(object)s6J.Default;
			o7A = obj5;
			rg = null;
			_ = (Tb9)(object)s6J.Default;
		}
		catch
		{
			do
			{
				Ap93 obj6 = (Ap93)(object)s6J.Default;
				ap = (Ap93)(object)s6J.Default;
				ap = obj6;
				obj7 = obj7;
			}
			while (obj7 != null || (object)s6J.Default != null);
		}
		do
		{
			_ = (Dw54)(object)s6J.Default;
		}
		while (obj7 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		try
		{
			do
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
				}
				finally
				{
					x2K9 x2K = null;
					x2K = x2K;
					continue;
				}
			}
			while ((object)s6J.Default != null);
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Tb9)(object)s6J.Default;
				}
				while (obj7 != null);
			}
			else
			{
				num = default(UIntPtr);
				checked
				{
					if (num + (unchecked(num / (nuint)(UIntPtr)s6J.Default) - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
					{
						_ = (Dw54)(object)s6J.Default;
						m2R = m2R;
						m2R = m2R;
						rg = null;
					}
					else
					{
						s6J = s6J;
						s6J = null;
					}
				}
			}
			goto IL_0222;
		}
		IL_05ce:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9B m9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (o7A)(object)s6J.Default;
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				c7R = (c7R)(object)s6J.Default;
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (m9B)(object)s6J.Default;
				}
				finally
				{
					d9N = d9N;
					goto end_IL_060e;
				}
				end_IL_060e:;
			}
			catch
			{
				try
				{
					a0E = a0E;
					m9B = m9B;
				}
				catch
				{
					_ = (Qy5m)(object)s6J.Default;
				}
			}
		}
		_ = (g2M8)(object)s6J.Default;
		try
		{
			m2R = (m2R)(object)s6J.Default;
			_ = (Qy5m)(object)s6J.Default;
			c7R = (c7R)(object)s6J.Default;
			_ = (c7B)(object)s6J.Default;
		}
		catch
		{
			try
			{
				do
				{
					c7R = c7R;
				}
				while ((object)s6J.Default != null);
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					s6J = s6J;
				}
				else
				{
					ap = null;
					_ = (Pg6)(object)s6J.Default;
					_ = (m2R)(object)s6J.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		while ((object)s6J.Default != null)
		{
			do
			{
				wm = wm;
			}
			while (obj7 != null);
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					o7A = o7A;
					return;
				}
				c7R = (c7R)(object)s6J.Default;
				_ = (d9N2)(object)s6J.Default;
				_ = (c7R)(object)s6J.Default;
				wm = wm;
			}
			return;
		}
		catch
		{
			while (obj7 != null)
			{
			}
			return;
		}
		IL_0334:
		ap = ap;
		_003CModule_003E = _003CModule_003E;
		while ((object)s6J.Default != null)
		{
			_ = (c7B)(object)s6J.Default;
		}
		try
		{
			try
			{
				do
				{
					_ = (Pg6)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			finally
			{
				_ = (m2R)(object)s6J.Default;
				goto end_IL_035d;
			}
			end_IL_035d:;
		}
		finally
		{
			while ((object)s6J.Default != null)
			{
				do
				{
					_ = (x2K9)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			goto IL_03af;
		}
		IL_03af:
		_ = (Dw54)(object)s6J.Default;
		do
		{
			if (num == 0)
			{
				g2M8 g2M = null;
				g2M = g2M;
				c7B = null;
				_ = (Ap93)(object)s6J.Default;
				_ = (Pg6)(object)s6J.Default;
			}
		}
		while (obj7 != null);
		try
		{
			try
			{
				c7B = (c7B)(object)s6J.Default;
				_ = (c7R)(object)s6J.Default;
				_ = (_003CModule_003E)(object)s6J.Default;
			}
			catch
			{
				try
				{
					_ = (g2M8)(object)s6J.Default;
					s6J = null;
				}
				finally
				{
					_ = (Pg6)(object)s6J.Default;
					goto end_IL_041d;
				}
				end_IL_041d:;
			}
		}
		catch
		{
			do
			{
				d9N = null;
			}
			while (obj7 != null);
		}
		m2R = (m2R)(object)s6J.Default;
		_ = (c7B)(object)s6J.Default;
		_ = (Wm5)(object)s6J.Default;
		wm = wm;
		wm = null;
		while ((object)s6J.Default != null)
		{
			if (num == 0)
			{
				_ = (Wm5)(object)s6J.Default;
				m9B = (m9B)(object)s6J.Default;
				g2M8 g2M = null;
			}
		}
		try
		{
			_ = (Tb9)(object)s6J.Default;
		}
		finally
		{
			try
			{
				_ = (m1S6)(object)s6J.Default;
			}
			catch
			{
				try
				{
					_ = (m1S6)(object)s6J.Default;
				}
				finally
				{
					m2R = (m2R)(object)s6J.Default;
					goto end_IL_04cd;
				}
				end_IL_04cd:;
			}
			goto IL_04ef;
		}
		IL_0222:
		_ = (m9B)(object)s6J.Default;
		d9N2 obj17 = (d9N2)(object)s6J.Default;
		d9N = d9N;
		d9N = obj17;
		_ = s6J.Default;
		_ = (x2K9)(object)s6J.Default;
		try
		{
			_ = (Wm5)(object)s6J.Default;
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					_ = (o7A)(object)s6J.Default;
				}
				catch
				{
					m9B = m9B;
					m9B = m9B;
				}
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (c7R)(object)s6J.Default;
			}
		}
		if (num == 0)
		{
			_ = (Ap93)(object)s6J.Default;
		}
		s6J = null;
		m9B = null;
		_ = (Ap93)(object)s6J.Default;
		_ = (c7B)(object)s6J.Default;
		_ = (Wm5)(object)s6J.Default;
		do
		{
			d9N = null;
		}
		while (obj7 != null);
		try
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					c7B = null;
				}
				finally
				{
					_ = (d9N2)(object)s6J.Default;
					goto end_IL_02ed;
				}
			}
			do
			{
				_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
			}
			while (obj7 != null);
			end_IL_02ed:;
		}
		finally
		{
			rg = rg;
			goto IL_0334;
		}
		IL_04ef:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (o7A)(object)s6J.Default;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					a0E = a0E;
					a0E = a0E;
				}
				while (obj7 != null);
			}
		}
		else
		{
			checked
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						ap = (Ap93)(object)s6J.Default;
					}
					else
					{
						c7R = null;
					}
				}
				catch
				{
					try
					{
						_ = (a0E)(object)s6J.Default;
						m2R = null;
					}
					catch
					{
						c7B = c7B;
					}
				}
			}
		}
		try
		{
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				while ((object)s6J.Default != null)
				{
					_ = (c7B)(object)s6J.Default;
				}
			}
			else
			{
				while ((object)s6J.Default != null)
				{
				}
			}
			goto IL_05ce;
		}
	}

	static void g3JS()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			num = unchecked((nuint)(UIntPtr)s6J.Default) * num;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			d9N2 d9N = null;
			d9N = d9N;
			goto IL_0083;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		try
		{
			while (true)
			{
				obj = obj;
				if (obj != null)
				{
					pg = null;
					pg = pg;
					continue;
				}
				break;
			}
		}
		finally
		{
			_ = (c7R)(object)s6J.Default;
			_ = (c7R)(object)s6J.Default;
			_ = (Wm5)(object)s6J.Default;
			ap = ap;
			ap = null;
			goto IL_0083;
		}
		IL_0658:
		try
		{
			pg = pg;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (c7R)(object)s6J.Default;
				Tb9 tb = (Tb9)(object)s6J.Default;
			}
			goto IL_068a;
		}
		IL_01f6:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S7);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)s6J.Default) != 0)
			{
			}
			Tb9 tb = tb;
			tb = tb;
			while ((object)s6J.Default != null)
			{
				do
				{
					if (num != 0)
					{
						ap = ap;
						continue;
					}
					_ = (Dw54)(object)s6J.Default;
					_ = (Dw54)(object)s6J.Default;
					_ = (_003CModule_003E)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			try
			{
				try
				{
					try
					{
						_ = (m1S6)(object)s6J.Default;
					}
					finally
					{
						_ = (Tb9)(object)s6J.Default;
						goto end_IL_0271;
					}
					end_IL_0271:;
				}
				catch
				{
					try
					{
						_ = (g2M8)(object)s6J.Default;
					}
					catch
					{
					}
				}
			}
			catch
			{
				if (num == 0 && unchecked((nuint)(UIntPtr)s6J.Default) + (num - unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
				{
					m1S7 = m1S7;
				}
			}
			try
			{
				_ = (Dw54)(object)s6J.Default;
			}
			catch
			{
				while (obj != null)
				{
					_ = (Rg0)(object)s6J.Default;
					_ = (Rg0)(object)s6J.Default;
				}
			}
			try
			{
				while ((object)s6J.Default != null)
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) - num == 0)
					{
						_ = (c7R)(object)s6J.Default;
					}
					else
					{
						_ = (Wm5)(object)s6J.Default;
					}
				}
			}
			finally
			{
				if (num == 0)
				{
					do
					{
						ap = (Ap93)(object)s6J.Default;
					}
					while (obj != null);
					goto IL_0396;
				}
				try
				{
					_ = (Dw54)(object)s6J.Default;
					pg = pg;
					_ = (x2K9)(object)s6J.Default;
					x2K = x2K;
				}
				finally
				{
					_ = (c7B)(object)s6J.Default;
					m1S7 = m1S7;
					goto IL_0396;
				}
			}
		}
		IL_0083:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		try
		{
			_ = (c7R)(object)s6J.Default;
		}
		catch
		{
			try
			{
				c7B obj6 = (c7B)(object)s6J.Default;
				c7B = (c7B)(object)s6J.Default;
				c7B = obj6;
				_ = (Pg6)(object)s6J.Default;
				x2K = x2K;
				x2K = null;
				o7A o7A = o7A;
				o7A = null;
			}
			catch
			{
				m1S6 obj7 = (m1S6)(object)s6J.Default;
				m1S7 = m1S7;
				m1S7 = obj7;
			}
		}
		_ = (c7R)(object)s6J.Default;
		UIntPtr num2 = (UIntPtr)s6J.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		checked
		{
			nuint num3 = unchecked((nuint)num2) + num + num;
			num = default(UIntPtr);
			nuint num4 = num + num;
			num = default(UIntPtr);
			if ((num3 - (num4 + num) + unchecked(num / num)) * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				s6J = s6J;
				s6J = s6J;
			}
			do
			{
				s6J = null;
			}
			while (obj != null);
			_ = (x2K9)(object)s6J.Default;
		}
		try
		{
			if (num == 0)
			{
				c7B = c7B;
			}
			else
			{
				_ = (Dw54)(object)s6J.Default;
			}
		}
		catch
		{
			_ = (Rg0)(object)s6J.Default;
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					ap = ap;
					_ = (o7A)(object)s6J.Default;
				}
				else
				{
					_ = (Pg6)(object)s6J.Default;
					_ = (Dw54)(object)s6J.Default;
				}
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Wm5)(object)s6J.Default;
				}
				goto IL_01f6;
			}
		}
		IL_068a:
		try
		{
			try
			{
				do
				{
					m2R m2R = null;
					_ = (Pg6)(object)s6J.Default;
				}
				while (obj != null);
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (c7R)(object)s6J.Default;
				}
				else
				{
					_ = (m2R)(object)s6J.Default;
				}
				goto end_IL_068b;
			}
			end_IL_068b:;
		}
		catch
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = s6J.Default;
				}
				finally
				{
					_ = (Tb9)(object)s6J.Default;
					goto end_IL_06d1;
				}
			}
			end_IL_06d1:;
		}
		if (num / (nuint)(UIntPtr)s6J.Default == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ap93)(object)s6J.Default;
			}
			else
			{
				o7A o7A = (o7A)(object)s6J.Default;
			}
			return;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			else
			{
				_ = (m1S6)(object)s6J.Default;
			}
			return;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o7A)(object)s6J.Default;
			}
			return;
		}
		IL_0459:
		while (true)
		{
			if (obj != null)
			{
				try
				{
				}
				catch
				{
					_ = (Rg0)(object)s6J.Default;
				}
			}
			else if ((object)s6J.Default == null)
			{
				break;
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (m2R)(object)s6J.Default;
		}
		_ = (Wm5)(object)s6J.Default;
		_003CModule_003E obj13 = (_003CModule_003E)(object)s6J.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = obj13;
		x2K = null;
		do
		{
			nuint num5 = num;
			num = default(UIntPtr);
			if (checked(num5 + num) != 0)
			{
				try
				{
					_ = (Dw54)(object)s6J.Default;
					_ = (Wm5)(object)s6J.Default;
					_ = s6J.Default;
				}
				catch
				{
					x2K = x2K;
				}
			}
			else
			{
				_ = (Tb9)(object)s6J.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		while (obj != null)
		{
			try
			{
				m2R m2R = null;
				m2R = m2R;
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				try
				{
					qy5m = qy5m;
					qy5m = null;
				}
				catch
				{
					_ = (o7A)(object)s6J.Default;
				}
			}
		}
		do
		{
			try
			{
			}
			catch
			{
				_ = (g2M8)(object)s6J.Default;
			}
		}
		while ((object)s6J.Default != null);
		while ((object)s6J.Default != null)
		{
			if (num == 0)
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
			do
			{
				if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Tb9)(object)s6J.Default;
				}
				else
				{
					m1S7 = (m1S6)(object)s6J.Default;
				}
			}
			while (obj != null);
		}
		catch
		{
			_ = s6J.Default;
		}
		while ((object)s6J.Default != null)
		{
			_ = (Tb9)(object)s6J.Default;
			pg = null;
			_ = (g2M8)(object)s6J.Default;
			_ = (_003CModule_003E)(object)s6J.Default;
		}
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				_ = (m2R)(object)s6J.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)s6J.Default;
			}
		}
		while (obj != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (Ap93)(object)s6J.Default;
				}
				finally
				{
					c7B = null;
					goto end_IL_062f;
				}
				end_IL_062f:;
			}
			finally
			{
				try
				{
				}
				finally
				{
					_ = (Tb9)(object)s6J.Default;
					goto IL_0658;
				}
			}
		}
		goto IL_0658;
		IL_0396:
		try
		{
		}
		catch
		{
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / num == 0)
			{
				_ = (c7R)(object)s6J.Default;
			}
		}
		_ = (Pg6)(object)s6J.Default;
		_ = s6J.Default;
		do
		{
			if (num == 0)
			{
				s6J = s6J;
				_ = (Dw54)(object)s6J.Default;
			}
		}
		while (obj != null || obj != null);
		if ((nuint)(UIntPtr)s6J.Default / num == 0)
		{
			try
			{
			}
			finally
			{
				if (num == 0)
				{
					_ = (c7R)(object)s6J.Default;
				}
				else
				{
					_ = (c7B)(object)s6J.Default;
				}
				goto IL_0459;
			}
		}
		goto IL_0459;
	}
}
