using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Card : MonoBehaviour
{
    // 변수
    public TextMeshProUGUI card;
    public int cardNum;

    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        card = GetComponentInChildren<TextMeshProUGUI>();

        card.text = cardNum.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 180 * Time.deltaTime, 0);
    }

    // 카드 돌리기
}
