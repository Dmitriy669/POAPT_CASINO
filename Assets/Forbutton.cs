using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Forbutton : MonoBehaviour {
	public Button yourButton;
    public Camera camera;
    public GameObject g1;
    public GameObject g2;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		g1.SetActive(true);
        g2.SetActive(true);
        camera.transform.position = new Vector3(0, 0, -10);
        Debug.Log("Вы досрочно вышли из миссии!");
	}
}