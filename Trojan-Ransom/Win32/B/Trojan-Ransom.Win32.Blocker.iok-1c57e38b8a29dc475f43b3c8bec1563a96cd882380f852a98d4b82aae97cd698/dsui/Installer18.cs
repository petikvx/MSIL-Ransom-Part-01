using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer18 : Installer
{
	private IContainer components;

	public Installer18()
	{
		InitializeComponent();
	}

	internal static int Vfddg()
	{
		return Installer10.Kkjgy() - Installer22.Jttu();
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
