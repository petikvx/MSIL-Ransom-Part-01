using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using Newtonsoft.Json.Utilities;
using ns10;
using ns11;
using ns17;
using ns3;
using ns5;
using ns7;
using ns8;

namespace Newtonsoft.Json.Serialization;

internal static class JsonTypeReflector
{
	[CompilerGenerated]
	internal sealed class Class156
	{
		public Type type_0;

		public Func<object> func_0;

		internal object method_0(object[]? object_0)
		{
			try
			{
				if (object_0 != null)
				{
					Type[] types = object_0.Select(delegate(object object_0)
					{
						if (object_0 == null)
						{
							throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
						}
						return object_0.GetType();
					}).ToArray();
					ConstructorInfo constructor = type_0.GetConstructor(types);
					if (constructor != null)
					{
						return ReflectionDelegateFactory.vmethod_1(constructor)(object_0);
					}
					throw new JsonException("No matching parameterized constructor found for '{0}'.".smethod_1(CultureInfo.InvariantCulture, type_0));
				}
				if (func_0 == null)
				{
					throw new JsonException("No parameterless constructor defined for '{0}'.".smethod_1(CultureInfo.InvariantCulture, type_0));
				}
				return func_0();
			}
			catch (Exception innerException)
			{
				throw new JsonException("Error creating '{0}'.".smethod_1(CultureInfo.InvariantCulture, type_0), innerException);
			}
		}
	}

	private static bool? nullable_0;

	private static bool? nullable_1;

	public const string string_0 = "$id";

	public const string string_1 = "$ref";

	public const string string_2 = "$type";

	public const string string_3 = "$value";

	public const string string_4 = "$values";

	public const string string_5 = "ShouldSerialize";

	public const string string_6 = "Specified";

	public const string string_7 = "System.Collections.Concurrent.ConcurrentDictionary`2";

	internal static readonly Class111<Type, Func<object[]?, object>> class111_0 = new Class111<Type, Func<object[], object>>((Func<Type, Func<object[], object>>)Class4.smethod_761);

	internal static readonly Class111<Type, Type?> class111_1 = new Class111<Type, Type>((Func<Type, Type>)Class4.smethod_482);

	internal static Class100? class100_0;

	public static bool DynamicCodeGeneration
	{
		[SecuritySafeCritical]
		get
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			if (!nullable_0.HasValue)
			{
				try
				{
					((CodeAccessPermission)new ReflectionPermission((ReflectionPermissionFlag)2)).Demand();
					((CodeAccessPermission)new ReflectionPermission((ReflectionPermissionFlag)8)).Demand();
					((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.SkipVerification)).Demand();
					((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Demand();
					((CodeAccessPermission)new SecurityPermission(PermissionState.Unrestricted)).Demand();
					nullable_0 = true;
				}
				catch (Exception)
				{
					nullable_0 = false;
				}
			}
			return nullable_0.GetValueOrDefault();
		}
	}

	public static bool FullyTrusted
	{
		get
		{
			if (!nullable_1.HasValue)
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				nullable_1 = currentDomain.IsHomogenous && currentDomain.IsFullyTrusted;
			}
			return nullable_1.GetValueOrDefault();
		}
	}

	public static Class68 ReflectionDelegateFactory
	{
		get
		{
			if (DynamicCodeGeneration)
			{
				return Class69.Instance;
			}
			return Class71.class71_0;
		}
	}

	public static T? smethod_0<T>(object object_0) where T : Attribute
	{
		return Class114<T>.smethod_0(object_0);
	}

	private static T? smethod_1<T>(Type type_0) where T : Attribute
	{
		Type type = Class4.smethod_478(type_0);
		T val;
		if (type != null)
		{
			val = ReflectionUtils.smethod_5<T>(type, bool_0: true);
			if (val != null)
			{
				return val;
			}
		}
		val = ReflectionUtils.smethod_5<T>(type_0, bool_0: true);
		if (val != null)
		{
			return val;
		}
		Type[] interfaces = type_0.GetInterfaces();
		int num = 0;
		while (true)
		{
			if (num < interfaces.Length)
			{
				val = ReflectionUtils.smethod_5<T>(interfaces[num], bool_0: true);
				if (val != null)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return val;
	}

	private static T? smethod_2<T>(MemberInfo memberInfo_0) where T : Attribute
	{
		Type type = Class4.smethod_478(memberInfo_0.DeclaringType);
		T val;
		if (type != null)
		{
			MemberInfo memberInfo = Class4.smethod_405(type, memberInfo_0);
			if (memberInfo != null)
			{
				val = ReflectionUtils.smethod_5<T>(memberInfo, bool_0: true);
				if (val != null)
				{
					return val;
				}
			}
		}
		val = ReflectionUtils.smethod_5<T>(memberInfo_0, bool_0: true);
		if (val != null)
		{
			return val;
		}
		if (memberInfo_0.DeclaringType != null)
		{
			Type[] interfaces = memberInfo_0.DeclaringType!.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				MemberInfo memberInfo2 = Class4.smethod_405(interfaces[i], memberInfo_0);
				if (memberInfo2 != null)
				{
					val = ReflectionUtils.smethod_5<T>(memberInfo2, bool_0: true);
					if (val != null)
					{
						return val;
					}
				}
			}
		}
		return null;
	}

	public static T? smethod_3<T>(object object_0) where T : Attribute
	{
		if (object_0 is Type type_)
		{
			return smethod_1<T>(type_);
		}
		if (object_0 is MemberInfo memberInfo_)
		{
			return smethod_2<T>(memberInfo_);
		}
		return ReflectionUtils.smethod_5<T>(object_0, bool_0: true);
	}
}
