using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using MiniGameEngine.Examples.Shapes;
using MiniGameEngine.Examples.Shapes.SineCircles;
using MiniGameEngine.Transitions;
using MiniGameEngine.UI;

namespace MiniGameEngine.Examples.Scenes;

public class SineDemo : Scene
{
	public SineCircle Sine;

	private string string_0;

	private TextElement textElement_0;

	private TextElement textElement_1;

	private TextElement textElement_2;

	private ColorTransition colorTransition_0;

	private ColorTransition colorTransition_1;

	private int int_0;

	private Dictionary<SineCircleType, Class9> dictionary_0;

	public RandomDoubleTransition Radius;

	public RandomDoubleTransition Frequency;

	public RandomDoubleTransition Depth;

	public RandomPointTransition Position;

	public RandomDoubleTransition Rotation;

	public ColorTransition SineColorTransition;

	public Point maxTransitionalPosition => checked(new Point((int)Math.Round((double)base.Game.Width / 4.0 * 3.0), (int)Math.Round((double)base.Game.Height / 4.0 * 3.0)));

	public Point minTransitionalPosition => checked(new Point((int)Math.Round((double)base.Game.Width / 4.0), (int)Math.Round((double)base.Game.Height / 4.0)));

	public double maxTransitionalRadius => (double)base.Game.Height / 3.0;

	private void method_1()
	{
		Radius.Duration = TimeSpan.FromSeconds(10.0);
		Frequency.Duration = TimeSpan.FromSeconds(10.0);
		Depth.Duration = TimeSpan.FromSeconds(10.0);
		Rotation.Duration = TimeSpan.FromSeconds(3.0);
		Position.Duration = TimeSpan.FromSeconds(4.0);
	}

	private void method_2()
	{
		Radius.Duration = TimeSpan.FromSeconds(1.0);
		Frequency.Duration = TimeSpan.FromSeconds(1.0);
		Depth.Duration = TimeSpan.FromSeconds(2.0);
		Position.Duration = TimeSpan.FromMilliseconds(800.0);
		Rotation.Duration = TimeSpan.FromSeconds(1.0);
	}

	public void advanceSineType()
	{
		int_0 = checked(int_0 + 1) % dictionary_0.Count;
	}

	public SineDemo(GameContainer game)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		Class11.NQ1E32yzjMukk();
		base._002Ector(game);
		Sine = new SineCircle(base.Game.MIDDLE_POS, (double)base.Game.Height / 3.0, 40, 40);
		string_0 = ((ServerComputer)Class3.Class2_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\temp.mp3";
		textElement_0 = new TextElement("")
		{
			Position = new Point(0, 15),
			Font = new Font("consolas", 10f)
		};
		textElement_1 = new TextElement("Double-click to toggle fullscreen")
		{
			Font = new Font("consolas", 14f),
			Position = new Point(base.Game.BOTTOM_MIDDLE_POS.X, checked(base.Game.BOTTOM_MIDDLE_POS.Y - 100)),
			HorizontalAlignment = HorizontalAlignment.Center,
			VerticalAlignment = VerticalAlignment.Center
		};
		textElement_2 = new TextElement("Paused!")
		{
			Font = new Font("consolas", 20f),
			Position = base.Game.MIDDLE_POS,
			HorizontalAlignment = HorizontalAlignment.Center,
			VerticalAlignment = VerticalAlignment.Center,
			Visible = false
		};
		colorTransition_0 = new ColorTransition(Color.Red, Color.Blue)
		{
			Duration = TimeSpan.FromSeconds(5.0),
			Repeat = true,
			Reverse = true,
			ReverseUsesDuration = true,
			Enabled = true
		};
		colorTransition_1 = new ColorTransition(Color.Black, Color.White)
		{
			Repeat = true,
			Reverse = true,
			ReverseUsesDuration = true,
			Enabled = true,
			Duration = TimeSpan.FromSeconds(1.0)
		};
		int_0 = -1;
		dictionary_0 = new Dictionary<SineCircleType, Class9>();
		Radius = new RandomDoubleTransition(50.0, 20.0, maxTransitionalRadius)
		{
			Repeat = true,
			Reverse = true,
			Enabled = true
		};
		Frequency = new RandomDoubleTransition(24.0, 0.0, 85.0)
		{
			Repeat = true,
			Reverse = true,
			Enabled = true
		};
		Depth = new RandomDoubleTransition(25.0, 0.0, 80.0)
		{
			Repeat = true,
			Reverse = true,
			Enabled = true
		};
		Position = new RandomPointTransition(base.Game.MIDDLE_POS, minTransitionalPosition, maxTransitionalPosition)
		{
			Repeat = true,
			Reverse = true,
			Enabled = true
		};
		Rotation = new RandomDoubleTransition(0.0, 360.0)
		{
			Repeat = true,
			Reverse = true,
			ReverseUsesDuration = true,
			Enabled = true
		};
		SineColorTransition = new ColorTransition(Color.Red, Color.LimeGreen)
		{
			Duration = TimeSpan.FromSeconds(5.0),
			Repeat = true,
			Reverse = true,
			Enabled = true
		};
		game.AutomaticallyPause = false;
		base.BackgroundColor = Color.White;
		Sine.fillColor = Color.Gold;
	}

	public override void Init()
	{
		add(Sine);
		advanceSineType();
		TransitionProperty TransitionProperty = Sine.RotationProperty;
		add(ref TransitionProperty, Rotation);
		TransitionProperty = Sine.PositionProperty;
		add(ref TransitionProperty, Position);
		TransitionProperty = Sine.ColorProperty;
		add(ref TransitionProperty, SineColorTransition);
		TransitionProperty = Sine.FrequencyProperty;
		add(ref TransitionProperty, Frequency);
		TransitionProperty = Sine.DepthProperty;
		add(ref TransitionProperty, Depth);
		TransitionProperty = Sine.RadiusProperty;
		add(ref TransitionProperty, Radius);
		add(textElement_0);
		TransitionProperty = textElement_0.ColorProperty;
		add(ref TransitionProperty, colorTransition_0);
		add(textElement_1);
		TransitionProperty = textElement_1.ColorProperty;
		add(ref TransitionProperty, colorTransition_0);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("MiniGameEngine.dancin.mp3");
		FileStream fileStream = new FileStream(string_0, FileMode.Create);
		checked
		{
			byte[] buffer = new byte[(int)manifestResourceStream.Length + 1];
			manifestResourceStream.Read(buffer, 0, (int)manifestResourceStream.Length);
			fileStream.Write(buffer, 0, (int)manifestResourceStream.Length);
			fileStream.Close();
		}
	}

	public override void MouseClick(MouseButtons MouseButton)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		if ((int)MouseButton == 2097152)
		{
			base.BackgroundColor = ((base.BackgroundColor == Color.White) ? Color.Black : Color.White);
		}
		else if ((int)MouseButton == 1048576)
		{
			base.Game.Paused = !base.Game.Paused;
		}
		else if ((int)MouseButton == 4194304)
		{
			advanceSineType();
		}
	}

	public override void KeyPress(Keys KeyCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		if ((int)KeyCode == 32)
		{
			advanceSineType();
		}
		else if ((int)KeyCode == 80)
		{
			base.Game.Paused = !base.Game.Paused;
		}
		else if ((int)KeyCode == 77)
		{
		}
	}

	public override void onPause()
	{
		if (base.Game.Paused)
		{
			Sine.Pause();
			textElement_0.Pause();
			add(textElement_2);
			TransitionProperty TransitionProperty = textElement_2.ColorProperty;
			add(ref TransitionProperty, colorTransition_1);
		}
		else
		{
			Sine.Resume();
			textElement_0.Resume();
			remove(textElement_2);
			ref ColorTransition reference = ref colorTransition_1;
			Transition Transition = reference;
			remove(ref Transition);
			reference = (ColorTransition)Transition;
		}
	}

	public override void MouseDoubleClick(MouseButtons MouseButton)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		if ((int)MouseButton == 1048576)
		{
			base.Game.Fullscreen = ((!base.Game.Fullscreen) ? true : false);
			Position.maxPosition = maxTransitionalPosition;
			Radius.maxDouble = maxTransitionalRadius;
			textElement_2.Position = base.Game.MIDDLE_POS;
			textElement_1.Position = new Point(base.Game.BOTTOM_MIDDLE_POS.X, checked(base.Game.BOTTOM_MIDDLE_POS.Y - 100));
		}
	}

	public override void Update(double delta)
	{
		textElement_0.Text = $"Sine Generator [{Sine.ToString()}]{Environment.NewLine}TextColor:{RuntimeHelpers.GetObjectValue(colorTransition_0.lastValue)}";
	}

	public override void Render(Graphics g)
	{
	}

	public override void ExitGame()
	{
	}
}
