using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class AnswerManager
{
	public bool AddAAnswer(Answer answer)
	{
		return AnswerService.Insert(answer);
	}

	public bool DeleteAAnswer(Answer answer)
	{
		return AnswerService.Delete(answer);
	}

	public bool ModifyAAnswer(Answer answer)
	{
		return AnswerService.Update(answer);
	}

	public Answer GetAAnswerById(int id)
	{
		return AnswerService.SelectById(id);
	}

	public List<Answer> GetAllAnswer()
	{
		return AnswerService.SelectAll();
	}
}
