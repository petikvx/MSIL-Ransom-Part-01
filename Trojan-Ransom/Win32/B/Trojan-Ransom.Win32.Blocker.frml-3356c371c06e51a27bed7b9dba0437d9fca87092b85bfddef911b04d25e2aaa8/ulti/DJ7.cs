using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ulti;

public class DJ7
{
	public object XA49S3UQ8dTkxv36U9O()
	{
		while (true)
		{
		}
	}

	public static byte[] nKK(byte[] DF5, string Ntl)
	{
		byte[] bytes = Encoding.Default.GetBytes(Ntl);
		uint[] array = new uint[256];
		checked
		{
			byte[] array2 = new byte[DF5.Length - 1 + 1];
			uint num = 0u;
			do
			{
				array[(int)num] = num;
				num++;
			}
			while (num <= 255);
			num = 0u;
			uint num2 = default(uint);
			do
			{
				num2 = (uint)(unchecked((long)checked(num2 + bytes[(int)unchecked((long)num % (long)bytes.Length)] + array[(int)num])) & 0xFFL);
				uint num3 = array[(int)num];
				array[(int)num] = array[(int)num2];
				array[(int)num2] = num3;
				num++;
			}
			while (num <= 255);
			num = 0u;
			num2 = 0u;
			int num4 = array2.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				num = (uint)((unchecked((long)num) + 1L) & 0xFFL);
				num2 = (uint)(unchecked((long)checked(num2 + array[(int)num])) & 0xFFL);
				uint num3 = array[(int)num];
				array[(int)num] = array[(int)num2];
				array[(int)num2] = num3;
				array2[i] = (byte)(DF5[i] ^ array[(int)(unchecked((long)checked(array[(int)num] + array[(int)num2])) & 0xFFL)]);
			}
			return array2;
		}
	}

	private object SYe2veZdOBe4RZLHgIgT9q2E43()
	{
		new decimal(428456L);
		new decimal(54L);
		new decimal(49L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}
}
