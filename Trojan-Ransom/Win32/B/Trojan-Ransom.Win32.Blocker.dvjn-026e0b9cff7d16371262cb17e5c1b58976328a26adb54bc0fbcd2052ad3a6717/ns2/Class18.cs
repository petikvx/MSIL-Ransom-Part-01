using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2;

[StandardModule]
internal sealed class Class18
{
	static Class18()
	{
		while (true)
		{
			bool bool_ = false;
			while (true)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				while (true)
				{
					IL_004a:
					if (Class17.StrongNameSignatureVerificationEx_3(executingAssembly.Location, bool_0: true, out bool_) && bool_)
					{
						while (executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
						{
							if (dk3aOJFiryFSkCtqsV())
							{
								switch (6)
								{
								case 5:
									goto IL_004a;
								case 1:
								case 4:
									goto end_IL_004a;
								case 0:
								case 3:
									goto end_IL_005c;
								case 6:
									return;
								}
								continue;
							}
							goto IL_004a;
						}
					}
					throw new SecurityException("Assembly has been tampered");
					continue;
					end_IL_004a:
					break;
				}
				continue;
				end_IL_005c:
				break;
			}
		}
	}

	internal static bool dk3aOJFiryFSkCtqsV()
	{
		return true;
	}

	internal static bool BAia0hO0QcK8X2SwKV()
	{
		return false;
	}
}
