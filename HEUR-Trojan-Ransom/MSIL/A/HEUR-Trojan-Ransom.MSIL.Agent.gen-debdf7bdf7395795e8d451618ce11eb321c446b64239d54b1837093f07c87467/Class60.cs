using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

internal class Class60
{
	internal unsafe static be6c394c d28b9c53(Module module_0)
	{
		if (!Class0.ed4cb10e)
		{
			throw new PlatformNotSupportedException();
		}
		byte* pByte_ = (byte*)(void*)Marshal.GetHINSTANCE(module_0);
		string fullyQualifiedName = module_0.FullyQualifiedName;
		if (fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<')
		{
			return new be6c394c(module_0, smethod_0(pByte_));
		}
		return new be6c394c(module_0, d1e9f596(pByte_));
	}

	private unsafe static void* d1e9f596(byte* pByte_0)
	{
		byte* ptr = pByte_0 + 60;
		ptr = pByte_0 + (uint)(*(int*)ptr);
		ptr += 6;
		ptr += 14;
		ushort num = *(ushort*)ptr;
		ptr = ptr + 4 + (int)num;
		byte* ptr2 = pByte_0 + (uint)(*(int*)(ptr - 16));
		byte* ptr3 = pByte_0 + (uint)(*(int*)(ptr2 + 8));
		ptr3 += 12;
		ptr3 += (uint)(*(int*)ptr3);
		ptr3 = (byte*)(((ulong)ptr3 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
		ptr3 += 2;
		ushort num2 = *ptr3;
		ptr3 += 2;
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = 0;
		uint num4;
		uint uint_;
		while (true)
		{
			if (num3 < num2)
			{
				num4 = *(uint*)ptr3;
				uint_ = *(uint*)(ptr3 + 4);
				ptr3 += 8;
				stringBuilder.Length = 0;
				for (int i = 0; i < 8; i++)
				{
					stringBuilder.Append((char)(*(ptr3++)));
					if (*ptr3 != 0)
					{
						stringBuilder.Append((char)(*(ptr3++)));
						if (*ptr3 != 0)
						{
							stringBuilder.Append((char)(*(ptr3++)));
							if (*ptr3 != 0)
							{
								stringBuilder.Append((char)(*(ptr3++)));
								if (*ptr3 == 0)
								{
									break;
								}
								continue;
							}
							ptr3++;
							break;
						}
						ptr3 += 2;
						break;
					}
					ptr3 += 3;
					break;
				}
				if (stringBuilder.ToString() == "#DNG")
				{
					break;
				}
				num3++;
				continue;
			}
			return null;
		}
		return b456c337(pByte_0 + (uint)(*(int*)(ptr2 + 8)) + num4, uint_);
	}

	private unsafe static void* smethod_0(byte* pByte_0)
	{
		byte* ptr = pByte_0 + 60;
		ptr = pByte_0 + (uint)(*(int*)ptr);
		ptr += 6;
		ushort num = *(ushort*)ptr;
		ptr += 14;
		ushort num2 = *(ushort*)ptr;
		ptr = ptr + 4 + (int)num2;
		uint num3 = *(uint*)(ptr - 16);
		uint[] array = new uint[num];
		uint[] array2 = new uint[num];
		uint[] array3 = new uint[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = *(uint*)(ptr + 12);
			array2[i] = *(uint*)(ptr + 8);
			array3[i] = *(uint*)(ptr + 20);
			ptr += 40;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[j] <= num3 && num3 < array[j] + array2[j])
			{
				num3 = num3 - array[j] + array3[j];
				break;
			}
		}
		byte* ptr2 = pByte_0 + num3;
		uint num4 = *(uint*)(ptr2 + 8);
		for (int k = 0; k < num; k++)
		{
			if (array[k] <= num4 && num4 < array[k] + array2[k])
			{
				num4 = num4 - array[k] + array3[k];
				break;
			}
		}
		byte* ptr3 = pByte_0 + num4;
		ptr3 += 12;
		ptr3 += (uint)(*(int*)ptr3);
		ptr3 = (byte*)(((ulong)ptr3 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
		ptr3 += 2;
		ushort num5 = *ptr3;
		ptr3 += 2;
		StringBuilder stringBuilder = new StringBuilder();
		int num6 = 0;
		uint num7;
		uint uint_;
		while (true)
		{
			if (num6 < num5)
			{
				num7 = *(uint*)ptr3;
				uint_ = *(uint*)(ptr3 + 4);
				stringBuilder.Length = 0;
				ptr3 += 8;
				for (int l = 0; l < 8; l++)
				{
					stringBuilder.Append((char)(*(ptr3++)));
					if (*ptr3 != 0)
					{
						stringBuilder.Append((char)(*(ptr3++)));
						if (*ptr3 != 0)
						{
							stringBuilder.Append((char)(*(ptr3++)));
							if (*ptr3 != 0)
							{
								stringBuilder.Append((char)(*(ptr3++)));
								if (*ptr3 == 0)
								{
									break;
								}
								continue;
							}
							ptr3++;
							break;
						}
						ptr3 += 2;
						break;
					}
					ptr3 += 3;
					break;
				}
				if (stringBuilder.ToString() == "#DNG")
				{
					break;
				}
				num6++;
				continue;
			}
			return null;
		}
		return b456c337(pByte_0 + num4 + num7, uint_);
	}

	[DllImport("kernel32.dll")]
	private unsafe static extern void CopyMemory(void* pVoid_0, void* pVoid_1, uint uint_0);

	private unsafe static void* b456c337(void* pVoid_0, uint uint_0)
	{
		void* ptr = (void*)Marshal.AllocHGlobal((int)uint_0);
		CopyMemory(ptr, pVoid_0, uint_0);
		return ptr;
	}
}
