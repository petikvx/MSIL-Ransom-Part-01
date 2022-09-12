using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using ns10;
using ns18;
using ns9;

namespace ns4;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class164
{
	[CompilerGenerated]
	internal sealed class Class165
	{
		public JsonSchemaType jsonSchemaType_0;

		internal bool method_0(KeyValuePair<string, JsonSchemaType> keyValuePair_0)
		{
			return keyValuePair_0.Value == jsonSchemaType_0;
		}
	}

	internal readonly IList<JsonSchema> ilist_0;

	internal readonly Class172 class172_0;

	internal readonly IDictionary<string, JsonSchema> idictionary_0;

	internal JsonSchema jsonSchema_0;

	internal JObject jobject_0;

	internal JsonSchema CurrentSchema => jsonSchema_0;

	public Class164(Class172 class172_1)
	{
		ilist_0 = new List<JsonSchema>();
		idictionary_0 = new Dictionary<string, JsonSchema>();
		class172_0 = class172_1;
	}

	internal JsonSchema method_0(JsonSchema jsonSchema_1)
	{
		if (jsonSchema_1.DeferredReference != null)
		{
			string text = jsonSchema_1.DeferredReference;
			bool flag;
			if (flag = text.StartsWith("#", StringComparison.Ordinal))
			{
				text = Class7.smethod_159(text, this);
			}
			JsonSchema jsonSchema = class172_0.vmethod_0(text);
			if (jsonSchema == null)
			{
				if (flag)
				{
					string[] array = jsonSchema_1.DeferredReference.TrimStart(new char[1] { '#' }).Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
					JToken jToken = jobject_0;
					string[] array2 = array;
					foreach (string string_ in array2)
					{
						string text2 = Class7.smethod_159(string_, this);
						if (jToken.Type == JTokenType.Object)
						{
							jToken = jToken[text2];
						}
						else if (jToken.Type == JTokenType.Array || jToken.Type == JTokenType.Constructor)
						{
							jToken = ((!int.TryParse(text2, out var result) || result < 0 || result >= jToken.Count()) ? null : jToken[result]);
						}
						if (jToken == null)
						{
							break;
						}
					}
					if (jToken != null)
					{
						jsonSchema = Class7.smethod_617(this, jToken);
					}
				}
				if (jsonSchema == null)
				{
					throw new JsonException("Could not resolve schema reference '{0}'.".smethod_1(CultureInfo.InvariantCulture, jsonSchema_1.DeferredReference));
				}
			}
			jsonSchema_1 = jsonSchema;
		}
		if (jsonSchema_1.ReferencesResolved)
		{
			return jsonSchema_1;
		}
		jsonSchema_1.ReferencesResolved = true;
		if (jsonSchema_1.Extends != null)
		{
			for (int j = 0; j < jsonSchema_1.Extends.Count; j++)
			{
				jsonSchema_1.Extends[j] = method_0(jsonSchema_1.Extends[j]);
			}
		}
		if (jsonSchema_1.Items != null)
		{
			for (int k = 0; k < jsonSchema_1.Items.Count; k++)
			{
				jsonSchema_1.Items[k] = method_0(jsonSchema_1.Items[k]);
			}
		}
		if (jsonSchema_1.AdditionalItems != null)
		{
			jsonSchema_1.AdditionalItems = method_0(jsonSchema_1.AdditionalItems);
		}
		if (jsonSchema_1.PatternProperties != null)
		{
			foreach (KeyValuePair<string, JsonSchema> item in jsonSchema_1.PatternProperties.ToList())
			{
				jsonSchema_1.PatternProperties[item.Key] = method_0(item.Value);
			}
		}
		if (jsonSchema_1.Properties != null)
		{
			foreach (KeyValuePair<string, JsonSchema> item2 in jsonSchema_1.Properties.ToList())
			{
				jsonSchema_1.Properties[item2.Key] = method_0(item2.Value);
			}
		}
		if (jsonSchema_1.AdditionalProperties != null)
		{
			jsonSchema_1.AdditionalProperties = method_0(jsonSchema_1.AdditionalProperties);
		}
		return jsonSchema_1;
	}
}
