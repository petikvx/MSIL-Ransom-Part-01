using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectParameter()
	{
	}
}
