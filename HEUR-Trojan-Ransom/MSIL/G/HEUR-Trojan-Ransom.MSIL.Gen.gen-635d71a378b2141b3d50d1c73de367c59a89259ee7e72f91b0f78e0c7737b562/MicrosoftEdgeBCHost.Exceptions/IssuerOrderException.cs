using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IssuerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceStatus()
	{
	}
}
