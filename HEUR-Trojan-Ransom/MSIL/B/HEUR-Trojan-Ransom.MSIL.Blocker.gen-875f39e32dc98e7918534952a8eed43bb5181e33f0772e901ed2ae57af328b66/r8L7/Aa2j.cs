using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lz89;
using Microsoft.VisualBasic.CompilerServices;
using Rp35;
using Yk48;
using w9B4;

namespace r8L7;

[DesignerGenerated]
public class Aa2j : Form
{
	internal delegate void Fp17();

	private IContainer components;

	private k8MJ dataaccess;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("txtMakh")]
	internal virtual TextBox txtMakh
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTenkh")]
	internal virtual TextBox txtTenkh
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDiachi")]
	internal virtual TextBox txtDiachi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSdt")]
	internal virtual TextBox txtSdt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnOK
	{
		[CompilerGenerated]
		get
		{
			return _btnOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ni13;
			Button val = _btnOK;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnOK = value;
			val = _btnOK;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnCanc
	{
		[CompilerGenerated]
		get
		{
			return _btnCanc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Bf4y;
			Button val = _btnCanc;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnCanc = value;
			val = _btnCanc;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Aa2j()
	{
		dataaccess = new k8MJ();
		g6X3();
	}

	[DebuggerNonUserCode]
	protected override void Be01(bool Py83)
	{
		try
		{
			if (Py83 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Py83);
		}
	}

	[DebuggerStepThrough]
	private void g6X3()
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
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		txtMakh = new TextBox();
		txtTenkh = new TextBox();
		txtDiachi = new TextBox();
		txtSdt = new TextBox();
		btnOK = new Button();
		btnCanc = new Button();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(12, 36));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(40, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Ma KH");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(12, 78));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(44, 13));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Ten KH");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(12, 123));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(41, 13));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Dia Chi");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(12, 173));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(29, 13));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("SDT");
		((Control)txtMakh).set_Location(new Point(72, 33));
		((Control)txtMakh).set_Name("txtMakh");
		((Control)txtMakh).set_Size(new Size(185, 20));
		((Control)txtMakh).set_TabIndex(4);
		((Control)txtTenkh).set_Location(new Point(72, 75));
		((Control)txtTenkh).set_Name("txtTenkh");
		((Control)txtTenkh).set_Size(new Size(185, 20));
		((Control)txtTenkh).set_TabIndex(5);
		((Control)txtDiachi).set_Location(new Point(72, 120));
		((Control)txtDiachi).set_Name("txtDiachi");
		((Control)txtDiachi).set_Size(new Size(185, 20));
		((Control)txtDiachi).set_TabIndex(6);
		((Control)txtSdt).set_Location(new Point(72, 170));
		((Control)txtSdt).set_Name("txtSdt");
		((Control)txtSdt).set_Size(new Size(185, 20));
		((Control)txtSdt).set_TabIndex(7);
		((Control)btnOK).set_Location(new Point(58, 213));
		((Control)btnOK).set_Name("btnOK");
		((Control)btnOK).set_Size(new Size(75, 23));
		((Control)btnOK).set_TabIndex(8);
		((ButtonBase)btnOK).set_Text("OK");
		((ButtonBase)btnOK).set_UseVisualStyleBackColor(true);
		((Control)btnCanc).set_Location(new Point(166, 213));
		((Control)btnCanc).set_Name("btnCanc");
		((Control)btnCanc).set_Size(new Size(75, 23));
		((Control)btnCanc).set_TabIndex(9);
		((ButtonBase)btnCanc).set_Text("Cancel");
		((ButtonBase)btnCanc).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)btnCanc);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)txtSdt);
		((Control)this).get_Controls().Add((Control)(object)txtDiachi);
		((Control)this).get_Controls().Add((Control)(object)txtTenkh);
		((Control)this).get_Controls().Add((Control)(object)txtMakh);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("EditKH");
		((Form)this).set_Text("EditKH");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private bool a6DK()
	{
		string x1S = $"UPDATE KhachHang SET TenKH = '{txtTenkh.get_Text()}', Diachi = '{txtDiachi.get_Text()}', SoDT = '{txtSdt.get_Text()}' WHERE MaKH = '{txtMakh.get_Text()}'";
		return dataaccess.Ze9q(x1S);
	}

	[STAThread]
	public static void m5GF()
	{
		Cx3p();
	}

	private bool Ep8o()
	{
		return string.IsNullOrEmpty(txtMakh.get_Text()) || string.IsNullOrEmpty(txtTenkh.get_Text()) || string.IsNullOrEmpty(txtDiachi.get_Text()) || string.IsNullOrEmpty(txtSdt.get_Text());
	}

	private void Ni13(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (Ep8o())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
		}
		else if (a6DK())
		{
			MessageBox.Show("Cap Nhap thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Cap nhap that bai", "Error", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)7);
		}
	}

	internal static void Cx3p()
	{
		try
		{
			if (Gx38.Je45(2) && s1W0.r2M0())
			{
				Qj4i.Ng25(1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Bf4y(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
