using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using La50;
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
using s6Y;
using w7Y6;
using w8E;

namespace Lg1;

[DesignerGenerated]
public class c7B : Form
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
			EventHandler eventHandler = Zz2;
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
			EventHandler eventHandler = s2G;
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

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
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
			EventHandler eventHandler = o8R;
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
			EventHandler eventHandler = x3H;
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

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPStock")]
	internal virtual TextBox txtPStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCost")]
	internal virtual TextBox txtPCost
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

	[field: AccessedThroughProperty("txtPid")]
	internal virtual TextBox txtPid
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
			EventHandler eventHandler = t1A;
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

	public c7B()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)k0C);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Jk9();
	}

	[DebuggerNonUserCode]
	protected override void x2S(bool o1N)
	{
		try
		{
			if (o1N && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o1N);
		}
	}

	[DebuggerStepThrough]
	private void Jk9()
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
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		txtPMachine = new TextBox();
		Label9 = new Label();
		btnDelete = new Button();
		btnModify = new Button();
		DataGridView1 = new DataGridView();
		txtWeight = new TextBox();
		txtPStock = new TextBox();
		txtPCost = new TextBox();
		Label4 = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label5 = new Label();
		txtPid = new TextBox();
		btnSave = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(332, 21));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(111, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Product Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(739, 21));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(14);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(47, 21));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Go To Main");
		((Control)txtPMachine).set_Location(new Point(413, 99));
		((Control)txtPMachine).set_Name("txtPMachine");
		((Control)txtPMachine).set_Size(new Size(122, 20));
		((Control)txtPMachine).set_TabIndex(4);
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(299, 99));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(108, 13));
		((Control)Label9).set_TabIndex(46);
		Label9.set_Text("Production Machine :");
		((Control)btnDelete).set_Location(new Point(398, 218));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 23));
		((Control)btnDelete).set_TabIndex(7);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(286, 218));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 23));
		((Control)btnModify).set_TabIndex(6);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(50, 255));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(599, 183));
		((Control)DataGridView1).set_TabIndex(41);
		((Control)txtWeight).set_Location(new Point(413, 53));
		((Control)txtWeight).set_Name("txtWeight");
		((Control)txtWeight).set_Size(new Size(122, 20));
		((Control)txtWeight).set_TabIndex(3);
		((Control)txtPStock).set_Location(new Point(191, 134));
		((Control)txtPStock).set_Name("txtPStock");
		((Control)txtPStock).set_Size(new Size(100, 20));
		((Control)txtPStock).set_TabIndex(2);
		((Control)txtPCost).set_Location(new Point(191, 95));
		((Control)txtPCost).set_Name("txtPCost");
		((Control)txtPCost).set_Size(new Size(100, 20));
		((Control)txtPCost).set_TabIndex(1);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(360, 56));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(47, 13));
		((Control)Label4).set_TabIndex(37);
		Label4.set_Text("Weight :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(120, 141));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(41, 13));
		((Control)Label1).set_TabIndex(36);
		Label1.set_Text("Stock :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(99, 59));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(62, 13));
		((Control)Label2).set_TabIndex(35);
		Label2.set_Text("Product Id :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(127, 102));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(34, 13));
		((Control)Label5).set_TabIndex(34);
		Label5.set_Text("Cost :");
		((Control)txtPid).set_Location(new Point(191, 56));
		((Control)txtPid).set_Name("txtPid");
		((Control)txtPid).set_Size(new Size(100, 20));
		((Control)txtPid).set_TabIndex(0);
		((Control)btnSave).set_Location(new Point(178, 218));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(5);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)txtPMachine);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)txtWeight);
		((Control)this).get_Controls().Add((Control)(object)txtPStock);
		((Control)this).get_Controls().Add((Control)(object)txtPCost);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtPid);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmProductDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmProductDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void s2G(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void Zz2(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void t1A(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_product_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",'" + txtPStock.get_Text() + "','" + txtWeight.get_Text() + "','" + txtPMachine.get_Text() + "')");
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
		b8N();
	}

	public void b8N()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_product_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Product Id");
			DataGridView1.get_Columns().Add("c2", "Product Cost");
			DataGridView1.get_Columns().Add("c3", "Product Stock");
			DataGridView1.get_Columns().Add("c4", "Product Weight");
			DataGridView1.get_Columns().Add("c5", "Production Machine");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("pid").ToString(),
					rd.get_Item("pcost").ToString(),
					rd.get_Item("pstock"),
					rd.get_Item("stockweight"),
					rd.get_Item("productionmachine")
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

	internal static byte[] x6B(byte[] j3T, byte[] b3G, int n3G, int Cb4)
	{
		int num = checked(j3T.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			j3T[i] = (byte)(j3T[i] ^ checked((byte)(b3G[unchecked(i % b3G.Length)] ^ ((i + unchecked(n3G % b3G.Length)) & n3G))));
		}
		return j3T;
	}

	private void o8R(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_product_detail where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		b8N();
	}

	private void x3H(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_product_detail set pcost = " + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",pstock=" + txtPStock.get_Text() + ",stockweight='" + txtWeight.get_Text() + "',productionmachine='" + txtPMachine.get_Text() + "' where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		b8N();
	}

	private void k0C(object sender, EventArgs e)
	{
		b8N();
	}

	internal static string[] Ci4()
	{
		m2R.a5W();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		m9B.mDic.Add("AO", executingAssembly);
		return d9N2.r3A5();
	}

	static void z2E()
	{
		nuint uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			m2R = m2R;
			m2R = m2R;
			goto IL_0060;
		}
		try
		{
			_ = (g2M8)(object)s6J.Default;
		}
		catch
		{
			_ = (Tb9)(object)s6J.Default;
		}
		finally
		{
			_ = (Ap93)(object)s6J.Default;
			goto IL_0060;
		}
		IL_0398:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		while (obj2 != null)
		{
			_ = (Pg6)(object)s6J.Default;
		}
		m1S6 m1S;
		try
		{
			try
			{
				try
				{
					_ = (Tb9)(object)s6J.Default;
				}
				finally
				{
					_ = (m2R)(object)s6J.Default;
					goto end_IL_039f;
				}
				end_IL_039f:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (m2R)(object)s6J.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Pg6)(object)s6J.Default;
				}
				finally
				{
					_ = (m9B)(object)s6J.Default;
					goto end_IL_03dc;
				}
			}
			try
			{
				m1S = m1S;
			}
			finally
			{
				_ = s6J.Default;
				goto end_IL_03dc;
			}
			end_IL_03dc:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rg0 rg);
		do
		{
			try
			{
				rg = rg;
			}
			catch
			{
				_ = (g2M8)(object)s6J.Default;
			}
		}
		while ((object)s6J.Default != null || obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		while (obj2 != null)
		{
			try
			{
				_ = (c7B)(object)s6J.Default;
			}
			finally
			{
				while ((object)s6J.Default != null)
				{
					pg = (Pg6)(object)s6J.Default;
				}
				continue;
			}
		}
		if (checked(unchecked((nuint)(UIntPtr)s6J.Default) - uIntPtr) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pg6)(object)s6J.Default;
				}
				else
				{
					_ = (g2M8)(object)s6J.Default;
				}
			}
		}
		else
		{
			c7B c7B2 = null;
			_ = (Dw54)(object)s6J.Default;
			_ = (m9B)(object)s6J.Default;
			_ = (Ap93)(object)s6J.Default;
		}
		s6J obj6 = s6J.Default;
		s6J s6J = s6J;
		s6J = obj6;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (a0E)(object)s6J.Default;
			}
			while (obj2 != null);
		}
		try
		{
			_ = (Dw54)(object)s6J.Default;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					rg = rg;
					_ = (Wm5)(object)s6J.Default;
					_ = (Wm5)(object)s6J.Default;
				}
			}
			goto IL_0573;
		}
		IL_0573:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (uIntPtr * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (Wm5)(object)s6J.Default;
					}
					else
					{
						_ = (a0E)(object)s6J.Default;
					}
				}
			}
		}
		else
		{
			do
			{
				_ = (Dw54)(object)s6J.Default;
			}
			while ((object)s6J.Default != null);
		}
		try
		{
			s6J = null;
		}
		catch
		{
			o7A o7A = null;
			o7A = o7A;
		}
		try
		{
			_ = (Tb9)(object)s6J.Default;
		}
		catch
		{
			try
			{
				_ = (_003CModule_003E)(object)s6J.Default;
			}
			finally
			{
				o7A o7A = null;
				goto end_IL_05f8;
			}
			end_IL_05f8:;
		}
		finally
		{
			try
			{
				try
				{
					pg = null;
					_ = (a0E)(object)s6J.Default;
				}
				catch
				{
					Qy5m qy5m = (Qy5m)(object)s6J.Default;
					qy5m = qy5m;
					_ = (Wm5)(object)s6J.Default;
					_ = (c7B)(object)s6J.Default;
				}
			}
			catch
			{
				while (obj2 != null)
				{
					x2K9 x2K = (x2K9)(object)s6J.Default;
					_ = (m1S6)(object)s6J.Default;
				}
			}
			goto IL_067c;
		}
		IL_0060:
		try
		{
			obj2 = null;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
			while (obj2 != null)
			{
				Rg0 obj11 = (Rg0)(object)s6J.Default;
				rg = null;
				rg = obj11;
				d9N = d9N;
				d9N = d9N;
				pg = pg;
				pg = null;
			}
		}
		_ = (c7B)(object)s6J.Default;
		_ = s6J.Default;
		_ = (Dw54)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		do
		{
			a0E = a0E;
			a0E = a0E;
			_ = (Ap93)(object)s6J.Default;
			_ = (a0E)(object)s6J.Default;
			m1S6 obj13 = (m1S6)(object)s6J.Default;
			m1S = (m1S6)(object)s6J.Default;
			m1S = obj13;
		}
		while (obj2 != null);
		try
		{
			x2K9 x2K = x2K;
			x2K = null;
		}
		catch
		{
			while (obj2 != null)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					x2K9 x2K = (x2K9)(object)s6J.Default;
				}
			}
		}
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				nuint num = unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) + (unchecked((nuint)(UIntPtr)s6J.Default) - (uIntPtr - unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)(UIntPtr)s6J.Default)));
				uIntPtr = default(UIntPtr);
				if ((num * uIntPtr + unchecked((nuint)(UIntPtr)s6J.Default)) * unchecked((nuint)(UIntPtr)s6J.Default) * (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
				{
					try
					{
						_ = (m1S6)(object)s6J.Default;
					}
					finally
					{
						_ = (m1S6)(object)s6J.Default;
						continue;
					}
				}
			}
			while (obj2 != null);
			try
			{
				if (unchecked((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u))
				{
					try
					{
						m1S = m1S;
						_ = (g2M8)(object)s6J.Default;
						m1S = (m1S6)(object)s6J.Default;
						pg = pg;
					}
					finally
					{
						_ = (m9B)(object)s6J.Default;
						goto end_IL_01ed;
					}
				}
				try
				{
					_ = s6J.Default;
				}
				catch
				{
					_ = (Pg6)(object)s6J.Default;
				}
				end_IL_01ed:;
			}
			finally
			{
				while ((object)s6J.Default != null)
				{
					nuint num2 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 * uIntPtr == 0)
					{
						rg = (Rg0)(object)s6J.Default;
					}
				}
				goto IL_0283;
			}
		}
		IL_067c:
		if (uIntPtr == 0)
		{
			c7B c7B2 = null;
		}
		a0E = a0E;
		try
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Dw54)(object)s6J.Default;
				}
				catch
				{
					_ = (Wm5)(object)s6J.Default;
				}
			}
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			goto IL_06cc;
		}
		IL_06cc:
		try
		{
			if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
				}
				finally
				{
					s6J = s6J;
					goto end_IL_06cd;
				}
			}
			_ = (c7R)(object)s6J.Default;
			_ = (Ap93)(object)s6J.Default;
			end_IL_06cd:;
		}
		catch
		{
			_ = (_003CModule_003E)(object)s6J.Default;
		}
		do
		{
			if ((nuint)(UIntPtr)s6J.Default / (nuint)(UIntPtr)s6J.Default == 0)
			{
			}
		}
		while ((object)s6J.Default != null);
		while ((object)s6J.Default != null)
		{
			try
			{
				_ = (g2M8)(object)s6J.Default;
			}
			finally
			{
				_ = (Tb9)(object)s6J.Default;
				continue;
			}
		}
		_ = (m9B)(object)s6J.Default;
		do
		{
			try
			{
			}
			finally
			{
				try
				{
					a0E = a0E;
				}
				finally
				{
					_ = (Wm5)(object)s6J.Default;
					continue;
				}
			}
		}
		while (obj2 != null);
		try
		{
			do
			{
				if (uIntPtr == 0)
				{
					_ = (m2R)(object)s6J.Default;
				}
			}
			while (obj2 != null);
			return;
		}
		catch
		{
			do
			{
				_ = (a0E)(object)s6J.Default;
			}
			while (obj2 != null);
			return;
		}
		IL_0283:
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Dw54)(object)s6J.Default;
				}
				finally
				{
					_ = (g2M8)(object)s6J.Default;
					goto end_IL_0284;
				}
			}
			while (obj2 != null)
			{
				_ = (Wm5)(object)s6J.Default;
			}
			end_IL_0284:;
		}
		catch
		{
			try
			{
				try
				{
					m1S = null;
				}
				finally
				{
					m1S = null;
					_ = (x2K9)(object)s6J.Default;
					goto end_IL_02be;
				}
				end_IL_02be:;
			}
			catch
			{
				_ = (Dw54)(object)s6J.Default;
				_ = (c7R)(object)s6J.Default;
			}
		}
		try
		{
			m2R = m2R;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Rg0)(object)s6J.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (m2R)(object)s6J.Default;
					_ = (m1S6)(object)s6J.Default;
					c7B c7B2 = null;
					c7B2 = c7B2;
				}
			}
		}
		try
		{
			while ((object)s6J.Default != null)
			{
				_ = (m9B)(object)s6J.Default;
			}
		}
		finally
		{
			try
			{
				_ = (m9B)(object)s6J.Default;
			}
			finally
			{
				try
				{
					_ = (x2K9)(object)s6J.Default;
				}
				finally
				{
					_ = (m2R)(object)s6J.Default;
					goto IL_0398;
				}
			}
		}
	}
}
