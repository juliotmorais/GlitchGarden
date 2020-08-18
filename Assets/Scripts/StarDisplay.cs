using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;
    
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
    public void AddStars(int amt)
    {
        stars += amt;
        UpdateDisplay();
    }
    public void subtractStars(int amt)
    {
        if (stars>=amt)
        {
            stars -= amt;
            UpdateDisplay();
        }
    }
    public bool HaveEnoughStars(int amt)
    {
        return stars >= amt;
    }
}
