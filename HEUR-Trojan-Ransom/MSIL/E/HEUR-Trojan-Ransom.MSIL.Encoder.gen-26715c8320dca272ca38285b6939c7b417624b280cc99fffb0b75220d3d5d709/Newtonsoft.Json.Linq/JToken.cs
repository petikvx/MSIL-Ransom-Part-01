using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq;

public abstract class JToken : IEnumerable, ICloneable, IEnumerable<JToken>, IJEnumerable<JToken>, IDynamicMetaObjectProvider, IJsonLineInfo
{
	private class LineInfoAnnotation
	{
		internal readonly int LineNumber;

		internal readonly int LinePosition;

		public LineInfoAnnotation(int lineNumber, int linePosition)
		{
			LineNumber = lineNumber;
			LinePosition = linePosition;
		}
	}

	private static JTokenEqualityComparer? _equalityComparer;

	private JContainer? _parent;

	private JToken? _previous;

	private JToken? _next;

	private object? _annotations;

	private static readonly JTokenType[] BooleanTypes = new JTokenType[6]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean
	};

	private static readonly JTokenType[] NumberTypes = new JTokenType[6]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean
	};

	private static readonly JTokenType[] BigIntegerTypes = new JTokenType[7]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean,
		JTokenType.Bytes
	};

	private static readonly JTokenType[] StringTypes = new JTokenType[11]
	{
		JTokenType.Date,
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean,
		JTokenType.Bytes,
		JTokenType.Guid,
		JTokenType.TimeSpan,
		JTokenType.Uri
	};

	private static readonly JTokenType[] GuidTypes = new JTokenType[5]
	{
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Guid,
		JTokenType.Bytes
	};

	private static readonly JTokenType[] TimeSpanTypes = new JTokenType[4]
	{
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.TimeSpan
	};

	private static readonly JTokenType[] UriTypes = new JTokenType[4]
	{
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Uri
	};

	private static readonly JTokenType[] CharTypes = new JTokenType[5]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw
	};

	private static readonly JTokenType[] DateTimeTypes = new JTokenType[4]
	{
		JTokenType.Date,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw
	};

	private static readonly JTokenType[] BytesTypes = new JTokenType[5]
	{
		JTokenType.Bytes,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Integer
	};

	public static JTokenEqualityComparer EqualityComparer
	{
		get
		{
			if (_equalityComparer == null)
			{
				_equalityComparer = new JTokenEqualityComparer();
			}
			return _equalityComparer;
		}
	}

	public JContainer? Parent
	{
		[DebuggerStepThrough]
		get
		{
			return _parent;
		}
		internal set
		{
			_parent = value;
		}
	}

	public JToken Root
	{
		get
		{
			JContainer parent = Parent;
			if (parent == null)
			{
				return this;
			}
			while (parent.Parent != null)
			{
				parent = parent.Parent;
			}
			return parent;
		}
	}

	public abstract JTokenType Type { get; }

	public abstract bool HasValues { get; }

	public JToken? Next
	{
		get
		{
			return _next;
		}
		internal set
		{
			_next = value;
		}
	}

	public JToken? Previous
	{
		get
		{
			return _previous;
		}
		internal set
		{
			_previous = value;
		}
	}

	public string Path
	{
		get
		{
			if (Parent == null)
			{
				return string.Empty;
			}
			List<JsonPosition> list = new List<JsonPosition>();
			JToken jToken = null;
			for (JToken jToken2 = this; jToken2 != null; jToken2 = jToken2.Parent)
			{
				switch (jToken2.Type)
				{
				case JTokenType.Property:
				{
					JProperty jProperty = (JProperty)jToken2;
					list.Add(new JsonPosition(JsonContainerType.Object)
					{
						PropertyName = jProperty.Name
					});
					break;
				}
				case JTokenType.Array:
				case JTokenType.Constructor:
					if (jToken != null)
					{
						int position = ((IList<JToken>)jToken2).IndexOf(jToken);
						list.Add(new JsonPosition(JsonContainerType.Array)
						{
							Position = position
						});
					}
					break;
				}
				jToken = jToken2;
			}
			list.FastReverse();
			return JsonPosition.BuildPath(list, null);
		}
	}

	public virtual JToken? this[object key]
	{
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, GetType()));
		}
		set
		{
			throw new InvalidOperationException("Cannot set child value on {0}.".FormatWith(CultureInfo.InvariantCulture, GetType()));
		}
	}

	public virtual JToken? First
	{
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, GetType()));
		}
	}

	public virtual JToken? Last
	{
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, GetType()));
		}
	}

	IJEnumerable<JToken> IJEnumerable<JToken>.this[object key] => this[key];

	int IJsonLineInfo.LineNumber => Annotation<LineInfoAnnotation>()?.LineNumber ?? 0;

	int IJsonLineInfo.LinePosition => Annotation<LineInfoAnnotation>()?.LinePosition ?? 0;

	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
	{
		throw new NotImplementedException();
	}

	public Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters)
	{
		return WriteToAsync(writer, default(CancellationToken), converters);
	}

	public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ReadFromAsync(reader, null, cancellationToken);
	}

	public static async Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		ValidationUtils.ArgumentNotNull(reader, "reader");
		if (reader.TokenType == JsonToken.None && !(await ((settings == null || settings!.CommentHandling != 0) ? reader.ReadAsync(cancellationToken) : reader.ReadAndMoveToContentAsync(cancellationToken)).ConfigureAwait(continueOnCapturedContext: false)))
		{
			throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader.");
		}
		IJsonLineInfo lineInfo = reader as IJsonLineInfo;
		switch (reader.TokenType)
		{
		case JsonToken.Comment:
		{
			JValue jValue4 = JValue.CreateComment(reader.Value?.ToString());
			jValue4.SetLineInfo(lineInfo, settings);
			return jValue4;
		}
		case JsonToken.Null:
		{
			JValue jValue3 = JValue.CreateNull();
			jValue3.SetLineInfo(lineInfo, settings);
			return jValue3;
		}
		case JsonToken.Undefined:
		{
			JValue jValue2 = JValue.CreateUndefined();
			jValue2.SetLineInfo(lineInfo, settings);
			return jValue2;
		}
		default:
			throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader. Unexpected token: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Date:
		case JsonToken.Bytes:
		{
			JValue jValue = new JValue(reader.Value);
			jValue.SetLineInfo(lineInfo, settings);
			return jValue;
		}
		case JsonToken.StartObject:
			return await JObject.LoadAsync(reader, settings, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		case JsonToken.StartArray:
			return await JArray.LoadAsync(reader, settings, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		case JsonToken.StartConstructor:
			return await JConstructor.LoadAsync(reader, settings, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		case JsonToken.PropertyName:
			return await JProperty.LoadAsync(reader, settings, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(reader, null, cancellationToken);
	}

	public static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ReadFromAsync(reader, settings, cancellationToken);
	}

	internal abstract JToken CloneToken();

	internal abstract bool DeepEquals(JToken node);

	public static bool DeepEquals(JToken? t1, JToken? t2)
	{
		if (t1 != t2)
		{
			if (t1 != null && t2 != null)
			{
				return t1!.DeepEquals(t2);
			}
			return false;
		}
		return true;
	}

	internal JToken()
	{
	}

	public void AddAfterSelf(object? content)
	{
		if (_parent == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		int num = _parent!.IndexOfItem(this);
		_parent!.AddInternal(num + 1, content, skipParentCheck: false);
	}

	public void AddBeforeSelf(object? content)
	{
		if (_parent == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		int index = _parent!.IndexOfItem(this);
		_parent!.AddInternal(index, content, skipParentCheck: false);
	}

	public IEnumerable<JToken> Ancestors()
	{
		return GetAncestors(self: false);
	}

	public IEnumerable<JToken> AncestorsAndSelf()
	{
		return GetAncestors(self: true);
	}

	internal IEnumerable<JToken> GetAncestors(bool self)
	{
		for (JToken current = (self ? this : Parent); current != null; current = current.Parent)
		{
			yield return current;
		}
	}

	public IEnumerable<JToken> AfterSelf()
	{
		if (Parent != null)
		{
			for (JToken o = Next; o != null; o = o.Next)
			{
				yield return o;
			}
		}
	}

	public IEnumerable<JToken> BeforeSelf()
	{
		if (Parent != null)
		{
			JToken o = Parent!.First;
			while (o != this && o != null)
			{
				yield return o;
				o = o.Next;
			}
		}
	}

	public virtual T Value<T>(object key) where T : notnull
	{
		JToken jToken = this[key];
		if (jToken != null)
		{
			return jToken.Convert<JToken, T>();
		}
		return default(T);
	}

	public virtual JEnumerable<JToken> Children()
	{
		return JEnumerable<JToken>.Empty;
	}

	public JEnumerable<T> Children<T>() where T : JToken
	{
		return new JEnumerable<T>(Children().OfType<T>());
	}

	public virtual IEnumerable<T> Values<T>() where T : notnull
	{
		throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, GetType()));
	}

	public void Remove()
	{
		if (_parent == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		_parent!.RemoveItem(this);
	}

	public void Replace(JToken value)
	{
		if (_parent == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		_parent!.ReplaceItem(this, value);
	}

	public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

	public override string ToString()
	{
		return ToString(Formatting.Indented);
	}

	public string ToString(Formatting formatting, params JsonConverter[] converters)
	{
		using StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
		jsonTextWriter.Formatting = formatting;
		WriteTo(jsonTextWriter, converters);
		return stringWriter.ToString();
	}

	private static JValue? EnsureValue(JToken value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (value is JProperty jProperty)
		{
			value = jProperty.Value;
		}
		return value as JValue;
	}

	private static string GetType(JToken token)
	{
		ValidationUtils.ArgumentNotNull(token, "token");
		if (token is JProperty jProperty)
		{
			token = jProperty.Value;
		}
		return token.Type.ToString();
	}

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
	{
		if (Array.IndexOf(validTypes, o.Type) == -1)
		{
			if (nullable)
			{
				if (o.Type != JTokenType.Null)
				{
					return o.Type == JTokenType.Undefined;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static explicit operator bool(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, BooleanTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return Convert.ToBoolean((int)bigInteger);
			}
			return Convert.ToBoolean(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator DateTimeOffset(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, DateTimeTypes, nullable: false))
		{
			object value2 = jValue.Value;
			if (value2 is DateTimeOffset)
			{
				return (DateTimeOffset)value2;
			}
			if (jValue.Value is string input)
			{
				return DateTimeOffset.Parse(input, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator bool?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, BooleanTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return Convert.ToBoolean((int)bigInteger);
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToBoolean(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator long(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (long)bigInteger;
			}
			return Convert.ToInt64(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator DateTime?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, DateTimeTypes, nullable: true))
		{
			if (jValue.Value is DateTimeOffset dateTimeOffset)
			{
				return dateTimeOffset.DateTime;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator DateTimeOffset?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, DateTimeTypes, nullable: true))
		{
			if (jValue.Value == null)
			{
				return null;
			}
			object value2 = jValue.Value;
			if (value2 is DateTimeOffset)
			{
				return (DateTimeOffset)value2;
			}
			if (jValue.Value is string input)
			{
				return DateTimeOffset.Parse(input, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator decimal?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (decimal)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToDecimal(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator double?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (double)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToDouble(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator char?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, CharTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (char)(ushort)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToChar(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Char.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator int(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (int)bigInteger;
			}
			return Convert.ToInt32(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator short(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (short)bigInteger;
			}
			return Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator ushort(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (ushort)bigInteger;
			}
			return Convert.ToUInt16(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator char(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, CharTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (char)(ushort)bigInteger;
			}
			return Convert.ToChar(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Char.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator byte(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (byte)bigInteger;
			}
			return Convert.ToByte(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Byte.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator sbyte(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (sbyte)bigInteger;
			}
			return Convert.ToSByte(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to SByte.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator int?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (int)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToInt32(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator short?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (short)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator ushort?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (ushort)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToUInt16(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator byte?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (byte)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToByte(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Byte.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator sbyte?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (sbyte)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToSByte(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to SByte.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator DateTime(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, DateTimeTypes, nullable: false))
		{
			if (jValue.Value is DateTimeOffset dateTimeOffset)
			{
				return dateTimeOffset.DateTime;
			}
			return Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator long?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (long)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToInt64(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator float?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (float)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToSingle(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator decimal(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (decimal)bigInteger;
			}
			return Convert.ToDecimal(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator uint?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (uint)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToUInt32(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator ulong?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: true))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (ulong)bigInteger;
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToUInt64(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator double(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (double)bigInteger;
			}
			return Convert.ToDouble(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator float(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (float)bigInteger;
			}
			return Convert.ToSingle(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator string?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, StringTypes, nullable: true))
		{
			if (jValue.Value == null)
			{
				return null;
			}
			if (jValue.Value is byte[] inArray)
			{
				return Convert.ToBase64String(inArray);
			}
			if (jValue.Value is BigInteger bigInteger)
			{
				return bigInteger.ToString(CultureInfo.InvariantCulture);
			}
			return Convert.ToString(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to String.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator uint(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (uint)bigInteger;
			}
			return Convert.ToUInt32(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	[CLSCompliant(false)]
	public static explicit operator ulong(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, NumberTypes, nullable: false))
		{
			if (jValue.Value is BigInteger bigInteger)
			{
				return (ulong)bigInteger;
			}
			return Convert.ToUInt64(jValue.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator byte[]?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, BytesTypes, nullable: false))
		{
			if (jValue.Value is string)
			{
				return Convert.FromBase64String(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
			}
			if (jValue.Value is BigInteger bigInteger)
			{
				return bigInteger.ToByteArray();
			}
			if (!(jValue.Value is byte[] result))
			{
				throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
			}
			return result;
		}
		throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator Guid(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, GuidTypes, nullable: false))
		{
			if (jValue.Value is byte[] b)
			{
				return new Guid(b);
			}
			object value2 = jValue.Value;
			if (value2 is Guid)
			{
				return (Guid)value2;
			}
			return new Guid(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to Guid.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator Guid?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, GuidTypes, nullable: true))
		{
			if (jValue.Value == null)
			{
				return null;
			}
			if (jValue.Value is byte[] b)
			{
				return new Guid(b);
			}
			return (!(jValue.Value is Guid guid)) ? new Guid(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture)) : guid;
		}
		throw new ArgumentException("Can not convert {0} to Guid.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator TimeSpan(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, TimeSpanTypes, nullable: false))
		{
			object value2 = jValue.Value;
			if (value2 is TimeSpan)
			{
				return (TimeSpan)value2;
			}
			return ConvertUtils.ParseTimeSpan(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator TimeSpan?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, TimeSpanTypes, nullable: true))
		{
			if (jValue.Value == null)
			{
				return null;
			}
			return (!(jValue.Value is TimeSpan timeSpan)) ? ConvertUtils.ParseTimeSpan(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture)) : timeSpan;
		}
		throw new ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static explicit operator Uri?(JToken? value)
	{
		if (value == null)
		{
			return null;
		}
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, UriTypes, nullable: true))
		{
			if (jValue.Value == null)
			{
				return null;
			}
			if (!(jValue.Value is Uri result))
			{
				return new Uri(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
			}
			return result;
		}
		throw new ArgumentException("Can not convert {0} to Uri.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	private static BigInteger ToBigInteger(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue == null || !ValidateToken(jValue, BigIntegerTypes, nullable: false))
		{
			throw new ArgumentException("Can not convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
		}
		return ConvertUtils.ToBigInteger(jValue.Value);
	}

	private static BigInteger? ToBigIntegerNullable(JToken value)
	{
		JValue jValue = EnsureValue(value);
		if (jValue != null && ValidateToken(jValue, BigIntegerTypes, nullable: true))
		{
			if (jValue.Value == null)
			{
				return null;
			}
			return ConvertUtils.ToBigInteger(jValue.Value);
		}
		throw new ArgumentException("Can not convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, GetType(value)));
	}

	public static implicit operator JToken(bool value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(DateTimeOffset value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(byte value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(byte? value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(sbyte value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(sbyte? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(bool? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(long value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(DateTime? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(DateTimeOffset? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(decimal? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(double? value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(short value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ushort value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(int value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(int? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(DateTime value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(long? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(float? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(decimal value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(short? value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ushort? value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(uint? value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ulong? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(double value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(float value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(string? value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(uint value)
	{
		return new JValue(value);
	}

	[CLSCompliant(false)]
	public static implicit operator JToken(ulong value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(byte[] value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(Uri? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(TimeSpan value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(TimeSpan? value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(Guid value)
	{
		return new JValue(value);
	}

	public static implicit operator JToken(Guid? value)
	{
		return new JValue(value);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<JToken>)this).GetEnumerator();
	}

	IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
	{
		return Children().GetEnumerator();
	}

	internal abstract int GetDeepHashCode();

	public JsonReader CreateReader()
	{
		return new JTokenReader(this);
	}

	internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
	{
		ValidationUtils.ArgumentNotNull(o, "o");
		ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
		using JTokenWriter jTokenWriter = new JTokenWriter();
		jsonSerializer.Serialize(jTokenWriter, o);
		return jTokenWriter.Token;
	}

	public static JToken FromObject(object o)
	{
		return FromObjectInternal(o, JsonSerializer.CreateDefault());
	}

	public static JToken FromObject(object o, JsonSerializer jsonSerializer)
	{
		return FromObjectInternal(o, jsonSerializer);
	}

	[return: MaybeNull]
	public T ToObject<T>() where T : notnull
	{
		return (T)ToObject(typeof(T));
	}

	public object? ToObject(Type objectType)
	{
		if (JsonConvert.DefaultSettings == null)
		{
			bool isEnum;
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(objectType, out isEnum);
			if (isEnum)
			{
				if (Type == JTokenType.String)
				{
					try
					{
						return ToObject(objectType, JsonSerializer.CreateDefault());
					}
					catch (Exception innerException)
					{
						Type type = (objectType.IsEnum() ? objectType : Nullable.GetUnderlyingType(objectType));
						throw new ArgumentException("Could not convert '{0}' to {1}.".FormatWith(CultureInfo.InvariantCulture, (string?)this, type.Name), innerException);
					}
				}
				if (Type == JTokenType.Integer)
				{
					return Enum.ToObject(objectType.IsEnum() ? objectType : Nullable.GetUnderlyingType(objectType), ((JValue)this).Value);
				}
			}
			switch (typeCode)
			{
			case PrimitiveTypeCode.Char:
				return (char)this;
			case PrimitiveTypeCode.CharNullable:
				return (char?)this;
			case PrimitiveTypeCode.Boolean:
				return (bool)this;
			case PrimitiveTypeCode.BooleanNullable:
				return (bool?)this;
			case PrimitiveTypeCode.SByte:
				return (sbyte)this;
			case PrimitiveTypeCode.SByteNullable:
				return (sbyte?)this;
			case PrimitiveTypeCode.Int16:
				return (short)this;
			case PrimitiveTypeCode.Int16Nullable:
				return (short?)this;
			case PrimitiveTypeCode.UInt16:
				return (ushort)this;
			case PrimitiveTypeCode.UInt16Nullable:
				return (ushort?)this;
			case PrimitiveTypeCode.Int32:
				return (int)this;
			case PrimitiveTypeCode.Int32Nullable:
				return (int?)this;
			case PrimitiveTypeCode.Byte:
				return (byte)this;
			case PrimitiveTypeCode.ByteNullable:
				return (byte?)this;
			case PrimitiveTypeCode.UInt32:
				return (uint)this;
			case PrimitiveTypeCode.UInt32Nullable:
				return (uint?)this;
			case PrimitiveTypeCode.Int64:
				return (long)this;
			case PrimitiveTypeCode.Int64Nullable:
				return (long?)this;
			case PrimitiveTypeCode.UInt64:
				return (ulong)this;
			case PrimitiveTypeCode.UInt64Nullable:
				return (ulong?)this;
			case PrimitiveTypeCode.Single:
				return (float)this;
			case PrimitiveTypeCode.SingleNullable:
				return (float?)this;
			case PrimitiveTypeCode.Double:
				return (double)this;
			case PrimitiveTypeCode.DoubleNullable:
				return (double?)this;
			case PrimitiveTypeCode.DateTime:
				return (DateTime)this;
			case PrimitiveTypeCode.DateTimeNullable:
				return (DateTime?)this;
			case PrimitiveTypeCode.DateTimeOffset:
				return (DateTimeOffset)this;
			case PrimitiveTypeCode.DateTimeOffsetNullable:
				return (DateTimeOffset?)this;
			case PrimitiveTypeCode.Decimal:
				return (decimal)this;
			case PrimitiveTypeCode.DecimalNullable:
				return (decimal?)this;
			case PrimitiveTypeCode.Guid:
				return (Guid)this;
			case PrimitiveTypeCode.GuidNullable:
				return (Guid?)this;
			case PrimitiveTypeCode.TimeSpan:
				return (TimeSpan)this;
			case PrimitiveTypeCode.TimeSpanNullable:
				return (TimeSpan?)this;
			case PrimitiveTypeCode.BigInteger:
				return ToBigInteger(this);
			case PrimitiveTypeCode.BigIntegerNullable:
				return ToBigIntegerNullable(this);
			case PrimitiveTypeCode.Uri:
				return (Uri?)this;
			case PrimitiveTypeCode.String:
				return (string?)this;
			}
		}
		return ToObject(objectType, JsonSerializer.CreateDefault());
	}

	[return: MaybeNull]
	public T ToObject<T>(JsonSerializer jsonSerializer) where T : notnull
	{
		return (T)ToObject(typeof(T), jsonSerializer);
	}

	public object? ToObject(Type objectType, JsonSerializer jsonSerializer)
	{
		ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
		using JTokenReader reader = new JTokenReader(this);
		return jsonSerializer.Deserialize(reader, objectType);
	}

	public static JToken ReadFrom(JsonReader reader)
	{
		return ReadFrom(reader, null);
	}

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings? settings)
	{
		ValidationUtils.ArgumentNotNull(reader, "reader");
		if (!((reader.TokenType == JsonToken.None) ? ((settings == null || settings!.CommentHandling != 0) ? reader.Read() : reader.ReadAndMoveToContent()) : (reader.TokenType != JsonToken.Comment || settings == null || settings!.CommentHandling != 0 || reader.ReadAndMoveToContent())))
		{
			throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader.");
		}
		IJsonLineInfo lineInfo = reader as IJsonLineInfo;
		switch (reader.TokenType)
		{
		case JsonToken.StartObject:
			return JObject.Load(reader, settings);
		case JsonToken.StartArray:
			return JArray.Load(reader, settings);
		case JsonToken.StartConstructor:
			return JConstructor.Load(reader, settings);
		case JsonToken.PropertyName:
			return JProperty.Load(reader, settings);
		case JsonToken.Comment:
		{
			JValue jValue4 = JValue.CreateComment(reader.Value!.ToString());
			jValue4.SetLineInfo(lineInfo, settings);
			return jValue4;
		}
		case JsonToken.Null:
		{
			JValue jValue3 = JValue.CreateNull();
			jValue3.SetLineInfo(lineInfo, settings);
			return jValue3;
		}
		case JsonToken.Undefined:
		{
			JValue jValue2 = JValue.CreateUndefined();
			jValue2.SetLineInfo(lineInfo, settings);
			return jValue2;
		}
		default:
			throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader. Unexpected token: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Date:
		case JsonToken.Bytes:
		{
			JValue jValue = new JValue(reader.Value);
			jValue.SetLineInfo(lineInfo, settings);
			return jValue;
		}
		}
	}

	public static JToken Parse(string json)
	{
		return Parse(json, null);
	}

	public static JToken Parse(string json, JsonLoadSettings? settings)
	{
		using JsonReader jsonReader = new JsonTextReader(new StringReader(json));
		JToken result = Load(jsonReader, settings);
		while (jsonReader.Read())
		{
		}
		return result;
	}

	public static JToken Load(JsonReader reader, JsonLoadSettings? settings)
	{
		return ReadFrom(reader, settings);
	}

	public static JToken Load(JsonReader reader)
	{
		return Load(reader, null);
	}

	internal void SetLineInfo(IJsonLineInfo? lineInfo, JsonLoadSettings? settings)
	{
		if ((settings == null || settings!.LineInfoHandling == LineInfoHandling.Load) && lineInfo != null && lineInfo!.HasLineInfo())
		{
			SetLineInfo(lineInfo!.LineNumber, lineInfo!.LinePosition);
		}
	}

	internal void SetLineInfo(int lineNumber, int linePosition)
	{
		AddAnnotation(new LineInfoAnnotation(lineNumber, linePosition));
	}

	bool IJsonLineInfo.HasLineInfo()
	{
		return Annotation<LineInfoAnnotation>() != null;
	}

	public JToken? SelectToken(string path)
	{
		return SelectToken(path, errorWhenNoMatch: false);
	}

	public JToken? SelectToken(string path, bool errorWhenNoMatch)
	{
		JPath jPath = new JPath(path);
		JToken jToken = null;
		foreach (JToken item in jPath.Evaluate(this, this, errorWhenNoMatch))
		{
			if (jToken == null)
			{
				jToken = item;
				continue;
			}
			throw new JsonException("Path returned multiple tokens.");
		}
		return jToken;
	}

	public IEnumerable<JToken> SelectTokens(string path)
	{
		return SelectTokens(path, errorWhenNoMatch: false);
	}

	public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
	{
		return new JPath(path).Evaluate(this, this, errorWhenNoMatch);
	}

	protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
	{
		return new DynamicProxyMetaObject<JToken>(parameter, this, new DynamicProxy<JToken>());
	}

	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return GetMetaObject(parameter);
	}

	object ICloneable.Clone()
	{
		return DeepClone();
	}

	public JToken DeepClone()
	{
		return CloneToken();
	}

	public void AddAnnotation(object annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (_annotations == null)
		{
			_annotations = ((!(annotation is object[])) ? annotation : new object[1] { annotation });
			return;
		}
		object[] array = _annotations as object[];
		if (array == null)
		{
			_annotations = new object[2] { _annotations, annotation };
			return;
		}
		int i;
		for (i = 0; i < array.Length && array[i] != null; i++)
		{
		}
		if (i == array.Length)
		{
			Array.Resize(ref array, i * 2);
			_annotations = array;
		}
		array[i] = annotation;
	}

	public T? Annotation<T>() where T : class
	{
		if (_annotations != null)
		{
			if (!(_annotations is object[] array))
			{
				return _annotations as T;
			}
			foreach (object obj in array)
			{
				if (obj == null)
				{
					break;
				}
				if (obj is T result)
				{
					return result;
				}
			}
		}
		return null;
	}

	public object? Annotation(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (_annotations != null)
		{
			if (!(_annotations is object[] array))
			{
				if (type.IsInstanceOfType(_annotations))
				{
					return _annotations;
				}
			}
			else
			{
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					if (type.IsInstanceOfType(obj))
					{
						return obj;
					}
				}
			}
		}
		return null;
	}

	public IEnumerable<T> Annotations<T>() where T : class
	{
		if (_annotations == null)
		{
			yield break;
		}
		object annotations2 = _annotations;
		object[] annotations = annotations2 as object[];
		if (annotations != null)
		{
			foreach (object obj in annotations)
			{
				if (obj != null)
				{
					if (obj is T val)
					{
						yield return val;
					}
					continue;
				}
				break;
			}
		}
		else if (_annotations is T val2)
		{
			yield return val2;
		}
	}

	public IEnumerable<object> Annotations(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (_annotations == null)
		{
			yield break;
		}
		object annotations2 = _annotations;
		object[] annotations = annotations2 as object[];
		if (annotations != null)
		{
			foreach (object obj in annotations)
			{
				if (obj != null)
				{
					if (type.IsInstanceOfType(obj))
					{
						yield return obj;
					}
					continue;
				}
				break;
			}
		}
		else if (type.IsInstanceOfType(_annotations))
		{
			yield return _annotations;
		}
	}

	public void RemoveAnnotations<T>() where T : class
	{
		if (_annotations == null)
		{
			return;
		}
		if (!(_annotations is object[] array))
		{
			if (_annotations is T)
			{
				_annotations = null;
			}
			return;
		}
		int i = 0;
		int num = 0;
		for (; i < array.Length; i++)
		{
			object obj = array[i];
			if (obj == null)
			{
				break;
			}
			if (!(obj is T))
			{
				array[num++] = obj;
			}
		}
		if (num != 0)
		{
			while (num < i)
			{
				array[num++] = null;
			}
		}
		else
		{
			_annotations = null;
		}
	}

	public void RemoveAnnotations(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (_annotations == null)
		{
			return;
		}
		if (!(_annotations is object[] array))
		{
			if (type.IsInstanceOfType(_annotations))
			{
				_annotations = null;
			}
			return;
		}
		int i = 0;
		int num = 0;
		for (; i < array.Length; i++)
		{
			object obj = array[i];
			if (obj == null)
			{
				break;
			}
			if (!type.IsInstanceOfType(obj))
			{
				array[num++] = obj;
			}
		}
		if (num != 0)
		{
			while (num < i)
			{
				array[num++] = null;
			}
		}
		else
		{
			_annotations = null;
		}
	}
}
