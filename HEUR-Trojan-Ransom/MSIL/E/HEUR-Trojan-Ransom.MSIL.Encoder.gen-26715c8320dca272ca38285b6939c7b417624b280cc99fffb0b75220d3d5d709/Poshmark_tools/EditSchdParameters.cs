using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class EditSchdParameters : Form
{
	public struct SchdParametersStruct
	{
		public string type;

		public string hour;

		public string closet_name;

		public string QuantityOfLoops;

		public string QuantityOfListings;

		public string DelayAfterLoops;

		public string DelayInListings;

		public string ShareSpecificListingsFromMyCloset;

		public string ShareBackLast;

		public string ShareNewPosher;

		public string DelayBetweenFollow_Unfollow;

		public string QuantityOfFollow_Unfollow;

		public string Follow_keywords;

		public string FollowNextClosetXtoXSec;

		public string NumberofClosetsToFollow;

		public string KeywordToLike;

		public string CountOfLikes;

		public string DelayBetweennextLike;

		public string KeywordToComment;

		public string CountOfComments;

		public string DelayBetweennextComment;

		public string CommentText;

		public bool ShareToParty;

		public bool ShareClosetInReverse;

		public string last_run_hour;

		public string last_run_date;
	}

	public Pro_share_follow_schedules ProSchd;

	public string type = "";

	public string hour = "";

	public SchdParametersStruct SchdParameters;

	private IContainer components = null;

	public MetroTextBox tb_shareBackLast;

	public MetroTextBox tb_ShareSpecificListings;

	private MetroLabel label_delayInListings;

	private MetroLabel label_DelayAfterLoops;

	private MetroLabel label_QuantityofListings;

	private MetroLabel label_QuantityofLoops;

	public MetroTextBox tb_delayInListings;

	public MetroTextBox tb_DelayAfterLoops;

	public MetroTextBox tb_QuantityofListings;

	public MetroTextBox tb_QuantityofLoops;

	public MetroTextBox tb_Closet_name;

	private Label label_ShareSpecificListing;

	private Label label_sharebackX;

	private Label label_shareNewPoshers;

	private TableLayoutPanel tableLayoutPanel1;

	private TableLayoutPanel tlb_ShareNewPoshers;

	public MetroTextBox tb_shareNewPosher;

	private TableLayoutPanel tlb_shareBackX;

	public MetroTextBox tb_QuantityFollow;

	private MetroLabel label_QuantityFollow;

	public MetroTextBox tb_DelayFollow;

	private MetroLabel label_DelayFollow;

	private Button button_Set;

	private Button button_Cancel;

	private MetroLabel label_ClosetName;

	private MetroLabel label_ShareClosetinReverse;

	public MetroCheckBox cb_ShareToParty;

	public MetroCheckBox cb_ShareClosetinReverse;

	private MetroLabel label_ShareToParty;

	public MetroTextBox tb_shareNewPosher_x;

	public MetroTextBox tb_shareBackLast_x;

	public EditSchdParameters(Pro_share_follow_schedules _ProSchd, string _type, string _hour)
	{
		hour = _hour;
		type = _type;
		((Control)this).set_Text(type);
		SchdParameters = default(SchdParametersStruct);
		ProSchd = _ProSchd;
		InitializeComponent();
		tb_ShareSpecificListings.Multiline = false;
		switch (type)
		{
		case "Follow Back Closets":
			((Control)label_ClosetName).set_Text("Keywords");
			((Control)tb_Closet_name).set_Text("Follow Back Closets");
			((Control)tb_Closet_name).set_Enabled(false);
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_delayInListings).set_Text("Follow next closet every [X] to [X] seconds");
			((Control)label_QuantityofLoops).set_Text("Number of Closets to Follow");
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "UnFollow Closet":
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofLoops).Hide();
			((Control)tb_QuantityofLoops).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_delayInListings).Hide();
			((Control)tb_delayInListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			break;
		case "Follow (keyword based)":
			((Control)label_ClosetName).set_Text("Keywords LIKE Anthropologie, Prada, Gucci");
			((Control)tb_Closet_name).set_Text("Anthropologie, Prada, Gucci");
			((Control)label_delayInListings).set_Text("Follow next closet every [X] to [X] seconds");
			((Control)label_QuantityofLoops).set_Text("Number of Closets to Follow");
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Feed Share":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			break;
		case "Share My Available Items":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share Specific Listings":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share":
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			break;
		case "Comment":
			((Control)label_ClosetName).set_Text("Provide Keyword/Brand to Comment in listings");
			((Control)tb_Closet_name).set_Text("");
			((Control)label_QuantityofLoops).set_Text("Provide Count of Comments");
			((Control)tb_QuantityofLoops).set_Text("");
			((Control)label_delayInListings).set_Text("Provide Delay between next Comment");
			((Control)tb_delayInListings).set_Text("");
			((Control)label_ShareSpecificListing).set_Text("Comment Text");
			tb_ShareSpecificListings.Multiline = true;
			((Control)tb_ShareSpecificListings).set_Text("Nice\r\nLoved it\r\nAmazing");
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_delayInListings).Hide();
			((Control)tb_delayInListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Like":
			((Control)label_ClosetName).set_Text("Provide Keyword/Brand to Like in listings");
			((Control)tb_Closet_name).set_Text("");
			((Control)label_QuantityofLoops).set_Text("Provide Count of Likes");
			((Control)tb_QuantityofLoops).set_Text("");
			((Control)label_delayInListings).set_Text("Provide Delay between next Like");
			((Control)tb_delayInListings).set_Text("");
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_delayInListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share New Posher Listings":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share Back from Party":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Follow Closet":
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofLoops).Hide();
			((Control)tb_QuantityofLoops).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_delayInListings).Hide();
			((Control)tb_delayInListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			break;
		case "Follow New Poshers":
			((Control)label_ClosetName).set_Text("Keywords");
			((Control)tb_Closet_name).set_Text("New Poshers");
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)tb_Closet_name).set_Enabled(false);
			((Control)label_delayInListings).set_Text("Follow next closet every [X] to [X] seconds");
			((Control)label_QuantityofLoops).set_Text("Number of Closets to Follow");
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share Back":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		}
	}

	public EditSchdParameters(Pro_share_follow_schedules _ProSchd, string _type, string _hour, SchdParametersStruct SavedSchdParams)
	{
		hour = _hour;
		type = _type;
		((Control)this).set_Text(type);
		SchdParameters = default(SchdParametersStruct);
		SchdParameters = SavedSchdParams;
		SavedSchdParams.hour = hour;
		ProSchd = _ProSchd;
		InitializeComponent();
		switch (type)
		{
		case "Follow Back Closets":
			((Control)label_ClosetName).set_Text("Keywords");
			((Control)tb_Closet_name).set_Text("Follow Back Closets");
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)tb_Closet_name).set_Enabled(false);
			((Control)label_delayInListings).set_Text("Follow next closet every [X] to [X] seconds (x,x)");
			((Control)label_QuantityofLoops).set_Text("Number of Closets to Follow");
			((Control)tb_Closet_name).set_Text("");
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.NumberofClosetsToFollow);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.FollowNextClosetXtoXSec);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "UnFollow Closet":
			((Control)tb_DelayFollow).set_Text(SavedSchdParams.DelayBetweenFollow_Unfollow);
			((Control)tb_QuantityFollow).set_Text(SavedSchdParams.QuantityOfFollow_Unfollow);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofLoops).Hide();
			((Control)tb_QuantityofLoops).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_delayInListings).Hide();
			((Control)tb_delayInListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			break;
		case "Follow (keyword based)":
			((Control)label_ClosetName).set_Text("Keywords LIKE Anthropologie, Prada, Gucci");
			((Control)tb_Closet_name).set_Text("Anthropologie, Prada, Gucci");
			((Control)label_delayInListings).set_Text("Follow next closet every [X] to [X] seconds");
			((Control)label_QuantityofLoops).set_Text("Number of Closets to Follow");
			((Control)tb_Closet_name).set_Text(SavedSchdParams.Follow_keywords);
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.NumberofClosetsToFollow);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.FollowNextClosetXtoXSec);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Feed Share":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)tb_Closet_name).set_Text(SavedSchdParams.closet_name);
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_QuantityofListings).set_Text(SavedSchdParams.QuantityOfListings);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			break;
		case "Share My Available Items":
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share Specific Listings":
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			((Control)tb_ShareSpecificListings).set_Text(SavedSchdParams.ShareSpecificListingsFromMyCloset);
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share":
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)tb_Closet_name).set_Text(SavedSchdParams.closet_name);
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_QuantityofListings).set_Text(SavedSchdParams.QuantityOfListings);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			break;
		case "Comment":
			((Control)label_ClosetName).set_Text("Provide Keyword/Brand to Comment in listings");
			((Control)tb_Closet_name).set_Text("");
			((Control)label_QuantityofLoops).set_Text("Provide Count of Comments");
			((Control)tb_QuantityofLoops).set_Text("");
			((Control)label_delayInListings).set_Text("Provide Delay between next Comment");
			((Control)tb_delayInListings).set_Text("");
			((Control)label_ShareSpecificListing).set_Text("Comment Text (1 comment in 1 line)");
			tb_ShareSpecificListings.Multiline = true;
			((Control)tb_ShareSpecificListings).set_Text("Nice\r\nLoved it\r\nAmazing");
			((Control)tb_Closet_name).set_Text(SavedSchdParams.KeywordToComment);
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.CountOfComments);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayBetweennextComment);
			((Control)tb_ShareSpecificListings).set_Text(SavedSchdParams.CommentText);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Like":
			((Control)label_ClosetName).set_Text("Provide Keyword/Brand to Like in listings");
			((Control)tb_Closet_name).set_Text("");
			((Control)label_QuantityofLoops).set_Text("Provide Count of Likes");
			((Control)tb_QuantityofLoops).set_Text("");
			((Control)label_delayInListings).set_Text("Provide Delay between next Like");
			((Control)tb_delayInListings).set_Text("");
			((Control)tb_Closet_name).set_Text(SavedSchdParams.KeywordToLike);
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.CountOfLikes);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayBetweennextLike);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share New Posher Listings":
		{
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			string[] array2 = Regex.Split(SavedSchdParams.ShareNewPosher, ",");
			if (array2.Length < 2)
			{
				array2 = new string[2] { "1", "2" };
			}
			((Control)tb_shareNewPosher).set_Text(array2[0]);
			((Control)tb_shareNewPosher_x).set_Text(array2[1]);
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		}
		case "Share Back from Party":
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_QuantityofListings).set_Text(SavedSchdParams.QuantityOfListings);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Follow Closet":
			((Control)tb_Closet_name).set_Text(SavedSchdParams.closet_name);
			((Control)tb_DelayFollow).set_Text(SavedSchdParams.DelayBetweenFollow_Unfollow);
			((Control)tb_QuantityFollow).set_Text(SavedSchdParams.QuantityOfFollow_Unfollow);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofLoops).Hide();
			((Control)tb_QuantityofLoops).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_delayInListings).Hide();
			((Control)tb_delayInListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			break;
		case "Follow New Poshers":
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)tb_Closet_name).set_Text("New Poshers");
			((Control)tb_Closet_name).set_Enabled(false);
			((Control)label_delayInListings).set_Text("Follow next closet every [X] to [X] seconds");
			((Control)label_QuantityofLoops).set_Text("Number of Closets to Follow");
			((Control)tb_Closet_name).set_Text(SavedSchdParams.closet_name);
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.NumberofClosetsToFollow);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.FollowNextClosetXtoXSec);
			((Control)label_ShareToParty).Hide();
			((Control)cb_ShareToParty).Hide();
			((Control)label_ShareClosetinReverse).Hide();
			((Control)cb_ShareClosetinReverse).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_DelayAfterLoops).Hide();
			((Control)tb_DelayAfterLoops).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_sharebackX).Hide();
			((Control)tlb_shareBackX).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		case "Share Back":
		{
			if (SavedSchdParams.ShareToParty)
			{
				((CheckBox)cb_ShareToParty).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareToParty).set_Checked(false);
			}
			if (SavedSchdParams.ShareClosetInReverse)
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
			}
			else
			{
				((CheckBox)cb_ShareClosetinReverse).set_Checked(false);
			}
			((Control)tb_QuantityofLoops).set_Text(SavedSchdParams.QuantityOfLoops);
			((Control)tb_DelayAfterLoops).set_Text(SavedSchdParams.DelayAfterLoops);
			((Control)tb_delayInListings).set_Text(SavedSchdParams.DelayInListings);
			string[] array = Regex.Split(SavedSchdParams.ShareBackLast, ",");
			if (array.Length < 2)
			{
				array = new string[2] { "1", "2" };
			}
			((Control)tb_shareBackLast).set_Text(array[0]);
			((Control)tb_shareBackLast_x).set_Text(array[1]);
			((Control)label_ClosetName).Hide();
			((Control)tb_Closet_name).Hide();
			((Control)label_QuantityofListings).Hide();
			((Control)tb_QuantityofListings).Hide();
			((Control)label_ShareSpecificListing).Hide();
			((Control)tb_ShareSpecificListings).Hide();
			((Control)label_shareNewPoshers).Hide();
			((Control)tlb_ShareNewPoshers).Hide();
			((Control)label_DelayFollow).Hide();
			((Control)tb_DelayFollow).Hide();
			((Control)label_QuantityFollow).Hide();
			((Control)tb_QuantityFollow).Hide();
			break;
		}
		}
	}

	private void label12_Click(object sender, EventArgs e)
	{
	}

	private void metroLabel2_Click(object sender, EventArgs e)
	{
	}

	private void button_Cancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_Set_Click(object sender, EventArgs e)
	{
		SchdParameters.type = type;
		SchdParameters.hour = hour;
		switch (type)
		{
		case "Follow Back Closets":
			SchdParameters.Follow_keywords = "Follow Back Closets";
			SchdParameters.FollowNextClosetXtoXSec = ((Control)tb_delayInListings).get_Text();
			SchdParameters.NumberofClosetsToFollow = ((Control)tb_QuantityofLoops).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "UnFollow Closet":
			SchdParameters.DelayBetweenFollow_Unfollow = ((Control)tb_DelayFollow).get_Text();
			SchdParameters.QuantityOfFollow_Unfollow = ((Control)tb_QuantityFollow).get_Text();
			break;
		case "Follow (keyword based)":
			SchdParameters.Follow_keywords = ((Control)tb_Closet_name).get_Text();
			SchdParameters.FollowNextClosetXtoXSec = ((Control)tb_delayInListings).get_Text();
			SchdParameters.NumberofClosetsToFollow = ((Control)tb_QuantityofLoops).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Feed Share":
			SchdParameters.closet_name = "feed";
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.QuantityOfListings = ((Control)tb_QuantityofListings).get_Text();
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Share My Available Items":
			SchdParameters.closet_name = "";
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Share Specific Listings":
			SchdParameters.closet_name = "";
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			SchdParameters.ShareSpecificListingsFromMyCloset = ((Control)tb_ShareSpecificListings).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Share":
			SchdParameters.closet_name = ((Control)tb_Closet_name).get_Text();
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.QuantityOfListings = ((Control)tb_QuantityofListings).get_Text();
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			((Form)this).Close();
			break;
		case "Comment":
			SchdParameters.KeywordToComment = ((Control)tb_Closet_name).get_Text();
			SchdParameters.CountOfComments = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.DelayBetweennextComment = ((Control)tb_delayInListings).get_Text();
			SchdParameters.CommentText = ((Control)tb_ShareSpecificListings).get_Text();
			break;
		case "Like":
			SchdParameters.KeywordToLike = ((Control)tb_Closet_name).get_Text();
			SchdParameters.CountOfLikes = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.DelayBetweennextLike = ((Control)tb_delayInListings).get_Text();
			break;
		case "Share New Posher Listings":
			SchdParameters.closet_name = "";
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			SchdParameters.ShareNewPosher = ((Control)tb_shareNewPosher).get_Text() + "," + ((Control)tb_shareNewPosher_x).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Share Back from Party":
			SchdParameters.closet_name = "party shareback";
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.QuantityOfListings = ((Control)tb_QuantityofListings).get_Text();
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Follow Closet":
			SchdParameters.closet_name = ((Control)tb_Closet_name).get_Text();
			SchdParameters.DelayBetweenFollow_Unfollow = ((Control)tb_DelayFollow).get_Text();
			SchdParameters.QuantityOfFollow_Unfollow = ((Control)tb_QuantityFollow).get_Text();
			break;
		case "Follow New Poshers":
			SchdParameters.Follow_keywords = "New Poshers";
			SchdParameters.FollowNextClosetXtoXSec = ((Control)tb_delayInListings).get_Text();
			SchdParameters.NumberofClosetsToFollow = ((Control)tb_QuantityofLoops).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		case "Share Back":
			SchdParameters.closet_name = "";
			SchdParameters.QuantityOfLoops = ((Control)tb_QuantityofLoops).get_Text();
			SchdParameters.closet_name = "Share Back";
			SchdParameters.DelayAfterLoops = ((Control)tb_DelayAfterLoops).get_Text();
			SchdParameters.DelayInListings = ((Control)tb_delayInListings).get_Text();
			SchdParameters.ShareBackLast = ((Control)tb_shareBackLast).get_Text() + "," + ((Control)tb_shareBackLast_x).get_Text();
			if (((CheckBox)cb_ShareToParty).get_Checked())
			{
				SchdParameters.ShareToParty = true;
			}
			else
			{
				SchdParameters.ShareToParty = false;
			}
			if (((CheckBox)cb_ShareClosetinReverse).get_Checked())
			{
				SchdParameters.ShareClosetInReverse = true;
			}
			else
			{
				SchdParameters.ShareClosetInReverse = false;
			}
			break;
		}
		((Form)this).Close();
	}

	private void tb_QuantityofLoops_KeyPress(object sender, KeyPressEventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		string name = ((Control)metroTextBox).get_Name();
		if (name.ToLower().Contains("delay"))
		{
			if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != ',')
			{
				e.set_Handled(true);
			}
		}
		else if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()))
		{
			e.set_Handled(true);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected O, but got Unknown
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected O, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected O, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Expected O, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected O, but got Unknown
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected O, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected O, but got Unknown
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected O, but got Unknown
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected O, but got Unknown
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected O, but got Unknown
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected O, but got Unknown
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected O, but got Unknown
		//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1005: Expected O, but got Unknown
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Expected O, but got Unknown
		//IL_114f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Expected O, but got Unknown
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Expected O, but got Unknown
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected O, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected O, but got Unknown
		//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d0: Expected O, but got Unknown
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected O, but got Unknown
		//IL_1451: Unknown result type (might be due to invalid IL or missing references)
		//IL_145b: Expected O, but got Unknown
		tb_shareBackLast = new MetroTextBox();
		tb_ShareSpecificListings = new MetroTextBox();
		label_delayInListings = new MetroLabel();
		label_DelayAfterLoops = new MetroLabel();
		label_QuantityofListings = new MetroLabel();
		label_QuantityofLoops = new MetroLabel();
		tb_delayInListings = new MetroTextBox();
		tb_DelayAfterLoops = new MetroTextBox();
		tb_QuantityofListings = new MetroTextBox();
		tb_QuantityofLoops = new MetroTextBox();
		tb_Closet_name = new MetroTextBox();
		label_ShareSpecificListing = new Label();
		label_sharebackX = new Label();
		label_shareNewPoshers = new Label();
		tableLayoutPanel1 = new TableLayoutPanel();
		cb_ShareClosetinReverse = new MetroCheckBox();
		button_Set = new Button();
		tb_QuantityFollow = new MetroTextBox();
		tlb_ShareNewPoshers = new TableLayoutPanel();
		tb_shareNewPosher = new MetroTextBox();
		label_QuantityFollow = new MetroLabel();
		tlb_shareBackX = new TableLayoutPanel();
		label_DelayFollow = new MetroLabel();
		tb_DelayFollow = new MetroTextBox();
		button_Cancel = new Button();
		label_ClosetName = new MetroLabel();
		label_ShareClosetinReverse = new MetroLabel();
		cb_ShareToParty = new MetroCheckBox();
		label_ShareToParty = new MetroLabel();
		tb_shareBackLast_x = new MetroTextBox();
		tb_shareNewPosher_x = new MetroTextBox();
		((Control)tableLayoutPanel1).SuspendLayout();
		((Control)tlb_ShareNewPoshers).SuspendLayout();
		((Control)tlb_shareBackX).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tb_shareBackLast).set_Dock((DockStyle)5);
		((Control)tb_shareBackLast).set_ForeColor(Color.LightGray);
		((Control)tb_shareBackLast).set_Location(new Point(3, 3));
		((Control)tb_shareBackLast).set_Name("tb_shareBackLast");
		((Control)tb_shareBackLast).set_Size(new Size(201, 30));
		tb_shareBackLast.Style = MetroColorStyle.Brown;
		((Control)tb_shareBackLast).set_TabIndex(111);
		((Control)tb_shareBackLast).set_Text("2");
		tb_shareBackLast.UseStyleColors = true;
		((Control)tb_shareBackLast).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)tb_ShareSpecificListings).set_Dock((DockStyle)5);
		((Control)tb_ShareSpecificListings).set_ForeColor(Color.LightGray);
		((Control)tb_ShareSpecificListings).set_Location(new Point(426, 255));
		((Control)tb_ShareSpecificListings).set_Name("tb_ShareSpecificListings");
		((Control)tb_ShareSpecificListings).set_Size(new Size(417, 36));
		tb_ShareSpecificListings.Style = MetroColorStyle.Brown;
		((Control)tb_ShareSpecificListings).set_TabIndex(110);
		((Control)tb_ShareSpecificListings).set_Text("Michael Kors, Handbag, Bag, Tote (Comma Seperated)");
		tb_ShareSpecificListings.UseStyleColors = true;
		((Control)label_delayInListings).set_AutoSize(true);
		((Control)label_delayInListings).set_Dock((DockStyle)5);
		((Control)label_delayInListings).set_Location(new Point(3, 210));
		((Control)label_delayInListings).set_Name("label_delayInListings");
		((Control)label_delayInListings).set_Size(new Size(417, 42));
		label_delayInListings.Style = MetroColorStyle.Brown;
		((Control)label_delayInListings).set_TabIndex(107);
		((Control)label_delayInListings).set_Text("Delay in listings");
		label_delayInListings.UseStyleColors = true;
		((Control)label_DelayAfterLoops).set_AutoSize(true);
		((Control)label_DelayAfterLoops).set_Dock((DockStyle)5);
		((Control)label_DelayAfterLoops).set_Location(new Point(3, 168));
		((Control)label_DelayAfterLoops).set_Name("label_DelayAfterLoops");
		((Control)label_DelayAfterLoops).set_Size(new Size(417, 42));
		label_DelayAfterLoops.Style = MetroColorStyle.Brown;
		((Control)label_DelayAfterLoops).set_TabIndex(106);
		((Control)label_DelayAfterLoops).set_Text("Delay after loops");
		label_DelayAfterLoops.UseStyleColors = true;
		((Control)label_QuantityofListings).set_AutoSize(true);
		((Control)label_QuantityofListings).set_Dock((DockStyle)5);
		((Control)label_QuantityofListings).set_Location(new Point(3, 126));
		((Control)label_QuantityofListings).set_Name("label_QuantityofListings");
		((Control)label_QuantityofListings).set_Size(new Size(417, 42));
		label_QuantityofListings.Style = MetroColorStyle.Brown;
		((Control)label_QuantityofListings).set_TabIndex(105);
		((Control)label_QuantityofListings).set_Text("Quantity of Listings");
		label_QuantityofListings.UseStyleColors = true;
		((Control)label_QuantityofLoops).set_AutoSize(true);
		((Control)label_QuantityofLoops).set_Dock((DockStyle)5);
		((Control)label_QuantityofLoops).set_Location(new Point(3, 84));
		((Control)label_QuantityofLoops).set_Name("label_QuantityofLoops");
		((Control)label_QuantityofLoops).set_Size(new Size(417, 42));
		label_QuantityofLoops.Style = MetroColorStyle.Brown;
		((Control)label_QuantityofLoops).set_TabIndex(104);
		((Control)label_QuantityofLoops).set_Text("Quantity of loops");
		label_QuantityofLoops.UseStyleColors = true;
		((Control)label_QuantityofLoops).add_Click((EventHandler)metroLabel2_Click);
		((Control)tb_delayInListings).set_Dock((DockStyle)5);
		((Control)tb_delayInListings).set_Location(new Point(426, 213));
		((Control)tb_delayInListings).set_Name("tb_delayInListings");
		((Control)tb_delayInListings).set_Size(new Size(417, 36));
		tb_delayInListings.Style = MetroColorStyle.Brown;
		((Control)tb_delayInListings).set_TabIndex(102);
		((Control)tb_delayInListings).set_Text("3,7");
		tb_delayInListings.UseStyleColors = true;
		((Control)tb_delayInListings).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)tb_DelayAfterLoops).set_Dock((DockStyle)5);
		((Control)tb_DelayAfterLoops).set_Location(new Point(426, 171));
		tb_DelayAfterLoops.Multiline = true;
		((Control)tb_DelayAfterLoops).set_Name("tb_DelayAfterLoops");
		((Control)tb_DelayAfterLoops).set_Size(new Size(417, 36));
		tb_DelayAfterLoops.Style = MetroColorStyle.Brown;
		((Control)tb_DelayAfterLoops).set_TabIndex(101);
		((Control)tb_DelayAfterLoops).set_Text("3,7");
		tb_DelayAfterLoops.UseStyleColors = true;
		((Control)tb_DelayAfterLoops).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)tb_QuantityofListings).set_Dock((DockStyle)5);
		((Control)tb_QuantityofListings).set_Location(new Point(426, 129));
		((Control)tb_QuantityofListings).set_Name("tb_QuantityofListings");
		((Control)tb_QuantityofListings).set_Size(new Size(417, 36));
		tb_QuantityofListings.Style = MetroColorStyle.Brown;
		((Control)tb_QuantityofListings).set_TabIndex(100);
		((Control)tb_QuantityofListings).set_Text("100");
		tb_QuantityofListings.UseStyleColors = true;
		((Control)tb_QuantityofListings).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)tb_QuantityofLoops).set_Dock((DockStyle)5);
		((Control)tb_QuantityofLoops).set_Location(new Point(426, 87));
		((Control)tb_QuantityofLoops).set_Name("tb_QuantityofLoops");
		((Control)tb_QuantityofLoops).set_Size(new Size(417, 36));
		tb_QuantityofLoops.Style = MetroColorStyle.Brown;
		((Control)tb_QuantityofLoops).set_TabIndex(99);
		((Control)tb_QuantityofLoops).set_Text("3");
		tb_QuantityofLoops.UseStyleColors = true;
		((Control)tb_QuantityofLoops).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)tb_Closet_name).set_Dock((DockStyle)5);
		((Control)tb_Closet_name).set_Location(new Point(426, 45));
		((Control)tb_Closet_name).set_Name("tb_Closet_name");
		((Control)tb_Closet_name).set_Size(new Size(417, 36));
		tb_Closet_name.Style = MetroColorStyle.Brown;
		((Control)tb_Closet_name).set_TabIndex(98);
		((Control)tb_Closet_name).set_Text("closetname");
		tb_Closet_name.UseStyleColors = true;
		((Control)label_ShareSpecificListing).set_AutoSize(true);
		((Control)label_ShareSpecificListing).set_Dock((DockStyle)5);
		((Control)label_ShareSpecificListing).set_ForeColor(Color.FromArgb(128, 64, 0));
		((Control)label_ShareSpecificListing).set_Location(new Point(3, 252));
		((Control)label_ShareSpecificListing).set_Name("label_ShareSpecificListing");
		((Control)label_ShareSpecificListing).set_Size(new Size(417, 42));
		((Control)label_ShareSpecificListing).set_TabIndex(115);
		((Control)label_ShareSpecificListing).set_Text("Share Specific Listings From My Closet");
		((Control)label_sharebackX).set_AutoSize(true);
		((Control)label_sharebackX).set_Dock((DockStyle)5);
		((Control)label_sharebackX).set_ForeColor(Color.FromArgb(128, 64, 0));
		((Control)label_sharebackX).set_Location(new Point(3, 294));
		((Control)label_sharebackX).set_Name("label_sharebackX");
		((Control)label_sharebackX).set_Size(new Size(417, 42));
		((Control)label_sharebackX).set_TabIndex(116);
		((Control)label_sharebackX).set_Text("Share back the last [X] closets who shared my listings, and share back [X] of their listings each.");
		((Control)label_shareNewPoshers).set_AutoSize(true);
		((Control)label_shareNewPoshers).set_Dock((DockStyle)5);
		((Control)label_shareNewPoshers).set_ForeColor(Color.FromArgb(128, 64, 0));
		((Control)label_shareNewPoshers).set_Location(new Point(3, 336));
		((Control)label_shareNewPoshers).set_Name("label_shareNewPoshers");
		((Control)label_shareNewPoshers).set_Size(new Size(417, 42));
		((Control)label_shareNewPoshers).set_TabIndex(117);
		((Control)label_shareNewPoshers).set_Text("Share [X] New Posher [X] Listings");
		((Control)tableLayoutPanel1).set_AutoSize(true);
		tableLayoutPanel1.set_ColumnCount(2);
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel1.get_Controls().Add((Control)(object)cb_ShareClosetinReverse, 1, 1);
		tableLayoutPanel1.get_Controls().Add((Control)(object)button_Set, 1, 12);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_QuantityFollow, 1, 11);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tlb_ShareNewPoshers, 1, 9);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_QuantityFollow, 0, 11);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_shareNewPoshers, 0, 9);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tlb_shareBackX, 1, 8);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_DelayFollow, 0, 10);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_Closet_name, 1, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_QuantityofLoops, 0, 3);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_QuantityofLoops, 1, 3);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_sharebackX, 0, 8);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_QuantityofListings, 0, 4);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_ShareSpecificListing, 0, 7);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_QuantityofListings, 1, 4);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_DelayAfterLoops, 0, 5);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_ShareSpecificListings, 1, 7);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_delayInListings, 0, 6);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_delayInListings, 1, 6);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_DelayFollow, 1, 10);
		tableLayoutPanel1.get_Controls().Add((Control)(object)tb_DelayAfterLoops, 1, 5);
		tableLayoutPanel1.get_Controls().Add((Control)(object)button_Cancel, 0, 12);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_ClosetName, 0, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_ShareClosetinReverse, 0, 1);
		tableLayoutPanel1.get_Controls().Add((Control)(object)cb_ShareToParty, 1, 0);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label_ShareToParty, 0, 0);
		((Control)tableLayoutPanel1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel1).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel1).set_Name("tableLayoutPanel1");
		tableLayoutPanel1.set_RowCount(14);
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle());
		((Control)tableLayoutPanel1).set_Size(new Size(846, 531));
		((Control)tableLayoutPanel1).set_TabIndex(120);
		((Control)cb_ShareClosetinReverse).set_AutoSize(true);
		((CheckBox)cb_ShareClosetinReverse).set_Checked(true);
		((CheckBox)cb_ShareClosetinReverse).set_CheckState((CheckState)1);
		((Control)cb_ShareClosetinReverse).set_Location(new Point(426, 24));
		((Control)cb_ShareClosetinReverse).set_Name("cb_ShareClosetinReverse");
		((Control)cb_ShareClosetinReverse).set_Size(new Size(32, 15));
		cb_ShareClosetinReverse.Style = MetroColorStyle.Brown;
		((Control)cb_ShareClosetinReverse).set_TabIndex(131);
		((Control)cb_ShareClosetinReverse).set_Text("   ");
		cb_ShareClosetinReverse.UseStyleColors = true;
		((ButtonBase)cb_ShareClosetinReverse).set_UseVisualStyleBackColor(true);
		((Control)button_Set).set_Dock((DockStyle)3);
		((Control)button_Set).set_Location(new Point(426, 473));
		((Control)button_Set).set_Name("button_Set");
		((Control)button_Set).set_Size(new Size(75, 55));
		((Control)button_Set).set_TabIndex(126);
		((Control)button_Set).set_Text("Set");
		((ButtonBase)button_Set).set_UseVisualStyleBackColor(true);
		((Control)button_Set).add_Click((EventHandler)button_Set_Click);
		((Control)tb_QuantityFollow).set_Dock((DockStyle)5);
		((Control)tb_QuantityFollow).set_ForeColor(Color.LightGray);
		((Control)tb_QuantityFollow).set_Location(new Point(426, 423));
		((Control)tb_QuantityFollow).set_Name("tb_QuantityFollow");
		((Control)tb_QuantityFollow).set_Size(new Size(417, 44));
		tb_QuantityFollow.Style = MetroColorStyle.Brown;
		((Control)tb_QuantityFollow).set_TabIndex(124);
		((Control)tb_QuantityFollow).set_Text("300");
		tb_QuantityFollow.UseStyleColors = true;
		((Control)tb_QuantityFollow).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		tlb_ShareNewPoshers.set_ColumnCount(2);
		tlb_ShareNewPoshers.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tlb_ShareNewPoshers.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 192f));
		tlb_ShareNewPoshers.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tlb_ShareNewPoshers.get_Controls().Add((Control)(object)tb_shareNewPosher_x, 0, 0);
		tlb_ShareNewPoshers.get_Controls().Add((Control)(object)tb_shareNewPosher, 0, 0);
		((Control)tlb_ShareNewPoshers).set_Dock((DockStyle)5);
		((Control)tlb_ShareNewPoshers).set_Location(new Point(426, 339));
		((Control)tlb_ShareNewPoshers).set_Name("tlb_ShareNewPoshers");
		tlb_ShareNewPoshers.set_RowCount(1);
		tlb_ShareNewPoshers.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tlb_ShareNewPoshers).set_Size(new Size(417, 36));
		((Control)tlb_ShareNewPoshers).set_TabIndex(122);
		((Control)tb_shareNewPosher).set_Dock((DockStyle)5);
		((Control)tb_shareNewPosher).set_ForeColor(Color.LightGray);
		((Control)tb_shareNewPosher).set_Location(new Point(3, 3));
		((Control)tb_shareNewPosher).set_Name("tb_shareNewPosher");
		((Control)tb_shareNewPosher).set_Size(new Size(219, 30));
		tb_shareNewPosher.Style = MetroColorStyle.Brown;
		((Control)tb_shareNewPosher).set_TabIndex(111);
		((Control)tb_shareNewPosher).set_Text("2");
		tb_shareNewPosher.UseStyleColors = true;
		((Control)tb_shareNewPosher).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)label_QuantityFollow).set_AutoSize(true);
		((Control)label_QuantityFollow).set_Dock((DockStyle)5);
		((Control)label_QuantityFollow).set_Location(new Point(3, 420));
		((Control)label_QuantityFollow).set_Name("label_QuantityFollow");
		((Control)label_QuantityFollow).set_Size(new Size(417, 50));
		label_QuantityFollow.Style = MetroColorStyle.Brown;
		((Control)label_QuantityFollow).set_TabIndex(123);
		((Control)label_QuantityFollow).set_Text("Quantity of follow and unfollow");
		label_QuantityFollow.UseStyleColors = true;
		tlb_shareBackX.set_ColumnCount(2);
		tlb_shareBackX.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tlb_shareBackX.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 210f));
		tlb_shareBackX.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tlb_shareBackX.get_Controls().Add((Control)(object)tb_shareBackLast_x, 0, 0);
		tlb_shareBackX.get_Controls().Add((Control)(object)tb_shareBackLast, 0, 0);
		((Control)tlb_shareBackX).set_Dock((DockStyle)5);
		((Control)tlb_shareBackX).set_Location(new Point(426, 297));
		((Control)tlb_shareBackX).set_Name("tlb_shareBackX");
		tlb_shareBackX.set_RowCount(1);
		tlb_shareBackX.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tlb_shareBackX.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tlb_shareBackX).set_Size(new Size(417, 36));
		((Control)tlb_shareBackX).set_TabIndex(121);
		((Control)label_DelayFollow).set_AutoSize(true);
		((Control)label_DelayFollow).set_Dock((DockStyle)5);
		((Control)label_DelayFollow).set_Location(new Point(3, 378));
		((Control)label_DelayFollow).set_Name("label_DelayFollow");
		((Control)label_DelayFollow).set_Size(new Size(417, 42));
		label_DelayFollow.Style = MetroColorStyle.Brown;
		((Control)label_DelayFollow).set_TabIndex(121);
		((Control)label_DelayFollow).set_Text("Dealy Between Follow/Unfollow");
		label_DelayFollow.UseStyleColors = true;
		((Control)label_DelayFollow).add_Click((EventHandler)label12_Click);
		((Control)tb_DelayFollow).set_Dock((DockStyle)5);
		((Control)tb_DelayFollow).set_ForeColor(Color.LightGray);
		((Control)tb_DelayFollow).set_Location(new Point(426, 381));
		((Control)tb_DelayFollow).set_Name("tb_DelayFollow");
		((Control)tb_DelayFollow).set_Size(new Size(417, 36));
		tb_DelayFollow.Style = MetroColorStyle.Brown;
		((Control)tb_DelayFollow).set_TabIndex(122);
		((Control)tb_DelayFollow).set_Text("5,9");
		tb_DelayFollow.UseStyleColors = true;
		((Control)tb_DelayFollow).add_KeyPress(new KeyPressEventHandler(tb_QuantityofLoops_KeyPress));
		((Control)button_Cancel).set_Dock((DockStyle)4);
		((Control)button_Cancel).set_Location(new Point(345, 473));
		((Control)button_Cancel).set_Name("button_Cancel");
		((Control)button_Cancel).set_Size(new Size(75, 55));
		((Control)button_Cancel).set_TabIndex(125);
		((Control)button_Cancel).set_Text("Cancel");
		((ButtonBase)button_Cancel).set_UseVisualStyleBackColor(true);
		((Control)button_Cancel).add_Click((EventHandler)button_Cancel_Click);
		((Control)label_ClosetName).set_AutoSize(true);
		((Control)label_ClosetName).set_Location(new Point(3, 42));
		((Control)label_ClosetName).set_Name("label_ClosetName");
		((Control)label_ClosetName).set_Size(new Size(143, 19));
		label_ClosetName.Style = MetroColorStyle.Brown;
		((Control)label_ClosetName).set_TabIndex(127);
		((Control)label_ClosetName).set_Text("Poshmark Closet name");
		label_ClosetName.UseStyleColors = true;
		((Control)label_ShareClosetinReverse).set_AutoSize(true);
		((Control)label_ShareClosetinReverse).set_Location(new Point(3, 21));
		((Control)label_ShareClosetinReverse).set_Name("label_ShareClosetinReverse");
		((Control)label_ShareClosetinReverse).set_Size(new Size(167, 19));
		label_ShareClosetinReverse.Style = MetroColorStyle.Brown;
		((Control)label_ShareClosetinReverse).set_TabIndex(128);
		((Control)label_ShareClosetinReverse).set_Text("Share my Closet in Reverse");
		label_ShareClosetinReverse.UseStyleColors = true;
		((Control)cb_ShareToParty).set_AutoSize(true);
		((CheckBox)cb_ShareToParty).set_Checked(true);
		((CheckBox)cb_ShareToParty).set_CheckState((CheckState)1);
		((Control)cb_ShareToParty).set_Location(new Point(426, 3));
		((Control)cb_ShareToParty).set_Name("cb_ShareToParty");
		((Control)cb_ShareToParty).set_Size(new Size(32, 15));
		cb_ShareToParty.Style = MetroColorStyle.Brown;
		((Control)cb_ShareToParty).set_TabIndex(130);
		((Control)cb_ShareToParty).set_Text("   ");
		cb_ShareToParty.UseStyleColors = true;
		((ButtonBase)cb_ShareToParty).set_UseVisualStyleBackColor(true);
		((Control)label_ShareToParty).set_AutoSize(true);
		((Control)label_ShareToParty).set_Location(new Point(3, 0));
		((Control)label_ShareToParty).set_Name("label_ShareToParty");
		((Control)label_ShareToParty).set_Size(new Size(93, 19));
		label_ShareToParty.Style = MetroColorStyle.Brown;
		((Control)label_ShareToParty).set_TabIndex(132);
		((Control)label_ShareToParty).set_Text("Share To Party");
		label_ShareToParty.UseStyleColors = true;
		((Control)tb_shareBackLast_x).set_Dock((DockStyle)5);
		((Control)tb_shareBackLast_x).set_ForeColor(Color.LightGray);
		((Control)tb_shareBackLast_x).set_Location(new Point(210, 3));
		((Control)tb_shareBackLast_x).set_Name("tb_shareBackLast_x");
		((Control)tb_shareBackLast_x).set_Size(new Size(204, 30));
		tb_shareBackLast_x.Style = MetroColorStyle.Brown;
		((Control)tb_shareBackLast_x).set_TabIndex(112);
		((Control)tb_shareBackLast_x).set_Text("5");
		tb_shareBackLast_x.UseStyleColors = true;
		((Control)tb_shareNewPosher_x).set_Dock((DockStyle)5);
		((Control)tb_shareNewPosher_x).set_ForeColor(Color.LightGray);
		((Control)tb_shareNewPosher_x).set_Location(new Point(228, 3));
		((Control)tb_shareNewPosher_x).set_Name("tb_shareNewPosher_x");
		((Control)tb_shareNewPosher_x).set_Size(new Size(186, 30));
		tb_shareNewPosher_x.Style = MetroColorStyle.Brown;
		((Control)tb_shareNewPosher_x).set_TabIndex(112);
		((Control)tb_shareNewPosher_x).set_Text("5");
		tb_shareNewPosher_x.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Control)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(846, 531));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel1);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Name("EditSchdParameters");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Schedules Setup");
		((Control)tableLayoutPanel1).ResumeLayout(false);
		((Control)tableLayoutPanel1).PerformLayout();
		((Control)tlb_ShareNewPoshers).ResumeLayout(false);
		((Control)tlb_shareBackX).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
