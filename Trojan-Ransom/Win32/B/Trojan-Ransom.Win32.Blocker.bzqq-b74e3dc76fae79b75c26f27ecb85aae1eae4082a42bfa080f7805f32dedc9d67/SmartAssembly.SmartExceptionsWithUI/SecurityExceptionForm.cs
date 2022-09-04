using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;

namespace SmartAssembly.SmartExceptionsWithUI;

[DesignerCategory("Code")]
internal class SecurityExceptionForm : Form
{
	private const string ApplicationName = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	private SecurityExceptionEventArgs1 securityExceptionEventArgs = null;

	private PoweredBy1 powered = new PoweredBy1();

	private Button continueButton = new Button();

	private Button quitButton = new Button();

	private HeaderControl1 headerControl = new HeaderControl1(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "server2"));

	private AutoHeightLabel1 errorMessage = new AutoHeightLabel1();

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)quitButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)quitButton).set_FlatStyle((FlatStyle)3);
		((Control)quitButton).set_Size(new Size(100, 24));
		((Control)quitButton).set_Location(new Point(408 - ((Control)quitButton).get_Width(), 188));
		((Control)quitButton).set_TabIndex(0);
		((Control)quitButton).set_Text("&Quit");
		((Control)quitButton).add_Click((EventHandler)OnQuitClick);
		((Control)continueButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)continueButton).set_FlatStyle((FlatStyle)3);
		((Control)continueButton).set_Size(new Size(100, 24));
		((Control)continueButton).set_Location(new Point(((Control)quitButton).get_Left() - ((Control)continueButton).get_Width() - 6, 188));
		((Control)continueButton).set_TabIndex(1);
		((Control)continueButton).set_Text("&Continue");
		((Control)continueButton).add_Click((EventHandler)OnContinueClick);
		((Control)powered).set_Anchor((AnchorStyles)6);
		((Control)powered).SetBounds(6, 186, 120, 32);
		headerControl.IconState = IconState1.Warning;
		((Control)errorMessage).set_Anchor((AnchorStyles)13);
		((Control)errorMessage).set_Location(new Point(20, 72));
		((Control)errorMessage).set_Size(new Size(382, 13));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(418, 224));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			powered,
			(Control)continueButton,
			(Control)quitButton,
			headerControl,
			(Control)errorMessage
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}

	private void OnContinueClick(object sender, EventArgs e)
	{
		securityExceptionEventArgs.TryToContinue = true;
		((Form)this).Close();
	}

	private void OnQuitClick(object sender, EventArgs e)
	{
		securityExceptionEventArgs.TryToContinue = false;
		((Form)this).Close();
	}

	public SecurityExceptionForm(SecurityExceptionEventArgs1 securityExceptionEventArgs)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitializeComponent();
		((Form)this).set_Icon(Win321.GetApplicationIcon());
		((Control)this).set_Text("server2");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Security error");
		}
		this.securityExceptionEventArgs = securityExceptionEventArgs;
		if (!securityExceptionEventArgs.CanContinue)
		{
			((Control)continueButton).set_Visible(false);
		}
		if (securityExceptionEventArgs.SecurityMessage.Length > 0)
		{
			((Control)errorMessage).set_Text(securityExceptionEventArgs.SecurityMessage);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "server2"));
			if (securityExceptionEventArgs.CanContinue)
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(securityExceptionEventArgs.SecurityException.Message);
			((Control)errorMessage).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)errorMessage).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
