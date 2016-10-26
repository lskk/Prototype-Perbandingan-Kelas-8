using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TreeClass : MonoBehaviour {
	public GameObject theTree;
	public GameObject example;
	public float initialHeight;
	public float currentHeight;
	public float initialScale;
	public float currentScale;
	public float scaleToHeightRatio;
	public float sunIncrement;
	public float waterIncrement;
	Text treeText;

	// Use this for initialization
	void Start () {

		if (example != null) {
			TreeClass exampleProps = (TreeClass)example.GetComponent (typeof(TreeClass));
			scaleToHeightRatio = exampleProps.scaleToHeightRatio;

			float scale = initialHeight / exampleProps.initialHeight *scaleToHeightRatio;
			theTree.transform.localScale = new Vector3 (scale, scale, scale);
			sunIncrement = exampleProps.sunIncrement;
			waterIncrement = exampleProps.waterIncrement;
		} else {

			initialScale = theTree.transform.lossyScale.y;
			currentScale = theTree.transform.lossyScale.y;
			scaleToHeightRatio = initialScale / initialHeight;
		}



		treeText = theTree.transform.parent.FindChild ("TreeText").FindChild ("Canvas").FindChild ("Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		treeText.text = string.Format ("{0} meter", currentHeight);


		if (example != null) {
			TreeClass exampleProps = (TreeClass)example.GetComponent (typeof(TreeClass));

			GameObject notification = GameObject.Find ("Notification");
			if (Mathf.Approximately(currentHeight,exampleProps.initialHeight)) {
				notification.transform.localScale = new Vector3 (1, 1, 1);

				Text notificationText = notification.transform.FindChild ("Canvas").FindChild ("Text").GetComponent<Text> ();
				notificationText.text = "Hoho!! Sangat Indah!!\nUkurannya sangat pas dengan harapanku!!\nPertahankan Kinerjamu!";
			} else if (currentHeight > exampleProps.currentHeight) {
				notification.transform.localScale = new Vector3 (1, 1, 1);

				Text notificationText = notification.transform.FindChild ("Canvas").FindChild ("Text").GetComponent<Text> ();
				notificationText.text = "hmmm. Tanamannya terlalu besar.\nUntuk kali ini tidak apa-apa. \nLain kali lebih hati-hati ya";
			}
		}
	}
}
