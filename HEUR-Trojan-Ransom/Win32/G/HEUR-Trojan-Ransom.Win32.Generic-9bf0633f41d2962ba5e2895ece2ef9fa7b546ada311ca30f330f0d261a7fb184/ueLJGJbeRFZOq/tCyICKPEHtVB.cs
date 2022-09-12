using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ueLJGJbeRFZOq;

public sealed class tCyICKPEHtVB : IEnumerable<string>, IEnumerable
{
	private sealed class pwNcNduZxoW : IEnumerator<string>, IEnumerator, IDisposable
	{
		private string FTPLHMdKEjMdoVR;

		private int HmxYVKFLeZPxH;

		public tCyICKPEHtVB WGdARPEwdUDnfb;

		public List<string> sGxrxuMRBai;

		public MfCRkKvYSremtJ pVvCFVGoLsRvwW;

		public MfCRkKvYSremtJ dyTOZgeOCnpPhP;

		public int ozaGghPjzuA;

		public string epVGChuLKsT;

		public Dictionary<ulong, MfCRkKvYSremtJ>.ValueCollection.Enumerator mzCRnvyOIcqf;

		string IEnumerator<string>.Current => FTPLHMdKEjMdoVR;

		object IEnumerator.Current => FTPLHMdKEjMdoVR;

		private bool MoveNext()
		{
			try
			{
				switch (HmxYVKFLeZPxH)
				{
				case 0:
					HmxYVKFLeZPxH = -1;
					WGdARPEwdUDnfb.EuaSYbXuDaAaIXX();
					sGxrxuMRBai = new List<string>();
					mzCRnvyOIcqf = WGdARPEwdUDnfb.FaEmDwLGknL.Values.GetEnumerator();
					HmxYVKFLeZPxH = 1;
					goto IL_018e;
				case 2:
					{
						HmxYVKFLeZPxH = 1;
						goto IL_018e;
					}
					IL_018e:
					while (mzCRnvyOIcqf.MoveNext())
					{
						pVvCFVGoLsRvwW = mzCRnvyOIcqf.Current;
						sGxrxuMRBai.Clear();
						dyTOZgeOCnpPhP = pVvCFVGoLsRvwW;
						ozaGghPjzuA = -1;
						do
						{
							if (dyTOZgeOCnpPhP.ParentFrn != 0L)
							{
								sGxrxuMRBai.Add(dyTOZgeOCnpPhP.Name);
							}
							if (WGdARPEwdUDnfb.FaEmDwLGknL.ContainsKey(dyTOZgeOCnpPhP.ParentFrn))
							{
								dyTOZgeOCnpPhP = WGdARPEwdUDnfb.FaEmDwLGknL[dyTOZgeOCnpPhP.ParentFrn];
							}
							else if (WGdARPEwdUDnfb.XCLjqRfOfyrl.ContainsKey(dyTOZgeOCnpPhP.ParentFrn))
							{
								dyTOZgeOCnpPhP = WGdARPEwdUDnfb.XCLjqRfOfyrl[dyTOZgeOCnpPhP.ParentFrn];
							}
							else
							{
								dyTOZgeOCnpPhP = null;
							}
						}
						while (dyTOZgeOCnpPhP != null && ++ozaGghPjzuA < 1000);
						if (sGxrxuMRBai.Count != 0)
						{
							sGxrxuMRBai.Reverse();
							epVGChuLKsT = WGdARPEwdUDnfb.rOJjIOviiRdAL + '\\' + Path.Combine(sGxrxuMRBai.ToArray());
							FTPLHMdKEjMdoVR = epVGChuLKsT;
							HmxYVKFLeZPxH = 2;
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
			switch (HmxYVKFLeZPxH)
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

		public pwNcNduZxoW(int int_0)
		{
			HmxYVKFLeZPxH = int_0;
		}

		private void _003C_003Em__Finally7()
		{
			HmxYVKFLeZPxH = -1;
			((IDisposable)mzCRnvyOIcqf).Dispose();
		}
	}

	private Dictionary<ulong, MfCRkKvYSremtJ> FaEmDwLGknL;

	private Dictionary<ulong, MfCRkKvYSremtJ> XCLjqRfOfyrl;

	private readonly string rOJjIOviiRdAL;

	public tCyICKPEHtVB(string string_0)
	{
		rOJjIOviiRdAL = string_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		pwNcNduZxoW pwNcNduZxoW = new pwNcNduZxoW(0);
		pwNcNduZxoW.WGdARPEwdUDnfb = this;
		return pwNcNduZxoW;
	}

	private void EuaSYbXuDaAaIXX()
	{
		if (FaEmDwLGknL == null)
		{
			NsgdkUCziu nsgdkUCziu = new NsgdkUCziu();
			nsgdkUCziu.EEHCdCakbQjF(rOJjIOviiRdAL, null, out FaEmDwLGknL, out XCLjqRfOfyrl);
		}
	}
}
