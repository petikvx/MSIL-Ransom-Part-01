using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DnDSpellSorter.ResourceParser;

public class SpellListXML
{
	[Serializable]
	[XmlType(AnonymousType = true)]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class compendium
	{
		private compendiumSpell[] spellField;

		private byte versionField;

		[XmlElement("spell")]
		public compendiumSpell[] spell
		{
			get
			{
				return spellField;
			}
			set
			{
				spellField = value;
			}
		}

		[XmlAttribute]
		public byte version
		{
			get
			{
				return versionField;
			}
			set
			{
				versionField = value;
			}
		}
	}

	[Serializable]
	[XmlType(AnonymousType = true)]
	[DesignerCategory("code")]
	public class compendiumSpell
	{
		private string nameField;

		private byte levelField;

		private string schoolField;

		private string ritualField;

		private string timeField;

		private string rangeField;

		private string componentsField;

		private string durationField;

		private string classesField;

		private string[] textField;

		private string[] rollField;

		public string name
		{
			get
			{
				return nameField;
			}
			set
			{
				nameField = value;
			}
		}

		public byte level
		{
			get
			{
				return levelField;
			}
			set
			{
				levelField = value;
			}
		}

		public string school
		{
			get
			{
				return schoolField;
			}
			set
			{
				schoolField = value;
			}
		}

		public string ritual
		{
			get
			{
				return ritualField;
			}
			set
			{
				ritualField = value;
			}
		}

		public string time
		{
			get
			{
				return timeField;
			}
			set
			{
				timeField = value;
			}
		}

		public string range
		{
			get
			{
				return rangeField;
			}
			set
			{
				rangeField = value;
			}
		}

		public string components
		{
			get
			{
				return componentsField;
			}
			set
			{
				componentsField = value;
			}
		}

		public string duration
		{
			get
			{
				return durationField;
			}
			set
			{
				durationField = value;
			}
		}

		public string classes
		{
			get
			{
				return classesField;
			}
			set
			{
				classesField = value;
			}
		}

		[XmlElement("text")]
		public string[] text
		{
			get
			{
				return textField;
			}
			set
			{
				textField = value;
			}
		}

		[XmlElement("roll")]
		public string[] roll
		{
			get
			{
				return rollField;
			}
			set
			{
				rollField = value;
			}
		}
	}
}
