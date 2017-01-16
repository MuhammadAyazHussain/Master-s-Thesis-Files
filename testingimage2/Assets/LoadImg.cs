using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadImg : MonoBehaviour {
	string url = "http://192.168.43.169:1234/graphs/pie3dex41.php";
	string url2 = "http://192.168.43.169:1234/Graphs/accbarex1.php";
	string url3 = "http://192.168.43.169:1234/Graphs/pie3dex1.php";
	Texture2D img;
	Texture2D img2;
	Texture2D img3;
	public RawImage r1;
	public RawImage r2;
	public RawImage r3;






	// Use this for initialization
	void Start () {
		StartCoroutine (LoadingImg());
	
	}
	// main function
	IEnumerator LoadingImg()
		{
		yield return 0;
		WWW imageLink = new WWW (url);
		yield return imageLink;
		img = imageLink.texture;
		r1.texture = img;

		WWW imageLink1 = new WWW (url2);
		yield return imageLink1;
		img2 = imageLink1.texture;
		r2.texture = img2;

		//yield return 0;
		WWW imageLink2 = new WWW (url3);
		yield return imageLink2;
		img3 = imageLink2.texture;
		r3.texture = img3;



		}

	//IEnumerator LoadingImg1()
	//{
		//yield return 0;
		//WWW imageLink = new WWW (url2);
		//yield return imageLink;
		//img2 = imageLink.texture;
		//r2.texture = img2;
	//}

	//IEnumerator LoadingImg3()
	//{
		//yield return 0;
		//WWW imageLink = new WWW (url3);
		//yield return imageLink;
		//img3 = imageLink.texture;
		//r3.texture = img3;
	//}


	
	// Update is called once per frame
	void OnGUI () {
		GUILayout.Label (img);
		//GUI.Label (new Rect(10,10,100,20),img2);
		//GUILayout.BeginArea (Rect (10, 10, 100, 20), img2);
	
	}

	void FixedUpdate(){
		StartCoroutine (LoadingImg ());
		//StartCoroutine (LoadingImg1 ());
		//StartCoroutine (LoadingImg3 ());
}

}
