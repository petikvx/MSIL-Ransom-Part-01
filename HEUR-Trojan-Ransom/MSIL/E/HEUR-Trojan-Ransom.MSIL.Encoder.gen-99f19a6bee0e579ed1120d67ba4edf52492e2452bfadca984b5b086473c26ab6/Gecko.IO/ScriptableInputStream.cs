namespace Gecko.IO;

public sealed class ScriptableInputStream
{
	private nsIScriptableInputStream _scriptableInputStream;

	public int Available => (int)_scriptableInputStream.Available();

	public ScriptableInputStream()
	{
		_scriptableInputStream = Xpcom.CreateInstance<nsIScriptableInputStream>("@mozilla.org/scriptableinputstream;1");
	}

	public ScriptableInputStream(InputStream stream)
		: this()
	{
		Init(stream);
	}

	public void Close()
	{
		_scriptableInputStream.Close();
	}

	public void Init(InputStream stream)
	{
		_scriptableInputStream.Init(stream._inputStream);
	}

	public string Read(int count)
	{
		return _scriptableInputStream.Read((uint)count);
	}

	public string ReadBytes(int count)
	{
		return nsString.Get(_scriptableInputStream.ReadBytes, (uint)count);
	}
}
