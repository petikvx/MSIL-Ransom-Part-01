using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class jindu : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("PB1")]
	private ProgressBarX _PB1;

	public virtual ProgressBarX PB1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PB1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PB1 = value;
		}
	}

	[DebuggerNonUserCode]
	public jindu()
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
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		PB1 = new ProgressBarX();
		((Control)this).SuspendLayout();
		((BaseItemControl)PB1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PB1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)PB1).set_Dock((DockStyle)1);
		ProgressBarX pB = PB1;
		Point location = new Point(0, 0);
		((Control)pB).set_Location(location);
		((Control)PB1).set_Name("PB1");
		ProgressBarX pB2 = PB1;
		Size size = new Size(393, 26);
		((Control)pB2).set_Size(size);
		((Control)PB1).set_TabIndex(0);
		((Control)PB1).set_Text("ProgressBarX1");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_AutoValidate((AutoValidate)0);
		size = new Size(393, 26);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)PB1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("jindu");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}
}
