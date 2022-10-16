using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorContext()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
