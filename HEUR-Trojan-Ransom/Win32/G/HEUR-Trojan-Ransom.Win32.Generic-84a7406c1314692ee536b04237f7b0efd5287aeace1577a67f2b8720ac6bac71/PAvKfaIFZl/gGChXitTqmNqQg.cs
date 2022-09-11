using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PAvKfaIFZl;

public sealed class gGChXitTqmNqQg : IEnumerable<string>, IEnumerable
{
	private sealed class PeVJmPliRNHCTb : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string xgwcRZTwFpWG;

		private int bbBWbbsDIvlAF;

		public gGChXitTqmNqQg GFSBozWTnZpZU;

		public List<string> RhTZMezuToqH;

		public XovkoNBycBOnCD ZHylTrpPUvKd;

		public XovkoNBycBOnCD hnIAPcxJlC;

		public int xnxlggnfVTJr;

		public string sUnjoupYgklrHZ;

		public Dictionary<ulong, XovkoNBycBOnCD>.ValueCollection.Enumerator XcPbwPSCZOqti;

		string IEnumerator<string>.Current => xgwcRZTwFpWG;

		object IEnumerator.Current => xgwcRZTwFpWG;

		private bool MoveNext()
		{
			try
			{
				switch (bbBWbbsDIvlAF)
				{
				case 0:
					bbBWbbsDIvlAF = -1;
					GFSBozWTnZpZU.dRZFiVkwWzJXbO();
					RhTZMezuToqH = new List<string>();
					XcPbwPSCZOqti = GFSBozWTnZpZU.JfOBHuPmGu.Values.GetEnumerator();
					bbBWbbsDIvlAF = 1;
					goto IL_019e;
				case 2:
					{
						bbBWbbsDIvlAF = 1;
						goto IL_019e;
					}
					IL_019e:
					while (XcPbwPSCZOqti.MoveNext())
					{
						ZHylTrpPUvKd = XcPbwPSCZOqti.Current;
						RhTZMezuToqH.Clear();
						hnIAPcxJlC = ZHylTrpPUvKd;
						xnxlggnfVTJr = -1;
						do
						{
							if (hnIAPcxJlC.ParentFrn != 0L)
							{
								RhTZMezuToqH.Add(hnIAPcxJlC.Name);
							}
							if (GFSBozWTnZpZU.JfOBHuPmGu.ContainsKey(hnIAPcxJlC.ParentFrn))
							{
								hnIAPcxJlC = GFSBozWTnZpZU.JfOBHuPmGu[hnIAPcxJlC.ParentFrn];
							}
							else if (GFSBozWTnZpZU.AlhuXCvUzDhM.ContainsKey(hnIAPcxJlC.ParentFrn))
							{
								hnIAPcxJlC = GFSBozWTnZpZU.AlhuXCvUzDhM[hnIAPcxJlC.ParentFrn];
							}
							else
							{
								hnIAPcxJlC = null;
							}
						}
						while (hnIAPcxJlC != null && ++xnxlggnfVTJr < 1000);
						if (RhTZMezuToqH.Count != 0)
						{
							RhTZMezuToqH.Reverse();
							sUnjoupYgklrHZ = GFSBozWTnZpZU.YDlcCDNkfWAGN + '\\' + Path.Combine(RhTZMezuToqH.ToArray());
							xgwcRZTwFpWG = sUnjoupYgklrHZ;
							bbBWbbsDIvlAF = 2;
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
			switch (bbBWbbsDIvlAF)
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

		public PeVJmPliRNHCTb(int int_0)
		{
			bbBWbbsDIvlAF = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			bbBWbbsDIvlAF = -1;
			((IDisposable)XcPbwPSCZOqti).Dispose();
		}
	}

	private Dictionary<ulong, XovkoNBycBOnCD> JfOBHuPmGu;

	private Dictionary<ulong, XovkoNBycBOnCD> AlhuXCvUzDhM;

	private readonly string YDlcCDNkfWAGN;

	public gGChXitTqmNqQg(string string_0)
	{
		YDlcCDNkfWAGN = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		PeVJmPliRNHCTb peVJmPliRNHCTb = new PeVJmPliRNHCTb(0);
		peVJmPliRNHCTb.GFSBozWTnZpZU = this;
		return peVJmPliRNHCTb;
	}

	private void dRZFiVkwWzJXbO()
	{
		if (JfOBHuPmGu == null)
		{
			FntIdrUCcqfQMx fntIdrUCcqfQMx = new FntIdrUCcqfQMx();
			fntIdrUCcqfQMx.EdJeFavqgTF(YDlcCDNkfWAGN, null, out JfOBHuPmGu, out AlhuXCvUzDhM);
		}
	}
}
