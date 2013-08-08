using Strategy.GameObjectControl.RuntimeProperty;

namespace Strategy.GameMaterial {
	/// <summary>
	/// Represents game material and stores the quantity ofthe material.
	/// </summary>
    public interface IMaterial {
		/// <summary>
		/// Returns reference on Property with a current quantity of the material. Object with reference on this Property
		/// can see the current quantity of the material.
		/// </summary>
		/// <returns>Returns refence to material Property with a current quantity.</returns>
        Property<int> GetQuantityOfMaterial();

		/// <summary>
		/// Adds given quantity of the material.
		/// </summary>
		/// <param name="quantity">The adding quantities of material.</param>
        void AddQuantity(double quantity);

		/// <summary>
		/// Returns current quantity of material.
		/// </summary>
        int Quantity {  get; }

		/// <summary>
		/// Returns a name of the material.
		/// </summary>
        string Name { get; }
    }
}
