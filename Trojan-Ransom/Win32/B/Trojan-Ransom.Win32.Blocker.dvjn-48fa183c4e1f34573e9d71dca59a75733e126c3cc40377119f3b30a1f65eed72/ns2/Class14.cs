using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.Devices;
using ns10;

namespace ns2;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class14 : Computer
{
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Class14()
	{
	}

	static Class14()
	{
		Assembly executingAssembly = default(Assembly);
		while (true)
		{
			bool bool_ = false;
			if (!ekiV70TDMtjYf6tbE0())
			{
				break;
			}
			switch (1)
			{
			case 0:
			case 3:
				break;
			case 1:
				executingAssembly = Assembly.GetExecutingAssembly();
				goto case 2;
			case 2:
			case 5:
				if (Class12.StrongNameSignatureVerificationEx_13(executingAssembly.Location, bool_0: true, out bool_))
				{
					goto default;
				}
				goto IL_0065;
			default:
				if (bool_ && executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
				{
					return;
				}
				goto IL_0065;
			case 6:
				return;
				IL_0065:
				throw new SecurityException(Class32.smethod_0(255));
			}
		}
	}

	internal static bool ekiV70TDMtjYf6tbE0()
	{
		return true;
	}

	internal static bool oe4gXBbhdwP2XhZCwD()
	{
		return false;
	}
}
