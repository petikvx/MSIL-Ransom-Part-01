using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace XEThkAUKbjVOBg;

public sealed class sYJePUUjEUWKEO : IEnumerable<string>, IEnumerable
{
	private sealed class fDtXhylNXNqSu : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string JSSsEbEZxIxl;

		private int DPoqEXhWDpmC;

		public sYJePUUjEUWKEO ALqWpMQgYOA;

		public List<string> uIpYmeKWYmWB;

		public WCXDFAuCSQrWLB CXdogISaYwVg;

		public WCXDFAuCSQrWLB rspwySBhLvow;

		public int CVsfBYUiBrKdR;

		public string LgRvEIJCtVbh;

		public Dictionary<ulong, WCXDFAuCSQrWLB>.ValueCollection.Enumerator BAHpTUNqKQSMO;

		string IEnumerator<string>.Current => JSSsEbEZxIxl;

		object IEnumerator.Current => JSSsEbEZxIxl;

		private bool MoveNext()
		{
			try
			{
				switch (DPoqEXhWDpmC)
				{
				case 0:
					DPoqEXhWDpmC = -1;
					ALqWpMQgYOA.ndtPcCFeqWni();
					uIpYmeKWYmWB = new List<string>();
					BAHpTUNqKQSMO = ALqWpMQgYOA.fLqxkZKRhDxxBJ.Values.GetEnumerator();
					DPoqEXhWDpmC = 1;
					goto IL_018e;
				case 2:
					{
						DPoqEXhWDpmC = 1;
						goto IL_018e;
					}
					IL_018e:
					while (BAHpTUNqKQSMO.MoveNext())
					{
						CXdogISaYwVg = BAHpTUNqKQSMO.Current;
						uIpYmeKWYmWB.Clear();
						rspwySBhLvow = CXdogISaYwVg;
						CVsfBYUiBrKdR = -1;
						do
						{
							if (rspwySBhLvow.ParentFrn != 0L)
							{
								uIpYmeKWYmWB.Add(rspwySBhLvow.Name);
							}
							if (ALqWpMQgYOA.fLqxkZKRhDxxBJ.ContainsKey(rspwySBhLvow.ParentFrn))
							{
								rspwySBhLvow = ALqWpMQgYOA.fLqxkZKRhDxxBJ[rspwySBhLvow.ParentFrn];
							}
							else if (ALqWpMQgYOA.ePkxpCPPDf.ContainsKey(rspwySBhLvow.ParentFrn))
							{
								rspwySBhLvow = ALqWpMQgYOA.ePkxpCPPDf[rspwySBhLvow.ParentFrn];
							}
							else
							{
								rspwySBhLvow = null;
							}
						}
						while (rspwySBhLvow != null && ++CVsfBYUiBrKdR < 1000);
						if (uIpYmeKWYmWB.Count != 0)
						{
							uIpYmeKWYmWB.Reverse();
							LgRvEIJCtVbh = ALqWpMQgYOA.gcPaAyvVeyQ + '\\' + Path.Combine(uIpYmeKWYmWB.ToArray());
							JSSsEbEZxIxl = LgRvEIJCtVbh;
							DPoqEXhWDpmC = 2;
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
			switch (DPoqEXhWDpmC)
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

		public fDtXhylNXNqSu(int int_0)
		{
			DPoqEXhWDpmC = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			DPoqEXhWDpmC = -1;
			((IDisposable)BAHpTUNqKQSMO).Dispose();
		}
	}

	private Dictionary<ulong, WCXDFAuCSQrWLB> fLqxkZKRhDxxBJ;

	private Dictionary<ulong, WCXDFAuCSQrWLB> ePkxpCPPDf;

	private readonly string gcPaAyvVeyQ;

	public sYJePUUjEUWKEO(string string_0)
	{
		gcPaAyvVeyQ = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		fDtXhylNXNqSu fDtXhylNXNqSu = new fDtXhylNXNqSu(0);
		fDtXhylNXNqSu.ALqWpMQgYOA = this;
		return fDtXhylNXNqSu;
	}

	private void ndtPcCFeqWni()
	{
		if (fLqxkZKRhDxxBJ == null)
		{
			BPQcCBMokWmV bPQcCBMokWmV = new BPQcCBMokWmV();
			bPQcCBMokWmV.hFkyJOpOtZP(gcPaAyvVeyQ, null, out fLqxkZKRhDxxBJ, out ePkxpCPPDf);
		}
	}
}
