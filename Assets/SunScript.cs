using UnityEngine;
using System.Collections;


public class SunScript : MonoBehaviour {
	public float exposureCount;
	public float exposureIncrement;
	// Use this for initialization
	void Start () {
		Debug.Log ("TEST");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		//Debug.Log ("TESTXXX");
		GameObject sun = GameObject.Find("SunController");
		sun.transform.localScale += new Vector3 (0.2f, 0.2f, 0.2f);
	}

	void OnMouseExit(){
		GameObject sun = GameObject.Find("SunController");
		sun.transform.localScale -= new Vector3 (0.2f, 0.2f, 0.2f);
	}

	void OnMouseDown(){
		GameObject treeTreated = GameObject.Find ("Tree_treated");
		TreeClass treeTreatedProps = (TreeClass) treeTreated.GetComponent (typeof(TreeClass));
		GameObject treeExample = GameObject.Find ("Tree_example");
		TreeClass treeExampleProps = (TreeClass) treeExample.GetComponent (typeof(TreeClass));

		if ( treeExampleProps.initialHeight >treeTreatedProps.currentHeight) {
			float scaleAdd = treeTreatedProps.scaleToHeightRatio*treeTreatedProps.sunIncrement/2;
			Debug.Log (scaleAdd);
			treeTreated.transform.localScale += new Vector3 (scaleAdd, scaleAdd, scaleAdd);
			//GameObject treeTreatedText = GameObject.Find ("TreeTreatedText");
			//treeTreatedText.transform.localPosition += new Vector3 (0.0f, 0.1f, 0.0f);

			exposureCount += exposureIncrement;
			treeTreatedProps.currentHeight = treeTreated.transform.lossyScale.y / treeTreatedProps.scaleToHeightRatio;
		} else {
			Debug.Log ("ukurannya jangan ditambah");
		}



	}


}
