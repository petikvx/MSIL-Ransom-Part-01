using System.Collections.Generic;
using SchoolworkManager.DAL;
using SchoolworkManager.Module;

namespace SchoolworkManager.BLL;

public class ChapterManager
{
	public bool AddAChapter(Chapter chapter)
	{
		return ChapterService.Insert(chapter);
	}

	public bool DeleteAChapter(Chapter chapter)
	{
		return ChapterService.Delete(chapter);
	}

	public bool ModifyAChapter(Chapter chapter)
	{
		return ChapterService.Update(chapter);
	}

	public Chapter GetAChapterById(int id)
	{
		return ChapterService.SelectById(id);
	}

	public List<Chapter> GetAllChapter()
	{
		return ChapterService.SelectAll();
	}
}
