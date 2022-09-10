using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FileEncryptor.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("FileEncryptor.Properties.Resources", typeof(Resources).Assembly));
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

	internal static string All_File_Type => ResourceManager.GetString("All_File_Type", resourceCulture);

	internal static string Backend_Busy => ResourceManager.GetString("Backend_Busy", resourceCulture);

	internal static string DialogTitle_CreateKey => ResourceManager.GetString("DialogTitle_CreateKey", resourceCulture);

	internal static string DialogTitle_SelectKey => ResourceManager.GetString("DialogTitle_SelectKey", resourceCulture);

	internal static string DialogTitle_SelectManifest => ResourceManager.GetString("DialogTitle_SelectManifest", resourceCulture);

	internal static string DialogTitle_SelectPem => ResourceManager.GetString("DialogTitle_SelectPem", resourceCulture);

	internal static string DialogTitle_SelectPlain => ResourceManager.GetString("DialogTitle_SelectPlain", resourceCulture);

	internal static string DialogTitle_SelectPublicKey => ResourceManager.GetString("DialogTitle_SelectPublicKey", resourceCulture);

	internal static string Error_convertToPrivateKey => ResourceManager.GetString("Error_convertToPrivateKey", resourceCulture);

	internal static string Error_convertToPublicKey => ResourceManager.GetString("Error_convertToPublicKey", resourceCulture);

	internal static string Error_Need_PublicKey => ResourceManager.GetString("Error_Need_PublicKey", resourceCulture);

	internal static Bitmap images
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("images", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static string Out_msg_decryption_success => ResourceManager.GetString("Out_msg_decryption_success", resourceCulture);

	internal static string Out_msg_encrypt_success => ResourceManager.GetString("Out_msg_encrypt_success", resourceCulture);

	internal static string Out_msg_start_decryption => ResourceManager.GetString("Out_msg_start_decryption", resourceCulture);

	internal static string Out_msg_start_encryption => ResourceManager.GetString("Out_msg_start_encryption", resourceCulture);

	internal static string Output_msg_importKey => ResourceManager.GetString("Output_msg_importKey", resourceCulture);

	internal static string PEM_File_Type => ResourceManager.GetString("PEM_File_Type", resourceCulture);

	internal static string Start_Compression => ResourceManager.GetString("Start_Compression", resourceCulture);

	internal static string XML_File_Type => ResourceManager.GetString("XML_File_Type", resourceCulture);

	internal Resources()
	{
	}
}
