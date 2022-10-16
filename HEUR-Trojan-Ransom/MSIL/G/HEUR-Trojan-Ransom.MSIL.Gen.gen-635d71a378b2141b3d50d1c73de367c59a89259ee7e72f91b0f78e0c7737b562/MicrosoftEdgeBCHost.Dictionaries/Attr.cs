using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Attr : Attribute, _003CModule_003E, Attr
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Attr()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateObject()
	{
	}
}
