using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal sealed class ErrorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UIntPtr VerifyStub(object spec)
	{
		return (UIntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CancelServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelServer()
	{
	}
}
