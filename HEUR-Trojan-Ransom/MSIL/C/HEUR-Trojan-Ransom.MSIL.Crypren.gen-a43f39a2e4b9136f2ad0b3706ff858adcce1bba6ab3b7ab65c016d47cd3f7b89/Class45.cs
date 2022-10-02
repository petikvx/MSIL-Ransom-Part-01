using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

internal class Class45
{
	private delegate string Delegate2();

	private class Class46
	{
		private static readonly Delegate2 delegate2_0;

		internal static readonly Class46 class46_0;

		internal int[] int_0;

		internal long[] long_0;

		internal float[] float_0;

		internal double[] double_0;

		static Class46()
		{
			delegate2_0 = smethod_5;
			class46_0 = new Class46();
		}

		private Class46()
		{
			Stream stream_ = Class51.smethod_0(Assembly.GetExecutingAssembly().GetManifestResourceStream(delegate2_0()));
			method_0(stream_);
		}

		private void method_0(Stream stream_0)
		{
			BinaryReader binaryReader = new BinaryReader(stream_0);
			int num = binaryReader.ReadInt32() ^ 0x7358F3F1;
			if (num > 0)
			{
				int_0 = new int[num];
				while (--num >= 0)
				{
					int_0[num] = binaryReader.ReadInt32() ^ 0x3C77618;
				}
			}
			num = binaryReader.ReadInt32() ^ 0x236D47E4;
			while (num > 0)
			{
				long_0 = new long[num];
				while (--num >= 0)
				{
					long_0[num] = binaryReader.ReadInt64() ^ 0x6A8BE27EL;
				}
			}
			num = binaryReader.ReadInt32() ^ 0x61A771E;
			while (num > 0)
			{
				float_0 = new float[num];
				while (--num >= 0)
				{
					float_0[num] = binaryReader.ReadSingle();
				}
			}
			num = binaryReader.ReadInt32() ^ 0x4E00C873;
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
			Stream stream = Class51.smethod_0(stream_);
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
		return Class46.class46_0.int_0[int_0];
	}

	public static long smethod_1(int int_0)
	{
		return Class46.class46_0.long_0[int_0];
	}

	public static float smethod_2(int int_0)
	{
		return Class46.class46_0.float_0[int_0];
	}

	public static double smethod_3(int int_0)
	{
		return Class46.class46_0.double_0[int_0];
	}

	public static Array smethod_4(byte[] byte_0)
	{
		return Class46.smethod_0(byte_0);
	}

	public static string smethod_5()
	{
		char[] array = "ÑÁÿøê".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x88u);
		}
		return new string(array);
	}
}
