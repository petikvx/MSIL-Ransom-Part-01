using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace dfb44QxstTvciGRseP;

public class os8ccuxHm2mZ39syimh : IDisposable
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool yRKTqe7xNU;

	private ConcurrentQueue<ManualResetEventSlim> qsHT3ulL9p;

	internal static os8ccuxHm2mZ39syimh C029nJDoBlhiv5apk1G;

	[SpecialName]
	[CompilerGenerated]
	public bool DaKTAMWgNg()
	{
		return yRKTqe7xNU;
	}

	[SpecialName]
	[CompilerGenerated]
	public void srcTeqxUhC(bool bool_0)
	{
		yRKTqe7xNU = bool_0;
	}

	[SpecialName]
	public int CpUTFDbTJW()
	{
		return qsHT3ulL9p.Count;
	}

	public os8ccuxHm2mZ39syimh()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		yRKTqe7xNU = false;
		base._002Ector();
		qsHT3ulL9p = new ConcurrentQueue<ManualResetEventSlim>();
	}

	public void Dispose()
	{
		lock (qsHT3ulL9p)
		{
			using (IEnumerator<ManualResetEventSlim> enumerator = qsHT3ulL9p.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManualResetEventSlim current = enumerator.Current;
					current.Set();
					current.Dispose();
				}
				int num = 0;
				if (T9QWR0DpJ6Z0JZ2GxFW() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			int num5 = default(int);
			while (true)
			{
				int num3 = 0;
				while (true)
				{
					if (num3 < pXUHu4Djp8cp9hOy7Ni(qsHT3ulL9p))
					{
						qsHT3ulL9p.TryDequeue(out var _);
						int num4 = 1;
						if (T9QWR0DpJ6Z0JZ2GxFW() != null)
						{
							num4 = num5;
						}
						switch (num4)
						{
						case 1:
							goto IL_009a;
						}
						break;
					}
					return;
					IL_009a:
					num3++;
				}
			}
		}
	}

	private ManualResetEventSlim Xc4THGdEFT()
	{
		ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim();
		qsHT3ulL9p.Enqueue(manualResetEventSlim);
		return manualResetEventSlim;
	}

	public void LOXTto5uoM()
	{
		Xc4THGdEFT().Wait();
	}

	public bool Xj5Tl0Ektg(int int_0)
	{
		return Xc4THGdEFT().Wait(int_0);
	}

	public void DC0TJid0sX()
	{
		if (qsHT3ulL9p.TryDequeue(out var result))
		{
			result.Set();
			result.Dispose();
		}
		else
		{
			if (!DaKTAMWgNg())
			{
				return;
			}
			if (!HJbfydDdrVxKCtPh6NC())
			{
				switch (0)
				{
				}
			}
			throw new InvalidOperationException("The call queue is empty.");
		}
	}

	internal static bool HJbfydDdrVxKCtPh6NC()
	{
		return C029nJDoBlhiv5apk1G == null;
	}

	internal static os8ccuxHm2mZ39syimh T9QWR0DpJ6Z0JZ2GxFW()
	{
		return C029nJDoBlhiv5apk1G;
	}

	internal static int pXUHu4Djp8cp9hOy7Ni(object object_0)
	{
		return ((ConcurrentQueue<ManualResetEventSlim>)object_0).Count;
	}
}
