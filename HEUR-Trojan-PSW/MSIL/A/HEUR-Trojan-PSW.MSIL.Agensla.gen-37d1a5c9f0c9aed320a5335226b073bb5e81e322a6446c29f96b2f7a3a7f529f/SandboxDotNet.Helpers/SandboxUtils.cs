using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using SandboxDotNet.Perms;

namespace SandboxDotNet.Helpers;

public class SandboxUtils
{
	public static bool IsFileValidExe(string path)
	{
		try
		{
			return File.Exists(path) && Path.HasExtension(path) && Path.GetExtension(path)!.ToUpper() == ".EXE";
		}
		catch
		{
			return false;
		}
	}

	public static bool IsFileReadWriteAppendRegex(string input)
	{
		return Regex.IsMatch(input, "^[r.w.a]+$");
	}

	public static bool OpenFileInExplorer(string path)
	{
		if (File.Exists(path))
		{
			path = Path.GetDirectoryName(Path.GetFullPath(path));
		}
		if (Directory.Exists(path))
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				Arguments = path,
				FileName = "explorer.exe"
			};
			Process.Start(startInfo);
			return true;
		}
		return false;
	}

	public static string[] ConvertStringArgsWithQuotes(string arguments)
	{
		return (from Match x in Regex.Matches(arguments, "[\\\"].+?[\\\"]|[^ ]+")
			select x.Value.Trim(new char[1] { '"' })).ToArray();
	}

	public static void ExtractPermissions(ref Permissions permissions, string[] permArgs)
	{
		for (int i = 0; i < permArgs.Length; i++)
		{
			string text = permArgs[i].Replace("permission", "").TrimStart('-', '/').Trim()
				.ToLower();
			SecurityPerms securityPerms = new SecurityPerms();
			switch (text)
			{
			case "files":
				if (!string.IsNullOrWhiteSpace(permArgs[i + 1]))
				{
					goto case "file";
				}
				goto default;
			case "file":
				if (permArgs.Length > i + 2 && !string.IsNullOrWhiteSpace(permArgs[i + 2]) && IsFileReadWriteAppendRegex(permArgs[i + 2]))
				{
					List<FilePerms> list = ((permissions.FileIOPerms == null) ? new List<FilePerms>() : permissions.FileIOPerms.ToList());
					if (File.Exists(permArgs[i + 1]) || (Directory.Exists(permArgs[i + 1]) && (Enumerable.Contains(permArgs[i + 2], 'r') || Enumerable.Contains(permArgs[i + 2], 'w') || Enumerable.Contains(permArgs[i + 2], 'a'))))
					{
						bool read = Enumerable.Contains(permArgs[i + 2], 'r');
						bool write = Enumerable.Contains(permArgs[i + 2], 'w');
						bool append = Enumerable.Contains(permArgs[i + 2], 'a');
						list.Add(new FilePerms(permArgs[i + 1], read, write, append));
						permissions.FileIOPerms = list.ToArray();
						i += 2;
					}
				}
				else if (permArgs.Length > i + 1 && permArgs[i + 1].Trim() == "*")
				{
					permissions.AllFiles = true;
					i++;
				}
				break;
			default:
				if (text == "assert" || text == "assertion")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.Assertion);
					break;
				}
				if (text == "binding" || text == "bindingredirect")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.BindingRedirects);
					break;
				}
				if (text == "appdomain" || text == "controlappdomain")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.ControlAppDomain);
					break;
				}
				if (text == "evidence" || text == "controlevidence")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.ControlEvidence);
					break;
				}
				if (text == "domainpolicy" || text == "controldomainpolicy")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.ControlDomainPolicy);
					break;
				}
				if (text == "thread" || text == "controlthread")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.ControlThread);
					break;
				}
				if (text == "exec" || text == "execution")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.Execution);
					break;
				}
				if (text == "infra" || text == "infrastructure")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.Infrastructure);
					break;
				}
				if (text == "remoting" || text == "remotingconfiguration")
				{
					securityPerms.AddFlag(SecurityPermissionFlag.RemotingConfiguration);
					break;
				}
				switch (text)
				{
				default:
					if (!(text == "serialisationformatter"))
					{
						if (text == "skipverif" || text == "skipverification")
						{
							securityPerms.AddFlag(SecurityPermissionFlag.SkipVerification);
							break;
						}
						if (text == "unmanaged" || text == "unmanagedcode")
						{
							securityPerms.AddFlag(SecurityPermissionFlag.UnmanagedCode);
							break;
						}
						if (text == "asp" || text == "aspnet" || text == "aspnethosting")
						{
							permissions.AspNetHosting = true;
							break;
						}
						switch (text)
						{
						case "dns":
							permissions.Dns = true;
							break;
						case "eventlog":
							permissions.EventLog = true;
							break;
						default:
							if (!(text == "filed"))
							{
								if (text == "gac" || text == "gacidentity")
								{
									permissions.GacIdentity = true;
									break;
								}
								if (text == "isolated" || text == "isolatedstorage" || text == "isolatedstoragefile")
								{
									permissions.IsolatedStorage = true;
									break;
								}
								if (text == "key" || text == "keycontainer")
								{
									permissions.KeyContainer = true;
									break;
								}
								if (text == "network" || text == "networkinformation")
								{
									permissions.NetworkInformation = true;
									break;
								}
								if (text == "odbc")
								{
									permissions.Odbc = true;
									break;
								}
								if (text == "ole" || text == "oledb")
								{
									permissions.OleDb = true;
									break;
								}
								if (text == "perf" || text == "performance" || text == "performancecounter")
								{
									permissions.PerformanceCounter = true;
									break;
								}
								if (text == "principal")
								{
									permissions.Principal = true;
									break;
								}
								if (text == "print" || text == "printing")
								{
									permissions.Printing = true;
									break;
								}
								if (text == "publish" || text == "publisher" || text == "publisheridentity")
								{
									permissions.PublisherIdentity = true;
									break;
								}
								switch (text)
								{
								case "reflection":
									permissions.Reflection = true;
									break;
								case "registry":
									permissions.Registry = true;
									break;
								default:
									if (!(text == "email"))
									{
										if (text == "sql" || text == "sqlclient")
										{
											permissions.Sql = true;
											break;
										}
										switch (text)
										{
										case "socket":
											permissions.Socket = true;
											break;
										case "store":
											permissions.Store = true;
											break;
										default:
											if (!(text == "siteidentity"))
											{
												if (text == "strongname" || text == "strongnameidentity")
												{
													permissions.StrongNameIdentity = true;
												}
												else if (text == "url" || text == "urlidentity")
												{
													permissions.UrlIdentity = true;
												}
												else if (text == "zone" || text == "zoneidentity")
												{
													permissions.ZoneIdentity = true;
												}
												else if (text == "web")
												{
													permissions.Web = true;
												}
												else if (text == "type" || text == "typedescriptor")
												{
													permissions.TypeDescriptor = true;
												}
												else if (text == "ui")
												{
													permissions.UI = true;
												}
												break;
											}
											goto case "site";
										case "site":
											permissions.SiteIdentity = true;
											break;
										}
										break;
									}
									goto case "smtp";
								case "smtp":
									permissions.Smtp = true;
									break;
								}
								break;
							}
							goto case "filedialog";
						case "filedialog":
							permissions.FileDialog = true;
							break;
						}
						break;
					}
					goto case "serialization";
				case "serialization":
				case "serializationformatter":
				case "serialisation":
					securityPerms.AddFlag(SecurityPermissionFlag.SerializationFormatter);
					break;
				}
				break;
			case "all":
				permissions.GiveAllPermissions();
				return;
			}
			permissions.Security = securityPerms;
		}
	}
}
