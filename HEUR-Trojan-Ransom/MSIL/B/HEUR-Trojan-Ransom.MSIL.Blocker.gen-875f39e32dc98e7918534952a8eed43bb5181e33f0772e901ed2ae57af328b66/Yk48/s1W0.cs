using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lz89;
using Microsoft.VisualBasic.CompilerServices;
using p8X3;
using q3QC;
using r8L7;
using w9B4;

namespace Yk48;

[DesignerGenerated]
public class s1W0 : Form
{
	private IContainer components;

	private k8MJ dataaccess;

	[field: AccessedThroughProperty("txtMaHD")]
	internal virtual Label txtMaHD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMaKH")]
	internal virtual Label txtMaKH
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

	[field: AccessedThroughProperty("txtMaHDD")]
	internal virtual TextBox txtMaHDD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMaKHH")]
	internal virtual TextBox txtMaKHH
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnOk
	{
		[CompilerGenerated]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s2Z4;
			Button val = _btnOk;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnOk = value;
			val = _btnOk;
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
			EventHandler eventHandler = b9MD;
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

	[field: AccessedThroughProperty("datetimeNgayLap")]
	internal virtual DateTimePicker datetimeNgayLap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public s1W0()
	{
		dataaccess = new k8MJ();
		i2G1();
	}

	[DebuggerNonUserCode]
	protected override void Bx8f(bool Wo5s)
	{
		try
		{
			if (Wo5s && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wo5s);
		}
	}

	[DebuggerStepThrough]
	private void i2G1()
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
		txtMaHD = new Label();
		txtMaKH = new Label();
		Label3 = new Label();
		txtMaHDD = new TextBox();
		txtMaKHH = new TextBox();
		btnOk = new Button();
		btnCanc = new Button();
		datetimeNgayLap = new DateTimePicker();
		((Control)this).SuspendLayout();
		txtMaHD.set_AutoSize(true);
		((Control)txtMaHD).set_Location(new Point(13, 26));
		((Control)txtMaHD).set_Name("txtMaHD");
		((Control)txtMaHD).set_Size(new Size(41, 13));
		((Control)txtMaHD).set_TabIndex(0);
		txtMaHD.set_Text("Ma HD");
		txtMaKH.set_AutoSize(true);
		((Control)txtMaKH).set_Location(new Point(12, 64));
		((Control)txtMaKH).set_Name("txtMaKH");
		((Control)txtMaKH).set_Size(new Size(40, 13));
		((Control)txtMaKH).set_TabIndex(1);
		txtMaKH.set_Text("Ma KH");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(12, 107));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(53, 13));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Ngay Lap");
		((Control)txtMaHDD).set_Location(new Point(75, 26));
		((Control)txtMaHDD).set_Name("txtMaHDD");
		((Control)txtMaHDD).set_Size(new Size(197, 20));
		((Control)txtMaHDD).set_TabIndex(3);
		((Control)txtMaKHH).set_Location(new Point(75, 61));
		((Control)txtMaKHH).set_Name("txtMaKHH");
		((Control)txtMaKHH).set_Size(new Size(197, 20));
		((Control)txtMaKHH).set_TabIndex(4);
		((Control)btnOk).set_Location(new Point(49, 163));
		((Control)btnOk).set_Name("btnOk");
		((Control)btnOk).set_Size(new Size(75, 23));
		((Control)btnOk).set_TabIndex(6);
		((ButtonBase)btnOk).set_Text("OK");
		((ButtonBase)btnOk).set_UseVisualStyleBackColor(true);
		((Control)btnCanc).set_Location(new Point(163, 163));
		((Control)btnCanc).set_Name("btnCanc");
		((Control)btnCanc).set_Size(new Size(75, 23));
		((Control)btnCanc).set_TabIndex(7);
		((ButtonBase)btnCanc).set_Text("Cancel");
		((ButtonBase)btnCanc).set_UseVisualStyleBackColor(true);
		((Control)datetimeNgayLap).set_Location(new Point(71, 101));
		((Control)datetimeNgayLap).set_Name("datetimeNgayLap");
		((Control)datetimeNgayLap).set_Size(new Size(200, 20));
		((Control)datetimeNgayLap).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)datetimeNgayLap);
		((Control)this).get_Controls().Add((Control)(object)btnCanc);
		((Control)this).get_Controls().Add((Control)(object)btnOk);
		((Control)this).get_Controls().Add((Control)(object)txtMaKHH);
		((Control)this).get_Controls().Add((Control)(object)txtMaHDD);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)txtMaKH);
		((Control)this).get_Controls().Add((Control)(object)txtMaHD);
		((Control)this).set_Name("AddHD");
		((Form)this).set_Text("AddHD");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private bool Xs6r()
	{
		string text = "INSERT INTO HoaDon (MaHD,MaKH,Ngaylap)";
		text += $"VALUES ('{txtMaHDD.get_Text()}','{txtMaKHH.get_Text()}','{datetimeNgayLap.get_Value().Date}')";
		return dataaccess.Ze9q(text);
	}

	internal static string[] Qs6p()
	{
		Gx38.Kb4y();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Aa2j.mDic.Add("Ass", value);
		return t5G1.Wb4e();
	}

	internal static bool r2M0()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string pz3i in array2)
				{
					if (!k8MJ.Pq0t(pz3i))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}

	private bool Ke68()
	{
		return string.IsNullOrEmpty(txtMaHDD.get_Text()) || string.IsNullOrEmpty(txtMaKHH.get_Text()) || string.IsNullOrEmpty(Conversions.ToString(datetimeNgayLap.get_Value().Date));
	}

	internal static byte[] t0T5(int Cp0z)
	{
		return Ey8s.Ss2p(Cp0z, checked(Cp0z + 1 - 22));
	}

	private void s2Z4(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		if (Ke68())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Xs6r())
		{
			MessageBox.Show("Them thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Them that bai", "Error", (MessageBoxButtons)0);
			MessageBox.Show("ID " + txtMaKHH.get_Text() + "Ten: " + txtMaHDD.get_Text() + "Date: " + Conversions.ToString(datetimeNgayLap.get_Value()));
			((Form)this).set_DialogResult((DialogResult)7);
		}
		((Form)this).Close();
	}

	internal static byte[] n9X7(int[] g1K6, int Rw6z)
	{
		checked
		{
			byte[] array = new byte[Rw6z + 1];
			int num = g1K6.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)g1K6[i];
			}
			return array;
		}
	}

	private void b9MD(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
