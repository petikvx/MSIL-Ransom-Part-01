using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Request : Attribute, _003CModule_003E, Request
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Request()
	{
		WriterPropertyProducer.ResolveStub();
		StartInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInstance()
	{
	}
}
