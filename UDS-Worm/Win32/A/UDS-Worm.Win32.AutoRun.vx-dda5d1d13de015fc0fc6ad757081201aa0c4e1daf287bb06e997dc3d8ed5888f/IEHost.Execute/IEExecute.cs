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

namespace IEHost.Execute;

internal class IEExecute
{
	private static bool FailRebinds(PermissionSet psAllowed)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		bool result = true;
		if (psAllowed != null)
		{
			if (psAllowed.IsUnrestricted())
			{
				result = false;
			}
			else
			{
				SecurityPermission val = (SecurityPermission)psAllowed.GetPermission(typeof(SecurityPermission));
				if (val != null && (val.get_Flags() & SecurityPermissionFlag.BindingRedirects) != 0)
				{
					result = false;
				}
			}
		}
		return result;
	}

	internal static string GetSiteName(string pURL)
	{
		string text = null;
		if (pURL != null)
		{
			int num = pURL.IndexOf(':');
			if (num != -1 && num + 3 < pURL.Length && pURL[num + 1] == '/' && pURL[num + 2] == '/')
			{
				num += 3;
				int num2 = pURL.IndexOf('/', num);
				text = ((num2 <= -1) ? pURL.Substring(num) : pURL.Substring(num, num2 - num));
			}
			if (text == null)
			{
				text = pURL;
			}
		}
		return text;
	}

	internal static byte[] DecodeHex(string hexString)
	{
		if (hexString != null)
		{
			if (hexString.Length % 2 != 0)
			{
				throw new ArgumentException(Resource.FormatString("Err_InvalidHexStringFormat"), "hexString");
			}
			byte[] array = new byte[hexString.Length / 2];
			int num = 0;
			int num2 = 0;
			while (num < hexString.Length)
			{
				int num3 = ConvertHexDigit(hexString[num]);
				int num4 = ConvertHexDigit(hexString[num + 1]);
				array[num2] = (byte)(num3 | (num4 << 4));
				num += 2;
				num2++;
			}
			return array;
		}
		return new byte[0];
	}

	internal static int ConvertHexDigit(char val)
	{
		if (val <= '9')
		{
			return val - 48;
		}
		return val - 65 + 10;
	}

	internal static int Main(string[] args)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		if (args.Length != 1)
		{
			throw new ArgumentException(Resource.FormatString("Err_NoArgument"));
		}
		string text = args[0];
		if (text.Length != 0 && text[0] != 0)
		{
			string text2 = null;
			byte[] array = null;
			int num = text.LastIndexOf("#", StringComparison.Ordinal);
			if ((num != -1) & (num != text.Length - 1))
			{
				text2 = text.Substring(num + 1);
				text = text.Substring(0, num);
				array = DecodeHex(text2);
			}
			string text3 = null;
			int num2 = text.LastIndexOf('/');
			string applicationBase;
			if (num2 == -1)
			{
				applicationBase = text;
				text3 = text;
			}
			else
			{
				applicationBase = text.Substring(0, num2 + 1);
				if (num2 + 1 < text.Length)
				{
					text3 = text.Substring(num2 + 1);
				}
			}
			if (text3 != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(text3);
				stringBuilder.Append(".config");
				text3 = stringBuilder.ToString();
			}
			string siteName = GetSiteName(text);
			Evidence evidence = null;
			evidence = new Evidence();
			Zone val = Zone.CreateFromUrl(text);
			if ((int)val.get_SecurityZone() == 0)
			{
				throw new ArgumentException(Resource.FormatString("Err_InvalidSecurityZone"));
			}
			evidence.AddHost(val);
			if (text.Length >= 7 && string.Compare(text.Substring(0, 7), "file://", StringComparison.OrdinalIgnoreCase) == 0)
			{
				throw new ArgumentException(Resource.FormatString("Err_InvalidPrefix"));
			}
			evidence.AddHost(Site.CreateFromUrl(text));
			evidence.AddHost((object)new Url(text));
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			PermissionSet psAllowed = SecurityManager.ResolvePolicy(evidence);
			if (FailRebinds(psAllowed))
			{
				appDomainSetup.set_DisallowBindingRedirects(true);
			}
			else
			{
				appDomainSetup.set_DisallowBindingRedirects(false);
			}
			appDomainSetup.set_ApplicationBase(applicationBase);
			appDomainSetup.set_PrivateBinPath("bin");
			if (text3 != null)
			{
				appDomainSetup.set_ConfigurationFile(text3);
			}
			AppDomain appDomain = AppDomain.CreateDomain(siteName, evidence, appDomainSetup);
			if (appDomain != null)
			{
				AssemblyName name = Assembly.GetExecutingAssembly().GetName();
				AssemblyName assemblyName = new AssemblyName();
				assemblyName.Name = "IEExecRemote";
				assemblyName.SetPublicKey(name.GetPublicKey());
				assemblyName.Version = name.Version;
				assemblyName.CultureInfo = CultureInfo.InvariantCulture;
				appDomain.SetData("APP_LAUNCH_URL", text);
				ObjectHandle objectHandle = appDomain.CreateInstance(assemblyName.FullName, "IEHost.Execute.IEExecuteRemote");
				if (objectHandle != null)
				{
					IEExecuteRemote val2 = (IEExecuteRemote)objectHandle.Unwrap();
					if (val2 != null)
					{
						int result = val2.ExecuteAsAssembly(text, evidence, array, AssemblyHashAlgorithm.SHA1);
						Stream exception = val2.get_Exception();
						if (exception != null)
						{
							BinaryFormatter binaryFormatter = new BinaryFormatter();
							Exception ex = (Exception)binaryFormatter.Deserialize(exception);
							throw ex;
						}
						return result;
					}
				}
			}
			return -1;
		}
		throw new ArgumentException(Resource.FormatString("Err_EmptyArgument"));
	}
}
