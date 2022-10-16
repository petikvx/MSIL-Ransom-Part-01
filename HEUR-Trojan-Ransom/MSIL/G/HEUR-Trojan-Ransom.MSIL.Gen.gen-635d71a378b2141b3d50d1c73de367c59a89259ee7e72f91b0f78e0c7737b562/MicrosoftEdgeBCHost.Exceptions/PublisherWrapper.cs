using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PublisherWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveImporter()
	{
	}
}
