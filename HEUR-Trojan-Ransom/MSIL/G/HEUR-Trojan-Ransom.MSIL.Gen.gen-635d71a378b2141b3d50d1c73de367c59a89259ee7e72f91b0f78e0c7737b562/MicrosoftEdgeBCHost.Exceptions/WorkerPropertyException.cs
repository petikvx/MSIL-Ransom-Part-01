using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralExporter()
	{
	}
}
