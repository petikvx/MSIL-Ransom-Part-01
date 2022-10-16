using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttributeGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceFacade()
	{
	}
}
