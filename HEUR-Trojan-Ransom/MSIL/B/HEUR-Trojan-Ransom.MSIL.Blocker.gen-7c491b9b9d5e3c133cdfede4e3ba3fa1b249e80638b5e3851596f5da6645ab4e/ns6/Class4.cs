using System;
using System.Reflection;
using System.Threading;
using ns3;
using ns7;

namespace ns6;

internal sealed class Class4
{
	internal delegate void Delegate0();

	internal static Assembly q;

	public void method_0(byte[] byte_0)
	{
		try
		{
			q = Thread.GetDomain().Load(byte_0);
			int num = byte_0.Length;
			while (num-- > 0)
			{
				byte_0[num] = 0;
			}
			Class2.smethod_0();
		}
		catch
		{
		}
	}

	internal static Delegate smethod_0(TypeInfo typeInfo_0, out Delegate delegate_0)
	{
		if (Class5.smethod_0(typeInfo_0, out delegate_0, out var type_, out var string_) == null)
		{
			throw new ArgumentNullException("target");
		}
		if (typeInfo_0.IsGenericType && typeInfo_0.ContainsGenericParameters)
		{
			throw new ArgumentException("target");
		}
		if (string_ == null)
		{
			throw new ArgumentNullException("target");
		}
		delegate_0 = Delegate.CreateDelegate(type_, typeInfo_0, string_, ignoreCase: false, throwOnBindFailure: false);
		return delegate_0;
	}
}
