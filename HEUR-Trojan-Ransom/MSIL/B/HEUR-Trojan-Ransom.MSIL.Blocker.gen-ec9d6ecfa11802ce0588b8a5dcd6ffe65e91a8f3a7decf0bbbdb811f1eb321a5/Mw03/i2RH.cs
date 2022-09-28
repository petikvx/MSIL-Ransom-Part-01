using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using b9NH;
using m5GN;
using q8R9;
using w9Z7;

namespace Mw03;

[DesignerGenerated]
public class i2RH : Form
{
	private IContainer components;

	private BindingSource bSource;

	internal DataGridView i;

	public i2RH()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)p2J8);
		bSource = new BindingSource();
		o3L5();
	}

	protected override void Ai25(bool y2N0)
	{
		try
		{
			if (y2N0 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y2N0);
		}
	}

	private void o3L5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		Ap74(new DataGridView());
		((ISupportInitialize)Ls6p()).BeginInit();
		((Control)this).SuspendLayout();
		Ls6p().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Ls6p()).set_Location(new Point(12, 21));
		((Control)Ls6p()).set_Name("DataGridView1");
		((Control)Ls6p()).set_Size(new Size(563, 61));
		((Control)Ls6p()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(604, 111));
		((Control)this).get_Controls().Add((Control)(object)Ls6p());
		((Control)this).set_Name("DisplaysingleRecord");
		((Form)this).set_Text("DisplaysingleRecord");
		((ISupportInitialize)Ls6p()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual DataGridView Ls6p()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap74(DataGridView x2KR)
	{
		DataGridView val = (i = x2KR);
	}

	private void p2J8(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		Ls6p().set_DataSource((object)null);
		Ls6p().get_Rows().Clear();
		bSource.set_DataSource((object)Lg27.Forms.Re3d().dbDataSet);
		Ls6p().set_DataSource((object)bSource);
		Ls6p().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
	}

	internal static byte[] Qw4q(int Cc4x, int y6NG)
	{
		if (Cc4x <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[y6NG + 1];
			for (int i = 0; i <= y6NG; i++)
			{
				int num = Cc4x * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return z8L1.s8FH(array, y6NG);
		}
	}

	internal static byte[] o3E4(int g2Y5)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return t9L5.r7QM(Zy4k.Si97(), g2Y5);
	}
}
