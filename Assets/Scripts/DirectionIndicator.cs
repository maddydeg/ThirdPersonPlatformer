using Unity.Cinemachine;
using UnityEngine;

public class DirectionIndicator : MonoBehaviour
{

    [SerializeField] private CinemachineCamera freeLookCamera;

    // Update is called once per frame
    void Update()
    {
        transform.forward = freeLookCamera.transform.forward;
    }
}
