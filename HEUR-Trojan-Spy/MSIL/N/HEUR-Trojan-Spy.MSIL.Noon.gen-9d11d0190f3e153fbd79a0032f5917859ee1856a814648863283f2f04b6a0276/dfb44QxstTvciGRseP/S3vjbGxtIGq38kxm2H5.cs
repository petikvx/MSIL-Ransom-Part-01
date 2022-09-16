using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;

namespace dfb44QxstTvciGRseP;

public class S3vjbGxtIGq38kxm2H5 : IDisposable
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action W1hpjriT62;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string kT9pKAOCjX;

	private bool g78pYGtKar;

	private System.Timers.Timer a79pzUCXVt;

	private List<Thread> tikTwU6Slb;

	private static S3vjbGxtIGq38kxm2H5 C17I0hDH27ww6x3klkg;

	[SpecialName]
	[CompilerGenerated]
	public void OgEp4vSxTN(Action action_0)
	{
		Action action = W1hpjriT62;
		Action action2;
		int num2 = default(int);
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, action_0);
			action = Interlocked.CompareExchange(ref W1hpjriT62, value, action2);
			int num = 0;
			if (!afFd3dD1S4TrWOQoNFL())
			{
				num = num2;
			}
			switch (num)
			{
			}
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void SfApvGdEem(Action action_0)
	{
		Action action = W1hpjriT62;
		Action action2;
		int num2 = default(int);
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, action_0);
			action = Interlocked.CompareExchange(ref W1hpjriT62, value, action2);
			int num = 0;
			if (!afFd3dD1S4TrWOQoNFL())
			{
				num = num2;
			}
			switch (num)
			{
			}
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public double cLLpNUXuQ4()
	{
		return a79pzUCXVt.Interval;
	}

	[SpecialName]
	public void hhEpmOuZXr(double double_0)
	{
		a79pzUCXVt.Interval = double_0;
	}

	[SpecialName]
	public bool qFsp8aQA4D()
	{
		return IADKScDkGxu3Lj8SNN9(a79pzUCXVt);
	}

	[SpecialName]
	public void fJ1pg2ThLI(bool bool_0)
	{
		a79pzUCXVt.AutoReset = bool_0;
	}

	[SpecialName]
	public bool VlRpOgYhYd()
	{
		return kj3drRDGwtToOmTaUIK(a79pzUCXVt);
	}

	[SpecialName]
	public void BLxpdoVZhg(bool bool_0)
	{
		a79pzUCXVt.Enabled = (g78pYGtKar = bool_0);
	}

	[SpecialName]
	[CompilerGenerated]
	public string iEEpWfUeAF()
	{
		return kT9pKAOCjX;
	}

	[SpecialName]
	[CompilerGenerated]
	public void rwCpUZuk94(string string_0)
	{
		kT9pKAOCjX = string_0;
	}

	public S3vjbGxtIGq38kxm2H5(double double_0, Action action_0, string string_0 = null, bool bool_0 = false)
	{
		XZOjvXDnWyYMnENyGpE();
		g78pYGtKar = false;
		base._002Ector();
		OgEp4vSxTN(action_0);
		System.Timers.Timer timer = new System.Timers.Timer(double_0);
		RE5n7mDSB7cWimoj4m9(timer, double_0);
		timer.AutoReset = bool_0;
		a79pzUCXVt = timer;
		rwCpUZuk94(string_0 ?? typeof(S3vjbGxtIGq38kxm2H5).FullName);
		ax8HKkDhA9ih618rPZq(a79pzUCXVt, (ElapsedEventHandler)delegate
		{
			b7KpiJ07l7();
		});
		tikTwU6Slb = new List<Thread>(20);
	}

	public void Dispose()
	{
		MNnpQiJTnC(bool_0: true);
		a79pzUCXVt.Dispose();
		W1hpjriT62 = null;
		tikTwU6Slb.Clear();
	}

	public void jP5p3jSFXx()
	{
		if (!g78pYGtKar)
		{
			lock (a79pzUCXVt)
			{
				BLxpdoVZhg(bool_0: true);
			}
		}
	}

	public void MNnpQiJTnC(bool bool_0 = false)
	{
		if (!g78pYGtKar)
		{
			return;
		}
		while (true)
		{
			System.Timers.Timer obj = a79pzUCXVt;
			if (FCCoDcDeUB1X8SuWvq0() != null)
			{
				continue;
			}
			switch (1)
			{
			case 1:
			{
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					BLxpdoVZhg(bool_0: false);
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				if (!bool_0)
				{
					return;
				}
				lock (tikTwU6Slb)
				{
					foreach (Thread item in tikTwU6Slb)
					{
						item.Abort();
					}
					tikTwU6Slb.Clear();
					return;
				}
			}
			}
		}
	}

	private void b7KpiJ07l7()
	{
		int num = 2;
		while (true)
		{
			Thread currentThread = Thread.CurrentThread;
			int num2 = 1;
			if (FCCoDcDeUB1X8SuWvq0() != null)
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					currentThread.Name = iEEpWfUeAF();
					tikTwU6Slb.Add(currentThread);
					W1hpjriT62?.Invoke();
					tikTwU6Slb.Remove(currentThread);
					if (qFsp8aQA4D() || !g78pYGtKar)
					{
						return;
					}
					goto IL_0057;
				default:
					return;
				case 2:
					break;
				case 0:
					return;
				}
				break;
				IL_0057:
				BLxpdoVZhg(bool_0: true);
				num2 = 0;
				if (!afFd3dD1S4TrWOQoNFL())
				{
					return;
				}
			}
		}
	}

	[CompilerGenerated]
	private void J1Ep6wePKD(object sender, ElapsedEventArgs e)
	{
		b7KpiJ07l7();
	}

	internal static bool afFd3dD1S4TrWOQoNFL()
	{
		return C17I0hDH27ww6x3klkg == null;
	}

	internal static S3vjbGxtIGq38kxm2H5 FCCoDcDeUB1X8SuWvq0()
	{
		return C17I0hDH27ww6x3klkg;
	}

	internal static bool IADKScDkGxu3Lj8SNN9(object object_0)
	{
		return ((System.Timers.Timer)object_0).AutoReset;
	}

	internal static bool kj3drRDGwtToOmTaUIK(object object_0)
	{
		return ((System.Timers.Timer)object_0).Enabled;
	}

	internal static void XZOjvXDnWyYMnENyGpE()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
	}

	internal static void RE5n7mDSB7cWimoj4m9(object object_0, double double_0)
	{
		((System.Timers.Timer)object_0).Interval = double_0;
	}

	internal static void ax8HKkDhA9ih618rPZq(object object_0, object object_1)
	{
		((System.Timers.Timer)object_0).Elapsed += (ElapsedEventHandler)object_1;
	}
}
