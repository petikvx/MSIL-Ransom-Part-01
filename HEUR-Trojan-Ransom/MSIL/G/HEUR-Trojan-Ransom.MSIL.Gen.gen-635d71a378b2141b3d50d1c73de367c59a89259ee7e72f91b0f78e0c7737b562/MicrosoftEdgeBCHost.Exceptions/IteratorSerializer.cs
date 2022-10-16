using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralDescriptor()
	{
	}
}
