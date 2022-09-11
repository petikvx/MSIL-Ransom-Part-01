using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class0 : ApplicationBase
{
	static Class0()
	{
		while (true)
		{
			bool bool_ = false;
			while (true)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				if (Class17.StrongNameSignatureVerificationEx_6(executingAssembly.Location, bool_0: true, out bool_))
				{
					if (c9kGb1LjZ3FHotuhZR())
					{
					}
					switch (5)
					{
					case 1:
					case 2:
						break;
					case 0:
					case 3:
						goto end_IL_0032;
					case 5:
						if (bool_)
						{
							goto default;
						}
						goto IL_0063;
					default:
						if (executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
						{
							return;
						}
						goto IL_0063;
					case 6:
						return;
					}
					continue;
				}
				goto IL_0063;
				IL_0063:
				throw new SecurityException("Assembly has been tampered");
				continue;
				end_IL_0032:
				break;
			}
		}
	}

	internal static bool OWy2OOwtNWxy6l4HW7()
	{
		return true;
	}

	internal static bool c9kGb1LjZ3FHotuhZR()
	{
		return false;
	}
}
