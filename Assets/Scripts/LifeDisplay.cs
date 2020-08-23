using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] int life = 10;
    Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        lifeText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        lifeText.text = life.ToString();
    }

    public void TakeLife()
    {
        
        life -= 1;
        UpdateDisplay();
        
        if(life <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }


}
