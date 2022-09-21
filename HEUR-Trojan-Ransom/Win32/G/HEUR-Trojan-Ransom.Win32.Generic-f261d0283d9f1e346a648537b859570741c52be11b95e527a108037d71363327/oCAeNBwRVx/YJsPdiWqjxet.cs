using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace oCAeNBwRVx;

public sealed class YJsPdiWqjxet : IEnumerable<string>, IEnumerable
{
	private sealed class wYfyvHmqaDOw : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string ASPTQLOktOVUfu;

		private int KbNkSSdvZdB;

		public YJsPdiWqjxet OZcsAMxdJeIRI;

		public List<string> zXtYYGThTf;

		public RWqiBDaDvSuhe UvCMinFWHZYY;

		public RWqiBDaDvSuhe bkMzjeUueCSOsk;

		public int ALGGKDetkSopD;

		public string aPtCFtSMjszhYI;

		public Dictionary<ulong, RWqiBDaDvSuhe>.ValueCollection.Enumerator JIJrVyJgjxkQA;

		string IEnumerator<string>.Current => ASPTQLOktOVUfu;

		object IEnumerator.Current => ASPTQLOktOVUfu;

		private bool MoveNext()
		{
			try
			{
				switch (KbNkSSdvZdB)
				{
				case 0:
					KbNkSSdvZdB = -1;
					OZcsAMxdJeIRI.pJYzQOAxlFjeZ();
					zXtYYGThTf = new List<string>();
					JIJrVyJgjxkQA = OZcsAMxdJeIRI.jnjYcaSUwSU.Values.GetEnumerator();
					KbNkSSdvZdB = 1;
					goto IL_018e;
				case 2:
					{
						KbNkSSdvZdB = 1;
						goto IL_018e;
					}
					IL_018e:
					while (JIJrVyJgjxkQA.MoveNext())
					{
						UvCMinFWHZYY = JIJrVyJgjxkQA.Current;
						zXtYYGThTf.Clear();
						bkMzjeUueCSOsk = UvCMinFWHZYY;
						ALGGKDetkSopD = -1;
						do
						{
							if (bkMzjeUueCSOsk.ParentFrn != 0L)
							{
								zXtYYGThTf.Add(bkMzjeUueCSOsk.Name);
							}
							if (OZcsAMxdJeIRI.jnjYcaSUwSU.ContainsKey(bkMzjeUueCSOsk.ParentFrn))
							{
								bkMzjeUueCSOsk = OZcsAMxdJeIRI.jnjYcaSUwSU[bkMzjeUueCSOsk.ParentFrn];
							}
							else if (OZcsAMxdJeIRI.XeQMfDMZwXb.ContainsKey(bkMzjeUueCSOsk.ParentFrn))
							{
								bkMzjeUueCSOsk = OZcsAMxdJeIRI.XeQMfDMZwXb[bkMzjeUueCSOsk.ParentFrn];
							}
							else
							{
								bkMzjeUueCSOsk = null;
							}
						}
						while (bkMzjeUueCSOsk != null && ++ALGGKDetkSopD < 1000);
						if (zXtYYGThTf.Count != 0)
						{
							zXtYYGThTf.Reverse();
							aPtCFtSMjszhYI = OZcsAMxdJeIRI.wZbRAqbbRJpuj + '\\' + Path.Combine(zXtYYGThTf.ToArray());
							ASPTQLOktOVUfu = aPtCFtSMjszhYI;
							KbNkSSdvZdB = 2;
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
			switch (KbNkSSdvZdB)
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

		public wYfyvHmqaDOw(int int_0)
		{
			KbNkSSdvZdB = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			KbNkSSdvZdB = -1;
			((IDisposable)JIJrVyJgjxkQA).Dispose();
		}
	}

	private Dictionary<ulong, RWqiBDaDvSuhe> jnjYcaSUwSU;

	private Dictionary<ulong, RWqiBDaDvSuhe> XeQMfDMZwXb;

	private readonly string wZbRAqbbRJpuj;

	public YJsPdiWqjxet(string string_0)
	{
		wZbRAqbbRJpuj = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		wYfyvHmqaDOw wYfyvHmqaDOw = new wYfyvHmqaDOw(0);
		wYfyvHmqaDOw.OZcsAMxdJeIRI = this;
		return wYfyvHmqaDOw;
	}

	private void pJYzQOAxlFjeZ()
	{
		if (jnjYcaSUwSU == null)
		{
			iIXCpVGzaxeH iIXCpVGzaxeH2 = new iIXCpVGzaxeH();
			iIXCpVGzaxeH2.QVGSNCHqyxDRNe(wZbRAqbbRJpuj, null, out jnjYcaSUwSU, out XeQMfDMZwXb);
		}
	}
}
