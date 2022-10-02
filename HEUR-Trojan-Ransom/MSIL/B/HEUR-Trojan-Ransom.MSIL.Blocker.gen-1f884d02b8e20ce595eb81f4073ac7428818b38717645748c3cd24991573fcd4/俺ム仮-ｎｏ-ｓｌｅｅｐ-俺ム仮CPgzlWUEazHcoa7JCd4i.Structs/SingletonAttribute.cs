using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Structs;

internal class SingletonAttribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonAttribute()
	{
		DicWriterConsumer.ListIndexer();
		LogoutConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutConnection()
	{
	}
}
