using System;
using Microsoft.Win32;
using eC98jAqdnPLlDITmK6;
using eaahHxZXcoR88iaZkL;
using etKNQTu9kgqwCqmIAv;

namespace eZQK2xBlyBqnDmcNvU;

internal class etLkbiKQmtC8HcUdXI
{
	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eKb3AYt8Z;

	public static string e4ZIbpnTa()
	{
		try
		{
			RegistryKey registryKey = (RegistryKey)eTCKBfQSBxjLeqJXLem(Registry.LocalMachine, efEUCdQbIkDdaTQJMLQ());
			if (registryKey == null)
			{
				_ = 0;
				if (!enX4g5QMEpnRQsYw3Jb())
				{
					goto IL_0055;
				}
				registryKey = (RegistryKey)eTCKBfQSBxjLeqJXLem(Registry.LocalMachine, eDcKiiQDMqvC8oVGflV());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)eLuFJUQvsXYwmGQNCRe(registryKey, eKb3AYt8Z(22032), null);
			goto IL_0055;
			IL_0055:
			elioAtQ8pKYlHVJo9Wi(registryKey);
			return result;
		}
		catch
		{
			return null;
		}
	}

	static etLkbiKQmtC8HcUdXI()
	{
		er5tDSQ4WWtOWaFOwiX(edf9SCQwTUtjb2OfaMu(typeof(etLkbiKQmtC8HcUdXI).TypeHandle));
	}

	internal static object efEUCdQbIkDdaTQJMLQ()
	{
		return eyvUZALoPftjoC8rJC.smethod_0();
	}

	internal static object eTCKBfQSBxjLeqJXLem(object object_0, object object_1)
	{
		return ((RegistryKey)object_0).OpenSubKey((string)object_1);
	}

	internal static object eDcKiiQDMqvC8oVGflV()
	{
		return eyvUZALoPftjoC8rJC.smethod_1();
	}

	internal static object eLuFJUQvsXYwmGQNCRe(object object_0, object object_1, object object_2)
	{
		return ((RegistryKey)object_0).GetValue((string?)object_1, object_2);
	}

	internal static void elioAtQ8pKYlHVJo9Wi(object object_0)
	{
		((RegistryKey)object_0).Close();
	}

	internal static bool enX4g5QMEpnRQsYw3Jb()
	{
		return true;
	}

	internal static bool eDGjQ8QuIBGopnDAYiv()
	{
		return false;
	}

	internal static Type edf9SCQwTUtjb2OfaMu(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void er5tDSQ4WWtOWaFOwiX(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
