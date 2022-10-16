using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceProc()
	{
	}
}
