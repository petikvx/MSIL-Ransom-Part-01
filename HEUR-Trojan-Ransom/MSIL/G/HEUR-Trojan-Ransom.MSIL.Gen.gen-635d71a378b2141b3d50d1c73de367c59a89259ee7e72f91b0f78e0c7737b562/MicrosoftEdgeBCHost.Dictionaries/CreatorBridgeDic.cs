using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CreatorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		AddCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddCallback()
	{
	}
}
