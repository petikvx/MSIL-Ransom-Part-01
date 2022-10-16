using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdvisorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceCode()
	{
	}
}
