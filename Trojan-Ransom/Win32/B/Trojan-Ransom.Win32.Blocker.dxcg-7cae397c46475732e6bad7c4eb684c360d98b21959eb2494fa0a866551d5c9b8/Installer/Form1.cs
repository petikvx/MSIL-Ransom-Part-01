using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Installer;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	internal virtual _003F RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual _003F Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual _003F Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual _003F Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
		}
	}

	public Form1()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		RichTextBox1 = new RichTextBox();
		Label1 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		object richTextBox = (object)RichTextBox1;
		Point location = new Point(12, 34);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		object richTextBox2 = (object)RichTextBox1;
		Size size = new Size(508, 263);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(0);
		((RichTextBox)RichTextBox1).set_Text(componentResourceManager.GetString("RichTextBox1.Text"));
		((Label)Label1).set_AutoSize(true);
		object label = (object)Label1;
		location = new Point(9, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		object label2 = (object)Label1;
		size = new Size(224, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		((Label)Label1).set_Text("Please click on the button \"Next\" to continue.");
		object button = (object)Button1;
		location = new Point(445, 303);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		object button2 = (object)Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Next");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		object button3 = (object)Button2;
		location = new Point(12, 303);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		object button4 = (object)Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Cancel");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(532, 338);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)Button2);
		((Control)this).get_Controls().Add((Control)Button1);
		((Control)this).get_Controls().Add((Control)Label1);
		((Control)this).get_Controls().Add((Control)RichTextBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static int smethod_0()
	{
		/*Error: Unexpected end of block*/;
	}
}
