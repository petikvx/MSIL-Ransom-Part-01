using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InitializerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceGlobal()
	{
	}
}
