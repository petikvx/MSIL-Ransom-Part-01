using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class VisitorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceParser()
	{
	}
}
