using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen;

    public Texture skyBoxRef;
    [SerializeField] private GameObject cameraMain;

    //Level Change Function
    [SerializeField] private List<GameObject> levelList = new List<GameObject>();
    private int levelIndexNum;

    //public bool isWin;

    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        levelIndexNum = PlayerPrefs.GetInt("LevelIndex");

        if (levelList[levelIndexNum].activeSelf == false)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                levelList[i].SetActive(false);
            }
            levelList[levelIndexNum].SetActive(true);
        }
        cameraMain.GetComponent<RotateSkyBox>().skyBoxM.SetTexture("_Tex", skyBoxRef);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WinLevel()
    {
        winScreen.SetActive(true);
    }

    public void ChangeLevel()
    {
        PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
