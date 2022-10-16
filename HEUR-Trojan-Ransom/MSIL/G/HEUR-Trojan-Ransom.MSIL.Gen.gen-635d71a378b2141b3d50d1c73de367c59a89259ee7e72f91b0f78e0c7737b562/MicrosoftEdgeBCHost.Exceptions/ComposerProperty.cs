using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComposerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceDic()
	{
	}
}
