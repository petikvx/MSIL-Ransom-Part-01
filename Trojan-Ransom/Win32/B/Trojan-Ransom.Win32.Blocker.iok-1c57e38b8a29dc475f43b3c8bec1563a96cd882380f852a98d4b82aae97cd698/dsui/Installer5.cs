using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer5 : Installer
{
	private IContainer components;

	public Installer5()
	{
		InitializeComponent();
	}

	internal static void Jgvu()
	{
		Installer13.Data[Installer28.Sed(Installer8.I)] = Convert.ToByte(Installer34.Ddfe());
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
