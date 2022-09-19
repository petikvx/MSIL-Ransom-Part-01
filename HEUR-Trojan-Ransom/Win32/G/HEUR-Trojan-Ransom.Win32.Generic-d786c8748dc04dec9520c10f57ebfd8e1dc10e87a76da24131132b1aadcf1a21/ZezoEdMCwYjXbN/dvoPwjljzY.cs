using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ZezoEdMCwYjXbN;

public sealed class dvoPwjljzY : IEnumerable<string>, IEnumerable
{
	private sealed class ENEuGMSPfJjrQ : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string RDEMTIoyyxpUyP;

		private int HAxobAEFlDlu;

		public dvoPwjljzY mXMhRhmLbHtwRHDK;

		public List<string> mFpaPUHznhvL;

		public PxVrqMmyWm KJuVxZOohOcXr;

		public PxVrqMmyWm EuedfriOLHI;

		public int ipUjfqYBvCpKSk;

		public string gpveNgqAgiOxsC;

		public Dictionary<ulong, PxVrqMmyWm>.ValueCollection.Enumerator MSbxMhBHMvzP;

		string IEnumerator<string>.Current => RDEMTIoyyxpUyP;

		object IEnumerator.Current => RDEMTIoyyxpUyP;

		private bool MoveNext()
		{
			try
			{
				switch (HAxobAEFlDlu)
				{
				case 0:
					HAxobAEFlDlu = -1;
					mXMhRhmLbHtwRHDK.sqrbonnqYZhczNs();
					mFpaPUHznhvL = new List<string>();
					MSbxMhBHMvzP = mXMhRhmLbHtwRHDK.RRKgrvPDDh.Values.GetEnumerator();
					HAxobAEFlDlu = 1;
					goto IL_018e;
				case 2:
					{
						HAxobAEFlDlu = 1;
						goto IL_018e;
					}
					IL_018e:
					while (MSbxMhBHMvzP.MoveNext())
					{
						KJuVxZOohOcXr = MSbxMhBHMvzP.Current;
						mFpaPUHznhvL.Clear();
						EuedfriOLHI = KJuVxZOohOcXr;
						ipUjfqYBvCpKSk = -1;
						do
						{
							if (EuedfriOLHI.ParentFrn != 0L)
							{
								mFpaPUHznhvL.Add(EuedfriOLHI.Name);
							}
							if (mXMhRhmLbHtwRHDK.RRKgrvPDDh.ContainsKey(EuedfriOLHI.ParentFrn))
							{
								EuedfriOLHI = mXMhRhmLbHtwRHDK.RRKgrvPDDh[EuedfriOLHI.ParentFrn];
							}
							else if (mXMhRhmLbHtwRHDK.ZwoylUalMocDg.ContainsKey(EuedfriOLHI.ParentFrn))
							{
								EuedfriOLHI = mXMhRhmLbHtwRHDK.ZwoylUalMocDg[EuedfriOLHI.ParentFrn];
							}
							else
							{
								EuedfriOLHI = null;
							}
						}
						while (EuedfriOLHI != null && ++ipUjfqYBvCpKSk < 1000);
						if (mFpaPUHznhvL.Count != 0)
						{
							mFpaPUHznhvL.Reverse();
							gpveNgqAgiOxsC = mXMhRhmLbHtwRHDK.nxibjzWMcjmeW + '\\' + Path.Combine(mFpaPUHznhvL.ToArray());
							RDEMTIoyyxpUyP = gpveNgqAgiOxsC;
							HAxobAEFlDlu = 2;
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
			switch (HAxobAEFlDlu)
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

		public ENEuGMSPfJjrQ(int int_0)
		{
			HAxobAEFlDlu = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			HAxobAEFlDlu = -1;
			((IDisposable)MSbxMhBHMvzP).Dispose();
		}
	}

	private Dictionary<ulong, PxVrqMmyWm> RRKgrvPDDh;

	private Dictionary<ulong, PxVrqMmyWm> ZwoylUalMocDg;

	private readonly string nxibjzWMcjmeW;

	public dvoPwjljzY(string string_0)
	{
		nxibjzWMcjmeW = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		ENEuGMSPfJjrQ eNEuGMSPfJjrQ = new ENEuGMSPfJjrQ(0);
		eNEuGMSPfJjrQ.mXMhRhmLbHtwRHDK = this;
		return eNEuGMSPfJjrQ;
	}

	private void sqrbonnqYZhczNs()
	{
		if (RRKgrvPDDh == null)
		{
			XVxmwajqDcnCPbk xVxmwajqDcnCPbk = new XVxmwajqDcnCPbk();
			xVxmwajqDcnCPbk.TCXyaXBBsUyDcNT(nxibjzWMcjmeW, null, out RRKgrvPDDh, out ZwoylUalMocDg);
		}
	}
}
