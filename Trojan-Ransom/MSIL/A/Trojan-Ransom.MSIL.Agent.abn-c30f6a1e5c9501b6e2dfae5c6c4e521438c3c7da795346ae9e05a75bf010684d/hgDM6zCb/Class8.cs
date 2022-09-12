using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;

namespace hgDM6zCb;

internal sealed class Class8
{
	private int[] int_0;

	private int[] int_1;

	private int[] int_2;

	private int[] int_3;

	internal ISymbolDocumentWriter isymbolDocumentWriter_0;

	private const int int_4 = 16;

	internal int[] int_5;

	internal int int_6;

	internal Class8(ISymbolDocumentWriter isymbolDocumentWriter_1)
	{
		int_6 = 0;
		isymbolDocumentWriter_0 = isymbolDocumentWriter_1;
	}

	internal void method_0(ISymbolDocumentWriter isymbolDocumentWriter_1, int int_7, int int_8, int int_9, int int_10, int int_11)
	{
		method_1();
		int_0[int_6] = int_7;
		int_1[int_6] = int_8;
		int_5[int_6] = int_9;
		int_2[int_6] = int_10;
		int_3[int_6] = int_11;
		checked
		{
			int_6++;
		}
	}

	private void method_1()
	{
		if (int_6 == 0)
		{
			int_0 = new int[16];
			int_1 = new int[16];
			int[] array = (int_5 = new int[16]);
			int_2 = new int[16];
			int_3 = new int[16];
		}
		else if (int_6 == int_0.Length)
		{
			int num = checked(int_6 * 2);
			int[] destinationArray = new int[num];
			Array.Copy(int_0, destinationArray, int_6);
			int_0 = destinationArray;
			int[] destinationArray2 = new int[num];
			Array.Copy(int_1, destinationArray2, int_6);
			int_1 = destinationArray2;
			int[] destinationArray3 = new int[num];
			Array.Copy(int_5, destinationArray3, int_6);
			int[] array2 = (int_5 = destinationArray3);
			int[] destinationArray4 = new int[num];
			Array.Copy(int_2, destinationArray4, int_6);
			int_2 = destinationArray4;
			int[] destinationArray5 = new int[num];
			Array.Copy(int_3, destinationArray5, int_6);
			int_3 = destinationArray5;
		}
	}

	internal static bool smethod_0(ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0, AppDomain appDomain_0)
	{
		string[] array = new string[1] { Class10.smethod_0() };
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string value = array[num];
				if (resolveEventArgs_0.Name.Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			assembly_0 = null;
			return false;
		}
		assembly_0 = Class4.smethod_0(appDomain_0);
		return true;
	}

	internal static string smethod_1()
	{
		return GClass2.smethod_0();
	}

	internal void method_2(ISymbolWriter isymbolWriter_0)
	{
		if (int_6 != 0)
		{
			int[] array = new int[int_6];
			Array.Copy(int_0, array, int_6);
			int[] array2 = new int[int_6];
			Array.Copy(int_1, array2, int_6);
			int[] array3 = new int[int_6];
			Array.Copy(int_5, array3, int_6);
			int[] array4 = new int[int_6];
			Array.Copy(int_2, array4, int_6);
			int[] array5 = new int[int_6];
			Array.Copy(int_3, array5, int_6);
			isymbolWriter_0.DefineSequencePoints(isymbolDocumentWriter_0, array, array2, array3, array4, array5);
		}
	}
}
