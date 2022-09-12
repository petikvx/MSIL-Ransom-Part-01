using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns18;
using ns3;
using ns4;
using ns5;
using ns6;
using ns8;
using ns9;

namespace ns7;

internal class Class36
{
	[CompilerGenerated]
	private sealed class Class37
	{
		public Interface5 interface5_0;

		internal Interface5? method_0()
		{
			return interface5_0;
		}
	}

	internal const Enum15 enum15_0 = Enum15.const_0;

	internal const Enum11 enum11_0 = Enum11.const_0;

	internal const Enum12 enum12_0 = Enum12.const_0;

	internal const Enum4 enum4_0 = Enum4.flag_0;

	internal const Enum13 enum13_0 = Enum13.const_0;

	internal const Enum14 enum14_0 = Enum14.flag_0;

	internal const Enum0 enum0_0 = Enum0.const_0;

	internal const Enum19 enum19_0 = Enum19.flag_0;

	internal const Enum10 enum10_0 = Enum10.const_0;

	internal static readonly StreamingContext streamingContext_0;

	internal const Enum7 enum7_0 = Enum7.const_0;

	internal const Enum1 enum1_0 = Enum1.const_0;

	internal const Enum3 enum3_0 = Enum3.const_3;

	internal const Enum2 enum2_0 = Enum2.const_1;

	internal const Enum6 enum6_0 = Enum6.const_0;

	internal const Enum5 enum5_0 = Enum5.const_0;

	internal const Enum17 enum17_0 = Enum17.const_0;

	internal const Enum18 enum18_0 = Enum18.const_0;

	internal static readonly CultureInfo cultureInfo_0;

	internal const bool bool_0 = false;

	internal const string string_0 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

	internal const int int_0 = 64;

	internal Enum7? nullable_0;

	internal Enum1? nullable_1;

	internal Enum3? nullable_2;

	internal Enum2? nullable_3;

	internal Enum5? nullable_4;

	internal Enum6? nullable_5;

	internal Enum17? nullable_6;

	internal CultureInfo? cultureInfo_1;

	internal bool? nullable_7;

	internal int? nullable_8;

	internal bool bool_1;

	internal string? string_1;

	internal bool bool_2;

	internal Enum18? nullable_9;

	internal Enum4? nullable_10;

	internal Enum14? nullable_11;

	internal Enum12? nullable_12;

	internal Enum13? nullable_13;

	internal Enum11? nullable_14;

	internal Enum15? nullable_15;

	internal StreamingContext? nullable_16;

	internal Enum0? nullable_17;

	internal Enum19? nullable_18;

	internal Enum10? nullable_19;

	[CompilerGenerated]
	private IList<Class9> ilist_0;

	[CompilerGenerated]
	private Interface4? interface4_0;

	[CompilerGenerated]
	private IEqualityComparer? iequalityComparer_0;

	[CompilerGenerated]
	private Func<Interface5?>? func_0;

	[CompilerGenerated]
	private Interface7? interface7_0;

	[CompilerGenerated]
	private Interface6? interface6_0;

	[CompilerGenerated]
	private EventHandler<EventArgs0>? eventHandler_0;

	public Enum15 ReferenceLoopHandling
	{
		get
		{
			return nullable_15.GetValueOrDefault();
		}
		set
		{
			nullable_15 = value;
		}
	}

	public Enum11 MissingMemberHandling
	{
		get
		{
			return nullable_14.GetValueOrDefault();
		}
		set
		{
			nullable_14 = value;
		}
	}

	public Enum13 ObjectCreationHandling
	{
		get
		{
			return nullable_13.GetValueOrDefault();
		}
		set
		{
			nullable_13 = value;
		}
	}

	public Enum12 NullValueHandling
	{
		get
		{
			return nullable_12.GetValueOrDefault();
		}
		set
		{
			nullable_12 = value;
		}
	}

	public Enum4 DefaultValueHandling
	{
		get
		{
			return nullable_10.GetValueOrDefault();
		}
		set
		{
			nullable_10 = value;
		}
	}

	public IList<Class9> Converters
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		set
		{
			ilist_0 = value;
		}
	}

	public Enum14 PreserveReferencesHandling
	{
		get
		{
			return nullable_11.GetValueOrDefault();
		}
		set
		{
			nullable_11 = value;
		}
	}

	public Enum19 TypeNameHandling
	{
		get
		{
			return nullable_18.GetValueOrDefault();
		}
		set
		{
			nullable_18 = value;
		}
	}

	public Enum10 MetadataPropertyHandling
	{
		get
		{
			return nullable_19.GetValueOrDefault();
		}
		set
		{
			nullable_19 = value;
		}
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		get
		{
			return (FormatterAssemblyStyle)TypeNameAssemblyFormatHandling;
		}
		set
		{
			nullable_9 = (Enum18)value;
		}
	}

	public Enum18 TypeNameAssemblyFormatHandling
	{
		get
		{
			return nullable_9.GetValueOrDefault();
		}
		set
		{
			nullable_9 = value;
		}
	}

	public Enum0 ConstructorHandling
	{
		get
		{
			return nullable_17.GetValueOrDefault();
		}
		set
		{
			nullable_17 = value;
		}
	}

	public Interface4? ContractResolver
	{
		[CompilerGenerated]
		get
		{
			return interface4_0;
		}
		[CompilerGenerated]
		set
		{
			interface4_0 = value;
		}
	}

	public IEqualityComparer? EqualityComparer
	{
		[CompilerGenerated]
		get
		{
			return iequalityComparer_0;
		}
		[CompilerGenerated]
		set
		{
			iequalityComparer_0 = value;
		}
	}

	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public Interface5? ReferenceResolver
	{
		get
		{
			return ReferenceResolverProvider?.Invoke();
		}
		set
		{
			Interface5 interface5_0 = value;
			ReferenceResolverProvider = ((interface5_0 != null) ? ((Func<Interface5>)(() => interface5_0)) : null);
		}
	}

	public Func<Interface5?>? ReferenceResolverProvider
	{
		[CompilerGenerated]
		get
		{
			return func_0;
		}
		[CompilerGenerated]
		set
		{
			func_0 = value;
		}
	}

	public Interface7? TraceWriter
	{
		[CompilerGenerated]
		get
		{
			return interface7_0;
		}
		[CompilerGenerated]
		set
		{
			interface7_0 = value;
		}
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder? Binder
	{
		get
		{
			if (SerializationBinder == null)
			{
				return null;
			}
			if (!(SerializationBinder is Class160 @class))
			{
				throw new InvalidOperationException("Cannot get SerializationBinder because an ISerializationBinder was previously set.");
			}
			return @class.serializationBinder_0;
		}
		set
		{
			SerializationBinder = ((value == null) ? null : new Class160(value));
		}
	}

	public Interface6? SerializationBinder
	{
		[CompilerGenerated]
		get
		{
			return interface6_0;
		}
		[CompilerGenerated]
		set
		{
			interface6_0 = value;
		}
	}

	public EventHandler<EventArgs0>? Error
	{
		[CompilerGenerated]
		get
		{
			return eventHandler_0;
		}
		[CompilerGenerated]
		set
		{
			eventHandler_0 = value;
		}
	}

	public StreamingContext Context
	{
		get
		{
			return nullable_16 ?? streamingContext_0;
		}
		set
		{
			nullable_16 = value;
		}
	}

	public string DateFormatString
	{
		get
		{
			return string_1 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
		}
		set
		{
			string_1 = value;
			bool_2 = true;
		}
	}

	public int? MaxDepth
	{
		get
		{
			if (!bool_1)
			{
				return 64;
			}
			return nullable_8;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Value must be positive.", "value");
			}
			nullable_8 = value;
			bool_1 = true;
		}
	}

	public Enum7 Formatting
	{
		get
		{
			return nullable_0.GetValueOrDefault();
		}
		set
		{
			nullable_0 = value;
		}
	}

	public Enum1 DateFormatHandling
	{
		get
		{
			return nullable_1.GetValueOrDefault();
		}
		set
		{
			nullable_1 = value;
		}
	}

	public Enum3 DateTimeZoneHandling
	{
		get
		{
			return nullable_2 ?? Enum3.const_3;
		}
		set
		{
			nullable_2 = value;
		}
	}

	public Enum2 DateParseHandling
	{
		get
		{
			return nullable_3 ?? Enum2.const_1;
		}
		set
		{
			nullable_3 = value;
		}
	}

	public Enum5 FloatFormatHandling
	{
		get
		{
			return nullable_4.GetValueOrDefault();
		}
		set
		{
			nullable_4 = value;
		}
	}

	public Enum6 FloatParseHandling
	{
		get
		{
			return nullable_5.GetValueOrDefault();
		}
		set
		{
			nullable_5 = value;
		}
	}

	public Enum17 StringEscapeHandling
	{
		get
		{
			return nullable_6.GetValueOrDefault();
		}
		set
		{
			nullable_6 = value;
		}
	}

	public CultureInfo Culture
	{
		get
		{
			return cultureInfo_1 ?? cultureInfo_0;
		}
		set
		{
			cultureInfo_1 = value;
		}
	}

	public bool CheckAdditionalContent
	{
		get
		{
			return nullable_7.GetValueOrDefault();
		}
		set
		{
			nullable_7 = value;
		}
	}

	static Class36()
	{
		streamingContext_0 = default(StreamingContext);
		cultureInfo_0 = CultureInfo.InvariantCulture;
	}

	[DebuggerStepThrough]
	public Class36()
	{
		Converters = new List<Class9>();
	}
}
