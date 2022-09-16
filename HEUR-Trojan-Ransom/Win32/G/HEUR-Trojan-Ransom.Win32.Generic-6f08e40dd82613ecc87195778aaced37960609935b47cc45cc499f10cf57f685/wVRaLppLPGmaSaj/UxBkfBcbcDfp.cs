using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace wVRaLppLPGmaSaj;

public sealed class UxBkfBcbcDfp : IEnumerable<string>, IEnumerable
{
	private sealed class XzzUNjKdbHoXN : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string SgzMDOpKPDh;

		private int mmBpRbfPBUjEvJ;

		public UxBkfBcbcDfp agnhlZvRfU;

		public List<string> GOyOBYagvpwALgf;

		public FJuXIlXhWlTe aCkZOzMTDWHUp;

		public FJuXIlXhWlTe ZLdSGBRcDamIAzG;

		public int dAoBILVldCsUTjW;

		public string IdBRAWnnFFoAd;

		public Dictionary<ulong, FJuXIlXhWlTe>.ValueCollection.Enumerator cQYtYryutvG;

		string IEnumerator<string>.Current => SgzMDOpKPDh;

		object IEnumerator.Current => SgzMDOpKPDh;

		private bool MoveNext()
		{
			try
			{
				switch (mmBpRbfPBUjEvJ)
				{
				case 0:
					mmBpRbfPBUjEvJ = -1;
					agnhlZvRfU.SysypShANYuc();
					GOyOBYagvpwALgf = new List<string>();
					cQYtYryutvG = agnhlZvRfU.vHXKsPTuCZFfG.Values.GetEnumerator();
					mmBpRbfPBUjEvJ = 1;
					goto IL_018e;
				case 2:
					{
						mmBpRbfPBUjEvJ = 1;
						goto IL_018e;
					}
					IL_018e:
					while (cQYtYryutvG.MoveNext())
					{
						aCkZOzMTDWHUp = cQYtYryutvG.Current;
						GOyOBYagvpwALgf.Clear();
						ZLdSGBRcDamIAzG = aCkZOzMTDWHUp;
						dAoBILVldCsUTjW = -1;
						do
						{
							if (ZLdSGBRcDamIAzG.ParentFrn != 0L)
							{
								GOyOBYagvpwALgf.Add(ZLdSGBRcDamIAzG.Name);
							}
							if (agnhlZvRfU.vHXKsPTuCZFfG.ContainsKey(ZLdSGBRcDamIAzG.ParentFrn))
							{
								ZLdSGBRcDamIAzG = agnhlZvRfU.vHXKsPTuCZFfG[ZLdSGBRcDamIAzG.ParentFrn];
							}
							else if (agnhlZvRfU.HrmZpiywKuEf.ContainsKey(ZLdSGBRcDamIAzG.ParentFrn))
							{
								ZLdSGBRcDamIAzG = agnhlZvRfU.HrmZpiywKuEf[ZLdSGBRcDamIAzG.ParentFrn];
							}
							else
							{
								ZLdSGBRcDamIAzG = null;
							}
						}
						while (ZLdSGBRcDamIAzG != null && ++dAoBILVldCsUTjW < 1000);
						if (GOyOBYagvpwALgf.Count != 0)
						{
							GOyOBYagvpwALgf.Reverse();
							IdBRAWnnFFoAd = agnhlZvRfU.MuLPZDdhDiwoDZV + '\\' + Path.Combine(GOyOBYagvpwALgf.ToArray());
							SgzMDOpKPDh = IdBRAWnnFFoAd;
							mmBpRbfPBUjEvJ = 2;
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
			switch (mmBpRbfPBUjEvJ)
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

		public XzzUNjKdbHoXN(int int_0)
		{
			mmBpRbfPBUjEvJ = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			mmBpRbfPBUjEvJ = -1;
			((IDisposable)cQYtYryutvG).Dispose();
		}
	}

	private Dictionary<ulong, FJuXIlXhWlTe> vHXKsPTuCZFfG;

	private Dictionary<ulong, FJuXIlXhWlTe> HrmZpiywKuEf;

	private readonly string MuLPZDdhDiwoDZV;

	public UxBkfBcbcDfp(string string_0)
	{
		MuLPZDdhDiwoDZV = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		XzzUNjKdbHoXN xzzUNjKdbHoXN = new XzzUNjKdbHoXN(0);
		xzzUNjKdbHoXN.agnhlZvRfU = this;
		return xzzUNjKdbHoXN;
	}

	private void SysypShANYuc()
	{
		if (vHXKsPTuCZFfG == null)
		{
			gjKVjOSgGMyg gjKVjOSgGMyg2 = new gjKVjOSgGMyg();
			gjKVjOSgGMyg2.vTsxTsmjCg(MuLPZDdhDiwoDZV, null, out vHXKsPTuCZFfG, out HrmZpiywKuEf);
		}
	}
}
