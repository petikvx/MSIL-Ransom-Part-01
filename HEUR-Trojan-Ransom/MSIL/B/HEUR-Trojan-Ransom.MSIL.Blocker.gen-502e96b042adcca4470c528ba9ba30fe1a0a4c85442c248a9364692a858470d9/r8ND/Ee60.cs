using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace r8ND;

[DesignerGenerated]
public class Ee60 : Form
{
	private IContainer components;

	private Label _Label1;

	private TextBox _TextBox1;

	private Label _Label2;

	internal Button e;

	internal TextBox B;

	public Ee60()
	{
		Cg92();
	}

	protected override void w8Y1(bool Gp15)
	{
		try
		{
			if (Gp15 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gp15);
		}
	}

	private void Cg92()
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
		e3E2(new Label());
		Em9t(new TextBox());
		b9EN(new Button());
		Pk1m(new TextBox());
		t7ZP(new Label());
		((Control)this).SuspendLayout();
		n0SN().set_AutoSize(true);
		((Control)n0SN()).set_Location(new Point(44, 77));
		((Control)n0SN()).set_Name("Label1");
		((Control)n0SN()).set_Size(new Size(77, 13));
		((Control)n0SN()).set_TabIndex(3);
		n0SN().set_Text("New Schedule");
		((Control)Pd6x()).set_Location(new Point(127, 70));
		((Control)Pd6x()).set_Name("TextBox1");
		((Control)Pd6x()).set_Size(new Size(132, 20));
		((Control)Pd6x()).set_TabIndex(2);
		((Control)Tp80()).set_Location(new Point(127, 110));
		((Control)Tp80()).set_Name("Button1");
		((Control)Tp80()).set_Size(new Size(132, 23));
		((Control)Tp80()).set_TabIndex(4);
		((ButtonBase)Tp80()).set_Text("Accept");
		((ButtonBase)Tp80()).set_UseVisualStyleBackColor(true);
		((Control)o4M2()).set_Location(new Point(127, 35));
		((Control)o4M2()).set_Name("TextBox2");
		((Control)o4M2()).set_Size(new Size(132, 20));
		((Control)o4M2()).set_TabIndex(2);
		x2FL().set_AutoSize(true);
		((Control)x2FL()).set_Location(new Point(44, 42));
		((Control)x2FL()).set_Name("Label2");
		((Control)x2FL()).set_Size(new Size(61, 13));
		((Control)x2FL()).set_TabIndex(3);
		x2FL().set_Text("Student_ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(333, 189));
		((Control)this).get_Controls().Add((Control)(object)Tp80());
		((Control)this).get_Controls().Add((Control)(object)x2FL());
		((Control)this).get_Controls().Add((Control)(object)n0SN());
		((Control)this).get_Controls().Add((Control)(object)o4M2());
		((Control)this).get_Controls().Add((Control)(object)Pd6x());
		((Control)this).set_Name("Reschedule");
		((Form)this).set_Text("Reschedule");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label n0SN()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3E2(Label Me2n)
	{
		_Label1 = Me2n;
	}

	[SpecialName]
	internal virtual TextBox Pd6x()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Em9t(TextBox Fq95)
	{
		_TextBox1 = Fq95;
	}

	[SpecialName]
	internal virtual Button Tp80()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9EN(Button Gf36)
	{
		EventHandler eventHandler = Qo13;
		Button val = e;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (e = Gf36);
		val = e;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox o4M2()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pk1m(TextBox w2H5)
	{
		TextBox val = (B = w2H5);
	}

	[SpecialName]
	internal virtual Label x2FL()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7ZP(Label Zf61)
	{
		_Label2 = Zf61;
	}

	private void Qo13(object sender, EventArgs e)
	{
	}
}
