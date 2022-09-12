using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lw62;
using Microsoft.VisualBasic.CompilerServices;
using Py9j;
using m3AQ;
using n9D6;
using x1JM;
using z7B0;

namespace Nb0p;

[DesignerGenerated]
public class g6DW : Form
{
	private x5BN dataaccess;

	private bool isloading;

	private IContainer components;

	[field: AccessedThroughProperty("dgvLoad")]
	internal virtual DataGridView dgvLoad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnsanpham
	{
		[CompilerGenerated]
		get
		{
			return _btnsanpham;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r6S0;
			Button val = _btnsanpham;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnsanpham = value;
			val = _btnsanpham;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnkhachhang
	{
		[CompilerGenerated]
		get
		{
			return _btnkhachhang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n3AG;
			Button val = _btnkhachhang;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnkhachhang = value;
			val = _btnkhachhang;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbSP
	{
		[CompilerGenerated]
		get
		{
			return _cbSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d2SQ;
			ComboBox val = _cbSP;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_cbSP = value;
			val = _cbSP;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbSearch")]
	internal virtual ComboBox cbSearch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtSearch
	{
		[CompilerGenerated]
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ap5m;
			TextBox val = _txtSearch;
			if (val != null)
			{
				((Control)val).remove_TextChanged(eventHandler);
			}
			_txtSearch = value;
			val = _txtSearch;
			if (val != null)
			{
				((Control)val).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAddHD
	{
		[CompilerGenerated]
		get
		{
			return _btnAddHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k5Q7;
			Button val = _btnAddHD;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAddHD = value;
			val = _btnAddHD;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBox cbKH
	{
		[CompilerGenerated]
		get
		{
			return _cbKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Pg7o;
			CheckBox val = _cbKH;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_cbKH = value;
			val = _cbKH;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox cbHD
	{
		[CompilerGenerated]
		get
		{
			return _cbHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Hf21;
			CheckBox val = _cbHD;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_cbHD = value;
			val = _cbHD;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox cbCTHD
	{
		[CompilerGenerated]
		get
		{
			return _cbCTHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ta23;
			CheckBox val = _cbCTHD;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_cbCTHD = value;
			val = _cbCTHD;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button btnAddLSP
	{
		[CompilerGenerated]
		get
		{
			return _btnAddLSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Hg79;
			Button val = _btnAddLSP;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAddLSP = value;
			val = _btnAddLSP;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnEditKH
	{
		[CompilerGenerated]
		get
		{
			return _btnEditKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ry3o;
			Button val = _btnEditKH;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnEditKH = value;
			val = _btnEditKH;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnXoa
	{
		[CompilerGenerated]
		get
		{
			return _btnXoa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lx98;
			Button val = _btnXoa;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnXoa = value;
			val = _btnXoa;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public g6DW()
	{
		((Form)this).add_Load((EventHandler)Eo9z);
		dataaccess = new x5BN();
		isloading = false;
		Td78();
	}

	private void e8AY()
	{
		string zo = "SELECT MaLSP,TenLSP FROM dbo.LoaiSP";
		DataTable dataSource = dataaccess.y2X5(zo);
		cbSP.set_DataSource((object)dataSource);
		((ListControl)cbSP).set_ValueMember("MaLSP");
		((ListControl)cbSP).set_DisplayMember("TenLSP");
	}

	private void o1QX(string m6NT)
	{
		string zo = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{m6NT}'";
		DataTable dataSource = dataaccess.y2X5(zo);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void Eo9z(object sender, EventArgs e)
	{
		isloading = true;
		e8AY();
		o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		isloading = false;
	}

	private void d2SQ(object sender, EventArgs e)
	{
		if (!isloading)
		{
			o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void q2TQ(string Gq3p, string Ck9i)
	{
		string text = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{Gq3p}'";
		if (cbSearch.get_SelectedIndex() == 0)
		{
			text += $" AND MaSP LIKE '{Ck9i}%'";
		}
		else if (cbSearch.get_SelectedIndex() == 1)
		{
			text += $" AND TenSP LIKE '{Ck9i}%'";
		}
		DataTable dataSource = dataaccess.y2X5(text);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void Ap5m(object sender, EventArgs e)
	{
		q2TQ(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()), txtSearch.get_Text());
	}

	private void n3AG(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		x0X2 x0X = new x0X2();
		((Form)x0X).ShowDialog();
		if ((int)((Form)x0X).get_DialogResult() == 1)
		{
			o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void r6S0(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		i7M0 i7M = new i7M0();
		i7M.txtLoaisp.set_Text(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		((Form)i7M).ShowDialog();
		if ((int)((Form)i7M).get_DialogResult() == 1)
		{
			o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void Pg7o(object sender, EventArgs e)
	{
		string zo = "SELECT MaKH,TenKH,Diachi,SoDT FROM dbo.KhachHang";
		DataTable dataSource = dataaccess.y2X5(zo);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ten KH");
		val.get_Columns().get_Item(0).set_HeaderText("Dia Chi");
		val.get_Columns().get_Item(0).set_HeaderText("So DT");
		val = null;
	}

	private void Hf21(object sender, EventArgs e)
	{
		string zo = "SELECT MaHD,MaKH,Ngaylap FROM dbo.HoaDon";
		DataTable dataSource = dataaccess.y2X5(zo);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ngay Lap");
		val = null;
	}

	private void Ta23(object sender, EventArgs e)
	{
		string zo = "SELECT MaSP,MaHD,SoLuong,DonGia FROM dbo.ChiTietHoaDon";
		DataTable dataSource = dataaccess.y2X5(zo);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val.get_Columns().get_Item(0).set_HeaderText("Don Gia");
		val = null;
	}

	internal static string[] Xz69()
	{
		List<string> list = new List<string>();
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(Fd48.mDic["Ass"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
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

	private void k5Q7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		Fq78 fq = new Fq78();
		((Form)fq).ShowDialog();
		if ((int)((Form)fq).get_DialogResult() == 1)
		{
			o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void Hg79(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		d9LM d9LM = new d9LM();
		((Form)d9LM).ShowDialog();
		if ((int)((Form)d9LM).get_DialogResult() == 1)
		{
			o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	internal static bool w7ZS()
	{
		try
		{
			try
			{
				Type type = i7M0.Ey52((Assembly)Fd48.mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, Fd48.mDic[Fd48.tName], false))
				{
					Fd48.mDic.Add(Fd48.T, type);
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

	private void Ry3o(object sender, EventArgs e)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		Fd48 fd = new Fd48();
		DataGridView val = dgvLoad;
		fd.txtMakh.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("MaKH")
			.get_Value()));
		fd.txtTenkh.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("TenKH")
			.get_Value()));
		fd.txtDiachi.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("Diachi")
			.get_Value()));
		fd.txtSdt.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("SoDT")
			.get_Value()));
		val = null;
		((Form)fd).ShowDialog();
		if ((int)((Form)fd).get_DialogResult() == 1)
		{
			o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	public static byte Lw6f(byte Dz59, byte[] n2K6, int Fp96, int i3TM)
	{
		Dz59 = (byte)(Dz59 ^ checked((byte)(n2K6[unchecked(i3TM % n2K6.Length)] ^ ((i3TM + unchecked(Fp96 % n2K6.Length)) & Fp96))));
		return Dz59;
	}

	private void Lx98(object sender, EventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if (cbKH.get_Checked())
		{
			string arg = Conversions.ToString(dgvLoad.get_Rows().get_Item(dgvLoad.get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaKH")
				.get_Value());
			string n8XN = $"DELETE KhachHang WHERE MaKH = '{arg}'";
			if (dataaccess.Ro87(n8XN))
			{
				MessageBox.Show("Xoa thanh cong");
				o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
		if (cbHD.get_Checked())
		{
			string arg2 = Conversions.ToString(dgvLoad.get_Rows().get_Item(dgvLoad.get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaHD")
				.get_Value());
			string n8XN2 = $"DELETE HoaDon WHERE MaHD = '{arg2}'";
			if (dataaccess.Ro87(n8XN2))
			{
				MessageBox.Show("Xoa thanh cong");
				o1QX(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void s9ZB(bool i1ES)
	{
		try
		{
			if (i1ES && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i1ES);
		}
	}

	[DebuggerStepThrough]
	private void Td78()
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
		dgvLoad = new DataGridView();
		btnsanpham = new Button();
		btnkhachhang = new Button();
		GroupBox1 = new GroupBox();
		cbSP = new ComboBox();
		Label1 = new Label();
		cbSearch = new ComboBox();
		txtSearch = new TextBox();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		btnAddHD = new Button();
		cbKH = new CheckBox();
		cbHD = new CheckBox();
		cbCTHD = new CheckBox();
		btnAddLSP = new Button();
		btnEditKH = new Button();
		btnXoa = new Button();
		((ISupportInitialize)dgvLoad).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		dgvLoad.set_AllowUserToAddRows(false);
		dgvLoad.set_AllowUserToDeleteRows(false);
		dgvLoad.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgvLoad).set_Location(new Point(12, 71));
		dgvLoad.set_MultiSelect(false);
		((Control)dgvLoad).set_Name("dgvLoad");
		dgvLoad.set_ReadOnly(true);
		dgvLoad.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dgvLoad).set_Size(new Size(508, 308));
		((Control)dgvLoad).set_TabIndex(0);
		((Control)btnsanpham).set_Location(new Point(538, 97));
		((Control)btnsanpham).set_Name("btnsanpham");
		((Control)btnsanpham).set_Size(new Size(100, 23));
		((Control)btnsanpham).set_TabIndex(1);
		((ButtonBase)btnsanpham).set_Text("Them San Pham");
		((ButtonBase)btnsanpham).set_UseVisualStyleBackColor(true);
		((Control)btnkhachhang).set_Location(new Point(538, 39));
		((Control)btnkhachhang).set_Name("btnkhachhang");
		((Control)btnkhachhang).set_Size(new Size(100, 23));
		((Control)btnkhachhang).set_TabIndex(2);
		((ButtonBase)btnkhachhang).set_Text("Them KH");
		((ButtonBase)btnkhachhang).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cbSP);
		((Control)GroupBox1).set_Location(new Point(526, 279));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(137, 100));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Loai San Pham");
		((ListControl)cbSP).set_FormattingEnabled(true);
		((Control)cbSP).set_Location(new Point(6, 38));
		((Control)cbSP).set_Name("cbSP");
		((Control)cbSP).set_Size(new Size(121, 21));
		((Control)cbSP).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(13, 39));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(49, 13));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Tìm kiếm");
		((ListControl)cbSearch).set_FormattingEnabled(true);
		cbSearch.get_Items().AddRange(new object[2] { "MaSP", "TenSP" });
		((Control)cbSearch).set_Location(new Point(68, 36));
		((Control)cbSearch).set_Name("cbSearch");
		((Control)cbSearch).set_Size(new Size(109, 21));
		((Control)cbSearch).set_TabIndex(5);
		((Control)txtSearch).set_Location(new Point(184, 36));
		((Control)txtSearch).set_Name("txtSearch");
		((Control)txtSearch).set_Size(new Size(336, 20));
		((Control)txtSearch).set_TabIndex(6);
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		((Control)ContextMenuStrip1).set_Size(new Size(61, 4));
		((Control)btnAddHD).set_Location(new Point(538, 68));
		((Control)btnAddHD).set_Name("btnAddHD");
		((Control)btnAddHD).set_Size(new Size(100, 23));
		((Control)btnAddHD).set_TabIndex(10);
		((ButtonBase)btnAddHD).set_Text("Them Hoa Don");
		((ButtonBase)btnAddHD).set_UseVisualStyleBackColor(true);
		((ButtonBase)cbKH).set_AutoSize(true);
		((Control)cbKH).set_Location(new Point(538, 198));
		((Control)cbKH).set_Name("cbKH");
		((Control)cbKH).set_Size(new Size(86, 17));
		((Control)cbKH).set_TabIndex(12);
		((ButtonBase)cbKH).set_Text("Khach Hang");
		((ButtonBase)cbKH).set_UseVisualStyleBackColor(true);
		((ButtonBase)cbHD).set_AutoSize(true);
		((Control)cbHD).set_Location(new Point(538, 221));
		((Control)cbHD).set_Name("cbHD");
		((Control)cbHD).set_Size(new Size(69, 17));
		((Control)cbHD).set_TabIndex(13);
		((ButtonBase)cbHD).set_Text("Hoa Don");
		((ButtonBase)cbHD).set_UseVisualStyleBackColor(true);
		((ButtonBase)cbCTHD).set_AutoSize(true);
		((Control)cbCTHD).set_Location(new Point(538, 245));
		((Control)cbCTHD).set_Name("cbCTHD");
		((Control)cbCTHD).set_Size(new Size(108, 17));
		((Control)cbCTHD).set_TabIndex(14);
		((ButtonBase)cbCTHD).set_Text("Chi Tiet Hoa Don");
		((ButtonBase)cbCTHD).set_UseVisualStyleBackColor(true);
		((Control)btnAddLSP).set_Location(new Point(538, 126));
		((Control)btnAddLSP).set_Name("btnAddLSP");
		((Control)btnAddLSP).set_Size(new Size(100, 23));
		((Control)btnAddLSP).set_TabIndex(15);
		((ButtonBase)btnAddLSP).set_Text("Them Loai SP");
		((ButtonBase)btnAddLSP).set_UseVisualStyleBackColor(true);
		((Control)btnEditKH).set_Location(new Point(12, 394));
		((Control)btnEditKH).set_Name("btnEditKH");
		((Control)btnEditKH).set_Size(new Size(75, 23));
		((Control)btnEditKH).set_TabIndex(16);
		((ButtonBase)btnEditKH).set_Text("Sua KH");
		((ButtonBase)btnEditKH).set_UseVisualStyleBackColor(true);
		((Control)btnXoa).set_Location(new Point(102, 394));
		((Control)btnXoa).set_Name("btnXoa");
		((Control)btnXoa).set_Size(new Size(75, 23));
		((Control)btnXoa).set_TabIndex(17);
		((ButtonBase)btnXoa).set_Text("Xoa");
		((ButtonBase)btnXoa).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(675, 440));
		((Control)this).get_Controls().Add((Control)(object)btnXoa);
		((Control)this).get_Controls().Add((Control)(object)btnEditKH);
		((Control)this).get_Controls().Add((Control)(object)btnAddLSP);
		((Control)this).get_Controls().Add((Control)(object)cbCTHD);
		((Control)this).get_Controls().Add((Control)(object)cbHD);
		((Control)this).get_Controls().Add((Control)(object)cbKH);
		((Control)this).get_Controls().Add((Control)(object)btnAddHD);
		((Control)this).get_Controls().Add((Control)(object)txtSearch);
		((Control)this).get_Controls().Add((Control)(object)cbSearch);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)btnkhachhang);
		((Control)this).get_Controls().Add((Control)(object)btnsanpham);
		((Control)this).get_Controls().Add((Control)(object)dgvLoad);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)dgvLoad).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
