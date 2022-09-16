using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Cct.Services.VirtualMachines;
using Microsoft.Samples.WindowsAzure.ServiceManagement;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement.DataContracts;
using _0xH7arquisettes;
using _0xHD3ats;
using _0xHNatural1se;

namespace _0xH8ompah;

internal interface IWatServiceManagement
{
	bool UsesDefaultEndpoint { get; }

	string SubscriptionId { get; }

	IServiceManagement Svc { get; }

	int PollIntervalInSeconds { get; set; }

	SynchronizationContext Sync { get; set; }

	Uri ServiceUri { get; }

	bool IsConnected { get; }

	event _0xH8eminomad StatusUpdated;

	void Connect();

	void CreateOrUpdateDeployment(string hostedService, string slot, CreateDeploymentInput createArgs);

	void CreateOrUpdateDeployment(string hostedService, string slot, CreateDeploymentInput createArgs, _0xHUn0urbing retryPolicy);

	void UpgradeDeploymentBySlot(string hostedService, string slot, UpgradeDeploymentInput upgradeArgs, _0xHUn0urbing retryPolicy);

	void DeleteDeploymentBySlot(string hostedService, string deploymentSlot);

	Task DeleteDeploymentBySlotAsync(string hostedService, string deploymentSlot);

	void DeleteDeploymentBySlot(string hostedService, string deploymentSlot, _0xHUn0urbing retryPolicy);

	Task<Subscription> GetSubscriptionAsync();

	Task<AffinityGroupList> ListAffinityGroupsAsync();

	Task<VirtualNetworkSites> ListVirtualNetworkSitesAsync();

	IEnumerable<string> ListAvailabilitySets(string hostedService);

	IEnumerable<InputEndpoint> ListEndpoints(string hostedService);

	Task<Stream> DownloadDeploymentRoleInstanceRemoteDesktopFileAsync(string serviceName, string deploymentName, string roleInstanceName);

	void ShutdownVirtualMachineInstance(string serviceName, string deploymentName, string roleInstanceName);

	void StartVirtualMachineInstance(string serviceName, string deploymentName, string roleInstanceName);

	void RestartVirtualMachineInstance(string serviceName, string deploymentName, string roleInstanceName);

	void CaptureVirtualMachineInstance(string serviceName, string deploymentName, string roleInstanceName, string osState, string imageName, string imageLabel, string imageDescription, string imageFamily, string recommendedVMSize);

	void DeleteVirtualMachine(string serviceName, string deploymentName, string roleInstanceName);

	Task EnsureResourceExtensionEnabledAsync(string serviceName, string deploymentName, string roleName, ResourceExtensionReference newExtension, IEnumerable<InputEndpoint> newEndpoints);

	Task DisableResourceExtensionAsync(string serviceName, string deploymentName, string roleName, string extensionReferenceName);

	Task UpdateRoleAsync(string serviceName, string deploymentName, string roleName, IVirtualMachineInstance instance);

	Deployment GetDeploymentBySlot(string hostedService, string slot);

	Deployment GetDeploymentBySlot(string hostedService, string slot, _0xHUn0urbing retryPolicy);

	Task<Deployment> GetDeploymentBySlotAsync(string hostedService, string slot);

	Task ChangeConfigurationBySlot(string serviceName, string deploymentSlot, ChangeConfigurationInput input);

	Deployment TryGetDeploymentBySlot(string hostedService, string slot);

	HostedService GetHostedService(string hostedService);

	HostedService GetHostedServiceWithDetails(string hostedService);

	Task<HostedService> GetHostedServiceWithDetailsAsync(string hostedService);

	Task DeleteStorageServiceAsync(string storageService);

	void DeleteHostedService(string hostedService);

	Task DeleteHostedServiceAsync(string hostedService);

	StorageService GetStorageKeys(string storageService);

	StorageService GetStorageKeys(string storageService, _0xHUn0urbing retryPolicy);

	void GetStorageKeysAsync(string serviceName, Action<StorageService> callback, Action<Exception> onError);

	Task<StorageService> GetStorageKeysAsync(string serviceName);

	Task<StorageService> GetStorageServiceAsync(string storageService);

	StorageService GetStorageService(string storageService);

	StorageService GetStorageService(string storageService, _0xHUn0urbing retryPolicy);

	HostedServiceList ListHostedServices();

	void ListHostedServicesAsync(Action<HostedServiceList> callback, Action<Exception> onError);

	Task<LocationList> ListLocationsAsync();

	void ListHostedServicesDetails(Action<HostedServiceList> callback, Action<Exception> onError);

	void GetCertificateAsync(Action<_0xHDob8on8, Certificate> callback, Action<_0xHDob8on8, Exception> onError, _0xHDob8on8 certificateRequestState);

	StorageServiceList ListStorageServices();

	void ListStorageServicesAsync(Action<StorageServiceList> callback, Action<Exception> onError);

	Task<StorageServiceList> ListStorageServicesAsync();

	void ListStorageServicesDetails(Action<StorageServiceList> callback, Action<Exception> onError);

	void StartSlot(string hostedService, string slot);

	void StartSlot(string hostedService, string slot, _0xHUn0urbing retryPolicy);

	void StopSlot(string hostedService, string slot);

	Task StopSlotAsync(string hostedService, string slot);

	void StopSlot(string hostedService, string slot, _0xHUn0urbing retryPolicy);

	void AddCertificate(string hostedServiceName, X509Certificate2 cert, _0xHUn0urbing retryPolicy);

	CertificateList ListCertificates(string hostedServiceName, _0xHUn0urbing retryPolicy);

	Certificate GetCertificate(string serviceName, string thumbprint, _0xHUn0urbing retryPolicy);

	void WalkUpgradeDomainBySlot(string hostedService, string slot, WalkUpgradeDomainInput input, _0xHUn0urbing retryPolicy);

	IEnumerable<Deployment> ListDeployments(string hostedService);

	IEnumerable<PersistentVMRole> ListPersistentVmRoles(string hostedService);

	Task<HostedServiceExtensionList> ListHostedServiceExtensionsTask(string serviceName);

	Task<ExtensionImageList> ListAvailableExtensions();

	Task<ExtensionImageList> ListExtensionVersions(string providerNamespace, string type);

	Task<HostedServiceExtensionList> ListServiceExtensions(string serviceName);

	Task AddServiceExtension(string serviceName, string id, string privateConfig, string publicConfig, string provider, string type, string version, string thumbprint, string thumbprintAlgorithm);

	Task DeleteServiceExtension(string serviceName, string id);

	Task<NamespaceDescription[]> ListServiceBusNamespacesAsync();

	Task<ConnectionDetail[]> GetServiceBusConnectionDetailAsync(string serviceName);
}
