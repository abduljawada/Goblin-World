using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [HideInInspector] public static DialogueManager instance;
    int dialoguePhase = 0;
    [SerializeField] GameObject dialogueUI;
    [SerializeField] RectTransform buttonRectTransform;
    [SerializeField] float buttonTextPaddingSize;
    [SerializeField] GameObject buttonPrefab;
    [SerializeField] Text npcNameField;
    [SerializeField] Text dialogueText;
    [SerializeField] float spaceBetweenButtons;
    [SerializeField] float multiplicationNumber;
    [SerializeField] Transform choicesHolder;
    Animator animator;
    List<GameObject> choicesObjects;
    [SerializeField] Health playerHealth;
    PlayerMana playerMana => PlayerMana.instance;
    GameManager gameManager => GameManager.instance;
    InventoryManager inventoryManager => InventoryManager.instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        instance = this;

        Text buttonText = buttonRectTransform.GetComponentInChildren<Text>();

        animator = dialogueUI.GetComponent<Animator>();

        choicesObjects = new List<GameObject>();

        buttonRectTransform.sizeDelta = new Vector2(buttonText.preferredWidth + buttonTextPaddingSize, buttonText.preferredHeight + buttonTextPaddingSize);
    }

    public void StartDialogue(string npcName, DialogueNode startingNode)
    {
        dialoguePhase = 0;

        dialogueUI.SetActive(true);

        animator.SetBool("Open", true);

        npcNameField.text = npcName;

        StartCoroutine(TypeText(startingNode.text));

        StartCoroutine(StartDialogueCoroutine(startingNode));

        
    }

    IEnumerator TypeText(string sentence)
    {
        dialogueText.text = "";

        //Wait for end of animation
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;

            yield return null;
        }


    }

    IEnumerator StartDialogueCoroutine(DialogueNode startingNode)
    {
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        foreach (DialogueChoice choice in startingNode.choices)
        {

            GameObject choiceObject = Instantiate(buttonPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            choiceObject.transform.SetParent(choicesHolder);

            choicesObjects.Add(choiceObject);

            Text choiceText = choiceObject.GetComponentInChildren<Text>();
            choiceText.text = choice.choiceText;

            RectTransform choiceRectTransform = choiceObject.GetComponent<RectTransform>();
            choiceRectTransform.localScale = Vector3.one;
            choiceRectTransform.sizeDelta = buttonRectTransform.sizeDelta;

            //if (choicesObjects.Count == 1)
            //{
            //choiceRectTransform.offsetMax = new Vector2(buttonRectTransform.offsetMax.x - choiceText.text.Length * multiplicationNumber * choicesObjects.Count - spaceBetweenButtons, buttonRectTransform.offsetMax.y);
            //choiceRectTransform.offsetMin = new Vector2(buttonRectTransform.offsetMin.x, buttonRectTransform.offsetMin.y);
            //}
            //else
            //{
            //RectTransform lastChoiceRectTransform = choicesObjects[choicesObjects.Count - 1].GetComponent<RectTransform>();
            //choiceRectTransform.offsetMax = new Vector2(lastChoiceRectTransform.offsetMax.x - choiceText.text.Length * multiplicationNumber - spaceBetweenButtons, buttonRectTransform.offsetMax.y);
            //choiceRectTransform.offsetMin = new Vector2(lastChoiceRectTransform.offsetMin.x, buttonRectTransform.offsetMin.y);
            //}

            Button choiceButton = choiceObject.GetComponent<Button>();

            Debug.Log(choice.amount);
            Debug.Log(inventoryManager.gold);
            if (choice.amount > inventoryManager.gold)
            {
                Debug.Log("t");
                choiceButton.interactable = false;
            }
            else
            {
                choiceButton.onClick.AddListener(() => OnClick(choice));
            }
        };
    }

    public void UpdateDialogue(DialogueNode nextNode)
    {
        dialoguePhase ++;

        foreach (GameObject choiceObject in choicesObjects.ToList())
        {
            Destroy(choiceObject);

            choicesObjects.Remove(choiceObject);
        }

        StartCoroutine(TypeText(nextNode.text));

        foreach (DialogueChoice choice in nextNode.choices)
        {

            GameObject choiceObject = Instantiate(buttonPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            choiceObject.transform.SetParent(choicesHolder);

            choicesObjects.Add(choiceObject);

            Text choiceText = choiceObject.GetComponentInChildren<Text>();
            choiceText.text = choice.choiceText;

            RectTransform choiceRectTransform = choiceObject.GetComponent<RectTransform>();
            choiceRectTransform.localScale = Vector3.one;
            choiceRectTransform.sizeDelta = buttonRectTransform.sizeDelta;

            //if (choicesObjects.Count == 1)
            //{
                //choiceRectTransform.offsetMax = new Vector2(buttonRectTransform.offsetMax.x - choiceText.text.Length * multiplicationNumber * choicesObjects.Count - spaceBetweenButtons, buttonRectTransform.offsetMax.y);
                //choiceRectTransform.offsetMin = new Vector2(buttonRectTransform.offsetMin.x, buttonRectTransform.offsetMin.y);
            //}
            //else
            //{
                //RectTransform lastChoiceRectTransform = choicesObjects[choicesObjects.Count - 1].GetComponent<RectTransform>();
                //choiceRectTransform.offsetMax = new Vector2(lastChoiceRectTransform.offsetMax.x - choiceText.text.Length * multiplicationNumber - spaceBetweenButtons, buttonRectTransform.offsetMax.y);
                //choiceRectTransform.offsetMin = new Vector2(lastChoiceRectTransform.offsetMin.x, buttonRectTransform.offsetMin.y);
            //}
            

            Button choiceButton = choiceObject.GetComponent<Button>();

            Debug.Log(choice.amount);
            Debug.Log(inventoryManager.gold);
            if (choice.amount > inventoryManager.gold)
            {
                Debug.Log("t");
                choiceButton.interactable = false;
            }
            else
            {
                choiceButton.onClick.AddListener(() => OnClick(choice));
            }
            
        };

    }

    public void EndDialogue()
    {
        //dialoguePhase = 0;
        Debug.Log("Talk to you later");

        animator.SetBool("Open", false);

        StartCoroutine(DialogueEndCoroutine());
    }

    IEnumerator DialogueEndCoroutine()
    {
        //Wait for end of animation
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        foreach (GameObject choiceObject in choicesObjects.ToList())
        {
            Destroy(choiceObject);

            choicesObjects.Remove(choiceObject);
        }
    }

    void OnClick(DialogueChoice choiceChosen)
    {
        inventoryManager.Remove(choiceChosen.amount);
        playerHealth.ModifyHealth(choiceChosen.health);
        playerMana.RegainMana(choiceChosen.mana);
        UpdateDialogue(choiceChosen.nextNode);
    }

}
