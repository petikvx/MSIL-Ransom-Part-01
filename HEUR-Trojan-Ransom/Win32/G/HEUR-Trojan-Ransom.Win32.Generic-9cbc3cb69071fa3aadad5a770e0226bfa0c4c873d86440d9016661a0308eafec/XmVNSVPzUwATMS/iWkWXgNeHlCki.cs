using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace XmVNSVPzUwATMS;

public sealed class iWkWXgNeHlCki : IEnumerable<string>, IEnumerable
{
	private sealed class smOKfiVWzXce : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string lPRtATMRZNPieN;

		private int AGdIwaOAsCXvO;

		public iWkWXgNeHlCki FqDywIWoKv;

		public List<string> bJenlMhWjIxAW;

		public wNutgPcrslPuK DYduxPxINGqJjb;

		public wNutgPcrslPuK OGLJSDTKFCMCo;

		public int AJGWVeXCCrmXWfC;

		public string mUPgexDAVmS;

		public Dictionary<ulong, wNutgPcrslPuK>.ValueCollection.Enumerator UpVZJZwAlr;

		string IEnumerator<string>.Current => lPRtATMRZNPieN;

		object IEnumerator.Current => lPRtATMRZNPieN;

		private bool MoveNext()
		{
			try
			{
				switch (AGdIwaOAsCXvO)
				{
				case 0:
					AGdIwaOAsCXvO = -1;
					FqDywIWoKv.JlVbfedEuptql();
					bJenlMhWjIxAW = new List<string>();
					UpVZJZwAlr = FqDywIWoKv.dubVyPClAKZH.Values.GetEnumerator();
					AGdIwaOAsCXvO = 1;
					goto IL_019e;
				case 2:
					{
						AGdIwaOAsCXvO = 1;
						goto IL_019e;
					}
					IL_019e:
					while (UpVZJZwAlr.MoveNext())
					{
						DYduxPxINGqJjb = UpVZJZwAlr.Current;
						bJenlMhWjIxAW.Clear();
						OGLJSDTKFCMCo = DYduxPxINGqJjb;
						AJGWVeXCCrmXWfC = -1;
						do
						{
							if (OGLJSDTKFCMCo.ParentFrn != 0L)
							{
								bJenlMhWjIxAW.Add(OGLJSDTKFCMCo.Name);
							}
							if (FqDywIWoKv.dubVyPClAKZH.ContainsKey(OGLJSDTKFCMCo.ParentFrn))
							{
								OGLJSDTKFCMCo = FqDywIWoKv.dubVyPClAKZH[OGLJSDTKFCMCo.ParentFrn];
							}
							else if (FqDywIWoKv.HFEYMspjTbMwXwZ.ContainsKey(OGLJSDTKFCMCo.ParentFrn))
							{
								OGLJSDTKFCMCo = FqDywIWoKv.HFEYMspjTbMwXwZ[OGLJSDTKFCMCo.ParentFrn];
							}
							else
							{
								OGLJSDTKFCMCo = null;
							}
						}
						while (OGLJSDTKFCMCo != null && ++AJGWVeXCCrmXWfC < 1000);
						if (bJenlMhWjIxAW.Count != 0)
						{
							bJenlMhWjIxAW.Reverse();
							mUPgexDAVmS = FqDywIWoKv.SlqaMLktugJdX + '\\' + Path.Combine(bJenlMhWjIxAW.ToArray());
							lPRtATMRZNPieN = mUPgexDAVmS;
							AGdIwaOAsCXvO = 2;
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
			switch (AGdIwaOAsCXvO)
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

		public smOKfiVWzXce(int int_0)
		{
			AGdIwaOAsCXvO = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			AGdIwaOAsCXvO = -1;
			((IDisposable)UpVZJZwAlr).Dispose();
		}
	}

	private Dictionary<ulong, wNutgPcrslPuK> dubVyPClAKZH;

	private Dictionary<ulong, wNutgPcrslPuK> HFEYMspjTbMwXwZ;

	private readonly string SlqaMLktugJdX;

	public iWkWXgNeHlCki(string string_0)
	{
		SlqaMLktugJdX = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		smOKfiVWzXce smOKfiVWzXce = new smOKfiVWzXce(0);
		smOKfiVWzXce.FqDywIWoKv = this;
		return smOKfiVWzXce;
	}

	private void JlVbfedEuptql()
	{
		if (dubVyPClAKZH == null)
		{
			VyLkIyFTJp vyLkIyFTJp = new VyLkIyFTJp();
			vyLkIyFTJp.PofSZHeQpiMf(SlqaMLktugJdX, null, out dubVyPClAKZH, out HFEYMspjTbMwXwZ);
		}
	}
}
