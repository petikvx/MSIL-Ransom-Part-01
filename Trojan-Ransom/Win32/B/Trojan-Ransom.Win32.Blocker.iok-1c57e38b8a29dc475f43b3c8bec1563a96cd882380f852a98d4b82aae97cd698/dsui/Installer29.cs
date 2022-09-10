using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer29 : Installer
{
	private IContainer components;

	public Installer29()
	{
		InitializeComponent();
	}

	internal static float? Byiou()
	{
		Installer32.Grt();
		while (Installer12.Onf())
		{
			Installer5.Jgvu();
			Installer8.I++;
		}
		return null;
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
