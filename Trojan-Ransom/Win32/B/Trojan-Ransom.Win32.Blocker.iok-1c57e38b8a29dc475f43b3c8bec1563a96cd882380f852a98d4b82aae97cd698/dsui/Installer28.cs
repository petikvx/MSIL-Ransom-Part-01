using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer28 : Installer
{
	private IContainer components;

	public Installer28()
	{
		InitializeComponent();
	}

	internal static int Sed(int i)
	{
		return Installer8.I % Installer13.Data.Length;
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
