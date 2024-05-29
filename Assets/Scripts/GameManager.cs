using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private GameObject titleText, startBtn;
    public MapController mapController;

    public static GameManger Instance;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

    }

    public void onStartBtnClicked()
    {
        titleText.SetActive(false);
        startBtn.SetActive(false);

        mapController.getTheBallGoing();
    }
}