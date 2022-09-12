using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using ns10;
using ns15;
using ns17;
using ns2;
using ns5;
using ns8;

namespace Newtonsoft.Json;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonValidatingReader : Class29, Interface1
{
	internal class SchemaScope
	{
		internal readonly JTokenType jtokenType_0;

		internal readonly IList<JsonSchemaModel> ilist_0;

		internal readonly Dictionary<string, bool> dictionary_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private readonly bool bool_0;

		[CompilerGenerated]
		private readonly IList<JToken> ilist_1;

		[CompilerGenerated]
		private Class41 class41_0;

		public string CurrentPropertyName
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public int ArrayItemCount
		{
			[CompilerGenerated]
			get
			{
				return int_0;
			}
			[CompilerGenerated]
			set
			{
				int_0 = value;
			}
		}

		public bool IsUniqueArray
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
		}

		public IList<JToken> UniqueArrayItems
		{
			[CompilerGenerated]
			get
			{
				return ilist_1;
			}
		}

		public Class41 CurrentItemWriter
		{
			[CompilerGenerated]
			get
			{
				return class41_0;
			}
			[CompilerGenerated]
			set
			{
				class41_0 = value;
			}
		}

		public IList<JsonSchemaModel> Schemas => ilist_0;

		public Dictionary<string, bool> RequiredProperties => dictionary_0;

		public JTokenType TokenType => jtokenType_0;

		public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
		{
			jtokenType_0 = tokenType;
			ilist_0 = schemas;
			dictionary_0 = schemas.SelectMany(method_0).Distinct().ToDictionary((string string_0) => string_0, (string string_0) => false);
			if (tokenType == JTokenType.Array && schemas.Any((JsonSchemaModel jsonSchemaModel_0) => jsonSchemaModel_0.UniqueItems))
			{
				bool_0 = true;
				ilist_1 = new List<JToken>();
			}
		}

		private IEnumerable<string> method_0(JsonSchemaModel jsonSchemaModel_0)
		{
			if (jsonSchemaModel_0?.Properties == null)
			{
				return Enumerable.Empty<string>();
			}
			return from keyValuePair_0 in jsonSchemaModel_0.Properties
				where keyValuePair_0.Value.Required
				select keyValuePair_0.Key;
		}
	}

	internal readonly Class29 class29_0;

	internal readonly Stack<SchemaScope> stack_0;

	internal JsonSchema jsonSchema_0;

	internal JsonSchemaModel jsonSchemaModel_0;

	internal SchemaScope schemaScope_0;

	[CompilerGenerated]
	internal Delegate8 delegate8_0;

	private static readonly IList<JsonSchemaModel> ilist_0 = new List<JsonSchemaModel>();

	public override object Value => class29_0.Value;

	public override int Depth => class29_0.Depth;

	public override string Path => class29_0.Path;

	public override char QuoteChar
	{
		get
		{
			return class29_0.QuoteChar;
		}
		protected internal set
		{
		}
	}

	public override JsonToken TokenType => class29_0.TokenType;

	public override Type ValueType => class29_0.ValueType;

	internal IList<JsonSchemaModel> CurrentSchemas => schemaScope_0.ilist_0;

	internal IList<JsonSchemaModel> CurrentMemberSchemas
	{
		get
		{
			if (schemaScope_0 == null)
			{
				return new List<JsonSchemaModel>(new JsonSchemaModel[1] { jsonSchemaModel_0 });
			}
			if (schemaScope_0.ilist_0 != null && schemaScope_0.ilist_0.Count != 0)
			{
				switch (schemaScope_0.jtokenType_0)
				{
				default:
					throw new ArgumentOutOfRangeException("TokenType", "Unexpected token type: {0}".smethod_1(CultureInfo.InvariantCulture, schemaScope_0.jtokenType_0));
				case JTokenType.None:
					return schemaScope_0.ilist_0;
				case JTokenType.Object:
				{
					if (schemaScope_0.CurrentPropertyName == null)
					{
						throw new JsonReaderException("CurrentPropertyName has not been set on scope.");
					}
					IList<JsonSchemaModel> list2 = new List<JsonSchemaModel>();
					{
						foreach (JsonSchemaModel currentSchema in CurrentSchemas)
						{
							if (currentSchema.Properties != null && currentSchema.Properties.TryGetValue(schemaScope_0.CurrentPropertyName, out var value))
							{
								list2.Add(value);
							}
							if (currentSchema.PatternProperties != null)
							{
								foreach (KeyValuePair<string, JsonSchemaModel> patternProperty in currentSchema.PatternProperties)
								{
									if (Regex.IsMatch(schemaScope_0.CurrentPropertyName, patternProperty.Key))
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
								if (currentSchema2.Items != null && currentSchema2.Items.Count > 0 && currentSchema2.Items.Count > schemaScope_0.ArrayItemCount - 1)
								{
									list.Add(currentSchema2.Items[schemaScope_0.ArrayItemCount - 1]);
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
					return ilist_0;
				}
			}
			return ilist_0;
		}
	}

	public JsonSchema Schema
	{
		get
		{
			return jsonSchema_0;
		}
		set
		{
			if (TokenType != 0)
			{
				throw new InvalidOperationException("Cannot change schema while validating JSON.");
			}
			jsonSchema_0 = value;
			jsonSchemaModel_0 = null;
		}
	}

	public Class29 Reader => class29_0;

	int Interface1.LineNumber
	{
		get
		{
			if (!(class29_0 is Interface1 @interface))
			{
				return 0;
			}
			return @interface.LineNumber;
		}
	}

	int Interface1.LinePosition
	{
		get
		{
			if (!(class29_0 is Interface1 @interface))
			{
				return 0;
			}
			return @interface.LinePosition;
		}
	}

	public event Delegate8 ValidationEventHandler
	{
		[CompilerGenerated]
		add
		{
			Delegate8 @delegate = delegate8_0;
			Delegate8 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate8 value2 = (Delegate8)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate8_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate8 @delegate = delegate8_0;
			Delegate8 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate8 value2 = (Delegate8)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate8_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public JsonValidatingReader(Class29 reader)
	{
		Class113.smethod_0(reader, "reader");
		class29_0 = reader;
		stack_0 = new Stack<SchemaScope>();
	}

	public override void vmethod_10()
	{
		base.vmethod_10();
		if (base.CloseInput)
		{
			class29_0?.vmethod_10();
		}
	}

	public override int? vmethod_1()
	{
		int? result = class29_0.vmethod_1();
		Class4.smethod_33(this);
		return result;
	}

	public override byte[] vmethod_3()
	{
		byte[]? result = class29_0.vmethod_3();
		Class4.smethod_33(this);
		return result;
	}

	public override decimal? vmethod_6()
	{
		decimal? result = class29_0.vmethod_6();
		Class4.smethod_33(this);
		return result;
	}

	public override double? vmethod_4()
	{
		double? result = class29_0.vmethod_4();
		Class4.smethod_33(this);
		return result;
	}

	public override bool? vmethod_5()
	{
		bool? result = class29_0.vmethod_5();
		Class4.smethod_33(this);
		return result;
	}

	public override string vmethod_2()
	{
		string? result = class29_0.vmethod_2();
		Class4.smethod_33(this);
		return result;
	}

	public override DateTime? vmethod_7()
	{
		DateTime? result = class29_0.vmethod_7();
		Class4.smethod_33(this);
		return result;
	}

	public override DateTimeOffset? vmethod_8()
	{
		DateTimeOffset? result = class29_0.vmethod_8();
		Class4.smethod_33(this);
		return result;
	}

	public override bool vmethod_0()
	{
		if (!class29_0.vmethod_0())
		{
			return false;
		}
		if (class29_0.TokenType == JsonToken.Comment)
		{
			return true;
		}
		Class4.smethod_33(this);
		return true;
	}

	internal void method_3(IList<JsonSchemaModel> ilist_1)
	{
		foreach (SchemaScope item in stack_0)
		{
			bool flag;
			if (!(flag = item.jtokenType_0 == JTokenType.Array && item.IsUniqueArray && item.ArrayItemCount > 0) && !ilist_1.Any((JsonSchemaModel jsonSchemaModel_0) => jsonSchemaModel_0.Enum != null))
			{
				continue;
			}
			if (item.CurrentItemWriter == null)
			{
				if (Class4.smethod_245(class29_0.TokenType))
				{
					continue;
				}
				item.CurrentItemWriter = new Class41();
			}
			Class4.smethod_713((Class38)item.CurrentItemWriter, class29_0, bool_0: false);
			if (item.CurrentItemWriter.Top != 0 || class29_0.TokenType == JsonToken.PropertyName)
			{
				continue;
			}
			JToken token = item.CurrentItemWriter.Token;
			item.CurrentItemWriter = null;
			if (flag)
			{
				if (item.UniqueArrayItems.Contains(token, JToken.EqualityComparer))
				{
					Class4.smethod_603(this, "Non-unique array item at index {0}.".smethod_1(CultureInfo.InvariantCulture, item.ArrayItemCount - 1), item.ilist_0.First((JsonSchemaModel jsonSchemaModel_0) => jsonSchemaModel_0.UniqueItems));
				}
				item.UniqueArrayItems.Add(token);
			}
			else
			{
				if (!ilist_1.Any((JsonSchemaModel jsonSchemaModel_0) => jsonSchemaModel_0.Enum != null))
				{
					continue;
				}
				foreach (JsonSchemaModel item2 in ilist_1)
				{
					if (item2.Enum != null && !item2.Enum.smethod_4(token, JToken.EqualityComparer))
					{
						StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
						token.vmethod_5(new Class39(stringWriter));
						Class4.smethod_603(this, "Value {0} is not defined in enum.".smethod_1(CultureInfo.InvariantCulture, stringWriter.ToString()), item2);
					}
				}
			}
		}
	}

	internal void method_4(JsonSchemaModel jsonSchemaModel_1)
	{
		if (jsonSchemaModel_1 == null || !Class4.smethod_680(this, jsonSchemaModel_1, JsonSchemaType.Integer))
		{
			return;
		}
		Class4.smethod_224(this, jsonSchemaModel_1);
		object value = class29_0.Value;
		if (jsonSchemaModel_1.Maximum.HasValue)
		{
			if (Class179.smethod_37(JTokenType.Integer, value, jsonSchemaModel_1.Maximum) > 0)
			{
				Class4.smethod_603(this, "Integer {0} exceeds maximum value of {1}.".smethod_2(CultureInfo.InvariantCulture, value, jsonSchemaModel_1.Maximum), jsonSchemaModel_1);
			}
			if (jsonSchemaModel_1.ExclusiveMaximum && Class179.smethod_37(JTokenType.Integer, value, jsonSchemaModel_1.Maximum) == 0)
			{
				Class4.smethod_603(this, "Integer {0} equals maximum value of {1} and exclusive maximum is true.".smethod_2(CultureInfo.InvariantCulture, value, jsonSchemaModel_1.Maximum), jsonSchemaModel_1);
			}
		}
		if (jsonSchemaModel_1.Minimum.HasValue)
		{
			if (Class179.smethod_37(JTokenType.Integer, value, jsonSchemaModel_1.Minimum) < 0)
			{
				Class4.smethod_603(this, "Integer {0} is less than minimum value of {1}.".smethod_2(CultureInfo.InvariantCulture, value, jsonSchemaModel_1.Minimum), jsonSchemaModel_1);
			}
			if (jsonSchemaModel_1.ExclusiveMinimum && Class179.smethod_37(JTokenType.Integer, value, jsonSchemaModel_1.Minimum) == 0)
			{
				Class4.smethod_603(this, "Integer {0} equals minimum value of {1} and exclusive minimum is true.".smethod_2(CultureInfo.InvariantCulture, value, jsonSchemaModel_1.Minimum), jsonSchemaModel_1);
			}
		}
		if (jsonSchemaModel_1.DivisibleBy.HasValue && ((!(value is BigInteger bigInteger)) ? (!Class4.smethod_620((double)Convert.ToInt64(value, CultureInfo.InvariantCulture) % jsonSchemaModel_1.DivisibleBy.GetValueOrDefault())) : (Math.Abs(jsonSchemaModel_1.DivisibleBy.Value - Math.Truncate(jsonSchemaModel_1.DivisibleBy.Value)).Equals(0.0) ? (bigInteger % new BigInteger(jsonSchemaModel_1.DivisibleBy.Value) != 0L) : (bigInteger != 0L))))
		{
			Class4.smethod_603(this, "Integer {0} is not evenly divisible by {1}.".smethod_2(CultureInfo.InvariantCulture, Class4.smethod_304(value), jsonSchemaModel_1.DivisibleBy), jsonSchemaModel_1);
		}
	}

	internal bool method_5(JsonSchemaModel jsonSchemaModel_1)
	{
		if (jsonSchemaModel_1 == null)
		{
			return true;
		}
		return Class4.smethod_680(this, jsonSchemaModel_1, JsonSchemaType.Array);
	}

	internal bool method_6(JsonSchemaModel jsonSchemaModel_1)
	{
		if (jsonSchemaModel_1 == null)
		{
			return true;
		}
		return Class4.smethod_680(this, jsonSchemaModel_1, JsonSchemaType.Object);
	}

	bool Interface1.imethod_0()
	{
		if (class29_0 is Interface1 @interface)
		{
			return @interface.imethod_0();
		}
		return false;
	}
}
