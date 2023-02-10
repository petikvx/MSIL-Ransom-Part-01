using System;
using System.Collections;
using System.IO;
using System.Reflection;

internal class BabelAssemblyResolver
{
	private object _o;

	private int _i;

	private Hashtable _h;

	private static void Register()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += OnAssemblyResolve;
		}
		catch (Exception)
		{
		}
	}

	private static Assembly OnAssemblyResolve(object P_0, ResolveEventArgs P_1)
	{
		Assembly result = default(Assembly);
		try
		{
			result = null;
			return result;
		}
		catch (Exception)
		{
			while (true)
			{
				int num = 1594174466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)_003CModule_003E._003C_003Ec__DisplayClassf_00602(num)) % 3u)
					{
					case 0u:
						break;
					case 1u:
						goto IL_0026;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_0026:
					result = null;
					num = (int)((num2 * 460214254) ^ 0x6F66B561);
				}
			}
		}
	}

	private static void Decrypt(Stream P_0)
	{
	}
}
