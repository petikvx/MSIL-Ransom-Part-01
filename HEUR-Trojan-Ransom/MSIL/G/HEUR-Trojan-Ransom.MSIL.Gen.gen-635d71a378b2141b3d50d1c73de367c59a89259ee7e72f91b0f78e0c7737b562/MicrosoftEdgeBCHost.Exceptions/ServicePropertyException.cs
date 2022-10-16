using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServicePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServicePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralWrapper()
	{
	}
}
