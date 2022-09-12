using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Mk6;

[DesignerGenerated]
public class Rs8 : Form
{
	private BackgroundWorker _BackgroundWorker1;

	private Button _Button1;

	private CheckBox _CheckBox1;

	internal IContainer Q;

	internal Button f;

	internal ColorDialog D;

	internal DataGridView Y;

	public Rs8()
	{
		p1G();
	}

	protected override void s8L(bool w1X)
	{
		try
		{
			if (w1X && Q != null)
			{
				Q.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w1X);
		}
	}

	private void p1G()
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
		i5H(new BackgroundWorker());
		Rn6(new Button());
		z2H(new Button());
		d7H(new CheckBox());
		b3F(new ColorDialog());
		n5L(new DataGridView());
		((ISupportInitialize)Db4()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)q4S()).set_Location(new Point(222, 255));
		((Control)q4S()).set_Name("Button1");
		((Control)q4S()).set_Size(new Size(75, 23));
		((Control)q4S()).set_TabIndex(0);
		((ButtonBase)q4S()).set_Text("Button1");
		((ButtonBase)q4S()).set_UseVisualStyleBackColor(true);
		((Control)g8S()).set_Location(new Point(232, 156));
		((Control)g8S()).set_Name("Button2");
		((Control)g8S()).set_Size(new Size(75, 23));
		((Control)g8S()).set_TabIndex(1);
		((ButtonBase)g8S()).set_Text("Button2");
		((ButtonBase)g8S()).set_UseVisualStyleBackColor(true);
		((ButtonBase)c9X()).set_AutoSize(true);
		((Control)c9X()).set_Location(new Point(147, 394));
		((Control)c9X()).set_Name("CheckBox1");
		((Control)c9X()).set_Size(new Size(81, 17));
		((Control)c9X()).set_TabIndex(2);
		((ButtonBase)c9X()).set_Text("CheckBox1");
		((ButtonBase)c9X()).set_UseVisualStyleBackColor(true);
		Db4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Db4()).set_Location(new Point(130, 13));
		((Control)Db4()).set_Name("DataGridView1");
		((Control)Db4()).set_Size(new Size(240, 150));
		((Control)Db4()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Db4());
		((Control)this).get_Controls().Add((Control)(object)c9X());
		((Control)this).get_Controls().Add((Control)(object)g8S());
		((Control)this).get_Controls().Add((Control)(object)q4S());
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("Form3");
		((ISupportInitialize)Db4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual BackgroundWorker Ei5()
	{
		return _BackgroundWorker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5H(BackgroundWorker Mx9)
	{
		_BackgroundWorker1 = Mx9;
	}

	[SpecialName]
	internal virtual Button q4S()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn6(Button d9Q)
	{
		_Button1 = d9Q;
	}

	[SpecialName]
	internal virtual Button g8S()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2H(Button Ha9)
	{
		Button val = (f = Ha9);
	}

	[SpecialName]
	internal virtual CheckBox c9X()
	{
		return _CheckBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7H(CheckBox Gx2)
	{
		_CheckBox1 = Gx2;
	}

	[SpecialName]
	internal virtual ColorDialog Qo1()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3F(ColorDialog Rz1)
	{
		ColorDialog val = (D = Rz1);
	}

	[SpecialName]
	internal virtual DataGridView Db4()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5L(DataGridView m4R)
	{
		DataGridView val = (Y = m4R);
	}
}
