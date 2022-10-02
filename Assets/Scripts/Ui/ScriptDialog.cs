using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDialog : MonoBehaviour
{
    public DialogData dialogData;

    Text characterName;
    Text dialogText;
    Image characterImg;
    int curIndexDialog = 0;

    // Start is called before the first frame update
    void OnEnable()
    {
        Time.timeScale = 0f;

        characterName = GameObject.Find("CharacterName").GetComponent<Text>();
        characterName.text = dialogData.listCharacterNames[curIndexDialog];

        dialogText = GameObject.Find("TextDialog").GetComponent<Text>();
        dialogText.text = dialogData.listDialogTexts[curIndexDialog];

        characterImg = GameObject.Find("CharacterImg").GetComponent<Image>();
        characterImg.sprite = dialogData.listCharacterImgs[curIndexDialog];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        curIndexDialog++;

        if (curIndexDialog < dialogData.listDialogTexts.Count)
        {
            characterName = GameObject.Find("CharacterName").GetComponent<Text>();
            characterName.text = dialogData.listCharacterNames[curIndexDialog];

            dialogText = GameObject.Find("TextDialog").GetComponent<Text>();
            dialogText.text = dialogData.listDialogTexts[curIndexDialog];

            characterImg = GameObject.Find("CharacterImg").GetComponent<Image>();
            characterImg.sprite = dialogData.listCharacterImgs[curIndexDialog];
        }
        else
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
