using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PrintWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintWriter()
	{
	}
}
