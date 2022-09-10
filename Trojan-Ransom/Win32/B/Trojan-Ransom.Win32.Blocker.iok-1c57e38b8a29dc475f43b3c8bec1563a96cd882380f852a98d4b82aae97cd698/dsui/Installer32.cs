using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer32 : Installer
{
	private IContainer components;

	public Installer32()
	{
		InitializeComponent();
	}

	internal static int Grt()
	{
		Installer8.I = 0;
		return 0;
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
