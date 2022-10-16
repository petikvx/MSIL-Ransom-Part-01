using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
