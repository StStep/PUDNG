using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    /// <summary>
    /// The single current instance of this class
    /// </summary>
    public static GameManager instance;

    public GameObject SelectedObject = null;

    protected void Awake() {
        // Only have one in game
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectItem(GameObject obj) {
        if (obj != SelectedObject) {
            SelectedObject = obj;
        }
    }
}
