using System;

namespace antlr;

[Serializable]
public class TokenStreamRecognitionException : TokenStreamException
{
	public RecognitionException recognitionException_0;

	public TokenStreamRecognitionException(RecognitionException recognitionException_1)
	{
	}

	public override string ToString()
	{
		return (string)Class26.smethod_0(7346477, this, null);
	}
}
