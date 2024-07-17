using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BALANCEcode : MonoBehaviour
{
    public Button buttHIT;
    public Button buttST;
    public Button buttDEAL;
    public Button butt10K;
    public Button butt5K;
    public Button butt1K;
    public Button butt100;
    public Button butt25;
    public Button buttSTAVKA;
    public Image buttSTAVKA1;
    public GameObject buttSTAVKA2;
    public GameObject butt10K1;
    public GameObject butt5K1;
    public GameObject butt1K1;
    public GameObject butt1001;
    public GameObject butt251;
    public GameObject buttST1;
    public GameObject buttHIT1;
    public GameObject buttDEAL1;
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject de1;
    public GameObject de2;
    public GameObject de3;
    public GameObject de4;
    public GameObject de5;
    public Image nnn1;
    int balance = 2500;
    int outbalance = 0;
    int znachKarti1 = 0;
    int znachKarti2 = 0;
    int znachKarti3 = 0;
    int znachKarti4 = 0;
    int znachKarti5 = 0;
    int znachKartiDEAL1 = 0;
    int znachKartiDEAL2 = 0;
    int znachKartiDEAL3 = 0;
    int znachKartiDEAL4 = 0;
    int znachKartiDEAL5 = 0;
    int dada = 0;
    public Image nn1;
    public Image nn2;
    public Image dee1;
    string forn1;
    string forn2;
    string forde1;

    string fornn1;
    string fornn2;
    string fordee1;
    string just;
    void Premium(int znach, string perem){
        if(znach <= 13){
            perem = "D";
        }
        else if(znach <= 26){
            perem = "H";
        }
        else if(znach <= 39){
            perem = "C";
        }
        else if(znach <= 52){
            perem = "S";
        }


        if((znach % 13) == 1){
            perem = perem + "01";
        }
        else if((znach % 13) == 2){
            perem = perem + "02";
        }
        else if((znach % 13) == 3){
            perem = perem + "03";
        }
        else if((znach % 13) == 4){
            perem = perem + "04";
        }
        else if((znach % 13) == 5){
            perem = perem + "05";
        }
        else if((znach % 13) == 6){
            perem = perem + "06";
        }
        else if((znach % 13) == 7){
            perem = perem + "07";
        }
        else if((znach % 13) == 8){
            perem = perem + "08";
        }
        else if((znach % 13) == 9){
            perem = perem + "09";
        }
        else if((znach % 13) == 10){
            perem = perem + "10";
        }
        else if((znach % 13) == 11){
            perem = perem + "11";
        }
        else if((znach % 13) == 12){
            perem = perem + "12";
        }
        else if((znach % 13) == 0){
            perem = perem + "13";
        }
        just = perem;
    }
    void Start(){
        buttSTAVKA.GetComponent<Image>().sprite = Resources.Load<Sprite>("Screenshot_20240715_112806_Gmail");
        outbalance = balance;
        Premium(52, forn2);
        nn1.GetComponent<Image>().sprite = Resources.Load<Sprite>("backc");//////////////////////////////////////////////////////////////
        Debug.Log(just);
        Button btn = buttDEAL.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClickDEAL);
        Button btn1 = buttHIT.GetComponent<Button>();
		btn1.onClick.AddListener(TaskOnClickHIT);
        Button btn2 = buttST.GetComponent<Button>();
		btn2.onClick.AddListener(TaskOnClickST);
        Button btn10K = butt10K.GetComponent<Button>();
		btn10K.onClick.AddListener(T10K);
        Button btn5K = butt5K.GetComponent<Button>();
		btn5K.onClick.AddListener(T5K);
        Button btn1K = butt1K.GetComponent<Button>();
		btn1K.onClick.AddListener(T1K);
        Button btn100 = butt100.GetComponent<Button>();
		btn100.onClick.AddListener(T100);
        Button btn25 = butt25.GetComponent<Button>();
		btn25.onClick.AddListener(T25);
        balance = 2500;
        buttST.enabled = false;
        buttHIT.enabled = false;
        buttST1.SetActive(false);
        buttHIT1.SetActive(false);
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(false);
        n4.SetActive(false);
        n5.SetActive(false);
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
    }

    void TaskOnClickDEAL(){
        if(outbalance == balance){
            Debug.Log("Сначала нужно сделать ставку!");
        }
        else{
        balance = outbalance;
        Debug.Log(balance);
        outbalance = 0;
        buttDEAL1.SetActive(false);
        buttST.enabled = true;
        buttHIT.enabled = true;
        buttST1.SetActive(true);
        buttHIT1.SetActive(true);
        znachKarti1 = Random.Range(1, 52);
        znachKarti2 = Random.Range(1, 52);
        while(znachKarti1 == znachKarti2){
            znachKarti2 = Random.Range(1, 52);
            znachKarti1 = Random.Range(1, 52);
        }
        Debug.Log(znachKarti1);
        Debug.Log(znachKarti2);


        znachKartiDEAL1 = Random.Range(1, 52);
        znachKartiDEAL2 = Random.Range(1, 52);
        while(znachKartiDEAL1 == znachKartiDEAL2 |  znachKartiDEAL1 == znachKarti1 | znachKartiDEAL1 == znachKarti2 | znachKartiDEAL2 == znachKarti1 | znachKartiDEAL2 == znachKarti2){
            znachKartiDEAL2 = Random.Range(1, 52);
            znachKartiDEAL1 = Random.Range(1, 52);
        }
        Debug.Log(znachKartiDEAL1);
        Debug.Log(znachKartiDEAL2);
        n1.SetActive(true);
        n2.SetActive(true);
        de1.SetActive(true);
        de2.SetActive(true);
        //nn1.GetComponent<Image>().sprite = Resources.Load("") as Sprite;
        //nn2.GetComponent<Image>().sprite = Resources.Load("") as Sprite;
        //dee1.GetComponent<Image>().sprite = Resources.Load("") as Sprite;
        butt10K1.SetActive(false);
        butt5K1.SetActive(false);
        butt1K1.SetActive(false);
        butt1001.SetActive(false);
        butt251.SetActive(false);
    }}
    void TaskOnClickHIT(){
        if(dada == 3){
            Debug.Log("Слишком много, подите прочь!");
            balance = 1000000;
            buttHIT1.SetActive(false);
            buttST1.SetActive(false);
        }
        else if(dada == 2){
            n5.SetActive(true);
            dada = 3;
        }
        else if(dada == 1){
            n4.SetActive(true);
            dada = 2;
        }
        else if(dada == 0){
            n3.SetActive(true);
            dada = 1;
        }
    }
    void TaskOnClickST(){
        buttHIT1.SetActive(false);
        buttST1.SetActive(false);
    }
    void T10K(){
        outbalance -= 10000;
        if(outbalance < 10000){
            butt10K1.SetActive(false);
        }
        if(outbalance < 5000){
            butt5K1.SetActive(false);
        }
        if(outbalance < 1000){
            butt1K1.SetActive(false);
        }
        if(outbalance < 100){
            butt1001.SetActive(false);
        }
        if(outbalance < 25){
            butt251.SetActive(false);
        }
    }
    void T5K(){
        outbalance -= 5000;
        if(outbalance < 10000){
            butt10K1.SetActive(false);
        }
        if(outbalance < 5000){
            butt5K1.SetActive(false);
        }
        if(outbalance < 1000){
            butt1K1.SetActive(false);
        }
        if(outbalance < 100){
            butt1001.SetActive(false);
        }
        if(outbalance < 25){
            butt251.SetActive(false);
        }
    }
    void T1K(){
        outbalance -= 1000;
        if(outbalance < 10000){
            butt10K1.SetActive(false);
        }
        if(outbalance < 5000){
            butt5K1.SetActive(false);
        }
        if(outbalance < 1000){
            butt1K1.SetActive(false);
        }
        if(outbalance < 100){
            butt1001.SetActive(false);
        }
        if(outbalance < 25){
            butt251.SetActive(false);
        }
    }
    void T100(){
        outbalance -= 100;
        Debug.Log(outbalance);
        if(outbalance < 10000){
            butt10K1.SetActive(false);
        }
        if(outbalance < 5000){
            butt5K1.SetActive(false);
        }
        if(outbalance < 1000){
            butt1K1.SetActive(false);
        }
        if(outbalance < 100){
            butt1001.SetActive(false);
        }
        if(outbalance < 25){
            butt251.SetActive(false);
        }
    }
    void T25(){
        outbalance -= 25;
        if(outbalance < 10000){
            butt10K1.SetActive(false);
        }
        if(outbalance < 5000){
            butt5K1.SetActive(false);
        }
        if(outbalance < 1000){
            butt1K1.SetActive(false);
        }
        if(outbalance < 100){
            butt1001.SetActive(false);
        }
        if(outbalance < 25){
            butt251.SetActive(false);
        }
    }
    void Update(){
        if(balance < 10000){
            butt10K1.SetActive(false);
        }
        if(balance < 5000){
            butt5K1.SetActive(false);
        }
        if(balance < 1000){
            butt1K1.SetActive(false);
        }
        if(balance < 100){
            butt1001.SetActive(false);
        }
        if(balance < 25){
            butt251.SetActive(false);
        }
    }
}
