using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using La50;
using Lg1;
using Microsoft.VisualBasic.CompilerServices;
using Qo03;
using Yi2x;
using Yw2;
using b8ED;
using e2N;
using f0B;
using f2K3;
using f4A;
using m4K5;
using m7A;
using r4B;
using r4Z;
using s6Y;
using w7Y6;
using w8E;

namespace f2H;

[DesignerGenerated]
public class Tb9 : Form
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
			EventHandler eventHandler = Ft0;
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
			EventHandler eventHandler = d1R;
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
			EventHandler eventHandler = r5N;
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
			EventHandler eventHandler = r0C;
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

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGWeight")]
	internal virtual TextBox txtGWeight
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

	[field: AccessedThroughProperty("txtFGood")]
	internal virtual TextBox txtFGood
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
			EventHandler eventHandler = z1B;
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFinishGoodCode")]
	internal virtual TextBox txtFinishGoodCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Tb9()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)j9M);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Pm4();
	}

	[DebuggerNonUserCode]
	protected override void e4X(bool Yb7)
	{
		try
		{
			if (Yb7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Yb7);
		}
	}

	[DebuggerStepThrough]
	private void Pm4()
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
		btnDelete = new Button();
		btnModify = new Button();
		DataGridView1 = new DataGridView();
		txtPId = new TextBox();
		txtGWeight = new TextBox();
		txtPCost = new TextBox();
		Label4 = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label5 = new Label();
		txtFGood = new TextBox();
		btnSave = new Button();
		Label8 = new Label();
		txtFinishGoodCode = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(326, 21));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(125, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Processing Cost");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(735, 21));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(14);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(43, 21));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Go To Main");
		((Control)btnDelete).set_Location(new Point(404, 183));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(7);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(404, 132));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(6);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(87, 232));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(599, 206));
		((Control)DataGridView1).set_TabIndex(25);
		((Control)txtPId).set_Location(new Point(229, 195));
		((Control)txtPId).set_Name("txtPId");
		((Control)txtPId).set_Size(new Size(100, 20));
		((Control)txtPId).set_TabIndex(4);
		((Control)txtGWeight).set_Location(new Point(229, 162));
		((Control)txtGWeight).set_Name("txtGWeight");
		((Control)txtGWeight).set_Size(new Size(100, 20));
		((Control)txtGWeight).set_TabIndex(3);
		((Control)txtPCost).set_Location(new Point(229, 135));
		((Control)txtPCost).set_Name("txtPCost");
		((Control)txtPCost).set_Size(new Size(100, 20));
		((Control)txtPCost).set_TabIndex(2);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(108, 169));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(106, 13));
		((Control)Label4).set_TabIndex(21);
		Label4.set_Text("Finish Good Weight :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(104, 108));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(110, 13));
		((Control)Label1).set_TabIndex(20);
		Label1.set_Text("Finish Process Good :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(151, 202));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(63, 13));
		((Control)Label2).set_TabIndex(19);
		Label2.set_Text("Process Id :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(139, 138));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(75, 13));
		((Control)Label5).set_TabIndex(18);
		Label5.set_Text("Process Cost :");
		((Control)txtFGood).set_Location(new Point(229, 105));
		((Control)txtFGood).set_Name("txtFGood");
		((Control)txtFGood).set_Size(new Size(100, 20));
		((Control)txtFGood).set_TabIndex(1);
		((Control)btnSave).set_Location(new Point(404, 72));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(5);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(117, 75));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(97, 13));
		((Control)Label8).set_TabIndex(29);
		Label8.set_Text("Finish Good Code :");
		((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
		((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
		((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
		((Control)txtFinishGoodCode).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)txtPId);
		((Control)this).get_Controls().Add((Control)(object)txtGWeight);
		((Control)this).get_Controls().Add((Control)(object)txtPCost);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtFGood);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmProcessingCost");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmProcessingCost");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void d1R(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void Ft0(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void z1B(object sender, EventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_cost values(" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())) + ",'" + txtFGood.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtGWeight.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ")");
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
		Fe1();
	}

	public void Fe1()
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_cost");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Finish Good Code");
			DataGridView1.get_Columns().Add("c2", "Finish Good");
			DataGridView1.get_Columns().Add("c3", "Processing Cost");
			DataGridView1.get_Columns().Add("c4", "Finish Good Weight");
			DataGridView1.get_Columns().Add("c5", "Processing Id");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("finishgoodcode").ToString(),
					rd.get_Item("finishgood"),
					rd.get_Item("procost").ToString(),
					rd.get_Item("finishgoodweight").ToString(),
					rd.get_Item("proid").ToString()
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

	internal static bool Yx5(int j5A)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(j5A + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				j5A = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				j5A = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				j5A = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) == 0 && Operators.CompareString(text, "l", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void j9M(object sender, EventArgs e)
	{
		Fe1();
	}

	private void r0C(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_cost set finishgood ='" + txtFGood.get_Text() + "',procost=" + txtPCost.get_Text() + ",finishgoodweight=" + txtGWeight.get_Text() + " where finishgoodcode=" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())));
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
		Fe1();
	}

	private void r5N(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_cost where finishgoodcode=" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())));
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
		Fe1();
	}

	internal static byte[] Ee6(int s2T, int Fn5)
	{
		if (s2T <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Fn5 + 1];
			for (int i = 0; i <= Fn5; i++)
			{
				int num = s2T * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return o7A.o1K(array, Fn5);
		}
	}

	static void g7T()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wm5 wm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			while (true)
			{
				obj = s6J.Default;
				if (obj == null)
				{
					break;
				}
				num *= unchecked((nuint)default(UIntPtr));
				if (num == 0)
				{
					try
					{
						_ = (c7R)(object)s6J.Default;
					}
					catch
					{
						wm = (Wm5)(object)s6J.Default;
						wm = wm;
					}
				}
			}
			try
			{
				m2R m2R = (m2R)(object)s6J.Default;
				m2R = m2R;
				_ = (x2K9)(object)s6J.Default;
				_ = (Rg0)(object)s6J.Default;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Dw54)(object)s6J.Default;
					_ = s6J.Default;
				}
			}
			while ((object)s6J.Default != null)
			{
				do
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = _003CModule_003E;
						_ = (Wm5)(object)s6J.Default;
						_ = (Qy5m)(object)s6J.Default;
					}
					finally
					{
						_ = (Rg0)(object)s6J.Default;
						continue;
					}
				}
				while ((object)s6J.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				x2K9 obj4 = (x2K9)(object)s6J.Default;
				x2K = (x2K9)(object)s6J.Default;
				x2K = obj4;
			}
		}
		catch
		{
			while (obj != null)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		do
		{
			_ = (g2M8)(object)s6J.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		while ((object)s6J.Default != null)
		{
			UIntPtr num2 = (UIntPtr)s6J.Default;
			UIntPtr num3 = (UIntPtr)s6J.Default;
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num2) + (unchecked((nuint)num3) - num) + unchecked((nuint)(UIntPtr)s6J.Default)) == 0)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)s6J.Default;
				}
				else
				{
					_ = (g2M8)(object)s6J.Default;
				}
			}
			else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				dw = dw;
				dw = null;
			}
		}
		nuint num4 = num;
		num = default(UIntPtr);
		checked
		{
			if (num4 + num - unchecked((nuint)(UIntPtr)s6J.Default) - unchecked((nuint)(UIntPtr)s6J.Default) == 0)
			{
				_ = (Dw54)(object)s6J.Default;
			}
			else
			{
				try
				{
					_ = (o7A)(object)s6J.Default;
				}
				catch
				{
					_ = s6J.Default;
				}
			}
			_ = (Tb9)(object)s6J.Default;
			_ = (c7R)(object)s6J.Default;
			_ = (Pg6)(object)s6J.Default;
			_ = (Pg6)(object)s6J.Default;
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num == 0 && num == 0)
				{
					wm = (Wm5)(object)s6J.Default;
				}
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)s6J.Default) - (num + num) == 0)
				{
					while (obj != null)
					{
						_ = (Rg0)(object)s6J.Default;
					}
				}
			}
			finally
			{
				try
				{
					c7R c7R = c7R;
					c7R = null;
				}
				catch
				{
					dw = (Dw54)(object)s6J.Default;
					_ = (Pg6)(object)s6J.Default;
				}
				goto IL_02d0;
			}
		}
		IL_040f:
		m9B m9B = m9B;
		_ = (m1S6)(object)s6J.Default;
		m9B = null;
		_ = (Pg6)(object)s6J.Default;
		nuint num5 = num;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		if (checked(num5 - (num - num)) == 0)
		{
			m1S = m1S;
			m1S = m1S;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			Ap93 ap = ap;
			ap = null;
		}
		else if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				m2R m2R = null;
			}
		}
		_ = (m9B)(object)s6J.Default;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pg6)(object)s6J.Default;
				}
				else
				{
					_ = (Rg0)(object)s6J.Default;
					_ = (a0E)(object)s6J.Default;
					_ = (Pg6)(object)s6J.Default;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)s6J.Default;
			}
		}
		catch
		{
			nuint num6 = num;
			num = default(UIntPtr);
			if (checked(num6 + num) == 0)
			{
				try
				{
					_ = (o7A)(object)s6J.Default;
				}
				catch
				{
					_ = (o7A)(object)s6J.Default;
				}
			}
			else if (num == 0)
			{
				_ = (c7B)(object)s6J.Default;
			}
			else
			{
				x2K = (x2K9)(object)s6J.Default;
			}
		}
		try
		{
			if ((nuint)(UIntPtr)s6J.Default / unchecked((nuint)default(UIntPtr)) == 0)
			{
				do
				{
					c7R c7R = null;
				}
				while (obj != null);
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				d9N2 d9N = d9N;
				d9N = d9N;
				_ = (g2M8)(object)s6J.Default;
			}
			else
			{
				_ = (Pg6)(object)s6J.Default;
				_ = (g2M8)(object)s6J.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				_ = (Wm5)(object)s6J.Default;
				m1S = m1S;
				_ = (x2K9)(object)s6J.Default;
			}
			goto IL_05df;
		}
		IL_065f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rg0 rg);
		do
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				rg = rg;
				rg = rg;
			}
		}
		while ((object)s6J.Default != null);
		while ((object)s6J.Default != null)
		{
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
				_ = (a0E)(object)s6J.Default;
				return;
			}
			catch
			{
				_ = (Wm5)(object)s6J.Default;
				return;
			}
			finally
			{
				Ap93 ap = null;
				return;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tb9 tb);
		try
		{
			do
			{
				tb = tb;
			}
			while (obj != null);
			return;
		}
		catch
		{
			try
			{
				_ = (m1S6)(object)s6J.Default;
				return;
			}
			finally
			{
				_ = (Qy5m)(object)s6J.Default;
				Ap93 ap = null;
				c7B c7B = null;
				c7B = c7B;
				return;
			}
		}
		IL_05df:
		try
		{
			try
			{
				do
				{
					_ = (g2M8)(object)s6J.Default;
				}
				while (obj != null);
			}
			finally
			{
				_ = (g2M8)(object)s6J.Default;
				goto end_IL_05e0;
			}
			end_IL_05e0:;
		}
		finally
		{
			try
			{
				x2K = x2K;
			}
			catch
			{
				_ = s6J.Default;
			}
			finally
			{
				try
				{
					_ = (m9B)(object)s6J.Default;
				}
				finally
				{
					_ = (Pg6)(object)s6J.Default;
					goto IL_065f;
				}
			}
		}
		IL_02d0:
		_ = (Pg6)(object)s6J.Default;
		nuint num7 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
		num = default(UIntPtr);
		nuint num8;
		checked
		{
			if (num7 + num == 0)
			{
				while ((object)s6J.Default != null)
				{
					dw = dw;
					_ = (m9B)(object)s6J.Default;
					m9B = m9B;
					m9B = m9B;
					tb = tb;
					tb = tb;
				}
			}
			_ = (Ap93)(object)s6J.Default;
			_ = (Ap93)(object)s6J.Default;
			_ = (c7R)(object)s6J.Default;
			_ = (Rg0)(object)s6J.Default;
			_ = (Wm5)(object)s6J.Default;
			num8 = unchecked(num / (nuint)(UIntPtr)s6J.Default) - unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
		}
		if (num8 / num == 0)
		{
			try
			{
				wm = wm;
			}
			finally
			{
				try
				{
					_ = (Tb9)(object)s6J.Default;
				}
				finally
				{
					_ = (g2M8)(object)s6J.Default;
					dw = (Dw54)(object)s6J.Default;
					_003CModule_003E = _003CModule_003E;
					goto IL_040f;
				}
			}
		}
		do
		{
			try
			{
				m2R m2R = null;
			}
			catch
			{
				_ = (g2M8)(object)s6J.Default;
			}
		}
		while ((object)s6J.Default != null);
		goto IL_040f;
	}

	static void Fe6()
	{
		object obj;
		while (true)
		{
			obj = s6J.Default;
			if (obj == null)
			{
				break;
			}
			_ = (g2M8)(object)s6J.Default;
		}
		_ = (d9N2)(object)s6J.Default;
		Rg0 rg = null;
		rg = rg;
		a0E a0E = null;
		a0E = a0E;
		Qy5m qy5m = qy5m;
		qy5m = qy5m;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7B c7B);
		m9B m9B;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R);
		try
		{
			while (obj != null)
			{
				while ((object)s6J.Default != null)
				{
					_ = (Pg6)(object)s6J.Default;
					c7B = (c7B)(object)s6J.Default;
					c7B = null;
				}
			}
		}
		catch
		{
			try
			{
				c7R = c7R;
				c7R = null;
				_ = (d9N2)(object)s6J.Default;
				_ = (_003CModule_003E)(object)s6J.Default;
				m9B = null;
				m9B = m9B;
			}
			catch
			{
				_ = (c7B)(object)s6J.Default;
			}
			finally
			{
				try
				{
					_ = (m9B)(object)s6J.Default;
					a0E = (a0E)(object)s6J.Default;
					c7B = c7B;
					_ = (Qy5m)(object)s6J.Default;
				}
				catch
				{
					_ = (m2R)(object)s6J.Default;
				}
				goto end_IL_008f;
			}
			end_IL_008f:;
		}
		o7A obj5 = (o7A)(object)s6J.Default;
		o7A o7A = o7A;
		o7A = obj5;
		nuint num;
		checked
		{
			try
			{
				while (obj != null)
				{
					num = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)s6J.Default);
					if (num == 0)
					{
						rg = null;
					}
					else
					{
						a0E = null;
					}
				}
			}
			finally
			{
				while ((object)s6J.Default != null)
				{
					try
					{
						_ = (c7B)(object)s6J.Default;
					}
					finally
					{
						_ = (Wm5)(object)s6J.Default;
						continue;
					}
				}
				goto IL_0190;
			}
		}
		IL_0260:
		try
		{
			try
			{
				do
				{
					_ = (Ap93)(object)s6J.Default;
					qy5m = qy5m;
					rg = rg;
					_ = (d9N2)(object)s6J.Default;
				}
				while (obj != null);
			}
			catch
			{
				_ = (m2R)(object)s6J.Default;
			}
		}
		catch
		{
			_ = (d9N2)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap93 ap);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw54 dw);
		checked
		{
			if (unchecked((nuint)(UIntPtr)s6J.Default) + num == 0)
			{
				try
				{
				}
				finally
				{
					_ = (c7R)(object)s6J.Default;
					goto IL_035c;
				}
			}
			if (num - num == 0)
			{
				try
				{
					_ = (m9B)(object)s6J.Default;
					_ = (x2K9)(object)s6J.Default;
					dw = dw;
				}
				catch
				{
					dw = (Dw54)(object)s6J.Default;
				}
			}
			else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
			{
				Ap93 obj9 = (Ap93)(object)s6J.Default;
				ap = ap;
				ap = obj9;
			}
			else
			{
				Wm5 wm = null;
				_ = (Rg0)(object)s6J.Default;
				_ = (x2K9)(object)s6J.Default;
				c7R = c7R;
			}
			goto IL_035c;
		}
		IL_0575:
		_ = (Wm5)(object)s6J.Default;
		_ = (c7R)(object)s6J.Default;
		do
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = s6J.Default;
				}
				else
				{
					dw = (Dw54)(object)s6J.Default;
				}
			}
			else
			{
				do
				{
					ap = ap;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o7A)(object)s6J.Default;
			}
			else
			{
				qy5m = qy5m;
			}
		}
		finally
		{
			while (true)
			{
				if ((object)s6J.Default != null)
				{
					_ = (m2R)(object)s6J.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_0641;
		}
		IL_035c:
		m9B = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (a0E)(object)s6J.Default;
				}
				catch
				{
					g2M8 g2M = g2M;
					g2M = null;
				}
			}
			catch
			{
				try
				{
					_ = (Rg0)(object)s6J.Default;
				}
				finally
				{
					_ = (Wm5)(object)s6J.Default;
					goto end_IL_0394;
				}
				end_IL_0394:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		s6J s6J;
		do
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
				_ = (Rg0)(object)s6J.Default;
				dw = dw;
				m1S = null;
				m1S = m1S;
				s6J = null;
				s6J = s6J;
			}
		}
		while (obj != null);
		s6J = s6J.Default;
		o7A = o7A;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_ = (Ap93)(object)s6J.Default;
				}
				catch
				{
					_ = (c7B)(object)s6J.Default;
					_ = (c7B)(object)s6J.Default;
				}
			}
		}
		qy5m = null;
		try
		{
			ap = null;
			_ = s6J.Default;
		}
		catch
		{
			try
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Dw54)(object)s6J.Default;
				}
			}
			catch
			{
				while (true)
				{
					_ = (Dw54)(object)s6J.Default;
					c7B = null;
					_ = (m9B)(object)s6J.Default;
					if ((object)s6J.Default != null)
					{
						continue;
					}
					goto end_IL_0488;
				}
				end_IL_0488:;
			}
		}
		try
		{
			while ((object)s6J.Default != null)
			{
			}
		}
		catch
		{
			do
			{
				rg = null;
				m1S = m1S;
				c7B = c7B;
			}
			while (obj != null);
		}
		Tb9 obj17 = (Tb9)(object)s6J.Default;
		Tb9 tb = tb;
		tb = obj17;
		try
		{
			try
			{
				_ = (a0E)(object)s6J.Default;
			}
			finally
			{
				while ((object)s6J.Default != null)
				{
					_ = (o7A)(object)s6J.Default;
				}
				goto end_IL_04fb;
			}
			end_IL_04fb:;
		}
		finally
		{
			try
			{
				_ = (m9B)(object)s6J.Default;
				_ = (Pg6)(object)s6J.Default;
				_ = (Tb9)(object)s6J.Default;
				_ = (Qy5m)(object)s6J.Default;
			}
			catch
			{
				try
				{
					_ = (m1S6)(object)s6J.Default;
				}
				finally
				{
					_ = (m9B)(object)s6J.Default;
					goto end_IL_0556;
				}
				end_IL_0556:;
			}
			goto IL_0575;
		}
		IL_0190:
		do
		{
			try
			{
				_ = (Qy5m)(object)s6J.Default;
			}
			finally
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					Pg6 pg = (Pg6)(object)s6J.Default;
					pg = pg;
				}
				continue;
			}
		}
		while ((object)s6J.Default != null);
		rg = (Rg0)(object)s6J.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				rg = (Rg0)(object)s6J.Default;
			}
			else
			{
				while ((object)s6J.Default != null)
				{
					dw = null;
					dw = dw;
					_ = (d9N2)(object)s6J.Default;
				}
			}
			goto IL_0260;
		}
		try
		{
			_ = (o7A)(object)s6J.Default;
		}
		finally
		{
			try
			{
				Wm5 obj19 = (Wm5)(object)s6J.Default;
				Wm5 wm = wm;
				wm = obj19;
			}
			finally
			{
				qy5m = null;
				goto IL_0260;
			}
		}
		IL_0641:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		while (obj != null)
		{
			while (obj != null)
			{
				try
				{
					_ = (Dw54)(object)s6J.Default;
				}
				catch
				{
					m2R = m2R;
					m2R = null;
				}
			}
		}
		if (num == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (checked(num * num) == 0)
			{
				_ = (o7A)(object)s6J.Default;
			}
		}
		_ = (m2R)(object)s6J.Default;
		_ = (g2M8)(object)s6J.Default;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)s6J.Default != null)
				{
					tb = null;
				}
			}
			else
			{
				dw = null;
			}
		}
		finally
		{
			try
			{
				_ = (g2M8)(object)s6J.Default;
			}
			catch
			{
				try
				{
					_ = (Qy5m)(object)s6J.Default;
				}
				finally
				{
					_ = (o7A)(object)s6J.Default;
					goto end_IL_06cd;
				}
				end_IL_06cd:;
			}
			goto IL_06ec;
		}
		IL_06ec:
		do
		{
			try
			{
				ap = ap;
			}
			finally
			{
				try
				{
					Pg6 pg = (Pg6)(object)s6J.Default;
				}
				finally
				{
					_ = (Tb9)(object)s6J.Default;
					_ = (m9B)(object)s6J.Default;
					continue;
				}
			}
		}
		while ((object)s6J.Default != null);
		c7R = c7R;
		dw = null;
		tb = (Tb9)(object)s6J.Default;
	}
}
