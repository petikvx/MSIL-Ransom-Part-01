using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace wFLFuclWzVArMo;

public sealed class GmjRHaOlsTej : IEnumerable<string>, IEnumerable
{
	private sealed class DVTVMCNasQKFviR : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string iidPfodMqcUYFy;

		private int zuBUfNbnpvX;

		public GmjRHaOlsTej wUiFalyRykXM;

		public List<string> iRPiDmEBmn;

		public EcvBOyInqG lUjRVfMWymmB;

		public EcvBOyInqG EzxWdVYGyQLnh;

		public int MygRpMVcsdiIRL;

		public string vNzaGcTxfnJJ;

		public Dictionary<ulong, EcvBOyInqG>.ValueCollection.Enumerator usvOGdWaUBni;

		string IEnumerator<string>.Current => iidPfodMqcUYFy;

		object IEnumerator.Current => iidPfodMqcUYFy;

		private bool MoveNext()
		{
			try
			{
				switch (zuBUfNbnpvX)
				{
				case 0:
					zuBUfNbnpvX = -1;
					wUiFalyRykXM.REtsaJALtGo();
					iRPiDmEBmn = new List<string>();
					usvOGdWaUBni = wUiFalyRykXM.YIsACZETiKIZOt.Values.GetEnumerator();
					zuBUfNbnpvX = 1;
					goto IL_018e;
				case 2:
					{
						zuBUfNbnpvX = 1;
						goto IL_018e;
					}
					IL_018e:
					while (usvOGdWaUBni.MoveNext())
					{
						lUjRVfMWymmB = usvOGdWaUBni.Current;
						iRPiDmEBmn.Clear();
						EzxWdVYGyQLnh = lUjRVfMWymmB;
						MygRpMVcsdiIRL = -1;
						do
						{
							if (EzxWdVYGyQLnh.ParentFrn != 0L)
							{
								iRPiDmEBmn.Add(EzxWdVYGyQLnh.Name);
							}
							if (wUiFalyRykXM.YIsACZETiKIZOt.ContainsKey(EzxWdVYGyQLnh.ParentFrn))
							{
								EzxWdVYGyQLnh = wUiFalyRykXM.YIsACZETiKIZOt[EzxWdVYGyQLnh.ParentFrn];
							}
							else if (wUiFalyRykXM.SmGhhAiMHUjwZ.ContainsKey(EzxWdVYGyQLnh.ParentFrn))
							{
								EzxWdVYGyQLnh = wUiFalyRykXM.SmGhhAiMHUjwZ[EzxWdVYGyQLnh.ParentFrn];
							}
							else
							{
								EzxWdVYGyQLnh = null;
							}
						}
						while (EzxWdVYGyQLnh != null && ++MygRpMVcsdiIRL < 1000);
						if (iRPiDmEBmn.Count != 0)
						{
							iRPiDmEBmn.Reverse();
							vNzaGcTxfnJJ = wUiFalyRykXM.qXwKQHMQSvtnwb + '\\' + Path.Combine(iRPiDmEBmn.ToArray());
							iidPfodMqcUYFy = vNzaGcTxfnJJ;
							zuBUfNbnpvX = 2;
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
			switch (zuBUfNbnpvX)
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

		public DVTVMCNasQKFviR(int int_0)
		{
			zuBUfNbnpvX = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			zuBUfNbnpvX = -1;
			((IDisposable)usvOGdWaUBni).Dispose();
		}
	}

	private Dictionary<ulong, EcvBOyInqG> YIsACZETiKIZOt;

	private Dictionary<ulong, EcvBOyInqG> SmGhhAiMHUjwZ;

	private readonly string qXwKQHMQSvtnwb;

	public GmjRHaOlsTej(string string_0)
	{
		qXwKQHMQSvtnwb = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		DVTVMCNasQKFviR dVTVMCNasQKFviR = new DVTVMCNasQKFviR(0);
		dVTVMCNasQKFviR.wUiFalyRykXM = this;
		return dVTVMCNasQKFviR;
	}

	private void REtsaJALtGo()
	{
		if (YIsACZETiKIZOt == null)
		{
			jGfdhKPGPh jGfdhKPGPh2 = new jGfdhKPGPh();
			jGfdhKPGPh2.GgrQooptxtyoY(qXwKQHMQSvtnwb, null, out YIsACZETiKIZOt, out SmGhhAiMHUjwZ);
		}
	}
}
