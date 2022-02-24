using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject Scary;
    public GameObject Baby;
    public GameObject Ginger;
    public GameObject Posh;
    public GameObject Sporty;
    private string charchoose;

    // Start is called before the first frame update
    void Start()
    {
        charchoose = CharacterSelect.charchoose;

        switch(charchoose)
        {
            case "Scary":
                Instantiate(Scary);
                break;
            case "Baby":
                Instantiate(Baby);
                break;
            case "Ginger":
                Instantiate(Ginger);
                break;
            case "Posh":
                Instantiate(Posh);
                break;
            case "Sporty":
                Instantiate(Sporty);
                break;
        }
    }
}
