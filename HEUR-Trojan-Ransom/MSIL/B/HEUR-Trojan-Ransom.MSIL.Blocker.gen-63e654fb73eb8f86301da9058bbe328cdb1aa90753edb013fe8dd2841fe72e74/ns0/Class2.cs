using System;

namespace ns0;

internal sealed class Class2
{
	private GenericUriParserOptions genericUriParserOptions_0;

	internal string string_0;

	public string String_0 => string_0;

	public GenericUriParserOptions GenericUriParserOptions_0 => genericUriParserOptions_0;

	public Class2(string string_1, GenericUriParserOptions genericUriParserOptions_1)
	{
		string text = (string_0 = string_1.ToLowerInvariant());
		genericUriParserOptions_0 = genericUriParserOptions_1;
	}
}
