using System;
using System.Runtime.CompilerServices;
using Geologe8s;
using ns4;
using ns6;
using ns8;

namespace Dorso0atera0;

public class Extra2agate : ILogMessage
{
	[CompilerGenerated]
	private Te3timonie3 Hogw11d;

	[CompilerGenerated]
	private Az0ths Camp7ly = Az0ths.Severe;

	[CompilerGenerated]
	private Thermogr5phers Hi7e7;

	[CompilerGenerated]
	private string Pi0s0b0;

	[CompilerGenerated]
	private string Can5ygrams;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_0 = DateTimeOffset.UtcNow;

	public Te3timonie3 Level
	{
		[CompilerGenerated]
		get
		{
			return Hogw11d;
		}
		[CompilerGenerated]
		set
		{
			Hogw11d = value;
		}
	}

	public Az0ths WarningLevel
	{
		[CompilerGenerated]
		get
		{
			return Camp7ly;
		}
		[CompilerGenerated]
		set
		{
			Camp7ly = value;
		}
	}

	public Thermogr5phers Code
	{
		[CompilerGenerated]
		get
		{
			return Hi7e7;
		}
		[CompilerGenerated]
		set
		{
			Hi7e7 = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return Pi0s0b0;
		}
		[CompilerGenerated]
		set
		{
			Pi0s0b0 = value;
		}
	}

	public string ProjectPath
	{
		[CompilerGenerated]
		get
		{
			return Can5ygrams;
		}
		[CompilerGenerated]
		set
		{
			Can5ygrams = value;
		}
	}

	public DateTimeOffset Time
	{
		[CompilerGenerated]
		get
		{
			return dateTimeOffset_0;
		}
		[CompilerGenerated]
		set
		{
			dateTimeOffset_0 = value;
		}
	}

	public Extra2agate(Te3timonie3 level, string message, Thermogr5phers code)
		: this(level, message)
	{
		Code = code;
	}

	public Extra2agate(Te3timonie3 level, string message)
	{
		Level = level;
		Message = message;
	}

	public override string Fore7ail()
	{
		return Message;
	}

	public static Extra2agate R3joind3rs(Thermogr5phers thermogr5phers_0, string Chap6en)
	{
		return new Extra2agate(Te3timonie3.Error, Chap6en, thermogr5phers_0);
	}

	public static Extra2agate smethod_0(Thermogr5phers thermogr5phers_0, string Tro3ars)
	{
		return new Extra2agate(Te3timonie3.Warning, Tro3ars, thermogr5phers_0);
	}

	public static Extra2agate smethod_1(Te3timonie3 Un1isguise1, string C6mpline)
	{
		return new Extra2agate(Un1isguise1, C6mpline);
	}
}
