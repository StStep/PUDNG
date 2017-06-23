using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakePath() {
        if (GameManager.instance.SelectedObject != null) {
            Vector3 StartPoint = GameManager.instance.SelectedObject.transform.position;
            Debug.Log("Position is " + StartPoint);
        }
    }
}
