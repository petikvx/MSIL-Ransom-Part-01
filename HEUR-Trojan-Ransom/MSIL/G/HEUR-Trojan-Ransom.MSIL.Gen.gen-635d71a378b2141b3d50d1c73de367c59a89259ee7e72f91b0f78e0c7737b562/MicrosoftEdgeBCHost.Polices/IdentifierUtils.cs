using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IdentifierUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierUtils()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceExporter()
	{
	}
}
