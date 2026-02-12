using UnityEngine;
using UnityEngine.Rendering;

public class ZoomCamera : MonoBehaviour
{
    public float fovNormal = 55f;
    public float fovZoom = 30f;
    public float velocidadeZoom = 5f;

    public Camera cam2;

    void Start()
    {
        cam2 = GetComponent<Camera>();
        if (cam2 != null)
            cam2.fieldOfView = fovNormal;
        else
            Debug.LogWarning("ZoomCamera: componente Camera não encontrado no GameObject.", this);
    }

    void Update()
    {
        if (cam2 == null || !cam2.enabled) return; // Só funciona se a câmera estiver ativa

        float alvoFOV = Input.GetKey(KeyCode.LeftShift) ? fovZoom : fovNormal;

        cam2.fieldOfView = Mathf.Lerp(cam2.fieldOfView, alvoFOV, Time.deltaTime * velocidadeZoom);
    }
}

