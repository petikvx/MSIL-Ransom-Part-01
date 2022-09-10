using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class SubmitWorkManager
{
	public bool AddASubmitWork(SubmitWork submitWork)
	{
		return SubmitWorkService.Insert(submitWork);
	}

	public bool DeleteASubmitWork(SubmitWork submitWork)
	{
		return SubmitWorkService.Delete(submitWork);
	}

	public bool ModifyASubmitWork(SubmitWork submitWork)
	{
		return SubmitWorkService.Update(submitWork);
	}

	public SubmitWork GetASubmitWorkById(int id)
	{
		return SubmitWorkService.SelectById(id);
	}

	public List<SubmitWork> GetAllSubmitWork()
	{
		return SubmitWorkService.SelectAll();
	}
}
