using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass5
{
	public delegate void GDelegate1(object object_0);

	private GDelegate1 gdelegate1_0;

	private int int_0;

	private bool bool_0;

	private Timer timer_0;

	private object object_0;

	public GClass5()
	{
		timer_0 = new Timer(method_8, null, -1, -1);
		object_0 = RuntimeHelpers.GetObjectValue(new object());
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate1 gdelegate1_1)
	{
		gdelegate1_0 = (GDelegate1)Delegate.Combine(gdelegate1_0, gdelegate1_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate1 gdelegate1_1)
	{
		gdelegate1_0 = (GDelegate1)Delegate.Remove(gdelegate1_0, gdelegate1_1);
	}

	public int method_2()
	{
		return int_0;
	}

	public void method_3(int int_1)
	{
		int_0 = int_1;
		if (bool_0)
		{
			timer_0.Change(0, int_0);
		}
	}

	public bool method_4()
	{
		return bool_0;
	}

	public void method_5(bool bool_1)
	{
		if (bool_1)
		{
			method_6();
		}
		else
		{
			method_7();
		}
	}

	public void method_6()
	{
		if (!bool_0)
		{
			bool_0 = true;
			timer_0.Change(0, int_0);
		}
	}

	public void method_7()
	{
		if (bool_0)
		{
			bool_0 = false;
			timer_0.Change(-1, -1);
		}
	}

	private void method_8(object object_1)
	{
		if (bool_0)
		{
			object obj = object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			Monitor.Enter(obj);
			try
			{
				gdelegate1_0?.Invoke(this);
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}
	}
}
