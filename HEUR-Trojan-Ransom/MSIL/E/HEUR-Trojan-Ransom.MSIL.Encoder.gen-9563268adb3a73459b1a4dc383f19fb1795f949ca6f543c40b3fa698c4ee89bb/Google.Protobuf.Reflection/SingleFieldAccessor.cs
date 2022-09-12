using System;
using System.Reflection;

namespace Google.Protobuf.Reflection;

internal sealed class SingleFieldAccessor : FieldAccessorBase
{
	private readonly Action<IMessage, object> setValueDelegate;

	private readonly Action<IMessage> clearDelegate;

	internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
		: base(property, descriptor)
	{
		if (!property.CanWrite)
		{
			throw new ArgumentException("Not all required properties/methods available");
		}
		setValueDelegate = ReflectionUtil.CreateActionIMessageObject(property.GetSetMethod());
		Type propertyType = property.PropertyType;
		object defaultValue = ((descriptor.FieldType == FieldType.Message) ? null : ((propertyType == typeof(string)) ? "" : ((propertyType == typeof(ByteString)) ? ByteString.Empty : Activator.CreateInstance(propertyType))));
		clearDelegate = delegate(IMessage message)
		{
			SetValue(message, defaultValue);
		};
	}

	public override void Clear(IMessage message)
	{
		clearDelegate(message);
	}

	public override void SetValue(IMessage message, object value)
	{
		setValueDelegate(message, value);
	}
}
