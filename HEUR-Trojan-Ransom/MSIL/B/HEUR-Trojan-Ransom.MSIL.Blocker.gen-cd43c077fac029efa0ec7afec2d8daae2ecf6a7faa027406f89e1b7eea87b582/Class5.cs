using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "14.0.0.0")]
internal class Class5 : ApplicationBase
{
	public unsafe Class5()
	{
		//Discarded unreachable code: IL_001d, IL_0029, IL_0033, IL_0037, IL_003e
		//IL_0004: Expected O, but got I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and O
		//IL_0018: Incompatible stack heights: 0 vs 1
		//IL_0024: Expected F4, but got O
		//IL_0023: Expected native int or pointer, but got F8
		//IL_0039: Invalid comparison between Unknown and I
		while (true)
		{
			byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
			IntPtr intPtr = (nint)((Array)1).LongLength;
			((int[])/*Error near IL_0005: Stack underflow*/)[num] = (int)(nint)intPtr;
			if ((object)(/*Error near IL_0006: Stack underflow*/ & /*Error near IL_0006: Stack underflow*/) < this)
			{
				sbyte num2 = ((sbyte[])null)[5];
				*(float*)(int)((uint[])/*Error near IL_0010: Stack underflow*/)[num2] = (float)(ref this);
				checked
				{
					_ = (int)/*Error near IL_0018: Stack underflow*/;
				}
			}
		}
	}
}
