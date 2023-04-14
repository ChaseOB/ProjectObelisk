using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraShaderToggle : MonoBehaviour
{
    public GameObject image;
    public Camera camera;
    public Material mat;
    
    private void OnEnable() {
        GameManager.OnGameStateChanged += OnGameStateChange;
    }

    private void OnDisable() {
        GameManager.OnGameStateChanged -= OnGameStateChange;
    }

     private void OnGameStateChange(object sender, OnGameStateChangedArgs e) {
        image.SetActive(e.NewState == GameState.Plan);
    }

    private void Update() {
        //RenderTexture rt = new RenderTexture(Screen.width, Screen.height, 16, RenderTextureFormat.ARGB32);
       // camera.targetTexture = rt;
        //mat.SetTexture("_RenderTexture", rt);
    }
}
