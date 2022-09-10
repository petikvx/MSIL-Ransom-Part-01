using System;

namespace CommandLineParser;

[Flags]
public enum CommandLineArgumentType
{
	Required = 1,
	Unique = 2,
	Multiple = 4,
	AtMostOnce = 0,
	LastOccurenceWins = 4,
	MultipleUnique = 6
}
