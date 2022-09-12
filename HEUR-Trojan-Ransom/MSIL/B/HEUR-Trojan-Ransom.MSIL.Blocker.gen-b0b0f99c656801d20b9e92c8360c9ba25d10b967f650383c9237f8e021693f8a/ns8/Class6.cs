using System;
using System.Reflection;
using System.Threading;
using ns11;
using ns9;

namespace ns8;

internal sealed class Class6
{
	internal delegate void Delegate0();

	internal static Assembly e;

	[STAThread]
	public void method_0(byte[] byte_0)
	{
		try
		{
			e = Thread.GetDomain().Load(byte_0);
			int int_ = byte_0.Length;
			GClass0.smethod_0(byte_0, int_);
		}
		catch
		{
		}
	}

	internal static Delegate smethod_0(TypeInfo typeInfo_0, out Delegate delegate_0)
	{
		if (Class7.smethod_0(typeInfo_0, out delegate_0, out var type_, out var string_) == null)
		{
			throw new ArgumentNullException("target");
		}
		delegate_0 = Delegate.CreateDelegate(type_, typeInfo_0, string_, ignoreCase: false, throwOnBindFailure: false);
		return delegate_0;
	}
}
