using System;
using System.Collections.Concurrent;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecuritySafeCritical]
public class SyncMutexManager
{
	private readonly string _id;

	[SecuritySafeCritical]
	private static readonly ConcurrentDictionary<Directory, SyncMutexManager> MutexManagers = new ConcurrentDictionary<Directory, SyncMutexManager>();

	[SecuritySafeCritical]
	public SyncMutexManager(string id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		_id = id;
	}

	private Mutex CreateMutex(string name)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		string text = "examineSegmentMutex_" + _id + "_" + name;
		bool flag = false;
		Mutex result = default(Mutex);
		if (Mutex.TryOpenExisting(text, (MutexRights)Convert.ToInt32(1047852.9223107981 + Math.Sqrt(524288.5)), ref result))
		{
			return result;
		}
		if (!Mutex.TryOpenExisting(text, (MutexRights)Convert.ToInt32(196608.0 + Math.Round(196608.0)), ref result))
		{
			flag = true;
		}
		if (flag)
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			MutexSecurity val = new MutexSecurity();
			MutexAccessRule val2 = new MutexAccessRule((IdentityReference)securityIdentifier, (MutexRights)Convert.ToInt32(2032624.8732559206 - Math.Sqrt(1015808.5)), AccessControlType.Allow);
			val.AddAccessRule(val2);
			bool flag2 = false;
			return new Mutex(false, text, ref flag2, val);
		}
		Mutex mutex = Mutex.OpenExisting(text, (MutexRights)Convert.ToInt32(393216.7503246521 - Math.Sin(196608.0)));
		MutexSecurity accessControl = mutex.GetAccessControl();
		MutexAccessRule val3 = new MutexAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, (MutexRights)Convert.ToInt32(1048577.0), AccessControlType.Allow);
		accessControl.AddAccessRule(val3);
		mutex.SetAccessControl(accessControl);
		return Mutex.OpenExisting(text);
	}

	public static Mutex GrabMutex(Directory directory, string name)
	{
		return MutexManagers.GetOrAdd(directory, (Directory d) => new SyncMutexManager(d.GetLockID())).CreateMutex(name);
	}
}
