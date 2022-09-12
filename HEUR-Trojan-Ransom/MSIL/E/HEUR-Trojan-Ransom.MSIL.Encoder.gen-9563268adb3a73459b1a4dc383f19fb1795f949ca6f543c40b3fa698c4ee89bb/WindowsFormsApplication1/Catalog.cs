using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Catalog
{
	public string department { get; set; }

	public string category { get; set; }

	public List<string> category_features { get; set; }

	public DepartmentObj department_obj { get; set; }

	public CategoryObj category_obj { get; set; }

	public List<CategoryFeatureObj> category_feature_objs { get; set; }
}
