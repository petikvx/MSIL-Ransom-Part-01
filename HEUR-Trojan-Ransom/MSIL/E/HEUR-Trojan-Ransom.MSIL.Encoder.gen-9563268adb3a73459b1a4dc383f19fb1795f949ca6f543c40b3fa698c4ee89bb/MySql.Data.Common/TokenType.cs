namespace MySql.Data.Common;

internal enum TokenType
{
	Keyword,
	String,
	Number,
	Symbol,
	Identifier,
	Comment,
	CommandComment,
	Whitespace
}
