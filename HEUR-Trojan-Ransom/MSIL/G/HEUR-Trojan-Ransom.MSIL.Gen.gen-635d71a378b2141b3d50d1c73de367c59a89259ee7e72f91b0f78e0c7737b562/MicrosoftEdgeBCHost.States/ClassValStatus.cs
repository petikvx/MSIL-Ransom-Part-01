using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClassValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralProccesor()
	{
	}
}
