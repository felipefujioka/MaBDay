using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<string> Keys;
    public List<GameObject> Items;

    public GameObject Canvas;
    public Image Image;

    private void Update()
    {
        for (int i = 0; i < Keys.Count; i++)
        {
            if (KeyController.Instance.GetKey(Keys[i]))
            {
                Items[i].SetActive(true);
                var sprite = Items[i].GetComponent<Image>().sprite;
                Items[i].GetComponent<Button>().onClick.AddListener(() =>
                {
                    ShowItem(sprite);
                });

                Keys.RemoveAt(i);
                Items.RemoveAt(i);
                i--;
                
            }
        }
    }

    private void ShowItem(Sprite item)
    {
        Canvas.SetActive(true);
        Image.sprite = item;
    }
}
