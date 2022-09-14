using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Ionic.Zip;
using Microsoft.CSharp;
using ns0;
using ns1;
using ns10;
using ns11;
using ns14;
using ns15;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns9;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
[ComVisible(true)]
public sealed class GClass1 : IEnumerable<GClass0>, IEnumerable, IDisposable
{
	private sealed class Class25
	{
		public SelfExtractorFlavor selfExtractorFlavor_0;

		public List<string> list_0;

		public List<string> list_1;

		public List<string> list_2;
	}

	[CompilerGenerated]
	private sealed class Class26
	{
		public StringComparison stringComparison_0;

		public int method_0(GClass0 gclass0_0, GClass0 gclass0_1)
		{
			return string.Compare(gclass0_0.string_1, gclass0_1.string_1, stringComparison_0);
		}
	}

	internal TextWriter textWriter_0;

	internal bool bool_0;

	internal Stream stream_0;

	internal Stream stream_1;

	internal ushort ushort_0;

	internal ushort ushort_1;

	internal uint uint_0;

	internal int int_0;

	internal uint uint_1;

	private Enum1 enum1_0;

	private bool bool_1;

	internal Dictionary<string, GClass0> dictionary_0;

	internal List<GClass0> list_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal string string_3;

	internal bool bool_2 = true;

	internal bool bool_3;

	internal Enum21 enum21_0;

	internal CompressionMethod compressionMethod_0 = CompressionMethod.Deflate;

	internal bool bool_4;

	internal string string_4;

	internal bool bool_5;

	internal bool bool_6;

	internal string string_5;

	internal bool bool_7 = true;

	internal object object_0 = new object();

	internal bool bool_8;

	internal bool bool_9;

	internal bool bool_10;

	internal Enum2 enum2_0;

	internal bool bool_11;

	internal long long_0 = -1L;

	internal uint uint_2;

	internal long long_1;

	internal bool? nullable_0;

	internal bool bool_12;

	internal Encoding encoding_0 = Encoding.GetEncoding("IBM437");

	internal Enum9 enum9_0;

	internal static Encoding encoding_1 = Encoding.GetEncoding("IBM437");

	internal int int_1 = int_3;

	internal Stream11 stream11_0;

	internal long long_2;

	internal int int_2 = 16;

	internal Enum8 enum8_0;

	internal bool bool_13;

	public static readonly int int_3 = 32768;

	internal EventHandler<EventArgs3> eventHandler_0;

	internal EventHandler<EventArgs1> eventHandler_1;

	private long long_3 = -99L;

	internal EventHandler<EventArgs4> eventHandler_2;

	internal EventHandler<EventArgs2> eventHandler_3;

	internal EventHandler<EventArgs5> eventHandler_4;

	private static Class25[] class25_0 = new Class25[2]
	{
		new Class25
		{
			selfExtractorFlavor_0 = SelfExtractorFlavor.WinFormsApplication,
			list_0 = new List<string> { "System.dll", "System.Windows.Forms.dll", "System.Drawing.dll" },
			list_1 = new List<string> { "Ionic.Zip.WinFormsSelfExtractorStub.resources", "Ionic.Zip.Forms.PasswordDialog.resources", "Ionic.Zip.Forms.ZipContentsDialog.resources" },
			list_2 = new List<string> { "WinFormsSelfExtractorStub.cs", "WinFormsSelfExtractorStub.Designer.cs", "PasswordDialog.cs", "PasswordDialog.Designer.cs", "ZipContentsDialog.cs", "ZipContentsDialog.Designer.cs", "FolderBrowserDialogEx.cs" }
		},
		new Class25
		{
			selfExtractorFlavor_0 = SelfExtractorFlavor.ConsoleApplication,
			list_0 = new List<string> { "System.dll" },
			list_1 = null,
			list_2 = new List<string> { "CommandLineSelfExtractorStub.cs" }
		}
	};

	[CompilerGenerated]
	private bool bool_14;

	[CompilerGenerated]
	private bool bool_15;

	[CompilerGenerated]
	private bool bool_16;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private bool bool_17;

	[CompilerGenerated]
	private Enum20 enum20_0;

	[CompilerGenerated]
	private Enum3 enum3_0;

	[CompilerGenerated]
	private Delegate3 delegate3_0;

	public string Info
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"          ZipFile: {string_0}\n");
			if (!string.IsNullOrEmpty(string_2))
			{
				stringBuilder.Append($"          Comment: {string_2}\n");
			}
			if (ushort_0 != 0)
			{
				stringBuilder.Append($"  version made by: 0x{ushort_0:X4}\n");
			}
			if (ushort_1 != 0)
			{
				stringBuilder.Append($"needed to extract: 0x{ushort_1:X4}\n");
			}
			stringBuilder.Append($"       uses ZIP64: {InputUsesZip64}\n");
			stringBuilder.Append($"     disk with CD: {uint_0}\n");
			if (uint_2 == uint.MaxValue)
			{
				stringBuilder.Append($"      CD64 offset: 0x{long_1:X16}\n");
			}
			else
			{
				stringBuilder.Append($"        CD offset: 0x{uint_2:X8}\n");
			}
			stringBuilder.Append("\n");
			foreach (GClass0 value in dictionary_0.Values)
			{
				stringBuilder.Append(value.Info);
			}
			return stringBuilder.ToString();
		}
	}

	public bool FullScan
	{
		[CompilerGenerated]
		get
		{
			return bool_14;
		}
		[CompilerGenerated]
		set
		{
			bool_14 = value;
		}
	}

	public bool SortEntriesBeforeSaving
	{
		[CompilerGenerated]
		get
		{
			return bool_15;
		}
		[CompilerGenerated]
		set
		{
			bool_15 = value;
		}
	}

	public bool AddDirectoryWillTraverseReparsePoints
	{
		[CompilerGenerated]
		get
		{
			return bool_16;
		}
		[CompilerGenerated]
		set
		{
			bool_16 = value;
		}
	}

	public int BufferSize
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	public int CodecBufferSize
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		set
		{
			int_4 = value;
		}
	}

	public bool FlattenFoldersOnExtract
	{
		[CompilerGenerated]
		get
		{
			return bool_17;
		}
		[CompilerGenerated]
		set
		{
			bool_17 = value;
		}
	}

	public Enum21 Strategy
	{
		get
		{
			return enum21_0;
		}
		set
		{
			enum21_0 = value;
		}
	}

	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public Enum20 CompressionLevel
	{
		[CompilerGenerated]
		get
		{
			return enum20_0;
		}
		[CompilerGenerated]
		set
		{
			enum20_0 = value;
		}
	}

	public CompressionMethod CompressionMethod
	{
		get
		{
			return compressionMethod_0;
		}
		set
		{
			compressionMethod_0 = value;
		}
	}

	public string Comment
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			bool_5 = true;
		}
	}

	public bool EmitTimesInWindowsFormatWhenSaving
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public bool EmitTimesInUnixFormatWhenSaving
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	internal bool Verbose => textWriter_0 != null;

	public bool CaseSensitiveRetrieval
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (value != bool_0)
			{
				bool_0 = value;
				Class6.smethod_510(this);
			}
		}
	}

	public bool UseUnicodeAsNecessary
	{
		get
		{
			if (encoding_0 == Encoding.GetEncoding("UTF-8"))
			{
				return enum9_0 == Enum9.const_2;
			}
			return false;
		}
		set
		{
			if (value)
			{
				encoding_0 = Encoding.GetEncoding("UTF-8");
				enum9_0 = Enum9.const_2;
			}
			else
			{
				encoding_0 = encoding_1;
				enum9_0 = Enum9.const_0;
			}
		}
	}

	public Enum8 UseZip64WhenSaving
	{
		get
		{
			return enum8_0;
		}
		set
		{
			enum8_0 = value;
		}
	}

	public bool? RequiresZip64
	{
		get
		{
			if (dictionary_0.Count > 65534)
			{
				return true;
			}
			if (bool_6 && !bool_5)
			{
				foreach (GClass0 value in dictionary_0.Values)
				{
					bool? nullable_ = value.nullable_1;
					if (nullable_.Value)
					{
						return true;
					}
				}
				return false;
			}
			return null;
		}
	}

	public bool? OutputUsedZip64 => nullable_0;

	public bool? InputUsesZip64
	{
		get
		{
			if (dictionary_0.Count > 65534)
			{
				return true;
			}
			foreach (GClass0 item in (IEnumerable<GClass0>)this)
			{
				if (item.enum0_0 == Enum0.const_3)
				{
					if (item.bool_10)
					{
						return true;
					}
					continue;
				}
				return null;
			}
			return false;
		}
	}

	public Encoding ProvisionalAlternateEncoding
	{
		get
		{
			if (enum9_0 == Enum9.const_2)
			{
				return encoding_0;
			}
			return null;
		}
		set
		{
			encoding_0 = value;
			enum9_0 = Enum9.const_2;
		}
	}

	public Encoding AlternateEncoding
	{
		get
		{
			return encoding_0;
		}
		set
		{
			encoding_0 = value;
		}
	}

	public Enum9 AlternateEncodingUsage
	{
		get
		{
			return enum9_0;
		}
		set
		{
			enum9_0 = value;
		}
	}

	public static Encoding DefaultEncoding => encoding_1;

	public TextWriter StatusMessageTextWriter
	{
		get
		{
			return textWriter_0;
		}
		set
		{
			textWriter_0 = value;
		}
	}

	public string TempFileFolder
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
			if (value == null || Directory.Exists(value))
			{
				return;
			}
			throw new FileNotFoundException($"That directory ({value}) does not exist.");
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
				Encryption = Enum2.const_0;
			}
			else if (enum2_0 == Enum2.const_0)
			{
				Encryption = Enum2.const_1;
			}
		}
	}

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
		get
		{
			if (eventHandler_4 != null)
			{
				enum1_0 = Enum1.const_3;
			}
			return enum1_0;
		}
		set
		{
			enum1_0 = value;
			if (enum1_0 != Enum1.const_3 && eventHandler_4 != null)
			{
				eventHandler_4 = null;
			}
		}
	}

	public Enum2 Encryption
	{
		get
		{
			return enum2_0;
		}
		set
		{
			if (value == Enum2.const_4)
			{
				throw new InvalidOperationException("You may not set Encryption to that value.");
			}
			enum2_0 = value;
		}
	}

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

	public int MaxOutputSegmentSize
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value < 65536 && value != 0)
			{
				throw new ZipException("The minimum acceptable segment size is 65536.");
			}
			int_0 = value;
		}
	}

	public int NumberOfSegmentsForMostRecentSave => (int)(uint_1 + 1);

	public long ParallelDeflateThreshold
	{
		get
		{
			return long_2;
		}
		set
		{
			if (value != 0L && value != -1L && value < 65536L)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateThreshold should be -1, 0, or > 65536");
			}
			long_2 = value;
		}
	}

	public int ParallelDeflateMaxBufferPairs
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
			}
			int_2 = value;
		}
	}

	public static Version LibraryVersion => Assembly.GetExecutingAssembly().GetName().Version;

	private List<GClass0> ZipEntriesAsList
	{
		get
		{
			if (list_0 == null)
			{
				list_0 = new List<GClass0>(dictionary_0.Values);
			}
			return list_0;
		}
	}

	public GClass0 this[int int_5] => ZipEntriesAsList[int_5];

	public GClass0 this[string string_6]
	{
		get
		{
			string text = Class6.smethod_260(string_6);
			if (dictionary_0.ContainsKey(text))
			{
				return dictionary_0[text];
			}
			text = text.Replace("/", "\\");
			if (dictionary_0.ContainsKey(text))
			{
				return dictionary_0[text];
			}
			return null;
		}
	}

	public ICollection<string> EntryFileNames => dictionary_0.Keys;

	public ICollection<GClass0> Entries => dictionary_0.Values;

	public ICollection<GClass0> EntriesSorted
	{
		get
		{
			List<GClass0> list = new List<GClass0>();
			foreach (GClass0 entry in Entries)
			{
				list.Add(entry);
			}
			StringComparison stringComparison_0 = (bool_0 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
			list.Sort((GClass0 gclass0_0, GClass0 gclass0_1) => string.Compare(gclass0_0.string_1, gclass0_1.string_1, stringComparison_0));
			return list.AsReadOnly();
		}
	}

	public int Count => dictionary_0.Count;

	internal Stream ReadStream
	{
		get
		{
			if (stream_0 == null && (string_1 != null || string_0 != null))
			{
				stream_0 = File.Open(string_1 ?? string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				bool_7 = true;
			}
			return stream_0;
		}
	}

	internal Stream WriteStream
	{
		get
		{
			if (stream_1 != null)
			{
				return stream_1;
			}
			if (string_0 == null)
			{
				return stream_1;
			}
			if (int_0 != 0)
			{
				stream_1 = Class6.smethod_48(string_0, int_0);
				return stream_1;
			}
			Class6.smethod_296(string_5 ?? Path.GetDirectoryName(string_0), out stream_1, out string_4);
			return stream_1;
		}
		private set
		{
			if (value != null)
			{
				throw new ZipException("Cannot set the stream to a non-null value.");
			}
			stream_1 = null;
		}
	}

	internal string ArchiveNameForEvent
	{
		get
		{
			if (string_0 == null)
			{
				return "(stream)";
			}
			return string_0;
		}
	}

	internal long LengthOfReadStream
	{
		get
		{
			if (long_3 == -99L)
			{
				long_3 = (bool_7 ? Class6.smethod_545(string_0) : (-1L));
			}
			return long_3;
		}
	}

	public event EventHandler<EventArgs3> SaveProgress
	{
		add
		{
			EventHandler<EventArgs3> eventHandler = eventHandler_0;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> value2 = (EventHandler<EventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<EventArgs3> eventHandler = eventHandler_0;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> value2 = (EventHandler<EventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<EventArgs1> ReadProgress
	{
		add
		{
			EventHandler<EventArgs1> eventHandler = eventHandler_1;
			EventHandler<EventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs1> value2 = (EventHandler<EventArgs1>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<EventArgs1> eventHandler = eventHandler_1;
			EventHandler<EventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs1> value2 = (EventHandler<EventArgs1>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<EventArgs4> ExtractProgress
	{
		add
		{
			EventHandler<EventArgs4> eventHandler = eventHandler_2;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> value2 = (EventHandler<EventArgs4>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<EventArgs4> eventHandler = eventHandler_2;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> value2 = (EventHandler<EventArgs4>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<EventArgs2> AddProgress
	{
		add
		{
			EventHandler<EventArgs2> eventHandler = eventHandler_3;
			EventHandler<EventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs2> value2 = (EventHandler<EventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<EventArgs2> eventHandler = eventHandler_3;
			EventHandler<EventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs2> value2 = (EventHandler<EventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<EventArgs5> ZipError
	{
		add
		{
			EventHandler<EventArgs5> eventHandler = eventHandler_4;
			EventHandler<EventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5> value2 = (EventHandler<EventArgs5>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<EventArgs5> eventHandler = eventHandler_4;
			EventHandler<EventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5> value2 = (EventHandler<EventArgs5>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	string object.ToString()
	{
		return $"ZipFile::{string_0}";
	}

	internal void method_0(bool bool_18)
	{
		if (!bool_11)
		{
			return;
		}
		using (GClass1 gClass = new GClass1())
		{
			gClass.string_1 = (gClass.string_0 = (bool_18 ? (string_1 ?? string_0) : string_0));
			gClass.encoding_0 = encoding_0;
			gClass.enum9_0 = enum9_0;
			Class6.smethod_101(gClass);
			using IEnumerator<GClass0> enumerator = gClass.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
			while (enumerator.MoveNext())
			{
				GClass0 current = enumerator.Current;
				foreach (GClass0 item in (IEnumerable<GClass0>)this)
				{
					if (current.string_1 == item.string_1)
					{
						Class6.smethod_133(item, current);
						break;
					}
				}
			}
		}
		bool_11 = false;
	}

	public GClass1(string string_6)
	{
		try
		{
			Class6.smethod_438(string_6, this, (TextWriter)null);
		}
		catch (Exception exception_)
		{
			throw new ZipException($"Could not read {string_6} as a zip file", exception_);
		}
	}

	public GClass1(string string_6, Encoding encoding_2)
	{
		try
		{
			encoding_0 = encoding_2;
			enum9_0 = Enum9.const_3;
			Class6.smethod_438(string_6, this, (TextWriter)null);
		}
		catch (Exception exception_)
		{
			throw new ZipException($"{string_6} is not a valid zip file", exception_);
		}
	}

	public GClass1()
	{
		Class6.smethod_438((string)null, this, (TextWriter)null);
	}

	public GClass1(Encoding encoding_2)
	{
		encoding_0 = encoding_2;
		enum9_0 = Enum9.const_3;
		Class6.smethod_438((string)null, this, (TextWriter)null);
	}

	public GClass1(string string_6, TextWriter textWriter_1)
	{
		try
		{
			Class6.smethod_438(string_6, this, textWriter_1);
		}
		catch (Exception exception_)
		{
			throw new ZipException($"{string_6} is not a valid zip file", exception_);
		}
	}

	public GClass1(string string_6, TextWriter textWriter_1, Encoding encoding_2)
	{
		try
		{
			encoding_0 = encoding_2;
			enum9_0 = Enum9.const_3;
			Class6.smethod_438(string_6, this, textWriter_1);
		}
		catch (Exception exception_)
		{
			throw new ZipException($"{string_6} is not a valid zip file", exception_);
		}
	}

	void IDisposable.Dispose()
	{
		vmethod_0(bool_18: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_0(bool bool_18)
	{
		if (bool_1)
		{
			return;
		}
		if (bool_18)
		{
			if (bool_7 && stream_0 != null)
			{
				stream_0.Dispose();
				stream_0 = null;
			}
			if (string_4 != null && string_0 != null && stream_1 != null)
			{
				stream_1.Dispose();
				stream_1 = null;
			}
			if (stream11_0 != null)
			{
				stream11_0.method_2();
				stream11_0 = null;
			}
		}
		bool_1 = true;
	}

	internal void method_1(string string_6, bool bool_18)
	{
		bool flag = textWriter_0 != null;
		bool_12 = true;
		try
		{
			Class6.smethod_443(this, string_6);
			int num = 0;
			foreach (GClass0 value in dictionary_0.Values)
			{
				if (flag)
				{
					textWriter_0.WriteLine("\n{1,-22} {2,-8} {3,4}   {4,-8}  {0}", "Name", "Modified", "Size", "Ratio", "Packed");
					textWriter_0.WriteLine(new string('-', 72));
					flag = false;
				}
				if (textWriter_0 != null)
				{
					textWriter_0.WriteLine("{1,-22} {2,-8} {3,4:F0}%   {4,-8} {0}", value.string_1, value.LastModified.ToString("yyyy-MM-dd HH:mm:ss"), value.long_2, value.CompressionRatio, value.long_0);
					if (!string.IsNullOrEmpty(value.string_2))
					{
						textWriter_0.WriteLine("  Comment: {0}", value.string_2);
					}
				}
				value.Password = string_3;
				Class6.smethod_289(string_6, this, value, bool_0: true, num);
				if (bool_18)
				{
					value.ExtractExistingFile = ExtractExistingFile;
				}
				Class6.smethod_185(value, string_6);
				num++;
				Class6.smethod_289(string_6, this, value, bool_0: false, num);
				if (bool_9)
				{
					break;
				}
			}
			if (bool_9)
			{
				return;
			}
			foreach (GClass0 value2 in dictionary_0.Values)
			{
				if (value2.bool_4 || value2.string_1.EndsWith("/"))
				{
					string text = (value2.string_1.StartsWith("/") ? Path.Combine(string_6, value2.string_1.Substring(1)) : Path.Combine(string_6, value2.string_1));
					Class6.smethod_110(bool_0: false, value2, text);
				}
			}
			Class6.smethod_97(this, string_6);
		}
		finally
		{
			bool_12 = false;
		}
	}

	internal void method_2(string string_6, Class30 class30_0)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		string text = null;
		string text2 = null;
		string text3 = null;
		string text4 = null;
		try
		{
			if (File.Exists(string_6) && textWriter_0 != null)
			{
				textWriter_0.WriteLine("The existing file ({0}) will be overwritten.", string_6);
			}
			if (!string_6.EndsWith(".exe") && textWriter_0 != null)
			{
				textWriter_0.WriteLine("Warning: The generated self-extracting file will not have an .exe extension.");
			}
			text4 = string_5 ?? Path.GetDirectoryName(string_6);
			text2 = Class6.smethod_182("exe", text4);
			Assembly assembly = typeof(GClass1).Assembly;
			CSharpCodeProvider val = new CSharpCodeProvider();
			try
			{
				Class25 @class = null;
				Class25[] array = class25_0;
				foreach (Class25 class2 in array)
				{
					if (class2.selfExtractorFlavor_0 == class30_0.method_0())
					{
						@class = class2;
						break;
					}
				}
				if (@class == null)
				{
					throw new BadStateException($"While saving a Self-Extracting Zip, Cannot find that flavor ({class30_0.method_0()})?");
				}
				CompilerParameters val2 = new CompilerParameters();
				val2.get_ReferencedAssemblies().Add(assembly.Location);
				if (@class.list_0 != null)
				{
					foreach (string item in @class.list_0)
					{
						val2.get_ReferencedAssemblies().Add(item);
					}
				}
				val2.set_GenerateInMemory(false);
				val2.set_GenerateExecutable(true);
				val2.set_IncludeDebugInformation(false);
				val2.set_CompilerOptions("");
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				StringBuilder stringBuilder = new StringBuilder();
				string text5 = Class6.smethod_182("cs", text4);
				using (GClass1 gClass = Class6.smethod_548(executingAssembly.GetManifestResourceStream("Ionic.Zip.Resources.ZippedResources.zip")))
				{
					text3 = Class6.smethod_182("tmp", text4);
					if (string.IsNullOrEmpty(class30_0.method_4()))
					{
						Directory.CreateDirectory(text3);
						GClass0 gClass2 = gClass["zippedFile.ico"];
						if ((gClass2.int_0 & 1) == 1)
						{
							gClass2.Attributes = (FileAttributes)(gClass2.int_0 ^ 1);
						}
						Class6.smethod_185(gClass2, text3);
						text = Path.Combine(text3, "zippedFile.ico");
						val2.set_CompilerOptions(val2.get_CompilerOptions() + $"/win32icon:\"{text}\"");
					}
					else
					{
						val2.set_CompilerOptions(val2.get_CompilerOptions() + $"/win32icon:\"{class30_0.method_4()}\"");
					}
					val2.set_OutputAssembly(text2);
					if (class30_0.method_0() == SelfExtractorFlavor.WinFormsApplication)
					{
						val2.set_CompilerOptions(val2.get_CompilerOptions() + " /target:winexe");
					}
					if (!string.IsNullOrEmpty(class30_0.method_14()))
					{
						val2.set_CompilerOptions(val2.get_CompilerOptions() + " " + class30_0.method_14());
					}
					if (string.IsNullOrEmpty(val2.get_CompilerOptions()))
					{
						val2.set_CompilerOptions((string)null);
					}
					if (@class.list_1 != null && @class.list_1.Count != 0)
					{
						if (!Directory.Exists(text3))
						{
							Directory.CreateDirectory(text3);
						}
						foreach (string item2 in @class.list_1)
						{
							string value = Path.Combine(text3, item2);
							Class6.smethod_63(value, executingAssembly, item2);
							val2.get_EmbeddedResources().Add(value);
						}
					}
					val2.get_EmbeddedResources().Add(assembly.Location);
					stringBuilder.Append("// " + Path.GetFileName(text5) + "\n").Append("// --------------------------------------------\n//\n").Append("// This SFX source file was generated by DotNetZip ")
						.Append(LibraryVersion.ToString())
						.Append("\n//         at ")
						.Append(DateTime.Now.ToString("yyyy MMMM dd  HH:mm:ss"))
						.Append("\n//\n// --------------------------------------------\n\n\n");
					if (!string.IsNullOrEmpty(class30_0.method_11()))
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"" + class30_0.method_11().Replace("\"", "") + "\")]\n");
					}
					else
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"DotNetZip SFX Archive\")]\n");
					}
					if (!string.IsNullOrEmpty(class30_0.method_9()))
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyInformationalVersion(\"" + class30_0.method_9().Replace("\"", "") + "\")]\n");
					}
					string text6 = (string.IsNullOrEmpty(class30_0.method_10()) ? "Extractor: Copyright © Dino Chiesa 2008-2011" : class30_0.method_10().Replace("\"", ""));
					if (!string.IsNullOrEmpty(class30_0.method_12()))
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"").Append(class30_0.method_12().Replace("\"", "")).Append("\")]\n");
					}
					else
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"DotNetZip\")]\n");
					}
					stringBuilder.Append("[assembly: System.Reflection.AssemblyCopyright(\"" + text6 + "\")]\n").Append($"[assembly: System.Reflection.AssemblyVersion(\"{LibraryVersion.ToString()}\")]\n");
					if (class30_0.method_8() != null)
					{
						stringBuilder.Append($"[assembly: System.Reflection.AssemblyFileVersion(\"{class30_0.method_8().ToString()}\")]\n");
					}
					stringBuilder.Append("\n\n\n");
					string text7 = class30_0.method_3();
					if (text7 != null)
					{
						text7 = text7.Replace("\"", "").Replace("\\", "\\\\");
					}
					string text8 = class30_0.method_2();
					if (text8 != null)
					{
						text8 = text8.Replace("\\", "\\\\");
						text8 = text8.Replace("\"", "\\\"");
					}
					foreach (string item3 in @class.list_2)
					{
						using Stream stream = Class6.smethod_578(gClass[item3]);
						if (stream == null)
						{
							throw new ZipException($"missing resource '{item3}'");
						}
						using (StreamReader streamReader = new StreamReader(stream))
						{
							while (streamReader.Peek() >= 0)
							{
								string text9 = streamReader.ReadLine();
								if (text7 != null)
								{
									text9 = text9.Replace("@@EXTRACTLOCATION", text7);
								}
								text9 = text9.Replace("@@REMOVE_AFTER_EXECUTE", class30_0.method_7().ToString());
								text9 = text9.Replace("@@QUIET", class30_0.method_5().ToString());
								if (!string.IsNullOrEmpty(class30_0.method_13()))
								{
									text9 = text9.Replace("@@SFX_EXE_WINDOW_TITLE", class30_0.method_13());
								}
								text9 = text9.Replace("@@EXTRACT_EXISTING_FILE", ((int)class30_0.method_6()).ToString());
								if (text8 != null)
								{
									text9 = text9.Replace("@@POST_UNPACK_CMD_LINE", text8);
								}
								stringBuilder.Append(text9).Append("\n");
							}
						}
						stringBuilder.Append("\n\n");
					}
				}
				string text10 = stringBuilder.ToString();
				CompilerResults val3 = ((CodeDomProvider)val).CompileAssemblyFromSource(val2, new string[1] { text10 });
				if (val3 == null)
				{
					throw new SfxGenerationException("Cannot compile the extraction logic!");
				}
				if (textWriter_0 != null)
				{
					StringEnumerator enumerator4 = val3.get_Output().GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							string current4 = enumerator4.Current;
							textWriter_0.WriteLine(current4);
						}
					}
					finally
					{
						if (enumerator4 is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
				}
				if (((CollectionBase)(object)val3.get_Errors()).Count != 0)
				{
					using (TextWriter textWriter = new StreamWriter(text5))
					{
						textWriter.Write(text10);
						textWriter.Write("\n\n\n// ------------------------------------------------------------------\n");
						textWriter.Write("// Errors during compilation: \n//\n");
						string fileName = Path.GetFileName(text5);
						foreach (CompilerError item4 in (CollectionBase)(object)val3.get_Errors())
						{
							CompilerError val4 = item4;
							textWriter.Write(string.Format("//   {0}({1},{2}): {3} {4}: {5}\n//\n", fileName, val4.get_Line(), val4.get_Column(), val4.get_IsWarning() ? "Warning" : "error", val4.get_ErrorNumber(), val4.get_ErrorText()));
						}
					}
					throw new SfxGenerationException($"Errors compiling the extraction logic!  {text5}");
				}
				Class6.smethod_364(this, Enum6.const_15);
				using Stream stream2 = File.OpenRead(text2);
				byte[] array2 = new byte[4000];
				int num = 1;
				while (num != 0)
				{
					num = stream2.Read(array2, 0, array2.Length);
					if (num != 0)
					{
						WriteStream.Write(array2, 0, num);
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Class6.smethod_364(this, Enum6.const_12);
		}
		finally
		{
			try
			{
				if (Directory.Exists(text3))
				{
					try
					{
						Directory.Delete(text3, recursive: true);
					}
					catch (IOException arg)
					{
						textWriter_0.WriteLine("Warning: Exception: {0}", arg);
					}
				}
				if (File.Exists(text2))
				{
					try
					{
						File.Delete(text2);
					}
					catch (IOException arg2)
					{
						textWriter_0.WriteLine("Warning: Exception: {0}", arg2);
					}
				}
			}
			catch (IOException)
			{
			}
		}
	}

	IEnumerator<GClass0> IEnumerable<GClass0>.GetEnumerator()
	{
		//yield-return decompiler failed: Method not found
		Class27 @class = new Class27(0);
		@class.gclass1_0 = this;
		return @class;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<GClass0>)this).GetEnumerator();
	}

	[DispId(-4)]
	public IEnumerator method_3()
	{
		return ((IEnumerable<GClass0>)this).GetEnumerator();
	}
}
