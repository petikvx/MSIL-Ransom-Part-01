using System.Reflection;
using hospitally.Properties;

namespace a;

internal sealed class a
{
	internal static MethodInfo l()
	{
		return typeof(Assembly).GetMethod(Settings.Default.Setting2, Y.c());
	}
}
