using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;
using ns0;
using ns10;
using ns12;
using ns13;
using ns14;
using ns16;
using ns17;
using ns19;
using ns4;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns3;

internal class Class34 : Class33
{
	internal readonly JsonSerializerInternalReader? jsonSerializerInternalReader_0;

	internal readonly Class152? class152_0;

	private readonly Class33 class33_0;

	public override Interface5? ReferenceResolver
	{
		get
		{
			return class33_0.ReferenceResolver;
		}
		set
		{
			class33_0.ReferenceResolver = value;
		}
	}

	public override Interface7? TraceWriter
	{
		get
		{
			return class33_0.TraceWriter;
		}
		set
		{
			class33_0.TraceWriter = value;
		}
	}

	public override IEqualityComparer? EqualityComparer
	{
		get
		{
			return class33_0.EqualityComparer;
		}
		set
		{
			class33_0.EqualityComparer = value;
		}
	}

	public override Class27 Converters => class33_0.Converters;

	public override Enum4 DefaultValueHandling
	{
		get
		{
			return class33_0.DefaultValueHandling;
		}
		set
		{
			class33_0.DefaultValueHandling = value;
		}
	}

	public override Interface4 ContractResolver
	{
		get
		{
			return class33_0.ContractResolver;
		}
		set
		{
			class33_0.ContractResolver = value;
		}
	}

	public override Enum11 MissingMemberHandling
	{
		get
		{
			return class33_0.MissingMemberHandling;
		}
		set
		{
			class33_0.MissingMemberHandling = value;
		}
	}

	public override Enum12 NullValueHandling
	{
		get
		{
			return class33_0.NullValueHandling;
		}
		set
		{
			class33_0.NullValueHandling = value;
		}
	}

	public override Enum13 ObjectCreationHandling
	{
		get
		{
			return class33_0.ObjectCreationHandling;
		}
		set
		{
			class33_0.ObjectCreationHandling = value;
		}
	}

	public override Enum15 ReferenceLoopHandling
	{
		get
		{
			return class33_0.ReferenceLoopHandling;
		}
		set
		{
			class33_0.ReferenceLoopHandling = value;
		}
	}

	public override Enum14 PreserveReferencesHandling
	{
		get
		{
			return class33_0.PreserveReferencesHandling;
		}
		set
		{
			class33_0.PreserveReferencesHandling = value;
		}
	}

	public override Enum19 TypeNameHandling
	{
		get
		{
			return class33_0.TypeNameHandling;
		}
		set
		{
			class33_0.TypeNameHandling = value;
		}
	}

	public override Enum10 MetadataPropertyHandling
	{
		get
		{
			return class33_0.MetadataPropertyHandling;
		}
		set
		{
			class33_0.MetadataPropertyHandling = value;
		}
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public override FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		get
		{
			return class33_0.TypeNameAssemblyFormat;
		}
		set
		{
			class33_0.TypeNameAssemblyFormat = value;
		}
	}

	public override Enum18 TypeNameAssemblyFormatHandling
	{
		get
		{
			return class33_0.TypeNameAssemblyFormatHandling;
		}
		set
		{
			class33_0.TypeNameAssemblyFormatHandling = value;
		}
	}

	public override Enum0 ConstructorHandling
	{
		get
		{
			return class33_0.ConstructorHandling;
		}
		set
		{
			class33_0.ConstructorHandling = value;
		}
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public override SerializationBinder Binder
	{
		get
		{
			return class33_0.Binder;
		}
		set
		{
			class33_0.Binder = value;
		}
	}

	public override Interface6 SerializationBinder
	{
		get
		{
			return class33_0.SerializationBinder;
		}
		set
		{
			class33_0.SerializationBinder = value;
		}
	}

	public override StreamingContext Context
	{
		get
		{
			return class33_0.Context;
		}
		set
		{
			class33_0.Context = value;
		}
	}

	public override Enum7 Formatting
	{
		get
		{
			return class33_0.Formatting;
		}
		set
		{
			class33_0.Formatting = value;
		}
	}

	public override Enum1 DateFormatHandling
	{
		get
		{
			return class33_0.DateFormatHandling;
		}
		set
		{
			class33_0.DateFormatHandling = value;
		}
	}

	public override Enum3 DateTimeZoneHandling
	{
		get
		{
			return class33_0.DateTimeZoneHandling;
		}
		set
		{
			class33_0.DateTimeZoneHandling = value;
		}
	}

	public override Enum2 DateParseHandling
	{
		get
		{
			return class33_0.DateParseHandling;
		}
		set
		{
			class33_0.DateParseHandling = value;
		}
	}

	public override Enum5 FloatFormatHandling
	{
		get
		{
			return class33_0.FloatFormatHandling;
		}
		set
		{
			class33_0.FloatFormatHandling = value;
		}
	}

	public override Enum6 FloatParseHandling
	{
		get
		{
			return class33_0.FloatParseHandling;
		}
		set
		{
			class33_0.FloatParseHandling = value;
		}
	}

	public override Enum17 StringEscapeHandling
	{
		get
		{
			return class33_0.StringEscapeHandling;
		}
		set
		{
			class33_0.StringEscapeHandling = value;
		}
	}

	public override string DateFormatString
	{
		get
		{
			return class33_0.DateFormatString;
		}
		set
		{
			class33_0.DateFormatString = value;
		}
	}

	public override CultureInfo Culture
	{
		get
		{
			return class33_0.Culture;
		}
		set
		{
			class33_0.Culture = value;
		}
	}

	public override int? MaxDepth
	{
		get
		{
			return class33_0.MaxDepth;
		}
		set
		{
			class33_0.MaxDepth = value;
		}
	}

	public override bool CheckAdditionalContent
	{
		get
		{
			return class33_0.CheckAdditionalContent;
		}
		set
		{
			class33_0.CheckAdditionalContent = value;
		}
	}

	public override event EventHandler<EventArgs0>? Error
	{
		add
		{
			class33_0.Error += value;
		}
		remove
		{
			class33_0.Error -= value;
		}
	}

	public Class34(JsonSerializerInternalReader jsonSerializerInternalReader_1)
	{
		Class112.smethod_0(jsonSerializerInternalReader_1, "serializerReader");
		jsonSerializerInternalReader_0 = jsonSerializerInternalReader_1;
		class33_0 = jsonSerializerInternalReader_1.class33_0;
	}

	public Class34(Class152 class152_1)
	{
		Class112.smethod_0(class152_1, "serializerWriter");
		class152_0 = class152_1;
		class33_0 = class152_1.class33_0;
	}

	internal override object? vmethod_1(Class28 class28_0, Type? type_0)
	{
		if (jsonSerializerInternalReader_0 != null)
		{
			return jsonSerializerInternalReader_0!.method_2(class28_0, type_0, bool_0: false);
		}
		return class33_0.method_5(class28_0, type_0);
	}

	internal override void vmethod_0(Class28 class28_0, object object_0)
	{
		if (jsonSerializerInternalReader_0 != null)
		{
			Class131.smethod_154(jsonSerializerInternalReader_0, class28_0, object_0);
		}
		else
		{
			class33_0.method_1(class28_0, object_0);
		}
	}

	internal override void vmethod_2(Class37 class37_0, object? object_0, Type? type_0)
	{
		if (class152_0 != null)
		{
			class152_0!.method_1(class37_0, object_0, type_0);
		}
		else
		{
			Class131.smethod_436(class33_0, class37_0, object_0);
		}
	}
}
