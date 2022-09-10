using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using Microsoft.Web.Services3;

namespace VaultMirror.Document;

[WebServiceBinding(Name = "DocumentServiceSoap", Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class DocumentServiceWse : WebServicesClientProtocol
{
	private SecurityHeader securityHeaderValueField;

	private SendOrPostCallback GetFolderRootOperationCompleted;

	private SendOrPostCallback GetFolderByPathOperationCompleted;

	private SendOrPostCallback GetFoldersByPathsOperationCompleted;

	private SendOrPostCallback FindFoldersByPathsOperationCompleted;

	private SendOrPostCallback GetFolderByIdOperationCompleted;

	private SendOrPostCallback GetFoldersByIdsOperationCompleted;

	private SendOrPostCallback FindFoldersByIdsOperationCompleted;

	private SendOrPostCallback GetFoldersByParentIdOperationCompleted;

	private SendOrPostCallback GetFoldersByParentIdsOperationCompleted;

	private SendOrPostCallback GetFoldersByFileMasterIdOperationCompleted;

	private SendOrPostCallback GetFoldersByFileMasterIdsOperationCompleted;

	private SendOrPostCallback AddFolderOperationCompleted;

	private SendOrPostCallback DeleteFolderHierarchyOperationCompleted;

	private SendOrPostCallback DeleteFolderHierarchyUnconditionalOperationCompleted;

	private SendOrPostCallback GetFolderDeleteRestrictionsByIdOperationCompleted;

	private SendOrPostCallback GetFolderDeleteRestrictionsByIdsOperationCompleted;

	private SendOrPostCallback UpdateFolderUNCPathOperationCompleted;

	private SendOrPostCallback UpdateFolderNameOperationCompleted;

	private SendOrPostCallback GetFileByIdOperationCompleted;

	private SendOrPostCallback GetFilesByIdsOperationCompleted;

	private SendOrPostCallback LockFileByMasterIdOperationCompleted;

	private SendOrPostCallback LockFilesByMasterIdsOperationCompleted;

	private SendOrPostCallback GetFileLockRestrictionsByMasterIdOperationCompleted;

	private SendOrPostCallback GetFileLockRestrictionsByMasterIdsOperationCompleted;

	private SendOrPostCallback FindLatestFilesByPathsOperationCompleted;

	private SendOrPostCallback FindFilesByPathsAndChecksumsOperationCompleted;

	private SendOrPostCallback FindFilesByFoldersNamesAndChecksumsOperationCompleted;

	private SendOrPostCallback FindFilePathsByNameAndChecksumOperationCompleted;

	private SendOrPostCallback GetLatestFilePathsByNamesOperationCompleted;

	private SendOrPostCallback GetLatestDuplicateFilePathsOperationCompleted;

	private SendOrPostCallback GetLatestFilesByFolderIdOperationCompleted;

	private SendOrPostCallback GetLatestFilesByFolderIdsOperationCompleted;

	private SendOrPostCallback GetFilesByMasterIdOperationCompleted;

	private SendOrPostCallback GetFilesByMasterIdsOperationCompleted;

	private SendOrPostCallback GetFileByVersionOperationCompleted;

	private SendOrPostCallback GetFilesByVersionsOperationCompleted;

	private SendOrPostCallback GetLatestFileByMasterIdOperationCompleted;

	private SendOrPostCallback GetLatestFilesByMasterIdsOperationCompleted;

	private SendOrPostCallback DownloadFileOperationCompleted;

	private SendOrPostCallback DownloadFilePartOperationCompleted;

	private SendOrPostCallback UploadFilePartOperationCompleted;

	private SendOrPostCallback AddFileOperationCompleted;

	private SendOrPostCallback AddUploadedFileOperationCompleted;

	private SendOrPostCallback CheckinFileOperationCompleted;

	private SendOrPostCallback CheckinUploadedFileOperationCompleted;

	private SendOrPostCallback CheckoutFileOperationCompleted;

	private SendOrPostCallback UndoCheckoutFileOperationCompleted;

	private SendOrPostCallback DeleteFileFromFolderOperationCompleted;

	private SendOrPostCallback DeleteFilesFromFolderOperationCompleted;

	private SendOrPostCallback DeleteFileFromFolderUnconditionalOperationCompleted;

	private SendOrPostCallback DeleteFilesFromFolderUnconditionalOperationCompleted;

	private SendOrPostCallback GetFileDeleteRestrictionsByMasterIdOperationCompleted;

	private SendOrPostCallback GetFileDeleteRestrictionsByMasterIdsOperationCompleted;

	private SendOrPostCallback ShareFileOperationCompleted;

	private SendOrPostCallback MoveFileOperationCompleted;

	private SendOrPostCallback GetFileAssociationRestrictionsByIdOperationCompleted;

	private SendOrPostCallback GetFileRenameRestrictionsByMasterIdOperationCompleted;

	private SendOrPostCallback GetFileRenameRestrictionsByMasterIdsOperationCompleted;

	private SendOrPostCallback FindFilesBySearchConditionsOperationCompleted;

	private SendOrPostCallback GetBOMByFileIdOperationCompleted;

	private SendOrPostCallback GetBOMByFileIdsOperationCompleted;

	private SendOrPostCallback GetAllPropertyDefinitionsOperationCompleted;

	private SendOrPostCallback GetAllPropertyDefinitionsExtendedOperationCompleted;

	private SendOrPostCallback FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesOperationCompleted;

	private SendOrPostCallback SetPropertyDefinitionDisplayNameOperationCompleted;

	private SendOrPostCallback SetPropertyDefinitionsDisplayNamesOperationCompleted;

	private SendOrPostCallback GetPropertiesOperationCompleted;

	private SendOrPostCallback FindFileFoldersBySearchConditionsOperationCompleted;

	private SendOrPostCallback GetAllPropertyGroupsOperationCompleted;

	private SendOrPostCallback AddPropertyGroupOperationCompleted;

	private SendOrPostCallback UpdatePropertyGroupOperationCompleted;

	private SendOrPostCallback UpdatePropertyGroupsOperationCompleted;

	private SendOrPostCallback DeletePropertyGroupOperationCompleted;

	private SendOrPostCallback DeletePropertyGroupsOperationCompleted;

	private SendOrPostCallback VoidPropertyDefinitionsOperationCompleted;

	private SendOrPostCallback UnvoidPropertyDefinitionsOperationCompleted;

	private SendOrPostCallback ReIndexPropertiesOperationCompleted;

	private SendOrPostCallback GetAllLabelsOperationCompleted;

	private SendOrPostCallback FindLabelByNameOperationCompleted;

	private SendOrPostCallback FindLabelsByNamesOperationCompleted;

	private SendOrPostCallback AddLabelOperationCompleted;

	private SendOrPostCallback DeleteLabelOperationCompleted;

	private SendOrPostCallback UpdateLabelOperationCompleted;

	private SendOrPostCallback GetFileFoldersByLabelIdOperationCompleted;

	private SendOrPostCallback MoveFolderOperationCompleted;

	private SendOrPostCallback GetFolderMoveRestrictionsOperationCompleted;

	private SendOrPostCallback GetFolderRenameRestrictionsOperationCompleted;

	private SendOrPostCallback GetUniqueFileNameRequiredOperationCompleted;

	private SendOrPostCallback SetUniqueFileNameRequiredOperationCompleted;

	private SendOrPostCallback GetEnableDWFAttachmentOperationCompleted;

	private SendOrPostCallback SetEnableDWFAttachmentOperationCompleted;

	private SendOrPostCallback GetDWFPublishFolderLocationOperationCompleted;

	private SendOrPostCallback SetDWFPublishFolderLocationOperationCompleted;

	private SendOrPostCallback GetDWFPublishPreserveFolderHierarchyOperationCompleted;

	private SendOrPostCallback SetDWFPublishPreserveFolderHierarchyOperationCompleted;

	private SendOrPostCallback GetEnforceWorkingFolderOperationCompleted;

	private SendOrPostCallback SetEnforceWorkingFolderOperationCompleted;

	private SendOrPostCallback GetRequiredWorkingFolderLocationOperationCompleted;

	private SendOrPostCallback SetRequiredWorkingFolderLocationOperationCompleted;

	private SendOrPostCallback GetLatestFileAssociationsByMasterIdOperationCompleted;

	private SendOrPostCallback GetLatestFileAssociationsByMasterIdsOperationCompleted;

	private SendOrPostCallback GetAssociatedFilePathsByIdOperationCompleted;

	private SendOrPostCallback GetAssociatedFilePathsByIdsOperationCompleted;

	private SendOrPostCallback GetFileAssociationsByIdOperationCompleted;

	private SendOrPostCallback GetFileAssociationsByIdsOperationCompleted;

	private SendOrPostCallback GetLatestAssociatedFilePathsByMasterIdOperationCompleted;

	private SendOrPostCallback GetLatestAssociatedFilePathsByMasterIdsOperationCompleted;

	private SendOrPostCallback ValidateBOMByFileIdOperationCompleted;

	private SendOrPostCallback GetComponentPropertiesOperationCompleted;

	private SendOrPostCallback AddComponentCustomPropertyDefinitionOperationCompleted;

	private SendOrPostCallback DeleteComponentCustomPropertyDefinitionOperationCompleted;

	private SendOrPostCallback GetFileVersionDeleteRestrictionsByMasterIdsOperationCompleted;

	private SendOrPostCallback DeleteFileVersionsByMasterIdsOperationCompleted;

	private SendOrPostCallback DeleteFileVersionsByMasterIdsUnconditionalOperationCompleted;

	private SendOrPostCallback GetTrackFileStatusOperationCompleted;

	private SendOrPostCallback SetTrackFileStatusOperationCompleted;

	private SendOrPostCallback GetFilterConfigXmlOperationCompleted;

	private SendOrPostCallback DeleteFileVersionsOperationCompleted;

	private SendOrPostCallback DeleteFileVersionsUnconditionalOperationCompleted;

	private SendOrPostCallback SetFileStatusByMasterIdOperationCompleted;

	private SendOrPostCallback SetFileStatusByMasterIdsOperationCompleted;

	private SendOrPostCallback GetFileStatusSetRestrictionsByMasterIdsOperationCompleted;

	private SendOrPostCallback GetFileVersionDeleteRestrictionsByFileIdsOperationCompleted;

	private SendOrPostCallback AddFileNamingSchemeOperationCompleted;

	private SendOrPostCallback UpdateFileNamingSchemeOperationCompleted;

	private SendOrPostCallback DeleteFileNamingSchemeOperationCompleted;

	private SendOrPostCallback SetDefaultFileNamingSchemeOperationCompleted;

	private SendOrPostCallback GetAllFileNamingSchemesOperationCompleted;

	private SendOrPostCallback ReserveFileNamingDescriptionsOperationCompleted;

	private SendOrPostCallback RollbackFileNamingDescriptionsOperationCompleted;

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

	public event GetFolderRootCompletedEventHandler GetFolderRootCompleted;

	public event GetFolderByPathCompletedEventHandler GetFolderByPathCompleted;

	public event GetFoldersByPathsCompletedEventHandler GetFoldersByPathsCompleted;

	public event FindFoldersByPathsCompletedEventHandler FindFoldersByPathsCompleted;

	public event GetFolderByIdCompletedEventHandler GetFolderByIdCompleted;

	public event GetFoldersByIdsCompletedEventHandler GetFoldersByIdsCompleted;

	public event FindFoldersByIdsCompletedEventHandler FindFoldersByIdsCompleted;

	public event GetFoldersByParentIdCompletedEventHandler GetFoldersByParentIdCompleted;

	public event GetFoldersByParentIdsCompletedEventHandler GetFoldersByParentIdsCompleted;

	public event GetFoldersByFileMasterIdCompletedEventHandler GetFoldersByFileMasterIdCompleted;

	public event GetFoldersByFileMasterIdsCompletedEventHandler GetFoldersByFileMasterIdsCompleted;

	public event AddFolderCompletedEventHandler AddFolderCompleted;

	public event DeleteFolderHierarchyCompletedEventHandler DeleteFolderHierarchyCompleted;

	public event DeleteFolderHierarchyUnconditionalCompletedEventHandler DeleteFolderHierarchyUnconditionalCompleted;

	public event GetFolderDeleteRestrictionsByIdCompletedEventHandler GetFolderDeleteRestrictionsByIdCompleted;

	public event GetFolderDeleteRestrictionsByIdsCompletedEventHandler GetFolderDeleteRestrictionsByIdsCompleted;

	public event UpdateFolderUNCPathCompletedEventHandler UpdateFolderUNCPathCompleted;

	public event UpdateFolderNameCompletedEventHandler UpdateFolderNameCompleted;

	public event GetFileByIdCompletedEventHandler GetFileByIdCompleted;

	public event GetFilesByIdsCompletedEventHandler GetFilesByIdsCompleted;

	public event LockFileByMasterIdCompletedEventHandler LockFileByMasterIdCompleted;

	public event LockFilesByMasterIdsCompletedEventHandler LockFilesByMasterIdsCompleted;

	public event GetFileLockRestrictionsByMasterIdCompletedEventHandler GetFileLockRestrictionsByMasterIdCompleted;

	public event GetFileLockRestrictionsByMasterIdsCompletedEventHandler GetFileLockRestrictionsByMasterIdsCompleted;

	public event FindLatestFilesByPathsCompletedEventHandler FindLatestFilesByPathsCompleted;

	public event FindFilesByPathsAndChecksumsCompletedEventHandler FindFilesByPathsAndChecksumsCompleted;

	public event FindFilesByFoldersNamesAndChecksumsCompletedEventHandler FindFilesByFoldersNamesAndChecksumsCompleted;

	public event FindFilePathsByNameAndChecksumCompletedEventHandler FindFilePathsByNameAndChecksumCompleted;

	public event GetLatestFilePathsByNamesCompletedEventHandler GetLatestFilePathsByNamesCompleted;

	public event GetLatestDuplicateFilePathsCompletedEventHandler GetLatestDuplicateFilePathsCompleted;

	public event GetLatestFilesByFolderIdCompletedEventHandler GetLatestFilesByFolderIdCompleted;

	public event GetLatestFilesByFolderIdsCompletedEventHandler GetLatestFilesByFolderIdsCompleted;

	public event GetFilesByMasterIdCompletedEventHandler GetFilesByMasterIdCompleted;

	public event GetFilesByMasterIdsCompletedEventHandler GetFilesByMasterIdsCompleted;

	public event GetFileByVersionCompletedEventHandler GetFileByVersionCompleted;

	public event GetFilesByVersionsCompletedEventHandler GetFilesByVersionsCompleted;

	public event GetLatestFileByMasterIdCompletedEventHandler GetLatestFileByMasterIdCompleted;

	public event GetLatestFilesByMasterIdsCompletedEventHandler GetLatestFilesByMasterIdsCompleted;

	public event DownloadFileCompletedEventHandler DownloadFileCompleted;

	public event DownloadFilePartCompletedEventHandler DownloadFilePartCompleted;

	public event UploadFilePartCompletedEventHandler UploadFilePartCompleted;

	public event AddFileCompletedEventHandler AddFileCompleted;

	public event AddUploadedFileCompletedEventHandler AddUploadedFileCompleted;

	public event CheckinFileCompletedEventHandler CheckinFileCompleted;

	public event CheckinUploadedFileCompletedEventHandler CheckinUploadedFileCompleted;

	public event CheckoutFileCompletedEventHandler CheckoutFileCompleted;

	public event UndoCheckoutFileCompletedEventHandler UndoCheckoutFileCompleted;

	public event DeleteFileFromFolderCompletedEventHandler DeleteFileFromFolderCompleted;

	public event DeleteFilesFromFolderCompletedEventHandler DeleteFilesFromFolderCompleted;

	public event DeleteFileFromFolderUnconditionalCompletedEventHandler DeleteFileFromFolderUnconditionalCompleted;

	public event DeleteFilesFromFolderUnconditionalCompletedEventHandler DeleteFilesFromFolderUnconditionalCompleted;

	public event GetFileDeleteRestrictionsByMasterIdCompletedEventHandler GetFileDeleteRestrictionsByMasterIdCompleted;

	public event GetFileDeleteRestrictionsByMasterIdsCompletedEventHandler GetFileDeleteRestrictionsByMasterIdsCompleted;

	public event ShareFileCompletedEventHandler ShareFileCompleted;

	public event MoveFileCompletedEventHandler MoveFileCompleted;

	public event GetFileAssociationRestrictionsByIdCompletedEventHandler GetFileAssociationRestrictionsByIdCompleted;

	public event GetFileRenameRestrictionsByMasterIdCompletedEventHandler GetFileRenameRestrictionsByMasterIdCompleted;

	public event GetFileRenameRestrictionsByMasterIdsCompletedEventHandler GetFileRenameRestrictionsByMasterIdsCompleted;

	public event FindFilesBySearchConditionsCompletedEventHandler FindFilesBySearchConditionsCompleted;

	public event GetBOMByFileIdCompletedEventHandler GetBOMByFileIdCompleted;

	public event GetBOMByFileIdsCompletedEventHandler GetBOMByFileIdsCompleted;

	public event GetAllPropertyDefinitionsCompletedEventHandler GetAllPropertyDefinitionsCompleted;

	public event GetAllPropertyDefinitionsExtendedCompletedEventHandler GetAllPropertyDefinitionsExtendedCompleted;

	public event FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesCompletedEventHandler FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesCompleted;

	public event SetPropertyDefinitionDisplayNameCompletedEventHandler SetPropertyDefinitionDisplayNameCompleted;

	public event SetPropertyDefinitionsDisplayNamesCompletedEventHandler SetPropertyDefinitionsDisplayNamesCompleted;

	public event GetPropertiesCompletedEventHandler GetPropertiesCompleted;

	public event FindFileFoldersBySearchConditionsCompletedEventHandler FindFileFoldersBySearchConditionsCompleted;

	public event GetAllPropertyGroupsCompletedEventHandler GetAllPropertyGroupsCompleted;

	public event AddPropertyGroupCompletedEventHandler AddPropertyGroupCompleted;

	public event UpdatePropertyGroupCompletedEventHandler UpdatePropertyGroupCompleted;

	public event UpdatePropertyGroupsCompletedEventHandler UpdatePropertyGroupsCompleted;

	public event DeletePropertyGroupCompletedEventHandler DeletePropertyGroupCompleted;

	public event DeletePropertyGroupsCompletedEventHandler DeletePropertyGroupsCompleted;

	public event VoidPropertyDefinitionsCompletedEventHandler VoidPropertyDefinitionsCompleted;

	public event UnvoidPropertyDefinitionsCompletedEventHandler UnvoidPropertyDefinitionsCompleted;

	public event ReIndexPropertiesCompletedEventHandler ReIndexPropertiesCompleted;

	public event GetAllLabelsCompletedEventHandler GetAllLabelsCompleted;

	public event FindLabelByNameCompletedEventHandler FindLabelByNameCompleted;

	public event FindLabelsByNamesCompletedEventHandler FindLabelsByNamesCompleted;

	public event AddLabelCompletedEventHandler AddLabelCompleted;

	public event DeleteLabelCompletedEventHandler DeleteLabelCompleted;

	public event UpdateLabelCompletedEventHandler UpdateLabelCompleted;

	public event GetFileFoldersByLabelIdCompletedEventHandler GetFileFoldersByLabelIdCompleted;

	public event MoveFolderCompletedEventHandler MoveFolderCompleted;

	public event GetFolderMoveRestrictionsCompletedEventHandler GetFolderMoveRestrictionsCompleted;

	public event GetFolderRenameRestrictionsCompletedEventHandler GetFolderRenameRestrictionsCompleted;

	public event GetUniqueFileNameRequiredCompletedEventHandler GetUniqueFileNameRequiredCompleted;

	public event SetUniqueFileNameRequiredCompletedEventHandler SetUniqueFileNameRequiredCompleted;

	public event GetEnableDWFAttachmentCompletedEventHandler GetEnableDWFAttachmentCompleted;

	public event SetEnableDWFAttachmentCompletedEventHandler SetEnableDWFAttachmentCompleted;

	public event GetDWFPublishFolderLocationCompletedEventHandler GetDWFPublishFolderLocationCompleted;

	public event SetDWFPublishFolderLocationCompletedEventHandler SetDWFPublishFolderLocationCompleted;

	public event GetDWFPublishPreserveFolderHierarchyCompletedEventHandler GetDWFPublishPreserveFolderHierarchyCompleted;

	public event SetDWFPublishPreserveFolderHierarchyCompletedEventHandler SetDWFPublishPreserveFolderHierarchyCompleted;

	public event GetEnforceWorkingFolderCompletedEventHandler GetEnforceWorkingFolderCompleted;

	public event SetEnforceWorkingFolderCompletedEventHandler SetEnforceWorkingFolderCompleted;

	public event GetRequiredWorkingFolderLocationCompletedEventHandler GetRequiredWorkingFolderLocationCompleted;

	public event SetRequiredWorkingFolderLocationCompletedEventHandler SetRequiredWorkingFolderLocationCompleted;

	public event GetLatestFileAssociationsByMasterIdCompletedEventHandler GetLatestFileAssociationsByMasterIdCompleted;

	public event GetLatestFileAssociationsByMasterIdsCompletedEventHandler GetLatestFileAssociationsByMasterIdsCompleted;

	public event GetAssociatedFilePathsByIdCompletedEventHandler GetAssociatedFilePathsByIdCompleted;

	public event GetAssociatedFilePathsByIdsCompletedEventHandler GetAssociatedFilePathsByIdsCompleted;

	public event GetFileAssociationsByIdCompletedEventHandler GetFileAssociationsByIdCompleted;

	public event GetFileAssociationsByIdsCompletedEventHandler GetFileAssociationsByIdsCompleted;

	public event GetLatestAssociatedFilePathsByMasterIdCompletedEventHandler GetLatestAssociatedFilePathsByMasterIdCompleted;

	public event GetLatestAssociatedFilePathsByMasterIdsCompletedEventHandler GetLatestAssociatedFilePathsByMasterIdsCompleted;

	public event ValidateBOMByFileIdCompletedEventHandler ValidateBOMByFileIdCompleted;

	public event GetComponentPropertiesCompletedEventHandler GetComponentPropertiesCompleted;

	public event AddComponentCustomPropertyDefinitionCompletedEventHandler AddComponentCustomPropertyDefinitionCompleted;

	public event DeleteComponentCustomPropertyDefinitionCompletedEventHandler DeleteComponentCustomPropertyDefinitionCompleted;

	public event GetFileVersionDeleteRestrictionsByMasterIdsCompletedEventHandler GetFileVersionDeleteRestrictionsByMasterIdsCompleted;

	public event DeleteFileVersionsByMasterIdsCompletedEventHandler DeleteFileVersionsByMasterIdsCompleted;

	public event DeleteFileVersionsByMasterIdsUnconditionalCompletedEventHandler DeleteFileVersionsByMasterIdsUnconditionalCompleted;

	public event GetTrackFileStatusCompletedEventHandler GetTrackFileStatusCompleted;

	public event SetTrackFileStatusCompletedEventHandler SetTrackFileStatusCompleted;

	public event GetFilterConfigXmlCompletedEventHandler GetFilterConfigXmlCompleted;

	public event DeleteFileVersionsCompletedEventHandler DeleteFileVersionsCompleted;

	public event DeleteFileVersionsUnconditionalCompletedEventHandler DeleteFileVersionsUnconditionalCompleted;

	public event SetFileStatusByMasterIdCompletedEventHandler SetFileStatusByMasterIdCompleted;

	public event SetFileStatusByMasterIdsCompletedEventHandler SetFileStatusByMasterIdsCompleted;

	public event GetFileStatusSetRestrictionsByMasterIdsCompletedEventHandler GetFileStatusSetRestrictionsByMasterIdsCompleted;

	public event GetFileVersionDeleteRestrictionsByFileIdsCompletedEventHandler GetFileVersionDeleteRestrictionsByFileIdsCompleted;

	public event AddFileNamingSchemeCompletedEventHandler AddFileNamingSchemeCompleted;

	public event UpdateFileNamingSchemeCompletedEventHandler UpdateFileNamingSchemeCompleted;

	public event DeleteFileNamingSchemeCompletedEventHandler DeleteFileNamingSchemeCompleted;

	public event SetDefaultFileNamingSchemeCompletedEventHandler SetDefaultFileNamingSchemeCompleted;

	public event GetAllFileNamingSchemesCompletedEventHandler GetAllFileNamingSchemesCompleted;

	public event ReserveFileNamingDescriptionsCompletedEventHandler ReserveFileNamingDescriptionsCompleted;

	public event RollbackFileNamingDescriptionsCompletedEventHandler RollbackFileNamingDescriptionsCompleted;

	public DocumentServiceWse()
	{
		Url = "http://localhost/AutodeskDM/Services/DocumentService.asmx";
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

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Folder GetFolderRoot()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderRoot", new object[0]);
		return (Folder)array[0];
	}

	public void GetFolderRootAsync()
	{
		GetFolderRootAsync(null);
	}

	public void GetFolderRootAsync(object userState)
	{
		if (GetFolderRootOperationCompleted == null)
		{
			GetFolderRootOperationCompleted = OnGetFolderRootOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderRoot", new object[0], GetFolderRootOperationCompleted, userState);
	}

	private void OnGetFolderRootOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderRootCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderRootCompleted(this, new GetFolderRootCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Folder GetFolderByPath(string path)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderByPath", new object[1] { path });
		return (Folder)array[0];
	}

	public void GetFolderByPathAsync(string path)
	{
		GetFolderByPathAsync(path, null);
	}

	public void GetFolderByPathAsync(string path, object userState)
	{
		if (GetFolderByPathOperationCompleted == null)
		{
			GetFolderByPathOperationCompleted = OnGetFolderByPathOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderByPath", new object[1] { path }, GetFolderByPathOperationCompleted, userState);
	}

	private void OnGetFolderByPathOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderByPathCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderByPathCompleted(this, new GetFolderByPathCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Folder[] GetFoldersByPaths(string[] paths)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFoldersByPaths", new object[1] { paths });
		return (Folder[])array[0];
	}

	public void GetFoldersByPathsAsync(string[] paths)
	{
		GetFoldersByPathsAsync(paths, null);
	}

	public void GetFoldersByPathsAsync(string[] paths, object userState)
	{
		if (GetFoldersByPathsOperationCompleted == null)
		{
			GetFoldersByPathsOperationCompleted = OnGetFoldersByPathsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFoldersByPaths", new object[1] { paths }, GetFoldersByPathsOperationCompleted, userState);
	}

	private void OnGetFoldersByPathsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFoldersByPathsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFoldersByPathsCompleted(this, new GetFoldersByPathsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Folder[] FindFoldersByPaths(string[] paths)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFoldersByPaths", new object[1] { paths });
		return (Folder[])array[0];
	}

	public void FindFoldersByPathsAsync(string[] paths)
	{
		FindFoldersByPathsAsync(paths, null);
	}

	public void FindFoldersByPathsAsync(string[] paths, object userState)
	{
		if (FindFoldersByPathsOperationCompleted == null)
		{
			FindFoldersByPathsOperationCompleted = OnFindFoldersByPathsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFoldersByPaths", new object[1] { paths }, FindFoldersByPathsOperationCompleted, userState);
	}

	private void OnFindFoldersByPathsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFoldersByPathsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFoldersByPathsCompleted(this, new FindFoldersByPathsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Folder GetFolderById(long folderId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderById", new object[1] { folderId });
		return (Folder)array[0];
	}

	public void GetFolderByIdAsync(long folderId)
	{
		GetFolderByIdAsync(folderId, null);
	}

	public void GetFolderByIdAsync(long folderId, object userState)
	{
		if (GetFolderByIdOperationCompleted == null)
		{
			GetFolderByIdOperationCompleted = OnGetFolderByIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderById", new object[1] { folderId }, GetFolderByIdOperationCompleted, userState);
	}

	private void OnGetFolderByIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderByIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderByIdCompleted(this, new GetFolderByIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Folder[] GetFoldersByIds(long[] folderIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFoldersByIds", new object[1] { folderIds });
		return (Folder[])array[0];
	}

	public void GetFoldersByIdsAsync(long[] folderIds)
	{
		GetFoldersByIdsAsync(folderIds, null);
	}

	public void GetFoldersByIdsAsync(long[] folderIds, object userState)
	{
		if (GetFoldersByIdsOperationCompleted == null)
		{
			GetFoldersByIdsOperationCompleted = OnGetFoldersByIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFoldersByIds", new object[1] { folderIds }, GetFoldersByIdsOperationCompleted, userState);
	}

	private void OnGetFoldersByIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFoldersByIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFoldersByIdsCompleted(this, new GetFoldersByIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Folder[] FindFoldersByIds(long[] folderIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFoldersByIds", new object[1] { folderIds });
		return (Folder[])array[0];
	}

	public void FindFoldersByIdsAsync(long[] folderIds)
	{
		FindFoldersByIdsAsync(folderIds, null);
	}

	public void FindFoldersByIdsAsync(long[] folderIds, object userState)
	{
		if (FindFoldersByIdsOperationCompleted == null)
		{
			FindFoldersByIdsOperationCompleted = OnFindFoldersByIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFoldersByIds", new object[1] { folderIds }, FindFoldersByIdsOperationCompleted, userState);
	}

	private void OnFindFoldersByIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFoldersByIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFoldersByIdsCompleted(this, new FindFoldersByIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Folder[] GetFoldersByParentId(long parentFolderId, bool recurse)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFoldersByParentId", new object[2] { parentFolderId, recurse });
		return (Folder[])array[0];
	}

	public void GetFoldersByParentIdAsync(long parentFolderId, bool recurse)
	{
		GetFoldersByParentIdAsync(parentFolderId, recurse, null);
	}

	public void GetFoldersByParentIdAsync(long parentFolderId, bool recurse, object userState)
	{
		if (GetFoldersByParentIdOperationCompleted == null)
		{
			GetFoldersByParentIdOperationCompleted = OnGetFoldersByParentIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFoldersByParentId", new object[2] { parentFolderId, recurse }, GetFoldersByParentIdOperationCompleted, userState);
	}

	private void OnGetFoldersByParentIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFoldersByParentIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFoldersByParentIdCompleted(this, new GetFoldersByParentIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FolderArray[] GetFoldersByParentIds(long[] parentFolderIds, bool recurse)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFoldersByParentIds", new object[2] { parentFolderIds, recurse });
		return (FolderArray[])array[0];
	}

	public void GetFoldersByParentIdsAsync(long[] parentFolderIds, bool recurse)
	{
		GetFoldersByParentIdsAsync(parentFolderIds, recurse, null);
	}

	public void GetFoldersByParentIdsAsync(long[] parentFolderIds, bool recurse, object userState)
	{
		if (GetFoldersByParentIdsOperationCompleted == null)
		{
			GetFoldersByParentIdsOperationCompleted = OnGetFoldersByParentIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFoldersByParentIds", new object[2] { parentFolderIds, recurse }, GetFoldersByParentIdsOperationCompleted, userState);
	}

	private void OnGetFoldersByParentIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFoldersByParentIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFoldersByParentIdsCompleted(this, new GetFoldersByParentIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Folder[] GetFoldersByFileMasterId(long fileMasterId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFoldersByFileMasterId", new object[1] { fileMasterId });
		return (Folder[])array[0];
	}

	public void GetFoldersByFileMasterIdAsync(long fileMasterId)
	{
		GetFoldersByFileMasterIdAsync(fileMasterId, null);
	}

	public void GetFoldersByFileMasterIdAsync(long fileMasterId, object userState)
	{
		if (GetFoldersByFileMasterIdOperationCompleted == null)
		{
			GetFoldersByFileMasterIdOperationCompleted = OnGetFoldersByFileMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFoldersByFileMasterId", new object[1] { fileMasterId }, GetFoldersByFileMasterIdOperationCompleted, userState);
	}

	private void OnGetFoldersByFileMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFoldersByFileMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFoldersByFileMasterIdCompleted(this, new GetFoldersByFileMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FolderArray[] GetFoldersByFileMasterIds(long[] fileMasterIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFoldersByFileMasterIds", new object[1] { fileMasterIds });
		return (FolderArray[])array[0];
	}

	public void GetFoldersByFileMasterIdsAsync(long[] fileMasterIds)
	{
		GetFoldersByFileMasterIdsAsync(fileMasterIds, null);
	}

	public void GetFoldersByFileMasterIdsAsync(long[] fileMasterIds, object userState)
	{
		if (GetFoldersByFileMasterIdsOperationCompleted == null)
		{
			GetFoldersByFileMasterIdsOperationCompleted = OnGetFoldersByFileMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFoldersByFileMasterIds", new object[1] { fileMasterIds }, GetFoldersByFileMasterIdsOperationCompleted, userState);
	}

	private void OnGetFoldersByFileMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFoldersByFileMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFoldersByFileMasterIdsCompleted(this, new GetFoldersByFileMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Folder AddFolder(string name, long parentId, bool isLibrary)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddFolder", new object[3] { name, parentId, isLibrary });
		return (Folder)array[0];
	}

	public void AddFolderAsync(string name, long parentId, bool isLibrary)
	{
		AddFolderAsync(name, parentId, isLibrary, null);
	}

	public void AddFolderAsync(string name, long parentId, bool isLibrary, object userState)
	{
		if (AddFolderOperationCompleted == null)
		{
			AddFolderOperationCompleted = OnAddFolderOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddFolder", new object[3] { name, parentId, isLibrary }, AddFolderOperationCompleted, userState);
	}

	private void OnAddFolderOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddFolderCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddFolderCompleted(this, new AddFolderCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void DeleteFolderHierarchy(long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFolderHierarchy", new object[1] { folderId });
	}

	public void DeleteFolderHierarchyAsync(long folderId)
	{
		DeleteFolderHierarchyAsync(folderId, null);
	}

	public void DeleteFolderHierarchyAsync(long folderId, object userState)
	{
		if (DeleteFolderHierarchyOperationCompleted == null)
		{
			DeleteFolderHierarchyOperationCompleted = OnDeleteFolderHierarchyOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFolderHierarchy", new object[1] { folderId }, DeleteFolderHierarchyOperationCompleted, userState);
	}

	private void OnDeleteFolderHierarchyOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFolderHierarchyCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFolderHierarchyCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void DeleteFolderHierarchyUnconditional(long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFolderHierarchyUnconditional", new object[1] { folderId });
	}

	public void DeleteFolderHierarchyUnconditionalAsync(long folderId)
	{
		DeleteFolderHierarchyUnconditionalAsync(folderId, null);
	}

	public void DeleteFolderHierarchyUnconditionalAsync(long folderId, object userState)
	{
		if (DeleteFolderHierarchyUnconditionalOperationCompleted == null)
		{
			DeleteFolderHierarchyUnconditionalOperationCompleted = OnDeleteFolderHierarchyUnconditionalOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFolderHierarchyUnconditional", new object[1] { folderId }, DeleteFolderHierarchyUnconditionalOperationCompleted, userState);
	}

	private void OnDeleteFolderHierarchyUnconditionalOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFolderHierarchyUnconditionalCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFolderHierarchyUnconditionalCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FolderDelRestric[] GetFolderDeleteRestrictionsById(long folderId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderDeleteRestrictionsById", new object[1] { folderId });
		return (FolderDelRestric[])array[0];
	}

	public void GetFolderDeleteRestrictionsByIdAsync(long folderId)
	{
		GetFolderDeleteRestrictionsByIdAsync(folderId, null);
	}

	public void GetFolderDeleteRestrictionsByIdAsync(long folderId, object userState)
	{
		if (GetFolderDeleteRestrictionsByIdOperationCompleted == null)
		{
			GetFolderDeleteRestrictionsByIdOperationCompleted = OnGetFolderDeleteRestrictionsByIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderDeleteRestrictionsById", new object[1] { folderId }, GetFolderDeleteRestrictionsByIdOperationCompleted, userState);
	}

	private void OnGetFolderDeleteRestrictionsByIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderDeleteRestrictionsByIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderDeleteRestrictionsByIdCompleted(this, new GetFolderDeleteRestrictionsByIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FolderDelRestricArray[] GetFolderDeleteRestrictionsByIds(long[] folderIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderDeleteRestrictionsByIds", new object[1] { folderIds });
		return (FolderDelRestricArray[])array[0];
	}

	public void GetFolderDeleteRestrictionsByIdsAsync(long[] folderIds)
	{
		GetFolderDeleteRestrictionsByIdsAsync(folderIds, null);
	}

	public void GetFolderDeleteRestrictionsByIdsAsync(long[] folderIds, object userState)
	{
		if (GetFolderDeleteRestrictionsByIdsOperationCompleted == null)
		{
			GetFolderDeleteRestrictionsByIdsOperationCompleted = OnGetFolderDeleteRestrictionsByIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderDeleteRestrictionsByIds", new object[1] { folderIds }, GetFolderDeleteRestrictionsByIdsOperationCompleted, userState);
	}

	private void OnGetFolderDeleteRestrictionsByIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderDeleteRestrictionsByIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderDeleteRestrictionsByIdsCompleted(this, new GetFolderDeleteRestrictionsByIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Folder UpdateFolderUNCPath(long folderId, string uncPath)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("UpdateFolderUNCPath", new object[2] { folderId, uncPath });
		return (Folder)array[0];
	}

	public void UpdateFolderUNCPathAsync(long folderId, string uncPath)
	{
		UpdateFolderUNCPathAsync(folderId, uncPath, null);
	}

	public void UpdateFolderUNCPathAsync(long folderId, string uncPath, object userState)
	{
		if (UpdateFolderUNCPathOperationCompleted == null)
		{
			UpdateFolderUNCPathOperationCompleted = OnUpdateFolderUNCPathOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdateFolderUNCPath", new object[2] { folderId, uncPath }, UpdateFolderUNCPathOperationCompleted, userState);
	}

	private void OnUpdateFolderUNCPathOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdateFolderUNCPathCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdateFolderUNCPathCompleted(this, new UpdateFolderUNCPathCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Folder UpdateFolderName(long folderId, string folderName)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("UpdateFolderName", new object[2] { folderId, folderName });
		return (Folder)array[0];
	}

	public void UpdateFolderNameAsync(long folderId, string folderName)
	{
		UpdateFolderNameAsync(folderId, folderName, null);
	}

	public void UpdateFolderNameAsync(long folderId, string folderName, object userState)
	{
		if (UpdateFolderNameOperationCompleted == null)
		{
			UpdateFolderNameOperationCompleted = OnUpdateFolderNameOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdateFolderName", new object[2] { folderId, folderName }, UpdateFolderNameOperationCompleted, userState);
	}

	private void OnUpdateFolderNameOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdateFolderNameCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdateFolderNameCompleted(this, new UpdateFolderNameCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File GetFileById(long fileId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileById", new object[1] { fileId });
		return (File)array[0];
	}

	public void GetFileByIdAsync(long fileId)
	{
		GetFileByIdAsync(fileId, null);
	}

	public void GetFileByIdAsync(long fileId, object userState)
	{
		if (GetFileByIdOperationCompleted == null)
		{
			GetFileByIdOperationCompleted = OnGetFileByIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileById", new object[1] { fileId }, GetFileByIdOperationCompleted, userState);
	}

	private void OnGetFileByIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileByIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileByIdCompleted(this, new GetFileByIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File[] GetFilesByIds(long[] fileIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFilesByIds", new object[1] { fileIds });
		return (File[])array[0];
	}

	public void GetFilesByIdsAsync(long[] fileIds)
	{
		GetFilesByIdsAsync(fileIds, null);
	}

	public void GetFilesByIdsAsync(long[] fileIds, object userState)
	{
		if (GetFilesByIdsOperationCompleted == null)
		{
			GetFilesByIdsOperationCompleted = OnGetFilesByIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFilesByIds", new object[1] { fileIds }, GetFilesByIdsOperationCompleted, userState);
	}

	private void OnGetFilesByIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFilesByIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFilesByIdsCompleted(this, new GetFilesByIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File LockFileByMasterId(long fileMasterId, bool locked)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("LockFileByMasterId", new object[2] { fileMasterId, locked });
		return (File)array[0];
	}

	public void LockFileByMasterIdAsync(long fileMasterId, bool locked)
	{
		LockFileByMasterIdAsync(fileMasterId, locked, null);
	}

	public void LockFileByMasterIdAsync(long fileMasterId, bool locked, object userState)
	{
		if (LockFileByMasterIdOperationCompleted == null)
		{
			LockFileByMasterIdOperationCompleted = OnLockFileByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("LockFileByMasterId", new object[2] { fileMasterId, locked }, LockFileByMasterIdOperationCompleted, userState);
	}

	private void OnLockFileByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.LockFileByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.LockFileByMasterIdCompleted(this, new LockFileByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File[] LockFilesByMasterIds(long[] fileMasterIds, bool locked)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("LockFilesByMasterIds", new object[2] { fileMasterIds, locked });
		return (File[])array[0];
	}

	public void LockFilesByMasterIdsAsync(long[] fileMasterIds, bool locked)
	{
		LockFilesByMasterIdsAsync(fileMasterIds, locked, null);
	}

	public void LockFilesByMasterIdsAsync(long[] fileMasterIds, bool locked, object userState)
	{
		if (LockFilesByMasterIdsOperationCompleted == null)
		{
			LockFilesByMasterIdsOperationCompleted = OnLockFilesByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("LockFilesByMasterIds", new object[2] { fileMasterIds, locked }, LockFilesByMasterIdsOperationCompleted, userState);
	}

	private void OnLockFilesByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.LockFilesByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.LockFilesByMasterIdsCompleted(this, new LockFilesByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileLockRestric[] GetFileLockRestrictionsByMasterId(long fileMasterId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileLockRestrictionsByMasterId", new object[1] { fileMasterId });
		return (FileLockRestric[])array[0];
	}

	public void GetFileLockRestrictionsByMasterIdAsync(long fileMasterId)
	{
		GetFileLockRestrictionsByMasterIdAsync(fileMasterId, null);
	}

	public void GetFileLockRestrictionsByMasterIdAsync(long fileMasterId, object userState)
	{
		if (GetFileLockRestrictionsByMasterIdOperationCompleted == null)
		{
			GetFileLockRestrictionsByMasterIdOperationCompleted = OnGetFileLockRestrictionsByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileLockRestrictionsByMasterId", new object[1] { fileMasterId }, GetFileLockRestrictionsByMasterIdOperationCompleted, userState);
	}

	private void OnGetFileLockRestrictionsByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileLockRestrictionsByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileLockRestrictionsByMasterIdCompleted(this, new GetFileLockRestrictionsByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileLockRestricArray[] GetFileLockRestrictionsByMasterIds(long[] fileMasterIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileLockRestrictionsByMasterIds", new object[1] { fileMasterIds });
		return (FileLockRestricArray[])array[0];
	}

	public void GetFileLockRestrictionsByMasterIdsAsync(long[] fileMasterIds)
	{
		GetFileLockRestrictionsByMasterIdsAsync(fileMasterIds, null);
	}

	public void GetFileLockRestrictionsByMasterIdsAsync(long[] fileMasterIds, object userState)
	{
		if (GetFileLockRestrictionsByMasterIdsOperationCompleted == null)
		{
			GetFileLockRestrictionsByMasterIdsOperationCompleted = OnGetFileLockRestrictionsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileLockRestrictionsByMasterIds", new object[1] { fileMasterIds }, GetFileLockRestrictionsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetFileLockRestrictionsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileLockRestrictionsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileLockRestrictionsByMasterIdsCompleted(this, new GetFileLockRestrictionsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File[] FindLatestFilesByPaths(string[] filePaths)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindLatestFilesByPaths", new object[1] { filePaths });
		return (File[])array[0];
	}

	public void FindLatestFilesByPathsAsync(string[] filePaths)
	{
		FindLatestFilesByPathsAsync(filePaths, null);
	}

	public void FindLatestFilesByPathsAsync(string[] filePaths, object userState)
	{
		if (FindLatestFilesByPathsOperationCompleted == null)
		{
			FindLatestFilesByPathsOperationCompleted = OnFindLatestFilesByPathsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindLatestFilesByPaths", new object[1] { filePaths }, FindLatestFilesByPathsOperationCompleted, userState);
	}

	private void OnFindLatestFilesByPathsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindLatestFilesByPathsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindLatestFilesByPathsCompleted(this, new FindLatestFilesByPathsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File[] FindFilesByPathsAndChecksums(string[] filePaths, int[] checksums)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFilesByPathsAndChecksums", new object[2] { filePaths, checksums });
		return (File[])array[0];
	}

	public void FindFilesByPathsAndChecksumsAsync(string[] filePaths, int[] checksums)
	{
		FindFilesByPathsAndChecksumsAsync(filePaths, checksums, null);
	}

	public void FindFilesByPathsAndChecksumsAsync(string[] filePaths, int[] checksums, object userState)
	{
		if (FindFilesByPathsAndChecksumsOperationCompleted == null)
		{
			FindFilesByPathsAndChecksumsOperationCompleted = OnFindFilesByPathsAndChecksumsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFilesByPathsAndChecksums", new object[2] { filePaths, checksums }, FindFilesByPathsAndChecksumsOperationCompleted, userState);
	}

	private void OnFindFilesByPathsAndChecksumsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFilesByPathsAndChecksumsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFilesByPathsAndChecksumsCompleted(this, new FindFilesByPathsAndChecksumsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File[] FindFilesByFoldersNamesAndChecksums(long[] folderIds, string[] filenames, int[] checksums)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFilesByFoldersNamesAndChecksums", new object[3] { folderIds, filenames, checksums });
		return (File[])array[0];
	}

	public void FindFilesByFoldersNamesAndChecksumsAsync(long[] folderIds, string[] filenames, int[] checksums)
	{
		FindFilesByFoldersNamesAndChecksumsAsync(folderIds, filenames, checksums, null);
	}

	public void FindFilesByFoldersNamesAndChecksumsAsync(long[] folderIds, string[] filenames, int[] checksums, object userState)
	{
		if (FindFilesByFoldersNamesAndChecksumsOperationCompleted == null)
		{
			FindFilesByFoldersNamesAndChecksumsOperationCompleted = OnFindFilesByFoldersNamesAndChecksumsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFilesByFoldersNamesAndChecksums", new object[3] { folderIds, filenames, checksums }, FindFilesByFoldersNamesAndChecksumsOperationCompleted, userState);
	}

	private void OnFindFilesByFoldersNamesAndChecksumsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFilesByFoldersNamesAndChecksumsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFilesByFoldersNamesAndChecksumsCompleted(this, new FindFilesByFoldersNamesAndChecksumsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FilePath[] FindFilePathsByNameAndChecksum(string fileName, int checksum)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFilePathsByNameAndChecksum", new object[2] { fileName, checksum });
		return (FilePath[])array[0];
	}

	public void FindFilePathsByNameAndChecksumAsync(string fileName, int checksum)
	{
		FindFilePathsByNameAndChecksumAsync(fileName, checksum, null);
	}

	public void FindFilePathsByNameAndChecksumAsync(string fileName, int checksum, object userState)
	{
		if (FindFilePathsByNameAndChecksumOperationCompleted == null)
		{
			FindFilePathsByNameAndChecksumOperationCompleted = OnFindFilePathsByNameAndChecksumOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFilePathsByNameAndChecksum", new object[2] { fileName, checksum }, FindFilePathsByNameAndChecksumOperationCompleted, userState);
	}

	private void OnFindFilePathsByNameAndChecksumOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFilePathsByNameAndChecksumCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFilePathsByNameAndChecksumCompleted(this, new FindFilePathsByNameAndChecksumCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FilePathArray[] GetLatestFilePathsByNames(string[] fileNames)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFilePathsByNames", new object[1] { fileNames });
		return (FilePathArray[])array[0];
	}

	public void GetLatestFilePathsByNamesAsync(string[] fileNames)
	{
		GetLatestFilePathsByNamesAsync(fileNames, null);
	}

	public void GetLatestFilePathsByNamesAsync(string[] fileNames, object userState)
	{
		if (GetLatestFilePathsByNamesOperationCompleted == null)
		{
			GetLatestFilePathsByNamesOperationCompleted = OnGetLatestFilePathsByNamesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFilePathsByNames", new object[1] { fileNames }, GetLatestFilePathsByNamesOperationCompleted, userState);
	}

	private void OnGetLatestFilePathsByNamesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFilePathsByNamesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFilePathsByNamesCompleted(this, new GetLatestFilePathsByNamesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FilePath[] GetLatestDuplicateFilePaths()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestDuplicateFilePaths", new object[0]);
		return (FilePath[])array[0];
	}

	public void GetLatestDuplicateFilePathsAsync()
	{
		GetLatestDuplicateFilePathsAsync(null);
	}

	public void GetLatestDuplicateFilePathsAsync(object userState)
	{
		if (GetLatestDuplicateFilePathsOperationCompleted == null)
		{
			GetLatestDuplicateFilePathsOperationCompleted = OnGetLatestDuplicateFilePathsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestDuplicateFilePaths", new object[0], GetLatestDuplicateFilePathsOperationCompleted, userState);
	}

	private void OnGetLatestDuplicateFilePathsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestDuplicateFilePathsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestDuplicateFilePathsCompleted(this, new GetLatestDuplicateFilePathsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File[] GetLatestFilesByFolderId(long folderId, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFilesByFolderId", new object[2] { folderId, includeHidden });
		return (File[])array[0];
	}

	public void GetLatestFilesByFolderIdAsync(long folderId, bool includeHidden)
	{
		GetLatestFilesByFolderIdAsync(folderId, includeHidden, null);
	}

	public void GetLatestFilesByFolderIdAsync(long folderId, bool includeHidden, object userState)
	{
		if (GetLatestFilesByFolderIdOperationCompleted == null)
		{
			GetLatestFilesByFolderIdOperationCompleted = OnGetLatestFilesByFolderIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFilesByFolderId", new object[2] { folderId, includeHidden }, GetLatestFilesByFolderIdOperationCompleted, userState);
	}

	private void OnGetLatestFilesByFolderIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFilesByFolderIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFilesByFolderIdCompleted(this, new GetLatestFilesByFolderIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileArray[] GetLatestFilesByFolderIds(long[] folderIds, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFilesByFolderIds", new object[2] { folderIds, includeHidden });
		return (FileArray[])array[0];
	}

	public void GetLatestFilesByFolderIdsAsync(long[] folderIds, bool includeHidden)
	{
		GetLatestFilesByFolderIdsAsync(folderIds, includeHidden, null);
	}

	public void GetLatestFilesByFolderIdsAsync(long[] folderIds, bool includeHidden, object userState)
	{
		if (GetLatestFilesByFolderIdsOperationCompleted == null)
		{
			GetLatestFilesByFolderIdsOperationCompleted = OnGetLatestFilesByFolderIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFilesByFolderIds", new object[2] { folderIds, includeHidden }, GetLatestFilesByFolderIdsOperationCompleted, userState);
	}

	private void OnGetLatestFilesByFolderIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFilesByFolderIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFilesByFolderIdsCompleted(this, new GetLatestFilesByFolderIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File[] GetFilesByMasterId(long fileMasterId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFilesByMasterId", new object[1] { fileMasterId });
		return (File[])array[0];
	}

	public void GetFilesByMasterIdAsync(long fileMasterId)
	{
		GetFilesByMasterIdAsync(fileMasterId, null);
	}

	public void GetFilesByMasterIdAsync(long fileMasterId, object userState)
	{
		if (GetFilesByMasterIdOperationCompleted == null)
		{
			GetFilesByMasterIdOperationCompleted = OnGetFilesByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFilesByMasterId", new object[1] { fileMasterId }, GetFilesByMasterIdOperationCompleted, userState);
	}

	private void OnGetFilesByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFilesByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFilesByMasterIdCompleted(this, new GetFilesByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileArray[] GetFilesByMasterIds(long[] fileMasterIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFilesByMasterIds", new object[1] { fileMasterIds });
		return (FileArray[])array[0];
	}

	public void GetFilesByMasterIdsAsync(long[] fileMasterIds)
	{
		GetFilesByMasterIdsAsync(fileMasterIds, null);
	}

	public void GetFilesByMasterIdsAsync(long[] fileMasterIds, object userState)
	{
		if (GetFilesByMasterIdsOperationCompleted == null)
		{
			GetFilesByMasterIdsOperationCompleted = OnGetFilesByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFilesByMasterIds", new object[1] { fileMasterIds }, GetFilesByMasterIdsOperationCompleted, userState);
	}

	private void OnGetFilesByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFilesByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFilesByMasterIdsCompleted(this, new GetFilesByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File GetFileByVersion(long fileMasterId, int versionNumber)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileByVersion", new object[2] { fileMasterId, versionNumber });
		return (File)array[0];
	}

	public void GetFileByVersionAsync(long fileMasterId, int versionNumber)
	{
		GetFileByVersionAsync(fileMasterId, versionNumber, null);
	}

	public void GetFileByVersionAsync(long fileMasterId, int versionNumber, object userState)
	{
		if (GetFileByVersionOperationCompleted == null)
		{
			GetFileByVersionOperationCompleted = OnGetFileByVersionOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileByVersion", new object[2] { fileMasterId, versionNumber }, GetFileByVersionOperationCompleted, userState);
	}

	private void OnGetFileByVersionOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileByVersionCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileByVersionCompleted(this, new GetFileByVersionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File[] GetFilesByVersions(long[] fileMasterIds, int[] versionNumbers)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFilesByVersions", new object[2] { fileMasterIds, versionNumbers });
		return (File[])array[0];
	}

	public void GetFilesByVersionsAsync(long[] fileMasterIds, int[] versionNumbers)
	{
		GetFilesByVersionsAsync(fileMasterIds, versionNumbers, null);
	}

	public void GetFilesByVersionsAsync(long[] fileMasterIds, int[] versionNumbers, object userState)
	{
		if (GetFilesByVersionsOperationCompleted == null)
		{
			GetFilesByVersionsOperationCompleted = OnGetFilesByVersionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFilesByVersions", new object[2] { fileMasterIds, versionNumbers }, GetFilesByVersionsOperationCompleted, userState);
	}

	private void OnGetFilesByVersionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFilesByVersionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFilesByVersionsCompleted(this, new GetFilesByVersionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File GetLatestFileByMasterId(long fileMasterId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFileByMasterId", new object[1] { fileMasterId });
		return (File)array[0];
	}

	public void GetLatestFileByMasterIdAsync(long fileMasterId)
	{
		GetLatestFileByMasterIdAsync(fileMasterId, null);
	}

	public void GetLatestFileByMasterIdAsync(long fileMasterId, object userState)
	{
		if (GetLatestFileByMasterIdOperationCompleted == null)
		{
			GetLatestFileByMasterIdOperationCompleted = OnGetLatestFileByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFileByMasterId", new object[1] { fileMasterId }, GetLatestFileByMasterIdOperationCompleted, userState);
	}

	private void OnGetLatestFileByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFileByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFileByMasterIdCompleted(this, new GetLatestFileByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File[] GetLatestFilesByMasterIds(long[] fileMasterIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFilesByMasterIds", new object[1] { fileMasterIds });
		return (File[])array[0];
	}

	public void GetLatestFilesByMasterIdsAsync(long[] fileMasterIds)
	{
		GetLatestFilesByMasterIdsAsync(fileMasterIds, null);
	}

	public void GetLatestFilesByMasterIdsAsync(long[] fileMasterIds, object userState)
	{
		if (GetLatestFilesByMasterIdsOperationCompleted == null)
		{
			GetLatestFilesByMasterIdsOperationCompleted = OnGetLatestFilesByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFilesByMasterIds", new object[1] { fileMasterIds }, GetLatestFilesByMasterIdsOperationCompleted, userState);
	}

	private void OnGetLatestFilesByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFilesByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFilesByMasterIdsCompleted(this, new GetLatestFilesByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string DownloadFile(long fileId, bool allowSync, [XmlElement(DataType = "base64Binary")] out byte[] fileContents)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("DownloadFile", new object[2] { fileId, allowSync });
		fileContents = (byte[])array[1];
		return (string)array[0];
	}

	public void DownloadFileAsync(long fileId, bool allowSync)
	{
		DownloadFileAsync(fileId, allowSync, null);
	}

	public void DownloadFileAsync(long fileId, bool allowSync, object userState)
	{
		if (DownloadFileOperationCompleted == null)
		{
			DownloadFileOperationCompleted = OnDownloadFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DownloadFile", new object[2] { fileId, allowSync }, DownloadFileOperationCompleted, userState);
	}

	private void OnDownloadFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DownloadFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DownloadFileCompleted(this, new DownloadFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	[return: XmlElement(DataType = "base64Binary")]
	public byte[] DownloadFilePart(long fileId, long firstByte, long lastByte, bool allowSync)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("DownloadFilePart", new object[4] { fileId, firstByte, lastByte, allowSync });
		return (byte[])array[0];
	}

	public void DownloadFilePartAsync(long fileId, long firstByte, long lastByte, bool allowSync)
	{
		DownloadFilePartAsync(fileId, firstByte, lastByte, allowSync, null);
	}

	public void DownloadFilePartAsync(long fileId, long firstByte, long lastByte, bool allowSync, object userState)
	{
		if (DownloadFilePartOperationCompleted == null)
		{
			DownloadFilePartOperationCompleted = OnDownloadFilePartOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DownloadFilePart", new object[4] { fileId, firstByte, lastByte, allowSync }, DownloadFilePartOperationCompleted, userState);
	}

	private void OnDownloadFilePartOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DownloadFilePartCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DownloadFilePartCompleted(this, new DownloadFilePartCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Guid UploadFilePart(Guid uploadIdentifier, [XmlElement(DataType = "base64Binary")] byte[] filePart)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("UploadFilePart", new object[2] { uploadIdentifier, filePart });
		return (Guid)array[0];
	}

	public void UploadFilePartAsync(Guid uploadIdentifier, byte[] filePart)
	{
		UploadFilePartAsync(uploadIdentifier, filePart, null);
	}

	public void UploadFilePartAsync(Guid uploadIdentifier, byte[] filePart, object userState)
	{
		if (UploadFilePartOperationCompleted == null)
		{
			UploadFilePartOperationCompleted = OnUploadFilePartOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UploadFilePart", new object[2] { uploadIdentifier, filePart }, UploadFilePartOperationCompleted, userState);
	}

	private void OnUploadFilePartOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UploadFilePartCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UploadFilePartCompleted(this, new UploadFilePartCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File AddFile(long folderId, string fileName, string comment, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, FileClassification fileClassification, bool hidden, [XmlElement(DataType = "base64Binary")] byte[] fileContents)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddFile", new object[12]
		{
			folderId, fileName, comment, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, fileClassification,
			hidden, fileContents
		});
		return (File)array[0];
	}

	public void AddFileAsync(long folderId, string fileName, string comment, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, FileClassification fileClassification, bool hidden, byte[] fileContents)
	{
		AddFileAsync(folderId, fileName, comment, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, fileClassification, hidden, fileContents, null);
	}

	public void AddFileAsync(long folderId, string fileName, string comment, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, FileClassification fileClassification, bool hidden, byte[] fileContents, object userState)
	{
		if (AddFileOperationCompleted == null)
		{
			AddFileOperationCompleted = OnAddFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddFile", new object[12]
		{
			folderId, fileName, comment, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, fileClassification,
			hidden, fileContents
		}, AddFileOperationCompleted, userState);
	}

	private void OnAddFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddFileCompleted(this, new AddFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File AddUploadedFile(long folderId, string fileName, string comment, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, FileClassification fileClass, bool hidden, Guid uploadIdentifier)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddUploadedFile", new object[12]
		{
			folderId, fileName, comment, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, fileClass,
			hidden, uploadIdentifier
		});
		return (File)array[0];
	}

	public void AddUploadedFileAsync(long folderId, string fileName, string comment, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, FileClassification fileClass, bool hidden, Guid uploadIdentifier)
	{
		AddUploadedFileAsync(folderId, fileName, comment, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, fileClass, hidden, uploadIdentifier, null);
	}

	public void AddUploadedFileAsync(long folderId, string fileName, string comment, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, FileClassification fileClass, bool hidden, Guid uploadIdentifier, object userState)
	{
		if (AddUploadedFileOperationCompleted == null)
		{
			AddUploadedFileOperationCompleted = OnAddUploadedFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddUploadedFile", new object[12]
		{
			folderId, fileName, comment, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, fileClass,
			hidden, uploadIdentifier
		}, AddUploadedFileOperationCompleted, userState);
	}

	private void OnAddUploadedFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddUploadedFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddUploadedFileCompleted(this, new AddUploadedFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File CheckinFile(long fileMasterId, string comment, bool keepCheckedOut, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, bool copyBom, string newFileName, FileClassification fileClassification, bool hidden, [XmlElement(DataType = "base64Binary")] byte[] fileContents)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("CheckinFile", new object[14]
		{
			fileMasterId, comment, keepCheckedOut, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, copyBom,
			newFileName, fileClassification, hidden, fileContents
		});
		return (File)array[0];
	}

	public void CheckinFileAsync(long fileMasterId, string comment, bool keepCheckedOut, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, bool copyBom, string newFileName, FileClassification fileClassification, bool hidden, byte[] fileContents)
	{
		CheckinFileAsync(fileMasterId, comment, keepCheckedOut, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, copyBom, newFileName, fileClassification, hidden, fileContents, null);
	}

	public void CheckinFileAsync(long fileMasterId, string comment, bool keepCheckedOut, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, bool copyBom, string newFileName, FileClassification fileClassification, bool hidden, byte[] fileContents, object userState)
	{
		if (CheckinFileOperationCompleted == null)
		{
			CheckinFileOperationCompleted = OnCheckinFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("CheckinFile", new object[14]
		{
			fileMasterId, comment, keepCheckedOut, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, copyBom,
			newFileName, fileClassification, hidden, fileContents
		}, CheckinFileOperationCompleted, userState);
	}

	private void OnCheckinFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.CheckinFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.CheckinFileCompleted(this, new CheckinFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File CheckinUploadedFile(long fileMasterId, string comment, bool keepCheckedOut, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, bool copyBom, string newFileName, Guid uploadIdentifier, FileClassification fileClassification, bool hidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("CheckinUploadedFile", new object[14]
		{
			fileMasterId, comment, keepCheckedOut, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, copyBom,
			newFileName, uploadIdentifier, fileClassification, hidden
		});
		return (File)array[0];
	}

	public void CheckinUploadedFileAsync(long fileMasterId, string comment, bool keepCheckedOut, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, bool copyBom, string newFileName, Guid uploadIdentifier, FileClassification fileClassification, bool hidden)
	{
		CheckinUploadedFileAsync(fileMasterId, comment, keepCheckedOut, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, copyBom, newFileName, uploadIdentifier, fileClassification, hidden, null);
	}

	public void CheckinUploadedFileAsync(long fileMasterId, string comment, bool keepCheckedOut, DateTime lastWrite, long[] dependFileIds, string[] dependSources, long[] attachFileIds, string[] attachSources, BOM bom, bool copyBom, string newFileName, Guid uploadIdentifier, FileClassification fileClassification, bool hidden, object userState)
	{
		if (CheckinUploadedFileOperationCompleted == null)
		{
			CheckinUploadedFileOperationCompleted = OnCheckinUploadedFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("CheckinUploadedFile", new object[14]
		{
			fileMasterId, comment, keepCheckedOut, lastWrite, dependFileIds, dependSources, attachFileIds, attachSources, bom, copyBom,
			newFileName, uploadIdentifier, fileClassification, hidden
		}, CheckinUploadedFileOperationCompleted, userState);
	}

	private void OnCheckinUploadedFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.CheckinUploadedFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.CheckinUploadedFileCompleted(this, new CheckinUploadedFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File CheckoutFile(long folderId, long fileMasterId, string machine, string localPath, string comment, bool downloadFile, bool allowSync, [XmlElement(DataType = "base64Binary")] out byte[] fileContents)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("CheckoutFile", new object[7] { folderId, fileMasterId, machine, localPath, comment, downloadFile, allowSync });
		fileContents = (byte[])array[1];
		return (File)array[0];
	}

	public void CheckoutFileAsync(long folderId, long fileMasterId, string machine, string localPath, string comment, bool downloadFile, bool allowSync)
	{
		CheckoutFileAsync(folderId, fileMasterId, machine, localPath, comment, downloadFile, allowSync, null);
	}

	public void CheckoutFileAsync(long folderId, long fileMasterId, string machine, string localPath, string comment, bool downloadFile, bool allowSync, object userState)
	{
		if (CheckoutFileOperationCompleted == null)
		{
			CheckoutFileOperationCompleted = OnCheckoutFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("CheckoutFile", new object[7] { folderId, fileMasterId, machine, localPath, comment, downloadFile, allowSync }, CheckoutFileOperationCompleted, userState);
	}

	private void OnCheckoutFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.CheckoutFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.CheckoutFileCompleted(this, new CheckoutFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public File UndoCheckoutFile(long fileMasterId, bool downloadFile, [XmlElement(DataType = "base64Binary")] out byte[] fileContents)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("UndoCheckoutFile", new object[2] { fileMasterId, downloadFile });
		fileContents = (byte[])array[1];
		return (File)array[0];
	}

	public void UndoCheckoutFileAsync(long fileMasterId, bool downloadFile)
	{
		UndoCheckoutFileAsync(fileMasterId, downloadFile, null);
	}

	public void UndoCheckoutFileAsync(long fileMasterId, bool downloadFile, object userState)
	{
		if (UndoCheckoutFileOperationCompleted == null)
		{
			UndoCheckoutFileOperationCompleted = OnUndoCheckoutFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UndoCheckoutFile", new object[2] { fileMasterId, downloadFile }, UndoCheckoutFileOperationCompleted, userState);
	}

	private void OnUndoCheckoutFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UndoCheckoutFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UndoCheckoutFileCompleted(this, new UndoCheckoutFileCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void DeleteFileFromFolder(long fileMasterId, long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFileFromFolder", new object[2] { fileMasterId, folderId });
	}

	public void DeleteFileFromFolderAsync(long fileMasterId, long folderId)
	{
		DeleteFileFromFolderAsync(fileMasterId, folderId, null);
	}

	public void DeleteFileFromFolderAsync(long fileMasterId, long folderId, object userState)
	{
		if (DeleteFileFromFolderOperationCompleted == null)
		{
			DeleteFileFromFolderOperationCompleted = OnDeleteFileFromFolderOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileFromFolder", new object[2] { fileMasterId, folderId }, DeleteFileFromFolderOperationCompleted, userState);
	}

	private void OnDeleteFileFromFolderOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileFromFolderCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileFromFolderCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void DeleteFilesFromFolder(long[] fileMasterIds, long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFilesFromFolder", new object[2] { fileMasterIds, folderId });
	}

	public void DeleteFilesFromFolderAsync(long[] fileMasterIds, long folderId)
	{
		DeleteFilesFromFolderAsync(fileMasterIds, folderId, null);
	}

	public void DeleteFilesFromFolderAsync(long[] fileMasterIds, long folderId, object userState)
	{
		if (DeleteFilesFromFolderOperationCompleted == null)
		{
			DeleteFilesFromFolderOperationCompleted = OnDeleteFilesFromFolderOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFilesFromFolder", new object[2] { fileMasterIds, folderId }, DeleteFilesFromFolderOperationCompleted, userState);
	}

	private void OnDeleteFilesFromFolderOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFilesFromFolderCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFilesFromFolderCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void DeleteFileFromFolderUnconditional(long fileMasterId, long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFileFromFolderUnconditional", new object[2] { fileMasterId, folderId });
	}

	public void DeleteFileFromFolderUnconditionalAsync(long fileMasterId, long folderId)
	{
		DeleteFileFromFolderUnconditionalAsync(fileMasterId, folderId, null);
	}

	public void DeleteFileFromFolderUnconditionalAsync(long fileMasterId, long folderId, object userState)
	{
		if (DeleteFileFromFolderUnconditionalOperationCompleted == null)
		{
			DeleteFileFromFolderUnconditionalOperationCompleted = OnDeleteFileFromFolderUnconditionalOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileFromFolderUnconditional", new object[2] { fileMasterId, folderId }, DeleteFileFromFolderUnconditionalOperationCompleted, userState);
	}

	private void OnDeleteFileFromFolderUnconditionalOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileFromFolderUnconditionalCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileFromFolderUnconditionalCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void DeleteFilesFromFolderUnconditional(long[] fileMasterIds, long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFilesFromFolderUnconditional", new object[2] { fileMasterIds, folderId });
	}

	public void DeleteFilesFromFolderUnconditionalAsync(long[] fileMasterIds, long folderId)
	{
		DeleteFilesFromFolderUnconditionalAsync(fileMasterIds, folderId, null);
	}

	public void DeleteFilesFromFolderUnconditionalAsync(long[] fileMasterIds, long folderId, object userState)
	{
		if (DeleteFilesFromFolderUnconditionalOperationCompleted == null)
		{
			DeleteFilesFromFolderUnconditionalOperationCompleted = OnDeleteFilesFromFolderUnconditionalOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFilesFromFolderUnconditional", new object[2] { fileMasterIds, folderId }, DeleteFilesFromFolderUnconditionalOperationCompleted, userState);
	}

	private void OnDeleteFilesFromFolderUnconditionalOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFilesFromFolderUnconditionalCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFilesFromFolderUnconditionalCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileDelRestric[] GetFileDeleteRestrictionsByMasterId(long fileMasterId, long folderId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileDeleteRestrictionsByMasterId", new object[2] { fileMasterId, folderId });
		return (FileDelRestric[])array[0];
	}

	public void GetFileDeleteRestrictionsByMasterIdAsync(long fileMasterId, long folderId)
	{
		GetFileDeleteRestrictionsByMasterIdAsync(fileMasterId, folderId, null);
	}

	public void GetFileDeleteRestrictionsByMasterIdAsync(long fileMasterId, long folderId, object userState)
	{
		if (GetFileDeleteRestrictionsByMasterIdOperationCompleted == null)
		{
			GetFileDeleteRestrictionsByMasterIdOperationCompleted = OnGetFileDeleteRestrictionsByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileDeleteRestrictionsByMasterId", new object[2] { fileMasterId, folderId }, GetFileDeleteRestrictionsByMasterIdOperationCompleted, userState);
	}

	private void OnGetFileDeleteRestrictionsByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileDeleteRestrictionsByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileDeleteRestrictionsByMasterIdCompleted(this, new GetFileDeleteRestrictionsByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileDelRestricArray[] GetFileDeleteRestrictionsByMasterIds(long[] fileMasterIds, long[] folderIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileDeleteRestrictionsByMasterIds", new object[2] { fileMasterIds, folderIds });
		return (FileDelRestricArray[])array[0];
	}

	public void GetFileDeleteRestrictionsByMasterIdsAsync(long[] fileMasterIds, long[] folderIds)
	{
		GetFileDeleteRestrictionsByMasterIdsAsync(fileMasterIds, folderIds, null);
	}

	public void GetFileDeleteRestrictionsByMasterIdsAsync(long[] fileMasterIds, long[] folderIds, object userState)
	{
		if (GetFileDeleteRestrictionsByMasterIdsOperationCompleted == null)
		{
			GetFileDeleteRestrictionsByMasterIdsOperationCompleted = OnGetFileDeleteRestrictionsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileDeleteRestrictionsByMasterIds", new object[2] { fileMasterIds, folderIds }, GetFileDeleteRestrictionsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetFileDeleteRestrictionsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileDeleteRestrictionsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileDeleteRestrictionsByMasterIdsCompleted(this, new GetFileDeleteRestrictionsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void ShareFile(long fileMasterId, long folderId)
	{
		((SoapHttpClientProtocol)this).Invoke("ShareFile", new object[2] { fileMasterId, folderId });
	}

	public void ShareFileAsync(long fileMasterId, long folderId)
	{
		ShareFileAsync(fileMasterId, folderId, null);
	}

	public void ShareFileAsync(long fileMasterId, long folderId, object userState)
	{
		if (ShareFileOperationCompleted == null)
		{
			ShareFileOperationCompleted = OnShareFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("ShareFile", new object[2] { fileMasterId, folderId }, ShareFileOperationCompleted, userState);
	}

	private void OnShareFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.ShareFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.ShareFileCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void MoveFile(long fileMasterId, long srcFolderId, long dstFolderId)
	{
		((SoapHttpClientProtocol)this).Invoke("MoveFile", new object[3] { fileMasterId, srcFolderId, dstFolderId });
	}

	public void MoveFileAsync(long fileMasterId, long srcFolderId, long dstFolderId)
	{
		MoveFileAsync(fileMasterId, srcFolderId, dstFolderId, null);
	}

	public void MoveFileAsync(long fileMasterId, long srcFolderId, long dstFolderId, object userState)
	{
		if (MoveFileOperationCompleted == null)
		{
			MoveFileOperationCompleted = OnMoveFileOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("MoveFile", new object[3] { fileMasterId, srcFolderId, dstFolderId }, MoveFileOperationCompleted, userState);
	}

	private void OnMoveFileOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.MoveFileCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.MoveFileCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileAssocRestric[] GetFileAssociationRestrictionsById(long fileId, long[] dependFileIds, long[] attachFileIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileAssociationRestrictionsById", new object[3] { fileId, dependFileIds, attachFileIds });
		return (FileAssocRestric[])array[0];
	}

	public void GetFileAssociationRestrictionsByIdAsync(long fileId, long[] dependFileIds, long[] attachFileIds)
	{
		GetFileAssociationRestrictionsByIdAsync(fileId, dependFileIds, attachFileIds, null);
	}

	public void GetFileAssociationRestrictionsByIdAsync(long fileId, long[] dependFileIds, long[] attachFileIds, object userState)
	{
		if (GetFileAssociationRestrictionsByIdOperationCompleted == null)
		{
			GetFileAssociationRestrictionsByIdOperationCompleted = OnGetFileAssociationRestrictionsByIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileAssociationRestrictionsById", new object[3] { fileId, dependFileIds, attachFileIds }, GetFileAssociationRestrictionsByIdOperationCompleted, userState);
	}

	private void OnGetFileAssociationRestrictionsByIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileAssociationRestrictionsByIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileAssociationRestrictionsByIdCompleted(this, new GetFileAssociationRestrictionsByIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileRenameRestric[] GetFileRenameRestrictionsByMasterId(long fileMasterId, string newFileName)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileRenameRestrictionsByMasterId", new object[2] { fileMasterId, newFileName });
		return (FileRenameRestric[])array[0];
	}

	public void GetFileRenameRestrictionsByMasterIdAsync(long fileMasterId, string newFileName)
	{
		GetFileRenameRestrictionsByMasterIdAsync(fileMasterId, newFileName, null);
	}

	public void GetFileRenameRestrictionsByMasterIdAsync(long fileMasterId, string newFileName, object userState)
	{
		if (GetFileRenameRestrictionsByMasterIdOperationCompleted == null)
		{
			GetFileRenameRestrictionsByMasterIdOperationCompleted = OnGetFileRenameRestrictionsByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileRenameRestrictionsByMasterId", new object[2] { fileMasterId, newFileName }, GetFileRenameRestrictionsByMasterIdOperationCompleted, userState);
	}

	private void OnGetFileRenameRestrictionsByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileRenameRestrictionsByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileRenameRestrictionsByMasterIdCompleted(this, new GetFileRenameRestrictionsByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileRenameRestricArray[] GetFileRenameRestrictionsByMasterIds(long[] fileMasterIds, string[] newFileNames)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileRenameRestrictionsByMasterIds", new object[2] { fileMasterIds, newFileNames });
		return (FileRenameRestricArray[])array[0];
	}

	public void GetFileRenameRestrictionsByMasterIdsAsync(long[] fileMasterIds, string[] newFileNames)
	{
		GetFileRenameRestrictionsByMasterIdsAsync(fileMasterIds, newFileNames, null);
	}

	public void GetFileRenameRestrictionsByMasterIdsAsync(long[] fileMasterIds, string[] newFileNames, object userState)
	{
		if (GetFileRenameRestrictionsByMasterIdsOperationCompleted == null)
		{
			GetFileRenameRestrictionsByMasterIdsOperationCompleted = OnGetFileRenameRestrictionsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileRenameRestrictionsByMasterIds", new object[2] { fileMasterIds, newFileNames }, GetFileRenameRestrictionsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetFileRenameRestrictionsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileRenameRestrictionsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileRenameRestrictionsByMasterIdsCompleted(this, new GetFileRenameRestrictionsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File[] FindFilesBySearchConditions(long[] folderIds, bool recurseFolders, SrchCond[] conditions, bool latestOnly, bool includeCheckedOutVersions)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFilesBySearchConditions", new object[5] { folderIds, recurseFolders, conditions, latestOnly, includeCheckedOutVersions });
		return (File[])array[0];
	}

	public void FindFilesBySearchConditionsAsync(long[] folderIds, bool recurseFolders, SrchCond[] conditions, bool latestOnly, bool includeCheckedOutVersions)
	{
		FindFilesBySearchConditionsAsync(folderIds, recurseFolders, conditions, latestOnly, includeCheckedOutVersions, null);
	}

	public void FindFilesBySearchConditionsAsync(long[] folderIds, bool recurseFolders, SrchCond[] conditions, bool latestOnly, bool includeCheckedOutVersions, object userState)
	{
		if (FindFilesBySearchConditionsOperationCompleted == null)
		{
			FindFilesBySearchConditionsOperationCompleted = OnFindFilesBySearchConditionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFilesBySearchConditions", new object[5] { folderIds, recurseFolders, conditions, latestOnly, includeCheckedOutVersions }, FindFilesBySearchConditionsOperationCompleted, userState);
	}

	private void OnFindFilesBySearchConditionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFilesBySearchConditionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFilesBySearchConditionsCompleted(this, new FindFilesBySearchConditionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public BOM GetBOMByFileId(long fileId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetBOMByFileId", new object[1] { fileId });
		return (BOM)array[0];
	}

	public void GetBOMByFileIdAsync(long fileId)
	{
		GetBOMByFileIdAsync(fileId, null);
	}

	public void GetBOMByFileIdAsync(long fileId, object userState)
	{
		if (GetBOMByFileIdOperationCompleted == null)
		{
			GetBOMByFileIdOperationCompleted = OnGetBOMByFileIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetBOMByFileId", new object[1] { fileId }, GetBOMByFileIdOperationCompleted, userState);
	}

	private void OnGetBOMByFileIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetBOMByFileIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetBOMByFileIdCompleted(this, new GetBOMByFileIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public BOM[] GetBOMByFileIds(long[] fileIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetBOMByFileIds", new object[1] { fileIds });
		return (BOM[])array[0];
	}

	public void GetBOMByFileIdsAsync(long[] fileIds)
	{
		GetBOMByFileIdsAsync(fileIds, null);
	}

	public void GetBOMByFileIdsAsync(long[] fileIds, object userState)
	{
		if (GetBOMByFileIdsOperationCompleted == null)
		{
			GetBOMByFileIdsOperationCompleted = OnGetBOMByFileIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetBOMByFileIds", new object[1] { fileIds }, GetBOMByFileIdsOperationCompleted, userState);
	}

	private void OnGetBOMByFileIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetBOMByFileIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetBOMByFileIdsCompleted(this, new GetBOMByFileIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public PropDef[] GetAllPropertyDefinitions()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAllPropertyDefinitions", new object[0]);
		return (PropDef[])array[0];
	}

	public void GetAllPropertyDefinitionsAsync()
	{
		GetAllPropertyDefinitionsAsync(null);
	}

	public void GetAllPropertyDefinitionsAsync(object userState)
	{
		if (GetAllPropertyDefinitionsOperationCompleted == null)
		{
			GetAllPropertyDefinitionsOperationCompleted = OnGetAllPropertyDefinitionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAllPropertyDefinitions", new object[0], GetAllPropertyDefinitionsOperationCompleted, userState);
	}

	private void OnGetAllPropertyDefinitionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAllPropertyDefinitionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAllPropertyDefinitionsCompleted(this, new GetAllPropertyDefinitionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public PropDef[] GetAllPropertyDefinitionsExtended()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAllPropertyDefinitionsExtended", new object[0]);
		return (PropDef[])array[0];
	}

	public void GetAllPropertyDefinitionsExtendedAsync()
	{
		GetAllPropertyDefinitionsExtendedAsync(null);
	}

	public void GetAllPropertyDefinitionsExtendedAsync(object userState)
	{
		if (GetAllPropertyDefinitionsExtendedOperationCompleted == null)
		{
			GetAllPropertyDefinitionsExtendedOperationCompleted = OnGetAllPropertyDefinitionsExtendedOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAllPropertyDefinitionsExtended", new object[0], GetAllPropertyDefinitionsExtendedOperationCompleted, userState);
	}

	private void OnGetAllPropertyDefinitionsExtendedOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAllPropertyDefinitionsExtendedCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAllPropertyDefinitionsExtendedCompleted(this, new GetAllPropertyDefinitionsExtendedCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public PropDef[] FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypes(string[] propertySetIds, string[] propIds, string[] types)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypes", new object[3] { propertySetIds, propIds, types });
		return (PropDef[])array[0];
	}

	public void FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesAsync(string[] propertySetIds, string[] propIds, string[] types)
	{
		FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesAsync(propertySetIds, propIds, types, null);
	}

	public void FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesAsync(string[] propertySetIds, string[] propIds, string[] types, object userState)
	{
		if (FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesOperationCompleted == null)
		{
			FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesOperationCompleted = OnFindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypes", new object[3] { propertySetIds, propIds, types }, FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesOperationCompleted, userState);
	}

	private void OnFindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesCompleted(this, new FindPropertyDefinitionsByPropertySetIdsPropIdsAndDataTypesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public PropDef SetPropertyDefinitionDisplayName(long propertyDefinitionId, string displayName)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("SetPropertyDefinitionDisplayName", new object[2] { propertyDefinitionId, displayName });
		return (PropDef)array[0];
	}

	public void SetPropertyDefinitionDisplayNameAsync(long propertyDefinitionId, string displayName)
	{
		SetPropertyDefinitionDisplayNameAsync(propertyDefinitionId, displayName, null);
	}

	public void SetPropertyDefinitionDisplayNameAsync(long propertyDefinitionId, string displayName, object userState)
	{
		if (SetPropertyDefinitionDisplayNameOperationCompleted == null)
		{
			SetPropertyDefinitionDisplayNameOperationCompleted = OnSetPropertyDefinitionDisplayNameOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetPropertyDefinitionDisplayName", new object[2] { propertyDefinitionId, displayName }, SetPropertyDefinitionDisplayNameOperationCompleted, userState);
	}

	private void OnSetPropertyDefinitionDisplayNameOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetPropertyDefinitionDisplayNameCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetPropertyDefinitionDisplayNameCompleted(this, new SetPropertyDefinitionDisplayNameCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public PropDef[] SetPropertyDefinitionsDisplayNames(long[] propertyDefinitionIds, string[] displayNames)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("SetPropertyDefinitionsDisplayNames", new object[2] { propertyDefinitionIds, displayNames });
		return (PropDef[])array[0];
	}

	public void SetPropertyDefinitionsDisplayNamesAsync(long[] propertyDefinitionIds, string[] displayNames)
	{
		SetPropertyDefinitionsDisplayNamesAsync(propertyDefinitionIds, displayNames, null);
	}

	public void SetPropertyDefinitionsDisplayNamesAsync(long[] propertyDefinitionIds, string[] displayNames, object userState)
	{
		if (SetPropertyDefinitionsDisplayNamesOperationCompleted == null)
		{
			SetPropertyDefinitionsDisplayNamesOperationCompleted = OnSetPropertyDefinitionsDisplayNamesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetPropertyDefinitionsDisplayNames", new object[2] { propertyDefinitionIds, displayNames }, SetPropertyDefinitionsDisplayNamesOperationCompleted, userState);
	}

	private void OnSetPropertyDefinitionsDisplayNamesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetPropertyDefinitionsDisplayNamesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetPropertyDefinitionsDisplayNamesCompleted(this, new SetPropertyDefinitionsDisplayNamesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public PropInst[] GetProperties(long[] fileIds, long[] propertyDefinitionIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetProperties", new object[2] { fileIds, propertyDefinitionIds });
		return (PropInst[])array[0];
	}

	public void GetPropertiesAsync(long[] fileIds, long[] propertyDefinitionIds)
	{
		GetPropertiesAsync(fileIds, propertyDefinitionIds, null);
	}

	public void GetPropertiesAsync(long[] fileIds, long[] propertyDefinitionIds, object userState)
	{
		if (GetPropertiesOperationCompleted == null)
		{
			GetPropertiesOperationCompleted = OnGetPropertiesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetProperties", new object[2] { fileIds, propertyDefinitionIds }, GetPropertiesOperationCompleted, userState);
	}

	private void OnGetPropertiesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetPropertiesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetPropertiesCompleted(this, new GetPropertiesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileFolder[] FindFileFoldersBySearchConditions(long[] folderIds, bool recurseFolders, SrchCond[] conditions, bool latestOnly, bool includeCheckedOutVersions)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindFileFoldersBySearchConditions", new object[5] { folderIds, recurseFolders, conditions, latestOnly, includeCheckedOutVersions });
		return (FileFolder[])array[0];
	}

	public void FindFileFoldersBySearchConditionsAsync(long[] folderIds, bool recurseFolders, SrchCond[] conditions, bool latestOnly, bool includeCheckedOutVersions)
	{
		FindFileFoldersBySearchConditionsAsync(folderIds, recurseFolders, conditions, latestOnly, includeCheckedOutVersions, null);
	}

	public void FindFileFoldersBySearchConditionsAsync(long[] folderIds, bool recurseFolders, SrchCond[] conditions, bool latestOnly, bool includeCheckedOutVersions, object userState)
	{
		if (FindFileFoldersBySearchConditionsOperationCompleted == null)
		{
			FindFileFoldersBySearchConditionsOperationCompleted = OnFindFileFoldersBySearchConditionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindFileFoldersBySearchConditions", new object[5] { folderIds, recurseFolders, conditions, latestOnly, includeCheckedOutVersions }, FindFileFoldersBySearchConditionsOperationCompleted, userState);
	}

	private void OnFindFileFoldersBySearchConditionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindFileFoldersBySearchConditionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindFileFoldersBySearchConditionsCompleted(this, new FindFileFoldersBySearchConditionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public PropGrp[] GetAllPropertyGroups()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAllPropertyGroups", new object[0]);
		return (PropGrp[])array[0];
	}

	public void GetAllPropertyGroupsAsync()
	{
		GetAllPropertyGroupsAsync(null);
	}

	public void GetAllPropertyGroupsAsync(object userState)
	{
		if (GetAllPropertyGroupsOperationCompleted == null)
		{
			GetAllPropertyGroupsOperationCompleted = OnGetAllPropertyGroupsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAllPropertyGroups", new object[0], GetAllPropertyGroupsOperationCompleted, userState);
	}

	private void OnGetAllPropertyGroupsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAllPropertyGroupsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAllPropertyGroupsCompleted(this, new GetAllPropertyGroupsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public PropGrp AddPropertyGroup(string displayName, string documentColumnName, int state, long[] propertyDefIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddPropertyGroup", new object[4] { displayName, documentColumnName, state, propertyDefIds });
		return (PropGrp)array[0];
	}

	public void AddPropertyGroupAsync(string displayName, string documentColumnName, int state, long[] propertyDefIds)
	{
		AddPropertyGroupAsync(displayName, documentColumnName, state, propertyDefIds, null);
	}

	public void AddPropertyGroupAsync(string displayName, string documentColumnName, int state, long[] propertyDefIds, object userState)
	{
		if (AddPropertyGroupOperationCompleted == null)
		{
			AddPropertyGroupOperationCompleted = OnAddPropertyGroupOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddPropertyGroup", new object[4] { displayName, documentColumnName, state, propertyDefIds }, AddPropertyGroupOperationCompleted, userState);
	}

	private void OnAddPropertyGroupOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddPropertyGroupCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddPropertyGroupCompleted(this, new AddPropertyGroupCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void UpdatePropertyGroup(PropGrp propertyGroup)
	{
		((SoapHttpClientProtocol)this).Invoke("UpdatePropertyGroup", new object[1] { propertyGroup });
	}

	public void UpdatePropertyGroupAsync(PropGrp propertyGroup)
	{
		UpdatePropertyGroupAsync(propertyGroup, null);
	}

	public void UpdatePropertyGroupAsync(PropGrp propertyGroup, object userState)
	{
		if (UpdatePropertyGroupOperationCompleted == null)
		{
			UpdatePropertyGroupOperationCompleted = OnUpdatePropertyGroupOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdatePropertyGroup", new object[1] { propertyGroup }, UpdatePropertyGroupOperationCompleted, userState);
	}

	private void OnUpdatePropertyGroupOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdatePropertyGroupCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdatePropertyGroupCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void UpdatePropertyGroups(PropGrp[] propertyGroups)
	{
		((SoapHttpClientProtocol)this).Invoke("UpdatePropertyGroups", new object[1] { propertyGroups });
	}

	public void UpdatePropertyGroupsAsync(PropGrp[] propertyGroups)
	{
		UpdatePropertyGroupsAsync(propertyGroups, null);
	}

	public void UpdatePropertyGroupsAsync(PropGrp[] propertyGroups, object userState)
	{
		if (UpdatePropertyGroupsOperationCompleted == null)
		{
			UpdatePropertyGroupsOperationCompleted = OnUpdatePropertyGroupsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdatePropertyGroups", new object[1] { propertyGroups }, UpdatePropertyGroupsOperationCompleted, userState);
	}

	private void OnUpdatePropertyGroupsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdatePropertyGroupsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdatePropertyGroupsCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void DeletePropertyGroup(long propertyGroupId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeletePropertyGroup", new object[1] { propertyGroupId });
	}

	public void DeletePropertyGroupAsync(long propertyGroupId)
	{
		DeletePropertyGroupAsync(propertyGroupId, null);
	}

	public void DeletePropertyGroupAsync(long propertyGroupId, object userState)
	{
		if (DeletePropertyGroupOperationCompleted == null)
		{
			DeletePropertyGroupOperationCompleted = OnDeletePropertyGroupOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeletePropertyGroup", new object[1] { propertyGroupId }, DeletePropertyGroupOperationCompleted, userState);
	}

	private void OnDeletePropertyGroupOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeletePropertyGroupCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeletePropertyGroupCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void DeletePropertyGroups(long[] propertyGroupIds)
	{
		((SoapHttpClientProtocol)this).Invoke("DeletePropertyGroups", new object[1] { propertyGroupIds });
	}

	public void DeletePropertyGroupsAsync(long[] propertyGroupIds)
	{
		DeletePropertyGroupsAsync(propertyGroupIds, null);
	}

	public void DeletePropertyGroupsAsync(long[] propertyGroupIds, object userState)
	{
		if (DeletePropertyGroupsOperationCompleted == null)
		{
			DeletePropertyGroupsOperationCompleted = OnDeletePropertyGroupsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeletePropertyGroups", new object[1] { propertyGroupIds }, DeletePropertyGroupsOperationCompleted, userState);
	}

	private void OnDeletePropertyGroupsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeletePropertyGroupsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeletePropertyGroupsCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void VoidPropertyDefinitions(long[] propertyDefinitions)
	{
		((SoapHttpClientProtocol)this).Invoke("VoidPropertyDefinitions", new object[1] { propertyDefinitions });
	}

	public void VoidPropertyDefinitionsAsync(long[] propertyDefinitions)
	{
		VoidPropertyDefinitionsAsync(propertyDefinitions, null);
	}

	public void VoidPropertyDefinitionsAsync(long[] propertyDefinitions, object userState)
	{
		if (VoidPropertyDefinitionsOperationCompleted == null)
		{
			VoidPropertyDefinitionsOperationCompleted = OnVoidPropertyDefinitionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("VoidPropertyDefinitions", new object[1] { propertyDefinitions }, VoidPropertyDefinitionsOperationCompleted, userState);
	}

	private void OnVoidPropertyDefinitionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.VoidPropertyDefinitionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.VoidPropertyDefinitionsCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void UnvoidPropertyDefinitions(long[] propertyDefinitions)
	{
		((SoapHttpClientProtocol)this).Invoke("UnvoidPropertyDefinitions", new object[1] { propertyDefinitions });
	}

	public void UnvoidPropertyDefinitionsAsync(long[] propertyDefinitions)
	{
		UnvoidPropertyDefinitionsAsync(propertyDefinitions, null);
	}

	public void UnvoidPropertyDefinitionsAsync(long[] propertyDefinitions, object userState)
	{
		if (UnvoidPropertyDefinitionsOperationCompleted == null)
		{
			UnvoidPropertyDefinitionsOperationCompleted = OnUnvoidPropertyDefinitionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UnvoidPropertyDefinitions", new object[1] { propertyDefinitions }, UnvoidPropertyDefinitionsOperationCompleted, userState);
	}

	private void OnUnvoidPropertyDefinitionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UnvoidPropertyDefinitionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UnvoidPropertyDefinitionsCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void ReIndexProperties()
	{
		((SoapHttpClientProtocol)this).Invoke("ReIndexProperties", new object[0]);
	}

	public void ReIndexPropertiesAsync()
	{
		ReIndexPropertiesAsync(null);
	}

	public void ReIndexPropertiesAsync(object userState)
	{
		if (ReIndexPropertiesOperationCompleted == null)
		{
			ReIndexPropertiesOperationCompleted = OnReIndexPropertiesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("ReIndexProperties", new object[0], ReIndexPropertiesOperationCompleted, userState);
	}

	private void OnReIndexPropertiesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.ReIndexPropertiesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.ReIndexPropertiesCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Label[] GetAllLabels()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAllLabels", new object[0]);
		return (Label[])array[0];
	}

	public void GetAllLabelsAsync()
	{
		GetAllLabelsAsync(null);
	}

	public void GetAllLabelsAsync(object userState)
	{
		if (GetAllLabelsOperationCompleted == null)
		{
			GetAllLabelsOperationCompleted = OnGetAllLabelsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAllLabels", new object[0], GetAllLabelsOperationCompleted, userState);
	}

	private void OnGetAllLabelsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAllLabelsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAllLabelsCompleted(this, new GetAllLabelsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Label FindLabelByName(string labelName)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindLabelByName", new object[1] { labelName });
		return (Label)array[0];
	}

	public void FindLabelByNameAsync(string labelName)
	{
		FindLabelByNameAsync(labelName, null);
	}

	public void FindLabelByNameAsync(string labelName, object userState)
	{
		if (FindLabelByNameOperationCompleted == null)
		{
			FindLabelByNameOperationCompleted = OnFindLabelByNameOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindLabelByName", new object[1] { labelName }, FindLabelByNameOperationCompleted, userState);
	}

	private void OnFindLabelByNameOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindLabelByNameCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindLabelByNameCompleted(this, new FindLabelByNameCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Label[] FindLabelsByNames(string[] labelNames)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FindLabelsByNames", new object[1] { labelNames });
		return (Label[])array[0];
	}

	public void FindLabelsByNamesAsync(string[] labelNames)
	{
		FindLabelsByNamesAsync(labelNames, null);
	}

	public void FindLabelsByNamesAsync(string[] labelNames, object userState)
	{
		if (FindLabelsByNamesOperationCompleted == null)
		{
			FindLabelsByNamesOperationCompleted = OnFindLabelsByNamesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("FindLabelsByNames", new object[1] { labelNames }, FindLabelsByNamesOperationCompleted, userState);
	}

	private void OnFindLabelsByNamesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.FindLabelsByNamesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.FindLabelsByNamesCompleted(this, new FindLabelsByNamesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public Label AddLabel(long folderId, string labelName, string comment)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddLabel", new object[3] { folderId, labelName, comment });
		return (Label)array[0];
	}

	public void AddLabelAsync(long folderId, string labelName, string comment)
	{
		AddLabelAsync(folderId, labelName, comment, null);
	}

	public void AddLabelAsync(long folderId, string labelName, string comment, object userState)
	{
		if (AddLabelOperationCompleted == null)
		{
			AddLabelOperationCompleted = OnAddLabelOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddLabel", new object[3] { folderId, labelName, comment }, AddLabelOperationCompleted, userState);
	}

	private void OnAddLabelOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddLabelCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddLabelCompleted(this, new AddLabelCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void DeleteLabel(long labelId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteLabel", new object[1] { labelId });
	}

	public void DeleteLabelAsync(long labelId)
	{
		DeleteLabelAsync(labelId, null);
	}

	public void DeleteLabelAsync(long labelId, object userState)
	{
		if (DeleteLabelOperationCompleted == null)
		{
			DeleteLabelOperationCompleted = OnDeleteLabelOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteLabel", new object[1] { labelId }, DeleteLabelOperationCompleted, userState);
	}

	private void OnDeleteLabelOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteLabelCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteLabelCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public Label UpdateLabel(long labelId, string labelName, string comment)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("UpdateLabel", new object[3] { labelId, labelName, comment });
		return (Label)array[0];
	}

	public void UpdateLabelAsync(long labelId, string labelName, string comment)
	{
		UpdateLabelAsync(labelId, labelName, comment, null);
	}

	public void UpdateLabelAsync(long labelId, string labelName, string comment, object userState)
	{
		if (UpdateLabelOperationCompleted == null)
		{
			UpdateLabelOperationCompleted = OnUpdateLabelOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdateLabel", new object[3] { labelId, labelName, comment }, UpdateLabelOperationCompleted, userState);
	}

	private void OnUpdateLabelOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdateLabelCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdateLabelCompleted(this, new UpdateLabelCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileFolder[] GetFileFoldersByLabelId(long labelId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileFoldersByLabelId", new object[1] { labelId });
		return (FileFolder[])array[0];
	}

	public void GetFileFoldersByLabelIdAsync(long labelId)
	{
		GetFileFoldersByLabelIdAsync(labelId, null);
	}

	public void GetFileFoldersByLabelIdAsync(long labelId, object userState)
	{
		if (GetFileFoldersByLabelIdOperationCompleted == null)
		{
			GetFileFoldersByLabelIdOperationCompleted = OnGetFileFoldersByLabelIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileFoldersByLabelId", new object[1] { labelId }, GetFileFoldersByLabelIdOperationCompleted, userState);
	}

	private void OnGetFileFoldersByLabelIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileFoldersByLabelIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileFoldersByLabelIdCompleted(this, new GetFileFoldersByLabelIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void MoveFolder(long folderId, long newParentFolderId)
	{
		((SoapHttpClientProtocol)this).Invoke("MoveFolder", new object[2] { folderId, newParentFolderId });
	}

	public void MoveFolderAsync(long folderId, long newParentFolderId)
	{
		MoveFolderAsync(folderId, newParentFolderId, null);
	}

	public void MoveFolderAsync(long folderId, long newParentFolderId, object userState)
	{
		if (MoveFolderOperationCompleted == null)
		{
			MoveFolderOperationCompleted = OnMoveFolderOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("MoveFolder", new object[2] { folderId, newParentFolderId }, MoveFolderOperationCompleted, userState);
	}

	private void OnMoveFolderOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.MoveFolderCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.MoveFolderCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public DocRestric[] GetFolderMoveRestrictions(long folderId, long newParentFolderId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderMoveRestrictions", new object[2] { folderId, newParentFolderId });
		return (DocRestric[])array[0];
	}

	public void GetFolderMoveRestrictionsAsync(long folderId, long newParentFolderId)
	{
		GetFolderMoveRestrictionsAsync(folderId, newParentFolderId, null);
	}

	public void GetFolderMoveRestrictionsAsync(long folderId, long newParentFolderId, object userState)
	{
		if (GetFolderMoveRestrictionsOperationCompleted == null)
		{
			GetFolderMoveRestrictionsOperationCompleted = OnGetFolderMoveRestrictionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderMoveRestrictions", new object[2] { folderId, newParentFolderId }, GetFolderMoveRestrictionsOperationCompleted, userState);
	}

	private void OnGetFolderMoveRestrictionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderMoveRestrictionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderMoveRestrictionsCompleted(this, new GetFolderMoveRestrictionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public DocRestric[] GetFolderRenameRestrictions(long folderId, string newFolderName)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFolderRenameRestrictions", new object[2] { folderId, newFolderName });
		return (DocRestric[])array[0];
	}

	public void GetFolderRenameRestrictionsAsync(long folderId, string newFolderName)
	{
		GetFolderRenameRestrictionsAsync(folderId, newFolderName, null);
	}

	public void GetFolderRenameRestrictionsAsync(long folderId, string newFolderName, object userState)
	{
		if (GetFolderRenameRestrictionsOperationCompleted == null)
		{
			GetFolderRenameRestrictionsOperationCompleted = OnGetFolderRenameRestrictionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFolderRenameRestrictions", new object[2] { folderId, newFolderName }, GetFolderRenameRestrictionsOperationCompleted, userState);
	}

	private void OnGetFolderRenameRestrictionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFolderRenameRestrictionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFolderRenameRestrictionsCompleted(this, new GetFolderRenameRestrictionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public bool GetUniqueFileNameRequired()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetUniqueFileNameRequired", new object[0]);
		return (bool)array[0];
	}

	public void GetUniqueFileNameRequiredAsync()
	{
		GetUniqueFileNameRequiredAsync(null);
	}

	public void GetUniqueFileNameRequiredAsync(object userState)
	{
		if (GetUniqueFileNameRequiredOperationCompleted == null)
		{
			GetUniqueFileNameRequiredOperationCompleted = OnGetUniqueFileNameRequiredOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetUniqueFileNameRequired", new object[0], GetUniqueFileNameRequiredOperationCompleted, userState);
	}

	private void OnGetUniqueFileNameRequiredOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetUniqueFileNameRequiredCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetUniqueFileNameRequiredCompleted(this, new GetUniqueFileNameRequiredCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void SetUniqueFileNameRequired(bool required)
	{
		((SoapHttpClientProtocol)this).Invoke("SetUniqueFileNameRequired", new object[1] { required });
	}

	public void SetUniqueFileNameRequiredAsync(bool required)
	{
		SetUniqueFileNameRequiredAsync(required, null);
	}

	public void SetUniqueFileNameRequiredAsync(bool required, object userState)
	{
		if (SetUniqueFileNameRequiredOperationCompleted == null)
		{
			SetUniqueFileNameRequiredOperationCompleted = OnSetUniqueFileNameRequiredOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetUniqueFileNameRequired", new object[1] { required }, SetUniqueFileNameRequiredOperationCompleted, userState);
	}

	private void OnSetUniqueFileNameRequiredOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetUniqueFileNameRequiredCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetUniqueFileNameRequiredCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public bool GetEnableDWFAttachment()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetEnableDWFAttachment", new object[0]);
		return (bool)array[0];
	}

	public void GetEnableDWFAttachmentAsync()
	{
		GetEnableDWFAttachmentAsync(null);
	}

	public void GetEnableDWFAttachmentAsync(object userState)
	{
		if (GetEnableDWFAttachmentOperationCompleted == null)
		{
			GetEnableDWFAttachmentOperationCompleted = OnGetEnableDWFAttachmentOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetEnableDWFAttachment", new object[0], GetEnableDWFAttachmentOperationCompleted, userState);
	}

	private void OnGetEnableDWFAttachmentOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetEnableDWFAttachmentCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetEnableDWFAttachmentCompleted(this, new GetEnableDWFAttachmentCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SetEnableDWFAttachment(bool enabled)
	{
		((SoapHttpClientProtocol)this).Invoke("SetEnableDWFAttachment", new object[1] { enabled });
	}

	public void SetEnableDWFAttachmentAsync(bool enabled)
	{
		SetEnableDWFAttachmentAsync(enabled, null);
	}

	public void SetEnableDWFAttachmentAsync(bool enabled, object userState)
	{
		if (SetEnableDWFAttachmentOperationCompleted == null)
		{
			SetEnableDWFAttachmentOperationCompleted = OnSetEnableDWFAttachmentOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetEnableDWFAttachment", new object[1] { enabled }, SetEnableDWFAttachmentOperationCompleted, userState);
	}

	private void OnSetEnableDWFAttachmentOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetEnableDWFAttachmentCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetEnableDWFAttachmentCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string GetDWFPublishFolderLocation()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetDWFPublishFolderLocation", new object[0]);
		return (string)array[0];
	}

	public void GetDWFPublishFolderLocationAsync()
	{
		GetDWFPublishFolderLocationAsync(null);
	}

	public void GetDWFPublishFolderLocationAsync(object userState)
	{
		if (GetDWFPublishFolderLocationOperationCompleted == null)
		{
			GetDWFPublishFolderLocationOperationCompleted = OnGetDWFPublishFolderLocationOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetDWFPublishFolderLocation", new object[0], GetDWFPublishFolderLocationOperationCompleted, userState);
	}

	private void OnGetDWFPublishFolderLocationOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetDWFPublishFolderLocationCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetDWFPublishFolderLocationCompleted(this, new GetDWFPublishFolderLocationCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void SetDWFPublishFolderLocation(string location)
	{
		((SoapHttpClientProtocol)this).Invoke("SetDWFPublishFolderLocation", new object[1] { location });
	}

	public void SetDWFPublishFolderLocationAsync(string location)
	{
		SetDWFPublishFolderLocationAsync(location, null);
	}

	public void SetDWFPublishFolderLocationAsync(string location, object userState)
	{
		if (SetDWFPublishFolderLocationOperationCompleted == null)
		{
			SetDWFPublishFolderLocationOperationCompleted = OnSetDWFPublishFolderLocationOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetDWFPublishFolderLocation", new object[1] { location }, SetDWFPublishFolderLocationOperationCompleted, userState);
	}

	private void OnSetDWFPublishFolderLocationOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetDWFPublishFolderLocationCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetDWFPublishFolderLocationCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public bool GetDWFPublishPreserveFolderHierarchy()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetDWFPublishPreserveFolderHierarchy", new object[0]);
		return (bool)array[0];
	}

	public void GetDWFPublishPreserveFolderHierarchyAsync()
	{
		GetDWFPublishPreserveFolderHierarchyAsync(null);
	}

	public void GetDWFPublishPreserveFolderHierarchyAsync(object userState)
	{
		if (GetDWFPublishPreserveFolderHierarchyOperationCompleted == null)
		{
			GetDWFPublishPreserveFolderHierarchyOperationCompleted = OnGetDWFPublishPreserveFolderHierarchyOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetDWFPublishPreserveFolderHierarchy", new object[0], GetDWFPublishPreserveFolderHierarchyOperationCompleted, userState);
	}

	private void OnGetDWFPublishPreserveFolderHierarchyOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetDWFPublishPreserveFolderHierarchyCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetDWFPublishPreserveFolderHierarchyCompleted(this, new GetDWFPublishPreserveFolderHierarchyCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SetDWFPublishPreserveFolderHierarchy(bool preserve)
	{
		((SoapHttpClientProtocol)this).Invoke("SetDWFPublishPreserveFolderHierarchy", new object[1] { preserve });
	}

	public void SetDWFPublishPreserveFolderHierarchyAsync(bool preserve)
	{
		SetDWFPublishPreserveFolderHierarchyAsync(preserve, null);
	}

	public void SetDWFPublishPreserveFolderHierarchyAsync(bool preserve, object userState)
	{
		if (SetDWFPublishPreserveFolderHierarchyOperationCompleted == null)
		{
			SetDWFPublishPreserveFolderHierarchyOperationCompleted = OnSetDWFPublishPreserveFolderHierarchyOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetDWFPublishPreserveFolderHierarchy", new object[1] { preserve }, SetDWFPublishPreserveFolderHierarchyOperationCompleted, userState);
	}

	private void OnSetDWFPublishPreserveFolderHierarchyOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetDWFPublishPreserveFolderHierarchyCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetDWFPublishPreserveFolderHierarchyCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public bool GetEnforceWorkingFolder()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetEnforceWorkingFolder", new object[0]);
		return (bool)array[0];
	}

	public void GetEnforceWorkingFolderAsync()
	{
		GetEnforceWorkingFolderAsync(null);
	}

	public void GetEnforceWorkingFolderAsync(object userState)
	{
		if (GetEnforceWorkingFolderOperationCompleted == null)
		{
			GetEnforceWorkingFolderOperationCompleted = OnGetEnforceWorkingFolderOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetEnforceWorkingFolder", new object[0], GetEnforceWorkingFolderOperationCompleted, userState);
	}

	private void OnGetEnforceWorkingFolderOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetEnforceWorkingFolderCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetEnforceWorkingFolderCompleted(this, new GetEnforceWorkingFolderCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SetEnforceWorkingFolder(bool enforce)
	{
		((SoapHttpClientProtocol)this).Invoke("SetEnforceWorkingFolder", new object[1] { enforce });
	}

	public void SetEnforceWorkingFolderAsync(bool enforce)
	{
		SetEnforceWorkingFolderAsync(enforce, null);
	}

	public void SetEnforceWorkingFolderAsync(bool enforce, object userState)
	{
		if (SetEnforceWorkingFolderOperationCompleted == null)
		{
			SetEnforceWorkingFolderOperationCompleted = OnSetEnforceWorkingFolderOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetEnforceWorkingFolder", new object[1] { enforce }, SetEnforceWorkingFolderOperationCompleted, userState);
	}

	private void OnSetEnforceWorkingFolderOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetEnforceWorkingFolderCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetEnforceWorkingFolderCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public string GetRequiredWorkingFolderLocation()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetRequiredWorkingFolderLocation", new object[0]);
		return (string)array[0];
	}

	public void GetRequiredWorkingFolderLocationAsync()
	{
		GetRequiredWorkingFolderLocationAsync(null);
	}

	public void GetRequiredWorkingFolderLocationAsync(object userState)
	{
		if (GetRequiredWorkingFolderLocationOperationCompleted == null)
		{
			GetRequiredWorkingFolderLocationOperationCompleted = OnGetRequiredWorkingFolderLocationOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetRequiredWorkingFolderLocation", new object[0], GetRequiredWorkingFolderLocationOperationCompleted, userState);
	}

	private void OnGetRequiredWorkingFolderLocationOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetRequiredWorkingFolderLocationCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetRequiredWorkingFolderLocationCompleted(this, new GetRequiredWorkingFolderLocationCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SetRequiredWorkingFolderLocation(string location)
	{
		((SoapHttpClientProtocol)this).Invoke("SetRequiredWorkingFolderLocation", new object[1] { location });
	}

	public void SetRequiredWorkingFolderLocationAsync(string location)
	{
		SetRequiredWorkingFolderLocationAsync(location, null);
	}

	public void SetRequiredWorkingFolderLocationAsync(string location, object userState)
	{
		if (SetRequiredWorkingFolderLocationOperationCompleted == null)
		{
			SetRequiredWorkingFolderLocationOperationCompleted = OnSetRequiredWorkingFolderLocationOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetRequiredWorkingFolderLocation", new object[1] { location }, SetRequiredWorkingFolderLocationOperationCompleted, userState);
	}

	private void OnSetRequiredWorkingFolderLocationOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetRequiredWorkingFolderLocationCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetRequiredWorkingFolderLocationCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileAssoc[] GetLatestFileAssociationsByMasterId(long fileMasterId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFileAssociationsByMasterId", new object[4] { fileMasterId, relation, recurse, includeHidden });
		return (FileAssoc[])array[0];
	}

	public void GetLatestFileAssociationsByMasterIdAsync(long fileMasterId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetLatestFileAssociationsByMasterIdAsync(fileMasterId, relation, recurse, includeHidden, null);
	}

	public void GetLatestFileAssociationsByMasterIdAsync(long fileMasterId, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetLatestFileAssociationsByMasterIdOperationCompleted == null)
		{
			GetLatestFileAssociationsByMasterIdOperationCompleted = OnGetLatestFileAssociationsByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFileAssociationsByMasterId", new object[4] { fileMasterId, relation, recurse, includeHidden }, GetLatestFileAssociationsByMasterIdOperationCompleted, userState);
	}

	private void OnGetLatestFileAssociationsByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFileAssociationsByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFileAssociationsByMasterIdCompleted(this, new GetLatestFileAssociationsByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileAssocArray[] GetLatestFileAssociationsByMasterIds(long[] fileMasterIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestFileAssociationsByMasterIds", new object[4] { fileMasterIds, relation, recurse, includeHidden });
		return (FileAssocArray[])array[0];
	}

	public void GetLatestFileAssociationsByMasterIdsAsync(long[] fileMasterIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetLatestFileAssociationsByMasterIdsAsync(fileMasterIds, relation, recurse, includeHidden, null);
	}

	public void GetLatestFileAssociationsByMasterIdsAsync(long[] fileMasterIds, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetLatestFileAssociationsByMasterIdsOperationCompleted == null)
		{
			GetLatestFileAssociationsByMasterIdsOperationCompleted = OnGetLatestFileAssociationsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestFileAssociationsByMasterIds", new object[4] { fileMasterIds, relation, recurse, includeHidden }, GetLatestFileAssociationsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetLatestFileAssociationsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestFileAssociationsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestFileAssociationsByMasterIdsCompleted(this, new GetLatestFileAssociationsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FilePath[] GetAssociatedFilePathsById(long fileId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAssociatedFilePathsById", new object[4] { fileId, relation, recurse, includeHidden });
		return (FilePath[])array[0];
	}

	public void GetAssociatedFilePathsByIdAsync(long fileId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetAssociatedFilePathsByIdAsync(fileId, relation, recurse, includeHidden, null);
	}

	public void GetAssociatedFilePathsByIdAsync(long fileId, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetAssociatedFilePathsByIdOperationCompleted == null)
		{
			GetAssociatedFilePathsByIdOperationCompleted = OnGetAssociatedFilePathsByIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAssociatedFilePathsById", new object[4] { fileId, relation, recurse, includeHidden }, GetAssociatedFilePathsByIdOperationCompleted, userState);
	}

	private void OnGetAssociatedFilePathsByIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAssociatedFilePathsByIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAssociatedFilePathsByIdCompleted(this, new GetAssociatedFilePathsByIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FilePathArray[] GetAssociatedFilePathsByIds(long[] fileIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAssociatedFilePathsByIds", new object[4] { fileIds, relation, recurse, includeHidden });
		return (FilePathArray[])array[0];
	}

	public void GetAssociatedFilePathsByIdsAsync(long[] fileIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetAssociatedFilePathsByIdsAsync(fileIds, relation, recurse, includeHidden, null);
	}

	public void GetAssociatedFilePathsByIdsAsync(long[] fileIds, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetAssociatedFilePathsByIdsOperationCompleted == null)
		{
			GetAssociatedFilePathsByIdsOperationCompleted = OnGetAssociatedFilePathsByIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAssociatedFilePathsByIds", new object[4] { fileIds, relation, recurse, includeHidden }, GetAssociatedFilePathsByIdsOperationCompleted, userState);
	}

	private void OnGetAssociatedFilePathsByIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAssociatedFilePathsByIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAssociatedFilePathsByIdsCompleted(this, new GetAssociatedFilePathsByIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileAssoc[] GetFileAssociationsById(long fileId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileAssociationsById", new object[4] { fileId, relation, recurse, includeHidden });
		return (FileAssoc[])array[0];
	}

	public void GetFileAssociationsByIdAsync(long fileId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetFileAssociationsByIdAsync(fileId, relation, recurse, includeHidden, null);
	}

	public void GetFileAssociationsByIdAsync(long fileId, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetFileAssociationsByIdOperationCompleted == null)
		{
			GetFileAssociationsByIdOperationCompleted = OnGetFileAssociationsByIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileAssociationsById", new object[4] { fileId, relation, recurse, includeHidden }, GetFileAssociationsByIdOperationCompleted, userState);
	}

	private void OnGetFileAssociationsByIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileAssociationsByIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileAssociationsByIdCompleted(this, new GetFileAssociationsByIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileAssocArray[] GetFileAssociationsByIds(long[] fileIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileAssociationsByIds", new object[4] { fileIds, relation, recurse, includeHidden });
		return (FileAssocArray[])array[0];
	}

	public void GetFileAssociationsByIdsAsync(long[] fileIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetFileAssociationsByIdsAsync(fileIds, relation, recurse, includeHidden, null);
	}

	public void GetFileAssociationsByIdsAsync(long[] fileIds, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetFileAssociationsByIdsOperationCompleted == null)
		{
			GetFileAssociationsByIdsOperationCompleted = OnGetFileAssociationsByIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileAssociationsByIds", new object[4] { fileIds, relation, recurse, includeHidden }, GetFileAssociationsByIdsOperationCompleted, userState);
	}

	private void OnGetFileAssociationsByIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileAssociationsByIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileAssociationsByIdsCompleted(this, new GetFileAssociationsByIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FilePath[] GetLatestAssociatedFilePathsByMasterId(long fileMasterId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestAssociatedFilePathsByMasterId", new object[4] { fileMasterId, relation, recurse, includeHidden });
		return (FilePath[])array[0];
	}

	public void GetLatestAssociatedFilePathsByMasterIdAsync(long fileMasterId, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetLatestAssociatedFilePathsByMasterIdAsync(fileMasterId, relation, recurse, includeHidden, null);
	}

	public void GetLatestAssociatedFilePathsByMasterIdAsync(long fileMasterId, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetLatestAssociatedFilePathsByMasterIdOperationCompleted == null)
		{
			GetLatestAssociatedFilePathsByMasterIdOperationCompleted = OnGetLatestAssociatedFilePathsByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestAssociatedFilePathsByMasterId", new object[4] { fileMasterId, relation, recurse, includeHidden }, GetLatestAssociatedFilePathsByMasterIdOperationCompleted, userState);
	}

	private void OnGetLatestAssociatedFilePathsByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestAssociatedFilePathsByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestAssociatedFilePathsByMasterIdCompleted(this, new GetLatestAssociatedFilePathsByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FilePathArray[] GetLatestAssociatedFilePathsByMasterIds(long[] fileMasterIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetLatestAssociatedFilePathsByMasterIds", new object[4] { fileMasterIds, relation, recurse, includeHidden });
		return (FilePathArray[])array[0];
	}

	public void GetLatestAssociatedFilePathsByMasterIdsAsync(long[] fileMasterIds, AssociationRelationEnum relation, bool recurse, bool includeHidden)
	{
		GetLatestAssociatedFilePathsByMasterIdsAsync(fileMasterIds, relation, recurse, includeHidden, null);
	}

	public void GetLatestAssociatedFilePathsByMasterIdsAsync(long[] fileMasterIds, AssociationRelationEnum relation, bool recurse, bool includeHidden, object userState)
	{
		if (GetLatestAssociatedFilePathsByMasterIdsOperationCompleted == null)
		{
			GetLatestAssociatedFilePathsByMasterIdsOperationCompleted = OnGetLatestAssociatedFilePathsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetLatestAssociatedFilePathsByMasterIds", new object[4] { fileMasterIds, relation, recurse, includeHidden }, GetLatestAssociatedFilePathsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetLatestAssociatedFilePathsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetLatestAssociatedFilePathsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetLatestAssociatedFilePathsByMasterIdsCompleted(this, new GetLatestAssociatedFilePathsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public bool ValidateBOMByFileId(long fileId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("ValidateBOMByFileId", new object[1] { fileId });
		return (bool)array[0];
	}

	public void ValidateBOMByFileIdAsync(long fileId)
	{
		ValidateBOMByFileIdAsync(fileId, null);
	}

	public void ValidateBOMByFileIdAsync(long fileId, object userState)
	{
		if (ValidateBOMByFileIdOperationCompleted == null)
		{
			ValidateBOMByFileIdOperationCompleted = OnValidateBOMByFileIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("ValidateBOMByFileId", new object[1] { fileId }, ValidateBOMByFileIdOperationCompleted, userState);
	}

	private void OnValidateBOMByFileIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.ValidateBOMByFileIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.ValidateBOMByFileIdCompleted(this, new ValidateBOMByFileIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public CompPropInfo GetComponentProperties(long fileId, string uniqueId)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetComponentProperties", new object[2] { fileId, uniqueId });
		return (CompPropInfo)array[0];
	}

	public void GetComponentPropertiesAsync(long fileId, string uniqueId)
	{
		GetComponentPropertiesAsync(fileId, uniqueId, null);
	}

	public void GetComponentPropertiesAsync(long fileId, string uniqueId, object userState)
	{
		if (GetComponentPropertiesOperationCompleted == null)
		{
			GetComponentPropertiesOperationCompleted = OnGetComponentPropertiesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetComponentProperties", new object[2] { fileId, uniqueId }, GetComponentPropertiesOperationCompleted, userState);
	}

	private void OnGetComponentPropertiesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetComponentPropertiesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetComponentPropertiesCompleted(this, new GetComponentPropertiesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public PropDef AddComponentCustomPropertyDefinition(string name, string dataType)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddComponentCustomPropertyDefinition", new object[2] { name, dataType });
		return (PropDef)array[0];
	}

	public void AddComponentCustomPropertyDefinitionAsync(string name, string dataType)
	{
		AddComponentCustomPropertyDefinitionAsync(name, dataType, null);
	}

	public void AddComponentCustomPropertyDefinitionAsync(string name, string dataType, object userState)
	{
		if (AddComponentCustomPropertyDefinitionOperationCompleted == null)
		{
			AddComponentCustomPropertyDefinitionOperationCompleted = OnAddComponentCustomPropertyDefinitionOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddComponentCustomPropertyDefinition", new object[2] { name, dataType }, AddComponentCustomPropertyDefinitionOperationCompleted, userState);
	}

	private void OnAddComponentCustomPropertyDefinitionOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddComponentCustomPropertyDefinitionCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddComponentCustomPropertyDefinitionCompleted(this, new AddComponentCustomPropertyDefinitionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void DeleteComponentCustomPropertyDefinition(long propertyDefId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteComponentCustomPropertyDefinition", new object[1] { propertyDefId });
	}

	public void DeleteComponentCustomPropertyDefinitionAsync(long propertyDefId)
	{
		DeleteComponentCustomPropertyDefinitionAsync(propertyDefId, null);
	}

	public void DeleteComponentCustomPropertyDefinitionAsync(long propertyDefId, object userState)
	{
		if (DeleteComponentCustomPropertyDefinitionOperationCompleted == null)
		{
			DeleteComponentCustomPropertyDefinitionOperationCompleted = OnDeleteComponentCustomPropertyDefinitionOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteComponentCustomPropertyDefinition", new object[1] { propertyDefId }, DeleteComponentCustomPropertyDefinitionOperationCompleted, userState);
	}

	private void OnDeleteComponentCustomPropertyDefinitionOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteComponentCustomPropertyDefinitionCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteComponentCustomPropertyDefinitionCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileDelRestricEx[] GetFileVersionDeleteRestrictionsByMasterIds(long[] fileMasterIds, int keepCount, int minAge, string comment)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileVersionDeleteRestrictionsByMasterIds", new object[4] { fileMasterIds, keepCount, minAge, comment });
		return (FileDelRestricEx[])array[0];
	}

	public void GetFileVersionDeleteRestrictionsByMasterIdsAsync(long[] fileMasterIds, int keepCount, int minAge, string comment)
	{
		GetFileVersionDeleteRestrictionsByMasterIdsAsync(fileMasterIds, keepCount, minAge, comment, null);
	}

	public void GetFileVersionDeleteRestrictionsByMasterIdsAsync(long[] fileMasterIds, int keepCount, int minAge, string comment, object userState)
	{
		if (GetFileVersionDeleteRestrictionsByMasterIdsOperationCompleted == null)
		{
			GetFileVersionDeleteRestrictionsByMasterIdsOperationCompleted = OnGetFileVersionDeleteRestrictionsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileVersionDeleteRestrictionsByMasterIds", new object[4] { fileMasterIds, keepCount, minAge, comment }, GetFileVersionDeleteRestrictionsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetFileVersionDeleteRestrictionsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileVersionDeleteRestrictionsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileVersionDeleteRestrictionsByMasterIdsCompleted(this, new GetFileVersionDeleteRestrictionsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileDelStatus[] DeleteFileVersionsByMasterIds(long[] fileMasterIds, int keepCount, int minAge, string comment)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("DeleteFileVersionsByMasterIds", new object[4] { fileMasterIds, keepCount, minAge, comment });
		return (FileDelStatus[])array[0];
	}

	public void DeleteFileVersionsByMasterIdsAsync(long[] fileMasterIds, int keepCount, int minAge, string comment)
	{
		DeleteFileVersionsByMasterIdsAsync(fileMasterIds, keepCount, minAge, comment, null);
	}

	public void DeleteFileVersionsByMasterIdsAsync(long[] fileMasterIds, int keepCount, int minAge, string comment, object userState)
	{
		if (DeleteFileVersionsByMasterIdsOperationCompleted == null)
		{
			DeleteFileVersionsByMasterIdsOperationCompleted = OnDeleteFileVersionsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileVersionsByMasterIds", new object[4] { fileMasterIds, keepCount, minAge, comment }, DeleteFileVersionsByMasterIdsOperationCompleted, userState);
	}

	private void OnDeleteFileVersionsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileVersionsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileVersionsByMasterIdsCompleted(this, new DeleteFileVersionsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileDelStatus[] DeleteFileVersionsByMasterIdsUnconditional(long[] fileMasterIds, int keepCount, int minAge, string comment)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("DeleteFileVersionsByMasterIdsUnconditional", new object[4] { fileMasterIds, keepCount, minAge, comment });
		return (FileDelStatus[])array[0];
	}

	public void DeleteFileVersionsByMasterIdsUnconditionalAsync(long[] fileMasterIds, int keepCount, int minAge, string comment)
	{
		DeleteFileVersionsByMasterIdsUnconditionalAsync(fileMasterIds, keepCount, minAge, comment, null);
	}

	public void DeleteFileVersionsByMasterIdsUnconditionalAsync(long[] fileMasterIds, int keepCount, int minAge, string comment, object userState)
	{
		if (DeleteFileVersionsByMasterIdsUnconditionalOperationCompleted == null)
		{
			DeleteFileVersionsByMasterIdsUnconditionalOperationCompleted = OnDeleteFileVersionsByMasterIdsUnconditionalOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileVersionsByMasterIdsUnconditional", new object[4] { fileMasterIds, keepCount, minAge, comment }, DeleteFileVersionsByMasterIdsUnconditionalOperationCompleted, userState);
	}

	private void OnDeleteFileVersionsByMasterIdsUnconditionalOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileVersionsByMasterIdsUnconditionalCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileVersionsByMasterIdsUnconditionalCompleted(this, new DeleteFileVersionsByMasterIdsUnconditionalCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public bool GetTrackFileStatus()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetTrackFileStatus", new object[0]);
		return (bool)array[0];
	}

	public void GetTrackFileStatusAsync()
	{
		GetTrackFileStatusAsync(null);
	}

	public void GetTrackFileStatusAsync(object userState)
	{
		if (GetTrackFileStatusOperationCompleted == null)
		{
			GetTrackFileStatusOperationCompleted = OnGetTrackFileStatusOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetTrackFileStatus", new object[0], GetTrackFileStatusOperationCompleted, userState);
	}

	private void OnGetTrackFileStatusOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetTrackFileStatusCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetTrackFileStatusCompleted(this, new GetTrackFileStatusCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void SetTrackFileStatus(bool trackStatus)
	{
		((SoapHttpClientProtocol)this).Invoke("SetTrackFileStatus", new object[1] { trackStatus });
	}

	public void SetTrackFileStatusAsync(bool trackStatus)
	{
		SetTrackFileStatusAsync(trackStatus, null);
	}

	public void SetTrackFileStatusAsync(bool trackStatus, object userState)
	{
		if (SetTrackFileStatusOperationCompleted == null)
		{
			SetTrackFileStatusOperationCompleted = OnSetTrackFileStatusOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetTrackFileStatus", new object[1] { trackStatus }, SetTrackFileStatusOperationCompleted, userState);
	}

	private void OnSetTrackFileStatusOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetTrackFileStatusCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetTrackFileStatusCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public string GetFilterConfigXml()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFilterConfigXml", new object[0]);
		return (string)array[0];
	}

	public void GetFilterConfigXmlAsync()
	{
		GetFilterConfigXmlAsync(null);
	}

	public void GetFilterConfigXmlAsync(object userState)
	{
		if (GetFilterConfigXmlOperationCompleted == null)
		{
			GetFilterConfigXmlOperationCompleted = OnGetFilterConfigXmlOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFilterConfigXml", new object[0], GetFilterConfigXmlOperationCompleted, userState);
	}

	private void OnGetFilterConfigXmlOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFilterConfigXmlCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFilterConfigXmlCompleted(this, new GetFilterConfigXmlCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileDelStatus[] DeleteFileVersions(long[] fileIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("DeleteFileVersions", new object[1] { fileIds });
		return (FileDelStatus[])array[0];
	}

	public void DeleteFileVersionsAsync(long[] fileIds)
	{
		DeleteFileVersionsAsync(fileIds, null);
	}

	public void DeleteFileVersionsAsync(long[] fileIds, object userState)
	{
		if (DeleteFileVersionsOperationCompleted == null)
		{
			DeleteFileVersionsOperationCompleted = OnDeleteFileVersionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileVersions", new object[1] { fileIds }, DeleteFileVersionsOperationCompleted, userState);
	}

	private void OnDeleteFileVersionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileVersionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileVersionsCompleted(this, new DeleteFileVersionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileDelStatus[] DeleteFileVersionsUnconditional(long[] fileIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("DeleteFileVersionsUnconditional", new object[1] { fileIds });
		return (FileDelStatus[])array[0];
	}

	public void DeleteFileVersionsUnconditionalAsync(long[] fileIds)
	{
		DeleteFileVersionsUnconditionalAsync(fileIds, null);
	}

	public void DeleteFileVersionsUnconditionalAsync(long[] fileIds, object userState)
	{
		if (DeleteFileVersionsUnconditionalOperationCompleted == null)
		{
			DeleteFileVersionsUnconditionalOperationCompleted = OnDeleteFileVersionsUnconditionalOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileVersionsUnconditional", new object[1] { fileIds }, DeleteFileVersionsUnconditionalOperationCompleted, userState);
	}

	private void OnDeleteFileVersionsUnconditionalOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileVersionsUnconditionalCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileVersionsUnconditionalCompleted(this, new DeleteFileVersionsUnconditionalCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File SetFileStatusByMasterId(long fileMasterId, FileStatus fileStatus)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("SetFileStatusByMasterId", new object[2] { fileMasterId, fileStatus });
		return (File)array[0];
	}

	public void SetFileStatusByMasterIdAsync(long fileMasterId, FileStatus fileStatus)
	{
		SetFileStatusByMasterIdAsync(fileMasterId, fileStatus, null);
	}

	public void SetFileStatusByMasterIdAsync(long fileMasterId, FileStatus fileStatus, object userState)
	{
		if (SetFileStatusByMasterIdOperationCompleted == null)
		{
			SetFileStatusByMasterIdOperationCompleted = OnSetFileStatusByMasterIdOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetFileStatusByMasterId", new object[2] { fileMasterId, fileStatus }, SetFileStatusByMasterIdOperationCompleted, userState);
	}

	private void OnSetFileStatusByMasterIdOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetFileStatusByMasterIdCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetFileStatusByMasterIdCompleted(this, new SetFileStatusByMasterIdCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public File[] SetFileStatusByMasterIds(long[] fileMasterIds, FileStatus fileStatus)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("SetFileStatusByMasterIds", new object[2] { fileMasterIds, fileStatus });
		return (File[])array[0];
	}

	public void SetFileStatusByMasterIdsAsync(long[] fileMasterIds, FileStatus fileStatus)
	{
		SetFileStatusByMasterIdsAsync(fileMasterIds, fileStatus, null);
	}

	public void SetFileStatusByMasterIdsAsync(long[] fileMasterIds, FileStatus fileStatus, object userState)
	{
		if (SetFileStatusByMasterIdsOperationCompleted == null)
		{
			SetFileStatusByMasterIdsOperationCompleted = OnSetFileStatusByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetFileStatusByMasterIds", new object[2] { fileMasterIds, fileStatus }, SetFileStatusByMasterIdsOperationCompleted, userState);
	}

	private void OnSetFileStatusByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetFileStatusByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetFileStatusByMasterIdsCompleted(this, new SetFileStatusByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public DocRestricArray[] GetFileStatusSetRestrictionsByMasterIds(long[] fileMasterIds, FileStatus fileStatus)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileStatusSetRestrictionsByMasterIds", new object[2] { fileMasterIds, fileStatus });
		return (DocRestricArray[])array[0];
	}

	public void GetFileStatusSetRestrictionsByMasterIdsAsync(long[] fileMasterIds, FileStatus fileStatus)
	{
		GetFileStatusSetRestrictionsByMasterIdsAsync(fileMasterIds, fileStatus, null);
	}

	public void GetFileStatusSetRestrictionsByMasterIdsAsync(long[] fileMasterIds, FileStatus fileStatus, object userState)
	{
		if (GetFileStatusSetRestrictionsByMasterIdsOperationCompleted == null)
		{
			GetFileStatusSetRestrictionsByMasterIdsOperationCompleted = OnGetFileStatusSetRestrictionsByMasterIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileStatusSetRestrictionsByMasterIds", new object[2] { fileMasterIds, fileStatus }, GetFileStatusSetRestrictionsByMasterIdsOperationCompleted, userState);
	}

	private void OnGetFileStatusSetRestrictionsByMasterIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileStatusSetRestrictionsByMasterIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileStatusSetRestrictionsByMasterIdsCompleted(this, new GetFileStatusSetRestrictionsByMasterIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileDelRestricEx[] GetFileVersionDeleteRestrictionsByFileIds(long[] fileIds)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetFileVersionDeleteRestrictionsByFileIds", new object[1] { fileIds });
		return (FileDelRestricEx[])array[0];
	}

	public void GetFileVersionDeleteRestrictionsByFileIdsAsync(long[] fileIds)
	{
		GetFileVersionDeleteRestrictionsByFileIdsAsync(fileIds, null);
	}

	public void GetFileVersionDeleteRestrictionsByFileIdsAsync(long[] fileIds, object userState)
	{
		if (GetFileVersionDeleteRestrictionsByFileIdsOperationCompleted == null)
		{
			GetFileVersionDeleteRestrictionsByFileIdsOperationCompleted = OnGetFileVersionDeleteRestrictionsByFileIdsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetFileVersionDeleteRestrictionsByFileIds", new object[1] { fileIds }, GetFileVersionDeleteRestrictionsByFileIdsOperationCompleted, userState);
	}

	private void OnGetFileVersionDeleteRestrictionsByFileIdsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetFileVersionDeleteRestrictionsByFileIdsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetFileVersionDeleteRestrictionsByFileIdsCompleted(this, new GetFileVersionDeleteRestrictionsByFileIdsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileNmngSchm AddFileNamingScheme(FileNmngSchm scheme)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddFileNamingScheme", new object[1] { scheme });
		return (FileNmngSchm)array[0];
	}

	public void AddFileNamingSchemeAsync(FileNmngSchm scheme)
	{
		AddFileNamingSchemeAsync(scheme, null);
	}

	public void AddFileNamingSchemeAsync(FileNmngSchm scheme, object userState)
	{
		if (AddFileNamingSchemeOperationCompleted == null)
		{
			AddFileNamingSchemeOperationCompleted = OnAddFileNamingSchemeOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("AddFileNamingScheme", new object[1] { scheme }, AddFileNamingSchemeOperationCompleted, userState);
	}

	private void OnAddFileNamingSchemeOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.AddFileNamingSchemeCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.AddFileNamingSchemeCompleted(this, new AddFileNamingSchemeCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public void UpdateFileNamingScheme(FileNmngSchm scheme)
	{
		((SoapHttpClientProtocol)this).Invoke("UpdateFileNamingScheme", new object[1] { scheme });
	}

	public void UpdateFileNamingSchemeAsync(FileNmngSchm scheme)
	{
		UpdateFileNamingSchemeAsync(scheme, null);
	}

	public void UpdateFileNamingSchemeAsync(FileNmngSchm scheme, object userState)
	{
		if (UpdateFileNamingSchemeOperationCompleted == null)
		{
			UpdateFileNamingSchemeOperationCompleted = OnUpdateFileNamingSchemeOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("UpdateFileNamingScheme", new object[1] { scheme }, UpdateFileNamingSchemeOperationCompleted, userState);
	}

	private void OnUpdateFileNamingSchemeOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.UpdateFileNamingSchemeCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.UpdateFileNamingSchemeCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void DeleteFileNamingScheme(long schemeId)
	{
		((SoapHttpClientProtocol)this).Invoke("DeleteFileNamingScheme", new object[1] { schemeId });
	}

	public void DeleteFileNamingSchemeAsync(long schemeId)
	{
		DeleteFileNamingSchemeAsync(schemeId, null);
	}

	public void DeleteFileNamingSchemeAsync(long schemeId, object userState)
	{
		if (DeleteFileNamingSchemeOperationCompleted == null)
		{
			DeleteFileNamingSchemeOperationCompleted = OnDeleteFileNamingSchemeOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("DeleteFileNamingScheme", new object[1] { schemeId }, DeleteFileNamingSchemeOperationCompleted, userState);
	}

	private void OnDeleteFileNamingSchemeOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.DeleteFileNamingSchemeCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.DeleteFileNamingSchemeCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void SetDefaultFileNamingScheme(long schemeId)
	{
		((SoapHttpClientProtocol)this).Invoke("SetDefaultFileNamingScheme", new object[1] { schemeId });
	}

	public void SetDefaultFileNamingSchemeAsync(long schemeId)
	{
		SetDefaultFileNamingSchemeAsync(schemeId, null);
	}

	public void SetDefaultFileNamingSchemeAsync(long schemeId, object userState)
	{
		if (SetDefaultFileNamingSchemeOperationCompleted == null)
		{
			SetDefaultFileNamingSchemeOperationCompleted = OnSetDefaultFileNamingSchemeOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("SetDefaultFileNamingScheme", new object[1] { schemeId }, SetDefaultFileNamingSchemeOperationCompleted, userState);
	}

	private void OnSetDefaultFileNamingSchemeOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.SetDefaultFileNamingSchemeCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.SetDefaultFileNamingSchemeCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[SoapHeader("SecurityHeaderValue")]
	public FileNmngSchm[] GetAllFileNamingSchemes()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("GetAllFileNamingSchemes", new object[0]);
		return (FileNmngSchm[])array[0];
	}

	public void GetAllFileNamingSchemesAsync()
	{
		GetAllFileNamingSchemesAsync(null);
	}

	public void GetAllFileNamingSchemesAsync(object userState)
	{
		if (GetAllFileNamingSchemesOperationCompleted == null)
		{
			GetAllFileNamingSchemesOperationCompleted = OnGetAllFileNamingSchemesOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("GetAllFileNamingSchemes", new object[0], GetAllFileNamingSchemesOperationCompleted, userState);
	}

	private void OnGetAllFileNamingSchemesOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.GetAllFileNamingSchemesCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.GetAllFileNamingSchemesCompleted(this, new GetAllFileNamingSchemesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public FileNmngDescr[] ReserveFileNamingDescriptions(long fileNamingSchemeId, int size)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("ReserveFileNamingDescriptions", new object[2] { fileNamingSchemeId, size });
		return (FileNmngDescr[])array[0];
	}

	public void ReserveFileNamingDescriptionsAsync(long fileNamingSchemeId, int size)
	{
		ReserveFileNamingDescriptionsAsync(fileNamingSchemeId, size, null);
	}

	public void ReserveFileNamingDescriptionsAsync(long fileNamingSchemeId, int size, object userState)
	{
		if (ReserveFileNamingDescriptionsOperationCompleted == null)
		{
			ReserveFileNamingDescriptionsOperationCompleted = OnReserveFileNamingDescriptionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("ReserveFileNamingDescriptions", new object[2] { fileNamingSchemeId, size }, ReserveFileNamingDescriptionsOperationCompleted, userState);
	}

	private void OnReserveFileNamingDescriptionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.ReserveFileNamingDescriptionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.ReserveFileNamingDescriptionsCompleted(this, new ReserveFileNamingDescriptionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapHeader("SecurityHeaderValue")]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void RollbackFileNamingDescriptions(FileNmngDescr[] descriptions)
	{
		((SoapHttpClientProtocol)this).Invoke("RollbackFileNamingDescriptions", new object[1] { descriptions });
	}

	public void RollbackFileNamingDescriptionsAsync(FileNmngDescr[] descriptions)
	{
		RollbackFileNamingDescriptionsAsync(descriptions, null);
	}

	public void RollbackFileNamingDescriptionsAsync(FileNmngDescr[] descriptions, object userState)
	{
		if (RollbackFileNamingDescriptionsOperationCompleted == null)
		{
			RollbackFileNamingDescriptionsOperationCompleted = OnRollbackFileNamingDescriptionsOperationCompleted;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("RollbackFileNamingDescriptions", new object[1] { descriptions }, RollbackFileNamingDescriptionsOperationCompleted, userState);
	}

	private void OnRollbackFileNamingDescriptionsOperationCompleted(object arg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (this.RollbackFileNamingDescriptionsCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			this.RollbackFileNamingDescriptionsCompleted(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
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
