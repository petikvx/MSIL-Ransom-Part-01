using System;
using System.Security;
using ns0;

namespace Evaluation;

internal sealed class DeepSeaObfuscator : Attribute
{
	internal readonly string Warning;

	internal DeepSeaObfuscator(string string_0)
	{
		Warning = string_0;
		Class9.Class11.smethod_10();
	}

	[SecuritySafeCritical]
	static DeepSeaObfuscator()
	{
		Class8.smethod_6();
	}
}
