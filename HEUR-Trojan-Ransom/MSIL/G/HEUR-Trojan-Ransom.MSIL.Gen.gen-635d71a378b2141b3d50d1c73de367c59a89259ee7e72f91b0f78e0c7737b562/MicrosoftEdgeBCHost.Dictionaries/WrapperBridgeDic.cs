using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintContainer()
	{
	}
}
