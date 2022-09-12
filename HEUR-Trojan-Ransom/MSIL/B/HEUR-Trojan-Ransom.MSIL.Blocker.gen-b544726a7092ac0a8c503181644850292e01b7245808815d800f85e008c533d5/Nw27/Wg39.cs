using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using As6;
using Js9;
using Microsoft.VisualBasic.CompilerServices;
using Nk7;
using Qd4;
using Ws9;
using y8P;

namespace Nw27;

[DesignerGenerated]
public class Wg39 : Form
{
	private Ca2 dataaccess;

	private bool isloading;

	private IContainer components;

	private Label _Label1;

	private ContextMenuStrip _ContextMenuStrip1;

	private Button _btnAddHD;

	internal DataGridView y;

	internal Button b;

	internal Button s;

	internal GroupBox m;

	internal ComboBox r;

	internal ComboBox q;

	internal TextBox H;

	internal CheckBox F;

	internal CheckBox d;

	internal CheckBox P;

	internal Button G;

	internal Button l;

	internal Button I;

	public Wg39()
	{
		((Form)this).add_Load((EventHandler)k2FJ);
		dataaccess = new Ca2();
		isloading = false;
		x8Y6();
	}

	private void Pm3z()
	{
		string k0G = "SELECT MaLSP,TenLSP FROM dbo.LoaiSP";
		DataTable dataSource = dataaccess.o5S(k0G);
		z1N2().set_DataSource((object)dataSource);
		((ListControl)z1N2()).set_ValueMember("MaLSP");
		((ListControl)z1N2()).set_DisplayMember("TenLSP");
	}

	private void w7KJ(string e7LE)
	{
		string k0G = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{e7LE}'";
		DataTable dataSource = dataaccess.o5S(k0G);
		x8D5().set_DataSource((object)dataSource);
		DataGridView val = x8D5();
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void k2FJ(object sender, EventArgs e)
	{
		isloading = true;
		Pm3z();
		w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		isloading = false;
	}

	private void a5YR(object sender, EventArgs e)
	{
		if (!isloading)
		{
			w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		}
	}

	private void x9Z1(string r9A4, string r2YZ)
	{
		string text = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{r9A4}'";
		if (Gc4s().get_SelectedIndex() == 0)
		{
			text += $" AND MaSP LIKE '{r2YZ}%'";
		}
		else if (Gc4s().get_SelectedIndex() == 1)
		{
			text += $" AND TenSP LIKE '{r2YZ}%'";
		}
		DataTable dataSource = dataaccess.o5S(text);
		x8D5().set_DataSource((object)dataSource);
		DataGridView val = x8D5();
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void Ki54(object sender, EventArgs e)
	{
		x9Z1(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()), b0E6().get_Text());
	}

	private void o9D0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		k8W k8W = new k8W();
		((Form)k8W).ShowDialog();
		if ((int)((Form)k8W).get_DialogResult() == 1)
		{
			w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		}
	}

	private void Jn35(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		j5H j5H = new j5H();
		j5H.t0A().set_Text(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		((Form)j5H).ShowDialog();
		if ((int)((Form)j5H).get_DialogResult() == 1)
		{
			w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		}
	}

	private void Xp89(object sender, EventArgs e)
	{
		string k0G = "SELECT MaKH,TenKH,Diachi,SoDT FROM dbo.KhachHang";
		DataTable dataSource = dataaccess.o5S(k0G);
		x8D5().set_DataSource((object)dataSource);
		DataGridView val = x8D5();
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ten KH");
		val.get_Columns().get_Item(0).set_HeaderText("Dia Chi");
		val.get_Columns().get_Item(0).set_HeaderText("So DT");
		val = null;
	}

	private void Rs34(object sender, EventArgs e)
	{
		string k0G = "SELECT MaHD,MaKH,Ngaylap FROM dbo.HoaDon";
		DataTable dataSource = dataaccess.o5S(k0G);
		x8D5().set_DataSource((object)dataSource);
		DataGridView val = x8D5();
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ngay Lap");
		val = null;
	}

	private void Wq25(object sender, EventArgs e)
	{
		string k0G = "SELECT MaSP,MaHD,SoLuong,DonGia FROM dbo.ChiTietHoaDon";
		DataTable dataSource = dataaccess.o5S(k0G);
		x8D5().set_DataSource((object)dataSource);
		DataGridView val = x8D5();
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val.get_Columns().get_Item(0).set_HeaderText("Don Gia");
		val = null;
	}

	internal static string[] Hy9g()
	{
		List<string> list = new List<string>();
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(k8A.mDic["Ass"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
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

	private void Ep1e(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		Yw7 yw = new Yw7();
		((Form)yw).ShowDialog();
		if ((int)((Form)yw).get_DialogResult() == 1)
		{
			w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		}
	}

	private void Bn01(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		c4K c4K = new c4K();
		((Form)c4K).ShowDialog();
		if ((int)((Form)c4K).get_DialogResult() == 1)
		{
			w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		}
	}

	internal static bool Fq6k()
	{
		try
		{
			try
			{
				Type type = j5H.t1N((Assembly)k8A.mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, k8A.mDic[k8A.tName], false))
				{
					k8A.mDic.Add(k8A.T, type);
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

	private void Sx5i(object sender, EventArgs e)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		k8A k8A = new k8A();
		DataGridView val = x8D5();
		k8A.m6N().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("MaKH")
			.get_Value()));
		k8A.Cc3().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("TenKH")
			.get_Value()));
		k8A.w9P().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("Diachi")
			.get_Value()));
		k8A.Dc3().set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("SoDT")
			.get_Value()));
		val = null;
		((Form)k8A).ShowDialog();
		if ((int)((Form)k8A).get_DialogResult() == 1)
		{
			w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
		}
	}

	public static byte i9NM(byte Km39, byte[] j1NL, int w1YZ, int a7A0)
	{
		Km39 = (byte)(Km39 ^ checked((byte)(j1NL[unchecked(a7A0 % j1NL.Length)] ^ ((a7A0 + unchecked(w1YZ % j1NL.Length)) & w1YZ))));
		return Km39;
	}

	private void a8RJ(object sender, EventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		if (Fj70().get_Checked())
		{
			string arg = Conversions.ToString(x8D5().get_Rows().get_Item(x8D5().get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaKH")
				.get_Value());
			string ha = $"DELETE KhachHang WHERE MaKH = '{arg}'";
			if (dataaccess.q6P(ha))
			{
				MessageBox.Show("Xoa thanh cong");
				w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
		if (m9X0().get_Checked())
		{
			string arg2 = Conversions.ToString(x8D5().get_Rows().get_Item(x8D5().get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaHD")
				.get_Value());
			string ha2 = $"DELETE HoaDon WHERE MaHD = '{arg2}'";
			if (dataaccess.q6P(ha2))
			{
				MessageBox.Show("Xoa thanh cong");
				w7KJ(Conversions.ToString(((ListControl)z1N2()).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
	}

	protected override void w8Q2(bool Nt12)
	{
		try
		{
			if (Nt12 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Nt12);
		}
	}

	private void x8Y6()
	{
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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		components = new Container();
		d0AH(new DataGridView());
		Qa3r(new Button());
		Qa7i(new Button());
		Ab93(new GroupBox());
		o0D2(new ComboBox());
		Xf7b(new Label());
		Lc6f(new ComboBox());
		t0KP(new TextBox());
		k5EG(new ContextMenuStrip(components));
		Xa0m(new Button());
		Ms3e(new CheckBox());
		Hq4r(new CheckBox());
		Ei12(new CheckBox());
		Yk95(new Button());
		e6JK(new Button());
		Dg17(new Button());
		((ISupportInitialize)x8D5()).BeginInit();
		((Control)f5N7()).SuspendLayout();
		((Control)this).SuspendLayout();
		x8D5().set_AllowUserToAddRows(false);
		x8D5().set_AllowUserToDeleteRows(false);
		x8D5().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)x8D5()).set_Location(new Point(12, 71));
		x8D5().set_MultiSelect(false);
		((Control)x8D5()).set_Name("dgvLoad");
		x8D5().set_ReadOnly(true);
		x8D5().set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)x8D5()).set_Size(new Size(508, 308));
		((Control)x8D5()).set_TabIndex(0);
		((Control)e5BG()).set_Location(new Point(538, 97));
		((Control)e5BG()).set_Name("btnsanpham");
		((Control)e5BG()).set_Size(new Size(100, 23));
		((Control)e5BG()).set_TabIndex(1);
		((ButtonBase)e5BG()).set_Text("Them San Pham");
		((ButtonBase)e5BG()).set_UseVisualStyleBackColor(true);
		((Control)Te16()).set_Location(new Point(538, 39));
		((Control)Te16()).set_Name("btnkhachhang");
		((Control)Te16()).set_Size(new Size(100, 23));
		((Control)Te16()).set_TabIndex(2);
		((ButtonBase)Te16()).set_Text("Them KH");
		((ButtonBase)Te16()).set_UseVisualStyleBackColor(true);
		((Control)f5N7()).get_Controls().Add((Control)(object)z1N2());
		((Control)f5N7()).set_Location(new Point(526, 279));
		((Control)f5N7()).set_Name("GroupBox1");
		((Control)f5N7()).set_Size(new Size(137, 100));
		((Control)f5N7()).set_TabIndex(3);
		f5N7().set_TabStop(false);
		f5N7().set_Text("Loai San Pham");
		((ListControl)z1N2()).set_FormattingEnabled(true);
		((Control)z1N2()).set_Location(new Point(6, 38));
		((Control)z1N2()).set_Name("cbSP");
		((Control)z1N2()).set_Size(new Size(121, 21));
		((Control)z1N2()).set_TabIndex(0);
		f4D2().set_AutoSize(true);
		((Control)f4D2()).set_Location(new Point(13, 39));
		((Control)f4D2()).set_Name("Label1");
		((Control)f4D2()).set_Size(new Size(49, 13));
		((Control)f4D2()).set_TabIndex(4);
		f4D2().set_Text("Tìm kiếm");
		((ListControl)Gc4s()).set_FormattingEnabled(true);
		Gc4s().get_Items().AddRange(new object[2] { "MaSP", "TenSP" });
		((Control)Gc4s()).set_Location(new Point(68, 36));
		((Control)Gc4s()).set_Name("cbSearch");
		((Control)Gc4s()).set_Size(new Size(109, 21));
		((Control)Gc4s()).set_TabIndex(5);
		((Control)b0E6()).set_Location(new Point(184, 36));
		((Control)b0E6()).set_Name("txtSearch");
		((Control)b0E6()).set_Size(new Size(336, 20));
		((Control)b0E6()).set_TabIndex(6);
		((Control)m8C3()).set_Name("ContextMenuStrip1");
		((Control)m8C3()).set_Size(new Size(61, 4));
		((Control)a1QD()).set_Location(new Point(538, 68));
		((Control)a1QD()).set_Name("btnAddHD");
		((Control)a1QD()).set_Size(new Size(100, 23));
		((Control)a1QD()).set_TabIndex(10);
		((ButtonBase)a1QD()).set_Text("Them Hoa Don");
		((ButtonBase)a1QD()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Fj70()).set_AutoSize(true);
		((Control)Fj70()).set_Location(new Point(538, 198));
		((Control)Fj70()).set_Name("cbKH");
		((Control)Fj70()).set_Size(new Size(86, 17));
		((Control)Fj70()).set_TabIndex(12);
		((ButtonBase)Fj70()).set_Text("Khach Hang");
		((ButtonBase)Fj70()).set_UseVisualStyleBackColor(true);
		((ButtonBase)m9X0()).set_AutoSize(true);
		((Control)m9X0()).set_Location(new Point(538, 221));
		((Control)m9X0()).set_Name("cbHD");
		((Control)m9X0()).set_Size(new Size(69, 17));
		((Control)m9X0()).set_TabIndex(13);
		((ButtonBase)m9X0()).set_Text("Hoa Don");
		((ButtonBase)m9X0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)g3ZK()).set_AutoSize(true);
		((Control)g3ZK()).set_Location(new Point(538, 245));
		((Control)g3ZK()).set_Name("cbCTHD");
		((Control)g3ZK()).set_Size(new Size(108, 17));
		((Control)g3ZK()).set_TabIndex(14);
		((ButtonBase)g3ZK()).set_Text("Chi Tiet Hoa Don");
		((ButtonBase)g3ZK()).set_UseVisualStyleBackColor(true);
		((Control)g5YC()).set_Location(new Point(538, 126));
		((Control)g5YC()).set_Name("btnAddLSP");
		((Control)g5YC()).set_Size(new Size(100, 23));
		((Control)g5YC()).set_TabIndex(15);
		((ButtonBase)g5YC()).set_Text("Them Loai SP");
		((ButtonBase)g5YC()).set_UseVisualStyleBackColor(true);
		((Control)g1B0()).set_Location(new Point(12, 394));
		((Control)g1B0()).set_Name("btnEditKH");
		((Control)g1B0()).set_Size(new Size(75, 23));
		((Control)g1B0()).set_TabIndex(16);
		((ButtonBase)g1B0()).set_Text("Sua KH");
		((ButtonBase)g1B0()).set_UseVisualStyleBackColor(true);
		((Control)j6B2()).set_Location(new Point(102, 394));
		((Control)j6B2()).set_Name("btnXoa");
		((Control)j6B2()).set_Size(new Size(75, 23));
		((Control)j6B2()).set_TabIndex(17);
		((ButtonBase)j6B2()).set_Text("Xoa");
		((ButtonBase)j6B2()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(675, 440));
		((Control)this).get_Controls().Add((Control)(object)j6B2());
		((Control)this).get_Controls().Add((Control)(object)g1B0());
		((Control)this).get_Controls().Add((Control)(object)g5YC());
		((Control)this).get_Controls().Add((Control)(object)g3ZK());
		((Control)this).get_Controls().Add((Control)(object)m9X0());
		((Control)this).get_Controls().Add((Control)(object)Fj70());
		((Control)this).get_Controls().Add((Control)(object)a1QD());
		((Control)this).get_Controls().Add((Control)(object)b0E6());
		((Control)this).get_Controls().Add((Control)(object)Gc4s());
		((Control)this).get_Controls().Add((Control)(object)f4D2());
		((Control)this).get_Controls().Add((Control)(object)f5N7());
		((Control)this).get_Controls().Add((Control)(object)Te16());
		((Control)this).get_Controls().Add((Control)(object)e5BG());
		((Control)this).get_Controls().Add((Control)(object)x8D5());
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)x8D5()).EndInit();
		((Control)f5N7()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView x8D5()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0AH(DataGridView x1KB)
	{
		DataGridView val = (y = x1KB);
	}

	[SpecialName]
	internal virtual Button e5BG()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa3r(Button Gf43)
	{
		EventHandler eventHandler = Jn35;
		Button val = b;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (b = Gf43);
		val = b;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Te16()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa7i(Button a2PN)
	{
		EventHandler eventHandler = o9D0;
		Button val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (s = a2PN);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox f5N7()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ab93(GroupBox s4XZ)
	{
		GroupBox val = (m = s4XZ);
	}

	[SpecialName]
	internal virtual ComboBox z1N2()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0D2(ComboBox x5T8)
	{
		EventHandler eventHandler = a5YR;
		ComboBox val = r;
		if (val != null)
		{
			val.remove_SelectedIndexChanged(eventHandler);
		}
		ComboBox val2 = (r = x5T8);
		val = r;
		if (val != null)
		{
			val.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label f4D2()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf7b(Label Jf5n)
	{
		_Label1 = Jf5n;
	}

	[SpecialName]
	internal virtual ComboBox Gc4s()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc6f(ComboBox Js60)
	{
		ComboBox val = (q = Js60);
	}

	[SpecialName]
	internal virtual TextBox b0E6()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0KP(TextBox Kx03)
	{
		EventHandler eventHandler = Ki54;
		TextBox h = H;
		if (h != null)
		{
			((Control)h).remove_TextChanged(eventHandler);
		}
		TextBox val = (H = Kx03);
		h = H;
		if (h != null)
		{
			((Control)h).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ContextMenuStrip m8C3()
	{
		return _ContextMenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5EG(ContextMenuStrip Xt0y)
	{
		_ContextMenuStrip1 = Xt0y;
	}

	[SpecialName]
	internal virtual Button a1QD()
	{
		return _btnAddHD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xa0m(Button Gn52)
	{
		EventHandler eventHandler = Ep1e;
		Button btnAddHD = _btnAddHD;
		if (btnAddHD != null)
		{
			((Control)btnAddHD).remove_Click(eventHandler);
		}
		_btnAddHD = Gn52;
		btnAddHD = _btnAddHD;
		if (btnAddHD != null)
		{
			((Control)btnAddHD).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox Fj70()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms3e(CheckBox Ft06)
	{
		EventHandler eventHandler = Xp89;
		CheckBox f = F;
		if (f != null)
		{
			f.remove_CheckedChanged(eventHandler);
		}
		CheckBox val = (F = Ft06);
		f = F;
		if (f != null)
		{
			f.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox m9X0()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq4r(CheckBox Es71)
	{
		EventHandler eventHandler = Rs34;
		CheckBox val = d;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		CheckBox val2 = (d = Es71);
		val = d;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox g3ZK()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei12(CheckBox i8D3)
	{
		EventHandler eventHandler = Wq25;
		CheckBox p = P;
		if (p != null)
		{
			p.remove_CheckedChanged(eventHandler);
		}
		CheckBox val = (P = i8D3);
		p = P;
		if (p != null)
		{
			p.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button g5YC()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yk95(Button w2W6)
	{
		EventHandler eventHandler = Bn01;
		Button g = G;
		if (g != null)
		{
			((Control)g).remove_Click(eventHandler);
		}
		Button val = (G = w2W6);
		g = G;
		if (g != null)
		{
			((Control)g).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button g1B0()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6JK(Button Cs9f)
	{
		EventHandler eventHandler = Sx5i;
		Button val = l;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (l = Cs9f);
		val = l;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j6B2()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dg17(Button Xs71)
	{
		EventHandler eventHandler = a8RJ;
		Button i = I;
		if (i != null)
		{
			((Control)i).remove_Click(eventHandler);
		}
		Button val = (I = Xs71);
		i = I;
		if (i != null)
		{
			((Control)i).add_Click(eventHandler);
		}
	}
}
