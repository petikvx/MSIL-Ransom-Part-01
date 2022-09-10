using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class QuestionManager
{
	public bool AddAQuestion(Question question)
	{
		return QuestionService.Insert(question);
	}

	public bool DeleteAQuestion(Question question)
	{
		return QuestionService.Delete(question);
	}

	public bool ModifyAQuestion(Question question)
	{
		return QuestionService.Update(question);
	}

	public Question GetAQuestionById(int id)
	{
		return QuestionService.SelectById(id);
	}

	public List<Question> GetAllQuestion()
	{
		return QuestionService.SelectAll();
	}
}
