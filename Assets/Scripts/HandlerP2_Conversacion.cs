using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HandlerP2_Conversacion : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogue
    {
        public string actor;
        public string message;
        public Sprite img;
    }

    public List<Dialogue> dialogueList;

    [SerializeField] TextMeshProUGUI txtActor;
    [SerializeField] TextMeshProUGUI txtMessage;
    [SerializeField] Image sprtImage;

    int dialogID;

    public void showMessage()
    {
        txtActor.text = dialogueList[dialogID].actor;
        txtMessage.text = dialogueList[dialogID].message;
        sprtImage.sprite = dialogueList[dialogID].img;
    }

    // Start is called before the first frame update
    void Start()
    {
        dialogID = 0;
        showMessage();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogID++;
            dialogID %= dialogueList.Count;
            showMessage();
        }
    }
}
