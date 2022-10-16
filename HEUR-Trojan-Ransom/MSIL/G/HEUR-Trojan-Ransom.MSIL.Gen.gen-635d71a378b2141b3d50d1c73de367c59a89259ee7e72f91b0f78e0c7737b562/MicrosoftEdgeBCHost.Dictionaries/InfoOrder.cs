using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CreateStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateStruct()
	{
	}
}
