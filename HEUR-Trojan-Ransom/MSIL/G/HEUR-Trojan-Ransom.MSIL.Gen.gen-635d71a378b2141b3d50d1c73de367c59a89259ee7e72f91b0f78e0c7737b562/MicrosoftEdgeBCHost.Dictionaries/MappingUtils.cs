using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MappingUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingUtils()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceTests()
	{
	}
}
