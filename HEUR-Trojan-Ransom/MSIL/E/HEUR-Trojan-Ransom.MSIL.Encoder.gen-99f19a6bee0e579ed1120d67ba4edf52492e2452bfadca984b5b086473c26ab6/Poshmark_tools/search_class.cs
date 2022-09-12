using System;
using System.Collections.Generic;

namespace Poshmark_tools;

internal class search_class
{
	public class SizeObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string display_with_size_set { get; set; }
	}

	public class SizeQuantity
	{
		public string size_id { get; set; }

		public int quantity_available { get; set; }

		public int quantity_reserved { get; set; }

		public int quantity_sold { get; set; }

		public int size_ref { get; set; }

		public SizeObj size_obj { get; set; }

		public List<object> size_set_tags { get; set; }
	}

	public class Inventory
	{
		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public List<SizeQuantity> size_quantities { get; set; }

		public int size_quantity_revision { get; set; }

		public bool multi_item { get; set; }

		public string nfs_reason { get; set; }

		public DateTime? last_unit_reserved_at { get; set; }
	}

	public class DepartmentObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class Catalog
	{
		public List<object> category_features { get; set; }

		public string department { get; set; }

		public string category { get; set; }

		public DepartmentObj department_obj { get; set; }

		public CategoryObj category_obj { get; set; }

		public List<object> category_feature_objs { get; set; }
	}

	public class PriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class OriginalPriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class CoverShot
	{
		public string id { get; set; }

		public string picture { get; set; }

		public string path { get; set; }

		public string path_small { get; set; }

		public string path_large { get; set; }

		public string content_type { get; set; }

		public string storage_location { get; set; }

		public string md5_hash { get; set; }

		public DateTime created_at { get; set; }

		public string url { get; set; }

		public string url_small { get; set; }

		public string url_large { get; set; }
	}

	public class Picture
	{
		public string id { get; set; }

		public string picture { get; set; }

		public string path { get; set; }

		public string path_small { get; set; }

		public string path_large { get; set; }

		public string content_type { get; set; }

		public string storage_location { get; set; }

		public string md5_hash { get; set; }

		public DateTime created_at { get; set; }

		public string url { get; set; }

		public string url_small { get; set; }

		public string url_large { get; set; }
	}

	public class FirstEventShare
	{
		public string event_id { get; set; }

		public DateTime shared_at { get; set; }
	}

	public class Aggregates
	{
		public int shares { get; set; }

		public int comments { get; set; }

		public int likes { get; set; }
	}

	public class PriceDrop
	{
		public int percentage { get; set; }
	}

	public class _Department
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryV2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class SizeObj2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string display_with_size_set { get; set; }
	}

	public class BrandObj
	{
		public string id { get; set; }

		public string canonical_name { get; set; }

		public string slug { get; set; }
	}

	public class FirstEventHostShare
	{
		public string event_id { get; set; }

		public DateTime shared_at { get; set; }
	}

	public class Datum
	{
		public string id { get; set; }

		public string creator_id { get; set; }

		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public string origin_domain { get; set; }

		public List<string> destination_domains { get; set; }

		public int publish_count { get; set; }

		public string app { get; set; }

		public string app_version { get; set; }

		public Inventory inventory { get; set; }

		public Catalog catalog { get; set; }

		public List<object> colors { get; set; }

		public string catalog_source { get; set; }

		public string inventory_unit_id { get; set; }

		public DateTime updated_at { get; set; }

		public string title { get; set; }

		public string description { get; set; }

		public PriceAmount price_amount { get; set; }

		public OriginalPriceAmount original_price_amount { get; set; }

		public string size { get; set; }

		public string brand { get; set; }

		public string brand_id { get; set; }

		public string category { get; set; }

		public string condition { get; set; }

		public CoverShot cover_shot { get; set; }

		public List<Picture> pictures { get; set; }

		public DateTime first_published_at { get; set; }

		public FirstEventShare first_event_share { get; set; }

		public int share_count { get; set; }

		public int post_comment_page { get; set; }

		public int comment_count { get; set; }

		public DateTime created_at { get; set; }

		public int price { get; set; }

		public int original_price { get; set; }

		public int like_count { get; set; }

		public int post_like_page { get; set; }

		public int post_event_page { get; set; }

		public int post_event_host_shares_page { get; set; }

		public bool has_offer { get; set; }

		public bool has_seller_offer { get; set; }

		public string picture_url { get; set; }

		public Aggregates aggregates { get; set; }

		public List<object> comments { get; set; }

		public List<object> events { get; set; }

		public List<object> event_host_shares { get; set; }

		public List<object> likes { get; set; }

		public string creator_username { get; set; }

		public string creator_display_handle { get; set; }

		public string creator_full_name { get; set; }

		public string creator_picture_url { get; set; }

		public bool caller_has_liked { get; set; }

		public PriceDrop price_drop { get; set; }

		public _Department department { get; set; }

		public CategoryV2 category_v2 { get; set; }

		public List<object> category_features { get; set; }

		public SizeObj2 size_obj { get; set; }

		public BrandObj brand_obj { get; set; }

		public string creator_fb_id { get; set; }

		public string short_url { get; set; }

		public FirstEventHostShare first_event_host_share { get; set; }
	}

	public class More
	{
		public int total { get; set; }

		public int next_max_id { get; set; }
	}

	public class Term
	{
		public int count { get; set; }

		public string term { get; set; }

		public string brand_id { get; set; }
	}

	public class Brand
	{
		public string _type { get; set; }

		public int missing { get; set; }

		public int other { get; set; }

		public List<Term> terms { get; set; }

		public int total { get; set; }
	}

	public class Term2
	{
		public int count { get; set; }

		public string term { get; set; }

		public string rgb { get; set; }
	}

	public class Color
	{
		public string _type { get; set; }

		public int missing { get; set; }

		public int other { get; set; }

		public List<Term2> terms { get; set; }

		public int total { get; set; }
	}

	public class Department2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }

		public List<object> category_v2 { get; set; }
	}

	public class Catalog2
	{
		public List<Department2> department { get; set; }
	}

	public class Facets
	{
		public Brand brand { get; set; }

		public Color color { get; set; }

		public List<object> size { get; set; }

		public Catalog2 catalog { get; set; }
	}

	public class ColorToHexMap
	{
		public string Red { get; set; }

		public string Pink { get; set; }

		public string Orange { get; set; }

		public string Yellow { get; set; }

		public string Green { get; set; }

		public string Blue { get; set; }

		public string Purple { get; set; }

		public string Gold { get; set; }

		public string Silver { get; set; }

		public string Black { get; set; }

		public string Gray { get; set; }

		public string White { get; set; }

		public string Cream { get; set; }

		public string Brown { get; set; }

		public string Tan { get; set; }
	}

	public class SelectedCatalog
	{
		public List<object> department { get; set; }

		public List<object> category_v2 { get; set; }

		public List<object> category_feature { get; set; }
	}

	public class RootObject
	{
		public List<Datum> data { get; set; }

		public More more { get; set; }

		public Facets facets { get; set; }

		public ColorToHexMap colorToHexMap { get; set; }

		public SelectedCatalog selected_catalog { get; set; }

		public string req_id { get; set; }
	}
}
