using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Ionic.Zip;
using ns0;
using ns10;
using ns11;
using ns13;
using ns14;
using ns4;
using ns6;
using ns7;
using ns9;

namespace ns5;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
[ComVisible(true)]
public sealed class GClass0
{
	internal sealed class Class22
	{
		internal static Regex regex_0 = new Regex(" \\(copy (\\d+)\\)$");

		internal static int int_0 = 0;
	}

	internal delegate T Delegate4<T>();

	[CompilerGenerated]
	internal sealed class Class23
	{
		public int int_0;

		public byte[] byte_0;

		public int int_1;

		public long long_0;

		public long method_0()
		{
			if (int_0 < 8)
			{
				throw new BadReadException($"  Missing data for ZIP64 extra field, position 0x{long_0:X16}");
			}
			long result = BitConverter.ToInt64(byte_0, int_1);
			int_1 += 8;
			int_0 -= 8;
			return result;
		}
	}

	[CompilerGenerated]
	internal sealed class Class24
	{
		public int int_0;

		public GClass0 gclass0_0;

		public byte[] byte_0;

		public int int_1;

		public DateTime method_0()
		{
			int num = BitConverter.ToInt32(byte_0, int_1);
			int_1 += 4;
			int_0 -= 4;
			return dateTime_4.AddSeconds(num);
		}
	}

	internal short short_0;

	internal short short_1;

	internal int int_0;

	internal short short_2;

	internal short short_3;

	internal short short_4;

	internal Class21 class21_0;

	internal Class21 class21_1;

	internal Class19 class19_0;

	internal Class19 class19_1;

	internal short short_5;

	internal DateTime dateTime_0;

	internal DateTime dateTime_1;

	internal DateTime dateTime_2;

	internal DateTime dateTime_3;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2;

	internal bool bool_3 = true;

	internal string string_0;

	internal string string_1;

	internal short short_6;

	internal short short_7;

	internal short short_8;

	internal short short_9;

	internal Enum20 enum20_0;

	internal string string_2;

	internal bool bool_4;

	internal byte[] byte_0;

	internal long long_0;

	internal long long_1;

	internal long long_2;

	internal int int_1;

	internal bool bool_5;

	internal int int_2;

	internal byte[] byte_1;

	internal bool bool_6;

	internal bool bool_7;

	internal bool bool_8;

	internal bool bool_9;

	internal uint uint_0;

	internal static Encoding encoding_0 = Encoding.GetEncoding("IBM437");

	internal Encoding encoding_1;

	internal Class8 class8_0;

	internal long long_3 = -1L;

	internal byte[] byte_2;

	internal long long_4;

	internal long long_5;

	internal long long_6;

	internal int int_3;

	internal int int_4;

	internal bool bool_10;

	internal uint uint_1;

	internal string string_3;

	internal Enum0 enum0_0;

	internal Enum2 enum2_0;

	internal Enum2 enum2_1;

	internal byte[] byte_3;

	internal Stream stream_0;

	internal Stream stream_1;

	internal long? nullable_0;

	private bool bool_11;

	internal bool bool_12;

	internal bool bool_13;

	internal bool? nullable_1;

	internal bool? nullable_2;

	internal bool bool_14;

	internal Enum7 enum7_0;

	internal static DateTime dateTime_4 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	internal static DateTime dateTime_5 = DateTime.FromFileTimeUtc(0L);

	internal static DateTime dateTime_6 = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	internal Delegate0 delegate0_0;

	internal Delegate1 delegate1_0;

	internal Delegate2 delegate2_0;

	internal Stream stream_2;

	internal int int_5;

	private object object_0 = new object();

	[CompilerGenerated]
	private Enum3 enum3_0;

	[CompilerGenerated]
	private Enum1 enum1_0;

	[CompilerGenerated]
	private Delegate3 delegate3_0;

	[CompilerGenerated]
	private Encoding encoding_2;

	[CompilerGenerated]
	private Encoding encoding_3;

	[CompilerGenerated]
	private Enum9 enum9_0;

	internal bool AttributesIndicateDirectory
	{
		get
		{
			if (short_1 == 0)
			{
				return (int_0 & 0x10) == 16;
			}
			return false;
		}
	}

	public string Info
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"          ZipEntry: {string_1}\n").Append($"   Version Made By: {short_0}\n").Append($" Needed to extract: {short_6}\n");
			if (bool_4)
			{
				stringBuilder.Append("        Entry type: directory\n");
			}
			else
			{
				stringBuilder.Append(string.Format("         File type: {0}\n", bool_14 ? "text" : "binary")).Append($"       Compression: {(CompressionMethod)short_8}\n").Append($"        Compressed: 0x{long_0:X}\n")
					.Append($"      Uncompressed: 0x{long_2:X}\n")
					.Append($"             CRC32: 0x{int_2:X8}\n");
			}
			stringBuilder.Append($"       Disk Number: {uint_0}\n");
			if (long_4 > 4294967295L)
			{
				stringBuilder.Append($"   Relative Offset: 0x{long_4:X16}\n");
			}
			else
			{
				stringBuilder.Append($"   Relative Offset: 0x{long_4:X8}\n");
			}
			stringBuilder.Append($"         Bit Field: 0x{short_7:X4}\n").Append($"        Encrypted?: {bool_8}\n").Append($"          Timeblob: 0x{int_1:X8}\n")
				.Append($"              Time: {Class6.smethod_6(int_1)}\n");
			stringBuilder.Append($"         Is Zip64?: {bool_10}\n");
			if (!string.IsNullOrEmpty(string_2))
			{
				stringBuilder.Append($"           Comment: {string_2}\n");
			}
			stringBuilder.Append("\n");
			return stringBuilder.ToString();
		}
	}

	public DateTime LastModified
	{
		get
		{
			return dateTime_0.ToLocalTime();
		}
		set
		{
			dateTime_0 = ((value.Kind == DateTimeKind.Unspecified) ? DateTime.SpecifyKind(value, DateTimeKind.Local) : value.ToLocalTime());
			dateTime_1 = Class6.smethod_609(dateTime_0).ToUniversalTime();
			bool_6 = true;
		}
	}

	internal int BufferSize => Class6.smethod_281(class8_0);

	public DateTime ModifiedTime
	{
		get
		{
			return dateTime_1;
		}
		set
		{
			DateTime dateTime = dateTime_3;
			DateTime dateTime2 = dateTime_2;
			Class6.smethod_520(dateTime, value, dateTime2, this);
		}
	}

	public DateTime AccessedTime
	{
		get
		{
			return dateTime_2;
		}
		set
		{
			DateTime dateTime = dateTime_3;
			DateTime dateTime2 = dateTime_1;
			Class6.smethod_520(dateTime, dateTime2, value, this);
		}
	}

	public DateTime CreationTime
	{
		get
		{
			return dateTime_3;
		}
		set
		{
			DateTime dateTime = dateTime_2;
			DateTime dateTime2 = dateTime_1;
			Class6.smethod_520(value, dateTime2, dateTime, this);
		}
	}

	public bool EmitTimesInWindowsFormatWhenSaving
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			bool_6 = true;
		}
	}

	public bool EmitTimesInUnixFormatWhenSaving
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			bool_6 = true;
		}
	}

	public Enum7 Timestamp => enum7_0;

	public FileAttributes Attributes
	{
		get
		{
			return (FileAttributes)int_0;
		}
		set
		{
			int_0 = (int)value;
			short_0 = 45;
			bool_6 = true;
		}
	}

	internal string LocalFileName => string_0;

	public string FileName
	{
		get
		{
			return string_1;
		}
		set
		{
			if (class8_0.gclass1_0 == null)
			{
				throw new ZipException("Cannot rename; this is not supported in ZipOutputStream/ZipInputStream.");
			}
			if (string.IsNullOrEmpty(value))
			{
				throw new ZipException("The FileName must be non empty and non-null.");
			}
			string text = Class6.smethod_599(value, (string)null);
			if (!(string_1 == text))
			{
				Class6.smethod_613(class8_0.gclass1_0, this);
				Class6.smethod_577(text, class8_0.gclass1_0, this);
				string_1 = text;
				class8_0.gclass1_0.bool_5 = true;
				bool_6 = true;
			}
		}
	}

	public Stream InputStream
	{
		get
		{
			return stream_1;
		}
		set
		{
			if (enum0_0 != Enum0.const_2)
			{
				throw new ZipException("You must not set the input stream for this entry.");
			}
			bool_11 = true;
			stream_1 = value;
		}
	}

	public bool InputStreamWasJitProvided => bool_11;

	public Enum0 Source => enum0_0;

	public short VersionNeeded => short_6;

	public string Comment
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			bool_6 = true;
		}
	}

	public bool? RequiresZip64 => nullable_1;

	public bool? OutputUsedZip64 => nullable_2;

	public short BitField => short_7;

	public CompressionMethod CompressionMethod
	{
		get
		{
			return (CompressionMethod)short_8;
		}
		set
		{
			if (value != (CompressionMethod)short_8)
			{
				if (value != 0 && value != CompressionMethod.Deflate && value != CompressionMethod.BZip2)
				{
					throw new InvalidOperationException("Unsupported compression method.");
				}
				short_8 = (short)value;
				if (short_8 == 0)
				{
					enum20_0 = Enum20.const_0;
				}
				else if (enum20_0 == Enum20.const_0)
				{
					enum20_0 = Enum20.const_8;
				}
				if (class8_0.gclass1_0 != null)
				{
					class8_0.gclass1_0.bool_5 = true;
				}
				bool_7 = true;
			}
		}
	}

	public Enum20 CompressionLevel
	{
		get
		{
			return enum20_0;
		}
		set
		{
			if ((short_8 != 8 && short_8 != 0) || (value == Enum20.const_8 && short_8 == 8))
			{
				return;
			}
			enum20_0 = value;
			if (value != 0 || short_8 != 0)
			{
				if (enum20_0 == Enum20.const_0)
				{
					short_8 = 0;
				}
				else
				{
					short_8 = 8;
				}
				if (class8_0.gclass1_0 != null)
				{
					class8_0.gclass1_0.bool_5 = true;
				}
				bool_7 = true;
			}
		}
	}

	public long CompressedSize => long_0;

	public long UncompressedSize => long_2;

	public double CompressionRatio
	{
		get
		{
			if (long_2 == 0L)
			{
				return 0.0;
			}
			return 100.0 * (1.0 - 1.0 * (double)long_0 / (1.0 * (double)long_2));
		}
	}

	public int Crc => int_2;

	public bool IsDirectory => bool_4;

	public bool UsesEncryption => enum2_1 != Enum2.const_0;

	public Enum2 Encryption
	{
		get
		{
			return enum2_0;
		}
		set
		{
			if (value != enum2_0)
			{
				if (value == Enum2.const_4)
				{
					throw new InvalidOperationException("You may not set Encryption to that value.");
				}
				enum2_0 = value;
				bool_7 = true;
				if (class8_0.gclass1_0 != null)
				{
					class8_0.gclass1_0.bool_5 = true;
				}
			}
		}
	}

	public string Password
	{
		private get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
			if (string_3 == null)
			{
				enum2_0 = Enum2.const_0;
				return;
			}
			if (enum0_0 == Enum0.const_3 && !bool_8)
			{
				bool_7 = true;
			}
			if (enum2_0 == Enum2.const_0)
			{
				enum2_0 = Enum2.const_1;
			}
		}
	}

	internal bool IsChanged => bool_7 | bool_6;

	public Enum3 ExtractExistingFile
	{
		[CompilerGenerated]
		get
		{
			return enum3_0;
		}
		[CompilerGenerated]
		set
		{
			enum3_0 = value;
		}
	}

	public Enum1 ZipErrorAction
	{
		[CompilerGenerated]
		get
		{
			return enum1_0;
		}
		[CompilerGenerated]
		set
		{
			enum1_0 = value;
		}
	}

	public bool IncludedInMostRecentSave => !bool_9;

	public Delegate3 SetCompression
	{
		[CompilerGenerated]
		get
		{
			return delegate3_0;
		}
		[CompilerGenerated]
		set
		{
			delegate3_0 = value;
		}
	}

	public bool UseUnicodeAsNecessary
	{
		get
		{
			if (AlternateEncoding == Encoding.GetEncoding("UTF-8"))
			{
				return AlternateEncodingUsage == Enum9.const_2;
			}
			return false;
		}
		set
		{
			if (value)
			{
				AlternateEncoding = Encoding.GetEncoding("UTF-8");
				AlternateEncodingUsage = Enum9.const_2;
			}
			else
			{
				AlternateEncoding = GClass1.encoding_1;
				AlternateEncodingUsage = Enum9.const_0;
			}
		}
	}

	public Encoding ProvisionalAlternateEncoding
	{
		[CompilerGenerated]
		get
		{
			return encoding_2;
		}
		[CompilerGenerated]
		set
		{
			encoding_2 = value;
		}
	}

	public Encoding AlternateEncoding
	{
		[CompilerGenerated]
		get
		{
			return encoding_3;
		}
		[CompilerGenerated]
		set
		{
			encoding_3 = value;
		}
	}

	public Enum9 AlternateEncodingUsage
	{
		[CompilerGenerated]
		get
		{
			return enum9_0;
		}
		[CompilerGenerated]
		set
		{
			enum9_0 = value;
		}
	}

	public bool IsText
	{
		get
		{
			return bool_14;
		}
		set
		{
			bool_14 = value;
		}
	}

	internal Stream ArchiveStream
	{
		get
		{
			if (stream_0 == null)
			{
				if (class8_0.gclass1_0 != null)
				{
					GClass1 gclass1_ = class8_0.gclass1_0;
					gclass1_.method_0(bool_18: false);
					stream_0 = Class6.smethod_297(uint_0, gclass1_);
				}
				else
				{
					stream_0 = class8_0.stream0_0.stream_0;
				}
			}
			return stream_0;
		}
	}

	internal long FileDataPosition
	{
		get
		{
			if (long_3 == -1L)
			{
				Class6.smethod_49(this);
			}
			return long_3;
		}
	}

	internal int LengthOfHeader
	{
		get
		{
			if (int_3 == 0)
			{
				Class6.smethod_49(this);
			}
			return int_3;
		}
	}

	internal string UnsupportedAlgorithm
	{
		get
		{
			string empty = string.Empty;
			return uint_1 switch
			{
				26113u => "DES", 
				26114u => "RC2", 
				26115u => "3DES-168", 
				0u => "--", 
				26126u => "PKWare AES128", 
				26127u => "PKWare AES192", 
				26128u => "PKWare AES256", 
				26121u => "3DES-112", 
				26400u => "Blowfish", 
				26401u => "Twofish", 
				26370u => "RC2", 
				26625u => "RC4", 
				_ => $"Unknown (0x{uint_1:X4})", 
			};
		}
	}

	internal string UnsupportedCompressionMethod
	{
		get
		{
			string empty = string.Empty;
			return short_8 switch
			{
				8 => "DEFLATE", 
				9 => "Deflate64", 
				12 => "BZIP2", 
				14 => "LZMA", 
				0 => "Store", 
				1 => "Shrink", 
				98 => "PPMd", 
				19 => "LZ77", 
				_ => $"Unknown (0x{short_8:X4})", 
			};
		}
	}

	public GClass0()
	{
		short_8 = 8;
		enum20_0 = Enum20.const_8;
		enum2_0 = Enum2.const_0;
		enum0_0 = Enum0.const_0;
		AlternateEncoding = Encoding.GetEncoding("IBM437");
		AlternateEncodingUsage = Enum9.const_0;
	}

	string object.ToString()
	{
		return $"ZipEntry::{string_1}";
	}

	private void method_0(string string_4, object[] object_1)
	{
		lock (object_0)
		{
			int hashCode = Thread.CurrentThread.GetHashCode();
			Console.ForegroundColor = (ConsoleColor)(hashCode % 8 + 8);
			Console.Write("{0:000} ZipEntry.Write ", hashCode);
			Console.WriteLine(string_4, object_1);
			Console.ResetColor();
		}
	}
}
