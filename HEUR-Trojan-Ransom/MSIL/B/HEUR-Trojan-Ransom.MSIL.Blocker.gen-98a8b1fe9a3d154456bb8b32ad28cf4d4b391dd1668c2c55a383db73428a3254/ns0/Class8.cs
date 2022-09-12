using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;

namespace ns0;

internal sealed class Class8
{
	private int[] int_0;

	internal ISymbolDocumentWriter isymbolDocumentWriter_0;

	private int int_1;

	private const int int_2 = 16;

	internal int[] int_3;

	internal int[] int_4;

	internal int[] int_5;

	internal int[] int_6;

	internal Class8(ISymbolDocumentWriter isymbolDocumentWriter_1)
	{
		int_1 = 0;
		isymbolDocumentWriter_0 = isymbolDocumentWriter_1;
	}

	internal void method_0(ISymbolDocumentWriter isymbolDocumentWriter_1, int int_7, int int_8, int int_9, int int_10, int int_11)
	{
		method_1();
		int_0[int_1] = int_7;
		int_3[int_1] = int_8;
		int_4[int_1] = int_9;
		int_5[int_1] = int_10;
		int_6[int_1] = int_11;
		checked
		{
			int_1++;
		}
	}

	private void method_1()
	{
		if (int_1 == 0)
		{
			int_0 = new int[16];
			int[] array = (int_3 = new int[16]);
			int[] array2 = (int_4 = new int[16]);
			int[] array3 = (int_5 = new int[16]);
			int[] array4 = (int_6 = new int[16]);
		}
		else if (int_1 == int_0.Length)
		{
			int num = checked(int_1 * 2);
			int[] destinationArray = new int[num];
			Array.Copy(int_0, destinationArray, int_1);
			int_0 = destinationArray;
			int[] destinationArray2 = new int[num];
			Array.Copy(int_3, destinationArray2, int_1);
			int[] array5 = (int_3 = destinationArray2);
			int[] destinationArray3 = new int[num];
			Array.Copy(int_4, destinationArray3, int_1);
			int[] array6 = (int_4 = destinationArray3);
			int[] destinationArray4 = new int[num];
			Array.Copy(int_5, destinationArray4, int_1);
			int[] array7 = (int_5 = destinationArray4);
			int[] destinationArray5 = new int[num];
			Array.Copy(int_6, destinationArray5, int_1);
			int[] array8 = (int_6 = destinationArray5);
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
		if (int_1 != 0)
		{
			int[] array = new int[int_1];
			Array.Copy(int_0, array, int_1);
			int[] array2 = new int[int_1];
			Array.Copy(int_3, array2, int_1);
			int[] array3 = new int[int_1];
			Array.Copy(int_4, array3, int_1);
			int[] array4 = new int[int_1];
			Array.Copy(int_5, array4, int_1);
			int[] array5 = new int[int_1];
			Array.Copy(int_6, array5, int_1);
			isymbolWriter_0.DefineSequencePoints(isymbolDocumentWriter_0, array, array2, array3, array4, array5);
		}
	}
}
