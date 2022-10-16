using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParserValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceObject()
	{
	}
}
