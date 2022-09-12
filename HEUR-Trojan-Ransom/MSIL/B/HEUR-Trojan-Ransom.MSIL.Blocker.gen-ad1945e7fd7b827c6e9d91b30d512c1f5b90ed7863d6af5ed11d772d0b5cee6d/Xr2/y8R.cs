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

namespace Xr2;

[DesignerGenerated]
public class y8R : Form
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
			EventHandler eventHandler = Aq5;
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
			EventHandler eventHandler = Xw5;
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
			EventHandler eventHandler = r0E;
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
			EventHandler eventHandler = Kt4;
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
			EventHandler eventHandler = g1Y;
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

	public y8R()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Qt7);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		g8T();
	}

	[DebuggerNonUserCode]
	protected override void c7D(bool r9S)
	{
		try
		{
			if (r9S && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r9S);
		}
	}

	[DebuggerStepThrough]
	private void g8T()
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

	private void Xw5(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void Aq5(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Qt7(object sender, EventArgs e)
	{
	}

	private void g1Y(object sender, EventArgs e)
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
		Mo3();
	}

	public void Mo3()
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

	internal static void x0G()
	{
		byte[] y0AF = i0A1.a1T2(133632);
		int num = checked(Conversions.ToInteger(Em1.mDic[Em1.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		Em1.mDic.Add(Em1.mArray, Qg6.Ho83(y0AF, (byte[])Em1.mDic[Em1.sArray], num, 25));
		if (Nn9a.Dz91())
		{
			Nm2f.q6MF();
		}
	}

	private void Kt4(object sender, EventArgs e)
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
		Mo3();
	}

	private void r0E(object sender, EventArgs e)
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
		Mo3();
	}

	internal static void x6L()
	{
		string[] t7K = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Sm6.j6C(t7K, 0, 3);
		string value2 = Sm6.j6C(t7K, 4, 7);
		Em1.mDic.Add(Em1.tName, value);
		Em1.mDic.Add(Em1.mName, value2);
	}

	static void q5K()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				while ((object)a7W.Default != null)
				{
					num = num;
					UIntPtr num2 = num;
					num = default(UIntPtr);
					if (unchecked((nuint)num2) * num == 0)
					{
						_ = (Ln53)(object)a7W.Default;
						continue;
					}
					nm2f = nm2f;
					nm2f = nm2f;
				}
			}
		}
		else
		{
			try
			{
				_ = (_003CModule_003E)(object)a7W.Default;
			}
			catch
			{
				_ = (y8R)(object)a7W.Default;
				_ = (a1B)(object)a7W.Default;
				_ = (Jy1)(object)a7W.Default;
			}
		}
		_ = (a1B)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R2);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (y8R)(object)a7W.Default;
					_ = (_003CModule_003E)(object)a7W.Default;
					_ = (Ln53)(object)a7W.Default;
					qg = qg;
					qg = qg;
				}
				catch
				{
					_ = (Zo8)(object)a7W.Default;
				}
			}
			else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				j3J = (j3J)(object)a7W.Default;
				j3J = j3J;
			}
		}
		catch
		{
			_ = (j3J)(object)a7W.Default;
			y8R2 = y8R2;
			y8R2 = y8R2;
			_ = (s9EJ)(object)a7W.Default;
		}
		Ln53 ln = ln;
		ln = ln;
		_ = (j3J)(object)a7W.Default;
		_ = (Ta6)(object)a7W.Default;
		object obj4;
		while (true)
		{
			obj4 = a7W.Default;
			if (obj4 != null)
			{
				b1YL b1YL = (b1YL)(object)a7W.Default;
				b1YL = b1YL;
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		if (num == 0)
		{
			try
			{
				_ = (Qg6)(object)a7W.Default;
			}
			finally
			{
				while ((object)a7W.Default != null)
				{
					_ = (Zo8)(object)a7W.Default;
				}
				goto IL_0200;
			}
		}
		_003CModule_003E _003CModule_003E = null;
		_003CModule_003E = _003CModule_003E;
		goto IL_0200;
		IL_04f2:
		try
		{
			_ = (y8R)(object)a7W.Default;
		}
		catch
		{
			b1YL b1YL = null;
		}
		while ((object)a7W.Default != null)
		{
			_ = (Zo8)(object)a7W.Default;
		}
		Zo8 zo = null;
		zo = null;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		checked
		{
			if (num * num == 0)
			{
				_ = (En1)(object)a7W.Default;
				ln = null;
				a7W = a7W;
				b6E = b6E;
			}
			else
			{
				_ = (Jy1)(object)a7W.Default;
			}
			try
			{
				try
				{
					try
					{
						_ = (j3J)(object)a7W.Default;
					}
					finally
					{
						_ = (Nn9a)(object)a7W.Default;
						goto end_IL_056d;
					}
					end_IL_056d:;
				}
				catch
				{
					try
					{
						i0A = null;
					}
					catch
					{
						_003CModule_003E = _003CModule_003E;
						_ = (s9EJ)(object)a7W.Default;
						qg = qg;
						nn9a = nn9a;
						nn9a = nn9a;
					}
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						Jy1 jy = jy;
						jy = jy;
					}
				}
				else if (num + unchecked((nuint)(UIntPtr)a7W.Default / (nuint)(UIntPtr)a7W.Default) == 0)
				{
					a7W = a7W;
				}
			}
			try
			{
				try
				{
					try
					{
						qg = qg;
						_ = (a1B)(object)a7W.Default;
						_ = (y8R)(object)a7W.Default;
					}
					finally
					{
						_ = (Sm6)(object)a7W.Default;
						_ = (Ta6)(object)a7W.Default;
						goto end_IL_061f;
					}
					end_IL_061f:;
				}
				finally
				{
					try
					{
						en = en;
					}
					finally
					{
						y8R2 = (y8R)(object)a7W.Default;
						zo = zo;
						_ = (Nn9a)(object)a7W.Default;
						goto end_IL_061e;
					}
				}
				end_IL_061e:;
			}
			finally
			{
				_ = (Ta6)(object)a7W.Default;
				goto IL_0699;
			}
		}
		IL_0474:
		while ((object)a7W.Default != null)
		{
			if (num == 0)
			{
				try
				{
					Em1 em = (Em1)(object)a7W.Default;
					em = em;
				}
				finally
				{
					_ = (a1B)(object)a7W.Default;
					_ = (y8R)(object)a7W.Default;
					_ = (b1YL)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
					continue;
				}
			}
			while (obj4 != null)
			{
				Em1 em = (Em1)(object)a7W.Default;
				_ = (_003CModule_003E)(object)a7W.Default;
				_ = (b6E)(object)a7W.Default;
			}
		}
		_ = (s9EJ)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Sm6)(object)a7W.Default;
				}
				else
				{
					qg = qg;
				}
			}
			finally
			{
				do
				{
					b1YL b1YL = (b1YL)(object)a7W.Default;
				}
				while (obj4 != null);
				goto end_IL_048e;
			}
			end_IL_048e:;
		}
		finally
		{
			Sm6 obj9 = (Sm6)(object)a7W.Default;
			sm = sm;
			sm = obj9;
			_ = (s9EJ)(object)a7W.Default;
			goto IL_04f2;
		}
		IL_0743:
		do
		{
			num = default(UIntPtr);
			if (num != (UIntPtr)(nuint)0u)
			{
				nn9a = nn9a;
				continue;
			}
			j3J = (j3J)(object)a7W.Default;
			b6E = (b6E)(object)a7W.Default;
		}
		while (obj4 != null);
		do
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					sm = sm;
				}
				finally
				{
					a7W = a7W.Default;
					continue;
				}
			}
		}
		while (obj4 != null);
		try
		{
			try
			{
				do
				{
					b1YL b1YL = (b1YL)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
			finally
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					zo = null;
				}
				else
				{
					i0A = i0A;
				}
				goto end_IL_077b;
			}
			end_IL_077b:;
		}
		catch
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					a7W = a7W;
					_ = (_003CModule_003E)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
			}
		}
		do
		{
			nn9a = (Nn9a)(object)a7W.Default;
		}
		while (obj4 != null || obj4 != null || obj4 != null);
		num = default(UIntPtr);
		checked
		{
			if (num * num == 0)
			{
				if (num == 0)
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						_ = (b6E)(object)a7W.Default;
					}
					else
					{
						_ = (Ln53)(object)a7W.Default;
					}
				}
			}
			else
			{
				while (obj4 != null)
				{
					try
					{
						en = en;
						j3J = (j3J)(object)a7W.Default;
						j3J = j3J;
						Em1 em = null;
					}
					catch
					{
						_ = (Jy1)(object)a7W.Default;
					}
				}
			}
		}
		do
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				ln = null;
			}
		}
		while ((object)a7W.Default != null);
		return;
		IL_0699:
		checked
		{
			try
			{
				if (num == 0)
				{
					try
					{
						j3J = j3J;
						ln = ln;
					}
					finally
					{
						qg = qg;
						goto end_IL_069a;
					}
				}
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				else
				{
					en = (En1)(object)a7W.Default;
				}
				end_IL_069a:;
			}
			finally
			{
				try
				{
					try
					{
						sm = null;
					}
					finally
					{
						_ = (En1)(object)a7W.Default;
						goto end_IL_06f9;
					}
					end_IL_06f9:;
				}
				catch
				{
				}
				goto IL_0743;
			}
		}
		IL_0200:
		while ((object)a7W.Default != null)
		{
			try
			{
				_ = (j3J)(object)a7W.Default;
			}
			catch
			{
				_ = (s9EJ)(object)a7W.Default;
			}
			finally
			{
				do
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
				continue;
			}
		}
		do
		{
			if (num == 0)
			{
				i0A1 obj15 = (i0A1)(object)a7W.Default;
				i0A = i0A;
				i0A = obj15;
			}
		}
		while (obj4 != null);
		_ = (b1YL)(object)a7W.Default;
		b6E = b6E;
		b6E = null;
		_ = (Sm6)(object)a7W.Default;
		_ = (Qg6)(object)a7W.Default;
		try
		{
			try
			{
				_ = (s9EJ)(object)a7W.Default;
				En1 obj16 = (En1)(object)a7W.Default;
				en = en;
				en = obj16;
				_ = (Ta6)(object)a7W.Default;
			}
			finally
			{
				while (obj4 != null)
				{
					_ = (Ln53)(object)a7W.Default;
				}
				goto end_IL_0264;
			}
			end_IL_0264:;
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					j3J = j3J;
					_ = (y8R)(object)a7W.Default;
					y8R2 = y8R2;
					y8R2 = y8R2;
				}
				finally
				{
					_ = (b1YL)(object)a7W.Default;
					b6E = (b6E)(object)a7W.Default;
					goto end_IL_02ab;
				}
			}
			do
			{
				nm2f = nm2f;
			}
			while ((object)a7W.Default != null);
			end_IL_02ab:;
		}
		_ = (Em1)(object)a7W.Default;
		_ = (_003CModule_003E)(object)a7W.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - num == 0)
			{
				_ = (y8R)(object)a7W.Default;
			}
			else
			{
				_ = (b1YL)(object)a7W.Default;
			}
			do
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						ln = ln;
					}
					else
					{
						_ = (_003CModule_003E)(object)a7W.Default;
					}
				}
				finally
				{
					if (num == 0)
					{
						en = en;
					}
					continue;
				}
			}
			while (obj4 != null);
		}
		try
		{
			do
			{
				a7W = null;
				a7W = null;
			}
			while ((object)a7W.Default != null);
		}
		catch
		{
			try
			{
				_ = (Jy1)(object)a7W.Default;
			}
			catch
			{
				_ = a7W.Default;
			}
		}
		finally
		{
			try
			{
				nm2f = null;
			}
			catch
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			goto IL_0474;
		}
	}

	static void s2P()
	{
		try
		{
			try
			{
				try
				{
					_ = (Qg6)(object)a7W.Default;
				}
				catch
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
			catch
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = a7W.Default;
				}
			}
		}
		catch
		{
			_ = (s9EJ)(object)a7W.Default;
			_ = (y8R)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		UIntPtr uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = (UIntPtr)a7W.Default;
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
				else
				{
					_ = (i0A1)(object)a7W.Default;
				}
			}
			else
			{
				do
				{
					_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
					_003CModule_003E = null;
					obj4 = a7W.Default;
				}
				while (obj4 != null);
			}
		}
		finally
		{
			_ = (j3J)(object)a7W.Default;
			goto IL_00cf;
		}
		IL_04e0:
		Qg6 qg = qg;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				ln = null;
			}
			catch
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ln53)(object)a7W.Default;
					nn9a = null;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					j3J = (j3J)(object)a7W.Default;
					Nm2f nm2f = null;
					_ = (y8R)(object)a7W.Default;
				}
				else
				{
					ln = ln;
				}
			}
			finally
			{
				_ = (_003CModule_003E)(object)a7W.Default;
				goto end_IL_051f;
			}
			end_IL_051f:;
		}
		finally
		{
			_ = (s9EJ)(object)a7W.Default;
			goto IL_056c;
		}
		IL_00cf:
		_ = (s9EJ)(object)a7W.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)a7W.Default != null)
			{
				i0A1 obj6 = (i0A1)(object)a7W.Default;
				i0A = (i0A1)(object)a7W.Default;
				i0A = obj6;
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		try
		{
			Ln53 obj7 = (Ln53)(object)a7W.Default;
			ln = (Ln53)(object)a7W.Default;
			ln = obj7;
		}
		catch
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (b1YL)(object)a7W.Default;
					_ = (Jy1)(object)a7W.Default;
					sm = sm;
					sm = sm;
					_ = (Zo8)(object)a7W.Default;
				}
				else
				{
					sm = sm;
					qg = qg;
					qg = null;
					En1 en = null;
					en = en;
					_ = (Nm2f)(object)a7W.Default;
				}
			}
			catch
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					i0A = i0A;
				}
			}
		}
		Ta6 ta = ta;
		ta = null;
		while (true)
		{
			if ((object)a7W.Default != null)
			{
				_ = (b6E)(object)a7W.Default;
			}
			else if ((object)a7W.Default == null && (object)a7W.Default == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			En1 en = (En1)(object)a7W.Default;
		}
		if (uIntPtr / uIntPtr == 0)
		{
			_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
			Em1 em = null;
			em = em;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Zo8)(object)a7W.Default;
					ta = ta;
					Jy1 jy = (Jy1)(object)a7W.Default;
					jy = jy;
				}
				while ((object)a7W.Default != null);
			}
			catch
			{
				while (true)
				{
					if ((object)a7W.Default != null)
					{
						sm = sm;
						continue;
					}
					goto end_IL_02b7;
				}
				end_IL_02b7:;
			}
		}
		try
		{
			_ = (a1B)(object)a7W.Default;
		}
		finally
		{
			_ = (y8R)(object)a7W.Default;
			goto IL_02ed;
		}
		IL_0376:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			qg = null;
		}
		try
		{
			j3J obj12 = (j3J)(object)a7W.Default;
			j3J = null;
			j3J = obj12;
		}
		finally
		{
			_ = (Nm2f)(object)a7W.Default;
			_ = (Em1)(object)a7W.Default;
			i0A = (i0A1)(object)a7W.Default;
			Nm2f nm2f = (Nm2f)(object)a7W.Default;
			nm2f = nm2f;
			goto IL_03d9;
		}
		IL_0703:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (b1YL)(object)a7W.Default;
		}
		else
		{
			i0A = (i0A1)(object)a7W.Default;
		}
		while (obj4 != null)
		{
			if (checked(unchecked((nuint)(UIntPtr)a7W.Default) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					qg = null;
				}
			}
			else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				j3J = j3J;
				_ = (Ln53)(object)a7W.Default;
				j3J = (j3J)(object)a7W.Default;
				j3J = j3J;
			}
			else
			{
				nn9a = null;
			}
		}
		return;
		IL_02ed:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Zo8)(object)a7W.Default;
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			checked
			{
				if (uIntPtr == 0)
				{
					if (unchecked((nuint)(UIntPtr)a7W.Default) + (uIntPtr + unchecked((nuint)(UIntPtr)a7W.Default)) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						ln = ln;
					}
				}
				else
				{
					_ = (j3J)(object)a7W.Default;
					_ = (Ta6)(object)a7W.Default;
					_ = (En1)(object)a7W.Default;
					En1 en = null;
				}
				goto IL_0376;
			}
		}
		IL_03d9:
		try
		{
			try
			{
				while (obj4 != null)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (b6E)(object)a7W.Default;
				}
				catch
				{
					y8R obj14 = (y8R)(object)a7W.Default;
					y8R y8R2 = y8R2;
					y8R2 = obj14;
				}
			}
		}
		while (obj4 != null)
		{
			do
			{
				i0A = i0A;
			}
			while (obj4 != null);
		}
		_ = (i0A1)(object)a7W.Default;
		_003CModule_003E = null;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				try
				{
					En1 en = (En1)(object)a7W.Default;
					_ = (Ta6)(object)a7W.Default;
				}
				catch
				{
					Nn9a obj17 = (Nn9a)(object)a7W.Default;
					nn9a = null;
					nn9a = obj17;
				}
			}
		}
		else
		{
			_ = (Jy1)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			y8R y8R2 = null;
		}
		finally
		{
			try
			{
				nn9a = (Nn9a)(object)a7W.Default;
			}
			catch
			{
				a7W = null;
			}
			goto IL_04e0;
		}
		IL_056c:
		do
		{
			try
			{
				while (obj4 != null)
				{
					i0A = i0A;
				}
			}
			catch
			{
				y8R y8R2 = (y8R)(object)a7W.Default;
			}
		}
		while ((object)a7W.Default != null);
		do
		{
			if (checked(unchecked((nuint)(UIntPtr)a7W.Default) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					Em1 em = null;
				}
				else
				{
					Jy1 jy = null;
				}
			}
		}
		while (obj4 != null);
		_ = (b6E)(object)a7W.Default;
		while (obj4 != null)
		{
			while (obj4 != null)
			{
				_ = (En1)(object)a7W.Default;
				_ = (b1YL)(object)a7W.Default;
				_ = a7W.Default;
			}
		}
		do
		{
			try
			{
				_ = (y8R)(object)a7W.Default;
			}
			catch
			{
				try
				{
					_ = (i0A1)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
					_ = (s9EJ)(object)a7W.Default;
				}
				catch
				{
					i0A = null;
					_ = (Ta6)(object)a7W.Default;
					_ = (Qg6)(object)a7W.Default;
					_ = (Jy1)(object)a7W.Default;
				}
			}
		}
		while (obj4 != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				nn9a = nn9a;
			}
		}
		else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				ta = (Ta6)(object)a7W.Default;
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				try
				{
					_ = (Zo8)(object)a7W.Default;
				}
				catch
				{
					y8R y8R2 = null;
					a7W = a7W;
					_ = (Ta6)(object)a7W.Default;
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				goto IL_0703;
			}
		}
		goto IL_0703;
	}

	static void b3Q()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		checked
		{
			try
			{
				num = default(UIntPtr);
				num -= unchecked((nuint)(UIntPtr)a7W.Default);
				nuint num2 = num;
				num = default(UIntPtr);
				if (num2 - unchecked(num / num) == 0)
				{
					Jy1 jy = jy;
					jy = jy;
				}
				else
				{
					En1 en = (En1)(object)a7W.Default;
					en = en;
				}
			}
			catch
			{
				_ = (j3J)(object)a7W.Default;
			}
			Nm2f obj2 = (Nm2f)(object)a7W.Default;
			nm2f = nm2f;
			nm2f = obj2;
			try
			{
				qg = null;
				qg = null;
			}
			catch
			{
				if (num == 0)
				{
					if (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						a1B = (a1B)(object)a7W.Default;
						a1B = a1B;
					}
				}
				else
				{
					try
					{
						_ = (Nn9a)(object)a7W.Default;
					}
					catch
					{
						_ = (Ln53)(object)a7W.Default;
					}
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Nm2f)(object)a7W.Default;
			}
			while ((object)a7W.Default != null);
		}
		try
		{
			_ = (Nn9a)(object)a7W.Default;
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Jy1)(object)a7W.Default;
				}
			}
			catch
			{
			}
			goto IL_013e;
		}
		IL_0794:
		object obj6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R2);
		Sm6 sm;
		try
		{
			try
			{
				while (obj6 != null)
				{
					sm = null;
				}
			}
			catch
			{
				try
				{
					y8R2 = y8R2;
				}
				finally
				{
					_ = (Jy1)(object)a7W.Default;
					goto end_IL_07a6;
				}
				end_IL_07a6:;
			}
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		try
		{
			try
			{
				if (checked(num - num) == 0)
				{
					_ = (j3J)(object)a7W.Default;
					qg = null;
					ln = ln;
					_ = (Sm6)(object)a7W.Default;
				}
			}
			finally
			{
				try
				{
					i0A = i0A;
				}
				catch
				{
					j3J = j3J;
				}
				goto end_IL_07c6;
			}
			end_IL_07c6:;
		}
		finally
		{
			try
			{
				do
				{
					_ = (j3J)(object)a7W.Default;
					_ = (Jy1)(object)a7W.Default;
				}
				while (obj6 != null);
			}
			finally
			{
				while ((object)a7W.Default != null)
				{
					_ = (Ta6)(object)a7W.Default;
				}
				goto IL_084f;
			}
		}
		IL_0523:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			a1B = a1B;
		}
		try
		{
			_ = (Qg6)(object)a7W.Default;
		}
		catch
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		qg = qg;
		Zo8 zo = null;
		zo = null;
		b1YL b1YL = b1YL;
		_ = (_003CModule_003E)(object)a7W.Default;
		do
		{
			try
			{
				sm = sm;
			}
			catch
			{
				_ = (i0A1)(object)a7W.Default;
				_ = (Nn9a)(object)a7W.Default;
				b1YL = b1YL;
			}
		}
		while (obj6 != null);
		_ = (Ta6)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		do
		{
			try
			{
				do
				{
					b1YL = (b1YL)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
					a7W obj12 = a7W.Default;
					a7W = null;
					a7W = obj12;
				}
				while ((object)a7W.Default != null);
			}
			finally
			{
				_ = (Sm6)(object)a7W.Default;
				continue;
			}
		}
		while (obj6 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			qg = null;
		}
		else
		{
			_ = (Ta6)(object)a7W.Default;
		}
		while (true)
		{
			if ((object)a7W.Default != null)
			{
				En1 en = null;
				zo = zo;
			}
			else if (obj6 == null)
			{
				break;
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (i0A1)(object)a7W.Default;
				}
				else
				{
					ln = ln;
				}
			}
			catch
			{
				if (num == 0)
				{
					_ = (Zo8)(object)a7W.Default;
				}
			}
		}
		catch
		{
			do
			{
				Jy1 jy = null;
			}
			while ((object)a7W.Default != null);
		}
		try
		{
			if (num / (nuint)(UIntPtr)a7W.Default == 0)
			{
				_ = (j3J)(object)a7W.Default;
			}
		}
		catch
		{
		}
		_ = (Ta6)(object)a7W.Default;
		try
		{
			try
			{
				b1YL = (b1YL)(object)a7W.Default;
			}
			finally
			{
				_ = (Ln53)(object)a7W.Default;
				goto end_IL_06d0;
			}
			end_IL_06d0:;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				j3J = (j3J)(object)a7W.Default;
				_ = (b1YL)(object)a7W.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		try
		{
			while ((object)a7W.Default != null)
			{
				do
				{
					em = (Em1)(object)a7W.Default;
					Jy1 jy = (Jy1)(object)a7W.Default;
					b1YL = b1YL;
					ln = (Ln53)(object)a7W.Default;
				}
				while (obj6 != null);
			}
		}
		finally
		{
			try
			{
				_ = (j3J)(object)a7W.Default;
			}
			catch
			{
				_ = (Sm6)(object)a7W.Default;
			}
			finally
			{
				_ = (Sm6)(object)a7W.Default;
				goto IL_0794;
			}
		}
		IL_08ad:
		try
		{
			num = default(UIntPtr);
			nuint num3;
			checked
			{
				num3 = unchecked(checked(num - unchecked((nuint)(UIntPtr)a7W.Default)) / (nuint)(UIntPtr)a7W.Default) - num;
				num = default(UIntPtr);
			}
			if (checked(num3 * num - num) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = a7W.Default;
			}
		}
		catch
		{
			a7W = a7W.Default;
			_ = (Ta6)(object)a7W.Default;
		}
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Nm2f)(object)a7W.Default;
			}
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		try
		{
			a7W = a7W.Default;
			return;
		}
		finally
		{
			s9EJ = s9EJ;
			return;
		}
		IL_01d9:
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				if (num * (unchecked((nuint)(UIntPtr)a7W.Default) * num) + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					_ = (y8R)(object)a7W.Default;
				}
			}
			else
			{
				while ((object)a7W.Default != null)
				{
					try
					{
						_ = (Nn9a)(object)a7W.Default;
					}
					finally
					{
						_ = (En1)(object)a7W.Default;
						continue;
					}
				}
			}
			try
			{
				try
				{
					b6E b6E = b6E;
					b6E = b6E;
				}
				catch
				{
					a1B = null;
				}
				finally
				{
					try
					{
						ln = ln;
					}
					catch
					{
						_ = (y8R)(object)a7W.Default;
					}
					goto end_IL_023f;
				}
				end_IL_023f:;
			}
			finally
			{
				do
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (Qg6)(object)a7W.Default;
					Jy1 jy = null;
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				while (obj6 != null || obj6 != null);
				goto IL_02ed;
			}
		}
		IL_013e:
		Ln53 obj21 = (Ln53)(object)a7W.Default;
		ln = ln;
		ln = obj21;
		obj6 = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			UIntPtr num4 = (UIntPtr)a7W.Default;
			num = default(UIntPtr);
			if ((nuint)num4 / checked(num - num) == 0)
			{
				do
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				while (obj6 != null);
			}
		}
		else
		{
			em = null;
			em = em;
		}
		try
		{
			while ((object)a7W.Default != null)
			{
				while (obj6 != null)
				{
					_ = (Sm6)(object)a7W.Default;
				}
			}
		}
		finally
		{
			_ = (En1)(object)a7W.Default;
			goto IL_01d9;
		}
		IL_084f:
		try
		{
			a7W = a7W;
		}
		finally
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					qg = qg;
				}
				else
				{
					En1 en = null;
				}
			}
			catch
			{
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						_ = (Sm6)(object)a7W.Default;
					}
					else
					{
						em = em;
					}
				}
			}
			goto IL_08ad;
		}
		IL_02ed:
		while (obj6 != null)
		{
			while (obj6 != null)
			{
				try
				{
					b1YL = b1YL;
					b1YL = b1YL;
					a1B = a1B;
					_ = (Nn9a)(object)a7W.Default;
				}
				catch
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = a7W.Default;
				}
				else
				{
					_ = (Jy1)(object)a7W.Default;
				}
			}
			else
			{
				do
				{
					j3J = (j3J)(object)a7W.Default;
					j3J = j3J;
					_ = (Nm2f)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
					s9EJ = null;
				}
				while ((object)a7W.Default != null);
			}
		}
		else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (y8R)(object)a7W.Default;
		}
		_ = (a1B)(object)a7W.Default;
		while ((object)a7W.Default != null)
		{
			try
			{
				try
				{
					_ = (Ta6)(object)a7W.Default;
				}
				catch
				{
					_ = (y8R)(object)a7W.Default;
				}
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Em1)(object)a7W.Default;
					nm2f = nm2f;
					j3J = j3J;
					continue;
				}
				_ = (Em1)(object)a7W.Default;
				_ = a7W.Default;
				y8R obj25 = (y8R)(object)a7W.Default;
				y8R2 = (y8R)(object)a7W.Default;
				y8R2 = obj25;
				qg = qg;
			}
		}
		do
		{
			sm = (Sm6)(object)a7W.Default;
			sm = sm;
		}
		while (obj6 != null || obj6 != null || (object)a7W.Default != null);
		while (obj6 != null)
		{
			_ = (y8R)(object)a7W.Default;
		}
		do
		{
			if ((UIntPtr)a7W.Default != (UIntPtr)(nuint)0u)
			{
				do
				{
					s9EJ = s9EJ;
				}
				while ((object)a7W.Default != null);
				continue;
			}
			try
			{
				i0A = i0A;
				i0A = null;
			}
			catch
			{
				Jy1 jy = (Jy1)(object)a7W.Default;
			}
		}
		while (obj6 != null);
		_ = (Ta6)(object)a7W.Default;
		if (unchecked((nuint)default(UIntPtr)) / (checked(unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default)) / (nuint)(UIntPtr)a7W.Default) == 0)
		{
			try
			{
				do
				{
					_ = (i0A1)(object)a7W.Default;
				}
				while (obj6 != null);
			}
			finally
			{
				try
				{
					b1YL = b1YL;
				}
				finally
				{
					_ = (Ta6)(object)a7W.Default;
					goto IL_0523;
				}
			}
		}
		goto IL_0523;
	}

	static void t5P()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		try
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		catch
		{
			try
			{
				ta = null;
				ta = ta;
			}
			finally
			{
				_ = (Sm6)(object)a7W.Default;
				goto end_IL_000e;
			}
			end_IL_000e:;
		}
		finally
		{
			goto IL_0031;
		}
		IL_0031:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		try
		{
			while ((object)a7W.Default != null)
			{
				do
				{
					obj2 = obj2;
				}
				while (obj2 != null);
			}
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (En1)(object)a7W.Default;
			}
			goto IL_0067;
		}
		IL_0067:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				finally
				{
					a1B = (a1B)(object)a7W.Default;
					a1B = null;
					_ = (Qg6)(object)a7W.Default;
					sm = null;
					sm = sm;
					_ = a7W.Default;
					goto end_IL_0073;
				}
				end_IL_0073:;
			}
			catch
			{
				try
				{
					qg = (Qg6)(object)a7W.Default;
					qg = qg;
				}
				catch
				{
					Em1 em = em;
					em = em;
				}
			}
		}
		qg = qg;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				num /= checked(num + unchecked((nuint)(UIntPtr)a7W.Default));
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (a1B)(object)a7W.Default;
				}
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
			do
			{
				if (num == 0)
				{
					jy = jy;
					jy = null;
				}
			}
			while (obj2 != null);
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			a1B = null;
		}
		do
		{
			try
			{
				_ = (Em1)(object)a7W.Default;
			}
			catch
			{
				while (obj2 != null)
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
		}
		while (obj2 != null);
		Nm2f nm2f = nm2f;
		nm2f = null;
		sm = sm;
		_ = (s9EJ)(object)a7W.Default;
		while (obj2 != null)
		{
		}
		a7W a7W = a7W;
		a7W = null;
		try
		{
		}
		catch
		{
			nm2f = nm2f;
		}
		finally
		{
			goto IL_0231;
		}
		IL_0287:
		ta = ta;
		Nn9a nn9a = nn9a;
		nn9a = null;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Sm6)(object)a7W.Default;
				}
				finally
				{
					_ = (y8R)(object)a7W.Default;
					sm = sm;
					continue;
				}
			}
			goto IL_0306;
		}
		try
		{
			while (obj2 != null)
			{
				_ = (a1B)(object)a7W.Default;
			}
		}
		finally
		{
			do
			{
				_ = (b1YL)(object)a7W.Default;
			}
			while ((object)a7W.Default != null);
			goto IL_0306;
		}
		IL_05f2:
		while (obj2 != null)
		{
			do
			{
				ta = null;
			}
			while ((object)a7W.Default != null);
		}
		try
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					i0A1 i0A = (i0A1)(object)a7W.Default;
					ta = (Ta6)(object)a7W.Default;
				}
			}
			finally
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					nm2f = nm2f;
				}
				goto end_IL_05f8;
			}
			end_IL_05f8:;
		}
		finally
		{
			_ = (Jy1)(object)a7W.Default;
			goto IL_0665;
		}
		IL_0306:
		do
		{
			_ = (En1)(object)a7W.Default;
		}
		while ((object)a7W.Default != null);
		checked
		{
			try
			{
				nuint num2 = num;
				nuint num3 = num * unchecked((nuint)(UIntPtr)a7W.Default / num);
				num = default(UIntPtr);
				if (num2 + (num3 + (unchecked(num / num) - num)) == 0)
				{
					try
					{
						_ = (Nn9a)(object)a7W.Default;
					}
					catch
					{
						a1B = (a1B)(object)a7W.Default;
					}
				}
			}
			catch
			{
				while (obj2 != null)
				{
				}
			}
			Em1 em = null;
			ta = (Ta6)(object)a7W.Default;
			num = default(UIntPtr);
			if (num == 0)
			{
				if (num == 0)
				{
					while ((object)a7W.Default != null)
					{
						_ = (y8R)(object)a7W.Default;
					}
				}
				goto IL_03ee;
			}
		}
		try
		{
			_ = (s9EJ)(object)a7W.Default;
		}
		finally
		{
			nuint num4 = num;
			num = default(UIntPtr);
			if (num4 / num == 0)
			{
				_ = (En1)(object)a7W.Default;
			}
			goto IL_03ee;
		}
		IL_043a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		try
		{
			sm = sm;
			i0A1 i0A = (i0A1)(object)a7W.Default;
			i0A = i0A;
			zo = zo;
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				nm2f = nm2f;
			}
			goto IL_0479;
		}
		IL_0665:
		while (obj2 != null)
		{
			if (num == 0 && (UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Jy1)(object)a7W.Default;
			}
		}
		return;
		IL_0231:
		while (obj2 != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if (checked(num + num) == 0)
				{
					Zo8 obj9 = (Zo8)(object)a7W.Default;
					zo = zo;
					zo = obj9;
				}
				else
				{
					a1B = a1B;
				}
			}
			else
			{
				while (obj2 != null)
				{
					a7W = a7W.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Nm2f)(object)a7W.Default;
					_ = (a1B)(object)a7W.Default;
					qg = null;
				}
				catch
				{
					b6E = b6E;
					b6E = b6E;
				}
			}
			goto IL_0287;
		}
		IL_03ee:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (a1B)(object)a7W.Default;
			}
		}
		else
		{
			sm = sm;
		}
		_003CModule_003E = _003CModule_003E;
		try
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		finally
		{
			do
			{
				nn9a = null;
			}
			while (obj2 != null);
			goto IL_043a;
		}
		IL_0479:
		y8R y8R2 = y8R2;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = a7W.Default;
			_ = (Nm2f)(object)a7W.Default;
		}
		else
		{
			try
			{
				if (num / num == 0)
				{
					b6E = null;
					_ = (b1YL)(object)a7W.Default;
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
					_ = (En1)(object)a7W.Default;
				}
				catch
				{
					Em1 em = (Em1)(object)a7W.Default;
				}
			}
		}
		UIntPtr num5 = (UIntPtr)a7W.Default;
		UIntPtr num6 = (UIntPtr)a7W.Default;
		UIntPtr num7 = (UIntPtr)a7W.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num5) - unchecked((nuint)num6) * unchecked((nuint)num7 / num) == 0)
			{
				while ((object)a7W.Default != null)
				{
					do
					{
						a7W = a7W.Default;
					}
					while (obj2 != null);
				}
			}
		}
		if (num == 0)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (i0A1)(object)a7W.Default;
				}
				while (obj2 != null);
				goto IL_05f2;
			}
			try
			{
				b6E = b6E;
			}
			finally
			{
				b1YL b1YL = (b1YL)(object)a7W.Default;
				b1YL = b1YL;
				_ = (b1YL)(object)a7W.Default;
				goto IL_05f2;
			}
		}
		try
		{
			_ = (Nn9a)(object)a7W.Default;
		}
		catch
		{
			_ = (a1B)(object)a7W.Default;
		}
		finally
		{
			a1B = null;
			_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			_ = (Nn9a)(object)a7W.Default;
			nn9a = nn9a;
			goto IL_05f2;
		}
	}
}
