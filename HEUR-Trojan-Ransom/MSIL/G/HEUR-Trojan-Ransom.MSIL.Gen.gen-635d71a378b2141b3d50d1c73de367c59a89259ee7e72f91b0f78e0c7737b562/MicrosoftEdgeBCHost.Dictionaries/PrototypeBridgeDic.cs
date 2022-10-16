using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResetPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetPolicy()
	{
	}
}
