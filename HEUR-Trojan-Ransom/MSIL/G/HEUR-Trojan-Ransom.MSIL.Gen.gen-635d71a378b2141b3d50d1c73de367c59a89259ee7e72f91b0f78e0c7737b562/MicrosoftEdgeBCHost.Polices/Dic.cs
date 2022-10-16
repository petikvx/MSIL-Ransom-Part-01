using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class Dic : Attribute, _003CModule_003E, Dic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Dic()
	{
		WriterPropertyProducer.ResolveStub();
		RevertIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertIssuer()
	{
	}
}
