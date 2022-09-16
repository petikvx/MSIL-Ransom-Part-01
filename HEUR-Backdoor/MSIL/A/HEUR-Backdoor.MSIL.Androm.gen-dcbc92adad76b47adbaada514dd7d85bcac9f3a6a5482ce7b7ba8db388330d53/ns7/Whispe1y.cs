using System;
using System.Runtime.CompilerServices;
using Aphola5e;
using Geologe8s;
using O3cinols;
using Str4ami4st;
using ns4;
using ns6;
using ns8;

namespace ns7;

public class Whispe1y : ILogFileContext, ILogMessage, INuGetLogMessage, IPackLogMessage
{
	[CompilerGenerated]
	private Te3timonie3 Co77uptness;

	[CompilerGenerated]
	private Thermogr5phers Pa66book;

	[CompilerGenerated]
	private string Y1ppieish;

	[CompilerGenerated]
	private DateTimeOffset Wr6stlet;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private Az0ths E3ecrations = Az0ths.Severe;

	[CompilerGenerated]
	private string D7nnybr77k;

	[CompilerGenerated]
	private int Expe2imented;

	[CompilerGenerated]
	private int V0tra0n;

	[CompilerGenerated]
	private int Adulte2ously;

	[CompilerGenerated]
	private int Ch7rchman;

	public Te3timonie3 Level
	{
		[CompilerGenerated]
		get
		{
			return Co77uptness;
		}
		[CompilerGenerated]
		set
		{
			Co77uptness = value;
		}
	}

	public Thermogr5phers Code
	{
		[CompilerGenerated]
		get
		{
			return Pa66book;
		}
		[CompilerGenerated]
		set
		{
			Pa66book = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return Y1ppieish;
		}
		[CompilerGenerated]
		set
		{
			Y1ppieish = value;
		}
	}

	public DateTimeOffset Time
	{
		[CompilerGenerated]
		get
		{
			return Wr6stlet;
		}
		[CompilerGenerated]
		set
		{
			Wr6stlet = value;
		}
	}

	public string ProjectPath
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

	public Az0ths WarningLevel
	{
		[CompilerGenerated]
		get
		{
			return E3ecrations;
		}
		[CompilerGenerated]
		set
		{
			E3ecrations = value;
		}
	}

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return D7nnybr77k;
		}
		[CompilerGenerated]
		set
		{
			D7nnybr77k = value;
		}
	}

	public int StartLineNumber
	{
		[CompilerGenerated]
		get
		{
			return Expe2imented;
		}
		[CompilerGenerated]
		set
		{
			Expe2imented = value;
		}
	}

	public int StartColumnNumber
	{
		[CompilerGenerated]
		get
		{
			return V0tra0n;
		}
		[CompilerGenerated]
		set
		{
			V0tra0n = value;
		}
	}

	public int EndLineNumber
	{
		[CompilerGenerated]
		get
		{
			return Adulte2ously;
		}
		[CompilerGenerated]
		set
		{
			Adulte2ously = value;
		}
	}

	public int EndColumnNumber
	{
		[CompilerGenerated]
		get
		{
			return Ch7rchman;
		}
		[CompilerGenerated]
		set
		{
			Ch7rchman = value;
		}
	}

	private Whispe1y(Te3timonie3 logLevel, Thermogr5phers logCode, string message)
	{
		Level = logLevel;
		Code = logCode;
		Message = message;
		Time = DateTimeOffset.UtcNow;
	}

	private Whispe1y(Te3timonie3 logLevel, string message)
	{
		Message = message;
		Code = Thermogr5phers.Undefined;
		Level = logLevel;
		Time = DateTimeOffset.UtcNow;
	}

	public static Whispe1y Str8ct8ration(string Ta0ama, Thermogr5phers Ra5orbills)
	{
		return new Whispe1y(Te3timonie3.Error, Ra5orbills, Ta0ama);
	}

	public static Whispe1y Sco0iosis(string Pa6lum, Thermogr5phers Re3eizure3)
	{
		return new Whispe1y(Te3timonie3.Warning, Re3eizure3, Pa6lum);
	}

	public static Whispe1y Boxthorn7(string L8nesmen, Te3timonie3 As0rocy0ic)
	{
		return new Whispe1y(As0rocy0ic, L8nesmen);
	}

	private static Thermogr5phers smethod_0(Te3timonie3 Mahjo7ggs)
	{
		return Mahjo7ggs switch
		{
			Te3timonie3.Error => Thermogr5phers.NU5000, 
			Te3timonie3.Warning => Thermogr5phers.NU5500, 
			_ => Thermogr5phers.Undefined, 
		};
	}
}
