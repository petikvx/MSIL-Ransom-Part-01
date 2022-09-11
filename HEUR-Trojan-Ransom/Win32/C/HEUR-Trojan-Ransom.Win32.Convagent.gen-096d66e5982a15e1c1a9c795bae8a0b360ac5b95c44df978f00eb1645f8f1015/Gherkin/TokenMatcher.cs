using System;
using System.Linq;
using System.Text.RegularExpressions;
using Gherkin.Ast;

namespace Gherkin;

public class TokenMatcher : ITokenMatcher
{
	private readonly Regex LANGUAGE_PATTERN = new Regex("^\\s*#\\s*language\\s*:\\s*([a-zA-Z\\-_]+)\\s*$");

	private readonly IGherkinDialectProvider dialectProvider;

	private GherkinDialect currentDialect;

	private string activeDocStringSeparator;

	private int indentToRemove;

	public GherkinDialect CurrentDialect
	{
		get
		{
			if (currentDialect == null)
			{
				currentDialect = dialectProvider.DefaultDialect;
			}
			return currentDialect;
		}
	}

	public TokenMatcher(IGherkinDialectProvider dialectProvider = null)
	{
		this.dialectProvider = dialectProvider ?? new GherkinDialectProvider();
	}

	public TokenMatcher(string defaultLanguage)
		: this(new GherkinDialectProvider(defaultLanguage))
	{
	}

	public void Reset()
	{
		activeDocStringSeparator = null;
		indentToRemove = 0;
		if (currentDialect != dialectProvider.DefaultDialect)
		{
			currentDialect = dialectProvider.DefaultDialect;
		}
	}

	protected virtual void SetTokenMatched(Token token, TokenType matchedType, string text = null, string keyword = null, int? indent = null, GherkinLineSpan[] items = null)
	{
		token.MatchedType = matchedType;
		token.MatchedKeyword = keyword;
		token.MatchedText = text;
		token.MatchedItems = items;
		token.MatchedGherkinDialect = CurrentDialect;
		token.MatchedIndent = (indent.HasValue ? indent.Value : ((token.Line != null) ? token.Line.Indent : 0));
		token.Location = new Location(token.Location.Line, token.MatchedIndent + 1);
	}

	public bool Match_EOF(Token token)
	{
		if (token.IsEOF)
		{
			SetTokenMatched(token, TokenType.EOF);
			return true;
		}
		return false;
	}

	public bool Match_Other(Token token)
	{
		string lineText = token.Line.GetLineText(indentToRemove);
		SetTokenMatched(token, TokenType.Other, UnescapeDocString(lineText), null, 0);
		return true;
	}

	public bool Match_Empty(Token token)
	{
		if (token.Line.IsEmpty())
		{
			SetTokenMatched(token, TokenType.Empty);
			return true;
		}
		return false;
	}

	public bool Match_Comment(Token token)
	{
		if (token.Line.StartsWith("#"))
		{
			string lineText = token.Line.GetLineText();
			SetTokenMatched(token, TokenType.Comment, lineText, null, 0);
			return true;
		}
		return false;
	}

	private ParserException CreateTokenMatcherException(Token token, string message)
	{
		return new AstBuilderException(message, new Location(token.Location.Line, token.Line.Indent + 1));
	}

	public bool Match_Language(Token token)
	{
		Match match = LANGUAGE_PATTERN.Match(token.Line.GetLineText());
		if (match.Success)
		{
			string value = match.Groups[1].Value;
			SetTokenMatched(token, TokenType.Language, value);
			try
			{
				currentDialect = dialectProvider.GetDialect(value, token.Location);
			}
			catch (NotSupportedException ex)
			{
				throw CreateTokenMatcherException(token, ex.Message);
			}
			return true;
		}
		return false;
	}

	public bool Match_TagLine(Token token)
	{
		if (token.Line.StartsWith("@"))
		{
			GherkinLineSpan[] items = token.Line.GetTags().ToArray();
			SetTokenMatched(token, TokenType.TagLine, null, null, null, items);
			return true;
		}
		return false;
	}

	public bool Match_FeatureLine(Token token)
	{
		return MatchTitleLine(token, TokenType.FeatureLine, CurrentDialect.FeatureKeywords);
	}

	public bool Match_BackgroundLine(Token token)
	{
		return MatchTitleLine(token, TokenType.BackgroundLine, CurrentDialect.BackgroundKeywords);
	}

	public bool Match_ScenarioLine(Token token)
	{
		return MatchTitleLine(token, TokenType.ScenarioLine, CurrentDialect.ScenarioKeywords);
	}

	public bool Match_ScenarioOutlineLine(Token token)
	{
		return MatchTitleLine(token, TokenType.ScenarioOutlineLine, CurrentDialect.ScenarioOutlineKeywords);
	}

	public bool Match_ExamplesLine(Token token)
	{
		return MatchTitleLine(token, TokenType.ExamplesLine, CurrentDialect.ExamplesKeywords);
	}

	private bool MatchTitleLine(Token token, TokenType tokenType, string[] keywords)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < keywords.Length)
			{
				text = keywords[num];
				if (token.Line.StartsWithTitleKeyword(text))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		string restTrimmed = token.Line.GetRestTrimmed(text.Length + ":".Length);
		string keyword = text;
		SetTokenMatched(token, tokenType, restTrimmed, keyword);
		return true;
	}

	public bool Match_DocStringSeparator(Token token)
	{
		return (activeDocStringSeparator != null) ? Match_DocStringSeparator(token, activeDocStringSeparator, isOpen: false) : (Match_DocStringSeparator(token, "\"\"\"", isOpen: true) || Match_DocStringSeparator(token, "```", isOpen: true));
	}

	private bool Match_DocStringSeparator(Token token, string separator, bool isOpen)
	{
		if (token.Line.StartsWith(separator))
		{
			string text = null;
			if (isOpen)
			{
				text = token.Line.GetRestTrimmed(separator.Length);
				activeDocStringSeparator = separator;
				indentToRemove = token.Line.Indent;
			}
			else
			{
				activeDocStringSeparator = null;
				indentToRemove = 0;
			}
			SetTokenMatched(token, TokenType.DocStringSeparator, text);
			return true;
		}
		return false;
	}

	public bool Match_StepLine(Token token)
	{
		string[] stepKeywords = CurrentDialect.StepKeywords;
		string[] array = stepKeywords;
		int num = 0;
		string text;
		while (true)
		{
			if (num < array.Length)
			{
				text = array[num];
				if (token.Line.StartsWith(text))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		string restTrimmed = token.Line.GetRestTrimmed(text.Length);
		string keyword = text;
		SetTokenMatched(token, TokenType.StepLine, restTrimmed, keyword);
		return true;
	}

	public bool Match_TableRow(Token token)
	{
		if (token.Line.StartsWith("|"))
		{
			GherkinLineSpan[] items = token.Line.GetTableCells().ToArray();
			SetTokenMatched(token, TokenType.TableRow, null, null, null, items);
			return true;
		}
		return false;
	}

	private string UnescapeDocString(string text)
	{
		return (activeDocStringSeparator == null) ? text : text.Replace("\\\"\\\"\\\"", "\"\"\"");
	}
}
