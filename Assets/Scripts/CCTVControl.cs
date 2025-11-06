using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
public class CCTVControl : MonoBehaviour
{
    [SerializeField] CinemachineCamera[] cameras;

    public void OnCam1()
    {
        SwitchCam(0);
    }
    public void OnCam2()
    {
        SwitchCam(1);
    }
    public void OnCam3()
    {
        SwitchCam(2);
    }
    public void OnCam4()
    {
        SwitchCam(3);
    }

    private void SwitchCam(int num)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if(i == num)
                cameras[i].Priority = 10;
            else 
                cameras[i].Priority = 8;
        }
    }
}
