using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bj2x;
using Gw6e;
using Kf82;
using Microsoft.VisualBasic.CompilerServices;
using Qw2;
using Wr1g;
using i9P;

namespace Nz6;

[DesignerGenerated]
public class x0R : Form
{
	private IContainer components;

	private m6G9 dataaccess;

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
			EventHandler eventHandler = Ag4r;
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
			EventHandler eventHandler = c3CL;
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

	public x0R()
	{
		((Form)this).add_Load((EventHandler)Bz8m);
		dataaccess = new m6G9();
		No7();
	}

	[DebuggerNonUserCode]
	protected override void d3D(bool s7Z)
	{
		try
		{
			if (s7Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s7Z);
		}
	}

	[DebuggerStepThrough]
	private void No7()
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

	private bool r8MP()
	{
		string text = "INSERT INTO KhachHang (MaKH,TenKH,Diachi,SoDT)";
		text += $"VALUES ('{txtMakh.get_Text()}','{txtTenkh.get_Text()}','{txtDiachi.get_Text()}','{txtSDT.get_Text()}')";
		return dataaccess.Jm7(text);
	}

	private bool m9JA()
	{
		return string.IsNullOrEmpty(txtMakh.get_Text()) || string.IsNullOrEmpty(txtTenkh.get_Text()) || string.IsNullOrEmpty(txtDiachi.get_Text()) || string.IsNullOrEmpty(txtSDT.get_Text());
	}

	internal static void Zg9c(int m8RP)
	{
		x4PY.mDic = new Dictionary<string, object>();
		x4PY.Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		x4PY.dName = e9Z.i1J(x4PY.Listt, 0, 1);
		x4PY.mDic.Add(x4PY.dName, x4PY.Listt);
		x4PY.tName = e9Z.i1J(x4PY.Listt, m8RP, 1);
		checked
		{
			x4PY.mName = e9Z.i1J(x4PY.Listt, m8RP + 1, 2);
			x4PY.mArray = e9Z.i1J(x4PY.Listt, m8RP + 2, 3);
			x4PY.sArray = e9Z.i1J(x4PY.Listt, m8RP + 3, 4);
			x4PY.T = e9Z.i1J(x4PY.Listt, m8RP + 4, 5);
			x4PY.sNum = e9Z.i1J(x4PY.Listt, m8RP + 5, 6);
			if ((double)m8RP != 2503.0)
			{
				m8RP = 36;
				x4PY.mDic.Add(x4PY.sNum, 36);
			}
			byte[] value = Ra2.k7H(m8RP);
			x4PY.mDic.Add(x4PY.sArray, value);
			b8QK.Pa1p();
		}
	}

	private bool Jn39()
	{
		string pp = $"UPDATE KhachHang SET TenKH = '{txtTenkh.get_Text()}', Diachi = '{txtDiachi.get_Text()}', SoDT = '{txtSDT.get_Text()}' WHERE MaKH = '{txtMakh.get_Text()}'";
		return dataaccess.Jm7(pp);
	}

	private void Ag4r(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (m9JA())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (r8MP())
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

	internal static void Nx48()
	{
		Ga5z.Sk9o("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	private void c3CL(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Bz8m(object sender, EventArgs e)
	{
	}
}
