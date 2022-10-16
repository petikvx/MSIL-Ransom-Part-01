using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigurationWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectSpecification()
	{
	}
}
