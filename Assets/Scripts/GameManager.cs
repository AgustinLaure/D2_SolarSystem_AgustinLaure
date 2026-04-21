using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject deathMessage;
    [SerializeField] private GameObject wonMessage;
    [SerializeField] private GameObject celestials;

    bool isGameFinished = false;
    private float postPlayerFinishTime = 0f;
    private const float timeBeforeRestart = 5f;
    private void Update()
    {
        if (!IsPlayerAlive())
        {
            isGameFinished = true;
            deathMessage.SetActive(true);
        }
        else if (!ArePlanetsAlive())
        {
            isGameFinished = true;
            wonMessage.SetActive(true);
        }

        if (isGameFinished)
        {
            postPlayerFinishTime += Time.deltaTime;

            if (postPlayerFinishTime >= timeBeforeRestart)
            {
                SceneManager.LoadScene("Gameplay");
            }
        }
    }
    private bool IsPlayerAlive()
    {
        return player != null;
    }

    private bool ArePlanetsAlive()
    {
        bool arePlanetsAlive = false;

        foreach (Transform planet in celestials.transform)
        {
            if (planet.gameObject.CompareTag("Planet") && planet.gameObject.activeSelf)
            {
                arePlanetsAlive = true;
            }
        }

        return arePlanetsAlive;
    }
}
