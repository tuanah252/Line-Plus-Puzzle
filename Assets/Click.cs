using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite red;
    public Sprite blue;
    private Image image;
    private Button button;
    private int count = 0;
    void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    public void Change(string s)
    {
        if (s == "x")
        {
            image.sprite = blue;
        }
        else
        {
            image.sprite = red;
        }
    }
    public void OnClick()
    {
        count++;
        if (count % 2 == 0)
        {
            Change("x");
        }
        else
        {
            Change("o");
        }
    }
}
