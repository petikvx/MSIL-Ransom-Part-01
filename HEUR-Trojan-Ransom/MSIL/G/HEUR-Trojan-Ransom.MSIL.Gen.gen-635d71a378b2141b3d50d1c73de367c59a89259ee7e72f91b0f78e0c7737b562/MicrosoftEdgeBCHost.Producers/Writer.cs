using System;
using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Writer : Attribute, _003CModule_003E, Writer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Writer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInstance()
	{
	}
}
