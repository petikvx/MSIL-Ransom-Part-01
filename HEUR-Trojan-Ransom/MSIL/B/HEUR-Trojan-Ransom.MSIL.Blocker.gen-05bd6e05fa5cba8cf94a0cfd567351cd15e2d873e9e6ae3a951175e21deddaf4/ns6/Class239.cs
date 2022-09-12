using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Bson;
using ns1;
using ns10;
using ns17;
using ns18;
using ns3;
using ns7;
using ns8;
using ns9;

namespace ns6;

internal class Class239
{
	internal static readonly Encoding encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	internal readonly BinaryWriter binaryWriter_0;

	internal byte[] byte_0;

	[CompilerGenerated]
	private DateTimeKind dateTimeKind_0;

	public DateTimeKind DateTimeKindHandling
	{
		[CompilerGenerated]
		get
		{
			return dateTimeKind_0;
		}
		[CompilerGenerated]
		set
		{
			dateTimeKind_0 = value;
		}
	}

	public Class239(BinaryWriter binaryWriter_1)
	{
		DateTimeKindHandling = DateTimeKind.Utc;
		binaryWriter_0 = binaryWriter_1;
	}

	internal void method_0(Class242 class242_0)
	{
		switch (class242_0.Type)
		{
		case BsonType.Number:
		{
			Class246 class8 = (Class246)class242_0;
			binaryWriter_0.Write(Convert.ToDouble(class8.object_0, CultureInfo.InvariantCulture));
			break;
		}
		case BsonType.String:
		{
			Class248 class6 = (Class248)class242_0;
			string string_ = (string)class6.object_0;
			int int_ = class6.ByteCount;
			int? nullable_2 = class6.CalculatedSize - 4;
			Class4.smethod_380(string_, this, int_, nullable_2);
			break;
		}
		case BsonType.Object:
		{
			Class243 class7 = (Class243)class242_0;
			binaryWriter_0.Write(class7.CalculatedSize);
			using (IEnumerator<Class251> enumerator = class7.System_002ECollections_002EGeneric_002EIEnumerable_003Cns9_002EClass251_003E_002EGetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class251 current = enumerator.Current;
					binaryWriter_0.Write((sbyte)current.Value.Type);
					string string_ = (string)current.Name.object_0;
					int byteCount3 = current.Name.ByteCount;
					int? nullable_ = null;
					int int_ = byteCount3;
					Class4.smethod_380(string_, this, int_, nullable_);
					method_0(current.Value);
				}
			}
			binaryWriter_0.Write((byte)0);
			break;
		}
		case BsonType.Array:
		{
			Class244 class9 = (Class244)class242_0;
			binaryWriter_0.Write(class9.CalculatedSize);
			ulong num2 = 0uL;
			using (IEnumerator<Class242> enumerator2 = class9.System_002ECollections_002EGeneric_002EIEnumerable_003Cns17_002EClass242_003E_002EGetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class242 current2 = enumerator2.Current;
					binaryWriter_0.Write((sbyte)current2.Type);
					string string_ = num2.ToString(CultureInfo.InvariantCulture);
					int num3 = Class4.smethod_71(num2);
					int? nullable_ = null;
					int int_ = num3;
					Class4.smethod_380(string_, this, int_, nullable_);
					method_0(current2);
					num2++;
				}
			}
			binaryWriter_0.Write((byte)0);
			break;
		}
		case BsonType.Binary:
		{
			Class249 class5 = (Class249)class242_0;
			byte[] array = (byte[])class5.object_0;
			binaryWriter_0.Write(array.Length);
			binaryWriter_0.Write((byte)class5.BinaryType);
			binaryWriter_0.Write(array);
			break;
		}
		case BsonType.Oid:
		{
			byte[] buffer = (byte[])((Class246)class242_0).object_0;
			binaryWriter_0.Write(buffer);
			break;
		}
		case BsonType.Boolean:
			binaryWriter_0.Write(class242_0 == Class247.class247_1);
			break;
		case BsonType.Date:
		{
			Class246 class4 = (Class246)class242_0;
			long num = 0L;
			if (class4.object_0 is DateTime dateTime_)
			{
				if (DateTimeKindHandling == DateTimeKind.Utc)
				{
					dateTime_ = dateTime_.ToUniversalTime();
				}
				else if (DateTimeKindHandling == DateTimeKind.Local)
				{
					dateTime_ = dateTime_.ToLocalTime();
				}
				num = Class4.smethod_70(dateTime_, bool_0: false);
			}
			else
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)class4.object_0;
				DateTime utcDateTime = dateTimeOffset.UtcDateTime;
				TimeSpan offset = dateTimeOffset.Offset;
				num = Class4.smethod_476(offset, utcDateTime);
			}
			binaryWriter_0.Write(num);
			break;
		}
		case BsonType.Undefined:
		case BsonType.Null:
			break;
		case BsonType.Regex:
		{
			Class250 class3 = (Class250)class242_0;
			string string_ = (string)class3.Pattern.object_0;
			int byteCount = class3.Pattern.ByteCount;
			int? nullable_ = null;
			int int_ = byteCount;
			Class4.smethod_380(string_, this, int_, nullable_);
			string_ = (string)class3.Options.object_0;
			int byteCount2 = class3.Options.ByteCount;
			nullable_ = null;
			int_ = byteCount2;
			Class4.smethod_380(string_, this, int_, nullable_);
			break;
		}
		case BsonType.Integer:
		{
			Class246 class2 = (Class246)class242_0;
			binaryWriter_0.Write(Convert.ToInt32(class2.object_0, CultureInfo.InvariantCulture));
			break;
		}
		default:
			throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".smethod_1(CultureInfo.InvariantCulture, class242_0.Type));
		case BsonType.Long:
		{
			Class246 @class = (Class246)class242_0;
			binaryWriter_0.Write(Convert.ToInt64(@class.object_0, CultureInfo.InvariantCulture));
			break;
		}
		}
	}
}
