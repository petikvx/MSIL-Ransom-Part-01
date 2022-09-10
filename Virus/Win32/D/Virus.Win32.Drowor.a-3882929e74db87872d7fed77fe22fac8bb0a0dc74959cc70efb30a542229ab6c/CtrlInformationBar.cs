using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class CtrlInformationBar : UserControl
{
	private CtrlLogin.GDelegate2 gdelegate2_0;

	private IContainer icontainer_0;

	private Label lblStatus;

	private FlowLayoutPanel flpInformationBar;

	private Button btnLoginOff;

	private Label lblInformation;

	private Label lblLoginInfo;

	private GClass9 customPanel1;

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(CtrlLogin.GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (CtrlLogin.GDelegate2)Delegate.Combine(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(CtrlLogin.GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (CtrlLogin.GDelegate2)Delegate.Remove(gdelegate2_0, gdelegate2_1);
	}

	public CtrlInformationBar()
	{
		InitializeComponent();
		method_5();
	}

	private void btnLoginOff_Click(object sender, EventArgs e)
	{
		method_2();
	}

	public void method_2()
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)btnLoginOff).get_Text() == "Login")
		{
			Login login = new Login();
			((Form)login).set_StartPosition((FormStartPosition)0);
			login.method_0(method_3);
			if (gdelegate2_0 != null)
			{
				login.method_0(gdelegate2_0);
			}
			if (((ContainerControl)this).get_ParentForm() != null)
			{
				int x = ((ContainerControl)this).get_ParentForm().get_Location().X + (int)((double)((Control)((ContainerControl)this).get_ParentForm()).get_Width() * 0.5 - (double)((Control)login).get_Width() * 0.5);
				int y = ((ContainerControl)this).get_ParentForm().get_Location().Y + (int)((double)((Control)((ContainerControl)this).get_ParentForm()).get_Height() * 0.5 - (double)((Control)login).get_Height() * 0.5);
				((Form)login).set_Location(new Point(x, y));
			}
			((Form)login).ShowDialog();
		}
		else
		{
			GClass6 gClass = new GClass6();
			if (gClass.method_21())
			{
				method_5();
				MessageBox.Show("Logout was successful.");
			}
			else
			{
				method_5();
			}
		}
	}

	protected void method_3(string string_0, string string_1, string string_2)
	{
		switch (string_0)
		{
		case "Failed":
			method_5();
			break;
		case "Success":
			method_4();
			method_6(string_1, string_2);
			break;
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaint(paintEventArgs_0);
		RectangleF visibleClipBounds = paintEventArgs_0.get_Graphics().get_VisibleClipBounds();
		paintEventArgs_0.get_Graphics().DrawLine(Pens.get_LightGray(), 0f, 0f, visibleClipBounds.Right, 0f);
		paintEventArgs_0.get_Graphics().DrawLine(Pens.get_LightGray(), 0f, visibleClipBounds.Bottom - 1f, visibleClipBounds.Right, visibleClipBounds.Bottom - 1f);
	}

	public void method_4()
	{
		((Control)lblStatus).set_Text("Online");
		((Control)lblStatus).set_ForeColor(Color.Green);
		((Control)btnLoginOff).set_Text("Logout");
	}

	public void method_5()
	{
		((Control)lblStatus).set_Text("Offline");
		((Control)lblStatus).set_ForeColor(Color.DarkRed);
		method_7();
		((Control)btnLoginOff).set_Text("Login");
		if (gdelegate2_0 != null)
		{
			gdelegate2_0("Failed", "", "");
		}
	}

	public void method_6(string string_0, string string_1)
	{
		((Control)lblLoginInfo).set_Text(string_0 + "  -  " + string_1);
	}

	public void method_7()
	{
		((Control)lblLoginInfo).set_Text("Please login to use CS Crop Finder.");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		customPanel1 = new GClass9();
		flpInformationBar = new FlowLayoutPanel();
		lblStatus = new Label();
		lblInformation = new Label();
		lblLoginInfo = new Label();
		btnLoginOff = new Button();
		((Control)customPanel1).SuspendLayout();
		((Control)flpInformationBar).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)customPanel1).set_Anchor((AnchorStyles)15);
		customPanel1.method_1(SystemColors.ControlLightLight);
		customPanel1.method_3(Color.Transparent);
		customPanel1.method_9(Color.FromArgb(0, 192, 0));
		customPanel1.method_7((BorderStyle)1);
		((Control)customPanel1).get_Controls().Add((Control)(object)flpInformationBar);
		((Control)customPanel1).get_Controls().Add((Control)(object)btnLoginOff);
		customPanel1.method_13(10);
		((Control)customPanel1).set_Location(new Point(0, 0));
		((Control)customPanel1).set_Name("customPanel1");
		((Control)customPanel1).set_Size(new Size(606, 28));
		((Control)customPanel1).set_TabIndex(3);
		((Control)flpInformationBar).set_Anchor((AnchorStyles)15);
		((Control)flpInformationBar).get_Controls().Add((Control)(object)lblStatus);
		((Control)flpInformationBar).get_Controls().Add((Control)(object)lblInformation);
		((Control)flpInformationBar).get_Controls().Add((Control)(object)lblLoginInfo);
		((Control)flpInformationBar).set_Location(new Point(12, 3));
		((Control)flpInformationBar).set_Name("flpInformationBar");
		((Control)flpInformationBar).set_Padding(new Padding(2));
		((Control)flpInformationBar).set_Size(new Size(483, 22));
		((Control)flpInformationBar).set_TabIndex(1);
		((Control)lblStatus).set_AutoSize(true);
		((Control)lblStatus).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblStatus).set_ForeColor(Color.Maroon);
		((Control)lblStatus).set_Location(new Point(5, 2));
		((Control)lblStatus).set_Name("lblStatus");
		((Control)lblStatus).set_Size(new Size(58, 19));
		((Control)lblStatus).set_TabIndex(0);
		((Control)lblStatus).set_Text("Offline");
		((Control)lblInformation).set_AutoSize(true);
		((Control)lblInformation).set_Font(new Font("Arial", 11f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblInformation).set_Location(new Point(69, 2));
		((Control)lblInformation).set_Name("lblInformation");
		((Control)lblInformation).set_Size(new Size(13, 18));
		((Control)lblInformation).set_TabIndex(1);
		((Control)lblInformation).set_Text("-");
		((Control)lblLoginInfo).set_AutoSize(true);
		((Control)lblLoginInfo).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblLoginInfo).set_ForeColor(Color.FromArgb(64, 0, 0));
		((Control)lblLoginInfo).set_Location(new Point(88, 2));
		((Control)lblLoginInfo).set_Name("lblLoginInfo");
		((Control)lblLoginInfo).set_Size(new Size(0, 19));
		((Control)lblLoginInfo).set_TabIndex(2);
		((Control)btnLoginOff).set_Anchor((AnchorStyles)9);
		((ButtonBase)btnLoginOff).get_FlatAppearance().set_BorderColor(Color.FromArgb(224, 224, 224));
		((ButtonBase)btnLoginOff).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(192, 192, 255));
		((Control)btnLoginOff).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnLoginOff).set_ForeColor(Color.Green);
		((Control)btnLoginOff).set_Location(new Point(501, 3));
		((Control)btnLoginOff).set_Name("btnLoginOff");
		((Control)btnLoginOff).set_Size(new Size(88, 23));
		((Control)btnLoginOff).set_TabIndex(2);
		((Control)btnLoginOff).set_Text("Login");
		((ButtonBase)btnLoginOff).set_UseVisualStyleBackColor(false);
		((Control)btnLoginOff).add_Click((EventHandler)btnLoginOff_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)customPanel1);
		((Control)this).set_Name("CtrlInformationBar");
		((Control)this).set_Size(new Size(606, 28));
		((Control)customPanel1).ResumeLayout(false);
		((Control)flpInformationBar).ResumeLayout(false);
		((Control)flpInformationBar).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
