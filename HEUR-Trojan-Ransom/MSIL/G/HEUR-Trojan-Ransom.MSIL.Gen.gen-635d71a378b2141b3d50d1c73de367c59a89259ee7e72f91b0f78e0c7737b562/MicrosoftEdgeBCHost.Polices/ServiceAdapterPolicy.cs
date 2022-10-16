using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralProcess()
	{
	}
}
