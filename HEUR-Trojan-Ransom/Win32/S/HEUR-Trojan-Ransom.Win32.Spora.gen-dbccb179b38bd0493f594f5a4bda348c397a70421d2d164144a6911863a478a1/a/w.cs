using System.Reflection;
using System.Text;
using hospitally.Properties;

namespace a;

internal sealed class w
{
	internal static MethodInfo W()
	{
		return typeof(Encoding).GetMethod(Settings.Default.Setting1, i.C());
	}
}
