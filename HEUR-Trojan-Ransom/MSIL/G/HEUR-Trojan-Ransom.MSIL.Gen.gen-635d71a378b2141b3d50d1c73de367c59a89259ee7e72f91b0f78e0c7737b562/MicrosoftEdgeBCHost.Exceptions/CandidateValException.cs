using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateValException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatAttribute()
	{
	}
}
