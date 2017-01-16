using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using UnityEngine.UI.Text;

public class DataLoader : MonoBehaviour {
    public Text abc;
    public Text abc1;
    public Text abc2;
    public Button createdButton;

	// Use this for initialization
	IEnumerator Start () {
        WWW itemsData =new WWW("http://localhost:1234/Cool_YT_RPG/ItemsData.php");
        yield return itemsData;
        string itemsDataString = itemsData.text;
        print(itemsDataString);
        Debug.Log(itemsDataString);
        
        abc.text = itemsDataString;
        abc1.text = itemsDataString;
        abc2.text = itemsDataString;
        //Button.UI.text = itemsDataString;

    }
    void Update ()
    {
        StartCoroutine(updatefunction());
    }

    IEnumerator updatefunction()
    {
        WWW itemsData = new WWW("http://localhost:1234/Cool_YT_RPG/ItemsData.php");
        yield return  itemsData;
        
        string itemsDataString = itemsData.text;
        print(itemsDataString);
        Debug.Log(itemsDataString);

        abc.text = itemsDataString;
        abc1.text = itemsDataString;
        abc2.text = itemsDataString;
        //Button.UI.text = itemsDataString
    }



}
