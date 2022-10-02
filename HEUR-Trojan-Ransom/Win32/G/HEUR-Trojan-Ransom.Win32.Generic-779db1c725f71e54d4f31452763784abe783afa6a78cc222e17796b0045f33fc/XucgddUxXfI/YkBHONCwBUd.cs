using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace XucgddUxXfI;

public sealed class YkBHONCwBUd : IEnumerable<string>, IEnumerable
{
	private sealed class atZALzqCSOYfIC : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string xVIPrnLDoTWjdvITz;

		private int wJRoGiEsdsbEs;

		public YkBHONCwBUd JWfsTcHVPaOMv;

		public List<string> hvUNRiXuhmRdK;

		public UbQjvrTNaCh mbyFnbJwhaRGWD;

		public UbQjvrTNaCh MeSVtHxnwTikSBDo;

		public int iYplfmoXLgbe;

		public string XWlXzpnTbSdD;

		public Dictionary<ulong, UbQjvrTNaCh>.ValueCollection.Enumerator XZhvNgGGNCbOC;

		string IEnumerator<string>.Current => xVIPrnLDoTWjdvITz;

		object IEnumerator.Current => xVIPrnLDoTWjdvITz;

		private bool MoveNext()
		{
			try
			{
				switch (wJRoGiEsdsbEs)
				{
				case 0:
					wJRoGiEsdsbEs = -1;
					JWfsTcHVPaOMv.xPEvEPQQUaUEbxZ();
					hvUNRiXuhmRdK = new List<string>();
					XZhvNgGGNCbOC = JWfsTcHVPaOMv.uWtVYjdVznoGn.Values.GetEnumerator();
					wJRoGiEsdsbEs = 1;
					goto IL_018e;
				case 2:
					{
						wJRoGiEsdsbEs = 1;
						goto IL_018e;
					}
					IL_018e:
					while (XZhvNgGGNCbOC.MoveNext())
					{
						mbyFnbJwhaRGWD = XZhvNgGGNCbOC.Current;
						hvUNRiXuhmRdK.Clear();
						MeSVtHxnwTikSBDo = mbyFnbJwhaRGWD;
						iYplfmoXLgbe = -1;
						do
						{
							if (MeSVtHxnwTikSBDo.ParentFrn != 0L)
							{
								hvUNRiXuhmRdK.Add(MeSVtHxnwTikSBDo.Name);
							}
							if (JWfsTcHVPaOMv.uWtVYjdVznoGn.ContainsKey(MeSVtHxnwTikSBDo.ParentFrn))
							{
								MeSVtHxnwTikSBDo = JWfsTcHVPaOMv.uWtVYjdVznoGn[MeSVtHxnwTikSBDo.ParentFrn];
							}
							else if (JWfsTcHVPaOMv.oyQFFMWWtc.ContainsKey(MeSVtHxnwTikSBDo.ParentFrn))
							{
								MeSVtHxnwTikSBDo = JWfsTcHVPaOMv.oyQFFMWWtc[MeSVtHxnwTikSBDo.ParentFrn];
							}
							else
							{
								MeSVtHxnwTikSBDo = null;
							}
						}
						while (MeSVtHxnwTikSBDo != null && ++iYplfmoXLgbe < 1000);
						if (hvUNRiXuhmRdK.Count != 0)
						{
							hvUNRiXuhmRdK.Reverse();
							XWlXzpnTbSdD = JWfsTcHVPaOMv.WiVmJroyTHr + '\\' + Path.Combine(hvUNRiXuhmRdK.ToArray());
							xVIPrnLDoTWjdvITz = XWlXzpnTbSdD;
							wJRoGiEsdsbEs = 2;
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
			switch (wJRoGiEsdsbEs)
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

		public atZALzqCSOYfIC(int int_0)
		{
			wJRoGiEsdsbEs = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			wJRoGiEsdsbEs = -1;
			((IDisposable)XZhvNgGGNCbOC).Dispose();
		}
	}

	private Dictionary<ulong, UbQjvrTNaCh> uWtVYjdVznoGn;

	private Dictionary<ulong, UbQjvrTNaCh> oyQFFMWWtc;

	private readonly string WiVmJroyTHr;

	public YkBHONCwBUd(string string_0)
	{
		WiVmJroyTHr = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		atZALzqCSOYfIC atZALzqCSOYfIC = new atZALzqCSOYfIC(0);
		atZALzqCSOYfIC.JWfsTcHVPaOMv = this;
		return atZALzqCSOYfIC;
	}

	private void xPEvEPQQUaUEbxZ()
	{
		if (uWtVYjdVznoGn == null)
		{
			QqsVeFsvYG qqsVeFsvYG = new QqsVeFsvYG();
			qqsVeFsvYG.WEtNMskVzoB(WiVmJroyTHr, null, out uWtVYjdVznoGn, out oyQFFMWWtc);
		}
	}
}
