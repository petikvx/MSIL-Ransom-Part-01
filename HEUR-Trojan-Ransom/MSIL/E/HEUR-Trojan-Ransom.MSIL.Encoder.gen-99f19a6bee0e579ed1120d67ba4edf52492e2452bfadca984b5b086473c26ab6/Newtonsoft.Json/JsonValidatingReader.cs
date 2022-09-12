using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonValidatingReader : JsonReader, IJsonLineInfo
{
	private class SchemaScope
	{
		private readonly JTokenType _tokenType;

		private readonly IList<JsonSchemaModel> _schemas;

		private readonly Dictionary<string, bool> _requiredProperties;

		public string CurrentPropertyName { get; set; }

		public int ArrayItemCount { get; set; }

		public bool IsUniqueArray { get; }

		public IList<JToken> UniqueArrayItems { get; }

		public JTokenWriter CurrentItemWriter { get; set; }

		public IList<JsonSchemaModel> Schemas => _schemas;

		public Dictionary<string, bool> RequiredProperties => _requiredProperties;

		public JTokenType TokenType => _tokenType;

		public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
		{
			_tokenType = tokenType;
			_schemas = schemas;
			_requiredProperties = schemas.SelectMany(GetRequiredProperties).Distinct().ToDictionary((string p) => p, (string p) => false);
			if (tokenType == JTokenType.Array && schemas.Any((JsonSchemaModel s) => s.UniqueItems))
			{
				IsUniqueArray = true;
				UniqueArrayItems = new List<JToken>();
			}
		}

		private IEnumerable<string> GetRequiredProperties(JsonSchemaModel schema)
		{
			if (schema?.Properties == null)
			{
				return Enumerable.Empty<string>();
			}
			return from p in schema.Properties
				where p.Value.Required
				select p.Key;
		}
	}

	private readonly JsonReader _reader;

	private readonly Stack<SchemaScope> _stack;

	private JsonSchema _schema;

	private JsonSchemaModel _model;

	private SchemaScope _currentScope;

	private static readonly IList<JsonSchemaModel> EmptySchemaList = new List<JsonSchemaModel>();

	public override object Value => _reader.Value;

	public override int Depth => _reader.Depth;

	public override string Path => _reader.Path;

	public override char QuoteChar
	{
		get
		{
			return _reader.QuoteChar;
		}
		protected internal set
		{
		}
	}

	public override JsonToken TokenType => _reader.TokenType;

	public override Type ValueType => _reader.ValueType;

	private IList<JsonSchemaModel> CurrentSchemas => _currentScope.Schemas;

	private IList<JsonSchemaModel> CurrentMemberSchemas
	{
		get
		{
			if (_currentScope == null)
			{
				return new List<JsonSchemaModel>(new JsonSchemaModel[1] { _model });
			}
			if (_currentScope.Schemas != null && _currentScope.Schemas.Count != 0)
			{
				switch (_currentScope.TokenType)
				{
				default:
					throw new ArgumentOutOfRangeException("TokenType", "Unexpected token type: {0}".FormatWith(CultureInfo.InvariantCulture, _currentScope.TokenType));
				case JTokenType.None:
					return _currentScope.Schemas;
				case JTokenType.Object:
				{
					if (_currentScope.CurrentPropertyName == null)
					{
						throw new JsonReaderException("CurrentPropertyName has not been set on scope.");
					}
					IList<JsonSchemaModel> list2 = new List<JsonSchemaModel>();
					{
						foreach (JsonSchemaModel currentSchema in CurrentSchemas)
						{
							if (currentSchema.Properties != null && currentSchema.Properties.TryGetValue(_currentScope.CurrentPropertyName, out var value))
							{
								list2.Add(value);
							}
							if (currentSchema.PatternProperties != null)
							{
								foreach (KeyValuePair<string, JsonSchemaModel> patternProperty in currentSchema.PatternProperties)
								{
									if (Regex.IsMatch(_currentScope.CurrentPropertyName, patternProperty.Key))
									{
										list2.Add(patternProperty.Value);
									}
								}
							}
							if (list2.Count == 0 && currentSchema.AllowAdditionalProperties && currentSchema.AdditionalProperties != null)
							{
								list2.Add(currentSchema.AdditionalProperties);
							}
						}
						return list2;
					}
				}
				case JTokenType.Array:
				{
					IList<JsonSchemaModel> list = new List<JsonSchemaModel>();
					{
						foreach (JsonSchemaModel currentSchema2 in CurrentSchemas)
						{
							if (!currentSchema2.PositionalItemsValidation)
							{
								if (currentSchema2.Items != null && currentSchema2.Items.Count > 0)
								{
									list.Add(currentSchema2.Items[0]);
								}
							}
							else
							{
								if (currentSchema2.Items != null && currentSchema2.Items.Count > 0 && currentSchema2.Items.Count > _currentScope.ArrayItemCount - 1)
								{
									list.Add(currentSchema2.Items[_currentScope.ArrayItemCount - 1]);
								}
								if (currentSchema2.AllowAdditionalItems && currentSchema2.AdditionalItems != null)
								{
									list.Add(currentSchema2.AdditionalItems);
								}
							}
						}
						return list;
					}
				}
				case JTokenType.Constructor:
					return EmptySchemaList;
				}
			}
			return EmptySchemaList;
		}
	}

	public JsonSchema Schema
	{
		get
		{
			return _schema;
		}
		set
		{
			if (TokenType != 0)
			{
				throw new InvalidOperationException("Cannot change schema while validating JSON.");
			}
			_schema = value;
			_model = null;
		}
	}

	public JsonReader Reader => _reader;

	int IJsonLineInfo.LineNumber
	{
		get
		{
			if (!(_reader is IJsonLineInfo jsonLineInfo))
			{
				return 0;
			}
			return jsonLineInfo.LineNumber;
		}
	}

	int IJsonLineInfo.LinePosition
	{
		get
		{
			if (!(_reader is IJsonLineInfo jsonLineInfo))
			{
				return 0;
			}
			return jsonLineInfo.LinePosition;
		}
	}

	public event ValidationEventHandler ValidationEventHandler;

	private void Push(SchemaScope scope)
	{
		_stack.Push(scope);
		_currentScope = scope;
	}

	private SchemaScope Pop()
	{
		SchemaScope result = _stack.Pop();
		_currentScope = ((_stack.Count != 0) ? _stack.Peek() : null);
		return result;
	}

	private void RaiseError(string message, JsonSchemaModel schema)
	{
		string message2 = (((IJsonLineInfo)this).HasLineInfo() ? (message + " Line {0}, position {1}.".FormatWith(CultureInfo.InvariantCulture, ((IJsonLineInfo)this).LineNumber, ((IJsonLineInfo)this).LinePosition)) : message);
		OnValidationEvent(new JsonSchemaException(message2, null, Path, ((IJsonLineInfo)this).LineNumber, ((IJsonLineInfo)this).LinePosition));
	}

	private void OnValidationEvent(JsonSchemaException exception)
	{
		ValidationEventHandler validationEventHandler = this.ValidationEventHandler;
		if (validationEventHandler == null)
		{
			throw exception;
		}
		validationEventHandler(this, new ValidationEventArgs(exception));
	}

	public JsonValidatingReader(JsonReader reader)
	{
		ValidationUtils.ArgumentNotNull(reader, "reader");
		_reader = reader;
		_stack = new Stack<SchemaScope>();
	}

	public override void Close()
	{
		base.Close();
		if (base.CloseInput)
		{
			_reader?.Close();
		}
	}

	private void ValidateNotDisallowed(JsonSchemaModel schema)
	{
		if (schema != null)
		{
			JsonSchemaType? currentNodeSchemaType = GetCurrentNodeSchemaType();
			if (currentNodeSchemaType.HasValue && JsonSchemaGenerator.HasFlag(schema.Disallow, currentNodeSchemaType.GetValueOrDefault()))
			{
				RaiseError("Type {0} is disallowed.".FormatWith(CultureInfo.InvariantCulture, currentNodeSchemaType), schema);
			}
		}
	}

	private JsonSchemaType? GetCurrentNodeSchemaType()
	{
		return _reader.TokenType switch
		{
			JsonToken.StartObject => JsonSchemaType.Object, 
			JsonToken.StartArray => JsonSchemaType.Array, 
			JsonToken.Integer => JsonSchemaType.Integer, 
			JsonToken.Float => JsonSchemaType.Float, 
			JsonToken.String => JsonSchemaType.String, 
			JsonToken.Boolean => JsonSchemaType.Boolean, 
			JsonToken.Null => JsonSchemaType.Null, 
			_ => null, 
		};
	}

	public override int? ReadAsInt32()
	{
		int? result = _reader.ReadAsInt32();
		ValidateCurrentToken();
		return result;
	}

	public override byte[] ReadAsBytes()
	{
		byte[]? result = _reader.ReadAsBytes();
		ValidateCurrentToken();
		return result;
	}

	public override decimal? ReadAsDecimal()
	{
		decimal? result = _reader.ReadAsDecimal();
		ValidateCurrentToken();
		return result;
	}

	public override double? ReadAsDouble()
	{
		double? result = _reader.ReadAsDouble();
		ValidateCurrentToken();
		return result;
	}

	public override bool? ReadAsBoolean()
	{
		bool? result = _reader.ReadAsBoolean();
		ValidateCurrentToken();
		return result;
	}

	public override string ReadAsString()
	{
		string? result = _reader.ReadAsString();
		ValidateCurrentToken();
		return result;
	}

	public override DateTime? ReadAsDateTime()
	{
		DateTime? result = _reader.ReadAsDateTime();
		ValidateCurrentToken();
		return result;
	}

	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		DateTimeOffset? result = _reader.ReadAsDateTimeOffset();
		ValidateCurrentToken();
		return result;
	}

	public override bool Read()
	{
		if (!_reader.Read())
		{
			return false;
		}
		if (_reader.TokenType == JsonToken.Comment)
		{
			return true;
		}
		ValidateCurrentToken();
		return true;
	}

	private void ValidateCurrentToken()
	{
		if (_model == null)
		{
			JsonSchemaModelBuilder jsonSchemaModelBuilder = new JsonSchemaModelBuilder();
			_model = jsonSchemaModelBuilder.Build(_schema);
			if (!JsonTokenUtils.IsStartToken(_reader.TokenType))
			{
				Push(new SchemaScope(JTokenType.None, CurrentMemberSchemas));
			}
		}
		switch (_reader.TokenType)
		{
		case JsonToken.StartObject:
		{
			ProcessValue();
			IList<JsonSchemaModel> schemas2 = CurrentMemberSchemas.Where(ValidateObject).ToList();
			Push(new SchemaScope(JTokenType.Object, schemas2));
			WriteToken(CurrentSchemas);
			break;
		}
		case JsonToken.StartArray:
		{
			ProcessValue();
			IList<JsonSchemaModel> schemas = CurrentMemberSchemas.Where(ValidateArray).ToList();
			Push(new SchemaScope(JTokenType.Array, schemas));
			WriteToken(CurrentSchemas);
			break;
		}
		case JsonToken.StartConstructor:
			ProcessValue();
			Push(new SchemaScope(JTokenType.Constructor, null));
			WriteToken(CurrentSchemas);
			break;
		case JsonToken.PropertyName:
			WriteToken(CurrentSchemas);
			{
				foreach (JsonSchemaModel currentSchema in CurrentSchemas)
				{
					ValidatePropertyName(currentSchema);
				}
				break;
			}
		default:
			throw new ArgumentOutOfRangeException();
		case JsonToken.Raw:
			ProcessValue();
			break;
		case JsonToken.Integer:
			ProcessValue();
			WriteToken(CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema in CurrentMemberSchemas)
				{
					ValidateInteger(currentMemberSchema);
				}
				break;
			}
		case JsonToken.Float:
			ProcessValue();
			WriteToken(CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema2 in CurrentMemberSchemas)
				{
					ValidateFloat(currentMemberSchema2);
				}
				break;
			}
		case JsonToken.String:
			ProcessValue();
			WriteToken(CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema3 in CurrentMemberSchemas)
				{
					ValidateString(currentMemberSchema3);
				}
				break;
			}
		case JsonToken.Boolean:
			ProcessValue();
			WriteToken(CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema4 in CurrentMemberSchemas)
				{
					ValidateBoolean(currentMemberSchema4);
				}
				break;
			}
		case JsonToken.Null:
			ProcessValue();
			WriteToken(CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema5 in CurrentMemberSchemas)
				{
					ValidateNull(currentMemberSchema5);
				}
				break;
			}
		case JsonToken.None:
			break;
		case JsonToken.EndObject:
			WriteToken(CurrentSchemas);
			foreach (JsonSchemaModel currentSchema2 in CurrentSchemas)
			{
				ValidateEndObject(currentSchema2);
			}
			Pop();
			break;
		case JsonToken.EndArray:
			WriteToken(CurrentSchemas);
			foreach (JsonSchemaModel currentSchema3 in CurrentSchemas)
			{
				ValidateEndArray(currentSchema3);
			}
			Pop();
			break;
		case JsonToken.EndConstructor:
			WriteToken(CurrentSchemas);
			Pop();
			break;
		case JsonToken.Undefined:
		case JsonToken.Date:
		case JsonToken.Bytes:
			WriteToken(CurrentMemberSchemas);
			break;
		}
	}

	private void WriteToken(IList<JsonSchemaModel> schemas)
	{
		foreach (SchemaScope item in _stack)
		{
			bool flag;
			if (!(flag = item.TokenType == JTokenType.Array && item.IsUniqueArray && item.ArrayItemCount > 0) && !schemas.Any((JsonSchemaModel s) => s.Enum != null))
			{
				continue;
			}
			if (item.CurrentItemWriter == null)
			{
				if (JsonTokenUtils.IsEndToken(_reader.TokenType))
				{
					continue;
				}
				item.CurrentItemWriter = new JTokenWriter();
			}
			item.CurrentItemWriter.WriteToken(_reader, writeChildren: false);
			if (item.CurrentItemWriter.Top != 0 || _reader.TokenType == JsonToken.PropertyName)
			{
				continue;
			}
			JToken token = item.CurrentItemWriter.Token;
			item.CurrentItemWriter = null;
			if (flag)
			{
				if (item.UniqueArrayItems.Contains(token, JToken.EqualityComparer))
				{
					RaiseError("Non-unique array item at index {0}.".FormatWith(CultureInfo.InvariantCulture, item.ArrayItemCount - 1), item.Schemas.First((JsonSchemaModel s) => s.UniqueItems));
				}
				item.UniqueArrayItems.Add(token);
			}
			else
			{
				if (!schemas.Any((JsonSchemaModel s) => s.Enum != null))
				{
					continue;
				}
				foreach (JsonSchemaModel schema in schemas)
				{
					if (schema.Enum != null && !schema.Enum.ContainsValue(token, JToken.EqualityComparer))
					{
						StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
						token.WriteTo(new JsonTextWriter(stringWriter));
						RaiseError("Value {0} is not defined in enum.".FormatWith(CultureInfo.InvariantCulture, stringWriter.ToString()), schema);
					}
				}
			}
		}
	}

	private void ValidateEndObject(JsonSchemaModel schema)
	{
		if (schema == null)
		{
			return;
		}
		Dictionary<string, bool> requiredProperties = _currentScope.RequiredProperties;
		if (requiredProperties != null && requiredProperties.Values.Any((bool v) => !v))
		{
			IEnumerable<string> values = from kv in requiredProperties
				where !kv.Value
				select kv.Key;
			RaiseError("Required properties are missing from object: {0}.".FormatWith(CultureInfo.InvariantCulture, string.Join(", ", values)), schema);
		}
	}

	private void ValidateEndArray(JsonSchemaModel schema)
	{
		if (schema != null)
		{
			int arrayItemCount = _currentScope.ArrayItemCount;
			if (schema.MaximumItems.HasValue && arrayItemCount > schema.MaximumItems)
			{
				RaiseError("Array item count {0} exceeds maximum count of {1}.".FormatWith(CultureInfo.InvariantCulture, arrayItemCount, schema.MaximumItems), schema);
			}
			if (schema.MinimumItems.HasValue && arrayItemCount < schema.MinimumItems)
			{
				RaiseError("Array item count {0} is less than minimum count of {1}.".FormatWith(CultureInfo.InvariantCulture, arrayItemCount, schema.MinimumItems), schema);
			}
		}
	}

	private void ValidateNull(JsonSchemaModel schema)
	{
		if (schema != null && TestType(schema, JsonSchemaType.Null))
		{
			ValidateNotDisallowed(schema);
		}
	}

	private void ValidateBoolean(JsonSchemaModel schema)
	{
		if (schema != null && TestType(schema, JsonSchemaType.Boolean))
		{
			ValidateNotDisallowed(schema);
		}
	}

	private void ValidateString(JsonSchemaModel schema)
	{
		if (schema == null || !TestType(schema, JsonSchemaType.String))
		{
			return;
		}
		ValidateNotDisallowed(schema);
		string text = _reader.Value!.ToString();
		if (schema.MaximumLength.HasValue && text.Length > schema.MaximumLength)
		{
			RaiseError("String '{0}' exceeds maximum length of {1}.".FormatWith(CultureInfo.InvariantCulture, text, schema.MaximumLength), schema);
		}
		if (schema.MinimumLength.HasValue && text.Length < schema.MinimumLength)
		{
			RaiseError("String '{0}' is less than minimum length of {1}.".FormatWith(CultureInfo.InvariantCulture, text, schema.MinimumLength), schema);
		}
		if (schema.Patterns == null)
		{
			return;
		}
		foreach (string pattern in schema.Patterns)
		{
			if (!Regex.IsMatch(text, pattern))
			{
				RaiseError("String '{0}' does not match regex pattern '{1}'.".FormatWith(CultureInfo.InvariantCulture, text, pattern), schema);
			}
		}
	}

	private void ValidateInteger(JsonSchemaModel schema)
	{
		if (schema == null || !TestType(schema, JsonSchemaType.Integer))
		{
			return;
		}
		ValidateNotDisallowed(schema);
		object value = _reader.Value;
		if (schema.Maximum.HasValue)
		{
			if (JValue.Compare(JTokenType.Integer, value, schema.Maximum) > 0)
			{
				RaiseError("Integer {0} exceeds maximum value of {1}.".FormatWith(CultureInfo.InvariantCulture, value, schema.Maximum), schema);
			}
			if (schema.ExclusiveMaximum && JValue.Compare(JTokenType.Integer, value, schema.Maximum) == 0)
			{
				RaiseError("Integer {0} equals maximum value of {1} and exclusive maximum is true.".FormatWith(CultureInfo.InvariantCulture, value, schema.Maximum), schema);
			}
		}
		if (schema.Minimum.HasValue)
		{
			if (JValue.Compare(JTokenType.Integer, value, schema.Minimum) < 0)
			{
				RaiseError("Integer {0} is less than minimum value of {1}.".FormatWith(CultureInfo.InvariantCulture, value, schema.Minimum), schema);
			}
			if (schema.ExclusiveMinimum && JValue.Compare(JTokenType.Integer, value, schema.Minimum) == 0)
			{
				RaiseError("Integer {0} equals minimum value of {1} and exclusive minimum is true.".FormatWith(CultureInfo.InvariantCulture, value, schema.Minimum), schema);
			}
		}
		if (schema.DivisibleBy.HasValue && ((!(value is BigInteger bigInteger)) ? (!IsZero((double)Convert.ToInt64(value, CultureInfo.InvariantCulture) % schema.DivisibleBy.GetValueOrDefault())) : (Math.Abs(schema.DivisibleBy.Value - Math.Truncate(schema.DivisibleBy.Value)).Equals(0.0) ? (bigInteger % new BigInteger(schema.DivisibleBy.Value) != 0L) : (bigInteger != 0L))))
		{
			RaiseError("Integer {0} is not evenly divisible by {1}.".FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(value), schema.DivisibleBy), schema);
		}
	}

	private void ProcessValue()
	{
		if (_currentScope == null || _currentScope.TokenType != JTokenType.Array)
		{
			return;
		}
		_currentScope.ArrayItemCount++;
		foreach (JsonSchemaModel currentSchema in CurrentSchemas)
		{
			if (currentSchema != null && currentSchema.PositionalItemsValidation && !currentSchema.AllowAdditionalItems && (currentSchema.Items == null || _currentScope.ArrayItemCount - 1 >= currentSchema.Items.Count))
			{
				RaiseError("Index {0} has not been defined and the schema does not allow additional items.".FormatWith(CultureInfo.InvariantCulture, _currentScope.ArrayItemCount), currentSchema);
			}
		}
	}

	private void ValidateFloat(JsonSchemaModel schema)
	{
		if (schema == null || !TestType(schema, JsonSchemaType.Float))
		{
			return;
		}
		ValidateNotDisallowed(schema);
		double num = Convert.ToDouble(_reader.Value, CultureInfo.InvariantCulture);
		if (schema.Maximum.HasValue)
		{
			if (num > schema.Maximum)
			{
				RaiseError("Float {0} exceeds maximum value of {1}.".FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Maximum), schema);
			}
			if (schema.ExclusiveMaximum && num == schema.Maximum)
			{
				RaiseError("Float {0} equals maximum value of {1} and exclusive maximum is true.".FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Maximum), schema);
			}
		}
		if (schema.Minimum.HasValue)
		{
			if (num < schema.Minimum)
			{
				RaiseError("Float {0} is less than minimum value of {1}.".FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Minimum), schema);
			}
			if (schema.ExclusiveMinimum && num == schema.Minimum)
			{
				RaiseError("Float {0} equals minimum value of {1} and exclusive minimum is true.".FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Minimum), schema);
			}
		}
		if (schema.DivisibleBy.HasValue && !IsZero(FloatingPointRemainder(num, schema.DivisibleBy.GetValueOrDefault())))
		{
			RaiseError("Float {0} is not evenly divisible by {1}.".FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.DivisibleBy), schema);
		}
	}

	private static double FloatingPointRemainder(double dividend, double divisor)
	{
		return dividend - Math.Floor(dividend / divisor) * divisor;
	}

	private static bool IsZero(double value)
	{
		return Math.Abs(value) < 4.440892098500626E-15;
	}

	private void ValidatePropertyName(JsonSchemaModel schema)
	{
		if (schema != null)
		{
			string text = Convert.ToString(_reader.Value, CultureInfo.InvariantCulture);
			if (_currentScope.RequiredProperties.ContainsKey(text))
			{
				_currentScope.RequiredProperties[text] = true;
			}
			if (!schema.AllowAdditionalProperties && !IsPropertyDefinied(schema, text))
			{
				RaiseError("Property '{0}' has not been defined and the schema does not allow additional properties.".FormatWith(CultureInfo.InvariantCulture, text), schema);
			}
			_currentScope.CurrentPropertyName = text;
		}
	}

	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName)
	{
		if (schema.Properties != null && schema.Properties.ContainsKey(propertyName))
		{
			return true;
		}
		if (schema.PatternProperties != null)
		{
			foreach (string key in schema.PatternProperties.Keys)
			{
				if (Regex.IsMatch(propertyName, key))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool ValidateArray(JsonSchemaModel schema)
	{
		if (schema == null)
		{
			return true;
		}
		return TestType(schema, JsonSchemaType.Array);
	}

	private bool ValidateObject(JsonSchemaModel schema)
	{
		if (schema == null)
		{
			return true;
		}
		return TestType(schema, JsonSchemaType.Object);
	}

	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType)
	{
		if (!JsonSchemaGenerator.HasFlag(currentSchema.Type, currentType))
		{
			RaiseError("Invalid type. Expected {0} but got {1}.".FormatWith(CultureInfo.InvariantCulture, currentSchema.Type, currentType), currentSchema);
			return false;
		}
		return true;
	}

	bool IJsonLineInfo.HasLineInfo()
	{
		if (_reader is IJsonLineInfo jsonLineInfo)
		{
			return jsonLineInfo.HasLineInfo();
		}
		return false;
	}
}
