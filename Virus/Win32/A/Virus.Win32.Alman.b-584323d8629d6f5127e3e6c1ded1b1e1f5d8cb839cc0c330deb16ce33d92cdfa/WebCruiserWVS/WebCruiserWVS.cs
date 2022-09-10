using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WebCruiserWVS;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class WebCruiserWVS : ApplicationSettingsBase
{
	private static WebCruiserWVS defaultInstance = (WebCruiserWVS)(object)SettingsBase.Synchronized((SettingsBase)(object)new WebCruiserWVS());

	public static WebCruiserWVS Default => defaultInstance;

	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	[UserScopedSetting]
	public int MaxHTTPThread
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("MaxHTTPThread");
		}
		set
		{
			((SettingsBase)this).set_Item("MaxHTTPThread", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string ProxyAddress
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ProxyAddress");
		}
		set
		{
			((SettingsBase)this).set_Item("ProxyAddress", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("8080")]
	public int ProxyPort
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("ProxyPort");
		}
		set
		{
			((SettingsBase)this).set_Item("ProxyPort", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string ProxyUsername
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ProxyUsername");
		}
		set
		{
			((SettingsBase)this).set_Item("ProxyUsername", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ProxyPassword
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ProxyPassword");
		}
		set
		{
			((SettingsBase)this).set_Item("ProxyPassword", (object)value);
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool UseProxy
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("UseProxy");
		}
		set
		{
			((SettingsBase)this).set_Item("UseProxy", (object)value);
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool chkReplace1
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("chkReplace1");
		}
		set
		{
			((SettingsBase)this).set_Item("chkReplace1", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("%20")]
	public string FiltExpr1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("FiltExpr1");
		}
		set
		{
			((SettingsBase)this).set_Item("FiltExpr1", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("/**/")]
	[DebuggerNonUserCode]
	public string RepExpr1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("RepExpr1");
		}
		set
		{
			((SettingsBase)this).set_Item("RepExpr1", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool chkReplace2
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("chkReplace2");
		}
		set
		{
			((SettingsBase)this).set_Item("chkReplace2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("%27")]
	public string FiltExpr2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("FiltExpr2");
		}
		set
		{
			((SettingsBase)this).set_Item("FiltExpr2", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("%2527")]
	[DebuggerNonUserCode]
	public string RepExpr2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("RepExpr2");
		}
		set
		{
			((SettingsBase)this).set_Item("RepExpr2", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool chkReplace3
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("chkReplace3");
		}
		set
		{
			((SettingsBase)this).set_Item("chkReplace3", (object)value);
		}
	}

	[DefaultSettingValue("select")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string FiltExpr3
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("FiltExpr3");
		}
		set
		{
			((SettingsBase)this).set_Item("FiltExpr3", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("SeLselecteCt")]
	public string RepExpr3
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("RepExpr3");
		}
		set
		{
			((SettingsBase)this).set_Item("RepExpr3", (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int SecondsDelay
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("SecondsDelay");
		}
		set
		{
			((SettingsBase)this).set_Item("SecondsDelay", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Standard")]
	[UserScopedSetting]
	public string Edition
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Edition");
		}
		set
		{
			((SettingsBase)this).set_Item("Edition", (object)value);
		}
	}

	[DefaultSettingValue("5")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ScanDepth
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("ScanDepth");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanDepth", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("htm:html:shtml:asp:aspx:jsp:php:do:cfm:cgi:pl:txt:action:js")]
	public string CrawlableExt
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("CrawlableExt");
		}
		set
		{
			((SettingsBase)this).set_Item("CrawlableExt", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Mozilla/4.0")]
	[UserScopedSetting]
	public string UserAgent
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("UserAgent");
		}
		set
		{
			((SettingsBase)this).set_Item("UserAgent", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("UnRegistered")]
	public string RegisterInfo
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("RegisterInfo");
		}
		set
		{
			((SettingsBase)this).set_Item("RegisterInfo", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1900-01-01")]
	public DateTime InitDate
	{
		get
		{
			return (DateTime)((SettingsBase)this).get_Item("InitDate");
		}
		set
		{
			((SettingsBase)this).set_Item("InitDate", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("admin:admins:admin_login:adm:Dv_admin:Superuser:sys:sysadmin:sysadmins:System:sysuser:sysusers:account:accounts:admin_name:admin_user:admin_userinfo:administrator:administrators:adminuser:BBS:cms_admin:cms_admins:cms_user:cms_users:company:config:Contact:content:customer:customers:dbadmins:group:guanli:guanliyuan:info:key:keywords:login:logon:logs:m_admin:main:manage:manager:member:memberlist:members:name:names:reg_user:reg_users:reguser:regusers:root:roots:session:setting:settings:site_login:site_logins:sitelogin:sitelogins:Subjects:tb_admin:tb_administrator:tb_login:tb_member:tb_members:tb_user:tbl_user:tbl_users:tbladmins:tblUser:test:user:user_admin:user_login:user_name:userinfo:users:usr:vip:WebAdmin:webadmins:Webmaster:webmasters:webuser:webusers")]
	public string AccessTables
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("AccessTables");
		}
		set
		{
			((SettingsBase)this).set_Item("AccessTables", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("id:uid:user:username:password:access:account:accounts:admin_id:admin_name:admin_pass:admin_passwd:admin_password:admin_psw:admin_pwd:admin_user:admin_userid:admin_username:adminemail:adminid:administrator_name:adminlogin:adminmail:adminname:adminpass:adminpassword:adminpsw:adminpwd:AdminUID:adminuser:adminuserid:adminusername:address:ArticleID:cid:city:client:clientname:clientpassword:clients:clientusername:content:customer:customers:customers_password:data:db_hostname:db_password:db_username:dw:E-mail:e_mail:email:emailaddress:group:hash:index:isadmin:key:keywords:last_login:lastname:log:login:login_admin:login_name:login_pass:login_passwd:login_password:login_pw:login_pwd:login_user:login_username:mail:md5hash:member_id:member_name:memberid:membername:mempassword:name:newsid:number:pass:pass1word:pass_hash:pass_word:passwd:phone:POWER:pwd:pwd1:pword:sid:telephone:temp_pass:temp_password:temppass:temppasword:text:uname:user1:user_admin:user_email:user_id:user_ip:user_level:user_login:user_name:user_pass:user_passw:user_passwd:user_password:user_pw:user_pwd:user_pword:user_pwrd:user_uname:user_username:user_usernm:user_usernun:user_usrnm:useradmin:userid:userip:Userlogin:usernm:userpass:userpasswd:userPassword:userpw:userpwd:usr_name:usr_nusr:usr_pass:usr_pw:usrname:usrpass:usrs")]
	public string AccessColumns
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("AccessColumns");
		}
		set
		{
			((SettingsBase)this).set_Item("AccessColumns", (object)value);
		}
	}

	[DefaultSettingValue("admin/:admin_login/:admin/login/:adm/:adm_login/:admin/manage/:aadmin/:ad/:ad_login/:ad_manage/:forum/admin/:admin/default/:admin/index/:admin1/:admin123/:admin888/:admin_admin/:admin_index/:admin_main/:admin_user/:adminadmin/:adminindex/:administrator/:adminlogin/:adminmember/:adminuser/:adminuserlogin/:bbs/admin/login/:chkadmin/:chklogin/:config/:database/:databases/:db/:denglu/:devel/:guanli/:houtai/:houtaiguanli/:htgl/:idea/:ideas/:index_admin/:index_manage/:indexadmin/:login/login/:login/super/:login1/:login_admin/:main/login/:manage/:manage_index/:manager/:manager/login/:private/:root/:secret/:secrets/:setting/:setup/:super/:superadmin/:sys_admin/:webadmin/:webmaster/")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string AdminPath
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("AdminPath");
		}
		set
		{
			((SettingsBase)this).set_Item("AdminPath", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("index:admin_login:admin_main:ad_login:ad_manage:adm_login:admin123:admin1:admin888:admin_admin:admin_edit:admin_index:admin_user:admindefault:adminindex:administrator:adminlogin:adminmanage:adminmember:adminuserlogin:adminuser:admin:ad:chkadmin:chklogin:config:conn:default:denglu:guanli:houtaiguanli:houtai:htgl:index_admin:index_manage:index:login_admin:login:main:manage_index:manager:manage")]
	[UserScopedSetting]
	public string AdminPage
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("AdminPage");
		}
		set
		{
			((SettingsBase)this).set_Item("AdminPage", (object)value);
		}
	}

	[DefaultSettingValue("3")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int MultiSitesNum
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("MultiSitesNum");
		}
		set
		{
			((SettingsBase)this).set_Item("MultiSitesNum", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("http://sec4app.com/test/info.php?id=")]
	[DebuggerNonUserCode]
	public string CrossSiteURL
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("CrossSiteURL");
		}
		set
		{
			((SettingsBase)this).set_Item("CrossSiteURL", (object)value);
		}
	}

	[DefaultSettingValue("http://sec4app.com/test/info.txt")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string CrossSiteRecord
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("CrossSiteRecord");
		}
		set
		{
			((SettingsBase)this).set_Item("CrossSiteRecord", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ScanSQLInjection
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ScanSQLInjection");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanSQLInjection", (object)value);
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool ScanXSS
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ScanXSS");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanXSS", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool ScanXPathInjection
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ScanXPathInjection");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanXPathInjection", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool ScanURLSQL
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ScanURLSQL");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanURLSQL", (object)value);
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool ScanPostSQL
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ScanPostSQL");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanPostSQL", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool ScanCookieSQL
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ScanCookieSQL");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanCookieSQL", (object)value);
		}
	}
}
