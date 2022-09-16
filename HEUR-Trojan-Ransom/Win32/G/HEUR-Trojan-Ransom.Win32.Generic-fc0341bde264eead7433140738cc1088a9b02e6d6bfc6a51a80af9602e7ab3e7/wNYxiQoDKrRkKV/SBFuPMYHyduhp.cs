using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace wNYxiQoDKrRkKV;

public sealed class SBFuPMYHyduhp : IEnumerable<string>, IEnumerable
{
	private sealed class wAOGpGWxlKvQS : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string YiIJhFRuWYSBL;

		private int RqREnLtEASXU;

		public SBFuPMYHyduhp XaHankGjjxeO;

		public List<string> diIxuZkthGBuWZ;

		public xTgjpcnmTTwIo GtPRIskmOMwXM;

		public xTgjpcnmTTwIo qaoTjjuYHdfVRV;

		public int neshSGjOkHt;

		public string DrJQdjTkNa;

		public Dictionary<ulong, xTgjpcnmTTwIo>.ValueCollection.Enumerator nBgsuBZQiuGQk;

		string IEnumerator<string>.Current => YiIJhFRuWYSBL;

		object IEnumerator.Current => YiIJhFRuWYSBL;

		private bool MoveNext()
		{
			try
			{
				switch (RqREnLtEASXU)
				{
				case 0:
					RqREnLtEASXU = -1;
					XaHankGjjxeO.OIVrxVaFUduW();
					diIxuZkthGBuWZ = new List<string>();
					nBgsuBZQiuGQk = XaHankGjjxeO.YfqzQprIDa.Values.GetEnumerator();
					RqREnLtEASXU = 1;
					goto IL_018e;
				case 2:
					{
						RqREnLtEASXU = 1;
						goto IL_018e;
					}
					IL_018e:
					while (nBgsuBZQiuGQk.MoveNext())
					{
						GtPRIskmOMwXM = nBgsuBZQiuGQk.Current;
						diIxuZkthGBuWZ.Clear();
						qaoTjjuYHdfVRV = GtPRIskmOMwXM;
						neshSGjOkHt = -1;
						do
						{
							if (qaoTjjuYHdfVRV.ParentFrn != 0L)
							{
								diIxuZkthGBuWZ.Add(qaoTjjuYHdfVRV.Name);
							}
							if (XaHankGjjxeO.YfqzQprIDa.ContainsKey(qaoTjjuYHdfVRV.ParentFrn))
							{
								qaoTjjuYHdfVRV = XaHankGjjxeO.YfqzQprIDa[qaoTjjuYHdfVRV.ParentFrn];
							}
							else if (XaHankGjjxeO.wpWiYtoarItqWu.ContainsKey(qaoTjjuYHdfVRV.ParentFrn))
							{
								qaoTjjuYHdfVRV = XaHankGjjxeO.wpWiYtoarItqWu[qaoTjjuYHdfVRV.ParentFrn];
							}
							else
							{
								qaoTjjuYHdfVRV = null;
							}
						}
						while (qaoTjjuYHdfVRV != null && ++neshSGjOkHt < 1000);
						if (diIxuZkthGBuWZ.Count != 0)
						{
							diIxuZkthGBuWZ.Reverse();
							DrJQdjTkNa = XaHankGjjxeO.EyHntBCjKEruOTm + '\\' + Path.Combine(diIxuZkthGBuWZ.ToArray());
							YiIJhFRuWYSBL = DrJQdjTkNa;
							RqREnLtEASXU = 2;
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
			switch (RqREnLtEASXU)
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

		public wAOGpGWxlKvQS(int int_0)
		{
			RqREnLtEASXU = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			RqREnLtEASXU = -1;
			((IDisposable)nBgsuBZQiuGQk).Dispose();
		}
	}

	private Dictionary<ulong, xTgjpcnmTTwIo> YfqzQprIDa;

	private Dictionary<ulong, xTgjpcnmTTwIo> wpWiYtoarItqWu;

	private readonly string EyHntBCjKEruOTm;

	public SBFuPMYHyduhp(string string_0)
	{
		EyHntBCjKEruOTm = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		wAOGpGWxlKvQS wAOGpGWxlKvQS = new wAOGpGWxlKvQS(0);
		wAOGpGWxlKvQS.XaHankGjjxeO = this;
		return wAOGpGWxlKvQS;
	}

	private void OIVrxVaFUduW()
	{
		if (YfqzQprIDa == null)
		{
			uyryLuhcaC uyryLuhcaC2 = new uyryLuhcaC();
			uyryLuhcaC2.NjqbKCOlkbvoE(EyHntBCjKEruOTm, null, out YfqzQprIDa, out wpWiYtoarItqWu);
		}
	}
}
