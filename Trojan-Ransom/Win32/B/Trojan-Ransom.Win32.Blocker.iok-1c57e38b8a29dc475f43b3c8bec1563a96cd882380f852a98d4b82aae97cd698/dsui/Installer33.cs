using System.ComponentModel;
using System.Configuration.Install;

namespace dsui;

[RunInstaller(true)]
public class Installer33 : Installer
{
	private IContainer components;

	public Installer33()
	{
		InitializeComponent();
	}

	internal static string Rk()
	{
		return "fddgr.jgrp";
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
