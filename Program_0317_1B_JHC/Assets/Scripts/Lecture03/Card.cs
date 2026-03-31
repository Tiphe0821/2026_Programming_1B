using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Card : MonoBehaviour
{
    // 변수
    public TextMeshProUGUI card;
    public int cardNum;
    public float rotateSpeed;
    public bool isClick = false;
    public Quaternion flipRotation = Quaternion.Euler(0, 180f, 0);
    public Quaternion originRotation = Quaternion.Euler(0, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        card = GetComponentInChildren<TextMeshProUGUI>();

        cardNum = Random.Range(0, 10);

        card.text = cardNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // 0 => 180 => -180 => 0
        //if (isClick)
        //{
        //    if (transform.eulerAngles.y >= 0 && transform.eulerAngles.y < 180)
        //    {
        //        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        //    }
        //}

        if(isClick)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, flipRotation, rotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, originRotation, rotateSpeed * Time.deltaTime);
        }
    }

    // 카드 돌리기
    public void ClickCard()
    {
        isClick = !isClick;
    }
}
