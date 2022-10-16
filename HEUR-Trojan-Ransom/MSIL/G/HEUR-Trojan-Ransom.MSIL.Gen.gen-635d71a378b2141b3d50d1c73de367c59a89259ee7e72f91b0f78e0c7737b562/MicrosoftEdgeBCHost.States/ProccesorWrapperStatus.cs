using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorWrapperStatus : System.Attribute, _003CModule_003E, ProccesorWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RestartValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartValue()
	{
	}
}
