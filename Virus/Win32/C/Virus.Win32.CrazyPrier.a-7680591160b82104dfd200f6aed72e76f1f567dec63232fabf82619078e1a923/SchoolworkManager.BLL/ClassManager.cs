using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class ClassManager
{
	public bool AddAClass(Class _class)
	{
		return ClassService.Insert(_class);
	}

	public extern bool DeleteAClass(Class _class);

	public bool ModifyAClass(Class _class)
	{
		return ClassService.Update(_class);
	}

	public Class GetAClassById(int id)
	{
		return ClassService.SelectById(id);
	}

	public List<Class> GetAllClass()
	{
		return ClassService.SelectAll();
	}
}
