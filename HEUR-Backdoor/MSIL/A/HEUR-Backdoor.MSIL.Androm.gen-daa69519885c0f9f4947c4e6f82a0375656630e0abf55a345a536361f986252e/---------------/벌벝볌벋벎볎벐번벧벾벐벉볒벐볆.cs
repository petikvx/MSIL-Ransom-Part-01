using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Markup;

namespace _2528_2566_2526_2527_2526_2561_2566_2522_2555_2551_251F_2521_253B_2528_2546;

[DebuggerNonUserCode]
[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class 벌벝볌벋벎볎벐번벧벾벐벉볒벐볆 : InternalTypeHelper
{
	protected override object CreateInstance(Type type, CultureInfo culture)
	{
		//Discarded unreachable code: IL_0012, IL_0014
		//IL_0014: Ignored invalid 'constrained' prefix
		object obj = Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, culture);
		/*Error near IL_0010: Could not find block for branch target IL_001a*/;
	}

	protected override object GetPropertyValue(PropertyInfo propertyInfo, object target, CultureInfo culture)
	{
		//Discarded unreachable code: IL_000f, IL_0011
		//IL_0011: Ignored invalid 'constrained' prefix
		object value = propertyInfo.GetValue(target, BindingFlags.Default, null, null, culture);
		/*Error near IL_000d: Could not find block for branch target IL_0017*/;
	}

	protected override void SetPropertyValue(PropertyInfo propertyInfo, object target, object value, CultureInfo culture)
	{
		propertyInfo.SetValue(target, value, BindingFlags.Default, null, null, culture);
	}

	protected override Delegate CreateDelegate(Type delegateType, object target, string handler)
	{
		//Discarded unreachable code: IL_002f, IL_0031
		//IL_0031: Ignored invalid 'constrained' prefix
		Delegate @delegate = (Delegate)target.GetType().InvokeMember("_CreateDelegate", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, new object[2] { delegateType, handler }, null);
		/*Error near IL_002d: Could not find block for branch target IL_0037*/;
	}

	protected override void AddEventHandler(EventInfo eventInfo, object target, Delegate handler)
	{
		eventInfo.AddEventHandler(target, handler);
	}
}
