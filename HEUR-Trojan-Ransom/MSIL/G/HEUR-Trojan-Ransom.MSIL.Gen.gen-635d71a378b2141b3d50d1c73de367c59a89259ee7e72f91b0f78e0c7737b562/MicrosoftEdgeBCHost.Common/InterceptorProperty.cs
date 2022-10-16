using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterceptorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceAttribute()
	{
	}
}
