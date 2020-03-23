using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ObjectDrag_Polygon : MonoBehaviour
{
    public int ObjectNumber;
    bool isDragged = false;
    public GameObject ButtonPrefab_2D;
    GameObject ObjectText;
    GameObject Empty;
    public int InitCount;
    Touch touch;
    RaycastHit2D hit2D;
    bool isHit;

    void Start()
    {
        //InitCount = 5;
        ObjectText = GameObject.Find("Canvas").transform.Find("Tools").transform.Find("Button" + ObjectNumber).transform.Find("Text" + ObjectNumber).gameObject;
        Empty = GameObject.Find("Canvas").transform.Find("Tools").transform.Find("Button" + ObjectNumber).transform.Find("Empty" + ObjectNumber).gameObject;
    }

    void Update()
    {
        ButtonMove();
        ObjectText.GetComponent<Text>().text = InitCount.ToString();
    }
    GameObject data;

    public void ButtonoDrag()
    {
        if (Input.touchCount == 0) return;
        touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            isDragged = true;
            if (InitCount > 0)
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
                pos.z = -5;
                data = Instantiate(ButtonPrefab_2D, pos, Quaternion.identity);
                this.InitCount--;//생성할때마다 감소
                data.GetComponent<PolygonCollider2D>().enabled = false;
            }
        }
    }

    public void ButtonMove()
    {

        if (InitCount <= 0)
            Empty.SetActive(true);

        if (Input.touchCount == 0) return;
        touch = Input.GetTouch(0);

        if (isDragged && touch.phase == TouchPhase.Moved)
        {
            var pos = Camera.main.ScreenToWorldPoint(touch.position);
            pos.z = -5;
            data.transform.position = pos;
            isHit = Physics2D.BoxCast(data.transform.position, data.transform.lossyScale, 0, Vector3.forward);

            if (!isHit)
                data.GetComponent<SpriteRenderer>().material.SetColor("_TintColor", new Color(1, 1, 1, 1));
            else
                data.GetComponent<SpriteRenderer>().material.SetColor("_TintColor", new Color(1, 0, 0, 1));
        }

        if (touch.phase == TouchPhase.Ended)
        {
            if (!isHit)
            {
                isDragged = false;
                data.GetComponent<PolygonCollider2D>().enabled = true;

                var meshRenderer = ButtonPrefab_2D.GetComponent<SpriteRenderer>();
                if (meshRenderer != null)
                {
                    data.GetComponent<SpriteRenderer>().material = meshRenderer.sharedMaterial;
                }
            }
        }
    }

}
