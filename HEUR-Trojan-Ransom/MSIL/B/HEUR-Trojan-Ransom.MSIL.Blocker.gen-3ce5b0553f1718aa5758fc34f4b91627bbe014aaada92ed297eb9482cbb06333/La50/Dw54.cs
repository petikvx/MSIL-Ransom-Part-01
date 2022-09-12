using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
using s6Y;
using w7Y6;
using w8E;

namespace La50;

[DesignerGenerated]
public class Dw54 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

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
			EventHandler eventHandler = o3WJ;
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

	[field: AccessedThroughProperty("txtTid")]
	internal virtual TextBox txtTid
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("txtTCost")]
	internal virtual TextBox txtTCost
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTDistance")]
	internal virtual TextBox txtTDistance
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTMode")]
	internal virtual TextBox txtTMode
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
			EventHandler eventHandler = k7GF;
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
			EventHandler eventHandler = Lk6c;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = m6YP;
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
			EventHandler eventHandler = Hq92;
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

	public Dw54()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Pz4e);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		q0MD();
	}

	[DebuggerNonUserCode]
	protected override void Sc81(bool o6RG)
	{
		try
		{
			if (o6RG && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o6RG);
		}
	}

	[DebuggerStepThrough]
	private void q0MD()
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
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		btnSave = new Button();
		txtTid = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		txtTCost = new TextBox();
		txtTDistance = new TextBox();
		txtTMode = new TextBox();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		DataGridView1 = new DataGridView();
		btnModify = new Button();
		btnDelete = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnSave).set_Location(new Point(160, 202));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(4);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)txtTid).set_Location(new Point(173, 40));
		((Control)txtTid).set_Name("txtTid");
		((Control)txtTid).set_Size(new Size(100, 20));
		((Control)txtTid).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(58, 90));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(82, 13));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Transport Cost :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(58, 47));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(70, 13));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Transport Id :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(46, 125));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(103, 13));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Transport Distance :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(46, 158));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(88, 13));
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("Transport Mode :");
		((Control)txtTCost).set_Location(new Point(173, 83));
		((Control)txtTCost).set_Name("txtTCost");
		((Control)txtTCost).set_Size(new Size(100, 20));
		((Control)txtTCost).set_TabIndex(1);
		((Control)txtTDistance).set_Location(new Point(173, 125));
		((Control)txtTDistance).set_Name("txtTDistance");
		((Control)txtTDistance).set_Size(new Size(100, 20));
		((Control)txtTDistance).set_TabIndex(2);
		((Control)txtTMode).set_Location(new Point(173, 158));
		((Control)txtTMode).set_Name("txtTMode");
		((Control)txtTMode).set_Size(new Size(100, 20));
		((Control)txtTMode).set_TabIndex(3);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(341, 19));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(126, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Transport Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(731, 19));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(39, 19));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(7);
		Label7.set_Text("Go To Main");
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(32, 239));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(599, 199));
		((Control)DataGridView1).set_TabIndex(10);
		((Control)btnModify).set_Location(new Point(268, 202));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 23));
		((Control)btnModify).set_TabIndex(5);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		((Control)btnDelete).set_Location(new Point(380, 202));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 23));
		((Control)btnDelete).set_TabIndex(6);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtTMode);
		((Control)this).get_Controls().Add((Control)(object)txtTDistance);
		((Control)this).get_Controls().Add((Control)(object)txtTCost);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtTid);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmTransportDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmTransportDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void o3WJ(object sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_transport values(" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())) + ",'" + txtTCost.get_Text() + "'," + txtTDistance.get_Text() + ",'" + txtTMode.get_Text() + "')");
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
		y5GW();
	}

	public void y5GW()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_transport");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Transport Id");
			DataGridView1.get_Columns().Add("c2", "Transport Cost");
			DataGridView1.get_Columns().Add("c3", "Transport Distance");
			DataGridView1.get_Columns().Add("c4", "Transport Mode");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[4]
				{
					rd.get_Item("transportid").ToString(),
					rd.get_Item("transportcost"),
					rd.get_Item("transportdistance").ToString(),
					rd.get_Item("transportmode")
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

	private void Lk6c(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void k7GF(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Pz4e(object sender, EventArgs e)
	{
		y5GW();
	}

	private void m6YP(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_transport set transportcost ='" + txtTCost.get_Text() + "',transportdistance=" + txtTDistance.get_Text() + ",transportmode='" + txtTMode.get_Text() + "' where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
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
		y5GW();
	}

	private void Hq92(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_transport where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
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
		y5GW();
	}

	internal static bool Jc5s()
	{
		try
		{
			try
			{
				m9B.mDic.Add(m9B.T, Assembly.Load((byte[])m9B.mDic[m9B.mArray]).GetExportedTypes()[27]);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	static void n5AW()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9B m9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		try
		{
			num = (UIntPtr)s6J.Default;
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					_ = (Dw54)(object)s6J.Default;
					_ = (g2M8)(object)s6J.Default;
					_ = (Wm5)(object)s6J.Default;
					c7R = c7R;
					c7R = null;
					obj = s6J.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			while ((object)s6J.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					m9B = m9B;
					m9B = m9B;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		if (num == 0)
		{
			try
			{
				a0E = (a0E)(object)s6J.Default;
				a0E = null;
			}
			catch
			{
				try
				{
					tb = null;
					tb = tb;
				}
				catch
				{
					_ = (x2K9)(object)s6J.Default;
				}
			}
		}
		else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				c7R = c7R;
			}
			finally
			{
				_ = (x2K9)(object)s6J.Default;
				goto IL_00f1;
			}
		}
		goto IL_00f1;
		IL_02b6:
		c7B c7B;
		Wm5 wm;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Wm5)(object)s6J.Default;
				}
				catch
				{
					tb = tb;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (Dw54)(object)s6J.Default;
				}
			}
		}
		else
		{
			try
			{
				try
				{
					c7B = null;
				}
				finally
				{
					_ = (Qy5m)(object)s6J.Default;
					goto end_IL_02fa;
				}
				end_IL_02fa:;
			}
			catch
			{
				UIntPtr num2 = (UIntPtr)s6J.Default;
				nuint num3 = num;
				UIntPtr num4 = (UIntPtr)s6J.Default;
				num = default(UIntPtr);
				if (checked(unchecked((nuint)num2) * (num3 + (unchecked((nuint)num4) - num))) / (nuint)(UIntPtr)s6J.Default == 0)
				{
					wm = (Wm5)(object)s6J.Default;
				}
				else
				{
					m9B = m9B;
					_ = (a0E)(object)s6J.Default;
					_ = (a0E)(object)s6J.Default;
					_ = (g2M8)(object)s6J.Default;
				}
			}
		}
		_ = (o7A)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (d9N2)(object)s6J.Default;
		}
		else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				x2K = x2K;
				x2K = x2K;
			}
			finally
			{
				_ = (d9N2)(object)s6J.Default;
				goto IL_03d2;
			}
		}
		goto IL_03d2;
		IL_079c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		if (num == (UIntPtr)(nuint)0u)
		{
			a0E = a0E;
		}
		else
		{
			if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					x2K = x2K;
					_ = (Dw54)(object)s6J.Default;
				}
				finally
				{
					_ = (Dw54)(object)s6J.Default;
					m2R = null;
					_ = (d9N2)(object)s6J.Default;
					goto IL_083f;
				}
			}
			c7B = c7B;
		}
		goto IL_083f;
		IL_083f:
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Wm5)(object)s6J.Default;
				}
				catch
				{
					_ = (Rg0)(object)s6J.Default;
					_ = (Pg6)(object)s6J.Default;
					m9B = (m9B)(object)s6J.Default;
				}
			}
			else
			{
				m2R = m2R;
			}
		}
		while (obj != null);
		Pg6 pg = pg;
		tb = tb;
		_ = (c7R)(object)s6J.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				d9N = d9N;
			}
			while ((object)s6J.Default != null || (object)s6J.Default != null);
		}
		else if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			_ = s6J.Default;
		}
		return;
		IL_03d2:
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (c7B)(object)s6J.Default;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num / num == 0)
				{
					_ = (Wm5)(object)s6J.Default;
					_ = (m1S6)(object)s6J.Default;
					x2K = x2K;
					m9B = (m9B)(object)s6J.Default;
				}
				else
				{
					_ = (x2K9)(object)s6J.Default;
				}
			}
		}
		catch
		{
			tb = tb;
		}
		Qy5m qy5m = qy5m;
		qy5m = qy5m;
		_ = s6J.Default;
		_ = (m1S6)(object)s6J.Default;
		try
		{
			do
			{
				if (num == 0)
				{
					x2K = null;
				}
			}
			while ((object)s6J.Default != null);
		}
		catch
		{
			do
			{
				_ = (a0E)(object)s6J.Default;
			}
			while (obj != null);
		}
		try
		{
			g2M8 g2M = g2M;
			g2M = null;
		}
		catch
		{
			_ = (g2M8)(object)s6J.Default;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (o7A)(object)s6J.Default;
		}
		else if (num == 0)
		{
			Dw54 dw = dw;
			dw = dw;
		}
		Ap93 ap;
		if (num == 0)
		{
			ap = (Ap93)(object)s6J.Default;
			ap = null;
		}
		try
		{
			try
			{
				m2R = m2R;
				m2R = m2R;
			}
			finally
			{
				while (obj != null)
				{
					a0E = a0E;
				}
				goto end_IL_051a;
			}
			end_IL_051a:;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Wm5)(object)s6J.Default;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
					goto end_IL_0557;
				}
				finally
				{
					x2K = (x2K9)(object)s6J.Default;
					goto end_IL_0557;
				}
				end_IL_0557:;
			}
		}
		d9N = null;
		a0E = a0E;
		ap = (Ap93)(object)s6J.Default;
		_ = (_003CModule_003E)(object)s6J.Default;
		_ = (_003CModule_003E)(object)s6J.Default;
		Rg0 rg;
		do
		{
			try
			{
				_ = (c7B)(object)s6J.Default;
				_ = (a0E)(object)s6J.Default;
				qy5m = qy5m;
				qy5m = null;
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					rg = null;
				}
				else
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
		}
		while (obj != null);
		wm = (Wm5)(object)s6J.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (m1S6)(object)s6J.Default;
					_ = s6J.Default;
					_ = (Qy5m)(object)s6J.Default;
					_ = (Dw54)(object)s6J.Default;
				}
				else if ((object)s6J.Default == null)
				{
					break;
				}
			}
		}
		_ = (Qy5m)(object)s6J.Default;
		while (obj != null)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					m9B = (m9B)(object)s6J.Default;
				}
				else
				{
					ap = ap;
				}
			}
			catch
			{
				_ = (a0E)(object)s6J.Default;
			}
		}
		try
		{
			do
			{
				_ = (a0E)(object)s6J.Default;
				_ = (_003CModule_003E)(object)s6J.Default;
				_ = (d9N2)(object)s6J.Default;
				_ = (m9B)(object)s6J.Default;
			}
			while ((object)s6J.Default != null || obj != null);
		}
		catch
		{
			_ = (Ap93)(object)s6J.Default;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					x2K = x2K;
					pg = pg;
					_ = (c7R)(object)s6J.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (a0E)(object)s6J.Default;
				}
				else
				{
					_ = (Pg6)(object)s6J.Default;
				}
				goto IL_079c;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		try
		{
			try
			{
				m1S = m1S;
				rg = rg;
				_ = (g2M8)(object)s6J.Default;
			}
			finally
			{
				rg = null;
				goto end_IL_074f;
			}
			end_IL_074f:;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				m1S = m1S;
			}
			else
			{
				c7R = (c7R)(object)s6J.Default;
			}
			goto IL_079c;
		}
		IL_00f1:
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)s6J.Default / num) - num) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					_ = (a0E)(object)s6J.Default;
				}
				catch
				{
					pg = (Pg6)(object)s6J.Default;
					pg = pg;
				}
			}
		}
		catch
		{
			_ = (x2K9)(object)s6J.Default;
		}
		_ = (m9B)(object)s6J.Default;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					c7B = (c7B)(object)s6J.Default;
					c7B = c7B;
				}
				while (obj != null);
			}
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					_ = (_003CModule_003E)(object)s6J.Default;
					continue;
				}
				wm = (Wm5)(object)s6J.Default;
				wm = wm;
			}
			while (obj != null);
		}
		try
		{
			m9B = m9B;
		}
		catch
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o7A)(object)s6J.Default;
			}
		}
		do
		{
			_ = (Dw54)(object)s6J.Default;
			_ = (c7B)(object)s6J.Default;
			d9N = d9N;
			d9N = d9N;
			c7B = (c7B)(object)s6J.Default;
		}
		while (obj != null);
		if (num == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (c7B)(object)s6J.Default;
				}
				while (obj != null);
			}
			else if (num == 0)
			{
				_ = (x2K9)(object)s6J.Default;
			}
		}
		else
		{
			pg = null;
		}
		rg = (Rg0)(object)s6J.Default;
		rg = null;
		_ = (_003CModule_003E)(object)s6J.Default;
		try
		{
			tb = tb;
			c7R = c7R;
			d9N = d9N;
			m9B = m9B;
		}
		finally
		{
			while (obj != null)
			{
				_ = (m2R)(object)s6J.Default;
			}
			goto IL_02b6;
		}
	}

	static void Wg06()
	{
		object obj;
		try
		{
			_ = (Tb9)(object)s6J.Default;
		}
		finally
		{
			do
			{
				obj = s6J.Default;
			}
			while (obj != null);
			goto IL_0024;
		}
		IL_0024:
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9B m9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		checked
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					try
					{
						tb = null;
						tb = tb;
					}
					catch
					{
						_ = (Rg0)(object)s6J.Default;
					}
				}
			}
			else
			{
				try
				{
					if (uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (_003CModule_003E)(object)s6J.Default;
					}
					else
					{
						_ = (Wm5)(object)s6J.Default;
						s6J obj3 = s6J.Default;
						s6J = s6J;
						s6J = obj3;
						tb = null;
					}
				}
				catch
				{
					_ = (m2R)(object)s6J.Default;
				}
			}
			pg = pg;
			pg = null;
			if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u) && unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				do
				{
					_ = (m2R)(object)s6J.Default;
				}
				while (obj != null);
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (m2R)(object)s6J.Default;
				goto IL_017c;
			}
			try
			{
				_ = (o7A)(object)s6J.Default;
			}
			catch
			{
				qy5m = qy5m;
				qy5m = qy5m;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Wm5)(object)s6J.Default;
				}
				else
				{
					m9B = m9B;
					m9B = m9B;
				}
				goto IL_017c;
			}
		}
		IL_017c:
		while ((object)s6J.Default != null)
		{
		}
		pg = null;
		_ = (m1S6)(object)s6J.Default;
		x2K9 x2K = (x2K9)(object)s6J.Default;
		x2K = x2K;
		_ = (c7B)(object)s6J.Default;
		try
		{
			while (obj != null)
			{
				try
				{
					tb = null;
				}
				finally
				{
					_ = (Ap93)(object)s6J.Default;
					continue;
				}
			}
		}
		catch
		{
			_ = (Tb9)(object)s6J.Default;
		}
		_ = (_003CModule_003E)(object)s6J.Default;
		_ = s6J.Default;
		while (true)
		{
			if ((object)s6J.Default != null)
			{
				tb = null;
			}
			else if (obj == null && obj == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		try
		{
			try
			{
				o7A = null;
				o7A = o7A;
				x2K = (x2K9)(object)s6J.Default;
				_ = (c7B)(object)s6J.Default;
				_ = (Qy5m)(object)s6J.Default;
			}
			catch
			{
				o7A = o7A;
			}
			finally
			{
				a0E = a0E;
				a0E = a0E;
				_ = (Dw54)(object)s6J.Default;
				_ = (o7A)(object)s6J.Default;
				goto end_IL_0220;
			}
			end_IL_0220:;
		}
		finally
		{
			goto IL_028e;
		}
		IL_04ca:
		pg = (Pg6)(object)s6J.Default;
		_ = (c7R)(object)s6J.Default;
		pg = pg;
		do
		{
			try
			{
				_ = (m2R)(object)s6J.Default;
			}
			catch
			{
				_ = (a0E)(object)s6J.Default;
			}
		}
		while (obj != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if (obj != null)
				{
					tb = tb;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)s6J.Default;
					x2K = (x2K9)(object)s6J.Default;
					_ = (Rg0)(object)s6J.Default;
					_ = (Dw54)(object)s6J.Default;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
				catch
				{
					x2K = x2K;
				}
			}
		}
		_ = (Rg0)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		if (uIntPtr == 0)
		{
			try
			{
				m1S6 m1S = null;
				m1S = m1S;
			}
			catch
			{
				_ = s6J.Default;
				_ = (Wm5)(object)s6J.Default;
				_ = (m2R)(object)s6J.Default;
				ap = ap;
			}
		}
		else
		{
			pg = pg;
		}
		_ = (g2M8)(object)s6J.Default;
		try
		{
			try
			{
			}
			finally
			{
				try
				{
					qy5m = qy5m;
					_ = (o7A)(object)s6J.Default;
					s6J = s6J;
				}
				catch
				{
					_ = (x2K9)(object)s6J.Default;
				}
				goto end_IL_0604;
			}
			end_IL_0604:;
		}
		finally
		{
			_ = (a0E)(object)s6J.Default;
			goto IL_0644;
		}
		IL_074a:
		_ = (Pg6)(object)s6J.Default;
		_ = (Ap93)(object)s6J.Default;
		_ = (m9B)(object)s6J.Default;
		return;
		IL_028e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
		if ((nuint)(UIntPtr)s6J.Default / (nuint)(UIntPtr)s6J.Default == 0)
		{
			try
			{
				do
				{
					_ = (a0E)(object)s6J.Default;
				}
				while (obj != null);
			}
			finally
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						d9N = d9N;
						d9N = d9N;
					}
					else
					{
						_ = (o7A)(object)s6J.Default;
					}
					goto IL_035d;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			_003CModule_003E obj12 = (_003CModule_003E)(object)s6J.Default;
			_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
			_003CModule_003E = obj12;
			_ = (Wm5)(object)s6J.Default;
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			else
			{
				_ = (Qy5m)(object)s6J.Default;
				d9N = d9N;
				a0E = a0E;
				_ = (m1S6)(object)s6J.Default;
			}
			goto IL_035d;
		}
		IL_0644:
		if (uIntPtr == 0)
		{
			try
			{
				_ = (m9B)(object)s6J.Default;
			}
			catch
			{
				Rg0 rg = rg;
				rg = null;
			}
			finally
			{
				_ = (Pg6)(object)s6J.Default;
				goto IL_06a4;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				_ = (m1S6)(object)s6J.Default;
			}
		}
		else
		{
			qy5m = qy5m;
		}
		goto IL_06a4;
		IL_06a4:
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				do
				{
					if (uIntPtr - unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						x2K = x2K;
					}
				}
				while (obj != null);
			}
		}
		else
		{
			_ = (m2R)(object)s6J.Default;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				_ = (Dw54)(object)s6J.Default;
			}
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (d9N2)(object)s6J.Default;
				}
				catch
				{
					_ = (Dw54)(object)s6J.Default;
					_ = (m1S6)(object)s6J.Default;
				}
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)s6J.Default;
		}
		finally
		{
			_ = (a0E)(object)s6J.Default;
			goto IL_074a;
		}
		IL_035d:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					tb = (Tb9)(object)s6J.Default;
				}
				while (obj != null);
			}
			else
			{
				while (obj != null)
				{
					_ = (g2M8)(object)s6J.Default;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (c7R)(object)s6J.Default;
					a0E = null;
					_ = (Dw54)(object)s6J.Default;
					_ = (Dw54)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			goto IL_03d1;
		}
		IL_03d1:
		_ = s6J.Default;
		do
		{
			_ = (Dw54)(object)s6J.Default;
		}
		while (obj != null);
		checked
		{
			try
			{
				if ((unchecked((nuint)(UIntPtr)s6J.Default) - uIntPtr * uIntPtr) * (uIntPtr * uIntPtr) == 0)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
					}
					catch
					{
						_003CModule_003E = _003CModule_003E;
						_ = (Tb9)(object)s6J.Default;
					}
				}
			}
			catch
			{
				if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
				{
					if (uIntPtr * uIntPtr == 0)
					{
						m9B = null;
					}
				}
				else
				{
					while ((object)s6J.Default != null)
					{
						_ = (c7B)(object)s6J.Default;
						ap = ap;
						ap = ap;
						_ = (d9N2)(object)s6J.Default;
					}
				}
			}
			try
			{
				while (obj != null)
				{
					try
					{
						_ = (x2K9)(object)s6J.Default;
					}
					finally
					{
						o7A = o7A;
						m9B = m9B;
						continue;
					}
				}
			}
			finally
			{
				do
				{
					_ = (Rg0)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
				goto IL_04ca;
			}
		}
	}
}
