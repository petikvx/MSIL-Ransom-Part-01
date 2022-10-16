using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RequestValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralMapper()
	{
	}
}
