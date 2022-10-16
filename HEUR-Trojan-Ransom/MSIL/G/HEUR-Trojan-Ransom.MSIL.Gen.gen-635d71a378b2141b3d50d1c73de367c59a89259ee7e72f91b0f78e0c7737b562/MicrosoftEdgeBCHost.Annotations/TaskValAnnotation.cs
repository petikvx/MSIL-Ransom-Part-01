using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceSystem()
	{
	}
}
