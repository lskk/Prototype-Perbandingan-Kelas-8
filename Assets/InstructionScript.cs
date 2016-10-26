using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InstructionScript : MonoBehaviour {
	public int instructionCount=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		instructionCount++;

		GameObject instruction = GameObject.Find ("Instruction");
		Text instructionText = instruction.transform.FindChild ("Canvas").FindChild ("Text").GetComponent<Text> ();

		switch (instructionCount) {
		case 1:
			{
				instructionText.text = "Hmmmm.... Aku hanya bisa memberi petunjuk.\nPerhatikan seberapa tinggi perkembangan pohon untuk setiap penggunaan alat/sumberdaya!!\n\n(klik untuk melanjutkan)";
				break;
			}
		case 2:
			{
				instruction.transform.localScale = new Vector3 (0, 0, 0);
				break;
			}
		}

	}
}
