using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.GameObjectControl.Game_Objects.GameSave {

	/// <summary>
	/// Indicates the type of targeted property/field
	/// </summary>
	public enum AttributeType {
		Vector3,
		Basic,
		Property,
		PropertyVector3,
		List
	}

	/// <summary>
	/// Targets the field or property to save. The order indicates the order of the saving and 
	/// type indicates the type of saving (translate vector, etc).
	/// </summary>
	public class ConstructorFieldAttribute : Attribute {
		/// <summary>
		/// The order of the targeted field/property.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// The type of the targeted field/property.
		/// </summary>
		public AttributeType Type { get; set; }

		/// <summary>
		/// Initializes the attribute
		/// </summary>
		/// <param name="order">The order of the saving.</param>
		/// <param name="type">The type of the saving filed/property.</param>
		public ConstructorFieldAttribute(int order, AttributeType type) {
			this.Type = type;
			this.Order = order;
		}
	}
}
