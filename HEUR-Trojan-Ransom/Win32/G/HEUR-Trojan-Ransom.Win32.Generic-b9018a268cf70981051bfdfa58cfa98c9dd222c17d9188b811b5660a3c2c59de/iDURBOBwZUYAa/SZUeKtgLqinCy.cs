using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace iDURBOBwZUYAa;

public sealed class SZUeKtgLqinCy : IEnumerable<string>, IEnumerable
{
	private sealed class cuftcjyDKu : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string ZgwZckGSFE;

		private int zVwKEuLBCqYCx;

		public SZUeKtgLqinCy BQMpZOBqZDKJYd;

		public List<string> rLTGvvZryGw;

		public iTusLOxKGOOgeO IXVxuwDyoJydAT;

		public iTusLOxKGOOgeO nvmAAzOAhb;

		public int YsMBmtMlFYPzcqu;

		public string uGfbLFOiOdtY;

		public Dictionary<ulong, iTusLOxKGOOgeO>.ValueCollection.Enumerator NpkHDcHxDOfo;

		string IEnumerator<string>.Current => ZgwZckGSFE;

		object IEnumerator.Current => ZgwZckGSFE;

		private bool MoveNext()
		{
			try
			{
				switch (zVwKEuLBCqYCx)
				{
				case 0:
					zVwKEuLBCqYCx = -1;
					BQMpZOBqZDKJYd.UpmJtMnGcCmgeVx();
					rLTGvvZryGw = new List<string>();
					NpkHDcHxDOfo = BQMpZOBqZDKJYd.GKXHfOUcXWoR.Values.GetEnumerator();
					zVwKEuLBCqYCx = 1;
					goto IL_018e;
				case 2:
					{
						zVwKEuLBCqYCx = 1;
						goto IL_018e;
					}
					IL_018e:
					while (NpkHDcHxDOfo.MoveNext())
					{
						IXVxuwDyoJydAT = NpkHDcHxDOfo.Current;
						rLTGvvZryGw.Clear();
						nvmAAzOAhb = IXVxuwDyoJydAT;
						YsMBmtMlFYPzcqu = -1;
						do
						{
							if (nvmAAzOAhb.ParentFrn != 0L)
							{
								rLTGvvZryGw.Add(nvmAAzOAhb.Name);
							}
							if (BQMpZOBqZDKJYd.GKXHfOUcXWoR.ContainsKey(nvmAAzOAhb.ParentFrn))
							{
								nvmAAzOAhb = BQMpZOBqZDKJYd.GKXHfOUcXWoR[nvmAAzOAhb.ParentFrn];
							}
							else if (BQMpZOBqZDKJYd.rWyvSbCKDPU.ContainsKey(nvmAAzOAhb.ParentFrn))
							{
								nvmAAzOAhb = BQMpZOBqZDKJYd.rWyvSbCKDPU[nvmAAzOAhb.ParentFrn];
							}
							else
							{
								nvmAAzOAhb = null;
							}
						}
						while (nvmAAzOAhb != null && ++YsMBmtMlFYPzcqu < 1000);
						if (rLTGvvZryGw.Count != 0)
						{
							rLTGvvZryGw.Reverse();
							uGfbLFOiOdtY = BQMpZOBqZDKJYd.fEuadPuAjPXPfE + '\\' + Path.Combine(rLTGvvZryGw.ToArray());
							ZgwZckGSFE = uGfbLFOiOdtY;
							zVwKEuLBCqYCx = 2;
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
			switch (zVwKEuLBCqYCx)
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

		public cuftcjyDKu(int int_0)
		{
			zVwKEuLBCqYCx = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			zVwKEuLBCqYCx = -1;
			((IDisposable)NpkHDcHxDOfo).Dispose();
		}
	}

	private Dictionary<ulong, iTusLOxKGOOgeO> GKXHfOUcXWoR;

	private Dictionary<ulong, iTusLOxKGOOgeO> rWyvSbCKDPU;

	private readonly string fEuadPuAjPXPfE;

	public SZUeKtgLqinCy(string string_0)
	{
		fEuadPuAjPXPfE = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		cuftcjyDKu cuftcjyDKu = new cuftcjyDKu(0);
		cuftcjyDKu.BQMpZOBqZDKJYd = this;
		return cuftcjyDKu;
	}

	private void UpmJtMnGcCmgeVx()
	{
		if (GKXHfOUcXWoR == null)
		{
			uLMKysImSsJ uLMKysImSsJ2 = new uLMKysImSsJ();
			uLMKysImSsJ2.LelsgrjahQdRzW(fEuadPuAjPXPfE, null, out GKXHfOUcXWoR, out rWyvSbCKDPU);
		}
	}
}
