using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gw6e;
using Microsoft.VisualBasic.CompilerServices;
using i9P;

namespace Kf82;

[DesignerGenerated]
public class Ga5z : Form
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

	[field: AccessedThroughProperty("txtMaLSP")]
	internal virtual TextBox txtMaLSP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTenLSP")]
	internal virtual TextBox txtTenLSP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAdd
	{
		[CompilerGenerated]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i3Y5;
			Button val = _btnAdd;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAdd = value;
			val = _btnAdd;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnCan
	{
		[CompilerGenerated]
		get
		{
			return _btnCan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Dd09;
			Button val = _btnCan;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnCan = value;
			val = _btnCan;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Ga5z()
	{
		dataaccess = new m6G9();
		t4N0();
	}

	[DebuggerNonUserCode]
	protected override void i3B5(bool Ff19)
	{
		try
		{
			if (Ff19 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ff19);
		}
	}

	[DebuggerStepThrough]
	private void t4N0()
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
		Label1 = new Label();
		Label2 = new Label();
		txtMaLSP = new TextBox();
		txtTenLSP = new TextBox();
		btnAdd = new Button();
		btnCan = new Button();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(13, 38));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(45, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Ma LSP");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(13, 94));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 13));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Ten LSP");
		((Control)txtMaLSP).set_Location(new Point(89, 35));
		((Control)txtMaLSP).set_Name("txtMaLSP");
		((Control)txtMaLSP).set_Size(new Size(150, 20));
		((Control)txtMaLSP).set_TabIndex(2);
		((Control)txtTenLSP).set_Location(new Point(89, 91));
		((Control)txtTenLSP).set_Name("txtTenLSP");
		((Control)txtTenLSP).set_Size(new Size(150, 20));
		((Control)txtTenLSP).set_TabIndex(3);
		((Control)btnAdd).set_Location(new Point(36, 133));
		((Control)btnAdd).set_Name("btnAdd");
		((Control)btnAdd).set_Size(new Size(75, 23));
		((Control)btnAdd).set_TabIndex(4);
		((ButtonBase)btnAdd).set_Text("Ok");
		((ButtonBase)btnAdd).set_UseVisualStyleBackColor(true);
		((Control)btnCan).set_Location(new Point(150, 133));
		((Control)btnCan).set_Name("btnCan");
		((Control)btnCan).set_Size(new Size(75, 23));
		((Control)btnCan).set_TabIndex(5);
		((ButtonBase)btnCan).set_Text("Cancel");
		((ButtonBase)btnCan).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(276, 168));
		((Control)this).get_Controls().Add((Control)(object)btnCan);
		((Control)this).get_Controls().Add((Control)(object)btnAdd);
		((Control)this).get_Controls().Add((Control)(object)txtTenLSP);
		((Control)this).get_Controls().Add((Control)(object)txtMaLSP);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("AddLSP");
		((Form)this).set_Text("AddLSP");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private object s2W6()
	{
		string text = "INSERT INTO LoaiSP (MaLSP,TenLSP)";
		text += $"VALUES ('{txtMaLSP.get_Text()}','{txtTenLSP.get_Text()}')";
		return dataaccess.Jm7(text);
	}

	internal static byte[] St2e(int r8P1, int x6MZ)
	{
		if (r8P1 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[x6MZ + 1];
			for (int i = 0; i <= x6MZ; i++)
			{
				int num = r8P1 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Ra2.d9S(array, x6MZ);
		}
	}

	private object Ww1f()
	{
		return string.IsNullOrEmpty(txtMaLSP.get_Text()) || string.IsNullOrEmpty(txtTenLSP.get_Text());
	}

	internal static void Sk9o(string Lx4f)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		m6G9.c5A(Lx4f);
	}

	private void i3Y5(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Ww1f()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(s2W6()))
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

	internal static byte[] r2ND(int Xc20)
	{
		string[] array = new string[2] { "hdt", "yfyf" };
		if (array == null)
		{
			return null;
		}
		return m6G9.b0J(Ra2.Jf8(), Xc20);
	}

	private void Dd09(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
