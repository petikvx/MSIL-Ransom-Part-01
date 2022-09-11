using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System.Runtime.Caching.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class R
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("System.Runtime.Caching.Resources.R", typeof(R).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Argument_out_of_range => ResourceManager.GetString("Argument_out_of_range", resourceCulture);

	internal static string Collection_contains_null_element => ResourceManager.GetString("Collection_contains_null_element", resourceCulture);

	internal static string Collection_contains_null_or_empty_string => ResourceManager.GetString("Collection_contains_null_or_empty_string", resourceCulture);

	internal static string Config_unable_to_get_section => ResourceManager.GetString("Config_unable_to_get_section", resourceCulture);

	internal static string Default_is_reserved => ResourceManager.GetString("Default_is_reserved", resourceCulture);

	internal static string Empty_collection => ResourceManager.GetString("Empty_collection", resourceCulture);

	internal static string Init_not_complete => ResourceManager.GetString("Init_not_complete", resourceCulture);

	internal static string Invalid_argument_combination => ResourceManager.GetString("Invalid_argument_combination", resourceCulture);

	internal static string Invalid_callback_combination => ResourceManager.GetString("Invalid_callback_combination", resourceCulture);

	internal static string Invalid_expiration_combination => ResourceManager.GetString("Invalid_expiration_combination", resourceCulture);

	internal static string Invalid_state => ResourceManager.GetString("Invalid_state", resourceCulture);

	internal static string Method_already_invoked => ResourceManager.GetString("Method_already_invoked", resourceCulture);

	internal static string Property_already_set => ResourceManager.GetString("Property_already_set", resourceCulture);

	internal static string TimeSpan_invalid_format => ResourceManager.GetString("TimeSpan_invalid_format", resourceCulture);

	internal static string Update_callback_must_be_null => ResourceManager.GetString("Update_callback_must_be_null", resourceCulture);

	internal static string Value_must_be_non_negative_integer => ResourceManager.GetString("Value_must_be_non_negative_integer", resourceCulture);

	internal static string Value_must_be_positive_integer => ResourceManager.GetString("Value_must_be_positive_integer", resourceCulture);

	internal static string Value_too_big => ResourceManager.GetString("Value_too_big", resourceCulture);

	internal static string Value_must_be_boolean => ResourceManager.GetString("Value_must_be_boolean", resourceCulture);

	internal static string Empty_string_invalid => ResourceManager.GetString("Empty_string_invalid", resourceCulture);

	internal static string RegionName_not_supported => ResourceManager.GetString("RegionName_not_supported", resourceCulture);

	internal R()
	{
	}
}
