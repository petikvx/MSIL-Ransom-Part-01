using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

internal class Class84
{
	private delegate string Delegate8();

	private class Class85
	{
		private static readonly Delegate8 delegate8_0;

		internal static readonly Class85 class85_0;

		internal int[] int_0;

		internal long[] long_0;

		internal float[] float_0;

		internal double[] double_0;

		static Class85()
		{
			delegate8_0 = smethod_5;
			class85_0 = new Class85();
		}

		private Class85()
		{
			Stream stream_ = Class90.smethod_0(Assembly.GetExecutingAssembly().GetManifestResourceStream(delegate8_0()));
			method_0(stream_);
		}

		private void method_0(Stream stream_0)
		{
			BinaryReader binaryReader = new BinaryReader(stream_0);
			int num = binaryReader.ReadInt32() ^ 0xEB4C523;
			if (num > 0)
			{
				int_0 = new int[num];
				while (--num >= 0)
				{
					int_0[num] = binaryReader.ReadInt32() ^ 0x7252BFC9;
				}
			}
			num = binaryReader.ReadInt32() ^ 0x6B60CDD2;
			while (num > 0)
			{
				long_0 = new long[num];
				while (--num >= 0)
				{
					long_0[num] = binaryReader.ReadInt64() ^ 0x1E8AA13CL;
				}
			}
			num = binaryReader.ReadInt32() ^ 0x68CC95C1;
			while (num > 0)
			{
				float_0 = new float[num];
				while (--num >= 0)
				{
					float_0[num] = binaryReader.ReadSingle();
				}
			}
			num = binaryReader.ReadInt32() ^ 0x58603A03;
			while (num > 0)
			{
				double_0 = new double[num];
				while (--num >= 0)
				{
					double_0[num] = binaryReader.ReadDouble();
				}
			}
		}

		internal static Array smethod_0(byte[] byte_0)
		{
			MemoryStream stream_ = new MemoryStream(byte_0);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			Stream stream = Class90.smethod_0(stream_);
			try
			{
				return (Array)binaryFormatter.Deserialize(stream);
			}
			finally
			{
				if (stream != null || 1 == 0)
				{
					((IDisposable)stream).Dispose();
				}
			}
		}
	}

	public static int smethod_0(int int_0)
	{
		return Class85.class85_0.int_0[int_0];
	}

	public static long smethod_1(int int_0)
	{
		return Class85.class85_0.long_0[int_0];
	}

	public static float smethod_2(int int_0)
	{
		return Class85.class85_0.float_0[int_0];
	}

	public static double smethod_3(int int_0)
	{
		return Class85.class85_0.double_0[int_0];
	}

	public static Array smethod_4(byte[] byte_0)
	{
		return Class85.smethod_0(byte_0);
	}

	public static string smethod_5()
	{
		char[] array = "+\u0011\u001e\u001f".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x58u);
		}
		return new string(array);
	}
}
