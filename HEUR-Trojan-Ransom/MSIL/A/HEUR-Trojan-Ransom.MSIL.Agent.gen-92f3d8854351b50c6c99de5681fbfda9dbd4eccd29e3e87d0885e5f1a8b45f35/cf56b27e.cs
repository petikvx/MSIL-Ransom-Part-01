using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Permissions;

internal static class cf56b27e
{
	public static readonly Module bd4237c5;

	static cf56b27e()
	{
		AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("DNGM"), AssemblyBuilderAccess.Run);
		ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DNGM");
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(typeof(SecurityPermissionAttribute).GetConstructor(new Type[1] { typeof(SecurityAction) }), new object[1] { SecurityAction.Assert }, new PropertyInfo[1] { typeof(SecurityPermissionAttribute).GetProperty("SkipVerification") }, new object[1] { true });
		moduleBuilder.SetCustomAttribute(customAttribute);
		bd4237c5 = moduleBuilder.DefineType(" ").CreateType()!.Module;
	}
}
