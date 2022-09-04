using System;
using System.Security;
using My;

namespace Evaluation;

internal sealed class DeepSeaObfuscator : Attribute
{
	internal readonly string Warning;

	internal DeepSeaObfuscator(string string_0)
	{
		Warning = string_0;
		MyApplication.smethod_6();
	}

	[SecuritySafeCritical]
	static DeepSeaObfuscator()
	{
		MyApplication.Class0.smethod_12();
	}
}
