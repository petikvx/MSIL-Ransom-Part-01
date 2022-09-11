using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Qhvqj;

public class Form4 : Form
{
	internal Type Type;

	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private string Data => "Fbeprgcpexzrt.Zinysqkbxvcpkqhouyz";

	public Form4()
	{
		InitializeComponent();
		Win();
	}

	internal void Pc()
	{
		Win();
	}

	private void Win()
	{
		if (Type == null)
		{
			Type = new Form3().assembly.GetType(Data);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(0, 0));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(140, 60));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(146, 0));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(140, 60));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(0, 66));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(140, 60));
		((Control)button3).set_TabIndex(2);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(146, 66));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(140, 60));
		((Control)button4).set_TabIndex(3);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(663, 337));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form4");
		((Control)this).set_Text("Form4");
		((Control)this).ResumeLayout(false);
	}
}
