using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace gSIYQHSVYK;

public sealed class uUqrgrydKeUy : IEnumerable<string>, IEnumerable
{
	private sealed class tczhhlWgNATXdzsqx : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string koVjygWSnRMQ;

		private int SqhYTLPjWBAu;

		public uUqrgrydKeUy ynzVxbCqirks;

		public List<string> nRVricXVdLYKwH;

		public RTVnWQrlpyAp IkCDvsxTEDC;

		public RTVnWQrlpyAp loompPZXhRJn;

		public int dnejJKtFuxgWgC;

		public string PCNderVysUZT;

		public Dictionary<ulong, RTVnWQrlpyAp>.ValueCollection.Enumerator TKwqhdGOVCkIT;

		string IEnumerator<string>.Current => koVjygWSnRMQ;

		object IEnumerator.Current => koVjygWSnRMQ;

		private bool MoveNext()
		{
			try
			{
				switch (SqhYTLPjWBAu)
				{
				case 0:
					SqhYTLPjWBAu = -1;
					ynzVxbCqirks.VIVfutEEWDuC();
					nRVricXVdLYKwH = new List<string>();
					TKwqhdGOVCkIT = ynzVxbCqirks.FRsAMRcufPx.Values.GetEnumerator();
					SqhYTLPjWBAu = 1;
					goto IL_019e;
				case 2:
					{
						SqhYTLPjWBAu = 1;
						goto IL_019e;
					}
					IL_019e:
					while (TKwqhdGOVCkIT.MoveNext())
					{
						IkCDvsxTEDC = TKwqhdGOVCkIT.Current;
						nRVricXVdLYKwH.Clear();
						loompPZXhRJn = IkCDvsxTEDC;
						dnejJKtFuxgWgC = -1;
						do
						{
							if (loompPZXhRJn.ParentFrn != 0L)
							{
								nRVricXVdLYKwH.Add(loompPZXhRJn.Name);
							}
							if (ynzVxbCqirks.FRsAMRcufPx.ContainsKey(loompPZXhRJn.ParentFrn))
							{
								loompPZXhRJn = ynzVxbCqirks.FRsAMRcufPx[loompPZXhRJn.ParentFrn];
							}
							else if (ynzVxbCqirks.IOGYSXgCls.ContainsKey(loompPZXhRJn.ParentFrn))
							{
								loompPZXhRJn = ynzVxbCqirks.IOGYSXgCls[loompPZXhRJn.ParentFrn];
							}
							else
							{
								loompPZXhRJn = null;
							}
						}
						while (loompPZXhRJn != null && ++dnejJKtFuxgWgC < 1000);
						if (nRVricXVdLYKwH.Count != 0)
						{
							nRVricXVdLYKwH.Reverse();
							PCNderVysUZT = ynzVxbCqirks.qUJXqzMdSMgHTw + '\\' + Path.Combine(nRVricXVdLYKwH.ToArray());
							koVjygWSnRMQ = PCNderVysUZT;
							SqhYTLPjWBAu = 2;
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
			switch (SqhYTLPjWBAu)
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

		public tczhhlWgNATXdzsqx(int int_0)
		{
			SqhYTLPjWBAu = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			SqhYTLPjWBAu = -1;
			((IDisposable)TKwqhdGOVCkIT).Dispose();
		}
	}

	private Dictionary<ulong, RTVnWQrlpyAp> FRsAMRcufPx;

	private Dictionary<ulong, RTVnWQrlpyAp> IOGYSXgCls;

	private readonly string qUJXqzMdSMgHTw;

	public uUqrgrydKeUy(string string_0)
	{
		qUJXqzMdSMgHTw = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		tczhhlWgNATXdzsqx tczhhlWgNATXdzsqx = new tczhhlWgNATXdzsqx(0);
		tczhhlWgNATXdzsqx.ynzVxbCqirks = this;
		return tczhhlWgNATXdzsqx;
	}

	private void VIVfutEEWDuC()
	{
		if (FRsAMRcufPx == null)
		{
			GBFUDDDTpMNpaRFV gBFUDDDTpMNpaRFV = new GBFUDDDTpMNpaRFV();
			gBFUDDDTpMNpaRFV.YjszwrQAsNAa(qUJXqzMdSMgHTw, null, out FRsAMRcufPx, out IOGYSXgCls);
		}
	}
}
