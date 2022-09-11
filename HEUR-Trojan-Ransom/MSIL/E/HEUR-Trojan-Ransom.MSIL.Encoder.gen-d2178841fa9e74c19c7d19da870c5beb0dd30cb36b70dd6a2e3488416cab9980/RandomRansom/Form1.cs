using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RandomRansom;

public class Form1 : Form
{
	private int FPS = 30;

	private int W = 500;

	private int H = 500;

	private int FPSCOUNT = 0;

	private Stopwatch FPS_Watch;

	private Bitmap render_image = null;

	private Bitmap clear_image = null;

	private Bitmap death_image = null;

	private Graphics g;

	private bool firsttime = true;

	private int speedfixmult = 0;

	private double scaleX = 0.0;

	private double scaleY = 0.0;

	private int IntscaleX = 0;

	private int IntscaleY = 0;

	private int dead_ix = 0;

	private int dead_iy = 0;

	private Random RND = new Random();

	private Particle[] particle_array;

	private int Particle_Count = 0;

	private string appdatafolder = "";

	private string key = "JyCSi0qa3YqHH0ri0WRdqckV1feBHLmpRSmWtuVfBOC84PcWJO2Z115vmDTctJbqBq0EDR8JwFztoad4fxwocrAD5fjCLGqvYYvbr4GhS8RN5U8Q1fKBm1bT3hCfj0KaOHtsb6MT0hnl6PLSmrzIvzhotFPBtix61YJvMnATzjEy6PMSk0MagrBcZv0mApwe6h8lP1aQ";

	private int Particle_Quality = 2;

	private bool AntiAliasing = false;

	private int InterpolationQuality = 1;

	private IContainer components = null;

	private Timer timer1;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	public int score = 0;

	private int player_color_state = 1;

	private bool dead = false;

	private int enemy_color_state = 1;

	private bool enemy_exists = false;

	private double enemy_y = 0.0;

	private double speed = 0.0;

	private void InitializeComponent()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		Control.set_CheckForIllegalCrossThreadCalls(false);
		components = new Container();
		timer1 = new Timer(components);
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		timer1.set_Interval(33);
		timer1.add_Tick((EventHandler)Timer1_Tick);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(500, 500));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(30, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("FPS:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(39, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(13, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("0");
		((Control)label2).add_Click((EventHandler)Label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(12, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(13, 13));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("0");
		((Control)label3).add_Click((EventHandler)Label3_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(12, 160));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(13, 13));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("0");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(613, 602));
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ControlBox(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("ColorWheelThingy");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		startGame();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	public void startGame()
	{
		Console.WriteLine("Starting game engine...");
		timer1.Start();
	}

	public void init()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		InitializeComponent();
		((Control)this).set_Width(W + 30);
		((Control)this).set_Height(H + 30);
		((Control)pictureBox1).set_Width(W);
		((Control)pictureBox1).set_Height(H);
		((Control)this).set_AutoSize(true);
		((Control)this).Update();
		((Control)this).Invalidate();
		((Control)this).Refresh();
		((Control)this).set_AutoSize(false);
		((Control)this).set_Width(((Control)this).get_Width() - 15);
		((Control)this).set_Height(((Control)this).get_Height());
		((Control)this).Update();
		((Control)this).Invalidate();
		((Control)this).Refresh();
		FPS_Watch = new Stopwatch();
		FPS_Watch.Start();
		AntiAliasing = false;
		InterpolationQuality = 4;
		Particle_Quality = 4;
		timer1.set_Interval(1000 / FPS);
		render_image = new Bitmap(W, H);
		clear_image = new Bitmap(W, H);
		death_image = new Bitmap(W, H);
		for (int i = 0; i < H; i++)
		{
			for (int j = 0; j < W; j++)
			{
				clear_image.SetPixel(j, i, Color.FromArgb(255, 255, 255, 255));
				render_image.SetPixel(j, i, Color.FromArgb(255, 255, 255, 255));
				death_image.SetPixel(j, i, Color.FromArgb(255, 255, 0, 0));
			}
		}
		g = Graphics.FromImage((Image)(object)render_image);
		if (Particle_Quality == 0)
		{
			Particle_Count = 0;
		}
		if (Particle_Quality == 1)
		{
			Particle_Count = 8;
		}
		if (Particle_Quality == 2)
		{
			Particle_Count = 32;
		}
		if (Particle_Quality == 3)
		{
			Particle_Count = 64;
		}
		if (Particle_Quality == 4)
		{
			Particle_Count = 256;
		}
		fix_graphics();
		particle_array = new Particle[Particle_Count * 32];
		for (int k = 0; k < particle_array.Length; k++)
		{
			particle_array[k] = new Particle(0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
			particle_array[k].is_dead = true;
		}
		scaleX = W / 500;
		scaleY = H / 500;
		IntscaleX = (int)scaleX;
		IntscaleY = (int)scaleY;
		speedfixmult = FPS / 30;
		appdatafolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
	}

	private void fix_graphics()
	{
		if (AntiAliasing)
		{
			g.set_SmoothingMode((SmoothingMode)2);
		}
		else
		{
			g.set_SmoothingMode((SmoothingMode)1);
		}
		if (InterpolationQuality == 0)
		{
			g.set_InterpolationMode((InterpolationMode)0);
		}
		if (InterpolationQuality == 1)
		{
			g.set_InterpolationMode((InterpolationMode)1);
		}
		if (InterpolationQuality == 2)
		{
			g.set_InterpolationMode((InterpolationMode)5);
		}
		if (InterpolationQuality == 3)
		{
			g.set_InterpolationMode((InterpolationMode)4);
		}
		if (InterpolationQuality == 4)
		{
			g.set_InterpolationMode((InterpolationMode)7);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		RenderFrame();
		UpdateFrame();
		UpdateGame();
		Fix_FPS();
		FPSCOUNT++;
		if (firsttime)
		{
			Console.WriteLine("Done!");
			firsttime = false;
		}
	}

	public void UpdateGame()
	{
		if (!enemy_exists)
		{
			int num = RND.Next(1, 5);
			enemy_exists = true;
			enemy_color_state = num;
			enemy_y = (float)(50.0 * scaleY);
		}
		speed += 0.01 / (double)speedfixmult;
		enemy_y += speed;
		if (enemy_exists && enemy_y > (double)(H - 33))
		{
			if (player_color_state == enemy_color_state)
			{
				enemy_exists = false;
				enemy_y = 0.0;
				score++;
				int num2 = 0;
				for (int i = 0; i < particle_array.Length; i++)
				{
					if (num2 >= Particle_Count)
					{
						break;
					}
					if (particle_array[i].is_dead)
					{
						num2++;
						particle_array[i] = new Particle(RND.Next(W / 2 - 10, W / 2 + 10), H - 10, RND.Next(-20, 20), RND.Next(10, 100), 0.0, RND.Next(-10, -6));
						particle_array[i].is_dead = false;
					}
				}
			}
			else
			{
				if (dead)
				{
				}
				dead = true;
				score = 0;
			}
		}
		if (!dead)
		{
			for (int j = 0; j < particle_array.Length; j++)
			{
				if (!particle_array[j].is_dead)
				{
					particle_array[j].update(W, H, speedfixmult);
				}
			}
		}
		if (dead)
		{
			dead_ix++;
			if (dead_ix == 240)
			{
				dead_ix = 0;
				dead = false;
				enemy_exists = false;
				enemy_y = 0.0;
				speed = 0.0;
				score = 0;
			}
		}
	}

	private void RenderFrame()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		if (!dead)
		{
			SolidBrush val = null;
			if (!dead)
			{
				for (int i = 0; i < particle_array.Length; i++)
				{
					if (particle_array[i] != null && !particle_array[i].is_dead)
					{
						val = new SolidBrush(Color.FromArgb(255, RND.Next(0, 255), RND.Next(0, 255), RND.Next(0, 255)));
						g.FillEllipse((Brush)(object)val, new RectangleF((int)particle_array[i].loc_x, (int)particle_array[i].loc_y, 5f, 5f));
					}
				}
			}
		}
		if (!dead && enemy_exists)
		{
			SolidBrush val2 = null;
			val2 = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
			if (enemy_color_state == 1)
			{
				val2 = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
			}
			if (enemy_color_state == 2)
			{
				val2 = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
			}
			if (enemy_color_state == 3)
			{
				val2 = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
			}
			if (enemy_color_state == 4)
			{
				val2 = new SolidBrush(Color.FromArgb(255, 255, 0, 255));
			}
			g.FillEllipse((Brush)(object)val2, new RectangleF((float)(W / 2) - (float)(15.0 * scaleX / 2.0), (float)(enemy_y * scaleY), (float)(15.0 * scaleX), (float)(15.0 * scaleY)));
		}
		if (!dead)
		{
			SolidBrush val3 = new SolidBrush(Color.FromArgb(255, 0, 255, 255));
			g.FillEllipse((Brush)(object)val3, new RectangleF((float)(W / 2) - (float)(25.0 * scaleX / 2.0), (float)(50.0 * scaleY), (float)(25.0 * scaleX), (float)(25.0 * scaleY)));
		}
		if (!dead)
		{
			SolidBrush val4 = null;
			val4 = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
			if (player_color_state == 1)
			{
				val4 = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
			}
			if (player_color_state == 2)
			{
				val4 = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
			}
			if (player_color_state == 3)
			{
				val4 = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
			}
			if (player_color_state == 4)
			{
				val4 = new SolidBrush(Color.FromArgb(255, 255, 0, 255));
			}
			g.FillEllipse((Brush)(object)val4, new RectangleF(W / 2 - 100 * IntscaleX / 2, H - 100 * IntscaleX / 2, 100 * IntscaleX, 100 * IntscaleY));
		}
	}

	private void UpdateFrame()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		pictureBox1.set_Image((Image)(object)render_image.Clone(new RectangleF(0f, 0f, W, H), ((Image)render_image).get_PixelFormat()));
		if (!dead)
		{
			((Control)label3).set_Text(score.ToString());
			render_image = clear_image.Clone(new RectangleF(0f, 0f, W, H), ((Image)render_image).get_PixelFormat());
			dead_ix = 0;
		}
		else
		{
			render_image = death_image.Clone(new RectangleF(0f, 0f, W, H), ((Image)render_image).get_PixelFormat());
		}
		g = Graphics.FromImage((Image)(object)render_image);
		fix_graphics();
		((Control)this).Invalidate();
	}

	private void Fix_FPS()
	{
		if (FPS_Watch.ElapsedMilliseconds >= 1000L)
		{
			FPS_Watch.Stop();
			FPS_Watch.Reset();
			if (FPSCOUNT < FPS && timer1.get_Interval() > 1)
			{
				Timer obj = timer1;
				int interval = obj.get_Interval();
				obj.set_Interval(interval - 1);
			}
			((Control)label2).set_Text(FPSCOUNT.ToString());
			((Control)label2).Invalidate();
			FPSCOUNT = 0;
			FPS_Watch.Start();
		}
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyData() == 65)
		{
			player_color_state = 1;
		}
		if ((int)e.get_KeyData() == 68)
		{
			player_color_state = 2;
		}
		if ((int)e.get_KeyData() == 87)
		{
			player_color_state = 3;
		}
		if ((int)e.get_KeyData() == 83)
		{
			player_color_state = 4;
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}

	private void Label3_Click(object sender, EventArgs e)
	{
	}
}
