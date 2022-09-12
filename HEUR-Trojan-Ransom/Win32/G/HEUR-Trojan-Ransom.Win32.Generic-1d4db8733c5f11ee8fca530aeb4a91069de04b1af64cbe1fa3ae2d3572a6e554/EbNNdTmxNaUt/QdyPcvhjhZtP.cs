using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EbNNdTmxNaUt;

public sealed class QdyPcvhjhZtP : IEnumerable<string>, IEnumerable
{
	private sealed class TorSSUbwlcW : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string hfMYqDULWlNj;

		private int XYkKIGBwgfaoLL;

		public QdyPcvhjhZtP wJyalXNgTTzc;

		public List<string> lULeJhJjDQnCD;

		public gscyLTjmBf fDgfrsexlySQGS;

		public gscyLTjmBf yemWgdydcQ;

		public int RUcnEqUJXet;

		public string ZUfzseLuJBUIgkZ;

		public Dictionary<ulong, gscyLTjmBf>.ValueCollection.Enumerator MCfVMCOcDmH;

		string IEnumerator<string>.Current => hfMYqDULWlNj;

		object IEnumerator.Current => hfMYqDULWlNj;

		private bool MoveNext()
		{
			try
			{
				switch (XYkKIGBwgfaoLL)
				{
				case 0:
					XYkKIGBwgfaoLL = -1;
					wJyalXNgTTzc.eGLObvqxqTZ();
					lULeJhJjDQnCD = new List<string>();
					MCfVMCOcDmH = wJyalXNgTTzc.vUiqVfPrYxX.Values.GetEnumerator();
					XYkKIGBwgfaoLL = 1;
					goto IL_018e;
				case 2:
					{
						XYkKIGBwgfaoLL = 1;
						goto IL_018e;
					}
					IL_018e:
					while (MCfVMCOcDmH.MoveNext())
					{
						fDgfrsexlySQGS = MCfVMCOcDmH.Current;
						lULeJhJjDQnCD.Clear();
						yemWgdydcQ = fDgfrsexlySQGS;
						RUcnEqUJXet = -1;
						do
						{
							if (yemWgdydcQ.ParentFrn != 0L)
							{
								lULeJhJjDQnCD.Add(yemWgdydcQ.Name);
							}
							if (wJyalXNgTTzc.vUiqVfPrYxX.ContainsKey(yemWgdydcQ.ParentFrn))
							{
								yemWgdydcQ = wJyalXNgTTzc.vUiqVfPrYxX[yemWgdydcQ.ParentFrn];
							}
							else if (wJyalXNgTTzc.RwRYcnGkxg.ContainsKey(yemWgdydcQ.ParentFrn))
							{
								yemWgdydcQ = wJyalXNgTTzc.RwRYcnGkxg[yemWgdydcQ.ParentFrn];
							}
							else
							{
								yemWgdydcQ = null;
							}
						}
						while (yemWgdydcQ != null && ++RUcnEqUJXet < 1000);
						if (lULeJhJjDQnCD.Count != 0)
						{
							lULeJhJjDQnCD.Reverse();
							ZUfzseLuJBUIgkZ = wJyalXNgTTzc.FigiclpimPfO + '\\' + Path.Combine(lULeJhJjDQnCD.ToArray());
							hfMYqDULWlNj = ZUfzseLuJBUIgkZ;
							XYkKIGBwgfaoLL = 2;
							return true;
						}
					}
					_003C_003Em__Finally7();
					break;
				}
				return false;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		void IDisposable.Dispose()
		{
			switch (XYkKIGBwgfaoLL)
			{
			case 1:
			case 2:
				try
				{
					break;
				}
				finally
				{
					_003C_003Em__Finally7();
				}
			}
		}

		public TorSSUbwlcW(int int_0)
		{
			XYkKIGBwgfaoLL = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			XYkKIGBwgfaoLL = -1;
			((IDisposable)MCfVMCOcDmH).Dispose();
		}
	}

	private Dictionary<ulong, gscyLTjmBf> vUiqVfPrYxX;

	private Dictionary<ulong, gscyLTjmBf> RwRYcnGkxg;

	private readonly string FigiclpimPfO;

	public QdyPcvhjhZtP(string string_0)
	{
		FigiclpimPfO = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		TorSSUbwlcW torSSUbwlcW = new TorSSUbwlcW(0);
		torSSUbwlcW.wJyalXNgTTzc = this;
		return torSSUbwlcW;
	}

	private void eGLObvqxqTZ()
	{
		if (vUiqVfPrYxX == null)
		{
			aMKFziBBCmob aMKFziBBCmob2 = new aMKFziBBCmob();
			aMKFziBBCmob2.npFmhzJJPSuN(FigiclpimPfO, null, out vUiqVfPrYxX, out RwRYcnGkxg);
		}
	}
}
