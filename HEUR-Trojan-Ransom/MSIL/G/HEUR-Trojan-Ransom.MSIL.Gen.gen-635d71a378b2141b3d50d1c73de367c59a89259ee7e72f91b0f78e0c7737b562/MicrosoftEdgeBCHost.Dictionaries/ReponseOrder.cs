using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReponseOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ResetTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetTokenizer()
	{
	}
}
