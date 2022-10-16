using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal sealed class Reponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UIntPtr RemoveStub(object ident)
	{
		return (UIntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Reponse()
	{
		WriterPropertyProducer.ResolveStub();
		SetupIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupIssuer()
	{
	}
}
