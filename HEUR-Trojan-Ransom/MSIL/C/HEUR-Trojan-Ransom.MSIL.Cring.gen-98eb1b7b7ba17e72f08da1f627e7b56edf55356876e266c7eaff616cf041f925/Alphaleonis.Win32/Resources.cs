using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Alphaleonis.Win32;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
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
				resourceMan = new ResourceManager("Alphaleonis.Win32.Resources", typeof(Resources).Assembly);
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

	internal static string Buffer_Not_Large_Enough => ResourceManager.GetString("Buffer_Not_Large_Enough", resourceCulture);

	internal static string Cannot_Create_Directory => ResourceManager.GetString("Cannot_Create_Directory", resourceCulture);

	internal static string Cannot_Determine_Copy_Or_Move => ResourceManager.GetString("Cannot_Determine_Copy_Or_Move", resourceCulture);

	internal static string Destination_Buffer_Not_Large_Enough => ResourceManager.GetString("Destination_Buffer_Not_Large_Enough", resourceCulture);

	internal static string Directory_Is_Not_A_MountPoint => ResourceManager.GetString("Directory_Is_Not_A_MountPoint", resourceCulture);

	internal static string Exception_From_Successful_Operation => ResourceManager.GetString("Exception_From_Successful_Operation", resourceCulture);

	internal static string File_Is_Hidden => ResourceManager.GetString("File_Is_Hidden", resourceCulture);

	internal static string File_Or_Directory_Already_Exists => ResourceManager.GetString("File_Or_Directory_Already_Exists", resourceCulture);

	internal static string GetCurrentWindowsIdentityFailed => ResourceManager.GetString("GetCurrentWindowsIdentityFailed", resourceCulture);

	internal static string GetFullPathOptions_Add_And_Remove_DirectorySeparator_Invalid => ResourceManager.GetString("GetFullPathOptions_Add_And_Remove_DirectorySeparator_Invalid", resourceCulture);

	internal static string Handle_Is_Closed => ResourceManager.GetString("Handle_Is_Closed", resourceCulture);

	internal static string Handle_Is_Invalid => ResourceManager.GetString("Handle_Is_Invalid", resourceCulture);

	internal static string Handle_Is_Invalid_Win32Error => ResourceManager.GetString("Handle_Is_Invalid_Win32Error", resourceCulture);

	internal static string HardLinks_Not_Supported => ResourceManager.GetString("HardLinks_Not_Supported", resourceCulture);

	internal static string Illegal_Characters_In_Path => ResourceManager.GetString("Illegal_Characters_In_Path", resourceCulture);

	internal static string Invalid_File_Attribute => ResourceManager.GetString("Invalid_File_Attribute", resourceCulture);

	internal static string Invalid_Reparse_Data => ResourceManager.GetString("Invalid_Reparse_Data", resourceCulture);

	internal static string Invalid_Stream_Name => ResourceManager.GetString("Invalid_Stream_Name", resourceCulture);

	internal static string Invalid_Subpath => ResourceManager.GetString("Invalid_Subpath", resourceCulture);

	internal static string Invalid_Transaction_Request => ResourceManager.GetString("Invalid_Transaction_Request", resourceCulture);

	internal static string InvalidDriveLetterArgument => ResourceManager.GetString("InvalidDriveLetterArgument", resourceCulture);

	internal static string Junction_And_Target_Must_Be_On_The_Same_Drive => ResourceManager.GetString("Junction_And_Target_Must_Be_On_The_Same_Drive", resourceCulture);

	internal static string MoveOptionsDelayUntilReboot_Not_Allowed_With_MoveOptionsCopyAllowed => ResourceManager.GetString("MoveOptionsDelayUntilReboot_Not_Allowed_With_MoveOptionsCopyAllowed", resourceCulture);

	internal static string MoveOptionsDelayUntilReboot_Not_Allowed_With_NetworkPath => ResourceManager.GetString("MoveOptionsDelayUntilReboot_Not_Allowed_With_NetworkPath", resourceCulture);

	internal static string Negative_Count => ResourceManager.GetString("Negative_Count", resourceCulture);

	internal static string Negative_Destination_Offset => ResourceManager.GetString("Negative_Destination_Offset", resourceCulture);

	internal static string Negative_Length => ResourceManager.GetString("Negative_Length", resourceCulture);

	internal static string Negative_Lock_Length => ResourceManager.GetString("Negative_Lock_Length", resourceCulture);

	internal static string Negative_Offset => ResourceManager.GetString("Negative_Offset", resourceCulture);

	internal static string Network_Path_Not_Allowed => ResourceManager.GetString("Network_Path_Not_Allowed", resourceCulture);

	internal static string No_Drive_Letters_Available => ResourceManager.GetString("No_Drive_Letters_Available", resourceCulture);

	internal static string No_Stream_Seeking_Support => ResourceManager.GetString("No_Stream_Seeking_Support", resourceCulture);

	internal static string Not_A_Valid_Guid => ResourceManager.GetString("Not_A_Valid_Guid", resourceCulture);

	internal static string Path_Is_Zero_Length_Or_Only_White_Space => ResourceManager.GetString("Path_Is_Zero_Length_Or_Only_White_Space", resourceCulture);

	internal static string Privilege_Name_Cannot_Be_Empty => ResourceManager.GetString("Privilege_Name_Cannot_Be_Empty", resourceCulture);

	internal static string Read_Incomplete_Header => ResourceManager.GetString("Read_Incomplete_Header", resourceCulture);

	internal static string Returned_Invalid_Security_Descriptor => ResourceManager.GetString("Returned_Invalid_Security_Descriptor", resourceCulture);

	internal static string Source_OffsetAndLength_Outside_Bounds => ResourceManager.GetString("Source_OffsetAndLength_Outside_Bounds", resourceCulture);

	internal static string Target_Directory_Is_A_File => ResourceManager.GetString("Target_Directory_Is_A_File", resourceCulture);

	internal static string Target_File_Is_A_Directory => ResourceManager.GetString("Target_File_Is_A_Directory", resourceCulture);

	internal static string Transaction_Already_Aborted => ResourceManager.GetString("Transaction_Already_Aborted", resourceCulture);

	internal static string Transaction_Already_Committed => ResourceManager.GetString("Transaction_Already_Committed", resourceCulture);

	internal static string Transaction_Invalid => ResourceManager.GetString("Transaction_Invalid", resourceCulture);

	internal static string Transaction_Not_Active => ResourceManager.GetString("Transaction_Not_Active", resourceCulture);

	internal static string Transaction_Not_Requested => ResourceManager.GetString("Transaction_Not_Requested", resourceCulture);

	internal static string Transactional_Conflict => ResourceManager.GetString("Transactional_Conflict", resourceCulture);

	internal static string UNC_Path_Should_Match_Format => ResourceManager.GetString("UNC_Path_Should_Match_Format", resourceCulture);

	internal static string Unsupported_Path_Format => ResourceManager.GetString("Unsupported_Path_Format", resourceCulture);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
	}
}
