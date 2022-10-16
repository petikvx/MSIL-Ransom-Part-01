using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StructUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceGlobal()
	{
	}
}
