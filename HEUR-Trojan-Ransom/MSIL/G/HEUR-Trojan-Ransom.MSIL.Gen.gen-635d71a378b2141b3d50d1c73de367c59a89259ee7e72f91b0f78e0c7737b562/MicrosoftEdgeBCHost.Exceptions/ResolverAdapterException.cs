using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ResolverAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralInstance()
	{
	}
}
