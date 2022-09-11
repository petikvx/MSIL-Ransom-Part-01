using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns16;
using ns2;
using ns21;

namespace MySql.Data.MySqlClient.Interceptors;

internal sealed class ExceptionInterceptor : Class157
{
	private readonly List<BaseExceptionInterceptor> list_0 = new List<BaseExceptionInterceptor>();

	[NonSerialized]
	internal static GetString getString_1;

	public ExceptionInterceptor(Class139 connection)
	{
		class139_0 = connection;
		method_0(connection.Settings.ExceptionInterceptors);
		list_0.Add(new Exception1());
	}

	protected override void vmethod_0(object object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentException(getString_1(107370781));
		}
		if (!(object_0 is BaseExceptionInterceptor))
		{
			throw new InvalidOperationException(string.Format(Class121.TypeIsNotExceptionInterceptor, object_0.GetType()));
		}
		(object_0 as BaseExceptionInterceptor).vmethod_1(class139_0);
		list_0.Insert(0, (BaseExceptionInterceptor)object_0);
	}

	public void method_1(Exception exception_0)
	{
		throw list_0.Aggregate(exception_0, (Exception exception_0, BaseExceptionInterceptor baseExceptionInterceptor_0) => baseExceptionInterceptor_0.vmethod_0(exception_0));
	}

	protected override string vmethod_1(string string_0)
	{
		if (MySqlConfiguration.Settings != null && MySqlConfiguration.Settings.ExceptionInterceptors != null)
		{
			using (IEnumerator<InterceptorConfigurationElement> enumerator = MySqlConfiguration.Settings.ExceptionInterceptors.System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					InterceptorConfigurationElement current = enumerator.Current;
					if (string.Compare(current.Name, string_0, ignoreCase: true) == 0)
					{
						return current.Type;
					}
				}
			}
			return base.vmethod_1(string_0);
		}
		return base.vmethod_1(string_0);
	}

	static ExceptionInterceptor()
	{
		Strings.CreateGetStringDelegate(typeof(ExceptionInterceptor));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107399577), getString_1(107399572)).Replace(getString_1(107399535), getString_1(107399530)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107399525)))
		{
			throw new SecurityException(getString_1(107399500));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
