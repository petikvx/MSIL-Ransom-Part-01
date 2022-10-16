using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SystemProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceAttribute()
	{
	}
}
