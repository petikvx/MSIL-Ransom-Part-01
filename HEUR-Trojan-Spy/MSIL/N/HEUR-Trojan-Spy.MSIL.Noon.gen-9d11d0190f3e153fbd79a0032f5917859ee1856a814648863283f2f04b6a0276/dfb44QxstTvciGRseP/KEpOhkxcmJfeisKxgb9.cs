using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace dfb44QxstTvciGRseP;

public class KEpOhkxcmJfeisKxgb9 : IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class UPDYq2cJcOsLy9k3Pmp
	{
		public static readonly UPDYq2cJcOsLy9k3Pmp Qm0M4PUQI9;

		public static Func<ushort, int> gKTMvD1UlS;

		internal static UPDYq2cJcOsLy9k3Pmp QUirW4sj9FuZacQv1E7;

		static UPDYq2cJcOsLy9k3Pmp()
		{
			GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
			Qm0M4PUQI9 = new UPDYq2cJcOsLy9k3Pmp();
		}

		public UPDYq2cJcOsLy9k3Pmp()
		{
			GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
			base._002Ector();
		}

		internal int m4JMxSYHmx(ushort n)
		{
			return n;
		}

		internal static bool mmgg6csE23eBSsrHjHl()
		{
			return QUirW4sj9FuZacQv1E7 == null;
		}

		internal static UPDYq2cJcOsLy9k3Pmp ohvU7hsw5EbrQGCyghf()
		{
			return QUirW4sj9FuZacQv1E7;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool nMdTrodOC9;

	private ConcurrentDictionary<ushort, ManualResetEventSlim> A6eTcsAs8C;

	private Dictionary<ushort, object> dBDT7fJDKs;

	private static KEpOhkxcmJfeisKxgb9 rC6xcIDN5kwCxx5KfFy;

	[SpecialName]
	[CompilerGenerated]
	public bool PbLTDcV3Ni()
	{
		return nMdTrodOC9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void WsaTBnmGYm(bool bool_0)
	{
		nMdTrodOC9 = bool_0;
	}

	[SpecialName]
	public int ctTT1hYlcR()
	{
		return A6eTcsAs8C.Count;
	}

	public KEpOhkxcmJfeisKxgb9()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		nMdTrodOC9 = false;
		base._002Ector();
		A6eTcsAs8C = new ConcurrentDictionary<ushort, ManualResetEventSlim>();
		dBDT7fJDKs = new Dictionary<ushort, object>();
	}

	public void Dispose()
	{
		lock (A6eTcsAs8C)
		{
			foreach (ManualResetEventSlim value in A6eTcsAs8C.Values)
			{
				if (!GxrVT7DOnOLqPGKjFDS())
				{
					switch (0)
					{
					}
				}
				Y61KyKDMV2WghJlVn7n(value);
				value.Dispose();
			}
			A6eTcsAs8C.Clear();
			dBDT7fJDKs.Clear();
			int num = 0;
			if (!GxrVT7DOnOLqPGKjFDS())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	public ushort VsjT5AxYMn()
	{
		ManualResetEventSlim value = new ManualResetEventSlim();
		lock (A6eTcsAs8C)
		{
			ushort num = (ushort)Enumerable.Range(1, 65535).Except(((IEnumerable<ushort>)A6eTcsAs8C.Keys).Select((Func<ushort, int>)((ushort n) => n))).First();
			bool flag = !A6eTcsAs8C.TryAdd(num, value);
			int num2 = 0;
			if (WCd7roD06j4gxYkDxOg() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			default:
				if (flag)
				{
					throw new Exception("Unable to add turn to WaitBag.");
				}
				return num;
			}
		}
	}

	private ManualResetEventSlim I9pTPOcRDr(in ushort key)
	{
		if (A6eTcsAs8C.TryGetValue(key, out var value))
		{
			return value;
		}
		if (PbLTDcV3Ni())
		{
			throw new InvalidOperationException("WaitBag does not contain this key.");
		}
		return null;
	}

	public void QmvTXIy6St(in ushort key)
	{
		djsh7SD66VZRAPn7OyA(I9pTPOcRDr(in key));
	}

	public bool egOT9GcmBY(int int_0, in ushort key)
	{
		return I9pTPOcRDr(in key).Wait(int_0);
	}

	public object T84TyRWgGr(in ushort key)
	{
		lock (dBDT7fJDKs)
		{
			if (dBDT7fJDKs.ContainsKey(key))
			{
				object obj = dBDT7fJDKs[key];
				dBDT7fJDKs.Remove(key);
				object obj2 = obj;
				if (!GxrVT7DOnOLqPGKjFDS())
				{
					return 0 switch
					{
						_ => obj2, 
					};
				}
				return obj2;
			}
			return null;
		}
	}

	public void KBaTf1PqlH(ushort ushort_0, object object_0 = null)
	{
		int num = 1;
		Dictionary<ushort, object> dictionary = default(Dictionary<ushort, object>);
		while (true)
		{
			ManualResetEventSlim value;
			bool flag = !A6eTcsAs8C.TryRemove(ushort_0, out value);
			int num2 = 0;
			if (WCd7roD06j4gxYkDxOg() != null)
			{
				goto IL_0024;
			}
			goto IL_0028;
			IL_0028:
			while (true)
			{
				switch (num2)
				{
				default:
					if (flag)
					{
						if (PbLTDcV3Ni())
						{
							throw new InvalidOperationException("WaitBag does not contain this key.");
						}
						return;
					}
					goto IL_000f;
				case 1:
					break;
				case 2:
				{
					bool lockTaken = false;
					try
					{
						Monitor.Enter(dictionary, ref lockTaken);
						dBDT7fJDKs[ushort_0] = object_0;
					}
					finally
					{
						if (lockTaken)
						{
							gWuvNUD5HKN441muSfB(dictionary);
						}
					}
					value.Set();
					value.Dispose();
					return;
				}
				}
				break;
				IL_000f:
				dictionary = dBDT7fJDKs;
				num2 = 2;
				if (GxrVT7DOnOLqPGKjFDS())
				{
					continue;
				}
				goto IL_0024;
			}
			continue;
			IL_0024:
			num2 = num;
			goto IL_0028;
		}
	}

	internal static bool GxrVT7DOnOLqPGKjFDS()
	{
		return rC6xcIDN5kwCxx5KfFy == null;
	}

	internal static KEpOhkxcmJfeisKxgb9 WCd7roD06j4gxYkDxOg()
	{
		return rC6xcIDN5kwCxx5KfFy;
	}

	internal static void Y61KyKDMV2WghJlVn7n(object object_0)
	{
		((ManualResetEventSlim)object_0).Set();
	}

	internal static void djsh7SD66VZRAPn7OyA(object object_0)
	{
		((ManualResetEventSlim)object_0).Wait();
	}

	internal static void gWuvNUD5HKN441muSfB(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
