using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

internal abstract class JsonTokenizer
{
	private sealed class JsonReplayTokenizer : JsonTokenizer
	{
		private readonly IList<JsonToken> tokens;

		private readonly JsonTokenizer nextTokenizer;

		private int nextTokenIndex;

		[NonSerialized]
		internal static GetString getString_1;

		internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer)
		{
			this.tokens = tokens;
			this.nextTokenizer = nextTokenizer;
		}

		protected override JsonToken NextImpl()
		{
			if (nextTokenIndex >= tokens.Count)
			{
				return nextTokenizer.Next();
			}
			return tokens[nextTokenIndex++];
		}

		static JsonReplayTokenizer()
		{
			Strings.CreateGetStringDelegate(typeof(JsonReplayTokenizer));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107399806), getString_1(107399801)).Replace(getString_1(107399764), getString_1(107399759)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107399754)))
			{
				throw new SecurityException(getString_1(107399729));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private new static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private sealed class JsonTextTokenizer : JsonTokenizer
	{
		private enum ContainerType
		{
			Document,
			Object,
			Array
		}

		[Flags]
		private enum State
		{
			StartOfDocument = 1,
			ExpectedEndOfDocument = 2,
			ReaderExhausted = 4,
			ObjectStart = 8,
			ObjectBeforeColon = 0x10,
			ObjectAfterColon = 0x20,
			ObjectAfterProperty = 0x40,
			ObjectAfterComma = 0x80,
			ArrayStart = 0x100,
			ArrayAfterValue = 0x200,
			ArrayAfterComma = 0x400
		}

		private sealed class PushBackReader
		{
			private readonly TextReader reader;

			private char? nextChar;

			[NonSerialized]
			internal static GetString getString_0;

			internal PushBackReader(TextReader reader)
			{
				this.reader = reader;
			}

			internal char? Read()
			{
				if (nextChar.HasValue)
				{
					char? result = nextChar;
					nextChar = null;
					return result;
				}
				int num = reader.Read();
				if (num != -1)
				{
					return (char)num;
				}
				return null;
			}

			internal char ReadOrFail(string messageOnFailure)
			{
				char? c = Read();
				if (!c.HasValue)
				{
					throw CreateException(messageOnFailure);
				}
				return c.Value;
			}

			internal void PushBack(char c)
			{
				if (nextChar.HasValue)
				{
					throw new InvalidOperationException(getString_0(107468505));
				}
				nextChar = c;
			}

			internal InvalidJsonException CreateException(string message)
			{
				return new InvalidJsonException(message);
			}

			static PushBackReader()
			{
				Strings.CreateGetStringDelegate(typeof(PushBackReader));
				bool bool_ = false;
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399830), getString_0(107399825)).Replace(getString_0(107399788), getString_0(107399783)));
				if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399778)))
				{
					throw new SecurityException(getString_0(107399753));
				}
			}

			[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
		}

		private static readonly State ValueStates;

		private readonly Stack<ContainerType> containerStack = new Stack<ContainerType>();

		private readonly PushBackReader reader;

		private State state;

		[NonSerialized]
		internal static GetString getString_1;

		internal JsonTextTokenizer(TextReader reader)
		{
			this.reader = new PushBackReader(reader);
			state = State.StartOfDocument;
			containerStack.Push(ContainerType.Document);
		}

		protected override JsonToken NextImpl()
		{
			if (state == State.ReaderExhausted)
			{
				throw new InvalidOperationException(getString_1(107470385));
			}
			while (true)
			{
				char? c = reader.Read();
				if (!c.HasValue)
				{
					break;
				}
				switch (c.Value)
				{
				case ',':
					ValidateState(State.ObjectAfterProperty | State.ArrayAfterValue, getString_1(107470782));
					state = ((state == State.ObjectAfterProperty) ? State.ObjectAfterComma : State.ArrayAfterComma);
					break;
				case ':':
					ValidateState(State.ObjectBeforeColon, getString_1(107470315));
					state = State.ObjectAfterColon;
					break;
				case '\t':
				case '\n':
				case '\r':
				case ' ':
					break;
				case '"':
				{
					string text = ReadString();
					if ((state & (State.ObjectStart | State.ObjectAfterComma)) != 0)
					{
						state = State.ObjectBeforeColon;
						return JsonToken.Name(text);
					}
					ValidateAndModifyStateForValue(getString_1(107470705));
					return JsonToken.Value(text);
				}
				case '-':
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
				{
					double value = ReadNumber(c.Value);
					ValidateAndModifyStateForValue(getString_1(107470257));
					return JsonToken.Value(value);
				}
				case ']':
					ValidateState(State.ArrayStart | State.ArrayAfterValue, getString_1(107469969));
					PopContainer();
					return JsonToken.EndArray;
				case '[':
					ValidateState(ValueStates, getString_1(107470546));
					state = State.ArrayStart;
					containerStack.Push(ContainerType.Array);
					return JsonToken.StartArray;
				case 'n':
					ConsumeLiteral(getString_1(107410792));
					ValidateAndModifyStateForValue(getString_1(107469904));
					return JsonToken.Null;
				case 'f':
					ConsumeLiteral(getString_1(107408038));
					ValidateAndModifyStateForValue(getString_1(107469830));
					return JsonToken.False;
				default:
					throw new InvalidJsonException(getString_1(107470204) + c.Value);
				case '}':
					ValidateState(State.ObjectStart | State.ObjectAfterProperty, getString_1(107470631));
					PopContainer();
					return JsonToken.EndObject;
				case '{':
					ValidateState(ValueStates, getString_1(107470652));
					state = State.ObjectStart;
					containerStack.Push(ContainerType.Object);
					return JsonToken.StartObject;
				case 't':
					ConsumeLiteral(getString_1(107411197));
					ValidateAndModifyStateForValue(getString_1(107469851));
					return JsonToken.True;
				}
			}
			ValidateState(State.ExpectedEndOfDocument, getString_1(107470368));
			state = State.ReaderExhausted;
			return JsonToken.EndDocument;
		}

		private void ValidateState(State validStates, string errorPrefix)
		{
			if ((validStates & state) == 0)
			{
				throw reader.CreateException(errorPrefix + state);
			}
		}

		private string ReadString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			while (true)
			{
				char c = reader.ReadOrFail(getString_1(107470187));
				if (c >= ' ')
				{
					if (c != '"')
					{
						if (c == '\\')
						{
							c = ReadEscapedCharacter();
						}
						if (flag == char.IsLowSurrogate(c))
						{
							flag = char.IsHighSurrogate(c);
							stringBuilder.Append(c);
							continue;
						}
						throw reader.CreateException(getString_1(107470033));
					}
					if (!flag)
					{
						break;
					}
					throw reader.CreateException(getString_1(107470033));
				}
				throw reader.CreateException(string.Format(CultureInfo.InvariantCulture, getString_1(107470094), new object[1] { (int)c }));
			}
			return stringBuilder.ToString();
		}

		private char ReadEscapedCharacter()
		{
			char c = reader.ReadOrFail(getString_1(107469464));
			return c switch
			{
				'\\' => '\\', 
				'/' => '/', 
				'"' => '"', 
				'f' => '\f', 
				'b' => '\b', 
				'r' => '\r', 
				't' => '\t', 
				'u' => ReadUnicodeEscape(), 
				'n' => '\n', 
				_ => throw reader.CreateException(string.Format(CultureInfo.InvariantCulture, getString_1(107469411), new object[1] { (int)c })), 
			};
		}

		private char ReadUnicodeEscape()
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				char c = reader.ReadOrFail(getString_1(107469302));
				int num2;
				if (c >= '0' && c <= '9')
				{
					num2 = c - 48;
				}
				else if (c >= 'a' && c <= 'f')
				{
					num2 = c - 97 + 10;
				}
				else
				{
					if (c < 'A' || c > 'F')
					{
						throw reader.CreateException(string.Format(CultureInfo.InvariantCulture, getString_1(107469411), new object[1] { (int)c }));
					}
					num2 = c - 65 + 10;
				}
				num = (num << 4) + num2;
			}
			return (char)num;
		}

		private void ConsumeLiteral(string text)
		{
			int num = 1;
			while (true)
			{
				if (num < text.Length)
				{
					char? c = reader.Read();
					if (c.HasValue)
					{
						if (c.Value != text[num])
						{
							break;
						}
						num++;
						continue;
					}
					throw reader.CreateException(getString_1(107469765) + text);
				}
				return;
			}
			throw reader.CreateException(getString_1(107469696) + text);
		}

		private double ReadNumber(char initialCharacter)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (initialCharacter == '-')
			{
				stringBuilder.Append(getString_1(107411079));
			}
			else
			{
				reader.PushBack(initialCharacter);
			}
			char? c = ReadInt(stringBuilder);
			if (c == '.')
			{
				c = ReadFrac(stringBuilder);
			}
			if (c == 'e' || c == 'E')
			{
				c = ReadExp(stringBuilder);
			}
			if (c.HasValue)
			{
				reader.PushBack(c.Value);
			}
			try
			{
				return double.Parse(stringBuilder.ToString(), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture);
			}
			catch (OverflowException)
			{
				throw reader.CreateException(getString_1(107469595) + stringBuilder);
			}
		}

		private char? ReadInt(StringBuilder builder)
		{
			char c = reader.ReadOrFail(getString_1(107469554));
			if (c >= '0' && c <= '9')
			{
				builder.Append(c);
				int count;
				char? result = ConsumeDigits(builder, out count);
				if (c == '0' && count != 0)
				{
					throw reader.CreateException(getString_1(107469521));
				}
				return result;
			}
			throw reader.CreateException(getString_1(107469554));
		}

		private char? ReadFrac(StringBuilder builder)
		{
			builder.Append('.');
			int count;
			char? result = ConsumeDigits(builder, out count);
			if (count == 0)
			{
				throw reader.CreateException(getString_1(107468968));
			}
			return result;
		}

		private char? ReadExp(StringBuilder builder)
		{
			builder.Append('E');
			char? c = reader.Read();
			if (!c.HasValue)
			{
				throw reader.CreateException(getString_1(107468859));
			}
			if (c != '-' && c != '+')
			{
				reader.PushBack(c.Value);
			}
			else
			{
				builder.Append(c.Value);
			}
			c = ConsumeDigits(builder, out var count);
			if (count == 0)
			{
				throw reader.CreateException(getString_1(107468782));
			}
			return c;
		}

		private char? ConsumeDigits(StringBuilder builder, out int count)
		{
			count = 0;
			char? result;
			while (true)
			{
				result = reader.Read();
				if (!result.HasValue || result.Value < '0' || result.Value > '9')
				{
					break;
				}
				count++;
				builder.Append(result.Value);
			}
			return result;
		}

		private void ValidateAndModifyStateForValue(string errorPrefix)
		{
			ValidateState(ValueStates, errorPrefix);
			switch (state)
			{
			case State.ObjectAfterColon:
				state = State.ObjectAfterProperty;
				break;
			case State.StartOfDocument:
				state = State.ExpectedEndOfDocument;
				break;
			default:
				throw new InvalidOperationException(getString_1(107469261));
			case State.ArrayStart:
			case State.ArrayAfterComma:
				state = State.ArrayAfterValue;
				break;
			}
		}

		private void PopContainer()
		{
			containerStack.Pop();
			ContainerType containerType = containerStack.Peek();
			switch (containerType)
			{
			default:
				throw new InvalidOperationException(getString_1(107469156) + containerType);
			case ContainerType.Document:
				state = State.ExpectedEndOfDocument;
				break;
			case ContainerType.Object:
				state = State.ObjectAfterProperty;
				break;
			case ContainerType.Array:
				state = State.ArrayAfterValue;
				break;
			}
		}

		static JsonTextTokenizer()
		{
			Strings.CreateGetStringDelegate(typeof(JsonTextTokenizer));
			ValueStates = State.StartOfDocument | State.ObjectAfterColon | State.ArrayStart | State.ArrayAfterComma;
		}
	}

	private JsonToken bufferedToken;

	[NonSerialized]
	internal static GetString getString_0;

	internal int ObjectDepth { get; private set; }

	internal static JsonTokenizer FromTextReader(TextReader reader)
	{
		return new JsonTextTokenizer(reader);
	}

	internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation)
	{
		return new JsonReplayTokenizer(tokens, continuation);
	}

	internal void PushBack(JsonToken token)
	{
		if (bufferedToken != null)
		{
			throw new InvalidOperationException(getString_0(107463067));
		}
		bufferedToken = token;
		if (token.Type == JsonToken.TokenType.StartObject)
		{
			ObjectDepth--;
		}
		else if (token.Type == JsonToken.TokenType.EndObject)
		{
			ObjectDepth++;
		}
	}

	internal JsonToken Next()
	{
		JsonToken jsonToken;
		if (bufferedToken != null)
		{
			jsonToken = bufferedToken;
			bufferedToken = null;
		}
		else
		{
			jsonToken = NextImpl();
		}
		if (jsonToken.Type == JsonToken.TokenType.StartObject)
		{
			ObjectDepth++;
		}
		else if (jsonToken.Type == JsonToken.TokenType.EndObject)
		{
			ObjectDepth--;
		}
		return jsonToken;
	}

	protected abstract JsonToken NextImpl();

	internal void SkipValue()
	{
		int num = 0;
		do
		{
			switch (Next().Type)
			{
			case JsonToken.TokenType.EndObject:
			case JsonToken.TokenType.EndArray:
				num--;
				break;
			case JsonToken.TokenType.StartObject:
			case JsonToken.TokenType.StartArray:
				num++;
				break;
			}
		}
		while (num != 0);
	}

	static JsonTokenizer()
	{
		Strings.CreateGetStringDelegate(typeof(JsonTokenizer));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399802), getString_0(107399797)).Replace(getString_0(107399760), getString_0(107399755)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399750)))
		{
			throw new SecurityException(getString_0(107399725));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
