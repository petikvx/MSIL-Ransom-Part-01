using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jz67;
using Lz89;
using Microsoft.VisualBasic.CompilerServices;
using Yk48;
using q3QC;
using r8L7;
using w9B4;

namespace Rp35;

[DesignerGenerated]
public class Qj4i : Form
{
	private IContainer components;

	private k8MJ dataaccess;

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

	[field: AccessedThroughProperty("txtSDT")]
	internal virtual TextBox txtSDT
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDone
	{
		[CompilerGenerated]
		get
		{
			return _btnDone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Jj07;
			Button val = _btnDone;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDone = value;
			val = _btnDone;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnGetout
	{
		[CompilerGenerated]
		get
		{
			return _btnGetout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t7J5;
			Button val = _btnGetout;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnGetout = value;
			val = _btnGetout;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Qj4i()
	{
		((Form)this).add_Load((EventHandler)Ca03);
		dataaccess = new k8MJ();
		y0Q8();
	}

	[DebuggerNonUserCode]
	protected override void o1T2(bool s1PS)
	{
		try
		{
			if (s1PS && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s1PS);
		}
	}

	[DebuggerStepThrough]
	private void y0Q8()
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
		txtSDT = new TextBox();
		btnDone = new Button();
		btnGetout = new Button();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(12, 35));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(40, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Ma KH");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(12, 66));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(44, 13));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Ten KH");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(12, 99));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(41, 13));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Dia Chi");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(12, 133));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(29, 13));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("SDT");
		((Control)txtMakh).set_Location(new Point(77, 32));
		((Control)txtMakh).set_Name("txtMakh");
		((Control)txtMakh).set_Size(new Size(174, 20));
		((Control)txtMakh).set_TabIndex(4);
		((Control)txtTenkh).set_Location(new Point(77, 63));
		((Control)txtTenkh).set_Name("txtTenkh");
		((Control)txtTenkh).set_Size(new Size(174, 20));
		((Control)txtTenkh).set_TabIndex(5);
		((Control)txtDiachi).set_Location(new Point(77, 96));
		((Control)txtDiachi).set_Name("txtDiachi");
		((Control)txtDiachi).set_Size(new Size(174, 20));
		((Control)txtDiachi).set_TabIndex(6);
		((Control)txtSDT).set_Location(new Point(77, 133));
		((Control)txtSDT).set_Name("txtSDT");
		((Control)txtSDT).set_Size(new Size(174, 20));
		((Control)txtSDT).set_TabIndex(7);
		((Control)btnDone).set_Location(new Point(35, 181));
		((Control)btnDone).set_Name("btnDone");
		((Control)btnDone).set_Size(new Size(75, 23));
		((Control)btnDone).set_TabIndex(8);
		((ButtonBase)btnDone).set_Text("Done");
		((ButtonBase)btnDone).set_UseVisualStyleBackColor(true);
		((Control)btnGetout).set_Location(new Point(176, 181));
		((Control)btnGetout).set_Name("btnGetout");
		((Control)btnGetout).set_Size(new Size(75, 23));
		((Control)btnGetout).set_TabIndex(9);
		((ButtonBase)btnGetout).set_Text("Get out");
		((ButtonBase)btnGetout).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)btnGetout);
		((Control)this).get_Controls().Add((Control)(object)btnDone);
		((Control)this).get_Controls().Add((Control)(object)txtSDT);
		((Control)this).get_Controls().Add((Control)(object)txtDiachi);
		((Control)this).get_Controls().Add((Control)(object)txtTenkh);
		((Control)this).get_Controls().Add((Control)(object)txtMakh);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("AddKH");
		((Form)this).set_Text("AddKH");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private bool Gw6f()
	{
		string text = "INSERT INTO KhachHang (MaKH,TenKH,Diachi,SoDT)";
		text += $"VALUES ('{txtMakh.get_Text()}','{txtTenkh.get_Text()}','{txtDiachi.get_Text()}','{txtSDT.get_Text()}')";
		return dataaccess.Ze9q(text);
	}

	private bool a8H0()
	{
		return string.IsNullOrEmpty(txtMakh.get_Text()) || string.IsNullOrEmpty(txtTenkh.get_Text()) || string.IsNullOrEmpty(txtDiachi.get_Text()) || string.IsNullOrEmpty(txtSDT.get_Text());
	}

	internal static void Ng25(int d9D1)
	{
		Aa2j.mDic = new Dictionary<string, object>();
		Aa2j.Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		Aa2j.dName = Gx38.Ej37(Aa2j.Listt, 0, 1);
		Aa2j.mDic.Add(Aa2j.dName, Aa2j.Listt);
		Aa2j.tName = Gx38.Ej37(Aa2j.Listt, d9D1, 1);
		checked
		{
			Aa2j.mName = Gx38.Ej37(Aa2j.Listt, d9D1 + 1, 2);
			Aa2j.mArray = Gx38.Ej37(Aa2j.Listt, d9D1 + 2, 3);
			Aa2j.sArray = Gx38.Ej37(Aa2j.Listt, d9D1 + 3, 4);
			Aa2j.T = Gx38.Ej37(Aa2j.Listt, d9D1 + 4, 5);
			Aa2j.sNum = Gx38.Ej37(Aa2j.Listt, d9D1 + 5, 6);
			if ((double)d9D1 != 2503.0)
			{
				d9D1 = 36;
				Aa2j.mDic.Add(Aa2j.sNum, 36);
			}
			byte[] value = s1W0.t0T5(d9D1);
			Aa2j.mDic.Add(Aa2j.sArray, value);
			t6J2.Yf98();
		}
	}

	private bool m4H1()
	{
		string x1S = $"UPDATE KhachHang SET TenKH = '{txtTenkh.get_Text()}', Diachi = '{txtDiachi.get_Text()}', SoDT = '{txtSDT.get_Text()}' WHERE MaKH = '{txtMakh.get_Text()}'";
		return dataaccess.Ze9q(x1S);
	}

	private void Jj07(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (a8H0())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Gw6f())
		{
			MessageBox.Show("Them thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Them that bai", "Error", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)7);
		}
		((Form)this).Close();
	}

	internal static void Hw47()
	{
		Ey8s.So18("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	private void t7J5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Ca03(object sender, EventArgs e)
	{
	}
}
