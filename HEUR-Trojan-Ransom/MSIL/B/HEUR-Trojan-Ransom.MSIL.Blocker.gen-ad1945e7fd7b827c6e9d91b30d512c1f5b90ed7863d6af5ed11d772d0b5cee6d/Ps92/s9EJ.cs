using System;
using System.Collections.Generic;
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

namespace Ps92;

[DesignerGenerated]
public class s9EJ : Form
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
			EventHandler eventHandler = t6XS;
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
			EventHandler eventHandler = Aa3d;
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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("txtSNo")]
	internal virtual TextBox txtSNo
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
			EventHandler eventHandler = At2w;
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
			EventHandler eventHandler = Mq3c;
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

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRaw")]
	internal virtual TextBox txtSRaw
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler eventHandler = k5Q9;
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

	public s9EJ()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d7EB);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Sb45();
	}

	[DebuggerNonUserCode]
	protected override void Kk7n(bool r7NS)
	{
		try
		{
			if (r7NS && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r7NS);
		}
	}

	[DebuggerStepThrough]
	private void Sb45()
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
		DataGridView1 = new DataGridView();
		DateTimePicker1 = new DateTimePicker();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label1 = new Label();
		txtSNo = new TextBox();
		btnDelete = new Button();
		btnModify = new Button();
		txtAmount = new TextBox();
		txtSRaw = new TextBox();
		txtWeight = new TextBox();
		Label2 = new Label();
		btnSave = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(355, 22));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(95, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Sales Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(739, 22));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(47, 22));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(8);
		Label7.set_Text("Go To Main");
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(33, 239));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(724, 199));
		((Control)DataGridView1).set_TabIndex(10);
		((Control)DateTimePicker1).set_Location(new Point(525, 64));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(126, 20));
		((Control)DateTimePicker1).set_TabIndex(3);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(154, 130));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(49, 13));
		((Control)Label8).set_TabIndex(94);
		Label8.set_Text("Amount :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(144, 101));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(66, 13));
		((Control)Label5).set_TabIndex(93);
		Label5.set_Text("Raw Name :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(431, 102));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(72, 13));
		((Control)Label4).set_TabIndex(92);
		Label4.set_Text("Raw Weight :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(438, 64));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(65, 13));
		((Control)Label1).set_TabIndex(91);
		Label1.set_Text("Sales Date :");
		((Control)txtSNo).set_Location(new Point(233, 64));
		((Control)txtSNo).set_Name("txtSNo");
		((Control)txtSNo).set_Size(new Size(100, 20));
		((Control)txtSNo).set_TabIndex(0);
		((Control)btnDelete).set_Location(new Point(480, 172));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(7);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(362, 172));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(6);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		((Control)txtAmount).set_Location(new Point(231, 124));
		((Control)txtAmount).set_Name("txtAmount");
		((Control)txtAmount).set_Size(new Size(100, 20));
		((Control)txtAmount).set_TabIndex(2);
		((Control)txtSRaw).set_Location(new Point(231, 94));
		((Control)txtSRaw).set_Name("txtSRaw");
		((Control)txtSRaw).set_Size(new Size(100, 20));
		((Control)txtSRaw).set_TabIndex(1);
		((Control)txtWeight).set_Location(new Point(525, 99));
		((Control)txtWeight).set_Name("txtWeight");
		((Control)txtWeight).set_Size(new Size(100, 20));
		((Control)txtWeight).set_TabIndex(4);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(155, 67));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(56, 13));
		((Control)Label2).set_TabIndex(90);
		Label2.set_Text("Sales No :");
		((Control)btnSave).set_Location(new Point(233, 172));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(5);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtSNo);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)txtAmount);
		((Control)this).get_Controls().Add((Control)(object)txtSRaw);
		((Control)this).get_Controls().Add((Control)(object)txtWeight);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmSalesDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmSalesDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Aa3d(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void t6XS(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void d7EB(object sender, EventArgs e)
	{
	}

	private void k5Q9(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_sales_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())) + ",'" + DateTimePicker1.get_Text() + "','" + txtSRaw.get_Text() + "','" + txtWeight.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ")");
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
		s4N5();
	}

	public void s4N5()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_sales_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Sales No");
			DataGridView1.get_Columns().Add("c2", "Sales Date");
			DataGridView1.get_Columns().Add("c3", "Raw Name");
			DataGridView1.get_Columns().Add("c4", "Raw Weight");
			DataGridView1.get_Columns().Add("c4", "Amount");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("salesno").ToString(),
					rd.get_Item("salesdate"),
					rd.get_Item("raw"),
					rd.get_Item("rawweight"),
					rd.get_Item("amount").ToString()
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

	private void At2w(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_sales_detail where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		s4N5();
	}

	internal static string[] x3S8()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(Em1.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				foreach (string item in array2)
				{
					list.Add(item);
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num2 = array3.Length - 1;
				for (num = 0; num <= num2; num++)
				{
					array3[num] = list[num];
				}
				return array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Mq3c(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_sales_detail set salesdate ='" + DateTimePicker1.get_Text() + "',raw='" + txtSRaw.get_Text() + "',rawweight='" + txtWeight.get_Text() + "',amount='" + txtAmount.get_Text() + "'  where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		s4N5();
	}

	static void Jm62()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ2);
		a1B a1B;
		b1YL b1YL;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				Nm2f obj = (Nm2f)(object)a7W.Default;
				nm2f = (Nm2f)(object)a7W.Default;
				nm2f = obj;
			}
			else if (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				try
				{
					_ = (j3J)(object)a7W.Default;
				}
				catch
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			Sm6 obj3 = (Sm6)(object)a7W.Default;
			sm = sm;
			sm = obj3;
			_ = (Nm2f)(object)a7W.Default;
			_ = (b6E)(object)a7W.Default;
			j3J = j3J;
			j3J = null;
			try
			{
				b6E b6E = b6E;
				b6E = b6E;
				_ = (Qg6)(object)a7W.Default;
				_ = a7W.Default;
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
				while (true)
				{
					obj4 = a7W.Default;
					if (obj4 != null)
					{
						try
						{
							Em1 obj5 = (Em1)(object)a7W.Default;
							em = (Em1)(object)a7W.Default;
							em = obj5;
						}
						catch
						{
							_ = (i0A1)(object)a7W.Default;
							_ = (b6E)(object)a7W.Default;
							Ta6 obj6 = (Ta6)(object)a7W.Default;
							ta = ta;
							ta = obj6;
						}
						continue;
					}
					break;
				}
			}
			try
			{
				try
				{
					if (uIntPtr == 0)
					{
						b1YL obj9 = (b1YL)(object)a7W.Default;
						b1YL = null;
						b1YL = obj9;
						a1B = (a1B)(object)a7W.Default;
						a1B = a1B;
						_ = (Ln53)(object)a7W.Default;
						_ = a7W.Default;
					}
				}
				finally
				{
					try
					{
						_ = (s9EJ)(object)a7W.Default;
					}
					catch
					{
						s9EJ obj10 = (s9EJ)(object)a7W.Default;
						s9EJ2 = s9EJ2;
						s9EJ2 = obj10;
					}
					goto end_IL_0130;
				}
				end_IL_0130:;
			}
			finally
			{
				_ = (Ln53)(object)a7W.Default;
				Ta6 ta = null;
				_ = (a1B)(object)a7W.Default;
				_ = (Ln53)(object)a7W.Default;
				goto IL_01cb;
			}
		}
		IL_03ba:
		b1YL = null;
		_ = (s9EJ)(object)a7W.Default;
		_ = (Ta6)(object)a7W.Default;
		_ = (i0A1)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		try
		{
			a1B = (a1B)(object)a7W.Default;
			qg = qg;
			sm = null;
		}
		catch
		{
			do
			{
				try
				{
					s9EJ2 = null;
				}
				catch
				{
					en = en;
				}
			}
			while ((object)a7W.Default != null);
		}
		s9EJ2 = null;
		a7W a7W = a7W;
		a7W = null;
		_ = (_003CModule_003E)(object)a7W.Default;
		_ = (En1)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					em = em;
					nn9a = nn9a;
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				else
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
		}
		finally
		{
			while ((object)a7W.Default != null)
			{
				i0A = i0A;
			}
			goto IL_04d8;
		}
		IL_04d8:
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (a1B)(object)a7W.Default;
					_ = (Qg6)(object)a7W.Default;
					qg = (Qg6)(object)a7W.Default;
					sm = sm;
				}
				while (obj4 != null);
			}
		}
		while (obj4 != null);
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		checked
		{
			if (unchecked((nuint)num) + uIntPtr == 0)
			{
				do
				{
					_ = (Ln53)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
			try
			{
				try
				{
					_ = (b1YL)(object)a7W.Default;
					sm = null;
					Ln53 obj14 = (Ln53)(object)a7W.Default;
					ln = null;
					ln = obj14;
					_ = (i0A1)(object)a7W.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
			}
			catch
			{
				_ = (j3J)(object)a7W.Default;
				_ = (b1YL)(object)a7W.Default;
				y8R = (y8R)(object)a7W.Default;
				s9EJ2 = s9EJ2;
			}
			finally
			{
				a1B = null;
				goto IL_0591;
			}
		}
		IL_067c:
		if (uIntPtr == 0)
		{
			while (obj4 != null)
			{
				nn9a = null;
				a7W = a7W;
				b1YL = b1YL;
				y8R = y8R;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				if (uIntPtr == 0)
				{
					_ = (Ta6)(object)a7W.Default;
					ln = ln;
				}
				else
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
					_ = (y8R)(object)a7W.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				while (obj4 != null)
				{
					_ = (j3J)(object)a7W.Default;
				}
			}
			else
			{
				try
				{
					nm2f = (Nm2f)(object)a7W.Default;
				}
				catch
				{
					b6E b6E = (b6E)(object)a7W.Default;
				}
			}
		}
		else
		{
			while (obj4 != null)
			{
				do
				{
					s9EJ2 = s9EJ2;
				}
				while ((object)a7W.Default != null);
			}
		}
		_ = (j3J)(object)a7W.Default;
		try
		{
			try
			{
				a1B = a1B;
				Zo8 zo = zo;
				zo = null;
				Jy1 jy = null;
			}
			catch
			{
				_ = (a1B)(object)a7W.Default;
			}
			finally
			{
				try
				{
					Jy1 jy = (Jy1)(object)a7W.Default;
				}
				finally
				{
					a1B = a1B;
					goto end_IL_075d;
				}
			}
			end_IL_075d:;
		}
		catch
		{
			i0A = i0A;
			b1YL = null;
			qg = qg;
		}
		if (uIntPtr == 0)
		{
			_ = (a1B)(object)a7W.Default;
		}
		else if (uIntPtr == 0)
		{
			_ = (j3J)(object)a7W.Default;
		}
		else
		{
			j3J = j3J;
		}
		return;
		IL_0348:
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				en = (En1)(object)a7W.Default;
			}
			else
			{
				while (obj4 != null)
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (Em1)(object)a7W.Default;
				em = (Em1)(object)a7W.Default;
				y8R = y8R;
				y8R = (y8R)(object)a7W.Default;
			}
			goto IL_03ba;
		}
		IL_05d8:
		_ = (Em1)(object)a7W.Default;
		do
		{
			nn9a = nn9a;
		}
		while (obj4 != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) * uIntPtr == 0)
			{
				while ((object)a7W.Default != null)
				{
					em = em;
				}
			}
			en = en;
			sm = sm;
			qg = null;
			try
			{
				try
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (Em1)(object)a7W.Default;
				}
				finally
				{
					do
					{
						_ = (i0A1)(object)a7W.Default;
					}
					while (obj4 != null);
					goto end_IL_062d;
				}
				end_IL_062d:;
			}
			finally
			{
				while (true)
				{
					if (obj4 != null)
					{
						_ = (y8R)(object)a7W.Default;
					}
					else if (obj4 == null)
					{
						break;
					}
				}
				goto IL_067c;
			}
		}
		IL_01cb:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num2 - uIntPtr) == 0)
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
			}
			catch
			{
				try
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		while (obj4 != null);
		try
		{
			try
			{
				Ta6 ta = null;
				nn9a = null;
				nn9a = nn9a;
			}
			catch
			{
				_ = (Ta6)(object)a7W.Default;
			}
			finally
			{
				try
				{
					Qg6 obj23 = (Qg6)(object)a7W.Default;
					qg = qg;
					qg = obj23;
				}
				catch
				{
					b6E b6E = (b6E)(object)a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
					_ = (Em1)(object)a7W.Default;
					_ = (Em1)(object)a7W.Default;
				}
				goto end_IL_0223;
			}
			end_IL_0223:;
		}
		catch
		{
			En1 obj25 = (En1)(object)a7W.Default;
			en = null;
			en = obj25;
			_ = (b1YL)(object)a7W.Default;
			y8R = null;
			y8R = y8R;
		}
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Jy1 obj27 = (Jy1)(object)a7W.Default;
					jy = jy;
					jy = obj27;
				}
			}
			while ((object)a7W.Default != null);
		}
		if (uIntPtr == 0)
		{
			_ = (Nn9a)(object)a7W.Default;
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
			}
			finally
			{
				while (obj4 != null)
				{
					i0A = null;
					i0A = i0A;
				}
				goto IL_0348;
			}
		}
		goto IL_0348;
		IL_0591:
		try
		{
			_ = (y8R)(object)a7W.Default;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (Nm2f)(object)a7W.Default;
				nm2f = nm2f;
				_ = a7W.Default;
			}
			else if (uIntPtr == 0)
			{
				_ = (a1B)(object)a7W.Default;
			}
			goto IL_05d8;
		}
	}

	static void j3Q5()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (a1B)(object)a7W.Default;
				}
				catch
				{
					_ = (b1YL)(object)a7W.Default;
				}
				obj2 = obj2;
			}
			while (obj2 != null);
		}
		else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (s9EJ)(object)a7W.Default;
			}
			catch
			{
				_ = (Em1)(object)a7W.Default;
			}
		}
		UIntPtr num = (UIntPtr)a7W.Default;
		nuint num2 = (UIntPtr)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		checked
		{
			if (unchecked((nuint)num) - num2 == 0)
			{
				if (num2 == 0)
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				else
				{
					_ = (Nm2f)(object)a7W.Default;
					Ln53 obj4 = (Ln53)(object)a7W.Default;
					ln = ln;
					ln = obj4;
					ln = ln;
					b6E b6E = (b6E)(object)a7W.Default;
					b6E = null;
				}
			}
			else
			{
				b6E b6E = b6E;
			}
			while ((object)a7W.Default != null)
			{
				do
				{
					try
					{
						_ = (s9EJ)(object)a7W.Default;
					}
					finally
					{
						_ = (En1)(object)a7W.Default;
						continue;
					}
				}
				while ((object)a7W.Default != null);
			}
			try
			{
				do
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = a7W.Default;
					}
				}
				while (obj2 != null);
			}
			finally
			{
				UIntPtr num3 = unchecked((UIntPtr)a7W.Default);
				num2 = default(UIntPtr);
				if (unchecked((nuint)num3) + num2 + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					UIntPtr num4 = unchecked((UIntPtr)a7W.Default);
					num2 = default(UIntPtr);
					if (unchecked((nuint)num4) * num2 == 0)
					{
						Qg6 obj5 = (Qg6)(object)a7W.Default;
						qg = (Qg6)(object)a7W.Default;
						qg = obj5;
					}
					else
					{
						_ = (y8R)(object)a7W.Default;
						_ = (y8R)(object)a7W.Default;
					}
				}
				else
				{
					try
					{
						sm = (Sm6)(object)a7W.Default;
						sm = null;
					}
					catch
					{
						qg = qg;
						_ = (y8R)(object)a7W.Default;
						Nn9a obj6 = (Nn9a)(object)a7W.Default;
						nn9a = nn9a;
						nn9a = obj6;
					}
				}
				goto IL_021c;
			}
		}
		IL_042b:
		try
		{
			_ = (Sm6)(object)a7W.Default;
		}
		finally
		{
			goto IL_043b;
		}
		IL_043b:
		_ = (_003CModule_003E)(object)a7W.Default;
		Zo8 zo = zo;
		zo = zo;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		if (num2 == 0)
		{
			qg = (Qg6)(object)a7W.Default;
			sm = null;
			nm2f = nm2f;
		}
		else
		{
			j3J = j3J;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		try
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Zo8)(object)a7W.Default;
				}
				finally
				{
					em = em;
					em = em;
					continue;
				}
			}
		}
		catch
		{
			_ = (Jy1)(object)a7W.Default;
			_ = (Jy1)(object)a7W.Default;
		}
		while (obj2 != null)
		{
			while (obj2 != null)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		try
		{
			en = en;
			en = en;
		}
		catch
		{
			while (true)
			{
				if (obj2 != null)
				{
					sm = sm;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		s9EJ s9EJ2 = s9EJ2;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				nuint num5;
				checked
				{
					num5 = num2 + unchecked((nuint)(UIntPtr)a7W.Default);
					num2 = default(UIntPtr);
				}
				if (num5 / num2 == 0)
				{
					em = em;
				}
				else
				{
					_ = (y8R)(object)a7W.Default;
				}
			}
			finally
			{
				try
				{
					_ = (En1)(object)a7W.Default;
				}
				catch
				{
					_ = (Ta6)(object)a7W.Default;
				}
				goto IL_0590;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		do
		{
			try
			{
				_ = a7W.Default;
			}
			catch
			{
				a7W = a7W;
			}
		}
		while (obj2 != null);
		goto IL_0590;
		IL_0590:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					qg = qg;
				}
				catch
				{
					_ = (Nm2f)(object)a7W.Default;
				}
			}
			catch
			{
				do
				{
					en = en;
				}
				while ((object)a7W.Default != null);
			}
		}
		else
		{
			while ((object)a7W.Default != null)
			{
				while (obj2 != null)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
		}
		while (obj2 != null)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				if (num2 == 0)
				{
					_ = (En1)(object)a7W.Default;
					continue;
				}
				_ = (Sm6)(object)a7W.Default;
				_ = (y8R)(object)a7W.Default;
			}
		}
		_ = (_003CModule_003E)(object)a7W.Default;
		_ = (_003CModule_003E)(object)a7W.Default;
		try
		{
			while (obj2 != null)
			{
				if (num2 == 0)
				{
					_ = (a1B)(object)a7W.Default;
				}
				else
				{
					_ = (En1)(object)a7W.Default;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					nn9a = null;
				}
				else
				{
					j3J = j3J;
				}
			}
			catch
			{
				try
				{
					_ = (a1B)(object)a7W.Default;
					goto end_IL_0689;
				}
				catch
				{
					_ = (j3J)(object)a7W.Default;
					goto end_IL_0689;
				}
				end_IL_0689:;
			}
		}
		do
		{
			if ((UIntPtr)a7W.Default != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					a7W = a7W.Default;
				}
			}
			else
			{
				_ = (Zo8)(object)a7W.Default;
			}
		}
		while (obj2 != null);
		nuint num6 = num2;
		nuint num7 = num2;
		a1B a1B;
		checked
		{
			nuint num8 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)a7W.Default);
			num2 = default(UIntPtr);
			if (num6 * ((num7 * (num8 * num2) - num2) * unchecked((nuint)(UIntPtr)a7W.Default)) == 0)
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default / num2) == 0)
				{
					try
					{
						_ = (Qg6)(object)a7W.Default;
						a1B = a1B;
						i0A1 i0A = null;
						i0A = null;
						sm = sm;
						return;
					}
					catch
					{
						sm = (Sm6)(object)a7W.Default;
						_ = (i0A1)(object)a7W.Default;
						a7W = a7W;
						_ = (b6E)(object)a7W.Default;
						return;
					}
				}
				try
				{
					_ = (Jy1)(object)a7W.Default;
					return;
				}
				catch
				{
					en = (En1)(object)a7W.Default;
					j3J = j3J;
					i0A1 i0A = i0A;
					_ = (i0A1)(object)a7W.Default;
					return;
				}
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (b1YL)(object)a7W.Default;
		}
		return;
		IL_021c:
		while ((object)a7W.Default != null)
		{
			while ((object)a7W.Default != null)
			{
				_ = (Sm6)(object)a7W.Default;
			}
		}
		checked
		{
			while (obj2 != null)
			{
				num2 = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) * num2) == 0)
				{
					try
					{
						nn9a = (Nn9a)(object)a7W.Default;
					}
					finally
					{
						_ = (Sm6)(object)a7W.Default;
						continue;
					}
				}
			}
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
			}
			finally
			{
				j3J = j3J;
				j3J = null;
				goto IL_02a7;
			}
		}
		IL_02a7:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					nm2f = nm2f;
					nm2f = nm2f;
				}
				finally
				{
					_ = (En1)(object)a7W.Default;
					goto end_IL_02b6;
				}
				end_IL_02b6:;
			}
			catch
			{
				while (obj2 != null)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
		}
		do
		{
			try
			{
				_ = (Ln53)(object)a7W.Default;
				sm = sm;
				ln = ln;
				_ = (Nm2f)(object)a7W.Default;
			}
			catch
			{
				_ = (y8R)(object)a7W.Default;
			}
			finally
			{
				if (num2 == 0)
				{
					_ = (En1)(object)a7W.Default;
				}
				continue;
			}
		}
		while (obj2 != null);
		if (num2 == 0)
		{
			_ = (Ln53)(object)a7W.Default;
		}
		_ = (Nm2f)(object)a7W.Default;
		a1B = null;
		a1B = null;
		checked
		{
			while (obj2 != null)
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)(UIntPtr)a7W.Default) != 0)
					{
						a1B = (a1B)(object)a7W.Default;
					}
					else
					{
						nn9a = (Nn9a)(object)a7W.Default;
					}
				}
				while ((object)a7W.Default != null);
			}
			try
			{
				while (obj2 != null)
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						nm2f = (Nm2f)(object)a7W.Default;
					}
					else
					{
						_ = (Zo8)(object)a7W.Default;
					}
				}
			}
			finally
			{
				try
				{
					try
					{
						nm2f = nm2f;
					}
					finally
					{
						_ = (Nm2f)(object)a7W.Default;
						goto end_IL_03fc;
					}
					end_IL_03fc:;
				}
				finally
				{
					while (obj2 != null)
					{
						nn9a = nn9a;
					}
					goto IL_042b;
				}
			}
		}
	}

	static void k6D9()
	{
		_003CModule_003E _003CModule_003E = null;
		_003CModule_003E = _003CModule_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			qg = qg;
			qg = qg;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = num;
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Zo8)(object)a7W.Default;
				}
				else
				{
					_ = (a1B)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
				}
			}
			catch
			{
				nm2f = (Nm2f)(object)a7W.Default;
				nm2f = null;
			}
		}
		else
		{
			_ = (Zo8)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		Ta6 ta;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					y8R = (y8R)(object)a7W.Default;
					y8R = null;
				}
				finally
				{
					_ = (a1B)(object)a7W.Default;
					goto end_IL_00a3;
				}
				end_IL_00a3:;
			}
			catch
			{
				try
				{
					_ = (Jy1)(object)a7W.Default;
				}
				finally
				{
					_ = (i0A1)(object)a7W.Default;
					goto end_IL_00c8;
				}
				end_IL_00c8:;
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (Nm2f)(object)a7W.Default;
				}
				catch
				{
					ta = null;
					ta = ta;
				}
			}
			while ((object)a7W.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		if (num == 0)
		{
			while (true)
			{
				if (obj != null)
				{
					em = em;
					em = em;
					_ = (Nm2f)(object)a7W.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		_ = (Em1)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			a7W = a7W;
			a7W = a7W;
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Em1)(object)a7W.Default;
				}
				while (obj != null);
			}
			else
			{
				try
				{
					_ = (a1B)(object)a7W.Default;
				}
				catch
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (Nn9a)(object)a7W.Default;
					_ = (Ln53)(object)a7W.Default;
					_ = (a1B)(object)a7W.Default;
				}
			}
			goto IL_01bd;
		}
		IL_0505:
		ta = null;
		do
		{
			_ = (Em1)(object)a7W.Default;
			_ = (s9EJ)(object)a7W.Default;
		}
		while (obj != null);
		while ((object)a7W.Default != null)
		{
			do
			{
				try
				{
					_ = (s9EJ)(object)a7W.Default;
				}
				catch
				{
					_ = (Em1)(object)a7W.Default;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		try
		{
			try
			{
				try
				{
					_ = (Ln53)(object)a7W.Default;
				}
				finally
				{
					sm = sm;
					goto end_IL_0557;
				}
				end_IL_0557:;
			}
			finally
			{
				while (obj != null)
				{
					_ = (Zo8)(object)a7W.Default;
				}
				goto end_IL_0556;
			}
			end_IL_0556:;
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (Qg6)(object)a7W.Default;
					em = em;
					en = (En1)(object)a7W.Default;
				}
			}
			catch
			{
				nuint num2 = num;
				nuint num3 = num;
				num = default(UIntPtr);
				if (num2 / (num3 / num) == 0)
				{
					ta = ta;
				}
				else
				{
					en = (En1)(object)a7W.Default;
				}
			}
			goto IL_05ed;
		}
		IL_028e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ2);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			s9EJ2 = s9EJ2;
			_ = (s9EJ)(object)a7W.Default;
			_003CModule_003E = _003CModule_003E;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		try
		{
			try
			{
				i0A1 obj8 = (i0A1)(object)a7W.Default;
				i0A = null;
				i0A = obj8;
			}
			catch
			{
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (En1)(object)a7W.Default;
				}
				finally
				{
					sm = sm;
					goto end_IL_02d2;
				}
				end_IL_02d2:;
			}
			catch
			{
				while (true)
				{
					_ = (Nm2f)(object)a7W.Default;
					s9EJ2 = s9EJ2;
					if (obj != null)
					{
						continue;
					}
					goto end_IL_02ec;
				}
				end_IL_02ec:;
			}
		}
		if ((nuint)(UIntPtr)a7W.Default / num == 0)
		{
			_ = (b6E)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		try
		{
			while ((object)a7W.Default != null)
			{
				try
				{
					_ = (Ln53)(object)a7W.Default;
				}
				catch
				{
					a1B = a1B;
					a1B = a1B;
					a1B = a1B;
					_ = a7W.Default;
				}
			}
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				b6E obj13 = (b6E)(object)a7W.Default;
				b6E b6E = b6E;
				b6E = obj13;
				goto IL_03b0;
			}
			try
			{
				qg = (Qg6)(object)a7W.Default;
			}
			finally
			{
				_ = (Em1)(object)a7W.Default;
				goto IL_03b0;
			}
		}
		IL_05ed:
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (a1B)(object)a7W.Default;
		}
		else if (checked(num + num) == 0)
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
			}
			catch
			{
			}
		}
		else
		{
			while (obj != null)
			{
				nm2f = (Nm2f)(object)a7W.Default;
			}
		}
		_ = (b1YL)(object)a7W.Default;
		a1B = a1B;
		a7W = a7W;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		try
		{
			try
			{
				while ((object)a7W.Default != null)
				{
					en = en;
				}
			}
			finally
			{
				goto end_IL_0650;
			}
			end_IL_0650:;
		}
		catch
		{
			while (obj != null)
			{
				do
				{
					j3J = j3J;
				}
				while (obj != null);
			}
		}
		if (num != 0)
		{
		}
		_ = (b6E)(object)a7W.Default;
		i0A = i0A;
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) - num == 0)
			{
				ta = ta;
				_ = (a1B)(object)a7W.Default;
				a1B = null;
			}
			else
			{
				nuint num4 = num - (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)default(UIntPtr)));
				num = default(UIntPtr);
				if (num4 * num == 0)
				{
					_ = (a1B)(object)a7W.Default;
				}
			}
			if (num != 0 && unchecked((nuint)(UIntPtr)a7W.Default) * unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) == 0)
			{
				j3J = j3J;
			}
			return;
		}
		IL_04a1:
		try
		{
			if (num == 0)
			{
				try
				{
					sm = sm;
				}
				finally
				{
					a1B = a1B;
					s9EJ2 = (s9EJ)(object)a7W.Default;
					_ = (Qg6)(object)a7W.Default;
					i0A = (i0A1)(object)a7W.Default;
					goto end_IL_04a2;
				}
			}
			end_IL_04a2:;
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
					_ = (s9EJ)(object)a7W.Default;
				}
				catch
				{
					y8R = y8R;
				}
				goto IL_0505;
			}
		}
		IL_03b0:
		if (num == 0)
		{
			_ = (Em1)(object)a7W.Default;
			_ = (s9EJ)(object)a7W.Default;
		}
		else
		{
			while (obj != null)
			{
				if (num == 0)
				{
					ta = (Ta6)(object)a7W.Default;
				}
				else
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
		}
		if (num / num == 0)
		{
			em = null;
		}
		else
		{
			j3J = j3J;
		}
		do
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				_ = (b1YL)(object)a7W.Default;
				continue;
			}
			while (obj != null)
			{
				_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			}
		}
		while ((object)a7W.Default != null);
		try
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
			}
			finally
			{
				_ = (Ta6)(object)a7W.Default;
				goto end_IL_0453;
			}
			end_IL_0453:;
		}
		catch
		{
			_ = (b1YL)(object)a7W.Default;
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = (Qg6)(object)a7W.Default;
				}
				catch
				{
					Jy1 jy = null;
				}
			}
			goto IL_04a1;
		}
		IL_01bd:
		try
		{
			j3J = (j3J)(object)a7W.Default;
			j3J = j3J;
		}
		finally
		{
			if (num == 0)
			{
				if (num == 0)
				{
					j3J = null;
				}
				else
				{
					Jy1 jy = null;
					jy = jy;
					_ = (b6E)(object)a7W.Default;
					s9EJ obj19 = (s9EJ)(object)a7W.Default;
					s9EJ2 = s9EJ2;
					s9EJ2 = obj19;
				}
			}
			goto IL_0219;
		}
		IL_0219:
		nm2f = nm2f;
		_ = (Ln53)(object)a7W.Default;
		a7W = a7W;
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Em1)(object)a7W.Default;
					y8R = (y8R)(object)a7W.Default;
				}
				finally
				{
					a7W = a7W;
					goto end_IL_023f;
				}
				end_IL_023f:;
			}
			catch
			{
				try
				{
					en = en;
					en = en;
				}
				catch
				{
					sm = null;
					sm = sm;
				}
			}
			goto IL_028e;
		}
	}
}
