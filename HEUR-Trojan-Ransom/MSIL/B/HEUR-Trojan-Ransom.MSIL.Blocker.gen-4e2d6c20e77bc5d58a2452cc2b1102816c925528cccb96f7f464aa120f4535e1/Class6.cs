using System;
using System.Reflection;

internal class Class6
{
	private Assembly assembly_0;

	public Class6(Assembly assembly_1)
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
		int num4 = default(int);
		while (true)
		{
			int num = 1298635550;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(949679647 - -(num2 - 2021761031))) % 7u)
				{
				case 6u:
					num4 = 0;
					num = (int)(num3 * 734786817) ^ -1253255028;
					continue;
				case 3u:
					num = (int)(num3 * 1794150742) ^ -1768430008;
					continue;
				case 2u:
					num4++;
					num = (int)((num3 * 1836379968) ^ 0x8660644);
					continue;
				case 1u:
				{
					Type type_ = exportedTypes[num4];
					method_0(type_);
					num = -1374390198;
					continue;
				}
				case 0u:
				{
					int num5;
					if (num4 >= exportedTypes.Length)
					{
						num = -1413698451;
						num5 = -1413698451;
					}
					else
					{
						num = 2109512507;
						num5 = 2109512507;
					}
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}
}
