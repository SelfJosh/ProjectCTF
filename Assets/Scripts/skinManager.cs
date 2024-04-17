using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class skinManager : MonoBehaviour
{

    public SpriteRenderer sR;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerSkin;

    public void nextSkin()
    {
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sR.sprite = skins[selectedSkin];
    }

    public void prevSkin()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        sR.sprite = skins[selectedSkin];
    }

    public void playGame()
    {

        PrefabUtility.SaveAsPrefabAsset(playerSkin, "Assets/Sprites/SelectedSkin.prefab");
        SceneManager.LoadScene(2);
    
    }
}
