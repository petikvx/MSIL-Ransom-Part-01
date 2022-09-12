using System.Collections.Generic;

namespace Poshmark_tools;

internal class new_posher
{
	public class Sizes
	{
	}

	public class Closet
	{
		public string All { get; set; }

		public string __invalid_name__New_With_Tags { get; set; }
	}

	public class Nwt
	{
		public string All { get; set; }

		public string __invalid_name__New_With_Tags { get; set; }
	}

	public class NwtAndRet
	{
		public string All { get; set; }

		public string __invalid_name__New_With_Tags { get; set; }
	}

	public class Conditions
	{
		public Closet closet { get; set; }

		public Nwt nwt { get; set; }

		public NwtAndRet nwt_and_ret { get; set; }
	}

	public class NewType
	{
		public string __invalid_name__Closet___Boutique { get; set; }

		public string Closet { get; set; }

		public string Boutique { get; set; }
	}

	public class Availability
	{
		public string All { get; set; }

		public string Available { get; set; }

		public string Sold { get; set; }
	}

	public class Prices
	{
		public string __invalid_name___25_and_under { get; set; }

		public string __invalid_name___26__50 { get; set; }

		public string __invalid_name___51__100 { get; set; }

		public string __invalid_name___101__200 { get; set; }

		public string __invalid_name___201_and_above { get; set; }
	}

	public class Brands
	{
	}

	public class SortBy
	{
		public string __invalid_name__Just_Shared { get; set; }

		public string __invalid_name__Just_In { get; set; }

		public string __invalid_name__Price_High_to_Low { get; set; }

		public string __invalid_name__Price_Low_to_High { get; set; }

		public string __invalid_name__Recently_Price_Dropped { get; set; }
	}

	public class Colors
	{
		public string Orange { get; set; }

		public string Pink { get; set; }

		public string Blue { get; set; }

		public string Black { get; set; }

		public string Purple { get; set; }

		public string Red { get; set; }

		public string Green { get; set; }

		public string White { get; set; }

		public string Cream { get; set; }

		public string Gray { get; set; }

		public string Tan { get; set; }

		public string Brown { get; set; }

		public string Gold { get; set; }

		public string Silver { get; set; }

		public string Yellow { get; set; }
	}

	public class Categories
	{
	}

	public class Women
	{
		public string name { get; set; }

		public string slug { get; set; }

		public Categories categories { get; set; }
	}

	public class Categories2
	{
	}

	public class Men
	{
		public string name { get; set; }

		public string slug { get; set; }

		public Categories2 categories { get; set; }
	}

	public class Categories3
	{
	}

	public class Kids
	{
		public string name { get; set; }

		public string slug { get; set; }

		public Categories3 categories { get; set; }
	}

	public class CategoriesSection
	{
		public Women Women { get; set; }

		public Men Men { get; set; }

		public Kids Kids { get; set; }
	}

	public class Filters
	{
		public Sizes sizes { get; set; }

		public Conditions conditions { get; set; }

		public NewType new_type { get; set; }

		public Availability availability { get; set; }

		public Prices prices { get; set; }

		public Brands brands { get; set; }

		public string mySize { get; set; }

		public SortBy sortBy { get; set; }

		public Colors colors { get; set; }

		public CategoriesSection categoriesSection { get; set; }
	}

	public class SubCategory
	{
	}

	public class Department
	{
	}

	public class Category
	{
	}

	public class MeetThePosher
	{
		public string name { get; set; }

		public object slug { get; set; }
	}

	public class Brands2
	{
		public MeetThePosher __invalid_name__Meet_the_Posher { get; set; }
	}

	public class ConditionToType
	{
		public string all { get; set; }

		public string closet { get; set; }

		public string nwt { get; set; }

		public string nwt_and_ret { get; set; }

		public string ret { get; set; }
	}

	public class Colors2
	{
	}

	public class State
	{
		public SubCategory subCategory { get; set; }

		public Department department { get; set; }

		public Category category { get; set; }

		public Brands2 brands { get; set; }

		public ConditionToType conditionToType { get; set; }

		public string availability { get; set; }

		public string condition { get; set; }

		public List<object> sizes { get; set; }

		public object sortBy { get; set; }

		public Colors2 colors { get; set; }

		public List<object> prices { get; set; }

		public string filterType { get; set; }

		public object mySize { get; set; }
	}

	public class ScreenProperties
	{
		public string brand { get; set; }

		public object category_id { get; set; }

		public object department_id { get; set; }

		public object subcategory_id { get; set; }

		public object known_brand_id { get; set; }

		public string content_segment { get; set; }
	}

	public class TrackerData
	{
		public string screen_name { get; set; }

		public ScreenProperties screen_properties { get; set; }
	}

	public class RootObject
	{
		public bool success { get; set; }

		public string html { get; set; }

		public int max_id { get; set; }

		public Filters filters { get; set; }

		public State state { get; set; }

		public string breadcrumb { get; set; }

		public string pageType { get; set; }

		public string page_header { get; set; }

		public string page_title { get; set; }

		public TrackerData tracker_data { get; set; }
	}
}
