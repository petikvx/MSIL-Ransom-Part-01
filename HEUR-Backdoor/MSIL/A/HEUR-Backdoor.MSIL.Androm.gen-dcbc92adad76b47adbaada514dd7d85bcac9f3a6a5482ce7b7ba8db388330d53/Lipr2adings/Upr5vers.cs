using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aphola5e;
using Colla3ing;
using Geologe8s;
using Str4ami4st;
using ns4;
using ns6;
using ns8;

namespace Lipr2adings;

public class Upr5vers : ILogFileContext, ILogMessage, INuGetLogMessage, IRestoreLogMessage
{
	[CompilerGenerated]
	private Te3timonie3 Bafflega8s;

	[CompilerGenerated]
	private Thermogr5phers N5merable;

	[CompilerGenerated]
	private string Pompou8ne88;

	[CompilerGenerated]
	private DateTimeOffset Decarbox3lase;

	[CompilerGenerated]
	private string D3namics;

	[CompilerGenerated]
	private Az0ths Concept3alisms = Az0ths.Severe;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int F2ooders;

	[CompilerGenerated]
	private int L2vevines;

	[CompilerGenerated]
	private int E1o1ees;

	[CompilerGenerated]
	private int Spasm3ng;

	[CompilerGenerated]
	private string Tre8cly;

	[CompilerGenerated]
	private IReadOnlyList<string> P4as;

	[CompilerGenerated]
	private bool Amor8housnesses;

	public Te3timonie3 Level
	{
		[CompilerGenerated]
		get
		{
			return Bafflega8s;
		}
		[CompilerGenerated]
		set
		{
			Bafflega8s = value;
		}
	}

	public Thermogr5phers Code
	{
		[CompilerGenerated]
		get
		{
			return N5merable;
		}
		[CompilerGenerated]
		set
		{
			N5merable = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return Pompou8ne88;
		}
		[CompilerGenerated]
		set
		{
			Pompou8ne88 = value;
		}
	}

	public DateTimeOffset Time
	{
		[CompilerGenerated]
		get
		{
			return Decarbox3lase;
		}
		[CompilerGenerated]
		set
		{
			Decarbox3lase = value;
		}
	}

	public string ProjectPath
	{
		[CompilerGenerated]
		get
		{
			return D3namics;
		}
		[CompilerGenerated]
		set
		{
			D3namics = value;
		}
	}

	public Az0ths WarningLevel
	{
		[CompilerGenerated]
		get
		{
			return Concept3alisms;
		}
		[CompilerGenerated]
		set
		{
			Concept3alisms = value;
		}
	}

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public int StartLineNumber
	{
		[CompilerGenerated]
		get
		{
			return F2ooders;
		}
		[CompilerGenerated]
		set
		{
			F2ooders = value;
		}
	}

	public int StartColumnNumber
	{
		[CompilerGenerated]
		get
		{
			return L2vevines;
		}
		[CompilerGenerated]
		set
		{
			L2vevines = value;
		}
	}

	public int EndLineNumber
	{
		[CompilerGenerated]
		get
		{
			return E1o1ees;
		}
		[CompilerGenerated]
		set
		{
			E1o1ees = value;
		}
	}

	public int EndColumnNumber
	{
		[CompilerGenerated]
		get
		{
			return Spasm3ng;
		}
		[CompilerGenerated]
		set
		{
			Spasm3ng = value;
		}
	}

	public string LibraryId
	{
		[CompilerGenerated]
		get
		{
			return Tre8cly;
		}
		[CompilerGenerated]
		set
		{
			Tre8cly = value;
		}
	}

	public IReadOnlyList<string> TargetGraphs
	{
		[CompilerGenerated]
		get
		{
			return P4as;
		}
		[CompilerGenerated]
		set
		{
			P4as = value;
		}
	}

	public bool ShouldDisplay
	{
		[CompilerGenerated]
		get
		{
			return Amor8housnesses;
		}
		[CompilerGenerated]
		set
		{
			Amor8housnesses = value;
		}
	}

	public Upr5vers(Te3timonie3 logLevel, Thermogr5phers errorCode, string errorString, string targetGraph, bool logToInnerLogger)
	{
		Level = logLevel;
		Code = errorCode;
		Message = errorString;
		Time = DateTimeOffset.UtcNow;
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(targetGraph))
		{
			list.Add(targetGraph);
		}
		TargetGraphs = list;
		ShouldDisplay = logToInnerLogger;
	}

	public Upr5vers(Te3timonie3 logLevel, Thermogr5phers errorCode, string errorString, string targetGraph)
		: this(logLevel, errorCode, errorString, targetGraph, logToInnerLogger: false)
	{
	}

	public Upr5vers(Te3timonie3 logLevel, Thermogr5phers errorCode, string errorString)
		: this(logLevel, errorCode, errorString, string.Empty, logToInnerLogger: false)
	{
	}

	public Upr5vers(Te3timonie3 logLevel, string errorString)
		: this(logLevel, Uphe7ped(logLevel), errorString, string.Empty, logToInnerLogger: false)
	{
	}

	public static Upr5vers Av0ng0rs(Thermogr5phers Mage7ta, string Bleakne77e7, string Hemag3gs, params string[] S6perrich)
	{
		return new Upr5vers(Te3timonie3.Warning, Bleakne77e7)
		{
			Code = Mage7ta,
			LibraryId = Hemag3gs,
			TargetGraphs = S6perrich.ToList()
		};
	}

	public static Upr5vers smethod_0(Thermogr5phers A4cribed, string Disse4erance)
	{
		return new Upr5vers(Te3timonie3.Warning, A4cribed, Disse4erance);
	}

	public static Upr5vers smethod_1(Thermogr5phers Cap5tal5sed, string S0b0ls)
	{
		return new Upr5vers(Te3timonie3.Error, Cap5tal5sed, S0b0ls);
	}

	public static Upr5vers Pearl4t4c(Thermogr5phers Sto5s, string Us1abl1, string A8phalt8, params string[] Cod7f7cat7ons)
	{
		return new Upr5vers(Te3timonie3.Error, Us1abl1)
		{
			Code = Sto5s,
			LibraryId = A8phalt8,
			TargetGraphs = Cod7f7cat7ons.ToList()
		};
	}

	private static Thermogr5phers Uphe7ped(Te3timonie3 Becrustin1)
	{
		return Becrustin1 switch
		{
			Te3timonie3.Error => Thermogr5phers.NU1000, 
			Te3timonie3.Warning => Thermogr5phers.NU1500, 
			_ => Thermogr5phers.Undefined, 
		};
	}
}
