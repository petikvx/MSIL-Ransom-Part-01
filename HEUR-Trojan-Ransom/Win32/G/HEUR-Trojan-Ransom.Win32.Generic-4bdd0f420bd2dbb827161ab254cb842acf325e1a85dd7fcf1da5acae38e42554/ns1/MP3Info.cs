using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

public class MP3Info
{
	private string mFileName;

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
