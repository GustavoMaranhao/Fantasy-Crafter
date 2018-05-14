using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Script : MonoBehaviour {
	[HideInInspector]
	public static GameManager_Script scriptGameManagerRef;

	[HideInInspector]
	public static GameObject playerRef;
	[HideInInspector]
	public static Camera playerCameraRef;

	[HideInInspector]
	public static GameObject canvasRef;

	[HideInInspector]
	public enum ItemClassesEnum {
		Material_Raw, Material_Processed, 
		Tool_Smithing, Tool_Woodworking, Tool_Lapidary, Tool, Stoneworking, Tool_Alchemy,
		Tool_Lumberjack, Tool_Miner, Tool_Fisher
	};
	[HideInInspector]
	public enum ImpuritiesEnum {
		Carbon, Oxygen, Sulfur
	};

	void Awake () {
		scriptGameManagerRef = this;

		playerRef = GameObject.FindGameObjectWithTag ("Player");
		playerCameraRef = playerRef.transform.GetChild(0).GetComponent<Camera>();

		canvasRef = GameObject.Find ("Canvas");
	}
}
