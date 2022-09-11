using System;
using System.Reflection;

internal class Class7
{
	private Assembly assembly_0;

	public Class7(Assembly assembly_1)
	{
		if ((object)assembly_1 == null)
		{
			throw new ArgumentNullException();
		}
		assembly_0 = assembly_1;
	}

	private void method_0(Type type_0)
	{
		try
		{
			Activator.CreateInstance(type_0);
		}
		catch
		{
		}
	}

	public void method_1()
	{
		Type[] exportedTypes = assembly_0.GetExportedTypes();
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num < exportedTypes.Length)
			{
				num2 = 848498565;
				num3 = 848498565;
			}
			else
			{
				num2 = 2055083151;
				num3 = 2055083151;
			}
			while (true)
			{
				int num4 = num2;
				switch ((uint)(~(~((-(num4 - 1532498958) * 2078638359) ^ -103266991))) % 4u)
				{
				case 3u:
					num2 = 848498565;
					continue;
				case 2u:
				{
					Type type_ = exportedTypes[num];
					method_0(type_);
					num++;
					num2 = -883010466;
					continue;
				}
				default:
					return;
				case 1u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
