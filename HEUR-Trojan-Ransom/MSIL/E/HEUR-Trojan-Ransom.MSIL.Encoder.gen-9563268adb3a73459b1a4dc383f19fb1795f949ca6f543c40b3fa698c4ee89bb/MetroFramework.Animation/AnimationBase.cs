using System;
using System.Windows.Forms;

namespace MetroFramework.Animation;

public abstract class AnimationBase
{
	private DelayedCall timer;

	private Control targetControl;

	private AnimationAction actionHandler;

	private AnimationFinishedEvaluator evaluatorHandler;

	protected TransitionType transitionType;

	protected int counter;

	protected int startTime;

	protected int targetTime;

	public bool IsCompleted
	{
		get
		{
			if (timer != null)
			{
				return !timer.IsWaiting;
			}
			return true;
		}
	}

	public bool IsRunning
	{
		get
		{
			if (timer != null)
			{
				return timer.IsWaiting;
			}
			return false;
		}
	}

	public event EventHandler AnimationCompleted;

	private void OnAnimationCompleted()
	{
		if (this.AnimationCompleted != null)
		{
			this.AnimationCompleted(this, EventArgs.Empty);
		}
	}

	public void Cancel()
	{
		if (IsRunning)
		{
			timer.Cancel();
		}
	}

	protected void Start(Control control, TransitionType transitionType, int duration, AnimationAction actionHandler)
	{
		Start(control, transitionType, duration, actionHandler, null);
	}

	protected void Start(Control control, TransitionType transitionType, int duration, AnimationAction actionHandler, AnimationFinishedEvaluator evaluatorHandler)
	{
		targetControl = control;
		this.transitionType = transitionType;
		this.actionHandler = actionHandler;
		this.evaluatorHandler = evaluatorHandler;
		counter = 0;
		startTime = 0;
		targetTime = duration;
		timer = DelayedCall.Start(DoAnimation, duration);
	}

	private void DoAnimation()
	{
		if (evaluatorHandler != null && !evaluatorHandler())
		{
			actionHandler();
			counter++;
			timer.Start();
		}
		else
		{
			OnAnimationCompleted();
		}
	}

	protected int MakeTransition(float t, float b, float d, float c)
	{
		switch (transitionType)
		{
		default:
			return 0;
		case TransitionType.Linear:
			return (int)(c * t / d + b);
		case TransitionType.EaseInQuad:
			return (int)(c * (t /= d) * t + b);
		case TransitionType.EaseOutQuad:
			return (int)((0f - c) * (t /= d) * (t - 2f) + b);
		case TransitionType.EaseInOutQuad:
			if ((t /= d / 2f) < 1f)
			{
				return (int)(c / 2f * t * t + b);
			}
			return (int)((0f - c) / 2f * ((t -= 1f) * (t - 2f) - 1f) + b);
		case TransitionType.EaseInCubic:
			return (int)(c * (t /= d) * t * t + b);
		case TransitionType.EaseOutCubic:
			return (int)(c * ((t = t / d - 1f) * t * t + 1f) + b);
		case TransitionType.EaseInOutCubic:
			if ((t /= d / 2f) < 1f)
			{
				return (int)(c / 2f * t * t * t + b);
			}
			return (int)(c / 2f * ((t -= 2f) * t * t + 2f) + b);
		case TransitionType.EaseInQuart:
			return (int)(c * (t /= d) * t * t * t + b);
		case TransitionType.EaseInExpo:
			if (t == 0f)
			{
				return (int)b;
			}
			return (int)((double)c * Math.Pow(2.0, 10f * (t / d - 1f)) + (double)b);
		case TransitionType.EaseOutExpo:
			if (t == d)
			{
				return (int)(b + c);
			}
			return (int)((double)c * (0.0 - Math.Pow(2.0, -10f * t / d) + 1.0) + (double)b);
		}
	}
}
