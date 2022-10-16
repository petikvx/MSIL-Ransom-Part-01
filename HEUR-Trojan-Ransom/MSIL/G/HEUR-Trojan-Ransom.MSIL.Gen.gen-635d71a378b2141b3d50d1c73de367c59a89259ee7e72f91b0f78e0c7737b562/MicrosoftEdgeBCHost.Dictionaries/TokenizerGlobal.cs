using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenizerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceAuthentication()
	{
	}
}
