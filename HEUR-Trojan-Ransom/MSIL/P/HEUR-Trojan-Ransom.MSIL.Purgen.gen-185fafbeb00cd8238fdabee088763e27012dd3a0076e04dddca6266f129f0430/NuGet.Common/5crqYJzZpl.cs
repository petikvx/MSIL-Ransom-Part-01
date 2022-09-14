using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public class _5crqYJzZpl : IRestoreLogMessage, INuGetLogMessage, ILogMessage, ILogFileContext
{
	[CompilerGenerated]
	private HVe4ZaB2Yt b0taq54Jg6;

	[CompilerGenerated]
	private VMQYogJRDb _1fy003jfR3;

	[CompilerGenerated]
	private string _9SrVH8nZXw;

	[CompilerGenerated]
	private DateTimeOffset PqaiVjr91n;

	[CompilerGenerated]
	private string av3ciOW9WK;

	[CompilerGenerated]
	private _9bY1QXMJ4W _1G9Q3uAoxg = _9bY1QXMJ4W.Severe;

	[CompilerGenerated]
	private string gQcyiM99Ck;

	[CompilerGenerated]
	private int bBNhVjxFbM;

	[CompilerGenerated]
	private int SDv6UQi8IR;

	[CompilerGenerated]
	private int _4A06p8clpL;

	[CompilerGenerated]
	private int MZH6yxO430;

	[CompilerGenerated]
	private string CfFXYXo6D9;

	[CompilerGenerated]
	private IReadOnlyList<string> DxE8ILg6kM;

	[CompilerGenerated]
	private bool wnaYwfbzWB;

	public HVe4ZaB2Yt _1ogfAn0bii
	{
		[CompilerGenerated]
		get
		{
			return b0taq54Jg6;
		}
		[CompilerGenerated]
		set
		{
			b0taq54Jg6 = value;
		}
	}

	public VMQYogJRDb CoHZxFGVfW
	{
		[CompilerGenerated]
		get
		{
			return _1fy003jfR3;
		}
		[CompilerGenerated]
		set
		{
			_1fy003jfR3 = value;
		}
	}

	public string YTtSuNHcn5
	{
		[CompilerGenerated]
		get
		{
			return _9SrVH8nZXw;
		}
		[CompilerGenerated]
		set
		{
			_9SrVH8nZXw = value;
		}
	}

	public DateTimeOffset Gpp4X90NjO
	{
		[CompilerGenerated]
		get
		{
			return PqaiVjr91n;
		}
		[CompilerGenerated]
		set
		{
			PqaiVjr91n = value;
		}
	}

	public string BkpEIYigOn
	{
		[CompilerGenerated]
		get
		{
			return av3ciOW9WK;
		}
		[CompilerGenerated]
		set
		{
			av3ciOW9WK = value;
		}
	}

	public _9bY1QXMJ4W _3dhVeR2COh
	{
		[CompilerGenerated]
		get
		{
			return _1G9Q3uAoxg;
		}
		[CompilerGenerated]
		set
		{
			_1G9Q3uAoxg = value;
		}
	}

	public string Zl6RTBngkI
	{
		[CompilerGenerated]
		get
		{
			return gQcyiM99Ck;
		}
		[CompilerGenerated]
		set
		{
			gQcyiM99Ck = value;
		}
	}

	public int _2lGqlDVe0t
	{
		[CompilerGenerated]
		get
		{
			return bBNhVjxFbM;
		}
		[CompilerGenerated]
		set
		{
			bBNhVjxFbM = value;
		}
	}

	public int EOGED985kc
	{
		[CompilerGenerated]
		get
		{
			return SDv6UQi8IR;
		}
		[CompilerGenerated]
		set
		{
			SDv6UQi8IR = value;
		}
	}

	public int dxKn2hSCGh
	{
		[CompilerGenerated]
		get
		{
			return _4A06p8clpL;
		}
		[CompilerGenerated]
		set
		{
			_4A06p8clpL = value;
		}
	}

	public int _3XhVccEBxc
	{
		[CompilerGenerated]
		get
		{
			return MZH6yxO430;
		}
		[CompilerGenerated]
		set
		{
			MZH6yxO430 = value;
		}
	}

	public string FbgzCiJ3fG
	{
		[CompilerGenerated]
		get
		{
			return CfFXYXo6D9;
		}
		[CompilerGenerated]
		set
		{
			CfFXYXo6D9 = value;
		}
	}

	public IReadOnlyList<string> oQbqxnSIlj
	{
		[CompilerGenerated]
		get
		{
			return DxE8ILg6kM;
		}
		[CompilerGenerated]
		set
		{
			DxE8ILg6kM = value;
		}
	}

	public bool K8s3dK3DDy
	{
		[CompilerGenerated]
		get
		{
			return wnaYwfbzWB;
		}
		[CompilerGenerated]
		set
		{
			wnaYwfbzWB = value;
		}
	}

	public _5crqYJzZpl(HVe4ZaB2Yt logLevel, VMQYogJRDb errorCode, string errorString, string targetGraph, bool logToInnerLogger)
	{
		_1ogfAn0bii = logLevel;
		CoHZxFGVfW = errorCode;
		YTtSuNHcn5 = errorString;
		Gpp4X90NjO = DateTimeOffset.UtcNow;
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(targetGraph))
		{
			list.Add(targetGraph);
		}
		oQbqxnSIlj = list;
		K8s3dK3DDy = logToInnerLogger;
	}

	public _5crqYJzZpl(HVe4ZaB2Yt logLevel, VMQYogJRDb errorCode, string errorString, string targetGraph)
		: this(logLevel, errorCode, errorString, targetGraph, logToInnerLogger: false)
	{
	}

	public _5crqYJzZpl(HVe4ZaB2Yt logLevel, VMQYogJRDb errorCode, string errorString)
		: this(logLevel, errorCode, errorString, string.Empty, logToInnerLogger: false)
	{
	}

	public _5crqYJzZpl(HVe4ZaB2Yt logLevel, string errorString)
		: this(logLevel, KPAyQEsoY5(logLevel), errorString, string.Empty, logToInnerLogger: false)
	{
	}

	public static _5crqYJzZpl sxnqxM9UWb(VMQYogJRDb uSNnJXBf22, string qsSqfPkyu5, string LpPGaLEyht, params string[] abUb3Xks8B)
	{
		return new _5crqYJzZpl(HVe4ZaB2Yt.Warning, qsSqfPkyu5)
		{
			CoHZxFGVfW = uSNnJXBf22,
			FbgzCiJ3fG = LpPGaLEyht,
			oQbqxnSIlj = abUb3Xks8B.ToList()
		};
	}

	public static _5crqYJzZpl vwk9xMNBQV(VMQYogJRDb qXdUkTEHWm, string W9Jv5P0Pm4)
	{
		return new _5crqYJzZpl(HVe4ZaB2Yt.Warning, qXdUkTEHWm, W9Jv5P0Pm4);
	}

	public static _5crqYJzZpl pVl1YC8EES(VMQYogJRDb zbVZeYMQdQ, string _7UgBnLbTmk)
	{
		return new _5crqYJzZpl(HVe4ZaB2Yt.Error, zbVZeYMQdQ, _7UgBnLbTmk);
	}

	public static _5crqYJzZpl eLRa4zYTuy(VMQYogJRDb EJlMrNWd8d, string jgXU8WdU2h, string fpA4pbb3k5, params string[] Eu5IUW07Ya)
	{
		return new _5crqYJzZpl(HVe4ZaB2Yt.Error, jgXU8WdU2h)
		{
			CoHZxFGVfW = EJlMrNWd8d,
			FbgzCiJ3fG = fpA4pbb3k5,
			oQbqxnSIlj = Eu5IUW07Ya.ToList()
		};
	}

	private static VMQYogJRDb KPAyQEsoY5(HVe4ZaB2Yt vFpfmw13WU)
	{
		return vFpfmw13WU switch
		{
			HVe4ZaB2Yt.Error => VMQYogJRDb.NU1000, 
			HVe4ZaB2Yt.Warning => VMQYogJRDb.NU1500, 
			_ => VMQYogJRDb.Undefined, 
		};
	}
}
