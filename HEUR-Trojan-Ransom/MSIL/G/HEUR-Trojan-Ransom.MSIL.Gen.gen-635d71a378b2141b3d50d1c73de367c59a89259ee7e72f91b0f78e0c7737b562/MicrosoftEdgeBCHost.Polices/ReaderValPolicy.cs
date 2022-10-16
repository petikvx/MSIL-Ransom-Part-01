using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReaderValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		QueryHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryHelper()
	{
	}
}
