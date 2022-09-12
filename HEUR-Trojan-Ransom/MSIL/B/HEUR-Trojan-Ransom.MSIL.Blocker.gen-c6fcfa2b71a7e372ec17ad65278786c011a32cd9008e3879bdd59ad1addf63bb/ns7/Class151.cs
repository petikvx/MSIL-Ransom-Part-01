using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns12;
using ns13;
using ns15;
using ns16;
using ns3;
using ns5;
using ns8;

namespace ns7;

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

	private Class43<string, object>? class43_0;

	internal readonly Class33 class33_0;

	internal readonly Interface7? interface7_0;

	protected internal Class34? class34_0;

	internal Class43<string, object> DefaultReferenceMappings
	{
		get
		{
			if (class43_0 == null)
			{
				class43_0 = new Class43<string, object>(EqualityComparer<string>.Default, new Class153(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
			}
			return class43_0;
		}
	}

	protected Class151(Class33 class33_1)
	{
		Class112.smethod_0(class33_1, "serializer");
		class33_0 = class33_1;
		interface7_0 = class33_1.TraceWriter;
	}

	protected internal bool method_0(object? object_0, Class137? class137_0, object? object_1, Interface1? interface1_0, string string_0, Exception exception_0)
	{
		Class135 @class = Class131.smethod_191(exception_0, this, object_0, object_1, string_0);
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
			class137_0!.method_4(object_0, class33_0.Context, @class);
		}
		if (!@class.Handled)
		{
			Class131.smethod_651(class33_0, new EventArgs0(object_0, @class));
		}
		return @class.Handled;
	}
}
