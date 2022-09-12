using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace g2B;

[DesignerGenerated]
public class Pa7 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("LogoPictureBox")]
	internal virtual PictureBox LogoPictureBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameLabel")]
	internal virtual Label UsernameLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordLabel")]
	internal virtual Label PasswordLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameTextBox")]
	internal virtual TextBox UsernameTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordTextBox")]
	internal virtual TextBox PasswordTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s7B;
			Button oK = _OK;
			if (oK != null)
			{
				((Control)oK).remove_Click(eventHandler);
			}
			_OK = value;
			oK = _OK;
			if (oK != null)
			{
				((Control)oK).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Cancel
	{
		[CompilerGenerated]
		get
		{
			return _Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Pr1;
			Button cancel = _Cancel;
			if (cancel != null)
			{
				((Control)cancel).remove_Click(eventHandler);
			}
			_Cancel = value;
			cancel = _Cancel;
			if (cancel != null)
			{
				((Control)cancel).add_Click(eventHandler);
			}
		}
	}

	public Pa7()
	{
		Hs1();
	}

	[DebuggerNonUserCode]
	protected override void p8M(bool n4F)
	{
		try
		{
			if (n4F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n4F);
		}
	}

	[DebuggerStepThrough]
	private void Hs1()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pa7));
		LogoPictureBox = new PictureBox();
		UsernameLabel = new Label();
		PasswordLabel = new Label();
		UsernameTextBox = new TextBox();
		PasswordTextBox = new TextBox();
		OK = new Button();
		Cancel = new Button();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		((Control)LogoPictureBox).set_Location(new Point(0, 0));
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		((Control)LogoPictureBox).set_Size(new Size(165, 193));
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)UsernameLabel).set_Location(new Point(172, 24));
		((Control)UsernameLabel).set_Name("UsernameLabel");
		((Control)UsernameLabel).set_Size(new Size(220, 23));
		((Control)UsernameLabel).set_TabIndex(0);
		UsernameLabel.set_Text("&User name");
		UsernameLabel.set_TextAlign((ContentAlignment)16);
		((Control)PasswordLabel).set_Location(new Point(172, 81));
		((Control)PasswordLabel).set_Name("PasswordLabel");
		((Control)PasswordLabel).set_Size(new Size(220, 23));
		((Control)PasswordLabel).set_TabIndex(2);
		PasswordLabel.set_Text("&Password");
		PasswordLabel.set_TextAlign((ContentAlignment)16);
		((Control)UsernameTextBox).set_Location(new Point(174, 44));
		((Control)UsernameTextBox).set_Name("UsernameTextBox");
		((Control)UsernameTextBox).set_Size(new Size(220, 20));
		((Control)UsernameTextBox).set_TabIndex(1);
		((Control)PasswordTextBox).set_Location(new Point(174, 101));
		((Control)PasswordTextBox).set_Name("PasswordTextBox");
		PasswordTextBox.set_PasswordChar('*');
		((Control)PasswordTextBox).set_Size(new Size(220, 20));
		((Control)PasswordTextBox).set_TabIndex(3);
		((Control)OK).set_Location(new Point(197, 161));
		((Control)OK).set_Name("OK");
		((Control)OK).set_Size(new Size(94, 23));
		((Control)OK).set_TabIndex(4);
		((ButtonBase)OK).set_Text("&OK");
		Cancel.set_DialogResult((DialogResult)2);
		((Control)Cancel).set_Location(new Point(300, 161));
		((Control)Cancel).set_Name("Cancel");
		((Control)Cancel).set_Size(new Size(94, 23));
		((Control)Cancel).set_TabIndex(5);
		((ButtonBase)Cancel).set_Text("&Cancel");
		((Form)this).set_AcceptButton((IButtonControl)(object)OK);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)Cancel);
		((Form)this).set_ClientSize(new Size(401, 192));
		((Control)this).get_Controls().Add((Control)(object)Cancel);
		((Control)this).get_Controls().Add((Control)(object)OK);
		((Control)this).get_Controls().Add((Control)(object)PasswordTextBox);
		((Control)this).get_Controls().Add((Control)(object)UsernameTextBox);
		((Control)this).get_Controls().Add((Control)(object)PasswordLabel);
		((Control)this).get_Controls().Add((Control)(object)UsernameLabel);
		((Control)this).get_Controls().Add((Control)(object)LogoPictureBox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LoginForm1");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("LoginForm1");
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void s7B(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Pr1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
