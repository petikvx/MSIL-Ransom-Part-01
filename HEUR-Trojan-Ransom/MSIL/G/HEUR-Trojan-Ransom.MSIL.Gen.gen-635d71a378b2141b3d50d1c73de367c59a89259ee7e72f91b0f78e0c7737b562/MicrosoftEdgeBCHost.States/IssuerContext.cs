using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerContext()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceRequest()
	{
	}
}
