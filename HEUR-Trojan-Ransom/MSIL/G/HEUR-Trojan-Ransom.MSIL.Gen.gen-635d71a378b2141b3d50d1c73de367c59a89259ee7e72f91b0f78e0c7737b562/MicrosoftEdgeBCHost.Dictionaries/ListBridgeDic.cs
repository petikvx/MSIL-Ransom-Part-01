using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceInstance()
	{
	}
}
