using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralTokenizer()
	{
	}
}
