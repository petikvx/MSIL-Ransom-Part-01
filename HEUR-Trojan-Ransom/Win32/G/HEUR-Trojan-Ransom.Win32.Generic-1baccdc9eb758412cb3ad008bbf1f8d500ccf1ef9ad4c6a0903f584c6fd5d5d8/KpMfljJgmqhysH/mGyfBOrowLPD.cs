using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace KpMfljJgmqhysH;

public sealed class mGyfBOrowLPD : IEnumerable<string>, IEnumerable
{
	private sealed class AXWPVIofSw : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string ugKNeSPttSx;

		private int IgxcnNeZBLsPccZh;

		public mGyfBOrowLPD uHuGMfSNdcrjj;

		public List<string> oCZQaqGnrdJRsBL;

		public McDDHBPuVQei drMGfuuVnwl;

		public McDDHBPuVQei PrfmrewnoemOc;

		public int mKPoZHxTXbVuN;

		public string urZDkJTkEGaIlx;

		public Dictionary<ulong, McDDHBPuVQei>.ValueCollection.Enumerator oytzhEFJSwxm;

		string IEnumerator<string>.Current => ugKNeSPttSx;

		object IEnumerator.Current => ugKNeSPttSx;

		private bool MoveNext()
		{
			try
			{
				switch (IgxcnNeZBLsPccZh)
				{
				case 0:
					IgxcnNeZBLsPccZh = -1;
					uHuGMfSNdcrjj.NwTTGTMfytUxoW();
					oCZQaqGnrdJRsBL = new List<string>();
					oytzhEFJSwxm = uHuGMfSNdcrjj.tzsKxaXibNFj.Values.GetEnumerator();
					IgxcnNeZBLsPccZh = 1;
					goto IL_018e;
				case 2:
					{
						IgxcnNeZBLsPccZh = 1;
						goto IL_018e;
					}
					IL_018e:
					while (oytzhEFJSwxm.MoveNext())
					{
						drMGfuuVnwl = oytzhEFJSwxm.Current;
						oCZQaqGnrdJRsBL.Clear();
						PrfmrewnoemOc = drMGfuuVnwl;
						mKPoZHxTXbVuN = -1;
						do
						{
							if (PrfmrewnoemOc.ParentFrn != 0L)
							{
								oCZQaqGnrdJRsBL.Add(PrfmrewnoemOc.Name);
							}
							if (uHuGMfSNdcrjj.tzsKxaXibNFj.ContainsKey(PrfmrewnoemOc.ParentFrn))
							{
								PrfmrewnoemOc = uHuGMfSNdcrjj.tzsKxaXibNFj[PrfmrewnoemOc.ParentFrn];
							}
							else if (uHuGMfSNdcrjj.sAGBsrjPVlgp.ContainsKey(PrfmrewnoemOc.ParentFrn))
							{
								PrfmrewnoemOc = uHuGMfSNdcrjj.sAGBsrjPVlgp[PrfmrewnoemOc.ParentFrn];
							}
							else
							{
								PrfmrewnoemOc = null;
							}
						}
						while (PrfmrewnoemOc != null && ++mKPoZHxTXbVuN < 1000);
						if (oCZQaqGnrdJRsBL.Count != 0)
						{
							oCZQaqGnrdJRsBL.Reverse();
							urZDkJTkEGaIlx = uHuGMfSNdcrjj.YucjieINLS + '\\' + Path.Combine(oCZQaqGnrdJRsBL.ToArray());
							ugKNeSPttSx = urZDkJTkEGaIlx;
							IgxcnNeZBLsPccZh = 2;
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
			switch (IgxcnNeZBLsPccZh)
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

		public AXWPVIofSw(int int_0)
		{
			IgxcnNeZBLsPccZh = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			IgxcnNeZBLsPccZh = -1;
			((IDisposable)oytzhEFJSwxm).Dispose();
		}
	}

	private Dictionary<ulong, McDDHBPuVQei> tzsKxaXibNFj;

	private Dictionary<ulong, McDDHBPuVQei> sAGBsrjPVlgp;

	private readonly string YucjieINLS;

	public mGyfBOrowLPD(string string_0)
	{
		YucjieINLS = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		AXWPVIofSw aXWPVIofSw = new AXWPVIofSw(0);
		aXWPVIofSw.uHuGMfSNdcrjj = this;
		return aXWPVIofSw;
	}

	private void NwTTGTMfytUxoW()
	{
		if (tzsKxaXibNFj == null)
		{
			oefuEEHuDPssK oefuEEHuDPssK2 = new oefuEEHuDPssK();
			oefuEEHuDPssK2.cQxcsoZrLLwdmk(YucjieINLS, null, out tzsKxaXibNFj, out sAGBsrjPVlgp);
		}
	}
}
