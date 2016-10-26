using UnityEngine;
using System.Collections;


public class WaterScript : MonoBehaviour {
	public float waterCount;
	public float waterIncrement;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		Debug.Log ("TESTXXX");
		GameObject watercan = GameObject.Find("WatercanController");
		watercan.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
	}

	void OnMouseExit(){
		GameObject watercan = GameObject.Find("WatercanController");
		watercan.transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
	}

	void OnMouseDown(){
		GameObject treeTreated = GameObject.Find ("Tree_treated");
		TreeClass treeTreatedProps = (TreeClass) treeTreated.GetComponent (typeof(TreeClass));
		GameObject treeExample = GameObject.Find ("Tree_example");
		TreeClass treeExampleProps = (TreeClass) treeExample.GetComponent (typeof(TreeClass));

		if ( treeExampleProps.initialHeight >treeTreatedProps.currentHeight) {
			float scaleAdd = treeTreatedProps.scaleToHeightRatio*treeTreatedProps.waterIncrement/2;
			Debug.Log (scaleAdd);
			treeTreated.transform.localScale += new Vector3 (scaleAdd, scaleAdd, scaleAdd);
			//GameObject treeTreatedText = GameObject.Find ("TreeTreatedText");
			//treeTreatedText.transform.localPosition += new Vector3 (0.0f, 0.1f, 0.0f);

			waterCount += waterIncrement;
			treeTreatedProps.currentHeight = treeTreated.transform.lossyScale.y / treeTreatedProps.scaleToHeightRatio;
		} else {
			Debug.Log ("ukurannya jangan ditambah");
		}





	}


}
