using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralThread()
	{
	}
}
