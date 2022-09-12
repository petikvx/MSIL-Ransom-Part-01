using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns19;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace Newtonsoft.Json.Serialization;

public class DefaultContractResolver : Interface4
{
	internal class Class121<T, U> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
	{
		private readonly IEnumerable<KeyValuePair<T, U>> ienumerable_0;

		public Class121(IEnumerable<KeyValuePair<T, U>> ienumerable_1)
		{
			Class113.smethod_0(ienumerable_1, "e");
			ienumerable_0 = ienumerable_1;
		}

		IEnumerator<KeyValuePair<object, object>> IEnumerable<KeyValuePair<object, object>>.GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return new Class122(0)
			{
				class121_0 = this
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EObject_002CSystem_002EObject_003E_003E_002EGetEnumerator();
		}
	}

	[CompilerGenerated]
	private sealed class Class123
	{
		public Class115 class115_0;

		internal string method_0(string string_0)
		{
			return class115_0.vmethod_2(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class124
	{
		public Func<object, object?> func_0;

		public MemberInfo memberInfo_0;
	}

	[CompilerGenerated]
	private sealed class Class125
	{
		public Action<object, object?> action_0;

		public Func<object> func_0;

		public Delegate1<object, object?> delegate1_0;

		public Class124 class124_0;

		internal void method_0(object object_0, string string_0, object? object_1)
		{
			object obj = class124_0.func_0(object_0);
			if (obj == null)
			{
				if (action_0 == null)
				{
					throw new JsonSerializationException("Cannot set value onto extension data member '{0}'. The extension data collection is null and it cannot be set.".smethod_1(CultureInfo.InvariantCulture, class124_0.memberInfo_0.Name));
				}
				obj = func_0();
				action_0(object_0, obj);
			}
			delegate1_0(obj, string_0, object_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class126
	{
		public Delegate7<object> delegate7_0;

		public Class124 class124_0;

		internal IEnumerable<KeyValuePair<object, object>>? method_0(object object_0)
		{
			object obj = class124_0.func_0(object_0);
			if (obj == null)
			{
				return null;
			}
			return (IEnumerable<KeyValuePair<object, object>>)delegate7_0(obj);
		}
	}

	[CompilerGenerated]
	private sealed class Class127
	{
		public Class115 class115_0;

		internal string method_0(string string_0)
		{
			return class115_0.vmethod_2(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class128
	{
		public Class115 class115_0;

		internal string method_0(string string_0)
		{
			return class115_0.vmethod_2(string_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class129
	{
		public Delegate1<object, object?> delegate1_0;

		internal bool method_0(object object_0)
		{
			return (bool)delegate1_0(object_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class130
	{
		public Func<object, object> func_0;

		internal bool method_0(object object_0)
		{
			return (bool)func_0(object_0);
		}
	}

	internal static readonly Interface4 interface4_0 = new DefaultContractResolver();

	private static readonly string[] string_0 = new string[3] { "System.IO.DriveInfo", "System.IO.FileInfo", "System.IO.DirectoryInfo" };

	private static readonly Class9[] class9_0 = new Class9[10]
	{
		new Class21(),
		new Class22(),
		new Class27(),
		new Class11(),
		new Class14(),
		new Class15(),
		new Class20(),
		new Class23(),
		new Class12(),
		new Class24()
	};

	private readonly Class6 class6_0 = new Class6();

	private readonly Class111<Type, Class137> class111_0;

	[CompilerGenerated]
	private BindingFlags bindingFlags_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private Class115? class115_0;

	internal static Interface4 Instance => interface4_0;

	public bool DynamicCodeGeneration => JsonTypeReflector.DynamicCodeGeneration;

	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags
	{
		[CompilerGenerated]
		get
		{
			return bindingFlags_0;
		}
		[CompilerGenerated]
		set
		{
			bindingFlags_0 = value;
		}
	}

	public bool SerializeCompilerGeneratedMembers
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool IgnoreSerializableInterface
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool IgnoreSerializableAttribute
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool IgnoreIsSpecifiedMembers
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public bool IgnoreShouldSerializeMembers
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public Class115? NamingStrategy
	{
		[CompilerGenerated]
		get
		{
			return class115_0;
		}
		[CompilerGenerated]
		set
		{
			class115_0 = value;
		}
	}

	public DefaultContractResolver()
	{
		IgnoreSerializableAttribute = true;
		DefaultMembersSearchFlags = BindingFlags.Instance | BindingFlags.Public;
		class111_0 = new Class111<Type, Class137>(vmethod_12);
	}

	public virtual Class137 imethod_0(Type type_0)
	{
		Class113.smethod_0(type_0, "type");
		return class111_0.method_0(type_0);
	}

	protected virtual List<MemberInfo> vmethod_0(Type type_0)
	{
		Enum9 @enum = Class7.smethod_755(IgnoreSerializableAttribute, type_0);
		IEnumerable<MemberInfo> enumerable = from memberInfo_0 in Class7.smethod_393(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, type_0)
			where !(memberInfo_0 is PropertyInfo propertyInfo_) || !Class7.smethod_670(propertyInfo_)
			select memberInfo_0;
		List<MemberInfo> list = new List<MemberInfo>();
		if (@enum != Enum9.const_2)
		{
			DataContractAttribute dataContractAttribute = Class7.smethod_722(type_0);
			List<MemberInfo> list2 = ((IEnumerable<MemberInfo>)Class7.smethod_393(DefaultMembersSearchFlags, type_0)).Where((Func<MemberInfo, bool>)Class7.smethod_182).ToList();
			foreach (MemberInfo item in enumerable)
			{
				if (SerializeCompilerGeneratedMembers || !item.IsDefined(typeof(CompilerGeneratedAttribute), inherit: true))
				{
					if (list2.Contains(item))
					{
						list.Add(item);
					}
					else if (JsonTypeReflector.smethod_3<Attribute13>(item) != null)
					{
						list.Add(item);
					}
					else if (JsonTypeReflector.smethod_3<Attribute14>(item) != null)
					{
						list.Add(item);
					}
					else if (dataContractAttribute != null && JsonTypeReflector.smethod_3<DataMemberAttribute>(item) != null)
					{
						list.Add(item);
					}
					else if (@enum == Enum9.const_2 && item.smethod_1() == MemberTypes.Field)
					{
						list.Add(item);
					}
				}
			}
			if (type_0.smethod_15("System.Data.Objects.DataClasses.EntityObject", bool_0: false, out var _))
			{
				list = list.Where(method_0).ToList();
			}
			if (typeof(Exception).IsAssignableFrom(type_0))
			{
				list = list.Where((MemberInfo memberInfo_0) => !string.Equals(memberInfo_0.Name, "TargetSite", StringComparison.Ordinal)).ToList();
			}
			return list;
		}
		foreach (MemberInfo item2 in enumerable)
		{
			if (item2 is FieldInfo fieldInfo && !fieldInfo.IsStatic)
			{
				list.Add(item2);
			}
		}
		return list;
	}

	private bool method_0(MemberInfo memberInfo_0)
	{
		if (memberInfo_0 is PropertyInfo propertyInfo && propertyInfo.PropertyType.smethod_4() && propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1")
		{
			return false;
		}
		return true;
	}

	protected virtual Class143 vmethod_1(Type type_0)
	{
		Class143 @class = new Class143(type_0);
		method_1(@class);
		bool ignoreSerializableAttribute = IgnoreSerializableAttribute;
		@class.MemberSerialization = Class7.smethod_755(ignoreSerializableAttribute, @class.type_0);
		@class.Properties.smethod_1(vmethod_13(@class.type_0, @class.MemberSerialization));
		Func<string, string> func = null;
		Attribute8 attribute = JsonTypeReflector.smethod_0<Attribute8>(@class.type_0);
		if (attribute != null)
		{
			@class.ItemRequired = attribute.nullable_5;
			@class.ItemNullValueHandling = attribute.nullable_6;
			@class.MissingMemberHandling = attribute.nullable_4;
			if (attribute.type_1 != null)
			{
				Class115 class115_0 = Class7.smethod_98((Attribute5)attribute);
				func = (string string_0) => class115_0.vmethod_2(string_0);
			}
		}
		if (func == null)
		{
			func = vmethod_18;
		}
		@class.ExtensionDataNameResolver = func;
		if (@class.bool_5)
		{
			ConstructorInfo constructorInfo = Class7.smethod_623(this, @class.type_0);
			if (constructorInfo != null)
			{
				@class.delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo);
				@class.CreatorParameters.smethod_1(vmethod_2(constructorInfo, @class.Properties));
			}
			else if (@class.MemberSerialization == Enum9.const_2)
			{
				if (JsonTypeReflector.FullyTrusted)
				{
					@class.DefaultCreator = @class.method_5;
				}
			}
			else if (@class.DefaultCreator != null && !@class.DefaultCreatorNonPublic)
			{
				if (@class.type_0.smethod_13())
				{
					Type type_ = @class.type_0;
					Class150 properties = @class.Properties;
					ConstructorInfo constructorInfo2 = Class7.smethod_180(properties, type_, this);
					if (constructorInfo2 != null)
					{
						@class.delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo2);
						@class.CreatorParameters.smethod_1(vmethod_2(constructorInfo2, @class.Properties));
					}
				}
			}
			else
			{
				ConstructorInfo constructorInfo3 = Class7.smethod_177(this, @class.type_0);
				if (constructorInfo3 != null)
				{
					@class.delegate7_1 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo3);
					@class.CreatorParameters.smethod_1(vmethod_2(constructorInfo3, @class.Properties));
				}
			}
		}
		MemberInfo memberInfo = Class7.smethod_546(this, @class.type_0);
		if (memberInfo != null)
		{
			smethod_0(@class, memberInfo);
		}
		if (Array.IndexOf<string>(string_0, type_0.FullName) != -1)
		{
			@class.OnSerializingCallbacks.Add((Delegate3)Class7.smethod_216);
		}
		return @class;
	}

	private static void smethod_0(Class143 class143_0, MemberInfo memberInfo_0)
	{
		MemberInfo memberInfo_ = memberInfo_0;
		Attribute11 attribute = ReflectionUtils.smethod_4<Attribute11>(memberInfo_);
		if (attribute == null)
		{
			return;
		}
		Type type = Class7.smethod_632(memberInfo_);
		Class7.smethod_730(type, typeof(IDictionary<, >), out Type type_);
		Type type2 = type_.GetGenericArguments()[0];
		Type type3 = type_.GetGenericArguments()[1];
		Type type_2 = ((!Class7.smethod_316(type, typeof(IDictionary<, >))) ? type : typeof(Dictionary<, >).MakeGenericType(type2, type3));
		Func<object, object?> func_ = JsonTypeReflector.ReflectionDelegateFactory.method_0<object>(memberInfo_);
		if (attribute.ReadData)
		{
			Action<object, object?> action_0 = (Class7.smethod_572(memberInfo_, bool_0: true, bool_1: false) ? JsonTypeReflector.ReflectionDelegateFactory.method_1<object>(memberInfo_) : null);
			Func<object> func_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_2<object>(type_2);
			MethodInfo methodInfo = type.GetProperty("Item", BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[1] { type2 }, null)?.GetSetMethod();
			if (methodInfo == null)
			{
				methodInfo = type_.GetProperty("Item", BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[1] { type2 }, null)?.GetSetMethod();
			}
			Delegate1<object, object?> delegate1_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(methodInfo);
			Delegate5 delegate2 = (class143_0.ExtensionDataSetter = delegate(object object_0, string string_0, object? object_1)
			{
				object obj2 = func_(object_0);
				if (obj2 == null)
				{
					if (action_0 == null)
					{
						throw new JsonSerializationException("Cannot set value onto extension data member '{0}'. The extension data collection is null and it cannot be set.".smethod_1(CultureInfo.InvariantCulture, memberInfo_.Name));
					}
					obj2 = func_0();
					action_0(object_0, obj2);
				}
				delegate1_0(obj2, string_0, object_1);
			});
		}
		if (attribute.WriteData)
		{
			ConstructorInfo methodBase_ = typeof(Class121<, >).MakeGenericType(type2, type3).GetConstructors().First();
			Delegate7<object> delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(methodBase_);
			Delegate6 delegate4 = (class143_0.ExtensionDataGetter = delegate(object object_0)
			{
				object obj = func_(object_0);
				return (obj == null) ? null : ((IEnumerable<KeyValuePair<object, object>>)delegate7_0(obj));
			});
		}
		class143_0.ExtensionDataValueType = type3;
	}

	protected virtual IList<JsonProperty> vmethod_2(ConstructorInfo constructorInfo_0, Class150 class150_0)
	{
		ParameterInfo[] parameters = constructorInfo_0.GetParameters();
		Class150 @class = new Class150(constructorInfo_0.DeclaringType);
		ParameterInfo[] array = parameters;
		foreach (ParameterInfo parameterInfo in array)
		{
			if (parameterInfo.Name == null)
			{
				continue;
			}
			string name = parameterInfo.Name;
			Type parameterType = parameterInfo.ParameterType;
			JsonProperty jsonProperty = Class7.smethod_49(name, parameterType, class150_0, this);
			if (jsonProperty != null || parameterInfo.Name != null)
			{
				JsonProperty jsonProperty2 = vmethod_3(jsonProperty, parameterInfo);
				if (jsonProperty2 != null)
				{
					@class.method_0(jsonProperty2);
				}
			}
		}
		return @class;
	}

	protected virtual JsonProperty vmethod_3(JsonProperty? jsonProperty_0, ParameterInfo parameterInfo_0)
	{
		JsonProperty jsonProperty = new JsonProperty();
		jsonProperty.PropertyType = parameterInfo_0.ParameterType;
		jsonProperty.AttributeProvider = new Class158(parameterInfo_0);
		method_3(jsonProperty, parameterInfo_0, parameterInfo_0.Name, parameterInfo_0.Member.DeclaringType, Enum9.const_0, out var _);
		jsonProperty.Readable = false;
		jsonProperty.Writable = true;
		if (jsonProperty_0 != null)
		{
			jsonProperty.PropertyName = ((jsonProperty.string_0 != parameterInfo_0.Name) ? jsonProperty.string_0 : jsonProperty_0!.string_0);
			jsonProperty.Converter = jsonProperty.Converter ?? jsonProperty_0!.Converter;
			if (!jsonProperty.bool_0 && jsonProperty_0!.bool_0)
			{
				jsonProperty.DefaultValue = jsonProperty_0!.DefaultValue;
			}
			jsonProperty.nullable_0 = jsonProperty.nullable_0 ?? jsonProperty_0!.nullable_0;
			jsonProperty.IsReference = jsonProperty.IsReference ?? jsonProperty_0!.IsReference;
			jsonProperty.NullValueHandling = jsonProperty.NullValueHandling ?? jsonProperty_0!.NullValueHandling;
			jsonProperty.DefaultValueHandling = jsonProperty.DefaultValueHandling ?? jsonProperty_0!.DefaultValueHandling;
			jsonProperty.ReferenceLoopHandling = jsonProperty.ReferenceLoopHandling ?? jsonProperty_0!.ReferenceLoopHandling;
			jsonProperty.ObjectCreationHandling = jsonProperty.ObjectCreationHandling ?? jsonProperty_0!.ObjectCreationHandling;
			jsonProperty.TypeNameHandling = jsonProperty.TypeNameHandling ?? jsonProperty_0!.TypeNameHandling;
		}
		return jsonProperty;
	}

	protected virtual Class9? vmethod_4(Type type_0)
	{
		return Class7.smethod_696((object)type_0);
	}

	private void method_1(Class137 class137_0)
	{
		Attribute5 attribute = JsonTypeReflector.smethod_0<Attribute5>(class137_0.type_0);
		if (attribute != null)
		{
			class137_0.IsReference = attribute.nullable_0;
		}
		else
		{
			DataContractAttribute dataContractAttribute = Class7.smethod_722(class137_0.type_0);
			if (dataContractAttribute != null && dataContractAttribute.IsReference)
			{
				class137_0.IsReference = true;
			}
		}
		class137_0.Converter = vmethod_4(class137_0.type_0);
		IList<Class9> ilist_ = class9_0;
		Type type_ = class137_0.type_0;
		class137_0.InternalConverter = Class7.smethod_612(type_, ilist_);
		if (class137_0.bool_5 && (Class7.smethod_179(class137_0.type_1, bool_0: true) || class137_0.type_1.smethod_13()))
		{
			class137_0.DefaultCreator = Class7.smethod_198(class137_0.type_1, this);
			class137_0.DefaultCreatorNonPublic = !class137_0.type_1.smethod_13() && Class7.smethod_671(class137_0.type_1) == null;
		}
		Class7.smethod_156(this, class137_0, class137_0.type_0);
	}

	internal void method_2(Type type_0, out List<Delegate3>? list_0, out List<Delegate3>? list_1, out List<Delegate3>? list_2, out List<Delegate3>? list_3, out List<Delegate4>? list_4)
	{
		list_0 = null;
		list_1 = null;
		list_2 = null;
		list_3 = null;
		list_4 = null;
		foreach (Type item in Class7.smethod_458(type_0, this))
		{
			MethodInfo methodInfo_ = null;
			MethodInfo methodInfo_2 = null;
			MethodInfo methodInfo_3 = null;
			MethodInfo methodInfo_4 = null;
			MethodInfo methodInfo_5 = null;
			bool flag = Class7.smethod_635(item);
			bool flag2 = Class7.smethod_291(item);
			MethodInfo[] methods = item.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (MethodInfo methodInfo in methods)
			{
				if (!methodInfo.ContainsGenericParameters)
				{
					Type type_ = null;
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (!flag && Class7.smethod_697(methodInfo, parameters, typeof(OnSerializingAttribute), methodInfo_, ref type_))
					{
						list_0 = list_0 ?? new List<Delegate3>();
						list_0!.Add(Class7.smethod_20(methodInfo));
						methodInfo_ = methodInfo;
					}
					if (Class7.smethod_697(methodInfo, parameters, typeof(OnSerializedAttribute), methodInfo_2, ref type_))
					{
						list_1 = list_1 ?? new List<Delegate3>();
						list_1!.Add(Class7.smethod_20(methodInfo));
						methodInfo_2 = methodInfo;
					}
					if (Class7.smethod_697(methodInfo, parameters, typeof(OnDeserializingAttribute), methodInfo_3, ref type_))
					{
						list_2 = list_2 ?? new List<Delegate3>();
						list_2!.Add(Class7.smethod_20(methodInfo));
						methodInfo_3 = methodInfo;
					}
					if (!flag2 && Class7.smethod_697(methodInfo, parameters, typeof(OnDeserializedAttribute), methodInfo_4, ref type_))
					{
						list_3 = list_3 ?? new List<Delegate3>();
						list_3!.Add(Class7.smethod_20(methodInfo));
						methodInfo_4 = methodInfo;
					}
					if (Class7.smethod_697(methodInfo, parameters, typeof(Attribute15), methodInfo_5, ref type_))
					{
						list_4 = list_4 ?? new List<Delegate4>();
						list_4!.Add(Class7.smethod_90(methodInfo));
						methodInfo_5 = methodInfo;
					}
				}
			}
		}
	}

	protected virtual Class140 vmethod_5(Type type_0)
	{
		Class140 @class = new Class140(type_0);
		method_1(@class);
		Attribute5 attribute = JsonTypeReflector.smethod_3<Attribute5>(type_0);
		if (attribute?.type_1 != null)
		{
			Class115 class115_0 = Class7.smethod_98(attribute);
			@class.DictionaryKeyResolver = (string string_0) => class115_0.vmethod_2(string_0);
		}
		else
		{
			@class.DictionaryKeyResolver = vmethod_19;
		}
		ConstructorInfo constructorInfo = Class7.smethod_623(this, @class.type_0);
		if (constructorInfo != null)
		{
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			Type type = ((!(@class.DictionaryKeyType != null) || !(@class.DictionaryValueType != null)) ? typeof(IDictionary) : typeof(IEnumerable<>).MakeGenericType(typeof(KeyValuePair<, >).MakeGenericType(@class.DictionaryKeyType, @class.DictionaryValueType)));
			if (parameters.Length == 0)
			{
				@class.HasParameterizedCreator = false;
			}
			else
			{
				if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
				{
					throw new JsonException("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".smethod_2(CultureInfo.InvariantCulture, @class.UnderlyingType, type));
				}
				@class.HasParameterizedCreator = true;
			}
			@class.delegate7_1 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo);
		}
		return @class;
	}

	protected virtual Class139 vmethod_6(Type type_0)
	{
		Class139 @class = new Class139(type_0);
		method_1(@class);
		ConstructorInfo constructorInfo = Class7.smethod_623(this, @class.type_0);
		if (constructorInfo != null)
		{
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			Type type = ((@class.CollectionItemType != null) ? typeof(IEnumerable<>).MakeGenericType(@class.CollectionItemType) : typeof(IEnumerable));
			if (parameters.Length == 0)
			{
				@class.HasParameterizedCreator = false;
			}
			else
			{
				if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
				{
					throw new JsonException("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".smethod_2(CultureInfo.InvariantCulture, @class.UnderlyingType, type));
				}
				@class.HasParameterizedCreator = true;
			}
			@class.OverrideCreator = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructorInfo);
		}
		return @class;
	}

	protected virtual Class145 vmethod_7(Type type_0)
	{
		Class145 @class = new Class145(type_0);
		method_1(@class);
		return @class;
	}

	protected virtual Class144 vmethod_8(Type type_0)
	{
		Class144 @class = new Class144(type_0);
		method_1(@class);
		return @class;
	}

	protected virtual Class142 vmethod_9(Type type_0)
	{
		Class142 @class = new Class142(type_0);
		method_1(@class);
		if (@class.bool_5)
		{
			ConstructorInfo constructor = @class.type_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, null);
			if (constructor != null)
			{
				Delegate7<object> delegate2 = (@class.ISerializableCreator = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructor));
			}
		}
		return @class;
	}

	protected virtual Class141 vmethod_10(Type type_0)
	{
		Class141 @class = new Class141(type_0);
		method_1(@class);
		Attribute5 attribute = JsonTypeReflector.smethod_3<Attribute5>(type_0);
		if (attribute?.type_1 != null)
		{
			Class115 class115_0 = Class7.smethod_98(attribute);
			@class.PropertyNameResolver = (string string_0) => class115_0.vmethod_2(string_0);
		}
		else
		{
			@class.PropertyNameResolver = vmethod_19;
		}
		@class.Properties.smethod_1(vmethod_13(type_0, Enum9.const_0));
		return @class;
	}

	protected virtual Class146 vmethod_11(Type type_0)
	{
		Class146 @class = new Class146(type_0);
		method_1(@class);
		return @class;
	}

	protected virtual Class137 vmethod_12(Type type_0)
	{
		Type type_ = Class7.smethod_113(type_0);
		if (Class7.smethod_46(type_))
		{
			return vmethod_7(type_0);
		}
		type_ = Class7.smethod_692(type_);
		Attribute5 attribute = JsonTypeReflector.smethod_0<Attribute5>(type_);
		if (attribute is Attribute8)
		{
			return vmethod_1(type_0);
		}
		if (attribute is Attribute6)
		{
			return vmethod_6(type_0);
		}
		if (attribute is Attribute7)
		{
			return vmethod_5(type_0);
		}
		if (!(type_ == typeof(JToken)) && !type_.IsSubclassOf(typeof(JToken)))
		{
			if (Class7.smethod_774(type_))
			{
				return vmethod_5(type_0);
			}
			if (typeof(IEnumerable).IsAssignableFrom(type_))
			{
				return vmethod_6(type_0);
			}
			if (Class7.smethod_143(type_))
			{
				return vmethod_11(type_0);
			}
			if (!IgnoreSerializableInterface && typeof(ISerializable).IsAssignableFrom(type_) && Class7.smethod_217((object)type_))
			{
				return vmethod_9(type_0);
			}
			if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type_))
			{
				return vmethod_10(type_0);
			}
			if (Class7.smethod_430(type_))
			{
				return vmethod_7(type_);
			}
			return vmethod_1(type_0);
		}
		return vmethod_8(type_0);
	}

	protected virtual IList<JsonProperty> vmethod_13(Type type_0, Enum9 enum9_0)
	{
		List<MemberInfo> obj = vmethod_0(type_0) ?? throw new JsonSerializationException("Null collection of serializable members returned.");
		Class6 @class = vmethod_14();
		Class150 class2 = new Class150(type_0);
		foreach (MemberInfo item in obj)
		{
			JsonProperty jsonProperty = vmethod_16(item, enum9_0);
			if (jsonProperty != null)
			{
				lock (@class)
				{
					jsonProperty.PropertyName = Class7.smethod_261(@class, jsonProperty.string_0);
				}
				class2.method_0(jsonProperty);
			}
		}
		return class2.OrderBy((JsonProperty jsonProperty_0) => jsonProperty_0.Order ?? (-1)).ToList();
	}

	internal virtual Class6 vmethod_14()
	{
		return class6_0;
	}

	protected virtual Interface8 vmethod_15(MemberInfo memberInfo_0)
	{
		if (DynamicCodeGeneration)
		{
			return new Class134(memberInfo_0);
		}
		return new Class159(memberInfo_0);
	}

	protected virtual JsonProperty vmethod_16(MemberInfo memberInfo_0, Enum9 enum9_0)
	{
		JsonProperty jsonProperty = new JsonProperty();
		jsonProperty.PropertyType = Class7.smethod_632(memberInfo_0);
		jsonProperty.DeclaringType = memberInfo_0.DeclaringType;
		jsonProperty.ValueProvider = vmethod_15(memberInfo_0);
		jsonProperty.AttributeProvider = new Class158(memberInfo_0);
		method_3(jsonProperty, memberInfo_0, memberInfo_0.Name, memberInfo_0.DeclaringType, enum9_0, out var bool_);
		if (enum9_0 != Enum9.const_2)
		{
			jsonProperty.Readable = Class7.smethod_290(memberInfo_0, bool_);
			jsonProperty.Writable = Class7.smethod_572(memberInfo_0, bool_, jsonProperty.HasMemberAttribute);
		}
		else
		{
			jsonProperty.Readable = true;
			jsonProperty.Writable = true;
		}
		if (!IgnoreShouldSerializeMembers)
		{
			jsonProperty.ShouldSerialize = Class7.smethod_242(this, memberInfo_0);
		}
		if (!IgnoreIsSpecifiedMembers)
		{
			Class7.smethod_619(bool_, memberInfo_0, this, jsonProperty);
		}
		return jsonProperty;
	}

	private void method_3(JsonProperty jsonProperty_0, object object_0, string string_1, Type type_0, Enum9 enum9_0, out bool bool_5)
	{
		DataContractAttribute? dataContractAttribute = Class7.smethod_722(type_0);
		MemberInfo memberInfo = object_0 as MemberInfo;
		DataMemberAttribute dataMemberAttribute = ((dataContractAttribute == null || !(memberInfo != null)) ? null : Class7.smethod_79(memberInfo));
		Attribute13 attribute = JsonTypeReflector.smethod_3<Attribute13>(object_0);
		Attribute14? attribute2 = JsonTypeReflector.smethod_3<Attribute14>(object_0);
		string string_2;
		bool flag;
		if (attribute != null && attribute.PropertyName != null)
		{
			string_2 = attribute.PropertyName;
			flag = true;
		}
		else if (dataMemberAttribute != null && dataMemberAttribute.Name != null)
		{
			string_2 = dataMemberAttribute.Name;
			flag = true;
		}
		else
		{
			string_2 = string_1;
			flag = false;
		}
		Attribute5 attribute3 = JsonTypeReflector.smethod_3<Attribute5>(type_0);
		Class115 @class = ((attribute?.NamingStrategyType != null) ? Class7.smethod_11(attribute.NamingStrategyType, attribute.NamingStrategyParameters) : ((!(attribute3?.type_1 != null)) ? NamingStrategy : Class7.smethod_98(attribute3)));
		if (@class != null)
		{
			jsonProperty_0.PropertyName = @class.vmethod_0(string_2, flag);
		}
		else
		{
			jsonProperty_0.PropertyName = vmethod_17(string_2);
		}
		jsonProperty_0.UnderlyingName = string_1;
		bool flag2 = false;
		if (attribute != null)
		{
			jsonProperty_0.nullable_0 = attribute.nullable_7;
			jsonProperty_0.Order = attribute.nullable_6;
			jsonProperty_0.DefaultValueHandling = attribute.nullable_1;
			flag2 = true;
			jsonProperty_0.NullValueHandling = attribute.nullable_0;
			jsonProperty_0.ReferenceLoopHandling = attribute.nullable_2;
			jsonProperty_0.ObjectCreationHandling = attribute.nullable_3;
			jsonProperty_0.TypeNameHandling = attribute.nullable_4;
			jsonProperty_0.IsReference = attribute.nullable_5;
			jsonProperty_0.ItemIsReference = attribute.nullable_8;
			jsonProperty_0.ItemConverter = ((attribute.ItemConverterType != null) ? Class7.smethod_498(attribute.ItemConverterType, attribute.ItemConverterParameters) : null);
			jsonProperty_0.ItemReferenceLoopHandling = attribute.nullable_9;
			jsonProperty_0.ItemTypeNameHandling = attribute.nullable_10;
		}
		else
		{
			jsonProperty_0.NullValueHandling = null;
			jsonProperty_0.ReferenceLoopHandling = null;
			jsonProperty_0.ObjectCreationHandling = null;
			jsonProperty_0.TypeNameHandling = null;
			jsonProperty_0.IsReference = null;
			jsonProperty_0.ItemIsReference = null;
			jsonProperty_0.ItemConverter = null;
			jsonProperty_0.ItemReferenceLoopHandling = null;
			jsonProperty_0.ItemTypeNameHandling = null;
			if (dataMemberAttribute != null)
			{
				jsonProperty_0.nullable_0 = (dataMemberAttribute.IsRequired ? Enum16.const_1 : Enum16.const_0);
				jsonProperty_0.Order = ((dataMemberAttribute.Order != -1) ? new int?(dataMemberAttribute.Order) : null);
				jsonProperty_0.DefaultValueHandling = ((!dataMemberAttribute.EmitDefaultValue) ? new Enum4?(Enum4.flag_1) : null);
				flag2 = true;
			}
		}
		if (attribute2 != null)
		{
			jsonProperty_0.nullable_0 = Enum16.const_2;
			flag2 = true;
		}
		jsonProperty_0.HasMemberAttribute = flag2;
		bool flag3 = JsonTypeReflector.smethod_3<Attribute12>(object_0) != null || JsonTypeReflector.smethod_3<Attribute11>(object_0) != null || Class7.smethod_401(object_0);
		if (enum9_0 != Enum9.const_1)
		{
			bool flag4 = false;
			flag4 = JsonTypeReflector.smethod_3<IgnoreDataMemberAttribute>(object_0) != null;
			jsonProperty_0.Ignored = flag3 || flag4;
		}
		else
		{
			jsonProperty_0.Ignored = flag3 || !flag2;
		}
		jsonProperty_0.Converter = Class7.smethod_696(object_0);
		DefaultValueAttribute defaultValueAttribute = JsonTypeReflector.smethod_3<DefaultValueAttribute>(object_0);
		if (defaultValueAttribute != null)
		{
			jsonProperty_0.DefaultValue = defaultValueAttribute.Value;
		}
		bool_5 = false;
		if ((DefaultMembersSearchFlags & BindingFlags.NonPublic) == BindingFlags.NonPublic)
		{
			bool_5 = true;
		}
		if (flag2)
		{
			bool_5 = true;
		}
		if (enum9_0 == Enum9.const_2)
		{
			bool_5 = true;
		}
	}

	protected virtual string vmethod_17(string string_1)
	{
		if (NamingStrategy != null)
		{
			return NamingStrategy!.vmethod_0(string_1, bool_3: false);
		}
		return string_1;
	}

	protected virtual string vmethod_18(string string_1)
	{
		if (NamingStrategy != null)
		{
			return NamingStrategy!.vmethod_1(string_1);
		}
		return string_1;
	}

	protected virtual string vmethod_19(string string_1)
	{
		if (NamingStrategy != null)
		{
			return NamingStrategy!.vmethod_2(string_1);
		}
		return vmethod_17(string_1);
	}

	public string method_4(string string_1)
	{
		return vmethod_17(string_1);
	}
}
