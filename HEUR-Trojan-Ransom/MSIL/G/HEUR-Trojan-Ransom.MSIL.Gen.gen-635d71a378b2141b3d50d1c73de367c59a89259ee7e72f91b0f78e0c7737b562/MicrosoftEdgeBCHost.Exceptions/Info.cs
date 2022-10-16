using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class Info : Attribute, _003CModule_003E, Info
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Info()
	{
		WriterPropertyProducer.ResolveStub();
		SetupValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupValue()
	{
	}
}
