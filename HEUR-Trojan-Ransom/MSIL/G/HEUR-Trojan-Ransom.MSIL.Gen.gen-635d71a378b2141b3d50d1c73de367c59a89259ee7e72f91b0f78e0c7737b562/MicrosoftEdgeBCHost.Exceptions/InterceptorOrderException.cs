using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterceptorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceSetter()
	{
	}
}
