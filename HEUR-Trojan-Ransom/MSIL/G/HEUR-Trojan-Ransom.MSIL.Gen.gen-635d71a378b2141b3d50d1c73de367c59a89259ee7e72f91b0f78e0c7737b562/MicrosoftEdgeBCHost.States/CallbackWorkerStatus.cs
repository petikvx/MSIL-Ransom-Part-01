using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CallbackWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralStruct()
	{
	}
}
