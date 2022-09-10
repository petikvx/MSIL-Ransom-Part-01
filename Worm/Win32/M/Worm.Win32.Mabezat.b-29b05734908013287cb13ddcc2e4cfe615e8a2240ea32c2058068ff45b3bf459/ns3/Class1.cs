using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns3;

[Serializable]
internal class Class1
{
	private IntPtr intptr_0;

	private int int_0;

	[NonSerialized]
	private AppDomain appDomain_0;

	public Class1(AppDomain domain, int domainId)
	{
		int_0 = domainId;
		appDomain_0 = domain;
		intptr_0 = IntPtr.Zero;
	}

	public void method_0()
	{
		if (appDomain_0 == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < 10; i++)
			{
				try
				{
					_ = appDomain_0.FriendlyName;
					Thread.Sleep(50);
				}
				catch (AppDomainUnloadedException)
				{
					break;
				}
			}
		}
		finally
		{
			_003CModule_003E.smethod_156(int_0);
		}
	}

	public static AppDomain smethod_0()
	{
		MethodInfo method = typeof(AppDomain).GetMethod("GetDefaultDomain", BindingFlags.Static | BindingFlags.NonPublic);
		if ((object)method == null)
		{
			return null;
		}
		return method.Invoke(null, null) as AppDomain;
	}

	public void method_1()
	{
		Marshal.GetObjectForIUnknown(intptr_0);
		Marshal.Release(intptr_0);
		intptr_0 = IntPtr.Zero;
		new Thread(method_0).Start();
	}

	public void method_2(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		AppDomain appDomain = smethod_0();
		if (appDomain != null)
		{
			CrossAppDomainDelegate val = new CrossAppDomainDelegate(method_1);
			IntPtr intPtr = (intptr_0 = Marshal.GetIUnknownForObject(appDomain_0));
			appDomain_0 = null;
			appDomain.DoCallBack(val);
		}
	}
}
