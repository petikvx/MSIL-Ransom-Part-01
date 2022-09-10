using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace FC2ServerLauncher;

public class AboutForm : Form
{
	private IContainer components;

	private Label copyrightLabel;

	private Label productLabel;

	private Label versionLabel;

	private Button okButton;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutForm));
		copyrightLabel = new Label();
		productLabel = new Label();
		versionLabel = new Label();
		okButton = new Button();
		((Control)this).SuspendLayout();
		((Control)copyrightLabel).set_Location(new Point(7, 35));
		((Control)copyrightLabel).set_Name("copyrightLabel");
		((Control)copyrightLabel).set_Size(new Size(308, 13));
		((Control)copyrightLabel).set_TabIndex(0);
		((Control)copyrightLabel).set_Text("Copyright");
		copyrightLabel.set_TextAlign((ContentAlignment)2);
		((Control)productLabel).set_Location(new Point(31, 9));
		((Control)productLabel).set_Name("productLabel");
		((Control)productLabel).set_Size(new Size(261, 13));
		((Control)productLabel).set_TabIndex(1);
		((Control)productLabel).set_Text("Product");
		productLabel.set_TextAlign((ContentAlignment)2);
		((Control)versionLabel).set_Location(new Point(28, 22));
		((Control)versionLabel).set_Name("versionLabel");
		((Control)versionLabel).set_Size(new Size(266, 13));
		((Control)versionLabel).set_TabIndex(2);
		((Control)versionLabel).set_Text("Version");
		versionLabel.set_TextAlign((ContentAlignment)2);
		((Control)okButton).set_Location(new Point(124, 61));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(75, 23));
		((Control)okButton).set_TabIndex(3);
		((Control)okButton).set_Text("OK");
		((ButtonBase)okButton).set_UseVisualStyleBackColor(true);
		((Control)okButton).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(327, 95));
		((Control)this).get_Controls().Add((Control)(object)okButton);
		((Control)this).get_Controls().Add((Control)(object)versionLabel);
		((Control)this).get_Controls().Add((Control)(object)productLabel);
		((Control)this).get_Controls().Add((Control)(object)copyrightLabel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutForm");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("About Far Cry® 2 Server Launcher");
		((Control)this).ResumeLayout(false);
	}

	public AboutForm()
	{
		InitializeComponent();
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		((Control)productLabel).set_Text(Application.get_ProductName());
		((Control)versionLabel).set_Text("Version: " + Application.get_ProductVersion());
		((Control)copyrightLabel).set_Text(((AssemblyCopyrightAttribute)entryAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), inherit: false)[0]).Copyright);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)1);
	}
}
