using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace bFWwXrIbhEFQiaW;

public sealed class QDBnVTSCszg : IEnumerable<string>, IEnumerable
{
	private sealed class eMNudVTEhIOo : IEnumerator<string>, IDisposable, IEnumerator
	{
		private string ODsGzTfkyzGFRm;

		private int ERucUgszCbZzJ;

		public QDBnVTSCszg LecCcPzMEgrin;

		public List<string> LuXXhhWCKM;

		public TBzXjPONBCkB ZKEHYuBqqazC;

		public TBzXjPONBCkB DohmIWEgtpmfObT;

		public int lfcwNvtMvxqtodnA;

		public string HSEnxQgvlZs;

		public Dictionary<ulong, TBzXjPONBCkB>.ValueCollection.Enumerator mIxJBohoesQIGt;

		string IEnumerator<string>.Current => ODsGzTfkyzGFRm;

		object IEnumerator.Current => ODsGzTfkyzGFRm;

		private bool MoveNext()
		{
			try
			{
				switch (ERucUgszCbZzJ)
				{
				case 0:
					ERucUgszCbZzJ = -1;
					LecCcPzMEgrin.zkLdmUVVdBl();
					LuXXhhWCKM = new List<string>();
					mIxJBohoesQIGt = LecCcPzMEgrin.DBYMPSAiyWmiA.Values.GetEnumerator();
					ERucUgszCbZzJ = 1;
					goto IL_018e;
				case 2:
					{
						ERucUgszCbZzJ = 1;
						goto IL_018e;
					}
					IL_018e:
					while (mIxJBohoesQIGt.MoveNext())
					{
						ZKEHYuBqqazC = mIxJBohoesQIGt.Current;
						LuXXhhWCKM.Clear();
						DohmIWEgtpmfObT = ZKEHYuBqqazC;
						lfcwNvtMvxqtodnA = -1;
						do
						{
							if (DohmIWEgtpmfObT.ParentFrn != 0L)
							{
								LuXXhhWCKM.Add(DohmIWEgtpmfObT.Name);
							}
							if (LecCcPzMEgrin.DBYMPSAiyWmiA.ContainsKey(DohmIWEgtpmfObT.ParentFrn))
							{
								DohmIWEgtpmfObT = LecCcPzMEgrin.DBYMPSAiyWmiA[DohmIWEgtpmfObT.ParentFrn];
							}
							else if (LecCcPzMEgrin.mYPnNfdaEHTrX.ContainsKey(DohmIWEgtpmfObT.ParentFrn))
							{
								DohmIWEgtpmfObT = LecCcPzMEgrin.mYPnNfdaEHTrX[DohmIWEgtpmfObT.ParentFrn];
							}
							else
							{
								DohmIWEgtpmfObT = null;
							}
						}
						while (DohmIWEgtpmfObT != null && ++lfcwNvtMvxqtodnA < 1000);
						if (LuXXhhWCKM.Count != 0)
						{
							LuXXhhWCKM.Reverse();
							HSEnxQgvlZs = LecCcPzMEgrin.ZrUkHcGuGtbxuLV + '\\' + Path.Combine(LuXXhhWCKM.ToArray());
							ODsGzTfkyzGFRm = HSEnxQgvlZs;
							ERucUgszCbZzJ = 2;
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
			switch (ERucUgszCbZzJ)
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

		public eMNudVTEhIOo(int int_0)
		{
			ERucUgszCbZzJ = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			ERucUgszCbZzJ = -1;
			((IDisposable)mIxJBohoesQIGt).Dispose();
		}
	}

	private Dictionary<ulong, TBzXjPONBCkB> DBYMPSAiyWmiA;

	private Dictionary<ulong, TBzXjPONBCkB> mYPnNfdaEHTrX;

	private readonly string ZrUkHcGuGtbxuLV;

	public QDBnVTSCszg(string string_0)
	{
		ZrUkHcGuGtbxuLV = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		eMNudVTEhIOo eMNudVTEhIOo = new eMNudVTEhIOo(0);
		eMNudVTEhIOo.LecCcPzMEgrin = this;
		return eMNudVTEhIOo;
	}

	private void zkLdmUVVdBl()
	{
		if (DBYMPSAiyWmiA == null)
		{
			jJJionEAPj jJJionEAPj2 = new jJJionEAPj();
			jJJionEAPj2.MnUXtmLbFtUrg(ZrUkHcGuGtbxuLV, null, out DBYMPSAiyWmiA, out mYPnNfdaEHTrX);
		}
	}
}
