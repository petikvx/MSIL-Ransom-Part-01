using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceMap()
	{
	}
}
