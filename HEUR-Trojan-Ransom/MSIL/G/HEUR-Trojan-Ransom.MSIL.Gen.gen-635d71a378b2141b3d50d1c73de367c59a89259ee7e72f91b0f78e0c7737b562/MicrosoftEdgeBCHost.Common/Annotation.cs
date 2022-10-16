using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Annotation : Attribute, _003CModule_003E, Annotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Annotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortFactory()
	{
	}
}
