using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

internal sealed class JsonToken : IEquatable<JsonToken>
{
	internal enum TokenType
	{
		Null,
		False,
		True,
		StringValue,
		Number,
		Name,
		StartObject,
		EndObject,
		StartArray,
		EndArray,
		EndDocument
	}

	private static readonly JsonToken _true;

	private static readonly JsonToken _false;

	private static readonly JsonToken _null;

	private static readonly JsonToken startObject;

	private static readonly JsonToken endObject;

	private static readonly JsonToken startArray;

	private static readonly JsonToken endArray;

	private static readonly JsonToken endDocument;

	private readonly TokenType type;

	private readonly string stringValue;

	private readonly double numberValue;

	[NonSerialized]
	internal static GetString getString_0;

	internal static JsonToken Null => _null;

	internal static JsonToken False => _false;

	internal static JsonToken True => _true;

	internal static JsonToken StartObject => startObject;

	internal static JsonToken EndObject => endObject;

	internal static JsonToken StartArray => startArray;

	internal static JsonToken EndArray => endArray;

	internal static JsonToken EndDocument => endDocument;

	internal TokenType Type => type;

	internal string StringValue => stringValue;

	internal double NumberValue => numberValue;

	internal static JsonToken Name(string name)
	{
		return new JsonToken(TokenType.Name, name);
	}

	internal static JsonToken Value(string value)
	{
		return new JsonToken(TokenType.StringValue, value);
	}

	internal static JsonToken Value(double value)
	{
		return new JsonToken(TokenType.Number, null, value);
	}

	private JsonToken(TokenType type, string stringValue = null, double numberValue = 0.0)
	{
		this.type = type;
		this.stringValue = stringValue;
		this.numberValue = numberValue;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as JsonToken);
	}

	public override int GetHashCode()
	{
		int num = (((int)(527 + type) * 31 + stringValue != null) ? stringValue.GetHashCode() : 0) * 31;
		double num2 = numberValue;
		return num + num2.GetHashCode();
	}

	public override string ToString()
	{
		return type switch
		{
			TokenType.Null => getString_0(107410768), 
			TokenType.False => getString_0(107408014), 
			TokenType.True => getString_0(107411173), 
			TokenType.StringValue => getString_0(107462652) + stringValue + getString_0(107411159), 
			TokenType.Number => getString_0(107462671) + numberValue + getString_0(107411159), 
			TokenType.Name => getString_0(107462661) + stringValue + getString_0(107411159), 
			TokenType.StartObject => getString_0(107462626), 
			TokenType.EndObject => getString_0(107462641), 
			TokenType.StartArray => getString_0(107462592), 
			TokenType.EndArray => getString_0(107462607), 
			TokenType.EndDocument => getString_0(107463074), 
			_ => throw new InvalidOperationException(getString_0(107463089) + type), 
		};
	}

	public bool Equals(JsonToken other)
	{
		if (other == null)
		{
			return false;
		}
		if (other.type == type && other.stringValue == stringValue)
		{
			double num = other.numberValue;
			return num.Equals(numberValue);
		}
		return false;
	}

	static JsonToken()
	{
		Strings.CreateGetStringDelegate(typeof(JsonToken));
		_true = new JsonToken(TokenType.True);
		_false = new JsonToken(TokenType.False);
		_null = new JsonToken(TokenType.Null);
		startObject = new JsonToken(TokenType.StartObject);
		endObject = new JsonToken(TokenType.EndObject);
		startArray = new JsonToken(TokenType.StartArray);
		endArray = new JsonToken(TokenType.EndArray);
		endDocument = new JsonToken(TokenType.EndDocument);
	}
}
