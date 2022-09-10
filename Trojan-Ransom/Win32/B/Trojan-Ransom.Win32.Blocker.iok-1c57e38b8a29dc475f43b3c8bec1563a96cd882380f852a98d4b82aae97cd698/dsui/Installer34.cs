using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer34 : Installer
{
	private IContainer components;

	public Installer34()
	{
		InitializeComponent();
	}

	internal static int Ddfe()
	{
		return Installer24.Asqe() % 256;
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
