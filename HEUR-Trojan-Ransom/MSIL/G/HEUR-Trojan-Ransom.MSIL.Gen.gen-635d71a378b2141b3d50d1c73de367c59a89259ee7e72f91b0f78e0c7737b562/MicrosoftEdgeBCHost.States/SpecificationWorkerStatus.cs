using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SpecificationWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralStruct()
	{
	}
}
