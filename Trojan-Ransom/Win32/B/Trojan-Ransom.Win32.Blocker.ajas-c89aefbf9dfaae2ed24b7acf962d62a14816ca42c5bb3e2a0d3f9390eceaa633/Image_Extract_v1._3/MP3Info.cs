using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Image_Extract_v1._3;

public class MP3Info
{
	private string mFileName;

	public ID3V1 GetID3v1Tag(string FileName = "")
	{
		ID3V1 iD3V = new ID3V1();
		if (Operators.CompareString(FileName, "", false) == 0)
		{
			FileName = mFileName;
		}
		FileStream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		fileStream.Seek(-128L, SeekOrigin.End);
		if (Operators.CompareString(ByteToString(binaryReader.ReadBytes(3)).ToUpper(), "TAG", false) == 0)
		{
			iD3V.TagAvailable = true;
			ID3V1 iD3V2 = iD3V;
			iD3V2.Title = ByteToString(binaryReader.ReadBytes(30)).Replace("\0", "");
			iD3V2.Artist = ByteToString(binaryReader.ReadBytes(30)).Replace("\0", "");
			iD3V2.Album = ByteToString(binaryReader.ReadBytes(30)).Replace("\0", "");
			iD3V2.Year = ByteToString(binaryReader.ReadBytes(4)).Replace("\0", "");
			byte[] array = binaryReader.ReadBytes(30);
			if ((array[28] == 0) & (array[29] != 0))
			{
				iD3V2.TagVersion = ID3V1.ID3Version.ID3V11;
				iD3V2.Comment = ByteToString(array, 0, 28).Replace("\0", "");
				iD3V2.Track = array[29];
			}
			else
			{
				iD3V2.TagVersion = ID3V1.ID3Version.ID3V10;
				iD3V2.Comment = ByteToString(array).Replace("\0", "");
				iD3V2.Track = 0;
			}
			iD3V2.Genre = binaryReader.ReadByte();
			iD3V2 = null;
		}
		binaryReader.Close();
		fileStream.Close();
		return iD3V;
	}

	public void SetID3v1Tag(ID3V1 Tag, string FileName = "")
	{
		if (Operators.CompareString(FileName, "", false) == 0)
		{
			FileName = mFileName;
		}
		FileStream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		fileStream.Seek(-128L, SeekOrigin.End);
		if (Operators.CompareString(ByteToString(binaryReader.ReadBytes(3)).ToUpper(), "TAG", false) == 0)
		{
			fileStream.Seek(-3L, SeekOrigin.Current);
		}
		else
		{
			fileStream.Seek(0L, SeekOrigin.End);
		}
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.Write("TAG".ToCharArray());
		binaryWriter.Write(Tag.Title.PadRight(30, '\0').ToCharArray());
		binaryWriter.Write(Tag.Artist.PadRight(30, '\0').ToCharArray());
		binaryWriter.Write(Tag.Album.PadRight(30, '\0').ToCharArray());
		binaryWriter.Write(Tag.Year.PadRight(4, '\0').ToCharArray());
		switch (Tag.TagVersion)
		{
		case ID3V1.ID3Version.ID3V10:
			binaryWriter.Write(Tag.Comment.PadRight(30, '\0').ToCharArray());
			break;
		case ID3V1.ID3Version.ID3V11:
			binaryWriter.Write(Tag.Comment.PadRight(28, '\0').ToCharArray());
			binaryWriter.Write('\0');
			binaryWriter.Write(Tag.Track);
			break;
		}
		binaryWriter.Write(Tag.Genre);
		binaryWriter.Flush();
		binaryWriter.Close();
		binaryReader.Close();
	}

	private string ByteToString(byte[] Expression, int Index = 0, int Length = 0)
	{
		if (Length == 0)
		{
			Length = Expression.Length;
		}
		return Encoding.Default.GetString(Expression, Index, Length);
	}
}
