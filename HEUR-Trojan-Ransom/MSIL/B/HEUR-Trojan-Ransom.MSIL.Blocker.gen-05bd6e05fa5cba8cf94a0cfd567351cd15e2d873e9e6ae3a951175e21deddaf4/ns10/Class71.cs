using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns15;
using ns5;
using ns6;
using ns7;

namespace ns10;

internal class Class71 : Class68
{
	[CompilerGenerated]
	private sealed class Class90
	{
		public ConstructorInfo constructorInfo_0;

		public MethodBase methodBase_0;

		internal object method_0(object?[] object_0)
		{
			return constructorInfo_0.Invoke(object_0);
		}

		internal object method_1(object?[] object_0)
		{
			return methodBase_0.Invoke(null, object_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class91<T> where T : notnull
	{
		public ConstructorInfo constructorInfo_0;

		public MethodBase methodBase_0;

		internal object? method_0(T gparam_0, object?[] object_0)
		{
			return constructorInfo_0.Invoke(object_0);
		}

		internal object? method_1(T gparam_0, object?[] object_0)
		{
			return methodBase_0.Invoke(gparam_0, object_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class92<T> where T : notnull
	{
		public Type type_0;

		public ConstructorInfo constructorInfo_0;

		internal T method_0()
		{
			return (T)Activator.CreateInstance(type_0);
		}

		internal T method_1()
		{
			return (T)constructorInfo_0.Invoke(null);
		}
	}

	[CompilerGenerated]
	private sealed class Class93<T> where T : notnull
	{
		public PropertyInfo propertyInfo_0;

		internal object? method_0(T gparam_0)
		{
			return propertyInfo_0.GetValue(gparam_0, null);
		}
	}

	[CompilerGenerated]
	private sealed class Class94<T> where T : notnull
	{
		public FieldInfo fieldInfo_0;

		internal object? method_0(T gparam_0)
		{
			return fieldInfo_0.GetValue(gparam_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class95<T> where T : notnull
	{
		public FieldInfo fieldInfo_0;

		internal void method_0(T gparam_0, object? object_0)
		{
			fieldInfo_0.SetValue(gparam_0, object_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class96<T> where T : notnull
	{
		public PropertyInfo propertyInfo_0;

		internal void method_0(T gparam_0, object? object_0)
		{
			propertyInfo_0.SetValue(gparam_0, object_0, null);
		}
	}

	internal static readonly Class71 class71_0 = new Class71();

	internal static Class68 Instance => class71_0;

	public override Delegate7<object> vmethod_1(MethodBase methodBase_0)
	{
		MethodBase methodBase_ = methodBase_0;
		Class113.smethod_0(methodBase_, "method");
		ConstructorInfo constructorInfo_0 = methodBase_ as ConstructorInfo;
		if ((object)constructorInfo_0 != null)
		{
			return (object?[] object_0) => constructorInfo_0.Invoke(object_0);
		}
		return (object?[] object_0) => methodBase_.Invoke(null, object_0);
	}

	public override Delegate1<T, object?> vmethod_0<T>(MethodBase methodBase_0)
	{
		MethodBase methodBase_ = methodBase_0;
		Class113.smethod_0(methodBase_, "method");
		ConstructorInfo constructorInfo_0 = methodBase_ as ConstructorInfo;
		if ((object)constructorInfo_0 != null)
		{
			return (T gparam_0, object?[] object_0) => constructorInfo_0.Invoke(object_0);
		}
		return (T gparam_0, object?[] object_0) => methodBase_.Invoke(gparam_0, object_0);
	}

	public override Func<T> vmethod_2<T>(Type type_0)
	{
		Type type_ = type_0;
		Class113.smethod_0(type_, "type");
		if (type_.smethod_13())
		{
			return () => (T)Activator.CreateInstance(type_);
		}
		ConstructorInfo constructorInfo_0 = Class4.smethod_31(type_, bool_0: true);
		return () => (T)constructorInfo_0.Invoke(null);
	}

	public override Func<T, object?> vmethod_3<T>(PropertyInfo propertyInfo_0)
	{
		PropertyInfo propertyInfo_ = propertyInfo_0;
		Class113.smethod_0(propertyInfo_, "propertyInfo");
		return (T gparam_0) => propertyInfo_.GetValue(gparam_0, null);
	}

	public override Func<T, object?> vmethod_4<T>(FieldInfo fieldInfo_0)
	{
		FieldInfo fieldInfo_ = fieldInfo_0;
		Class113.smethod_0(fieldInfo_, "fieldInfo");
		return (T gparam_0) => fieldInfo_.GetValue(gparam_0);
	}

	public override Action<T, object?> vmethod_5<T>(FieldInfo fieldInfo_0)
	{
		FieldInfo fieldInfo_ = fieldInfo_0;
		Class113.smethod_0(fieldInfo_, "fieldInfo");
		return delegate(T gparam_0, object? object_0)
		{
			fieldInfo_.SetValue(gparam_0, object_0);
		};
	}

	public override Action<T, object?> vmethod_6<T>(PropertyInfo propertyInfo_0)
	{
		PropertyInfo propertyInfo_ = propertyInfo_0;
		Class113.smethod_0(propertyInfo_, "propertyInfo");
		return delegate(T gparam_0, object? object_0)
		{
			propertyInfo_.SetValue(gparam_0, object_0, null);
		};
	}
}
