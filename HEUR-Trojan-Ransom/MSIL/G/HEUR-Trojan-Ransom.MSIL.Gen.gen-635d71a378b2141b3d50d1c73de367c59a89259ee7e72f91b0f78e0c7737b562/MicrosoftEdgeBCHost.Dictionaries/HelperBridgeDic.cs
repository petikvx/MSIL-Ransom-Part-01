using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class HelperBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyReader()
	{
	}
}
