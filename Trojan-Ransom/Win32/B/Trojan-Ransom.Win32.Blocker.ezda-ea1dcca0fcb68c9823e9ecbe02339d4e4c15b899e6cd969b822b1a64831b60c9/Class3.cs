using System;

internal class Class3
{
	public string method_0(string string_0)
	{
		try
		{
			string text = string.Empty;
			char[] array = Delegate109.smethod_0(string_0);
			int num = array[0];
			int num2 = Delegate88.smethod_0(string_0) - 1;
			int num3 = Delegate88.smethod_0(string_0);
			string_0 = "";
			switch (num % 4)
			{
			case 0:
			{
				int num5 = 1;
				while (num5 < num2)
				{
					char c = array[num5];
					array[num5] = array[num2];
					array[num2] = c;
					num5 += 2;
					if (num5 < num2)
					{
						c = array[num5];
						array[num5] = array[num5 - 1];
						array[num5 - 1] = c;
					}
					num5++;
					num2--;
				}
				for (int l = 1; l < num3; l++)
				{
					string_0 = Delegate110.smethod_0(string_0, array[l]);
				}
				break;
			}
			case 1:
			{
				int num4 = 1;
				while (num4 < num2)
				{
					char c = array[num4];
					array[num4] = array[num2];
					array[num2] = c;
					num2 -= 2;
					if (num4 < num2)
					{
						c = array[num2];
						array[num2] = array[num2 + 1];
						array[num2 + 1] = c;
					}
					num4++;
					num2--;
				}
				for (int j = 1; j < num3; j++)
				{
					string_0 = Delegate110.smethod_0(string_0, array[j]);
				}
				break;
			}
			case 2:
			{
				char c = array[num2];
				array[num2] = array[num2 / 2];
				array[num2 / 2] = c;
				c = array[1];
				array[1] = array[num2 / 2 + 1];
				array[num2 / 2 + 1] = c;
				for (int k = 1; k < num3; k++)
				{
					string_0 = Delegate110.smethod_0(string_0, array[k]);
				}
				break;
			}
			case 3:
			{
				for (int i = 1; i < num3; i++)
				{
					string_0 = Delegate110.smethod_0(string_0, array[i]);
				}
				break;
			}
			}
			array = Delegate109.smethod_0(string_0);
			int num6 = array[0];
			for (int m = 1; m < Delegate88.smethod_0(string_0); m += 2)
			{
				text = ((array[m] < 'P') ? Delegate110.smethod_0(text, (char)(num6 - array[m + 1] + 48)) : Delegate110.smethod_0(text, (char)(array[m + 1] + num6 - 48)));
			}
			return text;
		}
		catch
		{
			Delegate111.smethod_0(IntPtr.Zero, (string)_003CModule_003E.smethod_0(3103087655u), (string)_003CModule_003E.smethod_0(3103087656u), 0);
			Delegate82.smethod_3(0);
			return null;
		}
	}
}
