using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AQW_Level_bot;

[DesignerGenerated]
public class Help : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual Label Label1
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

	public Help()
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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Help));
		Label1 = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		Point location = new Point(13, 13);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(422, 115);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("1, Open the program and log in\r\n2, Go to \"hachiko\"\r\n3, Press F2 over Auto attack, Special one, two and three\r\n4, Press F2 over the \"Rest\" button.\r\n5, Press F3 to start the bot and F4 to stop it!");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(453, 159);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		size = new Size(469, 197);
		((Form)this).set_MaximumSize(size);
		size = new Size(469, 197);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Help");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Help");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
