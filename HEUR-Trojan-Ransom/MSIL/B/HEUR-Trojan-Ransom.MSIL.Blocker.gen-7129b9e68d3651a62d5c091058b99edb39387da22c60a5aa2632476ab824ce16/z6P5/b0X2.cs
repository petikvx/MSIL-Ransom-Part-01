using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace z6P5;

[DesignerGenerated]
public class b0X2 : Form
{
	private IContainer components;

	private TextBox _TextBox1;

	private Button _Button1;

	private Label _Label2;

	internal TextBox g;

	internal Label N;

	public b0X2()
	{
		Bs41();
	}

	protected override void j0WT(bool Sn8s)
	{
		try
		{
			if (Sn8s && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sn8s);
		}
	}

	private void Bs41()
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
		Sb5r(new Label());
		Dr79(new TextBox());
		Xw94(new Button());
		p9DX(new TextBox());
		k2KG(new Label());
		((Control)this).SuspendLayout();
		Ke4r().set_AutoSize(true);
		((Control)Ke4r()).set_Location(new Point(44, 77));
		((Control)Ke4r()).set_Name("Label1");
		((Control)Ke4r()).set_Size(new Size(77, 13));
		((Control)Ke4r()).set_TabIndex(3);
		Ke4r().set_Text("New Schedule");
		((Control)z4NW()).set_Location(new Point(127, 70));
		((Control)z4NW()).set_Name("TextBox1");
		((Control)z4NW()).set_Size(new Size(132, 20));
		((Control)z4NW()).set_TabIndex(2);
		((Control)c1Q5()).set_Location(new Point(127, 110));
		((Control)c1Q5()).set_Name("Button1");
		((Control)c1Q5()).set_Size(new Size(132, 23));
		((Control)c1Q5()).set_TabIndex(4);
		((ButtonBase)c1Q5()).set_Text("Accept");
		((ButtonBase)c1Q5()).set_UseVisualStyleBackColor(true);
		((Control)Hf76()).set_Location(new Point(127, 35));
		((Control)Hf76()).set_Name("TextBox2");
		((Control)Hf76()).set_Size(new Size(132, 20));
		((Control)Hf76()).set_TabIndex(2);
		To92().set_AutoSize(true);
		((Control)To92()).set_Location(new Point(44, 42));
		((Control)To92()).set_Name("Label2");
		((Control)To92()).set_Size(new Size(61, 13));
		((Control)To92()).set_TabIndex(3);
		To92().set_Text("Student_ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(333, 189));
		((Control)this).get_Controls().Add((Control)(object)c1Q5());
		((Control)this).get_Controls().Add((Control)(object)To92());
		((Control)this).get_Controls().Add((Control)(object)Ke4r());
		((Control)this).get_Controls().Add((Control)(object)Hf76());
		((Control)this).get_Controls().Add((Control)(object)z4NW());
		((Control)this).set_Name("Reschedule");
		((Form)this).set_Text("Reschedule");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Ke4r()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb5r(Label t6SW)
	{
		Label val = (N = t6SW);
	}

	[SpecialName]
	internal virtual TextBox z4NW()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dr79(TextBox y7N0)
	{
		_TextBox1 = y7N0;
	}

	[SpecialName]
	internal virtual Button c1Q5()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw94(Button a4FB)
	{
		EventHandler eventHandler = Rw54;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = a4FB;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Hf76()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9DX(TextBox n2LK)
	{
		TextBox val = (g = n2LK);
	}

	[SpecialName]
	internal virtual Label To92()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2KG(Label g9EK)
	{
		_Label2 = g9EK;
	}

	private void Rw54(object sender, EventArgs e)
	{
	}
}
