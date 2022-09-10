using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class0 : Computer
{
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Class0()
	{
		while (true)
		{
			int num = -1860100886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC25180Bu) % 3u)
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
				num = (int)((num2 * 358316905) ^ 0x76B71968);
			}
		}
	}
}
