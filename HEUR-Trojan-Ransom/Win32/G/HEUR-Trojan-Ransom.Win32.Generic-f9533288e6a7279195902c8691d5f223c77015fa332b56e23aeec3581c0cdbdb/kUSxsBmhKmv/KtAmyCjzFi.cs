using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace kUSxsBmhKmv;

public sealed class KtAmyCjzFi : IEnumerable<string>, IEnumerable
{
	private sealed class aNzxtJlXJw : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string xClkVbBcLPvY;

		private int HwFJIqNfCurva;

		public KtAmyCjzFi gplEhxQobOrveX;

		public List<string> xdTpBXLMWEcWk;

		public RGhFDNIkuVjIouS BYVnaUtKFbbqL;

		public RGhFDNIkuVjIouS PRpPHGXrlACmFV;

		public int IqvnbmFiJKIU;

		public string aVVmAgxYobe;

		public Dictionary<ulong, RGhFDNIkuVjIouS>.ValueCollection.Enumerator lBtZnOPJiu;

		string IEnumerator<string>.Current => xClkVbBcLPvY;

		object IEnumerator.Current => xClkVbBcLPvY;

		private bool MoveNext()
		{
			try
			{
				switch (HwFJIqNfCurva)
				{
				case 0:
					HwFJIqNfCurva = -1;
					gplEhxQobOrveX.mCBhSNTuSgRJt();
					xdTpBXLMWEcWk = new List<string>();
					lBtZnOPJiu = gplEhxQobOrveX.qtZUksETBbF.Values.GetEnumerator();
					HwFJIqNfCurva = 1;
					goto IL_019e;
				case 2:
					{
						HwFJIqNfCurva = 1;
						goto IL_019e;
					}
					IL_019e:
					while (lBtZnOPJiu.MoveNext())
					{
						BYVnaUtKFbbqL = lBtZnOPJiu.Current;
						xdTpBXLMWEcWk.Clear();
						PRpPHGXrlACmFV = BYVnaUtKFbbqL;
						IqvnbmFiJKIU = -1;
						do
						{
							if (PRpPHGXrlACmFV.ParentFrn != 0L)
							{
								xdTpBXLMWEcWk.Add(PRpPHGXrlACmFV.Name);
							}
							if (gplEhxQobOrveX.qtZUksETBbF.ContainsKey(PRpPHGXrlACmFV.ParentFrn))
							{
								PRpPHGXrlACmFV = gplEhxQobOrveX.qtZUksETBbF[PRpPHGXrlACmFV.ParentFrn];
							}
							else if (gplEhxQobOrveX.mnZZceqskl.ContainsKey(PRpPHGXrlACmFV.ParentFrn))
							{
								PRpPHGXrlACmFV = gplEhxQobOrveX.mnZZceqskl[PRpPHGXrlACmFV.ParentFrn];
							}
							else
							{
								PRpPHGXrlACmFV = null;
							}
						}
						while (PRpPHGXrlACmFV != null && ++IqvnbmFiJKIU < 1000);
						if (xdTpBXLMWEcWk.Count != 0)
						{
							xdTpBXLMWEcWk.Reverse();
							aVVmAgxYobe = gplEhxQobOrveX.ZkwEPMUFUUIIktB + '\\' + Path.Combine(xdTpBXLMWEcWk.ToArray());
							xClkVbBcLPvY = aVVmAgxYobe;
							HwFJIqNfCurva = 2;
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
			switch (HwFJIqNfCurva)
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

		public aNzxtJlXJw(int int_0)
		{
			HwFJIqNfCurva = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			HwFJIqNfCurva = -1;
			((IDisposable)lBtZnOPJiu).Dispose();
		}
	}

	private Dictionary<ulong, RGhFDNIkuVjIouS> qtZUksETBbF;

	private Dictionary<ulong, RGhFDNIkuVjIouS> mnZZceqskl;

	private readonly string ZkwEPMUFUUIIktB;

	public KtAmyCjzFi(string string_0)
	{
		ZkwEPMUFUUIIktB = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		aNzxtJlXJw aNzxtJlXJw = new aNzxtJlXJw(0);
		aNzxtJlXJw.gplEhxQobOrveX = this;
		return aNzxtJlXJw;
	}

	private void mCBhSNTuSgRJt()
	{
		if (qtZUksETBbF == null)
		{
			IwzaWmnwcnlB iwzaWmnwcnlB = new IwzaWmnwcnlB();
			iwzaWmnwcnlB.CJkuFhqIgKwiFDo(ZkwEPMUFUUIIktB, null, out qtZUksETBbF, out mnZZceqskl);
		}
	}
}
