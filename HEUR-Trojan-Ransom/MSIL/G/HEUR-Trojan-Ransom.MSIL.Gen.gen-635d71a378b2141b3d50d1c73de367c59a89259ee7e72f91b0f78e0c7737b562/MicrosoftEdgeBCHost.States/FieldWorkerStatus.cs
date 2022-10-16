using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FieldWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralStruct()
	{
	}
}
