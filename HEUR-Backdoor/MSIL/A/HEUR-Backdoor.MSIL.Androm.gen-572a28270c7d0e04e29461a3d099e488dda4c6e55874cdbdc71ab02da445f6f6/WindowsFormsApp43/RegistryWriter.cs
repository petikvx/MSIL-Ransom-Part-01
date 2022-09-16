using System;
using System.Reflection;

namespace WindowsFormsApp43;

internal class RegistryWriter
{
	internal static RegistryWriter SetSingleton;

	internal void DestroyEvent()
	{
		MethodInfo method = new ServerFacadePool().EnableEvent();
		((Action)Delegate.CreateDelegate(typeof(Action), method))();
	}

	internal static bool CollectSingleton()
	{
		return SetSingleton == null;
	}

	internal static RegistryWriter ReflectSingleton()
	{
		return SetSingleton;
	}
}
