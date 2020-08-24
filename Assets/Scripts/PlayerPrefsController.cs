using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "mastervolume";
    const string DIFFICULTY_KEY = "difficulty";
    const float MIN_VOLUME=0f;
    const float MAX_VOLUME=1f;
    const float MIN_DIFFICULTY =0f;
    const float MAX_DIFFICULTY =1f;


    public static void SetMasterVolume(float vol)
    {
        if (vol>=MIN_VOLUME && vol<=MAX_VOLUME)
        {
            Debug.Log("vol set");
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, vol);
        }
        else
        {
            Debug.LogError("volume Out of Range");
        }
        
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <=MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.Log("not in range difficulty");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

}
