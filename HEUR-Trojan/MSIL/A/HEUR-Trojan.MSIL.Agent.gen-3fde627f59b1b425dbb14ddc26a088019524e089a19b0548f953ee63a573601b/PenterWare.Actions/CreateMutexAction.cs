using System;
using System.Threading;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class CreateMutexAction : SubAction<CreateMutexResult>
{
	public static string Name = "CreateMutex";

	public override string ActionName => Name;

	protected override void Run()
	{
		try
		{
			GeneralUtils.Log("Creating mutex " + ResourceData.MutexToCreate);
			bool createdNew = false;
			new Mutex(initiallyOwned: true, ResourceData.MutexToCreate, out createdNew);
			if (!createdNew)
			{
				throw new Exception("Mutex already exists");
			}
			base.Result.MutexName = ResourceData.MutexToCreate;
			base.Result.Created = true;
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Exception during mutex creation: " + ex.Message);
			base.Result.MutexName = ResourceData.MutexToCreate;
			base.Result.Created = false;
		}
	}
}
