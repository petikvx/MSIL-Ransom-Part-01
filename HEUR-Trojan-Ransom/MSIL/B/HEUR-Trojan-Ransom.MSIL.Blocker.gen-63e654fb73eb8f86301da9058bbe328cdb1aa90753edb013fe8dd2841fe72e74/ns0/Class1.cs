using System;
using System.Configuration;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;
using System.Web;
using ns1;

namespace ns0;

internal static class Class1
{
	private static volatile PermissionSet permissionSet_0;

	private static readonly ReflectionPermission reflectionPermission_0 = new ReflectionPermission((ReflectionPermissionFlag)2);

	private static readonly AspNetHostingPermission aspNetHostingPermission_0 = new AspNetHostingPermission((AspNetHostingPermissionLevel)200);

	internal static bool Boolean_0
	{
		get
		{
			bool result = false;
			try
			{
				if (permissionSet_0 == null)
				{
					permissionSet_0 = new PermissionSet(PermissionState.Unrestricted);
				}
				permissionSet_0.Demand();
				result = true;
				return result;
			}
			catch
			{
				return result;
			}
		}
	}

	private static Type smethod_0(string string_0)
	{
		Type result = null;
		try
		{
			result = typeof(ConfigurationException).Assembly.GetType(string_0, throwOnError: false);
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static Type smethod_1(string string_0, bool bool_0)
	{
		Type type = null;
		Exception ex = null;
		try
		{
			type = Type.GetType(string_0, bool_0);
		}
		catch (Exception ex2)
		{
			ex = ex2;
		}
		if (type == null)
		{
			type = smethod_0(string_0);
			if (type == null && ex != null)
			{
				throw ex;
			}
		}
		return type;
	}

	internal static Type smethod_2(IInternalConfigHost iinternalConfigHost_0, string string_0, bool bool_0)
	{
		Type type = null;
		Exception ex = null;
		try
		{
			type = iinternalConfigHost_0.imethod_30(string_0, bool_0);
		}
		catch (Exception ex2)
		{
			ex = ex2;
		}
		if (type == null)
		{
			type = smethod_0(string_0);
			if (type == null && ex != null)
			{
				throw ex;
			}
		}
		return type;
	}

	internal static void smethod_3(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			LXComboBox.smethod_0(byte_0, byte_1, i);
		}
	}

	internal static Type smethod_4(string string_0, bool bool_0)
	{
		return smethod_1(string_0, bool_0);
	}

	internal static T smethod_5<T>(string string_0)
	{
		return smethod_6<T>(null, string_0);
	}

	internal static T smethod_6<T>(Type type_0, string string_0)
	{
		Type type_ = smethod_1(string_0, bool_0: true);
		smethod_16(typeof(T), type_, bool_0: true);
		return (T)smethod_8(type_0, type_);
	}

	internal static object smethod_7(Type type_0)
	{
		return Activator.CreateInstance(type_0, nonPublic: true);
	}

	internal static object smethod_8(Type type_0, Type type_1)
	{
		if (smethod_18())
		{
			return smethod_7(type_1);
		}
		DynamicMethod dynamicMethod = smethod_10(type_0, typeof(object), new Type[1] { typeof(Type) });
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldc_I4_1);
		iLGenerator.Emit(OpCodes.Call, typeof(Activator).GetMethod("", new Type[2]
		{
			typeof(Type),
			typeof(bool)
		}));
		smethod_12(iLGenerator);
		iLGenerator.Emit(OpCodes.Ret);
		return ((Func<Type, object>)dynamicMethod.CreateDelegate(typeof(Func<Type, object>)))(type_1);
	}

	internal static Delegate smethod_9(Type type_0, Type type_1, MethodInfo methodInfo_0)
	{
		if (smethod_18())
		{
			return Delegate.CreateDelegate(type_1, methodInfo_0);
		}
		DynamicMethod dynamicMethod = smethod_10(type_0, typeof(Delegate), new Type[2]
		{
			typeof(Type),
			typeof(MethodInfo)
		});
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Call, typeof(Delegate).GetMethod("", new Type[2]
		{
			typeof(Type),
			typeof(MethodInfo)
		}));
		smethod_12(iLGenerator);
		iLGenerator.Emit(OpCodes.Ret);
		return ((Func<Type, MethodInfo, Delegate>)dynamicMethod.CreateDelegate(typeof(Func<Type, MethodInfo, Delegate>)))(type_1, methodInfo_0);
	}

	private static DynamicMethod smethod_10(Type type_0, Type type_1, Type[] type_2)
	{
		if (type_0 != null)
		{
			return smethod_11(type_0, type_1, type_2);
		}
		return new DynamicMethod("", type_1, type_2);
	}

	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private static DynamicMethod smethod_11(Type type_0, Type type_1, Type[] type_2)
	{
		return new DynamicMethod("", type_1, type_2, type_0);
	}

	private static void smethod_12(ILGenerator ilgenerator_0)
	{
		ilgenerator_0.Emit(OpCodes.Volatile);
		ilgenerator_0.Emit(OpCodes.Ldsfld, typeof(string).GetField(""));
		ilgenerator_0.Emit(OpCodes.Pop);
	}

	internal static ConstructorInfo smethod_13(Type type_0, Type type_1, bool bool_0)
	{
		type_0 = smethod_16(type_1, type_0, bool_0);
		if (type_0 == null)
		{
			return null;
		}
		ConstructorInfo? constructor = type_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.HasThis, Type.EmptyTypes, null);
		if (constructor == null && bool_0)
		{
			throw new TypeLoadException("");
		}
		return constructor;
	}

	internal static object smethod_14(ConstructorInfo constructorInfo_0)
	{
		return constructorInfo_0.Invoke(null);
	}

	internal static bool smethod_15(Type type_0)
	{
		Assembly assembly = type_0.Assembly;
		if (assembly.GlobalAssemblyCache)
		{
			return !smethod_17(assembly);
		}
		return false;
	}

	internal static Type smethod_16(Type type_0, Type type_1, bool bool_0)
	{
		if (type_0.IsAssignableFrom(type_1))
		{
			return type_1;
		}
		if (bool_0)
		{
			throw new TypeLoadException("");
		}
		return null;
	}

	private static bool smethod_17(Assembly assembly_0)
	{
		object[] customAttributes = assembly_0.GetCustomAttributes(typeof(AllowPartiallyTrustedCallersAttribute), inherit: false);
		if (customAttributes != null)
		{
			return customAttributes.Length != 0;
		}
		return false;
	}

	private static bool smethod_18()
	{
		try
		{
			((CodeAccessPermission)reflectionPermission_0).Demand();
			return true;
		}
		catch (SecurityException)
		{
		}
		try
		{
			((CodeAccessPermission)aspNetHostingPermission_0).Demand();
			return true;
		}
		catch (SecurityException)
		{
		}
		return false;
	}

	internal static bool smethod_19(Type type_0)
	{
		if (Boolean_0)
		{
			return true;
		}
		Assembly assembly = type_0.Assembly;
		if (assembly.GlobalAssemblyCache)
		{
			return smethod_17(assembly);
		}
		return true;
	}
}
