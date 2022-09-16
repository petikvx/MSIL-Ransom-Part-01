using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace dfb44QxstTvciGRseP;

public class cUshwsxxDtxmPvRmdE4 : IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class DPJwEic8jtq6yfkEalV
	{
		public static readonly DPJwEic8jtq6yfkEalV H0RMWU8of6;

		public static Func<ushort, int> wEuMUtUXsr;

		internal static DPJwEic8jtq6yfkEalV Fp5vgfs5wmm0it5HcGY;

		static DPJwEic8jtq6yfkEalV()
		{
			aHKBHGsp4p0tl5Wgnaq();
			H0RMWU8of6 = new DPJwEic8jtq6yfkEalV();
		}

		public DPJwEic8jtq6yfkEalV()
		{
			GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
			base._002Ector();
		}

		internal int ys6Mb9Ishj(ushort n)
		{
			return n;
		}

		internal static void aHKBHGsp4p0tl5Wgnaq()
		{
			GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		}

		internal static bool GtUNmJsog6jmiFW3R0P()
		{
			return Fp5vgfs5wmm0it5HcGY == null;
		}

		internal static DPJwEic8jtq6yfkEalV jUSLWWsdyuauqYYlXSj()
		{
			return Fp5vgfs5wmm0it5HcGY;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool ttOTa37kKN;

	private ConcurrentDictionary<ushort, ManualResetEvent> oqCTIAvQyD;

	private Dictionary<ushort, object> GZNTn73ZEM;

	internal static cUshwsxxDtxmPvRmdE4 PopGdBDCZesODL4AQjK;

	[SpecialName]
	[CompilerGenerated]
	public bool AMDTu5WcpH()
	{
		return ttOTa37kKN;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SeKTMhXMmY(bool bool_0)
	{
		ttOTa37kKN = bool_0;
	}

	[SpecialName]
	public int mn7TReKKJj()
	{
		return oqCTIAvQyD.Count;
	}

	public cUshwsxxDtxmPvRmdE4()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		ttOTa37kKN = false;
		base._002Ector();
		oqCTIAvQyD = new ConcurrentDictionary<ushort, ManualResetEvent>();
		GZNTn73ZEM = new Dictionary<ushort, object>();
	}

	public void Dispose()
	{
		lock (oqCTIAvQyD)
		{
			int num = 0;
			if (!Bv4XVKDTqWTHCwjW4lt())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			using (IEnumerator<ManualResetEvent> enumerator = oqCTIAvQyD.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManualResetEvent current = enumerator.Current;
					current.Set();
					current.Dispose();
				}
				int num3 = 0;
				if (!Bv4XVKDTqWTHCwjW4lt())
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
			BDEGIFD36GF2QtY8ooZ(oqCTIAvQyD);
			GZNTn73ZEM.Clear();
		}
	}

	public ushort GFUTsecKrB()
	{
		ManualResetEvent value = new ManualResetEvent(initialState: false);
		lock (oqCTIAvQyD)
		{
			ushort num = (ushort)Enumerable.Range(1, 65535).Except(((IEnumerable<ushort>)oqCTIAvQyD.Keys).Select((Func<ushort, int>)((ushort n) => n))).First();
			if (!oqCTIAvQyD.TryAdd(num, value))
			{
				int num2 = 0;
				if (TS5kIlDqP7vDW23kpbF() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					throw new Exception("Unable to add turn to WaitBag.");
				}
			}
			return num;
		}
	}

	private ManualResetEvent fm6Th8Gjbc(in ushort key)
	{
		ManualResetEvent result;
		if (oqCTIAvQyD.TryGetValue(key, out var value))
		{
			result = value;
		}
		else
		{
			if (AMDTu5WcpH())
			{
				throw new InvalidOperationException("WaitBag does not contain this key.");
			}
			result = null;
			if (TS5kIlDqP7vDW23kpbF() == null)
			{
				switch (0)
				{
				}
			}
		}
		return result;
	}

	public void WLxTLb6F8o(in ushort key)
	{
		NUS1EIDYyCV9Gjs21BO(fm6Th8Gjbc(in key));
	}

	public bool zBKTpQVaCl(int int_0, in ushort key)
	{
		return zOMm7IDLUrgbLwUK40i(fm6Th8Gjbc(in key), int_0);
	}

	public object zx0TTy5YRU(in ushort key)
	{
		lock (GZNTn73ZEM)
		{
			if (GZNTn73ZEM.ContainsKey(key))
			{
				object result = GZNTn73ZEM[key];
				GZNTn73ZEM.Remove(key);
				return result;
			}
			object obj = null;
			int num = 0;
			if (TS5kIlDqP7vDW23kpbF() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => obj, 
			};
		}
	}

	public void inWTS8kjYU(ushort ushort_0, object object_0 = null)
	{
		int num;
		Dictionary<ushort, object> gZNTn73ZEM = default(Dictionary<ushort, object>);
		bool lockTaken = default(bool);
		if (!oqCTIAvQyD.TryRemove(ushort_0, out var value))
		{
			num = 0;
			if (!Bv4XVKDTqWTHCwjW4lt())
			{
				goto IL_004b;
			}
		}
		else
		{
			gZNTn73ZEM = GZNTn73ZEM;
			lockTaken = false;
			num = 1;
			if (TS5kIlDqP7vDW23kpbF() != null)
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			try
			{
				Monitor.Enter(gZNTn73ZEM, ref lockTaken);
				GZNTn73ZEM[ushort_0] = object_0;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(gZNTn73ZEM);
				}
			}
			value.Set();
			value.Dispose();
			return;
		}
		goto IL_004b;
		IL_004b:
		if (AMDTu5WcpH())
		{
			throw new InvalidOperationException("WaitBag does not contain this key.");
		}
	}

	internal static bool Bv4XVKDTqWTHCwjW4lt()
	{
		return PopGdBDCZesODL4AQjK == null;
	}

	internal static cUshwsxxDtxmPvRmdE4 TS5kIlDqP7vDW23kpbF()
	{
		return PopGdBDCZesODL4AQjK;
	}

	internal static void BDEGIFD36GF2QtY8ooZ(object object_0)
	{
		((ConcurrentDictionary<ushort, ManualResetEvent>)object_0).Clear();
	}

	internal static bool NUS1EIDYyCV9Gjs21BO(object object_0)
	{
		return ((WaitHandle)object_0).WaitOne();
	}

	internal static bool zOMm7IDLUrgbLwUK40i(object object_0, int int_0)
	{
		return ((WaitHandle)object_0).WaitOne(int_0);
	}
}
