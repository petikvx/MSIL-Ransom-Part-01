using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SetterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewItem()
	{
	}
}
