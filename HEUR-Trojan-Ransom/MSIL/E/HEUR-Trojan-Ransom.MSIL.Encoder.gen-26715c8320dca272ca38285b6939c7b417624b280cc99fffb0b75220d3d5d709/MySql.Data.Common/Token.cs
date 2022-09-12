namespace MySql.Data.Common;

internal class Token
{
	public TokenType Type;

	public string Text;

	public bool Output;

	public bool IsRealToken
	{
		get
		{
			if (Type != TokenType.Comment && Type != TokenType.CommandComment && Type != TokenType.Whitespace)
			{
				return Output;
			}
			return false;
		}
	}

	public Token(TokenType type, string text)
	{
		Type = type;
		Text = text;
		Output = true;
	}
}
