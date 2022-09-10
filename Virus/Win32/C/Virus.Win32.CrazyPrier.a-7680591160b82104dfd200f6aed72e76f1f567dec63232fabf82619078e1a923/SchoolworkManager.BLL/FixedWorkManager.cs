using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class FixedWorkManager
{
	public bool AddAFixedWork(FixedWork fixedWork)
	{
		return FixedWorkService.Insert(fixedWork);
	}

	public bool DeleteAFixedWork(FixedWork fixedWork)
	{
		return FixedWorkService.Delete(fixedWork);
	}

	public bool ModifyAFixedWork(FixedWork fixedWork)
	{
		return FixedWorkService.Update(fixedWork);
	}

	public FixedWork GetAFixedWorkById(int id)
	{
		return FixedWorkService.SelectById(id);
	}

	public List<FixedWork> GetAllFixedWork()
	{
		return FixedWorkService.SelectAll();
	}
}
