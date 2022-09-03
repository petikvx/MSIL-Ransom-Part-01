using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LqOmRmSJUuFi;

public sealed class FQTtzLCDJJQAk : IEnumerable<string>, IEnumerable
{
	private sealed class VrKnkVfOXeYxxL : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string PefXpIWkkbYb;

		private int anYuXCTuZRfc;

		public FQTtzLCDJJQAk xudnACsWZyXIPkra;

		public List<string> caoHYaQjPlYI;

		public CJMoUoINuBFW DySLqzEqMLy;

		public CJMoUoINuBFW wzLJRauLGZKS;

		public int kUHAbDXtsifI;

		public string tdduQgeTLYRlkiH;

		public Dictionary<ulong, CJMoUoINuBFW>.ValueCollection.Enumerator koQVMymNwKs;

		string IEnumerator<string>.Current => PefXpIWkkbYb;

		object IEnumerator.Current => PefXpIWkkbYb;

		private bool MoveNext()
		{
			try
			{
				switch (anYuXCTuZRfc)
				{
				case 0:
					anYuXCTuZRfc = -1;
					xudnACsWZyXIPkra.fEYKzLaJfzLb();
					caoHYaQjPlYI = new List<string>();
					koQVMymNwKs = xudnACsWZyXIPkra.pjIULFqAqmMp.Values.GetEnumerator();
					anYuXCTuZRfc = 1;
					goto IL_018e;
				case 2:
					{
						anYuXCTuZRfc = 1;
						goto IL_018e;
					}
					IL_018e:
					while (koQVMymNwKs.MoveNext())
					{
						DySLqzEqMLy = koQVMymNwKs.Current;
						caoHYaQjPlYI.Clear();
						wzLJRauLGZKS = DySLqzEqMLy;
						kUHAbDXtsifI = -1;
						do
						{
							if (wzLJRauLGZKS.ParentFrn != 0L)
							{
								caoHYaQjPlYI.Add(wzLJRauLGZKS.Name);
							}
							if (xudnACsWZyXIPkra.pjIULFqAqmMp.ContainsKey(wzLJRauLGZKS.ParentFrn))
							{
								wzLJRauLGZKS = xudnACsWZyXIPkra.pjIULFqAqmMp[wzLJRauLGZKS.ParentFrn];
							}
							else if (xudnACsWZyXIPkra.UcZefSvnjiDK.ContainsKey(wzLJRauLGZKS.ParentFrn))
							{
								wzLJRauLGZKS = xudnACsWZyXIPkra.UcZefSvnjiDK[wzLJRauLGZKS.ParentFrn];
							}
							else
							{
								wzLJRauLGZKS = null;
							}
						}
						while (wzLJRauLGZKS != null && ++kUHAbDXtsifI < 1000);
						if (caoHYaQjPlYI.Count != 0)
						{
							caoHYaQjPlYI.Reverse();
							tdduQgeTLYRlkiH = xudnACsWZyXIPkra.nYCvQKtLWzST + '\\' + Path.Combine(caoHYaQjPlYI.ToArray());
							PefXpIWkkbYb = tdduQgeTLYRlkiH;
							anYuXCTuZRfc = 2;
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
			switch (anYuXCTuZRfc)
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

		public VrKnkVfOXeYxxL(int int_0)
		{
			anYuXCTuZRfc = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			anYuXCTuZRfc = -1;
			((IDisposable)koQVMymNwKs).Dispose();
		}
	}

	private Dictionary<ulong, CJMoUoINuBFW> pjIULFqAqmMp;

	private Dictionary<ulong, CJMoUoINuBFW> UcZefSvnjiDK;

	private readonly string nYCvQKtLWzST;

	public FQTtzLCDJJQAk(string string_0)
	{
		nYCvQKtLWzST = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		VrKnkVfOXeYxxL vrKnkVfOXeYxxL = new VrKnkVfOXeYxxL(0);
		vrKnkVfOXeYxxL.xudnACsWZyXIPkra = this;
		return vrKnkVfOXeYxxL;
	}

	private void fEYKzLaJfzLb()
	{
		if (pjIULFqAqmMp == null)
		{
			QEEnopKlJLPCoOHSx qEEnopKlJLPCoOHSx = new QEEnopKlJLPCoOHSx();
			qEEnopKlJLPCoOHSx.ImSPvucCuANaVUv(nYCvQKtLWzST, null, out pjIULFqAqmMp, out UcZefSvnjiDK);
		}
	}
}
