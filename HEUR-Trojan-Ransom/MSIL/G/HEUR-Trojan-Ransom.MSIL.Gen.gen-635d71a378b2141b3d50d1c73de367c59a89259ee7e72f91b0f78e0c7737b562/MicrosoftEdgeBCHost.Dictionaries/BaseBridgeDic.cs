using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BaseBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitMerchant()
	{
	}
}
