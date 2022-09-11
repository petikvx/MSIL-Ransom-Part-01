using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.Devices;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class Class1 : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerHidden]
	public Class1()
	{
	}

	static Class1()
	{
		Assembly executingAssembly = default(Assembly);
		while (true)
		{
			bool bool_ = false;
			if (E674xY0ppCXR1nf9WY())
			{
			}
			switch (5)
			{
			case 0:
			case 4:
				break;
			case 5:
				executingAssembly = Assembly.GetExecutingAssembly();
				if (Class17.StrongNameSignatureVerificationEx_4(executingAssembly.Location, bool_0: true, out bool_))
				{
					goto case 1;
				}
				goto IL_005d;
			case 1:
			case 2:
				if (bool_)
				{
					goto default;
				}
				goto IL_005d;
			default:
				if (executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
				{
					return;
				}
				goto IL_005d;
			case 6:
				return;
				IL_005d:
				throw new SecurityException("Assembly has been tampered");
			}
		}
	}

	internal static bool oUZ3mBWTuBSduIhPiW()
	{
		return true;
	}

	internal static bool E674xY0ppCXR1nf9WY()
	{
		return false;
	}
}
