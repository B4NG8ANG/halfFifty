using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingTableConfirmManager : MonoBehaviour
{
    GameObject Scroll;
    string DetailExpression1;
    string ScrollType;
    public GameObject DetailImage;
    
    //제작 취소 기능
    public void CancelButtonClick()
    {
        //세부사항 창 찾음
        DetailImage = GameObject.Find("DetailImage");
        DetailExpression1 = GameObject.Find("DetailExpression1").GetComponent<Text>().text;
        ScrollType = DetailExpression1.Substring(DetailExpression1.Length - 2);
        
        //세부사항의 문자열을 이용해 해당 아이템이 어느 스크롤뷰에 있는지 찾음
        if(ScrollType == "도구")
        {
            Scroll = GameObject.Find("ToolScroll");
            
        }
        else if(ScrollType == "음식")
        {
            Scroll = GameObject.Find("FoodScroll");
        }

        //세부사항 창 닫음
        DetailImage.SetActive(false);

        //해당 스크롤뷰 켜짐
        Scroll.SetActive(true);
    }
}
