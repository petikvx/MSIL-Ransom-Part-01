using System.ComponentModel;
using System.Configuration.Install;
using dsui.Properties;

namespace dsui;

[RunInstaller(true)]
public class Installer31 : Installer
{
	internal static string Stri = Resource1.Fvrwd;

	private IContainer components;

	public Installer31()
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
