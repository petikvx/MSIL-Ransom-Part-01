using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SchemaWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralRule()
	{
	}
}
