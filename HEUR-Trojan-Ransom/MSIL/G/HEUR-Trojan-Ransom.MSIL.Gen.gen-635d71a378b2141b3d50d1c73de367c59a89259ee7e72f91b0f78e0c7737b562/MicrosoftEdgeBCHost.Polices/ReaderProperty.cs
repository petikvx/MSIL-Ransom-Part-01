using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReaderProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceBridge()
	{
	}
}
