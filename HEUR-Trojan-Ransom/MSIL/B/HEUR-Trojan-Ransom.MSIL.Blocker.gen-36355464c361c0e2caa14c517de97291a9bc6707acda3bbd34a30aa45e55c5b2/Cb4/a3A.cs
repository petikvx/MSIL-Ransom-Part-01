using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Cb4;

[DesignerGenerated]
public class a3A : UserControl
{
	private IContainer components;

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public a3A()
	{
		Nc3();
	}

	[DebuggerNonUserCode]
	protected override void f8F(bool Gy4)
	{
		try
		{
			if (Gy4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Gy4);
		}
	}

	[DebuggerStepThrough]
	private void Nc3()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.DarkOrange);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)1);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)Button1).set_Location(new Point(0, 0));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(199, 57));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("View more");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("buttonCtrl");
		((Control)this).set_Size(new Size(199, 57));
		((Control)this).ResumeLayout(false);
	}
}
