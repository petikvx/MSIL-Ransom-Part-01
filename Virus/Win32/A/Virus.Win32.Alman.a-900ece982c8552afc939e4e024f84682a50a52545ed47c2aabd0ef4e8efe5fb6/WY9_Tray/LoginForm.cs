using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WY9_Tray;

[DesignerGenerated]
public class LoginForm : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("LogoPictureBox")]
	private PictureBox _LogoPictureBox;

	[AccessedThroughProperty("UsernameLabel")]
	private Label _UsernameLabel;

	[AccessedThroughProperty("PasswordLabel")]
	private Label _PasswordLabel;

	[AccessedThroughProperty("UsernameTextBox")]
	private TextBox _UsernameTextBox;

	[AccessedThroughProperty("PasswordTextBox")]
	private TextBox _PasswordTextBox;

	[AccessedThroughProperty("OK")]
	private Button _OK;

	[AccessedThroughProperty("Cancel")]
	private Button _Cancel;

	private IContainer components;

	internal virtual PictureBox LogoPictureBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _LogoPictureBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LogoPictureBox = value;
		}
	}

	internal virtual Label UsernameLabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _UsernameLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UsernameLabel = value;
		}
	}

	internal virtual Label PasswordLabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasswordLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PasswordLabel = value;
		}
	}

	internal virtual TextBox UsernameTextBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _UsernameTextBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UsernameTextBox = value;
		}
	}

	internal virtual TextBox PasswordTextBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasswordTextBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PasswordTextBox = value;
		}
	}

	internal virtual Button OK
	{
		[DebuggerNonUserCode]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OK_Click;
			if (_OK != null)
			{
				((Control)_OK).remove_Click(eventHandler);
			}
			_OK = value;
			if (_OK != null)
			{
				((Control)_OK).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Cancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Cancel_Click;
			if (_Cancel != null)
			{
				((Control)_Cancel).remove_Click(eventHandler);
			}
			_Cancel = value;
			if (_Cancel != null)
			{
				((Control)_Cancel).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public LoginForm()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LoginForm));
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
		PictureBox logoPictureBox = LogoPictureBox;
		Point location = new Point(0, 0);
		((Control)logoPictureBox).set_Location(location);
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		PictureBox logoPictureBox2 = LogoPictureBox;
		Size size = new Size(165, 193);
		((Control)logoPictureBox2).set_Size(size);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		Label usernameLabel = UsernameLabel;
		location = new Point(172, 24);
		((Control)usernameLabel).set_Location(location);
		((Control)UsernameLabel).set_Name("UsernameLabel");
		Label usernameLabel2 = UsernameLabel;
		size = new Size(220, 23);
		((Control)usernameLabel2).set_Size(size);
		((Control)UsernameLabel).set_TabIndex(0);
		UsernameLabel.set_Text("用户名(&U)");
		UsernameLabel.set_TextAlign((ContentAlignment)16);
		Label passwordLabel = PasswordLabel;
		location = new Point(172, 81);
		((Control)passwordLabel).set_Location(location);
		((Control)PasswordLabel).set_Name("PasswordLabel");
		Label passwordLabel2 = PasswordLabel;
		size = new Size(220, 23);
		((Control)passwordLabel2).set_Size(size);
		((Control)PasswordLabel).set_TabIndex(2);
		PasswordLabel.set_Text("密码(&P)");
		PasswordLabel.set_TextAlign((ContentAlignment)16);
		TextBox usernameTextBox = UsernameTextBox;
		location = new Point(174, 44);
		((Control)usernameTextBox).set_Location(location);
		((Control)UsernameTextBox).set_Name("UsernameTextBox");
		TextBox usernameTextBox2 = UsernameTextBox;
		size = new Size(220, 21);
		((Control)usernameTextBox2).set_Size(size);
		((Control)UsernameTextBox).set_TabIndex(1);
		TextBox passwordTextBox = PasswordTextBox;
		location = new Point(174, 101);
		((Control)passwordTextBox).set_Location(location);
		((Control)PasswordTextBox).set_Name("PasswordTextBox");
		PasswordTextBox.set_PasswordChar('*');
		TextBox passwordTextBox2 = PasswordTextBox;
		size = new Size(220, 21);
		((Control)passwordTextBox2).set_Size(size);
		((Control)PasswordTextBox).set_TabIndex(3);
		Button oK = OK;
		location = new Point(197, 161);
		((Control)oK).set_Location(location);
		((Control)OK).set_Name("OK");
		Button oK2 = OK;
		size = new Size(94, 23);
		((Control)oK2).set_Size(size);
		((Control)OK).set_TabIndex(4);
		((ButtonBase)OK).set_Text("确定(&O)");
		Cancel.set_DialogResult((DialogResult)2);
		Button cancel = Cancel;
		location = new Point(300, 161);
		((Control)cancel).set_Location(location);
		((Control)Cancel).set_Name("Cancel");
		Button cancel2 = Cancel;
		size = new Size(94, 23);
		((Control)cancel2).set_Size(size);
		((Control)Cancel).set_TabIndex(5);
		((ButtonBase)Cancel).set_Text("取消(&C)");
		((Form)this).set_AcceptButton((IButtonControl)(object)OK);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)Cancel);
		size = new Size(401, 192);
		((Form)this).set_ClientSize(size);
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
		((Control)this).set_Name("LoginForm");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("LoginForm");
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void OK_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Cancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
