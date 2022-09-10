using System.IO;
using System.Security;
using System.Text;

namespace Caspol;

internal sealed class Parser
{
	private SecurityElement _ecurr = null;

	private Tokenizer _t = null;

	public SecurityElement GetTopElement()
	{
		return (SecurityElement)_ecurr.Children![0];
	}

	public Encoding GetEncoding()
	{
		return _t.GetEncoding();
	}

	private void ParseContents(SecurityElement e, bool restarted)
	{
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		SecurityElementType securityElementType = SecurityElementType.Regular;
		ParserStack parserStack = new ParserStack();
		ParserStackFrame parserStackFrame = new ParserStackFrame();
		parserStackFrame.element = e;
		parserStackFrame.intag = false;
		parserStack.Push(parserStackFrame);
		bool flag = false;
		bool flag2 = false;
		do
		{
			ParserStackFrame parserStackFrame2 = parserStack.Peek();
			int num = _t.NextTokenType();
			while (true)
			{
				switch (num)
				{
				case 0:
					parserStackFrame2.intag = true;
					num = _t.NextTokenType();
					if (num == 2)
					{
						do
						{
							num = _t.NextTokenType();
						}
						while (num == 3);
						if (num == -1)
						{
							throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_UnexpectedEndOfFile"));
						}
						if (num != 1)
						{
							throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_ExpectedCloseBracket"));
						}
						parserStackFrame2.intag = false;
						securityElementType = parserStack.Peek().type;
						parserStack.Pop();
						flag = true;
					}
					else if (num == 3)
					{
						ParserStackFrame parserStackFrame3 = new ParserStackFrame();
						parserStackFrame3.element = new SecurityElement(_t.GetStringToken());
						if (parserStackFrame2.type != 0)
						{
							throw new XmlSyntaxException(_t.LineNo);
						}
						parserStackFrame2.element.AddChild(parserStackFrame3.element);
						parserStack.Push(parserStackFrame3);
						flag = true;
					}
					else if (num == 6)
					{
						ParserStackFrame parserStackFrame4 = new ParserStackFrame();
						parserStackFrame4.status = 1;
						while (true)
						{
							num = _t.NextTokenType();
							if (parserStackFrame4.status >= 3)
							{
								break;
							}
							if (num == 7)
							{
								parserStackFrame4.status++;
								continue;
							}
							throw new XmlSyntaxException(_t.LineNo);
						}
						if (num != 3)
						{
							throw new XmlSyntaxException(_t.LineNo);
						}
						parserStackFrame4.element = new SecurityElement(_t.GetStringToken());
						parserStackFrame4.type = SecurityElementType.Comment;
						if (parserStackFrame2.type != 0)
						{
							throw new XmlSyntaxException(_t.LineNo);
						}
						parserStackFrame2.element.AddChild(parserStackFrame4.element);
						parserStack.Push(parserStackFrame4);
						flag = true;
					}
					else
					{
						if (num != 5)
						{
							throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_ExpectedSlashOrString"));
						}
						num = _t.NextTokenType();
						if (num != 3)
						{
							throw new XmlSyntaxException(_t.LineNo);
						}
						ParserStackFrame parserStackFrame5 = new ParserStackFrame();
						parserStackFrame5.element = new SecurityElement(_t.GetStringToken());
						parserStackFrame5.type = SecurityElementType.Format;
						if (parserStackFrame2.type != 0)
						{
							throw new XmlSyntaxException(_t.LineNo);
						}
						parserStackFrame2.element.AddChild(parserStackFrame5.element);
						parserStackFrame5.status = 1;
						parserStack.Push(parserStackFrame5);
						flag = true;
					}
					goto IL_04ae;
				case 1:
					if (parserStackFrame2.intag)
					{
						parserStackFrame2.intag = false;
						goto IL_04b4;
					}
					throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_UnexpectedCloseBracket"));
				case 2:
					parserStackFrame2.element.Text = null;
					num = _t.NextTokenType();
					if (num == 1)
					{
						securityElementType = parserStack.Peek().type;
						parserStack.Pop();
						flag = true;
						goto IL_04ae;
					}
					throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_ExpectedCloseBracket"));
				case 3:
					if (parserStackFrame2.intag)
					{
						if (parserStackFrame2.type == SecurityElementType.Comment)
						{
							string text;
							if (parserStackFrame2.sawEquals)
							{
								text = "=\"" + _t.GetStringToken() + "\"";
								parserStackFrame2.sawEquals = false;
							}
							else
							{
								text = " " + _t.GetStringToken();
							}
							parserStackFrame2.element.Tag = parserStackFrame2.element.Tag + text;
						}
						else if (parserStackFrame2.strValue == null)
						{
							parserStackFrame2.strValue = _t.GetStringToken();
						}
						else
						{
							if (!parserStackFrame2.sawEquals)
							{
								throw new XmlSyntaxException(_t.LineNo);
							}
							parserStackFrame2.element.AddAttribute(parserStackFrame2.strValue, _t.GetStringToken());
							parserStackFrame2.strValue = null;
						}
					}
					else
					{
						if (parserStackFrame2.element.Text == null)
						{
							parserStackFrame2.element.Text = "";
						}
						StringBuilder stringBuilder = new StringBuilder(parserStackFrame2.element.Text);
						if (!parserStackFrame2.element.Text!.Equals(""))
						{
							stringBuilder.Append(" ");
						}
						stringBuilder.Append(_t.GetStringToken());
						parserStackFrame2.element.Text = stringBuilder.ToString();
					}
					goto IL_04ae;
				case 4:
					parserStackFrame2.sawEquals = true;
					goto IL_04ae;
				case 5:
					if (parserStackFrame2.intag && parserStackFrame2.type == SecurityElementType.Format && parserStackFrame2.status == 1)
					{
						num = _t.NextTokenType();
						if (num == 1)
						{
							securityElementType = parserStack.Peek().type;
							parserStack.Pop();
							flag = true;
							goto IL_04ae;
						}
						throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_ExpectedCloseBracket"));
					}
					throw new XmlSyntaxException(_t.LineNo);
				case 7:
					if (!parserStackFrame2.intag || parserStackFrame2.status <= 0 || parserStackFrame2.status >= 5 || parserStackFrame2.type != SecurityElementType.Comment)
					{
						break;
					}
					parserStackFrame2.status++;
					if (parserStackFrame2.status == 5)
					{
						num = _t.NextTokenType();
						if (num != 1)
						{
							throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_ExpectedCloseBracket"));
						}
						securityElementType = parserStack.Peek().type;
						parserStack.Pop();
						flag = true;
					}
					goto IL_04ae;
				case -1:
					if (flag2)
					{
						securityElementType = parserStack.Peek().type;
						parserStack.Pop();
					}
					else if (num == -1 && parserStack.GetCount() != 1)
					{
						throw new XmlSyntaxException(_t.LineNo, caspol.manager.GetString("XMLSyntax_UnexpectedEndOfFile"));
					}
					goto end_IL_04c1;
				default:
					{
						throw new XmlSyntaxException(_t.LineNo);
					}
					IL_04ae:
					if (!flag)
					{
						flag2 = true;
						goto IL_04b4;
					}
					flag = false;
					flag2 = false;
					goto case -1;
				}
				throw new XmlSyntaxException(_t.LineNo);
				IL_04b4:
				num = _t.NextTokenType();
				continue;
				end_IL_04c1:
				break;
			}
		}
		while (parserStack.GetCount() > 1);
		SecurityElement topElement = GetTopElement();
		if (securityElementType == SecurityElementType.Format)
		{
			if (restarted)
			{
				throw new XmlSyntaxException(_t.LineNo);
			}
			string text2 = topElement.Attribute("encoding");
			if (text2 != null)
			{
				_t.ChangeFormat(Encoding.GetEncoding(text2));
			}
			_ecurr = new SecurityElement("junk");
			ParseContents(_ecurr, restarted: true);
		}
	}

	private Parser(Tokenizer t)
	{
		_t = t;
		_ecurr = new SecurityElement("junk");
		ParseContents(_ecurr, restarted: false);
	}

	public Parser(string input)
		: this(new Tokenizer(input))
	{
	}

	public Parser(BinaryReader input)
		: this(new Tokenizer(input))
	{
	}

	public Parser(byte[] array)
		: this(new Tokenizer(array))
	{
	}

	public Parser(StreamReader input)
		: this(new Tokenizer(input))
	{
	}

	public Parser(Stream input)
		: this(new Tokenizer(input))
	{
	}

	public Parser(char[] array)
		: this(new Tokenizer(array))
	{
	}
}
