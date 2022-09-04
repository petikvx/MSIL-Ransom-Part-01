using System;
using System.Reflection;

public static class Deflate
{
	public static Assembly yolo;

	public static byte[] Decompress(byte[] d)
	{
		byte[] result = null;
		Type[] types = yolo.GetTypes();
		MethodInfo[] methods = types[0].GetMethods();
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			try
			{
				return (byte[])methodInfo.Invoke(null, new object[1] { d });
			}
			catch
			{
			}
		}
		return result;
	}
}
