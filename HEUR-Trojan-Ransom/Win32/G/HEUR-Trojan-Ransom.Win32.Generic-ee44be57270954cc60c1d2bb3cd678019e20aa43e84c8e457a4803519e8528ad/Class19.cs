using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal sealed class Class19 : SafeHandleZeroOrMinusOneIsInvalid
{
	internal Class19()
		: base(ownsHandle: true)
	{
		while (true)
		{
			int num = -141679934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC70672CAu) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				num = (int)(num2 * 378702666) ^ -1387839517;
			}
		}
	}

	bool SafeHandle.ReleaseHandle()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -628761863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90763E94u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -323386967) ^ 0x34DE0671;
					continue;
				case 1u:
					result = Class17.FindClose(handle);
					num = (int)((num2 * 576390295) ^ 0x5975EE6D);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
