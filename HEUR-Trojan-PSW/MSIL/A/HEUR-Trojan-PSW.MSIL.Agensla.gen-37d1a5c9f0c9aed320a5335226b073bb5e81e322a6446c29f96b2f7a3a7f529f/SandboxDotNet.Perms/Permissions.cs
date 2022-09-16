using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security;
using System.Security.Permissions;
using System.Web;

namespace SandboxDotNet.Perms;

public class Permissions
{
	private string _exePath;

	public bool DefaultIO { get; set; }

	public bool UI { get; set; }

	public bool AspNetHosting { get; set; }

	public bool Dns { get; set; }

	public bool EventLog { get; set; }

	public bool FileDialog { get; set; }

	public bool GacIdentity { get; set; }

	public bool IsolatedStorage { get; set; }

	public bool KeyContainer { get; set; }

	public bool NetworkInformation { get; set; }

	public bool Odbc { get; set; }

	public bool OleDb { get; set; }

	public bool PerformanceCounter { get; set; }

	public bool Principal { get; set; }

	public bool Printing { get; set; }

	public bool PublisherIdentity { get; set; }

	public bool Reflection { get; set; }

	public bool Registry { get; set; }

	public bool Smtp { get; set; }

	public bool Sql { get; set; }

	public bool Socket { get; set; }

	public bool Store { get; set; }

	public bool SiteIdentity { get; set; }

	public bool StrongNameIdentity { get; set; }

	public bool UrlIdentity { get; set; }

	public bool ZoneIdentity { get; set; }

	public bool Web { get; set; }

	public bool TypeDescriptor { get; set; }

	public bool AllFiles { get; set; }

	public SecurityPerms Security { get; set; }

	public FilePerms[] FileIOPerms { get; set; }

	public bool DefaultPermissions { get; set; }

	public Permissions()
	{
		AllFiles = false;
		TypeDescriptor = false;
		Web = false;
		ZoneIdentity = false;
		UrlIdentity = false;
		StrongNameIdentity = false;
		SiteIdentity = false;
		Store = false;
		Socket = false;
		Sql = false;
		Smtp = false;
		Registry = false;
		Reflection = false;
		PublisherIdentity = false;
		Printing = false;
		Principal = false;
		PerformanceCounter = false;
		OleDb = false;
		Odbc = false;
		NetworkInformation = false;
		KeyContainer = false;
		IsolatedStorage = false;
		GacIdentity = false;
		FileDialog = false;
		EventLog = false;
		Dns = false;
		AspNetHosting = false;
		UI = false;
		DefaultIO = false;
		Security = new SecurityPerms();
		DefaultPermissions = true;
	}

	public Permissions(bool includeDefaultPerms = true)
		: this()
	{
		DefaultPermissions = includeDefaultPerms;
	}

	public void GiveAllPermissions()
	{
		TypeDescriptor = true;
		Web = true;
		ZoneIdentity = true;
		UrlIdentity = true;
		StrongNameIdentity = true;
		SiteIdentity = true;
		Store = true;
		Socket = true;
		Sql = true;
		Smtp = true;
		Registry = true;
		Reflection = true;
		PublisherIdentity = true;
		Printing = true;
		Principal = true;
		PerformanceCounter = true;
		OleDb = true;
		Odbc = true;
		NetworkInformation = true;
		KeyContainer = true;
		IsolatedStorage = true;
		GacIdentity = true;
		FileDialog = true;
		EventLog = true;
		Dns = true;
		AspNetHosting = true;
		UI = true;
		DefaultIO = true;
		AllFiles = true;
		Security = new SecurityPerms(SecurityPermissionFlag.AllFlags);
	}

	public void SetExecutablePath(string exePath)
	{
		_exePath = exePath;
	}

	public PermissionSet GeneratePermissionSet(bool ignoreCurrentExePath = false)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		if (DefaultPermissions)
		{
			IncludeDefaultPermissions();
		}
		if (DefaultIO)
		{
			List<FilePerms> list = ((FileIOPerms == null) ? new List<FilePerms>() : FileIOPerms.ToList());
			if (!ignoreCurrentExePath && (FileIOPerms == null || FileIOPerms.Length == 0 || !FileIOPerms.Where((FilePerms p) => p.Path == _exePath).Any()))
			{
				list.Add(new FilePerms(_exePath, read: true, write: false, append: false));
			}
			FileIOPerms = list.ToArray();
		}
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		if (UI)
		{
			permissionSet.AddPermission((IPermission?)new UIPermission(PermissionState.Unrestricted));
		}
		if (AspNetHosting)
		{
			permissionSet.AddPermission((IPermission?)new AspNetHostingPermission(PermissionState.Unrestricted));
		}
		if (Dns)
		{
			permissionSet.AddPermission((IPermission?)new DnsPermission(PermissionState.Unrestricted));
		}
		if (EventLog)
		{
			permissionSet.AddPermission((IPermission?)new EventLogPermission(PermissionState.Unrestricted));
		}
		if (FileDialog)
		{
			permissionSet.AddPermission((IPermission?)new FileDialogPermission(PermissionState.Unrestricted));
		}
		if (GacIdentity)
		{
			permissionSet.AddPermission((IPermission?)new GacIdentityPermission(PermissionState.Unrestricted));
		}
		if (IsolatedStorage)
		{
			permissionSet.AddPermission((IPermission?)new IsolatedStorageFilePermission(PermissionState.Unrestricted));
		}
		if (KeyContainer)
		{
			permissionSet.AddPermission((IPermission?)new KeyContainerPermission(PermissionState.Unrestricted));
		}
		if (NetworkInformation)
		{
			permissionSet.AddPermission((IPermission?)new NetworkInformationPermission(PermissionState.Unrestricted));
		}
		if (Odbc)
		{
			permissionSet.AddPermission((IPermission?)new OdbcPermission(PermissionState.Unrestricted));
		}
		if (OleDb)
		{
			permissionSet.AddPermission((IPermission?)new OleDbPermission(PermissionState.Unrestricted));
		}
		if (PerformanceCounter)
		{
			permissionSet.AddPermission((IPermission?)new PerformanceCounterPermission(PermissionState.Unrestricted));
		}
		if (Principal)
		{
			permissionSet.AddPermission((IPermission?)new PrincipalPermission(PermissionState.Unrestricted));
		}
		if (Printing)
		{
			permissionSet.AddPermission((IPermission?)new PrintingPermission(PermissionState.Unrestricted));
		}
		if (PublisherIdentity)
		{
			permissionSet.AddPermission((IPermission?)new PublisherIdentityPermission(PermissionState.Unrestricted));
		}
		if (Reflection)
		{
			permissionSet.AddPermission((IPermission?)new ReflectionPermission(PermissionState.Unrestricted));
		}
		if (Registry)
		{
			permissionSet.AddPermission((IPermission?)new RegistryPermission(PermissionState.Unrestricted));
		}
		if (Smtp)
		{
			permissionSet.AddPermission((IPermission?)new SmtpPermission(PermissionState.Unrestricted));
		}
		if (Sql)
		{
			permissionSet.AddPermission((IPermission?)new SqlClientPermission(PermissionState.Unrestricted));
		}
		if (Socket)
		{
			permissionSet.AddPermission((IPermission?)new SocketPermission(PermissionState.Unrestricted));
		}
		if (Store)
		{
			permissionSet.AddPermission((IPermission?)new StorePermission(PermissionState.Unrestricted));
		}
		if (SiteIdentity)
		{
			permissionSet.AddPermission((IPermission?)new SiteIdentityPermission(PermissionState.Unrestricted));
		}
		if (StrongNameIdentity)
		{
			permissionSet.AddPermission((IPermission?)new StrongNameIdentityPermission(PermissionState.Unrestricted));
		}
		if (UrlIdentity)
		{
			permissionSet.AddPermission((IPermission?)new UrlIdentityPermission(PermissionState.Unrestricted));
		}
		if (ZoneIdentity)
		{
			permissionSet.AddPermission((IPermission?)new ZoneIdentityPermission(PermissionState.Unrestricted));
		}
		if (Web)
		{
			permissionSet.AddPermission((IPermission?)new WebPermission(PermissionState.Unrestricted));
		}
		if (TypeDescriptor)
		{
			permissionSet.AddPermission((IPermission?)new TypeDescriptorPermission(PermissionState.Unrestricted));
		}
		if (AllFiles)
		{
			permissionSet.AddPermission((IPermission?)new FileIOPermission(PermissionState.Unrestricted));
		}
		if (FileIOPerms != null && FileIOPerms.Length != 0)
		{
			FileIOPermission val = new FileIOPermission(PermissionState.None);
			if (FileIOPerms != null && FileIOPerms.Length != 0)
			{
				FilePerms[] fileIOPerms = FileIOPerms;
				foreach (FilePerms filePerms in fileIOPerms)
				{
					val.AddPathList(filePerms.GetFileIOPermissionAccess(), Path.GetFullPath(filePerms.Path));
				}
			}
			permissionSet.AddPermission((IPermission?)val);
		}
		if (Security != null)
		{
			SecurityPermission val2 = new SecurityPermission(PermissionState.None);
			val2.set_Flags(Security.GetSecurityPermissionFlag());
			permissionSet.AddPermission((IPermission?)val2);
		}
		else
		{
			SecurityPermission val3 = new SecurityPermission(PermissionState.None);
			val3.set_Flags(SecurityPermissionFlag.NoFlags);
			permissionSet.AddPermission((IPermission?)val3);
		}
		return permissionSet;
	}

	public override string ToString()
	{
		List<string> list = new List<string>();
		if (UI)
		{
			list.Add("UI");
		}
		if (AspNetHosting)
		{
			list.Add("AspNetHosting");
		}
		if (Dns)
		{
			list.Add("Dns");
		}
		if (EventLog)
		{
			list.Add("EventLog");
		}
		if (FileDialog)
		{
			list.Add("FileDialog");
		}
		if (GacIdentity)
		{
			list.Add("GacIdentity");
		}
		if (IsolatedStorage)
		{
			list.Add("IsolatedStorage");
		}
		if (KeyContainer)
		{
			list.Add("KeyContainer");
		}
		if (NetworkInformation)
		{
			list.Add("NetworkInformation");
		}
		if (Odbc)
		{
			list.Add("Odbc");
		}
		if (OleDb)
		{
			list.Add("OleDb");
		}
		if (PerformanceCounter)
		{
			list.Add("PerformanceCounter");
		}
		if (Principal)
		{
			list.Add("Principal");
		}
		if (Printing)
		{
			list.Add("Printing");
		}
		if (PublisherIdentity)
		{
			list.Add("PublisherIdentity");
		}
		if (Reflection)
		{
			list.Add("Reflection");
		}
		if (Registry)
		{
			list.Add("Registry");
		}
		if (Smtp)
		{
			list.Add("Smtp");
		}
		if (Sql)
		{
			list.Add("Sql");
		}
		if (Socket)
		{
			list.Add("Socket");
		}
		if (Store)
		{
			list.Add("Store");
		}
		if (SiteIdentity)
		{
			list.Add("SiteIdentity");
		}
		if (StrongNameIdentity)
		{
			list.Add("StrongNameIdentity");
		}
		if (UrlIdentity)
		{
			list.Add("UrlIdentity");
		}
		if (ZoneIdentity)
		{
			list.Add("ZoneIdentity");
		}
		if (Web)
		{
			list.Add("Web");
		}
		if (TypeDescriptor)
		{
			list.Add("TypeDescriptor");
		}
		if (Security != null)
		{
			list.Add($"Security: {Security}");
		}
		if (AllFiles)
		{
			list.Add("AllFiles");
		}
		if (FileIOPerms != null && FileIOPerms.Length != 0)
		{
			for (int i = 0; i < FileIOPerms.Length; i++)
			{
				list.Add($"FileIOPerm[{i}]: {FileIOPerms[i]}");
			}
		}
		return string.Join(", ", list);
	}

	private void IncludeDefaultPermissions()
	{
		UI = true;
		DefaultIO = true;
		Security.AddFlag(SecurityPermissionFlag.Execution);
	}
}
