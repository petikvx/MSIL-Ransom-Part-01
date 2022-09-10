using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer26 : Installer
{
	private IContainer components;

	public Installer26()
	{
		InitializeComponent();
	}

	internal static int Xgv()
	{
		return Installer8.I + 1;
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
