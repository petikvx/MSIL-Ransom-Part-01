using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InfoAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralMessage()
	{
	}
}
