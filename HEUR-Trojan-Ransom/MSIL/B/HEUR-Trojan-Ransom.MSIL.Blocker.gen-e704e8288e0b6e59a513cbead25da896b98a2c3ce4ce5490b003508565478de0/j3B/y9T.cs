using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ba50;
using Cd1t;
using Ci75;
using Es0;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Ri5n;
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xo8;
using Xs5;
using a9D;
using c4ZK;
using e6H;
using q8B;
using s1Y;
using t5D;
using x9E1;

namespace j3B;

[DesignerGenerated]
public class y9T : Form
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
			EventHandler eventHandler = Fa0;
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
			EventHandler eventHandler = q3N;
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

	[field: AccessedThroughProperty("txtSRcode")]
	internal virtual TextBox txtSRcode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
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

	[field: AccessedThroughProperty("txtSRName")]
	internal virtual TextBox txtSRName
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

	[field: AccessedThroughProperty("txtSCode")]
	internal virtual TextBox txtSCode
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
			EventHandler eventHandler = n0C;
			Button val = _btnDelete;
			Button obj = val;
			Ta8.char_0[144] = (char)(Ta8.char_0[144] & Ta8.char_0[138] & '\u00b8');
			if (obj != null)
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
			EventHandler eventHandler = i4D;
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
				Ta8.char_0[153] = (char)((Ta8.char_0[153] + Ta8.char_0[209]) & 'Ë');
			}
		}
	}

	[field: AccessedThroughProperty("txtSEmail")]
	internal virtual TextBox txtSEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSName")]
	internal virtual TextBox txtSName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRAmount")]
	internal virtual TextBox txtSRAmount
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
			EventHandler eventHandler = Jj3;
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

	[field: AccessedThroughProperty("txtSphoneno")]
	internal virtual TextBox txtSphoneno
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

	public y9T()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)i2N);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Es4();
	}

	[DebuggerNonUserCode]
	protected override void Jr1(bool a6E)
	{
		try
		{
			if (a6E && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a6E);
		}
	}

	[DebuggerStepThrough]
	private void Es4()
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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		txtSRcode = new TextBox();
		Label10 = new Label();
		DataGridView1 = new DataGridView();
		Label9 = new Label();
		txtSRName = new TextBox();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		txtSCode = new TextBox();
		btnDelete = new Button();
		btnModify = new Button();
		txtSEmail = new TextBox();
		txtSName = new TextBox();
		txtSRAmount = new TextBox();
		Label2 = new Label();
		btnSave = new Button();
		txtSphoneno = new TextBox();
		Label1 = new Label();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(336, 29));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(115, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Supplier Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(721, 29));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(29, 29));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(10);
		Label7.set_Text("Go To Main");
		((Control)txtSRcode).set_Location(new Point(504, 151));
		((Control)txtSRcode).set_Name("txtSRcode");
		((Control)txtSRcode).set_Size(new Size(100, 20));
		((Control)txtSRcode).set_TabIndex(6);
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(428, 157));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(60, 13));
		((Control)Label10).set_TabIndex(99);
		Label10.set_Text("Raw Code:");
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(32, 239));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(724, 199));
		((Control)DataGridView1).set_TabIndex(11);
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(422, 95));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(66, 13));
		((Control)Label9).set_TabIndex(96);
		Label9.set_Text("Raw Name :");
		((Control)txtSRName).set_Location(new Point(504, 88));
		((Control)txtSRName).set_Name("txtSRName");
		((Control)txtSRName).set_Size(new Size(100, 20));
		((Control)txtSRName).set_TabIndex(4);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(164, 182));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(50, 13));
		((Control)Label8).set_TabIndex(94);
		Label8.set_Text("Email Id :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(134, 122));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(82, 13));
		((Control)Label5).set_TabIndex(93);
		Label5.set_Text("Supplier Name :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(414, 127));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(74, 13));
		((Control)Label4).set_TabIndex(92);
		Label4.set_Text("Raw Amount :");
		((Control)txtSCode).set_Location(new Point(241, 85));
		((Control)txtSCode).set_Name("txtSCode");
		((Control)txtSCode).set_Size(new Size(100, 20));
		((Control)txtSCode).set_TabIndex(0);
		((Control)btnDelete).set_Location(new Point(483, 202));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(9);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(365, 202));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(8);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		((Control)txtSEmail).set_Location(new Point(241, 176));
		((Control)txtSEmail).set_Name("txtSEmail");
		((Control)txtSEmail).set_Size(new Size(100, 20));
		((Control)txtSEmail).set_TabIndex(3);
		((Control)txtSName).set_Location(new Point(239, 115));
		((Control)txtSName).set_Name("txtSName");
		((Control)txtSName).set_Size(new Size(100, 20));
		((Control)txtSName).set_TabIndex(1);
		((Control)txtSRAmount).set_Location(new Point(504, 122));
		((Control)txtSRAmount).set_Name("txtSRAmount");
		((Control)txtSRAmount).set_Size(new Size(100, 20));
		((Control)txtSRAmount).set_TabIndex(5);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(138, 88));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(79, 13));
		((Control)Label2).set_TabIndex(90);
		Label2.set_Text("Supplier Code :");
		((Control)btnSave).set_Location(new Point(236, 202));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(7);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)txtSphoneno).set_Location(new Point(239, 150));
		((Control)txtSphoneno).set_Name("txtSphoneno");
		((Control)txtSphoneno).set_Size(new Size(100, 20));
		((Control)txtSphoneno).set_TabIndex(2);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(153, 153));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(61, 13));
		((Control)Label1).set_TabIndex(101);
		Label1.set_Text("Phone No :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtSphoneno);
		((Control)this).get_Controls().Add((Control)(object)txtSRcode);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)txtSRName);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)txtSCode);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)txtSEmail);
		((Control)this).get_Controls().Add((Control)(object)txtSName);
		((Control)this).get_Controls().Add((Control)(object)txtSRAmount);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmSupplierDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmSupplierDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void q3N(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void Fa0(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void i2N(object sender, EventArgs e)
	{
		n4X();
	}

	private void Jj3(object sender, EventArgs e)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_supplier_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())) + ",'" + txtSName.get_Text() + "','" + txtSphoneno.get_Text() + "','" + txtSEmail.get_Text() + "','" + txtSRName.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtSRAmount.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtSRcode.get_Text())) + ")");
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
		n4X();
	}

	public void n4X()
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_supplier_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Supplier Code");
			DataGridView1.get_Columns().Add("c2", "Supplier Name");
			DataGridView1.get_Columns().Add("c3", "Phone No");
			DataGridView1.get_Columns().Add("c4", "Email Id");
			DataGridView1.get_Columns().Add("c5", "Raw Name");
			DataGridView1.get_Columns().Add("c6", "Raw Amount");
			DataGridView1.get_Columns().Add("c7", "Raw Code");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[7]
				{
					rd.get_Item("scode").ToString(),
					rd.get_Item("sname"),
					rd.get_Item("sphoneno"),
					rd.get_Item("semail"),
					rd.get_Item("raw"),
					rd.get_Item("rawamt").ToString(),
					rd.get_Item("rawcode").ToString()
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

	private void n0C(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_supplier_detail where scode=" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())));
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
		n4X();
		Ta8.char_0[176] = (char)((Ta8.char_0[176] | Ta8.char_0[124]) & '¹');
	}

	private void i4D(object sender, EventArgs e)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_supplier_detail set sname='" + txtSName.get_Text() + "',sphoneno='" + txtSphoneno.get_Text() + "',semail='" + txtSEmail.get_Text() + "',raw='" + txtSRName.get_Text() + "',rawamt=" + Conversions.ToString(Conversions.ToInteger(txtSRAmount.get_Text())) + ",rawcode=" + Conversions.ToString(Conversions.ToInteger(txtSRcode.get_Text())) + "  where scode=" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())));
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
		n4X();
	}

	internal static byte[] Pn2(string[] Xm5, int j4J)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Xm5.Length - 1 + 1];
				int num = Xm5.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (Xm5[i].Contains(value))
						{
							int startIndex = Xm5[i].IndexOf(value);
							array[i] = Xm5[i].Remove(startIndex, 10);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Ng67.mDic["AO"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "PD", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static void Aw0()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = (Gw13)(object)j5Y1.Default;
			obj = obj;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			_ = (z1J)(object)j5Y1.Default;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Be5)(object)j5Y1.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				_ = (k8NS)j5Y1.Default;
			}
			goto IL_005a;
		}
		IL_0631:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		UIntPtr num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		try
		{
			if (num == 0)
			{
				try
				{
					br = br;
				}
				catch
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
			else
			{
				o8W = (o8W)(object)j5Y1.Default;
				k8NS = k8NS;
			}
		}
		finally
		{
			while (true)
			{
				if (obj != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_0685;
		}
		IL_005a:
		_ = (o8W)(object)j5Y1.Default;
		_ = (w5D)(object)j5Y1.Default;
		_ = (Cd0n)(object)j5Y1.Default;
		Ta8 obj5 = (Ta8)(object)j5Y1.Default;
		Ta8 ta = (Ta8)(object)j5Y1.Default;
		ta = obj5;
		Ma6 ma = null;
		ma = ma;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		try
		{
			try
			{
				Ws0 ws = ws;
				ws = ws;
			}
			finally
			{
				while (obj != null)
				{
					be = (Be5)(object)j5Y1.Default;
					be = be;
				}
				goto end_IL_00a4;
			}
			end_IL_00a4:;
		}
		catch
		{
			try
			{
				try
				{
					o8W obj6 = (o8W)(object)j5Y1.Default;
					o8W = o8W;
					o8W = obj6;
				}
				finally
				{
					_ = (Gw13)(object)j5Y1.Default;
					goto end_IL_00db;
				}
				end_IL_00db:;
			}
			finally
			{
				try
				{
					ta = ta;
				}
				finally
				{
					_ = (k8NS)j5Y1.Default;
					goto end_IL_00da;
				}
			}
			end_IL_00da:;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			k8NS = k8NS;
			k8NS = k8NS;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		do
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					ng = ng;
					ng = ng;
				}
				finally
				{
					_ = (Cd0n)(object)j5Y1.Default;
					continue;
				}
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		try
		{
			try
			{
				y9T obj8 = (y9T)(object)j5Y1.Default;
				y9T y9T2 = y9T2;
				y9T2 = obj8;
			}
			catch
			{
				_ = (t1P)(object)j5Y1.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
			while ((object)j5Y1.Default != null);
		}
		finally
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				Ja24 obj11 = (Ja24)(object)j5Y1.Default;
				ja = (Ja24)(object)j5Y1.Default;
				ja = obj11;
			}
			else
			{
				_ = j5Y1.Default;
			}
			goto IL_01ef;
		}
		IL_0685:
		n4NE n4NE = n4NE;
		n4NE = n4NE;
		try
		{
			if (num == 0)
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				finally
				{
					_ = (n4NE)(object)j5Y1.Default;
					goto end_IL_0695;
				}
			}
			try
			{
				br = br;
			}
			catch
			{
				Tg0e tg0e = (Tg0e)(object)j5Y1.Default;
			}
			end_IL_0695:;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Tg0e)(object)j5Y1.Default;
				}
				catch
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
			catch
			{
				while (true)
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
					if ((object)j5Y1.Default != null)
					{
						continue;
					}
					goto end_IL_06f2;
				}
				end_IL_06f2:;
			}
		}
		_ = (Cd0n)(object)j5Y1.Default;
		_ = (Cd0n)(object)j5Y1.Default;
		ja = ja;
		Gw13 gw = gw;
		gw = null;
		do
		{
			if (num != 0)
			{
				_ = (w5D)(object)j5Y1.Default;
			}
			else
			{
				ta = ta;
			}
		}
		while (obj != null);
		do
		{
			try
			{
				do
				{
					_ = (o8W)(object)j5Y1.Default;
				}
				while (obj != null);
			}
			catch
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
		}
		while (obj != null);
		_ = (Br2)(object)j5Y1.Default;
		try
		{
			_ = (Gw13)(object)j5Y1.Default;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
				finally
				{
					_ = (t1P)(object)j5Y1.Default;
					_003CModule_003E = _003CModule_003E;
					_ = (Be5)(object)j5Y1.Default;
					goto end_IL_07a2;
				}
				end_IL_07a2:;
			}
			catch
			{
				if (num == 0)
				{
					_ = (y9T)(object)j5Y1.Default;
				}
				else
				{
					gw = null;
				}
			}
		}
		checked
		{
			try
			{
				do
				{
					try
					{
						_ = (Cd0n)(object)j5Y1.Default;
					}
					catch
					{
						_ = (Cd0n)(object)j5Y1.Default;
					}
				}
				while ((object)j5Y1.Default != null);
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
				{
					while ((object)j5Y1.Default != null)
					{
						_ = (Cd0n)(object)j5Y1.Default;
						_ = (w5D)(object)j5Y1.Default;
					}
				}
			}
			do
			{
				_ = (c0B)(object)j5Y1.Default;
			}
			while (obj != null);
			return;
		}
		IL_01ef:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				t1P = t1P;
				t1P = null;
			}
		}
		catch
		{
			ng = ng;
		}
		finally
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ng67)(object)j5Y1.Default;
				goto IL_0253;
			}
			try
			{
				j5Y = null;
				j5Y = null;
			}
			finally
			{
				t1P = null;
				_ = (b2H1)j5Y1.Default;
				goto IL_0253;
			}
		}
		IL_0253:
		num = (UIntPtr)j5Y1.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B);
			while (obj != null)
			{
				if (num == 0)
				{
					c0B = c0B;
					c0B = null;
				}
			}
		}
		else if (num == 0)
		{
			while (obj != null)
			{
				k8NS = k8NS;
			}
		}
		else
		{
			_ = (k8NS)j5Y1.Default;
		}
		checked
		{
			try
			{
				do
				{
					UIntPtr num2 = unchecked((UIntPtr)j5Y1.Default);
					num = default(UIntPtr);
					if (unchecked((nuint)num2) - num != 0)
					{
						_ = (t1P)(object)j5Y1.Default;
						_ = (Be5)(object)j5Y1.Default;
						_ = (t1P)(object)j5Y1.Default;
					}
					else
					{
						_ = (t1P)(object)j5Y1.Default;
					}
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					try
					{
						j5Y = j5Y;
					}
					finally
					{
						_ = (k8NS)j5Y1.Default;
						goto end_IL_030b;
					}
					end_IL_030b:;
				}
				finally
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
					do
					{
						be = be;
						_ = (Tg0e)(object)j5Y1.Default;
						z1J obj22 = (z1J)(object)j5Y1.Default;
						z1J = z1J;
						z1J = obj22;
					}
					while (obj != null);
					goto end_IL_030a;
				}
				end_IL_030a:;
			}
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					t1P = t1P;
				}
			}
			while (obj != null)
			{
				try
				{
					try
					{
						_ = (n4NE)(object)j5Y1.Default;
					}
					finally
					{
						_ = (Gw13)(object)j5Y1.Default;
						goto end_IL_037a;
					}
					end_IL_037a:;
				}
				finally
				{
					try
					{
						Tg0e tg0e = (Tg0e)(object)j5Y1.Default;
						tg0e = tg0e;
					}
					finally
					{
						_ = (o8W)(object)j5Y1.Default;
						continue;
					}
				}
			}
			do
			{
				try
				{
					if (num == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
				catch
				{
				}
			}
			while ((object)j5Y1.Default != null);
			try
			{
				if (num == 0)
				{
					if (num == 0)
					{
						o8W = o8W;
					}
					else
					{
						_ = (Tg0e)(object)j5Y1.Default;
					}
				}
				else
				{
					ng = ng;
				}
			}
			catch
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (t1P)(object)j5Y1.Default;
						_ = (t1P)(object)j5Y1.Default;
						Ws0 ws = (Ws0)(object)j5Y1.Default;
						_ = (c0B)(object)j5Y1.Default;
					}
					continue;
				}
				try
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				finally
				{
					_003CModule_003E = null;
					continue;
				}
			}
			try
			{
				try
				{
					try
					{
						b2H1 obj26 = (b2H1)j5Y1.Default;
						b2H1 b2H = b2H;
						b2H = obj26;
					}
					catch
					{
						_ = (o8W)(object)j5Y1.Default;
					}
				}
				catch
				{
					_ = (z1J)(object)j5Y1.Default;
				}
			}
			catch
			{
				try
				{
					_ = (w5D)(object)j5Y1.Default;
				}
				catch
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (_003CModule_003E)(object)j5Y1.Default;
						y9T y9T2 = (y9T)(object)j5Y1.Default;
					}
					else
					{
						br = br;
						br = br;
					}
				}
			}
			try
			{
				while ((object)j5Y1.Default != null)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = j5Y1.Default;
					}
				}
			}
			catch
			{
				_ = (t1P)(object)j5Y1.Default;
			}
			try
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)j5Y1.Default) - num == 0)
					{
						_ = (Ja24)(object)j5Y1.Default;
					}
					else
					{
						_ = (Gw13)(object)j5Y1.Default;
					}
				}
				catch
				{
					try
					{
						ng = (Ng67)(object)j5Y1.Default;
						Ws0 ws = null;
					}
					catch
					{
						_ = (Be5)(object)j5Y1.Default;
					}
				}
			}
			catch
			{
				do
				{
					try
					{
						be = be;
					}
					finally
					{
						t1P = null;
						continue;
					}
				}
				while (obj != null);
			}
			try
			{
				_ = (c0B)(object)j5Y1.Default;
			}
			finally
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Ma6)(object)j5Y1.Default;
						_ = (t1P)(object)j5Y1.Default;
						_ = (b2H1)j5Y1.Default;
						ng = ng;
					}
				}
				finally
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
					do
					{
						ma = ma;
						w5D = w5D;
						w5D = null;
						_003CModule_003E = _003CModule_003E;
					}
					while (obj != null);
					goto IL_0631;
				}
			}
		}
	}

	static void Nj2()
	{
		Ja24 ja = ja;
		ja = ja;
		_ = (w5D)(object)j5Y1.Default;
		_ = (Ma6)(object)j5Y1.Default;
		UIntPtr num = (UIntPtr)j5Y1.Default;
		nuint num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num) + num2) == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					k8NS = k8NS;
					k8NS = k8NS;
					_ = (Gw13)(object)j5Y1.Default;
					Ws0 ws = ws;
					ws = ws;
					_ = (Ma6)(object)j5Y1.Default;
				}
				else
				{
					do
					{
						ng = (Ng67)(object)j5Y1.Default;
						ng = null;
						obj = j5Y1.Default;
					}
					while (obj != null);
				}
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)j5Y1.Default) * num2 == 0)
				{
					if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
					{
						_ = (o8W)(object)j5Y1.Default;
						_ = (Br2)(object)j5Y1.Default;
						_ = (z1J)(object)j5Y1.Default;
						_ = (Be5)(object)j5Y1.Default;
					}
					else
					{
						w5D = (w5D)(object)j5Y1.Default;
						w5D = w5D;
					}
				}
			}
			finally
			{
				try
				{
					c0B = c0B;
					c0B = c0B;
					b2H = default(b2H1);
					b2H = b2H;
					b2H = default(b2H1);
					b2H = b2H;
				}
				catch
				{
					do
					{
						_ = (_003CModule_003E)(object)j5Y1.Default;
						ja = ja;
					}
					while (obj != null);
				}
				goto IL_0180;
			}
		}
		IL_04ae:
		_ = (w5D)(object)j5Y1.Default;
		_ = (o8W)(object)j5Y1.Default;
		if (checked(unchecked((nuint)(UIntPtr)j5Y1.Default) + num2) / num2 == 0)
		{
			do
			{
				_ = (n4NE)(object)j5Y1.Default;
			}
			while (obj != null);
		}
		else
		{
			do
			{
				try
				{
					w5D = w5D;
				}
				finally
				{
					_ = (c0B)(object)j5Y1.Default;
					continue;
				}
			}
			while (obj != null);
		}
		j5Y1 j5Y = j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		while (true)
		{
			if (obj != null)
			{
				t1P = t1P;
			}
			else if (obj == null && (object)j5Y1.Default == null)
			{
				break;
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			ng = ng;
		}
		do
		{
			try
			{
				while (obj != null)
				{
					_ = (k8NS)j5Y1.Default;
				}
			}
			catch
			{
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			try
			{
				_ = j5Y1.Default;
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 + (num2 + (unchecked((nuint)(UIntPtr)j5Y1.Default) - num2)) == 0)
				{
					if (unchecked((nuint)(UIntPtr)j5Y1.Default) - num2 - unchecked((nuint)(UIntPtr)j5Y1.Default) + num2 == 0)
					{
						_ = (w5D)(object)j5Y1.Default;
					}
				}
				else
				{
					b2H = b2H;
					_ = (w5D)(object)j5Y1.Default;
					_003CModule_003E = _003CModule_003E;
				}
				goto IL_05f4;
			}
		}
		IL_03fa:
		_ = (Tg0e)(object)j5Y1.Default;
		_ = (_003CModule_003E)(object)j5Y1.Default;
		nuint num3 = num2;
		nuint num4 = num2;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		checked
		{
			if (num3 + (num4 - (unchecked((nuint)default(UIntPtr)) + num2)) != 0)
			{
				j5Y = j5Y;
			}
			try
			{
				nuint num5 = num2;
				num2 = default(UIntPtr);
				if (num5 + num2 == 0)
				{
					try
					{
						o8W = null;
					}
					finally
					{
						b2H = (b2H1)j5Y1.Default;
						goto end_IL_0442;
					}
				}
				end_IL_0442:;
			}
			finally
			{
				nuint num6 = num2;
				UIntPtr num7 = unchecked((UIntPtr)j5Y1.Default);
				num2 = default(UIntPtr);
				if (num6 - (unchecked((nuint)num7) + (num2 - unchecked((nuint)(UIntPtr)j5Y1.Default))) == 0 && unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
				{
					j5Y = null;
				}
				goto IL_04ae;
			}
		}
		IL_082c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		do
		{
			IL_082c_2:
			if (obj != null)
			{
				try
				{
					cd0n = null;
				}
				finally
				{
					_ = (w5D)(object)j5Y1.Default;
					goto IL_082c_2;
				}
			}
		}
		while (obj != null);
		do
		{
			ng = ng;
		}
		while ((object)j5Y1.Default != null || (object)j5Y1.Default != null);
		return;
		IL_0264:
		_ = (k8NS)j5Y1.Default;
		Br2 br = (Br2)(object)j5Y1.Default;
		br = null;
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			j5Y = j5Y1.Default;
		}
		else
		{
			while (obj != null)
			{
				while ((object)j5Y1.Default != null)
				{
					k8NS = k8NS;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		try
		{
			try
			{
				try
				{
					ja = null;
				}
				finally
				{
					_ = (k8NS)j5Y1.Default;
					goto end_IL_02ba;
				}
				end_IL_02ba:;
			}
			finally
			{
				try
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				goto end_IL_02b9;
			}
			end_IL_02b9:;
		}
		catch
		{
			while (obj != null)
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y9T)(object)j5Y1.Default;
					o8W = o8W;
					o8W = o8W;
					_ = (Ws0)(object)j5Y1.Default;
					br = br;
				}
				else
				{
					gw = (Gw13)(object)j5Y1.Default;
					_ = (Tg0e)(object)j5Y1.Default;
				}
			}
		}
		if (num2 == 0)
		{
			try
			{
				try
				{
					o8W = o8W;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_0357;
				}
				end_IL_0357:;
			}
			finally
			{
				if (num2 == 0)
				{
					_ = (b2H1)j5Y1.Default;
				}
				else
				{
					_ = (b2H1)j5Y1.Default;
					Be5 be = null;
					be = be;
				}
				goto IL_03fa;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T2);
		try
		{
			try
			{
				y9T2 = y9T2;
			}
			finally
			{
				ja = ja;
				Cd0n obj6 = (Cd0n)(object)j5Y1.Default;
				cd0n = null;
				cd0n = obj6;
				_ = j5Y1.Default;
				_ = (Ja24)(object)j5Y1.Default;
				goto end_IL_039f;
			}
			end_IL_039f:;
		}
		catch
		{
			try
			{
				o8W = o8W;
			}
			catch
			{
				_ = (t1P)(object)j5Y1.Default;
			}
		}
		goto IL_03fa;
		IL_0180:
		try
		{
			do
			{
				gw = gw;
				gw = gw;
			}
			while (obj != null);
		}
		catch
		{
			y9T obj9 = (y9T)(object)j5Y1.Default;
			y9T2 = null;
			y9T2 = obj9;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
		}
		z1J z1J = null;
		z1J = z1J;
		try
		{
			num2 = default(UIntPtr);
			if (checked(num2 + (num2 - num2)) == 0)
			{
				t1P = (t1P)(object)j5Y1.Default;
				t1P = null;
			}
		}
		finally
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u && num2 == 0)
			{
				j5Y1 obj11 = j5Y1.Default;
				j5Y = j5Y;
				j5Y = obj11;
				y9T2 = (y9T)(object)j5Y1.Default;
				w5D = w5D;
			}
			goto IL_023c;
		}
		IL_05f4:
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					_ = (Tg0e)(object)j5Y1.Default;
					_ = (w5D)(object)j5Y1.Default;
					br = br;
				}
			}
			catch
			{
				_ = (c0B)(object)j5Y1.Default;
			}
		}
		gw = null;
		_ = (Be5)(object)j5Y1.Default;
		y9T2 = null;
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					w5D = null;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				finally
				{
					_ = (Ma6)(object)j5Y1.Default;
					continue;
				}
			}
			while (obj != null);
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				c0B = c0B;
			}
		}
		else if (checked(num2 - unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)j5Y1.Default == 0)
		{
			do
			{
				cd0n = cd0n;
			}
			while ((object)j5Y1.Default != null);
		}
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				_003CModule_003E = _003CModule_003E;
			}
			try
			{
				try
				{
					try
					{
						_ = (w5D)(object)j5Y1.Default;
					}
					catch
					{
						_ = (_003CModule_003E)(object)j5Y1.Default;
					}
				}
				catch
				{
					c0B = (c0B)(object)j5Y1.Default;
				}
			}
			catch
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
		}
		try
		{
			try
			{
				_ = j5Y1.Default;
			}
			catch
			{
				j5Y = j5Y;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				o8W = (o8W)(object)j5Y1.Default;
			}
			else
			{
				_ = (Gw13)(object)j5Y1.Default;
				w5D = w5D;
			}
		}
		finally
		{
			try
			{
				_ = (b2H1)j5Y1.Default;
				_ = (Br2)(object)j5Y1.Default;
				w5D = w5D;
			}
			catch
			{
				o8W = (o8W)(object)j5Y1.Default;
			}
			goto IL_082c;
		}
		IL_023c:
		try
		{
		}
		finally
		{
			if (checked(num2 * num2) == 0)
			{
				_ = (Ja24)(object)j5Y1.Default;
			}
			else
			{
				_ = (Br2)(object)j5Y1.Default;
			}
			goto IL_0264;
		}
	}

	static void Sn2()
	{
		Ws0 ws = ws;
		ws = ws;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			obj = null;
			goto IL_0063;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		Ja24 ja;
		try
		{
			do
			{
				be = null;
				be = be;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			catch
			{
				ja = (Ja24)(object)j5Y1.Default;
				ja = ja;
			}
			goto IL_0063;
		}
		IL_061a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		if (num == 0)
		{
			while (obj != null)
			{
				try
				{
					gw = (Gw13)(object)j5Y1.Default;
				}
				finally
				{
					cd0n = (Cd0n)(object)j5Y1.Default;
					continue;
				}
			}
		}
		y9T y9T2 = y9T2;
		y9T2 = null;
		o8W o8W = null;
		_ = (Br2)(object)j5Y1.Default;
		cd0n = cd0n;
		_ = (Ja24)(object)j5Y1.Default;
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (b2H1)j5Y1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (y9T)(object)j5Y1.Default;
				}
				catch
				{
					_ = (n4NE)(object)j5Y1.Default;
					_ = (y9T)(object)j5Y1.Default;
					ma = ma;
					ma = ma;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (Br2)(object)j5Y1.Default;
				}
			}
		}
		be = be;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		do
		{
			t1P = t1P;
		}
		while (obj != null || obj != null);
		return;
		IL_0422:
		c0B c0B = null;
		UIntPtr num2 = (UIntPtr)j5Y1.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		checked
		{
			if (unchecked((nuint)num2) + num == 0)
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			else if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					c0B = null;
				}
			}
			else
			{
				num = default(UIntPtr);
				unchecked
				{
					if (unchecked((nuint)default(UIntPtr)) / num != 0)
					{
						gw = gw;
					}
				}
			}
			if (num == 0)
			{
				do
				{
					try
					{
						ja = ja;
					}
					finally
					{
						_ = (n4NE)(object)j5Y1.Default;
						continue;
					}
				}
				while (obj != null);
			}
			else
			{
				cd0n = cd0n;
			}
			try
			{
				if (num == 0)
				{
					try
					{
						_ = (z1J)(object)j5Y1.Default;
					}
					finally
					{
						_003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
						goto end_IL_04c2;
					}
				}
				ja = (Ja24)(object)j5Y1.Default;
				end_IL_04c2:;
			}
			catch
			{
				try
				{
					_ = (t1P)(object)j5Y1.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			while ((object)j5Y1.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0 && num == 0)
				{
					_ = j5Y1.Default;
					_ = (c0B)(object)j5Y1.Default;
					_ = (Ta8)(object)j5Y1.Default;
					_ = (Ng67)(object)j5Y1.Default;
				}
			}
			try
			{
				while ((object)j5Y1.Default != null)
				{
					if (num + (unchecked((nuint)(UIntPtr)j5Y1.Default) - num) == 0)
					{
						z1J = (z1J)(object)j5Y1.Default;
					}
				}
			}
			finally
			{
				try
				{
					num = default(UIntPtr);
					if (num * unchecked(num / num) * num == 0)
					{
						o8W obj7 = (o8W)(object)j5Y1.Default;
						o8W = o8W;
						o8W = obj7;
					}
					else
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
				finally
				{
					if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
					{
						k8NS = default(k8NS);
					}
					else
					{
						_ = (Ng67)(object)j5Y1.Default;
						_ = (Gw13)(object)j5Y1.Default;
						w5D = w5D;
					}
					goto IL_061a;
				}
			}
		}
		IL_0063:
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				try
				{
					if (num * unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)(UIntPtr)j5Y1.Default) * num == 0)
					{
						_ = (Ta8)(object)j5Y1.Default;
					}
					else
					{
						_ = j5Y1.Default;
					}
				}
				finally
				{
					try
					{
						cd0n = (Cd0n)(object)j5Y1.Default;
						cd0n = cd0n;
					}
					catch
					{
						_ = (Gw13)(object)j5Y1.Default;
						_ = (b2H1)j5Y1.Default;
					}
					goto IL_0129;
				}
			}
			while ((object)j5Y1.Default != null)
			{
				do
				{
					w5D obj9 = (w5D)(object)j5Y1.Default;
					w5D = w5D;
					w5D = obj9;
					_ = (b2H1)j5Y1.Default;
					ws = null;
					_ = (w5D)(object)j5Y1.Default;
				}
				while (obj != null);
			}
			goto IL_0129;
		}
		IL_030c:
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Cd0n)(object)j5Y1.Default;
					t1P = (t1P)(object)j5Y1.Default;
					t1P = null;
					_ = (Cd0n)(object)j5Y1.Default;
				}
				finally
				{
					b2H1 b2H = default(b2H1);
					_ = (b2H1)j5Y1.Default;
					continue;
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (Ws0)(object)j5Y1.Default;
			}
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = null;
					c0B = (c0B)(object)j5Y1.Default;
				}
				finally
				{
					j5Y1 j5Y = null;
					j5Y = j5Y;
					continue;
				}
			}
		}
		while (obj != null);
		k8NS obj11 = (k8NS)j5Y1.Default;
		k8NS = k8NS;
		k8NS = obj11;
		try
		{
			try
			{
				_ = (n4NE)(object)j5Y1.Default;
			}
			catch
			{
				_ = (w5D)(object)j5Y1.Default;
			}
		}
		catch
		{
			_ = (b2H1)j5Y1.Default;
		}
		finally
		{
			w5D = (w5D)(object)j5Y1.Default;
			goto IL_0422;
		}
		IL_02d4:
		_ = j5Y1.Default;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
		}
		finally
		{
			ja = (Ja24)(object)j5Y1.Default;
			goto IL_030c;
		}
		IL_0129:
		try
		{
			try
			{
				_ = (z1J)(object)j5Y1.Default;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				goto end_IL_012b;
			}
			end_IL_012b:;
		}
		catch
		{
			try
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			catch
			{
				gw = gw;
				gw = gw;
				_ = (y9T)(object)j5Y1.Default;
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (k8NS)j5Y1.Default;
					z1J = z1J;
					z1J = z1J;
					be = null;
				}
				while (obj != null);
			}
			catch
			{
				if (num == 0)
				{
					be = be;
				}
			}
			goto IL_01ba;
		}
		IL_01ba:
		w5D = w5D;
		while (obj != null)
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					be = be;
				}
				else
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				continue;
			}
		}
		while (obj != null)
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					c0B = (c0B)(object)j5Y1.Default;
					c0B = c0B;
				}
				else
				{
					_ = (c0B)(object)j5Y1.Default;
				}
			}
		}
		num = default(UIntPtr);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				while ((object)j5Y1.Default != null)
				{
					c0B = c0B;
				}
			}
			else if (num == 0)
			{
				_ = (o8W)(object)j5Y1.Default;
			}
			_ = (Ta8)(object)j5Y1.Default;
			z1J = z1J;
			while (true)
			{
				if (obj != null)
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
			try
			{
				do
				{
					_ = (Br2)(object)j5Y1.Default;
				}
				while (obj != null);
			}
			finally
			{
				c0B = null;
				goto IL_02d4;
			}
		}
	}
}
