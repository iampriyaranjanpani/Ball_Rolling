using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        gameManager.GetComponent<GameManager>().WinLevel();
    }
}
