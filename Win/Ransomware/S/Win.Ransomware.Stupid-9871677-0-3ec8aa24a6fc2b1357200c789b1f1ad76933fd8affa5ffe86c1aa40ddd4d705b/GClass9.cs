using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Ionic.Zip;
using Ionic.Zlib;
using Microsoft.CSharp;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
public class GClass9 : IDisposable, IEnumerable<GClass8>, IEnumerable
{
	private class Class25
	{
		public SelfExtractorFlavor selfExtractorFlavor_0;

		public List<string> list_0;

		public List<string> list_1;

		public List<string> list_2;
	}

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private CompressionLevel compressionLevel_0;

	[CompilerGenerated]
	private ExtractExistingFileAction extractExistingFileAction_0;

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	private TextWriter textWriter_0;

	private bool bool_4;

	private Stream stream_0;

	private Stream stream_1;

	private ushort ushort_0;

	private ushort ushort_1;

	private uint uint_0;

	private int int_1;

	private uint uint_1;

	private ZipErrorAction zipErrorAction_0;

	private bool bool_5;

	private Dictionary<string, GClass8> dictionary_0;

	private List<GClass8> list_0;

	private string string_0;

	private string string_1;

	private string string_2;

	internal string string_3;

	private bool bool_6 = true;

	private bool bool_7;

	private CompressionStrategy compressionStrategy_0;

	private CompressionMethod compressionMethod_0 = CompressionMethod.Deflate;

	private bool bool_8;

	private string string_4;

	private bool bool_9;

	private bool bool_10;

	private string string_5;

	private bool bool_11 = true;

	private object object_0 = new object();

	private bool bool_12;

	private bool bool_13;

	private bool bool_14;

	private EncryptionAlgorithm encryptionAlgorithm_0;

	private bool bool_15;

	private long long_0 = -1L;

	private uint uint_2;

	private long long_1;

	private bool? nullable_0;

	internal bool bool_16;

	private Encoding encoding_0 = Encoding.GetEncoding("IBM437");

	private ZipOption zipOption_0;

	private static Encoding encoding_1 = Encoding.GetEncoding("IBM437");

	private int int_2 = int_4;

	internal GStream2 gstream2_0;

	private long long_2;

	private int int_3 = 16;

	internal Zip64Option zip64Option_0;

	private bool bool_17;

	public static readonly int int_4 = 32768;

	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_0;

	[CompilerGenerated]
	private EventHandler<GEventArgs1> eventHandler_1;

	private long long_3 = -99L;

	[CompilerGenerated]
	private EventHandler<GEventArgs4> eventHandler_2;

	[CompilerGenerated]
	private EventHandler<GEventArgs2> eventHandler_3;

	[CompilerGenerated]
	private EventHandler<GEventArgs5> eventHandler_4;

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

	public string String_0
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"          ZipFile: {String_1}\n");
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
			stringBuilder.Append($"       uses ZIP64: {Nullable_2}\n");
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
			foreach (GClass8 value in dictionary_0.Values)
			{
				stringBuilder.Append(value.String_0);
			}
			return stringBuilder.ToString();
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool Boolean_2
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public bool Boolean_3
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public CompressionStrategy CompressionStrategy_0
	{
		get
		{
			return compressionStrategy_0;
		}
		set
		{
			compressionStrategy_0 = value;
		}
	}

	public string String_1
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

	public CompressionLevel CompressionLevel_0
	{
		[CompilerGenerated]
		get
		{
			return compressionLevel_0;
		}
		[CompilerGenerated]
		set
		{
			compressionLevel_0 = value;
		}
	}

	public CompressionMethod CompressionMethod_0
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

	public string String_2
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			bool_9 = true;
		}
	}

	public bool Boolean_4
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	public bool Boolean_5
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	internal bool Boolean_6 => textWriter_0 != null;

	public bool Boolean_7
	{
		get
		{
			return bool_4;
		}
		set
		{
			if (value != bool_4)
			{
				bool_4 = value;
				method_42();
			}
		}
	}

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool Boolean_8
	{
		get
		{
			if (encoding_0 == Encoding.GetEncoding("UTF-8"))
			{
				return zipOption_0 == ZipOption.AsNecessary;
			}
			return false;
		}
		set
		{
			if (value)
			{
				encoding_0 = Encoding.GetEncoding("UTF-8");
				zipOption_0 = ZipOption.AsNecessary;
			}
			else
			{
				encoding_0 = Encoding_2;
				zipOption_0 = ZipOption.Default;
			}
		}
	}

	public Zip64Option Zip64Option_0
	{
		get
		{
			return zip64Option_0;
		}
		set
		{
			zip64Option_0 = value;
		}
	}

	public bool? Nullable_0
	{
		get
		{
			if (dictionary_0.Count > 65534)
			{
				return true;
			}
			if (bool_10 && !bool_9)
			{
				foreach (GClass8 value in dictionary_0.Values)
				{
					if (value.Nullable_0.Value)
					{
						return true;
					}
				}
				return false;
			}
			return null;
		}
	}

	public bool? Nullable_1 => nullable_0;

	public bool? Nullable_2
	{
		get
		{
			if (dictionary_0.Count > 65534)
			{
				return true;
			}
			using (IEnumerator<GClass8> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass8 current = enumerator.Current;
					if (current.ZipEntrySource_0 == ZipEntrySource.ZipFile)
					{
						if (current.bool_10)
						{
							return true;
						}
						continue;
					}
					return null;
				}
			}
			return false;
		}
	}

	[Obsolete("use AlternateEncoding instead.")]
	public Encoding Encoding_0
	{
		get
		{
			if (zipOption_0 == ZipOption.AsNecessary)
			{
				return encoding_0;
			}
			return null;
		}
		set
		{
			encoding_0 = value;
			zipOption_0 = ZipOption.AsNecessary;
		}
	}

	public Encoding Encoding_1
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

	public ZipOption ZipOption_0
	{
		get
		{
			return zipOption_0;
		}
		set
		{
			zipOption_0 = value;
		}
	}

	public static Encoding Encoding_2 => encoding_1;

	public TextWriter TextWriter_0
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

	public string String_3
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
				EncryptionAlgorithm_0 = EncryptionAlgorithm.None;
			}
			else if (EncryptionAlgorithm_0 == EncryptionAlgorithm.None)
			{
				EncryptionAlgorithm_0 = EncryptionAlgorithm.PkzipWeak;
			}
		}
	}

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
		get
		{
			if (eventHandler_4 != null)
			{
				zipErrorAction_0 = ZipErrorAction.InvokeErrorEvent;
			}
			return zipErrorAction_0;
		}
		set
		{
			zipErrorAction_0 = value;
			if (zipErrorAction_0 != ZipErrorAction.InvokeErrorEvent && eventHandler_4 != null)
			{
				eventHandler_4 = null;
			}
		}
	}

	public EncryptionAlgorithm EncryptionAlgorithm_0
	{
		get
		{
			return encryptionAlgorithm_0;
		}
		set
		{
			if (value == EncryptionAlgorithm.Unsupported)
			{
				throw new InvalidOperationException("You may not set Encryption to that value.");
			}
			encryptionAlgorithm_0 = value;
		}
	}

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

	public int Int32_2
	{
		get
		{
			return int_1;
		}
		set
		{
			if (value < 65536 && value != 0)
			{
				throw new ZipException("The minimum acceptable segment size is 65536.");
			}
			int_1 = value;
		}
	}

	public int Int32_3 => (int)(uint_1 + 1);

	public long Int64_0
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

	public int Int32_4
	{
		get
		{
			return int_3;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
			}
			int_3 = value;
		}
	}

	public static Version Version_0 => Assembly.GetExecutingAssembly().GetName().Version;

	private List<GClass8> List_0
	{
		get
		{
			if (list_0 == null)
			{
				list_0 = new List<GClass8>(dictionary_0.Values);
			}
			return list_0;
		}
	}

	public GClass8 this[int int_5] => List_0[int_5];

	public GClass8 this[string string_6]
	{
		get
		{
			string text = Class21.smethod_3(string_6);
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

	public ICollection<string> ICollection_0 => dictionary_0.Keys;

	public ICollection<GClass8> ICollection_1 => dictionary_0.Values;

	public ICollection<GClass8> ICollection_2
	{
		get
		{
			List<GClass8> list = new List<GClass8>();
			foreach (GClass8 item in ICollection_1)
			{
				list.Add(item);
			}
			StringComparison sc = (Boolean_7 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
			list.Sort((GClass8 x, GClass8 y) => string.Compare(x.String_2, y.String_2, sc));
			return list.AsReadOnly();
		}
	}

	public int Int32_5 => dictionary_0.Count;

	internal Stream Stream_0
	{
		get
		{
			if (stream_0 == null && (string_1 != null || string_0 != null))
			{
				stream_0 = File.Open(string_1 ?? string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				bool_11 = true;
			}
			return stream_0;
		}
	}

	private Stream Stream_1
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
			if (int_1 != 0)
			{
				stream_1 = Stream3.smethod_1(string_0, int_1);
				return stream_1;
			}
			Class21.smethod_16(String_3 ?? Path.GetDirectoryName(string_0), out stream_1, out string_4);
			return stream_1;
		}
		set
		{
			if (value != null)
			{
				throw new ZipException("Cannot set the stream to a non-null value.");
			}
			stream_1 = null;
		}
	}

	private string String_5
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

	private long Int64_1
	{
		get
		{
			if (long_3 == -99L)
			{
				long_3 = (bool_11 ? Class21.smethod_0(string_0) : (-1L));
			}
			return long_3;
		}
	}

	public event EventHandler<GEventArgs3> SaveProgress
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_0;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_0;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs1> ReadProgress
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs1> eventHandler = eventHandler_1;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs1> eventHandler = eventHandler_1;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs4> ExtractProgress
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs4> eventHandler = eventHandler_2;
			EventHandler<GEventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs4> value2 = (EventHandler<GEventArgs4>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs4> eventHandler = eventHandler_2;
			EventHandler<GEventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs4> value2 = (EventHandler<GEventArgs4>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs2> AddProgress
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs2> eventHandler = eventHandler_3;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs2> eventHandler = eventHandler_3;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs5> ZipError
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs5> eventHandler = eventHandler_4;
			EventHandler<GEventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs5> value2 = (EventHandler<GEventArgs5>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs5> eventHandler = eventHandler_4;
			EventHandler<GEventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs5> value2 = (EventHandler<GEventArgs5>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public GClass8 method_0(string string_6)
	{
		return method_1(string_6, null);
	}

	public GClass8 method_1(string string_6, string string_7)
	{
		if (File.Exists(string_6))
		{
			return method_3(string_6, string_7);
		}
		if (!Directory.Exists(string_6))
		{
			throw new FileNotFoundException($"That file or directory ({string_6}) does not exist!");
		}
		return method_32(string_6, string_7);
	}

	public GClass8 method_2(string string_6)
	{
		return method_3(string_6, null);
	}

	public GClass8 method_3(string string_6, string string_7)
	{
		string text = GClass8.smethod_2(string_6, string_7);
		GClass8 gclass8_ = GClass8.smethod_4(string_6, text);
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("adding {0}...", string_6);
		}
		return method_22(gclass8_);
	}

	public void method_4(ICollection<GClass8> icollection_0)
	{
		if (icollection_0 == null)
		{
			throw new ArgumentNullException("entriesToRemove");
		}
		foreach (GClass8 item in icollection_0)
		{
			method_44(item);
		}
	}

	public void method_5(ICollection<string> icollection_0)
	{
		if (icollection_0 == null)
		{
			throw new ArgumentNullException("entriesToRemove");
		}
		foreach (string item in icollection_0)
		{
			method_45(item);
		}
	}

	public void method_6(IEnumerable<string> ienumerable_0)
	{
		method_8(ienumerable_0, null);
	}

	public void method_7(IEnumerable<string> ienumerable_0)
	{
		method_10(ienumerable_0, null);
	}

	public void method_8(IEnumerable<string> ienumerable_0, string string_6)
	{
		method_9(ienumerable_0, bool_18: false, string_6);
	}

	public void method_9(IEnumerable<string> ienumerable_0, bool bool_18, string string_6)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		bool_14 = false;
		method_61();
		if (bool_18)
		{
			foreach (string item in ienumerable_0)
			{
				if (!bool_14)
				{
					if (string_6 != null)
					{
						string fullPath = Path.GetFullPath(Path.Combine(string_6, Path.GetDirectoryName(item)));
						method_3(item, fullPath);
					}
					else
					{
						method_3(item, null);
					}
					continue;
				}
				break;
			}
		}
		else
		{
			foreach (string item2 in ienumerable_0)
			{
				if (!bool_14)
				{
					method_3(item2, string_6);
					continue;
				}
				break;
			}
		}
		if (!bool_14)
		{
			method_62();
		}
	}

	public void method_10(IEnumerable<string> ienumerable_0, string string_6)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		method_61();
		foreach (string item in ienumerable_0)
		{
			method_12(item, string_6);
		}
		method_62();
	}

	public GClass8 method_11(string string_6)
	{
		return method_12(string_6, null);
	}

	public GClass8 method_12(string string_6, string string_7)
	{
		string string_8 = GClass8.smethod_2(string_6, string_7);
		if (this[string_8] != null)
		{
			method_45(string_8);
		}
		return method_3(string_6, string_7);
	}

	public GClass8 method_13(string string_6)
	{
		return method_14(string_6, null);
	}

	public GClass8 method_14(string string_6, string string_7)
	{
		return method_34(string_6, string_7, AddOrUpdateAction.AddOrUpdate);
	}

	public void method_15(string string_6)
	{
		method_16(string_6, null);
	}

	public void method_16(string string_6, string string_7)
	{
		if (File.Exists(string_6))
		{
			method_12(string_6, string_7);
			return;
		}
		if (!Directory.Exists(string_6))
		{
			throw new FileNotFoundException($"That file or directory ({string_6}) does not exist!");
		}
		method_14(string_6, string_7);
	}

	public GClass8 method_17(string string_6, string string_7)
	{
		return method_18(string_6, string_7, Encoding.Default);
	}

	public GClass8 method_18(string string_6, string string_7, Encoding encoding_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream, encoding_2);
		streamWriter.Write(string_7);
		streamWriter.Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return method_19(string_6, memoryStream);
	}

	public GClass8 method_19(string string_6, Stream stream_2)
	{
		GClass8 gClass = GClass8.smethod_5(string_6, stream_2);
		gClass.method_1(DateTime.Now, DateTime.Now, DateTime.Now);
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("adding {0}...", string_6);
		}
		return method_22(gClass);
	}

	public GClass8 method_20(string string_6, GDelegate0 gdelegate0_0)
	{
		GClass8 gclass8_ = GClass8.smethod_6(string_6, gdelegate0_0);
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("adding {0}...", string_6);
		}
		return method_22(gclass8_);
	}

	public GClass8 method_21(string string_6, GDelegate1 gdelegate1_0, GDelegate2 gdelegate2_0)
	{
		GClass8 gClass = GClass8.smethod_7(string_6, gdelegate1_0, gdelegate2_0);
		gClass.method_1(DateTime.Now, DateTime.Now, DateTime.Now);
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("adding {0}...", string_6);
		}
		return method_22(gClass);
	}

	private GClass8 method_22(GClass8 gclass8_0)
	{
		gclass8_0.class27_0 = new Class27(this);
		gclass8_0.CompressionMethod_0 = CompressionMethod_0;
		gclass8_0.CompressionLevel_0 = CompressionLevel_0;
		gclass8_0.ExtractExistingFileAction_0 = ExtractExistingFileAction_0;
		gclass8_0.ZipErrorAction_0 = ZipErrorAction_0;
		gclass8_0.GDelegate3_0 = GDelegate3_0;
		gclass8_0.Encoding_1 = Encoding_1;
		gclass8_0.ZipOption_0 = ZipOption_0;
		gclass8_0.String_4 = string_3;
		gclass8_0.EncryptionAlgorithm_0 = EncryptionAlgorithm_0;
		gclass8_0.Boolean_1 = bool_6;
		gclass8_0.Boolean_2 = bool_7;
		method_35(gclass8_0.String_2, gclass8_0);
		method_63(gclass8_0);
		return gclass8_0;
	}

	public GClass8 method_23(string string_6, string string_7)
	{
		return method_24(string_6, string_7, Encoding.Default);
	}

	public GClass8 method_24(string string_6, string string_7, Encoding encoding_2)
	{
		method_28(string_6);
		return method_18(string_6, string_7, encoding_2);
	}

	public GClass8 method_25(string string_6, GDelegate0 gdelegate0_0)
	{
		method_28(string_6);
		return method_20(string_6, gdelegate0_0);
	}

	public GClass8 method_26(string string_6, GDelegate1 gdelegate1_0, GDelegate2 gdelegate2_0)
	{
		method_28(string_6);
		return method_21(string_6, gdelegate1_0, gdelegate2_0);
	}

	public GClass8 method_27(string string_6, Stream stream_2)
	{
		method_28(string_6);
		return method_19(string_6, stream_2);
	}

	private void method_28(string string_6)
	{
		if (string.IsNullOrEmpty(string_6))
		{
			throw new ArgumentNullException("entryName");
		}
		string text = null;
		if (string_6.IndexOf('\\') != -1)
		{
			text = Path.GetDirectoryName(string_6);
			string_6 = Path.GetFileName(string_6);
		}
		string string_7 = GClass8.smethod_2(string_6, text);
		if (this[string_7] != null)
		{
			method_45(string_7);
		}
	}

	public GClass8 method_29(string string_6, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentException("bad argument", "byteContent");
		}
		MemoryStream stream_ = new MemoryStream(byte_0);
		return method_19(string_6, stream_);
	}

	public GClass8 method_30(string string_6, byte[] byte_0)
	{
		method_28(string_6);
		return method_29(string_6, byte_0);
	}

	public GClass8 method_31(string string_6)
	{
		return method_32(string_6, null);
	}

	public GClass8 method_32(string string_6, string string_7)
	{
		return method_34(string_6, string_7, AddOrUpdateAction.AddOnly);
	}

	public GClass8 method_33(string string_6)
	{
		GClass8 gClass = GClass8.smethod_3(string_6);
		gClass.class27_0 = new Class27(this);
		gClass.method_2();
		gClass.Encoding_1 = Encoding_1;
		gClass.ZipOption_0 = ZipOption_0;
		gClass.method_1(DateTime.Now, DateTime.Now, DateTime.Now);
		gClass.Boolean_1 = bool_6;
		gClass.Boolean_2 = bool_7;
		gClass.zipEntrySource_0 = ZipEntrySource.Stream;
		method_35(gClass.String_2, gClass);
		method_63(gClass);
		return gClass;
	}

	private GClass8 method_34(string string_6, string string_7, AddOrUpdateAction addOrUpdateAction_0)
	{
		if (string_7 == null)
		{
			string_7 = "";
		}
		return method_36(string_6, string_7, addOrUpdateAction_0, bool_18: true, 0);
	}

	internal void method_35(string string_6, GClass8 gclass8_0)
	{
		dictionary_0.Add(string_6, gclass8_0);
		list_0 = null;
		bool_9 = true;
	}

	private GClass8 method_36(string string_6, string string_7, AddOrUpdateAction addOrUpdateAction_0, bool bool_18, int int_5)
	{
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("{0} {1}...", (addOrUpdateAction_0 == AddOrUpdateAction.AddOnly) ? "adding" : "Adding or updating", string_6);
		}
		if (int_5 == 0)
		{
			bool_14 = false;
			method_61();
		}
		if (bool_14)
		{
			return null;
		}
		string string_8 = string_7;
		GClass8 gClass = null;
		if (int_5 > 0)
		{
			int num = string_6.Length;
			for (int num2 = int_5; num2 > 0; num2--)
			{
				num = string_6.LastIndexOfAny("/\\".ToCharArray(), num - 1, num - 1);
			}
			string_8 = string_6.Substring(num + 1);
			string_8 = Path.Combine(string_7, string_8);
		}
		if (int_5 > 0 || string_7 != "")
		{
			gClass = GClass8.smethod_4(string_6, string_8);
			gClass.class27_0 = new Class27(this);
			gClass.Encoding_1 = Encoding_1;
			gClass.ZipOption_0 = ZipOption_0;
			gClass.method_2();
			gClass.Boolean_1 = bool_6;
			gClass.Boolean_2 = bool_7;
			if (!dictionary_0.ContainsKey(gClass.String_2))
			{
				method_35(gClass.String_2, gClass);
				method_63(gClass);
			}
			string_8 = gClass.String_2;
		}
		if (!bool_14)
		{
			string[] files = Directory.GetFiles(string_6);
			if (bool_18)
			{
				string[] array = files;
				foreach (string string_9 in array)
				{
					if (bool_14)
					{
						break;
					}
					if (addOrUpdateAction_0 == AddOrUpdateAction.AddOnly)
					{
						method_3(string_9, string_8);
					}
					else
					{
						method_12(string_9, string_8);
					}
				}
				if (!bool_14)
				{
					array = Directory.GetDirectories(string_6);
					foreach (string text in array)
					{
						FileAttributes attributes = File.GetAttributes(text);
						if (Boolean_2 || (attributes & FileAttributes.ReparsePoint) == 0)
						{
							method_36(text, string_7, addOrUpdateAction_0, bool_18, int_5 + 1);
						}
					}
				}
			}
		}
		if (int_5 == 0)
		{
			method_62();
		}
		return gClass;
	}

	public static bool smethod_0(string string_6)
	{
		return smethod_1(string_6, bool_18: false, null);
	}

	public static bool smethod_1(string string_6, bool bool_18, TextWriter textWriter_1)
	{
		GClass9 gClass = null;
		GClass9 gClass2 = null;
		bool flag = true;
		try
		{
			gClass = new GClass9();
			gClass.Boolean_0 = true;
			gClass.method_41(string_6);
			gClass2 = smethod_4(string_6);
			foreach (GClass8 item in gClass)
			{
				foreach (GClass8 item2 in gClass2)
				{
					if (item.String_2 == item2.String_2)
					{
						if (item.long_4 != item2.long_4)
						{
							flag = false;
							textWriter_1?.WriteLine("{0}: mismatch in RelativeOffsetOfLocalHeader  (0x{1:X16} != 0x{2:X16})", item.String_2, item.long_4, item2.long_4);
						}
						if (item.long_0 != item2.long_0)
						{
							flag = false;
							textWriter_1?.WriteLine("{0}: mismatch in CompressedSize  (0x{1:X16} != 0x{2:X16})", item.String_2, item.long_0, item2.long_0);
						}
						if (item.long_2 != item2.long_2)
						{
							flag = false;
							textWriter_1?.WriteLine("{0}: mismatch in UncompressedSize  (0x{1:X16} != 0x{2:X16})", item.String_2, item.long_2, item2.long_2);
						}
						if (item.CompressionMethod_0 != item2.CompressionMethod_0)
						{
							flag = false;
							textWriter_1?.WriteLine("{0}: mismatch in CompressionMethod  (0x{1:X4} != 0x{2:X4})", item.String_2, item.CompressionMethod_0, item2.CompressionMethod_0);
						}
						if (item.Int32_1 != item2.Int32_1)
						{
							flag = false;
							textWriter_1?.WriteLine("{0}: mismatch in Crc32  (0x{1:X4} != 0x{2:X4})", item.String_2, item.Int32_1, item2.Int32_1);
						}
						break;
					}
				}
			}
			gClass2.Dispose();
			gClass2 = null;
			if (!flag && bool_18)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_6);
				fileNameWithoutExtension = $"{fileNameWithoutExtension}_fixed.zip";
				gClass.method_72(fileNameWithoutExtension);
				return flag;
			}
			return flag;
		}
		finally
		{
			gClass?.Dispose();
			gClass2?.Dispose();
		}
	}

	public static void smethod_2(string string_6)
	{
		using GClass9 gClass = new GClass9();
		gClass.Boolean_0 = true;
		gClass.method_41(string_6);
		gClass.method_72(string_6);
	}

	public static bool smethod_3(string string_6, string string_7)
	{
		bool result = false;
		try
		{
			using (GClass9 gClass = smethod_4(string_6))
			{
				foreach (GClass8 item in gClass)
				{
					if (!item.Boolean_4 && item.Boolean_5)
					{
						item.method_13(Stream.Null, string_7);
					}
				}
			}
			result = true;
			return result;
		}
		catch (BadPasswordException)
		{
			return result;
		}
	}

	public bool method_37(string string_6)
	{
		return dictionary_0.ContainsKey(Class21.smethod_3(string_6));
	}

	public override string ToString()
	{
		return $"ZipFile::{String_1}";
	}

	internal void method_38()
	{
		bool_9 = true;
	}

	internal Stream method_39(uint uint_3)
	{
		if (uint_3 + 1 != uint_0 && (uint_3 != 0 || uint_0 != 0))
		{
			return Stream3.smethod_0(string_1 ?? string_0, uint_3, uint_0);
		}
		return Stream_0;
	}

	internal void method_40(bool bool_18)
	{
		if (!bool_15)
		{
			return;
		}
		using (GClass9 gClass = new GClass9())
		{
			gClass.string_1 = (gClass.string_0 = (bool_18 ? (string_1 ?? string_0) : string_0));
			gClass.Encoding_1 = Encoding_1;
			gClass.ZipOption_0 = ZipOption_0;
			smethod_10(gClass);
			foreach (GClass8 item in gClass)
			{
				using IEnumerator<GClass8> enumerator2 = GetEnumerator();
				while (enumerator2.MoveNext())
				{
					GClass8 current2 = enumerator2.Current;
					if (item.String_2 == current2.String_2)
					{
						current2.method_50(item);
						break;
					}
				}
			}
		}
		bool_15 = false;
	}

	public GClass9(string fileName)
	{
		try
		{
			method_43(fileName, null);
		}
		catch (Exception innerException)
		{
			throw new ZipException($"Could not read {fileName} as a zip file", innerException);
		}
	}

	public GClass9(string fileName, Encoding encoding)
	{
		try
		{
			Encoding_1 = encoding;
			ZipOption_0 = ZipOption.Always;
			method_43(fileName, null);
		}
		catch (Exception innerException)
		{
			throw new ZipException($"{fileName} is not a valid zip file", innerException);
		}
	}

	public GClass9()
	{
		method_43(null, null);
	}

	public GClass9(Encoding encoding)
	{
		Encoding_1 = encoding;
		ZipOption_0 = ZipOption.Always;
		method_43(null, null);
	}

	public GClass9(string fileName, TextWriter statusMessageWriter)
	{
		try
		{
			method_43(fileName, statusMessageWriter);
		}
		catch (Exception innerException)
		{
			throw new ZipException($"{fileName} is not a valid zip file", innerException);
		}
	}

	public GClass9(string fileName, TextWriter statusMessageWriter, Encoding encoding)
	{
		try
		{
			Encoding_1 = encoding;
			ZipOption_0 = ZipOption.Always;
			method_43(fileName, statusMessageWriter);
		}
		catch (Exception innerException)
		{
			throw new ZipException($"{fileName} is not a valid zip file", innerException);
		}
	}

	public void method_41(string string_6)
	{
		try
		{
			method_43(string_6, null);
		}
		catch (Exception innerException)
		{
			throw new ZipException($"{string_6} is not a valid zip file", innerException);
		}
	}

	private void method_42()
	{
		StringComparer comparer = (Boolean_7 ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase);
		dictionary_0 = ((dictionary_0 == null) ? new Dictionary<string, GClass8>(comparer) : new Dictionary<string, GClass8>(dictionary_0, comparer));
	}

	private void method_43(string string_6, TextWriter textWriter_1)
	{
		string_0 = string_6;
		textWriter_0 = textWriter_1;
		bool_9 = true;
		Boolean_2 = true;
		CompressionLevel_0 = CompressionLevel.Default;
		Int64_0 = 524288L;
		method_42();
		if (File.Exists(string_0))
		{
			if (Boolean_0)
			{
				smethod_14(this);
			}
			else
			{
				smethod_10(this);
			}
			bool_8 = true;
		}
	}

	public void method_44(GClass8 gclass8_0)
	{
		if (gclass8_0 == null)
		{
			throw new ArgumentNullException("entry");
		}
		dictionary_0.Remove(Class21.smethod_3(gclass8_0.String_2));
		list_0 = null;
		bool_9 = true;
	}

	public void method_45(string string_6)
	{
		string string_7 = GClass8.smethod_2(string_6, null);
		GClass8 gClass = this[string_7];
		if (gClass == null)
		{
			throw new ArgumentException("The entry you specified was not found in the zip archive.");
		}
		method_44(gClass);
	}

	public void Dispose()
	{
		Dispose(disposeManagedResources: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposeManagedResources)
	{
		if (bool_5)
		{
			return;
		}
		if (disposeManagedResources)
		{
			if (bool_11 && stream_0 != null)
			{
				stream_0.Dispose();
				stream_0 = null;
			}
			if (string_4 != null && string_0 != null && stream_1 != null)
			{
				stream_1.Dispose();
				stream_1 = null;
			}
			if (gstream2_0 != null)
			{
				gstream2_0.method_3();
				gstream2_0 = null;
			}
		}
		bool_5 = true;
	}

	internal bool method_46(GClass8 gclass8_0, long long_4, long long_5)
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_0;
		if (eventHandler != null)
		{
			GEventArgs3 gEventArgs = GEventArgs3.smethod_0(String_5, gclass8_0, long_4, long_5);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_12 = true;
			}
		}
		return bool_12;
	}

	private void method_47(int int_5, GClass8 gclass8_0, bool bool_18)
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_0;
		if (eventHandler != null)
		{
			GEventArgs3 gEventArgs = new GEventArgs3(String_5, bool_18, dictionary_0.Count, int_5, gclass8_0);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_12 = true;
			}
		}
	}

	private void method_48(ZipProgressEventType zipProgressEventType_0)
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_0;
		if (eventHandler != null)
		{
			GEventArgs3 gEventArgs = new GEventArgs3(String_5, zipProgressEventType_0);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_12 = true;
			}
		}
	}

	private void method_49()
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_0;
		if (eventHandler != null)
		{
			GEventArgs3 gEventArgs = GEventArgs3.smethod_1(String_5);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_12 = true;
			}
		}
	}

	private void method_50()
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_0;
		if (eventHandler != null)
		{
			GEventArgs3 e = GEventArgs3.smethod_2(String_5);
			eventHandler(this, e);
		}
	}

	private void method_51()
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		if (eventHandler != null)
		{
			GEventArgs1 e = GEventArgs1.smethod_2(String_5);
			eventHandler(this, e);
		}
	}

	private void method_52()
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		if (eventHandler != null)
		{
			GEventArgs1 e = GEventArgs1.smethod_4(String_5);
			eventHandler(this, e);
		}
	}

	internal void method_53(GClass8 gclass8_0)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		if (eventHandler != null)
		{
			GEventArgs1 e = GEventArgs1.smethod_3(String_5, gclass8_0, Stream_0.Position, Int64_1);
			eventHandler(this, e);
		}
	}

	internal void method_54(bool bool_18, GClass8 gclass8_0)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		if (eventHandler != null)
		{
			GEventArgs1 e = (bool_18 ? GEventArgs1.smethod_0(String_5, dictionary_0.Count) : GEventArgs1.smethod_1(String_5, gclass8_0, dictionary_0.Count));
			eventHandler(this, e);
		}
	}

	private void method_55(int int_5, bool bool_18, GClass8 gclass8_0, string string_6)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		if (eventHandler != null)
		{
			GEventArgs4 gEventArgs = new GEventArgs4(String_5, bool_18, dictionary_0.Count, int_5, gclass8_0, string_6);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_13 = true;
			}
		}
	}

	internal bool method_56(GClass8 gclass8_0, long long_4, long long_5)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		if (eventHandler != null)
		{
			GEventArgs4 gEventArgs = GEventArgs4.smethod_5(String_5, gclass8_0, long_4, long_5);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_13 = true;
			}
		}
		return bool_13;
	}

	internal bool method_57(GClass8 gclass8_0, string string_6, bool bool_18)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		if (eventHandler != null)
		{
			GEventArgs4 gEventArgs = (bool_18 ? GEventArgs4.smethod_0(String_5, gclass8_0, string_6) : GEventArgs4.smethod_2(String_5, gclass8_0, string_6));
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_13 = true;
			}
		}
		return bool_13;
	}

	internal bool method_58(GClass8 gclass8_0, string string_6)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		if (eventHandler != null)
		{
			GEventArgs4 gEventArgs = GEventArgs4.smethod_1(String_5, gclass8_0, string_6);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_13 = true;
			}
		}
		return bool_13;
	}

	private void method_59(string string_6)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		if (eventHandler != null)
		{
			GEventArgs4 e = GEventArgs4.smethod_4(String_5, string_6);
			eventHandler(this, e);
		}
	}

	private void method_60(string string_6)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		if (eventHandler != null)
		{
			GEventArgs4 e = GEventArgs4.smethod_3(String_5, string_6);
			eventHandler(this, e);
		}
	}

	private void method_61()
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_3;
		if (eventHandler != null)
		{
			GEventArgs2 gEventArgs = GEventArgs2.smethod_1(String_5);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_14 = true;
			}
		}
	}

	private void method_62()
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_3;
		if (eventHandler != null)
		{
			GEventArgs2 e = GEventArgs2.smethod_2(String_5);
			eventHandler(this, e);
		}
	}

	internal void method_63(GClass8 gclass8_0)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_3;
		if (eventHandler != null)
		{
			GEventArgs2 gEventArgs = GEventArgs2.smethod_0(String_5, gclass8_0, dictionary_0.Count);
			eventHandler(this, gEventArgs);
			if (gEventArgs.Boolean_0)
			{
				bool_14 = true;
			}
		}
	}

	internal bool method_64(GClass8 gclass8_0, Exception exception_0)
	{
		if (eventHandler_4 != null)
		{
			lock (object_0)
			{
				GEventArgs5 gEventArgs = GEventArgs5.smethod_0(String_1, gclass8_0, exception_0);
				eventHandler_4(this, gEventArgs);
				if (gEventArgs.Boolean_0)
				{
					bool_12 = true;
				}
			}
		}
		return bool_12;
	}

	public void method_65(string string_6)
	{
		method_67(string_6, bool_18: true);
	}

	public void method_66(string string_6, ExtractExistingFileAction extractExistingFileAction_1)
	{
		ExtractExistingFileAction_0 = extractExistingFileAction_1;
		method_67(string_6, bool_18: true);
	}

	private void method_67(string string_6, bool bool_18)
	{
		bool flag = Boolean_6;
		bool_16 = true;
		try
		{
			method_60(string_6);
			int num = 0;
			foreach (GClass8 value in dictionary_0.Values)
			{
				if (flag)
				{
					TextWriter_0.WriteLine("\n{1,-22} {2,-8} {3,4}   {4,-8}  {0}", "Name", "Modified", "Size", "Ratio", "Packed");
					TextWriter_0.WriteLine(new string('-', 72));
					flag = false;
				}
				if (Boolean_6)
				{
					TextWriter_0.WriteLine("{1,-22} {2,-8} {3,4:F0}%   {4,-8} {0}", value.String_2, value.DateTime_0.ToString("yyyy-MM-dd HH:mm:ss"), value.Int64_1, value.Double_0, value.Int64_0);
					if (!string.IsNullOrEmpty(value.String_3))
					{
						TextWriter_0.WriteLine("  Comment: {0}", value.String_3);
					}
				}
				value.String_4 = string_3;
				method_55(num, bool_18: true, value, string_6);
				if (bool_18)
				{
					value.ExtractExistingFileAction_0 = ExtractExistingFileAction_0;
				}
				value.method_7(string_6);
				num++;
				method_55(num, bool_18: false, value, string_6);
				if (bool_13)
				{
					break;
				}
			}
			if (bool_13)
			{
				return;
			}
			foreach (GClass8 value2 in dictionary_0.Values)
			{
				if (value2.Boolean_4 || value2.String_2.EndsWith("/"))
				{
					string text = (value2.String_2.StartsWith("/") ? Path.Combine(string_6, value2.String_2.Substring(1)) : Path.Combine(string_6, value2.String_2));
					value2.method_29(text, bool_15: false);
				}
			}
			method_59(string_6);
		}
		finally
		{
			bool_16 = false;
		}
	}

	public static GClass9 smethod_4(string string_6)
	{
		return smethod_6(string_6, null, null, null);
	}

	public static GClass9 smethod_5(string string_6, GClass10 gclass10_0)
	{
		if (gclass10_0 == null)
		{
			throw new ArgumentNullException("options");
		}
		return smethod_6(string_6, gclass10_0.TextWriter_0, gclass10_0.Encoding_0, gclass10_0.EventHandler_0);
	}

	private static GClass9 smethod_6(string string_6, TextWriter textWriter_1, Encoding encoding_2, EventHandler<GEventArgs1> eventHandler_5)
	{
		GClass9 gClass = new GClass9();
		gClass.Encoding_1 = encoding_2 ?? Encoding_2;
		gClass.ZipOption_0 = ZipOption.Always;
		gClass.textWriter_0 = textWriter_1;
		gClass.string_0 = string_6;
		if (eventHandler_5 != null)
		{
			gClass.eventHandler_1 = eventHandler_5;
		}
		if (gClass.Boolean_6)
		{
			gClass.textWriter_0.WriteLine("reading from {0}...", string_6);
		}
		smethod_10(gClass);
		gClass.bool_8 = true;
		return gClass;
	}

	public static GClass9 smethod_7(Stream stream_2)
	{
		return smethod_9(stream_2, null, null, null);
	}

	public static GClass9 smethod_8(Stream stream_2, GClass10 gclass10_0)
	{
		if (gclass10_0 == null)
		{
			throw new ArgumentNullException("options");
		}
		return smethod_9(stream_2, gclass10_0.TextWriter_0, gclass10_0.Encoding_0, gclass10_0.EventHandler_0);
	}

	private static GClass9 smethod_9(Stream stream_2, TextWriter textWriter_1, Encoding encoding_2, EventHandler<GEventArgs1> eventHandler_5)
	{
		if (stream_2 == null)
		{
			throw new ArgumentNullException("zipStream");
		}
		GClass9 gClass = new GClass9();
		gClass.textWriter_0 = textWriter_1;
		gClass.encoding_0 = encoding_2 ?? Encoding_2;
		gClass.zipOption_0 = ZipOption.Always;
		if (eventHandler_5 != null)
		{
			gClass.ReadProgress += eventHandler_5;
		}
		gClass.stream_0 = ((stream_2.Position == 0L) ? stream_2 : new Stream1(stream_2));
		gClass.bool_11 = false;
		if (gClass.Boolean_6)
		{
			gClass.textWriter_0.WriteLine("reading from stream...");
		}
		smethod_10(gClass);
		return gClass;
	}

	private static void smethod_10(GClass9 gclass9_0)
	{
		Stream stream = gclass9_0.Stream_0;
		try
		{
			gclass9_0.string_1 = gclass9_0.string_0;
			if (!stream.CanSeek)
			{
				smethod_14(gclass9_0);
				return;
			}
			gclass9_0.method_51();
			if (smethod_12(stream) == 101010256)
			{
				return;
			}
			int num = 0;
			bool flag = false;
			long num2 = stream.Length - 64L;
			long num3 = Math.Max(stream.Length - 16384L, 10L);
			do
			{
				if (num2 < 0L)
				{
					num2 = 0L;
				}
				stream.Seek(num2, SeekOrigin.Begin);
				if (Class21.smethod_12(stream, 101010256) != -1L)
				{
					flag = true;
					continue;
				}
				if (num2 == 0L)
				{
					break;
				}
				num++;
				num2 -= 32 * (num + 1) * num;
			}
			while (!flag && num2 > num3);
			if (flag)
			{
				gclass9_0.long_0 = stream.Position - 4L;
				byte[] array = new byte[16];
				stream.Read(array, 0, array.Length);
				gclass9_0.uint_0 = BitConverter.ToUInt16(array, 2);
				if (gclass9_0.uint_0 == 65535)
				{
					throw new ZipException("Spanned archives with more than 65534 segments are not supported at this time.");
				}
				gclass9_0.uint_0++;
				uint num4 = BitConverter.ToUInt32(array, 12);
				if (num4 == uint.MaxValue)
				{
					smethod_11(gclass9_0);
				}
				else
				{
					gclass9_0.uint_2 = num4;
					stream.Seek(num4, SeekOrigin.Begin);
				}
				smethod_13(gclass9_0);
			}
			else
			{
				stream.Seek(0L, SeekOrigin.Begin);
				smethod_14(gclass9_0);
			}
		}
		catch (Exception innerException)
		{
			if (gclass9_0.bool_11 && gclass9_0.stream_0 != null)
			{
				gclass9_0.stream_0.Dispose();
				gclass9_0.stream_0 = null;
			}
			throw new ZipException("Cannot read that as a ZipFile", innerException);
		}
		gclass9_0.bool_9 = false;
	}

	private static void smethod_11(GClass9 gclass9_0)
	{
		Stream stream = gclass9_0.Stream_0;
		byte[] array = new byte[16];
		stream.Seek(-40L, SeekOrigin.Current);
		stream.Read(array, 0, 16);
		long offset = BitConverter.ToInt64(array, 8);
		gclass9_0.uint_2 = uint.MaxValue;
		gclass9_0.long_1 = offset;
		stream.Seek(offset, SeekOrigin.Begin);
		uint num = (uint)Class21.smethod_10(stream);
		if (num != 101075792)
		{
			throw new BadReadException($"  Bad signature (0x{num:X8}) looking for ZIP64 EoCD Record at position 0x{stream.Position:X8}");
		}
		stream.Read(array, 0, 8);
		array = new byte[BitConverter.ToInt64(array, 0)];
		stream.Read(array, 0, array.Length);
		offset = BitConverter.ToInt64(array, 36);
		stream.Seek(offset, SeekOrigin.Begin);
	}

	private static uint smethod_12(Stream stream_2)
	{
		return (uint)Class21.smethod_10(stream_2);
	}

	private static void smethod_13(GClass9 gclass9_0)
	{
		bool flag = false;
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		GClass8 gClass;
		while ((gClass = GClass8.smethod_0(gclass9_0, dictionary)) != null)
		{
			gClass.method_0();
			gclass9_0.method_54(bool_18: true, null);
			if (gclass9_0.Boolean_6)
			{
				gclass9_0.TextWriter_0.WriteLine("entry {0}", gClass.String_2);
			}
			gclass9_0.dictionary_0.Add(gClass.String_2, gClass);
			if (gClass.bool_10)
			{
				flag = true;
			}
			dictionary.Add(gClass.String_2, null);
		}
		if (flag)
		{
			gclass9_0.Zip64Option_0 = Zip64Option.Always;
		}
		if (gclass9_0.long_0 > 0L)
		{
			gclass9_0.Stream_0.Seek(gclass9_0.long_0, SeekOrigin.Begin);
		}
		smethod_15(gclass9_0);
		if (gclass9_0.Boolean_6 && !string.IsNullOrEmpty(gclass9_0.String_2))
		{
			gclass9_0.TextWriter_0.WriteLine("Zip file Comment: {0}", gclass9_0.String_2);
		}
		if (gclass9_0.Boolean_6)
		{
			gclass9_0.TextWriter_0.WriteLine("read in {0} entries.", gclass9_0.dictionary_0.Count);
		}
		gclass9_0.method_52();
	}

	private static void smethod_14(GClass9 gclass9_0)
	{
		gclass9_0.method_51();
		gclass9_0.dictionary_0 = new Dictionary<string, GClass8>();
		if (gclass9_0.Boolean_6)
		{
			if (gclass9_0.String_1 == null)
			{
				gclass9_0.TextWriter_0.WriteLine("Reading zip from stream...");
			}
			else
			{
				gclass9_0.TextWriter_0.WriteLine("Reading zip {0}...", gclass9_0.String_1);
			}
		}
		bool flag = true;
		Class27 class27_ = new Class27(gclass9_0);
		GClass8 gClass;
		while ((gClass = GClass8.smethod_15(class27_, flag)) != null)
		{
			if (gclass9_0.Boolean_6)
			{
				gclass9_0.TextWriter_0.WriteLine("  {0}", gClass.String_2);
			}
			gclass9_0.dictionary_0.Add(gClass.String_2, gClass);
			flag = false;
		}
		try
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			GClass8 gClass2;
			while ((gClass2 = GClass8.smethod_0(gclass9_0, dictionary)) != null)
			{
				GClass8 gClass3 = gclass9_0.dictionary_0[gClass2.String_2];
				if (gClass3 != null)
				{
					gClass3.string_2 = gClass2.String_3;
					if (gClass2.Boolean_4)
					{
						gClass3.method_2();
					}
				}
				dictionary.Add(gClass2.String_2, null);
			}
			if (gclass9_0.long_0 > 0L)
			{
				gclass9_0.Stream_0.Seek(gclass9_0.long_0, SeekOrigin.Begin);
			}
			smethod_15(gclass9_0);
			if (gclass9_0.Boolean_6 && !string.IsNullOrEmpty(gclass9_0.String_2))
			{
				gclass9_0.TextWriter_0.WriteLine("Zip file Comment: {0}", gclass9_0.String_2);
			}
		}
		catch (ZipException)
		{
		}
		catch (IOException)
		{
		}
		gclass9_0.method_52();
	}

	private static void smethod_15(GClass9 gclass9_0)
	{
		Stream stream = gclass9_0.Stream_0;
		int num = Class21.smethod_8(stream);
		byte[] array = null;
		int num2 = 0;
		if (num == 101075792L)
		{
			array = new byte[52];
			stream.Read(array, 0, array.Length);
			long num3 = BitConverter.ToInt64(array, 0);
			if (num3 < 44L)
			{
				throw new ZipException("Bad size in the ZIP64 Central Directory.");
			}
			gclass9_0.ushort_0 = BitConverter.ToUInt16(array, num2);
			num2 += 2;
			gclass9_0.ushort_1 = BitConverter.ToUInt16(array, num2);
			num2 += 2;
			gclass9_0.uint_0 = BitConverter.ToUInt32(array, num2);
			num2 += 2;
			array = new byte[num3 - 44L];
			stream.Read(array, 0, array.Length);
			num = Class21.smethod_8(stream);
			if (num != 117853008L)
			{
				throw new ZipException("Inconsistent metadata in the ZIP64 Central Directory.");
			}
			array = new byte[16];
			stream.Read(array, 0, array.Length);
			num = Class21.smethod_8(stream);
		}
		if (num != 101010256L)
		{
			stream.Seek(-4L, SeekOrigin.Current);
			throw new BadReadException($"Bad signature ({num:X8}) at position 0x{stream.Position:X8}");
		}
		array = new byte[16];
		gclass9_0.Stream_0.Read(array, 0, array.Length);
		if (gclass9_0.uint_0 == 0)
		{
			gclass9_0.uint_0 = BitConverter.ToUInt16(array, 2);
		}
		smethod_16(gclass9_0);
	}

	private static void smethod_16(GClass9 gclass9_0)
	{
		byte[] array = new byte[2];
		gclass9_0.Stream_0.Read(array, 0, array.Length);
		short num = (short)(array[0] + array[1] * 256);
		if (num > 0)
		{
			array = new byte[num];
			gclass9_0.Stream_0.Read(array, 0, array.Length);
			string text = (gclass9_0.String_2 = gclass9_0.Encoding_1.GetString(array, 0, array.Length));
		}
	}

	public static bool smethod_17(string string_6)
	{
		return smethod_18(string_6, bool_18: false);
	}

	public static bool smethod_18(string string_6, bool bool_18)
	{
		bool result = false;
		try
		{
			if (!File.Exists(string_6))
			{
				return false;
			}
			using FileStream stream_ = File.Open(string_6, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			result = smethod_19(stream_, bool_18);
			return result;
		}
		catch (IOException)
		{
			return result;
		}
		catch (ZipException)
		{
			return result;
		}
	}

	public static bool smethod_19(Stream stream_2, bool bool_18)
	{
		if (stream_2 == null)
		{
			throw new ArgumentNullException("stream");
		}
		bool result = false;
		try
		{
			if (!stream_2.CanRead)
			{
				return false;
			}
			Stream @null = Stream.Null;
			using (GClass9 gClass = smethod_9(stream_2, null, null, null))
			{
				if (bool_18)
				{
					foreach (GClass8 item in gClass)
					{
						if (!item.Boolean_4)
						{
							item.method_6(@null);
						}
					}
				}
			}
			result = true;
			return result;
		}
		catch (IOException)
		{
			return result;
		}
		catch (ZipException)
		{
			return result;
		}
	}

	private void method_68(string string_6)
	{
		bool flag = false;
		int num = 3;
		for (int i = 0; i < num; i++)
		{
			if (flag)
			{
				break;
			}
			try
			{
				File.Delete(string_6);
				flag = true;
			}
			catch (UnauthorizedAccessException)
			{
				Console.WriteLine("************************************************** Retry delete.");
				Thread.Sleep(200 + i * 200);
			}
		}
	}

	public void method_69()
	{
		try
		{
			bool flag = false;
			bool_12 = false;
			uint_1 = 0u;
			method_49();
			if (Stream_1 == null)
			{
				throw new BadStateException("You haven't specified where to save the zip.");
			}
			if (string_0 != null && string_0.EndsWith(".exe") && !bool_17)
			{
				throw new BadStateException("You specified an EXE for a plain zip file.");
			}
			if (!bool_9)
			{
				method_50();
				if (Boolean_6)
				{
					TextWriter_0.WriteLine("No save is necessary....");
				}
				return;
			}
			method_40(bool_18: true);
			if (Boolean_6)
			{
				TextWriter_0.WriteLine("saving....");
			}
			if (dictionary_0.Count >= 65535 && zip64Option_0 == Zip64Option.Default)
			{
				throw new ZipException("The number of entries is 65535 or greater. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			int num = 0;
			ICollection<GClass8> collection = (Boolean_1 ? ICollection_2 : ICollection_1);
			foreach (GClass8 item in collection)
			{
				method_47(num, item, bool_18: true);
				item.method_61(Stream_1);
				if (!bool_12)
				{
					num++;
					method_47(num, item, bool_18: false);
					if (!bool_12)
					{
						if (item.Boolean_7)
						{
							flag |= item.Nullable_1.Value;
						}
						continue;
					}
					break;
				}
				break;
			}
			if (bool_12)
			{
				return;
			}
			Stream3 stream = Stream_1 as Stream3;
			uint_1 = stream?.UInt32_0 ?? 1;
			bool flag2 = Class26.smethod_0(Stream_1, collection, uint_1, zip64Option_0, String_2, new Class27(this));
			method_48(ZipProgressEventType.Saving_AfterSaveTempArchive);
			bool_10 = true;
			bool_9 = false;
			flag = flag || flag2;
			nullable_0 = flag;
			if (string_0 != null && (string_4 != null || stream != null))
			{
				Stream_1.Dispose();
				if (bool_12)
				{
					return;
				}
				if (bool_8 && stream_0 != null)
				{
					stream_0.Close();
					stream_0 = null;
					foreach (GClass8 item2 in collection)
					{
						if (item2.stream_0 is Stream3 stream2)
						{
							stream2.Dispose();
						}
						item2.stream_0 = null;
					}
				}
				string text = null;
				if (File.Exists(string_0))
				{
					text = string_0 + "." + Path.GetRandomFileName();
					if (File.Exists(text))
					{
						method_68(text);
					}
					File.Move(string_0, text);
				}
				method_48(ZipProgressEventType.Saving_BeforeRenameTempArchive);
				File.Move((stream != null) ? stream.String_1 : string_4, string_0);
				method_48(ZipProgressEventType.Saving_AfterRenameTempArchive);
				if (text != null)
				{
					try
					{
						if (File.Exists(text))
						{
							File.Delete(text);
						}
					}
					catch
					{
					}
				}
				bool_8 = true;
			}
			smethod_20(collection);
			method_50();
			bool_15 = true;
		}
		finally
		{
			method_71();
		}
	}

	private static void smethod_20(ICollection<GClass8> icollection_0)
	{
		foreach (GClass8 item in icollection_0)
		{
			item.method_63();
		}
	}

	private void method_70()
	{
		try
		{
			if (File.Exists(string_4))
			{
				File.Delete(string_4);
			}
		}
		catch (IOException ex)
		{
			if (Boolean_6)
			{
				TextWriter_0.WriteLine("ZipFile::Save: could not delete temp file: {0}.", ex.Message);
			}
		}
	}

	private void method_71()
	{
		if (string_0 == null)
		{
			return;
		}
		if (stream_1 != null)
		{
			try
			{
				stream_1.Dispose();
			}
			catch (IOException)
			{
			}
		}
		stream_1 = null;
		if (string_4 != null)
		{
			method_70();
			string_4 = null;
		}
	}

	public void method_72(string string_6)
	{
		if (string_0 == null)
		{
			stream_1 = null;
		}
		else
		{
			string_1 = string_0;
		}
		string_0 = string_6;
		if (Directory.Exists(string_0))
		{
			throw new ZipException("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "fileName"));
		}
		bool_9 = true;
		bool_8 = File.Exists(string_0);
		method_69();
	}

	public void method_73(Stream stream_2)
	{
		if (stream_2 == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		if (!stream_2.CanWrite)
		{
			throw new ArgumentException("Must be a writable stream.", "outputStream");
		}
		string_0 = null;
		stream_1 = new GStream4(stream_2);
		bool_9 = true;
		bool_8 = false;
		method_69();
	}

	public void method_74(string string_6, SelfExtractorFlavor selfExtractorFlavor_0)
	{
		GClass11 gClass = new GClass11();
		gClass.SelfExtractorFlavor_0 = selfExtractorFlavor_0;
		method_75(string_6, gClass);
	}

	public void method_75(string string_6, GClass11 gclass11_0)
	{
		if (string_0 == null)
		{
			stream_1 = null;
		}
		bool_17 = true;
		string_0 = string_6;
		if (Directory.Exists(string_0))
		{
			throw new ZipException("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "exeToGenerate"));
		}
		bool_9 = true;
		bool_8 = File.Exists(string_0);
		method_76(string_6, gclass11_0);
		method_69();
		bool_17 = false;
	}

	private static void smethod_21(Assembly assembly_0, string string_6, string string_7)
	{
		int num = 0;
		byte[] array = new byte[1024];
		using Stream stream = assembly_0.GetManifestResourceStream(string_6);
		if (stream == null)
		{
			throw new ZipException($"missing resource '{string_6}'");
		}
		using FileStream fileStream = File.OpenWrite(string_7);
		do
		{
			num = stream.Read(array, 0, array.Length);
			fileStream.Write(array, 0, num);
		}
		while (num > 0);
	}

	private void method_76(string string_6, GClass11 gclass11_0)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		string text = null;
		string text2 = null;
		string text3 = null;
		string text4 = null;
		try
		{
			if (File.Exists(string_6) && Boolean_6)
			{
				TextWriter_0.WriteLine("The existing file ({0}) will be overwritten.", string_6);
			}
			if (!string_6.EndsWith(".exe") && Boolean_6)
			{
				TextWriter_0.WriteLine("Warning: The generated self-extracting file will not have an .exe extension.");
			}
			text4 = String_3 ?? Path.GetDirectoryName(string_6);
			text2 = smethod_22(text4, "exe");
			Assembly assembly = typeof(GClass9).Assembly;
			CSharpCodeProvider val = new CSharpCodeProvider((IDictionary<string, string>)new Dictionary<string, string> { { "CompilerVersion", "v2.0" } });
			try
			{
				Class25 @class = null;
				Class25[] array = class25_0;
				foreach (Class25 class2 in array)
				{
					if (class2.selfExtractorFlavor_0 == gclass11_0.SelfExtractorFlavor_0)
					{
						@class = class2;
						break;
					}
				}
				if (@class == null)
				{
					throw new BadStateException($"While saving a Self-Extracting Zip, Cannot find that flavor ({gclass11_0.SelfExtractorFlavor_0})?");
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
				string text5 = smethod_22(text4, "cs");
				using (GClass9 gClass = smethod_7(executingAssembly.GetManifestResourceStream("Ionic.Zip.Resources.ZippedResources.zip")))
				{
					text3 = smethod_22(text4, "tmp");
					if (string.IsNullOrEmpty(gclass11_0.String_2))
					{
						Directory.CreateDirectory(text3);
						GClass8 gClass2 = gClass["zippedFile.ico"];
						if ((gClass2.FileAttributes_0 & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
						{
							gClass2.FileAttributes_0 ^= FileAttributes.ReadOnly;
						}
						gClass2.method_7(text3);
						text = Path.Combine(text3, "zippedFile.ico");
						val2.set_CompilerOptions(val2.get_CompilerOptions() + $"/win32icon:\"{text}\"");
					}
					else
					{
						val2.set_CompilerOptions(val2.get_CompilerOptions() + $"/win32icon:\"{gclass11_0.String_2}\"");
					}
					val2.set_OutputAssembly(text2);
					if (gclass11_0.SelfExtractorFlavor_0 == SelfExtractorFlavor.WinFormsApplication)
					{
						val2.set_CompilerOptions(val2.get_CompilerOptions() + " /target:winexe");
					}
					if (!string.IsNullOrEmpty(gclass11_0.String_8))
					{
						val2.set_CompilerOptions(val2.get_CompilerOptions() + " " + gclass11_0.String_8);
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
							string text6 = Path.Combine(text3, item2);
							smethod_21(executingAssembly, item2, text6);
							val2.get_EmbeddedResources().Add(text6);
						}
					}
					val2.get_EmbeddedResources().Add(assembly.Location);
					stringBuilder.Append("// " + Path.GetFileName(text5) + "\n").Append("// --------------------------------------------\n//\n").Append("// This SFX source file was generated by DotNetZip ")
						.Append(Version_0.ToString())
						.Append("\n//         at ")
						.Append(DateTime.Now.ToString("yyyy MMMM dd  HH:mm:ss"))
						.Append("\n//\n// --------------------------------------------\n\n\n");
					if (!string.IsNullOrEmpty(gclass11_0.String_5))
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"" + gclass11_0.String_5.Replace("\"", "") + "\")]\n");
					}
					else
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"DotNetZip SFX Archive\")]\n");
					}
					if (!string.IsNullOrEmpty(gclass11_0.String_3))
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyInformationalVersion(\"" + gclass11_0.String_3.Replace("\"", "") + "\")]\n");
					}
					string text7 = (string.IsNullOrEmpty(gclass11_0.String_4) ? "Extractor: Copyright © Dino Chiesa 2008-2011" : gclass11_0.String_4.Replace("\"", ""));
					if (!string.IsNullOrEmpty(gclass11_0.String_6))
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"").Append(gclass11_0.String_6.Replace("\"", "")).Append("\")]\n");
					}
					else
					{
						stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"DotNetZip\")]\n");
					}
					stringBuilder.Append("[assembly: System.Reflection.AssemblyCopyright(\"" + text7 + "\")]\n").Append($"[assembly: System.Reflection.AssemblyVersion(\"{Version_0.ToString()}\")]\n");
					if (gclass11_0.Version_0 != null)
					{
						stringBuilder.Append($"[assembly: System.Reflection.AssemblyFileVersion(\"{gclass11_0.Version_0.ToString()}\")]\n");
					}
					stringBuilder.Append("\n\n\n");
					string text8 = gclass11_0.String_1;
					if (text8 != null)
					{
						text8 = text8.Replace("\"", "").Replace("\\", "\\\\");
					}
					string text9 = gclass11_0.String_0;
					if (text9 != null)
					{
						text9 = text9.Replace("\\", "\\\\");
						text9 = text9.Replace("\"", "\\\"");
					}
					foreach (string item3 in @class.list_2)
					{
						using Stream stream = gClass[item3].method_14();
						if (stream == null)
						{
							throw new ZipException($"missing resource '{item3}'");
						}
						using (StreamReader streamReader = new StreamReader(stream))
						{
							while (streamReader.Peek() >= 0)
							{
								string text10 = streamReader.ReadLine();
								if (text8 != null)
								{
									text10 = text10.Replace("@@EXTRACTLOCATION", text8);
								}
								text10 = text10.Replace("@@REMOVE_AFTER_EXECUTE", gclass11_0.Boolean_1.ToString());
								text10 = text10.Replace("@@QUIET", gclass11_0.Boolean_0.ToString());
								if (!string.IsNullOrEmpty(gclass11_0.String_7))
								{
									text10 = text10.Replace("@@SFX_EXE_WINDOW_TITLE", gclass11_0.String_7);
								}
								text10 = text10.Replace("@@EXTRACT_EXISTING_FILE", ((int)gclass11_0.ExtractExistingFileAction_0).ToString());
								if (text9 != null)
								{
									text10 = text10.Replace("@@POST_UNPACK_CMD_LINE", text9);
								}
								stringBuilder.Append(text10).Append("\n");
							}
						}
						stringBuilder.Append("\n\n");
					}
				}
				string text11 = stringBuilder.ToString();
				CompilerResults val3 = ((CodeDomProvider)val).CompileAssemblyFromSource(val2, new string[1] { text11 });
				if (val3 == null)
				{
					throw new SfxGenerationException("Cannot compile the extraction logic!");
				}
				if (Boolean_6)
				{
					StringEnumerator enumerator2 = val3.get_Output().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string current4 = enumerator2.Current;
							TextWriter_0.WriteLine(current4);
						}
					}
					finally
					{
						if (enumerator2 is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
				}
				if (((CollectionBase)(object)val3.get_Errors()).Count != 0)
				{
					using (TextWriter textWriter = new StreamWriter(text5))
					{
						textWriter.Write(text11);
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
				method_48(ZipProgressEventType.Saving_AfterCompileSelfExtractor);
				using Stream stream2 = File.OpenRead(text2);
				byte[] array2 = new byte[4000];
				int num = 1;
				while (num != 0)
				{
					num = stream2.Read(array2, 0, array2.Length);
					if (num != 0)
					{
						Stream_1.Write(array2, 0, num);
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			method_48(ZipProgressEventType.Saving_AfterSaveTempArchive);
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
						TextWriter_0.WriteLine("Warning: Exception: {0}", arg);
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
						TextWriter_0.WriteLine("Warning: Exception: {0}", arg2);
					}
				}
			}
			catch (IOException)
			{
			}
		}
	}

	internal static string smethod_22(string string_6, string string_7)
	{
		string text = null;
		string name = Assembly.GetExecutingAssembly().GetName().Name;
		do
		{
			string text2 = Guid.NewGuid().ToString();
			string path = string.Format("{0}-{1}-{2}.{3}", name, DateTime.Now.ToString("yyyyMMMdd-HHmmss"), text2, string_7);
			text = Path.Combine(string_6, path);
		}
		while (File.Exists(text) || Directory.Exists(text));
		return text;
	}

	public void method_77(string string_6)
	{
		method_82(string_6, ".", null, bool_18: false);
	}

	public void method_78(string string_6, bool bool_18)
	{
		method_82(string_6, ".", null, bool_18);
	}

	public void method_79(string string_6, string string_7)
	{
		method_82(string_6, string_7, null, bool_18: false);
	}

	public void method_80(string string_6, string string_7, bool bool_18)
	{
		method_82(string_6, string_7, null, bool_18);
	}

	public void method_81(string string_6, string string_7, string string_8)
	{
		method_82(string_6, string_7, string_8, bool_18: false);
	}

	public void method_82(string string_6, string string_7, string string_8, bool bool_18)
	{
		method_85(string_6, string_7, string_8, bool_18, bool_19: false);
	}

	public void method_83(string string_6, string string_7, string string_8, bool bool_18)
	{
		method_85(string_6, string_7, string_8, bool_18, bool_19: true);
	}

	private string method_84(string string_6)
	{
		if (string_6.EndsWith("\\"))
		{
			return string_6;
		}
		return string_6 + "\\";
	}

	private void method_85(string string_6, string string_7, string string_8, bool bool_18, bool bool_19)
	{
		if (string_7 == null && Directory.Exists(string_6))
		{
			string_7 = string_6;
			string_6 = "*.*";
		}
		else if (string.IsNullOrEmpty(string_7))
		{
			string_7 = ".";
		}
		while (string_7.EndsWith("\\"))
		{
			string_7 = string_7.Substring(0, string_7.Length - 1);
		}
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("adding selection '{0}' from dir '{1}'...", string_6, string_7);
		}
		ReadOnlyCollection<string> readOnlyCollection = new GClass3(string_6, Boolean_2).method_3(string_7, bool_18);
		if (Boolean_6)
		{
			TextWriter_0.WriteLine("found {0} files...", readOnlyCollection.Count);
		}
		method_61();
		AddOrUpdateAction addOrUpdateAction_ = (bool_19 ? AddOrUpdateAction.AddOrUpdate : AddOrUpdateAction.AddOnly);
		foreach (string item in readOnlyCollection)
		{
			string string_9 = ((string_8 == null) ? null : smethod_23(Path.GetDirectoryName(item), string_7, string_8));
			if (File.Exists(item))
			{
				if (bool_19)
				{
					method_12(item, string_9);
				}
				else
				{
					method_3(item, string_9);
				}
			}
			else
			{
				method_36(item, string_9, addOrUpdateAction_, bool_18: false, 0);
			}
		}
		method_62();
	}

	private static string smethod_23(string string_6, string string_7, string string_8)
	{
		string text = string_6.ToUpper();
		string text2 = string_7.ToUpper();
		if (text.IndexOf(text2) != 0)
		{
			return string_6;
		}
		return string_8 + string_6.Substring(text2.Length);
	}

	public ICollection<GClass8> method_86(string string_6)
	{
		return new GClass3(string_6, Boolean_2).method_5(this);
	}

	public ICollection<GClass8> method_87(string string_6, string string_7)
	{
		return new GClass3(string_6, Boolean_2).method_6(this, string_7);
	}

	public int method_88(string string_6)
	{
		ICollection<GClass8> collection = method_86(string_6);
		method_4(collection);
		return collection.Count;
	}

	public int method_89(string string_6, string string_7)
	{
		ICollection<GClass8> collection = method_87(string_6, string_7);
		method_4(collection);
		return collection.Count;
	}

	public void method_90(string string_6)
	{
		foreach (GClass8 item in method_86(string_6))
		{
			item.String_4 = string_3;
			item.method_4();
		}
	}

	public void method_91(string string_6, ExtractExistingFileAction extractExistingFileAction_1)
	{
		foreach (GClass8 item in method_86(string_6))
		{
			item.String_4 = string_3;
			item.method_5(extractExistingFileAction_1);
		}
	}

	public void method_92(string string_6, string string_7)
	{
		foreach (GClass8 item in method_87(string_6, string_7))
		{
			item.String_4 = string_3;
			item.method_4();
		}
	}

	public void method_93(string string_6, string string_7, string string_8)
	{
		foreach (GClass8 item in method_87(string_6, string_7))
		{
			item.String_4 = string_3;
			item.method_7(string_8);
		}
	}

	public void method_94(string string_6, string string_7, string string_8, ExtractExistingFileAction extractExistingFileAction_1)
	{
		foreach (GClass8 item in method_87(string_6, string_7))
		{
			item.String_4 = string_3;
			item.method_8(string_8, extractExistingFileAction_1);
		}
	}

	public IEnumerator<GClass8> GetEnumerator()
	{
		foreach (GClass8 value in dictionary_0.Values)
		{
			yield return value;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[DispId(-4)]
	public IEnumerator method_95()
	{
		return GetEnumerator();
	}
}
