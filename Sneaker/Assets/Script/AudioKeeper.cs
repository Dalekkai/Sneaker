using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioKeeper : MonoBehaviour
{
      void Awake() //Keep the audio jammin! Currently playing multiple audios TODO!
    {
       DontDestroyOnLoad(transform.gameObject);
    }
}
