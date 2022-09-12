using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using Newtonsoft.Json.Serialization;
using ns0;
using ns10;
using ns12;
using ns14;
using ns16;
using ns17;
using ns18;
using ns19;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns13;

internal class Class33
{
	internal Enum19 enum19_0;

	internal Enum18 enum18_0;

	internal Enum14 enum14_0;

	internal Enum15 enum15_0;

	internal Enum11 enum11_0;

	internal Enum13 enum13_0;

	internal Enum12 enum12_0;

	internal Enum4 enum4_0;

	internal Enum0 enum0_0;

	internal Enum10 enum10_0;

	internal Class27? class27_0;

	internal Interface4 interface4_0;

	internal Interface7? interface7_0;

	internal IEqualityComparer? iequalityComparer_0;

	internal Interface6 interface6_0;

	internal StreamingContext streamingContext_0;

	internal Interface5? interface5_0;

	internal Enum7? nullable_0;

	internal Enum1? nullable_1;

	internal Enum3? nullable_2;

	internal Enum2? nullable_3;

	internal Enum5? nullable_4;

	internal Enum6? nullable_5;

	internal Enum17? nullable_6;

	internal CultureInfo cultureInfo_0;

	internal int? nullable_7;

	internal bool bool_0;

	internal bool? nullable_8;

	internal string? string_0;

	internal bool bool_1;

	[CompilerGenerated]
	internal EventHandler<EventArgs0>? eventHandler_0;

	public virtual Interface5? ReferenceResolver
	{
		get
		{
			return Class131.smethod_641(this);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "Reference resolver cannot be null.");
			}
			interface5_0 = value;
		}
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public virtual SerializationBinder Binder
	{
		get
		{
			if (interface6_0 is SerializationBinder result)
			{
				return result;
			}
			if (!(interface6_0 is Class160 @class))
			{
				throw new InvalidOperationException("Cannot get SerializationBinder because an ISerializationBinder was previously set.");
			}
			return @class.serializationBinder_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "Serialization binder cannot be null.");
			}
			interface6_0 = (value as Interface6) ?? new Class160(value);
		}
	}

	public virtual Interface6 SerializationBinder
	{
		get
		{
			return interface6_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "Serialization binder cannot be null.");
			}
			interface6_0 = value;
		}
	}

	public virtual Interface7? TraceWriter
	{
		get
		{
			return interface7_0;
		}
		set
		{
			interface7_0 = value;
		}
	}

	public virtual IEqualityComparer? EqualityComparer
	{
		get
		{
			return iequalityComparer_0;
		}
		set
		{
			iequalityComparer_0 = value;
		}
	}

	public virtual Enum19 TypeNameHandling
	{
		get
		{
			return enum19_0;
		}
		set
		{
			if (value < Enum19.flag_0 || value > Enum19.flag_4)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum19_0 = value;
		}
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		get
		{
			return (FormatterAssemblyStyle)enum18_0;
		}
		set
		{
			if (value < FormatterAssemblyStyle.Simple || value > FormatterAssemblyStyle.Full)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum18_0 = (Enum18)value;
		}
	}

	public virtual Enum18 TypeNameAssemblyFormatHandling
	{
		get
		{
			return enum18_0;
		}
		set
		{
			if (value < Enum18.const_0 || value > Enum18.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum18_0 = value;
		}
	}

	public virtual Enum14 PreserveReferencesHandling
	{
		get
		{
			return enum14_0;
		}
		set
		{
			if (value < Enum14.flag_0 || value > Enum14.flag_3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum14_0 = value;
		}
	}

	public virtual Enum15 ReferenceLoopHandling
	{
		get
		{
			return enum15_0;
		}
		set
		{
			if (value < Enum15.const_0 || value > Enum15.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum15_0 = value;
		}
	}

	public virtual Enum11 MissingMemberHandling
	{
		get
		{
			return enum11_0;
		}
		set
		{
			if (value < Enum11.const_0 || value > Enum11.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum11_0 = value;
		}
	}

	public virtual Enum12 NullValueHandling
	{
		get
		{
			return enum12_0;
		}
		set
		{
			if (value < Enum12.const_0 || value > Enum12.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum12_0 = value;
		}
	}

	public virtual Enum4 DefaultValueHandling
	{
		get
		{
			return enum4_0;
		}
		set
		{
			if (value < Enum4.flag_0 || value > Enum4.flag_3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum4_0 = value;
		}
	}

	public virtual Enum13 ObjectCreationHandling
	{
		get
		{
			return enum13_0;
		}
		set
		{
			if (value < Enum13.const_0 || value > Enum13.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum13_0 = value;
		}
	}

	public virtual Enum0 ConstructorHandling
	{
		get
		{
			return enum0_0;
		}
		set
		{
			if (value < Enum0.const_0 || value > Enum0.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum0_0 = value;
		}
	}

	public virtual Enum10 MetadataPropertyHandling
	{
		get
		{
			return enum10_0;
		}
		set
		{
			if (value < Enum10.const_0 || value > Enum10.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum10_0 = value;
		}
	}

	public virtual Class27 Converters
	{
		get
		{
			if (class27_0 == null)
			{
				class27_0 = new Class27();
			}
			return class27_0;
		}
	}

	public virtual Interface4 ContractResolver
	{
		get
		{
			return interface4_0;
		}
		set
		{
			interface4_0 = value ?? DefaultContractResolver.interface4_0;
		}
	}

	public virtual StreamingContext Context
	{
		get
		{
			return streamingContext_0;
		}
		set
		{
			streamingContext_0 = value;
		}
	}

	public virtual Enum7 Formatting
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

	public virtual Enum1 DateFormatHandling
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

	public virtual Enum3 DateTimeZoneHandling
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

	public virtual Enum2 DateParseHandling
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

	public virtual Enum6 FloatParseHandling
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

	public virtual Enum5 FloatFormatHandling
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

	public virtual Enum17 StringEscapeHandling
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

	public virtual string DateFormatString
	{
		get
		{
			return string_0 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
		}
		set
		{
			string_0 = value;
			bool_1 = true;
		}
	}

	public virtual CultureInfo Culture
	{
		get
		{
			return cultureInfo_0 ?? Class35.cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	public virtual int? MaxDepth
	{
		get
		{
			return nullable_7;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Value must be positive.", "value");
			}
			nullable_7 = value;
			bool_0 = true;
		}
	}

	public virtual bool CheckAdditionalContent
	{
		get
		{
			return nullable_8.GetValueOrDefault();
		}
		set
		{
			nullable_8 = value;
		}
	}

	public virtual event EventHandler<EventArgs0>? Error
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs0> eventHandler = eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> value2 = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs0> eventHandler = eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> value2 = (EventHandler<EventArgs0>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Class33()
	{
		enum15_0 = Enum15.const_0;
		enum11_0 = Enum11.const_0;
		enum12_0 = Enum12.const_0;
		enum4_0 = Enum4.flag_0;
		enum13_0 = Enum13.const_0;
		enum14_0 = Enum14.flag_0;
		enum0_0 = Enum0.const_0;
		enum19_0 = Enum19.flag_0;
		enum10_0 = Enum10.const_0;
		streamingContext_0 = Class35.streamingContext_0;
		interface6_0 = Class132.class132_0;
		cultureInfo_0 = Class35.cultureInfo_0;
		interface4_0 = DefaultContractResolver.interface4_0;
	}

	[DebuggerStepThrough]
	public void method_0(TextReader textReader_0, object object_0)
	{
		method_1(new Class29(textReader_0), object_0);
	}

	[DebuggerStepThrough]
	public void method_1(Class28 class28_0, object object_0)
	{
		vmethod_0(class28_0, object_0);
	}

	internal virtual void vmethod_0(Class28 class28_0, object object_0)
	{
		Class112.smethod_0(class28_0, "reader");
		Class112.smethod_0(object_0, "target");
		method_6(class28_0, out var cultureInfo_, out var nullable_, out var nullable_2, out var nullable_3, out var nullable_4, out var string_);
		Class30 @class = ((TraceWriter == null || TraceWriter!.LevelFilter < TraceLevel.Verbose) ? null : Class131.smethod_470(this, class28_0));
		Class131.smethod_154(new JsonSerializerInternalReader(this), @class ?? class28_0, object_0);
		if (@class != null)
		{
			TraceWriter!.imethod_0(TraceLevel.Verbose, Class131.smethod_523(@class), null);
		}
		method_7(class28_0, cultureInfo_, nullable_, nullable_2, nullable_3, nullable_4, string_);
	}

	[DebuggerStepThrough]
	public object? method_2(Class28 class28_0)
	{
		return method_5(class28_0, null);
	}

	[DebuggerStepThrough]
	public object? method_3(TextReader textReader_0, Type type_0)
	{
		return method_5(new Class29(textReader_0), type_0);
	}

	[DebuggerStepThrough]
	public T? method_4<T>(Class28 class28_0)
	{
		return (T)method_5(class28_0, typeof(T));
	}

	[DebuggerStepThrough]
	public object? method_5(Class28 class28_0, Type? type_0)
	{
		return vmethod_1(class28_0, type_0);
	}

	internal virtual object? vmethod_1(Class28 class28_0, Type? type_0)
	{
		Class112.smethod_0(class28_0, "reader");
		method_6(class28_0, out var cultureInfo_, out var nullable_, out var nullable_2, out var nullable_3, out var nullable_4, out var string_);
		Class30 @class = ((TraceWriter == null || TraceWriter!.LevelFilter < TraceLevel.Verbose) ? null : Class131.smethod_470(this, class28_0));
		object? result = new JsonSerializerInternalReader(this).method_2(@class ?? class28_0, type_0, CheckAdditionalContent);
		if (@class != null)
		{
			TraceWriter!.imethod_0(TraceLevel.Verbose, Class131.smethod_523(@class), null);
		}
		method_7(class28_0, cultureInfo_, nullable_, nullable_2, nullable_3, nullable_4, string_);
		return result;
	}

	private void method_6(Class28 class28_0, out CultureInfo? cultureInfo_1, out Enum3? nullable_9, out Enum2? nullable_10, out Enum6? nullable_11, out int? nullable_12, out string? string_1)
	{
		if (cultureInfo_0 != null && !cultureInfo_0.Equals(class28_0.Culture))
		{
			cultureInfo_1 = class28_0.Culture;
			class28_0.Culture = cultureInfo_0;
		}
		else
		{
			cultureInfo_1 = null;
		}
		if (nullable_2.HasValue && class28_0.enum3_0 != nullable_2)
		{
			nullable_9 = class28_0.enum3_0;
			class28_0.DateTimeZoneHandling = nullable_2.GetValueOrDefault();
		}
		else
		{
			nullable_9 = null;
		}
		if (nullable_3.HasValue && class28_0.enum2_0 != nullable_3)
		{
			nullable_10 = class28_0.enum2_0;
			class28_0.DateParseHandling = nullable_3.GetValueOrDefault();
		}
		else
		{
			nullable_10 = null;
		}
		if (nullable_5.HasValue && class28_0.enum6_0 != nullable_5)
		{
			nullable_11 = class28_0.enum6_0;
			class28_0.FloatParseHandling = nullable_5.GetValueOrDefault();
		}
		else
		{
			nullable_11 = null;
		}
		if (bool_0 && class28_0.nullable_0 != nullable_7)
		{
			nullable_12 = class28_0.nullable_0;
			class28_0.MaxDepth = nullable_7;
		}
		else
		{
			nullable_12 = null;
		}
		if (bool_1 && class28_0.string_0 != string_0)
		{
			string_1 = class28_0.string_0;
			class28_0.string_0 = string_0;
		}
		else
		{
			string_1 = null;
		}
		if (class28_0 is Class29 @class && @class.PropertyNameTable == null && interface4_0 is DefaultContractResolver defaultContractResolver)
		{
			@class.PropertyNameTable = defaultContractResolver.vmethod_14();
		}
	}

	private void method_7(Class28 class28_0, CultureInfo? cultureInfo_1, Enum3? nullable_9, Enum2? nullable_10, Enum6? nullable_11, int? nullable_12, string? string_1)
	{
		if (cultureInfo_1 != null)
		{
			class28_0.Culture = cultureInfo_1;
		}
		if (nullable_9.HasValue)
		{
			class28_0.DateTimeZoneHandling = nullable_9.GetValueOrDefault();
		}
		if (nullable_10.HasValue)
		{
			class28_0.DateParseHandling = nullable_10.GetValueOrDefault();
		}
		if (nullable_11.HasValue)
		{
			class28_0.FloatParseHandling = nullable_11.GetValueOrDefault();
		}
		if (bool_0)
		{
			class28_0.MaxDepth = nullable_12;
		}
		if (bool_1)
		{
			class28_0.string_0 = string_1;
		}
		if (class28_0 is Class29 @class && @class.PropertyNameTable != null && interface4_0 is DefaultContractResolver defaultContractResolver && @class.PropertyNameTable == defaultContractResolver.vmethod_14())
		{
			@class.PropertyNameTable = null;
		}
	}

	public void method_8(Class37 class37_0, object? object_0, Type? type_0)
	{
		vmethod_2(class37_0, object_0, type_0);
	}

	internal virtual void vmethod_2(Class37 class37_0, object? object_0, Type? type_0)
	{
		Class112.smethod_0(class37_0, "jsonWriter");
		Enum7? @enum = null;
		if (nullable_0.HasValue && class37_0.enum7_0 != nullable_0)
		{
			@enum = class37_0.enum7_0;
			class37_0.Formatting = nullable_0.GetValueOrDefault();
		}
		Enum1? enum2 = null;
		if (nullable_1.HasValue && class37_0.enum1_0 != nullable_1)
		{
			enum2 = class37_0.enum1_0;
			class37_0.DateFormatHandling = nullable_1.GetValueOrDefault();
		}
		Enum3? enum3 = null;
		if (nullable_2.HasValue && class37_0.enum3_0 != nullable_2)
		{
			enum3 = class37_0.enum3_0;
			class37_0.DateTimeZoneHandling = nullable_2.GetValueOrDefault();
		}
		Enum5? enum4 = null;
		if (nullable_4.HasValue && class37_0.enum5_0 != nullable_4)
		{
			enum4 = class37_0.enum5_0;
			class37_0.FloatFormatHandling = nullable_4.GetValueOrDefault();
		}
		Enum17? enum5 = null;
		if (nullable_6.HasValue && class37_0.enum17_0 != nullable_6)
		{
			enum5 = class37_0.enum17_0;
			class37_0.StringEscapeHandling = nullable_6.GetValueOrDefault();
		}
		CultureInfo cultureInfo = null;
		if (cultureInfo_0 != null && !cultureInfo_0.Equals(class37_0.Culture))
		{
			cultureInfo = class37_0.Culture;
			class37_0.cultureInfo_0 = cultureInfo_0;
		}
		string dateFormatString = null;
		if (bool_1 && class37_0.DateFormatString != string_0)
		{
			dateFormatString = class37_0.DateFormatString;
			class37_0.DateFormatString = string_0;
		}
		Class39 @class = ((TraceWriter == null || TraceWriter!.LevelFilter < TraceLevel.Verbose) ? null : new Class39(class37_0));
		new Class152(this).method_1(@class ?? class37_0, object_0, type_0);
		if (@class != null)
		{
			TraceWriter!.imethod_0(TraceLevel.Verbose, Class131.smethod_636(@class), null);
		}
		if (@enum.HasValue)
		{
			class37_0.Formatting = @enum.GetValueOrDefault();
		}
		if (enum2.HasValue)
		{
			class37_0.DateFormatHandling = enum2.GetValueOrDefault();
		}
		if (enum3.HasValue)
		{
			class37_0.DateTimeZoneHandling = enum3.GetValueOrDefault();
		}
		if (enum4.HasValue)
		{
			class37_0.FloatFormatHandling = enum4.GetValueOrDefault();
		}
		if (enum5.HasValue)
		{
			class37_0.StringEscapeHandling = enum5.GetValueOrDefault();
		}
		if (bool_1)
		{
			class37_0.DateFormatString = dateFormatString;
		}
		if (cultureInfo != null)
		{
			class37_0.cultureInfo_0 = cultureInfo;
		}
	}
}
