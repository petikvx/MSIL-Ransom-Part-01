using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace ns0;

internal class Class5
{
	private Assembly assembly_0;

	public Class5(Assembly assembly_1)
	{
		if ((object)assembly_1 == null)
		{
			throw new ArgumentNullException();
		}
		assembly_0 = assembly_1;
	}

	private object method_0(object object_0)
	{
		if (object_0 is Module)
		{
			goto IL_001a;
		}
		goto IL_00b2;
		IL_00b2:
		int num;
		int num2;
		if (!(object_0 is Assembly))
		{
			num = 234559102;
			num2 = 234559102;
		}
		else
		{
			num = -739567781;
			num2 = -739567781;
		}
		goto IL_0061;
		IL_0061:
		while (true)
		{
			int num3 = num;
			switch ((uint)((num3 ^ -1519999504 ^ 0x2F62DCDB) * 521227587) % 9u)
			{
			case 4u:
				break;
			case 2u:
				goto IL_0021;
			case 0u:
				goto IL_0042;
			case 8u:
				goto IL_00b2;
			case 1u:
				return (object_0 as Module).ModuleHandle;
			default:
				return new object();
			case 5u:
				RuntimeHelpers.RunModuleConstructor((ModuleHandle)object_0);
				return null;
			case 6u:
				return null;
			case 7u:
				return (object_0 as Assembly).GetLoadedModules();
			}
			break;
			IL_0042:
			int num4;
			if (object_0 is ObjectDisposedException)
			{
				num = 1021937731;
				num4 = 1021937731;
			}
			else
			{
				num = -924523105;
				num4 = -924523105;
			}
			continue;
			IL_0021:
			int num5;
			if (object_0 is ModuleHandle)
			{
				num = -1910942472;
				num5 = -1910942472;
			}
			else
			{
				num = 666795427;
				num5 = 666795427;
			}
		}
		goto IL_001a;
		IL_001a:
		num = -380146519;
		goto IL_0061;
	}

	private List<Module> method_1(Module module_0)
	{
		Module[] array = method_0(assembly_0) as Module[];
		List<Module> list = new List<Module>();
		int num = -765123518;
		uint num2 = 1201089914u;
		int num3 = 0;
		Module module = default(Module);
		while (true)
		{
			if (num3 < array.Length)
			{
				module = array[num3];
				object obj = null;
				try
				{
					method_0((ModuleHandle)method_0(module));
				}
				catch (Exception ex)
				{
					obj = ex;
				}
				if (obj != null)
				{
					goto IL_006d;
				}
				goto IL_00a3;
			}
			int num4 = 328287677;
			goto IL_0072;
			IL_0072:
			while (true)
			{
				num = num4;
				switch ((num2 = (uint)(-num - -796127137) ^ 0x1A99E625u) % 5u)
				{
				case 2u:
					break;
				case 4u:
					list.Add(module);
					num4 = ((int)num2 * -109611385) ^ -421500704;
					continue;
				case 3u:
					goto IL_006d;
				case 0u:
					goto IL_00a3;
				default:
					return list;
				}
				break;
			}
			continue;
			IL_006d:
			num4 = -194472249;
			goto IL_0072;
			IL_00a3:
			num3++;
			num4 = -718036952;
			goto IL_0072;
		}
	}

	public int method_2()
	{
		return method_1(typeof(Information).Module).Capacity;
	}
}
