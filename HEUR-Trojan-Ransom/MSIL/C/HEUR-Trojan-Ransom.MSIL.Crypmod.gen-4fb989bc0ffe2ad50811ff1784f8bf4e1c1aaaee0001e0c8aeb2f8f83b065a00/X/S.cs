using System.Reflection;
using System.Windows.Forms;

namespace X;

internal sealed class S : ButtonBase
{
	internal static string smethod_0()
	{
		return Assembly.GetExecutingAssembly().GetName().Name + ".Properties.Resources";
	}
}
