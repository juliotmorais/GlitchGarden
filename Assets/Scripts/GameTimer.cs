using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in seconds")]
    [SerializeField] float levelTime = 100;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool timerFInished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFInished)
        {
            FindObjectOfType<SceneLoader>().LoseScreen();
        }
    }
}
