using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralError()
	{
	}
}
