namespace Locker;

internal class EncryptionKey
{
	private string pKey;

	private string pIv;

	public string Key
	{
		get
		{
			return pKey;
		}
		set
		{
			pKey = value;
		}
	}

	public string Iv
	{
		get
		{
			return pIv;
		}
		set
		{
			pIv = value;
		}
	}

	public EncryptionKey(string key, string iv)
	{
		pKey = key;
		pIv = iv;
	}
}
