using System;

namespace CommandLineParser;

[AttributeUsage(AttributeTargets.Field)]
public class DefaultCommandLineArgumentAttribute : CommandLineArgumentAttribute
{
	public DefaultCommandLineArgumentAttribute(CommandLineArgumentType type)
		: base(type)
	{
	}
}
