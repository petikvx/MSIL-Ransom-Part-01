using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Ionic.Zip;
using Ionic.Zlib;

[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class GClass8
{
	private class Class24
	{
		private static Regex regex_0 = new Regex(" \\(copy (\\d+)\\)$");

		private static int int_0 = 0;

		internal static string smethod_0(string string_0)
		{
			int_0++;
			if (int_0 > 25)
			{
				throw new OverflowException("overflow while creating filename");
			}
			int num = 1;
			int num2 = string_0.LastIndexOf(".");
			if (num2 == -1)
			{
				Match match = regex_0.Match(string_0);
				if (match.Success)
				{
					num = int.Parse(match.Groups[1].Value) + 1;
					string text = $" (copy {num})";
					string_0 = string_0.Substring(0, match.Index) + text;
				}
				else
				{
					string text2 = $" (copy {num})";
					string_0 += text2;
				}
			}
			else
			{
				Match match2 = regex_0.Match(string_0.Substring(0, num2));
				if (match2.Success)
				{
					num = int.Parse(match2.Groups[1].Value) + 1;
					string text3 = $" (copy {num})";
					string_0 = string_0.Substring(0, match2.Index) + text3 + string_0.Substring(num2);
				}
				else
				{
					string text4 = $" (copy {num})";
					string_0 = string_0.Substring(0, num2) + text4 + string_0.Substring(num2);
				}
			}
			return string_0;
		}
	}

	private delegate T Delegate1<T>();

	private short short_0;

	private short short_1;

	private int int_0;

	private short short_2;

	private short short_3;

	private short short_4;

	[CompilerGenerated]
	private ExtractExistingFileAction extractExistingFileAction_0;

	[CompilerGenerated]
	private ZipErrorAction zipErrorAction_0;

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	[CompilerGenerated]
	private Encoding encoding_0;

	[CompilerGenerated]
	private Encoding encoding_1;

	[CompilerGenerated]
	private ZipOption zipOption_0;

	private Class23 class23_0;

	private Class23 class23_1;

	internal DateTime dateTime_0;

	private DateTime dateTime_1;

	private DateTime dateTime_2;

	private DateTime dateTime_3;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2;

	private bool bool_3 = true;

	internal string string_0;

	private string string_1;

	internal short short_5;

	internal short short_6;

	internal short short_7;

	private short short_8;

	private CompressionLevel compressionLevel_0;

	internal string string_2;

	private bool bool_4;

	private byte[] byte_0;

	internal long long_0;

	internal long long_1;

	internal long long_2;

	internal int int_1;

	private bool bool_5;

	internal int int_2;

	internal byte[] byte_1;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private uint uint_0;

	private static Encoding encoding_2 = Encoding.GetEncoding("IBM437");

	private Encoding encoding_3;

	internal Class27 class27_0;

	private long long_3 = -1L;

	private byte[] byte_2;

	internal long long_4;

	private long long_5;

	private long long_6;

	private int int_3;

	private int int_4;

	internal bool bool_10;

	private uint uint_1;

	internal string string_3;

	internal ZipEntrySource zipEntrySource_0;

	internal EncryptionAlgorithm encryptionAlgorithm_0;

	internal EncryptionAlgorithm encryptionAlgorithm_1;

	internal byte[] byte_3;

	internal Stream stream_0;

	private Stream stream_1;

	private long? nullable_0;

	private bool bool_11;

	private bool bool_12;

	private bool bool_13;

	private bool? nullable_1;

	private bool? nullable_2;

	private bool bool_14;

	private ZipEntryTimestamp zipEntryTimestamp_0;

	private static DateTime dateTime_4 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private static DateTime dateTime_5 = DateTime.FromFileTimeUtc(0L);

	private static DateTime dateTime_6 = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private GDelegate0 gdelegate0_0;

	private GDelegate1 gdelegate1_0;

	private GDelegate2 gdelegate2_0;

	private Stream stream_2;

	private int int_5;

	private object object_0 = new object();

	internal bool Boolean_0
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

	public string String_0
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"          ZipEntry: {String_2}\n").Append($"   Version Made By: {short_0}\n").Append($" Needed to extract: {Int16_0}\n");
			if (bool_4)
			{
				stringBuilder.Append("        Entry type: directory\n");
			}
			else
			{
				stringBuilder.Append(string.Format("         File type: {0}\n", bool_14 ? "text" : "binary")).Append($"       Compression: {CompressionMethod_0}\n").Append($"        Compressed: 0x{Int64_0:X}\n")
					.Append($"      Uncompressed: 0x{Int64_1:X}\n")
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
			stringBuilder.Append($"         Bit Field: 0x{short_6:X4}\n").Append($"        Encrypted?: {bool_8}\n").Append($"          Timeblob: 0x{int_1:X8}\n")
				.Append($"              Time: {Class21.smethod_14(int_1)}\n");
			stringBuilder.Append($"         Is Zip64?: {bool_10}\n");
			if (!string.IsNullOrEmpty(string_2))
			{
				stringBuilder.Append($"           Comment: {string_2}\n");
			}
			stringBuilder.Append("\n");
			return stringBuilder.ToString();
		}
	}

	public DateTime DateTime_0
	{
		get
		{
			return dateTime_0.ToLocalTime();
		}
		set
		{
			dateTime_0 = ((value.Kind == DateTimeKind.Unspecified) ? DateTime.SpecifyKind(value, DateTimeKind.Local) : value.ToLocalTime());
			dateTime_1 = Class21.smethod_13(dateTime_0).ToUniversalTime();
			bool_6 = true;
		}
	}

	private int Int32_0 => class27_0.Int32_0;

	public DateTime DateTime_1
	{
		get
		{
			return dateTime_1;
		}
		set
		{
			method_1(dateTime_3, dateTime_2, value);
		}
	}

	public DateTime DateTime_2
	{
		get
		{
			return dateTime_2;
		}
		set
		{
			method_1(dateTime_3, value, dateTime_1);
		}
	}

	public DateTime DateTime_3
	{
		get
		{
			return dateTime_3;
		}
		set
		{
			method_1(value, dateTime_2, dateTime_1);
		}
	}

	public bool Boolean_1
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

	public bool Boolean_2
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

	public ZipEntryTimestamp ZipEntryTimestamp_0 => zipEntryTimestamp_0;

	public FileAttributes FileAttributes_0
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

	internal string String_1 => string_0;

	public string String_2
	{
		get
		{
			return string_1;
		}
		set
		{
			if (class27_0.GClass9_0 == null)
			{
				throw new ZipException("Cannot rename; this is not supported in ZipOutputStream/ZipInputStream.");
			}
			if (string.IsNullOrEmpty(value))
			{
				throw new ZipException("The FileName must be non empty and non-null.");
			}
			string text = smethod_2(value, null);
			if (!(string_1 == text))
			{
				class27_0.GClass9_0.method_44(this);
				class27_0.GClass9_0.method_35(text, this);
				string_1 = text;
				class27_0.GClass9_0.method_38();
				bool_6 = true;
			}
		}
	}

	public Stream Stream_0
	{
		get
		{
			return stream_1;
		}
		set
		{
			if (zipEntrySource_0 != ZipEntrySource.Stream)
			{
				throw new ZipException("You must not set the input stream for this entry.");
			}
			bool_11 = true;
			stream_1 = value;
		}
	}

	public bool Boolean_3 => bool_11;

	public ZipEntrySource ZipEntrySource_0 => zipEntrySource_0;

	public short Int16_0 => short_5;

	public string String_3
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

	public bool? Nullable_0 => nullable_1;

	public bool? Nullable_1 => nullable_2;

	public short Int16_1 => short_6;

	public CompressionMethod CompressionMethod_0
	{
		get
		{
			return (CompressionMethod)short_7;
		}
		set
		{
			if (value != (CompressionMethod)short_7)
			{
				if (value != 0 && value != CompressionMethod.Deflate)
				{
					throw new InvalidOperationException("Unsupported compression method.");
				}
				short_7 = (short)value;
				if (short_7 == 0)
				{
					compressionLevel_0 = CompressionLevel.None;
				}
				else if (CompressionLevel_0 == CompressionLevel.None)
				{
					compressionLevel_0 = CompressionLevel.Default;
				}
				if (class27_0.GClass9_0 != null)
				{
					class27_0.GClass9_0.method_38();
				}
				bool_7 = true;
			}
		}
	}

	public CompressionLevel CompressionLevel_0
	{
		get
		{
			return compressionLevel_0;
		}
		set
		{
			if ((short_7 != 8 && short_7 != 0) || (value == CompressionLevel.Default && short_7 == 8))
			{
				return;
			}
			compressionLevel_0 = value;
			if (value != 0 || short_7 != 0)
			{
				if (compressionLevel_0 == CompressionLevel.None)
				{
					short_7 = 0;
				}
				else
				{
					short_7 = 8;
				}
				if (class27_0.GClass9_0 != null)
				{
					class27_0.GClass9_0.method_38();
				}
				bool_7 = true;
			}
		}
	}

	public long Int64_0 => long_0;

	public long Int64_1 => long_2;

	public double Double_0
	{
		get
		{
			if (Int64_1 == 0L)
			{
				return 0.0;
			}
			return 100.0 * (1.0 - 1.0 * (double)Int64_0 / (1.0 * (double)Int64_1));
		}
	}

	public int Int32_1 => int_2;

	public bool Boolean_4 => bool_4;

	public bool Boolean_5 => encryptionAlgorithm_1 != EncryptionAlgorithm.None;

	public EncryptionAlgorithm EncryptionAlgorithm_0
	{
		get
		{
			return encryptionAlgorithm_0;
		}
		set
		{
			if (value != encryptionAlgorithm_0)
			{
				if (value == EncryptionAlgorithm.Unsupported)
				{
					throw new InvalidOperationException("You may not set Encryption to that value.");
				}
				encryptionAlgorithm_0 = value;
				bool_7 = true;
				if (class27_0.GClass9_0 != null)
				{
					class27_0.GClass9_0.method_38();
				}
			}
		}
	}

	public string String_4
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
				encryptionAlgorithm_0 = EncryptionAlgorithm.None;
				return;
			}
			if (zipEntrySource_0 == ZipEntrySource.ZipFile && !bool_8)
			{
				bool_7 = true;
			}
			if (EncryptionAlgorithm_0 == EncryptionAlgorithm.None)
			{
				encryptionAlgorithm_0 = EncryptionAlgorithm.PkzipWeak;
			}
		}
	}

	internal bool Boolean_6 => bool_7 | bool_6;

	public ExtractExistingFileAction ExtractExistingFileAction_0
	{
		[CompilerGenerated]
		get
		{
			return extractExistingFileAction_0;
		}
		[CompilerGenerated]
		set
		{
			extractExistingFileAction_0 = value;
		}
	}

	public ZipErrorAction ZipErrorAction_0
	{
		[CompilerGenerated]
		get
		{
			return zipErrorAction_0;
		}
		[CompilerGenerated]
		set
		{
			zipErrorAction_0 = value;
		}
	}

	public bool Boolean_7 => !bool_9;

	public GDelegate3 GDelegate3_0
	{
		[CompilerGenerated]
		get
		{
			return gdelegate3_0;
		}
		[CompilerGenerated]
		set
		{
			gdelegate3_0 = value;
		}
	}

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool Boolean_8
	{
		get
		{
			if (Encoding_1 == Encoding.GetEncoding("UTF-8"))
			{
				return ZipOption_0 == ZipOption.AsNecessary;
			}
			return false;
		}
		set
		{
			if (value)
			{
				Encoding_1 = Encoding.GetEncoding("UTF-8");
				ZipOption_0 = ZipOption.AsNecessary;
			}
			else
			{
				Encoding_1 = GClass9.Encoding_2;
				ZipOption_0 = ZipOption.Default;
			}
		}
	}

	[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
	public Encoding Encoding_0
	{
		[CompilerGenerated]
		get
		{
			return encoding_0;
		}
		[CompilerGenerated]
		set
		{
			encoding_0 = value;
		}
	}

	public Encoding Encoding_1
	{
		[CompilerGenerated]
		get
		{
			return encoding_1;
		}
		[CompilerGenerated]
		set
		{
			encoding_1 = value;
		}
	}

	public ZipOption ZipOption_0
	{
		[CompilerGenerated]
		get
		{
			return zipOption_0;
		}
		[CompilerGenerated]
		set
		{
			zipOption_0 = value;
		}
	}

	public bool Boolean_9
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

	internal Stream Stream_1
	{
		get
		{
			if (stream_0 == null)
			{
				if (class27_0.GClass9_0 != null)
				{
					GClass9 gClass9_ = class27_0.GClass9_0;
					gClass9_.method_40(bool_18: false);
					stream_0 = gClass9_.method_39(uint_0);
				}
				else
				{
					stream_0 = class27_0.GStream6_0.Stream_0;
				}
			}
			return stream_0;
		}
	}

	internal long Int64_2
	{
		get
		{
			if (long_3 == -1L)
			{
				method_3();
			}
			return long_3;
		}
	}

	private int Int32_2
	{
		get
		{
			if (int_3 == 0)
			{
				method_3();
			}
			return int_3;
		}
	}

	private string String_5
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
				26370u => "RC2", 
				26625u => "RC4", 
				26401u => "Twofish", 
				_ => $"Unknown (0x{uint_1:X4})", 
			};
		}
	}

	private string String_6
	{
		get
		{
			string empty = string.Empty;
			return short_7 switch
			{
				1 => "Shrink", 
				0 => "Store", 
				98 => "PPMd", 
				19 => "LZ77", 
				8 => "DEFLATE", 
				9 => "Deflate64", 
				12 => "BZIP2", 
				14 => "LZMA", 
				_ => $"Unknown (0x{short_7:X4})", 
			};
		}
	}

	internal void method_0()
	{
		long_3 = -1L;
		int_3 = 0;
	}

	internal static GClass8 smethod_0(GClass9 gclass9_0, Dictionary<string, object> dictionary_0)
	{
		Stream stream = gclass9_0.Stream_0;
		Encoding encoding = ((gclass9_0.ZipOption_0 == ZipOption.Always) ? gclass9_0.Encoding_1 : GClass9.Encoding_2);
		int num = Class21.smethod_8(stream);
		if (smethod_1(num))
		{
			stream.Seek(-4L, SeekOrigin.Current);
			if (num != 101010256L && num != 101075792L && num != 67324752)
			{
				throw new BadReadException($"  Bad signature (0x{num:X8}) at position 0x{stream.Position:X8}");
			}
			return null;
		}
		int num2 = 46;
		byte[] array = new byte[42];
		int num3 = stream.Read(array, 0, array.Length);
		if (num3 != array.Length)
		{
			return null;
		}
		GClass8 gClass = new GClass8();
		gClass.Encoding_1 = encoding;
		gClass.zipEntrySource_0 = ZipEntrySource.ZipFile;
		gClass.class27_0 = new Class27(gclass9_0);
		gClass.short_0 = (short)(array[0] + array[1] * 256);
		gClass.short_5 = (short)(array[2] + array[3] * 256);
		gClass.short_6 = (short)(array[4] + array[5] * 256);
		gClass.short_7 = (short)(array[6] + array[7] * 256);
		gClass.int_1 = array[8] + array[9] * 256 + array[10] * 256 * 256 + array[11] * 256 * 256 * 256;
		gClass.dateTime_0 = Class21.smethod_14(gClass.int_1);
		gClass.zipEntryTimestamp_0 |= ZipEntryTimestamp.DOS;
		gClass.int_2 = array[12] + array[13] * 256 + array[14] * 256 * 256 + array[15] * 256 * 256 * 256;
		gClass.long_0 = (uint)(array[16] + array[17] * 256 + array[18] * 256 * 256 + array[19] * 256 * 256 * 256);
		gClass.long_2 = (uint)(array[20] + array[21] * 256 + array[22] * 256 * 256 + array[23] * 256 * 256 * 256);
		gClass.short_8 = gClass.short_7;
		gClass.short_2 = (short)(array[24] + array[25] * 256);
		gClass.short_3 = (short)(array[26] + array[27] * 256);
		gClass.short_4 = (short)(array[28] + array[29] * 256);
		gClass.uint_0 = (uint)(array[30] + array[31] * 256);
		gClass.short_1 = (short)(array[32] + array[33] * 256);
		gClass.int_0 = array[34] + array[35] * 256 + array[36] * 256 * 256 + array[37] * 256 * 256 * 256;
		gClass.long_4 = (uint)(array[38] + array[39] * 256 + array[40] * 256 * 256 + array[41] * 256 * 256 * 256);
		gClass.Boolean_9 = (gClass.short_1 & 1) == 1;
		array = new byte[gClass.short_2];
		num3 = stream.Read(array, 0, array.Length);
		num2 += num3;
		if ((gClass.short_6 & 0x800) == 2048)
		{
			gClass.string_1 = Class21.smethod_6(array);
		}
		else
		{
			gClass.string_1 = Class21.smethod_7(array, encoding);
		}
		while (dictionary_0.ContainsKey(gClass.string_1))
		{
			gClass.string_1 = Class24.smethod_0(gClass.string_1);
			gClass.bool_6 = true;
		}
		if (gClass.Boolean_0)
		{
			gClass.method_2();
		}
		else if (gClass.string_1.EndsWith("/"))
		{
			gClass.method_2();
		}
		gClass.long_1 = gClass.long_0;
		if ((gClass.short_6 & 1) == 1)
		{
			gClass.encryptionAlgorithm_0 = EncryptionAlgorithm.PkzipWeak;
			gClass.encryptionAlgorithm_1 = EncryptionAlgorithm.PkzipWeak;
			gClass.bool_8 = true;
		}
		if (gClass.short_3 > 0)
		{
			gClass.bool_10 = gClass.long_0 == 4294967295L || gClass.long_2 == 4294967295L || gClass.long_4 == 4294967295L;
			num2 += gClass.method_35(stream, gClass.short_3);
			gClass.long_1 = gClass.long_0;
		}
		if (gClass.encryptionAlgorithm_0 == EncryptionAlgorithm.PkzipWeak)
		{
			gClass.long_1 -= 12L;
		}
		if ((gClass.short_6 & 8) == 8)
		{
			if (gClass.bool_10)
			{
				gClass.int_4 += 24;
			}
			else
			{
				gClass.int_4 += 16;
			}
		}
		gClass.Encoding_1 = (((gClass.short_6 & 0x800) == 2048) ? Encoding.UTF8 : encoding);
		gClass.ZipOption_0 = ZipOption.Always;
		if (gClass.short_4 > 0)
		{
			array = new byte[gClass.short_4];
			num3 = stream.Read(array, 0, array.Length);
			num2 += num3;
			if ((gClass.short_6 & 0x800) == 2048)
			{
				gClass.string_2 = Class21.smethod_6(array);
			}
			else
			{
				gClass.string_2 = Class21.smethod_7(array, encoding);
			}
		}
		return gClass;
	}

	internal static bool smethod_1(int int_6)
	{
		return int_6 != 33639248;
	}

	public GClass8()
	{
		short_7 = 8;
		compressionLevel_0 = CompressionLevel.Default;
		encryptionAlgorithm_0 = EncryptionAlgorithm.None;
		zipEntrySource_0 = ZipEntrySource.None;
		Encoding_1 = Encoding.GetEncoding("IBM437");
		ZipOption_0 = ZipOption.Default;
	}

	public void method_1(DateTime dateTime_7, DateTime dateTime_8, DateTime dateTime_9)
	{
		bool_0 = true;
		if (dateTime_7 == dateTime_6 && dateTime_7.Kind == dateTime_6.Kind)
		{
			dateTime_7 = dateTime_5;
		}
		if (dateTime_8 == dateTime_6 && dateTime_8.Kind == dateTime_6.Kind)
		{
			dateTime_8 = dateTime_5;
		}
		if (dateTime_9 == dateTime_6 && dateTime_9.Kind == dateTime_6.Kind)
		{
			dateTime_9 = dateTime_5;
		}
		dateTime_3 = dateTime_7.ToUniversalTime();
		dateTime_2 = dateTime_8.ToUniversalTime();
		dateTime_1 = dateTime_9.ToUniversalTime();
		dateTime_0 = dateTime_1;
		if (!bool_2 && !bool_1)
		{
			bool_1 = true;
		}
		bool_6 = true;
	}

	internal static string smethod_2(string string_4, string string_5)
	{
		string text = null;
		text = ((string_5 == null) ? string_4 : ((!string.IsNullOrEmpty(string_5)) ? Path.Combine(string_5, Path.GetFileName(string_4)) : Path.GetFileName(string_4)));
		return Class21.smethod_3(text);
	}

	internal static GClass8 smethod_3(string string_4)
	{
		return smethod_9(string_4, ZipEntrySource.None, null, null);
	}

	internal static GClass8 smethod_4(string string_4, string string_5)
	{
		return smethod_9(string_5, ZipEntrySource.FileSystem, string_4, null);
	}

	internal static GClass8 smethod_5(string string_4, Stream stream_3)
	{
		return smethod_9(string_4, ZipEntrySource.Stream, stream_3, null);
	}

	internal static GClass8 smethod_6(string string_4, GDelegate0 gdelegate0_1)
	{
		return smethod_9(string_4, ZipEntrySource.WriteDelegate, gdelegate0_1, null);
	}

	internal static GClass8 smethod_7(string string_4, GDelegate1 gdelegate1_1, GDelegate2 gdelegate2_1)
	{
		return smethod_9(string_4, ZipEntrySource.JitStream, gdelegate1_1, gdelegate2_1);
	}

	internal static GClass8 smethod_8(string string_4)
	{
		return smethod_9(string_4, ZipEntrySource.ZipOutputStream, null, null);
	}

	private static GClass8 smethod_9(string string_4, ZipEntrySource zipEntrySource_1, object object_1, object object_2)
	{
		if (string.IsNullOrEmpty(string_4))
		{
			throw new ZipException("The entry name must be non-null and non-empty.");
		}
		GClass8 gClass = new GClass8();
		gClass.short_0 = 45;
		gClass.zipEntrySource_0 = zipEntrySource_1;
		gClass.dateTime_1 = (gClass.dateTime_2 = (gClass.dateTime_3 = DateTime.UtcNow));
		switch (zipEntrySource_1)
		{
		case ZipEntrySource.Stream:
			gClass.stream_1 = object_1 as Stream;
			break;
		case ZipEntrySource.WriteDelegate:
			gClass.gdelegate0_0 = object_1 as GDelegate0;
			break;
		case ZipEntrySource.JitStream:
			gClass.gdelegate1_0 = object_1 as GDelegate1;
			gClass.gdelegate2_0 = object_2 as GDelegate2;
			break;
		case ZipEntrySource.None:
			gClass.zipEntrySource_0 = ZipEntrySource.FileSystem;
			break;
		default:
		{
			string text = object_1 as string;
			if (string.IsNullOrEmpty(text))
			{
				throw new ZipException("The filename must be non-null and non-empty.");
			}
			try
			{
				gClass.dateTime_1 = File.GetLastWriteTime(text).ToUniversalTime();
				gClass.dateTime_3 = File.GetCreationTime(text).ToUniversalTime();
				gClass.dateTime_2 = File.GetLastAccessTime(text).ToUniversalTime();
				if (File.Exists(text) || Directory.Exists(text))
				{
					gClass.int_0 = (int)File.GetAttributes(text);
				}
				gClass.bool_0 = true;
				gClass.string_0 = Path.GetFullPath(text);
			}
			catch (PathTooLongException innerException)
			{
				throw new ZipException($"The path is too long, filename={text}", innerException);
			}
			break;
		}
		case ZipEntrySource.ZipOutputStream:
			break;
		}
		gClass.dateTime_0 = gClass.dateTime_1;
		gClass.string_1 = Class21.smethod_3(string_4);
		return gClass;
	}

	internal void method_2()
	{
		bool_4 = true;
		if (!string_1.EndsWith("/"))
		{
			string_1 += "/";
		}
	}

	public override string ToString()
	{
		return $"ZipEntry::{String_2}";
	}

	private void method_3()
	{
		long position = Stream_1.Position;
		try
		{
			Stream_1.Seek(long_4, SeekOrigin.Begin);
		}
		catch (IOException innerException)
		{
			throw new BadStateException($"Exception seeking  entry({String_2}) offset(0x{long_4:X8}) len(0x{Stream_1.Length:X8})", innerException);
		}
		byte[] array = new byte[30];
		Stream_1.Read(array, 0, array.Length);
		short num = (short)(array[26] + array[27] * 256);
		short num2 = (short)(array[28] + array[29] * 256);
		Stream_1.Seek(num + num2, SeekOrigin.Current);
		int_3 = 30 + num2 + num + smethod_10(encryptionAlgorithm_1);
		long_3 = long_4 + int_3;
		Stream_1.Seek(position, SeekOrigin.Begin);
	}

	internal static int smethod_10(EncryptionAlgorithm encryptionAlgorithm_2)
	{
		return encryptionAlgorithm_2 switch
		{
			EncryptionAlgorithm.None => 0, 
			EncryptionAlgorithm.PkzipWeak => 12, 
			_ => throw new ZipException("internal error"), 
		};
	}

	public void method_4()
	{
		method_22(".", null, null);
	}

	public void method_5(ExtractExistingFileAction extractExistingFileAction_1)
	{
		ExtractExistingFileAction_0 = extractExistingFileAction_1;
		method_22(".", null, null);
	}

	public void method_6(Stream stream_3)
	{
		method_22(null, stream_3, null);
	}

	public void method_7(string string_4)
	{
		method_22(string_4, null, null);
	}

	public void method_8(string string_4, ExtractExistingFileAction extractExistingFileAction_1)
	{
		ExtractExistingFileAction_0 = extractExistingFileAction_1;
		method_22(string_4, null, null);
	}

	public void method_9(string string_4)
	{
		method_22(".", null, string_4);
	}

	public void method_10(string string_4, string string_5)
	{
		method_22(string_4, null, string_5);
	}

	public void method_11(ExtractExistingFileAction extractExistingFileAction_1, string string_4)
	{
		ExtractExistingFileAction_0 = extractExistingFileAction_1;
		method_22(".", null, string_4);
	}

	public void method_12(string string_4, ExtractExistingFileAction extractExistingFileAction_1, string string_5)
	{
		ExtractExistingFileAction_0 = extractExistingFileAction_1;
		method_22(string_4, null, string_5);
	}

	public void method_13(Stream stream_3, string string_4)
	{
		method_22(null, stream_3, string_4);
	}

	public GStream7 method_14()
	{
		if (class27_0.GClass9_0 == null)
		{
			throw new InvalidOperationException("Use OpenReader() only with ZipFile.");
		}
		return method_16(string_3 ?? class27_0.String_1);
	}

	public GStream7 method_15(string string_4)
	{
		if (class27_0.GClass9_0 == null)
		{
			throw new InvalidOperationException("Use OpenReader() only with ZipFile.");
		}
		return method_16(string_4);
	}

	internal GStream7 method_16(string string_4)
	{
		method_31();
		method_30();
		method_32(string_4);
		if (zipEntrySource_0 != ZipEntrySource.ZipFile)
		{
			throw new BadStateException("You must call ZipFile.Save before calling OpenReader");
		}
		long length = ((short_8 == 0) ? long_1 : Int64_1);
		Stream stream_ = Stream_1;
		Stream_1.Seek(Int64_2, SeekOrigin.Begin);
		stream_2 = method_28(stream_);
		return new GStream7(method_27(stream_2), length);
	}

	private void method_17(long long_7, long long_8)
	{
		if (class27_0.GClass9_0 != null)
		{
			bool_12 = class27_0.GClass9_0.method_56(this, long_7, long_8);
		}
	}

	private void method_18(string string_4)
	{
		if (class27_0.GClass9_0 != null && !class27_0.GClass9_0.bool_16)
		{
			bool_12 = class27_0.GClass9_0.method_57(this, string_4, bool_18: true);
		}
	}

	private void method_19(string string_4)
	{
		if (class27_0.GClass9_0 != null && !class27_0.GClass9_0.bool_16)
		{
			class27_0.GClass9_0.method_57(this, string_4, bool_18: false);
		}
	}

	private void method_20(string string_4)
	{
		if (class27_0.GClass9_0 != null)
		{
			bool_12 = class27_0.GClass9_0.method_58(this, string_4);
		}
	}

	private static void smethod_11(string string_4)
	{
		if ((File.GetAttributes(string_4) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			File.SetAttributes(string_4, FileAttributes.Normal);
		}
		File.Delete(string_4);
	}

	private void method_21(string string_4, params object[] object_1)
	{
		if (class27_0.GClass9_0 != null && class27_0.GClass9_0.Boolean_6)
		{
			class27_0.GClass9_0.TextWriter_0.WriteLine(string_4, object_1);
		}
	}

	private void method_22(string string_4, Stream stream_3, string string_5)
	{
		if (class27_0 == null)
		{
			throw new BadStateException("This entry is an orphan");
		}
		if (class27_0.GClass9_0 == null)
		{
			throw new InvalidOperationException("Use Extract() only with ZipFile.");
		}
		class27_0.GClass9_0.method_40(bool_18: false);
		if (zipEntrySource_0 != ZipEntrySource.ZipFile)
		{
			throw new BadStateException("You must call ZipFile.Save before calling any Extract method");
		}
		method_18(string_4);
		bool_12 = false;
		string string_6 = null;
		Stream stream = null;
		bool flag = false;
		bool flag2 = false;
		try
		{
			method_31();
			method_30();
			if (method_33(string_4, stream_3, out string_6))
			{
				method_21("extract dir {0}...", string_6);
				method_19(string_4);
				return;
			}
			if (string_6 != null && File.Exists(string_6))
			{
				flag = true;
				int num = method_24(string_4, string_6);
				if (num == 2 || num == 1)
				{
					return;
				}
			}
			string text = string_5 ?? string_3 ?? class27_0.String_1;
			if (encryptionAlgorithm_1 != 0)
			{
				if (text == null)
				{
					throw new BadPasswordException();
				}
				method_32(text);
			}
			if (string_6 != null)
			{
				method_21("extract file {0}...", string_6);
				string_6 += ".tmp";
				string directoryName = Path.GetDirectoryName(string_6);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				else if (class27_0.GClass9_0 != null)
				{
					flag2 = class27_0.GClass9_0.bool_16;
				}
				stream = new FileStream(string_6, FileMode.CreateNew);
			}
			else
			{
				method_21("extract entry {0} to stream...", String_2);
				stream = stream_3;
			}
			if (bool_12)
			{
				return;
			}
			int int_ = method_26(stream);
			if (bool_12)
			{
				return;
			}
			method_23(int_);
			if (string_6 != null)
			{
				stream.Close();
				stream = null;
				string text2 = string_6;
				string text3 = null;
				string_6 = text2.Substring(0, text2.Length - 4);
				if (flag)
				{
					text3 = string_6 + ".PendingOverwrite";
					File.Move(string_6, text3);
				}
				File.Move(text2, string_6);
				method_29(string_6, bool_15: true);
				if (text3 != null && File.Exists(text3))
				{
					smethod_11(text3);
				}
				if (flag2 && String_2.IndexOf('/') != -1)
				{
					string directoryName2 = Path.GetDirectoryName(String_2);
					if (class27_0.GClass9_0[directoryName2] == null)
					{
						method_29(Path.GetDirectoryName(string_6), bool_15: false);
					}
				}
				if ((short_0 & 0xFF00) == 2560 || (short_0 & 0xFF00) == 0)
				{
					File.SetAttributes(string_6, (FileAttributes)int_0);
				}
			}
			method_19(string_4);
		}
		catch (Exception)
		{
			bool_12 = true;
			throw;
		}
		finally
		{
			if (bool_12 && string_6 != null)
			{
				stream?.Close();
				if (File.Exists(string_6) && !flag)
				{
					File.Delete(string_6);
				}
			}
		}
	}

	internal void method_23(int int_6)
	{
		if (int_6 != int_2)
		{
			throw new BadCrcException("CRC error: the file being extracted appears to be corrupted. " + $"Expected 0x{int_2:X8}, Actual 0x{int_6:X8}");
		}
	}

	private int method_24(string string_4, string string_5)
	{
		int num = 0;
		while (true)
		{
			switch (ExtractExistingFileAction_0)
			{
			case ExtractExistingFileAction.InvokeExtractProgressEvent:
				if (num <= 0)
				{
					method_20(string_4);
					if (bool_12)
					{
						return 2;
					}
					break;
				}
				throw new ZipException($"The file {string_5} already exists.");
			default:
				throw new ZipException($"The file {string_5} already exists.");
			case ExtractExistingFileAction.OverwriteSilently:
				method_21("the file {0} exists; will overwrite it...", string_5);
				return 0;
			case ExtractExistingFileAction.DoNotOverwrite:
				method_21("the file {0} exists; not extracting entry...", String_2);
				method_19(string_4);
				return 1;
			}
			num++;
		}
	}

	private void method_25(int int_6)
	{
		if (int_6 == 0)
		{
			throw new BadReadException($"bad read of entry {String_2} from compressed archive.");
		}
	}

	private int method_26(Stream stream_3)
	{
		int num = 0;
		Stream stream = Stream_1;
		try
		{
			stream.Seek(Int64_2, SeekOrigin.Begin);
			byte[] array = new byte[Int32_0];
			long num2 = ((short_8 != 0) ? Int64_1 : long_1);
			stream_2 = method_28(stream);
			Stream stream2 = method_27(stream_2);
			long num3 = 0L;
			using GStream7 gStream = new GStream7(stream2);
			while (num2 > 0L)
			{
				int count = (int)((num2 > array.Length) ? array.Length : num2);
				int num4 = gStream.Read(array, 0, count);
				method_25(num4);
				stream_3.Write(array, 0, num4);
				num2 -= num4;
				num3 += num4;
				method_17(num3, Int64_1);
				if (bool_12)
				{
					break;
				}
			}
			return gStream.Int32_0;
		}
		finally
		{
			if (stream is Stream3 stream3)
			{
				stream3.Dispose();
				stream_0 = null;
			}
		}
	}

	internal Stream method_27(Stream stream_3)
	{
		return short_8 switch
		{
			8 => new GStream0(stream_3, CompressionMode.Decompress, leaveOpen: true), 
			0 => stream_3, 
			_ => null, 
		};
	}

	internal Stream method_28(Stream stream_3)
	{
		Stream stream = null;
		if (encryptionAlgorithm_1 == EncryptionAlgorithm.PkzipWeak)
		{
			return new Stream2(stream_3, class23_0, CryptoMode.Decrypt);
		}
		return stream_3;
	}

	internal void method_29(string string_4, bool bool_15)
	{
		try
		{
			if (bool_0)
			{
				if (bool_15)
				{
					if (File.Exists(string_4))
					{
						File.SetCreationTimeUtc(string_4, dateTime_3);
						File.SetLastAccessTimeUtc(string_4, dateTime_2);
						File.SetLastWriteTimeUtc(string_4, dateTime_1);
					}
				}
				else if (Directory.Exists(string_4))
				{
					Directory.SetCreationTimeUtc(string_4, dateTime_3);
					Directory.SetLastAccessTimeUtc(string_4, dateTime_2);
					Directory.SetLastWriteTimeUtc(string_4, dateTime_1);
				}
			}
			else
			{
				DateTime lastWriteTime = Class21.smethod_13(DateTime_0);
				if (bool_15)
				{
					File.SetLastWriteTime(string_4, lastWriteTime);
				}
				else
				{
					Directory.SetLastWriteTime(string_4, lastWriteTime);
				}
			}
		}
		catch (IOException ex)
		{
			method_21("failed to set time on {0}: {1}", string_4, ex.Message);
		}
	}

	internal void method_30()
	{
		if (EncryptionAlgorithm_0 != EncryptionAlgorithm.PkzipWeak && EncryptionAlgorithm_0 != 0)
		{
			if (uint_1 != 0)
			{
				throw new ZipException($"Cannot extract: Entry {String_2} is encrypted with an algorithm not supported by DotNetZip: {String_5}");
			}
			throw new ZipException($"Cannot extract: Entry {String_2} uses an unsupported encryption algorithm ({(int)EncryptionAlgorithm_0:X2})");
		}
	}

	private void method_31()
	{
		if (short_8 != 0 && short_8 != 8)
		{
			throw new ZipException($"Entry {String_2} uses an unsupported compression method (0x{short_8:X2}, {String_6})");
		}
	}

	private void method_32(string string_4)
	{
		if (encryptionAlgorithm_1 != 0 && encryptionAlgorithm_1 == EncryptionAlgorithm.PkzipWeak)
		{
			if (string_4 == null)
			{
				throw new ZipException("Missing password.");
			}
			Stream_1.Seek(Int64_2 - 12L, SeekOrigin.Begin);
			class23_0 = Class23.smethod_1(string_4, this);
		}
	}

	private bool method_33(string string_4, Stream stream_3, out string string_5)
	{
		if (string_4 != null)
		{
			string text = String_2.Replace("\\", "/");
			if (text.IndexOf(':') == 1)
			{
				text = text.Substring(2);
			}
			if (text.StartsWith("/"))
			{
				text = text.Substring(1);
			}
			if (class27_0.GClass9_0.Boolean_3)
			{
				string_5 = Path.Combine(string_4, (text.IndexOf('/') != -1) ? Path.GetFileName(text) : text);
			}
			else
			{
				string_5 = Path.Combine(string_4, text);
			}
			string_5 = string_5.Replace("/", "\\");
			if (!Boolean_4 && !String_2.EndsWith("/"))
			{
				return false;
			}
			if (!Directory.Exists(string_5))
			{
				Directory.CreateDirectory(string_5);
				method_29(string_5, bool_15: false);
			}
			else if (ExtractExistingFileAction_0 == ExtractExistingFileAction.OverwriteSilently)
			{
				method_29(string_5, bool_15: false);
			}
			return true;
		}
		if (stream_3 != null)
		{
			string_5 = null;
			if (!Boolean_4 && !String_2.EndsWith("/"))
			{
				return false;
			}
			return true;
		}
		throw new ArgumentNullException("outstream");
	}

	private void method_34()
	{
		int_5++;
		long position = Stream_1.Position;
		Stream_1.Seek(long_4, SeekOrigin.Begin);
		byte[] array = new byte[30];
		Stream_1.Read(array, 0, array.Length);
		short num = (short)(array[26] + array[27] * 256);
		short short_ = (short)(array[28] + array[29] * 256);
		Stream_1.Seek(num, SeekOrigin.Current);
		method_35(Stream_1, short_);
		Stream_1.Seek(position, SeekOrigin.Begin);
		int_5--;
	}

	private static bool smethod_12(GClass8 gclass8_0, Encoding encoding_4)
	{
		int num = 0;
		gclass8_0.long_4 = gclass8_0.Stream_1.Position;
		int num2 = Class21.smethod_9(gclass8_0.Stream_1);
		num = 4;
		if (smethod_14(num2))
		{
			gclass8_0.Stream_1.Seek(-4L, SeekOrigin.Current);
			if (smethod_1(num2) && num2 != 101010256L)
			{
				throw new BadReadException($"  Bad signature (0x{num2:X8}) at position  0x{gclass8_0.Stream_1.Position:X8}");
			}
			return false;
		}
		byte[] array = new byte[26];
		int num3 = gclass8_0.Stream_1.Read(array, 0, array.Length);
		if (num3 != array.Length)
		{
			return false;
		}
		num += num3;
		int num4 = 0;
		byte[] array2 = array;
		num4 = 1;
		byte num5 = array2[0];
		byte[] array3 = array;
		num4 = 2;
		gclass8_0.short_5 = (short)(num5 + array3[1] * 256);
		byte[] array4 = array;
		num4 = 3;
		byte num6 = array4[2];
		byte[] array5 = array;
		num4 = 4;
		gclass8_0.short_6 = (short)(num6 + array5[3] * 256);
		byte[] array6 = array;
		num4 = 5;
		byte num7 = array6[4];
		byte[] array7 = array;
		num4 = 6;
		gclass8_0.short_8 = (gclass8_0.short_7 = (short)(num7 + array7[5] * 256));
		byte[] array8 = array;
		num4 = 7;
		byte num8 = array8[6];
		byte[] array9 = array;
		num4 = 8;
		int num9 = num8 + array9[7] * 256;
		byte[] array10 = array;
		num4 = 9;
		int num10 = num9 + array10[8] * 256 * 256;
		byte[] array11 = array;
		num4 = 10;
		gclass8_0.int_1 = num10 + array11[9] * 256 * 256 * 256;
		gclass8_0.dateTime_0 = Class21.smethod_14(gclass8_0.int_1);
		gclass8_0.zipEntryTimestamp_0 |= ZipEntryTimestamp.DOS;
		if ((gclass8_0.short_6 & 1) == 1)
		{
			gclass8_0.encryptionAlgorithm_0 = EncryptionAlgorithm.PkzipWeak;
			gclass8_0.encryptionAlgorithm_1 = EncryptionAlgorithm.PkzipWeak;
			gclass8_0.bool_8 = true;
		}
		gclass8_0.int_2 = array[num4++] + array[num4++] * 256 + array[num4++] * 256 * 256 + array[num4++] * 256 * 256 * 256;
		gclass8_0.long_0 = (uint)(array[num4++] + array[num4++] * 256 + array[num4++] * 256 * 256 + array[num4++] * 256 * 256 * 256);
		gclass8_0.long_2 = (uint)(array[num4++] + array[num4++] * 256 + array[num4++] * 256 * 256 + array[num4++] * 256 * 256 * 256);
		if ((int)gclass8_0.long_0 == -1 || (int)gclass8_0.long_2 == -1)
		{
			gclass8_0.bool_10 = true;
		}
		short num11 = (short)(array[num4++] + array[num4++] * 256);
		short short_ = (short)(array[num4++] + array[num4++] * 256);
		array = new byte[num11];
		num3 = gclass8_0.Stream_1.Read(array, 0, array.Length);
		num += num3;
		if ((gclass8_0.short_6 & 0x800) == 2048)
		{
			gclass8_0.Encoding_1 = Encoding.UTF8;
			gclass8_0.ZipOption_0 = ZipOption.Always;
		}
		gclass8_0.string_1 = gclass8_0.Encoding_1.GetString(array, 0, array.Length);
		if (gclass8_0.string_1.EndsWith("/"))
		{
			gclass8_0.method_2();
		}
		num += gclass8_0.method_35(gclass8_0.Stream_1, short_);
		gclass8_0.int_4 = 0;
		if (!gclass8_0.string_1.EndsWith("/") && (gclass8_0.short_6 & 8) == 8)
		{
			long position = gclass8_0.Stream_1.Position;
			bool flag = true;
			long num12 = 0L;
			int num13 = 0;
			while (flag)
			{
				num13++;
				if (gclass8_0.class27_0.GClass9_0 != null)
				{
					gclass8_0.class27_0.GClass9_0.method_53(gclass8_0);
				}
				long num14 = Class21.smethod_12(gclass8_0.Stream_1, 134695760);
				if (num14 != -1L)
				{
					num12 += num14;
					if (gclass8_0.bool_10)
					{
						array = new byte[20];
						num3 = gclass8_0.Stream_1.Read(array, 0, array.Length);
						if (num3 != 20)
						{
							return false;
						}
						num4 = 0;
						byte[] array12 = array;
						num4 = 1;
						byte num15 = array12[0];
						byte[] array13 = array;
						num4 = 2;
						int num16 = num15 + array13[1] * 256;
						byte[] array14 = array;
						num4 = 3;
						int num17 = num16 + array14[2] * 256 * 256;
						byte[] array15 = array;
						num4 = 4;
						gclass8_0.int_2 = num17 + array15[3] * 256 * 256 * 256;
						gclass8_0.long_0 = BitConverter.ToInt64(array, 4);
						num4 = 12;
						gclass8_0.long_2 = BitConverter.ToInt64(array, 12);
						num4 = 20;
						gclass8_0.int_4 += 24;
					}
					else
					{
						array = new byte[12];
						num3 = gclass8_0.Stream_1.Read(array, 0, array.Length);
						if (num3 != 12)
						{
							return false;
						}
						num4 = 0;
						byte[] array16 = array;
						num4 = 1;
						byte num18 = array16[0];
						byte[] array17 = array;
						num4 = 2;
						int num19 = num18 + array17[1] * 256;
						byte[] array18 = array;
						num4 = 3;
						int num20 = num19 + array18[2] * 256 * 256;
						byte[] array19 = array;
						num4 = 4;
						gclass8_0.int_2 = num20 + array19[3] * 256 * 256 * 256;
						byte[] array20 = array;
						num4 = 5;
						byte num21 = array20[4];
						byte[] array21 = array;
						num4 = 6;
						int num22 = num21 + array21[5] * 256;
						byte[] array22 = array;
						num4 = 7;
						int num23 = num22 + array22[6] * 256 * 256;
						byte[] array23 = array;
						num4 = 8;
						gclass8_0.long_0 = (uint)(num23 + array23[7] * 256 * 256 * 256);
						byte[] array24 = array;
						num4 = 9;
						byte num24 = array24[8];
						byte[] array25 = array;
						num4 = 10;
						int num25 = num24 + array25[9] * 256;
						byte[] array26 = array;
						num4 = 11;
						int num26 = num25 + array26[10] * 256 * 256;
						byte[] array27 = array;
						num4 = 12;
						gclass8_0.long_2 = (uint)(num26 + array27[11] * 256 * 256 * 256);
						gclass8_0.int_4 += 16;
					}
					if (flag = num12 != gclass8_0.long_0)
					{
						gclass8_0.Stream_1.Seek(-12L, SeekOrigin.Current);
						num12 += 4L;
					}
					continue;
				}
				return false;
			}
			gclass8_0.Stream_1.Seek(position, SeekOrigin.Begin);
		}
		gclass8_0.long_1 = gclass8_0.long_0;
		if ((gclass8_0.short_6 & 1) == 1)
		{
			gclass8_0.byte_3 = new byte[12];
			num += smethod_13(gclass8_0.stream_0, gclass8_0.byte_3);
			gclass8_0.long_1 -= 12L;
		}
		gclass8_0.int_3 = num;
		gclass8_0.long_6 = gclass8_0.int_3 + gclass8_0.long_1 + gclass8_0.int_4;
		return true;
	}

	internal static int smethod_13(Stream stream_3, byte[] byte_4)
	{
		int num = stream_3.Read(byte_4, 0, 12);
		if (num != 12)
		{
			throw new ZipException($"Unexpected end of data at position 0x{stream_3.Position:X8}");
		}
		return num;
	}

	private static bool smethod_14(int int_6)
	{
		return int_6 != 67324752;
	}

	internal static GClass8 smethod_15(Class27 class27_1, bool bool_15)
	{
		GClass9 gClass9_ = class27_1.GClass9_0;
		Stream stream = class27_1.Stream_0;
		Encoding encoding_ = class27_1.Encoding_0;
		GClass8 gClass = new GClass8();
		gClass.zipEntrySource_0 = ZipEntrySource.ZipFile;
		gClass.class27_0 = class27_1;
		gClass.stream_0 = stream;
		gClass9_?.method_54(bool_18: true, null);
		if (bool_15)
		{
			smethod_16(stream);
		}
		if (!smethod_12(gClass, encoding_))
		{
			return null;
		}
		gClass.long_3 = gClass.Stream_1.Position;
		stream.Seek(gClass.long_1 + gClass.int_4, SeekOrigin.Current);
		smethod_17(gClass);
		if (gClass9_ != null)
		{
			gClass9_.method_53(gClass);
			gClass9_.method_54(bool_18: false, gClass);
		}
		return gClass;
	}

	internal static void smethod_16(Stream stream_3)
	{
		if (Class21.smethod_10(stream_3) != 808471376)
		{
			stream_3.Seek(-4L, SeekOrigin.Current);
		}
	}

	private static void smethod_17(GClass8 gclass8_0)
	{
		Stream stream = gclass8_0.Stream_1;
		if ((uint)Class21.smethod_10(stream) == gclass8_0.int_2)
		{
			if (Class21.smethod_10(stream) == gclass8_0.long_0)
			{
				if (Class21.smethod_10(stream) != gclass8_0.long_2)
				{
					stream.Seek(-12L, SeekOrigin.Current);
				}
			}
			else
			{
				stream.Seek(-8L, SeekOrigin.Current);
			}
		}
		else
		{
			stream.Seek(-4L, SeekOrigin.Current);
		}
	}

	internal static int smethod_18(byte[] byte_4, int int_6, ushort ushort_0)
	{
		int num = int_6;
		while (true)
		{
			if (num + 3 < byte_4.Length)
			{
				if ((ushort)(byte_4[num++] + byte_4[num++] * 256) == ushort_0)
				{
					break;
				}
				short num2 = (short)(byte_4[num++] + byte_4[num++] * 256);
				num += num2;
				continue;
			}
			return -1;
		}
		return num - 2;
	}

	internal int method_35(Stream stream_3, short short_9)
	{
		int num = 0;
		if (short_9 > 0)
		{
			byte[] array = (byte_1 = new byte[short_9]);
			num = stream_3.Read(array, 0, array.Length);
			long long_ = stream_3.Position - num;
			int num2 = 0;
			while (num2 + 3 < array.Length)
			{
				int num3 = num2;
				ushort num4 = (ushort)(array[num2++] + array[num2++] * 256);
				short num5 = (short)(array[num2++] + array[num2++] * 256);
				switch (num4)
				{
				case 23:
					num2 = method_36(array, num2);
					break;
				case 10:
					num2 = method_40(array, num2, num5, long_);
					break;
				case 1:
					num2 = method_37(array, num2, num5, long_);
					break;
				case 22613:
					num2 = method_38(array, num2, num5, long_);
					break;
				case 21589:
					num2 = method_39(array, num2, num5, long_);
					break;
				}
				num2 = num3 + num5 + 4;
			}
		}
		return num;
	}

	private int method_36(byte[] byte_4, int int_6)
	{
		int_6 += 2;
		uint_1 = (ushort)(byte_4[int_6++] + byte_4[int_6++] * 256);
		encryptionAlgorithm_0 = EncryptionAlgorithm.Unsupported;
		encryptionAlgorithm_1 = EncryptionAlgorithm.Unsupported;
		return int_6;
	}

	private int method_37(byte[] byte_4, int int_6, short short_9, long long_7)
	{
		bool_10 = true;
		if (short_9 > 28)
		{
			throw new BadReadException($"  Inconsistent size (0x{short_9:X4}) for ZIP64 extra field at position 0x{long_7:X16}");
		}
		int remainingData = short_9;
		Delegate1<long> @delegate = delegate
		{
			if (remainingData < 8)
			{
				throw new BadReadException($"  Missing data for ZIP64 extra field, position 0x{long_7:X16}");
			}
			long result = BitConverter.ToInt64(byte_4, int_6);
			int_6 += 8;
			remainingData -= 8;
			return result;
		};
		if (long_2 == 4294967295L)
		{
			long_2 = @delegate();
		}
		if (long_0 == 4294967295L)
		{
			long_0 = @delegate();
		}
		if (long_4 == 4294967295L)
		{
			long_4 = @delegate();
		}
		return int_6;
	}

	private int method_38(byte[] byte_4, int int_6, short short_9, long long_7)
	{
		if (short_9 != 12 && short_9 != 8)
		{
			throw new BadReadException($"  Unexpected size (0x{short_9:X4}) for InfoZip v1 extra field at position 0x{long_7:X16}");
		}
		int num = BitConverter.ToInt32(byte_4, int_6);
		dateTime_1 = dateTime_4.AddSeconds(num);
		int_6 += 4;
		num = BitConverter.ToInt32(byte_4, int_6);
		dateTime_2 = dateTime_4.AddSeconds(num);
		int_6 += 4;
		dateTime_3 = DateTime.UtcNow;
		bool_0 = true;
		zipEntryTimestamp_0 |= ZipEntryTimestamp.InfoZip1;
		return int_6;
	}

	private int method_39(byte[] byte_4, int int_6, short short_9, long long_7)
	{
		if (short_9 != 13 && short_9 != 9 && short_9 != 5)
		{
			throw new BadReadException($"  Unexpected size (0x{short_9:X4}) for Extended Timestamp extra field at position 0x{long_7:X16}");
		}
		int remainingData = short_9;
		Delegate1<DateTime> @delegate = delegate
		{
			int num = BitConverter.ToInt32(byte_4, int_6);
			int_6 += 4;
			remainingData -= 4;
			return dateTime_4.AddSeconds(num);
		};
		if (short_9 != 13 && int_5 <= 0)
		{
			method_34();
		}
		else
		{
			byte b = byte_4[int_6++];
			remainingData--;
			if (((uint)b & (true ? 1u : 0u)) != 0 && remainingData >= 4)
			{
				dateTime_1 = @delegate();
			}
			dateTime_2 = (((b & 2) == 0 || remainingData < 4) ? DateTime.UtcNow : @delegate());
			dateTime_3 = (((b & 4) == 0 || remainingData < 4) ? DateTime.UtcNow : @delegate());
			zipEntryTimestamp_0 |= ZipEntryTimestamp.Unix;
			bool_0 = true;
			bool_2 = true;
		}
		return int_6;
	}

	private int method_40(byte[] byte_4, int int_6, short short_9, long long_7)
	{
		if (short_9 != 32)
		{
			throw new BadReadException($"  Unexpected size (0x{short_9:X4}) for NTFS times extra field at position 0x{long_7:X16}");
		}
		int_6 += 4;
		short num = (short)(byte_4[int_6] + byte_4[int_6 + 1] * 256);
		short num2 = (short)(byte_4[int_6 + 2] + byte_4[int_6 + 3] * 256);
		int_6 += 4;
		if (num == 1 && num2 == 24)
		{
			long fileTime = BitConverter.ToInt64(byte_4, int_6);
			dateTime_1 = DateTime.FromFileTimeUtc(fileTime);
			int_6 += 8;
			fileTime = BitConverter.ToInt64(byte_4, int_6);
			dateTime_2 = DateTime.FromFileTimeUtc(fileTime);
			int_6 += 8;
			fileTime = BitConverter.ToInt64(byte_4, int_6);
			dateTime_3 = DateTime.FromFileTimeUtc(fileTime);
			int_6 += 8;
			bool_0 = true;
			zipEntryTimestamp_0 |= ZipEntryTimestamp.Windows;
			bool_1 = true;
		}
		return int_6;
	}

	internal void method_41(Stream stream_3)
	{
		byte[] array = new byte[4096];
		int num = 0;
		num = 1;
		array[0] = 80;
		num = 2;
		array[1] = 75;
		num = 3;
		array[2] = 1;
		num = 4;
		array[3] = 2;
		num = 5;
		array[4] = (byte)((uint)short_0 & 0xFFu);
		num = 6;
		array[5] = (byte)((short_0 & 0xFF00) >> 8);
		short num2 = (short)((Int16_0 != 0) ? Int16_0 : 20);
		if (!nullable_2.HasValue)
		{
			nullable_2 = class27_0.Zip64Option_0 == Zip64Option.Always;
		}
		short num3 = (short)(nullable_2.Value ? 45 : num2);
		array[num++] = (byte)((uint)num3 & 0xFFu);
		array[num++] = (byte)((num3 & 0xFF00) >> 8);
		array[num++] = (byte)((uint)short_6 & 0xFFu);
		array[num++] = (byte)((short_6 & 0xFF00) >> 8);
		array[num++] = (byte)((uint)short_7 & 0xFFu);
		array[num++] = (byte)((short_7 & 0xFF00) >> 8);
		array[num++] = (byte)((uint)int_1 & 0xFFu);
		array[num++] = (byte)((int_1 & 0xFF00) >> 8);
		array[num++] = (byte)((int_1 & 0xFF0000) >> 16);
		array[num++] = (byte)((int_1 & 0xFF000000L) >> 24);
		array[num++] = (byte)((uint)int_2 & 0xFFu);
		array[num++] = (byte)((int_2 & 0xFF00) >> 8);
		array[num++] = (byte)((int_2 & 0xFF0000) >> 16);
		array[num++] = (byte)((int_2 & 0xFF000000L) >> 24);
		int num4 = 0;
		if (nullable_2.Value)
		{
			for (num4 = 0; num4 < 8; num4++)
			{
				array[num++] = byte.MaxValue;
			}
		}
		else
		{
			array[num++] = (byte)((ulong)long_0 & 0xFFuL);
			array[num++] = (byte)((long_0 & 0xFF00L) >> 8);
			array[num++] = (byte)((long_0 & 0xFF0000L) >> 16);
			array[num++] = (byte)((long_0 & 0xFF000000L) >> 24);
			array[num++] = (byte)((ulong)long_2 & 0xFFuL);
			array[num++] = (byte)((long_2 & 0xFF00L) >> 8);
			array[num++] = (byte)((long_2 & 0xFF0000L) >> 16);
			array[num++] = (byte)((long_2 & 0xFF000000L) >> 24);
		}
		byte[] array2 = method_44();
		short num5 = (short)array2.Length;
		array[num++] = (byte)((uint)num5 & 0xFFu);
		array[num++] = (byte)((num5 & 0xFF00) >> 8);
		bool_13 = nullable_2.Value;
		byte_1 = method_42(bool_15: true);
		short num6 = (short)((byte_1 != null) ? byte_1.Length : 0);
		array[num++] = (byte)((uint)num6 & 0xFFu);
		array[num++] = (byte)((num6 & 0xFF00) >> 8);
		int num7 = ((byte_0 != null) ? byte_0.Length : 0);
		if (num7 + num > array.Length)
		{
			num7 = array.Length - num;
		}
		array[num++] = (byte)((uint)num7 & 0xFFu);
		array[num++] = (byte)((num7 & 0xFF00) >> 8);
		if (class27_0.GClass9_0 != null && class27_0.GClass9_0.Int32_2 != 0)
		{
			array[num++] = (byte)(uint_0 & 0xFFu);
			array[num++] = (byte)((uint_0 & 0xFF00) >> 8);
		}
		else
		{
			array[num++] = 0;
			array[num++] = 0;
		}
		array[num++] = (byte)(bool_14 ? 1u : 0u);
		array[num++] = 0;
		array[num++] = (byte)((uint)int_0 & 0xFFu);
		array[num++] = (byte)((int_0 & 0xFF00) >> 8);
		array[num++] = (byte)((int_0 & 0xFF0000) >> 16);
		array[num++] = (byte)((int_0 & 0xFF000000L) >> 24);
		if (long_4 > 4294967295L)
		{
			array[num++] = byte.MaxValue;
			array[num++] = byte.MaxValue;
			array[num++] = byte.MaxValue;
			array[num++] = byte.MaxValue;
		}
		else
		{
			array[num++] = (byte)((ulong)long_4 & 0xFFuL);
			array[num++] = (byte)((long_4 & 0xFF00L) >> 8);
			array[num++] = (byte)((long_4 & 0xFF0000L) >> 16);
			array[num++] = (byte)((long_4 & 0xFF000000L) >> 24);
		}
		Buffer.BlockCopy(array2, 0, array, num, num5);
		num += num5;
		if (byte_1 != null)
		{
			Buffer.BlockCopy(byte_1, 0, array, num, num6);
			num += num6;
		}
		if (num7 != 0)
		{
			Buffer.BlockCopy(byte_0, 0, array, num, num7);
			num += num7;
		}
		stream_3.Write(array, 0, num);
	}

	private byte[] method_42(bool bool_15)
	{
		List<byte[]> list = new List<byte[]>();
		if (class27_0.Zip64Option_0 == Zip64Option.Always || (class27_0.Zip64Option_0 == Zip64Option.AsNecessary && (!bool_15 || nullable_1.Value)))
		{
			int num = 4 + (bool_15 ? 28 : 16);
			byte[] array = new byte[num];
			int num2 = 0;
			if (bool_13 || bool_15)
			{
				array[num2++] = 1;
				array[num2++] = 0;
			}
			else
			{
				array[num2++] = 153;
				array[num2++] = 153;
			}
			array[num2++] = (byte)(num - 4);
			array[num2++] = 0;
			Array.Copy(BitConverter.GetBytes(long_2), 0, array, num2, 8);
			num2 += 8;
			Array.Copy(BitConverter.GetBytes(long_0), 0, array, num2, 8);
			num2 += 8;
			if (bool_15)
			{
				Array.Copy(BitConverter.GetBytes(long_4), 0, array, num2, 8);
				num2 += 8;
				Array.Copy(BitConverter.GetBytes(0), 0, array, num2, 4);
			}
			list.Add(array);
		}
		if (bool_0 && bool_1)
		{
			byte[] array = new byte[36]
			{
				10, 0, 32, 0, 0, 0, 0, 0, 1, 0,
				24, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0
			};
			Array.Copy(BitConverter.GetBytes(dateTime_1.ToFileTime()), 0, array, 12, 8);
			Array.Copy(BitConverter.GetBytes(dateTime_2.ToFileTime()), 0, array, 20, 8);
			Array.Copy(BitConverter.GetBytes(dateTime_3.ToFileTime()), 0, array, 28, 8);
			list.Add(array);
		}
		if (bool_0 && bool_2)
		{
			int num3 = 9;
			if (!bool_15)
			{
				num3 += 8;
			}
			byte[] array = new byte[num3];
			int num4 = 0;
			byte[] array2 = array;
			num4 = 1;
			array2[0] = 85;
			byte[] array3 = array;
			num4 = 2;
			array3[1] = 84;
			byte[] array4 = array;
			num4 = 3;
			array4[2] = (byte)(num3 - 4);
			byte[] array5 = array;
			num4 = 4;
			array5[3] = 0;
			byte[] array6 = array;
			num4 = 5;
			array6[4] = 7;
			Array.Copy(BitConverter.GetBytes((int)(dateTime_1 - dateTime_4).TotalSeconds), 0, array, 5, 4);
			num4 = 9;
			if (!bool_15)
			{
				Array.Copy(BitConverter.GetBytes((int)(dateTime_2 - dateTime_4).TotalSeconds), 0, array, num4, 4);
				num4 += 4;
				Array.Copy(BitConverter.GetBytes((int)(dateTime_3 - dateTime_4).TotalSeconds), 0, array, num4, 4);
				num4 += 4;
			}
			list.Add(array);
		}
		byte[] array7 = null;
		if (list.Count > 0)
		{
			int num5 = 0;
			int num6 = 0;
			for (int i = 0; i < list.Count; i++)
			{
				num5 += list[i].Length;
			}
			array7 = new byte[num5];
			for (int i = 0; i < list.Count; i++)
			{
				Array.Copy(list[i], 0, array7, num6, list[i].Length);
				num6 += list[i].Length;
			}
		}
		return array7;
	}

	private string method_43()
	{
		string text = String_2.Replace("\\", "/");
		string text2 = null;
		if (bool_3 && String_2.Length >= 3 && String_2[1] == ':' && text[2] == '/')
		{
			return text.Substring(3);
		}
		if (String_2.Length >= 4 && text[0] == '/' && text[1] == '/')
		{
			int num = text.IndexOf('/', 2);
			if (num == -1)
			{
				throw new ArgumentException("The path for that entry appears to be badly formatted");
			}
			return text.Substring(num + 1);
		}
		if (String_2.Length >= 3 && text[0] == '.' && text[1] == '/')
		{
			return text.Substring(2);
		}
		return text;
	}

	private byte[] method_44()
	{
		string text = method_43();
		switch (ZipOption_0)
		{
		case ZipOption.Always:
			if (string_2 != null && string_2.Length != 0)
			{
				byte_0 = Encoding_1.GetBytes(string_2);
			}
			encoding_3 = Encoding_1;
			return Encoding_1.GetBytes(text);
		default:
		{
			byte[] bytes = encoding_2.GetBytes(text);
			string @string = encoding_2.GetString(bytes, 0, bytes.Length);
			byte_0 = null;
			if (@string != text)
			{
				bytes = Encoding_1.GetBytes(text);
				if (string_2 != null && string_2.Length != 0)
				{
					byte_0 = Encoding_1.GetBytes(string_2);
				}
				encoding_3 = Encoding_1;
				return bytes;
			}
			encoding_3 = encoding_2;
			if (string_2 != null && string_2.Length != 0)
			{
				byte[] bytes2 = encoding_2.GetBytes(string_2);
				if (encoding_2.GetString(bytes2, 0, bytes2.Length) != String_3)
				{
					bytes = Encoding_1.GetBytes(text);
					byte_0 = Encoding_1.GetBytes(string_2);
					encoding_3 = Encoding_1;
					return bytes;
				}
				byte_0 = bytes2;
				return bytes;
			}
			return bytes;
		}
		case ZipOption.Default:
			if (string_2 != null && string_2.Length != 0)
			{
				byte_0 = encoding_2.GetBytes(string_2);
			}
			encoding_3 = encoding_2;
			return encoding_2.GetBytes(text);
		}
	}

	private bool method_45()
	{
		if (long_2 < 16L)
		{
			return false;
		}
		if (short_7 == 0)
		{
			return false;
		}
		if (CompressionLevel_0 == CompressionLevel.None)
		{
			return false;
		}
		if (long_0 < long_2)
		{
			return false;
		}
		if (zipEntrySource_0 == ZipEntrySource.Stream && !stream_1.CanSeek)
		{
			return false;
		}
		if (class23_1 != null && Int64_0 - 12L <= Int64_1)
		{
			return false;
		}
		return true;
	}

	private void method_46(int int_6)
	{
		if (int_6 > 1)
		{
			short_7 = 0;
		}
		else if (Boolean_4)
		{
			short_7 = 0;
		}
		else
		{
			if (zipEntrySource_0 == ZipEntrySource.ZipFile)
			{
				return;
			}
			if (zipEntrySource_0 == ZipEntrySource.Stream)
			{
				if (stream_1 != null && stream_1.CanSeek && stream_1.Length == 0L)
				{
					short_7 = 0;
					return;
				}
			}
			else if (zipEntrySource_0 == ZipEntrySource.FileSystem && Class21.smethod_0(String_1) == 0L)
			{
				short_7 = 0;
				return;
			}
			if (GDelegate3_0 != null)
			{
				CompressionLevel_0 = GDelegate3_0(String_1, string_1);
			}
			if (CompressionLevel_0 == CompressionLevel.None && CompressionMethod_0 == CompressionMethod.Deflate)
			{
				short_7 = 0;
			}
		}
	}

	internal void method_47(Stream stream_3, int int_6)
	{
		long_5 = (stream_3 as GStream4)?.Int64_2 ?? stream_3.Position;
		int num = 0;
		int num2 = 0;
		byte[] array = new byte[30];
		num2 = 1;
		array[0] = 80;
		num2 = 2;
		array[1] = 75;
		num2 = 3;
		array[2] = 3;
		num2 = 4;
		array[3] = 4;
		bool_13 = class27_0.Zip64Option_0 == Zip64Option.Always || (class27_0.Zip64Option_0 == Zip64Option.AsNecessary && !stream_3.CanSeek);
		short num3 = (short)(bool_13 ? 45 : 20);
		array[num2++] = (byte)((uint)num3 & 0xFFu);
		array[num2++] = (byte)((num3 & 0xFF00) >> 8);
		byte[] array2 = method_44();
		short num4 = (short)array2.Length;
		if (encryptionAlgorithm_0 == EncryptionAlgorithm.None)
		{
			short_6 &= -2;
		}
		else
		{
			short_6 |= 1;
		}
		if (encoding_3.CodePage == Encoding.UTF8.CodePage)
		{
			short_6 |= 2048;
		}
		if (!Boolean_4 && int_6 != 99)
		{
			if (!stream_3.CanSeek)
			{
				short_6 |= 8;
			}
		}
		else
		{
			short_6 &= -9;
			short_6 &= -2;
			EncryptionAlgorithm_0 = EncryptionAlgorithm.None;
			String_4 = null;
		}
		array[num2++] = (byte)((uint)short_6 & 0xFFu);
		array[num2++] = (byte)((short_6 & 0xFF00) >> 8);
		if (long_3 == -1L)
		{
			long_0 = 0L;
			bool_5 = false;
		}
		method_46(int_6);
		array[num2++] = (byte)((uint)short_7 & 0xFFu);
		array[num2++] = (byte)((short_7 & 0xFF00) >> 8);
		if (int_6 == 99)
		{
			method_56();
		}
		int_1 = Class21.smethod_15(DateTime_0);
		array[num2++] = (byte)((uint)int_1 & 0xFFu);
		array[num2++] = (byte)((int_1 & 0xFF00) >> 8);
		array[num2++] = (byte)((int_1 & 0xFF0000) >> 16);
		array[num2++] = (byte)((int_1 & 0xFF000000L) >> 24);
		array[num2++] = (byte)((uint)int_2 & 0xFFu);
		array[num2++] = (byte)((int_2 & 0xFF00) >> 8);
		array[num2++] = (byte)((int_2 & 0xFF0000) >> 16);
		array[num2++] = (byte)((int_2 & 0xFF000000L) >> 24);
		if (bool_13)
		{
			for (num = 0; num < 8; num++)
			{
				array[num2++] = byte.MaxValue;
			}
		}
		else
		{
			array[num2++] = (byte)((ulong)long_0 & 0xFFuL);
			array[num2++] = (byte)((long_0 & 0xFF00L) >> 8);
			array[num2++] = (byte)((long_0 & 0xFF0000L) >> 16);
			array[num2++] = (byte)((long_0 & 0xFF000000L) >> 24);
			array[num2++] = (byte)((ulong)long_2 & 0xFFuL);
			array[num2++] = (byte)((long_2 & 0xFF00L) >> 8);
			array[num2++] = (byte)((long_2 & 0xFF0000L) >> 16);
			array[num2++] = (byte)((long_2 & 0xFF000000L) >> 24);
		}
		array[num2++] = (byte)((uint)num4 & 0xFFu);
		array[num2++] = (byte)((num4 & 0xFF00) >> 8);
		byte_1 = method_42(bool_15: false);
		short num5 = (short)((byte_1 != null) ? byte_1.Length : 0);
		array[num2++] = (byte)((uint)num5 & 0xFFu);
		array[num2++] = (byte)((num5 & 0xFF00) >> 8);
		byte[] array3 = new byte[num2 + num4 + num5];
		Buffer.BlockCopy(array, 0, array3, 0, num2);
		Buffer.BlockCopy(array2, 0, array3, num2, array2.Length);
		num2 += array2.Length;
		if (byte_1 != null)
		{
			Buffer.BlockCopy(byte_1, 0, array3, num2, byte_1.Length);
			num2 += byte_1.Length;
		}
		int_3 = num2;
		Stream3 stream = stream_3 as Stream3;
		if (stream != null)
		{
			stream.Boolean_0 = true;
			uint num6 = stream.method_1(num2);
			if (num6 != stream.UInt32_0)
			{
				long_5 = 0L;
			}
			else
			{
				long_5 = stream.Position;
			}
			uint_0 = num6;
		}
		if (class27_0.Zip64Option_0 == Zip64Option.Default && (uint)long_4 >= uint.MaxValue)
		{
			throw new ZipException("Offset within the zip archive exceeds 0xFFFFFFFF. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
		}
		stream_3.Write(array3, 0, num2);
		if (stream != null)
		{
			stream.Boolean_0 = false;
		}
		byte_2 = array3;
	}

	private int method_48()
	{
		if (!bool_5)
		{
			Stream stream = null;
			if (zipEntrySource_0 == ZipEntrySource.WriteDelegate)
			{
				GStream7 gStream = new GStream7(Stream.Null);
				gdelegate0_0(String_2, gStream);
				int_2 = gStream.Int32_0;
			}
			else if (zipEntrySource_0 != ZipEntrySource.ZipFile)
			{
				if (zipEntrySource_0 == ZipEntrySource.Stream)
				{
					method_49();
					stream = stream_1;
				}
				else if (zipEntrySource_0 == ZipEntrySource.JitStream)
				{
					if (stream_1 == null)
					{
						stream_1 = gdelegate1_0(String_2);
					}
					method_49();
					stream = stream_1;
				}
				else if (zipEntrySource_0 != ZipEntrySource.ZipOutputStream)
				{
					stream = File.Open(String_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				}
				GClass12 gClass = new GClass12();
				int_2 = gClass.method_0(stream);
				if (stream_1 == null)
				{
					stream.Dispose();
				}
			}
			bool_5 = true;
		}
		return int_2;
	}

	private void method_49()
	{
		if (stream_1 == null)
		{
			throw new ZipException($"The input stream is null for entry '{String_2}'.");
		}
		if (nullable_0.HasValue)
		{
			stream_1.Position = nullable_0.Value;
		}
		else if (stream_1.CanSeek)
		{
			nullable_0 = stream_1.Position;
		}
		else if (EncryptionAlgorithm_0 == EncryptionAlgorithm.PkzipWeak && zipEntrySource_0 != ZipEntrySource.ZipFile && (short_6 & 8) != 8)
		{
			throw new ZipException("It is not possible to use PKZIP encryption on a non-seekable input stream");
		}
	}

	internal void method_50(GClass8 gclass8_0)
	{
		long_3 = gclass8_0.long_3;
		CompressionMethod_0 = gclass8_0.CompressionMethod_0;
		short_8 = gclass8_0.short_8;
		long_1 = gclass8_0.long_1;
		long_2 = gclass8_0.long_2;
		short_6 = gclass8_0.short_6;
		zipEntrySource_0 = gclass8_0.zipEntrySource_0;
		dateTime_0 = gclass8_0.dateTime_0;
		dateTime_1 = gclass8_0.dateTime_1;
		dateTime_2 = gclass8_0.dateTime_2;
		dateTime_3 = gclass8_0.dateTime_3;
		bool_0 = gclass8_0.bool_0;
		bool_2 = gclass8_0.bool_2;
		bool_1 = gclass8_0.bool_1;
	}

	private void method_51(long long_7, long long_8)
	{
		if (class27_0.GClass9_0 != null)
		{
			bool_12 = class27_0.GClass9_0.method_46(this, long_7, long_8);
		}
	}

	private void method_52(Stream stream_3)
	{
		Stream stream_4 = null;
		long num = -1L;
		try
		{
			num = stream_3.Position;
		}
		catch (Exception)
		{
		}
		try
		{
			long num2 = method_53(ref stream_4);
			GStream4 gStream = new GStream4(stream_3);
			Stream stream;
			Stream stream2;
			if (num2 != 0L)
			{
				stream = method_59(gStream);
				stream2 = method_58(stream, num2);
			}
			else
			{
				stream = (stream2 = gStream);
			}
			GStream7 gStream2 = new GStream7(stream2, leaveOpen: true);
			if (zipEntrySource_0 == ZipEntrySource.WriteDelegate)
			{
				gdelegate0_0(String_2, gStream2);
			}
			else
			{
				byte[] array = new byte[Int32_0];
				int count;
				while ((count = Class21.smethod_18(stream_4, array, 0, array.Length, String_2)) != 0)
				{
					gStream2.Write(array, 0, count);
					method_51(gStream2.Int64_0, num2);
					if (bool_12)
					{
						break;
					}
				}
			}
			method_54(stream_3, gStream, stream, stream2, gStream2);
		}
		finally
		{
			if (zipEntrySource_0 == ZipEntrySource.JitStream)
			{
				if (gdelegate2_0 != null)
				{
					gdelegate2_0(String_2, stream_4);
				}
			}
			else if (stream_4 is FileStream)
			{
				stream_4.Dispose();
			}
		}
		if (!bool_12)
		{
			long_3 = num;
			method_55(stream_3);
		}
	}

	private long method_53(ref Stream stream_3)
	{
		long result = -1L;
		if (zipEntrySource_0 == ZipEntrySource.Stream)
		{
			method_49();
			stream_3 = stream_1;
			try
			{
				result = stream_1.Length;
				return result;
			}
			catch (NotSupportedException)
			{
				return result;
			}
		}
		if (zipEntrySource_0 == ZipEntrySource.ZipFile)
		{
			string string_ = ((encryptionAlgorithm_1 == EncryptionAlgorithm.None) ? null : (string_3 ?? class27_0.String_1));
			stream_1 = method_16(string_);
			method_49();
			stream_3 = stream_1;
			result = stream_1.Length;
		}
		else
		{
			if (zipEntrySource_0 == ZipEntrySource.JitStream)
			{
				if (stream_1 == null)
				{
					stream_1 = gdelegate1_0(String_2);
				}
				method_49();
				stream_3 = stream_1;
				try
				{
					result = stream_1.Length;
					return result;
				}
				catch (NotSupportedException)
				{
					return result;
				}
			}
			if (zipEntrySource_0 == ZipEntrySource.FileSystem)
			{
				stream_3 = File.Open(String_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
				result = stream_3.Length;
			}
		}
		return result;
	}

	internal void method_54(Stream stream_3, GStream4 gstream4_0, Stream stream_4, Stream stream_5, GStream7 gstream7_0)
	{
		if (gstream7_0 != null)
		{
			gstream7_0.Close();
			if (stream_5 is GStream0)
			{
				stream_5.Close();
			}
			else if (stream_5 is GStream2)
			{
				stream_5.Close();
			}
			stream_4.Flush();
			stream_4.Close();
			int_4 = 0;
			long_2 = gstream7_0.Int64_0;
			long_1 = gstream4_0.Int64_0;
			long_0 = long_1;
			int_2 = gstream7_0.Int32_0;
			method_62();
		}
	}

	internal void method_55(Stream stream_3)
	{
		GStream4 gStream = stream_3 as GStream4;
		if (long_2 == 0L && long_0 == 0L)
		{
			if (zipEntrySource_0 == ZipEntrySource.ZipOutputStream)
			{
				return;
			}
			if (string_3 != null)
			{
				int num = 0;
				if (EncryptionAlgorithm_0 == EncryptionAlgorithm.PkzipWeak)
				{
					num = 12;
				}
				if (zipEntrySource_0 == ZipEntrySource.ZipOutputStream && !stream_3.CanSeek)
				{
					throw new ZipException("Zero bytes written, encryption in use, and non-seekable output.");
				}
				if (EncryptionAlgorithm_0 != 0)
				{
					stream_3.Seek(-1 * num, SeekOrigin.Current);
					stream_3.SetLength(stream_3.Position);
					gStream?.method_0(num);
					int_3 -= num;
					long_3 -= num;
				}
				string_3 = null;
				short_6 &= -2;
				byte_2[6] = (byte)((uint)short_6 & 0xFFu);
				byte_2[7] = (byte)((short_6 & 0xFF00) >> 8);
			}
			CompressionMethod_0 = CompressionMethod.None;
			EncryptionAlgorithm_0 = EncryptionAlgorithm.None;
		}
		else if (class23_1 != null && EncryptionAlgorithm_0 == EncryptionAlgorithm.PkzipWeak)
		{
			long_0 += 12L;
		}
		int num2 = 8;
		byte[] array = byte_2;
		num2 = 9;
		array[8] = (byte)((uint)short_7 & 0xFFu);
		byte[] array2 = byte_2;
		num2 = 10;
		array2[9] = (byte)((short_7 & 0xFF00) >> 8);
		num2 = 14;
		byte[] array3 = byte_2;
		num2 = 15;
		array3[14] = (byte)((uint)int_2 & 0xFFu);
		byte[] array4 = byte_2;
		num2 = 16;
		array4[15] = (byte)((int_2 & 0xFF00) >> 8);
		byte[] array5 = byte_2;
		num2 = 17;
		array5[16] = (byte)((int_2 & 0xFF0000) >> 16);
		byte[] array6 = byte_2;
		num2 = 18;
		array6[17] = (byte)((int_2 & 0xFF000000L) >> 24);
		method_56();
		short num3 = (short)(byte_2[26] + byte_2[27] * 256);
		short num4 = (short)(byte_2[28] + byte_2[29] * 256);
		if (nullable_2.Value)
		{
			byte_2[4] = 45;
			byte_2[5] = 0;
			for (int i = 0; i < 8; i++)
			{
				byte_2[num2++] = byte.MaxValue;
			}
			num2 = 30 + num3;
			byte_2[num2++] = 1;
			byte_2[num2++] = 0;
			num2 += 2;
			Array.Copy(BitConverter.GetBytes(long_2), 0, byte_2, num2, 8);
			num2 += 8;
			Array.Copy(BitConverter.GetBytes(long_0), 0, byte_2, num2, 8);
		}
		else
		{
			byte_2[4] = 20;
			byte_2[5] = 0;
			num2 = 18;
			byte[] array7 = byte_2;
			num2 = 19;
			array7[18] = (byte)((ulong)long_0 & 0xFFuL);
			byte[] array8 = byte_2;
			num2 = 20;
			array8[19] = (byte)((long_0 & 0xFF00L) >> 8);
			byte[] array9 = byte_2;
			num2 = 21;
			array9[20] = (byte)((long_0 & 0xFF0000L) >> 16);
			byte[] array10 = byte_2;
			num2 = 22;
			array10[21] = (byte)((long_0 & 0xFF000000L) >> 24);
			byte[] array11 = byte_2;
			num2 = 23;
			array11[22] = (byte)((ulong)long_2 & 0xFFuL);
			byte[] array12 = byte_2;
			num2 = 24;
			array12[23] = (byte)((long_2 & 0xFF00L) >> 8);
			byte[] array13 = byte_2;
			num2 = 25;
			array13[24] = (byte)((long_2 & 0xFF0000L) >> 16);
			byte[] array14 = byte_2;
			num2 = 26;
			array14[25] = (byte)((long_2 & 0xFF000000L) >> 24);
			if (num4 != 0)
			{
				num2 = 30 + num3;
				if ((short)(byte_2[num2 + 2] + byte_2[num2 + 3] * 256) == 16)
				{
					byte_2[num2++] = 153;
					byte_2[num2++] = 153;
				}
			}
		}
		if ((short_6 & 8) != 8 || (zipEntrySource_0 == ZipEntrySource.ZipOutputStream && stream_3.CanSeek))
		{
			if (stream_3 is Stream3 stream && uint_0 != stream.UInt32_0)
			{
				using Stream stream2 = Stream3.smethod_2(class27_0.GClass9_0.String_1, uint_0);
				stream2.Seek(long_4, SeekOrigin.Begin);
				stream2.Write(byte_2, 0, byte_2.Length);
			}
			else
			{
				stream_3.Seek(long_4, SeekOrigin.Begin);
				stream_3.Write(byte_2, 0, byte_2.Length);
				gStream?.method_0(byte_2.Length);
				stream_3.Seek(long_0, SeekOrigin.Current);
			}
		}
		if ((short_6 & 8) == 8 && !Boolean_4)
		{
			byte[] array15 = new byte[16 + (nullable_2.Value ? 8 : 0)];
			num2 = 0;
			Array.Copy(BitConverter.GetBytes(134695760), 0, array15, 0, 4);
			num2 = 4;
			Array.Copy(BitConverter.GetBytes(int_2), 0, array15, 4, 4);
			num2 = 8;
			if (nullable_2.Value)
			{
				Array.Copy(BitConverter.GetBytes(long_0), 0, array15, num2, 8);
				num2 += 8;
				Array.Copy(BitConverter.GetBytes(long_2), 0, array15, num2, 8);
				num2 += 8;
			}
			else
			{
				array15[num2++] = (byte)((ulong)long_0 & 0xFFuL);
				array15[num2++] = (byte)((long_0 & 0xFF00L) >> 8);
				array15[num2++] = (byte)((long_0 & 0xFF0000L) >> 16);
				array15[num2++] = (byte)((long_0 & 0xFF000000L) >> 24);
				array15[num2++] = (byte)((ulong)long_2 & 0xFFuL);
				array15[num2++] = (byte)((long_2 & 0xFF00L) >> 8);
				array15[num2++] = (byte)((long_2 & 0xFF0000L) >> 16);
				array15[num2++] = (byte)((long_2 & 0xFF000000L) >> 24);
			}
			stream_3.Write(array15, 0, array15.Length);
			int_4 += array15.Length;
		}
	}

	private void method_56()
	{
		nullable_1 = long_0 >= 4294967295L || long_2 >= 4294967295L || long_4 >= 4294967295L;
		if (class27_0.Zip64Option_0 == Zip64Option.Default && nullable_1.Value)
		{
			throw new ZipException("Compressed or Uncompressed size, or offset exceeds the maximum value. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
		}
		nullable_2 = class27_0.Zip64Option_0 == Zip64Option.Always || nullable_1.Value;
	}

	internal void method_57(Stream stream_3, long long_7, out GStream4 gstream4_0, out Stream stream_4, out Stream stream_5, out GStream7 gstream7_0)
	{
		gstream4_0 = new GStream4(stream_3);
		if (long_7 != 0L)
		{
			stream_4 = method_59(gstream4_0);
			stream_5 = method_58(stream_4, long_7);
		}
		else
		{
			stream_4 = (stream_5 = gstream4_0);
		}
		gstream7_0 = new GStream7(stream_5, leaveOpen: true);
	}

	private Stream method_58(Stream stream_3, long long_7)
	{
		if (short_7 == 8 && CompressionLevel_0 != 0)
		{
			if (class27_0.Int64_0 != 0L && (long_7 <= class27_0.Int64_0 || class27_0.Int64_0 <= 0L))
			{
				GStream0 gStream = new GStream0(stream_3, CompressionMode.Compress, CompressionLevel_0, leaveOpen: true);
				if (class27_0.Int32_2 > 0)
				{
					gStream.Int32_0 = class27_0.Int32_2;
				}
				gStream.CompressionStrategy_0 = class27_0.CompressionStrategy_0;
				return gStream;
			}
			if (class27_0.GStream2_0 == null)
			{
				class27_0.GStream2_0 = new GStream2(stream_3, CompressionLevel_0, class27_0.CompressionStrategy_0, leaveOpen: true);
				if (class27_0.Int32_2 > 0)
				{
					class27_0.GStream2_0.Int32_1 = class27_0.Int32_2;
				}
				if (class27_0.Int32_1 > 0)
				{
					class27_0.GStream2_0.Int32_0 = class27_0.Int32_1;
				}
			}
			GStream2 gStream2_ = class27_0.GStream2_0;
			gStream2_.method_4(stream_3);
			return gStream2_;
		}
		return stream_3;
	}

	private Stream method_59(Stream stream_3)
	{
		if (EncryptionAlgorithm_0 == EncryptionAlgorithm.PkzipWeak)
		{
			return new Stream2(stream_3, class23_1, CryptoMode.Encrypt);
		}
		return stream_3;
	}

	private void method_60(Exception exception_0)
	{
		if (class27_0.GClass9_0 != null)
		{
			bool_12 = class27_0.GClass9_0.method_64(this, exception_0);
		}
	}

	internal void method_61(Stream stream_3)
	{
		GStream4 gStream = stream_3 as GStream4;
		Stream3 stream = stream_3 as Stream3;
		bool flag = false;
		do
		{
			try
			{
				if (zipEntrySource_0 == ZipEntrySource.ZipFile && !bool_7)
				{
					method_65(stream_3);
					break;
				}
				if (Boolean_4)
				{
					method_47(stream_3, 1);
					method_62();
					nullable_1 = long_4 >= 4294967295L;
					nullable_2 = class27_0.Zip64Option_0 == Zip64Option.Always || nullable_1.Value;
					if (stream != null)
					{
						uint_0 = stream.UInt32_0;
					}
					break;
				}
				bool flag2 = true;
				int num = 0;
				do
				{
					num++;
					method_47(stream_3, num);
					method_64(stream_3);
					method_52(stream_3);
					long_6 = int_3 + long_1 + int_4;
					flag2 = num <= 1 && stream_3.CanSeek && method_45();
					if (flag2)
					{
						if (stream != null)
						{
							stream.method_4(uint_0, long_4);
						}
						else
						{
							stream_3.Seek(long_4, SeekOrigin.Begin);
						}
						stream_3.SetLength(stream_3.Position);
						gStream?.method_0(long_6);
					}
				}
				while (flag2);
				bool_9 = false;
				flag = true;
			}
			catch (Exception ex)
			{
				ZipErrorAction zipErrorAction = ZipErrorAction_0;
				int num2 = 0;
				while (true)
				{
					if (ZipErrorAction_0 != 0)
					{
						if (ZipErrorAction_0 != ZipErrorAction.Skip && ZipErrorAction_0 != ZipErrorAction.Retry)
						{
							if (num2 <= 0)
							{
								if (ZipErrorAction_0 == ZipErrorAction.InvokeErrorEvent)
								{
									method_60(ex);
									if (bool_12)
									{
										flag = true;
										break;
									}
								}
								num2++;
								continue;
							}
							throw;
						}
						long num3 = gStream?.Int64_2 ?? stream_3.Position;
						long num4 = num3 - long_5;
						if (num4 > 0L)
						{
							stream_3.Seek(num4, SeekOrigin.Current);
							long position = stream_3.Position;
							stream_3.SetLength(stream_3.Position);
							gStream?.method_0(num3 - position);
						}
						if (ZipErrorAction_0 == ZipErrorAction.Skip)
						{
							method_21("Skipping file {0} (exception: {1})", String_1, ex.ToString());
							bool_9 = true;
							flag = true;
						}
						else
						{
							ZipErrorAction_0 = zipErrorAction;
						}
						break;
					}
					throw;
				}
			}
		}
		while (!flag);
	}

	internal void method_62()
	{
		long_4 = long_5;
	}

	internal void method_63()
	{
		encryptionAlgorithm_1 = encryptionAlgorithm_0;
		short_8 = short_7;
		bool_7 = false;
		bool_6 = false;
		zipEntrySource_0 = ZipEntrySource.ZipFile;
	}

	internal void method_64(Stream stream_3)
	{
		if (EncryptionAlgorithm_0 == EncryptionAlgorithm.None)
		{
			return;
		}
		string text = string_3;
		if (zipEntrySource_0 == ZipEntrySource.ZipFile && text == null)
		{
			text = class27_0.String_1;
		}
		if (text == null)
		{
			class23_1 = null;
		}
		else if (EncryptionAlgorithm_0 == EncryptionAlgorithm.PkzipWeak)
		{
			class23_1 = Class23.smethod_0(text);
			Random random = new Random();
			byte[] array = new byte[12];
			random.NextBytes(array);
			if ((short_6 & 8) == 8)
			{
				int_1 = Class21.smethod_15(DateTime_0);
				array[11] = (byte)((uint)(int_1 >> 8) & 0xFFu);
			}
			else
			{
				method_48();
				array[11] = (byte)((uint)(int_2 >> 24) & 0xFFu);
			}
			byte[] array2 = class23_1.method_1(array, array.Length);
			stream_3.Write(array2, 0, array2.Length);
			int_3 += array2.Length;
		}
	}

	private void method_65(Stream stream_3)
	{
		if (Int32_2 == 0)
		{
			throw new BadStateException("Bad header length.");
		}
		if (bool_6 || Stream_1 is Stream3 || stream_3 is Stream3 || (bool_10 && class27_0.Zip64Option_1 == Zip64Option.Default) || (!bool_10 && class27_0.Zip64Option_1 == Zip64Option.Always))
		{
			method_66(stream_3);
		}
		else
		{
			method_67(stream_3);
		}
		nullable_1 = long_0 >= 4294967295L || long_2 >= 4294967295L || long_4 >= 4294967295L;
		nullable_2 = class27_0.Zip64Option_0 == Zip64Option.Always || nullable_1.Value;
	}

	private void method_66(Stream stream_3)
	{
		byte[] array = new byte[Int32_0];
		GStream4 gStream = new GStream4(Stream_1);
		long num = long_4;
		int int32_ = Int32_2;
		method_47(stream_3, 0);
		method_62();
		if (!String_2.EndsWith("/"))
		{
			long num2 = num + int32_;
			int num3 = smethod_10(encryptionAlgorithm_1);
			num2 -= num3;
			int_3 += num3;
			gStream.Seek(num2, SeekOrigin.Begin);
			long num4 = long_0;
			while (num4 > 0L)
			{
				num3 = (int)((num4 > array.Length) ? array.Length : num4);
				int num5 = gStream.Read(array, 0, num3);
				stream_3.Write(array, 0, num5);
				num4 -= num5;
				method_51(gStream.Int64_1, long_0);
				if (bool_12)
				{
					break;
				}
			}
			if ((short_6 & 8) == 8)
			{
				int num6 = 16;
				if (bool_10)
				{
					num6 += 8;
				}
				byte[] buffer = new byte[num6];
				gStream.Read(buffer, 0, num6);
				if (bool_10 && class27_0.Zip64Option_1 == Zip64Option.Default)
				{
					stream_3.Write(buffer, 0, 8);
					if (long_0 > 4294967295L)
					{
						throw new InvalidOperationException("ZIP64 is required");
					}
					stream_3.Write(buffer, 8, 4);
					if (long_2 > 4294967295L)
					{
						throw new InvalidOperationException("ZIP64 is required");
					}
					stream_3.Write(buffer, 16, 4);
					int_4 -= 8;
				}
				else if (!bool_10 && class27_0.Zip64Option_1 == Zip64Option.Always)
				{
					byte[] buffer2 = new byte[4];
					stream_3.Write(buffer, 0, 8);
					stream_3.Write(buffer, 8, 4);
					stream_3.Write(buffer2, 0, 4);
					stream_3.Write(buffer, 12, 4);
					stream_3.Write(buffer2, 0, 4);
					int_4 += 8;
				}
				else
				{
					stream_3.Write(buffer, 0, num6);
				}
			}
		}
		long_6 = int_3 + long_1 + int_4;
	}

	private void method_67(Stream stream_3)
	{
		byte[] array = new byte[Int32_0];
		GStream4 gStream = new GStream4(Stream_1);
		gStream.Seek(long_4, SeekOrigin.Begin);
		if (long_6 == 0L)
		{
			long_6 = int_3 + long_1 + int_4;
		}
		long_4 = (stream_3 as GStream4)?.Int64_2 ?? stream_3.Position;
		long num = long_6;
		while (num > 0L)
		{
			int count = (int)((num > array.Length) ? array.Length : num);
			int num2 = gStream.Read(array, 0, count);
			stream_3.Write(array, 0, num2);
			num -= num2;
			method_51(gStream.Int64_1, long_6);
			if (bool_12)
			{
				break;
			}
		}
	}

	[Conditional("Trace")]
	private void method_68(string string_4, params object[] object_1)
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
