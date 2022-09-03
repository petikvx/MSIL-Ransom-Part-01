using System;
using oyhnnxoksms.My;

namespace Evaluation;

internal sealed class DeepSeaObfuscator : Attribute
{
	internal readonly string Warning;

	internal DeepSeaObfuscator(string string_0)
	{
		Warning = string_0;
		MyApplication.x.t();
	}

	static DeepSeaObfuscator()
	{
		MyApplication.w.a();
	}
}
