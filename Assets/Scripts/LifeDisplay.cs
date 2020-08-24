using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] float baseLives=3;
    float life;
    Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        life = baseLives - PlayerPrefsController.GetDifficulty();
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
