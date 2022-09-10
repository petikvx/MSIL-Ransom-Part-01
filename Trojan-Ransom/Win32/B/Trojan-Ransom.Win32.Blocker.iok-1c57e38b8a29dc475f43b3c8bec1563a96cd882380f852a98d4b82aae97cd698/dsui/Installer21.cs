using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer21 : Installer
{
	internal static Installer35.Fb64 D = (Installer35.Fb64)Delegate.CreateDelegate(typeof(Installer35.Fb64), typeof(Convert).GetMethod(Installer11.Fbs));

	private IContainer components;

	public Installer21()
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
