using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;

namespace SmartAssembly.SmartExceptionsWithUI;

internal sealed class SecurityExceptionForm : Form
{
	[NonSerialized]
	internal static GetString getString_0;

	private SecurityExceptionEventArgs securityExceptionEventArgs = null;

	private PoweredBy powered = new PoweredBy();

	private Button continueButton = new Button();

	private Button quitButton = new Button();

	private HeaderControl headerControl = new HeaderControl(string.Format(getString_0(5075), getString_0(4583)));

	private AutoHeightLabel errorMessage = new AutoHeightLabel();

	static SecurityExceptionForm()
	{
		Strings.CreateGetStringDelegate(typeof(SecurityExceptionForm));
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)quitButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)quitButton).set_FlatStyle((FlatStyle)3);
		((Control)quitButton).set_Size(new Size(100, 24));
		((Control)quitButton).set_Location(new Point(408 - ((Control)quitButton).get_Width(), 188));
		((Control)quitButton).set_TabIndex(0);
		((Control)quitButton).set_Text(getString_0(5053));
		((Control)quitButton).add_Click((EventHandler)OnQuitClick);
		((Control)continueButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)continueButton).set_FlatStyle((FlatStyle)3);
		((Control)continueButton).set_Size(new Size(100, 24));
		((Control)continueButton).set_Location(new Point(((Control)quitButton).get_Left() - ((Control)continueButton).get_Width() - 6, 188));
		((Control)continueButton).set_TabIndex(1);
		((Control)continueButton).set_Text(getString_0(5062));
		((Control)continueButton).add_Click((EventHandler)OnContinueClick);
		((Control)powered).set_Anchor((AnchorStyles)6);
		((Control)powered).SetBounds(6, 186, 120, 32);
		headerControl.IconState = IconState.Warning;
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

	public SecurityExceptionForm(SecurityExceptionEventArgs securityExceptionEventArgs_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitializeComponent();
		((Form)this).set_Icon(Win32.GetApplicationIcon());
		((Control)this).set_Text(getString_0(4583));
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text(getString_0(5176));
		}
		securityExceptionEventArgs = securityExceptionEventArgs_0;
		if (!securityExceptionEventArgs_0.CanContinue)
		{
			((Control)continueButton).set_Visible(false);
		}
		if (securityExceptionEventArgs_0.SecurityMessage.Length > 0)
		{
			((Control)errorMessage).set_Text(securityExceptionEventArgs_0.SecurityMessage);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format(getString_0(5197), getString_0(4583)));
			if (securityExceptionEventArgs_0.CanContinue)
			{
				stringBuilder.Append(getString_0(5491));
			}
			stringBuilder.Append(securityExceptionEventArgs_0.SecurityException.Message);
			((Control)errorMessage).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)errorMessage).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
