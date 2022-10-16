using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContainerWrapperStatus : System.Attribute, _003CModule_003E, ContainerWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateFactory()
	{
	}
}
