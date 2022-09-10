using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer10 : Installer
{
	private IContainer components;

	public Installer10()
	{
		InitializeComponent();
	}

	internal static int Kkjgy()
	{
		return Convert.ToChar(Installer3.Gjgft());
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
