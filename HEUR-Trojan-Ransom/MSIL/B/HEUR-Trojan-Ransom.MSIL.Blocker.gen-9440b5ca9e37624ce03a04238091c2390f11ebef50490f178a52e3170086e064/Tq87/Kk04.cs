using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Tq87;

[DesignerGenerated]
public class Kk04 : Form
{
	private Label _Label1;

	private TextBox _TextBox1;

	private Button _Button1;

	private TextBox _TextBox2;

	private Label _Label2;

	internal IContainer f;

	public Kk04()
	{
		i8LA();
	}

	protected override void Kj29(bool c2K6)
	{
		try
		{
			if (c2K6 && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c2K6);
		}
	}

	private void i8LA()
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
		Rc01(new Label());
		Qz8w(new TextBox());
		Kk72(new Button());
		q9M3(new TextBox());
		Wk53(new Label());
		((Control)this).SuspendLayout();
		y8KB().set_AutoSize(true);
		((Control)y8KB()).set_Location(new Point(44, 77));
		((Control)y8KB()).set_Name("Label1");
		((Control)y8KB()).set_Size(new Size(77, 13));
		((Control)y8KB()).set_TabIndex(3);
		y8KB().set_Text("New Schedule");
		((Control)f8DG()).set_Location(new Point(127, 70));
		((Control)f8DG()).set_Name("TextBox1");
		((Control)f8DG()).set_Size(new Size(132, 20));
		((Control)f8DG()).set_TabIndex(2);
		((Control)d9N4()).set_Location(new Point(127, 110));
		((Control)d9N4()).set_Name("Button1");
		((Control)d9N4()).set_Size(new Size(132, 23));
		((Control)d9N4()).set_TabIndex(4);
		((ButtonBase)d9N4()).set_Text("Accept");
		((ButtonBase)d9N4()).set_UseVisualStyleBackColor(true);
		((Control)w3K6()).set_Location(new Point(127, 35));
		((Control)w3K6()).set_Name("TextBox2");
		((Control)w3K6()).set_Size(new Size(132, 20));
		((Control)w3K6()).set_TabIndex(2);
		e4TC().set_AutoSize(true);
		((Control)e4TC()).set_Location(new Point(44, 42));
		((Control)e4TC()).set_Name("Label2");
		((Control)e4TC()).set_Size(new Size(61, 13));
		((Control)e4TC()).set_TabIndex(3);
		e4TC().set_Text("Student_ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(333, 189));
		((Control)this).get_Controls().Add((Control)(object)d9N4());
		((Control)this).get_Controls().Add((Control)(object)e4TC());
		((Control)this).get_Controls().Add((Control)(object)y8KB());
		((Control)this).get_Controls().Add((Control)(object)w3K6());
		((Control)this).get_Controls().Add((Control)(object)f8DG());
		((Control)this).set_Name("Reschedule");
		((Form)this).set_Text("Reschedule");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label y8KB()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rc01(Label Mm34)
	{
		_Label1 = Mm34;
	}

	[SpecialName]
	internal virtual TextBox f8DG()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz8w(TextBox Lz4e)
	{
		_TextBox1 = Lz4e;
	}

	[SpecialName]
	internal virtual Button d9N4()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk72(Button m6BL)
	{
		EventHandler eventHandler = k4T0;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = m6BL;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox w3K6()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9M3(TextBox Qe92)
	{
		_TextBox2 = Qe92;
	}

	[SpecialName]
	internal virtual Label e4TC()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wk53(Label Bk6q)
	{
		_Label2 = Bk6q;
	}

	private void k4T0(object sender, EventArgs e)
	{
	}
}
