using System.Collections.Generic;
using System.Text;

namespace System.IO.Compression;

public class ZipStorer : IDisposable
{
	public enum Compression : ushort
	{
		Store = 0,
		Deflate = 8
	}

	public struct ZipFileEntry
	{
		public Compression Method;

		public string FilenameInZip;

		public uint FileSize;

		public uint CompressedSize;

		public uint HeaderOffset;

		public uint FileOffset;

		public uint HeaderSize;

		public uint Crc32;

		public DateTime ModifyTime;

		public string Comment;

		public bool EncodeUTF8;

		public override string ToString()
		{
			return FilenameInZip;
		}
	}

	public bool EncodeUTF8;

	public bool ForceDeflating;

	private List<ZipFileEntry> Files = new List<ZipFileEntry>();

	private string FileName;

	private Stream ZipFileStream;

	private string Comment = "";

	private byte[] CentralDirImage;

	private ushort ExistingFiles;

	private FileAccess Access;

	private bool leaveOpen;

	private static uint[] CrcTable;

	private static Encoding DefaultEncoding;

	static ZipStorer()
	{
		CrcTable = null;
		DefaultEncoding = Encoding.GetEncoding(437);
		CrcTable = new uint[256];
		for (int i = 0; i < CrcTable.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) == 0) ? (num >> 1) : (0xEDB88320u ^ (num >> 1)));
			}
			CrcTable[i] = num;
		}
	}

	public static ZipStorer Create(string _filename, string _comment)
	{
		ZipStorer zipStorer = Create(new FileStream(_filename, FileMode.Create, FileAccess.ReadWrite), _comment);
		zipStorer.Comment = _comment;
		zipStorer.FileName = _filename;
		return zipStorer;
	}

	public static ZipStorer Create(Stream _stream, string _comment, bool _leaveOpen = false)
	{
		return new ZipStorer
		{
			Comment = _comment,
			ZipFileStream = _stream,
			Access = FileAccess.Write,
			leaveOpen = _leaveOpen
		};
	}

	public static ZipStorer Open(string _filename, FileAccess _access)
	{
		ZipStorer zipStorer = Open(new FileStream(_filename, FileMode.Open, (_access == FileAccess.Read) ? FileAccess.Read : FileAccess.ReadWrite), _access);
		zipStorer.FileName = _filename;
		return zipStorer;
	}

	public static ZipStorer Open(Stream _stream, FileAccess _access, bool _leaveOpen = false)
	{
		if (!_stream.CanSeek && _access != FileAccess.Read)
		{
			throw new InvalidOperationException("Stream cannot seek");
		}
		ZipStorer zipStorer = new ZipStorer();
		zipStorer.ZipFileStream = _stream;
		zipStorer.Access = _access;
		zipStorer.leaveOpen = _leaveOpen;
		if (!zipStorer.ReadFileInfo())
		{
			throw new InvalidDataException();
		}
		return zipStorer;
	}

	public void AddStringStream(string buf, string name)
	{
		try
		{
			if (!string.IsNullOrEmpty(buf))
			{
				using (Stream source = new MemoryStream(Encoding.UTF8.GetBytes(buf)))
				{
					AddStream(Compression.Deflate, name, source, DateTime.Now, "");
					return;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void AddFileStream(List<string> list, string name)
	{
		try
		{
			if (list.Count > 0)
			{
				string s = string.Join(string.Empty, list.ToArray());
				using Stream source = new MemoryStream(Encoding.UTF8.GetBytes(s));
				AddStream(Compression.Deflate, name, source, DateTime.Now, "");
				return;
			}
		}
		catch (Exception)
		{
		}
	}

	public void AddFile(Compression _method, string _pathname, string _filenameInZip, string _comment)
	{
		if (Access == FileAccess.Read)
		{
			throw new InvalidOperationException("Writing is not alowed");
		}
		using FileStream source = new FileStream(_pathname, FileMode.Open, FileAccess.Read);
		AddStream(_method, _filenameInZip, source, File.GetLastWriteTime(_pathname), _comment);
	}

	public void AddStream(Compression _method, string _filenameInZip, Stream _source, DateTime _modTime, string _comment)
	{
		if (Access == FileAccess.Read)
		{
			throw new InvalidOperationException("Writing is not alowed");
		}
		ZipFileEntry _zfe = default(ZipFileEntry);
		_zfe.Method = _method;
		_zfe.EncodeUTF8 = EncodeUTF8;
		_zfe.FilenameInZip = NormalizedFilename(_filenameInZip);
		_zfe.Comment = _comment ?? "";
		_zfe.Crc32 = 0u;
		_zfe.HeaderOffset = (uint)ZipFileStream.Position;
		_zfe.ModifyTime = _modTime;
		WriteLocalHeader(ref _zfe);
		_zfe.FileOffset = (uint)ZipFileStream.Position;
		Store(ref _zfe, _source);
		_source.Close();
		UpdateCrcAndSizes(ref _zfe);
		Files.Add(_zfe);
	}

	public void Close()
	{
		if (Access != FileAccess.Read)
		{
			uint offset = (uint)ZipFileStream.Position;
			uint num = 0u;
			if (CentralDirImage != null)
			{
				ZipFileStream.Write(CentralDirImage, 0, CentralDirImage.Length);
			}
			for (int i = 0; i < Files.Count; i++)
			{
				long position = ZipFileStream.Position;
				WriteCentralDirRecord(Files[i]);
				num += (uint)(int)(ZipFileStream.Position - position);
			}
			if (CentralDirImage != null)
			{
				WriteEndRecord(num + (uint)CentralDirImage.Length, offset);
			}
			else
			{
				WriteEndRecord(num, offset);
			}
		}
		if (ZipFileStream != null && !leaveOpen)
		{
			ZipFileStream.Flush();
			ZipFileStream.Dispose();
			ZipFileStream = null;
		}
	}

	public List<ZipFileEntry> ReadCentralDir()
	{
		if (CentralDirImage == null)
		{
			throw new InvalidOperationException("Central directory currently does not exist");
		}
		List<ZipFileEntry> list = new List<ZipFileEntry>();
		ushort num2;
		ushort num3;
		ushort num4;
		for (int i = 0; i < CentralDirImage.Length && BitConverter.ToUInt32(CentralDirImage, i) == 33639248; i += 46 + num2 + num3 + num4)
		{
			bool num = (BitConverter.ToUInt16(CentralDirImage, i + 8) & 0x800) != 0;
			ushort method = BitConverter.ToUInt16(CentralDirImage, i + 10);
			uint dt = BitConverter.ToUInt32(CentralDirImage, i + 12);
			uint crc = BitConverter.ToUInt32(CentralDirImage, i + 16);
			uint compressedSize = BitConverter.ToUInt32(CentralDirImage, i + 20);
			uint fileSize = BitConverter.ToUInt32(CentralDirImage, i + 24);
			num2 = BitConverter.ToUInt16(CentralDirImage, i + 28);
			num3 = BitConverter.ToUInt16(CentralDirImage, i + 30);
			num4 = BitConverter.ToUInt16(CentralDirImage, i + 32);
			uint headerOffset = BitConverter.ToUInt32(CentralDirImage, i + 42);
			uint headerSize = (uint)(46 + num2 + num3 + num4);
			Encoding encoding = (num ? Encoding.UTF8 : DefaultEncoding);
			ZipFileEntry item = default(ZipFileEntry);
			item.Method = (Compression)method;
			item.FilenameInZip = encoding.GetString(CentralDirImage, i + 46, num2);
			item.FileOffset = GetFileOffset(headerOffset);
			item.FileSize = fileSize;
			item.CompressedSize = compressedSize;
			item.HeaderOffset = headerOffset;
			item.HeaderSize = headerSize;
			item.Crc32 = crc;
			item.ModifyTime = DosTimeToDateTime(dt) ?? DateTime.Now;
			if (num4 > 0)
			{
				item.Comment = encoding.GetString(CentralDirImage, i + 46 + num2 + num3, num4);
			}
			list.Add(item);
		}
		return list;
	}

	public bool ExtractFile(ZipFileEntry _zfe, string _filename)
	{
		string directoryName = Path.GetDirectoryName(_filename);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		if (Directory.Exists(_filename))
		{
			return true;
		}
		bool flag;
		using (FileStream stream = new FileStream(_filename, FileMode.Create, FileAccess.Write))
		{
			flag = ExtractFile(_zfe, stream);
		}
		if (flag)
		{
			File.SetCreationTime(_filename, _zfe.ModifyTime);
			File.SetLastWriteTime(_filename, _zfe.ModifyTime);
		}
		return flag;
	}

	public bool ExtractFile(ZipFileEntry _zfe, Stream _stream)
	{
		if (!_stream.CanWrite)
		{
			throw new InvalidOperationException("Stream cannot be written");
		}
		byte[] array = new byte[4];
		ZipFileStream.Seek(_zfe.HeaderOffset, SeekOrigin.Begin);
		ZipFileStream.Read(array, 0, 4);
		if (BitConverter.ToUInt32(array, 0) != 67324752)
		{
			return false;
		}
		Stream stream;
		if (_zfe.Method == Compression.Store)
		{
			stream = ZipFileStream;
		}
		else
		{
			if (_zfe.Method != Compression.Deflate)
			{
				return false;
			}
			stream = new DeflateStream(ZipFileStream, CompressionMode.Decompress, leaveOpen: true);
		}
		byte[] array2 = new byte[16384];
		ZipFileStream.Seek(_zfe.FileOffset, SeekOrigin.Begin);
		uint num = _zfe.FileSize;
		while (num != 0)
		{
			int num2 = stream.Read(array2, 0, (int)Math.Min(num, array2.Length));
			_stream.Write(array2, 0, num2);
			num -= (uint)num2;
		}
		_stream.Flush();
		if (_zfe.Method == Compression.Deflate)
		{
			stream.Dispose();
		}
		return true;
	}

	public bool ExtractFile(ZipFileEntry _zfe, out byte[] _file)
	{
		using MemoryStream memoryStream = new MemoryStream();
		if (ExtractFile(_zfe, memoryStream))
		{
			_file = memoryStream.ToArray();
			return true;
		}
		_file = null;
		return false;
	}

	public static bool RemoveEntries(ref ZipStorer _zip, List<ZipFileEntry> _zfes)
	{
		if (!(_zip.ZipFileStream is FileStream))
		{
			throw new InvalidOperationException("RemoveEntries is allowed just over streams of type FileStream");
		}
		List<ZipFileEntry> list = _zip.ReadCentralDir();
		string tempFileName = Path.GetTempFileName();
		string tempFileName2 = Path.GetTempFileName();
		try
		{
			ZipStorer zipStorer = Create(tempFileName, string.Empty);
			foreach (ZipFileEntry item in list)
			{
				if (!_zfes.Contains(item) && _zip.ExtractFile(item, tempFileName2))
				{
					zipStorer.AddFile(item.Method, tempFileName2, item.FilenameInZip, item.Comment);
				}
			}
			_zip.Close();
			zipStorer.Close();
			File.Delete(_zip.FileName);
			File.Move(tempFileName, _zip.FileName);
			_zip = Open(_zip.FileName, _zip.Access);
		}
		catch
		{
			return false;
		}
		finally
		{
			if (File.Exists(tempFileName))
			{
				File.Delete(tempFileName);
			}
			if (File.Exists(tempFileName2))
			{
				File.Delete(tempFileName2);
			}
		}
		return true;
	}

	private uint GetFileOffset(uint _headerOffset)
	{
		byte[] array = new byte[2];
		ZipFileStream.Seek(_headerOffset + 26, SeekOrigin.Begin);
		ZipFileStream.Read(array, 0, 2);
		ushort num = BitConverter.ToUInt16(array, 0);
		ZipFileStream.Read(array, 0, 2);
		ushort num2 = BitConverter.ToUInt16(array, 0);
		return (uint)(30 + num + num2 + _headerOffset);
	}

	private void WriteLocalHeader(ref ZipFileEntry _zfe)
	{
		long position = ZipFileStream.Position;
		byte[] bytes = (_zfe.EncodeUTF8 ? Encoding.UTF8 : DefaultEncoding).GetBytes(_zfe.FilenameInZip);
		ZipFileStream.Write(new byte[6] { 80, 75, 3, 4, 20, 0 }, 0, 6);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)(_zfe.EncodeUTF8 ? 2048u : 0u)), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)_zfe.Method), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes(DateTimeToDosTime(_zfe.ModifyTime)), 0, 4);
		ZipFileStream.Write(new byte[12], 0, 12);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)bytes.Length), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)0), 0, 2);
		ZipFileStream.Write(bytes, 0, bytes.Length);
		_zfe.HeaderSize = (uint)(ZipFileStream.Position - position);
	}

	private void WriteCentralDirRecord(ZipFileEntry _zfe)
	{
		Encoding obj = (_zfe.EncodeUTF8 ? Encoding.UTF8 : DefaultEncoding);
		byte[] bytes = obj.GetBytes(_zfe.FilenameInZip);
		byte[] bytes2 = obj.GetBytes(_zfe.Comment);
		ZipFileStream.Write(new byte[8] { 80, 75, 1, 2, 23, 11, 20, 0 }, 0, 8);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)(_zfe.EncodeUTF8 ? 2048u : 0u)), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)_zfe.Method), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes(DateTimeToDosTime(_zfe.ModifyTime)), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.Crc32), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.CompressedSize), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.FileSize), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)bytes.Length), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)0), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)bytes2.Length), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)0), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)0), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)0), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)33024), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.HeaderOffset), 0, 4);
		ZipFileStream.Write(bytes, 0, bytes.Length);
		ZipFileStream.Write(bytes2, 0, bytes2.Length);
	}

	private void WriteEndRecord(uint _size, uint _offset)
	{
		byte[] bytes = (EncodeUTF8 ? Encoding.UTF8 : DefaultEncoding).GetBytes(Comment);
		ZipFileStream.Write(new byte[8] { 80, 75, 5, 6, 0, 0, 0, 0 }, 0, 8);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)Files.Count + ExistingFiles), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)Files.Count + ExistingFiles), 0, 2);
		ZipFileStream.Write(BitConverter.GetBytes(_size), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes(_offset), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes((ushort)bytes.Length), 0, 2);
		ZipFileStream.Write(bytes, 0, bytes.Length);
	}

	private void Store(ref ZipFileEntry _zfe, Stream _source)
	{
		byte[] array = new byte[16384];
		uint num = 0u;
		long position = ZipFileStream.Position;
		long position2 = (_source.CanSeek ? _source.Position : 0L);
		Stream stream = ((_zfe.Method != 0) ? new DeflateStream(ZipFileStream, CompressionMode.Compress, leaveOpen: true) : ZipFileStream);
		_zfe.Crc32 = uint.MaxValue;
		int num2;
		do
		{
			num2 = _source.Read(array, 0, array.Length);
			num += (uint)num2;
			if (num2 > 0)
			{
				stream.Write(array, 0, num2);
				for (uint num3 = 0u; num3 < num2; num3++)
				{
					_zfe.Crc32 = CrcTable[(_zfe.Crc32 ^ array[num3]) & 0xFF] ^ (_zfe.Crc32 >> 8);
				}
			}
		}
		while (num2 > 0);
		stream.Flush();
		if (_zfe.Method == Compression.Deflate)
		{
			stream.Dispose();
		}
		_zfe.Crc32 ^= uint.MaxValue;
		_zfe.FileSize = num;
		_zfe.CompressedSize = (uint)(ZipFileStream.Position - position);
		if (_zfe.Method == Compression.Deflate && !ForceDeflating && _source.CanSeek && _zfe.CompressedSize > _zfe.FileSize)
		{
			_zfe.Method = Compression.Store;
			ZipFileStream.Position = position;
			ZipFileStream.SetLength(position);
			_source.Position = position2;
			Store(ref _zfe, _source);
		}
	}

	private uint DateTimeToDosTime(DateTime _dt)
	{
		return (uint)((_dt.Second / 2) | (_dt.Minute << 5) | (_dt.Hour << 11) | (_dt.Day << 16) | (_dt.Month << 21) | (_dt.Year - 1980 << 25));
	}

	private DateTime? DosTimeToDateTime(uint _dt)
	{
		int year = (int)((_dt >> 25) + 1980);
		int num = (int)((_dt >> 21) & 0xF);
		int num2 = (int)((_dt >> 16) & 0x1F);
		int hour = (int)((_dt >> 11) & 0x1F);
		int minute = (int)((_dt >> 5) & 0x3F);
		int second = (int)((_dt & 0x1F) * 2);
		if (num != 0 && num2 != 0)
		{
			return new DateTime(year, num, num2, hour, minute, second);
		}
		return null;
	}

	private void UpdateCrcAndSizes(ref ZipFileEntry _zfe)
	{
		long position = ZipFileStream.Position;
		ZipFileStream.Position = _zfe.HeaderOffset + 8;
		ZipFileStream.Write(BitConverter.GetBytes((ushort)_zfe.Method), 0, 2);
		ZipFileStream.Position = _zfe.HeaderOffset + 14;
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.Crc32), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.CompressedSize), 0, 4);
		ZipFileStream.Write(BitConverter.GetBytes(_zfe.FileSize), 0, 4);
		ZipFileStream.Position = position;
	}

	private string NormalizedFilename(string _filename)
	{
		string text = _filename.Replace('\\', '/');
		int num = text.IndexOf(':');
		if (num >= 0)
		{
			text = text.Remove(0, num + 1);
		}
		return text.Trim(new char[1] { '/' });
	}

	private bool ReadFileInfo()
	{
		if (ZipFileStream.Length < 22L)
		{
			return false;
		}
		try
		{
			ZipFileStream.Seek(-17L, SeekOrigin.End);
			BinaryReader binaryReader = new BinaryReader(ZipFileStream);
			do
			{
				ZipFileStream.Seek(-5L, SeekOrigin.Current);
				if (binaryReader.ReadUInt32() == 101010256)
				{
					ZipFileStream.Seek(6L, SeekOrigin.Current);
					ushort existingFiles = binaryReader.ReadUInt16();
					int num = binaryReader.ReadInt32();
					uint num2 = binaryReader.ReadUInt32();
					ushort num3 = binaryReader.ReadUInt16();
					if (ZipFileStream.Position + num3 != ZipFileStream.Length)
					{
						return false;
					}
					ExistingFiles = existingFiles;
					CentralDirImage = new byte[num];
					ZipFileStream.Seek(num2, SeekOrigin.Begin);
					ZipFileStream.Read(CentralDirImage, 0, num);
					ZipFileStream.Seek(num2, SeekOrigin.Begin);
					return true;
				}
			}
			while (ZipFileStream.Position > 0L);
		}
		catch
		{
		}
		return false;
	}

	public void Dispose()
	{
		Close();
	}
}
