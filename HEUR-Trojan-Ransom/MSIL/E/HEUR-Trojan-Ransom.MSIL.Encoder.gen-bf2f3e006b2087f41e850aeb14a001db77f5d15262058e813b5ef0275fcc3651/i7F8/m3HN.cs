using System;
using x7KX;

namespace i7F8;

internal sealed class m3HN
{
	internal void t6Y7()
	{
		throw new NotImplementedException();
	}

	public static byte s4JG(byte Nt34, byte[] Ty31, int Wb90, int f7PR)
	{
		checked
		{
			Nt34 = k8M5.Ze2s.Wn6x(Nt34, (byte)(Ty31[unchecked(f7PR % Ty31.Length)] ^ ((f7PR + unchecked(Wb90 % Ty31.Length)) & Wb90)));
			return Nt34;
		}
	}

	internal object q5D3()
	{
		throw new NotImplementedException();
	}

	internal static byte[] a9C3(int[] Pd09, int Am43)
	{
		checked
		{
			byte[] array = new byte[Am43 + 1];
			int num = Pd09.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Pd09[i];
			}
			return array;
		}
	}
}
