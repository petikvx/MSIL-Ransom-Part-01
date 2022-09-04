using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using SmartAssembly.SmartExceptionsCore;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace e1t9ZoIMs7pU1MfVBaV;

internal class eEJNauItTVW1j8pluTb
{
	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eSmVD9nBi;

	public static void eulODlten(Exception exception_0)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[0]);
	}

	public static void ecs0D1Zdd(Exception exception_0, object object_0)
	{
		evr6rZ2qvsbmMvRmKrf();
		if (eZpb9H2RkDbBfobhMgQ())
		{
		}
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[1] { object_0 });
	}

	public static void e9jslfSvk(Exception exception_0, object object_0, object object_1)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[2] { object_0, object_1 });
	}

	public static void eeN1kpseb(Exception exception_0, object object_0, object object_1, object object_2)
	{
		do
		{
			_ = 0;
			if (eZpb9H2RkDbBfobhMgQ())
			{
				eQGfbP2ODBO0Hb3ojN4(exception_0, new object[3] { object_0, object_1, object_2 });
				break;
			}
		}
		while (!eZpb9H2RkDbBfobhMgQ());
	}

	public static void elN6Gg9Qb(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	public static void eKyrTQhVp(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	public static void euXHswL8F(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	public static void eo2Gig6Qf(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		_ = 1;
		if (!evr6rZ2qvsbmMvRmKrf() || eZpb9H2RkDbBfobhMgQ())
		{
		}
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	public static void e8AuvEGCG(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	public static void eb1x595Bx(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		eQGfbP2ODBO0Hb3ojN4(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	public static void ep2oBURlk(Exception exception_0, object[] object_0)
	{
		_ = 0;
		int int_ = default(int);
		int int_2 = default(int);
		if (eZpb9H2RkDbBfobhMgQ())
		{
			int_ = -1;
			int_2 = -1;
		}
		int num = 0;
		StackTrace object_ = new StackTrace(exception_0);
		try
		{
			if (ewKw1q23Fuxg20eeZ5F(exception_0) != null)
			{
				string[] array = (string[])eCmeqP2FchfRKg2b5fn(ewKw1q23Fuxg20eeZ5F(exception_0), new char[2] { '\r', '\n' });
				string[] array2 = array;
				foreach (string object_2 in array2)
				{
					if (e0t8pV2eCBHE86E83oJ(object_2) > 0)
					{
						num++;
					}
				}
			}
		}
		catch
		{
			num = -1;
		}
		try
		{
			if (e2USi32KyN0nrHmgOPm(object_) > 0)
			{
				evr6rZ2qvsbmMvRmKrf();
				StackFrame object_3 = default(StackFrame);
				if (eZpb9H2RkDbBfobhMgQ())
				{
					object_3 = (StackFrame)ehRNh52sGBUwWB5C1JT(object_, e2USi32KyN0nrHmgOPm(object_) - 1);
				}
				int_ = (eBjPkF20WK8baDtAmW6(eogEBU2IDJUMO7eWUTt(object_3)) & 0xFFFFFF) - 1;
				int_2 = eTkODB2hQit9JOy70P3(object_3);
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, object_0, int_2, num);
			LinkedList<object> linkedList;
			if (!eTDKle2BvWlrYvs7lt9(e5kfBk2ALDjqcYZRthM(exception_0), eSmVD9nBi(23885)))
			{
				linkedList = new LinkedList<object>();
				evr6rZ2qvsbmMvRmKrf();
				if (eZpb9H2RkDbBfobhMgQ())
				{
					eBLgcG2Huolbn2OLumx(e5kfBk2ALDjqcYZRthM(exception_0), eSmVD9nBi(23885), linkedList);
				}
			}
			else
			{
				linkedList = (LinkedList<object>)emmHoP2W3GQxCEaADsG(e5kfBk2ALDjqcYZRthM(exception_0), eSmVD9nBi(23885));
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static eEJNauItTVW1j8pluTb()
	{
		ev2D9y2Uvuyh3dN2qhL(eCZgFs2cxVp0TbgDcls(typeof(eEJNauItTVW1j8pluTb).TypeHandle));
	}

	internal static void eQGfbP2ODBO0Hb3ojN4(object object_0, object object_1)
	{
		ep2oBURlk((Exception)object_0, (object[])object_1);
	}

	internal static bool eZpb9H2RkDbBfobhMgQ()
	{
		return true;
	}

	internal static bool evr6rZ2qvsbmMvRmKrf()
	{
		return false;
	}

	internal static object ewKw1q23Fuxg20eeZ5F(object object_0)
	{
		return ((Exception)object_0).StackTrace;
	}

	internal static object eCmeqP2FchfRKg2b5fn(object object_0, object object_1)
	{
		return ((string)object_0).Split((char[]?)object_1);
	}

	internal static int e0t8pV2eCBHE86E83oJ(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int e2USi32KyN0nrHmgOPm(object object_0)
	{
		return ((StackTrace)object_0).FrameCount;
	}

	internal static object ehRNh52sGBUwWB5C1JT(object object_0, int int_0)
	{
		return ((StackTrace)object_0).GetFrame(int_0);
	}

	internal static object eogEBU2IDJUMO7eWUTt(object object_0)
	{
		return ((StackFrame)object_0).GetMethod();
	}

	internal static int eBjPkF20WK8baDtAmW6(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static int eTkODB2hQit9JOy70P3(object object_0)
	{
		return ((StackFrame)object_0).GetILOffset();
	}

	internal static object e5kfBk2ALDjqcYZRthM(object object_0)
	{
		return ((Exception)object_0).Data;
	}

	internal static bool eTDKle2BvWlrYvs7lt9(object object_0, object object_1)
	{
		return ((IDictionary)object_0).Contains(object_1);
	}

	internal static void eBLgcG2Huolbn2OLumx(object object_0, object object_1, object object_2)
	{
		((IDictionary)object_0)[object_1] = object_2;
	}

	internal static object emmHoP2W3GQxCEaADsG(object object_0, object object_1)
	{
		return ((IDictionary)object_0)[object_1];
	}

	internal static Type eCZgFs2cxVp0TbgDcls(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void ev2D9y2Uvuyh3dN2qhL(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
