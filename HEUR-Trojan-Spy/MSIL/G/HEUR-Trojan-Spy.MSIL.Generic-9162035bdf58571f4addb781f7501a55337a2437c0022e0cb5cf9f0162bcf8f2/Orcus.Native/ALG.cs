namespace Orcus.Native;

internal static class ALG
{
	public enum ALG_ID
	{
		CALG_MD5 = 32771,
		CALG_SHA1
	}

	private const int ALG_CLASS_HASH = 32768;

	private const int ALG_SID_SHA1 = 4;
}
