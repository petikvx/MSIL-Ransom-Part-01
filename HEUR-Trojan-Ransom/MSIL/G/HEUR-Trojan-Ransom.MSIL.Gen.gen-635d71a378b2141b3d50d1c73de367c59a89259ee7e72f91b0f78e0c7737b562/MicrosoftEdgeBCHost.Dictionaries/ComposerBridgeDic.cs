using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComposerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceValue()
	{
	}
}
