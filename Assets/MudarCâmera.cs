using UnityEngine;
using UnityEngine.Rendering;

public class MudarCâmera : MonoBehaviour
{

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject MainCamera;

    void cam1()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        MainCamera.SetActive(false);
    }

    void cam2()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(true);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        MainCamera.SetActive(false);
    }

    void cam3()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(true);
        Cam4.SetActive(false);
        MainCamera.SetActive(false);
    }

    void cam4()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(true);
        MainCamera.SetActive(false);
    }

    void camMain()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        MainCamera.SetActive(true);
    }

    void Start()
    {
        camMain();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cam1();
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cam2();
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cam3();
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            cam4();
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            camMain();
        }
    }

}
