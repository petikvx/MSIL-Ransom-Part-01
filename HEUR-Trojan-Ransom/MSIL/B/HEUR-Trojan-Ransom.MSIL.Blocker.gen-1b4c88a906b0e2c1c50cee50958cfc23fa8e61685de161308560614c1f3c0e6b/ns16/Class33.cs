using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using ns10;
using ns12;
using ns14;
using ns9;

namespace ns16;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
internal class Class33 : Class29
{
	internal enum BsonReaderState
	{
		Normal,
		ReferenceStart,
		ReferenceRef,
		ReferenceId,
		CodeWScopeStart,
		CodeWScopeCode,
		CodeWScopeScope,
		CodeWScopeScopeObject,
		CodeWScopeScopeEnd
	}

	internal class Class241
	{
		public readonly BsonType bsonType_0;

		public int int_0;

		public int int_1;

		public Class241(BsonType bsonType_1)
		{
			bsonType_0 = bsonType_1;
		}
	}

	private const int int_0 = 128;

	internal static readonly byte[] byte_0 = new byte[2] { 0, 127 };

	internal static readonly byte[] byte_1 = new byte[2] { 194, 223 };

	internal static readonly byte[] byte_2 = new byte[2] { 224, 239 };

	internal static readonly byte[] byte_3 = new byte[2] { 240, 244 };

	internal readonly BinaryReader binaryReader_0;

	internal readonly List<Class241> list_1;

	internal byte[] byte_4;

	internal char[] char_1;

	internal BsonType bsonType_0;

	internal BsonReaderState bsonReaderState_0;

	internal Class241 class241_0;

	internal bool bool_3;

	internal bool bool_4;

	internal DateTimeKind dateTimeKind_0;

	[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
	public bool JsonNet35BinaryCompatibility
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	public bool ReadRootValueAsArray
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

	public DateTimeKind DateTimeKindHandling
	{
		get
		{
			return dateTimeKind_0;
		}
		set
		{
			dateTimeKind_0 = value;
		}
	}

	public Class33(Stream stream_0)
		: this(stream_0, bool_5: false, DateTimeKind.Local)
	{
	}

	public Class33(BinaryReader binaryReader_1)
		: this(binaryReader_1, bool_5: false, DateTimeKind.Local)
	{
	}

	public Class33(Stream stream_0, bool bool_5, DateTimeKind dateTimeKind_1)
	{
		Class113.smethod_0(stream_0, "stream");
		binaryReader_0 = new BinaryReader(stream_0);
		list_1 = new List<Class241>();
		bool_3 = bool_5;
		dateTimeKind_0 = dateTimeKind_1;
	}

	public Class33(BinaryReader binaryReader_1, bool bool_5, DateTimeKind dateTimeKind_1)
	{
		Class113.smethod_0(binaryReader_1, "reader");
		binaryReader_0 = binaryReader_1;
		list_1 = new List<Class241>();
		bool_3 = bool_5;
		dateTimeKind_0 = dateTimeKind_1;
	}

	public override bool vmethod_0()
	{
		try
		{
			bool flag;
			switch (bsonReaderState_0)
			{
			default:
				throw Class7.smethod_555((Class29)this, "Unexpected state: {0}".smethod_1(CultureInfo.InvariantCulture, bsonReaderState_0));
			case BsonReaderState.Normal:
				flag = Class7.smethod_4(this);
				break;
			case BsonReaderState.ReferenceStart:
			case BsonReaderState.ReferenceRef:
			case BsonReaderState.ReferenceId:
				flag = Class7.smethod_549(this);
				break;
			case BsonReaderState.CodeWScopeStart:
			case BsonReaderState.CodeWScopeCode:
			case BsonReaderState.CodeWScopeScope:
			case BsonReaderState.CodeWScopeScopeObject:
			case BsonReaderState.CodeWScopeScopeEnd:
				flag = Class7.smethod_449(this);
				break;
			}
			if (!flag)
			{
				Class7.smethod_386((Class29)this, JsonToken.None);
				return false;
			}
			return true;
		}
		catch (EndOfStreamException)
		{
			Class7.smethod_386((Class29)this, JsonToken.None);
			return false;
		}
	}

	public override void vmethod_10()
	{
		base.vmethod_10();
		if (base.CloseInput)
		{
			binaryReader_0?.Close();
		}
	}
}
