using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralService()
	{
	}
}
