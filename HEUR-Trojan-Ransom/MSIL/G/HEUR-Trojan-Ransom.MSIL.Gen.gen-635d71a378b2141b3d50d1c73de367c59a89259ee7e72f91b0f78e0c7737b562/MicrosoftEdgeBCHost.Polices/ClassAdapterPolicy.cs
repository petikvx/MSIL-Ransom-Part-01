using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralInitializer()
	{
	}
}
