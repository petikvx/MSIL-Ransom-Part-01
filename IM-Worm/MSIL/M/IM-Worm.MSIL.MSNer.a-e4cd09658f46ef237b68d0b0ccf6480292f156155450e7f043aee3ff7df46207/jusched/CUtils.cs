using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace jusched;

public class CUtils
{
	[DebuggerNonUserCode]
	public CUtils()
	{
	}

	protected string CopyString(IntPtr ptr)
	{
		return Marshal.PtrToStringUni(ptr);
	}

	protected int getStrLengthA(byte[] str)
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			while (true)
			{
				if (num2 < str.Length)
				{
					byte b = str[num2];
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
