using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class1 : Computer
{
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Class1()
	{
		while (true)
		{
			int num = 175713921;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38E49255u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 400306675) ^ -1695639872;
			}
		}
	}
}
