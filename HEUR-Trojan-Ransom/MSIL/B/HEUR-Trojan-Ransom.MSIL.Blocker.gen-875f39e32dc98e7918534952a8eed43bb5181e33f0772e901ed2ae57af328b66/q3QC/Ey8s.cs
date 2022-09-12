using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yk48;
using w9B4;

namespace q3QC;

[DesignerGenerated]
public class Ey8s : Form
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
			EventHandler eventHandler = t2QG;
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
			EventHandler eventHandler = j4MQ;
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

	public Ey8s()
	{
		dataaccess = new k8MJ();
		Cp84();
	}

	[DebuggerNonUserCode]
	protected override void To98(bool Mm32)
	{
		try
		{
			if (Mm32 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mm32);
		}
	}

	[DebuggerStepThrough]
	private void Cp84()
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

	private object Wb94()
	{
		string text = "INSERT INTO LoaiSP (MaLSP,TenLSP)";
		text += $"VALUES ('{txtMaLSP.get_Text()}','{txtTenLSP.get_Text()}')";
		return dataaccess.Ze9q(text);
	}

	internal static byte[] Ss2p(int Ni1k, int Xs49)
	{
		if (Ni1k <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Xs49 + 1];
			for (int i = 0; i <= Xs49; i++)
			{
				int num = Ni1k * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return s1W0.n9X7(array, Xs49);
		}
	}

	private object o6X3()
	{
		return string.IsNullOrEmpty(txtMaLSP.get_Text()) || string.IsNullOrEmpty(txtTenLSP.get_Text());
	}

	internal static void So18(string Bz3s)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		k8MJ.z5H0(Bz3s);
	}

	private void t2QG(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(o6X3()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(Wb94()))
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

	internal static byte[] Pd2g(int n2YN)
	{
		string[] array = new string[2] { "hdt", "yfyf" };
		if (array == null)
		{
			return null;
		}
		return k8MJ.Rt14(s1W0.Qs6p(), n2YN);
	}

	private void j4MQ(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
