using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Srv_Lock;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	internal virtual WebBrowser WebBrowser1
	{
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WebBrowser1 = value;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		WebBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 0);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(787, 406);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(787, 406);
		((Form)this).set_ClientSize(minimumSize);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Get Key");
		((Control)this).ResumeLayout(false);
	}
}
