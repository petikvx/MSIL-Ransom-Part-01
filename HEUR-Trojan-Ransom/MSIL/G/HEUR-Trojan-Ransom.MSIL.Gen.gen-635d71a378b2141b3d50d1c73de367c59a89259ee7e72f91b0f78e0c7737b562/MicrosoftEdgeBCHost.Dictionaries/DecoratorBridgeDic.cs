using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DecoratorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceState()
	{
	}
}
