using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer17 : Installer
{
	private IContainer components;

	public Installer17()
	{
		InitializeComponent();
	}

	internal static int Bng()
	{
		return Installer8.I % Installer16.Gby.Length;
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
