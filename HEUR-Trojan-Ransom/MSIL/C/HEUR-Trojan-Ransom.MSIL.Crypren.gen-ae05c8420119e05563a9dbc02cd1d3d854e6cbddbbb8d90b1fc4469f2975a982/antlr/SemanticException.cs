using System;

namespace antlr;

[Serializable]
public class SemanticException : RecognitionException
{
	public SemanticException(string string_1)
	{
	}

	[Obsolete("Replaced by SemanticException(string, string, int, int) since version 2.7.2.6", false)]
	public SemanticException(string string_1, string string_2, int int_2)
	{
	}

	public SemanticException(string string_1, string string_2, int int_2, int int_3)
	{
	}
}
