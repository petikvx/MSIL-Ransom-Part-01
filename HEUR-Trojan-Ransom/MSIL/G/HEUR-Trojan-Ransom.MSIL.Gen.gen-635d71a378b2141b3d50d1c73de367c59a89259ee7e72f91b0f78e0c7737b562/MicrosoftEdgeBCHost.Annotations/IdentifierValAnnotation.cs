using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceTask()
	{
	}
}
