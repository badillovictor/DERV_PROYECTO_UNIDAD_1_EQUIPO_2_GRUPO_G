using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerDialogue : MonoBehaviour
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

    int _dialogID;

    public void showMessage()
    {
        txtActor.text = dialogueList[_dialogID].actor;
        txtMessage.text = dialogueList[_dialogID].message;
        sprtImage.sprite = dialogueList[_dialogID].img;
    }

    // Start is called before the first frame update
    void Start()
    {
        _dialogID = 0;
        showMessage();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _dialogID++;
            _dialogID %= dialogueList.Count;
            showMessage();
        }
    }
}
