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
			int num = 966205960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3719E981u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -941605670) ^ 0x442DC200;
			}
		}
	}
}
