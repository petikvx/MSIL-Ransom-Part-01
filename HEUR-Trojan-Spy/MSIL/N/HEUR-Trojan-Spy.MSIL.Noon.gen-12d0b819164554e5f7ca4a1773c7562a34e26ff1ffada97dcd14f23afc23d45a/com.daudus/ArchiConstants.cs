namespace com.daudus;

public class ArchiConstants
{
	public const string csvDelimiter = ",";

	public const string csvQualifier = "\"";

	public static readonly string[] columsMappedElementsFileARCHI = new string[4] { "ID", "Type", "Name", "Documentation" };

	public const string encodePropertyParameter = "%s";

	public const string encodeProperty = "{ARCHIPROPID:%s:}";

	public const string propertyEAGUID = "EAGUID";

	public const string propertyEAID = "EAGUID";

	public const string typeModel = "ArchimateModel";

	public const string RelationSuffix = "Relationship";

	public const string typeElementCapability = "Capability";

	public const string typeElementGap = "Gap";

	public const string typeElementBusProcess = "BusinessProcess";

	public const string typeElementBusFunction = "BusinessFunction";

	public const string typeElementNode = "Node";

	public const string typeElementSystemSoftware = "SystemSoftware";

	public const string typeElementTechnologyInterface = "TechnologyInterface";

	public const string typeElementTechnologyprocess = "TechnologyProcess";

	public const string typeElementTechnologyFunction = "TechnologyFunction";

	public const string typeElementTechnologyService = "TechnologyService";

	public const string typeElementTechnologyArtifact = "Artifact";

	public const string typeElementTechnologyDevice = "Device";

	public const string typeElementAppComponent = "ApplicationComponent";

	public const string typeElementAppFunction = "ApplicationFunction";

	public const string typeElementAppService = "ApplicationService";

	public const string typeElementAppInterface = "ApplicationInterface";

	public const string typeElementAppEvent = "ApplicationEvent";

	public const string typeRelationRealization = "RealizationRelationship";

	public const string typeRelationAssociation = "AssociationRelationship";

	public const string typeRelationComposition = "CompositionRelationship";

	public const string typeRelationServing = "ServingRelationship";

	public const string typeRelationAssignment = "AssignmentRelationship";

	public const string typeRelationFlow = "FlowRelationship";
}
