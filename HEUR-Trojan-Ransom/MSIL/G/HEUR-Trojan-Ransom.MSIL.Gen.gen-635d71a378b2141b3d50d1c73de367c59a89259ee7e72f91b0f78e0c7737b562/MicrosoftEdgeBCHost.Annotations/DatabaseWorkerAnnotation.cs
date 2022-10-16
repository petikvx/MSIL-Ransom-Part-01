using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DatabaseWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralTask()
	{
	}
}
