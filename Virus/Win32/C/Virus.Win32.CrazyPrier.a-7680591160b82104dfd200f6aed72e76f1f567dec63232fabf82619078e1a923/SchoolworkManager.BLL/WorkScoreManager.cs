using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class WorkScoreManager
{
	public bool AddAWorkScore(WorkScore workScore)
	{
		return WorkScoreService.Insert(workScore);
	}

	public bool DeleteAWorkScore(WorkScore workScore)
	{
		return WorkScoreService.Delete(workScore);
	}

	public bool ModifyAWorkScore(WorkScore workScore)
	{
		return WorkScoreService.Update(workScore);
	}

	public WorkScore GetAWorkScoreById(int id)
	{
		return WorkScoreService.SelectById(id);
	}

	public List<WorkScore> GetAllWorkScore()
	{
		return WorkScoreService.SelectAll();
	}
}
