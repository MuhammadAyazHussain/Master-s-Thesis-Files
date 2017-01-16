using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class DataBaseAccess : MonoBehaviour {
	public Text abc;
	public Text abc1;
	public Text abc2;
	public Text abcS;
	public Button createdButton;
	public string[] items;

	// Use this for initialization
	IEnumerator Start () {
		WWW itemsData = new WWW("http://192.168.1.5:1234/University_1_34/Students.php");          //("http://192.168.1.4:1234/Cool_YT_RPG/ItemsData.php");
			yield return itemsData;
		string itemsDataString = itemsData.text;
		print(itemsDataString);
		items = itemsDataString.Split (';');
		print (GetDataValue (items [0],"Name:"));
		Debug.Log(itemsDataString);

		abc.text = itemsDataString;
		abc1.text = itemsDataString;
		abc2.text = itemsDataString;
		abcS.text=GetDataValue(items[0],"Name:");



	}
	void Update ()
	{
		
		StartCoroutine(updatefunction());
	}

	IEnumerator updatefunction()
	{
		WWW itemsData = new WWW ("http://192.168.43.169:1234/University_1_34/Students.php");   //WWW("http://192.168.0.104:1234/Cool_YT_RPG/ItemsData.php");
		yield return  itemsData;

		string itemsDataString = itemsData.text;

		print(itemsDataString);
		items = itemsDataString.Split (';');
		print (GetDataValue (items [0],"Name:"));
		Debug.Log(itemsDataString);

		abc.text = itemsDataString;
		abc1.text = itemsDataString;
		abc2.text = itemsDataString;
		abcS.text=GetDataValue(items[0],"Name:");
		//Button.UI.text = itemsDataString
	}
	string GetDataValue(string data, string index){
		string value = data.Substring (data.IndexOf (index) + index.Length);
		return value;
	}
		



}
