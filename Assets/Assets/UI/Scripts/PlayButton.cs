using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayButton : MonoBehaviour
{
    public GameObject StartUI;
    public GameObject Panel;
    private Image PanelI;
    public GameObject Button;
    private Transform ButtonI;

    private bool ClearOut = false;
    private int cleaning = 0;
    private Color Target_Opacity;

    // Start is called before the first frame update
    void Start()
    {
        PanelI = Panel.GetComponent<Image>();
        ButtonI = Button.GetComponent<Transform>();
        Target_Opacity = PanelI.color;
        Target_Opacity.a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ClearOut)
        {
            cleaning++;
            if(cleaning > 100)
            {
                cleaning = 0;
                ClearOut = false;
                StartUI.SetActive(false);
            }
            else
            {
                PanelI.color = Color.Lerp(PanelI.color, Target_Opacity, 0.02f);
                ButtonI.position = new Vector2(ButtonI.position.x, ButtonI.position.y - 4);
            }

        }
            
    }

    public void StartGame()
    {
        ClearOut = true;
    }
}
