using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ErrorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceRegistry()
	{
	}
}
