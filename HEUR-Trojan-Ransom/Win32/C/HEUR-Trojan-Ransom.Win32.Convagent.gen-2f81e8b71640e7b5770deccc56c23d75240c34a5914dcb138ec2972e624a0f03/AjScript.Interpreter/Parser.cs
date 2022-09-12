using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using AjScript.Commands;
using AjScript.Expressions;
using AjScript.Language;

namespace AjScript.Interpreter;

public class Parser : IDisposable
{
	private static readonly Token tokenSemiColon = new Token
	{
		TokenType = TokenType.Separator,
		Value = ";"
	};

	private static readonly string[] reserved = new string[5] { "this", "null", "true", "false", "undefined" };

	private Lexer lexer;

	private IList<ICommand> hoistedCommands;

	public Parser(string text)
		: this(new Lexer(text))
	{
	}

	public Parser(TextReader reader)
		: this(new Lexer(reader))
	{
	}

	public Parser(Lexer lexer)
	{
		this.lexer = lexer;
	}

	public ICommand ParseCommands()
	{
		IList<ICommand> commands = new List<ICommand>();
		IList<ICommand> list = hoistedCommands;
		try
		{
			hoistedCommands = new List<ICommand>();
			for (ICommand command = ParseCommand(); command != null; command = ParseCommand())
			{
				AddCommand(commands, command);
			}
			return new CompositeCommand(hoistedCommands, commands);
		}
		finally
		{
			hoistedCommands = list;
		}
	}

	public ICommand ParseCommand()
	{
		Token token = lexer.NextToken();
		if (token == null)
		{
			return null;
		}
		if (token.TokenType == TokenType.Name)
		{
			if (token.Value == "if")
			{
				return ParseIfCommand();
			}
			if (token.Value == "while")
			{
				return ParseWhileCommand();
			}
			if (token.Value == "for")
			{
				return ParseForCommand();
			}
			if (token.Value == "return")
			{
				return ParseReturnCommand();
			}
			if (token.Value == "var")
			{
				return ParseVarCommand();
			}
		}
		if (token.TokenType == TokenType.Separator && token.Value == "{")
		{
			return ParseCompositeCommand();
		}
		lexer.PushToken(token);
		ICommand result = ParseSimpleCommand() ?? throw new UnexpectedTokenException(token);
		Parse(TokenType.Separator, ";");
		return result;
	}

	public IExpression ParseExpression()
	{
		return ParseBinaryLogicalExpressionLevelOne();
	}

	public void Dispose()
	{
		if (lexer != null)
		{
			lexer.Dispose();
		}
	}

	private ICommand ParseSimpleCommand()
	{
		if (TryParse(TokenType.Name, "var"))
		{
			lexer.NextToken();
			return ParseVarCommand();
		}
		IExpression expression = ParseExpression();
		if (expression == null)
		{
			return null;
		}
		if (TryParse(TokenType.Operator, "="))
		{
			lexer.NextToken();
			ICommand command = null;
			if (expression is ArrayExpression)
			{
				ArrayExpression arrayExpression = (ArrayExpression)expression;
				return new SetArrayCommand(arrayExpression.Expression, arrayExpression.Arguments, ParseExpression());
			}
			if (expression is VariableExpression)
			{
				IsValidName(((VariableExpression)expression).Name);
			}
			return new SetCommand(expression, ParseExpression());
		}
		if (expression is FunctionExpression && ((FunctionExpression)expression).Name != null)
		{
			lexer.PushToken(tokenSemiColon);
		}
		return new ExpressionCommand(expression);
	}

	private static bool IsName(Token token, string value)
	{
		return IsToken(token, value, TokenType.Name);
	}

	private static bool IsToken(Token token, string value, TokenType type)
	{
		if (token == null)
		{
			return false;
		}
		if (token.TokenType != type)
		{
			return false;
		}
		return token.Value.Equals(value);
	}

	private ICollection<IExpression> ParseArrayValues()
	{
		Parse(TokenType.Separator, "{");
		List<IExpression> list = new List<IExpression>();
		while (!TryParse(TokenType.Separator, "}"))
		{
			if (list.Count > 0)
			{
				Parse(TokenType.Separator, ",");
			}
			list.Add(ParseExpression());
		}
		Parse(TokenType.Separator, "}");
		return list;
	}

	private IExpression ParseBinaryLogicalExpressionLevelOne()
	{
		IExpression expression = ParseBinaryLogicalExpressionLevelTwo();
		if (expression == null)
		{
			return null;
		}
		while (TryParse(TokenType.Operator, "||"))
		{
			lexer.NextToken();
			IExpression right = ParseBinaryLogicalExpressionLevelTwo();
			expression = new OrExpression(expression, right);
		}
		return expression;
	}

	private IExpression ParseBinaryLogicalExpressionLevelTwo()
	{
		IExpression expression = ParseBinaryExpressionZerothLevel();
		if (expression == null)
		{
			return null;
		}
		while (TryParse(TokenType.Operator, "&&"))
		{
			lexer.NextToken();
			IExpression right = ParseBinaryExpressionZerothLevel();
			expression = new AndExpression(expression, right);
		}
		return expression;
	}

	private IExpression ParseBinaryExpressionZerothLevel()
	{
		IExpression expression = ParseBinaryExpressionFirstLevel();
		if (expression == null)
		{
			return null;
		}
		while (TryParse(TokenType.Operator, "<", ">", "==", ">=", "<=", "!=", "===", "!=="))
		{
			Token token = lexer.NextToken();
			IExpression right = ParseBinaryExpressionFirstLevel();
			ComparisonOperator comparisonOperator = ComparisonOperator.Unknown;
			if (token.Value == "<")
			{
				comparisonOperator = ComparisonOperator.Less;
			}
			if (token.Value == ">")
			{
				comparisonOperator = ComparisonOperator.Greater;
			}
			if (token.Value == "<=")
			{
				comparisonOperator = ComparisonOperator.LessEqual;
			}
			if (token.Value == ">=")
			{
				comparisonOperator = ComparisonOperator.GreaterEqual;
			}
			if (token.Value == "===")
			{
				comparisonOperator = ComparisonOperator.Equal;
			}
			if (token.Value == "!==")
			{
				comparisonOperator = ComparisonOperator.NotEqual;
			}
			if (comparisonOperator != 0)
			{
				expression = new CompareExpression(comparisonOperator, expression, right);
				continue;
			}
			throw new ParserException($"Unknown operator '{token.Value}'");
		}
		return expression;
	}

	private IExpression ParseBinaryExpressionFirstLevel()
	{
		IExpression expression = ParseBinaryExpressionSecondLevel();
		if (expression == null)
		{
			return null;
		}
		while (TryParse(TokenType.Operator, "+", "-"))
		{
			Token token = lexer.NextToken();
			expression = new ArithmeticBinaryExpression(right: ParseBinaryExpressionSecondLevel(), operation: (!(token.Value == "+")) ? ArithmeticOperator.Subtract : ArithmeticOperator.Add, left: expression);
		}
		return expression;
	}

	private IExpression ParseBinaryExpressionSecondLevel()
	{
		IExpression expression = ParseUnaryExpression();
		if (expression == null)
		{
			return null;
		}
		while (TryParse(TokenType.Operator, "*", "/", "\\", "%"))
		{
			Token token = lexer.NextToken();
			IExpression right = ParseUnaryExpression();
			ArithmeticOperator operation;
			if (token.Value == "*")
			{
				operation = ArithmeticOperator.Multiply;
			}
			else if (token.Value == "/")
			{
				operation = ArithmeticOperator.Divide;
			}
			else if (token.Value == "\\")
			{
				operation = ArithmeticOperator.IntegerDivide;
			}
			else
			{
				if (!(token.Value == "%"))
				{
					throw new ParserException($"Invalid operator '{token.Value}'");
				}
				operation = ArithmeticOperator.Modulo;
			}
			expression = new ArithmeticBinaryExpression(operation, expression, right);
		}
		return expression;
	}

	private IExpression ParseUnaryExpression()
	{
		if (TryParse(TokenType.Operator, "+", "-", "!"))
		{
			Token token = lexer.NextToken();
			IExpression expression = ParseUnaryExpression();
			if (token.Value == "!")
			{
				return new NotExpression(expression);
			}
			return new ArithmeticUnaryExpression((token.Value == "+") ? ArithmeticOperator.Plus : ArithmeticOperator.Minus, expression);
		}
		if (TryParse(TokenType.Operator, "++", "--"))
		{
			Token token2 = lexer.NextToken();
			IExpression expression2 = ParseTermExpression();
			IncrementOperator oper = ((!(token2.Value == "++")) ? IncrementOperator.PreDecrement : IncrementOperator.PreIncrement);
			return new IncrementExpression(expression2, oper);
		}
		IExpression expression3 = ParseTermExpression();
		if (TryParse(TokenType.Operator, "++", "--"))
		{
			IncrementOperator oper2 = ((lexer.NextToken().Value == "++") ? IncrementOperator.PostIncrement : IncrementOperator.PostDecrement);
			return new IncrementExpression(expression3, oper2);
		}
		return expression3;
	}

	private IExpression ParseTermExpression()
	{
		if (TryParse(TokenType.Name, "new"))
		{
			return ParseNewExpression();
		}
		IExpression expression = ParseSimpleTermExpression();
		while (TryParse(TokenType.Operator, ".") || TryParse(TokenType.Separator, "[", "("))
		{
			if (TryParse(TokenType.Operator, "."))
			{
				lexer.NextToken();
				string name = ParseName();
				IList<IExpression> arguments = null;
				if (TryParse(TokenType.Separator, "("))
				{
					arguments = ParseArgumentList();
				}
				expression = new DotExpression(expression, name, arguments);
			}
			else if (TryParse(TokenType.Separator, "("))
			{
				IList<IExpression> arguments2 = ParseArgumentList();
				expression = new InvokeExpression(expression, arguments2);
			}
			else
			{
				expression = new ArrayExpression(expression, ParseArrayArgumentList());
			}
		}
		return expression;
	}

	private IExpression ParseNewExpression()
	{
		Parse(TokenType.Name, "new");
		string name = ParseName();
		IList<IExpression> arguments = ParseArgumentList();
		return new NewExpression(name, arguments);
	}

	private FunctionExpression ParseFunctionExpression()
	{
		string name = null;
		if (TryPeekName())
		{
			name = lexer.NextToken().Value;
		}
		IList<ICommand> list = hoistedCommands;
		hoistedCommands = new List<ICommand>();
		try
		{
			IList<string> source = ParseArgumentNames();
			Parse(TokenType.Separator, "{");
			CompositeCommand compositeCommand = ParseCompositeCommand();
			if (compositeCommand.HoistedCommandCount > 0)
			{
				throw new ParserException("Invalid command");
			}
			compositeCommand = new CompositeCommand(hoistedCommands, compositeCommand.Commands);
			return new FunctionExpression(name, source.ToArray(), compositeCommand);
		}
		finally
		{
			hoistedCommands = list;
		}
	}

	private IList<IExpression> ParseArgumentList()
	{
		List<IExpression> list = new List<IExpression>();
		Parse(TokenType.Separator, "(");
		while (!TryParse(TokenType.Separator, ")"))
		{
			if (list.Count > 0)
			{
				Parse(TokenType.Separator, ",");
			}
			list.Add(ParseExpression());
		}
		Parse(TokenType.Separator, ")");
		return list;
	}

	private IList<string> ParseArgumentNames()
	{
		List<string> list = new List<string>();
		Parse(TokenType.Separator, "(");
		while (TryPeekName())
		{
			string item = ParseName();
			list.Add(item);
			if (TryParse(TokenType.Separator, ")"))
			{
				break;
			}
			Parse(TokenType.Separator, ",");
		}
		Parse(TokenType.Separator, ")");
		return list;
	}

	private IList<IExpression> ParseArrayArgumentList()
	{
		List<IExpression> list = new List<IExpression>();
		Parse(TokenType.Separator, "[");
		while (!TryParse(TokenType.Separator, "]"))
		{
			if (list.Count > 0)
			{
				Parse(TokenType.Separator, ",");
			}
			list.Add(ParseExpression());
		}
		Parse(TokenType.Separator, "]");
		return list;
	}

	private IExpression ParseSimpleTermExpression()
	{
		Token token = lexer.NextToken();
		if (token == null)
		{
			return null;
		}
		if (token.TokenType == TokenType.Name && token.Value == "function")
		{
			return ParseFunctionExpression();
		}
		switch (token.TokenType)
		{
		case TokenType.Name:
		{
			IExpression expression = null;
			expression = new VariableExpression(token.Value);
			if (TryParse(TokenType.Separator, "("))
			{
				IList<IExpression> arguments = ParseArgumentList();
				expression = new InvokeExpression(expression, arguments);
			}
			return expression;
		}
		case TokenType.Integer:
			return new ConstantExpression(int.Parse(token.Value, CultureInfo.InvariantCulture));
		case TokenType.Real:
			return new ConstantExpression(double.Parse(token.Value, CultureInfo.InvariantCulture));
		case TokenType.Boolean:
			return new ConstantExpression(Convert.ToBoolean(token.Value));
		case TokenType.String:
			return new ConstantExpression(token.Value);
		case TokenType.Separator:
			if (token.Value == "(")
			{
				IExpression result = ParseExpression();
				Parse(TokenType.Separator, ")");
				return result;
			}
			if (token.Value == "{")
			{
				return ParseObjectExpression();
			}
			goto default;
		case TokenType.Object:
			if (token.Value == "null")
			{
				return new ConstantExpression(null);
			}
			if (token.Value == "undefined")
			{
				return new ConstantExpression(Undefined.Instance);
			}
			goto default;
		default:
			throw new UnexpectedTokenException(token);
		}
	}

	private IExpression ParseObjectExpression()
	{
		IList<string> list = new List<string>();
		IList<IExpression> list2 = new List<IExpression>();
		while (!TryParse(TokenType.Separator, "}"))
		{
			if (list.Count > 0)
			{
				Parse(TokenType.Separator, ",");
			}
			string item = ParseName();
			Parse(TokenType.Separator, ":");
			IExpression item2 = ParseExpression();
			list.Add(item);
			list2.Add(item2);
		}
		Parse(TokenType.Separator, "}");
		return new ObjectExpression(list, list2);
	}

	private CompositeCommand ParseCompositeCommand()
	{
		IList<ICommand> commands = new List<ICommand>();
		while (!TryParse(TokenType.Separator, "}"))
		{
			AddCommand(commands, ParseCommand());
		}
		lexer.NextToken();
		return new CompositeCommand(commands);
	}

	private void AddCommand(IList<ICommand> commands, ICommand command)
	{
		if (hoistedCommands != null && IsHoistedCommand(command))
		{
			hoistedCommands.Add(command);
		}
		else if (!IsNoOperationCommand(command))
		{
			commands.Add(command);
		}
	}

	private ICommand ParseReturnCommand()
	{
		if (TryParse(TokenType.Separator, ";"))
		{
			lexer.NextToken();
			return new ReturnCommand();
		}
		IExpression expression = ParseExpression();
		Parse(TokenType.Separator, ";");
		return new ReturnCommand(expression);
	}

	private ICommand ParseIfCommand()
	{
		Parse(TokenType.Separator, "(");
		IExpression condition = ParseExpression();
		Parse(TokenType.Separator, ")");
		ICommand thenCommand = ParseCommand();
		if (!TryParse(TokenType.Name, "else"))
		{
			return new IfCommand(condition, thenCommand);
		}
		lexer.NextToken();
		ICommand elseCommand = ParseCommand();
		return new IfCommand(condition, thenCommand, elseCommand);
	}

	private ICommand ParseWhileCommand()
	{
		Parse(TokenType.Separator, "(");
		IExpression condition = ParseExpression();
		Parse(TokenType.Separator, ")");
		ICommand command = ParseCommand();
		return new WhileCommand(condition, command);
	}

	private ICommand ParseForInCommand()
	{
		string text = ParseName();
		bool flag = false;
		if (text == "var")
		{
			text = ParseName();
			flag = true;
		}
		Parse(TokenType.Name, "in");
		IExpression expression = ParseExpression();
		Parse(TokenType.Separator, ")");
		ICommand command = ParseCommand();
		ICommand command2 = new ForEachCommand(text, expression, command);
		if (!flag)
		{
			return command2;
		}
		return new CompositeCommand(new List<ICommand>
		{
			new VarCommand(text),
			command2
		});
	}

	private ICommand ParseForCommand()
	{
		Parse(TokenType.Separator, "(");
		Token token = lexer.NextToken();
		if (token.TokenType == TokenType.Name && token.Value == "var")
		{
			string value = ParseName();
			if (TryParse(TokenType.Name, "in"))
			{
				lexer.PushToken(new Token
				{
					TokenType = TokenType.Name,
					Value = value
				});
				lexer.PushToken(token);
				return ParseForInCommand();
			}
			lexer.PushToken(new Token
			{
				TokenType = TokenType.Name,
				Value = value
			});
			lexer.PushToken(token);
		}
		ICommand initialCommand = ParseSimpleCommand();
		IExpression condition = ParseExpression();
		Parse(TokenType.Separator, ";");
		ICommand endCommand = ParseSimpleCommand();
		Parse(TokenType.Separator, ")");
		ICommand body = ParseCommand();
		return new ForCommand(initialCommand, condition, endCommand, body);
	}

	private ICommand ParseVarCommand()
	{
		string name = ParseName();
		IsValidName(name);
		IExpression expression = null;
		if (TryParse(TokenType.Operator, "="))
		{
			lexer.NextToken();
			expression = ParseExpression();
		}
		Parse(TokenType.Separator, ";");
		if (hoistedCommands != null)
		{
			hoistedCommands.Add(new VarCommand(name));
			if (expression == null)
			{
				return NoOperationCommand.Instance;
			}
			return new SetVariableCommand(name, expression);
		}
		if (expression == null)
		{
			return new VarCommand(name);
		}
		return new CompositeCommand(new List<ICommand>
		{
			new VarCommand(name),
			new SetVariableCommand(name, expression)
		});
	}

	private void ParseMemberVariable(IList<string> memberNames, IList<IExpression> memberExpressions)
	{
		string item = ParseName();
		IExpression item2 = null;
		if (TryParse(TokenType.Operator, "="))
		{
			lexer.NextToken();
			item2 = ParseExpression();
		}
		Parse(TokenType.Separator, ";");
		memberNames.Add(item);
		memberExpressions.Add(item2);
	}

	private void ParseMemberMethod(IList<string> memberNames, IList<IExpression> memberExpressions, bool isdefault)
	{
		string item = ParseName();
		bool hasvariableparameters = false;
		ParseParameters(ref hasvariableparameters);
		ParseCommand();
		memberNames.Add(item);
		throw new NotImplementedException();
	}

	private string[] ParseParameters(ref bool hasvariableparameters)
	{
		List<string> list = new List<string>();
		Parse(TokenType.Separator, "(");
		while (!TryParse(TokenType.Separator, ")"))
		{
			if (list.Count > 0)
			{
				Parse(TokenType.Separator, ",");
			}
			list.Add(ParseName());
		}
		lexer.NextToken();
		return list.ToArray();
	}

	private bool TryPeekName()
	{
		Token token = lexer.PeekToken();
		if (token == null)
		{
			return false;
		}
		return token.TokenType == TokenType.Name;
	}

	private object ParseValue()
	{
		Token token = lexer.NextToken();
		if (token == null)
		{
			throw new UnexpectedEndOfInputException();
		}
		if (token.TokenType == TokenType.String)
		{
			return token.Value;
		}
		if (token.TokenType != TokenType.Integer)
		{
			throw new UnexpectedTokenException(token);
		}
		return int.Parse(token.Value);
	}

	private bool TryParse(TokenType type, params string[] values)
	{
		Token token = lexer.PeekToken();
		if (token == null)
		{
			return false;
		}
		if (token.TokenType == type)
		{
			foreach (string text in values)
			{
				if (token.Value == text)
				{
					return true;
				}
			}
		}
		return false;
	}

	private void Parse(TokenType type, string value)
	{
		Token token = lexer.NextToken();
		if (token == null)
		{
			throw new UnexpectedEndOfInputException();
		}
		if (type == TokenType.Name)
		{
			if (!IsName(token, value))
			{
				throw new UnexpectedTokenException(token);
			}
		}
		else if (token.TokenType != type || token.Value != value)
		{
			throw new UnexpectedTokenException(token);
		}
	}

	private string ParseName()
	{
		Token token = lexer.NextToken();
		if (token == null)
		{
			throw new ParserException($"Unexpected end of input");
		}
		if (token.TokenType != 0)
		{
			throw new UnexpectedTokenException(token);
		}
		return token.Value;
	}

	private string ParseQualifiedName()
	{
		string text = ParseName();
		while (TryParse(TokenType.Operator, "."))
		{
			lexer.NextToken();
			text = text + "." + ParseName();
		}
		return text;
	}

	private static bool IsNoOperationCommand(ICommand command)
	{
		if (command == null)
		{
			return true;
		}
		if (command is CompositeCommand && ((CompositeCommand)command).CommandCount == 0)
		{
			return true;
		}
		if (command == NoOperationCommand.Instance)
		{
			return true;
		}
		return false;
	}

	private static bool IsHoistedCommand(ICommand command)
	{
		if (command == null)
		{
			return false;
		}
		if (command is VarCommand)
		{
			return true;
		}
		if (command is ExpressionCommand && ((ExpressionCommand)command).Expression is FunctionExpression && ((FunctionExpression)((ExpressionCommand)command).Expression).Name != null)
		{
			return true;
		}
		return false;
	}

	private void IsValidName(string name)
	{
		if (reserved.Contains(name))
		{
			throw new ParserException($"Invalid name '{name}'");
		}
	}
}
