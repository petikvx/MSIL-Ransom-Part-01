using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DispatcherOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralValue()
	{
	}
}
