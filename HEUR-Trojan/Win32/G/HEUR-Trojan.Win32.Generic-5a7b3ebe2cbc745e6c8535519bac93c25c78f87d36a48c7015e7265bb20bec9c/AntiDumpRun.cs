using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

internal class AntiDumpRun
{
	private enum MemoryProtection
	{
		ExecuteReadWrite = 0x40
	}

	private unsafe static void BestPasteNigga(void* startAddress, byte value, uint byteCount)
	{
	}

	private unsafe static void EtherShieldOnTopNigga(void* destination, void* source, uint byteCount)
	{
	}

	public unsafe static void Initialize()
	{
		while (true)
		{
			Thread.Sleep(10);
			Module module = typeof(AntiDumpRun).Module;
			byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
			byte* ptr2 = ptr + 60;
			ptr2 = ptr + *ptr2;
			ptr2 += 6;
			ushort num = *ptr2;
			ptr2 += 14;
			ptr2 = ptr2 + 4 + (int)(*ptr2);
			byte* ptr3 = stackalloc byte[11];
			MemoryProtection lpflOldProtect;
			if (module.FullyQualifiedName[0] != '<')
			{
				byte* ptr4 = ptr + *(ptr2 - 16);
				if (*(ptr2 - 120) != 0)
				{
					byte* ptr5 = ptr + *(ptr2 - 120);
					byte* ptr6 = ptr + *ptr5;
					byte* ptr7 = ptr + ptr5[12];
					byte* ptr8 = ptr + *ptr6 + 2;
					VirtualProtect(new IntPtr(ptr7), 11u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
					ptr3[8] = 108;
					ptr3[10] = 0;
					EtherShieldOnTopNigga(ptr7, ptr3, 11u);
					VirtualProtect(new IntPtr(ptr8), 11u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
					ptr3[10] = 0;
					EtherShieldOnTopNigga(ptr8, ptr3, 11u);
				}
				for (int i = 0; i < num; i++)
				{
					VirtualProtect(new IntPtr(ptr2), 8u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
					BestPasteNigga(ptr2, 0, 8u);
					ptr2 += 40;
				}
				VirtualProtect(new IntPtr(ptr4), 72u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
				byte* ptr9 = ptr + ptr4[8];
				BestPasteNigga(ptr4, 0, 16u);
				VirtualProtect(new IntPtr(ptr9), 4u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
				*ptr9 = 0;
				ptr9 += 12;
				ptr9 += *ptr9;
				ptr9 += 2;
				ushort num2 = *ptr9;
				ptr9 += 2;
				for (int j = 0; j < num2; j++)
				{
					VirtualProtect(new IntPtr(ptr9), 8u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
					ptr9 += 4;
					ptr9 += 4;
					for (int k = 0; k < 8; k++)
					{
						VirtualProtect(new IntPtr(ptr9), 4u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
						*ptr9 = 0;
						ptr9++;
						if (*ptr9 != 0)
						{
							*ptr9 = 0;
							ptr9++;
							if (*ptr9 != 0)
							{
								*ptr9 = 0;
								ptr9++;
								if (*ptr9 != 0)
								{
									*ptr9 = 0;
									ptr9++;
									continue;
								}
								ptr9++;
								break;
							}
							ptr9 += 2;
							break;
						}
						ptr9 += 3;
						break;
					}
				}
				continue;
			}
			uint num3 = *(ptr2 - 16);
			uint num4 = *(ptr2 - 120);
			uint[] array = new uint[num];
			uint[] array2 = new uint[num];
			uint[] array3 = new uint[num];
			for (int l = 0; l < num; l++)
			{
				VirtualProtect(new IntPtr(ptr2), 8u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
				Marshal.Copy(new byte[8], 0, (IntPtr)ptr2, 8);
				array[l] = ptr2[12];
				array2[l] = ptr2[8];
				array3[l] = ptr2[20];
				ptr2 += 40;
			}
			if (num4 != 0)
			{
				for (int m = 0; m < num; m++)
				{
					if (array[m] <= num4 && num4 < array[m] + array2[m])
					{
						num4 = num4 - array[m] + array3[m];
						break;
					}
				}
				byte* ptr10 = ptr + num4;
				uint num5 = *ptr10;
				for (int n = 0; n < num; n++)
				{
					if (array[n] <= num5 && num5 < array[n] + array2[n])
					{
						num5 = num5 - array[n] + array3[n];
						break;
					}
				}
				byte* ptr11 = ptr + num5;
				uint num6 = ptr10[12];
				for (int num7 = 0; num7 < num; num7++)
				{
					if (array[num7] <= num6 && num6 < array[num7] + array2[num7])
					{
						num6 = num6 - array[num7] + array3[num7];
						break;
					}
				}
				uint num8 = (uint)(*ptr11 + 2);
				for (int num9 = 0; num9 < num; num9++)
				{
					if (array[num9] <= num8 && num8 < array[num9] + array2[num9])
					{
						num8 = num8 - array[num9] + array3[num9];
						break;
					}
				}
				VirtualProtect(new IntPtr(ptr + num6), 11u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
				ptr3[8] = 108;
				ptr3[10] = 0;
				EtherShieldOnTopNigga(ptr + num6, ptr3, 11u);
				VirtualProtect(new IntPtr(ptr + num8), 11u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
				ptr3[10] = 0;
				EtherShieldOnTopNigga(ptr + num8, ptr3, 11u);
			}
			for (int num10 = 0; num10 < num; num10++)
			{
				if (array[num10] <= num3 && num3 < array[num10] + array2[num10])
				{
					num3 = num3 - array[num10] + array3[num10];
					break;
				}
			}
			byte* ptr12 = ptr + num3;
			VirtualProtect(new IntPtr(ptr12), 72u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
			uint num11 = ptr12[8];
			for (int num12 = 0; num12 < num; num12++)
			{
				if (array[num12] <= num11 && num11 < array[num12] + array2[num12])
				{
					num11 = num11 - array[num12] + array3[num12];
					break;
				}
			}
			BestPasteNigga(ptr12, 0, 16u);
			byte* ptr13 = ptr + num11;
			VirtualProtect(new IntPtr(ptr13), 4u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
			*ptr13 = 0;
			ptr13 += 12;
			ptr13 += *ptr13;
			ptr13 += 2;
			ushort num13 = *ptr13;
			ptr13 += 2;
			for (int num14 = 0; num14 < num13; num14++)
			{
				VirtualProtect(new IntPtr(ptr13), 8u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
				ptr13 += 4;
				ptr13 += 4;
				for (int num15 = 0; num15 < 8; num15++)
				{
					VirtualProtect(new IntPtr(ptr13), 4u, MemoryProtection.ExecuteReadWrite, out lpflOldProtect);
					*ptr13 = 0;
					ptr13++;
					if (*ptr13 != 0)
					{
						*ptr13 = 0;
						ptr13++;
						if (*ptr13 != 0)
						{
							*ptr13 = 0;
							ptr13++;
							if (*ptr13 != 0)
							{
								*ptr13 = 0;
								ptr13++;
								continue;
							}
							ptr13++;
							break;
						}
						ptr13 += 2;
						break;
					}
					ptr13 += 3;
					break;
				}
			}
		}
	}

	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, MemoryProtection flNewProtect, out MemoryProtection lpflOldProtect);
}
