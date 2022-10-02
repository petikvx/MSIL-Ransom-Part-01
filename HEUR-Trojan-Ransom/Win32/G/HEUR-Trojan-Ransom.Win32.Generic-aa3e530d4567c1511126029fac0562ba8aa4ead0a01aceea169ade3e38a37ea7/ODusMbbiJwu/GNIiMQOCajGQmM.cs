using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ODusMbbiJwu;

public sealed class GNIiMQOCajGQmM : IEnumerable<string>, IEnumerable
{
	private sealed class QcwuUkYKPEmqGdp : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string yZVKnIUbjfB;

		private int DWWRAuxdSHuh;

		public GNIiMQOCajGQmM smdohysUeDZ;

		public List<string> tWiQUYkOKw;

		public DECIbyuBTBupOG umptRCSDDxVMM;

		public DECIbyuBTBupOG zXKnvONTHoPF;

		public int IyffJiypbO;

		public string ckpKiAEPjor;

		public Dictionary<ulong, DECIbyuBTBupOG>.ValueCollection.Enumerator bANsyBCaBfhZZX;

		string IEnumerator<string>.Current => yZVKnIUbjfB;

		object IEnumerator.Current => yZVKnIUbjfB;

		private bool MoveNext()
		{
			try
			{
				switch (DWWRAuxdSHuh)
				{
				case 0:
					DWWRAuxdSHuh = -1;
					smdohysUeDZ.dmmUlqljsigHE();
					tWiQUYkOKw = new List<string>();
					bANsyBCaBfhZZX = smdohysUeDZ.BqLYHjhyDtOy.Values.GetEnumerator();
					DWWRAuxdSHuh = 1;
					goto IL_018e;
				case 2:
					{
						DWWRAuxdSHuh = 1;
						goto IL_018e;
					}
					IL_018e:
					while (bANsyBCaBfhZZX.MoveNext())
					{
						umptRCSDDxVMM = bANsyBCaBfhZZX.Current;
						tWiQUYkOKw.Clear();
						zXKnvONTHoPF = umptRCSDDxVMM;
						IyffJiypbO = -1;
						do
						{
							if (zXKnvONTHoPF.ParentFrn != 0L)
							{
								tWiQUYkOKw.Add(zXKnvONTHoPF.Name);
							}
							if (smdohysUeDZ.BqLYHjhyDtOy.ContainsKey(zXKnvONTHoPF.ParentFrn))
							{
								zXKnvONTHoPF = smdohysUeDZ.BqLYHjhyDtOy[zXKnvONTHoPF.ParentFrn];
							}
							else if (smdohysUeDZ.TccyeHnSPZLMAZLyB.ContainsKey(zXKnvONTHoPF.ParentFrn))
							{
								zXKnvONTHoPF = smdohysUeDZ.TccyeHnSPZLMAZLyB[zXKnvONTHoPF.ParentFrn];
							}
							else
							{
								zXKnvONTHoPF = null;
							}
						}
						while (zXKnvONTHoPF != null && ++IyffJiypbO < 1000);
						if (tWiQUYkOKw.Count != 0)
						{
							tWiQUYkOKw.Reverse();
							ckpKiAEPjor = smdohysUeDZ.tnFUyeRxMaDOJm + '\\' + Path.Combine(tWiQUYkOKw.ToArray());
							yZVKnIUbjfB = ckpKiAEPjor;
							DWWRAuxdSHuh = 2;
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
			switch (DWWRAuxdSHuh)
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

		public QcwuUkYKPEmqGdp(int int_0)
		{
			DWWRAuxdSHuh = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			DWWRAuxdSHuh = -1;
			((IDisposable)bANsyBCaBfhZZX).Dispose();
		}
	}

	private Dictionary<ulong, DECIbyuBTBupOG> BqLYHjhyDtOy;

	private Dictionary<ulong, DECIbyuBTBupOG> TccyeHnSPZLMAZLyB;

	private readonly string tnFUyeRxMaDOJm;

	public GNIiMQOCajGQmM(string string_0)
	{
		tnFUyeRxMaDOJm = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		QcwuUkYKPEmqGdp qcwuUkYKPEmqGdp = new QcwuUkYKPEmqGdp(0);
		qcwuUkYKPEmqGdp.smdohysUeDZ = this;
		return qcwuUkYKPEmqGdp;
	}

	private void dmmUlqljsigHE()
	{
		if (BqLYHjhyDtOy == null)
		{
			mDRQtbtneNnH mDRQtbtneNnH2 = new mDRQtbtneNnH();
			mDRQtbtneNnH2.mmIxvLuDLRy(tnFUyeRxMaDOJm, null, out BqLYHjhyDtOy, out TccyeHnSPZLMAZLyB);
		}
	}
}
