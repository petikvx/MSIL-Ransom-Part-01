using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.ApplicationServices;
using ProwxkN4F4ab5Fc8FL;

namespace gvYuiQ7LA45GiTpSI7;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class STrXkHdmHTMs7UIQ8E : ApplicationBase
{
	static STrXkHdmHTMs7UIQ8E()
	{
		while (true)
		{
			bool bool_ = false;
			while (true)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				while (true)
				{
					IL_0039:
					if (StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_))
					{
						while (bool_)
						{
							if (!UZVRwhZ4LY1MGD1RIs())
							{
								goto end_IL_0039;
							}
							switch (1)
							{
							case 6:
								goto IL_0039;
							case 2:
								goto end_IL_0039;
							case 5:
								goto end_IL_004c;
							case 1:
							case 4:
								goto IL_0058;
							case 7:
								return;
							}
							continue;
							IL_0058:
							if (!executingAssembly.FullName!.EndsWith(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(79)))
							{
								break;
							}
							return;
						}
					}
					throw new SecurityException(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(104));
					continue;
					end_IL_0039:
					break;
				}
				continue;
				end_IL_004c:
				break;
			}
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	internal static bool UZVRwhZ4LY1MGD1RIs()
	{
		return true;
	}

	internal static bool eeG1skuSVj2gH2OXWE()
	{
		return false;
	}
}
