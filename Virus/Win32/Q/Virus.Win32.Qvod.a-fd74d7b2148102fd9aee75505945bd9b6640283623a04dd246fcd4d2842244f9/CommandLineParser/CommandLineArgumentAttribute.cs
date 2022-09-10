using System;

namespace CommandLineParser;

[AttributeUsage(AttributeTargets.Field)]
public class CommandLineArgumentAttribute : Attribute
{
	private string shortName;

	private string longName;

	private CommandLineArgumentType type;

	public CommandLineArgumentType Type => type;

	public bool DefaultShortName => null == shortName;

	public string ShortName
	{
		get
		{
			return shortName;
		}
		set
		{
			shortName = value;
		}
	}

	public bool DefaultLongName => null == longName;

	public string LongName
	{
		get
		{
			return longName;
		}
		set
		{
			longName = value;
		}
	}

	public CommandLineArgumentAttribute()
	{
		type = CommandLineArgumentType.AtMostOnce;
	}

	public CommandLineArgumentAttribute(CommandLineArgumentType type)
	{
		this.type = type;
	}
}
