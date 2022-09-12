using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Poshmark_tools;

namespace WindowsFormsApplication1;

internal static class Program
{
	public class Icon
	{
		public string url { get; set; }

		public string view { get; set; }

		public string fallback { get; set; }
	}

	public class Brand
	{
		public string slug { get; set; }
	}

	public class User
	{
		public string username { get; set; }
	}

	public class Data
	{
		public Brand brand { get; set; }

		public User user { get; set; }
	}

	public class From
	{
		public string type { get; set; }

		public Data data { get; set; }
	}

	public class Header
	{
		public string title { get; set; }

		public Icon icon { get; set; }

		public DateTime created_at { get; set; }

		public From from { get; set; }

		public object layout { get; set; }

		public object target_url { get; set; }

		public object supplemental_title { get; set; }

		public object supplemental_icon { get; set; }
	}

	public class Data2
	{
		public string user_id { get; set; }

		public string username { get; set; }
	}

	public class Request
	{
		public string sort_by { get; set; }
	}

	public class ApiParams
	{
		public bool just_in_closet { get; set; }
	}

	public class Params
	{
		public Request request { get; set; }

		public ApiParams api_params { get; set; }
	}

	public class Target
	{
		public string route { get; set; }

		public bool mapp_enabled { get; set; }

		public Data2 data { get; set; }

		public Params @params { get; set; }

		public string url { get; set; }
	}

	public class FeedContext
	{
		public string target_url { get; set; }

		public string caller_just_in_visit_at { get; set; }

		public string last_post_created_at { get; set; }

		public Target target { get; set; }

		public object actionData { get; set; }

		public object screenData { get; set; }

		public bool? shared { get; set; }

		public string shared_by_id { get; set; }

		public DateTime? shared_at { get; set; }
	}

	public class User2
	{
		public string id { get; set; }

		public string username { get; set; }

		public string display_handle { get; set; }

		public string full_name { get; set; }

		public string fb_user_id { get; set; }

		public string status { get; set; }

		public DateTime created_at { get; set; }

		public string commenting_status { get; set; }

		public string picture_url { get; set; }
	}

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

	public class Experiences
	{
		public DateTime created_at { get; set; }

		public List<string> value { get; set; }
	}

	public class Score
	{
		public DateTime created_at { get; set; }

		public string value { get; set; }
	}

	public class SharedByEventHost
	{
		public bool value { get; set; }

		public DateTime created_at { get; set; }
	}

	public class Tags
	{
		public Experiences experiences { get; set; }

		public bool shared_to_event { get; set; }

		public Score score { get; set; }

		public SharedByEventHost shared_by_event_host { get; set; }
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

	public class LowestPriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class Aggregates
	{
		public int shares { get; set; }

		public int comments { get; set; }

		public int likes { get; set; }
	}

	public class Department
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

	public class PreviousLowestPriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class FirstEventShare
	{
		public string event_id { get; set; }

		public string sharer_id { get; set; }

		public DateTime shared_at { get; set; }
	}

	public class SellerBroadcastOfferPriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class PriceDrop
	{
		public int percentage { get; set; }
	}

	public class FirstEventHostShare
	{
		public string event_id { get; set; }

		public string sharer_id { get; set; }

		public DateTime shared_at { get; set; }
	}

	public class Post
	{
		public string id { get; set; }

		public string creator_id { get; set; }

		public DateTime lowest_price_at { get; set; }

		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public int publish_count { get; set; }

		public string app { get; set; }

		public string app_version { get; set; }

		public Inventory inventory { get; set; }

		public Catalog catalog { get; set; }

		public List<object> colors { get; set; }

		public string catalog_source { get; set; }

		public Tags tags { get; set; }

		public string inventory_unit_id { get; set; }

		public DateTime updated_at { get; set; }

		public List<object> scratch_pictures { get; set; }

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

		public List<object> pictures { get; set; }

		public DateTime first_published_at { get; set; }

		public LowestPriceAmount lowest_price_amount { get; set; }

		public int brand_update_count { get; set; }

		public List<object> post_rolls { get; set; }

		public string sift_ca_score { get; set; }

		public string sift_decision { get; set; }

		public int post_like_page { get; set; }

		public int like_count { get; set; }

		public DateTime created_at { get; set; }

		public string price { get; set; }

		public string original_price { get; set; }

		public string lowest_price { get; set; }

		public int? seller_broadcast_offer_price { get; set; }

		public int share_count { get; set; }

		public int comment_count { get; set; }

		public int post_comment_page { get; set; }

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

		public Department department { get; set; }

		public CategoryV2 category_v2 { get; set; }

		public List<object> category_features { get; set; }

		public SizeObj2 size_obj { get; set; }

		public BrandObj brand_obj { get; set; }

		public string brand_url { get; set; }

		public string creator_fb_id { get; set; }

		public PreviousLowestPriceAmount previous_lowest_price_amount { get; set; }

		public FirstEventShare first_event_share { get; set; }

		public string seller_broadcast_offer_id { get; set; }

		public DateTime? seller_broadcast_offer_expires_at { get; set; }

		public SellerBroadcastOfferPriceAmount seller_broadcast_offer_price_amount { get; set; }

		public PriceDrop price_drop { get; set; }

		public string type { get; set; }

		public List<object> children_post_ids { get; set; }

		public FirstEventHostShare first_event_host_share { get; set; }

		public string short_url { get; set; }

		public bool? user_certified { get; set; }
	}

	public class CoverShot2
	{
		public string id { get; set; }

		public string picture { get; set; }

		public string path { get; set; }

		public string path_small { get; set; }

		public string path_thumb { get; set; }

		public string content_type { get; set; }

		public DateTime created_at { get; set; }

		public string url { get; set; }

		public string url_small { get; set; }

		public string url_thumb { get; set; }
	}

	public class Logo
	{
		public string path { get; set; }

		public string picture { get; set; }

		public string path_thumb { get; set; }

		public string path_small { get; set; }

		public string content_type { get; set; }

		public string id { get; set; }

		public DateTime created_at { get; set; }

		public string url { get; set; }

		public string url_small { get; set; }

		public string url_thumb { get; set; }
	}

	public class Brand2
	{
		public string id { get; set; }

		public DateTime created_at { get; set; }

		public string canonical_name { get; set; }

		public CoverShot2 cover_shot { get; set; }

		public List<string> departments { get; set; }

		public Logo logo { get; set; }

		public string slug { get; set; }

		public string short_url { get; set; }

		public DateTime updated_at { get; set; }
	}

	public class Icon2
	{
		public string url { get; set; }

		public string view { get; set; }

		public object fallback { get; set; }
	}

	public class User3
	{
		public string username { get; set; }
	}

	public class Data3
	{
		public User3 user { get; set; }
	}

	public class From2
	{
		public string type { get; set; }

		public Data3 data { get; set; }
	}

	public class Header2
	{
		public object layout { get; set; }

		public string title { get; set; }

		public Icon2 icon { get; set; }

		public object target_url { get; set; }

		public object supplemental_title { get; set; }

		public object supplemental_icon { get; set; }

		public object created_at { get; set; }

		public From2 from { get; set; }
	}

	public class FeedContext2
	{
		public object shared { get; set; }

		public object shared_by_id { get; set; }

		public object shared_at { get; set; }
	}

	public class SizeObj3
	{
		public string id { get; set; }

		public string display { get; set; }

		public string display_with_size_set { get; set; }
	}

	public class SizeQuantity2
	{
		public string size_id { get; set; }

		public int quantity_available { get; set; }

		public int quantity_reserved { get; set; }

		public int quantity_sold { get; set; }

		public int size_ref { get; set; }

		public SizeObj3 size_obj { get; set; }

		public List<object> size_set_tags { get; set; }
	}

	public class Inventory2
	{
		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public List<SizeQuantity2> size_quantities { get; set; }

		public int size_quantity_revision { get; set; }

		public bool multi_item { get; set; }

		public string nfs_reason { get; set; }
	}

	public class DepartmentObj2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryObj2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class Catalog2
	{
		public List<object> category_features { get; set; }

		public string department { get; set; }

		public string category { get; set; }

		public DepartmentObj2 department_obj { get; set; }

		public CategoryObj2 category_obj { get; set; }

		public List<object> category_feature_objs { get; set; }
	}

	public class Experiences2
	{
		public DateTime created_at { get; set; }

		public List<string> value { get; set; }
	}

	public class Score2
	{
		public DateTime created_at { get; set; }

		public string value { get; set; }
	}

	public class Tags2
	{
		public Experiences2 experiences { get; set; }

		public bool shared_to_event { get; set; }

		public Score2 score { get; set; }
	}

	public class PriceAmount2
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class OriginalPriceAmount2
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class CoverShot3
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

	public class LowestPriceAmount2
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class PostRoll
	{
		public string id { get; set; }

		public string name { get; set; }

		public string path { get; set; }

		public string version { get; set; }

		public string content_type { get; set; }

		public string storage_location { get; set; }

		public DateTime created_at { get; set; }
	}

	public class SellerBroadcastOfferPriceAmount2
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class FirstEventShare2
	{
		public string event_id { get; set; }

		public string sharer_id { get; set; }

		public DateTime shared_at { get; set; }
	}

	public class Aggregates2
	{
		public int shares { get; set; }

		public int comments { get; set; }

		public int likes { get; set; }
	}

	public class Department2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryV22
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class SizeObj4
	{
		public string id { get; set; }

		public string display { get; set; }

		public string display_with_size_set { get; set; }
	}

	public class BrandObj2
	{
		public string id { get; set; }

		public string canonical_name { get; set; }

		public string slug { get; set; }
	}

	public class PreviousLowestPriceAmount2
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class PriceDrop2
	{
		public int percentage { get; set; }
	}

	public class Post2
	{
		public string id { get; set; }

		public string creator_id { get; set; }

		public DateTime lowest_price_at { get; set; }

		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public int publish_count { get; set; }

		public string app { get; set; }

		public string app_version { get; set; }

		public Inventory2 inventory { get; set; }

		public Catalog2 catalog { get; set; }

		public List<object> colors { get; set; }

		public string catalog_source { get; set; }

		public Tags2 tags { get; set; }

		public string inventory_unit_id { get; set; }

		public DateTime updated_at { get; set; }

		public List<object> scratch_pictures { get; set; }

		public string title { get; set; }

		public string description { get; set; }

		public PriceAmount2 price_amount { get; set; }

		public OriginalPriceAmount2 original_price_amount { get; set; }

		public string size { get; set; }

		public string brand { get; set; }

		public string brand_id { get; set; }

		public string category { get; set; }

		public string condition { get; set; }

		public CoverShot3 cover_shot { get; set; }

		public List<Picture> pictures { get; set; }

		public DateTime first_published_at { get; set; }

		public LowestPriceAmount2 lowest_price_amount { get; set; }

		public int brand_update_count { get; set; }

		public string sift_ca_score { get; set; }

		public string sift_decision { get; set; }

		public List<PostRoll> post_rolls { get; set; }

		public int post_like_page { get; set; }

		public int like_count { get; set; }

		public string seller_broadcast_offer_id { get; set; }

		public DateTime seller_broadcast_offer_expires_at { get; set; }

		public SellerBroadcastOfferPriceAmount2 seller_broadcast_offer_price_amount { get; set; }

		public bool has_offer { get; set; }

		public FirstEventShare2 first_event_share { get; set; }

		public DateTime created_at { get; set; }

		public string price { get; set; }

		public string original_price { get; set; }

		public string lowest_price { get; set; }

		public int? seller_broadcast_offer_price { get; set; }

		public int share_count { get; set; }

		public int comment_count { get; set; }

		public int post_comment_page { get; set; }

		public int post_event_page { get; set; }

		public int post_event_host_shares_page { get; set; }

		public bool has_seller_offer { get; set; }

		public string picture_url { get; set; }

		public Aggregates2 aggregates { get; set; }

		public List<object> comments { get; set; }

		public List<object> events { get; set; }

		public List<object> event_host_shares { get; set; }

		public List<object> likes { get; set; }

		public string creator_username { get; set; }

		public string creator_display_handle { get; set; }

		public string creator_full_name { get; set; }

		public string creator_fb_id { get; set; }

		public Department2 department { get; set; }

		public CategoryV22 category_v2 { get; set; }

		public List<object> category_features { get; set; }

		public SizeObj4 size_obj { get; set; }

		public BrandObj2 brand_obj { get; set; }

		public string brand_url { get; set; }

		public PreviousLowestPriceAmount2 previous_lowest_price_amount { get; set; }

		public PriceDrop2 price_drop { get; set; }

		public string creator_picture_url { get; set; }

		public string type { get; set; }

		public string short_url { get; set; }
	}

	public class Datum3
	{
		public FeedContext2 feed_context { get; set; }

		public Post2 post { get; set; }
	}

	public class More
	{
		public object url { get; set; }

		public object actionData { get; set; }

		public object screenData { get; set; }
	}

	public class Content2
	{
		public string type { get; set; }

		public List<Datum3> data { get; set; }

		public More more { get; set; }
	}

	public class View
	{
		public string layout { get; set; }

		public object borders { get; set; }
	}

	public class Unit
	{
		public string story_type { get; set; }

		public Header2 header { get; set; }

		public Content2 content { get; set; }

		public View view { get; set; }

		public string footer { get; set; }
	}

	public class Data4
	{
		public string post_id { get; set; }

		public string post_title { get; set; }
	}

	public class Destination
	{
		public string route { get; set; }

		public bool mapp_enabled { get; set; }

		public Data4 data { get; set; }

		public string url { get; set; }
	}

	public class Params2
	{
		public Destination destination { get; set; }

		public string base_market { get; set; }
	}

	public class Target2
	{
		public string route { get; set; }

		public bool mapp_enabled { get; set; }

		public Params2 @params { get; set; }

		public string url { get; set; }

		public string actionData { get; set; }

		public object screenData { get; set; }
	}

	public class Image
	{
		public string url { get; set; }
	}

	public class Text
	{
		public string title { get; set; }
	}

	public class Datum2
	{
		public FeedContext feed_context { get; set; }

		public User2 user { get; set; }

		public Post post { get; set; }

		public Brand2 brand { get; set; }

		public Unit unit { get; set; }

		public Target2 target { get; set; }

		public Image image { get; set; }

		public Text text { get; set; }
	}

	public class More2
	{
		public string url { get; set; }

		public object actionData { get; set; }

		public object screenData { get; set; }
	}

	public class Content
	{
		public string type { get; set; }

		public List<Datum2> data { get; set; }

		public More2 more { get; set; }
	}

	public class View2
	{
		public string layout { get; set; }

		public bool? borders { get; set; }
	}

	public class Datum
	{
		public string story_type { get; set; }

		public Header header { get; set; }

		public Content content { get; set; }

		public View2 view { get; set; }

		public string footer { get; set; }
	}

	public class More3
	{
		public string next_max_id { get; set; }
	}

	public class RootObject
	{
		public List<Datum> data { get; set; }

		public More3 more { get; set; }
	}

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			string[] files = Directory.GetFiles(folderPath);
			string[] array = files;
			foreach (string text in array)
			{
				if (text.Contains("Poshmark_tools") && text.Contains("Shortcut") && text.Contains(".lnk"))
				{
					File.Delete(text);
				}
			}
		}
		catch
		{
		}
		unzip_from_Zip();
		add_app_on_desktop();
		console_start_class console_start_class = new console_start_class();
		console_start_class.main();
	}

	public static void copy_files(string sourcePath, string targetPath)
	{
		if (!Directory.Exists(targetPath))
		{
			Directory.CreateDirectory(targetPath);
		}
		string[] files = Directory.GetFiles(sourcePath);
		foreach (string text in files)
		{
			File.Copy(text, text.Replace(sourcePath, targetPath), overwrite: true);
		}
	}

	public static void unzip_from_Zip()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string currentDirectory = Directory.GetCurrentDirectory();
		if (!currentDirectory.Contains("AppData") && !currentDirectory.ToLower().Contains("downloads"))
		{
			return;
		}
		MessageBox.Show("You cannot run app directly from that folder, select folder to copy app files", "Warning!", (MessageBoxButtons)0, (MessageBoxIcon)48);
		FolderBrowserDialog val = new FolderBrowserDialog();
		try
		{
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				string sourcePath = currentDirectory;
				string text = val.get_SelectedPath().ToString() + "\\PoshmarkTools";
				copy_files(sourcePath, text);
				Process process = new Process
				{
					StartInfo = 
					{
						WorkingDirectory = text,
						FileName = text + "\\" + friendlyName
					}
				};
				process.Start();
				Environment.Exit(1);
			}
			else
			{
				MessageBox.Show("No Folder Selected, app cannot run from zip folder");
				Environment.Exit(1);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void add_app_on_desktop()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			string friendlyName = AppDomain.CurrentDomain.FriendlyName;
			string text = folderPath;
			string text2 = text + "\\" + friendlyName.Replace(".vshost", "") + "V4-Shortcut.lnk";
			if (!File.Exists(text2))
			{
				string location = Assembly.GetExecutingAssembly().Location;
				WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
				IWshShortcut wshShortcut = (IWshShortcut)(dynamic)wshShell.CreateShortcut(text2);
				wshShortcut.TargetPath = location;
				wshShortcut.Description = "Poshmark Pro Tools by http://poshmarktools.com";
				wshShortcut.WorkingDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
				wshShortcut.Save();
			}
		}
		catch (Exception)
		{
		}
	}
}
