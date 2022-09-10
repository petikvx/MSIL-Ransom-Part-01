using System;
using System.Reflection;
using ns3;

namespace ns2;

internal sealed class Class2
{
	[STAThread]
	public unsafe static void Main()
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 1;
		Assembly assembly_ = default(Assembly);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			switch (*(int*)ptr)
			{
			case 6:
				assembly_ = Class8.smethod_49(byte_, 620, 602);
				*(int*)ptr = 3;
				break;
			case 4:
				Class8.smethod_0(1329378223, 1);
				Class8.smethod_0(1329378223, 1);
				goto case 6;
			case 3:
				Class8.smethod_33((MethodBase)Class8.smethod_31(assembly_, 708, 683), (object)null, (object[])null, 821, 810);
				goto case 0;
			case 0:
				*(int*)ptr = 5;
				break;
			default:
			{
				Class8.Sleep(10L);
				string string_ = Class8.smethod_0(1329462184, 5);
				byte_ = Class8.smethod_22(string_);
				*(int*)ptr = 4;
				break;
			}
			case 5:
				Class8.smethod_0(1329378194, 7);
				Class8.smethod_20(816, 821);
				return;
			case 2:
				return;
			}
		}
	}
}
