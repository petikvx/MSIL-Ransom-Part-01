using System;
using System.Runtime.InteropServices;

internal struct GLatNqbjSScBxotVtaHSlAGPyYbR : IDisposable
{
	public uint cedGrzYQePwFPvDebwjvVhABrbkO;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string JIhEejgCwPCfvpPlxUZLILVOVUpJA;

	public IntPtr qxfBdXyyCODUOgXuCaWKwtToKmUg;

	public IntPtr ryoTQrbBSlfkycKfdDTpNChspuUH;

	public GLatNqbjSScBxotVtaHSlAGPyYbR(string string_0, Guid guid_0)
	{
		cedGrzYQePwFPvDebwjvVhABrbkO = (uint)GLatNqbjSScBxotVtaHSlAGPyYbR.etmNCYkLzBroCHNPJnWkxZLlwCKR(GLatNqbjSScBxotVtaHSlAGPyYbR.NRdzgpHQJlURnVwGxjFDIqmiIHMbA(typeof(GLatNqbjSScBxotVtaHSlAGPyYbR).TypeHandle));
		JIhEejgCwPCfvpPlxUZLILVOVUpJA = string_0;
		if (guid_0 != Guid.Empty)
		{
			ryoTQrbBSlfkycKfdDTpNChspuUH = GLatNqbjSScBxotVtaHSlAGPyYbR.GeqgSRFOhnSwoDizFHdmgmwXcQqw(GLatNqbjSScBxotVtaHSlAGPyYbR.etmNCYkLzBroCHNPJnWkxZLlwCKR(GLatNqbjSScBxotVtaHSlAGPyYbR.NRdzgpHQJlURnVwGxjFDIqmiIHMbA(typeof(Guid).TypeHandle)));
			GLatNqbjSScBxotVtaHSlAGPyYbR.TutlVIWVMkvyzMnZAdtrqRuOgfNo((object)guid_0, ryoTQrbBSlfkycKfdDTpNChspuUH, (byte)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(954978690u) != 0);
		}
		else
		{
			ryoTQrbBSlfkycKfdDTpNChspuUH = IntPtr.Zero;
		}
		qxfBdXyyCODUOgXuCaWKwtToKmUg = IntPtr.Zero;
	}

	public void Dispose()
	{
		uwmEoPkWzWwKITZtfhFGKEvFojKdA((byte)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(954978690u) != 0);
	}

	private void uwmEoPkWzWwKITZtfhFGKEvFojKdA(bool bool_0)
	{
		if (!(ryoTQrbBSlfkycKfdDTpNChspuUH != IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1964561354;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((-(num2 + -1089046597) - 876106699) ^ -531356832) - 441915420)) % 3u)
				{
				case 1u:
					goto IL_0014;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0014:
				GLatNqbjSScBxotVtaHSlAGPyYbR.vDJhgOHWfRVIOucNEvuvtYidGsuFA(ryoTQrbBSlfkycKfdDTpNChspuUH, GLatNqbjSScBxotVtaHSlAGPyYbR.NRdzgpHQJlURnVwGxjFDIqmiIHMbA(typeof(Guid).TypeHandle));
				GLatNqbjSScBxotVtaHSlAGPyYbR.XEUiJVaeUYYjHBWApPlPeirppfRF(ryoTQrbBSlfkycKfdDTpNChspuUH);
				num = ((int)num3 * -1427996236) ^ 0x5CBA6B2C;
			}
		}
	}

	static Type NRdzgpHQJlURnVwGxjFDIqmiIHMbA(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static int etmNCYkLzBroCHNPJnWkxZLlwCKR(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	static IntPtr GeqgSRFOhnSwoDizFHdmgmwXcQqw(int int_0)
	{
		return Marshal.AllocHGlobal(int_0);
	}

	static void TutlVIWVMkvyzMnZAdtrqRuOgfNo(object object_0, IntPtr intptr_0, bool bool_0)
	{
		Marshal.StructureToPtr(object_0, intptr_0, bool_0);
	}

	static void vDJhgOHWfRVIOucNEvuvtYidGsuFA(IntPtr intptr_0, Type type_0)
	{
		Marshal.DestroyStructure(intptr_0, type_0);
	}

	static void XEUiJVaeUYYjHBWApPlPeirppfRF(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}
}
