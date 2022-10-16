using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IssuerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceIdentifier()
	{
	}
}
