using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DxdMrHCZzlIaV;

public sealed class DznYVPQyWVFwO : IEnumerable<string>, IEnumerable
{
	private sealed class GAEQuFNJCjMi : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string snGFcGgnfkRG;

		private int EaRWjGfppwoK;

		public DznYVPQyWVFwO yOGpkJhorHLO;

		public List<string> zFhPwsIzTTOiX;

		public sodccIdMmAL wVJqIsiOlxct;

		public sodccIdMmAL thIoRjzkipXd;

		public int HmtQwSCQKmpE;

		public string fXpEXqEwvPBSg;

		public Dictionary<ulong, sodccIdMmAL>.ValueCollection.Enumerator DclZXDtxictQOvws;

		string IEnumerator<string>.Current => snGFcGgnfkRG;

		object IEnumerator.Current => snGFcGgnfkRG;

		private bool MoveNext()
		{
			try
			{
				switch (EaRWjGfppwoK)
				{
				case 0:
					EaRWjGfppwoK = -1;
					yOGpkJhorHLO.uYqWKIXtchpNE();
					zFhPwsIzTTOiX = new List<string>();
					DclZXDtxictQOvws = yOGpkJhorHLO.xZluJSzxrWqc.Values.GetEnumerator();
					EaRWjGfppwoK = 1;
					goto IL_018e;
				case 2:
					{
						EaRWjGfppwoK = 1;
						goto IL_018e;
					}
					IL_018e:
					while (DclZXDtxictQOvws.MoveNext())
					{
						wVJqIsiOlxct = DclZXDtxictQOvws.Current;
						zFhPwsIzTTOiX.Clear();
						thIoRjzkipXd = wVJqIsiOlxct;
						HmtQwSCQKmpE = -1;
						do
						{
							if (thIoRjzkipXd.ParentFrn != 0L)
							{
								zFhPwsIzTTOiX.Add(thIoRjzkipXd.Name);
							}
							if (yOGpkJhorHLO.xZluJSzxrWqc.ContainsKey(thIoRjzkipXd.ParentFrn))
							{
								thIoRjzkipXd = yOGpkJhorHLO.xZluJSzxrWqc[thIoRjzkipXd.ParentFrn];
							}
							else if (yOGpkJhorHLO.UthcmWIwespyhB.ContainsKey(thIoRjzkipXd.ParentFrn))
							{
								thIoRjzkipXd = yOGpkJhorHLO.UthcmWIwespyhB[thIoRjzkipXd.ParentFrn];
							}
							else
							{
								thIoRjzkipXd = null;
							}
						}
						while (thIoRjzkipXd != null && ++HmtQwSCQKmpE < 1000);
						if (zFhPwsIzTTOiX.Count != 0)
						{
							zFhPwsIzTTOiX.Reverse();
							fXpEXqEwvPBSg = yOGpkJhorHLO.IJwjTqxCDFlq + '\\' + Path.Combine(zFhPwsIzTTOiX.ToArray());
							snGFcGgnfkRG = fXpEXqEwvPBSg;
							EaRWjGfppwoK = 2;
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
			switch (EaRWjGfppwoK)
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

		public GAEQuFNJCjMi(int int_0)
		{
			EaRWjGfppwoK = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			EaRWjGfppwoK = -1;
			((IDisposable)DclZXDtxictQOvws).Dispose();
		}
	}

	private Dictionary<ulong, sodccIdMmAL> xZluJSzxrWqc;

	private Dictionary<ulong, sodccIdMmAL> UthcmWIwespyhB;

	private readonly string IJwjTqxCDFlq;

	public DznYVPQyWVFwO(string string_0)
	{
		IJwjTqxCDFlq = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		GAEQuFNJCjMi gAEQuFNJCjMi = new GAEQuFNJCjMi(0);
		gAEQuFNJCjMi.yOGpkJhorHLO = this;
		return gAEQuFNJCjMi;
	}

	private void uYqWKIXtchpNE()
	{
		if (xZluJSzxrWqc == null)
		{
			AOdAReGcJduxd aOdAReGcJduxd = new AOdAReGcJduxd();
			aOdAReGcJduxd.rqCihwqReTYk(IJwjTqxCDFlq, null, out xZluJSzxrWqc, out UthcmWIwespyhB);
		}
	}
}
