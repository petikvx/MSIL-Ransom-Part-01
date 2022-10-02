using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace mkfUCNbBbSPaksK;

public sealed class EpvLxKFHdkhj : IEnumerable<string>, IEnumerable
{
	private sealed class qaAVXuvJEDp : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string JvKQLzMUcUXF;

		private int zUmQAkmPsNSpq;

		public EpvLxKFHdkhj aLDTMbZWMXCgUj;

		public List<string> fmabcWVAXee;

		public jkHCDLwRtVVaj uWzhZvHoRbAwfZA;

		public jkHCDLwRtVVaj MJJrIInBKcyTG;

		public int MjdvORMqnPQA;

		public string hZnYigEeeCxM;

		public Dictionary<ulong, jkHCDLwRtVVaj>.ValueCollection.Enumerator utwtEKrALvnIQqF;

		string IEnumerator<string>.Current => JvKQLzMUcUXF;

		object IEnumerator.Current => JvKQLzMUcUXF;

		private bool MoveNext()
		{
			try
			{
				switch (zUmQAkmPsNSpq)
				{
				case 0:
					zUmQAkmPsNSpq = -1;
					aLDTMbZWMXCgUj.bhHnAjaqCTIY();
					fmabcWVAXee = new List<string>();
					utwtEKrALvnIQqF = aLDTMbZWMXCgUj.ZfTDbfbUqz.Values.GetEnumerator();
					zUmQAkmPsNSpq = 1;
					goto IL_018e;
				case 2:
					{
						zUmQAkmPsNSpq = 1;
						goto IL_018e;
					}
					IL_018e:
					while (utwtEKrALvnIQqF.MoveNext())
					{
						uWzhZvHoRbAwfZA = utwtEKrALvnIQqF.Current;
						fmabcWVAXee.Clear();
						MJJrIInBKcyTG = uWzhZvHoRbAwfZA;
						MjdvORMqnPQA = -1;
						do
						{
							if (MJJrIInBKcyTG.ParentFrn != 0L)
							{
								fmabcWVAXee.Add(MJJrIInBKcyTG.Name);
							}
							if (aLDTMbZWMXCgUj.ZfTDbfbUqz.ContainsKey(MJJrIInBKcyTG.ParentFrn))
							{
								MJJrIInBKcyTG = aLDTMbZWMXCgUj.ZfTDbfbUqz[MJJrIInBKcyTG.ParentFrn];
							}
							else if (aLDTMbZWMXCgUj.EJFFlrBfmFEN.ContainsKey(MJJrIInBKcyTG.ParentFrn))
							{
								MJJrIInBKcyTG = aLDTMbZWMXCgUj.EJFFlrBfmFEN[MJJrIInBKcyTG.ParentFrn];
							}
							else
							{
								MJJrIInBKcyTG = null;
							}
						}
						while (MJJrIInBKcyTG != null && ++MjdvORMqnPQA < 1000);
						if (fmabcWVAXee.Count != 0)
						{
							fmabcWVAXee.Reverse();
							hZnYigEeeCxM = aLDTMbZWMXCgUj.ffVucUoidyugjpAJ + '\\' + Path.Combine(fmabcWVAXee.ToArray());
							JvKQLzMUcUXF = hZnYigEeeCxM;
							zUmQAkmPsNSpq = 2;
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
			switch (zUmQAkmPsNSpq)
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

		public qaAVXuvJEDp(int int_0)
		{
			zUmQAkmPsNSpq = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			zUmQAkmPsNSpq = -1;
			((IDisposable)utwtEKrALvnIQqF).Dispose();
		}
	}

	private Dictionary<ulong, jkHCDLwRtVVaj> ZfTDbfbUqz;

	private Dictionary<ulong, jkHCDLwRtVVaj> EJFFlrBfmFEN;

	private readonly string ffVucUoidyugjpAJ;

	public EpvLxKFHdkhj(string string_0)
	{
		ffVucUoidyugjpAJ = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		qaAVXuvJEDp qaAVXuvJEDp = new qaAVXuvJEDp(0);
		qaAVXuvJEDp.aLDTMbZWMXCgUj = this;
		return qaAVXuvJEDp;
	}

	private void bhHnAjaqCTIY()
	{
		if (ZfTDbfbUqz == null)
		{
			FTeWbHUrvUQOwPw fTeWbHUrvUQOwPw = new FTeWbHUrvUQOwPw();
			fTeWbHUrvUQOwPw.bXEzEPANiNsp(ffVucUoidyugjpAJ, null, out ZfTDbfbUqz, out EJFFlrBfmFEN);
		}
	}
}
