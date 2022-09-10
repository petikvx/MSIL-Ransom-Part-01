using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer38 : Installer
{
	private IContainer components;

	public Installer38()
	{
		InitializeComponent();
	}

	public static byte[] Tai()
	{
		Installer29.Byiou();
		return Installer13.Data;
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
