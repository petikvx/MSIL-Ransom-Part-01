using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamUtils()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceAdapter()
	{
	}
}
