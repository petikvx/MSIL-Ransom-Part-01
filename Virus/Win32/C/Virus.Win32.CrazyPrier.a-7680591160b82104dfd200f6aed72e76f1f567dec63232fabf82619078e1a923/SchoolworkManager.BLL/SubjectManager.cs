using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class SubjectManager
{
	public bool AddASubject(Subject subject)
	{
		return SubjectService.Insert(subject);
	}

	public bool DeleteASubject(Subject subject)
	{
		return SubjectService.Delete(subject);
	}

	public bool ModifyASubject(Subject subject)
	{
		return SubjectService.Update(subject);
	}

	public Subject GetASubjectById(int id)
	{
		return SubjectService.SelectById(id);
	}

	public List<Subject> GetAllSubject()
	{
		return SubjectService.SelectAll();
	}
}
