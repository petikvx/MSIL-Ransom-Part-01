using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace NuGet.Common;

public static class RsvtOLUsBt
{
	public static void rnLIktzWJA(Exception l4iweCcSvq, ILogger besrSBFjxg)
	{
		ctMYBKgBnd(l4iweCcSvq, besrSBFjxg, Ixd6IRW9tf: false);
	}

	public static void ctMYBKgBnd(Exception tUEPRYJFMZ, ILogger JzCosRWut9, bool Ixd6IRW9tf)
	{
		Exception ex = QmwX3T8zEF(tUEPRYJFMZ);
		if (ex is ILogMessageException ex2)
		{
			ILogMessage message = ex2.AsLogMessage();
			JzCosRWut9.Log(message);
		}
		else
		{
			JzCosRWut9.Log(new coTQJabLMP(HVe4ZaB2Yt.Error, _3cBRe2YGoB(ex)));
		}
		HVe4ZaB2Yt _48EOpEgE5C = ((!Ixd6IRW9tf && !xnYPGTeMX0.fJSUgG00YX.kfJMKmpbLC) ? HVe4ZaB2Yt.Verbose : HVe4ZaB2Yt.Error);
		JzCosRWut9.Log(coTQJabLMP.lq3skthx9A(_48EOpEgE5C, ex.ToString()));
	}

	public static string YIluLPWsLO(Exception _4bwKumXQot, bool _6m7J0FAlhc)
	{
		if (_4bwKumXQot == null)
		{
			throw new ArgumentNullException("exception");
		}
		if (_4bwKumXQot is AggregateException _2e0x2hB4EN)
		{
			return ndmhhmRay9(_2e0x2hB4EN);
		}
		if (_4bwKumXQot is TargetInvocationException mNp1faqo)
		{
			return _6GGPZfaUQ7(mNp1faqo);
		}
		return _3mcyBJxLb7(eTSDaOrN4m(_4bwKumXQot), _6m7J0FAlhc);
	}

	public static string _3cBRe2YGoB(Exception GO1tx7SUSA)
	{
		return YIluLPWsLO(GO1tx7SUSA, _6m7J0FAlhc: true);
	}

	public static string ndmhhmRay9(AggregateException _2e0x2hB4EN)
	{
		if (_2e0x2hB4EN == null)
		{
			throw new ArgumentNullException("exception");
		}
		return _3mcyBJxLb7(lrfXJpTqbf(_2e0x2hB4EN), OqiRiumEVb: true);
	}

	public static string _6GGPZfaUQ7(TargetInvocationException mNp1faqo86)
	{
		if (mNp1faqo86 == null)
		{
			throw new ArgumentNullException("exception");
		}
		return _3mcyBJxLb7(RHAl221rrT(mNp1faqo86), OqiRiumEVb: true);
	}

	public static Exception QmwX3T8zEF(Exception _2VSD4seLQR)
	{
		if (_2VSD4seLQR == null)
		{
			throw new ArgumentNullException("exception");
		}
		if (_2VSD4seLQR.InnerException == null)
		{
			return _2VSD4seLQR;
		}
		if (_2VSD4seLQR is AggregateException || _2VSD4seLQR is TargetInvocationException)
		{
			return _2VSD4seLQR.GetBaseException();
		}
		return _2VSD4seLQR;
	}

	[IteratorStateMachine(typeof(_003CGetMessages_003Ed__7))]
	private static IEnumerable<string> lrfXJpTqbf(AggregateException fWkzgDuHqr)
	{
		//yield-return decompiler failed: Method not found
		return new VN884HnJ5w(-2)
		{
			xuiUaJHZkh = fWkzgDuHqr
		};
	}

	private static IEnumerable<string> RHAl221rrT(TargetInvocationException bcGnLOkm8W)
	{
		if (bcGnLOkm8W.InnerException != null)
		{
			return eTSDaOrN4m(bcGnLOkm8W.InnerException);
		}
		return new string[1] { bcGnLOkm8W.Message };
	}

	[IteratorStateMachine(typeof(_003CGetMessages_003Ed__9))]
	private static IEnumerable<string> eTSDaOrN4m(Exception gzI4bBgvGz)
	{
		//yield-return decompiler failed: Method not found
		return new R7MtFkKbOJ(-2)
		{
			KbRgMrXdo7 = gzI4bBgvGz
		};
	}

	[IteratorStateMachine(typeof(_003CGetLines_003Ed__10))]
	private static IEnumerable<string> FVCRlSkikj(string gpmzxNrb4g)
	{
		//yield-return decompiler failed: Method not found
		return new _1QA8oXkY08(-2)
		{
			aHhG1t46Vn = gpmzxNrb4g
		};
	}

	private static string _3mcyBJxLb7(IEnumerable<string> LE1YP4fsc2, bool OqiRiumEVb)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in LE1YP4fsc2)
		{
			bool flag = OqiRiumEVb && stringBuilder.Length > 0;
			foreach (string item2 in FVCRlSkikj(item))
			{
				if (flag)
				{
					stringBuilder.Append("  ");
				}
				stringBuilder.AppendLine(item2);
			}
		}
		return stringBuilder.ToString().TrimEnd(Array.Empty<char>());
	}
}
