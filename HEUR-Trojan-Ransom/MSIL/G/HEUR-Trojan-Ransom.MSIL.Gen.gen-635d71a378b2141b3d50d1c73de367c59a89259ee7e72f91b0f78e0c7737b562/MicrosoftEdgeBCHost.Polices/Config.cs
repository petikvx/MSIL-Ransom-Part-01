using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class Config : Attribute, _003CModule_003E, Config
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Config()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInstance()
	{
	}
}
