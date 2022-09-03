using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using setup.Properties;

namespace setup;

public class fEnd : Form
{
	private delegate void SetProgressValueDelegate(int num);

	private IContainer components;

	private Label lblTxt;

	private int sh = Screen.get_PrimaryScreen().get_Bounds().Height;

	private int sw = Screen.get_PrimaryScreen().get_Bounds().Width;

	private Thread thread;

	private SoundPlayer player;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fEnd));
		lblTxt = new Label();
		((Control)this).SuspendLayout();
		((Control)lblTxt).set_AutoSize(true);
		((Control)lblTxt).set_Location(new Point(79, 98));
		((Control)lblTxt).set_Name("lblTxt");
		((Control)lblTxt).set_Size(new Size(0, 12));
		((Control)lblTxt).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)lblTxt);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("fEnd");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("fEnd");
		((Form)this).set_TopMost(true);
		((Control)this).add_Leave((EventHandler)fEnd_Leave);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public fEnd()
	{
		InitializeComponent();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).set_Text(Settings.Default.fn);
		((Control)lblTxt).set_Text(lib.GetEnd());
		if (((Control)lblTxt).get_Width() < sw)
		{
			((Control)lblTxt).set_Location(new Point(sw / 2 - ((Control)lblTxt).get_Width() / 2, sh));
		}
		else
		{
			((Control)lblTxt).set_Location(new Point(20, sh));
		}
		((Control)lblTxt).set_BackColor(Color.Transparent);
		((Control)lblTxt).set_Parent((Control)(object)this);
		((Control)lblTxt).set_ForeColor(Color.White);
		thread = new Thread(MoveText);
		thread.IsBackground = true;
		thread.Start();
	}

	private void SetProgressValue(int num)
	{
		if (((Control)lblTxt).get_Bottom() < 0)
		{
			((Control)lblTxt).set_Top(sh);
		}
		else
		{
			Label obj = lblTxt;
			((Control)obj).set_Top(((Control)obj).get_Top() - num);
		}
		((Control)lblTxt).Update();
	}

	private void MoveText()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		SetProgressValueDelegate setProgressValueDelegate = SetProgressValue;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		try
		{
			player = new SoundPlayer(executingAssembly.GetManifestResourceStream("setup.goose.wav"));
			player.PlayLooping();
			while (true)
			{
				((Control)this).Invoke((Delegate)setProgressValueDelegate, new object[1] { 1 });
				Thread.Sleep(10);
			}
		}
		catch (Exception)
		{
		}
	}

	private void fEnd_Leave(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}
}
