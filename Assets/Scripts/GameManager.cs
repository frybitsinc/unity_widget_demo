using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    // public PrefabManager prefabManager;
    // public ItemManager itemManager;
    // public GameObject someObject;
    // public SceneManager sceneManager;

    // Start is called before the first frame update
    void Start(){
        SceneManager.LoadScene("Menu 3D");
    }

    // Update is called once per frame
    void Update(){
        // if(Input.GetMouseButtonDown(0)){
        //     SceneManager.LoadScene("Controls");
        // }
        // if(Input.GetMouseButtonDown(1)){
        //     SceneManager.LoadScene("Draggable Panel");
        // }
    }

    public void OnClickBackButton ()
	{
		SceneManager.LoadScene("Menu 3D");
	}
}
