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

namespace f0B;

[DesignerGenerated]
public class m2R : Form
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
			EventHandler eventHandler = Ba1;
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
			EventHandler eventHandler = z0H;
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

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
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
			EventHandler eventHandler = s0N;
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
			EventHandler eventHandler = Yo5;
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

	[field: AccessedThroughProperty("txtPCode")]
	internal virtual TextBox txtPCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPRaw")]
	internal virtual TextBox txtPRaw
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

	[field: AccessedThroughProperty("txtPDate")]
	internal virtual TextBox txtPDate
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
			EventHandler eventHandler = e2J;
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("txtRWeight")]
	internal virtual TextBox txtRWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public m2R()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)b7H);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		p6L();
	}

	[DebuggerNonUserCode]
	protected override void Ze9(bool o0P)
	{
		try
		{
			if (o0P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o0P);
		}
	}

	[DebuggerStepThrough]
	private void p6L()
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
		txtPId = new TextBox();
		btnDelete = new Button();
		btnModify = new Button();
		DataGridView1 = new DataGridView();
		txtPCode = new TextBox();
		txtPMachine = new TextBox();
		txtPRaw = new TextBox();
		Label2 = new Label();
		txtPDate = new TextBox();
		btnSave = new Button();
		Label1 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		txtRWeight = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(331, 27));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(135, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Processing Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(742, 27));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(50, 27));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("Go To Main");
		((Control)txtPId).set_Location(new Point(242, 72));
		((Control)txtPId).set_Name("txtPId");
		((Control)txtPId).set_Size(new Size(100, 20));
		((Control)txtPId).set_TabIndex(0);
		((Control)btnDelete).set_Location(new Point(417, 183));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(8);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(417, 129));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(7);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(53, 241));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(707, 206));
		((Control)DataGridView1).set_TabIndex(11);
		((Control)txtPCode).set_Location(new Point(242, 183));
		((Control)txtPCode).set_Name("txtPCode");
		((Control)txtPCode).set_Size(new Size(100, 20));
		((Control)txtPCode).set_TabIndex(4);
		((Control)txtPMachine).set_Location(new Point(242, 156));
		((Control)txtPMachine).set_Name("txtPMachine");
		((Control)txtPMachine).set_Size(new Size(100, 20));
		((Control)txtPMachine).set_TabIndex(3);
		((Control)txtPRaw).set_Location(new Point(242, 129));
		((Control)txtPRaw).set_Name("txtPRaw");
		((Control)txtPRaw).set_Size(new Size(100, 20));
		((Control)txtPRaw).set_TabIndex(2);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(164, 75));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(63, 13));
		((Control)Label2).set_TabIndex(33);
		Label2.set_Text("Process Id :");
		((Control)txtPDate).set_Location(new Point(242, 99));
		((Control)txtPDate).set_Name("txtPDate");
		((Control)txtPDate).set_Size(new Size(100, 20));
		((Control)txtPDate).set_TabIndex(1);
		((Control)btnSave).set_Location(new Point(417, 72));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(6);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(150, 102));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(77, 13));
		((Control)Label1).set_TabIndex(43);
		Label1.set_Text("Process Date :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(150, 136));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(76, 13));
		((Control)Label4).set_TabIndex(44);
		Label4.set_Text("Process Raw :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(132, 163));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(95, 13));
		((Control)Label5).set_TabIndex(45);
		Label5.set_Text("Process Machine :");
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(134, 186));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(93, 13));
		((Control)Label8).set_TabIndex(46);
		Label8.set_Text("Processing Code :");
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(155, 212));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(72, 13));
		((Control)Label9).set_TabIndex(48);
		Label9.set_Text("Raw Weight :");
		((Control)txtRWeight).set_Location(new Point(242, 209));
		((Control)txtRWeight).set_Name("txtRWeight");
		((Control)txtRWeight).set_Size(new Size(100, 20));
		((Control)txtRWeight).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)txtRWeight);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtPId);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)txtPCode);
		((Control)this).get_Controls().Add((Control)(object)txtPMachine);
		((Control)this).get_Controls().Add((Control)(object)txtPRaw);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)txtPDate);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmProcessingDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmProcessingDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void z0H(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void Ba1(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void b7H(object sender, EventArgs e)
	{
	}

	private void e2J(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ",'" + txtPDate.get_Text() + "','" + txtPRaw.get_Text() + "','" + txtPMachine.get_Text() + "','" + txtPCode.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtRWeight.get_Text())) + ")");
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
		Gr0();
	}

	public void Gr0()
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Processing Id");
			DataGridView1.get_Columns().Add("c2", "Processing Date");
			DataGridView1.get_Columns().Add("c3", "Processing Raw");
			DataGridView1.get_Columns().Add("c4", "Processing Machine");
			DataGridView1.get_Columns().Add("c5", "Processing Code");
			DataGridView1.get_Columns().Add("c6", "Raw Weight");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("proid").ToString(),
					rd.get_Item("prodate"),
					rd.get_Item("proraw"),
					rd.get_Item("promachine"),
					rd.get_Item("procode"),
					rd.get_Item("rawweight").ToString()
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

	internal static void Wc8()
	{
		byte[] j3T = Pg6.o4G(133632);
		int num = checked(Conversions.ToInteger(m9B.mDic[m9B.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		m9B.mDic.Add(m9B.mArray, c7B.x6B(j3T, (byte[])m9B.mDic[m9B.sArray], num, 25));
		if (Dw54.Jc5s())
		{
			m1S6.Me60();
		}
	}

	private void Yo5(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_detail set prodate ='" + txtPDate.get_Text() + "',proraw='" + txtPRaw.get_Text() + "',promachine='" + txtPMachine.get_Text() + "' where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		Gr0();
	}

	private void s0N(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_detail where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		Gr0();
	}

	internal static void a5W()
	{
		string[] zd = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = c7R.Rz4(zd, 0, 3);
		string value2 = c7R.Rz4(zd, 4, 7);
		m9B.mDic.Add(m9B.tName, value);
		m9B.mDic.Add(m9B.mName, value2);
	}

	static void p1T()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		try
		{
			uIntPtr = (UIntPtr)s6J.Default;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (true)
				{
					obj = s6J.Default;
					if (obj != null)
					{
						c7B = c7B;
						c7B = c7B;
						continue;
					}
					break;
				}
			}
			else
			{
				while (obj != null)
				{
					Qy5m obj2 = (Qy5m)(object)s6J.Default;
					qy5m = (Qy5m)(object)s6J.Default;
					qy5m = obj2;
					_ = (c7R)(object)s6J.Default;
				}
			}
		}
		finally
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Rg0)(object)s6J.Default;
			}
			goto IL_0088;
		}
		IL_0088:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9B m9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s6J s6J);
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					ap = ap;
					ap = null;
				}
			}
		}
		else
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					m9B = m9B;
					m9B = m9B;
				}
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (m1S6)(object)s6J.Default;
				}
				else
				{
					s6J = s6J.Default;
					s6J = null;
					_ = (Qy5m)(object)s6J.Default;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					if (uIntPtr == 0)
					{
						s6J = s6J;
					}
				}
				finally
				{
					nuint num = unchecked(uIntPtr / (nuint)(UIntPtr)s6J.Default) + unchecked((nuint)(UIntPtr)s6J.Default);
					uIntPtr = default(UIntPtr);
					if ((num - uIntPtr) * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (o7A)(object)s6J.Default;
					}
					goto IL_0184;
				}
			}
			goto IL_0184;
		}
		IL_066b:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
			}
		}
		_ = (m1S6)(object)s6J.Default;
		do
		{
			_ = (Ap93)(object)s6J.Default;
			_ = (Wm5)(object)s6J.Default;
		}
		while ((object)s6J.Default != null);
		while (obj != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Qy5m)(object)s6J.Default;
					_ = (a0E)(object)s6J.Default;
				}
				while (obj != null);
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)s6J.Default != null)
			{
				_ = s6J.Default;
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr * uIntPtr) / uIntPtr == 0)
				{
					_ = (a0E)(object)s6J.Default;
				}
				else
				{
					_ = (c7B)(object)s6J.Default;
				}
			}
			else if (uIntPtr == 0)
			{
				_ = (Pg6)(object)s6J.Default;
			}
		}
		while (obj != null);
		_ = (m9B)(object)s6J.Default;
		ap = ap;
		c7B = null;
		checked
		{
			do
			{
				if (unchecked((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u))
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						m9B = m9B;
						continue;
					}
					_ = (m9B)(object)s6J.Default;
					_ = (a0E)(object)s6J.Default;
					_ = (Wm5)(object)s6J.Default;
				}
				else if (unchecked(uIntPtr / uIntPtr) - uIntPtr == 0)
				{
					_ = (Wm5)(object)s6J.Default;
				}
				else
				{
					_ = s6J.Default;
				}
			}
			while (obj != null);
			s6J = s6J.Default;
			return;
		}
		IL_04f8:
		checked
		{
			do
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
				{
					while (obj != null)
					{
						_ = (m1S6)(object)s6J.Default;
					}
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (m9B)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		while ((object)s6J.Default != null)
		{
			dw = dw;
		}
		_003CModule_003E = _003CModule_003E;
		_ = (d9N2)(object)s6J.Default;
		g2M8 g2M = g2M;
		g2M = g2M;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (o7A)(object)s6J.Default;
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (Qy5m)(object)s6J.Default;
				}
				while (obj != null);
			}
			catch
			{
				_ = (g2M8)(object)s6J.Default;
			}
			goto IL_05b7;
		}
		IL_0616:
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (x2K9)(object)s6J.Default;
			goto IL_066b;
		}
		checked
		{
			try
			{
				try
				{
					_ = (m2R)(object)s6J.Default;
				}
				finally
				{
					_ = s6J.Default;
					goto end_IL_0630;
				}
				end_IL_0630:;
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)s6J.Default) + uIntPtr != 0)
				{
					_ = (Dw54)(object)s6J.Default;
				}
				goto IL_066b;
			}
		}
		IL_05b7:
		uIntPtr = default(UIntPtr);
		x2K9 x2K;
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Tb9)(object)s6J.Default;
				_ = (Tb9)(object)s6J.Default;
			}
			finally
			{
				while (obj != null)
				{
					x2K = x2K;
				}
				goto IL_0616;
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (Qy5m)(object)s6J.Default;
			}
		}
		finally
		{
			_ = (m9B)(object)s6J.Default;
			goto IL_0616;
		}
		IL_0481:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		try
		{
			_ = (m2R)(object)s6J.Default;
			c7R = c7R;
			_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
		}
		finally
		{
			if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)s6J.Default == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (d9N2)(object)s6J.Default;
			}
			goto IL_04f8;
		}
		IL_0184:
		try
		{
			try
			{
				_ = (Wm5)(object)s6J.Default;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (g2M8)(object)s6J.Default;
					_ = (Rg0)(object)s6J.Default;
					_ = (x2K9)(object)s6J.Default;
				}
			}
		}
		catch
		{
			_ = (Pg6)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		if (uIntPtr / (uIntPtr / uIntPtr) == 0)
		{
			try
			{
				a0E = null;
				a0E = a0E;
			}
			catch
			{
				while ((object)s6J.Default != null)
				{
					_ = (Ap93)(object)s6J.Default;
				}
			}
		}
		else if (checked(unchecked((nuint)(UIntPtr)s6J.Default) + uIntPtr) == 0)
		{
			_ = (o7A)(object)s6J.Default;
		}
		Wm5 wm = wm;
		wm = wm;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Ap93)(object)s6J.Default;
				}
				else
				{
					wm = wm;
				}
			}
			catch
			{
				do
				{
					_ = (Wm5)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
		}
		do
		{
			_ = (m9B)(object)s6J.Default;
		}
		while (obj != null);
		_ = (Ap93)(object)s6J.Default;
		while (obj != null)
		{
			_ = (o7A)(object)s6J.Default;
		}
		_ = (Tb9)(object)s6J.Default;
		s6J = s6J;
		qy5m = qy5m;
		x2K = null;
		x2K = null;
		qy5m = (Qy5m)(object)s6J.Default;
		try
		{
			try
			{
				qy5m = (Qy5m)(object)s6J.Default;
			}
			finally
			{
				while (obj != null)
				{
					_ = (m2R)(object)s6J.Default;
				}
				goto end_IL_02ed;
			}
			end_IL_02ed:;
		}
		catch
		{
			try
			{
				try
				{
					c7R obj9 = (c7R)(object)s6J.Default;
					c7R = c7R;
					c7R = obj9;
				}
				finally
				{
					_ = (Wm5)(object)s6J.Default;
					goto end_IL_0317;
				}
				end_IL_0317:;
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
				}
				goto end_IL_0316;
			}
			end_IL_0316:;
		}
		try
		{
			try
			{
				try
				{
					_ = (Wm5)(object)s6J.Default;
				}
				finally
				{
					c7R = c7R;
					goto end_IL_035f;
				}
				end_IL_035f:;
			}
			finally
			{
				while ((object)s6J.Default != null)
				{
					dw = dw;
					dw = dw;
				}
				goto end_IL_035e;
			}
			end_IL_035e:;
		}
		catch
		{
			_ = (o7A)(object)s6J.Default;
		}
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				m1S6 m1S = m1S;
				m1S = m1S;
			}
			else
			{
				try
				{
					_ = s6J.Default;
				}
				catch
				{
					_ = (m1S6)(object)s6J.Default;
					c7R = c7R;
					_ = (c7R)(object)s6J.Default;
					_ = (Ap93)(object)s6J.Default;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					Rg0 rg = null;
					rg = rg;
				}
			}
			goto IL_0429;
		}
		IL_0429:
		a0E = a0E;
		checked
		{
			if (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					_ = s6J.Default;
				}
				catch
				{
					_ = (c7B)(object)s6J.Default;
				}
				finally
				{
					try
					{
						m9B = null;
					}
					finally
					{
						_ = (Qy5m)(object)s6J.Default;
						goto IL_0481;
					}
				}
			}
			goto IL_0481;
		}
	}

	static void Bt1()
	{
		Qy5m qy5m = qy5m;
		qy5m = qy5m;
		_ = (m1S6)(object)s6J.Default;
		_ = (a0E)(object)s6J.Default;
		UIntPtr uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				ap = (Ap93)(object)s6J.Default;
				ap = ap;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					m1S = null;
					m1S = m1S;
				}
				goto IL_0080;
			}
		}
		_ = (m1S6)(object)s6J.Default;
		goto IL_0080;
		IL_0185:
		_ = (Tb9)(object)s6J.Default;
		do
		{
			ap = ap;
		}
		while ((object)s6J.Default != null);
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		while (obj != null)
		{
			c7B = null;
			c7B = c7B;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		try
		{
			if (checked(unchecked((nuint)default(UIntPtr)) - unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)s6J.Default)) == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				c7B = c7B;
				tb = (Tb9)(object)s6J.Default;
				tb = tb;
				c7R = c7R;
			}
		}
		finally
		{
			goto IL_021d;
		}
		IL_033f:
		while (obj != null)
		{
			d9N2 d9N = null;
		}
		_ = (o7A)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		if (checked(uIntPtr * (unchecked((nuint)(UIntPtr)s6J.Default) - uIntPtr) + unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					m2R m2R2 = null;
				}
				else
				{
					x2K = x2K;
					x2K = x2K;
				}
			}
		}
		else
		{
			try
			{
				if ((nuint)(UIntPtr)s6J.Default / unchecked((nuint)default(UIntPtr)) == 0)
				{
					m9B m9B = (m9B)(object)s6J.Default;
					m9B = m9B;
				}
				else
				{
					_ = (m1S6)(object)s6J.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Wm5)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
		}
		c7B = (c7B)(object)s6J.Default;
		Wm5 wm = wm;
		wm = null;
		_ = (Ap93)(object)s6J.Default;
		try
		{
			qy5m = qy5m;
		}
		finally
		{
			_ = (m9B)(object)s6J.Default;
			goto IL_0441;
		}
		IL_0080:
		try
		{
		}
		finally
		{
			Dw54 dw = null;
			dw = dw;
			obj = null;
			goto IL_0097;
		}
		IL_0097:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (c7R)(object)s6J.Default;
		}
		else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			qy5m = (Qy5m)(object)s6J.Default;
		}
		while (obj != null)
		{
			_ = (Tb9)(object)s6J.Default;
		}
		qy5m = qy5m;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
				{
					try
					{
						m2R m2R2 = m2R2;
						m2R2 = m2R2;
					}
					catch
					{
						_ = (Wm5)(object)s6J.Default;
						ap = ap;
					}
				}
				else if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
				{
					_ = (x2K9)(object)s6J.Default;
				}
				goto IL_0185;
			}
			try
			{
				c7R obj4 = (c7R)(object)s6J.Default;
				c7R = c7R;
				c7R = obj4;
			}
			finally
			{
				qy5m = null;
				goto IL_0185;
			}
		}
		IL_0441:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Wm5)(object)s6J.Default;
			}
			while (obj != null || obj != null);
		}
		else
		{
			a0E a0E = a0E;
			a0E = a0E;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Wm5)(object)s6J.Default;
				}
				catch
				{
					_ = (m1S6)(object)s6J.Default;
				}
			}
		}
		catch
		{
			qy5m = null;
		}
		try
		{
			m1S = (m1S6)(object)s6J.Default;
		}
		catch
		{
			x2K = x2K;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rg0 rg);
		do
		{
			rg = rg;
			rg = rg;
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				wm = (Wm5)(object)s6J.Default;
			}
			catch
			{
				ap = ap;
			}
		}
		else
		{
			try
			{
				try
				{
					ap = null;
				}
				finally
				{
					_ = (c7R)(object)s6J.Default;
					goto end_IL_0510;
				}
				end_IL_0510:;
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					o7A = o7A;
				}
				else
				{
					ap = ap;
				}
			}
		}
		_ = (Dw54)(object)s6J.Default;
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Pg6)(object)s6J.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					m1S = m1S;
				}
				catch
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
			goto IL_05c6;
		}
		IL_05c6:
		while (true)
		{
			if ((object)s6J.Default != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					c7B = (c7B)(object)s6J.Default;
					continue;
				}
				m2R m2R2 = null;
				o7A = o7A;
				_ = (m9B)(object)s6J.Default;
			}
			else if (obj == null)
			{
				break;
			}
		}
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)s6J.Default) != 0)
			{
				return;
			}
			try
			{
				_ = s6J.Default;
				return;
			}
			catch
			{
				while (obj != null)
				{
					tb = tb;
				}
				return;
			}
		}
		IL_021d:
		_ = (m1S6)(object)s6J.Default;
		_ = (Pg6)(object)s6J.Default;
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (a0E)(object)s6J.Default;
			}
		}
		while (obj != null);
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			o7A = (o7A)(object)s6J.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (m2R)(object)s6J.Default;
		}
		else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				tb = tb;
			}
			catch
			{
				d9N2 d9N = d9N;
				d9N = d9N;
				_ = (Wm5)(object)s6J.Default;
				_ = (m9B)(object)s6J.Default;
			}
		}
		try
		{
			m2R m2R2 = (m2R)(object)s6J.Default;
		}
		catch
		{
			while (obj != null || (object)s6J.Default != null)
			{
			}
		}
		checked
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
				{
					_ = (o7A)(object)s6J.Default;
				}
			}
			finally
			{
				_ = (g2M8)(object)s6J.Default;
				goto IL_033f;
			}
		}
	}

	static void Kf1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9B m9B);
		nuint num;
		try
		{
			m9B obj = (m9B)(object)s6J.Default;
			m9B = m9B;
			m9B = obj;
			_ = (m9B)(object)s6J.Default;
		}
		finally
		{
			num = (UIntPtr)s6J.Default;
			if (num == 0)
			{
				do
				{
					_ = (x2K9)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			else
			{
				_ = (Rg0)(object)s6J.Default;
			}
			goto IL_005d;
		}
		IL_005d:
		object obj2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		d9N2 d9N;
		do
		{
			_ = (c7B)(object)s6J.Default;
			d9N = (d9N2)(object)s6J.Default;
			d9N = d9N;
			c7B obj3 = (c7B)(object)s6J.Default;
			c7B = c7B;
			c7B = obj3;
		}
		while (obj2 != null);
		try
		{
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					_ = (o7A)(object)s6J.Default;
					_ = (o7A)(object)s6J.Default;
				}
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
			while (obj2 != null)
			{
				do
				{
					c7R obj4 = (c7R)(object)s6J.Default;
					c7R = c7R;
					c7R = obj4;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null)
		{
			_ = (c7B)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		try
		{
			try
			{
				m1S = m1S;
				m1S = null;
			}
			finally
			{
				try
				{
					m9B = null;
				}
				finally
				{
					dw = (Dw54)(object)s6J.Default;
					dw = null;
					goto end_IL_00fe;
				}
			}
			end_IL_00fe:;
		}
		catch
		{
			Rg0 rg = rg;
			rg = null;
		}
		while (obj2 != null)
		{
			_ = s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2M8 g2M);
		while (obj2 != null)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u && (UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (m2R)(object)s6J.Default;
				g2M = g2M;
				g2M = null;
				g2M = g2M;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				tb = (Tb9)(object)s6J.Default;
				tb = tb;
				_ = (o7A)(object)s6J.Default;
			}
			finally
			{
				_ = (c7B)(object)s6J.Default;
				goto IL_0207;
			}
		}
		try
		{
			try
			{
				Rg0 rg = (Rg0)(object)s6J.Default;
			}
			catch
			{
				_ = (x2K9)(object)s6J.Default;
				m1S = m1S;
			}
		}
		catch
		{
			d9N = (d9N2)(object)s6J.Default;
		}
		goto IL_0207;
		IL_063f:
		while ((object)s6J.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (a0E)(object)s6J.Default;
				_ = (a0E)(object)s6J.Default;
			}
			else
			{
				m9B = m9B;
			}
		}
		_ = (d9N2)(object)s6J.Default;
		Ap93 ap = ap;
		ap = ap;
		_ = (Qy5m)(object)s6J.Default;
		_ = (Qy5m)(object)s6J.Default;
		_ = (d9N2)(object)s6J.Default;
		ap = ap;
		_ = (x2K9)(object)s6J.Default;
		m1S = m1S;
		d9N = (d9N2)(object)s6J.Default;
		_ = (m9B)(object)s6J.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		try
		{
			do
			{
				ap = ap;
			}
			while (obj2 != null || (object)s6J.Default != null);
		}
		finally
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				pg = pg;
			}
			goto IL_06f2;
		}
		IL_06f2:
		_ = (m2R)(object)s6J.Default;
		_ = (Dw54)(object)s6J.Default;
		m2R m2R2 = (m2R)(object)s6J.Default;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Ap93)(object)s6J.Default;
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)s6J.Default;
		}
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (a0E)(object)s6J.Default;
				return;
			}
			_ = (m2R)(object)s6J.Default;
			_ = (x2K9)(object)s6J.Default;
			return;
		}
		finally
		{
			while (obj2 != null)
			{
				while ((object)s6J.Default != null)
				{
				}
			}
			return;
		}
		IL_041a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (_003CModule_003E)(object)s6J.Default;
					d9N = (d9N2)(object)s6J.Default;
					_ = (c7B)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			else
			{
				d9N = d9N;
				pg = (Pg6)(object)s6J.Default;
			}
		}
		catch
		{
			qy5m = (Qy5m)(object)s6J.Default;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				if (num == 0)
				{
					d9N = d9N;
				}
				else
				{
					_ = (Rg0)(object)s6J.Default;
				}
			}
		}
		_ = (Qy5m)(object)s6J.Default;
		_ = (Pg6)(object)s6J.Default;
		_ = (c7R)(object)s6J.Default;
		_ = (Rg0)(object)s6J.Default;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (g2M8)(object)s6J.Default;
		}
		else
		{
			_ = (Pg6)(object)s6J.Default;
		}
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (m9B)(object)s6J.Default;
			}
		}
		finally
		{
			if (num == 0)
			{
				while (obj2 != null)
				{
					_ = (m9B)(object)s6J.Default;
				}
				goto IL_0566;
			}
			try
			{
				_ = (Qy5m)(object)s6J.Default;
				m9B = m9B;
				_ = (m2R)(object)s6J.Default;
			}
			finally
			{
				_ = (g2M8)(object)s6J.Default;
				goto IL_0566;
			}
		}
		IL_0207:
		_ = (a0E)(object)s6J.Default;
		while (obj2 != null)
		{
			try
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					ap = null;
					ap = null;
				}
			}
			catch
			{
				try
				{
					m2R2 = m2R2;
				}
				finally
				{
					Qy5m obj11 = (Qy5m)(object)s6J.Default;
					qy5m = qy5m;
					qy5m = obj11;
					goto end_IL_022d;
				}
				end_IL_022d:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					d9N = null;
					s6J s6J = s6J;
					s6J = null;
					Pg6 obj13 = (Pg6)(object)s6J.Default;
					pg = pg;
					pg = obj13;
				}
			}
			catch
			{
				do
				{
					m9B = null;
				}
				while (obj2 != null);
			}
		}
		catch
		{
			do
			{
				try
				{
					wm = wm;
					wm = wm;
				}
				finally
				{
					_ = (x2K9)(object)s6J.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		while (true)
		{
			if ((object)s6J.Default != null)
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
				}
				catch
				{
					_ = (c7R)(object)s6J.Default;
				}
			}
			else if ((object)s6J.Default == null)
			{
				break;
			}
		}
		checked
		{
			try
			{
				_ = (m9B)(object)s6J.Default;
			}
			finally
			{
				if (num + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Rg0)(object)s6J.Default;
				}
				goto IL_0331;
			}
		}
		IL_0331:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a0E a0E);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				try
				{
					if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
					{
						_ = (m2R)(object)s6J.Default;
						_ = (m9B)(object)s6J.Default;
						m2R2 = (m2R)(object)s6J.Default;
					}
				}
				finally
				{
					while ((object)s6J.Default != null)
					{
						_ = (Dw54)(object)s6J.Default;
						_ = (a0E)(object)s6J.Default;
					}
					goto IL_041a;
				}
			}
			if (unchecked((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u))
			{
				num = default(UIntPtr);
				if (num - (unchecked((nuint)(UIntPtr)s6J.Default) + unchecked(checked(num + num) / num) * num) == 0)
				{
					_ = (Wm5)(object)s6J.Default;
				}
				else
				{
					wm = null;
				}
			}
			else
			{
				try
				{
					a0E = a0E;
					a0E = null;
				}
				catch
				{
					o7A o7A = o7A;
					o7A = o7A;
				}
			}
			goto IL_041a;
		}
		IL_0566:
		_ = (Pg6)(object)s6J.Default;
		m1S = m1S;
		_ = (g2M8)(object)s6J.Default;
		_ = (Tb9)(object)s6J.Default;
		wm = wm;
		dw = dw;
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Pg6)(object)s6J.Default;
				}
				catch
				{
					tb = tb;
					_ = (Tb9)(object)s6J.Default;
					pg = pg;
					a0E = a0E;
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
				catch
				{
					_ = (m2R)(object)s6J.Default;
				}
			}
			catch
			{
				_ = (m2R)(object)s6J.Default;
			}
			goto IL_063f;
		}
	}

	static void j6S()
	{
		UIntPtr num = (UIntPtr)s6J.Default;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		m2R m2R2;
		d9N2 d9N;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		checked
		{
			if (unchecked((nuint)num) * uIntPtr == 0)
			{
				o7A = (o7A)(object)s6J.Default;
				o7A = null;
			}
			do
			{
				_ = (Qy5m)(object)s6J.Default;
				obj = obj;
			}
			while (obj != null);
			d9N2 obj2 = (d9N2)(object)s6J.Default;
			d9N = null;
			d9N = obj2;
			if (uIntPtr == 0)
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (unchecked(num2 / uIntPtr) == 0)
				{
					try
					{
						_ = (m1S6)(object)s6J.Default;
					}
					catch
					{
						_ = (m9B)(object)s6J.Default;
					}
				}
				else if (uIntPtr == 0)
				{
					_ = (m9B)(object)s6J.Default;
				}
				else
				{
					_ = (Qy5m)(object)s6J.Default;
				}
			}
			else
			{
				try
				{
					_ = (c7B)(object)s6J.Default;
				}
				catch
				{
					try
					{
						m2R2 = (m2R)(object)s6J.Default;
						m2R2 = m2R2;
					}
					finally
					{
						_ = s6J.Default;
						goto end_IL_00d0;
					}
					end_IL_00d0:;
				}
			}
			_ = (Qy5m)(object)s6J.Default;
			_ = (m2R)(object)s6J.Default;
			c7R = c7R;
			c7R = c7R;
			_ = (Rg0)(object)s6J.Default;
			try
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)s6J.Default) * unchecked((nuint)(UIntPtr)s6J.Default) == 0)
					{
						_ = (Dw54)(object)s6J.Default;
						Ap93 ap = null;
						ap = ap;
					}
				}
				while ((object)s6J.Default != null);
			}
			finally
			{
				try
				{
					m1S = (m1S6)(object)s6J.Default;
					m1S = null;
				}
				catch
				{
				}
				goto IL_018a;
			}
		}
		IL_05cc:
		_ = (m9B)(object)s6J.Default;
		s6J s6J = s6J;
		s6J = null;
		_ = s6J.Default;
		_ = s6J.Default;
		Rg0 rg;
		try
		{
			while ((object)s6J.Default != null)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					rg = (Rg0)(object)s6J.Default;
				}
			}
		}
		catch
		{
			_ = (c7R)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		if (uIntPtr == 0)
		{
			x2K = (x2K9)(object)s6J.Default;
		}
		else
		{
			c7B = c7B;
			c7B = c7B;
			dw = null;
			s6J = null;
			_ = (Wm5)(object)s6J.Default;
		}
		try
		{
			_ = (x2K9)(object)s6J.Default;
		}
		catch
		{
			while (obj != null)
			{
				_ = (Dw54)(object)s6J.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			do
			{
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null);
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				rg = null;
				_ = s6J.Default;
			}
			else
			{
				c7B = c7B;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (Wm5)(object)s6J.Default;
				}
				finally
				{
					_ = (g2M8)(object)s6J.Default;
					goto end_IL_06d5;
				}
				end_IL_06d5:;
			}
			finally
			{
				try
				{
					a0E a0E = a0E;
					a0E = a0E;
				}
				finally
				{
					rg = rg;
					_ = (m1S6)(object)s6J.Default;
					_ = (a0E)(object)s6J.Default;
					goto IL_0729;
				}
			}
		}
		IL_0729:
		_ = (Rg0)(object)s6J.Default;
		_ = s6J.Default;
		m2R2 = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (Tb9)(object)s6J.Default;
				}
				while ((object)s6J.Default != null);
			}
			catch
			{
				_ = (Qy5m)(object)s6J.Default;
			}
		}
		else
		{
			Qy5m qy5m = null;
			qy5m = qy5m;
		}
		_ = (Tb9)(object)s6J.Default;
		Tb9 tb = null;
		while ((object)s6J.Default != null)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				nuint num3 = uIntPtr / (nuint)(UIntPtr)s6J.Default;
				uIntPtr = default(UIntPtr);
				if (checked(num3 - uIntPtr - uIntPtr) == 0)
				{
					_ = (a0E)(object)s6J.Default;
				}
				else
				{
					_ = (Dw54)(object)s6J.Default;
				}
			}
		}
		_ = (_003CModule_003E)(object)s6J.Default;
		return;
		IL_0525:
		if (uIntPtr == 0)
		{
			do
			{
				x2K = (x2K9)(object)s6J.Default;
				_ = (x2K9)(object)s6J.Default;
				dw = null;
			}
			while ((object)s6J.Default != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					o7A = (o7A)(object)s6J.Default;
					dw = dw;
					_ = (Rg0)(object)s6J.Default;
					_003CModule_003E obj10 = (_003CModule_003E)(object)s6J.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj10;
				}
				while (obj != null);
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (o7A)(object)s6J.Default;
				}
				else
				{
					_ = (c7R)(object)s6J.Default;
				}
				goto IL_05cc;
			}
		}
		_ = (g2M8)(object)s6J.Default;
		goto IL_05cc;
		IL_018a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg6 pg);
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					pg = pg;
					pg = null;
				}
			}
			finally
			{
				m2R2 = null;
				goto end_IL_018b;
			}
			end_IL_018b:;
		}
		finally
		{
			tb = tb;
			tb = null;
			goto IL_01da;
		}
		IL_01da:
		do
		{
			IL_01da_2:
			if (obj != null)
			{
				try
				{
					_ = (Dw54)(object)s6J.Default;
				}
				finally
				{
					_ = (Dw54)(object)s6J.Default;
					goto IL_01da_2;
				}
			}
		}
		while (obj != null);
		do
		{
			try
			{
				x2K = x2K;
				x2K = x2K;
				_ = (c7B)(object)s6J.Default;
				m1S = m1S;
			}
			catch
			{
				_ = (m2R)(object)s6J.Default;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
				}
				finally
				{
					dw = null;
					dw = dw;
					goto end_IL_021d;
				}
				end_IL_021d:;
			}
			catch
			{
				_ = (Tb9)(object)s6J.Default;
			}
		}
		catch
		{
			try
			{
				c7R = c7R;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Wm5)(object)s6J.Default;
				}
				goto end_IL_024c;
			}
			end_IL_024c:;
		}
		try
		{
			try
			{
				_ = (Rg0)(object)s6J.Default;
			}
			catch
			{
				_ = (d9N2)(object)s6J.Default;
			}
			finally
			{
				_ = (Pg6)(object)s6J.Default;
				goto end_IL_0277;
			}
			end_IL_0277:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (g2M8)(object)s6J.Default;
				}
				else
				{
					_ = (a0E)(object)s6J.Default;
				}
			}
			else
			{
				_ = s6J.Default;
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr + uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Dw54)(object)s6J.Default;
				}
				else
				{
					while ((object)s6J.Default != null)
					{
						_ = (d9N2)(object)s6J.Default;
					}
				}
			}
		}
		else
		{
			while (obj != null)
			{
				do
				{
					_ = s6J.Default;
				}
				while (obj != null);
			}
		}
		_ = (Dw54)(object)s6J.Default;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && (nuint)(UIntPtr)s6J.Default / uIntPtr == 0)
			{
				_ = (d9N2)(object)s6J.Default;
			}
		}
		while (obj != null);
		_ = (m9B)(object)s6J.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			pg = (Pg6)(object)s6J.Default;
		}
		d9N = d9N;
		Rg0 obj16 = (Rg0)(object)s6J.Default;
		rg = null;
		rg = obj16;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				while (obj != null)
				{
					o7A = o7A;
				}
			}
			else if (unchecked((nuint)(UIntPtr)s6J.Default) * uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked(uIntPtr / uIntPtr) == 0)
				{
					o7A = o7A;
				}
				else
				{
					g2M8 g2M = null;
					g2M = g2M;
				}
			}
			else
			{
				o7A = o7A;
			}
			UIntPtr num4 = unchecked((UIntPtr)s6J.Default);
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num4) + (uIntPtr + uIntPtr) == 0)
			{
				try
				{
					try
					{
						o7A = o7A;
					}
					catch
					{
						_ = (m2R)(object)s6J.Default;
					}
				}
				catch
				{
					try
					{
						_ = (o7A)(object)s6J.Default;
					}
					finally
					{
						pg = pg;
						goto end_IL_0488;
					}
					end_IL_0488:;
				}
			}
			_ = (Pg6)(object)s6J.Default;
			try
			{
				unchecked
				{
					if (default(UIntPtr) == (UIntPtr)(nuint)0u)
					{
						c7R = (c7R)(object)s6J.Default;
					}
					else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
					{
						_ = (a0E)(object)s6J.Default;
					}
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr - unchecked((nuint)(UIntPtr)s6J.Default) == 0)
				{
					_ = (m9B)(object)s6J.Default;
				}
				else if (uIntPtr == 0)
				{
					_ = (m1S6)(object)s6J.Default;
				}
				goto IL_0525;
			}
		}
	}
}
