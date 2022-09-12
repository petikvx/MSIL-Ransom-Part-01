using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vdeecydkkhkntspg;

namespace Mauiipecjzet;

public class Form1 : Form
{
	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Update2()
	{
		Sched.Instance.Update();
	}

	private IEnumerator Init()
	{
		foreach (string item in Script())
		{
			Console.WriteLine(item);
			Console.WriteLine();
			int seconds = item.Split(new char[1] { ' ' }).Length / 10 + 3;
			Console.WriteLine("[Waiting for " + seconds + " seconds]");
			yield return Sched.Instance.StartCoroutine(WaitAboutSeconds(seconds));
		}
	}

	private IEnumerator WaitAboutSeconds(int seconds)
	{
		int timer = DateTime.Now.Second + seconds;
		while (DateTime.Now.Second <= timer)
		{
			yield return null;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		new Form2().One();
		new Form3();
		A();
		Sched.Instance.StartCoroutine(Init());
		while (true)
		{
			Update2();
		}
	}

	private void A()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
	}

	private IEnumerable<string> Script()
	{
		yield return "Their first meeting";
		yield return "Over the last nine seasons of The Big Bang Theory, we've loved watching Sheldon and Leonard's bromance blossom, and their bond only seems to grow stronger as the years pass.";
		yield return "Let's take a look back at the tumultuous—but always entertaining—friendship of these brainy pals.";
		yield return "Although fans didn’t witness the guys' first meeting until Season 3 (Episode 22, \"The Staircase Implementation\"), we learned that Leonard was introduced to Sheldon after looking for a room to rent near Caltech. And while he was warned by former roommates and neighbors of the theoretical physicist that Sheldon was crazy, Leonard proceeded through the extensive interview process and roommate agreement before eventually moving in.";
		yield return "The End";
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
