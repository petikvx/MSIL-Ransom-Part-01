using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
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
using j8P3;
using k6J;
using n0WD;
using n4M;
using n7K;
using o1N;
using p6S;
using y1M;
using y8D;

namespace o9R;

[DesignerGenerated]
public class Qg6 : Form
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
			EventHandler eventHandler = Fw2i;
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
			EventHandler eventHandler = Zq29;
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
			EventHandler eventHandler = f4EF;
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
			EventHandler eventHandler = o0QB;
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
			EventHandler eventHandler = s0SC;
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

	public Qg6()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)y2ZM);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Dx9();
	}

	[DebuggerNonUserCode]
	protected override void Ka2(bool Mo3)
	{
		try
		{
			if (Mo3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mo3);
		}
	}

	[DebuggerStepThrough]
	private void Dx9()
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

	private void Zq29(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void Fw2i(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void s0SC(object sender, EventArgs e)
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
		Cb3d();
	}

	public void Cb3d()
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

	internal static byte[] Ho83(byte[] y0AF, byte[] t9AZ, int Ry5r, int r9DB)
	{
		int num = checked(y0AF.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			y0AF[i] = (byte)(y0AF[i] ^ checked((byte)(t9AZ[unchecked(i % t9AZ.Length)] ^ ((i + unchecked(Ry5r % t9AZ.Length)) & Ry5r))));
		}
		return y0AF;
	}

	private void f4EF(object sender, EventArgs e)
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
		Cb3d();
	}

	private void o0QB(object sender, EventArgs e)
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
		Cb3d();
	}

	private void y2ZM(object sender, EventArgs e)
	{
		Cb3d();
	}

	internal static string[] Gg84()
	{
		y8R.x6L();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Em1.mDic.Add("AO", executingAssembly);
		return s9EJ.x3S8();
	}

	static void t4ED()
	{
		_ = (i0A1)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				try
				{
					while (true)
					{
						obj = a7W.Default;
						if (obj != null)
						{
							_ = (b6E)(object)a7W.Default;
							continue;
						}
						break;
					}
				}
				catch
				{
					num = default(UIntPtr);
					num = num;
					num = default(UIntPtr);
					if (num * (unchecked((nuint)(UIntPtr)a7W.Default) * num) == 0)
					{
						_ = (b6E)(object)a7W.Default;
					}
					else
					{
						Nm2f obj2 = (Nm2f)(object)a7W.Default;
						nm2f = nm2f;
						nm2f = obj2;
						_ = (y8R)(object)a7W.Default;
					}
				}
			}
			catch
			{
				do
				{
					if (num != 0)
					{
						jy = jy;
						jy = jy;
					}
					else
					{
						_ = (Ln53)(object)a7W.Default;
					}
				}
				while ((object)a7W.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		do
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Jy1)(object)a7W.Default;
					nn9a = nn9a;
					nn9a = null;
				}
				else
				{
					sm = null;
					sm = null;
				}
			}
			finally
			{
				continue;
			}
		}
		while ((object)a7W.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		try
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		finally
		{
			zo = zo;
			zo = null;
			_ = (Jy1)(object)a7W.Default;
			goto IL_0133;
		}
		IL_03fa:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) * num == 0)
				{
					nm2f = nm2f;
				}
				else
				{
					j3J = j3J;
					s9EJ s9EJ = null;
				}
			}
			catch
			{
				try
				{
					i0A = i0A;
				}
				catch
				{
					_ = (Nn9a)(object)a7W.Default;
					nm2f = nm2f;
				}
			}
			finally
			{
				_ = (b1YL)(object)a7W.Default;
				goto IL_0458;
			}
		}
		IL_04e1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			y8R = null;
		}
		finally
		{
			try
			{
				_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			}
			finally
			{
				_ = (Sm6)(object)a7W.Default;
				goto IL_0509;
			}
		}
		IL_0458:
		if (num == 0)
		{
			sm = null;
		}
		else
		{
			while (obj != null)
			{
				do
				{
					_ = (Ta6)(object)a7W.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			_ = (i0A1)(object)a7W.Default;
		}
		finally
		{
			_ = (_003CModule_003E)(object)a7W.Default;
			goto IL_0497;
		}
		IL_0133:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			try
			{
				y8R = null;
				y8R = y8R;
			}
			catch
			{
				a1B = a1B;
				a1B = a1B;
			}
			finally
			{
				_ = (Nm2f)(object)a7W.Default;
				i0A = i0A;
				i0A = null;
				a7W obj8 = a7W.Default;
				a7W = a7W;
				a7W = obj8;
				_ = (Ta6)(object)a7W.Default;
				goto end_IL_0134;
			}
			end_IL_0134:;
		}
		catch
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
			catch
			{
				try
				{
					_ = (Ln53)(object)a7W.Default;
					j3J = null;
					j3J = j3J;
					_ = (Nn9a)(object)a7W.Default;
					goto end_IL_01b2;
				}
				catch
				{
					_ = (a1B)(object)a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
					a7W = a7W.Default;
					goto end_IL_01b2;
				}
				end_IL_01b2:;
			}
		}
		try
		{
			_ = (Ln53)(object)a7W.Default;
			_ = a7W.Default;
			_ = (Ln53)(object)a7W.Default;
			jy = jy;
		}
		catch
		{
			_ = (Ta6)(object)a7W.Default;
			_ = (Qg6)(object)a7W.Default;
		}
		try
		{
			_003CModule_003E obj13 = (_003CModule_003E)(object)a7W.Default;
			_003CModule_003E = null;
			_003CModule_003E = obj13;
		}
		catch
		{
			do
			{
				nn9a = nn9a;
			}
			while (obj != null);
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (checked(num - num - num) == 0)
			{
				try
				{
					s9EJ s9EJ = s9EJ;
					s9EJ = s9EJ;
					_ = (Ta6)(object)a7W.Default;
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				catch
				{
					nm2f = (Nm2f)(object)a7W.Default;
				}
			}
		}
		_ = (Nm2f)(object)a7W.Default;
		nm2f = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (En1)(object)a7W.Default;
					j3J = null;
				}
			}
			finally
			{
				while (obj != null)
				{
					En1 obj16 = (En1)(object)a7W.Default;
					en = en;
					en = obj16;
				}
				continue;
			}
		}
		while (obj != null);
		while (obj != null)
		{
			_ = (Em1)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					b1YL = null;
					b1YL = b1YL;
				}
			}
		}
		else if (num == 0)
		{
			if (num == 0)
			{
				_ = (Qg6)(object)a7W.Default;
			}
			else
			{
				a1B = (a1B)(object)a7W.Default;
			}
		}
		nn9a = nn9a;
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					b1YL = b1YL;
					jy = null;
				}
			}
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					_ = a7W.Default;
				}
				catch
				{
					j3J = j3J;
					i0A = null;
					sm = sm;
				}
			}
		}
		try
		{
			do
			{
				if (num == 0)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			goto IL_03fa;
		}
		IL_0497:
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					y8R = y8R;
				}
			}
			finally
			{
				Ln53 ln = ln;
				ln = ln;
				goto end_IL_0498;
			}
			end_IL_0498:;
		}
		finally
		{
			do
			{
				_ = (b1YL)(object)a7W.Default;
			}
			while ((object)a7W.Default != null);
			goto IL_04e1;
		}
		IL_0509:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		if (num == 0)
		{
			if (num == 0)
			{
				sm = (Sm6)(object)a7W.Default;
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					qg = (Qg6)(object)a7W.Default;
					qg = null;
				}
			}
		}
		do
		{
			if (num != 0)
			{
				_ = (a1B)(object)a7W.Default;
				zo = zo;
				_ = (_003CModule_003E)(object)a7W.Default;
			}
			else
			{
				en = (En1)(object)a7W.Default;
				_ = (Zo8)(object)a7W.Default;
			}
		}
		while (obj != null);
		_ = (b1YL)(object)a7W.Default;
		if (num == 0)
		{
			nuint num2 = num;
			num = default(UIntPtr);
			if (checked(num2 + num) == 0)
			{
				do
				{
					y8R = (y8R)(object)a7W.Default;
				}
				while (obj != null);
			}
			else if (num == 0)
			{
				a1B = a1B;
			}
		}
		else
		{
			sm = sm;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				em = null;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				b1YL = b1YL;
				_ = (Ln53)(object)a7W.Default;
			}
			finally
			{
				do
				{
					_003CModule_003E = null;
				}
				while (obj != null);
				goto IL_0689;
			}
		}
		goto IL_0689;
		IL_0689:
		while (obj != null)
		{
			if (checked(unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (Nn9a)(object)a7W.Default;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				j3J = (j3J)(object)a7W.Default;
				en = en;
				_ = (_003CModule_003E)(object)a7W.Default;
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				UIntPtr num3 = (UIntPtr)a7W.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) - (unchecked((nuint)default(UIntPtr)) + unchecked(num / checked(unchecked((nuint)(UIntPtr)a7W.Default) - num)) - unchecked((nuint)default(UIntPtr))) == 0)
					{
						_ = (Em1)(object)a7W.Default;
					}
				}
			}
			else
			{
				qg = null;
				a7W = a7W;
			}
		}
		while (obj != null)
		{
			try
			{
				sm = (Sm6)(object)a7W.Default;
			}
			catch
			{
				sm = sm;
			}
			finally
			{
				try
				{
					nm2f = nm2f;
				}
				finally
				{
					_ = (En1)(object)a7W.Default;
					continue;
				}
			}
		}
		while (obj != null)
		{
			try
			{
				b1YL = null;
				_ = (Nm2f)(object)a7W.Default;
				_ = (Ln53)(object)a7W.Default;
			}
			finally
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					Ln53 ln = null;
				}
				continue;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			em = em;
			_ = (Nm2f)(object)a7W.Default;
			_ = a7W.Default;
		}
		else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)a7W.Default != null)
			{
				qg = qg;
			}
		}
		_ = (b6E)(object)a7W.Default;
	}
}
