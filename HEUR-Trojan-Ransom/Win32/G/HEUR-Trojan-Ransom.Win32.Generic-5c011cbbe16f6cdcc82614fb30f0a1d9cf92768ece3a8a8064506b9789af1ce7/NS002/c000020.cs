using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NS002;

public sealed class c000020 : IEnumerable<string>, IEnumerable
{
	private sealed class c000021 : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string xClkVbBcLPvY;

		private int HwFJIqNfCurva;

		public c000020 gplEhxQobOrveX;

		public List<string> f00005c;

		public c00001f BYVnaUtKFbbqL;

		public c00001f f00005d;

		public int IqvnbmFiJKIU;

		public string aVVmAgxYobe;

		public Dictionary<ulong, c00001f>.ValueCollection.Enumerator lBtZnOPJiu;

		private string Current => xClkVbBcLPvY;

		object IEnumerator.Current => xClkVbBcLPvY;

		private bool MoveNext()
		{
			try
			{
				switch (HwFJIqNfCurva)
				{
				case 0:
					HwFJIqNfCurva = -1;
					gplEhxQobOrveX.m00002e();
					f00005c = new List<string>();
					lBtZnOPJiu = gplEhxQobOrveX.qtZUksETBbF.Values.GetEnumerator();
					HwFJIqNfCurva = 1;
					goto IL_019b;
				case 2:
					{
						HwFJIqNfCurva = 1;
						goto IL_019b;
					}
					IL_019b:
					while (lBtZnOPJiu.MoveNext())
					{
						BYVnaUtKFbbqL = lBtZnOPJiu.Current;
						f00005c.Clear();
						f00005d = BYVnaUtKFbbqL;
						IqvnbmFiJKIU = -1;
						do
						{
							if (f00005d.ParentFrn != 0L)
							{
								f00005c.Add(f00005d.Name);
							}
							if (gplEhxQobOrveX.qtZUksETBbF.ContainsKey(f00005d.ParentFrn))
							{
								f00005d = gplEhxQobOrveX.qtZUksETBbF[f00005d.ParentFrn];
							}
							else if (gplEhxQobOrveX.mnZZceqskl.ContainsKey(f00005d.ParentFrn))
							{
								f00005d = gplEhxQobOrveX.mnZZceqskl[f00005d.ParentFrn];
							}
							else
							{
								f00005d = null;
							}
						}
						while (f00005d != null && ++IqvnbmFiJKIU < 1000);
						if (f00005c.Count != 0)
						{
							f00005c.Reverse();
							aVVmAgxYobe = gplEhxQobOrveX.f00005b + '\\' + Path.Combine(f00005c.ToArray());
							xClkVbBcLPvY = aVVmAgxYobe;
							HwFJIqNfCurva = 2;
							return true;
						}
					}
					m00002f();
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
					m00002f();
				}
			}
		}

		public c000021(int p0)
		{
			HwFJIqNfCurva = p0;
		}

		private void m00002f()
		{
			HwFJIqNfCurva = -1;
			((IDisposable)lBtZnOPJiu).Dispose();
		}
	}

	private Dictionary<ulong, c00001f> qtZUksETBbF;

	private Dictionary<ulong, c00001f> mnZZceqskl;

	private readonly string f00005b;

	public c000020(string p0)
	{
		f00005b = p0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		c000021 c21 = new c000021(0);
		c21.gplEhxQobOrveX = this;
		return c21;
	}

	private void m00002e()
	{
		if (qtZUksETBbF == null)
		{
			IwzaWmnwcnlB iwzaWmnwcnlB = new IwzaWmnwcnlB();
			iwzaWmnwcnlB.CJkuFhqIgKwiFDo(f00005b, null, out qtZUksETBbF, out mnZZceqskl);
		}
	}
}
