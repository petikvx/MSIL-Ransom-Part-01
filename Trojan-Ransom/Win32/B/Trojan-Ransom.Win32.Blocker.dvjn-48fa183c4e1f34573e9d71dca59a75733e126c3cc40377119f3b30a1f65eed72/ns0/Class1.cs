using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.Devices;
using ns10;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class1 : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerHidden]
	public Class1()
	{
	}

	static Class1()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!Class12.StrongNameSignatureVerificationEx_4(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
		{
			throw new SecurityException(Class32.smethod_0(255));
		}
	}

	internal static bool LDXWK77WytwDMTQGx2()
	{
		return true;
	}

	internal static bool THM6n4AHSUnb8JfKDo()
	{
		return false;
	}
}
