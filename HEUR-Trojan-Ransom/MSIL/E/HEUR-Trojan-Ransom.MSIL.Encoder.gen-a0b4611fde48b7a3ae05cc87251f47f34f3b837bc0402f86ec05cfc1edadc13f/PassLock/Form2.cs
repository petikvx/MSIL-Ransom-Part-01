using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PassLock;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form2()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		TextBox1 = new TextBox();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(12, 12));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		((TextBoxBase)TextBox1).set_ShortcutsEnabled(false);
		((Control)TextBox1).set_Size(new Size(338, 59));
		((Control)TextBox1).set_TabIndex(0);
		TextBox1.set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((Control)Button1).set_Location(new Point(12, 77));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(338, 19));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("OK");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(362, 108));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("AES (Advanced Encryption Standard)");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
