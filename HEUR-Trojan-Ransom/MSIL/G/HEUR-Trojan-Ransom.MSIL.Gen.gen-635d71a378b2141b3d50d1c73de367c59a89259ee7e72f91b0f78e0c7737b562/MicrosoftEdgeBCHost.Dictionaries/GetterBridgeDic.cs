using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GetterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceSetter()
	{
	}
}
