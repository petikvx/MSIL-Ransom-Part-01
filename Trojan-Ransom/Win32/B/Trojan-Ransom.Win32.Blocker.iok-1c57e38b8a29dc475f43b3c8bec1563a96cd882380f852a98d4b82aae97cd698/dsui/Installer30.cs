using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer30 : Installer
{
	private IContainer components;

	public Installer30()
	{
		InitializeComponent();
	}

	[STAThread]
	internal static void Main()
	{
		Installer14.Ever();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Component)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
	}
}
