using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CreatorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralCandidate()
	{
	}
}
