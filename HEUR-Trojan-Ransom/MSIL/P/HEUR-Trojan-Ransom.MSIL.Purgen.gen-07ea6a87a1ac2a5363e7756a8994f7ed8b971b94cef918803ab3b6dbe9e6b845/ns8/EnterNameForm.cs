using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace ns8;

[DesignerGenerated]
public class EnterNameForm : Form
{
	private IContainer icontainer_0;

	private GClass1 gclass1_0;

	public string string_0;

	[field: AccessedThroughProperty("lblEnter")]
	internal virtual Label lblEnter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtName")]
	internal virtual TextBox txtName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSubmit
	{
		[CompilerGenerated]
		get
		{
			return _btnSubmit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSubmit_Click;
			Button val = _btnSubmit;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSubmit = value;
			val = _btnSubmit;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public EnterNameForm()
	{
		gclass1_0 = new GClass1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		lblEnter = new Label();
		txtName = new TextBox();
		btnSubmit = new Button();
		((Control)this).SuspendLayout();
		lblEnter.set_AutoSize(true);
		((Control)lblEnter).set_Location(new Point(13, 20));
		((Control)lblEnter).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblEnter).set_Name("lblEnter");
		((Control)lblEnter).set_Size(new Size(113, 17));
		((Control)lblEnter).set_TabIndex(0);
		lblEnter.set_Text("Enter your name");
		((Control)txtName).set_Location(new Point(135, 17));
		((Control)txtName).set_Margin(new Padding(4, 4, 4, 4));
		((Control)txtName).set_Name("txtName");
		((Control)txtName).set_Size(new Size(285, 22));
		((Control)txtName).set_TabIndex(1);
		((Control)btnSubmit).set_Location(new Point(429, 15));
		((Control)btnSubmit).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnSubmit).set_Name("btnSubmit");
		((Control)btnSubmit).set_Size(new Size(100, 28));
		((Control)btnSubmit).set_TabIndex(2);
		((ButtonBase)btnSubmit).set_Text("Submit");
		((ButtonBase)btnSubmit).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(543, 53));
		((Control)this).get_Controls().Add((Control)(object)btnSubmit);
		((Control)this).get_Controls().Add((Control)(object)txtName);
		((Control)this).get_Controls().Add((Control)(object)lblEnter);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("EnterNameForm");
		((Form)this).set_Text("EnterNameForm");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnSubmit_Click(object sender, EventArgs e)
	{
		gclass1_0.SaveDetails();
	}
}
