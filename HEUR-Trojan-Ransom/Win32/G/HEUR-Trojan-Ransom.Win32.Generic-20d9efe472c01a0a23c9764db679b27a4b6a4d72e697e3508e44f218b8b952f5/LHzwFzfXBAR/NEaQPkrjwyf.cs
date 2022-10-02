using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LHzwFzfXBAR;

public sealed class NEaQPkrjwyf : IEnumerable<string>, IEnumerable
{
	private sealed class BbtOepOUZyEQWmn : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string JjasvmFXqK;

		private int sYsVtfNICsgOwNt;

		public NEaQPkrjwyf FEDeAZpFjy;

		public List<string> UagmtiDUxqVOtP;

		public hGdahdRUOgSYh OMSBHwpgODzl;

		public hGdahdRUOgSYh UbDqijlktbjCPei;

		public int jyeEOjpRcbhyZ;

		public string yDtPgVpENSx;

		public Dictionary<ulong, hGdahdRUOgSYh>.ValueCollection.Enumerator IPvGscFBoNet;

		string IEnumerator<string>.Current => JjasvmFXqK;

		object IEnumerator.Current => JjasvmFXqK;

		private bool MoveNext()
		{
			try
			{
				switch (sYsVtfNICsgOwNt)
				{
				case 0:
					sYsVtfNICsgOwNt = -1;
					FEDeAZpFjy.oVkdMrjTMsOH();
					UagmtiDUxqVOtP = new List<string>();
					IPvGscFBoNet = FEDeAZpFjy.BJMtIJIbFljXjY.Values.GetEnumerator();
					sYsVtfNICsgOwNt = 1;
					goto IL_018e;
				case 2:
					{
						sYsVtfNICsgOwNt = 1;
						goto IL_018e;
					}
					IL_018e:
					while (IPvGscFBoNet.MoveNext())
					{
						OMSBHwpgODzl = IPvGscFBoNet.Current;
						UagmtiDUxqVOtP.Clear();
						UbDqijlktbjCPei = OMSBHwpgODzl;
						jyeEOjpRcbhyZ = -1;
						do
						{
							if (UbDqijlktbjCPei.ParentFrn != 0L)
							{
								UagmtiDUxqVOtP.Add(UbDqijlktbjCPei.Name);
							}
							if (FEDeAZpFjy.BJMtIJIbFljXjY.ContainsKey(UbDqijlktbjCPei.ParentFrn))
							{
								UbDqijlktbjCPei = FEDeAZpFjy.BJMtIJIbFljXjY[UbDqijlktbjCPei.ParentFrn];
							}
							else if (FEDeAZpFjy.fNaiLTsrqcF.ContainsKey(UbDqijlktbjCPei.ParentFrn))
							{
								UbDqijlktbjCPei = FEDeAZpFjy.fNaiLTsrqcF[UbDqijlktbjCPei.ParentFrn];
							}
							else
							{
								UbDqijlktbjCPei = null;
							}
						}
						while (UbDqijlktbjCPei != null && ++jyeEOjpRcbhyZ < 1000);
						if (UagmtiDUxqVOtP.Count != 0)
						{
							UagmtiDUxqVOtP.Reverse();
							yDtPgVpENSx = FEDeAZpFjy.GGKwuoKcpJvY + '\\' + Path.Combine(UagmtiDUxqVOtP.ToArray());
							JjasvmFXqK = yDtPgVpENSx;
							sYsVtfNICsgOwNt = 2;
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
			switch (sYsVtfNICsgOwNt)
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

		public BbtOepOUZyEQWmn(int int_0)
		{
			sYsVtfNICsgOwNt = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			sYsVtfNICsgOwNt = -1;
			((IDisposable)IPvGscFBoNet).Dispose();
		}
	}

	private Dictionary<ulong, hGdahdRUOgSYh> BJMtIJIbFljXjY;

	private Dictionary<ulong, hGdahdRUOgSYh> fNaiLTsrqcF;

	private readonly string GGKwuoKcpJvY;

	public NEaQPkrjwyf(string string_0)
	{
		GGKwuoKcpJvY = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		BbtOepOUZyEQWmn bbtOepOUZyEQWmn = new BbtOepOUZyEQWmn(0);
		bbtOepOUZyEQWmn.FEDeAZpFjy = this;
		return bbtOepOUZyEQWmn;
	}

	private void oVkdMrjTMsOH()
	{
		if (BJMtIJIbFljXjY == null)
		{
			TKLtuxaYLWh tKLtuxaYLWh = new TKLtuxaYLWh();
			tKLtuxaYLWh.JHOuLlHRZiz(GGKwuoKcpJvY, null, out BJMtIJIbFljXjY, out fNaiLTsrqcF);
		}
	}
}
