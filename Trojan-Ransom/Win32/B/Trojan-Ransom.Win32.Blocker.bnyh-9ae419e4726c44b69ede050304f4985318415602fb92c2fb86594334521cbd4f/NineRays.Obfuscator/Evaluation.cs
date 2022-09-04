using System;

namespace NineRays.Obfuscator;

internal class Evaluation : Attribute
{
	internal readonly string Warning;

	internal Evaluation(string string_0)
	{
		Warning = string_0;
	}
}
