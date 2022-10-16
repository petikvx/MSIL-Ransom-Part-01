using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CandidateWrapperStatus : System.Attribute, _003CModule_003E, CandidateWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeError()
	{
	}
}
