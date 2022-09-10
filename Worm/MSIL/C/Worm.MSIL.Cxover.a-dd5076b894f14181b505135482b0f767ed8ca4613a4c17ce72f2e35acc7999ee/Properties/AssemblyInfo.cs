using System.Reflection;
using System.Security;
using System.Security.Permissions;

[assembly: PermissionSet(SecurityAction.RequestMinimum, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\">\r\n   <IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n                version=\"1\"\r\n                Flags=\"SkipVerification\"/>\r\n</PermissionSet>\r\n")]
[assembly: AssemblyVersion("0.0.0.0")]
