using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer25 : Installer
{
	private IContainer components;

	public Installer25()
	{
		InitializeComponent();
	}

	internal static int Klluhk()
	{
		return Installer13.Data.Length;
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
