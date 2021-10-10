using System;
using UnityEngine;

namespace CustomSaveDataUtilities
{
	[MelonLoader.RegisterTypeInIl2Cpp]
	public abstract class ModSaveBehaviour : MonoBehaviour
	{
		public abstract void Deserialize(string data);

		public abstract string Serialize();

		public ModSaveBehaviour(IntPtr intPtr) : base(intPtr) { }
	}
}
