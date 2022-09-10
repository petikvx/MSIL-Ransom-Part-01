using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

internal class Class43
{
	private delegate string Delegate3();

	private class Class44
	{
		private static readonly Delegate3 delegate3_0;

		internal static readonly Class44 class44_0;

		internal int[] int_0;

		internal long[] long_0;

		internal float[] float_0;

		internal double[] double_0;

		static Class44()
		{
			delegate3_0 = smethod_5;
			class44_0 = new Class44();
		}

		private Class44()
		{
			Stream stream_ = Class47.smethod_0(Assembly.GetExecutingAssembly().GetManifestResourceStream(delegate3_0()));
			method_0(stream_);
		}

		private void method_0(Stream stream_0)
		{
			BinaryReader binaryReader = new BinaryReader(stream_0);
			int num = binaryReader.ReadInt32() ^ 0x24CBAD83;
			if (num > 0)
			{
				int_0 = new int[num];
				while (--num >= 0)
				{
					int_0[num] = binaryReader.ReadInt32() ^ 0x172CB22C;
				}
			}
			num = binaryReader.ReadInt32() ^ 0x7C92FC36;
			while (num > 0)
			{
				long_0 = new long[num];
				while (--num >= 0)
				{
					long_0[num] = binaryReader.ReadInt64() ^ 0x3E89BF6FL;
				}
			}
			num = binaryReader.ReadInt32() ^ 0x1877BAA2;
			while (num > 0)
			{
				float_0 = new float[num];
				while (--num >= 0)
				{
					float_0[num] = binaryReader.ReadSingle();
				}
			}
			num = binaryReader.ReadInt32() ^ 0x4B6D7403;
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
			Stream stream = Class47.smethod_0(stream_);
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
		return Class44.class44_0.int_0[int_0];
	}

	public static long smethod_1(int int_0)
	{
		return Class44.class44_0.long_0[int_0];
	}

	public static float smethod_2(int int_0)
	{
		return Class44.class44_0.float_0[int_0];
	}

	public static double smethod_3(int int_0)
	{
		return Class44.class44_0.double_0[int_0];
	}

	public static Array smethod_4(byte[] byte_0)
	{
		return Class44.smethod_0(byte_0);
	}

	public static string smethod_5()
	{
		char[] array = "\u0005$\n3\u0015".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x5Du);
		}
		return new string(array);
	}
}
