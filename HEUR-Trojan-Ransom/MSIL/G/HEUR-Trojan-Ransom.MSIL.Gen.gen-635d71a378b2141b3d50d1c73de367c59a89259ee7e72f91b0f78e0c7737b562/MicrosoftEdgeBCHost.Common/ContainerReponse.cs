using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralFactory()
	{
	}
}
