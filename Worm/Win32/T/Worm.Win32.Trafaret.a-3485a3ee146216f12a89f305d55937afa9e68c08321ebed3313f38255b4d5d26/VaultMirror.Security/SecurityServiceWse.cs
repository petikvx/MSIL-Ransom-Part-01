using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using Microsoft.Web.Services3;

namespace VaultMirror.Security;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[XmlInclude(typeof(SecRestric[]))]
[DesignerCategory("code")]
[WebServiceBinding(Name = "SecurityServiceSoap", Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
[DebuggerStepThrough]
public class SecurityServiceWse : WebServicesClientProtocol
{
	private SecurityHeader securityHeaderValueField;

	private SendOrPostCallback SignInOperationCompleted;

	private SendOrPostCallback SignIn2OperationCompleted;

	private SendOrPostCallback SignOutOperationCompleted;

	private SendOrPostCallback GetACLsByEntityIdsOperationCompleted;

	private SendOrPostCallback UpdateACLOperationCompleted;

	private SendOrPostCallback GetACLUpdateRestrictionsOperationCompleted;

	private SendOrPostCallback GetAllAccessPermissionsAndGroupsOperationCompleted;

	private bool useDefaultCredentialsSetExplicitly;

	public SecurityHeader SecurityHeaderValue
	{
		get
		{
			return securityHeaderValueField;
		}
		set
		{
			securityHeaderValueField = value;
		}
	}

	public string Url
	{
		get
		{
			return ((WebServicesClientProtocol)this).get_Url();
		}
		set
		{
			if (IsLocalFileSystemWebService(((WebServicesClientProtocol)this).get_Url()) && !useDefaultCredentialsSetExplicitly && !IsLocalFileSystemWebService(value))
			{
				((WebServicesClientProtocol)this).set_UseDefaultCredentials(false);
			}
			((WebServicesClientProtocol)this).set_Url(value);
		}
	}

	public bool UseDefaultCredentials
	{
		get
		{
			return ((WebServicesClientProtocol)this).get_UseDefaultCredentials();
		}
		set
		{
			((WebServicesClientProtocol)this).set_UseDefaultCredentials(value);
			useDefaultCredentialsSetExplicitly = true;
		}
	}

	public event SignInCompletedEventHandler SignInCompleted;

	public event SignIn2CompletedEventHandler SignIn2Completed;

	public event SignOutCompletedEventHandler SignOutCompleted;

	public event GetACLsByEntityIdsCompletedEventHandler GetACLsByEntityIdsCompleted;

	public event UpdateACLCompletedEventHandler UpdateACLCompleted;

	public event GetACLUpdateRestrictionsCompletedEventHandler GetACLUpdateRestrictionsCompleted;

	public event GetAllAccessPermissionsAndGroupsCompletedEventHandler GetAllAccessPermissionsAndGroupsCompleted;

	public SecurityServiceWse()
	{
		Url = "http://localhost/AutodeskDM/Services/SecurityService.asmx";
		if (IsLocalFileSystemWebService(Url))
		{
			UseDefaultCredentials = true;
			useDefaultCredentialsSetExplicitly = false;
		}
		else
		{
			useDefaultCredentialsSetExplicitly = true;
		}
	}

	[SoapHeader(/*Could not decode attribute arguments.*/)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SignIn(string userName, string userPassword, string knowledgeVault)
	{
		((SoapHttpClientProtocol)this).Invoke("SignIn", new object[3] { userName, userPassword, knowledgeVault });
	}

	public void SignInAsync(string userName, string userPassword, string knowledgeVault)
	{
		SignInAsync(userName, userPassword, knowledgeVault, null);
	}

	public void SignInAsync(string userName, string userPassword, string knowledgeVault, object userState)
	{
		if (SignInOperationCompleted == null)
		{
			SignInOperationCompleted = OnSignInOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SignIn", new object[3] { userName, userPassword, knowledgeVault }, SignInOperationCompleted, userState);
	}

	private void OnSignInOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SignInCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SignInCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader(/*Could not decode attribute arguments.*/)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SignIn2(string userName, string userPassword)
	{
		((SoapHttpClientProtocol)this).Invoke("SignIn2", new object[2] { userName, userPassword });
	}

	public void SignIn2Async(string userName, string userPassword)
	{
		SignIn2Async(userName, userPassword, null);
	}

	public void SignIn2Async(string userName, string userPassword, object userState)
	{
		if (SignIn2OperationCompleted == null)
		{
			SignIn2OperationCompleted = OnSignIn2OperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SignIn2", new object[2] { userName, userPassword }, SignIn2OperationCompleted, userState);
	}

	private void OnSignIn2OperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SignIn2Completed != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SignIn2Completed(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader(/*Could not decode attribute arguments.*/)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SignOut()
	{
		((SoapHttpClientProtocol)this).Invoke("SignOut", new object[0]);
	}

	public void SignOutAsync()
	{
		SignOutAsync(null);
	}

	public void SignOutAsync(object userState)
	{
		if (SignOutOperationCompleted == null)
		{
			SignOutOperationCompleted = OnSignOutOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SignOut", new object[0], SignOutOperationCompleted, userState);
	}

	private void OnSignOutOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SignOutCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SignOutCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public ACL[] GetACLsByEntityIds(long[] entityIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetACLsByEntityIds", new object[1] { entityIds });
		return (ACL[])array[0];
	}

	public void GetACLsByEntityIdsAsync(long[] entityIds)
	{
		GetACLsByEntityIdsAsync(entityIds, null);
	}

	public void GetACLsByEntityIdsAsync(long[] entityIds, object userState)
	{
		if (GetACLsByEntityIdsOperationCompleted == null)
		{
			GetACLsByEntityIdsOperationCompleted = OnGetACLsByEntityIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetACLsByEntityIds", new object[1] { entityIds }, GetACLsByEntityIdsOperationCompleted, userState);
	}

	private void OnGetACLsByEntityIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetACLsByEntityIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetACLsByEntityIdsCompleted(this, new GetACLsByEntityIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public ACL UpdateACL(long entityId, ACE[] entries)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("UpdateACL", new object[2] { entityId, entries });
		return (ACL)array[0];
	}

	public void UpdateACLAsync(long entityId, ACE[] entries)
	{
		UpdateACLAsync(entityId, entries, null);
	}

	public void UpdateACLAsync(long entityId, ACE[] entries, object userState)
	{
		if (UpdateACLOperationCompleted == null)
		{
			UpdateACLOperationCompleted = OnUpdateACLOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdateACL", new object[2] { entityId, entries }, UpdateACLOperationCompleted, userState);
	}

	private void OnUpdateACLOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdateACLCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdateACLCompleted(this, new UpdateACLCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public SecRestric[] GetACLUpdateRestrictions(long entityId, ACE[] entries)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetACLUpdateRestrictions", new object[2] { entityId, entries });
		return (SecRestric[])array[0];
	}

	public void GetACLUpdateRestrictionsAsync(long entityId, ACE[] entries)
	{
		GetACLUpdateRestrictionsAsync(entityId, entries, null);
	}

	public void GetACLUpdateRestrictionsAsync(long entityId, ACE[] entries, object userState)
	{
		if (GetACLUpdateRestrictionsOperationCompleted == null)
		{
			GetACLUpdateRestrictionsOperationCompleted = OnGetACLUpdateRestrictionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetACLUpdateRestrictions", new object[2] { entityId, entries }, GetACLUpdateRestrictionsOperationCompleted, userState);
	}

	private void OnGetACLUpdateRestrictionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetACLUpdateRestrictionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetACLUpdateRestrictionsCompleted(this, new GetACLUpdateRestrictionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public AccessPermisAndGrp GetAllAccessPermissionsAndGroups()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAllAccessPermissionsAndGroups", new object[0]);
		return (AccessPermisAndGrp)array[0];
	}

	public void GetAllAccessPermissionsAndGroupsAsync()
	{
		GetAllAccessPermissionsAndGroupsAsync(null);
	}

	public void GetAllAccessPermissionsAndGroupsAsync(object userState)
	{
		if (GetAllAccessPermissionsAndGroupsOperationCompleted == null)
		{
			GetAllAccessPermissionsAndGroupsOperationCompleted = OnGetAllAccessPermissionsAndGroupsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAllAccessPermissionsAndGroups", new object[0], GetAllAccessPermissionsAndGroupsOperationCompleted, userState);
	}

	private void OnGetAllAccessPermissionsAndGroupsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAllAccessPermissionsAndGroupsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAllAccessPermissionsAndGroupsCompleted(this, new GetAllAccessPermissionsAndGroupsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	public void CancelAsync(object userState)
	{
		((HttpWebClientProtocol)this).CancelAsync(userState);
	}

	private bool IsLocalFileSystemWebService(string url)
	{
		if (url != null && !(url == string.Empty))
		{
			Uri uri = new Uri(url);
			if (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}
}
