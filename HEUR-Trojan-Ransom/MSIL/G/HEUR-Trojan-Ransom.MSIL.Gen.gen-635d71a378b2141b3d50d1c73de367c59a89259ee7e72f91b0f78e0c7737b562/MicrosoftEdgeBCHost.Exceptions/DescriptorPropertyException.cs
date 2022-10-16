using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DescriptorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralSpecification()
	{
	}
}
