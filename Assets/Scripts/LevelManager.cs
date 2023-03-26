using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    public Texture skyBoxTexture;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager.GetComponent<GameManager>().skyBoxRef = skyBoxTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
