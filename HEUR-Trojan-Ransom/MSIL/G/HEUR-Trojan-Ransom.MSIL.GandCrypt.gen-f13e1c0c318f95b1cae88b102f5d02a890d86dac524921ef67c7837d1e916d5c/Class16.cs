using System;
using System.Threading;

internal sealed class Class16 : Lazy<TimeZone>, Interface4
{
	public extern Class16();

	public extern Class16(Func<TimeZone> func_0);

	public extern Class16(bool bool_0);

	public Class16(LazyThreadSafetyMode lazyThreadSafetyMode_0)
	{
		//Discarded unreachable code: IL_0008, IL_0011, IL_0017
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		checked
		{
			ulong num = (ulong)(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			_ = /*Error near IL_0003: Stack underflow*/* num;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public extern Class16(Func<TimeZone> func_0, bool bool_0);

	public extern Class16(Func<TimeZone> func_0, LazyThreadSafetyMode lazyThreadSafetyMode_0);

	public override extern bool vmethod_0(object object_0);

	public override extern int vmethod_1();

	public override extern string vmethod_2();
}
