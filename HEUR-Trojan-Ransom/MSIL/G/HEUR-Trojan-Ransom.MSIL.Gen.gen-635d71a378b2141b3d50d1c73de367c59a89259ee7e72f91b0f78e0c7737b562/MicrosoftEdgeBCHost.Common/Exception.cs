using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Exception : Attribute, _003CModule_003E, Exception
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Exception()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateIssuer()
	{
	}
}
