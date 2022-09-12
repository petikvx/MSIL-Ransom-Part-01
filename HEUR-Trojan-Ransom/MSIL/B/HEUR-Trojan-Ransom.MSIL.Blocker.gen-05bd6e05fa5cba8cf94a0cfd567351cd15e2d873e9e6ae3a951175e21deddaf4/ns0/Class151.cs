using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns1;
using ns10;
using ns18;
using ns2;
using ns4;
using ns5;
using ns7;
using ns8;

namespace ns0;

internal abstract class Class151
{
	private class Class153 : IEqualityComparer<object>
	{
		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}
	}

	internal Class135? class135_0;

	private Class44<string, object>? class44_0;

	internal readonly Class34 class34_0;

	internal readonly Interface7? interface7_0;

	protected internal Class35? class35_0;

	internal Class44<string, object> DefaultReferenceMappings
	{
		get
		{
			if (class44_0 == null)
			{
				class44_0 = new Class44<string, object>(EqualityComparer<string>.Default, new Class153(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
			}
			return class44_0;
		}
	}

	protected Class151(Class34 class34_1)
	{
		Class113.smethod_0(class34_1, "serializer");
		class34_0 = class34_1;
		interface7_0 = class34_1.TraceWriter;
	}

	protected internal bool method_0(object? object_0, Class137? class137_0, object? object_1, Interface1? interface1_0, string string_0, Exception exception_0)
	{
		Class135 @class = Class4.smethod_587(exception_0, object_1, object_0, this, string_0);
		if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Error && !@class.Traced)
		{
			@class.Traced = true;
			string text = ((GetType() == typeof(Class152)) ? "Error serializing" : "Error deserializing");
			if (class137_0 != null)
			{
				text = text + " " + class137_0!.UnderlyingType;
			}
			text = text + ". " + exception_0.Message;
			if (!(exception_0 is JsonException))
			{
				text = Struct0.smethod_2(interface1_0, string_0, text);
			}
			interface7_0!.imethod_0(TraceLevel.Error, text, exception_0);
		}
		if (class137_0 != null && object_0 != null)
		{
			class137_0!.method_4(object_0, class34_0.Context, @class);
		}
		if (!@class.Handled)
		{
			Class34 class2 = class34_0;
			EventArgs0 eventArgs0_ = new EventArgs0(object_0, @class);
			Class4.smethod_413(eventArgs0_, class2);
		}
		return @class.Handled;
	}
}
