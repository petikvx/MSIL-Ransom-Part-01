using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceAttr()
	{
	}
}
