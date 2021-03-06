﻿
namespace Strategy.GameObjectControl.Game_Objects.Bullet {
	/// <summary>
	/// Represents bullet. Implements move in the space and when IBullet hits an object 
	/// so must reports it to the appropriate Fight. 
	/// </summary>
	public interface IBullet {
		/// <summary>
		/// Returns name of the IBullet.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Returns power of the IBullet.
		/// </summary>
		int Attack { get; }

		/// <summary>
		/// Updates IBullet position in a visible SolarSystem.
		/// </summary>
		/// <param name="delay">The delay between last two frames (seconds).</param>
		void Update(float delay);

		/// <summary>
		/// Updates IBullet position in an invisible SolarSystem.
		/// </summary>
		/// <param name="delay">The delay between last two frames (seconds).</param>
		void HiddenUpdate(float delay);

		/// <summary>
		/// Changes IBullet visibility (must destroy/create Mogre.SceneNode).
		/// </summary>
		/// <param name="visible">Represents if the object should be visible or not.</param>
		void ChangeVisible(bool visible);

		/// <summary>
		/// Destroys IBullet.
		/// </summary>
		void Destroy();
	}
}
