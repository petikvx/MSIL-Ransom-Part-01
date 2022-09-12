using System;
using System.Reflection;
using Ubiety.Dns.Core.Records;

namespace Ubiety.Dns.Core.Common;

public static class EnumExtensions
{
	public static Record GetRecord(this RecordType type, RecordReader reader, int length = 0)
	{
		FieldInfo field = type.GetType().GetField(type.ToString());
		RecordAttribute customAttribute = field.GetCustomAttribute<RecordAttribute>();
		if (type == RecordType.TXT)
		{
			return (Record)Activator.CreateInstance(customAttribute.RecordType, reader, length);
		}
		return (Record)Activator.CreateInstance(customAttribute.RecordType, reader);
	}
}
