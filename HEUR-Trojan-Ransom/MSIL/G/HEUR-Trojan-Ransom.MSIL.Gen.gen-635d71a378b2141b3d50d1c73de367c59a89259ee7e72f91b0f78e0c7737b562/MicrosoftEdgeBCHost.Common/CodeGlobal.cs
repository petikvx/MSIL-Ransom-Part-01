using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CodeGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceAuthentication()
	{
	}
}
