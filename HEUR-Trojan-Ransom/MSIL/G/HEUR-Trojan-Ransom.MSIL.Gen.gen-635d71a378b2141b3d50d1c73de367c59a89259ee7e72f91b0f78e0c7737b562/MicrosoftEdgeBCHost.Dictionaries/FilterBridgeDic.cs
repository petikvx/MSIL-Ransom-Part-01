using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FilterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PopSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopSingleton()
	{
	}
}
