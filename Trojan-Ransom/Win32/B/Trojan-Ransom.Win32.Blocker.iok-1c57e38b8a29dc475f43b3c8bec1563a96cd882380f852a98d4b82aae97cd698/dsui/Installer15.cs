using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer15 : Installer
{
	private IContainer components;

	internal static Installer23.LoadAssembly LoadAssembly => (Installer23.LoadAssembly)Installer36.Cd();

	public Installer15()
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
