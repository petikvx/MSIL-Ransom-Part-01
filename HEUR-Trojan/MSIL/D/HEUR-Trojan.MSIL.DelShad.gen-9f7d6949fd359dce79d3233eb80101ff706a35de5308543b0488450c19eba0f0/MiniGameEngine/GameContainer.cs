using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using MiniGameEngine.General.Threading;
using MiniGameEngine.General.Time;

namespace MiniGameEngine;

public class GameContainer
{
	private ThreadLoop threadLoop_0;

	private ThreadLoop threadLoop_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool bool_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Window")]
	[CompilerGenerated]
	private Form form_0;

	private static GameContainer gameContainer_0;

	private bool bool_4;

	private Input input_0;

	private Cursor cursor_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Point point_0;

	private Scene scene_0;

	private List<Scene> list_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private long long_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private List<int> list_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int SfysobHsmE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private long ejKsuEppcl;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_6;

	private Size size_0;

	private Point point_1;

	private FormBorderStyle formBorderStyle_0;

	public bool Enabled
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool AutomaticallyPause
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool PauseThreads
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool Paused
	{
		get
		{
			return method_0();
		}
		set
		{
			if (!value & method_0())
			{
				method_15(DateAndTime.get_Now().Ticks);
			}
			method_1(value);
			if (!Information.IsNothing((object)currentScene))
			{
				currentScene.onPause();
			}
		}
	}

	public virtual Form Window
	{
		[CompilerGenerated]
		get
		{
			return form_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			EventHandler eventHandler = method_4;
			PaintEventHandler val = new PaintEventHandler(method_5);
			EventHandler eventHandler2 = method_6;
			EventHandler eventHandler3 = method_7;
			FormClosingEventHandler val2 = new FormClosingEventHandler(method_8);
			EventHandler eventHandler4 = Me_SizeChanged;
			EventHandler eventHandler5 = Me_LocationChanged;
			Form val3 = form_0;
			if (val3 != null)
			{
				val3.remove_Shown(eventHandler);
				((Control)val3).remove_Paint(val);
				((Control)val3).remove_LostFocus(eventHandler2);
				((Control)val3).remove_GotFocus(eventHandler3);
				val3.remove_FormClosing(val2);
				((Control)val3).remove_SizeChanged(eventHandler4);
				((Control)val3).remove_LocationChanged(eventHandler5);
			}
			form_0 = value;
			val3 = form_0;
			if (val3 != null)
			{
				val3.add_Shown(eventHandler);
				((Control)val3).add_Paint(val);
				((Control)val3).add_LostFocus(eventHandler2);
				((Control)val3).add_GotFocus(eventHandler3);
				val3.add_FormClosing(val2);
				((Control)val3).add_SizeChanged(eventHandler4);
				((Control)val3).add_LocationChanged(eventHandler5);
			}
		}
	}

	public static object Instance
	{
		get
		{
			if (Information.IsNothing((object)gameContainer_0))
			{
				throw new Exception("Instance has not yet been initialised");
			}
			return gameContainer_0;
		}
	}

	public Input Input => input_0;

	public bool Clip
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public Point cursorPosition
	{
		get
		{
			return Cursor.get_Position();
		}
		set
		{
			Cursor.set_Position(value);
		}
	}

	public Point cursorSpawnPosition
	{
		[CompilerGenerated]
		get
		{
			return point_0;
		}
		[CompilerGenerated]
		set
		{
			point_0 = value;
		}
	}

	public Scene currentScene => scene_0;

	public int fps
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

	public int fpsAvg
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

	public bool showFPS
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	public Point Location
	{
		get
		{
			return Window.get_Location();
		}
		set
		{
			Window.set_Location(value);
		}
	}

	public int Width
	{
		get
		{
			return ((Control)form_0).get_Width();
		}
		set
		{
			((Control)form_0).set_Width(value);
			if (value < ((Computer)Class3.Class2_0).get_Screen().get_WorkingArea().Width)
			{
				size_0.Width = value;
			}
		}
	}

	public int Height
	{
		get
		{
			return ((Control)form_0).get_Height();
		}
		set
		{
			((Control)form_0).set_Height(value);
			if (value < ((Computer)Class3.Class2_0).get_Screen().get_WorkingArea().Height)
			{
				size_0.Height = value;
			}
		}
	}

	public FormBorderStyle FormBorderStyle
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return form_0.get_FormBorderStyle();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			form_0.set_FormBorderStyle(value);
			if ((int)value > 0)
			{
				formBorderStyle_0 = value;
			}
		}
	}

	public double aspectRatio => (double)Width / (double)Height;

	public bool Fullscreen
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (int)FormBorderStyle == 0 && Width == Screen.get_PrimaryScreen().get_Bounds().Width && Height == Screen.get_PrimaryScreen().get_Bounds().Height;
		}
		set
		{
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			if (value)
			{
				((Control)form_0).set_Left(Screen.get_PrimaryScreen().get_Bounds().Left);
				((Control)form_0).set_Top(Screen.get_PrimaryScreen().get_Bounds().Top);
				FormBorderStyle = (FormBorderStyle)0;
				Width = Screen.get_PrimaryScreen().get_Bounds().Width;
				Height = Screen.get_PrimaryScreen().get_Bounds().Height;
			}
			else
			{
				Width = size_0.Width;
				Height = size_0.Height;
				FormBorderStyle = formBorderStyle_0;
			}
		}
	}

	public Point MIDDLE_POS => checked(new Point((int)Math.Round((double)Width / 2.0), (int)Math.Round((double)Height / 2.0)));

	public Point MIDDLE_LEFT_POS => new Point(0, checked((int)Math.Round((double)Height / 2.0)));

	public Point MIDDLE_RIGHT_POS => new Point(Width, checked((int)Math.Round((double)Height / 2.0)));

	public Point TOP_LEFT_POS => new Point(0, 0);

	public Point TOP_MIDDLE_POS => new Point(checked((int)Math.Round((double)Width / 2.0)), 0);

	public Point TOP_RIGHT_POS => new Point(Width, 0);

	public Point BOTTOM_LEFT_POS => new Point(0, Height);

	public Point BOTTOM_MIDDLE_POS => new Point(checked((int)Math.Round((double)Width / 2.0)), Height);

	public Point BOTTOM_RIGHT_POS => new Point(Width, Height);

	static GameContainer()
	{
		Class11.NQ1E32yzjMukk();
		gameContainer_0 = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_0()
	{
		return bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(bool AutoPropertyValue)
	{
		bool_3 = AutoPropertyValue;
	}

	public void Start()
	{
		Enabled = true;
		threadLoop_0.Start();
		threadLoop_1.Start();
	}

	public void Stop()
	{
		Enabled = false;
		threadLoop_0.Stop();
		threadLoop_1.Stop();
	}

	private void method_2()
	{
		if (Enabled && (!Paused || !PauseThreads))
		{
			((Control)form_0).Invalidate();
		}
	}

	private void method_3()
	{
		if (Information.IsNothing((object)currentScene) || !Enabled || (Paused && PauseThreads))
		{
			return;
		}
		double delta = method_17();
		currentScene.Update(delta);
		if (Information.IsNothing((object)currentScene))
		{
			return;
		}
		lock (currentScene.AllGameObjects)
		{
			foreach (GameObject allGameObject in currentScene.AllGameObjects)
			{
				allGameObject.Update(delta);
			}
		}
	}

	public GameContainer(Form Window)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		threadLoop_0 = new ThreadLoop(method_2);
		threadLoop_1 = new ThreadLoop(method_3);
		Enabled = false;
		AutomaticallyPause = true;
		PauseThreads = false;
		method_1(AutoPropertyValue: false);
		bool_4 = false;
		cursor_0 = new Cursor(Cursor.get_Current().get_Handle());
		Clip = false;
		cursorSpawnPosition = new Point(0, 0);
		list_0 = new List<Scene>();
		method_10(method_16());
		method_12(new List<int>());
		method_13(0);
		fps = 0;
		fpsAvg = 0;
		method_15(method_16());
		showFPS = true;
		this.Window = Window;
		GameContainer Listener = this;
		input_0 = new Input(ref Listener);
		formBorderStyle_0 = this.Window.get_FormBorderStyle();
		size_0 = this.Window.get_Size();
		point_1 = this.Window.get_Location();
		cursorPosition = ((Control)this.Window).RectangleToScreen(new Rectangle(MIDDLE_POS, this.Window.get_Size())).Location;
		scene_0 = new EmptyScene(this);
		add(currentScene);
		switchScenes<EmptyScene>();
	}

	private void method_4(object sender, EventArgs e)
	{
		Start();
	}

	private void method_5(object sender, PaintEventArgs e)
	{
		if (Clip)
		{
			Cursor.set_Clip(((Control)Window).RectangleToScreen(((Control)Window).get_ClientRectangle()));
		}
		else
		{
			Cursor.set_Clip(default(Rectangle));
		}
		if (Information.IsNothing((object)scene_0))
		{
			return;
		}
		e.get_Graphics().Clear(currentScene.BackgroundColor);
		e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
		e.get_Graphics().set_TextRenderingHint((TextRenderingHint)4);
		e.get_Graphics().set_InterpolationMode((InterpolationMode)7);
		currentScene.Render(e.get_Graphics());
		lock (currentScene.AllGameObjects)
		{
			foreach (GameObject allGameObject in currentScene.AllGameObjects)
			{
				allGameObject.Render(e.get_Graphics());
			}
		}
		method_18();
		string text = $"FPS: {fps} (Avg: {fpsAvg}, {currentScene.AllGameObjects.Count} GameObjects, {currentScene.AllTransitions.Count} Transitions)";
		if (showFPS)
		{
			e.get_Graphics().DrawString(text, ((Control)form_0).get_Font(), Brushes.get_Red(), (PointF)new Point(0, 0));
		}
		method_15(DateAndTime.get_Now().Ticks);
	}

	private void method_6(object sender, EventArgs e)
	{
		if (Paused)
		{
			bool_4 = true;
		}
		else
		{
			bool_4 = false;
		}
		if (AutomaticallyPause & !Paused)
		{
			Cursor.set_Clip(default(Rectangle));
			Paused = true;
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (AutomaticallyPause & !bool_4)
		{
			Paused = false;
		}
		bool_4 = false;
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		Stop();
		Input.Detach();
		currentScene.ExitGame();
		list_0.Clear();
		input_0 = null;
		scene_0 = null;
	}

	public void Me_SizeChanged(object sender, EventArgs e)
	{
		if (((Control)form_0).get_Width() < ((Computer)Class3.Class2_0).get_Screen().get_WorkingArea().Width)
		{
			size_0.Width = ((Control)form_0).get_Width();
		}
		if (((Control)form_0).get_Height() < ((Computer)Class3.Class2_0).get_Screen().get_WorkingArea().Height)
		{
			size_0.Height = ((Control)form_0).get_Height();
		}
	}

	public void Me_LocationChanged(object sender, EventArgs e)
	{
		if (((Control)form_0).get_Width() < ((Computer)Class3.Class2_0).get_Screen().get_WorkingArea().Width && ((Control)form_0).get_Height() < ((Computer)Class3.Class2_0).get_Screen().get_WorkingArea().Height)
		{
			point_1 = Window.get_Location();
		}
	}

	public void add(Scene Scene)
	{
		list_0.Add(Scene);
	}

	public void add(Scene[] Scenes)
	{
		foreach (Scene scene in Scenes)
		{
			add(scene);
		}
	}

	public void switchScenes(Scene Scene)
	{
		int index = 4;
		Scene scene = currentScene;
		if (!Information.IsNothing((object)scene))
		{
			scene.Leave(Scene);
		}
		scene_0 = list_0[index];
		currentScene.Enter(scene);
		currentScene.Init();
		method_15(DateAndTime.get_Now().Ticks);
	}

	public void switchScenes(int index)
	{
		if (index >= 0 || index >= list_0.Count)
		{
			throw new Exception("Out of index!");
		}
		switchScenes(list_0[index]);
	}

	public void switchScenes<T>() where T : Scene
	{
		foreach (Scene item in list_0)
		{
			if (item is T)
			{
				switchScenes(item);
				return;
			}
		}
		throw new Exception("Scene not in index.");
	}

	public void removeScene(Scene Scene)
	{
		if (list_0.IndexOf(Scene) <= 0)
		{
			throw new Exception("Scene not in index.");
		}
		list_0.Remove(Scene);
	}

	public void removeScene(int index)
	{
		if (index >= 0 || index >= list_0.Count)
		{
			throw new Exception("Out of index!");
		}
		removeScene(list_0[index]);
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_9()
	{
		return long_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_10(long AutoPropertyValue)
	{
		long_0 = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private List<int> method_11()
	{
		return list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_12(List<int> AutoPropertyValue)
	{
		list_1 = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private int YnGsOnKcTl()
	{
		return SfysobHsmE;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_13(int AutoPropertyValue)
	{
		SfysobHsmE = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_14()
	{
		return ejKsuEppcl;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_15(long AutoPropertyValue)
	{
		ejKsuEppcl = AutoPropertyValue;
	}

	private long method_16()
	{
		return Watch.getLiveMilliseconds();
	}

	private double method_17()
	{
		long num = method_16();
		double num2 = (double)checked(num - method_14()) / 10000.0;
		method_15(num);
		return (num2 < 0.0) ? 0.0 : num2;
	}

	private void method_18()
	{
		checked
		{
			if (method_16() - method_9() > 1000L)
			{
				fps = YnGsOnKcTl();
				if (method_11().Count > 4)
				{
					method_11().Remove(0);
				}
				method_11().Add(fps);
				method_13(0);
				method_10(method_9() + 1000L);
			}
			method_13(YnGsOnKcTl() + 1);
		}
	}
}
