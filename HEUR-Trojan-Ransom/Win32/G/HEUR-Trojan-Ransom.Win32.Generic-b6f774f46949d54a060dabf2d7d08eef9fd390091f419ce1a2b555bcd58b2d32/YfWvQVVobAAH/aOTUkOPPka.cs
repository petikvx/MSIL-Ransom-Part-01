using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace YfWvQVVobAAH;

public sealed class aOTUkOPPka : IEnumerable<string>, IEnumerable
{
	private sealed class DGEvvPonwVdBfyyy : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string CluOLNoqEYU;

		private int UNvQsscdeocC;

		public aOTUkOPPka oDKncYElwWpgIe;

		public List<string> TLaDpBZmULKKtE;

		public FxgptJiCPLzC tMSPsBTlpUP;

		public FxgptJiCPLzC aoaKSkuFoXop;

		public int mCVDpkYgDMGUoBYh;

		public string AOjjqoTkwPqf;

		public Dictionary<ulong, FxgptJiCPLzC>.ValueCollection.Enumerator ylbQUDvbOgMCongN;

		string IEnumerator<string>.Current => CluOLNoqEYU;

		object IEnumerator.Current => CluOLNoqEYU;

		private bool MoveNext()
		{
			try
			{
				switch (UNvQsscdeocC)
				{
				case 0:
					UNvQsscdeocC = -1;
					oDKncYElwWpgIe.dsxZDgrKdiOyAP();
					TLaDpBZmULKKtE = new List<string>();
					ylbQUDvbOgMCongN = oDKncYElwWpgIe.OtcaZBWeuQh.Values.GetEnumerator();
					UNvQsscdeocC = 1;
					goto IL_018e;
				case 2:
					{
						UNvQsscdeocC = 1;
						goto IL_018e;
					}
					IL_018e:
					while (ylbQUDvbOgMCongN.MoveNext())
					{
						tMSPsBTlpUP = ylbQUDvbOgMCongN.Current;
						TLaDpBZmULKKtE.Clear();
						aoaKSkuFoXop = tMSPsBTlpUP;
						mCVDpkYgDMGUoBYh = -1;
						do
						{
							if (aoaKSkuFoXop.ParentFrn != 0L)
							{
								TLaDpBZmULKKtE.Add(aoaKSkuFoXop.Name);
							}
							if (oDKncYElwWpgIe.OtcaZBWeuQh.ContainsKey(aoaKSkuFoXop.ParentFrn))
							{
								aoaKSkuFoXop = oDKncYElwWpgIe.OtcaZBWeuQh[aoaKSkuFoXop.ParentFrn];
							}
							else if (oDKncYElwWpgIe.beDhrlZaooYH.ContainsKey(aoaKSkuFoXop.ParentFrn))
							{
								aoaKSkuFoXop = oDKncYElwWpgIe.beDhrlZaooYH[aoaKSkuFoXop.ParentFrn];
							}
							else
							{
								aoaKSkuFoXop = null;
							}
						}
						while (aoaKSkuFoXop != null && ++mCVDpkYgDMGUoBYh < 1000);
						if (TLaDpBZmULKKtE.Count != 0)
						{
							TLaDpBZmULKKtE.Reverse();
							AOjjqoTkwPqf = oDKncYElwWpgIe.aQRCDwEaphv + '\\' + Path.Combine(TLaDpBZmULKKtE.ToArray());
							CluOLNoqEYU = AOjjqoTkwPqf;
							UNvQsscdeocC = 2;
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
			switch (UNvQsscdeocC)
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

		public DGEvvPonwVdBfyyy(int int_0)
		{
			UNvQsscdeocC = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			UNvQsscdeocC = -1;
			((IDisposable)ylbQUDvbOgMCongN).Dispose();
		}
	}

	private Dictionary<ulong, FxgptJiCPLzC> OtcaZBWeuQh;

	private Dictionary<ulong, FxgptJiCPLzC> beDhrlZaooYH;

	private readonly string aQRCDwEaphv;

	public aOTUkOPPka(string string_0)
	{
		aQRCDwEaphv = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		DGEvvPonwVdBfyyy dGEvvPonwVdBfyyy = new DGEvvPonwVdBfyyy(0);
		dGEvvPonwVdBfyyy.oDKncYElwWpgIe = this;
		return dGEvvPonwVdBfyyy;
	}

	private void dsxZDgrKdiOyAP()
	{
		if (OtcaZBWeuQh == null)
		{
			EfCdADPdiV efCdADPdiV = new EfCdADPdiV();
			efCdADPdiV.vAEyrsAhZXXPqiz(aQRCDwEaphv, null, out OtcaZBWeuQh, out beDhrlZaooYH);
		}
	}
}
