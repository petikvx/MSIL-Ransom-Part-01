using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace pLpOiMPKFBqsYEtBP;

public sealed class yQvbZWVzRpVzK : IEnumerable<string>, IEnumerable
{
	private sealed class lZUzsWPWGkPYfM : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string ZzuJQyZWewWqDX;

		private int UIwgiTHangTxY;

		public yQvbZWVzRpVzK kWAHNyetfFtK;

		public List<string> UpARBSBgEhTVr;

		public FGNTLXNznfbNyvZ KhBjtdWLjhRDTXx;

		public FGNTLXNznfbNyvZ RPPckJxBJuuKlFc;

		public int PVAJbTOhdG;

		public string gESlXlVbIVRSJ;

		public Dictionary<ulong, FGNTLXNznfbNyvZ>.ValueCollection.Enumerator eWILMZLrbNYXlt;

		string IEnumerator<string>.Current => ZzuJQyZWewWqDX;

		object IEnumerator.Current => ZzuJQyZWewWqDX;

		private bool MoveNext()
		{
			try
			{
				switch (UIwgiTHangTxY)
				{
				case 0:
					UIwgiTHangTxY = -1;
					kWAHNyetfFtK.vQfZpLKCyHhhh();
					UpARBSBgEhTVr = new List<string>();
					eWILMZLrbNYXlt = kWAHNyetfFtK.legpjCTadAxLhJt.Values.GetEnumerator();
					UIwgiTHangTxY = 1;
					goto IL_018e;
				case 2:
					{
						UIwgiTHangTxY = 1;
						goto IL_018e;
					}
					IL_018e:
					while (eWILMZLrbNYXlt.MoveNext())
					{
						KhBjtdWLjhRDTXx = eWILMZLrbNYXlt.Current;
						UpARBSBgEhTVr.Clear();
						RPPckJxBJuuKlFc = KhBjtdWLjhRDTXx;
						PVAJbTOhdG = -1;
						do
						{
							if (RPPckJxBJuuKlFc.ParentFrn != 0L)
							{
								UpARBSBgEhTVr.Add(RPPckJxBJuuKlFc.Name);
							}
							if (kWAHNyetfFtK.legpjCTadAxLhJt.ContainsKey(RPPckJxBJuuKlFc.ParentFrn))
							{
								RPPckJxBJuuKlFc = kWAHNyetfFtK.legpjCTadAxLhJt[RPPckJxBJuuKlFc.ParentFrn];
							}
							else if (kWAHNyetfFtK.EhbTmgLvbBiI.ContainsKey(RPPckJxBJuuKlFc.ParentFrn))
							{
								RPPckJxBJuuKlFc = kWAHNyetfFtK.EhbTmgLvbBiI[RPPckJxBJuuKlFc.ParentFrn];
							}
							else
							{
								RPPckJxBJuuKlFc = null;
							}
						}
						while (RPPckJxBJuuKlFc != null && ++PVAJbTOhdG < 1000);
						if (UpARBSBgEhTVr.Count != 0)
						{
							UpARBSBgEhTVr.Reverse();
							gESlXlVbIVRSJ = kWAHNyetfFtK.oaXTnVLjPwD + '\\' + Path.Combine(UpARBSBgEhTVr.ToArray());
							ZzuJQyZWewWqDX = gESlXlVbIVRSJ;
							UIwgiTHangTxY = 2;
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
			switch (UIwgiTHangTxY)
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

		public lZUzsWPWGkPYfM(int int_0)
		{
			UIwgiTHangTxY = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			UIwgiTHangTxY = -1;
			((IDisposable)eWILMZLrbNYXlt).Dispose();
		}
	}

	private Dictionary<ulong, FGNTLXNznfbNyvZ> legpjCTadAxLhJt;

	private Dictionary<ulong, FGNTLXNznfbNyvZ> EhbTmgLvbBiI;

	private readonly string oaXTnVLjPwD;

	public yQvbZWVzRpVzK(string string_0)
	{
		oaXTnVLjPwD = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		lZUzsWPWGkPYfM lZUzsWPWGkPYfM = new lZUzsWPWGkPYfM(0);
		lZUzsWPWGkPYfM.kWAHNyetfFtK = this;
		return lZUzsWPWGkPYfM;
	}

	private void vQfZpLKCyHhhh()
	{
		if (legpjCTadAxLhJt == null)
		{
			tjzTpApWfmt tjzTpApWfmt2 = new tjzTpApWfmt();
			tjzTpApWfmt2.LTFjArhSgTvHJt(oaXTnVLjPwD, null, out legpjCTadAxLhJt, out EhbTmgLvbBiI);
		}
	}
}
