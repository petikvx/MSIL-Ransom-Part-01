using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace HxobVrDuhJbMYt;

public sealed class TGhvwhXCaTkEMBM : IEnumerable<string>, IEnumerable
{
	private sealed class XSYMTkZkhNfnx : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string XoiewYhfspGOaJoZl;

		private int sGfjnHSAWphWOtu;

		public TGhvwhXCaTkEMBM IIchnqynIYD;

		public List<string> VpOknCafZjdtr;

		public vDHOYTKrzyM bWZwuusJedwpuvIF;

		public vDHOYTKrzyM dboAzrTYFsVr;

		public int ZerbosTpyfBjiGc;

		public string KiRPLXuwogFXl;

		public Dictionary<ulong, vDHOYTKrzyM>.ValueCollection.Enumerator kQboBTXlWtv;

		string IEnumerator<string>.Current => XoiewYhfspGOaJoZl;

		object IEnumerator.Current => XoiewYhfspGOaJoZl;

		private bool MoveNext()
		{
			try
			{
				switch (sGfjnHSAWphWOtu)
				{
				case 0:
					sGfjnHSAWphWOtu = -1;
					IIchnqynIYD.HBngouaibnpHB();
					VpOknCafZjdtr = new List<string>();
					kQboBTXlWtv = IIchnqynIYD.minCNdILhnyVCEm.Values.GetEnumerator();
					sGfjnHSAWphWOtu = 1;
					goto IL_019e;
				case 2:
					{
						sGfjnHSAWphWOtu = 1;
						goto IL_019e;
					}
					IL_019e:
					while (kQboBTXlWtv.MoveNext())
					{
						bWZwuusJedwpuvIF = kQboBTXlWtv.Current;
						VpOknCafZjdtr.Clear();
						dboAzrTYFsVr = bWZwuusJedwpuvIF;
						ZerbosTpyfBjiGc = -1;
						do
						{
							if (dboAzrTYFsVr.ParentFrn != 0L)
							{
								VpOknCafZjdtr.Add(dboAzrTYFsVr.Name);
							}
							if (IIchnqynIYD.minCNdILhnyVCEm.ContainsKey(dboAzrTYFsVr.ParentFrn))
							{
								dboAzrTYFsVr = IIchnqynIYD.minCNdILhnyVCEm[dboAzrTYFsVr.ParentFrn];
							}
							else if (IIchnqynIYD.vwwuzsFGQn.ContainsKey(dboAzrTYFsVr.ParentFrn))
							{
								dboAzrTYFsVr = IIchnqynIYD.vwwuzsFGQn[dboAzrTYFsVr.ParentFrn];
							}
							else
							{
								dboAzrTYFsVr = null;
							}
						}
						while (dboAzrTYFsVr != null && ++ZerbosTpyfBjiGc < 1000);
						if (VpOknCafZjdtr.Count != 0)
						{
							VpOknCafZjdtr.Reverse();
							KiRPLXuwogFXl = IIchnqynIYD.biXmnUuhREv + '\\' + Path.Combine(VpOknCafZjdtr.ToArray());
							XoiewYhfspGOaJoZl = KiRPLXuwogFXl;
							sGfjnHSAWphWOtu = 2;
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
			switch (sGfjnHSAWphWOtu)
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

		public XSYMTkZkhNfnx(int int_0)
		{
			sGfjnHSAWphWOtu = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			sGfjnHSAWphWOtu = -1;
			((IDisposable)kQboBTXlWtv).Dispose();
		}
	}

	private Dictionary<ulong, vDHOYTKrzyM> minCNdILhnyVCEm;

	private Dictionary<ulong, vDHOYTKrzyM> vwwuzsFGQn;

	private readonly string biXmnUuhREv;

	public TGhvwhXCaTkEMBM(string string_0)
	{
		biXmnUuhREv = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		XSYMTkZkhNfnx xSYMTkZkhNfnx = new XSYMTkZkhNfnx(0);
		xSYMTkZkhNfnx.IIchnqynIYD = this;
		return xSYMTkZkhNfnx;
	}

	private void HBngouaibnpHB()
	{
		if (minCNdILhnyVCEm == null)
		{
			MlaUJHhJrSKE mlaUJHhJrSKE = new MlaUJHhJrSKE();
			mlaUJHhJrSKE.wByqwxhiyFl(biXmnUuhREv, null, out minCNdILhnyVCEm, out vwwuzsFGQn);
		}
	}
}
