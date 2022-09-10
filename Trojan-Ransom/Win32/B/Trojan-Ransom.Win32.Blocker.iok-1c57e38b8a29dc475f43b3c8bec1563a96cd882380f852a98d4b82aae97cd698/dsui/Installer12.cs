using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer12 : Installer
{
	private IContainer components;

	public Installer12()
	{
		InitializeComponent();
	}

	internal static bool Onf()
	{
		return Installer8.I <= Installer25.Klluhk();
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
