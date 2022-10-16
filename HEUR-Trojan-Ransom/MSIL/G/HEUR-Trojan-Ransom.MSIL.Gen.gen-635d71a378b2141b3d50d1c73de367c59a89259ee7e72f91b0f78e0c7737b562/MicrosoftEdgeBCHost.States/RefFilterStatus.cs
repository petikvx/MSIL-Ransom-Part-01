using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RefFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralConnection()
	{
	}
}
