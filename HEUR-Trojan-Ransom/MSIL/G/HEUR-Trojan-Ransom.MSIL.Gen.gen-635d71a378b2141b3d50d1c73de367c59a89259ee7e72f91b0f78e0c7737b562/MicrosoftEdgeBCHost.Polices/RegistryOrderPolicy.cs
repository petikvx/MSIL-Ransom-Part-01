using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralFactory()
	{
	}
}
