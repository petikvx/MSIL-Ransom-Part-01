using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace FC2ServerLauncher;

public class CMapHeader
{
	public string m_creatorName = "";

	public string m_authorName = "";

	public string m_mapName = "";

	public long m_mapID;

	public int m_mapSize;

	public int m_gameModes;

	public Image m_screenshot;

	public void LoadMapHeader(string mapFileName)
	{
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		FileStream fileStream = File.OpenRead(mapFileName);
		fileStream.Seek(28L, SeekOrigin.Begin);
		byte[] array = new byte[256];
		fileStream.Read(array, 0, 4);
		byte[] array2 = new byte[256];
		fileStream.Read(array2, 0, BitConverter.ToInt32(array, 0));
		m_creatorName = Encoding.UTF8.GetString(array2);
		string creatorName = m_creatorName;
		char[] trimChars = new char[1];
		m_creatorName = creatorName.TrimEnd(trimChars);
		byte[] buffer = new byte[256];
		fileStream.Read(buffer, 0, 8);
		byte[] array3 = new byte[256];
		fileStream.Read(array3, 0, 4);
		byte[] array4 = new byte[256];
		fileStream.Read(array4, 0, BitConverter.ToInt32(array3, 0));
		m_authorName = Encoding.UTF8.GetString(array4);
		string authorName = m_authorName;
		char[] trimChars2 = new char[1];
		m_authorName = authorName.TrimEnd(trimChars2);
		byte[] array5 = new byte[256];
		fileStream.Read(array5, 0, 4);
		byte[] array6 = new byte[256];
		fileStream.Read(array6, 0, BitConverter.ToInt32(array5, 0));
		m_mapName = Encoding.UTF8.GetString(array6);
		string mapName = m_mapName;
		char[] trimChars3 = new char[1];
		m_mapName = mapName.TrimEnd(trimChars3);
		byte[] array7 = new byte[256];
		fileStream.Read(array7, 0, 8);
		m_mapID = BitConverter.ToInt64(array7, 0);
		byte[] buffer2 = new byte[256];
		fileStream.Read(buffer2, 0, 72);
		byte[] array8 = new byte[256];
		fileStream.Read(array8, 0, 4);
		m_mapSize = BitConverter.ToInt32(array8, 0);
		byte[] buffer3 = new byte[256];
		fileStream.Read(buffer3, 0, 4);
		byte[] array9 = new byte[256];
		fileStream.Read(array9, 0, 4);
		m_gameModes = BitConverter.ToInt32(array9, 0);
		byte[] array10 = new byte[256];
		fileStream.Read(array10, 0, 4);
		int num = BitConverter.ToInt32(array10, 0);
		byte[] array11 = new byte[256];
		fileStream.Read(array11, 0, 4);
		int num2 = BitConverter.ToInt32(array11, 0);
		byte[] array12 = new byte[256];
		fileStream.Read(array12, 0, 4);
		int num3 = BitConverter.ToInt32(array12, 0);
		byte[] array13 = new byte[256];
		fileStream.Read(array13, 0, 4);
		int num4 = BitConverter.ToInt32(array13, 0);
		int num5 = num * num2 * num3 * num4 / 8;
		if (num5 > 0)
		{
			byte[] array14 = new byte[num5];
			fileStream.Read(array14, 0, num5);
			Bitmap val = new Bitmap(num, num2);
			BitmapData val2 = val.LockBits(new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), (ImageLockMode)2, (PixelFormat)2498570);
			Marshal.Copy(array14, 0, val2.get_Scan0(), num5);
			val.UnlockBits(val2);
			m_screenshot = (Image)(object)val;
		}
	}
}
