using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdvisorWrapperStatus : System.Attribute, _003CModule_003E, AdvisorWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeFactory()
	{
	}
}
