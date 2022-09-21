using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MiniGameEngine.Examples.Droplets;
using MiniGameEngine.General.Threading;
using MiniGameEngine.UI;

namespace MiniGameEngine.Examples.Scenes;

public class RaindropDemo : Scene
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private WeatherType weatherType_0;

	private Random random_0;

	private SmoothEchoDroplets smoothEchoDroplets_0;

	private TextElement tRnWoxxw0;

	private TextElement textElement_0;

	private TextElement textElement_1;

	private Timer timer_0;

	private Timer timer_1;

	private bool bool_1;

	private KeyValuePair<string, int[]> keyValuePair_0;

	private Dictionary<string, int[]> dictionary_0;

	private double double_0;

	private double double_1;

	private int int_3;

	public int MaxRaindrops
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int MaxRadius
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int MinRadius
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public WeatherType Type
	{
		[CompilerGenerated]
		get
		{
			return weatherType_0;
		}
		[CompilerGenerated]
		set
		{
			weatherType_0 = value;
		}
	}

	public RaindropDemo(GameContainer Game)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		Class11.NQ1E32yzjMukk();
		base._002Ector(Game);
		MaxRaindrops = 100;
		MaxRadius = 125;
		MinRadius = 20;
		Type = WeatherType.Stormy;
		random_0 = new Random();
		smoothEchoDroplets_0 = new SmoothEchoDroplets(this);
		tRnWoxxw0 = new TextElement("Current Weather: Unknown")
		{
			Font = new Font("Arial", 15f),
			Position = base.Game.MIDDLE_POS,
			HorizontalAlignment = HorizontalAlignment.Center,
			Color = Color.Blue
		};
		textElement_0 = new TextElement("\nControls:\nSpacebar - Toggle Pause,\n       N - Change Weather,\n       M - Rain Button\n")
		{
			Font = new Font("Arial", 10f),
			Position = base.Game.TOP_RIGHT_POS,
			HorizontalAlignment = HorizontalAlignment.Right,
			Color = Color.Gray
		};
		textElement_1 = new TextElement("Rain Generation Paused")
		{
			Font = new Font("Arial", 15f),
			HorizontalAlignment = HorizontalAlignment.Center,
			Color = Color.Gray
		};
		timer_0 = new Timer();
		timer_1 = new Timer();
		bool_1 = true;
		dictionary_0 = new Dictionary<string, int[]>
		{
			{
				"Drizzle",
				new int[2] { 0, 5 }
			},
			{
				"Light Rain",
				new int[2] { 0, 20 }
			},
			{
				"Rain Showers",
				new int[2] { 0, 50 }
			},
			{
				"Heavy Rain",
				new int[2] { 50, 150 }
			},
			{
				"Da-Rude Rain-Storm",
				new int[2] { 100, 200 }
			},
			{
				" The \"\"We're going to Die!\"\" Hurricane",
				new int[2] { 250, 300 }
			}
		};
		double_0 = 50.0;
		double_1 = 0.0;
		int_3 = 0;
		base.BackgroundColor = Color.Black;
	}

	public override void WindowSizeChange()
	{
		tRnWoxxw0.Position = base.Game.MIDDLE_POS;
		Point mIDDLE_POS = base.Game.MIDDLE_POS;
		mIDDLE_POS.Offset(0, -25);
		textElement_1.Position = mIDDLE_POS;
		mIDDLE_POS = base.Game.TOP_RIGHT_POS;
		mIDDLE_POS.Offset(-20, 0);
		textElement_0.Position = mIDDLE_POS;
	}

	public void ChangeWeather()
	{
		checked
		{
			_ = (int)Math.Floor(new Random().NextDouble() * (double)dictionary_0.Count);
			double_1 = keyValuePair_0.Value[0];
			double_0 = keyValuePair_0.Value[1];
			tRnWoxxw0.Text = "Current Weather: " + keyValuePair_0.Key;
			int_3 = 0;
			timer_0.set_Interval((int)Math.Round(Math.Floor(new Random().NextDouble() * 25000.0) + 5000.0));
		}
	}

	public void Spawn()
	{
		checked
		{
			int num = (int)Math.Round(Math.Floor(random_0.NextDouble() * (double_0 - double_1)) + double_1);
			_ = (int)Math.Round(double_0);
			int num2 = num;
			_Closure_0024__27_002D0 closure_0024__27_002D = default(_Closure_0024__27_002D0);
			for (int i = 0; i <= num2; i++)
			{
				closure_0024__27_002D = new _Closure_0024__27_002D0(closure_0024__27_002D);
				closure_0024__27_002D._0024VB_0024Me = this;
				closure_0024__27_002D._0024VB_0024Local_spawnPoint = new Point(random_0.Next(0, base.Game.Window.get_Size().Width + 150), random_0.Next(0, base.Game.Window.get_Size().Height + 150));
				int_3 = (int)Math.Round((double)(int_3 + 1) % double_0 + 1.0);
				ThreadWork.Start(closure_0024__27_002D._Lambda_0024__0);
			}
		}
	}

	public override void Init()
	{
		timer_0.add_Tick((EventHandler)delegate
		{
			ChangeWeather();
		});
		timer_0.set_Interval(1);
		timer_0.Start();
		timer_1.add_Tick((EventHandler)delegate
		{
			Spawn();
		});
		timer_1.set_Interval(50);
		timer_1.Start();
		WindowSizeChange();
		base.Game.Window.set_FormBorderStyle((FormBorderStyle)4);
		add(tRnWoxxw0);
		add(textElement_0);
	}

	public void TogglePause()
	{
		bool_1 = !bool_1;
		if (bool_1)
		{
			timer_1.Start();
			timer_0.Start();
			remove(textElement_1);
		}
		else
		{
			add(textElement_1);
			timer_1.Stop();
			timer_0.Stop();
		}
	}

	public override void MouseDoubleClick(MouseButtons MouseButton)
	{
		base.Game.Fullscreen = !base.Game.Fullscreen;
	}

	public override void MouseClick(MouseButtons MouseButton)
	{
	}

	public override void KeyPress(Keys KeyCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		if ((int)KeyCode <= 70)
		{
			if ((int)KeyCode != 32)
			{
				if ((int)KeyCode == 70)
				{
					base.Game.Fullscreen = !base.Game.Fullscreen;
				}
			}
			else
			{
				TogglePause();
			}
		}
		else if ((int)KeyCode != 77)
		{
			if ((int)KeyCode == 78)
			{
				ChangeWeather();
			}
		}
		else
		{
			Spawn();
		}
	}

	public override void Render(Graphics g)
	{
	}

	public override void Update(double delta)
	{
		tRnWoxxw0.Text = $"Current Weather: {keyValuePair_0.Key} (spawned {int_3} of {double_0})";
	}
}
