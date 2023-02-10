using System.Reflection;

namespace WindowsFormsApp31;

internal static class Releaser
{
	internal static object FromX()
	{
		return Assembly.Load(Short.Buffo());
	}
}
