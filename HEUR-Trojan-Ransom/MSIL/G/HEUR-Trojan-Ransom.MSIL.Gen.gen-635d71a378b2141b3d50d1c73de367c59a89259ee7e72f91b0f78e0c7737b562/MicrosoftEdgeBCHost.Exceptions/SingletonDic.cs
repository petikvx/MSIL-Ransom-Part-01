using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralDatabase()
	{
	}
}
