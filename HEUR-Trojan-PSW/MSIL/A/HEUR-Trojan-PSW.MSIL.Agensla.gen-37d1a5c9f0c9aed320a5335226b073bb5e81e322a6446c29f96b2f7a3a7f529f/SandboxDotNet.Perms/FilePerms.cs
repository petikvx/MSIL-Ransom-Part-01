using System;
using System.IO;
using System.Security.Permissions;

namespace SandboxDotNet.Perms;

public class FilePerms
{
	public string Path { get; set; }

	public bool Read { get; set; }

	public bool Write { get; set; }

	public bool Append { get; set; }

	public FilePerms()
	{
	}

	public FilePerms(string path, bool read, bool write, bool append)
		: this()
	{
		Path = System.IO.Path.GetFullPath(path);
		Read = read;
		Write = write;
		Append = append;
	}

	public FileIOPermissionAccess GetFileIOPermissionAccess()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (Write && Read && Append)
		{
			return (FileIOPermissionAccess)15;
		}
		if (Write && Read)
		{
			return (FileIOPermissionAccess)11;
		}
		if (Write && Append)
		{
			return (FileIOPermissionAccess)14;
		}
		if (Read && Append)
		{
			return (FileIOPermissionAccess)13;
		}
		if (Write)
		{
			return (FileIOPermissionAccess)10;
		}
		if (Read)
		{
			return (FileIOPermissionAccess)9;
		}
		if (Append)
		{
			return (FileIOPermissionAccess)12;
		}
		return (FileIOPermissionAccess)8;
	}

	public override string ToString()
	{
		return $"FilePerms: '{Path}' [{$"1{Convert.ToInt32(Append)}{Convert.ToInt32(Write)}{Convert.ToInt32(Read)}"}]";
	}
}
