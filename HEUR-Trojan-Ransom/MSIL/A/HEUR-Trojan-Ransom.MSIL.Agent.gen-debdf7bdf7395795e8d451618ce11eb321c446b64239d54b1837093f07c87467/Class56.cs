using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Permissions;

internal static class Class56
{
	public static readonly Module module_0;

	static Class56()
	{
		AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("DNGM"), AssemblyBuilderAccess.Run);
		ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DNGM");
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(typeof(SecurityPermissionAttribute).GetConstructor(new Type[1] { typeof(SecurityAction) }), new object[1] { SecurityAction.Assert }, new PropertyInfo[1] { typeof(SecurityPermissionAttribute).GetProperty("SkipVerification") }, new object[1] { true });
		moduleBuilder.SetCustomAttribute(customAttribute);
		module_0 = moduleBuilder.DefineType(" ").CreateType()!.Module;
	}
}
