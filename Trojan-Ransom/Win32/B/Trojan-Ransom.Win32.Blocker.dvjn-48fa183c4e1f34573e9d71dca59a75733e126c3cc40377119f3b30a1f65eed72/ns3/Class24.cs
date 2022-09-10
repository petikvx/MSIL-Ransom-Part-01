using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace ns3;

[StandardModule]
internal sealed class Class24
{
	static Class24()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!Class12.StrongNameSignatureVerificationEx_8(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
		{
			throw new SecurityException(Class32.smethod_0(255));
		}
	}

	internal static bool NsE1C5a8AQhHPnjiKBg()
	{
		return true;
	}

	internal static bool e0SvD9aEusy0AEAIT4F()
	{
		return false;
	}
}
