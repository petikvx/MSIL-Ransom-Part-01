using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeVal()
	{
		WriterPropertyProducer.ResolveStub();
		VisitContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitContainer()
	{
	}
}
