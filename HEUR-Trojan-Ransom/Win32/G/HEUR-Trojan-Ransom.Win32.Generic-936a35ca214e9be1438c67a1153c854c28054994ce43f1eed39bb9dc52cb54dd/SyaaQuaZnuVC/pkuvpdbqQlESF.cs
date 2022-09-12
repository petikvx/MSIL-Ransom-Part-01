using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SyaaQuaZnuVC;

public class pkuvpdbqQlESF : IEnumerable<string>, IEnumerable
{
	private sealed class yTjItMbDUntb : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string BqLBAZBjtfFwtCw;

		private int aCbYJkttPoqMPPu;

		public pkuvpdbqQlESF hMLeirCKvxvEK;

		public List<string> WCGAyshclV;

		public LwrHnVEFYNehp LfSJFLCiUszK;

		public LwrHnVEFYNehp ywaXFXtXUVvy;

		public int DSMMqDEhKKRsjxJ;

		public string QrayRYvuGvsM;

		public Dictionary<ulong, LwrHnVEFYNehp>.ValueCollection.Enumerator vESdXqyGxlnp;

		string IEnumerator<string>.Current => BqLBAZBjtfFwtCw;

		object IEnumerator.Current => BqLBAZBjtfFwtCw;

		private bool MoveNext()
		{
			try
			{
				switch (aCbYJkttPoqMPPu)
				{
				case 0:
					aCbYJkttPoqMPPu = -1;
					hMLeirCKvxvEK.FMjApdAfVJJLO();
					WCGAyshclV = new List<string>();
					vESdXqyGxlnp = hMLeirCKvxvEK.kZWUDxDevNkI.Values.GetEnumerator();
					aCbYJkttPoqMPPu = 1;
					goto IL_018e;
				case 2:
					{
						aCbYJkttPoqMPPu = 1;
						goto IL_018e;
					}
					IL_018e:
					while (vESdXqyGxlnp.MoveNext())
					{
						LfSJFLCiUszK = vESdXqyGxlnp.Current;
						WCGAyshclV.Clear();
						ywaXFXtXUVvy = LfSJFLCiUszK;
						DSMMqDEhKKRsjxJ = -1;
						do
						{
							if (ywaXFXtXUVvy.ParentFrn != 0L)
							{
								WCGAyshclV.Add(ywaXFXtXUVvy.Name);
							}
							if (hMLeirCKvxvEK.kZWUDxDevNkI.ContainsKey(ywaXFXtXUVvy.ParentFrn))
							{
								ywaXFXtXUVvy = hMLeirCKvxvEK.kZWUDxDevNkI[ywaXFXtXUVvy.ParentFrn];
							}
							else if (hMLeirCKvxvEK.uQAuvaNDXkfUGvk.ContainsKey(ywaXFXtXUVvy.ParentFrn))
							{
								ywaXFXtXUVvy = hMLeirCKvxvEK.uQAuvaNDXkfUGvk[ywaXFXtXUVvy.ParentFrn];
							}
							else
							{
								ywaXFXtXUVvy = null;
							}
						}
						while (ywaXFXtXUVvy != null && ++DSMMqDEhKKRsjxJ < 1000);
						if (WCGAyshclV.Count != 0)
						{
							WCGAyshclV.Reverse();
							QrayRYvuGvsM = hMLeirCKvxvEK.RcBeLVHXoYDXiGhRCI + '\\' + Path.Combine(WCGAyshclV.ToArray());
							BqLBAZBjtfFwtCw = QrayRYvuGvsM;
							aCbYJkttPoqMPPu = 2;
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
			switch (aCbYJkttPoqMPPu)
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

		public yTjItMbDUntb(int int_0)
		{
			aCbYJkttPoqMPPu = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			aCbYJkttPoqMPPu = -1;
			((IDisposable)vESdXqyGxlnp).Dispose();
		}
	}

	private Dictionary<ulong, LwrHnVEFYNehp> kZWUDxDevNkI;

	private Dictionary<ulong, LwrHnVEFYNehp> uQAuvaNDXkfUGvk;

	private readonly string RcBeLVHXoYDXiGhRCI;

	public pkuvpdbqQlESF(string string_0)
	{
		RcBeLVHXoYDXiGhRCI = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		yTjItMbDUntb yTjItMbDUntb = new yTjItMbDUntb(0);
		yTjItMbDUntb.hMLeirCKvxvEK = this;
		return yTjItMbDUntb;
	}

	private void FMjApdAfVJJLO()
	{
		if (kZWUDxDevNkI == null)
		{
			LeFVxlMLXOora leFVxlMLXOora = new LeFVxlMLXOora();
			leFVxlMLXOora.oBKxowLPqDffn(RcBeLVHXoYDXiGhRCI, null, out kZWUDxDevNkI, out uQAuvaNDXkfUGvk);
		}
	}
}
