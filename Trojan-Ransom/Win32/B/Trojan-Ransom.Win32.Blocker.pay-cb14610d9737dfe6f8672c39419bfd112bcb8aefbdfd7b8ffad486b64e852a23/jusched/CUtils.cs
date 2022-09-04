using System;
using System.Runtime.InteropServices;

namespace jusched;

public class CUtils
{
	protected string CopyString(IntPtr intptr_0)
	{
		return Marshal.PtrToStringUni(intptr_0);
	}

	protected int getStrLengthA(byte[] byte_0)
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			while (true)
			{
				if (num2 < byte_0.Length)
				{
					byte b = byte_0[num2];
					num++;
					if (b == 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return num;
			}
			return num;
		}
	}
}
