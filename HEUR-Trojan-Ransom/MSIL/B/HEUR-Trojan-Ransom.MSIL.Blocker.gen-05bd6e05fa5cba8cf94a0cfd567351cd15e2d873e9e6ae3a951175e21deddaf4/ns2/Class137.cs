using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ns10;
using ns12;
using ns15;
using ns5;
using ns7;
using ns8;

namespace ns2;

internal abstract class Class137
{
	[CompilerGenerated]
	internal sealed class Class147
	{
		public MethodInfo methodInfo_0;

		internal void method_0(object object_0, StreamingContext streamingContext_0)
		{
			methodInfo_0.Invoke(object_0, new object[1] { streamingContext_0 });
		}
	}

	[CompilerGenerated]
	internal sealed class Class148
	{
		public MethodInfo methodInfo_0;

		internal void method_0(object object_0, StreamingContext streamingContext_0, Class135 class135_0)
		{
			methodInfo_0.Invoke(object_0, new object[2] { streamingContext_0, class135_0 });
		}
	}

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

	internal Type type_0;

	internal Enum8 enum8_0;

	internal Enum26 enum26_0;

	internal bool bool_3;

	internal bool bool_4;

	internal bool bool_5;

	private List<Delegate3>? list_0;

	private List<Delegate3>? list_1;

	private List<Delegate3>? list_2;

	private List<Delegate3>? list_3;

	private List<Delegate4>? list_4;

	internal Type type_1;

	[CompilerGenerated]
	private readonly Type type_2;

	[CompilerGenerated]
	private bool? nullable_0;

	[CompilerGenerated]
	private Class9? class9_0;

	[CompilerGenerated]
	private Class9? class9_1;

	[CompilerGenerated]
	private Func<object>? func_0;

	[CompilerGenerated]
	private bool bool_6;

	public Type UnderlyingType
	{
		[CompilerGenerated]
		get
		{
			return type_2;
		}
	}

	public Type CreatedType
	{
		get
		{
			return type_1;
		}
		set
		{
			Class113.smethod_0(value, "value");
			type_1 = value;
			bool_4 = type_1.smethod_10();
			bool_5 = !type_1.smethod_3() && !type_1.smethod_11();
		}
	}

	public bool? IsReference
	{
		[CompilerGenerated]
		get
		{
			return nullable_0;
		}
		[CompilerGenerated]
		set
		{
			nullable_0 = value;
		}
	}

	public Class9? Converter
	{
		[CompilerGenerated]
		get
		{
			return class9_0;
		}
		[CompilerGenerated]
		set
		{
			class9_0 = value;
		}
	}

	public Class9? InternalConverter
	{
		[CompilerGenerated]
		get
		{
			return class9_1;
		}
		[CompilerGenerated]
		internal set
		{
			class9_1 = value;
		}
	}

	public IList<Delegate3> OnDeserializedCallbacks
	{
		get
		{
			if (list_0 == null)
			{
				list_0 = new List<Delegate3>();
			}
			return list_0;
		}
	}

	public IList<Delegate3> OnDeserializingCallbacks
	{
		get
		{
			if (list_1 == null)
			{
				list_1 = new List<Delegate3>();
			}
			return list_1;
		}
	}

	public IList<Delegate3> OnSerializedCallbacks
	{
		get
		{
			if (list_2 == null)
			{
				list_2 = new List<Delegate3>();
			}
			return list_2;
		}
	}

	public IList<Delegate3> OnSerializingCallbacks
	{
		get
		{
			if (list_3 == null)
			{
				list_3 = new List<Delegate3>();
			}
			return list_3;
		}
	}

	public IList<Delegate4> OnErrorCallbacks
	{
		get
		{
			if (list_4 == null)
			{
				list_4 = new List<Delegate4>();
			}
			return list_4;
		}
	}

	public Func<object>? DefaultCreator
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

	public bool DefaultCreatorNonPublic
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	internal Class137(Type type_3)
	{
		Class113.smethod_0(type_3, "underlyingType");
		type_2 = type_3;
		type_3 = Class4.smethod_277(type_3);
		bool_0 = Class4.smethod_753(type_3);
		type_0 = ((!bool_0 || !Class4.smethod_92(type_3)) ? type_3 : Nullable.GetUnderlyingType(type_3));
		type_1 = (CreatedType = type_0);
		bool_1 = Class4.smethod_375(type_0);
		bool_2 = type_0.smethod_8();
		enum8_0 = Enum8.const_0;
	}

	internal void method_0(object object_0, StreamingContext streamingContext_0)
	{
		if (list_3 == null)
		{
			return;
		}
		foreach (Delegate3 item in list_3!)
		{
			item(object_0, streamingContext_0);
		}
	}

	internal void method_1(object object_0, StreamingContext streamingContext_0)
	{
		if (list_2 == null)
		{
			return;
		}
		foreach (Delegate3 item in list_2!)
		{
			item(object_0, streamingContext_0);
		}
	}

	internal void method_2(object object_0, StreamingContext streamingContext_0)
	{
		if (list_1 == null)
		{
			return;
		}
		foreach (Delegate3 item in list_1!)
		{
			item(object_0, streamingContext_0);
		}
	}

	internal void method_3(object object_0, StreamingContext streamingContext_0)
	{
		if (list_0 == null)
		{
			return;
		}
		foreach (Delegate3 item in list_0!)
		{
			item(object_0, streamingContext_0);
		}
	}

	internal void method_4(object object_0, StreamingContext streamingContext_0, Class135 class135_0)
	{
		if (list_4 == null)
		{
			return;
		}
		foreach (Delegate4 item in list_4!)
		{
			item(object_0, streamingContext_0, class135_0);
		}
	}
}
