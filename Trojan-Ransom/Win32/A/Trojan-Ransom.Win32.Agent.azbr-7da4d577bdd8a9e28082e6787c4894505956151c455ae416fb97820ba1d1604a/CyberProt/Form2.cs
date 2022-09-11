using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CyberProt;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer m_a;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	private Label b;

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return b;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			b = value;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x2000000);
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_a != null)
			{
				this.m_a.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void a()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(84, 259));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(149, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("0.0.0.0");
		Label1.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Maroon);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)4);
		((Form)this).set_ClientSize(new Size(320, 320));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Cyber Prot");
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.Maroon);
		((Control)this).ResumeLayout(false);
	}

	public Form2()
	{
		((Form)this).add_Load((EventHandler)a);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		a();
	}

	private void a(object sender, EventArgs e)
	{
		Label1.set_Text(((Control)this).get_ProductVersion());
	}
}
