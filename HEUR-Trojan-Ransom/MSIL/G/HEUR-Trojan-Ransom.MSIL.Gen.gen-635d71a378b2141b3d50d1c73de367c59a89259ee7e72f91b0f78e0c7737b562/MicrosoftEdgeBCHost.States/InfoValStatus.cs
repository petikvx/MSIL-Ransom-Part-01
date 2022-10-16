using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InfoValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralResolver()
	{
	}
}
