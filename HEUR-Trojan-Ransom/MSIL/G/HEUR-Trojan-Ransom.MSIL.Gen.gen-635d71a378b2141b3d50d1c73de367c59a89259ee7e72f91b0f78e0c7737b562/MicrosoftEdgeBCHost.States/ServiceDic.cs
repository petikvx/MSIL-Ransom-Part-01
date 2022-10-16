using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServiceDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralStub()
	{
	}
}
