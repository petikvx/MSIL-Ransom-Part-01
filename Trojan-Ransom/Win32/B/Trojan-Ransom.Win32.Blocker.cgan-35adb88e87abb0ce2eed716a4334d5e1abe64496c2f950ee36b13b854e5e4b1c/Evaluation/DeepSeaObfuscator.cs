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
		Class7.Class8.Class10.smethod_11();
	}

	[SecuritySafeCritical]
	static DeepSeaObfuscator()
	{
		Class7.smethod_6();
	}
}
