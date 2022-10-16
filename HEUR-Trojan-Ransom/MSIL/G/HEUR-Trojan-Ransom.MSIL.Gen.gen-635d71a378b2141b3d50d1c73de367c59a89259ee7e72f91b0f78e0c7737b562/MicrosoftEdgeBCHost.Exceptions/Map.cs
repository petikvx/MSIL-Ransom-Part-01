using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class Map : Attribute, _003CModule_003E, Map
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Map()
	{
		WriterPropertyProducer.ResolveStub();
		FillFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillFactory()
	{
	}
}
