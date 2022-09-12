using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using ns13;
using ns17;
using ns3;
using ns4;
using ns5;
using ns8;
using ns9;

namespace ns1;

internal class Class19 : Class8
{
	internal class Class220
	{
		public readonly Class79 class79_0;

		public readonly List<Class221> list_0;

		public Class220(Class79 class79_1, List<Class221> list_1)
		{
			class79_0 = class79_1;
			list_0 = list_1;
		}
	}

	internal class Class221
	{
		public readonly int int_0;

		public readonly string string_0;

		public readonly PropertyInfo[] propertyInfo_0;

		public readonly Class79 class79_0;

		public readonly Class79 class79_1;

		public Class221(int int_1, string string_1, PropertyInfo[] propertyInfo_1, Class79 class79_2, Class79 class79_3)
		{
			int_0 = int_1;
			string_0 = string_1;
			propertyInfo_0 = propertyInfo_1;
			class79_0 = class79_2;
			class79_1 = class79_3;
		}
	}

	[CompilerGenerated]
	private sealed class Class222
	{
		public int int_0;

		internal bool method_0(Class221 class221_0)
		{
			return class221_0.int_0 == int_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class223
	{
		public string string_0;

		public Func<Class221, bool> func_0;

		internal bool method_0(Class221 class221_0)
		{
			return class221_0.string_0 == string_0;
		}
	}

	private const string string_0 = "Case";

	private const string string_1 = "Fields";

	private static readonly Class110<Type, Class220> class110_0 = new Class110<Type, Class220>((Func<Type, Class220>)Class131.smethod_231);

	private static readonly Class110<Type, Type> class110_1 = new Class110<Type, Type>((Func<Type, Type>)Class131.smethod_456);

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		DefaultContractResolver defaultContractResolver = class33_0.ContractResolver as DefaultContractResolver;
		Type gparam_ = class110_1.method_0(object_0!.GetType());
		Class220 @class = class110_0.method_0(gparam_);
		int int_0 = (int)@class.class79_0.method_0(object_0);
		Class221 class2 = @class.list_0.Single((Class221 class221_0) => class221_0.int_0 == int_0);
		class37_0.vmethod_3();
		class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Case") : "Case");
		class37_0.vmethod_21(class2.string_0);
		if (class2.propertyInfo_0 != null && class2.propertyInfo_0.Length != 0)
		{
			object[] obj = (object[])class2.class79_0.method_0(object_0);
			class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Fields") : "Fields");
			class37_0.vmethod_5();
			object[] array = obj;
			foreach (object object_ in array)
			{
				Class131.smethod_436(class33_0, class37_0, object_);
			}
			class37_0.vmethod_6();
		}
		class37_0.vmethod_4();
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		Class221 @class = null;
		string string_0 = null;
		Class177 class2 = null;
		Class131.smethod_167(class28_0);
		object[] array;
		while (true)
		{
			if (class28_0.TokenType == JsonToken.PropertyName)
			{
				string text = class28_0.Value!.ToString();
				if (string.Equals(text, "Case", StringComparison.OrdinalIgnoreCase))
				{
					Class131.smethod_167(class28_0);
					Class220 class3 = class110_0.method_0(type_0);
					string_0 = class28_0.Value!.ToString();
					@class = class3.list_0.SingleOrDefault((Class221 class221_0) => class221_0.string_0 == string_0);
					if (@class == null)
					{
						throw Class131.smethod_38(class28_0, "No union type found with the name '{0}'.".smethod_1(CultureInfo.InvariantCulture, string_0));
					}
				}
				else
				{
					if (!string.Equals(text, "Fields", StringComparison.OrdinalIgnoreCase))
					{
						throw Class131.smethod_38(class28_0, "Unexpected property '{0}' found when reading union.".smethod_1(CultureInfo.InvariantCulture, text));
					}
					Class131.smethod_167(class28_0);
					if (class28_0.TokenType != JsonToken.StartArray)
					{
						throw Class131.smethod_38(class28_0, "Union fields must been an array.");
					}
					class2 = (Class177)Class131.smethod_742(class28_0);
				}
				Class131.smethod_167(class28_0);
				continue;
			}
			if (@class == null)
			{
				throw Class131.smethod_38(class28_0, "No '{0}' property with union name found.".smethod_1(CultureInfo.InvariantCulture, "Case"));
			}
			array = new object[@class.propertyInfo_0.Length];
			if (@class.propertyInfo_0.Length != 0 && class2 == null)
			{
				throw Class131.smethod_38(class28_0, "No '{0}' property with union fields found.".smethod_1(CultureInfo.InvariantCulture, "Fields"));
			}
			if (class2 == null)
			{
				break;
			}
			if (@class.propertyInfo_0.Length != class2.Count)
			{
				throw Class131.smethod_38(class28_0, "The number of field values does not match the number of properties defined by union '{0}'.".smethod_1(CultureInfo.InvariantCulture, string_0));
			}
			for (int i = 0; i < class2.Count; i++)
			{
				JToken jtoken_ = class2[i];
				PropertyInfo propertyInfo = @class.propertyInfo_0[i];
				array[i] = Class131.smethod_416(jtoken_, propertyInfo.PropertyType, class33_0);
			}
			break;
		}
		object[] object_ = new object[1] { array };
		return @class.class79_1.method_0(object_);
	}

	public override bool vmethod_2(Type type_0)
	{
		if (typeof(IEnumerable).IsAssignableFrom(type_0))
		{
			return false;
		}
		object[] customAttributes = type_0.GetCustomAttributes(inherit: true);
		bool flag = false;
		object[] array = customAttributes;
		for (int i = 0; i < array.Length; i++)
		{
			Type type = array[i].GetType();
			if (type.FullName == "Microsoft.FSharp.Core.CompilationMappingAttribute")
			{
				Class131.smethod_594(type.smethod_7());
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return false;
		}
		return (bool)FSharpUtils.fsharpUtils_0!.IsUnion(null, type_0, null);
	}
}
