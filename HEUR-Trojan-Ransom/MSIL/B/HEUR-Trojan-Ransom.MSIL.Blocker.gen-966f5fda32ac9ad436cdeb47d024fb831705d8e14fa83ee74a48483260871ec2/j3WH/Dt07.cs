using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bb9w;
using Cb4;
using Microsoft.VisualBasic.CompilerServices;
using Pp27;
using Rx8m;
using e8T6;
using r9JD;

namespace j3WH;

[DesignerGenerated]
public class Dt07 : Form
{
	private DataGridView _dgvLoad;

	private GroupBox _GroupBox1;

	private ComboBox _cbSP;

	private Label _Label1;

	private ComboBox _cbSearch;

	private TextBox _txtSearch;

	private ContextMenuStrip _ContextMenuStrip1;

	private CheckBox _cbCTHD;

	private Button _btnEditKH;

	internal f1T9 E;

	internal bool I;

	internal IContainer v;

	internal Button m;

	internal Button X;

	internal Button h;

	internal CheckBox l;

	internal CheckBox U;

	internal Button b;

	internal Button C;

	public Dt07()
	{
		((Form)this).add_Load((EventHandler)g4AB);
		f1T9 f1T = (E = new f1T9());
		I = false;
		Tn6t();
	}

	private void k3DY()
	{
		string e5EB = "SELECT MaLSP,TenLSP FROM dbo.LoaiSP";
		DataTable dataSource = E.m2W6(e5EB);
		Cp1c().set_DataSource((object)dataSource);
		((ListControl)Cp1c()).set_ValueMember("MaLSP");
		((ListControl)Cp1c()).set_DisplayMember("TenLSP");
	}

	private void Co4n(string Ez4w)
	{
		string e5EB = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{Ez4w}'";
		DataTable dataSource = E.m2W6(e5EB);
		j8HE().set_DataSource((object)dataSource);
		DataGridView val = j8HE();
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void g4AB(object sender, EventArgs e)
	{
		I = true;
		k3DY();
		Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		I = false;
	}

	private void Yj47(object sender, EventArgs e)
	{
		if (!I)
		{
			Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		}
	}

	private void p5YR(string Lz73, string Np16)
	{
		string text = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{Lz73}'";
		if (Cm6g().get_SelectedIndex() == 0)
		{
			text += $" AND MaSP LIKE '{Np16}%'";
		}
		else if (Cm6g().get_SelectedIndex() == 1)
		{
			text += $" AND TenSP LIKE '{Np16}%'";
		}
		DataTable dataSource = E.m2W6(text);
		j8HE().set_DataSource((object)dataSource);
		DataGridView val = j8HE();
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void a0W2(object sender, EventArgs e)
	{
		p5YR(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()), p9FN().get_Text());
	}

	private void Yg57(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		Zb4q zb4q = new Zb4q();
		((Form)zb4q).ShowDialog();
		if ((int)((Form)zb4q).get_DialogResult() == 1)
		{
			Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		}
	}

	private void d0D7(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		Nt0w nt0w = new Nt0w();
		nt0w.Wc0a().set_Text(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		((Form)nt0w).ShowDialog();
		if ((int)((Form)nt0w).get_DialogResult() == 1)
		{
			Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		}
	}

	private void k0C4(object sender, EventArgs e)
	{
		string e5EB = "SELECT MaKH,TenKH,Diachi,SoDT FROM dbo.KhachHang";
		DataTable dataSource = E.m2W6(e5EB);
		j8HE().set_DataSource((object)dataSource);
		DataGridView val = j8HE();
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ten KH");
		val.get_Columns().get_Item(0).set_HeaderText("Dia Chi");
		val.get_Columns().get_Item(0).set_HeaderText("So DT");
		val = null;
	}

	private void Pw93(object sender, EventArgs e)
	{
		string e5EB = "SELECT MaHD,MaKH,Ngaylap FROM dbo.HoaDon";
		DataTable dataSource = E.m2W6(e5EB);
		j8HE().set_DataSource((object)dataSource);
		DataGridView val = j8HE();
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ngay Lap");
		val = null;
	}

	private void Xz5w(object sender, EventArgs e)
	{
		string e5EB = "SELECT MaSP,MaHD,SoLuong,DonGia FROM dbo.ChiTietHoaDon";
		DataTable dataSource = E.m2W6(e5EB);
		j8HE().set_DataSource((object)dataSource);
		DataGridView val = j8HE();
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val.get_Columns().get_Item(0).set_HeaderText("Don Gia");
		val = null;
	}

	internal static string[] Ny80()
	{
		List<string> list = new List<string>();
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(Lp07.mDic["Ass"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				list.Add(Conversions.ToString(objectValue));
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void Wn8k(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		j1C j1C = new j1C();
		((Form)j1C).ShowDialog();
		if ((int)((Form)j1C).get_DialogResult() == 1)
		{
			Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		}
	}

	private void Lz60(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		a0M7 a0M = new a0M7();
		((Form)a0M).ShowDialog();
		if ((int)((Form)a0M).get_DialogResult() == 1)
		{
			Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		}
	}

	internal static bool Jy5e()
	{
		try
		{
			try
			{
				Type type = Nt0w.k3CT((Assembly)Lp07.mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, Lp07.mDic[Lp07.tName], false))
				{
					Lp07.mDic.Add(Lp07.T, type);
					return true;
				}
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

	private void t1L8(object sender, EventArgs e)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		Lp07 lp = new Lp07();
		DataGridView val = j8HE();
		lp.Nc62().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("MaKH")
			.get_Value()));
		lp.r9W0().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("TenKH")
			.get_Value()));
		lp.Kb5n().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("Diachi")
			.get_Value()));
		lp.n1B0().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("SoDT")
			.get_Value()));
		val = null;
		((Form)lp).ShowDialog();
		if ((int)((Form)lp).get_DialogResult() == 1)
		{
			Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
		}
	}

	public static byte Az5y(byte o1NM, byte[] Nk08, int m5XA, int Ab7o)
	{
		o1NM = (byte)(o1NM ^ checked((byte)(Nk08[unchecked(Ab7o % Nk08.Length)] ^ ((Ab7o + unchecked(m5XA % Nk08.Length)) & m5XA))));
		return o1NM;
	}

	private void m5E0(object sender, EventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		if (Sw9g().get_Checked())
		{
			string arg = Conversions.ToString(j8HE().get_Rows().get_Item(j8HE().get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaKH")
				.get_Value());
			string e0M = $"DELETE KhachHang WHERE MaKH = '{arg}'";
			if (E.Li4f(e0M))
			{
				MessageBox.Show("Xoa thanh cong");
				Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
		if (n7BK().get_Checked())
		{
			string arg2 = Conversions.ToString(j8HE().get_Rows().get_Item(j8HE().get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaHD")
				.get_Value());
			string e0M2 = $"DELETE HoaDon WHERE MaHD = '{arg2}'";
			if (E.Li4f(e0M2))
			{
				MessageBox.Show("Xoa thanh cong");
				Co4n(Conversions.ToString(((ListControl)Cp1c()).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
	}

	protected override void Ay8d(bool Mo9d)
	{
		try
		{
			if (Mo9d && v != null)
			{
				v.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mo9d);
		}
	}

	private void Tn6t()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		IContainer container = (v = new Container());
		Yy70(new DataGridView());
		Jk04(new Button());
		e1Q4(new Button());
		Jp8i(new GroupBox());
		Zq65(new ComboBox());
		d8P2(new Label());
		y7E0(new ComboBox());
		e3ET(new TextBox());
		b9LT(new ContextMenuStrip(v));
		Gm7p(new Button());
		Sk59(new CheckBox());
		Rk45(new CheckBox());
		Nn06(new CheckBox());
		At64(new Button());
		b1P0(new Button());
		Tm26(new Button());
		((ISupportInitialize)j8HE()).BeginInit();
		((Control)m3PJ()).SuspendLayout();
		((Control)this).SuspendLayout();
		j8HE().set_AllowUserToAddRows(false);
		j8HE().set_AllowUserToDeleteRows(false);
		j8HE().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)j8HE()).set_Location(new Point(12, 71));
		j8HE().set_MultiSelect(false);
		((Control)j8HE()).set_Name("dgvLoad");
		j8HE().set_ReadOnly(true);
		j8HE().set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)j8HE()).set_Size(new Size(508, 308));
		((Control)j8HE()).set_TabIndex(0);
		((Control)z2XP()).set_Location(new Point(538, 97));
		((Control)z2XP()).set_Name("btnsanpham");
		((Control)z2XP()).set_Size(new Size(100, 23));
		((Control)z2XP()).set_TabIndex(1);
		((ButtonBase)z2XP()).set_Text("Them San Pham");
		((ButtonBase)z2XP()).set_UseVisualStyleBackColor(true);
		((Control)x1BT()).set_Location(new Point(538, 39));
		((Control)x1BT()).set_Name("btnkhachhang");
		((Control)x1BT()).set_Size(new Size(100, 23));
		((Control)x1BT()).set_TabIndex(2);
		((ButtonBase)x1BT()).set_Text("Them KH");
		((ButtonBase)x1BT()).set_UseVisualStyleBackColor(true);
		((Control)m3PJ()).get_Controls().Add((Control)(object)Cp1c());
		((Control)m3PJ()).set_Location(new Point(526, 279));
		((Control)m3PJ()).set_Name("GroupBox1");
		((Control)m3PJ()).set_Size(new Size(137, 100));
		((Control)m3PJ()).set_TabIndex(3);
		m3PJ().set_TabStop(false);
		m3PJ().set_Text("Loai San Pham");
		((ListControl)Cp1c()).set_FormattingEnabled(true);
		((Control)Cp1c()).set_Location(new Point(6, 38));
		((Control)Cp1c()).set_Name("cbSP");
		((Control)Cp1c()).set_Size(new Size(121, 21));
		((Control)Cp1c()).set_TabIndex(0);
		q0YL().set_AutoSize(true);
		((Control)q0YL()).set_Location(new Point(13, 39));
		((Control)q0YL()).set_Name("Label1");
		((Control)q0YL()).set_Size(new Size(49, 13));
		((Control)q0YL()).set_TabIndex(4);
		q0YL().set_Text("Tìm kiếm");
		((ListControl)Cm6g()).set_FormattingEnabled(true);
		Cm6g().get_Items().AddRange(new object[2] { "MaSP", "TenSP" });
		((Control)Cm6g()).set_Location(new Point(68, 36));
		((Control)Cm6g()).set_Name("cbSearch");
		((Control)Cm6g()).set_Size(new Size(109, 21));
		((Control)Cm6g()).set_TabIndex(5);
		((Control)p9FN()).set_Location(new Point(184, 36));
		((Control)p9FN()).set_Name("txtSearch");
		((Control)p9FN()).set_Size(new Size(336, 20));
		((Control)p9FN()).set_TabIndex(6);
		((Control)Yt9e()).set_Name("ContextMenuStrip1");
		((Control)Yt9e()).set_Size(new Size(61, 4));
		((Control)Qk3r()).set_Location(new Point(538, 68));
		((Control)Qk3r()).set_Name("btnAddHD");
		((Control)Qk3r()).set_Size(new Size(100, 23));
		((Control)Qk3r()).set_TabIndex(10);
		((ButtonBase)Qk3r()).set_Text("Them Hoa Don");
		((ButtonBase)Qk3r()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Sw9g()).set_AutoSize(true);
		((Control)Sw9g()).set_Location(new Point(538, 198));
		((Control)Sw9g()).set_Name("cbKH");
		((Control)Sw9g()).set_Size(new Size(86, 17));
		((Control)Sw9g()).set_TabIndex(12);
		((ButtonBase)Sw9g()).set_Text("Khach Hang");
		((ButtonBase)Sw9g()).set_UseVisualStyleBackColor(true);
		((ButtonBase)n7BK()).set_AutoSize(true);
		((Control)n7BK()).set_Location(new Point(538, 221));
		((Control)n7BK()).set_Name("cbHD");
		((Control)n7BK()).set_Size(new Size(69, 17));
		((Control)n7BK()).set_TabIndex(13);
		((ButtonBase)n7BK()).set_Text("Hoa Don");
		((ButtonBase)n7BK()).set_UseVisualStyleBackColor(true);
		((ButtonBase)i4JD()).set_AutoSize(true);
		((Control)i4JD()).set_Location(new Point(538, 245));
		((Control)i4JD()).set_Name("cbCTHD");
		((Control)i4JD()).set_Size(new Size(108, 17));
		((Control)i4JD()).set_TabIndex(14);
		((ButtonBase)i4JD()).set_Text("Chi Tiet Hoa Don");
		((ButtonBase)i4JD()).set_UseVisualStyleBackColor(true);
		((Control)Qa7w()).set_Location(new Point(538, 126));
		((Control)Qa7w()).set_Name("btnAddLSP");
		((Control)Qa7w()).set_Size(new Size(100, 23));
		((Control)Qa7w()).set_TabIndex(15);
		((ButtonBase)Qa7w()).set_Text("Them Loai SP");
		((ButtonBase)Qa7w()).set_UseVisualStyleBackColor(true);
		((Control)s1H2()).set_Location(new Point(12, 394));
		((Control)s1H2()).set_Name("btnEditKH");
		((Control)s1H2()).set_Size(new Size(75, 23));
		((Control)s1H2()).set_TabIndex(16);
		((ButtonBase)s1H2()).set_Text("Sua KH");
		((ButtonBase)s1H2()).set_UseVisualStyleBackColor(true);
		((Control)Wr05()).set_Location(new Point(102, 394));
		((Control)Wr05()).set_Name("btnXoa");
		((Control)Wr05()).set_Size(new Size(75, 23));
		((Control)Wr05()).set_TabIndex(17);
		((ButtonBase)Wr05()).set_Text("Xoa");
		((ButtonBase)Wr05()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(675, 440));
		((Control)this).get_Controls().Add((Control)(object)Wr05());
		((Control)this).get_Controls().Add((Control)(object)s1H2());
		((Control)this).get_Controls().Add((Control)(object)Qa7w());
		((Control)this).get_Controls().Add((Control)(object)i4JD());
		((Control)this).get_Controls().Add((Control)(object)n7BK());
		((Control)this).get_Controls().Add((Control)(object)Sw9g());
		((Control)this).get_Controls().Add((Control)(object)Qk3r());
		((Control)this).get_Controls().Add((Control)(object)p9FN());
		((Control)this).get_Controls().Add((Control)(object)Cm6g());
		((Control)this).get_Controls().Add((Control)(object)q0YL());
		((Control)this).get_Controls().Add((Control)(object)m3PJ());
		((Control)this).get_Controls().Add((Control)(object)x1BT());
		((Control)this).get_Controls().Add((Control)(object)z2XP());
		((Control)this).get_Controls().Add((Control)(object)j8HE());
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)j8HE()).EndInit();
		((Control)m3PJ()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView j8HE()
	{
		return _dgvLoad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yy70(DataGridView z2ZR)
	{
		_dgvLoad = z2ZR;
	}

	[SpecialName]
	internal virtual Button z2XP()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk04(Button Jo08)
	{
		EventHandler eventHandler = d0D7;
		Button val = m;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (m = Jo08);
		val = m;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x1BT()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1Q4(Button Fz4q)
	{
		EventHandler eventHandler = Yg57;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = Fz4q);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox m3PJ()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp8i(GroupBox p0PR)
	{
		_GroupBox1 = p0PR;
	}

	[SpecialName]
	internal virtual ComboBox Cp1c()
	{
		return _cbSP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zq65(ComboBox Ht7c)
	{
		EventHandler eventHandler = Yj47;
		ComboBox cbSP = _cbSP;
		if (cbSP != null)
		{
			cbSP.remove_SelectedIndexChanged(eventHandler);
		}
		_cbSP = Ht7c;
		cbSP = _cbSP;
		if (cbSP != null)
		{
			cbSP.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label q0YL()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8P2(Label Rf1t)
	{
		_Label1 = Rf1t;
	}

	[SpecialName]
	internal virtual ComboBox Cm6g()
	{
		return _cbSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7E0(ComboBox Gb61)
	{
		_cbSearch = Gb61;
	}

	[SpecialName]
	internal virtual TextBox p9FN()
	{
		return _txtSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3ET(TextBox x6RH)
	{
		EventHandler eventHandler = a0W2;
		TextBox txtSearch = _txtSearch;
		if (txtSearch != null)
		{
			((Control)txtSearch).remove_TextChanged(eventHandler);
		}
		_txtSearch = x6RH;
		txtSearch = _txtSearch;
		if (txtSearch != null)
		{
			((Control)txtSearch).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ContextMenuStrip Yt9e()
	{
		return _ContextMenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9LT(ContextMenuStrip a3QL)
	{
		_ContextMenuStrip1 = a3QL;
	}

	[SpecialName]
	internal virtual Button Qk3r()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gm7p(Button b9BR)
	{
		EventHandler eventHandler = Wn8k;
		Button val = h;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (h = b9BR);
		val = h;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox Sw9g()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk59(CheckBox Ns35)
	{
		EventHandler eventHandler = k0C4;
		CheckBox val = l;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		CheckBox val2 = (l = Ns35);
		val = l;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox n7BK()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rk45(CheckBox c5CP)
	{
		EventHandler eventHandler = Pw93;
		CheckBox u = U;
		if (u != null)
		{
			u.remove_CheckedChanged(eventHandler);
		}
		CheckBox val = (U = c5CP);
		u = U;
		if (u != null)
		{
			u.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox i4JD()
	{
		return _cbCTHD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn06(CheckBox Rs76)
	{
		EventHandler eventHandler = Xz5w;
		CheckBox cbCTHD = _cbCTHD;
		if (cbCTHD != null)
		{
			cbCTHD.remove_CheckedChanged(eventHandler);
		}
		_cbCTHD = Rs76;
		cbCTHD = _cbCTHD;
		if (cbCTHD != null)
		{
			cbCTHD.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Qa7w()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At64(Button To9d)
	{
		EventHandler eventHandler = Lz60;
		Button val = b;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (b = To9d);
		val = b;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button s1H2()
	{
		return _btnEditKH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1P0(Button To7y)
	{
		EventHandler eventHandler = t1L8;
		Button btnEditKH = _btnEditKH;
		if (btnEditKH != null)
		{
			((Control)btnEditKH).remove_Click(eventHandler);
		}
		_btnEditKH = To7y;
		btnEditKH = _btnEditKH;
		if (btnEditKH != null)
		{
			((Control)btnEditKH).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Wr05()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tm26(Button Wa2x)
	{
		EventHandler eventHandler = m5E0;
		Button c = C;
		if (c != null)
		{
			((Control)c).remove_Click(eventHandler);
		}
		Button val = (C = Wa2x);
		c = C;
		if (c != null)
		{
			((Control)c).add_Click(eventHandler);
		}
	}
}
