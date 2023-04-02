using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;

    
    public Texture skyBoxRef;
    [SerializeField] private GameObject cameraMain;

    //Level Change Function
    [SerializeField] private List<GameObject> levelList = new List<GameObject>();
    private int levelIndexNum;

    //RandomFactText
    [SerializeField] private List<GameObject> factList = new List<GameObject>();

    public List<AudioClip> audioClips = new List<AudioClip>();

    public AudioSource audioSource;

    //public bool isWin;

    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        Time.timeScale = 1;
        audioSource = GetComponent<AudioSource>();

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

    public void WinLevel()
    {
        audioSource.PlayOneShot(audioClips[1]);
        winScreen.SetActive(true);
        if (factList[levelIndexNum].activeSelf == false)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                factList[i].SetActive(false);
            }
            factList[levelIndexNum].SetActive(true);
        }
        StartCoroutine(StopTime());
    }

    public void ChangeLevel()
    {
        audioSource.PlayOneShot(audioClips[0]);
        if (PlayerPrefs.GetInt("LevelIndex") == (levelList.Count -1))
        {
            Debug.Log("ResetLevel");
            PlayerPrefs.SetInt("LevelIndex", 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);     
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator StopTime()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
