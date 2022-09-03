using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace eZkFrthrrFwCL;

public sealed class vsQXEBAtRsiO : IEnumerable<string>, IEnumerable
{
	private sealed class yPtGgvKqJKwjpD : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string xXzEjOqEMoCqJGu;

		private int cWliQwfvyqJMcuL;

		public vsQXEBAtRsiO PGBWaQuvLqS;

		public List<string> ouRYlnkIwqXGUy;

		public vnuJlJKmoK LCKhmOYDEfXrjZ;

		public vnuJlJKmoK zcAqFXOUai;

		public int tLULfSRxgUyTL;

		public string vySwPdOkid;

		public Dictionary<ulong, vnuJlJKmoK>.ValueCollection.Enumerator dCWujdcZpMJA;

		string IEnumerator<string>.Current => xXzEjOqEMoCqJGu;

		object IEnumerator.Current => xXzEjOqEMoCqJGu;

		private bool MoveNext()
		{
			try
			{
				switch (cWliQwfvyqJMcuL)
				{
				case 0:
					cWliQwfvyqJMcuL = -1;
					PGBWaQuvLqS.JLYIzotYSIJ();
					ouRYlnkIwqXGUy = new List<string>();
					dCWujdcZpMJA = PGBWaQuvLqS.BYFhXQQLydd.Values.GetEnumerator();
					cWliQwfvyqJMcuL = 1;
					goto IL_018e;
				case 2:
					{
						cWliQwfvyqJMcuL = 1;
						goto IL_018e;
					}
					IL_018e:
					while (dCWujdcZpMJA.MoveNext())
					{
						LCKhmOYDEfXrjZ = dCWujdcZpMJA.Current;
						ouRYlnkIwqXGUy.Clear();
						zcAqFXOUai = LCKhmOYDEfXrjZ;
						tLULfSRxgUyTL = -1;
						do
						{
							if (zcAqFXOUai.ParentFrn != 0L)
							{
								ouRYlnkIwqXGUy.Add(zcAqFXOUai.Name);
							}
							if (PGBWaQuvLqS.BYFhXQQLydd.ContainsKey(zcAqFXOUai.ParentFrn))
							{
								zcAqFXOUai = PGBWaQuvLqS.BYFhXQQLydd[zcAqFXOUai.ParentFrn];
							}
							else if (PGBWaQuvLqS.DCgxXRjZKkeO.ContainsKey(zcAqFXOUai.ParentFrn))
							{
								zcAqFXOUai = PGBWaQuvLqS.DCgxXRjZKkeO[zcAqFXOUai.ParentFrn];
							}
							else
							{
								zcAqFXOUai = null;
							}
						}
						while (zcAqFXOUai != null && ++tLULfSRxgUyTL < 1000);
						if (ouRYlnkIwqXGUy.Count != 0)
						{
							ouRYlnkIwqXGUy.Reverse();
							vySwPdOkid = PGBWaQuvLqS.WkzUTILTWDSY + '\\' + Path.Combine(ouRYlnkIwqXGUy.ToArray());
							xXzEjOqEMoCqJGu = vySwPdOkid;
							cWliQwfvyqJMcuL = 2;
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
			switch (cWliQwfvyqJMcuL)
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

		public yPtGgvKqJKwjpD(int int_0)
		{
			cWliQwfvyqJMcuL = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			cWliQwfvyqJMcuL = -1;
			((IDisposable)dCWujdcZpMJA).Dispose();
		}
	}

	private Dictionary<ulong, vnuJlJKmoK> BYFhXQQLydd;

	private Dictionary<ulong, vnuJlJKmoK> DCgxXRjZKkeO;

	private readonly string WkzUTILTWDSY;

	public vsQXEBAtRsiO(string string_0)
	{
		WkzUTILTWDSY = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		yPtGgvKqJKwjpD yPtGgvKqJKwjpD = new yPtGgvKqJKwjpD(0);
		yPtGgvKqJKwjpD.PGBWaQuvLqS = this;
		return yPtGgvKqJKwjpD;
	}

	private void JLYIzotYSIJ()
	{
		if (BYFhXQQLydd == null)
		{
			qkWKRdCGhTIAL qkWKRdCGhTIAL2 = new qkWKRdCGhTIAL();
			qkWKRdCGhTIAL2.yQfRnhCHpWXyR(WkzUTILTWDSY, null, out BYFhXQQLydd, out DCgxXRjZKkeO);
		}
	}
}
