using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContainerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerServer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralUtils()
	{
	}
}
