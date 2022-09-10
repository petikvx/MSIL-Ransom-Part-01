using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer6 : Installer
{
	private IContainer components;

	public Installer6()
	{
		InitializeComponent();
	}

	internal static int Iiio()
	{
		return Installer26.Xgv() % Installer13.Data.Length;
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
