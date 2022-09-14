using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

public class EAConstants
{
	public const string activeXEA = "EA.App";

	public const string encodePropertyParameter = "%s";

	public const string encodeProperty = "{ARCHIPROPID:%s:}";

	public const string taggedValueArchiID = "ARCHI_ID";

	public const string metatypeArchimatePrefix = "ArchiMate3::";

	public const string stereotypeArchimatePrefix = "ArchiMate_";

	public const string stereotypeElementCapability = "ArchiMate_Capability";

	public const string stereotypeElementGap = "ArchiMate_Gap";

	public const string stereotypeElementBusinessProcess = "ArchiMate_BusinessProcess";

	public const string stereotypeElementBusinessFunction = "ArchiMate_BusinessFunction";

	public const string stereotypeElementBusinessService = "ArchiMate_BusinessService";

	public const string stereotypeElementBusinessEvent = "ArchiMate_BusinessEvent";

	public const string stereotypeElementBusinessCollaboration = "ArchiMate_BusinessCollaboration";

	public const string stereotypeElementBusinessInteraction = "ArchiMate_BusinessInteraction";

	public const string stereotypeElementBusinessInterface = "ArchiMate_BusinessInterface";

	public const string stereotypeElementBusinessRole = "ArchiMate_BusinessRole";

	public const string stereotypeElementBusinessActor = "ArchiMate_BusinessActor";

	public const string stereotypeElementBusinessObject = "ArchiMate_BusinessObject";

	public const string stereotypeElementContract = "ArchiMate_Contract";

	public const string stereotypeElementRepresentation = "ArchiMate_Representation";

	public const string stereotypeElementProduct = "ArchiMate_Product";

	public const string stereotypeElementApplicationComponent = "ArchiMate_ApplicationComponent";

	public const string stereotypeElementApplicationFunction = "ArchiMate_ApplicationFunction";

	public const string stereotypeElementApplicationService = "ArchiMate_ApplicationService";

	public const string stereotypeElementApplicationInterface = "ArchiMate_ApplicationInterface";

	public const string stereotypeElementApplicationCollaboration = "ArchiMate_ApplicationCollaboration";

	public const string stereotypeElementApplicationProcess = "ArchiMate_ApplicationProcess";

	public const string stereotypeElementApplicationInteraction = "ArchiMate_ApplicationInteraction";

	public const string stereotypeElementApplicationEvent = "ArchiMate_ApplicationEvent";

	public const string stereotypeElementDataObject = "ArchiMate_DataObject";

	public const string stereotypeElementNode = "ArchiMate_Node";

	public const string stereotypeElementDevice = "ArchiMate_Device";

	public const string stereotypeElementSystemSoftware = "ArchiMate_SystemSoftware";

	public const string stereotypeElementTechnologyCollaboration = "ArchiMate_TechnologyCollaboration";

	public const string stereotypeElementTechnologyInterface = "ArchiMate_TechnologyInterface";

	public const string stereotypeElementPath = "ArchiMate_Path";

	public const string stereotypeElementCommunicationNetwork = "ArchiMate_CommunicationNetwork";

	public const string stereotypeElementTechnologyProcess = "ArchiMate_TechnologyProcess";

	public const string stereotypeElementTechnologyFunction = "ArchiMate_TechnologyFunction";

	public const string stereotypeElementTechnologyInteraction = "ArchiMate_TechnologyInteraction";

	public const string stereotypeElementTechnologyService = "ArchiMate_TechnologyService";

	public const string stereotypeElementTechnologyEvent = "ArchiMate_TechnologyEvent";

	public const string stereotypeElementTechnologyObject = "ArchiMate_TechnologyObject";

	public const string stereotypeElementArtifact = "ArchiMate_Artifact";

	public const string stereotypeElementFacility = "ArchiMate_Facility";

	public const string stereotypeElementEquipment = "ArchiMate_Equipment";

	public const string stereotypeElementDistributionNetwork = "ArchiMate_DistributionNetwork";

	public const string stereotypeElementMaterial = "ArchiMate_Material";

	public const string stereotypeElementLocation = "ArchiMate_Location";

	public const string stereotypeRelationComposition = "ArchiMate_Composition";

	public const string stereotypeRelationAggregation = "ArchiMate_Aggregation";

	public const string stereotypeRelationRealization = "ArchiMate_Realization";

	public const string stereotypeRelationAssignment = "ArchiMate_Assignment";

	public const string stereotypeRelationServing = "ArchiMate_Serving";

	public const string stereotypeRelationAccess = "ArchiMate_Access";

	public const string stereotypeRelationAssociation = "ArchiMate_Association";

	public const string stereotypeRelationInfluence = "ArchiMate_Influence";

	public const string stereotypeRelationTriggering = "ArchiMate_Triggering";

	public const string stereotypeRelationFlow = "ArchiMate_Flow";

	public const string stereotypeRelationSpecialization = "ArchiMate_Specialization";

	public const string stereotypeRelationJunction = "ArchiMate_Junction";

	public const string stereotypeRelationGrouping = "ArchiMate_Grouping";

	public const int relationDirectionAny = 0;

	public const int relationDirectionClient = 1;

	public const int relationDirectionSupplier = 2;

	public const string objectTypeActivity = "Activity";

	public const string objectTypeClass = "Class";

	public const string objectTypeInterface = "Interface";

	public const string objectTypeComponent = "Component";

	public const string connectorTypeAssociation = "Association";

	public const string connectorTypeDependency = "Dependency";

	public const string connectorTypeControlFlow = "ControlFlow";

	public const string connectorTypeGeneralization = "Generalization";

	public const string connectorDirectionSourceDestination = "Source -> Destination";

	public static readonly Hashtable stereotype2type = new Hashtable
	{
		{ "ArchiMate_Capability", "Class" },
		{ "ArchiMate_BusinessActor", "Class" },
		{ "ArchiMate_BusinessRole", "Class" },
		{ "ArchiMate_BusinessCollaboration", "Class" },
		{ "ArchiMate_BusinessInterface", "Interface" },
		{ "ArchiMate_BusinessInteraction", "Activity" },
		{ "ArchiMate_BusinessEvent", "Activity" },
		{ "ArchiMate_BusinessProcess", "Activity" },
		{ "ArchiMate_BusinessFunction", "Activity" },
		{ "ArchiMate_BusinessService", "Activity" },
		{ "ArchiMate_BusinessObject", "Class" },
		{ "ArchiMate_Contract", "Class" },
		{ "ArchiMate_Representation", "Class" },
		{ "ArchiMate_Product", "Class" },
		{ "ArchiMate_ApplicationCollaboration", "Class" },
		{ "ArchiMate_ApplicationComponent", "Component" },
		{ "ArchiMate_ApplicationInterface", "Interface" },
		{ "ArchiMate_ApplicationProcess", "Activity" },
		{ "ArchiMate_ApplicationFunction", "Activity" },
		{ "ArchiMate_ApplicationInteraction", "Activity" },
		{ "ArchiMate_ApplicationService", "Activity" },
		{ "ArchiMate_ApplicationEvent", "Activity" },
		{ "ArchiMate_DataObject", "Class" },
		{ "ArchiMate_Node", "Class" },
		{ "ArchiMate_Device", "Class" },
		{ "ArchiMate_SystemSoftware", "Class" },
		{ "ArchiMate_TechnologyCollaboration", "Class" },
		{ "ArchiMate_TechnologyInterface", "Interface" },
		{ "ArchiMate_Path", "Class" },
		{ "ArchiMate_CommunicationNetwork", "Class" },
		{ "ArchiMate_TechnologyProcess", "Activity" },
		{ "ArchiMate_TechnologyFunction", "Activity" },
		{ "ArchiMate_TechnologyInteraction", "Activity" },
		{ "ArchiMate_TechnologyService", "Activity" },
		{ "ArchiMate_TechnologyEvent", "Activity" },
		{ "ArchiMate_TechnologyObject", "Class" },
		{ "ArchiMate_Artifact", "Class" },
		{ "ArchiMate_Facility", "Class" },
		{ "ArchiMate_Equipment", "Class" },
		{ "ArchiMate_DistributionNetwork", "Class" },
		{ "ArchiMate_Material", "Class" },
		{ "ArchiMate_Location", "Class" },
		{ "ArchiMate_Serving", "Association" },
		{ "ArchiMate_Composition", "Association" },
		{ "ArchiMate_Aggregation", "Association" },
		{ "ArchiMate_Realization", "Dependency" },
		{ "ArchiMate_Assignment", "Association" },
		{ "ArchiMate_Access", "Dependency" },
		{ "ArchiMate_Association", "Association" },
		{ "ArchiMate_Influence", "ControlFlow" },
		{ "ArchiMate_Triggering", "ControlFlow" },
		{ "ArchiMate_Flow", "ControlFlow" },
		{ "ArchiMate_Specialization", "Generalization" }
	};

	public static string typeArchi2StereotypeEA(string typeArchi)
	{
		return "ArchiMate_" + typeArchi;
	}

	public static string stereotypeEA2StypeEA(string stereotypeEA)
	{
		return Conversions.ToString(stereotype2type[stereotypeEA]);
	}
}
