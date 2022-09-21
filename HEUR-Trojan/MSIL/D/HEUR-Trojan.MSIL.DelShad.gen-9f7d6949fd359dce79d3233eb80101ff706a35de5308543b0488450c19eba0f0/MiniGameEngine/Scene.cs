using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MiniGameEngine.General.Threading;
using MiniGameEngine.Transitions;

namespace MiniGameEngine;

public abstract class Scene
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Color color_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GameContainer gameContainer_0;

	private List<GameObject> list_0;

	private List<TransitionPropertyItem> list_1;

	private bool bool_0;

	private ThreadLoop threadLoop_0;

	public Color BackgroundColor
	{
		[CompilerGenerated]
		get
		{
			return color_0;
		}
		[CompilerGenerated]
		set
		{
			color_0 = value;
		}
	}

	public GameContainer Game
	{
		[CompilerGenerated]
		get
		{
			return gameContainer_0;
		}
		[CompilerGenerated]
		set
		{
			gameContainer_0 = value;
		}
	}

	public bool Active => bool_0;

	public List<GameObject> AllGameObjects
	{
		get
		{
			lock (list_0)
			{
				return list_0;
			}
		}
	}

	public List<TransitionPropertyItem> AllTransitions
	{
		get
		{
			lock (list_1)
			{
				return list_1;
			}
		}
	}

	private void method_0()
	{
		if (!Game.Enabled || (Game.Paused && Game.PauseThreads) || !bool_0 || AllTransitions.Count <= 0)
		{
			return;
		}
		checked
		{
			lock (AllTransitions)
			{
				int num = AllTransitions.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					TransitionPropertyItem transitionPropertyItem = AllTransitions[i];
					transitionPropertyItem.TransitionProperty.Work(transitionPropertyItem.Transition);
					if (transitionPropertyItem.Transition.isFinished && transitionPropertyItem.AutomaticallyRemoveObject)
					{
						_ = transitionPropertyItem.TransitionProperty.Reference;
						remove(transitionPropertyItem.TransitionProperty.Reference);
					}
					if (transitionPropertyItem.Transition.isFinished && transitionPropertyItem.AutomaticallyRemoveTransition)
					{
						TransitionPropertyItem transitionPropertyItem2;
						Transition Transition = (transitionPropertyItem2 = transitionPropertyItem).Transition;
						remove(ref Transition);
						transitionPropertyItem2.Transition = Transition;
					}
				}
			}
		}
	}

	public void add(GameObject GameObject)
	{
		lock (list_0)
		{
			if (list_0.IndexOf(GameObject) < 0)
			{
				list_0.Add(GameObject);
			}
		}
	}

	public void add(ref TransitionProperty TransitionProperty, Transition Transition, bool AutomaticallyRemoveTransition = false, bool AutomaticallyRemoveObject = false)
	{
		lock (list_1)
		{
			TransitionPropertyItem item = new TransitionPropertyItem(TransitionProperty, Transition, AutomaticallyRemoveTransition, AutomaticallyRemoveObject);
			if (list_1.IndexOf(item) < 0)
			{
				list_1.Add(item);
			}
		}
	}

	public void remove(GameObject GameObject)
	{
		lock (list_0)
		{
			list_0.Remove(GameObject);
		}
	}

	public void remove(ref TransitionProperty TransitionProperty)
	{
		lock (list_1)
		{
			TransitionPropertyItem transitionPropertyItem = null;
			foreach (TransitionPropertyItem item in list_1)
			{
				if (Operators.CompareString(item.TransitionProperty.ID, TransitionProperty.ID, false) == 0)
				{
					transitionPropertyItem = item;
					break;
				}
			}
			if (!Information.IsNothing((object)transitionPropertyItem))
			{
				list_1.Remove(transitionPropertyItem);
			}
		}
	}

	public void remove(ref Transition Transition)
	{
		lock (list_1)
		{
			TransitionPropertyItem transitionPropertyItem = null;
			foreach (TransitionPropertyItem item in list_1)
			{
				if (Operators.CompareString(item.Transition.ID, Transition.ID, false) == 0)
				{
					transitionPropertyItem = item;
					break;
				}
			}
			if (!Information.IsNothing((object)transitionPropertyItem))
			{
				list_1.Remove(transitionPropertyItem);
			}
		}
	}

	public Scene(GameContainer Game)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		BackgroundColor = Color.Black;
		list_0 = new List<GameObject>();
		list_1 = new List<TransitionPropertyItem>();
		bool_0 = false;
		threadLoop_0 = new ThreadLoop(method_0);
		this.Game = Game;
		threadLoop_0.Enabled = true;
	}

	public abstract void Init();

	public abstract void Render(Graphics g);

	public abstract void Update(double delta);

	public virtual void Enter(Scene lastScene)
	{
		bool_0 = true;
		threadLoop_0.Enabled = true;
	}

	public virtual void onPause()
	{
	}

	public virtual void Leave(Scene nextScene)
	{
		bool_0 = false;
		threadLoop_0.Enabled = false;
	}

	public virtual void ExitGame()
	{
		bool_0 = false;
		threadLoop_0.Enabled = false;
	}

	public virtual void KeyDown(Keys KeyCode)
	{
	}

	public virtual void KeyPress(Keys KeyCode)
	{
	}

	public virtual void KeyUp(Keys KeyCode)
	{
	}

	public virtual void MouseDown(MouseButtons MouseButton)
	{
	}

	public virtual void MouseUp(MouseButtons MouseButton)
	{
	}

	public virtual void MouseClick(MouseButtons MouseButton)
	{
	}

	public virtual void MouseDoubleClick(MouseButtons MouseButton)
	{
	}

	public virtual void MouseMove(Point Location)
	{
	}

	public virtual void WindowSizeChange()
	{
	}
}
