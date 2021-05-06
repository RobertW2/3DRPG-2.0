using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    [SerializeField] Text responseText;
    public Dialogue currentDialogue;


    Dialogue loadedDialogue;

    [SerializeField] GameObject buttonPrefab;
    [SerializeField] Transform dialogueButtonPanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void LoadDialogue(Dialogue _dialogue)
    {
        transform.GetChild(0).gameObject.SetActive(true);
        loadedDialogue = _dialogue;

        ClearButtons();
        int i = 0;
        Button spawnedButton;
        foreach (LineOfDialogue1 item in _dialogue.DialogueOptions)
        {
            float currentApproval = FactionManager.instance.getFactionsApproval(_dialogue.faction);
            if (currentApproval != null && currentApproval > item.minApproval) 
            {
                spawnedButton = Instantiate(buttonPrefab, dialogueButtonPanel).GetComponent<Button>();
                spawnedButton.GetComponentInChildren<Text>().text = item.topic;
                int i2 = i;
                spawnedButton.onClick.AddListener(delegate
                {
                    ButtonPressed(i2);
                });
                i++;

            }

       

            // i2 will be a differnt instance next loop.
            // it will be "this" instance of i2 but if just i "ButtonPressed(i)" they will all reference the same thing.
    
            // delegate is a variable that acts like a fuction, button the function can change depending on different factors.

        }

        Button spanwnedButton = Instantiate(buttonPrefab, dialogueButtonPanel).GetComponent<Button>();
        spanwnedButton.GetComponentInChildren<Text>().text = _dialogue.goodbye.topic;


        // delegate is a variable that acts like a fuction, button the function can change depending on different factors.
        spanwnedButton.onClick.AddListener(EndConversation);


        //print(_dialogue.greeting);
        DisplayResponse(loadedDialogue.greeting);
    }

    void EndConversation()
    {
        ClearButtons();
        transform.GetChild(0).gameObject.SetActive(false);

        DisplayResponse(loadedDialogue.goodbye.response);

        if (loadedDialogue.goodbye.nextDialogue != null)
        {
            LoadDialogue(currentDialogue.goodbye.nextDialogue);
           // currentDialogue = currentDialogue.goodbye.nextDialogue;
           

        }
        else
        {
            // Set pannel active false
        }
    }

    void ButtonPressed(int _index)
    {
        // print(loadedDialogue.DialogueOptions[_index].response);
        DisplayResponse(loadedDialogue.DialogueOptions[_index].response);
    }
    // move to the top with other variables
    private void DisplayResponse(string response)
    {
        //  Debug.Log(response);
        responseText.text = response;
    }

    void ClearButtons()
    {
        foreach (Transform child in dialogueButtonPanel)
        {
            Destroy(child.gameObject);
        }
    }
}