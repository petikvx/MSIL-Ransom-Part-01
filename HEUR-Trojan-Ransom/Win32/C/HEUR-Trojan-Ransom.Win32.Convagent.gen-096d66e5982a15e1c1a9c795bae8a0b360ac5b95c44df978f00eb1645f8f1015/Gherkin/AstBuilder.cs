using System;
using System.Collections.Generic;
using System.Linq;
using Gherkin.Ast;

namespace Gherkin;

public class AstBuilder<T> : IAstBuilder<T>
{
	private readonly Stack<AstNode> stack = new Stack<AstNode>();

	private List<Comment> comments = new List<Comment>();

	private AstNode CurrentNode => stack.Peek();

	public AstBuilder()
	{
		Reset();
	}

	public void Reset()
	{
		stack.Clear();
		stack.Push(new AstNode(RuleType.None));
		comments.Clear();
	}

	public void Build(Token token)
	{
		if (token.MatchedType == TokenType.Comment)
		{
			comments.Add(CreateComment(GetLocation(token), token.MatchedText));
		}
		else
		{
			CurrentNode.Add((RuleType)token.MatchedType, token);
		}
	}

	public void StartRule(RuleType ruleType)
	{
		stack.Push(new AstNode(ruleType));
	}

	public void EndRule(RuleType ruleType)
	{
		AstNode astNode = stack.Pop();
		object transformedNode = GetTransformedNode(astNode);
		CurrentNode.Add(astNode.RuleType, transformedNode);
	}

	public T GetResult()
	{
		return CurrentNode.GetSingle<T>(RuleType.GherkinDocument);
	}

	private object GetTransformedNode(AstNode node)
	{
		switch (node.RuleType)
		{
		case RuleType.GherkinDocument:
		{
			Feature single = node.GetSingle<Feature>(RuleType.Feature);
			return CreateGherkinDocument(single, comments.ToArray(), node);
		}
		case RuleType.Feature:
		{
			AstNode single2 = node.GetSingle<AstNode>(RuleType.Feature_Header);
			if (single2 == null)
			{
				return null;
			}
			Tag[] tags = GetTags(single2);
			Token token3 = single2.GetToken(TokenType.FeatureLine);
			if (token3 == null)
			{
				return null;
			}
			List<ScenarioDefinition> list = new List<ScenarioDefinition>();
			Background single3 = node.GetSingle<Background>(RuleType.Background);
			if (single3 != null)
			{
				list.Add(single3);
			}
			IEnumerable<ScenarioDefinition> source = list.Concat(node.GetItems<ScenarioDefinition>(RuleType.Scenario_Definition));
			string description = GetDescription(single2);
			if (token3.MatchedGherkinDialect == null)
			{
				return null;
			}
			string language = token3.MatchedGherkinDialect.Language;
			return CreateFeature(tags, GetLocation(token3), language, token3.MatchedKeyword, token3.MatchedText, description, source.ToArray(), node);
		}
		case RuleType.Background:
		{
			Token token4 = node.GetToken(TokenType.BackgroundLine);
			string description2 = GetDescription(node);
			Step[] steps = GetSteps(node);
			return CreateBackground(GetLocation(token4), token4.MatchedKeyword, token4.MatchedText, description2, steps, node);
		}
		case RuleType.Scenario_Definition:
		{
			Tag[] tags3 = GetTags(node);
			AstNode single6 = node.GetSingle<AstNode>(RuleType.Scenario);
			if (single6 != null)
			{
				Token token6 = single6.GetToken(TokenType.ScenarioLine);
				string description4 = GetDescription(single6);
				Step[] steps2 = GetSteps(single6);
				return CreateScenario(tags3, GetLocation(token6), token6.MatchedKeyword, token6.MatchedText, description4, steps2, node);
			}
			AstNode single7 = node.GetSingle<AstNode>(RuleType.ScenarioOutline);
			if (single7 == null)
			{
				throw new InvalidOperationException("Internal gramar error");
			}
			Token token7 = single7.GetToken(TokenType.ScenarioOutlineLine);
			string description5 = GetDescription(single7);
			Step[] steps3 = GetSteps(single7);
			Examples[] examples = single7.GetItems<Examples>(RuleType.Examples_Definition).ToArray();
			return CreateScenarioOutline(tags3, GetLocation(token7), token7.MatchedKeyword, token7.MatchedText, description5, steps3, examples, node);
		}
		case RuleType.Examples_Definition:
		{
			Tag[] tags2 = GetTags(node);
			AstNode single4 = node.GetSingle<AstNode>(RuleType.Examples);
			Token token5 = single4.GetToken(TokenType.ExamplesLine);
			string description3 = GetDescription(single4);
			TableRow[] single5 = single4.GetSingle<TableRow[]>(RuleType.Examples_Table);
			TableRow header = single5?.First();
			TableRow[] body = single5?.Skip(1).ToArray();
			return CreateExamples(tags2, GetLocation(token5), token5.MatchedKeyword, token5.MatchedText, description3, header, body, node);
		}
		case RuleType.Examples_Table:
			return GetTableRows(node);
		case RuleType.Step:
		{
			Token token2 = node.GetToken(TokenType.StepLine);
			StepArgument argument = node.GetSingle<StepArgument>(RuleType.DataTable) ?? node.GetSingle<StepArgument>(RuleType.DocString);
			return CreateStep(GetLocation(token2), token2.MatchedKeyword, token2.MatchedText, argument, node);
		}
		default:
			return node;
		case RuleType.Description:
		{
			IEnumerable<Token> tokens2 = node.GetTokens(TokenType.Other);
			tokens2 = tokens2.Reverse().SkipWhile((Token t) => string.IsNullOrWhiteSpace(t.MatchedText)).Reverse();
			return string.Join(Environment.NewLine, tokens2.Select((Token lt) => lt.MatchedText));
		}
		case RuleType.DataTable:
		{
			TableRow[] tableRows = GetTableRows(node);
			return CreateDataTable(tableRows, node);
		}
		case RuleType.DocString:
		{
			Token token = node.GetTokens(TokenType.DocStringSeparator).First();
			string contentType = ((token.MatchedText.Length != 0) ? token.MatchedText : null);
			IEnumerable<Token> tokens = node.GetTokens(TokenType.Other);
			string content = string.Join(Environment.NewLine, tokens.Select((Token lt) => lt.MatchedText));
			return CreateDocString(GetLocation(token), contentType, content, node);
		}
		}
	}

	protected virtual Background CreateBackground(Location location, string keyword, string name, string description, Step[] steps, AstNode node)
	{
		return new Background(location, keyword, name, description, steps);
	}

	protected virtual DataTable CreateDataTable(TableRow[] rows, AstNode node)
	{
		return new DataTable(rows);
	}

	protected virtual Comment CreateComment(Location location, string text)
	{
		return new Comment(location, text);
	}

	protected virtual ScenarioOutline CreateScenarioOutline(Tag[] tags, Location location, string keyword, string name, string description, Step[] steps, Examples[] examples, AstNode node)
	{
		return new ScenarioOutline(tags, location, keyword, name, description, steps, examples);
	}

	protected virtual Examples CreateExamples(Tag[] tags, Location location, string keyword, string name, string description, TableRow header, TableRow[] body, AstNode node)
	{
		return new Examples(tags, location, keyword, name, description, header, body);
	}

	protected virtual Scenario CreateScenario(Tag[] tags, Location location, string keyword, string name, string description, Step[] steps, AstNode node)
	{
		return new Scenario(tags, location, keyword, name, description, steps);
	}

	protected virtual DocString CreateDocString(Location location, string contentType, string content, AstNode node)
	{
		return new DocString(location, contentType, content);
	}

	protected virtual Step CreateStep(Location location, string keyword, string text, StepArgument argument, AstNode node)
	{
		return new Step(location, keyword, text, argument);
	}

	protected virtual GherkinDocument CreateGherkinDocument(Feature feature, Comment[] gherkinDocumentComments, AstNode node)
	{
		return new GherkinDocument(feature, gherkinDocumentComments);
	}

	protected virtual Feature CreateFeature(Tag[] tags, Location location, string language, string keyword, string name, string description, ScenarioDefinition[] children, AstNode node)
	{
		return new Feature(tags, location, language, keyword, name, description, children);
	}

	protected virtual Tag CreateTag(Location location, string name, AstNode node)
	{
		return new Tag(location, name);
	}

	protected virtual Location CreateLocation(int line, int column)
	{
		return new Location(line, column);
	}

	protected virtual TableRow CreateTableRow(Location location, TableCell[] cells, AstNode node)
	{
		return new TableRow(location, cells);
	}

	protected virtual TableCell CreateTableCell(Location location, string value)
	{
		return new TableCell(location, value);
	}

	private Location GetLocation(Token token, int column = 0)
	{
		return (column != 0) ? CreateLocation(token.Location.Line, column) : token.Location;
	}

	private Tag[] GetTags(AstNode node)
	{
		AstNode tagsNode = node.GetSingle<AstNode>(RuleType.Tags);
		if (tagsNode == null)
		{
			return new Tag[0];
		}
		return (from t in tagsNode.GetTokens(TokenType.TagLine)
			from tagItem in t.MatchedItems
			select CreateTag(GetLocation(t, tagItem.Column), tagItem.Text, tagsNode)).ToArray();
	}

	private TableRow[] GetTableRows(AstNode node)
	{
		TableRow[] array = (from token in node.GetTokens(TokenType.TableRow)
			select CreateTableRow(GetLocation(token), GetCells(token), node)).ToArray();
		EnsureCellCount(array);
		return array;
	}

	private void EnsureCellCount(TableRow[] rows)
	{
		if (rows.Length == 0)
		{
			return;
		}
		int num = rows[0].Cells.Count();
		int num2 = 0;
		TableRow tableRow;
		while (true)
		{
			if (num2 < rows.Length)
			{
				tableRow = rows[num2];
				if (tableRow.Cells.Count() != num)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		throw new AstBuilderException("inconsistent cell count within the table", tableRow.Location);
	}

	private TableCell[] GetCells(Token tableRowToken)
	{
		return tableRowToken.MatchedItems.Select((GherkinLineSpan cellItem) => CreateTableCell(GetLocation(tableRowToken, cellItem.Column), cellItem.Text)).ToArray();
	}

	private static Step[] GetSteps(AstNode scenarioDefinitionNode)
	{
		return scenarioDefinitionNode.GetItems<Step>(RuleType.Step).ToArray();
	}

	private static string GetDescription(AstNode scenarioDefinitionNode)
	{
		return scenarioDefinitionNode.GetSingle<string>(RuleType.Description);
	}
}
