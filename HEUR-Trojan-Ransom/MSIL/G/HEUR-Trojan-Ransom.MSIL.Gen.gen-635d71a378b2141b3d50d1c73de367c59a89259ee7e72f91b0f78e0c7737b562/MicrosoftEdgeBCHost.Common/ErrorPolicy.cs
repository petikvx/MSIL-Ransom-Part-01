using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceProcess()
	{
	}
}
