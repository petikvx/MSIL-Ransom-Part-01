using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapperContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperContext()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceTask()
	{
	}
}
