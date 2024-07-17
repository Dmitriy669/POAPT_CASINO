using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiirstLevelRazboi : MonoBehaviour
{
    public Camera camera;
    public GameObject g1;
    public GameObject g2;
    public int d1 = 0;
    void OnTriggerEnter(Collider other){
        if(d1 ==3){
            Debug.Log("Вы действительно хотите пройти миссию ещё раз, если да - нажмите 'Space'!");
        }
        else{
            Debug.Log("Нажмите 'Space', чтобы начать миссию!");
        }
        d1 = 1;
    }
    void OnTriggerExit(Collider other){
        Debug.Log("Вернитесь в зону миссии!");
        d1 = 0;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) & d1 == 1){
            Debug.Log("Нажмите 'Q', чтобы досрочно закончить миссию!");
            camera.transform.position = new Vector3(-49.9f, 0, -10);
            g1.SetActive(false);
            g2.SetActive(false);
            d1 = 2;
        }
        if(Input.GetKeyDown(KeyCode.Q) & d1 == 2){
            Debug.Log("Вы досрочно вышли из миссии!");
            camera.transform.position = new Vector3(0, 0, -10);
            g1.SetActive(true);
            g2.SetActive(true);
            d1 = 3;
        }
    }
}
