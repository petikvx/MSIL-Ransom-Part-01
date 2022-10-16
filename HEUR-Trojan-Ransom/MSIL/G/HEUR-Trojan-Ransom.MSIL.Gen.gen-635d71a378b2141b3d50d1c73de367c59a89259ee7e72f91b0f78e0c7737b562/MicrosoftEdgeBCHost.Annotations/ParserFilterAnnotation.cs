using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParserFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceProxy()
	{
	}
}
