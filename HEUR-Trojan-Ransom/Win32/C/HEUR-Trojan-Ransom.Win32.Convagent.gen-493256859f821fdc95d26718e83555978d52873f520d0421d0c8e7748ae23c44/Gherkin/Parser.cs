using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Gherkin.Ast;

namespace Gherkin;

[CompilerGenerated]
public class Parser<T>
{
	[CompilerGenerated]
	protected class ParserContext
	{
		public ITokenScanner TokenScanner { get; set; }

		public ITokenMatcher TokenMatcher { get; set; }

		public Queue<Token> TokenQueue { get; set; }

		public List<ParserException> Errors { get; set; }
	}

	private readonly IAstBuilder<T> astBuilder;

	public bool StopAtFirstError { get; set; }

	public Parser()
		: this((IAstBuilder<T>)new AstBuilder<T>())
	{
	}

	public Parser(IAstBuilder<T> astBuilder)
	{
		this.astBuilder = astBuilder;
	}

	public T Parse(ITokenScanner tokenScanner)
	{
		return Parse(tokenScanner, new TokenMatcher());
	}

	public T Parse(ITokenScanner tokenScanner, ITokenMatcher tokenMatcher)
	{
		tokenMatcher.Reset();
		astBuilder.Reset();
		ParserContext parserContext = new ParserContext();
		parserContext.TokenScanner = tokenScanner;
		parserContext.TokenMatcher = tokenMatcher;
		parserContext.TokenQueue = new Queue<Token>();
		parserContext.Errors = new List<ParserException>();
		ParserContext parserContext2 = parserContext;
		StartRule(parserContext2, RuleType.GherkinDocument);
		int state = 0;
		Token token;
		do
		{
			token = ReadToken(parserContext2);
			state = MatchToken(state, token, parserContext2);
		}
		while (!token.IsEOF);
		EndRule(parserContext2, RuleType.GherkinDocument);
		if (parserContext2.Errors.Count > 0)
		{
			throw new CompositeParserException(parserContext2.Errors.ToArray());
		}
		return GetResult(parserContext2);
	}

	private void AddError(ParserContext context, ParserException error)
	{
		context.Errors.Add(error);
		if (context.Errors.Count > 10)
		{
			throw new CompositeParserException(context.Errors.ToArray());
		}
	}

	private void HandleAstError(ParserContext context, Action action)
	{
		HandleExternalError(context, delegate
		{
			action();
			return true;
		}, defaultValue: false);
	}

	private U HandleExternalError<U>(ParserContext context, Func<U> action, U defaultValue = default(U))
	{
		if (StopAtFirstError)
		{
			return action();
		}
		try
		{
			return action();
		}
		catch (CompositeParserException ex)
		{
			foreach (ParserException error2 in ex.Errors)
			{
				AddError(context, error2);
			}
			return defaultValue;
		}
		catch (ParserException error)
		{
			AddError(context, error);
			return defaultValue;
		}
	}

	private void Build(ParserContext context, Token token)
	{
		HandleAstError(context, delegate
		{
			astBuilder.Build(token);
		});
	}

	private void StartRule(ParserContext context, RuleType ruleType)
	{
		HandleAstError(context, delegate
		{
			astBuilder.StartRule(ruleType);
		});
	}

	private void EndRule(ParserContext context, RuleType ruleType)
	{
		HandleAstError(context, delegate
		{
			astBuilder.EndRule(ruleType);
		});
	}

	private T GetResult(ParserContext context)
	{
		return astBuilder.GetResult();
	}

	private Token ReadToken(ParserContext context)
	{
		return (context.TokenQueue.Count <= 0) ? context.TokenScanner.Read() : context.TokenQueue.Dequeue();
	}

	private bool Match_EOF(ParserContext context, Token token)
	{
		return HandleExternalError(context, () => context.TokenMatcher.Match_EOF(token), defaultValue: false);
	}

	private bool Match_Empty(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_Empty(token), defaultValue: false);
	}

	private bool Match_Comment(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_Comment(token), defaultValue: false);
	}

	private bool Match_TagLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_TagLine(token), defaultValue: false);
	}

	private bool Match_FeatureLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_FeatureLine(token), defaultValue: false);
	}

	private bool Match_BackgroundLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_BackgroundLine(token), defaultValue: false);
	}

	private bool Match_ScenarioLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_ScenarioLine(token), defaultValue: false);
	}

	private bool Match_ScenarioOutlineLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_ScenarioOutlineLine(token), defaultValue: false);
	}

	private bool Match_ExamplesLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_ExamplesLine(token), defaultValue: false);
	}

	private bool Match_StepLine(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_StepLine(token), defaultValue: false);
	}

	private bool Match_DocStringSeparator(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_DocStringSeparator(token), defaultValue: false);
	}

	private bool Match_TableRow(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_TableRow(token), defaultValue: false);
	}

	private bool Match_Language(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_Language(token), defaultValue: false);
	}

	private bool Match_Other(ParserContext context, Token token)
	{
		if (token.IsEOF)
		{
			return false;
		}
		return HandleExternalError(context, () => context.TokenMatcher.Match_Other(token), defaultValue: false);
	}

	protected virtual int MatchToken(int state, Token token, ParserContext context)
	{
		return state switch
		{
			0 => MatchTokenAt_0(token, context), 
			1 => MatchTokenAt_1(token, context), 
			2 => MatchTokenAt_2(token, context), 
			3 => MatchTokenAt_3(token, context), 
			4 => MatchTokenAt_4(token, context), 
			5 => MatchTokenAt_5(token, context), 
			6 => MatchTokenAt_6(token, context), 
			7 => MatchTokenAt_7(token, context), 
			8 => MatchTokenAt_8(token, context), 
			9 => MatchTokenAt_9(token, context), 
			10 => MatchTokenAt_10(token, context), 
			11 => MatchTokenAt_11(token, context), 
			12 => MatchTokenAt_12(token, context), 
			13 => MatchTokenAt_13(token, context), 
			14 => MatchTokenAt_14(token, context), 
			15 => MatchTokenAt_15(token, context), 
			16 => MatchTokenAt_16(token, context), 
			17 => MatchTokenAt_17(token, context), 
			18 => MatchTokenAt_18(token, context), 
			19 => MatchTokenAt_19(token, context), 
			20 => MatchTokenAt_20(token, context), 
			21 => MatchTokenAt_21(token, context), 
			22 => MatchTokenAt_22(token, context), 
			23 => MatchTokenAt_23(token, context), 
			24 => MatchTokenAt_24(token, context), 
			25 => MatchTokenAt_25(token, context), 
			26 => MatchTokenAt_26(token, context), 
			28 => MatchTokenAt_28(token, context), 
			29 => MatchTokenAt_29(token, context), 
			30 => MatchTokenAt_30(token, context), 
			31 => MatchTokenAt_31(token, context), 
			32 => MatchTokenAt_32(token, context), 
			33 => MatchTokenAt_33(token, context), 
			_ => throw new InvalidOperationException("Unknown state: " + state), 
		};
	}

	private int MatchTokenAt_0(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			Build(context, token);
			return 27;
		}
		if (Match_Language(context, token))
		{
			StartRule(context, RuleType.Feature);
			StartRule(context, RuleType.Feature_Header);
			Build(context, token);
			return 1;
		}
		if (Match_TagLine(context, token))
		{
			StartRule(context, RuleType.Feature);
			StartRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 2;
		}
		if (Match_FeatureLine(context, token))
		{
			StartRule(context, RuleType.Feature);
			StartRule(context, RuleType.Feature_Header);
			Build(context, token);
			return 3;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 0;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 0;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[6] { "#EOF", "#Language", "#TagLine", "#FeatureLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 0 - Start")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 0 - Start")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 0;
	}

	private int MatchTokenAt_1(Token token, ParserContext context)
	{
		if (Match_TagLine(context, token))
		{
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 2;
		}
		if (Match_FeatureLine(context, token))
		{
			Build(context, token);
			return 3;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 1;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 1;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[4] { "#TagLine", "#FeatureLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 1 - GherkinDocument:0>Feature:0>Feature_Header:0>#Language:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 1 - GherkinDocument:0>Feature:0>Feature_Header:0>#Language:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 1;
	}

	private int MatchTokenAt_2(Token token, ParserContext context)
	{
		if (Match_TagLine(context, token))
		{
			Build(context, token);
			return 2;
		}
		if (Match_FeatureLine(context, token))
		{
			EndRule(context, RuleType.Tags);
			Build(context, token);
			return 3;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 2;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 2;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[4] { "#TagLine", "#FeatureLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 2 - GherkinDocument:0>Feature:0>Feature_Header:1>Tags:0>#TagLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 2 - GherkinDocument:0>Feature:0>Feature_Header:1>Tags:0>#TagLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 2;
	}

	private int MatchTokenAt_3(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 3;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 5;
		}
		if (Match_BackgroundLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Background);
			Build(context, token);
			return 6;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			StartRule(context, RuleType.Description);
			Build(context, token);
			return 4;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Empty", "#Comment", "#BackgroundLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 3 - GherkinDocument:0>Feature:0>Feature_Header:2>#FeatureLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 3 - GherkinDocument:0>Feature:0>Feature_Header:2>#FeatureLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 3;
	}

	private int MatchTokenAt_4(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Feature_Header);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			EndRule(context, RuleType.Description);
			Build(context, token);
			return 5;
		}
		if (Match_BackgroundLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Background);
			Build(context, token);
			return 6;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 4;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#Comment", "#BackgroundLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 4 - GherkinDocument:0>Feature:0>Feature_Header:3>Feature_Description:0>Description_Helper:1>Description:0>#Other:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 4 - GherkinDocument:0>Feature:0>Feature_Header:3>Feature_Description:0>Description_Helper:1>Description:0>#Other:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 4;
	}

	private int MatchTokenAt_5(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 5;
		}
		if (Match_BackgroundLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Background);
			Build(context, token);
			return 6;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Feature_Header);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 5;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#Comment", "#BackgroundLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 5 - GherkinDocument:0>Feature:0>Feature_Header:3>Feature_Description:0>Description_Helper:2>#Comment:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 5 - GherkinDocument:0>Feature:0>Feature_Header:3>Feature_Description:0>Description_Helper:2>#Comment:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 5;
	}

	private int MatchTokenAt_6(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Background);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 6;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 8;
		}
		if (Match_StepLine(context, token))
		{
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 9;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			StartRule(context, RuleType.Description);
			Build(context, token);
			return 7;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Empty", "#Comment", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 6 - GherkinDocument:0>Feature:1>Background:0>#BackgroundLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 6 - GherkinDocument:0>Feature:1>Background:0>#BackgroundLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 6;
	}

	private int MatchTokenAt_7(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Background);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			EndRule(context, RuleType.Description);
			Build(context, token);
			return 8;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.Description);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 9;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 7;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#Comment", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 7 - GherkinDocument:0>Feature:1>Background:1>Background_Description:0>Description_Helper:1>Description:0>#Other:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 7 - GherkinDocument:0>Feature:1>Background:1>Background_Description:0>Description_Helper:1>Description:0>#Other:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 7;
	}

	private int MatchTokenAt_8(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Background);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 8;
		}
		if (Match_StepLine(context, token))
		{
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 9;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 8;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#Comment", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 8 - GherkinDocument:0>Feature:1>Background:1>Background_Description:0>Description_Helper:2>#Comment:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 8 - GherkinDocument:0>Feature:1>Background:1>Background_Description:0>Description_Helper:2>#Comment:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 8;
	}

	private int MatchTokenAt_9(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			StartRule(context, RuleType.DataTable);
			Build(context, token);
			return 10;
		}
		if (Match_DocStringSeparator(context, token))
		{
			StartRule(context, RuleType.DocString);
			Build(context, token);
			return 32;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 9;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 9;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 9;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[9] { "#EOF", "#TableRow", "#DocStringSeparator", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 9 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:0>#StepLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 9 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:0>#StepLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 9;
	}

	private int MatchTokenAt_10(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			Build(context, token);
			return 10;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 9;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 10;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 10;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#TableRow", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 10 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:0>DataTable:0>#TableRow:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 10 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:0>DataTable:0>#TableRow:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 10;
	}

	private int MatchTokenAt_11(Token token, ParserContext context)
	{
		if (Match_TagLine(context, token))
		{
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Tags);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Tags);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 11;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 11;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[5] { "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 11 - GherkinDocument:0>Feature:2>Scenario_Definition:0>Tags:0>#TagLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 11 - GherkinDocument:0>Feature:2>Scenario_Definition:0>Tags:0>#TagLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 11;
	}

	private int MatchTokenAt_12(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 12;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 14;
		}
		if (Match_StepLine(context, token))
		{
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 15;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			StartRule(context, RuleType.Description);
			Build(context, token);
			return 13;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Empty", "#Comment", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 12 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:0>#ScenarioLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 12 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:0>#ScenarioLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 12;
	}

	private int MatchTokenAt_13(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			EndRule(context, RuleType.Description);
			Build(context, token);
			return 14;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.Description);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 15;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 13;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#Comment", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 13 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:1>Scenario_Description:0>Description_Helper:1>Description:0>#Other:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 13 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:1>Scenario_Description:0>Description_Helper:1>Description:0>#Other:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 13;
	}

	private int MatchTokenAt_14(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 14;
		}
		if (Match_StepLine(context, token))
		{
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 15;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 14;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#Comment", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 14 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:1>Scenario_Description:0>Description_Helper:2>#Comment:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 14 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:1>Scenario_Description:0>Description_Helper:2>#Comment:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 14;
	}

	private int MatchTokenAt_15(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			StartRule(context, RuleType.DataTable);
			Build(context, token);
			return 16;
		}
		if (Match_DocStringSeparator(context, token))
		{
			StartRule(context, RuleType.DocString);
			Build(context, token);
			return 30;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 15;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 15;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 15;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[9] { "#EOF", "#TableRow", "#DocStringSeparator", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 15 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:0>#StepLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 15 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:0>#StepLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 15;
	}

	private int MatchTokenAt_16(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			Build(context, token);
			return 16;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 15;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 16;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 16;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#TableRow", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 16 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:0>DataTable:0>#TableRow:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 16 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:0>DataTable:0>#TableRow:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 16;
	}

	private int MatchTokenAt_17(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 19;
		}
		if (Match_StepLine(context, token))
		{
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 20;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			StartRule(context, RuleType.Description);
			Build(context, token);
			return 18;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[9] { "#EOF", "#Empty", "#Comment", "#StepLine", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 17 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:0>#ScenarioOutlineLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 17 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:0>#ScenarioOutlineLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 17;
	}

	private int MatchTokenAt_18(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			EndRule(context, RuleType.Description);
			Build(context, token);
			return 19;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.Description);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 20;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.Description);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Description);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 18;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Comment", "#StepLine", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 18 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:1>ScenarioOutline_Description:0>Description_Helper:1>Description:0>#Other:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 18 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:1>ScenarioOutline_Description:0>Description_Helper:1>Description:0>#Other:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 18;
	}

	private int MatchTokenAt_19(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 19;
		}
		if (Match_StepLine(context, token))
		{
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 20;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 19;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Comment", "#StepLine", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 19 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:1>ScenarioOutline_Description:0>Description_Helper:2>#Comment:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 19 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:1>ScenarioOutline_Description:0>Description_Helper:2>#Comment:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 19;
	}

	private int MatchTokenAt_20(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			StartRule(context, RuleType.DataTable);
			Build(context, token);
			return 21;
		}
		if (Match_DocStringSeparator(context, token))
		{
			StartRule(context, RuleType.DocString);
			Build(context, token);
			return 28;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 20;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 20;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 20;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[10] { "#EOF", "#TableRow", "#DocStringSeparator", "#StepLine", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 20 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:0>#StepLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 20 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:0>#StepLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 20;
	}

	private int MatchTokenAt_21(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			Build(context, token);
			return 21;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 20;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.DataTable);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 21;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 21;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[9] { "#EOF", "#TableRow", "#StepLine", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 21 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:1>Step_Arg:0>__alt1:0>DataTable:0>#TableRow:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 21 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:1>Step_Arg:0>__alt1:0>DataTable:0>#TableRow:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 21;
	}

	private int MatchTokenAt_22(Token token, ParserContext context)
	{
		if (Match_TagLine(context, token))
		{
			Build(context, token);
			return 22;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Tags);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 22;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 22;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[4] { "#TagLine", "#ExamplesLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 22 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:0>Tags:0>#TagLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 22 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:0>Tags:0>#TagLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 22;
	}

	private int MatchTokenAt_23(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 23;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 25;
		}
		if (Match_TableRow(context, token))
		{
			StartRule(context, RuleType.Examples_Table);
			Build(context, token);
			return 26;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			StartRule(context, RuleType.Description);
			Build(context, token);
			return 24;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[9] { "#EOF", "#Empty", "#Comment", "#TableRow", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 23 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:0>#ExamplesLine:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 23 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:0>#ExamplesLine:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 23;
	}

	private int MatchTokenAt_24(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			EndRule(context, RuleType.Description);
			Build(context, token);
			return 25;
		}
		if (Match_TableRow(context, token))
		{
			EndRule(context, RuleType.Description);
			StartRule(context, RuleType.Examples_Table);
			Build(context, token);
			return 26;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Description);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 24;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Comment", "#TableRow", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 24 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:1>Examples_Description:0>Description_Helper:1>Description:0>#Other:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 24 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:1>Examples_Description:0>Description_Helper:1>Description:0>#Other:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 24;
	}

	private int MatchTokenAt_25(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 25;
		}
		if (Match_TableRow(context, token))
		{
			StartRule(context, RuleType.Examples_Table);
			Build(context, token);
			return 26;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 25;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#Comment", "#TableRow", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 25 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:1>Examples_Description:0>Description_Helper:2>#Comment:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 25 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:1>Examples_Description:0>Description_Helper:2>#Comment:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 25;
	}

	private int MatchTokenAt_26(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.Examples_Table);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_TableRow(context, token))
		{
			Build(context, token);
			return 26;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.Examples_Table);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.Examples_Table);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.Examples_Table);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.Examples_Table);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.Examples_Table);
			EndRule(context, RuleType.Examples);
			EndRule(context, RuleType.Examples_Definition);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 26;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 26;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#TableRow", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 26 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:2>Examples_Table:0>#TableRow:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 26 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:3>Examples_Definition:1>Examples:2>Examples_Table:0>#TableRow:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 26;
	}

	private int MatchTokenAt_28(Token token, ParserContext context)
	{
		if (Match_DocStringSeparator(context, token))
		{
			Build(context, token);
			return 29;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 28;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[2] { "#DocStringSeparator", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 28 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:0>#DocStringSeparator:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 28 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:0>#DocStringSeparator:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 28;
	}

	private int MatchTokenAt_29(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 20;
		}
		if (Match_TagLine(context, token) && LookAhead_0(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 22;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ExamplesLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Examples_Definition);
			StartRule(context, RuleType.Examples);
			Build(context, token);
			return 23;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.ScenarioOutline);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 29;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 29;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[8] { "#EOF", "#StepLine", "#TagLine", "#ExamplesLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 29 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:2>#DocStringSeparator:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 29 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:1>ScenarioOutline:2>ScenarioOutline_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:2>#DocStringSeparator:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 29;
	}

	private int MatchTokenAt_30(Token token, ParserContext context)
	{
		if (Match_DocStringSeparator(context, token))
		{
			Build(context, token);
			return 31;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 30;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[2] { "#DocStringSeparator", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 30 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:0>#DocStringSeparator:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 30 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:0>#DocStringSeparator:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 30;
	}

	private int MatchTokenAt_31(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 15;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Scenario);
			EndRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 31;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 31;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 31 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:2>#DocStringSeparator:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 31 - GherkinDocument:0>Feature:2>Scenario_Definition:1>__alt0:0>Scenario:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:2>#DocStringSeparator:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 31;
	}

	private int MatchTokenAt_32(Token token, ParserContext context)
	{
		if (Match_DocStringSeparator(context, token))
		{
			Build(context, token);
			return 33;
		}
		if (Match_Other(context, token))
		{
			Build(context, token);
			return 32;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[2] { "#DocStringSeparator", "#Other" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 32 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:0>#DocStringSeparator:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 32 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:0>#DocStringSeparator:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 32;
	}

	private int MatchTokenAt_33(Token token, ParserContext context)
	{
		if (Match_EOF(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			EndRule(context, RuleType.Feature);
			Build(context, token);
			return 27;
		}
		if (Match_StepLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			StartRule(context, RuleType.Step);
			Build(context, token);
			return 9;
		}
		if (Match_TagLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Tags);
			Build(context, token);
			return 11;
		}
		if (Match_ScenarioLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.Scenario);
			Build(context, token);
			return 12;
		}
		if (Match_ScenarioOutlineLine(context, token))
		{
			EndRule(context, RuleType.DocString);
			EndRule(context, RuleType.Step);
			EndRule(context, RuleType.Background);
			StartRule(context, RuleType.Scenario_Definition);
			StartRule(context, RuleType.ScenarioOutline);
			Build(context, token);
			return 17;
		}
		if (Match_Comment(context, token))
		{
			Build(context, token);
			return 33;
		}
		if (Match_Empty(context, token))
		{
			Build(context, token);
			return 33;
		}
		token.Detach();
		string[] expectedTokenTypes = new string[7] { "#EOF", "#StepLine", "#TagLine", "#ScenarioLine", "#ScenarioOutlineLine", "#Comment", "#Empty" };
		ParserException ex = ((!token.IsEOF) ? ((TokenParserException)new UnexpectedTokenException(token, expectedTokenTypes, "State: 33 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:2>#DocStringSeparator:0")) : ((TokenParserException)new UnexpectedEOFException(token, expectedTokenTypes, "State: 33 - GherkinDocument:0>Feature:1>Background:2>Scenario_Step:0>Step:1>Step_Arg:0>__alt1:1>DocString:2>#DocStringSeparator:0")));
		if (StopAtFirstError)
		{
			throw ex;
		}
		AddError(context, ex);
		return 33;
	}

	private bool LookAhead_0(ParserContext context, Token currentToken)
	{
		currentToken.Detach();
		Queue<Token> queue = new Queue<Token>();
		bool result = false;
		Token token;
		do
		{
			token = ReadToken(context);
			token.Detach();
			queue.Enqueue(token);
			if (Match_ExamplesLine(context, token))
			{
				result = true;
				break;
			}
		}
		while (Match_Empty(context, token) || Match_Comment(context, token) || Match_TagLine(context, token));
		foreach (Token item in queue)
		{
			context.TokenQueue.Enqueue(item);
		}
		return result;
	}
}
public class Parser : Parser<GherkinDocument>
{
	public Parser()
	{
	}

	public Parser(IAstBuilder<GherkinDocument> astBuilder)
		: base(astBuilder)
	{
	}

	public GherkinDocument Parse(TextReader reader)
	{
		return Parse(new TokenScanner(reader));
	}

	public GherkinDocument Parse(string sourceFile)
	{
		using StreamReader reader = new StreamReader(sourceFile);
		return Parse(new TokenScanner(reader));
	}
}
