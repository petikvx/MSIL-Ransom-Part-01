using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidatePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidatePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralAnnotation()
	{
	}
}
