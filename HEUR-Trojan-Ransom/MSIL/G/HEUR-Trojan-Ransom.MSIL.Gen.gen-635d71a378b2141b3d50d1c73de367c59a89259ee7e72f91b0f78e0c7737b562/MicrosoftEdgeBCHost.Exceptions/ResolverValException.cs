using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ResolverValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverValException()
	{
		WriterPropertyProducer.ResolveStub();
		CloneSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneSetter()
	{
	}
}
