using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class DiologueImageScript : MonoBehaviour
{
    public DiologueScript diologueScript;
    public GameObject Image;
    public TextMeshProUGUI Name;

    private void Update()
    {
        if ((diologueScript.index >= 2) && (diologueScript.index <= 3))
        {
            CharacterAppearence(Image, "Erika");
        }
        else
        {
            CharacterDisppearence(Image, "");
        }
    }

    public void CharacterAppearence(GameObject waifu, string name)
    {
        waifu.SetActive(true);
        Name.text = name;
    }

    public void CharacterDisppearence(GameObject waifu, string name)
    {
        waifu.SetActive(false);
        Name.text = name;
    }

}
