using System.Globalization;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Caching;

internal class SRef
{
	private static Type s_type = Type.GetType("System.SizedReference", throwOnError: true, ignoreCase: false);

	private object _sizedRef;

	internal long ApproximateSize
	{
		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
		get
		{
			object obj = s_type.InvokeMember("ApproximateSize", BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, _sizedRef, null, CultureInfo.InvariantCulture);
			return (long)obj;
		}
	}

	internal SRef(object target)
	{
		_sizedRef = Activator.CreateInstance(s_type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[1] { target }, null);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	internal void Dispose()
	{
		s_type.InvokeMember("Dispose", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, _sizedRef, null, CultureInfo.InvariantCulture);
	}
}
