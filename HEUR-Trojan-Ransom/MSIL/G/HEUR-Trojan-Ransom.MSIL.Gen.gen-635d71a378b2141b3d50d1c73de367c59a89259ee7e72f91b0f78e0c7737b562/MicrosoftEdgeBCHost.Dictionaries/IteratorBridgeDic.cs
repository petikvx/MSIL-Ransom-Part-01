using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IteratorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceError()
	{
	}
}
