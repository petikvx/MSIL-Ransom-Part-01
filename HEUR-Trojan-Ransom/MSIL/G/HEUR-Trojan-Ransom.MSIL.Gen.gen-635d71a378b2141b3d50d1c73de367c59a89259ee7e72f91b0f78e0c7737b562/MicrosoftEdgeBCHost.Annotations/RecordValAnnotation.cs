using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RecordValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceTask()
	{
	}
}
