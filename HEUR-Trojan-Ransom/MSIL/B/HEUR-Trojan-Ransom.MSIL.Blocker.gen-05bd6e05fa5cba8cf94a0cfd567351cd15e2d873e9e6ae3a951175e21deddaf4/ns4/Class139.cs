using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using ns0;
using ns10;
using ns15;
using ns2;
using ns6;

namespace ns4;

internal class Class139 : Class138
{
	[CompilerGenerated]
	private readonly Type? type_3;

	[CompilerGenerated]
	private readonly bool bool_7;

	private readonly Type? type_4;

	private Type? type_5;

	private Delegate7<object>? delegate7_0;

	private Func<object>? func_1;

	[CompilerGenerated]
	private readonly bool bool_8;

	[CompilerGenerated]
	private readonly bool bool_9;

	[CompilerGenerated]
	private bool bool_10;

	private readonly ConstructorInfo? constructorInfo_0;

	private Delegate7<object>? delegate7_1;

	internal Delegate7<object>? delegate7_2;

	[CompilerGenerated]
	private bool bool_11;

	public Type? CollectionItemType
	{
		[CompilerGenerated]
		get
		{
			return type_3;
		}
	}

	public bool IsMultidimensionalArray
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
	}

	internal bool IsArray
	{
		[CompilerGenerated]
		get
		{
			return bool_8;
		}
	}

	internal bool ShouldCreateWrapper
	{
		[CompilerGenerated]
		get
		{
			return bool_9;
		}
	}

	internal bool CanDeserialize
	{
		[CompilerGenerated]
		get
		{
			return bool_10;
		}
		[CompilerGenerated]
		private set
		{
			bool_10 = value;
		}
	}

	internal Delegate7<object>? ParameterizedCreator
	{
		get
		{
			if (delegate7_1 == null && constructorInfo_0 != null)
			{
				delegate7_1 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo_0);
			}
			return delegate7_1;
		}
	}

	public Delegate7<object>? OverrideCreator
	{
		get
		{
			return delegate7_2;
		}
		set
		{
			delegate7_2 = value;
			CanDeserialize = true;
		}
	}

	public bool HasParameterizedCreator
	{
		[CompilerGenerated]
		get
		{
			return bool_11;
		}
		[CompilerGenerated]
		set
		{
			bool_11 = value;
		}
	}

	internal bool HasParameterizedCreatorInternal
	{
		get
		{
			if (!HasParameterizedCreator && delegate7_1 == null)
			{
				return constructorInfo_0 != null;
			}
			return true;
		}
	}

	public Class139(Type type_6)
		: base(type_6)
	{
		enum26_0 = Enum26.const_2;
		bool_8 = type_1.IsArray || (type_0.smethod_4() && type_0.GetGenericTypeDefinition().FullName == "System.Linq.EmptyPartition`1");
		bool canDeserialize;
		Type type;
		if (IsArray)
		{
			type_3 = Class4.smethod_150(base.UnderlyingType);
			bool_3 = true;
			type_4 = typeof(List<>).MakeGenericType(CollectionItemType);
			canDeserialize = true;
			bool_7 = type_1.IsArray && base.UnderlyingType.GetArrayRank() > 1;
		}
		else if (typeof(IList).IsAssignableFrom(type_0))
		{
			if (Class4.smethod_543(type_0, typeof(ICollection<>), out type_4))
			{
				type_3 = type_4!.GetGenericArguments()[0];
			}
			else
			{
				type_3 = Class4.smethod_150(type_0);
			}
			if (type_0 == typeof(IList))
			{
				base.CreatedType = typeof(List<object>);
			}
			if (CollectionItemType != null)
			{
				constructorInfo_0 = Class4.smethod_260(type_0, CollectionItemType);
			}
			bool_3 = Class4.smethod_415(type_0, typeof(ReadOnlyCollection<>));
			canDeserialize = true;
		}
		else if (Class4.smethod_543(type_0, typeof(ICollection<>), out type_4))
		{
			type_3 = type_4!.GetGenericArguments()[0];
			if (Class4.smethod_192(type_0, typeof(ICollection<>)) || Class4.smethod_192(type_0, typeof(IList<>)))
			{
				base.CreatedType = typeof(List<>).MakeGenericType(CollectionItemType);
			}
			if (Class4.smethod_192(type_0, typeof(ISet<>)))
			{
				base.CreatedType = typeof(HashSet<>).MakeGenericType(CollectionItemType);
			}
			constructorInfo_0 = Class4.smethod_260(type_0, CollectionItemType);
			canDeserialize = true;
			bool_9 = true;
		}
		else if (Class4.smethod_543(type_0, typeof(IEnumerable<>), out type))
		{
			type_3 = type.GetGenericArguments()[0];
			if (Class4.smethod_192(base.UnderlyingType, typeof(IEnumerable<>)))
			{
				base.CreatedType = typeof(List<>).MakeGenericType(CollectionItemType);
			}
			constructorInfo_0 = Class4.smethod_260(type_0, CollectionItemType);
			method_7(type_0);
			if (type_0.smethod_4() && type_0.GetGenericTypeDefinition() == typeof(IEnumerable<>))
			{
				type_4 = type;
				bool_3 = false;
				bool_9 = false;
				canDeserialize = true;
			}
			else
			{
				type_4 = typeof(List<>).MakeGenericType(CollectionItemType);
				bool_3 = true;
				bool_9 = true;
				canDeserialize = HasParameterizedCreatorInternal;
			}
		}
		else
		{
			canDeserialize = false;
			bool_9 = true;
		}
		CanDeserialize = canDeserialize;
		if (CollectionItemType != null)
		{
			Type type2 = type_0;
			Type collectionItemType = CollectionItemType;
			Type createdType = default(Type);
			Delegate7<object> @delegate = default(Delegate7<object>);
			if (Class4.smethod_307(ref createdType, ref @delegate, type2, collectionItemType))
			{
				base.CreatedType = createdType;
				delegate7_1 = @delegate;
				bool_3 = true;
				CanDeserialize = true;
			}
		}
	}

	internal Interface2 method_5(object object_0)
	{
		if (delegate7_0 == null)
		{
			type_5 = typeof(Class47<>).MakeGenericType(CollectionItemType);
			Type type = ((Class4.smethod_415(type_4, typeof(List<>)) || type_4!.GetGenericTypeDefinition() == typeof(IEnumerable<>)) ? typeof(ICollection<>).MakeGenericType(CollectionItemType) : type_4);
			ConstructorInfo constructor = type_5!.GetConstructor(new Type[1] { type });
			delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructor);
		}
		return (Interface2)delegate7_0!(object_0);
	}

	internal IList method_6()
	{
		if (func_1 == null)
		{
			Type type = ((IsMultidimensionalArray || CollectionItemType == null) ? typeof(object) : CollectionItemType);
			Type type2 = typeof(List<>).MakeGenericType(type);
			func_1 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_2<object>(type2);
		}
		return (IList)func_1!();
	}

	private void method_7(Type type_6)
	{
		if (!HasParameterizedCreatorInternal && type_6.Name == "FSharpList`1")
		{
			Class4.smethod_611(type_6.smethod_7());
			delegate7_1 = Class4.smethod_359(FSharpUtils.fsharpUtils_0, CollectionItemType);
		}
	}
}
