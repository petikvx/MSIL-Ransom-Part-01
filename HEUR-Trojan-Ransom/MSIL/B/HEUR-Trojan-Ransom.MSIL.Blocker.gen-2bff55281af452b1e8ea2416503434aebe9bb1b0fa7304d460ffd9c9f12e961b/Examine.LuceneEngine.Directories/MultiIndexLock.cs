using System.Security;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecurityCritical]
internal class MultiIndexLock : Lock
{
	private readonly Lock _dirMaster;

	private readonly Lock _dirChild;

	public MultiIndexLock(Lock dirMaster, Lock dirChild)
	{
		_dirMaster = dirMaster;
		_dirChild = dirChild;
	}

	[SecurityCritical]
	public override bool Obtain()
	{
		if (_dirMaster.Obtain())
		{
			return _dirChild.Obtain();
		}
		return false;
	}

	[SecurityCritical]
	public override bool Obtain(long lockWaitTimeout)
	{
		if (_dirMaster.Obtain(lockWaitTimeout))
		{
			return _dirChild.Obtain(lockWaitTimeout);
		}
		return false;
	}

	[SecurityCritical]
	public override void Release()
	{
		_dirMaster.Release();
		_dirChild.Release();
	}

	[SecurityCritical]
	public override bool IsLocked()
	{
		if (!_dirMaster.IsLocked())
		{
			return _dirChild.IsLocked();
		}
		return true;
	}
}
