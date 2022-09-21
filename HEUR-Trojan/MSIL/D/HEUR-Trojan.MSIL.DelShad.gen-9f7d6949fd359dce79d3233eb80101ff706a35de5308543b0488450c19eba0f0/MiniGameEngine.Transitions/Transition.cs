using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;

namespace MiniGameEngine.Transitions;

public abstract class Transition
{
	public delegate void OnFinishEventHandler(object sender);

	public delegate void OnRepeatEventHandler(object sender);

	public delegate void OnReverseEventHandler(TransitionDirection oldDirection, TransitionDirection newDirection);

	public readonly string ID;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OnFinishEventHandler onFinishEventHandler_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OnRepeatEventHandler onRepeatEventHandler_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OnReverseEventHandler onReverseEventHandler_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object object_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object object_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object object_2;

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
	[CompilerGenerated]
	private bool bool_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private long long_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TimeSpan timeSpan_0;

	private long long_1;

	private long long_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TransitionDirection transitionDirection_0;

	private TransitionWorkElement transitionWorkElement_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_5;

	public bool ReverseUsesDuration
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

	public object A
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
		[CompilerGenerated]
		set
		{
			object_0 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object B
	{
		[CompilerGenerated]
		get
		{
			return object_1;
		}
		[CompilerGenerated]
		set
		{
			object_1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public bool Reverse
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

	public bool Repeat
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

	public bool Enabled
	{
		get
		{
			return method_2();
		}
		set
		{
			if (value)
			{
				long_1 = DateAndTime.get_Now().Ticks;
				method_10();
			}
			method_3(value);
		}
	}

	public bool Paused
	{
		get
		{
			return method_4();
		}
		set
		{
			checked
			{
				if (value)
				{
					method_7(DateAndTime.get_Now().Ticks);
				}
				else if (!value && method_4())
				{
					_ = method_6() - long_1;
					long_1 = DateAndTime.get_Now().Ticks - method_6();
				}
				method_5(value);
			}
		}
	}

	public TimeSpan Duration
	{
		[CompilerGenerated]
		get
		{
			return timeSpan_0;
		}
		[CompilerGenerated]
		set
		{
			timeSpan_0 = value;
		}
	}

	public TransitionDirection Direction
	{
		[CompilerGenerated]
		get
		{
			return transitionDirection_0;
		}
		[CompilerGenerated]
		set
		{
			transitionDirection_0 = value;
		}
	}

	public bool isFinished => method_12();

	public object Value
	{
		get
		{
			long num = method_8();
			double num2 = (double)num / ((ReverseUsesDuration & Reverse) ? ((double)Duration.Ticks / 2.0) : ((double)Duration.Ticks));
			if ((Enabled & !Paused) && num2 < 1.0)
			{
				return method_11(num2);
			}
			if ((Enabled & !Paused) && num2 >= 1.0)
			{
				if ((!Reverse & !Repeat) | (Reverse && !Repeat && transitionDirection_0 == TransitionDirection.Backward))
				{
					method_14();
					return lastValue;
				}
				if (!Reverse & Repeat)
				{
					method_1(RuntimeHelpers.GetObjectValue(A));
					onRepeatEventHandler_0?.Invoke(this);
				}
				else
				{
					onReverseEventHandler_0?.Invoke(Direction, (Direction != TransitionDirection.Forward) ? TransitionDirection.Forward : TransitionDirection.Backward);
					method_9();
				}
				method_10();
				long_1 = DateAndTime.get_Now().Ticks;
			}
			return lastValue;
		}
	}

	public object lastValue => method_0();

	public event OnFinishEventHandler OnFinish
	{
		[CompilerGenerated]
		add
		{
			OnFinishEventHandler onFinishEventHandler = onFinishEventHandler_0;
			OnFinishEventHandler onFinishEventHandler2;
			do
			{
				onFinishEventHandler2 = onFinishEventHandler;
				OnFinishEventHandler value2 = (OnFinishEventHandler)Delegate.Combine(onFinishEventHandler2, value);
				onFinishEventHandler = Interlocked.CompareExchange(ref onFinishEventHandler_0, value2, onFinishEventHandler2);
			}
			while ((object)onFinishEventHandler != onFinishEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			OnFinishEventHandler onFinishEventHandler = onFinishEventHandler_0;
			OnFinishEventHandler onFinishEventHandler2;
			do
			{
				onFinishEventHandler2 = onFinishEventHandler;
				OnFinishEventHandler value2 = (OnFinishEventHandler)Delegate.Remove(onFinishEventHandler2, value);
				onFinishEventHandler = Interlocked.CompareExchange(ref onFinishEventHandler_0, value2, onFinishEventHandler2);
			}
			while ((object)onFinishEventHandler != onFinishEventHandler2);
		}
	}

	public event OnRepeatEventHandler OnRepeat
	{
		[CompilerGenerated]
		add
		{
			OnRepeatEventHandler onRepeatEventHandler = onRepeatEventHandler_0;
			OnRepeatEventHandler onRepeatEventHandler2;
			do
			{
				onRepeatEventHandler2 = onRepeatEventHandler;
				OnRepeatEventHandler value2 = (OnRepeatEventHandler)Delegate.Combine(onRepeatEventHandler2, value);
				onRepeatEventHandler = Interlocked.CompareExchange(ref onRepeatEventHandler_0, value2, onRepeatEventHandler2);
			}
			while ((object)onRepeatEventHandler != onRepeatEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			OnRepeatEventHandler onRepeatEventHandler = onRepeatEventHandler_0;
			OnRepeatEventHandler onRepeatEventHandler2;
			do
			{
				onRepeatEventHandler2 = onRepeatEventHandler;
				OnRepeatEventHandler value2 = (OnRepeatEventHandler)Delegate.Remove(onRepeatEventHandler2, value);
				onRepeatEventHandler = Interlocked.CompareExchange(ref onRepeatEventHandler_0, value2, onRepeatEventHandler2);
			}
			while ((object)onRepeatEventHandler != onRepeatEventHandler2);
		}
	}

	public event OnReverseEventHandler OnReverse
	{
		[CompilerGenerated]
		add
		{
			OnReverseEventHandler onReverseEventHandler = onReverseEventHandler_0;
			OnReverseEventHandler onReverseEventHandler2;
			do
			{
				onReverseEventHandler2 = onReverseEventHandler;
				OnReverseEventHandler value2 = (OnReverseEventHandler)Delegate.Combine(onReverseEventHandler2, value);
				onReverseEventHandler = Interlocked.CompareExchange(ref onReverseEventHandler_0, value2, onReverseEventHandler2);
			}
			while ((object)onReverseEventHandler != onReverseEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			OnReverseEventHandler onReverseEventHandler = onReverseEventHandler_0;
			OnReverseEventHandler onReverseEventHandler2;
			do
			{
				onReverseEventHandler2 = onReverseEventHandler;
				OnReverseEventHandler value2 = (OnReverseEventHandler)Delegate.Remove(onReverseEventHandler2, value);
				onReverseEventHandler = Interlocked.CompareExchange(ref onReverseEventHandler_0, value2, onReverseEventHandler2);
			}
			while ((object)onReverseEventHandler != onReverseEventHandler2);
		}
	}

	public void Reset()
	{
		if (isFinished)
		{
			method_13(AutoPropertyValue: false);
			Direction = TransitionDirection.Forward;
			method_1(RuntimeHelpers.GetObjectValue(A));
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private object method_0()
	{
		return object_2;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(object AutoPropertyValue)
	{
		object_2 = RuntimeHelpers.GetObjectValue(AutoPropertyValue);
	}

	public Transition(object A, object B)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		ID = Guid.NewGuid().ToString();
		Reverse = false;
		Repeat = false;
		method_3(AutoPropertyValue: false);
		method_5(AutoPropertyValue: false);
		Duration = TimeSpan.FromSeconds(1.0);
		long_2 = DateAndTime.get_Now().Ticks;
		Direction = TransitionDirection.Forward;
		method_13(AutoPropertyValue: false);
		this.A = RuntimeHelpers.GetObjectValue(A);
		this.B = RuntimeHelpers.GetObjectValue(B);
		method_1(RuntimeHelpers.GetObjectValue(A));
		method_10();
	}

	public Transition(object StartPosition, object A, object B, TimeSpan Duration = default(TimeSpan), bool Enabled = false)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		ID = Guid.NewGuid().ToString();
		Reverse = false;
		Repeat = false;
		method_3(AutoPropertyValue: false);
		method_5(AutoPropertyValue: false);
		this.Duration = TimeSpan.FromSeconds(1.0);
		long_2 = DateAndTime.get_Now().Ticks;
		Direction = TransitionDirection.Forward;
		method_13(AutoPropertyValue: false);
		this.A = RuntimeHelpers.GetObjectValue(A);
		this.B = RuntimeHelpers.GetObjectValue(B);
		method_1(RuntimeHelpers.GetObjectValue(StartPosition));
		method_10();
		this.Duration = ((Duration.Ticks == 0L) ? this.Duration : Duration);
		this.Enabled = Enabled;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_2()
	{
		return bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(bool AutoPropertyValue)
	{
		bool_3 = AutoPropertyValue;
	}

	public void Start()
	{
		Enabled = true;
	}

	public void Stop()
	{
		Enabled = false;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_4()
	{
		return bool_4;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_5(bool AutoPropertyValue)
	{
		bool_4 = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_6()
	{
		return long_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_7(long AutoPropertyValue)
	{
		long_0 = AutoPropertyValue;
	}

	private long method_8()
	{
		long ticks = DateAndTime.get_Now().Ticks;
		return checked(ticks - long_1);
	}

	private void method_9()
	{
		Direction = ((Direction != TransitionDirection.Forward) ? TransitionDirection.Forward : TransitionDirection.Backward);
	}

	public abstract object ConvertFromRaw(double[] rawValues);

	public abstract double[] ConvertToRaw(object obj);

	private void method_10()
	{
		double[] array = ConvertToRaw(RuntimeHelpers.GetObjectValue(method_0()));
		double[] array2 = ConvertToRaw(RuntimeHelpers.GetObjectValue((Direction == TransitionDirection.Forward) ? B : A));
		checked
		{
			double[] array3 = new double[array.Length - 1 + 1];
			int num = array.Length - 1;
			for (int i = num; i >= 0; i += -1)
			{
				array3[i] = array2[i] - array[i];
			}
			transitionWorkElement_0 = new TransitionWorkElement(array, array3);
		}
	}

	[SpecialName]
	private object method_11(double time)
	{
		double[] array = ConvertToRaw(RuntimeHelpers.GetObjectValue(method_0()));
		checked
		{
			int num = transitionWorkElement_0.Work.Length - 1;
			for (int i = num; i >= 0; i += -1)
			{
				array[i] = transitionWorkElement_0.StartPosition[i] + transitionWorkElement_0.Work[i] * time;
			}
			method_1(RuntimeHelpers.GetObjectValue(ConvertFromRaw(array)));
			return method_0();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_12()
	{
		return bool_5;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_13(bool AutoPropertyValue)
	{
		bool_5 = AutoPropertyValue;
	}

	private void method_14()
	{
		method_3(AutoPropertyValue: false);
		onFinishEventHandler_0?.Invoke(this);
		method_13(AutoPropertyValue: true);
	}
}
