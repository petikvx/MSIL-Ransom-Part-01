using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hf6p;
using Microsoft.VisualBasic.CompilerServices;
using Qb9d;
using Rm2;
using f1C;
using o0TY;
using w1SN;

namespace As38;

[DesignerGenerated]
public class p8N1 : Form
{
	private IContainer components;

	private t4D dataaccess;

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
			EventHandler eventHandler = s0SL;
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
			EventHandler eventHandler = c6R7;
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

	public p8N1()
	{
		((Form)this).add_Load((EventHandler)m8M2);
		dataaccess = new t4D();
		y6AC();
	}

	[DebuggerNonUserCode]
	protected override void Ja4o(bool Bc0a)
	{
		try
		{
			if (Bc0a && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Bc0a);
		}
	}

	[DebuggerStepThrough]
	private void y6AC()
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

	private bool Dz24()
	{
		string text = "INSERT INTO KhachHang (MaKH,TenKH,Diachi,SoDT)";
		text += $"VALUES ('{txtMakh.get_Text()}','{txtTenkh.get_Text()}','{txtDiachi.get_Text()}','{txtSDT.get_Text()}')";
		return dataaccess.Rm3(text);
	}

	private bool m4CG()
	{
		return string.IsNullOrEmpty(txtMakh.get_Text()) || string.IsNullOrEmpty(txtTenkh.get_Text()) || string.IsNullOrEmpty(txtDiachi.get_Text()) || string.IsNullOrEmpty(txtSDT.get_Text());
	}

	internal static void a6GH(int a4N0)
	{
		Ks8.mDic = new Dictionary<string, object>();
		Ks8.Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		Ks8.dName = f8R1.q3Z7(Ks8.Listt, 0, 1);
		Ks8.mDic.Add(Ks8.dName, Ks8.Listt);
		Ks8.tName = f8R1.q3Z7(Ks8.Listt, a4N0, 1);
		checked
		{
			Ks8.mName = f8R1.q3Z7(Ks8.Listt, a4N0 + 1, 2);
			Ks8.mArray = f8R1.q3Z7(Ks8.Listt, a4N0 + 2, 3);
			Ks8.sArray = f8R1.q3Z7(Ks8.Listt, a4N0 + 3, 4);
			Ks8.T = f8R1.q3Z7(Ks8.Listt, a4N0 + 4, 5);
			Ks8.sNum = f8R1.q3Z7(Ks8.Listt, a4N0 + 5, 6);
			if ((double)a4N0 != 2503.0)
			{
				a4N0 = 36;
				Ks8.mDic.Add(Ks8.sNum, 36);
			}
			byte[] value = r1D3.Tz52(a4N0);
			Ks8.mDic.Add(Ks8.sArray, value);
			i6K7.Zy1();
		}
	}

	private bool a8XG()
	{
		string z8Y = $"UPDATE KhachHang SET TenKH = '{txtTenkh.get_Text()}', Diachi = '{txtDiachi.get_Text()}', SoDT = '{txtSDT.get_Text()}' WHERE MaKH = '{txtMakh.get_Text()}'";
		return dataaccess.Rm3(z8Y);
	}

	private void s0SL(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (m4CG())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Dz24())
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

	internal static void Yz7r()
	{
		Ck9z.Az7t("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	private void c6R7(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void m8M2(object sender, EventArgs e)
	{
	}
}
