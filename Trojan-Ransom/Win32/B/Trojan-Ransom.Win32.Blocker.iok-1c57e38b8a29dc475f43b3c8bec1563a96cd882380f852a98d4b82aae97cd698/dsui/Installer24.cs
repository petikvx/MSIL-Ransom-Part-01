using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer24 : Installer
{
	private IContainer components;

	public Installer24()
	{
		InitializeComponent();
	}

	internal static int Asqe()
	{
		return Installer18.Vfddg() + 256;
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
