using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour 
{
	
	public Text collectableText;
	
	private int nrOfTotalCollectables;
	private int nrOfCollectedItems;
	
	void Start () {
		
		GameObject[] collectables = GameObject.FindGameObjectsWithTag ("Collectable");
		nrOfTotalCollectables = collectables.Length;
		nrOfCollectedItems = 0;

		UpdateUI ();
		
	}

	void Update () {
		
	}
	
	public void AddCollectable()
	{
		nrOfCollectedItems++;
		UpdateUI ();
		Debug.Log ("je hebt " + nrOfCollectedItems + "van de " + nrOfCollectedItems);
		
		if (nrOfCollectedItems == nrOfTotalCollectables) {
			Application.LoadLevel(3);
		}
	}
	
	
	
	void UpdateUI()
	{
		collectableText.text = "Collectables: " + nrOfCollectedItems + "/" + nrOfTotalCollectables;
		
		
	}
	
}