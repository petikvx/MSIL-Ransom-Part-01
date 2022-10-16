using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StructWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralReg()
	{
	}
}
