using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
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
using n0WD;
using n4M;
using n7K;
using o9R;
using p6S;
using y1M;
using y8D;

namespace o1N;

[DesignerGenerated]
public class b6E : Form
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
			EventHandler eventHandler = Tt8;
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
			EventHandler eventHandler = i9M;
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
			EventHandler eventHandler = s5P;
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
			EventHandler eventHandler = Rf7;
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
			EventHandler eventHandler = Qo8;
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

	public b6E()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)b6R);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		a0Z();
	}

	[DebuggerNonUserCode]
	protected override void Bp4(bool i7F)
	{
		try
		{
			if (i7F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i7F);
		}
	}

	[DebuggerStepThrough]
	private void a0Z()
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

	private void i9M(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void Tt8(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Qo8(object sender, EventArgs e)
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
		Sc1();
	}

	public void Sc1()
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

	internal static bool k2N(int f9Q)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(f9Q + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				f9Q = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				f9Q = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				f9Q = -1;
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

	private void b6R(object sender, EventArgs e)
	{
		Sc1();
	}

	private void Rf7(object sender, EventArgs e)
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
		Sc1();
	}

	private void s5P(object sender, EventArgs e)
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
		Sc1();
	}

	internal static byte[] Jq4(int Sc8, int Rj5)
	{
		if (Sc8 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Rj5 + 1];
			for (int i = 0; i <= Rj5; i++)
			{
				int num = Sc8 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Jy1.p4A(array, Rj5);
		}
	}

	static void Bp6()
	{
		_ = (j3J)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
		try
		{
			Jy1 obj = (Jy1)(object)a7W.Default;
			jy = jy;
			jy = obj;
			y8R = y8R;
			y8R = y8R;
		}
		catch
		{
			do
			{
				_ = (Jy1)(object)a7W.Default;
			}
			while ((object)a7W.Default != null);
		}
		do
		{
			_ = (b1YL)(object)a7W.Default;
		}
		while ((object)a7W.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Sm6)(object)a7W.Default;
				a1B = a1B;
				a1B = a1B;
				i0A1 i0A = i0A;
				i0A = i0A;
			}
			finally
			{
				_ = (y8R)(object)a7W.Default;
				goto IL_0106;
			}
		}
		try
		{
			try
			{
				_ = (a1B)(object)a7W.Default;
				Nn9a nn9a = nn9a;
				nn9a = nn9a;
				_ = (Sm6)(object)a7W.Default;
				_ = a7W.Default;
			}
			finally
			{
				_ = (b1YL)(object)a7W.Default;
				goto end_IL_00ab;
			}
			end_IL_00ab:;
		}
		finally
		{
			Em1 em = (Em1)(object)a7W.Default;
			em = em;
			goto IL_0106;
		}
		IL_0106:
		object obj3;
		do
		{
			_ = (j3J)(object)a7W.Default;
			obj3 = a7W.Default;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		do
		{
			ta = ta;
			ta = null;
		}
		while (obj3 != null);
		do
		{
			_ = (Zo8)(object)a7W.Default;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		while ((object)a7W.Default != null)
		{
			while (obj3 != null)
			{
				do
				{
					sm = sm;
					sm = sm;
				}
				while (obj3 != null);
			}
		}
		UIntPtr num = (UIntPtr)a7W.Default;
		nuint num2 = default(UIntPtr);
		checked
		{
			num2 = unchecked((nuint)num) + unchecked(checked(num2 - num2) / num2);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		if (num2 == 0)
		{
			try
			{
				qg = qg;
				qg = qg;
				ta = ta;
				_ = (j3J)(object)a7W.Default;
				_ = (j3J)(object)a7W.Default;
				_ = (Sm6)(object)a7W.Default;
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (Em1)(object)a7W.Default;
				}
			}
		}
		else if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				Ln53 obj5 = (Ln53)(object)a7W.Default;
				ln = null;
				ln = obj5;
			}
			catch
			{
				_ = (Ln53)(object)a7W.Default;
			}
		}
		try
		{
			do
			{
				_ = (Sm6)(object)a7W.Default;
			}
			while (obj3 != null);
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Zo8)(object)a7W.Default;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Jy1)(object)a7W.Default;
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (s9EJ)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			_ = (Ta6)(object)a7W.Default;
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					jy = jy;
				}
			}
			catch
			{
				while ((object)a7W.Default != null)
				{
					_ = (En1)(object)a7W.Default;
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					ln = (Ln53)(object)a7W.Default;
				}
			}
			goto IL_02ec;
		}
		IL_06e8:
		_ = (En1)(object)a7W.Default;
		_ = (Qg6)(object)a7W.Default;
		_ = (i0A1)(object)a7W.Default;
		_ = (i0A1)(object)a7W.Default;
		return;
		IL_02ec:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		do
		{
			try
			{
				jy = (Jy1)(object)a7W.Default;
				b1YL = b1YL;
				b1YL = b1YL;
			}
			finally
			{
				_ = (_003CModule_003E)(object)a7W.Default;
				continue;
			}
		}
		while (obj3 != null || (object)a7W.Default != null);
		a1B = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		try
		{
			while (obj3 != null)
			{
				s9EJ = (s9EJ)(object)a7W.Default;
			}
		}
		finally
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					_ = (Sm6)(object)a7W.Default;
				}
			}
			goto IL_0368;
		}
		IL_0368:
		_ = (b6E)(object)a7W.Default;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					_ = (Em1)(object)a7W.Default;
				}
			}
			else
			{
				while (obj3 != null)
				{
					_ = (Ln53)(object)a7W.Default;
				}
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					while (obj3 != null)
					{
						Em1 em = null;
					}
				}
			}
		}
		do
		{
			num2 = default(UIntPtr);
			if (num2 != (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Nn9a)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
					_ = (b6E)(object)a7W.Default;
					_ = (i0A1)(object)a7W.Default;
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				while (obj3 != null);
			}
			else
			{
				try
				{
					_ = (Sm6)(object)a7W.Default;
				}
				catch
				{
					_ = (a1B)(object)a7W.Default;
				}
			}
		}
		while (obj3 != null);
		checked
		{
			while (true)
			{
				if (obj3 != null)
				{
					if (unchecked((nuint)(UIntPtr)a7W.Default) * (unchecked((nuint)(UIntPtr)a7W.Default) - (unchecked((nuint)(UIntPtr)a7W.Default) + unchecked((nuint)(UIntPtr)a7W.Default))) == 0)
					{
						sm = (Sm6)(object)a7W.Default;
					}
				}
				else if (obj3 == null)
				{
					break;
				}
			}
			_ = (Sm6)(object)a7W.Default;
			if (num2 == unchecked((UIntPtr)(nuint)0u))
			{
				try
				{
					do
					{
						Zo8 zo = null;
						zo = zo;
					}
					while (obj3 != null);
				}
				catch
				{
					try
					{
						_ = (Zo8)(object)a7W.Default;
					}
					finally
					{
						_ = (i0A1)(object)a7W.Default;
						goto end_IL_04cf;
					}
					end_IL_04cf:;
				}
			}
			else
			{
				qg = (Qg6)(object)a7W.Default;
				jy = jy;
				sm = sm;
			}
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				ln = ln;
			}
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (En1)(object)a7W.Default;
			}
			try
			{
				do
				{
					num2 = default(UIntPtr);
					nuint num3 = num2 + unchecked((nuint)(UIntPtr)a7W.Default);
					num2 = default(UIntPtr);
					if (num3 + num2 != 0)
					{
						y8R = y8R;
						_ = (y8R)(object)a7W.Default;
						Zo8 zo = null;
						qg = null;
					}
					else
					{
						sm = null;
					}
				}
				while ((object)a7W.Default != null);
			}
			catch
			{
				a1B = null;
				qg = (Qg6)(object)a7W.Default;
				_ = a7W.Default;
				s9EJ = (s9EJ)(object)a7W.Default;
			}
			try
			{
				do
				{
					y8R = null;
				}
				while (obj3 != null || obj3 != null);
			}
			catch
			{
				ta = ta;
			}
			_ = (Nm2f)(object)a7W.Default;
			s9EJ = s9EJ;
		}
		while (obj3 != null)
		{
			do
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y8R)(object)a7W.Default;
				}
			}
			while (obj3 != null);
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (y8R)(object)a7W.Default;
		}
		else
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				do
				{
					_ = (s9EJ)(object)a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
					_ = (Nm2f)(object)a7W.Default;
					_003CModule_003E = _003CModule_003E;
					_ = (s9EJ)(object)a7W.Default;
				}
				while (obj3 != null);
			}
			else
			{
				try
				{
					jy = (Jy1)(object)a7W.Default;
					qg = qg;
				}
				catch
				{
					_ = (Zo8)(object)a7W.Default;
				}
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (b1YL)(object)a7W.Default;
			}
			finally
			{
				_ = (Em1)(object)a7W.Default;
				goto IL_06e8;
			}
		}
		if (num2 == 0)
		{
		}
		goto IL_06e8;
	}
}
