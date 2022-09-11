using System;
using System.Collections.Generic;
using System.Reflection;

namespace ns3;

internal sealed class Class4
{
	private Assembly assembly_0;

	public Class4(Assembly assembly_1)
	{
		while (true)
		{
			int num = -456665822;
			while (true)
			{
				int num2 = num;
				uint num3;
				int num4;
				switch ((num3 = (uint)(~(-(num2 - -1318685184)))) % 4u)
				{
				case 0u:
					break;
				case 1u:
				{
					int num5;
					if ((object)assembly_1 != null)
					{
						num4 = -827710642;
						num5 = -827710642;
					}
					else
					{
						num4 = 535044713;
						num5 = 535044713;
					}
					goto IL_0026;
				}
				case 2u:
					throw new ArgumentNullException();
				default:
					assembly_0 = assembly_1;
					return;
				}
				break;
				IL_0026:
				num = num4 ^ (int)(num3 * 989313786);
			}
		}
	}

	private IEnumerable<Module> method_0(int int_0, int int_1)
	{
		//yield-return decompiler failed: Method not found
		return new Class5(-2)
		{
			class4_0 = this
		};
	}

	public Guid method_1(object object_0)
	{
		if (object_0 == null)
		{
			while (true)
			{
				int num = 1794308793;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((num2 ^ 0x31A376DE) - 1946871839 - 1734001076)) % 3u)
					{
					case 1u:
						object_0 = "MaxSPL.ComplexAlgorithm";
						num = ((int)num3 * -631232309) ^ -1930557560;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0044;
					}
					break;
				}
				continue;
				end_IL_0044:
				break;
			}
		}
		IEnumerator<Module> enumerator = method_0(object_0.GetHashCode(), 7777).GetEnumerator();
		Guid moduleVersionId;
		try
		{
			while (true)
			{
				IL_00b2:
				int num4;
				int num5;
				if (enumerator.MoveNext())
				{
					num4 = 893764827;
					num5 = 893764827;
				}
				else
				{
					num4 = 405391114;
					num5 = 405391114;
				}
				while (true)
				{
					int num2 = num4;
					uint num3;
					switch ((num3 = (uint)((num2 ^ 0x31A376DE) - 1946871839 - 1734001076)) % 4u)
					{
					case 0u:
						goto IL_0072;
					default:
						goto end_IL_0077;
					case 3u:
						break;
					case 1u:
						goto end_IL_0077;
					case 2u:
						moduleVersionId = enumerator.Current.ModuleVersionId;
						goto IL_0120;
					}
					goto IL_00b2;
					IL_0072:
					num4 = 893764827;
					continue;
					end_IL_0077:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_010f:
					int num6 = 1753875191;
					while (true)
					{
						int num2 = num6;
						uint num3;
						switch ((num3 = (uint)((num2 ^ 0x31A376DE) - 1946871839 - 1734001076)) % 3u)
						{
						case 2u:
							goto IL_00d1;
						default:
							goto end_IL_00e4;
						case 0u:
							break;
						case 1u:
							goto end_IL_00e4;
						}
						goto IL_010f;
						IL_00d1:
						enumerator.Dispose();
						num6 = (int)(num3 * 1160754903) ^ -302196748;
						continue;
						end_IL_00e4:
						break;
					}
					break;
				}
			}
		}
		return Guid.NewGuid();
		IL_0120:
		return moduleVersionId;
	}
}
