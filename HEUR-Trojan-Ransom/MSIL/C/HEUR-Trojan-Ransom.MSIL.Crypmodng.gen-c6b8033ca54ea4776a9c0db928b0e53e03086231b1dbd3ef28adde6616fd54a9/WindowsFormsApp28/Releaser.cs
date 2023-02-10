using System.Reflection;

namespace WindowsFormsApp28;

internal static class Releaser
{
	internal static object FromX()
	{
		return Assembly.Load(Short.Buffo());
	}
}
