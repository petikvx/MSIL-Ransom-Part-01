using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrintUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintUtils()
	{
	}
}
