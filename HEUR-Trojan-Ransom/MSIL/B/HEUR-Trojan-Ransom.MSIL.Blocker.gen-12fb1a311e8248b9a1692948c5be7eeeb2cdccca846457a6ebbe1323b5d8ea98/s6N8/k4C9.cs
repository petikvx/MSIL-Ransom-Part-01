using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using Yz5;
using a3S0;
using a7A;
using c9P;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using j6N2;
using k7R;
using q4PZ;
using w0WN;
using x5PX;

namespace s6N8;

[DesignerGenerated]
public class k4C9 : Form
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
			byte[] byte_ = Tf67.byte_0;
			int num = 1;
			while (true)
			{
				IL_0063:
				EventHandler eventHandler = Ee9t;
				Label label = _Label6;
				if (label == null)
				{
					num = 0;
					goto IL_004f;
				}
				num = 5;
				goto IL_0048;
				IL_004f:
				while (true)
				{
					IL_004f_2:
					_Label6 = value;
					label = _Label6;
					while (true)
					{
						if (label == null)
						{
							switch (byte_[64])
							{
							case 210:
								break;
							case 209:
							case 211:
								goto end_IL_0043;
							case 204:
								goto IL_004f_2;
							default:
								goto IL_0063;
							case 207:
							case 208:
								goto IL_007e;
							case 206:
								return;
							}
							continue;
						}
						num = 3;
						goto IL_007e;
						IL_007e:
						((Control)label).add_Click(eventHandler);
						return;
						continue;
						end_IL_0043:
						break;
					}
					break;
				}
				goto IL_0048;
				IL_0048:
				((Control)label).remove_Click(eventHandler);
				goto IL_004f;
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
			EventHandler eventHandler = o9B3;
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
			EventHandler eventHandler = k5K8;
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
			EventHandler eventHandler = Wm06;
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
			EventHandler eventHandler = Yi65;
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

	public k4C9()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d3N5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		b2PD();
	}

	[DebuggerNonUserCode]
	protected override void Bg46(bool Tz32)
	{
		try
		{
			if (Tz32 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Tz32);
		}
	}

	[DebuggerStepThrough]
	private void b2PD()
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
		Tf67.byte_0[128] = (byte)((Tf67.byte_0[128] * Hi84.char_0[290]) & 0x6D);
	}

	private void o9B3(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void Ee9t(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Yi65(object sender, EventArgs e)
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
		Fj7s();
		Tf67.byte_0[99] = (byte)((Tf67.byte_0[99] * Tf67.byte_0[27]) & 0x4C);
	}

	public void Fj7s()
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
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
			while (true)
			{
				bool num = rd.Read();
				Hi84.char_0[353] = (char)(Hi84.char_0[353] & Tf67.byte_0[33] & 'v');
				if (num)
				{
					DataGridView1.get_Rows().Add(new object[5]
					{
						rd.get_Item("pid").ToString(),
						rd.get_Item("pcost").ToString(),
						rd.get_Item("pstock"),
						rd.get_Item("stockweight"),
						rd.get_Item("productionmachine")
					});
					continue;
				}
				break;
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

	internal static byte[] y6C0(byte[] Wo9z, byte[] z4K1, int Xx09, int r5Z4)
	{
		checked
		{
			int num = Wo9z.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i;
				byte num3 = Wo9z[i];
				byte num4 = (byte)(z4K1[unchecked(i % z4K1.Length)] ^ ((i + unchecked(Xx09 % z4K1.Length)) & Xx09));
				unchecked
				{
					Tf67.byte_0[70] = (byte)((Tf67.byte_0[70] + Xx09) & 0x3C);
					Wo9z[num2] = (byte)(num3 ^ num4);
				}
			}
			return Wo9z;
		}
	}

	private void k5K8(object sender, EventArgs e)
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
		Fj7s();
		Tf67.byte_0[29] = (byte)((Tf67.byte_0[29] - Tf67.byte_0[43]) & 0x75);
	}

	private void Wm06(object sender, EventArgs e)
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
		Fj7s();
		Tf67.byte_0[52] = (byte)((Tf67.byte_0[52] * Tf67.byte_0[41]) & 0xD0);
	}

	private void d3N5(object sender, EventArgs e)
	{
		Fj7s();
	}

	internal static string[] q8E5()
	{
		x4N6.q0P6();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		f5R4.mDic.Add("AO", executingAssembly);
		return g9Z.Yx5();
	}

	static void Sf6j()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		while ((object)o0E3.Default != null)
		{
			UIntPtr num = (UIntPtr)o0E3.Default;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num) * num2 == 0)
				{
					try
					{
						_ = (k4C9)(object)o0E3.Default;
					}
					catch
					{
						zn1b = zn1b;
						zn1b = null;
					}
				}
			}
		}
		try
		{
			try
			{
				_ = (w0A)(object)o0E3.Default;
			}
			finally
			{
				_ = (Zn1b)(object)o0E3.Default;
				_ = (g9Z)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
				goto end_IL_0047;
			}
			end_IL_0047:;
		}
		catch
		{
		}
		w8W w8W = default(w8W);
		w8W = default(w8W);
		Et0 et;
		try
		{
			if (num2 == 0)
			{
				Gn76 gn = gn;
				gn = null;
			}
		}
		finally
		{
			et = default(Et0);
			goto IL_00d2;
		}
		IL_04ab:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		while (obj3 != null)
		{
			while ((object)o0E3.Default != null)
			{
				do
				{
					_ = (p9B)(object)o0E3.Default;
					_ = (p9B)(object)o0E3.Default;
					i5NX = i5NX;
				}
				while (obj3 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)o0E3.Default != null)
				{
					pg2c = pg2c;
					_003CModule_003E = null;
				}
			}
			else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				f5R = null;
			}
		}
		catch
		{
			_ = (i5NX)(object)o0E3.Default;
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (g9Z)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (g9Z)(object)o0E3.Default;
				}
			}
			else
			{
				_ = (w0A)(object)o0E3.Default;
			}
		}
		else
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k0WR)(object)o0E3.Default;
					et = default(Et0);
				}
				finally
				{
					_ = (Pg2c)(object)o0E3.Default;
					goto IL_05b2;
				}
			}
			if (num2 == (UIntPtr)(nuint)0u)
			{
				_ = (p9B)(object)o0E3.Default;
			}
			else
			{
				_ = (k0WR)(object)o0E3.Default;
			}
		}
		goto IL_05b2;
		IL_05b2:
		if (num2 == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (g9Z)(object)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
			return;
		}
		w0A w0A;
		try
		{
			pg2c = (Pg2c)(object)o0E3.Default;
			return;
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
				return;
			}
			finally
			{
				w0A = w0A;
				return;
			}
		}
		IL_0407:
		w0A = null;
		_ = (p9B)(object)o0E3.Default;
		_ = (w0A)(object)o0E3.Default;
		p9B p9B = p9B;
		while (obj3 != null)
		{
			do
			{
				f5R = null;
			}
			while (obj3 != null);
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			x4N6 x4N = x4N;
			x4N = x4N;
		}
		else if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Sf06)(object)o0E3.Default;
			}
			finally
			{
				_ = (Pg2c)(object)o0E3.Default;
				goto IL_04ab;
			}
		}
		goto IL_04ab;
		IL_00d2:
		_ = (w1H)(object)o0E3.Default;
		o0E3 o0E;
		if (num2 == 0)
		{
			o0E3 obj5 = o0E3.Default;
			o0E = null;
			o0E = obj5;
		}
		a9X obj6 = (a9X)(object)o0E3.Default;
		a9X a9X = null;
		a9X = obj6;
		if (num2 == 0)
		{
			_ = o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					Hi84 obj7 = (Hi84)(object)o0E3.Default;
					hi = null;
					hi = obj7;
				}
				while ((object)o0E3.Default != null);
			}
			else
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				catch
				{
					a9X = a9X;
				}
			}
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				w0A = null;
			}
		}
		try
		{
			try
			{
				_ = (x4N6)(object)o0E3.Default;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				else
				{
					_ = (Hi84)(object)o0E3.Default;
				}
				goto end_IL_017c;
			}
			end_IL_017c:;
		}
		finally
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
				else
				{
					_ = (k4C9)(object)o0E3.Default;
				}
			}
			catch
			{
				if (num2 == 0)
				{
					i5NX = i5NX;
					i5NX = null;
				}
			}
			goto IL_01f1;
		}
		IL_01f1:
		try
		{
			zn1b = zn1b;
		}
		catch
		{
			if (num2 == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Zn1b)(object)o0E3.Default;
				}
			}
			else
			{
				_ = (w1H)(object)o0E3.Default;
				_ = (Sf06)(object)o0E3.Default;
				_ = (i5NX)(object)o0E3.Default;
				_ = (k4C9)(object)o0E3.Default;
			}
		}
		do
		{
			o0E = o0E3.Default;
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			Pg2c obj12 = (Pg2c)(object)o0E3.Default;
			pg2c = pg2c;
			pg2c = obj12;
		}
		p9B = null;
		p9B = p9B;
		_ = (Zn1b)(object)o0E3.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (k4C9)(object)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		else
		{
			do
			{
				o0E = o0E3.Default;
			}
			while (obj3 != null);
		}
		while (obj3 != null || obj3 != null)
		{
		}
		_ = (k4C9)(object)o0E3.Default;
		do
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
		}
		while (obj3 != null);
		do
		{
			_ = (g9Z)(object)o0E3.Default;
		}
		while (obj3 != null);
		try
		{
			f5R = f5R;
			f5R = null;
		}
		catch
		{
			while ((object)o0E3.Default != null)
			{
				_ = (w8W)o0E3.Default;
			}
		}
		hi = hi;
		et = (Et0)o0E3.Default;
		do
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			catch
			{
				while (obj3 != null)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
		}
		while (obj3 != null);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					pg2c = (Pg2c)(object)o0E3.Default;
				}
				finally
				{
					o0E = o0E;
					goto end_IL_03af;
				}
				end_IL_03af:;
			}
			finally
			{
				try
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				finally
				{
					f5R = f5R;
					goto IL_0407;
				}
			}
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (i5NX)(object)o0E3.Default;
			}
			catch
			{
				_ = (Sf06)(object)o0E3.Default;
			}
		}
		goto IL_0407;
	}
}
