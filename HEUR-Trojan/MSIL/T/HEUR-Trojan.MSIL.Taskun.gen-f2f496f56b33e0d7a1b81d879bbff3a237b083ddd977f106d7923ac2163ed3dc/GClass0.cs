public class GClass0
{
	public string string_0;

	public string string_1;

	public int int_0;

	public GClass0(string string_2)
	{
		string_0 = string.Empty;
		string_1 = string.Empty;
		int_0 = 0;
		string_1 = string_2;
	}

	public void method_0(string string_2)
	{
		checked
		{
			int_0++;
			if (int_0 < Class24.int_5)
			{
				ref string reference = ref string_0;
				reference = reference + string_2 + Class16.smethod_0(-561794817);
			}
		}
	}

	public void method_1(string string_2)
	{
		ref string reference = ref string_0;
		reference = reference + string_2 + Class16.smethod_0(-561794817);
	}

	public void method_2()
	{
		int_0 = 0;
		string_0 = string.Empty;
	}

	public override string ToString()
	{
		if (int_0 < Class24.int_5)
		{
			return string_0;
		}
		return int_0 + Class16.smethod_0(-561781845) + string_1 + Class16.smethod_0(-561781492);
	}
}
