using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContainerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerValException()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterImporter()
	{
	}
}
