using System;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public class vrkY9BJx3W : IPackLogMessage, INuGetLogMessage, ILogMessage, ILogFileContext
{
	[CompilerGenerated]
	private HVe4ZaB2Yt xRocHaADKM;

	[CompilerGenerated]
	private VMQYogJRDb rTKH6Ocqbx;

	[CompilerGenerated]
	private string RkdNMaQFud;

	[CompilerGenerated]
	private DateTimeOffset PabT8rYgzs;

	[CompilerGenerated]
	private string ssx6KqFQCp;

	[CompilerGenerated]
	private _9bY1QXMJ4W TYk62xQEXI = _9bY1QXMJ4W.Severe;

	[CompilerGenerated]
	private string tG3Vepx2Ag;

	[CompilerGenerated]
	private int aQimyQKR8L;

	[CompilerGenerated]
	private int KtLzBH2Jmq;

	[CompilerGenerated]
	private int NBMyh6vext;

	[CompilerGenerated]
	private int bCsdSmodtl;

	public HVe4ZaB2Yt LgyY8OAnYq
	{
		[CompilerGenerated]
		get
		{
			return xRocHaADKM;
		}
		[CompilerGenerated]
		set
		{
			xRocHaADKM = value;
		}
	}

	public VMQYogJRDb RRp80z9JOB
	{
		[CompilerGenerated]
		get
		{
			return rTKH6Ocqbx;
		}
		[CompilerGenerated]
		set
		{
			rTKH6Ocqbx = value;
		}
	}

	public string QRsbX1azql
	{
		[CompilerGenerated]
		get
		{
			return RkdNMaQFud;
		}
		[CompilerGenerated]
		set
		{
			RkdNMaQFud = value;
		}
	}

	public DateTimeOffset HCIk8gWMEn
	{
		[CompilerGenerated]
		get
		{
			return PabT8rYgzs;
		}
		[CompilerGenerated]
		set
		{
			PabT8rYgzs = value;
		}
	}

	public string _1RfjejNf0j
	{
		[CompilerGenerated]
		get
		{
			return ssx6KqFQCp;
		}
		[CompilerGenerated]
		set
		{
			ssx6KqFQCp = value;
		}
	}

	public _9bY1QXMJ4W Mi3xdroNyn
	{
		[CompilerGenerated]
		get
		{
			return TYk62xQEXI;
		}
		[CompilerGenerated]
		set
		{
			TYk62xQEXI = value;
		}
	}

	public string gwyjsBlyFi
	{
		[CompilerGenerated]
		get
		{
			return tG3Vepx2Ag;
		}
		[CompilerGenerated]
		set
		{
			tG3Vepx2Ag = value;
		}
	}

	public int oXLJNstvzB
	{
		[CompilerGenerated]
		get
		{
			return aQimyQKR8L;
		}
		[CompilerGenerated]
		set
		{
			aQimyQKR8L = value;
		}
	}

	public int nyGEunmE65
	{
		[CompilerGenerated]
		get
		{
			return KtLzBH2Jmq;
		}
		[CompilerGenerated]
		set
		{
			KtLzBH2Jmq = value;
		}
	}

	public int _14amd9Co5L
	{
		[CompilerGenerated]
		get
		{
			return NBMyh6vext;
		}
		[CompilerGenerated]
		set
		{
			NBMyh6vext = value;
		}
	}

	public int aY0yK26Z6o
	{
		[CompilerGenerated]
		get
		{
			return bCsdSmodtl;
		}
		[CompilerGenerated]
		set
		{
			bCsdSmodtl = value;
		}
	}

	private vrkY9BJx3W(HVe4ZaB2Yt logLevel, VMQYogJRDb logCode, string message)
	{
		LgyY8OAnYq = logLevel;
		RRp80z9JOB = logCode;
		QRsbX1azql = message;
		HCIk8gWMEn = DateTimeOffset.UtcNow;
	}

	private vrkY9BJx3W(HVe4ZaB2Yt logLevel, string message)
	{
		QRsbX1azql = message;
		RRp80z9JOB = VMQYogJRDb.Undefined;
		LgyY8OAnYq = logLevel;
		HCIk8gWMEn = DateTimeOffset.UtcNow;
	}

	public static vrkY9BJx3W sZO4BcQVak(string GHKrD9vvuT, VMQYogJRDb NenfsDlHaZ)
	{
		return new vrkY9BJx3W(HVe4ZaB2Yt.Error, NenfsDlHaZ, GHKrD9vvuT);
	}

	public static vrkY9BJx3W wWQwo9mNyp(string mLxuRVF8eb, VMQYogJRDb Xcta5lQMqA)
	{
		return new vrkY9BJx3W(HVe4ZaB2Yt.Warning, Xcta5lQMqA, mLxuRVF8eb);
	}

	public static vrkY9BJx3W M90ggoLR58(string gK7nXeAaA8, HVe4ZaB2Yt vj9xbycGCE)
	{
		return new vrkY9BJx3W(vj9xbycGCE, gK7nXeAaA8);
	}

	private static VMQYogJRDb x6bUHwwpS0(HVe4ZaB2Yt k5kVbQCGot)
	{
		return k5kVbQCGot switch
		{
			HVe4ZaB2Yt.Error => VMQYogJRDb.NU5000, 
			HVe4ZaB2Yt.Warning => VMQYogJRDb.NU5500, 
			_ => VMQYogJRDb.Undefined, 
		};
	}
}
