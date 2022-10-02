using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace tvWKXrTHrmpn;

public sealed class LiJShuLfoF : IEnumerable<string>, IEnumerable
{
	private sealed class KHquTvPOshOqP : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string aIpAatdWDwnfx;

		private int solFulgOiOY;

		public LiJShuLfoF lfDMuWUWiTxcUC;

		public List<string> DBTrANDvnnQC;

		public bFlVsRFfhATc GQCZalzaUnfiq;

		public bFlVsRFfhATc vTHxLYtdLi;

		public int gZvbJmiciPsC;

		public string zwhZGhoQAqwIVm;

		public Dictionary<ulong, bFlVsRFfhATc>.ValueCollection.Enumerator GfcZMUAgXsqhCca;

		string IEnumerator<string>.Current => aIpAatdWDwnfx;

		object IEnumerator.Current => aIpAatdWDwnfx;

		private bool MoveNext()
		{
			try
			{
				switch (solFulgOiOY)
				{
				case 0:
					solFulgOiOY = -1;
					lfDMuWUWiTxcUC.aSkmiNmRbjBX();
					DBTrANDvnnQC = new List<string>();
					GfcZMUAgXsqhCca = lfDMuWUWiTxcUC.BjAEKNJqKfDbkh.Values.GetEnumerator();
					solFulgOiOY = 1;
					goto IL_018e;
				case 2:
					{
						solFulgOiOY = 1;
						goto IL_018e;
					}
					IL_018e:
					while (GfcZMUAgXsqhCca.MoveNext())
					{
						GQCZalzaUnfiq = GfcZMUAgXsqhCca.Current;
						DBTrANDvnnQC.Clear();
						vTHxLYtdLi = GQCZalzaUnfiq;
						gZvbJmiciPsC = -1;
						do
						{
							if (vTHxLYtdLi.ParentFrn != 0L)
							{
								DBTrANDvnnQC.Add(vTHxLYtdLi.Name);
							}
							if (lfDMuWUWiTxcUC.BjAEKNJqKfDbkh.ContainsKey(vTHxLYtdLi.ParentFrn))
							{
								vTHxLYtdLi = lfDMuWUWiTxcUC.BjAEKNJqKfDbkh[vTHxLYtdLi.ParentFrn];
							}
							else if (lfDMuWUWiTxcUC.NYGlGhuYsyOFK.ContainsKey(vTHxLYtdLi.ParentFrn))
							{
								vTHxLYtdLi = lfDMuWUWiTxcUC.NYGlGhuYsyOFK[vTHxLYtdLi.ParentFrn];
							}
							else
							{
								vTHxLYtdLi = null;
							}
						}
						while (vTHxLYtdLi != null && ++gZvbJmiciPsC < 1000);
						if (DBTrANDvnnQC.Count != 0)
						{
							DBTrANDvnnQC.Reverse();
							zwhZGhoQAqwIVm = lfDMuWUWiTxcUC.KzBPPIAkIUtg + '\\' + Path.Combine(DBTrANDvnnQC.ToArray());
							aIpAatdWDwnfx = zwhZGhoQAqwIVm;
							solFulgOiOY = 2;
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
			switch (solFulgOiOY)
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

		public KHquTvPOshOqP(int int_0)
		{
			solFulgOiOY = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			solFulgOiOY = -1;
			((IDisposable)GfcZMUAgXsqhCca).Dispose();
		}
	}

	private Dictionary<ulong, bFlVsRFfhATc> BjAEKNJqKfDbkh;

	private Dictionary<ulong, bFlVsRFfhATc> NYGlGhuYsyOFK;

	private readonly string KzBPPIAkIUtg;

	public LiJShuLfoF(string string_0)
	{
		KzBPPIAkIUtg = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		KHquTvPOshOqP kHquTvPOshOqP = new KHquTvPOshOqP(0);
		kHquTvPOshOqP.lfDMuWUWiTxcUC = this;
		return kHquTvPOshOqP;
	}

	private void aSkmiNmRbjBX()
	{
		if (BjAEKNJqKfDbkh == null)
		{
			RYFcAhWMVK rYFcAhWMVK = new RYFcAhWMVK();
			rYFcAhWMVK.uTtOfpheHvEJ(KzBPPIAkIUtg, null, out BjAEKNJqKfDbkh, out NYGlGhuYsyOFK);
		}
	}
}
