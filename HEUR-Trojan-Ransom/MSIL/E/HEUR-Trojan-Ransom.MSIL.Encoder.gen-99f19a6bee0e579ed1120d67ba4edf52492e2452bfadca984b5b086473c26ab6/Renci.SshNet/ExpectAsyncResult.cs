using System;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class ExpectAsyncResult : AsyncResult<string>
{
	internal ExpectAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}
}
