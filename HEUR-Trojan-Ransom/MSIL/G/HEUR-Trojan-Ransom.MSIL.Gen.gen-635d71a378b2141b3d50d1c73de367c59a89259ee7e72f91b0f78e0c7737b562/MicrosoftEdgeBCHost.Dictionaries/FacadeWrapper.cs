using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CompareDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareDecorator()
	{
	}
}
