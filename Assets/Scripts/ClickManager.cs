using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    public void OnClickBackButton ()
	{
		SceneManager.LoadScene("Menu 3D");
	}
}
