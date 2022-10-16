using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryWrapperStatus : System.Attribute, _003CModule_003E, RepositoryWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcIssuer()
	{
	}
}
