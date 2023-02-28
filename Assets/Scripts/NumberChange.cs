using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class NumberChange : AClickable
{
    public TextMeshPro Text;
    private int value = 0;

    public bool IsLetter;

    private const int MAX_LETTERS = 26;
    private const int MAX_NUMBER = 10;

    private char A_LETTER = 'A';

    private int MaxValue = MAX_NUMBER;
    private int FirstValue = 0;
    
    void Start()
    {
        Text.text = value.ToString();
        if (IsLetter)
        {
            MaxValue = MAX_LETTERS;
            FirstValue = A_LETTER;
            value = FirstValue;
            Text.text = ((char) value).ToString();
        }
        
    }

    public int GetValue()
    {
        return value;
    }

    public override void Click()
    {
        value++;

        if (value == FirstValue + MaxValue) value = FirstValue;
        string text = value.ToString();
        
        if (IsLetter)
        {
            text = ((char) value).ToString();
        }

        Text.text = text;
    }
}
