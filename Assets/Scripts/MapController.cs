using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] private BallController ballController;

    private void Start()
    {
        GameManger.Instance.mapController = this;
    }

    public void getTheBallGoing()
    {
        ballController.getTheBallGoing();
    }
}
