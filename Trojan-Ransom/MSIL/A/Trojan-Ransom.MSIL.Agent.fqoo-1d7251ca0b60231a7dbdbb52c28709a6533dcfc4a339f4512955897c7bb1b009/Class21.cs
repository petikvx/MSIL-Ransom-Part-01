using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

internal class Class21 : IDisposable
{
	public class Class22
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private uint uint_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private DateTime dateTime_0;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string String_1
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public uint UInt32_0
		{
			[CompilerGenerated]
			get
			{
				return uint_0;
			}
			[CompilerGenerated]
			set
			{
				uint_0 = value;
			}
		}

		public int Int32_0
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

		public int Int32_1
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
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

		public bool Boolean_1 => String_0.EndsWith("/");

		public DateTime DateTime_0
		{
			[CompilerGenerated]
			get
			{
				return dateTime_0;
			}
			[CompilerGenerated]
			set
			{
				dateTime_0 = value;
			}
		}

		public bool Boolean_2 => !Boolean_1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Int32_2
		{
			[CompilerGenerated]
			get
			{
				return int_2;
			}
			[CompilerGenerated]
			set
			{
				int_2 = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Int32_3
		{
			[CompilerGenerated]
			get
			{
				return int_3;
			}
			[CompilerGenerated]
			set
			{
				int_3 = value;
			}
		}
	}

	public class Class23
	{
		private static readonly uint[] uint_0 = new uint[256]
		{
			0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
			3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
			450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
			4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
			901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
			3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
			795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
			2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
			1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
			2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
			1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
			2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
			1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
			62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
			3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
			426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
			3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
			906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
			3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
			752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
			2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
			1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
			2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
			1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
			3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
			1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
		};

		private uint uint_1 = uint.MaxValue;

		public uint UInt32_0 => uint_1 ^ 0xFFFFFFFFu;

		public void method_0(byte[] byte_0, int int_0)
		{
			for (int i = 0; i < int_0; i++)
			{
				uint_1 = (uint_1 >> 8) ^ uint_0[byte_0[i] ^ (uint_1 & 0xFF)];
			}
		}
	}

	public class EventArgs0 : ProgressChangedEventArgs
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_0;

		public int Int32_0
		{
			[CompilerGenerated]
			get
			{
				return int_0;
			}
			[CompilerGenerated]
			private set
			{
				int_0 = value;
			}
		}

		public int Int32_1
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			private set
			{
				int_1 = value;
			}
		}

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			private set
			{
				string_0 = value;
			}
		}

		public EventArgs0(int int_2, int int_3, string string_1)
			: base((int_3 != 0) ? (int_2 * 100 / int_3) : 100, string_1)
		{
			Int32_0 = int_2;
			Int32_1 = int_3;
			String_0 = string_1;
		}
	}

	[CompilerGenerated]
	private sealed class Class24
	{
		public string string_0;

		internal bool method_0(Class22 class22_0)
		{
			return class22_0.String_0 == string_0;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class25
	{
		public static readonly Class25 _003C_003E9 = new Class25();

		public static Func<Class22, string> _003C_003E9__27_0;

		public static Func<string, bool> _003C_003E9__27_1;

		public static Func<string, string> _003C_003E9__27_2;

		internal string method_0(Class22 class22_0)
		{
			return class22_0.String_0;
		}

		internal bool method_1(string string_0)
		{
			return !string_0.EndsWith("/");
		}

		internal string method_2(string string_0)
		{
			return string_0;
		}
	}

	private const int int_0 = 33639248;

	private const int int_1 = 67324752;

	private const int int_2 = 101010256;

	private const int int_3 = 16384;

	[CompilerGenerated]
	private EventHandler<EventArgs0> eventHandler_0;

	[CompilerGenerated]
	private Stream stream_0;

	[CompilerGenerated]
	private BinaryReader binaryReader_0;

	private Class22[] class22_0;

	private Stream Stream_0
	{
		[CompilerGenerated]
		get
		{
			return stream_0;
		}
		[CompilerGenerated]
		set
		{
			stream_0 = value;
		}
	}

	private BinaryReader BinaryReader_0
	{
		[CompilerGenerated]
		get
		{
			return binaryReader_0;
		}
		[CompilerGenerated]
		set
		{
			binaryReader_0 = value;
		}
	}

	public IEnumerable<string> IEnumerable_0 => from class22_0 in Class22_0
		select class22_0.String_0 into string_0
		where !string_0.EndsWith("/")
		orderby string_0
		select string_0;

	public Class22[] Class22_0
	{
		get
		{
			if (class22_0 == null)
			{
				class22_0 = method_5().ToArray();
			}
			return class22_0;
		}
	}

	public event EventHandler<EventArgs0> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs0> eventHandler = eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> value2 = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs0> eventHandler = eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> value2 = (EventHandler<EventArgs0>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Class21(string string_0)
		: this(File.OpenRead(string_0))
	{
	}

	public Class21(Stream stream_1)
	{
		Stream_0 = stream_1;
		BinaryReader_0 = new BinaryReader(Stream_0);
	}

	public void Dispose()
	{
		if (Stream_0 != null)
		{
			Stream_0.Dispose();
			Stream_0 = null;
		}
		if (BinaryReader_0 != null)
		{
			BinaryReader_0.Close();
			BinaryReader_0 = null;
		}
	}

	public void method_0(string string_0)
	{
		for (int i = 0; i < Class22_0.Length; i++)
		{
			Class22 @class = Class22_0[i];
			string text = Path.Combine(string_0, @class.String_0);
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			if (!@class.Boolean_1)
			{
				method_1(@class.String_0, text);
			}
			eventHandler_0?.Invoke(this, new EventArgs0(i + 1, Class22_0.Length, @class.String_0));
		}
	}

	public void method_1(string string_0, string string_1)
	{
		Class22 @class = method_2(string_0);
		using (FileStream stream_ = File.Create(string_1))
		{
			method_4(@class, stream_);
		}
		FileInfo fileInfo = new FileInfo(string_1);
		if (fileInfo.Length != @class.Int32_1)
		{
			throw new InvalidDataException($"Corrupted archive: {string_1} has an uncompressed size {fileInfo.Length} which does not match its expected size {@class.Int32_1}");
		}
		File.SetLastWriteTime(string_1, @class.DateTime_0);
	}

	private Class22 method_2(string string_0)
	{
		string_0 = string_0.Replace("\\", "/").Trim().TrimStart(new char[1] { '/' });
		return Class22_0.FirstOrDefault((Class22 class22_0) => class22_0.String_0 == string_0) ?? throw new FileNotFoundException("File not found in the archive: " + string_0);
	}

	public void method_3(string string_0, Stream stream_1)
	{
		method_4(method_2(string_0), stream_1);
	}

	public void method_4(Class22 class22_1, Stream stream_1)
	{
		Stream_0.Seek(class22_1.Int32_2, SeekOrigin.Begin);
		if (BinaryReader_0.ReadInt32() == 67324752)
		{
			Stream_0.Seek(class22_1.Int32_3, SeekOrigin.Begin);
			Stream stream = Stream_0;
			if (class22_1.Boolean_0)
			{
				stream = new DeflateStream(Stream_0, CompressionMode.Decompress, leaveOpen: true);
			}
			int num = class22_1.Int32_1;
			int num2 = Math.Min(16384, class22_1.Int32_1);
			byte[] array = new byte[num2];
			Class23 @class = new Class23();
			while (num > 0)
			{
				int num3 = stream.Read(array, 0, num2);
				if (num3 == 0)
				{
					break;
				}
				@class.method_0(array, num3);
				stream_1.Write(array, 0, num3);
				num -= num3;
			}
			if (@class.UInt32_0 == class22_1.UInt32_0)
			{
				return;
			}
			throw new InvalidDataException($"Corrupted archive: CRC32 doesn't match on file {class22_1.String_0}: expected {class22_1.UInt32_0:x8}, got {@class.UInt32_0:x8}.");
		}
		throw new InvalidDataException("File signature doesn't match.");
	}

	private IEnumerable<Class22> method_5()
	{
		if (Stream_0.Length < 22L)
		{
			yield break;
		}
		Stream_0.Seek(-22L, SeekOrigin.End);
		ushort num;
		int i;
		while (true)
		{
			if (BinaryReader_0.ReadInt32() != 101010256)
			{
				if (Stream_0.Position > 5L)
				{
					Stream_0.Seek(-5L, SeekOrigin.Current);
					continue;
				}
				yield break;
			}
			Stream_0.Seek(6L, SeekOrigin.Current);
			num = BinaryReader_0.ReadUInt16();
			BinaryReader_0.ReadInt32();
			uint num2 = BinaryReader_0.ReadUInt32();
			Stream_0.Seek(num2, SeekOrigin.Begin);
			i = 0;
			break;
		}
		for (; i < num; i++)
		{
			if (BinaryReader_0.ReadInt32() == 33639248)
			{
				BinaryReader_0.ReadInt32();
				bool num3 = (BinaryReader_0.ReadInt16() & 0x800) != 0;
				short num4 = BinaryReader_0.ReadInt16();
				int int_ = BinaryReader_0.ReadInt32();
				uint uInt32_ = BinaryReader_0.ReadUInt32();
				int int32_ = BinaryReader_0.ReadInt32();
				int int32_2 = BinaryReader_0.ReadInt32();
				short count = BinaryReader_0.ReadInt16();
				short num5 = BinaryReader_0.ReadInt16();
				short count2 = BinaryReader_0.ReadInt16();
				BinaryReader_0.ReadInt32();
				BinaryReader_0.ReadInt32();
				int num6 = BinaryReader_0.ReadInt32();
				byte[] bytes = BinaryReader_0.ReadBytes(count);
				Stream_0.Seek(num5, SeekOrigin.Current);
				byte[] bytes2 = BinaryReader_0.ReadBytes(count2);
				int int32_3 = method_6(num6);
				Encoding encoding = ((!num3) ? Encoding.Default : Encoding.UTF8);
				yield return new Class22
				{
					String_0 = encoding.GetString(bytes),
					String_1 = encoding.GetString(bytes2),
					UInt32_0 = uInt32_,
					Int32_0 = int32_,
					Int32_1 = int32_2,
					Int32_2 = num6,
					Int32_3 = int32_3,
					Boolean_0 = (num4 == 8),
					DateTime_0 = smethod_0(int_)
				};
			}
		}
	}

	private int method_6(int int_4)
	{
		long position = Stream_0.Position;
		Stream_0.Seek(int_4 + 26, SeekOrigin.Begin);
		short num = BinaryReader_0.ReadInt16();
		short num2 = BinaryReader_0.ReadInt16();
		int result = (int)Stream_0.Position + num + num2;
		Stream_0.Seek(position, SeekOrigin.Begin);
		return result;
	}

	public static DateTime smethod_0(int int_4)
	{
		return new DateTime((int_4 >> 25) + 1980, (int_4 >> 21) & 0xF, (int_4 >> 16) & 0x1F, (int_4 >> 11) & 0x1F, (int_4 >> 5) & 0x3F, (int_4 & 0x1F) * 2);
	}
}
